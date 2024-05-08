# Classe CadastroValidacao

## Descrição

A classe CadastroValidacao é responsável por validar as informações de nome e data de nascimento fornecidas durante o processo de cadastro.

### Membros

- **nome**: O nome a ser validado.
- **dataNascimento**: A data de nascimento a ser validada.
- **mensagemNome**: Mensagem de validação do nome.
- **mensagemDataNascimento**: Mensagem de validação da data de nascimento.

#### Construtor

**CadastroValidacao(string nome, string dataNascimento)**: Inicializa uma nova instância da classe CadastroValidacao com o nome e a data de nascimento fornecidos, e realiza a validação.

#### Métodos

- **ValidarNome()**: Valida o nome fornecido, verificando se não está vazio e se possui o comprimento adequado.
- **ValidarDataNascimento()**: Valida a data de nascimento fornecida, verificando se não está vazia. Outras verificações de validade podem ser adicionadas aqui.

#### Propriedades

- **MensagemNome**: Obtém a mensagem de validação do nome.
- **MensagemDataNascimento**: Obtém a mensagem de validação da data de nascimento.

#### Uso

Para validar um nome e uma data de nascimento, crie uma instância da classe CadastroValidacao e utilize as propriedades MensagemNome e MensagemDataNascimento para obter as mensagens de validação correspondentes.
