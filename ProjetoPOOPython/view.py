from Generics.persistenciaGenerica import PersistenciaGenerica
from Models.cliente import Cliente

class View:
    # PARTE GENERICA ###########################################
    @staticmethod
    def inserir_entidade(obj):
        persistencia = PersistenciaGenerica[type(obj)]()
        persistencia.inserir(obj)
    
    @staticmethod
    def remover_entidade(entidade_cls, id):
        persistencia = PersistenciaGenerica[entidade_cls]()
        persistencia.excluir(id)
    
    @staticmethod
    def listar_entidade(entidade_cls):
        persistencia = PersistenciaGenerica[entidade_cls]()
        return persistencia.listar()
    
    @staticmethod
    def listar_entidade_por_id(entidade_cls, id):
        persistencia = PersistenciaGenerica[entidade_cls]()
        return persistencia.listar_por_id(id)
    
    @staticmethod
    def atualizar_entidade(obj):
        persistencia = PersistenciaGenerica[type(obj)]()
        persistencia.atualizar(obj)
    ###########################################################

    def autenticar_cliente(email, senha):
        clientes = View.listar_entidade(Cliente)
        
        for cliente in clientes:
            if cliente.email == email and cliente.senha == senha:
                return cliente
        return None