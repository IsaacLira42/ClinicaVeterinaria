from usuario import Usuario

class Admin(Usuario):
    def __init__(self, id: int = 0, nome: str = "", email: str = "", senha: str = "", nivel: int = 0):
        super().__init__(id, nome, email, senha, nivel)

    def __str__(self):
        return super().__str__()
