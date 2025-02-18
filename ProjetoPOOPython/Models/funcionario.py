from usuario import Usuario

class Funcionario(Usuario):
    def __init__(self, id: int = 0, nome: str = "", email: str = "", senha: str = "", nivel: int = 0, cargo: str = "", salario: float = 0.0):
        super().__init__(id, nome, email, senha, nivel)
        self.cargo = cargo
        self.salario = salario

    def __str__(self):
        return f"ID: {self.id} | Nome: {self.nome} | Email: {self.email} | Cargo: {self.cargo} | Salário: R$ {self.salario:.2f}"
