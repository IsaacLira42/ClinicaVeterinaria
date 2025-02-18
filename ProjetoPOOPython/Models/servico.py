from modeloId import ModeloId

class Servico(ModeloId):
    def __init__(self, id: int = 0, nome: str = "", descricao: str = "", preco: float = 0.0):
        super().__init__(id)
        self.nome = nome
        self.descricao = descricao
        self.preco = preco

    def __str__(self):
        return f"ID: {self.id} | Nome: {self.nome} | Descrição: {self.descricao} | Preço: R$ {self.preco:.2f}"
