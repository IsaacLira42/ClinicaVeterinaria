

from Models.usuario import Usuario


class Cliente(Usuario):
    def __init__(self, id=0, nome="", email="", senha="", nivel=0, telefone="", endereco=""):
        super().__init__(id, nome, email, senha, nivel)
        self.telefone = telefone
        self.endereco = endereco