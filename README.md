# Diamante de X

## Demonstra��o

![](https://i.imgur.com/xgBHjg9.gif)

## Introdu��o

Um jogo para voc� criar diamantes com tamanhos personalizados.

## Funcionalidades

- **Checagem de Input**: O jogo verifica se o n�mero informado � v�lido(N�mero inteiro e �mpar) antes de gerar o diamante.
- **Interatividade**: O jogador pode alterar o tamanho do diamante, o que refaz a gera��o do diamante e exibe um novo modelo.
- **Exibi��o do Diamante Completo**: Ao final, o diamante completo � impresso na tela, formando uma figura sim�trica.

## Como utilizar

1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project DiamanteX.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./DiamanteX.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
DiamanteX.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
