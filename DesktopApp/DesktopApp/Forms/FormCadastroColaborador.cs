using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class FormCadastroColaborador : Form
    {
        public FormCadastroColaborador()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.NomeCompleto = txtNome.Text;
            colaborador.EmpresaId = txtEmpresa.Text;
            colaborador.CPF = txtCpf.Text;
            colaborador.DataNascimento = txtNascimento.Text;
            colaborador.Telefone = txtTelefone.Text;
            colaborador.Email = txtEmail.Text;
            colaborador.Cargo = txtCargo.Text;
            colaborador.Salario = float.Parse(txtSalario.Text);
            colaborador.Cep = txtCep.Text;
            colaborador.Uf = txtUf.Text;
            colaborador.Cidade = txtCidade.Text;
            colaborador.Endereco = txtEndereco.Text;
            colaborador.Numero = txtNumero.Text;
            colaborador.Bairro = txtBairro.Text;
            colaborador.Complemento = txtComplemento.Text;
            colaborador.DataAdmissao = txtDataAdmissao.Text;
            colaborador.DataDemissao = txtDataDemissao.Text;

            bool result = colaborador.Gravar(colaborador);

            if (result)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
            } else
            {
                MessageBox.Show("Cadastro falhou!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
