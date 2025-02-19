import streamlit as st
from Generics.GenericPersistence import GenericPersistence
from Models.cliente import Cliente

CLIENT_DB_PATH = "/workspaces/ClinicaVeterinaria/Database/Cliente.json"

def app():
    st.header("Criar Conta")
    with st.form("abrir_conta_form"):
        nome = st.text_input("Nome")
        email = st.text_input("Email")
        senha = st.text_input("Senha", type="password")
        telefone = st.text_input("Telefone")
        endereco = st.text_input("Endereço")
        submit = st.form_submit_button("Criar Conta")
    
    if submit:
        novo_cliente = Cliente(nome=nome, email=email, senha=senha, telefone=telefone, endereco=endereco)
        persistence = GenericPersistence(CLIENT_DB_PATH)
        clientes_existentes = persistence.listar()
        if any(c.get("Email") == email for c in clientes_existentes):
            st.error("Já existe uma conta com este email.")
        else:
            persistence.inserir(novo_cliente)
            st.success("Conta criada com sucesso! Faça login para acessar sua conta.")