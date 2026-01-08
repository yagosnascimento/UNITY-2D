
# ⚔️ A Vingança de Blaid 2D (Projeto de Estudo)

![Unity](https://img.shields.io/badge/Unity-2022.3%2B-black?style=flat&logo=unity)
![C#](https://img.shields.io/badge/Language-C%23-blue?style=flat&logo=c-sharp)
![Status](https://img.shields.io/badge/Status-Em_Desenvolvimento-yellow)

## 📖 Sobre o Projeto
Este repositório contém o código-fonte de um jogo de plataforma 2D desenvolvido como parte dos meus estudos na engine Unity.

O objetivo principal deste projeto é explorar e consolidar conhecimentos sobre a arquitetura da Unity, movimentação de personagens, sistemas de input e animação.

## 🎯 Objetivos de Aprendizado
Durante o desenvolvimento, foquei em aprender e implementar:
- **Input System (Novo):** Configuração de ações de controle (pulo, movimento) separadas da lógica.
- **Máquina de Estados de Animação:** Uso do Animator Controller para transições entre Idle, Walk, etc.
- **Física 2D:** Detecção de chão (`IsGroundedChecker`) e manipulação de Rigidbody2D.
- **Singleton Pattern:** Implementação de um `GameManager` para gerenciar estados globais.

## 🛠️ Estrutura do Código
Alguns dos scripts principais desenvolvidos:

* `PlayerAnim.cs`: Responsável por comunicar a lógica do jogo com o componente Animator.
* `inputManager.cs`: Camada de abstração que lê o Input System e passa os valores para o jogo.
* `GameManager.cs`: Singleton que centraliza o acesso aos gerenciadores (como o Input).
* `IsGroundedChecker.cs`: Script utilitário para verificar colisão com o chão.

## 🚀 Como rodar o projeto
1. Certifique-se de ter o **Unity Hub** instalado.
2. Clone este repositório:
   ```bash
   git clone [https://github.com/SEU-USUARIO/NOME-DO-REPO.git](https://github.com/SEU-USUARIO/NOME-DO-REPO.git)
3. Abra o Unity Hub e clique em **Add** -> **Add project from disk**.
4. Selecione a pasta do projeto.
5. Aguarde a Unity importar os assets e pacotes (pode demorar na primeira vez).
