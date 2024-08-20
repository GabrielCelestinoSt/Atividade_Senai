namespace atividade
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descubraOMaiorEMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualSeuPesoNoEspaçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBrasileirâo2012ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descubraOMaiorEMenorToolStripMenuItem,
            this.qualSeuPesoNoEspaçoToolStripMenuItem,
            this.tabelaBrasileirâo2012ToolStripMenuItem});
            this.atividadesToolStripMenuItem.Image = global::atividade.Properties.Resources.logo_cptm_novo_vert_removebg_preview;
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // descubraOMaiorEMenorToolStripMenuItem
            // 
            this.descubraOMaiorEMenorToolStripMenuItem.Image = global::atividade.Properties.Resources._4043274_avatar_einstein_professor_scientist_icon;
            this.descubraOMaiorEMenorToolStripMenuItem.Name = "descubraOMaiorEMenorToolStripMenuItem";
            this.descubraOMaiorEMenorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.descubraOMaiorEMenorToolStripMenuItem.Text = "Descubra o Maior e Menor";
            this.descubraOMaiorEMenorToolStripMenuItem.Click += new System.EventHandler(this.descubraOMaiorEMenorToolStripMenuItem_Click);
            // 
            // qualSeuPesoNoEspaçoToolStripMenuItem
            // 
            this.qualSeuPesoNoEspaçoToolStripMenuItem.Image = global::atividade.Properties.Resources._3441000_astronomy_planet_rings_saturn_science_icon;
            this.qualSeuPesoNoEspaçoToolStripMenuItem.Name = "qualSeuPesoNoEspaçoToolStripMenuItem";
            this.qualSeuPesoNoEspaçoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.qualSeuPesoNoEspaçoToolStripMenuItem.Text = "Qual seu peso no Espaço?";
            this.qualSeuPesoNoEspaçoToolStripMenuItem.Click += new System.EventHandler(this.qualSeuPesoNoEspaçoToolStripMenuItem_Click);
            // 
            // tabelaBrasileirâo2012ToolStripMenuItem
            // 
            this.tabelaBrasileirâo2012ToolStripMenuItem.Image = global::atividade.Properties.Resources._300768_ball_soccer_sport_icon;
            this.tabelaBrasileirâo2012ToolStripMenuItem.Name = "tabelaBrasileirâo2012ToolStripMenuItem";
            this.tabelaBrasileirâo2012ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tabelaBrasileirâo2012ToolStripMenuItem.Text = "Tabela Brasileirâo 2012";
            this.tabelaBrasileirâo2012ToolStripMenuItem.Click += new System.EventHandler(this.tabelaBrasileirâo2012ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 123);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(526, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 72);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bem Vindos!\r\nEspero que vocês aproveitem \r\ntodas as funções que nosso \r\nprograma " +
    "fornece. (todas as 3).      ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::atividade.Properties.Resources.estacao_da_luz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descubraOMaiorEMenorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualSeuPesoNoEspaçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBrasileirâo2012ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}