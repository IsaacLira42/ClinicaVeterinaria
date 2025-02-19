import datetime
from Models.modeloId import ModeloId

class Agendamento(ModeloId):
    def __init__(self, id: int = 0, data: datetime = None, id_cliente: int = 0, id_pet: int = 0, id_servico: int = 0, id_funcionario: int = 0):
        super().__init__(id)
        self.data = data if data else datetime.now()
        self.id_cliente = id_cliente
        self.id_pet = id_pet
        self.id_servico = id_servico
        self.id_funcionario = id_funcionario

    def __str__(self):
        return f"ID: {self.id} | Data: {self.data.strftime('%d/%m/%Y %H:%M')} | Cliente: {self.id_cliente} | Pet: {self.id_pet} | Serviço: {self.id_servico} | Funcionário: {self.id_funcionario}"
