import streamlit as st
from Generics.persistenciaGenerica import PersistenciaGenerica
from Models.cliente import Cliente

def AbrirConta():
    st.title("Cadastro de Cliente")

    nome = st.text_input("Nome")
    email = st.text_input("Email")
    senha = st.text_input("Senha", type="password")
    telefone = st.text_input("Telefone")
    endereco = st.text_area("Endereço")

    if st.button("Cadastrar"):
        persistencia = PersistenciaGenerica[Cliente]()
        novo_cliente = Cliente(nome=nome, email=email, senha=senha, telefone=telefone, endereco=endereco)
        persistencia.inserir(novo_cliente)
        st.success("Cadastro realizado com sucesso! Faça login para continuar.")
        st.session_state.pagina = "login"
        st.experimental_rerun()
