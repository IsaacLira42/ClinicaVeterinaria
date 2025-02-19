import streamlit as st
from Templates import loginUI, abrircontaUI, clienteUI

# Inicializa o controle de sessão
if 'logged_in' not in st.session_state:
    st.session_state['logged_in'] = False
    st.session_state['current_user'] = None

st.title("Clínica Veterinária")

if st.session_state['logged_in']:
    clienteUI.app()
else:
    pagina = st.sidebar.radio("Navegação", ("Login", "Criar Conta"))
    if pagina == "Login":
        loginUI.app()
    elif pagina == "Criar Conta":
        abrircontaUI.app()