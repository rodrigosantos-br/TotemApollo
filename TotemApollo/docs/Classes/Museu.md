A classe `Museu` gerencia as obras e os visitantes do museu.

#### Atributos:

- `private readonly List<Obra> obras`: Armazena a lista de obras do museu.
- `private readonly List<Visitante> visitantes`: Armazena a lista de visitantes do museu.
- `private int obraAtualIndex`: Armazena o índice da obra atualmente exibida.

#### Construtor:

- `public Museu()`: Inicializa as listas de obras e visitantes. Adiciona as obras padrão caso a lista esteja vazia. Define o índice da obra atual como 0.

#### Métodos:

- `public void AvancarParaProximaObra()`: Avança para a próxima obra na lista.
- `public void RetrocederParaObraAnterior()`: Retrocede para a obra anterior na lista.
- `public Obra ObraAtual()`: Retorna a obra atualmente exibida.
- `public void CadastrarVisitante(string nome, string dataNascimento)`: Adiciona um novo visitante à lista.
- `public void RemoverUltimoVisitante()`: Remove o último visitante da lista.
- `public int ObterQuantidadeDeVisitantes()`: Retorna o número de visitantes no museu.
- `public string ExibirHistoricoObraAtual()`: Retorna o histórico da obra atualmente exibida.
- `public string ExibirHistoricoObra(int id)`: Retorna o histórico da obra com o ID especificado.
- `public List<Obra> Obras { get => obras; }`: Propriedade de apenas leitura que retorna a lista de obras do museu.