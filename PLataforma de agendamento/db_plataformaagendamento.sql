-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11/03/2025 às 15:26
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_plataformaagendamento`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_admin`
--

CREATE TABLE `tb_admin` (
  `id_admin` int(11) NOT NULL,
  `email` varchar(244) NOT NULL,
  `senha` varchar(244) NOT NULL,
  `nome` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cad_empresas`
--

CREATE TABLE `tb_cad_empresas` (
  `id` int(11) NOT NULL,
  `razaoSocial` varchar(244) NOT NULL,
  `nomeFantasia` varchar(244) NOT NULL,
  `cnpj` varchar(14) NOT NULL,
  `servicos` varchar(244) NOT NULL,
  `horario` time NOT NULL,
  `telefone` int(12) NOT NULL,
  `nomeContato` varchar(244) NOT NULL,
  `cep` int(9) NOT NULL,
  `estado` varchar(2) NOT NULL,
  `cidade` varchar(244) NOT NULL,
  `rua` varchar(244) NOT NULL,
  `numero` varchar(24) NOT NULL,
  `complemento` varchar(244) NOT NULL,
  `sobre` text NOT NULL,
  `foto1` varchar(244) NOT NULL,
  `foto2` varchar(244) NOT NULL,
  `foto3` varchar(244) NOT NULL,
  `foto4` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cad_profissional`
--

CREATE TABLE `tb_cad_profissional` (
  `id_profissional` int(11) NOT NULL,
  `nome_profissional` varchar(244) NOT NULL,
  `dat_nasc` varchar(11) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `telefone` varchar(12) NOT NULL,
  `area` varchar(50) NOT NULL,
  `certificado` varchar(244) NOT NULL,
  `anotacoes` text NOT NULL,
  `foto_profissional1` varchar(244) NOT NULL,
  `foto_profissional2` varchar(244) NOT NULL,
  `foto_profissional3` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cad_servicos`
--

CREATE TABLE `tb_cad_servicos` (
  `id_servico` int(11) NOT NULL,
  `servico_nome` varchar(244) NOT NULL,
  `tempo_servico` varchar(11) NOT NULL,
  `categoria_servico` varchar(244) NOT NULL,
  `valor_servico` varchar(11) NOT NULL,
  `nome_profissional` varchar(244) NOT NULL,
  `previsao_retorno` varchar(244) NOT NULL,
  `descricao_servico` varchar(244) NOT NULL,
  `foto_servico1` varchar(244) NOT NULL,
  `foto_servico2` varchar(244) NOT NULL,
  `foto_servico3` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_admin`
--
ALTER TABLE `tb_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Índices de tabela `tb_cad_empresas`
--
ALTER TABLE `tb_cad_empresas`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `tb_cad_profissional`
--
ALTER TABLE `tb_cad_profissional`
  ADD PRIMARY KEY (`id_profissional`);

--
-- Índices de tabela `tb_cad_servicos`
--
ALTER TABLE `tb_cad_servicos`
  ADD PRIMARY KEY (`id_servico`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_admin`
--
ALTER TABLE `tb_admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_cad_empresas`
--
ALTER TABLE `tb_cad_empresas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_cad_profissional`
--
ALTER TABLE `tb_cad_profissional`
  MODIFY `id_profissional` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_cad_servicos`
--
ALTER TABLE `tb_cad_servicos`
  MODIFY `id_servico` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
