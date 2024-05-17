A classe estática `QuestionarioEstaticos` mantém informações estáticas sobre respostas e interações do questionário.

#### Atributos:

- `public static readonly List<List<int>> respostas = []`: Armazena uma lista de listas de inteiros, representando as respostas para cada pergunta do questionário. Cada lista interna corresponde às respostas para uma pergunta específica.
- `public static int contadorInteracoes`: Armazena o número total de interações realizadas no questionário.

Essa classe é usada para armazenar informações que precisam ser compartilhadas entre diferentes instâncias de questionários ou acessadas globalmente. As respostas são armazenadas em uma estrutura de lista de listas para permitir o armazenamento de múltiplas respostas para cada pergunta. O contador de interações é atualizado conforme as interações ocorrem no questionário.