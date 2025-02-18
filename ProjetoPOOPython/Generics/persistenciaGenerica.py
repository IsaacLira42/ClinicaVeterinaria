import json
import os
from typing import TypeVar, Generic, List, Optional
from pathlib import Path

T = TypeVar('T', bound='ModeloId')

class ModeloId:
    def __init__(self, id: Optional[int] = None):
        self.id = id

    def to_dict(self):
        return self.__dict__

    @classmethod
    def from_dict(cls, data):
        return cls(**data)

class PersistenciaGenerica(Generic[T]):
    def __init__(self, base_path: str = "/workspaces/ClinicaVeterinaria/Database"):
        self.base_path = Path(base_path)
        self.base_path.mkdir(parents=True, exist_ok=True)
        self.caminho = self.base_path / f"{self.__orig_bases__[0].__args__[0].__name__}.json"
        self.objetos: List[T] = []
        self.abrir()

    def inserir(self, obj: T):
        self.abrir()
        obj.id = max((o.id for o in self.objetos), default=0) + 1
        self.objetos.append(obj)
        self.salvar()

    def listar(self) -> List[T]:
        self.abrir()
        return self.objetos.copy()

    def listar_por_id(self, id: int) -> Optional[T]:
        self.abrir()
        return next((obj for obj in self.objetos if obj.id == id), None)

    def atualizar(self, obj: T):
        self.abrir()
        for i, item in enumerate(self.objetos):
            if item.id == obj.id:
                self.objetos[i] = obj
                self.salvar()
                return

    def excluir(self, id: int):
        self.abrir()
        self.objetos = [obj for obj in self.objetos if obj.id != id]
        self.salvar()

    def abrir(self):
        if not self.caminho.exists():
            self.caminho.write_text("[]")

        try:
            with open(self.caminho, "r", encoding="utf-8") as file:
                data = json.load(file)
                self.objetos = [self.__orig_bases__[0].__args__[0].from_dict(d) for d in data]
        except (json.JSONDecodeError, FileNotFoundError):
            self.objetos = []

    def salvar(self):
        with open(self.caminho, "w", encoding="utf-8") as file:
            json.dump([obj.to_dict() for obj in self.objetos], file, indent=4)