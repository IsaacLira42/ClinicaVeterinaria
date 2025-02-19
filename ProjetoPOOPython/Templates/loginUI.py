import streamlit as st
from view import View

def login():
    st.title("Login do Cliente")
    
    email = st.text_input("Email")
    senha = st.text_input("Senha", type="password")

    if st.button("Entrar"):
        cliente = View.autenticar_cliente(email, senha)
        if cliente:
            st.session_state.cliente = cliente
            st.success(f"Bem-vindo, {cliente.nome}!")
            st.session_state.pagina = "area_cliente"
            st.rerun()
        else:
            st.warning("Conta não encontrada! Cadastre-se para acessar.")
            st.session_state.pagina = "cadastro"
            st.rerun()
