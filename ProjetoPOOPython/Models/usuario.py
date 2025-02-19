from Models.modeloId import ModeloId

class Usuario(ModeloId):
    def __init__(self, id: int = 0, nome: str = "", email: str = "", senha: str = "", nivel: int = 0):
        super().__init__(id)  # Passando id para o ModeloId
        self.Nome = nome
        self.Email = email
        self.Senha = senha
        self.Nivel = nivel

    @classmethod
    def from_dict(cls, data):
        return cls(
            id=data.get("Id", 0),  # Usando "Id" conforme esperado no JSON
            nome=data.get("Nome", ""),
            email=data.get("Email", ""),
            senha=data.get("Senha", ""),
            nivel=data.get("NivelAcesso", 0)
        )
