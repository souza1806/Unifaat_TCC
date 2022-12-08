using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DesktopApp.Model
{
    internal class Colaborador
	{
        public int ColaboradorId { get; set; }
		public string EmpresaId { get; set; }
		public string NomeCompleto { get; set; }
		public string CPF { get; set; }
		public string DataNascimento { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Cargo { get; set; }
		public float Salario { get; set; }
		public string Cep { get; set; }
		public string Uf { get; set; }
		public string Cidade { get; set; }
		public string Endereco { get; set; }
		public string Numero { get; set; }
		public string Bairro { get; set; }
		public string Complemento { get; set; }
		public string DataAdmissao { get; set; }
		public string DataDemissao { get; set; }

        Conexao con = new Conexao();
        public bool Gravar(Colaborador colaborador)
        {
            string sql = $"insert into colaborador (empresa_id, nome_completo, CPF, data_nascimento, telefone, email, cargo, salario, cep, uf, cidade, endereco, numero, bairro," +
                $"complemento, data_admissao, data_demissao) values('{colaborador.EmpresaId}', '{colaborador.NomeCompleto}', '{colaborador.CPF}'" +
                $", '{colaborador.DataNascimento}', '{colaborador.Telefone}', '{colaborador.Email}', '{colaborador.Cargo}'" +
                $", '{colaborador.Salario}', '{colaborador.Cep}', '{colaborador.Uf}', '{colaborador.Cidade}', '{colaborador.Endereco}', '{colaborador.Numero}'" +
                $", '{colaborador.Bairro}', '{colaborador.Complemento}', '{colaborador.DataAdmissao}', '{colaborador.DataDemissao}');";
            return con.Executa(sql);
        }

        public bool Atualizar()
        {
            string sql = $"update colaborador set empresa_id='{EmpresaId}', nome_completo='{NomeCompleto}', CPF = '{CPF}', data_nascimento='{DataNascimento}', telefone='{Telefone}'" +
                $", email='{Email}', cargo='{Cargo}', salario='{Salario}', cep='{Cep}', uf='{Uf}', cidade='{Cidade}', endereco='{Endereco}', numero='{Numero}'" +
                $", bairro='{Bairro}', complemento='{Complemento}', data_admissao='{DataAdmissao}', data_demissao='{DataDemissao}' where colaborador_id={ColaboradorId};";
            return con.Executa(sql);
        }

        public bool Excluir()
        {
            string sql = $"delete from colaborador where colaborador_id={ColaboradorId};";
            return con.Executa(sql);
        }

        public DataTable PesquisaTodos()
        {
            try
            {
                //string sql = "select * from colaborador;";
                string sql = "select colaborador_id, nome_completo, empresa_id from colaborador;";
                DataTable dt = new DataTable();
                dt = con.Retorna(sql);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Pesquisar()
        {
            string sql = $"select * from colaborador where colaborador_id={ColaboradorId};";
            DataTable dt = new DataTable();
            dt = con.Retorna(sql);
            if (dt.Rows.Count > 0)
            {
                EmpresaId = dt.Rows[0]["empresa_id"].ToString();
                NomeCompleto = dt.Rows[0]["nome_completo"].ToString();
                CPF = dt.Rows[0]["CPF"].ToString();
                DataNascimento = dt.Rows[0]["data_nascimento"].ToString();
                Telefone = dt.Rows[0]["telefone"].ToString();
                Email = dt.Rows[0]["email"].ToString();
                Cargo = dt.Rows[0]["cargo"].ToString();
                Salario = (float)dt.Rows[0]["salario"];
                Cep = dt.Rows[0]["cep"].ToString();
                Uf = dt.Rows[0]["uf"].ToString();
                Cidade = dt.Rows[0]["cidade"].ToString();
                Endereco = dt.Rows[0]["endereco"].ToString();
                Numero = dt.Rows[0]["numero"].ToString();
                Bairro = dt.Rows[0]["bairro"].ToString();
                Complemento = dt.Rows[0]["complemento"].ToString();
                DataAdmissao = dt.Rows[0]["data_admissao"].ToString();
                DataDemissao = dt.Rows[0]["data_demissao"].ToString();
            }
            else
            {
                ColaboradorId = 0;
            }
        }
    }
}
