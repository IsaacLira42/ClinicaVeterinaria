from Models.usuario import Usuario

class Cliente(Usuario):
    def __init__(self, Id, Nome, Email, Senha, NivelAcesso, Telefone, Endereco):
        super().__init__(Id, Nome, Email, Senha, NivelAcesso)
        self.Telefone = Telefone
        self.Endereco = Endereco