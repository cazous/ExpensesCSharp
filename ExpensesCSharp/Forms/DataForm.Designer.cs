namespace ExpensesCSharp.Forms
{
    partial class DataForm
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tabelaDataForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDataForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDataFormAtualizar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataForm)).BeginInit();
            this.contextMenuStripDataForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(1037, 23);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(1037, 52);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(160, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(821, 23);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(75, 13);
            this.lblPagamento.TabIndex = 16;
            this.lblPagamento.Text = "PAGAMENTO";
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "Débito",
            "Cartão de Crédito",
            "PIX"});
            this.cmbPagamento.Location = new System.Drawing.Point(821, 52);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(183, 21);
            this.cmbPagamento.TabIndex = 15;
            this.cmbPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(243, 23);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 13);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(243, 53);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(548, 20);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 23);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "DATA";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(15, 54);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(212, 20);
            this.dtpData.TabIndex = 11;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // tabelaDataForm
            // 
            this.tabelaDataForm.AllowUserToAddRows = false;
            this.tabelaDataForm.AllowUserToDeleteRows = false;
            this.tabelaDataForm.AllowUserToResizeColumns = false;
            this.tabelaDataForm.AllowUserToResizeRows = false;
            this.tabelaDataForm.BackgroundColor = System.Drawing.Color.White;
            this.tabelaDataForm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabelaDataForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDataForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Data,
            this.Descrição,
            this.Pagamento,
            this.Valor});
            this.tabelaDataForm.ContextMenuStrip = this.contextMenuStripDataForm;
            this.tabelaDataForm.GridColor = System.Drawing.Color.White;
            this.tabelaDataForm.Location = new System.Drawing.Point(6, 121);
            this.tabelaDataForm.MultiSelect = false;
            this.tabelaDataForm.Name = "tabelaDataForm";
            this.tabelaDataForm.RowHeadersVisible = false;
            this.tabelaDataForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaDataForm.Size = new System.Drawing.Size(1203, 531);
            this.tabelaDataForm.TabIndex = 19;
            this.tabelaDataForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaDataForm_CellContentClick);
            // 
            // contextMenuStripDataForm
            // 
            this.contextMenuStripDataForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEditar,
            this.ctxExcluir});
            this.contextMenuStripDataForm.Name = "contextMenuStripDataForm";
            this.contextMenuStripDataForm.Size = new System.Drawing.Size(110, 48);
            // 
            // ctxEditar
            // 
            this.ctxEditar.Name = "ctxEditar";
            this.ctxEditar.Size = new System.Drawing.Size(109, 22);
            this.ctxEditar.Text = "Editar";
            this.ctxEditar.Click += new System.EventHandler(this.ctxEditar_Click);
            // 
            // ctxExcluir
            // 
            this.ctxExcluir.Name = "ctxExcluir";
            this.ctxExcluir.Size = new System.Drawing.Size(109, 22);
            this.ctxExcluir.Text = "Excluir";
            this.ctxExcluir.Click += new System.EventHandler(this.ctxExcluir_Click);
            // 
            // btnDataFormAtualizar
            // 
            this.btnDataFormAtualizar.Location = new System.Drawing.Point(1152, 92);
            this.btnDataFormAtualizar.Name = "btnDataFormAtualizar";
            this.btnDataFormAtualizar.Size = new System.Drawing.Size(49, 23);
            this.btnDataFormAtualizar.TabIndex = 20;
            this.btnDataFormAtualizar.Text = "Att";
            this.btnDataFormAtualizar.UseVisualStyleBackColor = true;
            this.btnDataFormAtualizar.Click += new System.EventHandler(this.btnDataFormAtualizar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 250;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descrição.Width = 590;
            // 
            // Pagamento
            // 
            this.Pagamento.DataPropertyName = "pagamento";
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pagamento.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 160;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1213, 654);
            this.Controls.Add(this.btnDataFormAtualizar);
            this.Controls.Add(this.tabelaDataForm);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataForm)).EndInit();
            this.contextMenuStripDataForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView tabelaDataForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataForm;
        private System.Windows.Forms.ToolStripMenuItem ctxEditar;
        private System.Windows.Forms.ToolStripMenuItem ctxExcluir;
        private System.Windows.Forms.Button btnDataFormAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}