# Documento de Visão  
## Sistema de Agendamento de Serviços para Clínica Veterinária  

## Histórico da Revisão  
| Data       | Versão | Descrição                  | Autor       |  
|------------|--------|----------------------------|-------------|  
| 27/01/2025 | 1.0    | Versão inicial do documento | Isaac Lira  |  

## 1. Objetivo do Projeto  
O projeto **Sistema de Agendamento de Serviços para Clínica Veterinária** tem como objetivo principal otimizar o processo de marcação de serviços, como banho, tosa e consultas veterinárias, além de melhorar a experiência dos clientes e a gestão dos funcionários. Ele busca resolver problemas relacionados à dificuldade de organização de agendas, minimizando erros e retrabalhos.  

## 2. Descrição do Problema  

| O problema                              | Afetando                            | Impacto                                                                 | Uma boa solução seria                                              |  
|-----------------------------------------|-------------------------------------|------------------------------------------------------------------------|------------------------------------------------------------------|  
| Dificuldade em gerenciar agendamentos de serviços. | Funcionários e clientes da clínica veterinária. | Confusão na agenda, perda de clientes e baixa produtividade devido a erros de comunicação. | Um sistema que centralize a gestão de agendamentos, permita consulta de disponibilidade e automatize confirmações. |  
| Ausência de histórico de atendimentos.  | Clientes e equipe de gestão.       | Perda de informações importantes sobre os serviços realizados para cada animal. | Registro digital dos atendimentos, com detalhamento de serviços, histórico do pet e preferências do cliente. |  

## 3. Descrição dos Usuários  

| Nome         | Descrição                                   | Responsabilidades  |  
|-------------|--------------------------------------------|--------------------|  
| Administrador | Gerencia o sistema e configurações gerais. | Cadastro de serviços, definição de usuários e verificação de relatórios de desempenho. |  
| Funcionário   | Opera o sistema diariamente.              | Registro de agendamentos, confirmação de presença e controle da agenda. |  
| Cliente       | Utiliza o sistema para marcar serviços.   | Realiza o próprio cadastro, consulta serviços e agenda atendimentos. |  

## 4. Descrição do Ambiente dos Usuários  
O sistema será utilizado em um ambiente variado:  
- **Administradores e funcionários** operarão o sistema por meio de computadores na clínica veterinária, lidando com múltiplos agendamentos simultâneos.  
- **Clientes** acessarão o sistema via dispositivos móveis ou computadores pessoais, muitas vezes em situações informais.  

O sistema deve ser acessível em locais com conexão à Internet e garantir responsividade e facilidade de uso para diferentes dispositivos.  

## 5. Necessidades dos Usuários  

- **Administradores:**  
  - Centralizar a agenda e os dados de serviços.  
  - Monitorar o desempenho de atendimentos.  
  - Considerar a integração com sistemas de pagamento para facilitar a administração financeira.  
- **Funcionários:**  
  - Acessar agendas de forma rápida e intuitiva.  
  - Cancelar agendamentos.  
- **Clientes:**  
  - Visualizar serviços disponíveis e seus preços.  
  - Agendar serviços rapidamente e receber confirmações automáticas.  

## 6. Alternativas Concorrentes  
- **Soluções existentes:** Sistemas como *PetDesk* e *Gingr* oferecem funcionalidades semelhantes, mas são voltados para o mercado internacional.  
- **Diferencial:** Nosso sistema será adaptado ao contexto local, incluindo suporte ao idioma português, integração com métodos de pagamento regionais e custo acessível.  

## 7. Visão Geral do Produto  
O sistema de agendamento para **clínica veterinária** é uma plataforma web responsiva que conecta clientes e a clínica de forma eficiente. Ele centraliza a gestão de agendamentos e serviços, elimina erros de comunicação e oferece aos clientes autonomia para agendar e gerenciar suas interações.  

**Benefícios esperados:**  
- Redução de erros e confusões na agenda.  
- Melhor experiência para os clientes.  
- Otimização do tempo e dos recursos da clínica veterinária.  

## 8. Requisitos Funcionais  

| Código | Nome                 | Descrição                                              |  
|--------|----------------------|------------------------------------------------------|  
| RF01   | Login e autenticação | Usuários precisam logar para acessar o sistema.     |  
| RF02   | Cadastro de serviços | Administradores podem cadastrar e editar serviços oferecidos. |  
| RF03   | Gerenciamento de agenda | Funcionários podem cancelar agendamentos. |  
| RF04   | Cadastro de clientes | Clientes realizam auto-cadastro no sistema.         |  
| RF05   | Agendamento online  | Clientes consultam e agendam serviços pela plataforma. |  
| RF06   | Notificações automáticas | Sistema envia lembretes de agendamentos aos clientes. |  
| RF07   | Relatórios gerenciais | Administradores acessam relatórios de históricos e performance. |  

## 9. Requisitos Não Funcionais  

| Código  | Nome                 | Descrição                                        | Categoria   | Classificação |  
|---------|----------------------|-------------------------------------------------|------------|--------------|  
| RNF01   | Design responsivo    | O sistema deve ser responsivo, adaptando-se a diversos dispositivos. | Usabilidade | Obrigatório  |  
| RNF02   | Criptografia de dados | Dados sensíveis devem ser armazenados de forma segura (e.g., senhas). | Segurança   | Obrigatório  |  
| RNF03   | Tempo de resposta    | O sistema deve responder em até 2 segundos para consultas simples. | Performance | Desejável    |  
| RNF04   | Privacidade dos dados | Dados de clientes e agendamentos devem ser acessíveis apenas pelos autorizados. | Privacidade | Obrigatório  |  
| RNF05   | Escalabilidade       | O sistema deve suportar até 500 usuários simultâneos. | Arquitetura | Obrigatório  |  
