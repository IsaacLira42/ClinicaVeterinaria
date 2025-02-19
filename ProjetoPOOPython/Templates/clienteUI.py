import streamlit as st

def app():
    st.header("Área do Cliente")
    usuario = st.session_state.get("current_user", {})
    st.write(f"Bem-vindo, {usuario.get('Nome', 'Cliente')}!")
    st.subheader("Seus Dados:")
    st.write(usuario)
    
    if st.button("Sair"):
        st.session_state['logged_in'] = False
        st.session_state['current_user'] = None
        st.rerun()