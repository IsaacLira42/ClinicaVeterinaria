# Clínica Veterinária - Projeto

## Pré-requisitos

Antes de executar o projeto, você precisa garantir que possui as seguintes ferramentas instaladas no seu sistema:

- [Python 3.x](https://www.python.org/downloads/) (Recomendado: versão 3.7 ou superior)
- [Git](https://git-scm.com/) para clonar o repositório
- [pip](https://pip.pypa.io/en/stable/) para instalar as dependências do projeto

## Passo a Passo para Executar o Projeto

1. **Clone o Repositório**

   Comece clonando o repositório para o seu ambiente local. Abra o terminal ou prompt de comando e execute o seguinte comando:

   ```bash
   git clone https://github.com/IsaacLira42/ClinicaVeterinaria.git
   ```
2.  **Navegue até a Pasta do Projeto**
    
    Após clonar o repositório, navegue até a pasta do projeto:
    
    ```bash
    cd ClinicaVeterinaria
    ```
    
3.  **Crie um Ambiente Virtual (Opcional, mas recomendado)**
    
    Para isolar as dependências do projeto, é recomendado criar um ambiente virtual. No terminal, execute:
    
    ```bash
    python -m venv venv
    ```
    
    Após criar o ambiente virtual, ative-o:
    
    -   **Windows**:
        
        ```bash
        .\venv\Scripts\activate
        ```
        
    -   **Linux/Mac**:
        
        ```bash
        source venv/bin/activate
        ```
        
4.  **Instale as Dependências**
    
    No diretório do projeto, instale as dependências necessárias usando o arquivo `requirements.txt`. Execute o seguinte comando no terminal:
    
    ```bash
    pip install -r requirements.txt
    ```
    
    Isso irá instalar todas as bibliotecas necessárias para o funcionamento do projeto.
    
5.  **Execute o Projeto**
    
    Após instalar as dependências, você pode executar o projeto:
    
    ```bash
    streamlit run ProjetoPOOPython/indexUI.py
    ```
    
6.  **Acesse a Aplicação**
    
    Após executar o projeto, abra o navegador e acesse a URL onde a aplicação está sendo executada, normalmente algo como `http://127.0.0.1:5000/` ou `http://localhost:5000/`, dependendo da configuração do seu servidor.
    