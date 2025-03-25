# Diamante de X

## Demonstração

![](https://i.imgur.com/xgBHjg9.gif)

## Introdução

Um jogo para você criar diamantes com tamanhos personalizados.

## Funcionalidades

- **Checagem de Input**: O jogo verifica se o número informado é válido(Número inteiro e ímpar) antes de gerar o diamante.
- **Interatividade**: O jogador pode alterar o tamanho do diamante, o que refaz a geração do diamante e exibe um novo modelo.
- **Exibição do Diamante Completo**: Ao final, o diamante completo é impresso na tela, formando uma figura simétrica.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project DiamanteX.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./DiamanteX.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
DiamanteX.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
