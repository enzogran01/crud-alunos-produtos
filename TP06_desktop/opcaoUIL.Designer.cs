namespace TP06_desktop
{
    partial class opcaoUIL
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
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem1,
            this.cadastroDeProfessorToolStripMenuItem});
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Opções";
            this.cadastroDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem_Click);
            // 
            // cadastroDeAlunosToolStripMenuItem1
            // 
            this.cadastroDeAlunosToolStripMenuItem1.Name = "cadastroDeAlunosToolStripMenuItem1";
            this.cadastroDeAlunosToolStripMenuItem1.Size = new System.Drawing.Size(229, 26);
            this.cadastroDeAlunosToolStripMenuItem1.Text = "Cadastro de Aluno";
            this.cadastroDeAlunosToolStripMenuItem1.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem1_Click);
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Produto";
            this.cadastroDeProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProfessorToolStripMenuItem_Click);
            // 
            // opcaoUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 167);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "opcaoUIL";
            this.Text = "Escolha uma opção";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.opcaoUIL_FormClosing);
            this.Load += new System.EventHandler(this.opcaoUIL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProfessorToolStripMenuItem;
    }
}

