namespace IFSPStore.App.Cadastros
{
    partial class CadastroUsuario
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
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataCadastro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chkAtivo = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            tabControlCadastro.Size = new Size(629, 332);
            tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(chkAtivo);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtDataCadastro);
            tabPageCadastro.Controls.Add(txtDataLogin);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtLogin);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(621, 297);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSenha, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCadastro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(chkAtivo, 0);
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.fingerprint;
            txtSenha.Location = new Point(416, 60);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(177, 48);
            txtSenha.TabIndex = 2;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.Hint = "Login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(14, 60);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(380, 48);
            txtLogin.TabIndex = 1;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // txtDataLogin
            // 
            txtDataLogin.AnimateReadOnly = false;
            txtDataLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtDataLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtDataLogin.BackgroundImageLayout = ImageLayout.None;
            txtDataLogin.CharacterCasing = CharacterCasing.Normal;
            txtDataLogin.Depth = 0;
            txtDataLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataLogin.HideSelection = true;
            txtDataLogin.Hint = "Data de Último Login";
            txtDataLogin.LeadingIcon = null;
            txtDataLogin.Location = new Point(325, 168);
            txtDataLogin.MaxLength = 32767;
            txtDataLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataLogin.Name = "txtDataLogin";
            txtDataLogin.PasswordChar = '\0';
            txtDataLogin.PrefixSuffixText = null;
            txtDataLogin.ReadOnly = true;
            txtDataLogin.RightToLeft = RightToLeft.No;
            txtDataLogin.SelectedText = "";
            txtDataLogin.SelectionLength = 0;
            txtDataLogin.SelectionStart = 0;
            txtDataLogin.ShortcutsEnabled = true;
            txtDataLogin.Size = new Size(268, 48);
            txtDataLogin.TabIndex = 5;
            txtDataLogin.TabStop = false;
            txtDataLogin.TextAlign = HorizontalAlignment.Left;
            txtDataLogin.TrailingIcon = null;
            txtDataLogin.UseSystemPasswordChar = false;
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.AnimateReadOnly = false;
            txtDataCadastro.AutoCompleteMode = AutoCompleteMode.None;
            txtDataCadastro.AutoCompleteSource = AutoCompleteSource.None;
            txtDataCadastro.BackgroundImageLayout = ImageLayout.None;
            txtDataCadastro.CharacterCasing = CharacterCasing.Normal;
            txtDataCadastro.Depth = 0;
            txtDataCadastro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCadastro.HideSelection = true;
            txtDataCadastro.Hint = "Data de Cadastro";
            txtDataCadastro.LeadingIcon = null;
            txtDataCadastro.Location = new Point(14, 168);
            txtDataCadastro.MaxLength = 32767;
            txtDataCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.PasswordChar = '\0';
            txtDataCadastro.PrefixSuffixText = null;
            txtDataCadastro.ReadOnly = true;
            txtDataCadastro.RightToLeft = RightToLeft.No;
            txtDataCadastro.SelectedText = "";
            txtDataCadastro.SelectionLength = 0;
            txtDataCadastro.SelectionStart = 0;
            txtDataCadastro.ShortcutsEnabled = true;
            txtDataCadastro.Size = new Size(268, 48);
            txtDataCadastro.TabIndex = 4;
            txtDataCadastro.TabStop = false;
            txtDataCadastro.TextAlign = HorizontalAlignment.Left;
            txtDataCadastro.TrailingIcon = null;
            txtDataCadastro.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(14, 114);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(380, 48);
            txtEmail.TabIndex = 3;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(504, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(89, 48);
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Depth = 0;
            chkAtivo.Location = new Point(447, 114);
            chkAtivo.Margin = new Padding(0);
            chkAtivo.MouseLocation = new Point(-1, -1);
            chkAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkAtivo.Name = "chkAtivo";
            chkAtivo.ReadOnly = false;
            chkAtivo.Ripple = true;
            chkAtivo.Size = new Size(129, 37);
            chkAtivo.TabIndex = 12;
            chkAtivo.Text = "Usuário Ativo";
            chkAtivo.UseAccentColor = false;
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(14, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(484, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 399);
            Location = new Point(0, 0);
            Name = "CadastroUsuario";
            Text = "Cadastro de Usuários";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDataCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialCheckBox chkAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}