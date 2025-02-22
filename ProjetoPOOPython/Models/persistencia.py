from Generics.repositorioJSON import RepositorioJSON
from Models.cliente import Cliente
from Models.pet import Pet


class Clientes(RepositorioJSON[Cliente]):
    NomeArquivo = "Cliente" 
    @classmethod
    def ObjetoTipo(cls):
        return Cliente


class Pets(RepositorioJSON[Pet]):
    NomeArquivo = "Pet"
    @classmethod
    def ObjetoTipo(cls):
        return Pet