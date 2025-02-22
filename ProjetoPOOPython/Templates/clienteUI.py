import streamlit as st

def app():
    st.header("Área do Cliente")
    usuario = st.session_state.get("current_user")  # Não use {} como default
    if usuario:
        st.write(f"Bem-vindo, {usuario.Nome}!")

    st.write("Bem-vindo, Cliente!")
    st.subheader("Seus Dados:")
    st.write(usuario)
    
    # Temporário



    if st.button("Sair"):
        st.session_state['logged_in'] = False
        st.session_state['current_user'] = None
        st.rerun()