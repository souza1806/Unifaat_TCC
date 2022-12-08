using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class FormMenuPrincipal : Form
    {
        //Campos
        private Button botaoAtual;
        private Random aleatorio;
        public int tempIndice;
        private Form activeForm;

        //Construtor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            aleatorio = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


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
                    btnCloseChildForm.Visible = true;
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
            //OpenChildForm(new Forms.FormCadastroColaborador(), sender);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmpresas(), sender);
        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCandidatos(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DesabilitarBotao();
            lblTitulo.Text = "HOME";
            panelBarraTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            botaoAtual = null;
            btnCloseChildForm.Visible = false;

        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
