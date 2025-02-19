
from Models.modeloId import ModeloId


class Pet(ModeloId):
    def __init__(self, id: int = 0, nome: str = "", especie: str = "", raca: str = ""):
        super().__init__(id)
        self.nome = nome
        self.especie = especie
        self.raca = raca

    def __str__(self):
        return f"ID: {self.id} | Nome: {self.nome} | Espécie: {self.especie} | Raça: {self.raca}"
