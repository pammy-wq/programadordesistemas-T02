namespace CadastroCliente
{
    partial class Form1
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
            lblCadastroCliente = new Label();
            txtNome = new TextBox();
            lblNomeCompleto = new Label();
            lbID = new Label();
            txtID = new TextBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            lblCPF = new Label();
            txtCPF = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnCadastrarCliente = new Button();
            SuspendLayout();
            // 
            // lblCadastroCliente
            // 
            lblCadastroCliente.AutoSize = true;
            lblCadastroCliente.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroCliente.Location = new Point(104, 45);
            lblCadastroCliente.Name = "lblCadastroCliente";
            lblCadastroCliente.Size = new Size(176, 30);
            lblCadastroCliente.TabIndex = 0;
            lblCadastroCliente.Text = "Cadastrar Cliente";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 108);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(376, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(12, 90);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(12, 147);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 3;
            lbID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 165);
            txtID.Name = "txtID";
            txtID.Size = new Size(157, 23);
            txtID.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(215, 165);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 23);
            txtTelefone.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(216, 147);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(17, 205);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 7;
            lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 223);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(364, 23);
            txtCPF.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(17, 263);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 281);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(106, 322);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(174, 23);
            btnCadastrarCliente.TabIndex = 11;
            btnCadastrarCliente.Text = "Cadastrar Clientes";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Controls.Add(lblNomeCompleto);
            Controls.Add(txtNome);
            Controls.Add(lblCadastroCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroCliente;
        private TextBox txtNome;
        private Label lblNomeCompleto;
        private Label lbID;
        private TextBox txtID;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnCadastrarCliente;
    }
}
