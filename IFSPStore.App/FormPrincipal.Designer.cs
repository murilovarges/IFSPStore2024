namespace IFSPStore.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            grupoDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(794, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, toolStripMenuItem1, grupoDeProdutoToolStripMenuItem, produtoToolStripMenuItem, toolStripMenuItem2, cidadeToolStripMenuItem, clienteToolStripMenuItem, toolStripMenuItem3, vendaToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(224, 26);
            usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // grupoDeProdutoToolStripMenuItem
            // 
            grupoDeProdutoToolStripMenuItem.Name = "grupoDeProdutoToolStripMenuItem";
            grupoDeProdutoToolStripMenuItem.Size = new Size(224, 26);
            grupoDeProdutoToolStripMenuItem.Text = "Grupo de produto";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(224, 26);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(224, 26);
            cidadeToolStripMenuItem.Text = "Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(221, 6);
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(224, 26);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormPrincipal";
            Text = "Sistema IFSP Store";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem grupoDeProdutoToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem vendaToolStripMenuItem;
    }
}
