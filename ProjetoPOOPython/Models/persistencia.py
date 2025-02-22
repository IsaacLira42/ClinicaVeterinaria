from Models.cliente import Cliente
from Generics.repositorioJSON import RepositorioJSON

class Clientes(RepositorioJSON[Cliente]):
    NomeArquivo = "Cliente"
    
    @classmethod
    def ObjetoTipo(cls):
        return Cliente