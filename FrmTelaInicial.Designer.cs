
namespace CatAsService
{
    partial class FrmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarRaçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CatAsService.Properties.Resources._16_client_cat_icon_icons_com_76692;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(83, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem vindo ao Cat as Service";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRaçasToolStripMenuItem,
            this.meusFavoritosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            this.buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            this.buscarRaçasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            this.buscarRaçasToolStripMenuItem.Click += new System.EventHandler(this.buscarRaçasToolStripMenuItem_Click);
            // 
            // meusFavoritosToolStripMenuItem
            // 
            this.meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            this.meusFavoritosToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            this.meusFavoritosToolStripMenuItem.Click += new System.EventHandler(this.meusFavoritosToolStripMenuItem_Click);
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaInicial";
            this.Text = "Bem vindo ao Cat As Service";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusFavoritosToolStripMenuItem;
    }
}