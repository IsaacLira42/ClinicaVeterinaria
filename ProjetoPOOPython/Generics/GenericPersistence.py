import os
import json

class GenericPersistence:
    def __init__(self, arquivo):
        if not arquivo:
            raise ValueError("O caminho do arquivo não pode estar vazio!")
        self.arquivo = arquivo
        self.objetos = []

    def abrir(self):
        if not os.path.exists(self.arquivo):
            os.makedirs(os.path.dirname(self.arquivo), exist_ok=True)
            with open(self.arquivo, 'w') as f:
                json.dump([], f)
        
        with open(self.arquivo, 'r') as f:
            self.objetos = json.load(f)
        
        # Normalizar chave 'Id' para 'id' (se existir)
        for obj in self.objetos:
            if 'Id' in obj:
                obj['id'] = obj.pop('Id')

    def salvar(self):
        with open(self.arquivo, 'w') as f:
            json.dump(self.objetos, f, indent=4)

    def inserir(self, obj):
        self.abrir()
        # Atribui um novo id incrementado
        obj.id = max([o.get('id', 0) for o in self.objetos], default=0) + 1
        # Usa o método to_dict do objeto para obter o dicionário no formato correto
        self.objetos.append(obj.to_dict())
        self.salvar()

    def listar(self):
        self.abrir()
        return [obj for obj in self.objetos]

    def listar_por_id(self, id):
        self.abrir()
        return next((obj for obj in self.objetos if obj['id'] == id), None)

    def atualizar(self, obj):
        self.abrir()
        for i, o in enumerate(self.objetos):
            if o['id'] == obj.id:
                self.objetos[i] = obj.to_dict()  # Usa to_dict() em vez de __dict__
                self.salvar()
                break

    def excluir(self, id):
        self.abrir()
        self.objetos = [o for o in self.objetos if o['id'] != id]
        self.salvar()