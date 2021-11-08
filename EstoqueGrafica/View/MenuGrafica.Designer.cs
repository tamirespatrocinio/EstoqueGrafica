
namespace EstoqueGrafica.View
{
    partial class MenuGrafica
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
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageCadastrar = new System.Windows.Forms.TabPage();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tabPageBuscar = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.DataGridViewCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAlterar = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tabControlMenu.SuspendLayout();
            this.tabPageCadastrar.SuspendLayout();
            this.tabPageBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.tabPageAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageCadastrar);
            this.tabControlMenu.Controls.Add(this.tabPageBuscar);
            this.tabControlMenu.Controls.Add(this.tabPageAlterar);
            this.tabControlMenu.Location = new System.Drawing.Point(137, 111);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(752, 406);
            this.tabControlMenu.TabIndex = 0;
            this.tabControlMenu.UseWaitCursor = true;
            // 
            // tabPageCadastrar
            // 
            this.tabPageCadastrar.BackColor = System.Drawing.Color.White;
            this.tabPageCadastrar.Controls.Add(this.textBoxValor);
            this.tabPageCadastrar.Controls.Add(this.textBoxQtd);
            this.tabPageCadastrar.Controls.Add(this.textBoxDescricao);
            this.tabPageCadastrar.Controls.Add(this.textBoxProduto);
            this.tabPageCadastrar.Controls.Add(this.label1);
            this.tabPageCadastrar.Controls.Add(this.label2);
            this.tabPageCadastrar.Controls.Add(this.label3);
            this.tabPageCadastrar.Controls.Add(this.label4);
            this.tabPageCadastrar.Controls.Add(this.btnCadastrar);
            this.tabPageCadastrar.Location = new System.Drawing.Point(4, 30);
            this.tabPageCadastrar.Name = "tabPageCadastrar";
            this.tabPageCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastrar.Size = new System.Drawing.Size(744, 372);
            this.tabPageCadastrar.TabIndex = 2;
            this.tabPageCadastrar.Text = "Cadastrar Produto";
            this.tabPageCadastrar.UseWaitCursor = true;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(214, 241);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 29);
            this.textBoxValor.TabIndex = 19;
            this.textBoxValor.UseWaitCursor = true;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(214, 180);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(100, 29);
            this.textBoxQtd.TabIndex = 18;
            this.textBoxQtd.UseWaitCursor = true;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(214, 124);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(401, 29);
            this.textBoxDescricao.TabIndex = 17;
            this.textBoxDescricao.UseWaitCursor = true;
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(214, 67);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(401, 29);
            this.textBoxProduto.TabIndex = 16;
            this.textBoxProduto.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(140, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Preço:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(154, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Qtd:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(115, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(126, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Produto:";
            this.label4.UseWaitCursor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Teal;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(509, 262);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 32);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.UseWaitCursor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tabPageBuscar
            // 
            this.tabPageBuscar.BackColor = System.Drawing.Color.Teal;
            this.tabPageBuscar.Controls.Add(this.btnBuscar);
            this.tabPageBuscar.Controls.Add(this.textBoxBuscar);
            this.tabPageBuscar.Controls.Add(this.dataGridViewMenu);
            this.tabPageBuscar.Location = new System.Drawing.Point(4, 30);
            this.tabPageBuscar.Name = "tabPageBuscar";
            this.tabPageBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscar.Size = new System.Drawing.Size(744, 372);
            this.tabPageBuscar.TabIndex = 0;
            this.tabPageBuscar.Text = "Buscar Produto";
            this.tabPageBuscar.UseWaitCursor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(533, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.UseWaitCursor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(94, 66);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(433, 29);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.UseWaitCursor = true;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCodigo,
            this.DataGridViewProduto,
            this.DataGridViewDescricao,
            this.DataGridViewQuantidade,
            this.DataGridViewValor});
            this.dataGridViewMenu.Location = new System.Drawing.Point(94, 113);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowTemplate.Height = 25;
            this.dataGridViewMenu.Size = new System.Drawing.Size(543, 238);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.UseWaitCursor = true;
            // 
            // DataGridViewCodigo
            // 
            this.DataGridViewCodigo.HeaderText = "Código";
            this.DataGridViewCodigo.Name = "DataGridViewCodigo";
            // 
            // DataGridViewProduto
            // 
            this.DataGridViewProduto.HeaderText = "Produto";
            this.DataGridViewProduto.Name = "DataGridViewProduto";
            // 
            // DataGridViewDescricao
            // 
            this.DataGridViewDescricao.HeaderText = "Descrição";
            this.DataGridViewDescricao.Name = "DataGridViewDescricao";
            this.DataGridViewDescricao.Width = 200;
            // 
            // DataGridViewQuantidade
            // 
            this.DataGridViewQuantidade.HeaderText = "Qtd";
            this.DataGridViewQuantidade.Name = "DataGridViewQuantidade";
            this.DataGridViewQuantidade.Width = 50;
            // 
            // DataGridViewValor
            // 
            this.DataGridViewValor.HeaderText = "Preço";
            this.DataGridViewValor.Name = "DataGridViewValor";
            this.DataGridViewValor.Width = 50;
            // 
            // tabPageAlterar
            // 
            this.tabPageAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPageAlterar.Controls.Add(this.btnPesquisar);
            this.tabPageAlterar.Controls.Add(this.tbValor);
            this.tabPageAlterar.Controls.Add(this.tbQtd);
            this.tabPageAlterar.Controls.Add(this.tbDescricao);
            this.tabPageAlterar.Controls.Add(this.tbProduto);
            this.tabPageAlterar.Controls.Add(this.tbCodigo);
            this.tabPageAlterar.Controls.Add(this.lblValor);
            this.tabPageAlterar.Controls.Add(this.lblQtd);
            this.tabPageAlterar.Controls.Add(this.lblDescricao);
            this.tabPageAlterar.Controls.Add(this.lblProduto);
            this.tabPageAlterar.Controls.Add(this.lblCodigo);
            this.tabPageAlterar.Controls.Add(this.btnDeletar);
            this.tabPageAlterar.Controls.Add(this.btnAlterar);
            this.tabPageAlterar.ForeColor = System.Drawing.Color.Teal;
            this.tabPageAlterar.Location = new System.Drawing.Point(4, 30);
            this.tabPageAlterar.Name = "tabPageAlterar";
            this.tabPageAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlterar.Size = new System.Drawing.Size(744, 372);
            this.tabPageAlterar.TabIndex = 1;
            this.tabPageAlterar.Text = "Alterar Estoque";
            this.tabPageAlterar.UseWaitCursor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(268, 68);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 36);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.UseWaitCursor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(186, 255);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(67, 29);
            this.tbValor.TabIndex = 11;
            this.tbValor.UseWaitCursor = true;
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(186, 208);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(67, 29);
            this.tbQtd.TabIndex = 10;
            this.tbQtd.UseWaitCursor = true;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(186, 161);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(449, 29);
            this.tbDescricao.TabIndex = 9;
            this.tbDescricao.UseWaitCursor = true;
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(186, 117);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(449, 29);
            this.tbProduto.TabIndex = 8;
            this.tbProduto.UseWaitCursor = true;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(186, 73);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(67, 29);
            this.tbCodigo.TabIndex = 7;
            this.tbCodigo.UseWaitCursor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(128, 258);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 21);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Preço:";
            this.lblValor.UseWaitCursor = true;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQtd.Location = new System.Drawing.Point(141, 211);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(42, 21);
            this.lblQtd.TabIndex = 5;
            this.lblQtd.Text = "Qtd:";
            this.lblQtd.UseWaitCursor = true;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(100, 164);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(85, 21);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.UseWaitCursor = true;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.Location = new System.Drawing.Point(111, 120);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(74, 21);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produto:";
            this.lblProduto.UseWaitCursor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.Location = new System.Drawing.Point(117, 76);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 21);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseWaitCursor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(528, 311);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(107, 36);
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.UseWaitCursor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Teal;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(410, 311);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 36);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.UseWaitCursor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // MenuGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.tabControlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuGrafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageCadastrar.ResumeLayout(false);
            this.tabPageCadastrar.PerformLayout();
            this.tabPageBuscar.ResumeLayout(false);
            this.tabPageBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.tabPageAlterar.ResumeLayout(false);
            this.tabPageAlterar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.TabPage tabPageAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TabPage tabPageCadastrar;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewValor;
    }
}