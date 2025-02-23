import streamlit as st
from Models import persistencia
from Models.pet import Pet

def app():
    st.header("Área do Cliente")
    usuario = st.session_state.get("current_user")  # Não use {} como default
    if usuario:
        st.write(f"Bem-vindo, {usuario.Nome}!")

    st.write("Bem-vindo, Cliente!")
    st.subheader("Seus Dados:")
    st.write(usuario)
    
    ##### Temporário - Testes #####
    
    # persistencia.Pets.Inserir(Pet(0, ))


    ###############################


    if st.button("Sair"):
        st.session_state['logged_in'] = False
        st.session_state['current_user'] = None
        st.rerun()