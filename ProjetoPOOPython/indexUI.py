import streamlit as st
from Templates import abrircontaUI, clienteUI, loginUI

# Inicializar sessão
if "cliente" not in st.session_state:
    st.session_state.cliente = None

if "pagina" not in st.session_state:
    st.session_state.pagina = "login"

# Gerenciar navegação entre páginas
if st.session_state.cliente:
    clienteUI.area_cliente()
elif st.session_state.pagina == "cadastro":
    abrircontaUI.AbrirConta()
else:
    loginUI.login()
