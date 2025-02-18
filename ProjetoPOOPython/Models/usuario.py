from modeloId import ModeloId

class Usuario(ModeloId):
    def __init__(self, id: int = 0, nome: str = "", email: str = "", senha: str = "", nivel: int = 0):
        super().__init__(id)
        self.nome = nome
        self.email = email
        self.senha = senha
        self.nivel_acesso = nivel

    def __str__(self):
        return f"Id: {self.id} | Nome: {self.nome} | Email: {self.email}"
