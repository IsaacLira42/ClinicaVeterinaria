from Models.usuario import Usuario


class Funcionario(Usuario):
    def __init__(self, Id, Nome, Email, Senha, NivelAcesso, Cargo, Salario):
        super().__init__(Id, Nome, Email, Senha, NivelAcesso)
        self.Cargo = Cargo
        self.Salario = Salario