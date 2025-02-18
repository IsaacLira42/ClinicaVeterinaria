from modeloId import ModeloId
from datetime import datetime

class Pagamento(ModeloId):
    def __init__(self, id: int = 0, valor: float = 0.0, data_pagamento: datetime = None, id_funcionario: int = 0, id_cliente: int = 0):
        super().__init__(id)
        self.valor = valor
        self.data_pagamento = data_pagamento if data_pagamento else datetime.now()
        self.id_funcionario = id_funcionario
        self.id_cliente = id_cliente

    def __str__(self):
        return f"ID: {self.id} | Valor: R$ {self.valor:.2f} | Data: {self.data_pagamento.strftime('%d/%m/%Y %H:%M')} | Funcionário: {self.id_funcionario} | Cliente: {self.id_cliente}"
