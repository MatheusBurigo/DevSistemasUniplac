﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PizzariaDoZe.DAO.Interfaces;
using PizzariaDoZe.DAO.utils;
using System.Data;

namespace PizzariaDoZe.DAO
{
    public class FuncionarioDAO
    {

        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public FuncionarioDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Funcionario funcionario)
        {
            ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

            //Adiciona parâmetro (@campo e valor)
            var nome = connections.comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = funcionario.Nome; connections.comando.Parameters.Add(nome);
            var cpf = connections.comando.CreateParameter(); cpf.ParameterName = "@cpf";
            cpf.Value = funcionario.Cpf; connections.comando.Parameters.Add(cpf);
            var matricula = connections.comando.CreateParameter(); matricula.ParameterName = "@matricula";
            matricula.Value = funcionario.Matricula; connections.comando.Parameters.Add(matricula);
            var senha = connections.comando.CreateParameter(); senha.ParameterName = "@senha";
            senha.Value = funcionario.Senha; connections.comando.Parameters.Add(senha);
            var grupo = connections.comando.CreateParameter(); grupo.ParameterName = "@grupo";
            grupo.Value = funcionario.Grupo; connections.comando.Parameters.Add(grupo);
            var motorista = connections.comando.CreateParameter(); motorista.ParameterName = "@motorista";
            motorista.Value = funcionario.Motorista; connections.comando.Parameters.Add(motorista);
            var validade_motorista = connections.comando.CreateParameter(); validade_motorista.ParameterName = "@validade_motorista";
            validade_motorista.Value = funcionario.Validade; connections.comando.Parameters.Add(validade_motorista);
            var observacao = connections.comando.CreateParameter(); observacao.ParameterName = "@observacao";
            observacao.Value = funcionario.Observacao; connections.comando.Parameters.Add(observacao);
            var telefone = connections.comando.CreateParameter(); telefone.ParameterName = "@telefone";
            telefone.Value = funcionario.Telefone; connections.comando.Parameters.Add(telefone);
            var email = connections.comando.CreateParameter(); email.ParameterName = "@email";
            email.Value = funcionario.Email; connections.comando.Parameters.Add(email);
            var endereco_id = connections.comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id";
            endereco_id.Value = funcionario.EnderecoId; connections.comando.Parameters.Add(endereco_id);
            var numero = connections.comando.CreateParameter(); numero.ParameterName = "@numero";
            numero.Value = funcionario.Numero; connections.comando.Parameters.Add(numero);
            var complemento = connections.comando.CreateParameter(); complemento.ParameterName = "@complemento";
            complemento.Value = funcionario.Complemento; connections.comando.Parameters.Add(complemento);
            connections.conexao.Open();
            //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
            string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
            //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
            connections.comando.CommandText = @"INSERT INTO tb_funcionarios (nome, cpf, matricula, senha, grupo, motorista, validade_motorista, observacao, telefone, email, endereco_id, numero, complemento)
            VALUES (@nome, @cpf, @matricula, @senha, @grupo, @motorista, @validade_motorista, @observacao, @telefone, @email, @endereco_id, @numero, @complemento);" + auxSQL_ID;
            //executa o comando no banco de dados e captura o ID gerado
            var IdGerado = connections.comando.ExecuteScalar();
            return Convert.ToInt32(IdGerado);
        }

