import streamlit as st
from Models import persistencia
from Models.pet import Pet
from Templates import petUI, agendamentoUI

def app():
    pagina = st.sidebar.radio("Escolha uma opção:", ["Pet", "Agendamento"])
    if pagina == "Pet":
        petUI.PetUI.ShowPetUI()
    elif pagina == "Agendamento":
        agendamentoUI.AgendamentoUI.ShowAgendamentoUI()


    if st.sidebar.button("Sair"):
        st.session_state['logged_in'] = False
        st.session_state['current_user'] = None
        st.rerun()