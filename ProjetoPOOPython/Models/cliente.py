from Models.usuario import Usuario

class Cliente(Usuario):
    def __init__(self, id, nome, email, senha, nivel, telefone, endereco):
        super().__init__(id, nome, email, senha, nivel)  # Passando id para a classe pai (Usuario)
        self.Telefone = telefone
        self.Endereco = endereco

    @classmethod
    def from_dict(cls, data):
        return cls(
            id=data.get("Id", 0),  # Usando "Id" no JSON, mas mapeando para o atributo id
            nome=data.get("Nome", ""),
            email=data.get("Email", ""),
            senha=data.get("Senha", ""),
            nivel=data.get("NivelAcesso", 0),
            telefone=data.get("Telefone", ""),
            endereco=data.get("Endereco", "")
        )

    def to_dict(self):
        return {
            "Id": self.id,               # Acessando corretamente self.id
            "Nome": self.Nome,
            "Email": self.Email,
            "Senha": self.Senha,
            "NivelAcesso": self.Nivel,    # Usando "NivelAcesso" conforme o formato esperado
            "Telefone": self.Telefone,
            "Endereco": self.Endereco
        }
