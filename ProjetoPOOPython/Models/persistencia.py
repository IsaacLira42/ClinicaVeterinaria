from Models.cliente import Cliente
from repositorioJSON import RepositorioJSON


class Clientes(RepositorioJSON[Cliente]):
    @classmethod
    def ObjetoTipo(cls):
        return Cliente