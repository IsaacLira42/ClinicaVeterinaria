import os
import json
from typing import List, TypeVar, Generic, Optional, Type

# Definição do tipo genérico
T = TypeVar("T")

class RepositorioJSON(Generic[T]):
    Objetos: List[T] = []
    CaminhoBase = "/workspaces/ClinicaVeterinaria/Database/"

    @classmethod
    def _CaminhoArquivo(cls) -> str:
        """Define o caminho do arquivo JSON baseado no nome da classe."""
        return os.path.join(cls.CaminhoBase, f"{cls.__name__}.json")

    @classmethod
    def Inserir(cls, obj: T) -> None:
        """Insere um novo objeto na lista e salva no arquivo JSON."""
        cls.Abrir()

        IdMax = max((getattr(o, "Id", 0) for o in cls.Objetos), default=0)
        setattr(obj, "Id", IdMax + 1)

        cls.Objetos.append(obj)
        cls.Salvar()

    @classmethod
    def Listar(cls) -> List[T]:
        """Retorna a lista completa de objetos."""
        cls.Abrir()
        return cls.Objetos

    @classmethod
    def ListarId(cls, Id: int) -> Optional[T]:
        """Retorna um objeto pelo ID."""
        cls.Abrir()
        return next((obj for obj in cls.Objetos if getattr(obj, "Id", None) == Id), None)

    @classmethod
    def Atualizar(cls, obj: T) -> None:
        """Atualiza um objeto existente."""
        cls.Abrir()
        for i, existente in enumerate(cls.Objetos):
            if getattr(existente, "Id", None) == getattr(obj, "Id", None):
                cls.Objetos[i] = obj
                cls.Salvar()
                return

    @classmethod
    def Excluir(cls, Id: int) -> None:
        """Exclui um objeto pelo ID."""
        cls.Abrir()
        cls.Objetos = [obj for obj in cls.Objetos if getattr(obj, "Id", None) != Id]
        cls.Salvar()

    @classmethod
    def Abrir(cls) -> None:
        """Carrega os dados do arquivo JSON."""
        Caminho = cls._CaminhoArquivo()
        os.makedirs(cls.CaminhoBase, exist_ok=True)

        if not os.path.exists(Caminho):
            with open(Caminho, "w") as arquivo:
                json.dump([], arquivo)

        with open(Caminho, "r") as arquivo:
            cls.Objetos = [cls._FromDict(obj) for obj in json.load(arquivo)]

    @classmethod
    def Salvar(cls) -> None:
        """Salva os objetos no arquivo JSON."""
        Caminho = cls._CaminhoArquivo()
        with open(Caminho, "w") as arquivo:
            json.dump([cls._ToDict(obj) for obj in cls.Objetos], arquivo, indent=4)

    @staticmethod
    def _ToDict(obj: T) -> dict:
        """Converte um objeto em dicionário para salvar em JSON."""
        return obj.__dict__

    @classmethod
    def _FromDict(cls, data: dict) -> T:
        """Cria um objeto a partir de um dicionário."""
        return cls.ObjetoTipo()(**data)  # Deve ser sobrescrito nas classes filhas

    @classmethod
    def ObjetoTipo(cls) -> Type[T]:
        """Retorna o tipo do objeto, deve ser sobrescrito nas subclasses."""
        raise NotImplementedError("Deve ser implementado na classe filha.")
