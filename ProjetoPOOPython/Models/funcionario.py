from Models.usuario import Usuario


class Funcionario(Usuario):
    def __init__(self, Id, Email, Senha, NivelAcesso, Cargo, Salario):
        super().__init__(Id, Email, Senha, NivelAcesso)
        self.Cargo = Cargo
        self.Salario = Salario