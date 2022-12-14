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
    public partial class FormCandidatos : Form
    {
        public FormCandidatos()
        {
            InitializeComponent();
        }

        private void FormCandidatos_Load(object sender, EventArgs e)
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
            label1.ForeColor = TemasDeCores.CorPrimaria;
        }

    }
}
