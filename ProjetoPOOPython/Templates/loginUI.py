import streamlit as st
from Generics.GenericPersistence import GenericPersistence

CLIENT_DB_PATH = "/workspaces/ClinicaVeterinaria/Database/Cliente.json"

def app():
    st.header("Login")
    with st.form("login_form"):
        email = st.text_input("Email")
        senha = st.text_input("Senha", type="password")
        submit = st.form_submit_button("Entrar")
    
    if submit:
        persistence = GenericPersistence(CLIENT_DB_PATH)
        clientes = persistence.listar()
        usuario_encontrado = None
        for cliente in clientes:
            if cliente.get("email") == email and cliente.get("senha") == senha:
                usuario_encontrado = cliente
                break
        
        if usuario_encontrado:
            st.session_state['logged_in'] = True
            st.session_state['current_user'] = usuario_encontrado
            st.success("Login realizado com sucesso!")
            st.rerun()
        else:
            st.error("Email ou senha incorretos.")
