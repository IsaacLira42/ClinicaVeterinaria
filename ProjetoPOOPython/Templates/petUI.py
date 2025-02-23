import streamlit as st
from Models import persistencia
from Models.pet import Pet

class PetUI:
    @staticmethod
    def ShowPetUI():
        st.header("Área do Pet")

        tab1, tab2 = st.tabs(["Cadastrar Pet", "Meus Pets"])

        with tab1: PetUI.CadastrarPet()
        with tab2: PetUI.ListarMeusPets()

    @staticmethod
    def CadastrarPet():
        usuario = st.session_state.get("current_user")

        with st.form("cadastro_pet_form"):
            nome = st.text_input("Nome do Pet")
            especie = st.selectbox("Espécie", ["Cachorro", "Gato", "Coelho", "Hamster", "Peixe", "Pássaro", "Cobras", "Reptel", "Furão", "Porquinho-da-índia", "Gerbilo", "Cavalo", "Outro"])
            raca = st.text_input("Raça")
            submit = st.form_submit_button("Cadastrar Pet")

        if submit:
            pets_existentes = persistencia.Pets.Listar()

            if any(p.Nome == nome and p.IdCliente == usuario.Id for p in pets_existentes):
                st.error("Este pet já está cadastrado na sua conta.")
            else:
                novo_pet = Pet(0, usuario.Id, nome, especie, raca)
                persistencia.Pets.Inserir(novo_pet)
                st.success(f"Pet {nome} cadastrado com sucesso!")

    @staticmethod
    def ListarMeusPets():
        usuario = st.session_state.get("current_user")

        pets = persistencia.Pets.Listar()

        meus_pets = [p for p in pets if p.IdCliente == usuario.Id]  # Pets do usuario

        if not meus_pets:
            st.info("Você ainda não cadastrou nenhum pet.")
            return
        
        filtro_nome = st.text_input("🔍 Filtrar por nome:", "")
        filtro_especie = st.selectbox("📌 Filtrar por espécie:", ["Todos"] + list(set(p.Especie for p in meus_pets)))

        if filtro_nome:
            meus_pets = [p for p in meus_pets if filtro_nome.lower() in p.Nome.lower()]
        if filtro_especie != "Todos":
            meus_pets = [p for p in meus_pets if p.Especie == filtro_especie]

        if not meus_pets:
            st.warning("Nenhum pet encontrado com esses filtros.")
            return
        

        for pet in meus_pets:
            with st.expander(f"{pet.Nome}"):
                st.write(f"**Espécie:** {pet.Especie}")
                st.write(f"**Raça:** {pet.Raca}")
                
                if st.button(f"❌ Apagar {pet.Nome}", key=f"del_{pet.Id}"):
                    persistencia.Pets.Excluir(pet.Id)
                    st.success(f"Pet {pet.Nome} removido com sucesso!")
                    st.rerun()
