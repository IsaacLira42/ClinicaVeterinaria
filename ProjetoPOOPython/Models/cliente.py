from usuario import Usuario

class Cliente(Usuario):
    def __init__(self, id: int = 0, nome: str = "", email: str = "", senha: str = "", nivel: int = 0, telefone: str = "", endereco: str = ""):
        super().__init__(id, nome, email, senha, nivel)
        self.telefone = telefone
        self.endereco = endereco

    def __str__(self):
        return f"ID: {self.id} | Nome: {self.nome} | Email: {self.email} | Telefone: {self.telefone} | Endereço: {self.endereco}"
