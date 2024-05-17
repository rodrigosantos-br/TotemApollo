### Classe `FormularioControle`

Essa classe controla a manipulação e limpeza de controles em um formulário.

#### Métodos:

- `public void LimparControles(Control.ControlCollection control)`: Limpa os controles de um formulário, incluindo TextBoxes, ComboBoxes e CheckBoxes. Também limpa recursivamente os controles filhos, se houver.
- `public void IniciarTimer(Control objetoAlvo, int intervalo)`: Inicia um timer para ocultar um objeto alvo após um determinado intervalo de tempo.
- `public void IniciarTimer(Control control, int intervalo, Action callback)`: Inicia um timer para ocultar um controle após um determinado intervalo de tempo e executa um callback, se fornecido, após ocultar o controle.