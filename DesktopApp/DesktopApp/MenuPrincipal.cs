using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MenuPrincipal : Form
    {
        //Campos
        private Button botaoAtual;
        private Random aleatorio;
        private int tempIndice;
        private Form activeForm;

        //Construtor
        public MenuPrincipal()
        {
            InitializeComponent();
            aleatorio = new Random();
        }

        //Metodos
        private Color SelecionarTemaDeCor()
        {
            int indice = aleatorio.Next(TemasDeCores.ListaDeCores.Count);
            while(tempIndice == indice)
            {
                indice = aleatorio.Next(TemasDeCores.ListaDeCores.Count);
            }
            tempIndice = indice;
            string cor = TemasDeCores.ListaDeCores[indice];
            return ColorTranslator.FromHtml(cor);
        }

        private void AtivarBotao(object btnEnviar)
        {
            if (btnEnviar != null)
            {
                if (botaoAtual != (Button)btnEnviar)
                {
                    DesabilitarBotao();
                    Color cor = SelecionarTemaDeCor();
                    botaoAtual = (Button)btnEnviar;
                    botaoAtual.BackColor = cor;
                    botaoAtual.ForeColor = Color.White;
                    botaoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelBarraTitulo.BackColor = cor;
                    panelLogo.BackColor = TemasDeCores.AlterarBrilho(cor, -0.4);
                    TemasDeCores.CorPrimaria = cor;
                    TemasDeCores.CorSecundaria = TemasDeCores.AlterarBrilho(cor, -0.4);
                }
            }
        }

        private void DesabilitarBotao()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            AtivarBotao(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormColaboradores(),sender);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmpresas(), sender);
        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCandidatos(), sender);
        }
    }
}
