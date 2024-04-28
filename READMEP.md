[\[English\]](README.md) [\[Português\]](#Usando_Testes_Unitários_para_Testar_uma_Calculadora)
_______________________________________________________________________________________________________________________________________
# Usando Testes Unitários para Testar uma Calculadora
Esta solução é composta por três projetos:
1. Calculadora simples:

Um projeto que usa as quatro operações matemáticas (Soma. Subtração, Multiplicação e Divisão) com números inteiros. Guarda em uma lista as três últimas operações, para fins de histórico.

2. XUnit Teste:
  
  Um projeto usando o framework XUnit para testar as quatro operações, a exceção de número dividido por zero e a lista de histórico das operações.

3. NUnit Teste:
  
  Um projeto usando o framework NUnit para testar as quatro operações, a exceção de número dividido por zero e a lista de histórico das operações.

## Objetivos
O principal objetivo é utilizar as ferramentas XUnit e NUnit para testar um projeto simples de uma calculadora.

## Diferenças entre XUnit e NUnit
Ambos os frameworks tem o mesmo propósito. O que muda são os comandos utilizados.

Comandos do XUnit:
  - [Fact]: Usado para iniciar um bloco de teste unitário.
  - [Theory] e [InlineData]: Usado para testar um bloco de teste unitário com uma lista de parâmetros, pode repetir inúmeras chamadas com valores diferentes..
  - Assert.Equal: Testa se um resultado esperado é igual ao resultado obtido, em caso positivo o teste é válido, caso contrário inválido.

Comandos do NUnit:
  - [Test]: Usado para iniciar um bloco de teste unitário, roda uma única vez.
  - [TestCase]: Usado para testar um bloco de teste unitário com uma lista de parâmetros, pode repetir inúmeras chamadas com valores diferentes.
  - Assert.AreEqual: Testa se um resultado esperado é igual ao resultado obtido, em caso positivo o teste é válido, caso contrário inválido.

## Feramentas
- Visual Studio 2022
- .Net 7.0
- XUnit Framework
- NUnit Framewowrk
