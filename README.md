# Sistema de Eventos com Unity utilizando o Padrão Observer

Bem-vindo ao repositório do sistema de eventos com Unity, implementado utilizando o padrão de projeto Observer. Este projeto demonstra como criar um sistema de eventos eficiente e flexível no Unity, facilitando a comunicação entre diferentes componentes do jogo.

## Índice

- [Introdução](#introdução)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Como Usar](#como-usar)
- [Contribuição](#contribuição)
- [Licença](#licença)
- [Contato](#contato)
- [Recursos Adicionais](#recursos-adicionais)
- [Agradecimentos](#agradecimentos)

## Introdução

O padrão de projeto Observer é amplamente utilizado no desenvolvimento de jogos para gerenciar eventos e comunicação entre objetos de forma desacoplada. Este repositório contém um exemplo prático de como implementar este padrão no Unity, criando um sistema de eventos robusto e fácil de manter.

## Pré-requisitos

- Unity 2022.3 ou superior
- Conhecimento básico de C# e Unity

## Instalação

1. Clone este repositório para sua máquina local:
    ```bash
    git clone https://github.com/EvertonBorges/Unity-EventSystem.git
    ```

2. Abra o Unity Hub e clique em "Add" para adicionar o projeto clonado.

3. Selecione a pasta do projeto e abra-o no Unity.

## Estrutura do Projeto

```plaintext
Unity-EventSystem/
├── Assets/
│   ├── Scripts/
│   │   ├── EventManager.cs
│   │   ├── UiButton.cs
│   │   └── UiScore.cs
│   ├── Scenes/
│   │   └── SampleScene.unity
├── .gitignore
├── README.md
├── LICENSE
```

- **Scripts/**: Contém todos os scripts C# necessários para o sistema de eventos.
- **Scenes/**: Contém a cena principal do projeto.

## Como Usar

### 1. EventManager.cs

Este script gerencia a criação e disparo de eventos.

```csharp
using System;

public static class EventManager
{
    
    public static Action<int> OnAddScore = (value) => {};

}
```

### 2. UiButton.cs

Este script demonstra como disparar um evento.

```csharp
using UnityEngine;

public class UiButton : MonoBehaviour
{
    
    public void BTN_AddScore(int value)
    {
        EventManager.OnAddScore.Invoke(value);
    }

}
```

### 3. UiScore.cs

Este script representa um observador que reage a eventos.

```csharp
using TMPro;
using UnityEngine;

public class UiScore : MonoBehaviour
{

    public TextMeshProUGUI text;

    private int score = 0;

    private void AddScore(int value)
    {
        score += value;

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        text.SetText(score.ToString());
    }

    void OnEnable()
    {
        EventManager.OnAddScore += AddScore;
    }

    void OnDisable()
    {
        EventManager.OnAddScore -= AddScore;
    }

}
```

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato

Se você tiver alguma dúvida, sugestão ou feedback, sinta-se à vontade para entrar em contato:

- **Portfolio:** [Everton Borges](https://evertonborges.com.br)
- **Youtube:** [Everton Borges](https://www.youtube.com/@everton.borges)
- **Itch.io:** [Everton Borges](https://evertonborges.itch.io)
- **LinkedIn:** [Everton Borges](https://www.linkedin.com/in/everton-soares-borges/)

## Recursos Adicionais

Aqui estão alguns recursos adicionais que podem ser úteis para entender melhor o padrão Observer e o Unity:

- **Documentação do Unity:**
  - [Unity Manual](https://docs.unity3d.com/Manual/index.html)
  - [Unity Scripting API](https://docs.unity3d.com/ScriptReference/)
  
- **Tutoriais e Cursos:**
  - [Unity Learn](https://learn.unity.com/)

## Agradecimentos

Gostaria de agradecer a todos que contribuíram direta ou indiretamente para este projeto. Seu apoio e feedback são extremamente valiosos.
