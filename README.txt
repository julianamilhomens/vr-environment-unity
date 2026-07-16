PROJETO FINAL - MEU PRIMEIRO AMBIENTE VR
Aluna: Juliana Maria Milhomens de Siqueira
Curso: Residência em TIC 29 - Web 3.0

DESCRIÇÃO

Ambiente virtual de uma praça contendo banco, caixote, poste de luz,
arbusto e árvore, com chão caminhável e skybox configurada. A cena é
navegável em primeira pessoa no PC (WASD + mouse), sem necessidade de
óculos VR, conforme os requisitos do projeto.

COMO EXECUTAR
1. Abrir o projeto no Unity 6 (6000.3 LTS)
2. Abrir a cena: Assets/Scenes/SampleScene
3. Apertar Play no Editor
4. Controles: WASD anda, mouse olha ao redor, ESC libera o cursor

TECNOLOGIAS
- Unity 6000.3.19f1 LTS (URP)
- Meta XR All-in-One SDK v203 (OpenXR)
- Build Settings configurados para Android (Meta Quest)

REFLEXÃO SOBRE APRENDIZADO

O desenvolvimento deste projeto proporcionou uma visão completa do fluxo de
trabalho em XR, desde a configuração do ambiente até a entrega versionada.
Os principais aprendizados técnicos incluem a preparação do Unity para a
plataforma Android/Meta Quest, a integração do Meta XR SDK com o plugin
OpenXR e a implementação de movimentação em primeira pessoa utilizando
CharacterController.

Durante o processo, foram superados desafios reais de desenvolvimento: a
ausência do módulo Android Build Support na instalação original do editor,
incompatibilidades na ferramenta Unity Hub e um conflito entre o novo Input
System e a API clássica de entrada, solucionado por meio da configuração
Active Input Handling. 

O projeto também consolidou boas práticas de organização: estruturação de
pastas e nomenclatura consistente de assets, controle de versão com Git e
publicação adequada do repositório, incluindo o uso de .gitignore para
manter apenas os arquivos essenciais (Assets, Packages e ProjectSettings).