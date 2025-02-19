from Models.modelo_id import ModeloId


class Usuario(ModeloId):
    def __init__(self, id=0, nome="", email="", senha="", nivel=0):
        super().__init__(id)
        self.nome = nome
        self.email = email
        self.senha = senha
        self.nivel_acesso = nivel