import streamlit as st
from Models.cliente import Cliente
from Models import persistencia


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
        novo_cliente = Cliente(0, nome, email, senha, 1, telefone, endereco)
        clientes_existentes = persistencia.Clientes.Listar()
        if any(c.Email == email for c in clientes_existentes):
            st.error("Já existe uma conta com este email.")
        else:
            persistencia.Clientes.Inserir(novo_cliente)
            st.success("Conta criada com sucesso! Faça login para acessar sua conta.")