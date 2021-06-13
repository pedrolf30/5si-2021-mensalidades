# Gerenciamento de Mensalidades

[![NPM](https://img.shields.io/npm/l/react)](https://github.com/pedrolf30/gerenciamento-de-dividas/blob/main/LICENSE) 

## Sobre o projeto

>Neste momento difícil financeiramente falando que estamos passando, muitas instituições e escolas precisaram se adequar ao cenário, mas infelizmente mesmo assim muitas famílias não conseguem manter suas mensalidades em dia. Este cenário é uma realidade e precisamos propor soluções para quem está com dívida, que está sendo gerada seja negociada de forma amigável e viável, tanto para quem está devendo quanto para quem está precisando do dinheiro para pagar serviços e funcionários.

  ## Layout
  ![Screen 1](https://github.com/pedrolf30/gerenciamento-de-mensalidades/blob/main/gerenciamento-de-mensalidades/gerenciamento-de-mensalidades/assets/raw/screen1.png)

  ![Screen 2](https://github.com/pedrolf30/gerenciamento-de-mensalidades/blob/main/gerenciamento-de-mensalidades/gerenciamento-de-mensalidades/assets/raw/screen2.png)

  ![Screen 3](https://github.com/pedrolf30/gerenciamento-de-mensalidades/blob/main/gerenciamento-de-mensalidades/gerenciamento-de-mensalidades/assets/raw/screen3.png)


  # Tecnologias utilizadas
  - C#
  - phpMyAdmin
  - XAMPP
  - Windows Forms App (.NET Framework)
  - Visual Studio

  # Como executar o projeto

  ```bash
  # clonar repositório
  git clone https://github.com/pedrolf30/gerenciamento-de-mensalidades.git
  ```
  ## Banco de dados

  Pré-requisitos: [XAMPP](https://www.apachefriends.org/pt_br/index.html), [Notepad++](https://notepad-plus-plus.org/) (Opcional)

  ```bash
  # abra o XAMPP e inicie o Apache e o MySQL
  C:\xampp\xampp-control.exe
  
  # abra o banco de dados do projeto, selecione tudo (CTRL + A) e copie (CTRL + C)
  notepad Documentos/database.sql
  
  # após a inicialização do Apache e do MySQL acesse esse endereço abaixo no seu 
  # navegador e cole (CTRL + V) o conteúdo copiado do arquivo database.sql no espaço para 
  # consulta e execute o código
  http://localhost:8080/phpmyadmin/server_sql.php
  
  # você também pode escolher armazer o conteúdo do arquivo database.sql em um ambiente 
  # de sua escolha (eg. MySQL Workbench), apenas lembre de   
  # adaptar as configurações do seu ambiente no arquivo de Conexao do projeto
  cd gerenciamento-de-mensalidades/gerenciamento-de-mensalidades/App.config
  ```

  ## Projeto Windows Forms

  Pré-requisitos: [Visual Studio](https://visualstudio.microsoft.com/pt-br/)

  ```bash
  # clonar repositório
  https://github.com/pedrolf30/gerenciamento-de-mensalidades.git
  
  # entre na pasta do projeto
  cd gerenciamento-de-mensalidades\gerenciamento-de-mensalidades\bin\Debug
  
  # executar o projeto
  gerenciamento-de-vendas.exe
  ```

  ## Faça login utilizando uma das contas de usuário abaixo

  - administrador - Email: admin@admin.com | Password: admin123
  - funcionário - Email: samuel.cezar@email.com | Password: samuel123
  - aluno - Email: aluno.exemplo@email.com | Password: aluno123

  > Você também pode utilizar outra conta de usuário do arquivo database.sql ou criar sua
  própria conta no ambiente SQL que você estiver utilizando


  # Autores

  Samuel Paim Araújo Cezar
  [[Github](https://github.com/SamuelPaimAraujoCezar)]
  [[Linkedin](https://www.linkedin.com/in/samuel-paim-araujo-cezar/)]

  Pedro Lanatti Ferrareso
  [[Github](https://github.com/pedrolf30)]

