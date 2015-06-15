namespace OficinaEF
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nascimentoTextBox = new System.Windows.Forms.TextBox();
            this.inserirButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.pesquisarPorCodigoButton = new System.Windows.Forms.Button();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.listarTodosVeiculosPorClienteButton = new System.Windows.Forms.Button();
            this.veiculosDoClienteButton = new System.Windows.Forms.Button();
            this.dadosListBox = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // codigoLabel
            // 
            this.codigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.Location = new System.Drawing.Point(95, 21);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(60, 20);
            this.codigoLabel.TabIndex = 1;
            this.codigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nascimento:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(95, 52);
            this.nomeTextBox.MaxLength = 40;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(201, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 78);
            this.emailTextBox.MaxLength = 40;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // nascimentoTextBox
            // 
            this.nascimentoTextBox.Location = new System.Drawing.Point(95, 104);
            this.nascimentoTextBox.MaxLength = 10;
            this.nascimentoTextBox.Name = "nascimentoTextBox";
            this.nascimentoTextBox.Size = new System.Drawing.Size(201, 20);
            this.nascimentoTextBox.TabIndex = 7;
            this.nascimentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inserirButton
            // 
            this.inserirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserirButton.Location = new System.Drawing.Point(15, 154);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(281, 23);
            this.inserirButton.TabIndex = 8;
            this.inserirButton.Text = "&Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarButton.Location = new System.Drawing.Point(15, 183);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(281, 23);
            this.atualizarButton.TabIndex = 9;
            this.atualizarButton.Text = "&Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.atualizarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirButton.Location = new System.Drawing.Point(15, 212);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(281, 23);
            this.excluirButton.TabIndex = 10;
            this.excluirButton.Text = "&Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // pesquisarPorCodigoButton
            // 
            this.pesquisarPorCodigoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarPorCodigoButton.Location = new System.Drawing.Point(15, 241);
            this.pesquisarPorCodigoButton.Name = "pesquisarPorCodigoButton";
            this.pesquisarPorCodigoButton.Size = new System.Drawing.Size(217, 23);
            this.pesquisarPorCodigoButton.TabIndex = 11;
            this.pesquisarPorCodigoButton.Text = "Pesquisar por Código";
            this.pesquisarPorCodigoButton.UseVisualStyleBackColor = true;
            this.pesquisarPorCodigoButton.Click += new System.EventHandler(this.pesquisarPorCodigoButton_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoTextBox.Location = new System.Drawing.Point(238, 242);
            this.codigoTextBox.MaxLength = 4;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(58, 22);
            this.codigoTextBox.TabIndex = 12;
            this.codigoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listarTodosVeiculosPorClienteButton
            // 
            this.listarTodosVeiculosPorClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarTodosVeiculosPorClienteButton.Location = new System.Drawing.Point(15, 268);
            this.listarTodosVeiculosPorClienteButton.Name = "listarTodosVeiculosPorClienteButton";
            this.listarTodosVeiculosPorClienteButton.Size = new System.Drawing.Size(281, 23);
            this.listarTodosVeiculosPorClienteButton.TabIndex = 13;
            this.listarTodosVeiculosPorClienteButton.Text = "Listar Todos os Veículos por Cliente";
            this.listarTodosVeiculosPorClienteButton.UseVisualStyleBackColor = true;
            this.listarTodosVeiculosPorClienteButton.Click += new System.EventHandler(this.listarTodosVeiculosPorClienteButton_Click);
            // 
            // veiculosDoClienteButton
            // 
            this.veiculosDoClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculosDoClienteButton.Location = new System.Drawing.Point(161, 20);
            this.veiculosDoClienteButton.Name = "veiculosDoClienteButton";
            this.veiculosDoClienteButton.Size = new System.Drawing.Size(135, 23);
            this.veiculosDoClienteButton.TabIndex = 14;
            this.veiculosDoClienteButton.Text = "Veículos do Cliente";
            this.veiculosDoClienteButton.UseVisualStyleBackColor = true;
            this.veiculosDoClienteButton.Click += new System.EventHandler(this.veiculosDoClienteButton_Click);
            // 
            // dadosListBox
            // 
            this.dadosListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosListBox.FormattingEnabled = true;
            this.dadosListBox.ItemHeight = 14;
            this.dadosListBox.Location = new System.Drawing.Point(302, 21);
            this.dadosListBox.Name = "dadosListBox";
            this.dadosListBox.Size = new System.Drawing.Size(295, 270);
            this.dadosListBox.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AcceptButton = this.veiculosDoClienteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 308);
            this.Controls.Add(this.dadosListBox);
            this.Controls.Add(this.veiculosDoClienteButton);
            this.Controls.Add(this.listarTodosVeiculosPorClienteButton);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.pesquisarPorCodigoButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.atualizarButton);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.nascimentoTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oficina - EF";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nascimentoTextBox;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button pesquisarPorCodigoButton;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Button listarTodosVeiculosPorClienteButton;
        private System.Windows.Forms.Button veiculosDoClienteButton;
        private System.Windows.Forms.ListBox dadosListBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}

