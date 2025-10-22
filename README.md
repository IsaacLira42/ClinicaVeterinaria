# Clínica Veterinária – Projeto com Streamlit

## Pré-requisitos

Antes de executar o projeto, certifique-se de que seu ambiente possui as seguintes ferramentas instaladas:

* [Python 3.x](https://www.python.org/downloads/) (recomendado: versão 3.7 ou superior)
* [Git](https://git-scm.com/) para clonar o repositório
* [pip](https://pip.pypa.io/en/stable/) para instalar as dependências do projeto

---

## Passo a passo para execução do projeto

### 1. Clonar o repositório

Abra o terminal ou prompt de comando e execute:

```bash
git clone https://github.com/IsaacLira42/ClinicaVeterinaria.git
```

### 2. Navegar até a pasta do projeto

```bash
cd ClinicaVeterinaria
```

### 3. Criar um ambiente virtual (opcional, mas recomendado)

Para garantir que as dependências do projeto fiquem isoladas, crie um ambiente virtual:

```bash
python -m venv venv
```

Ative o ambiente virtual:

* **Windows:**

  ```bash
  .\venv\Scripts\activate
  ```

* **Linux/Mac:**

  ```bash
  source venv/bin/activate
  ```

### 4. Instalar as dependências

Com o ambiente virtual ativado, instale as dependências do projeto utilizando o arquivo `requirements.txt`:

```bash
pip install -r requirements.txt
```

### 5. Executar a aplicação

Ainda no diretório do projeto, execute o Streamlit:

```bash
streamlit run ProjetoPOOPython/indexUI.py
```

### 6. Acessar a aplicação

Após a execução, abra seu navegador e acesse a URL http://localhost:8501.
