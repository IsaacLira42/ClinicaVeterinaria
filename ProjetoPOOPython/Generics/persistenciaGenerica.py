import json
import os
from typing import Type, TypeVar, Generic, List, Optional
from pathlib import Path

T = TypeVar('T', bound='ModeloId')

class ModeloId:
    def __init__(self, Id: Optional[int] = None):  # Alterado para "Id" com maiúscula
        self.Id = Id  # Alterado para "Id"

    def to_dict(self):
        return self.__dict__

    @classmethod
    def from_dict(cls, data):
        return cls(**data)

class PersistenciaGenerica(Generic[T]):
    def __init__(self, entidade_cls: Type[T], base_path: str = "/workspaces/ClinicaVeterinaria/Database"):
        self.entidade_cls = entidade_cls
        self.base_path = Path(base_path)
        self.base_path.mkdir(parents=True, exist_ok=True)

        # Define o nome do arquivo JSON com base no nome da classe
        self.caminho = self.base_path / f"{self.entidade_cls.__name__}.json"
        self.objetos: List[T] = []
        self.abrir()

    def inserir(self, obj: T):
        self.abrir()
        obj.Id = max((o.Id for o in self.objetos), default=0) + 1  # Alterado "id" para "Id"
        self.objetos.append(obj)
        self.salvar()

    def listar(self) -> List[T]:
        self.abrir()
        return self.objetos.copy()

    def listar_por_id(self, Id: int) -> Optional[T]:  # Alterado "id" para "Id"
        self.abrir()
        return next((obj for obj in self.objetos if obj.Id == Id), None)  # Alterado "id" para "Id"

    def atualizar(self, obj: T):
        self.abrir()
        for i, item in enumerate(self.objetos):
            if item.Id == obj.Id:  # Alterado "id" para "Id"
                self.objetos[i] = obj
                self.salvar()
                return

    def excluir(self, Id: int):  # Alterado "id" para "Id"
        self.abrir()
        self.objetos = [obj for obj in self.objetos if obj.Id != Id]  # Alterado "id" para "Id"
        self.salvar()

    def abrir(self):
        """Carrega os objetos do arquivo JSON"""
        if not self.caminho.exists():
            self.caminho.write_text("[]")

        try:
            with open(self.caminho, "r", encoding="utf-8") as file:
                data = json.load(file)
                self.objetos = [self.entidade_cls.from_dict(d) for d in data]
        except (json.JSONDecodeError, FileNotFoundError):
            self.objetos = []

    def salvar(self):
        """Salva os objetos no arquivo JSON"""
        with open(self.caminho, "w", encoding="utf-8") as file:
            json.dump([obj.to_dict() for obj in self.objetos], file, indent=4)
