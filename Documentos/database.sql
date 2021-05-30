-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Maio-2021 às 00:08
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `gerenciamentomensalidades`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_alunos`
--

CREATE TABLE `tb_alunos` (
  `id_aluno` int(11) NOT NULL,
  `nome_completo` varchar(100) NOT NULL,
  `RA` int(11) NOT NULL,
  `data_nascimento` date NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `curso_matriculado` varchar(30) NOT NULL,
  `contato` varchar(30) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_alunos`
--

INSERT INTO `tb_alunos` (`id_aluno`, `nome_completo`, `RA`, `data_nascimento`, `CPF`, `curso_matriculado`, `contato`, `id_usuario`) VALUES
(1, 'Pedro L. Ferrareso', 9942, '2001-02-19', '502.489.058-22', 'Sistemas de Informação', '(19) 9 9695-8005', 1),
(2, 'Aluno Teste', 31451, '1996-04-12', '135.643.789-05', 'Direito', '(21) 8 8745-6876', 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_bolsistas`
--

CREATE TABLE `tb_bolsistas` (
  `id_bolsista` int(11) NOT NULL,
  `id_aluno` int(11) NOT NULL,
  `desconto` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_bolsistas`
--

INSERT INTO `tb_bolsistas` (`id_bolsista`, `id_aluno`, `desconto`) VALUES
(1, 2, '35%');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_enderecos`
--

CREATE TABLE `tb_enderecos` (
  `id_endereco` int(11) NOT NULL,
  `id_aluno` int(11) NOT NULL,
  `rua` varchar(150) NOT NULL,
  `numero` int(5) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `estado` char(2) NOT NULL,
  `complemento` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_enderecos`
--

INSERT INTO `tb_enderecos` (`id_endereco`, `id_aluno`, `rua`, `numero`, `cep`, `bairro`, `cidade`, `estado`, `complemento`) VALUES
(1, 1, 'Rua Endereço do Pedro', 777, '13171-635', 'Bairro do Pedro', 'Sumaré', 'SP', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionarios`
--

CREATE TABLE `tb_funcionarios` (
  `id_funcionario` int(11) NOT NULL,
  `nome_completo` varchar(100) NOT NULL,
  `data_nascimento` date NOT NULL,
  `CPF` varchar(14) NOT NULL,
  `contato` varchar(30) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_funcionarios`
--

INSERT INTO `tb_funcionarios` (`id_funcionario`, `nome_completo`, `data_nascimento`, `CPF`, `contato`, `id_usuario`) VALUES
(1, 'Samuel P. A. Cezar', '2001-07-18', '302.452.174-21', '(19) 3896-5331', 3),
(2, 'João da Silva', '2005-05-20', '398.902.819-02', '(19) 9 9748-9182', 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_mensalidades`
--

CREATE TABLE `tb_mensalidades` (
  `id_mensalidade` int(11) NOT NULL,
  `id_aluno` int(11) NOT NULL,
  `valor` double NOT NULL,
  `mes_mensalidade` varchar(15) NOT NULL,
  `data_vencimento` date NOT NULL,
  `pago` tinyint(1) NOT NULL,
  `data_pagamento` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_mensalidades`
--

INSERT INTO `tb_mensalidades` (`id_mensalidade`, `id_aluno`, `valor`, `mes_mensalidade`, `data_vencimento`, `pago`, `data_pagamento`) VALUES
(1, 2, 640, 'Abril 2021', '2021-05-15', 1, '2021-04-10'),
(2, 2, 640, 'Maio 2021', '2021-06-15', 0, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_solicitacoes`
--

CREATE TABLE `tb_solicitacoes` (
  `id_solicitacao` int(11) NOT NULL,
  `id_aluno` int(11) NOT NULL,
  `id_funcionario` int(11) DEFAULT NULL,
  `categoria` varchar(50) NOT NULL,
  `descricao` text NOT NULL,
  `data_solicitacao` date NOT NULL,
  `status` varchar(50) NOT NULL,
  `resposta` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_solicitacoes`
--

INSERT INTO `tb_solicitacoes` (`id_solicitacao`, `id_aluno`, `id_funcionario`, `categoria`, `descricao`, `data_solicitacao`, `status`, `resposta`) VALUES
(1, 2, 1, 'Solicitação de Bolsa', 'Bom dia, estou abrindo essa solicitação para pedir uma bolsa para o curso de direito', '2021-05-16', 'Aprovado', 'Bom dia Aluno Teste, a faculdade decidiu lhe conceder uma bolsa de 35% para o curso de direito');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tipos_usuario`
--

CREATE TABLE `tb_tipos_usuario` (
  `id_tipo_usuario` int(11) NOT NULL,
  `descricao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_tipos_usuario`
--

INSERT INTO `tb_tipos_usuario` (`id_tipo_usuario`, `descricao`) VALUES
(1, 'Administrador'),
(2, 'Funcionario'),
(3, 'Aluno');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `id_usuario` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `id_tipo_usuario` int(11) NOT NULL,
  `ativo` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `email`, `senha`, `id_tipo_usuario`, `ativo`) VALUES
(1, 'pedrolf30@gmail.com', 'pedro123', 3, 1),
(2, 'admin@admin.com', 'admin123', 1, 1),
(3, 'samuel.cezar@email.com', 'samuel123', 2, 1),
(4, 'aluno.exemplo@email.com', 'aluno123', 3, 1),
(5, 'joao.silva@gmail.com', '1234', 2, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_alunos`
--
ALTER TABLE `tb_alunos`
  ADD PRIMARY KEY (`id_aluno`),
  ADD UNIQUE KEY `RA` (`RA`),
  ADD UNIQUE KEY `CPF` (`CPF`),
  ADD UNIQUE KEY `id_usuario` (`id_usuario`);

--
-- Índices para tabela `tb_bolsistas`
--
ALTER TABLE `tb_bolsistas`
  ADD PRIMARY KEY (`id_bolsista`),
  ADD KEY `id_aluno` (`id_aluno`);

--
-- Índices para tabela `tb_enderecos`
--
ALTER TABLE `tb_enderecos`
  ADD PRIMARY KEY (`id_endereco`),
  ADD KEY `id_aluno` (`id_aluno`);

--
-- Índices para tabela `tb_funcionarios`
--
ALTER TABLE `tb_funcionarios`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD UNIQUE KEY `CPF` (`CPF`),
  ADD UNIQUE KEY `id_usuario` (`id_usuario`);

--
-- Índices para tabela `tb_mensalidades`
--
ALTER TABLE `tb_mensalidades`
  ADD PRIMARY KEY (`id_mensalidade`),
  ADD KEY `id_aluno` (`id_aluno`);

--
-- Índices para tabela `tb_solicitacoes`
--
ALTER TABLE `tb_solicitacoes`
  ADD PRIMARY KEY (`id_solicitacao`),
  ADD KEY `id_aluno` (`id_aluno`),
  ADD KEY `id_funcionario` (`id_funcionario`);

--
-- Índices para tabela `tb_tipos_usuario`
--
ALTER TABLE `tb_tipos_usuario`
  ADD PRIMARY KEY (`id_tipo_usuario`);

--
-- Índices para tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `id_tipo_usuario` (`id_tipo_usuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_alunos`
--
ALTER TABLE `tb_alunos`
  MODIFY `id_aluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_bolsistas`
--
ALTER TABLE `tb_bolsistas`
  MODIFY `id_bolsista` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tb_enderecos`
--
ALTER TABLE `tb_enderecos`
  MODIFY `id_endereco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tb_funcionarios`
--
ALTER TABLE `tb_funcionarios`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tb_mensalidades`
--
ALTER TABLE `tb_mensalidades`
  MODIFY `id_mensalidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `tb_solicitacoes`
--
ALTER TABLE `tb_solicitacoes`
  MODIFY `id_solicitacao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tb_tipos_usuario`
--
ALTER TABLE `tb_tipos_usuario`
  MODIFY `id_tipo_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `tb_alunos`
--
ALTER TABLE `tb_alunos`
  ADD CONSTRAINT `tb_alunos_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuarios` (`id_usuario`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_bolsistas`
--
ALTER TABLE `tb_bolsistas`
  ADD CONSTRAINT `tb_bolsistas_ibfk_1` FOREIGN KEY (`id_aluno`) REFERENCES `tb_alunos` (`id_aluno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_enderecos`
--
ALTER TABLE `tb_enderecos`
  ADD CONSTRAINT `tb_enderecos_ibfk_1` FOREIGN KEY (`id_aluno`) REFERENCES `tb_alunos` (`id_aluno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_funcionarios`
--
ALTER TABLE `tb_funcionarios`
  ADD CONSTRAINT `tb_funcionarios_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuarios` (`id_usuario`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_mensalidades`
--
ALTER TABLE `tb_mensalidades`
  ADD CONSTRAINT `tb_mensalidades_ibfk_1` FOREIGN KEY (`id_aluno`) REFERENCES `tb_alunos` (`id_aluno`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_solicitacoes`
--
ALTER TABLE `tb_solicitacoes`
  ADD CONSTRAINT `tb_solicitacoes_ibfk_1` FOREIGN KEY (`id_aluno`) REFERENCES `tb_alunos` (`id_aluno`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tb_solicitacoes_ibfk_2` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionarios` (`id_funcionario`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Limitadores para a tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD CONSTRAINT `tb_usuarios_ibfk_1` FOREIGN KEY (`id_tipo_usuario`) REFERENCES `tb_tipos_usuario` (`id_tipo_usuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
