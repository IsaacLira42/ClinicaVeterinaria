from Models.usuario import Usuario

class Cliente(Usuario):
    def __init__(self, id=0, nome="", email="", senha="", nivel=0, telefone="", endereco=""):
        super().__init__(id, nome, email, senha, nivel)
        self.Telefone = telefone
        self.Endereco = endereco

    def to_dict(self):
        # Retorna um dicionário no formato desejado
        return {
            "Id": self.id,
            "Nome": self.Nome,
            "Email": self.Email,
            "Senha": self.Senha,
            "NivelAcesso": self.NivelAcesso,
            "Telefone": self.Telefone,
            "Endereco": self.Endereco
        }