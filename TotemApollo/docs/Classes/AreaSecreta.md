# Classe AreaSecreta

## Descrição

A classe AreaSecreta representa a interface para acessar a área secreta do Totem Apollo, onde são exibidos relatórios confidenciais sobre o feedback do questionário coletado dos visitantes.

### Membros

- **_questionario**: Controle para acessar as funcionalidades relacionadas ao questionário.

#### Construtores

- **AreaSecreta()**: Inicializa uma nova instância da classe AreaSecreta e configura o controle do questionário.

#### Métodos

- **btnMostrarRelatorio_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Mostrar Relatório" é clicado, responsável por exibir as porcentagens totais para cada categoria de resposta do questionário no DataGridView.
- **btnFecharPrograma_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Fechar Programa" é clicado, responsável por encerrar a aplicação.

#### Uso

Para utilizar a classe AreaSecreta, crie uma nova instância dela e configure os controles necessários. Utilize os eventos e métodos disponíveis para controlar a interação com os usuários e executar as operações desejadas, como exibir relatórios confidenciais ou encerrar o programa.
