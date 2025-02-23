from Generics.repositorioJSON import RepositorioJSON
from Models.cliente import Cliente
from Models.pet import Pet
from Models.funcionario import Funcionario
from Models.agendamento import Agendamento
from Models.servico import Servico
from Models.pagamento import Pagamento


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
    

class Funcionarios(RepositorioJSON[Funcionario]):
    NomeArquivo = "Funcionario" 
    @classmethod
    def ObjetoTipo(cls):
        return Funcionario


class Agendamentos(RepositorioJSON[Agendamento]):
    NomeArquivo = "Agendamento"
    @classmethod
    def ObjetoTipo(cls):
        return Agendamento


class Servicos(RepositorioJSON[Servico]):
    NomeArquivo = "Servico"
    @classmethod
    def ObjetoTipo(cls):
        return Servico
    

class Pagamentos(RepositorioJSON[Pagamento]):
    NomeArquivo = "Pagamento"
    @classmethod
    def ObjetoTipo(cls):
        return Pagamento