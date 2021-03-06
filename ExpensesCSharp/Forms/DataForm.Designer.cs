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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDataForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIdGasto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDataForm)).BeginInit();
            this.contextMenuStripDataForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(1035, 28);
            this.lblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(51, 16);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "VALOR";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(1038, 64);
            this.txtValor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(161, 23);
            this.txtValor.TabIndex = 17;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.ForeColor = System.Drawing.Color.White;
            this.lblPagamento.Location = new System.Drawing.Point(824, 28);
            this.lblPagamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(85, 16);
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
            this.cmbPagamento.Location = new System.Drawing.Point(824, 64);
            this.cmbPagamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(171, 24);
            this.cmbPagamento.TabIndex = 15;
            this.cmbPagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(325, 28);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 16);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(325, 65);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(464, 23);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(16, 28);
            this.lblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 16);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "DATA";
            // 
            // dtpData
            // 
            this.dtpData.CalendarForeColor = System.Drawing.Color.White;
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dtpData.Location = new System.Drawing.Point(21, 65);
            this.dtpData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(282, 23);
            this.dtpData.TabIndex = 11;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // tabelaDataForm
            // 
            this.tabelaDataForm.AllowUserToAddRows = false;
            this.tabelaDataForm.AllowUserToDeleteRows = false;
            this.tabelaDataForm.AllowUserToResizeColumns = false;
            this.tabelaDataForm.AllowUserToResizeRows = false;
            this.tabelaDataForm.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.tabelaDataForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tabelaDataForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDataForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Data,
            this.Descrição,
            this.Pagamento,
            this.Valor});
            this.tabelaDataForm.ContextMenuStrip = this.contextMenuStripDataForm;
            this.tabelaDataForm.GridColor = System.Drawing.Color.SteelBlue;
            this.tabelaDataForm.Location = new System.Drawing.Point(8, 148);
            this.tabelaDataForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabelaDataForm.MultiSelect = false;
            this.tabelaDataForm.Name = "tabelaDataForm";
            this.tabelaDataForm.ReadOnly = true;
            this.tabelaDataForm.RowHeadersVisible = false;
            this.tabelaDataForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaDataForm.Size = new System.Drawing.Size(1200, 510);
            this.tabelaDataForm.TabIndex = 19;
            this.tabelaDataForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaDataForm_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 250;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descrição.Width = 590;
            // 
            // Pagamento
            // 
            this.Pagamento.DataPropertyName = "pagamento";
            this.Pagamento.HeaderText = "Pagamento";
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.ReadOnly = true;
            this.Pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Pagamento.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 160;
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
            // lblIdGasto
            // 
            this.lblIdGasto.AutoSize = true;
            this.lblIdGasto.Location = new System.Drawing.Point(1554, 12);
            this.lblIdGasto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIdGasto.Name = "lblIdGasto";
            this.lblIdGasto.Size = new System.Drawing.Size(71, 16);
            this.lblIdGasto.TabIndex = 21;
            this.lblIdGasto.Text = "lblIdGasto";
            this.lblIdGasto.Visible = false;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1213, 654);
            this.Controls.Add(this.lblIdGasto);
            this.Controls.Add(this.tabelaDataForm);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DataForm";
            this.Opacity = 0.95D;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataForm;
        private System.Windows.Forms.ToolStripMenuItem ctxEditar;
        private System.Windows.Forms.ToolStripMenuItem ctxExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        public System.Windows.Forms.Label lblIdGasto;
        private System.Windows.Forms.DataGridView tabelaDataForm;
    }
}