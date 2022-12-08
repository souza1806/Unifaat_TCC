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
    public partial class FormColaboradores : Form
    {
        public FormColaboradores()
        {
            InitializeComponent();
        }

        private void FormColaboradores_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = TemasDeCores.CorPrimaria;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = TemasDeCores.CorSecundaria;
                }
            }
            //label1.ForeColor = TemasDeCores.CorPrimaria;
        }

        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FormCadastroColaborador().Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Colaborador colaborador = new Colaborador();
            lstColaboradores.Items.Clear();
            dt = colaborador.PesquisaTodos();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());

                lstColaboradores.Items.Add(item);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda será implementado!");
        }
    }
}
