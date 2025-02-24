import streamlit as st
from Models import persistencia
from Models.agendamento import Agendamento
from Models.pet import Pet
from Models.servico import Servico
from Models.funcionario import Funcionario
from datetime import datetime

class AgendamentoUI:
    @staticmethod
    def ShowAgendamentoUI():
        st.header("Área de Agendamento")

        tab1, tab2 = st.tabs(["Cadastrar Agendamento", "Meus Agendamentos"])

        with tab1: AgendamentoUI.CadastrarAgendamento()
        with tab2: AgendamentoUI.ListarAgendamentos()

    @staticmethod
    def CadastrarAgendamento():
        usuario = st.session_state.get("current_user")

        # Selecionar o pet
        pets = persistencia.Pets.Listar()
        pets_cliente = [p for p in pets if p.IdCliente == usuario.Id]

        if not pets_cliente:
            st.warning("Você não tem nenhum pet cadastrado.")
            return

        pet_nome = st.selectbox("Escolha o Pet", [p.Nome for p in pets_cliente])

        # Selecionar o serviço
        servicos = persistencia.Servicos.Listar()
        servico_nome = st.selectbox("Escolha o Serviço", [s.Nome for s in servicos])

        # Selecionar o funcionário
        funcionarios = persistencia.Funcionarios.Listar()
        funcionario_nome = st.selectbox("Escolha o Funcionário", [f.Nome for f in funcionarios])

        # Selecionar a data do agendamento
        data_agendamento = st.date_input("Escolha a Data do Agendamento", min_value=datetime.now())
        
        # Selecionar a hora do agendamento
        hora_agendamento = st.time_input("Escolha a Hora do Agendamento")

        # Confirmar agendamento
        submit = st.button("Confirmar Agendamento")
        
        if submit:
            pet = next(p for p in pets_cliente if p.Nome == pet_nome)
            servico = next(s for s in servicos if s.Nome == servico_nome)
            funcionario = next(f for f in funcionarios if f.Nome == funcionario_nome)

            # Junta a data e hora
            data_hora_agendamento = datetime.combine(data_agendamento, hora_agendamento)

            # Verificar se o horário já está ocupado para o mesmo funcionário
            agendamentos_existentes = persistencia.Agendamentos.Listar()
            for agendamento in agendamentos_existentes:
                if (agendamento.IdFuncionario == funcionario.Id and
                    agendamento.Data == data_hora_agendamento):
                    st.error("Este horário já está ocupado. Escolha outro horário.")
                    return  


            # Criar e salvar o agendamento com a data
            novo_agendamento = Agendamento(0, data_hora_agendamento, usuario.Id, pet.Id, servico.Id, funcionario.Id)
            persistencia.Agendamentos.Inserir(novo_agendamento)
            st.success(f"Agendamento para o pet {pet_nome} realizado com sucesso!")

    @staticmethod
    def ListarAgendamentos():
        usuario = st.session_state.get("current_user")

        agendamentos = persistencia.Agendamentos.Listar()

        meus_agendamentos = [a for a in agendamentos if a.IdCliente == usuario.Id]

        if not meus_agendamentos:
            st.info("Você ainda não tem agendamentos.")
            return

        # Exibir agendamentos
        for agendamento in meus_agendamentos:
            pet = persistencia.Pets.ListarId(agendamento.IdPet)
            servico = persistencia.Servicos.ListarId(agendamento.IdServico)
            funcionario = persistencia.Funcionarios.ListarId(agendamento.IdFuncionario)
            data_formatada = agendamento.Data.strftime('%d/%m/%Y %H:%M')

            with st.expander(f"📅 Agendamento para {pet.Nome} - Serviço: {servico.Nome}"):
                st.write(f"**Pet:** {pet.Nome}")
                st.write(f"**Serviço:** {servico.Nome}")
                st.write(f"**Funcionário:** {funcionario.Nome}")
                st.write(f"**Data do Agendamento:** {data_formatada}")

                if st.button(f"❌ Apagar Agendamento de {pet.Nome}", key=f"del_{agendamento.Id}"):
                    persistencia.Agendamentos.Excluir(agendamento.Id)
                    st.success("Agendamento removido com sucesso!")
                    st.rerun()