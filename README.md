# Sistema_Escolar
Projeto da faculdade onde será feito um sistema de registro e incerssão de notas:  
  
# 1. Contexto da atividade
Uma escola deseja desenvolver um pequeno sistema para armazenar e consultar notas de alunos em uma disciplina.  
Cada aluno possuirá as seguintes informações:  
  
Código do aluno (inteiro)  
Nome do aluno (string)  
Nota final (double)  
Esses dados deverão ser armazenados em uma lista linear em memória, utilizando C#.  
  
Seu objetivo será implementar operações de armazenamento, exibição e busca sobre essa lista, aplicando os conceitos de:  
  
Lista Linear  
Pesquisa Sequencial  
Pesquisa Binária  
Recursividade  
Análise de Complexidade  
# 2. Objetivo da atividade
Desenvolver um programa em C# que permita:  
  
Cadastrar alunos em uma lista linear;  
Listar todos os alunos cadastrados;  
Buscar um aluno pelo código utilizando pesquisa sequencial;  
Ordenar os alunos pelo código em ordem crescente;  
Buscar um aluno pelo código utilizando pesquisa binária;  
Implementar uma função recursiva para uma das operações solicitadas;  
Realizar a análise de complexidade de cada algoritmo utilizado.  
# 3. Requisitos obrigatórios
3.1 Estrutura de dados  
Você deve utilizar uma lista linear para armazenar os dados dos alunos.  
  
3.2 Estrutura do aluno  
Crie uma estrutura/classe chamada Aluno com os seguintes atributos:  
  
int Codigo;  
string Nome;  
double Nota;  
# 4. Funcionalidades que o programa deve ter
4.1 Cadastro de alunos  
Permitir ao usuário inserir vários alunos na lista.  
  
Exemplo:  
Código: 101  
Nome: Ana  
Nota: 8,5  
4.2 Exibição da lista  
Exibir todos os alunos cadastrados.  
  
Exemplo de saída:  
Código: 101 | Nome: Ana | Nota: 8,5  
Código: 205 | Nome: Bruno | Nota: 7,0  
Código: 310 | Nome: Carla | Nota: 9,2  
4.3 Pesquisa Sequencial  
Implementar uma função que receba um código do aluno e procure esse aluno na lista utilizando pesquisa sequencial.  
  
Regras:  
Percorrer a lista do início ao fim;  
Informar se o aluno foi encontrado ou não;  
Caso encontrado, exibir seus dados.  
Exemplo:  
Digite o código a buscar: 205  
Aluno encontrado:  
Código: 205 | Nome: Bruno | Nota: 7,0  
4.4 Ordenação da lista  
Antes de aplicar a pesquisa binária, a lista deve estar ordenada pelo código do aluno em ordem crescente.  
  
Você pode implementar um algoritmo de ordenação simples, como:  
  
Bubble Sort  
Selection Sort  
Insertion Sort  
Observação: a ordenação é necessária para que a pesquisa binária funcione corretamente.  
  
4.5 Pesquisa Binária  
Implementar uma função que receba um código do aluno e realize a busca utilizando pesquisa binária.  
  
Regras:  
A lista deve estar previamente ordenada;  
Informar se o aluno foi encontrado ou não;  
Caso encontrado, exibir seus dados.  
Exemplo:  
Digite o código a buscar: 310  
Aluno encontrado:  
Código: 310 | Nome: Carla | Nota: 9,2  
4.6 Uso de Recursividade  
Você deverá implementar uma versão recursiva de pelo menos uma das seguintes opções:  
  
Opção A – Pesquisa Sequencial Recursiva  
Criar uma função recursiva que busque o aluno pelo código percorrendo a lista.  
  
ou  
  
Opção B – Pesquisa Binária Recursiva  
Criar uma função recursiva para realizar a pesquisa binária.  
  
ou  
  
Opção C – Impressão Recursiva da Lista  
Criar uma função recursiva para exibir os elementos da lista.  
  
Obrigatório: no relatório, explicar como a recursividade foi aplicada e qual foi o caso base e o passo recursivo.  

# 5. Menu sugerido
O programa deve apresentar um menu semelhante ao exemplo abaixo:  

===== SISTEMA DE ALUNOS =====  
1 - Cadastrar aluno  
2 - Listar alunos  
3 - Buscar por código (Pesquisa Sequencial)  
4 - Ordenar lista por código  
5 - Buscar por código (Pesquisa Binária)  
6 - Busca recursiva  
0 - Sair  
Escolha uma opção:  
# 6. Parte teórica obrigatória (entrega junto com o código)
Além da implementação, você deverá entregar uma análise de complexidade para os algoritmos utilizados.  

# 7. O que deve ser analisado
Para cada algoritmo implementado, o aluno deverá apresentar:  

Descrição do funcionamento  
Função de custo  
Ordem de complexidade  
Análise de melhor caso, pior caso e caso médio (quando aplicável)  
# 8. Algoritmos que devem ser analisados
8.1 Pesquisa Sequencial  
Você deve analisar:  

Como o algoritmo funciona  
Quantidade de comparações realizadas  
Função de custo  
Ordem de complexidade  
O aluno deve responder:  
Qual é o melhor caso?  
Qual é o pior caso?  
Qual é o caso médio?  
Qual é a função de custo?  
Qual é a ordem de complexidade?  
8.2 Pesquisa Binária  
Você deve analisar:  

Como a busca divide o problema em partes menores;  
Quantidade de comparações realizadas;  
Por que a lista precisa estar ordenada;  
Função de custo  
Ordem de complexidade  
O aluno deve responder:  
Qual é o melhor caso?  
Qual é o pior caso?  
Qual é o caso médio?  
Qual é a função de custo?  
Qual é a ordem de complexidade?  
8.3 Função Recursiva implementada  
Você deve analisar:  

Qual foi o caso base  
Qual foi o passo recursivo  
Quantas chamadas recursivas podem ocorrer  
8.4 Algoritmo de Ordenação (se implementado manualmente)  
Caso você implemente a ordenação manualmente, também deverá analisar:  

Número de comparações  
Número de trocas  
Função de custo  
Ordem de complexidade  
# 9. Exemplo do que deve aparecer na análise
Importante: não basta apenas escrever “é O(n)” ou “é O(log n)”.  
Você deve justificar.  

Exemplo esperado de nível de explicação:  
Na pesquisa sequencial, no pior caso, o algoritmo percorre todos os n elementos da lista até concluir que o valor está na última posição ou não existe.  
Logo, a função de custo pode ser representada por:  
T(n) = c1 + c2*n  
Desprezando constantes e termos de menor ordem:  
O(n)  
Esse nível de detalhamento será exigido para todos os algoritmos pedidos.  

# 10. Requisitos técnicos do código
Seu código deve apresentar:  

Boa organização  
Nomes de variáveis significativos  
Separação em funções/métodos  
Comentários explicativos quando necessário  
Uso correto de estruturas de repetição e decisão  
Tratamento básico de entrada inválida (se possível)  
