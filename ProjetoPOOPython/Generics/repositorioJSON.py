import os
import json
from typing import List, TypeVar, Generic, Optional, Type
from datetime import datetime

T = TypeVar("T")

class RepositorioJSON(Generic[T]):
    Objetos: List[T] = []
    CaminhoBase = "/workspaces/ClinicaVeterinaria/Database"
    NomeArquivo: str = None

    @classmethod
    def _CaminhoArquivo(cls) -> str:
        """Define o caminho do arquivo JSON."""
        nome = cls.NomeArquivo if cls.NomeArquivo else cls.__name__
        return os.path.join(cls.CaminhoBase, f"{nome}.json")

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
        # Converte qualquer campo datetime em string
        data_dict = obj.__dict__.copy()
        for key, value in data_dict.items():
            if isinstance(value, datetime):
                data_dict[key] = value.strftime('%d/%m/%Y %H:%M')  # Converte para string
        return data_dict

    @classmethod
    def _FromDict(cls, data: dict) -> T:
        """Cria um objeto a partir de um dicionário."""
        # Converte qualquer campo de string de volta para datetime
        for key, value in data.items():
            if isinstance(value, str):
                try:
                    # Tenta converter de volta para datetime
                    data[key] = datetime.strptime(value, '%d/%m/%Y %H:%M')
                except ValueError:
                    pass  # Se não for uma data válida, continua como string
        return cls.ObjetoTipo()(**data)  # Deve ser sobrescrito nas classes filhas

    @classmethod
    def ObjetoTipo(cls) -> Type[T]:
        """Retorna o tipo do objeto, deve ser sobrescrito nas subclasses."""
        raise NotImplementedError("Deve ser implementado na classe filha.")
