# Classe Museu

## Descrição

A classe Museu representa o museu no sistema Totem Apollo, responsável por armazenar informações sobre obras de arte e visitantes.

### Membros

- **obras**: Lista de obras de arte no museu.
- **visitantes**: Lista de visitantes do museu.

#### Construtor

**Museu()**: Inicializa uma nova instância da classe Museu, criando listas vazias de obras e visitantes. Adiciona quatro obras predefinidas se a lista de obras estiver vazia.

#### Métodos

- **CadastrarVisitante(string nome, string dataNascimento)**: Registra um novo visitante no museu com o nome e a data de nascimento fornecidos.
- **RemoverUltimoVisitante()**: Remove o último visitante.
- **ObterQuantidadeDeVisitantes()**: Retorna a quantidade total de visitantes registrados no museu.
- **ExibirHistoricoObra(int id)**: Retorna o histórico de uma obra de arte com o ID especificado.
- **Obras**: Propriedade que retorna a lista de obras de arte do museu.

#### Uso

Para interagir com o museu, crie uma instância da classe Museu e utilize seus métodos e propriedades conforme necessário para cadastrar visitantes, obter informações sobre obras e visitantes, e exibir o histórico de uma obra específica.
