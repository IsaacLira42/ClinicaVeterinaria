import streamlit as st

def area_cliente():
    st.title("Área do Cliente")
    st.write(f"Bem-vindo, {st.session_state.cliente.nome}!")
    
    if st.button("Sair"):
        st.session_state.cliente = None
        st.session_state.pagina = "login"
        st.experimental_rerun()