        public DataTable Buscar(Funcionario funcionario)
        {
            ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

            string auxSqlFiltro = "";
            if (funcionario.Id > 0)
            {
                auxSqlFiltro = "WHERE f.id_funcionario = " + funcionario.Id + " ";
            }
            else if (funcionario.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE f.nome_funcionario like '%" + funcionario.Nome + "%' ";
            }
            connections.conexao.Open();
            connections.comando.CommandText = @" " +
            "SELECT f.id_funcionario AS ID, f.nome_funcionario AS Nome, f.cpf AS CPF, f.matricula AS Matrícula, f.senha AS Senha, " +
            "f.grupo AS Grupo, f.motorista AS " +
            "Carteira, f.validade_motorista AS Validade, f.observacao AS Observação, f.telefone AS Telefone, f.email AS 'E-Mail', " +
            "e.id_endereco AS ID, e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
            "c.id_cidade AS IDCidade, c.nome_cidade AS Cidade, " +
            "u.id_uf AS IDUF, u.nome_uf AS UF, " +
            "p.id_pais AS IDPais, p.nome_pais AS Pais, " +
            "f.numero AS Número, f.complemento AS Complemento " +
            "FROM tb_funcionarios AS f " +
            "INNER JOIN tb_enderecos AS e ON e.id_endereco = f.endereco_id " +
            "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
            "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
            "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
            auxSqlFiltro +
            "ORDER BY f.nome_funcionario;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = connections.comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public void Editar(Funcionario funcionario)
        {
            ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

            //Adiciona parâmetro (@campo e valor)
            var id = connections.comando.CreateParameter(); id.ParameterName = "@id"; id.Value = funcionario.Id; connections.comando.Parameters.Add(id);
            var nome = connections.comando.CreateParameter(); nome.ParameterName = "@nome"; nome.Value = funcionario.Nome; connections.comando.Parameters.Add(nome);
            var cpf = connections.comando.CreateParameter(); cpf.ParameterName = "@cpf"; cpf.Value = funcionario.Cpf; connections.comando.Parameters.Add(cpf);
            var matricula = connections.comando.CreateParameter(); matricula.ParameterName = "@matricula"; matricula.Value = funcionario.Matricula; connections.comando.Parameters.Add(matricula);
            var senha = connections.comando.CreateParameter(); senha.ParameterName = "@senha"; senha.Value = funcionario.Senha; connections.comando.Parameters.Add(senha);
            var grupo = connections.comando.CreateParameter(); grupo.ParameterName = "@grupo"; grupo.Value = funcionario.Grupo; connections.comando.Parameters.Add(grupo);
            var motorista = connections.comando.CreateParameter(); motorista.ParameterName = "@motorista"; motorista.Value = funcionario.Motorista; connections.comando.Parameters.Add(motorista);
            var validade_motorista = connections.comando.CreateParameter(); validade_motorista.ParameterName = "@validade_motorista"; validade_motorista.Value = funcionario.Validade;
            connections.comando.Parameters.Add(validade_motorista);
            var observacao = connections.comando.CreateParameter(); observacao.ParameterName = "@observacao"; observacao.Value = funcionario.Observacao; connections.comando.Parameters.Add(observacao);
            var telefone = connections.comando.CreateParameter(); telefone.ParameterName = "@telefone"; telefone.Value = funcionario.Telefone; connections.comando.Parameters.Add(telefone);
            var email = connections.comando.CreateParameter(); email.ParameterName = "@email"; email.Value = funcionario.Email; connections.comando.Parameters.Add(email);
            var endereco_id = connections.comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id"; endereco_id.Value = funcionario.EnderecoId; connections.comando.Parameters.Add(endereco_id);
            var numero = connections.comando.CreateParameter(); numero.ParameterName = "@numero"; numero.Value = funcionario.Numero; connections.comando.Parameters.Add(numero);
            var complemento = connections.comando.CreateParameter(); complemento.ParameterName = "@complemento"; complemento.Value = funcionario.Complemento; connections.comando.Parameters.Add(complemento);

            connections.conexao.Open();
            //realiza o UPDATE
            connections.comando.CommandText = @"UPDATE tb_funcionarios SET " +
                "nome = @nome, " +
                "cpf = @cpf, " +
                "matricula = @matricula, " +
                "senha = @senha, " +
                "grupo = @grupo, " +
                "motorista = @motorista, " +
                "validade_motorista = @validade_motorista, " +
                "observacao = @observacao, " +
                "telefone = @telefone, " +
                "email = @email, " +
                "endereco_id = @endereco_id, " +
                "numero = @numero, " +
                "complemento = @complemento " +
                "WHERE id_funcionario = @id;";
            //executa o comando no banco de dados
            _ = connections.comando.ExecuteNonQuery();
        }

        public void Excluir(Funcionario funcionario)
        {
            ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

            var id = connections.comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = funcionario.Id;
            connections.comando.Parameters.Add(id);
            connections.conexao.Open();
            //realiza o DELETE
            connections.comando.CommandText = @"DELETE FROM tb_funcionarios WHERE id_funcionario = @id;";
            //executa o comando no banco de dados
            _ = connections.comando.ExecuteNonQuery();
        }

    }
}
