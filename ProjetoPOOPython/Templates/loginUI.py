import streamlit as st
from Models import persistencia


def app():
    st.header("Login")
    with st.form("login_form"):
        email = st.text_input("Email")
        senha = st.text_input("Senha", type="password")
        submit = st.form_submit_button("Entrar")
    
    if submit:
        clientes = persistencia.Clientes.Listar()
        usuario_encontrado = None
        for cliente in clientes:
            if cliente.get("Email") == email and cliente.get("Senha") == senha:
                usuario_encontrado = cliente
                break
        
        if usuario_encontrado:
            st.session_state['logged_in'] = True
            st.session_state['current_user'] = usuario_encontrado
            st.success("Login realizado com sucesso!")
            st.rerun()
        else:
            st.error("Email ou senha incorretos.")