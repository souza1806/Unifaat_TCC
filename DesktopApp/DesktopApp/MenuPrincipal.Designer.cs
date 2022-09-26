﻿namespace DesktopApp
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCandidatos = new System.Windows.Forms.Button();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnCandidatos);
            this.panelMenu.Controls.Add(this.btnEmpresas);
            this.panelMenu.Controls.Add(this.btnColaboradores);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 589);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCandidatos.FlatAppearance.BorderSize = 0;
            this.btnCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCandidatos.Image = ((System.Drawing.Image)(resources.GetObject("btnCandidatos.Image")));
            this.btnCandidatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidatos.Location = new System.Drawing.Point(0, 200);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCandidatos.Size = new System.Drawing.Size(220, 60);
            this.btnCandidatos.TabIndex = 3;
            this.btnCandidatos.Text = "   Candidatos";
            this.btnCandidatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCandidatos.UseVisualStyleBackColor = true;
            this.btnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpresas.FlatAppearance.BorderSize = 0;
            this.btnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpresas.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresas.Image")));
            this.btnEmpresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresas.Location = new System.Drawing.Point(0, 140);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmpresas.Size = new System.Drawing.Size(220, 60);
            this.btnEmpresas.TabIndex = 2;
            this.btnEmpresas.Text = "   Empresas";
            this.btnEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpresas.UseVisualStyleBackColor = true;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColaboradores.FlatAppearance.BorderSize = 0;
            this.btnColaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColaboradores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnColaboradores.Image = ((System.Drawing.Image)(resources.GetObject("btnColaboradores.Image")));
            this.btnColaboradores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.Location = new System.Drawing.Point(0, 80);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnColaboradores.Size = new System.Drawing.Size(220, 60);
            this.btnColaboradores.TabIndex = 1;
            this.btnColaboradores.Text = "   Colaboradores";
            this.btnColaboradores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColaboradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnColaboradores.UseVisualStyleBackColor = true;
            this.btnColaboradores.Click += new System.EventHandler(this.btnColaboradores_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBarraTitulo.Controls.Add(this.lblTitulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(804, 80);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(359, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SGRH";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(804, 509);
            this.panelDesktop.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 589);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCandidatos;
        private System.Windows.Forms.Button btnEmpresas;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

