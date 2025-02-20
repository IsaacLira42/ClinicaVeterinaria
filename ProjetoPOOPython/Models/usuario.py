from Models.modelo_id import ModeloId

class Usuario(ModeloId):
    def __init__(self, id=0, nome="", email="", senha="", nivel=0):
        super().__init__(id)
        self.Nome = nome
        self.Email = email
        self.Senha = senha
        self.NivelAcesso = nivel

    def to_dict(self):
        return {
            "Id": self.id,
            "Nome": self.Nome,
            "Email": self.Email,
            "Senha": self.Senha,
            "NivelAcesso": self.NivelAcesso
        }