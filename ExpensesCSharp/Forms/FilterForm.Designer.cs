namespace ExpensesCSharp.Forms
{
    partial class FilterForm
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
            this.DetailBTNAno = new System.Windows.Forms.Button();
            this.DetailBTNMes = new System.Windows.Forms.Button();
            this.DetailBTNBuscar = new System.Windows.Forms.Button();
            this.DetailLabelFim = new System.Windows.Forms.Label();
            this.DetailLabelInicio = new System.Windows.Forms.Label();
            this.DetailDateFim = new System.Windows.Forms.DateTimePicker();
            this.DetailDateInicio = new System.Windows.Forms.DateTimePicker();
            this.labelQuantDebito = new System.Windows.Forms.Label();
            this.labelQuantPix = new System.Windows.Forms.Label();
            this.labelQuantCC = new System.Windows.Forms.Label();
            this.labelValorGastosTotais = new System.Windows.Forms.Label();
            this.labelDebito = new System.Windows.Forms.Label();
            this.labelPix = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelGastosTotais = new System.Windows.Forms.Label();
            this.DetailLabelEstatistica = new System.Windows.Forms.Label();
            this.tabelaFilterForm = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFilterForm)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailBTNAno
            // 
            this.DetailBTNAno.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DetailBTNAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBTNAno.Location = new System.Drawing.Point(7, 157);
            this.DetailBTNAno.Name = "DetailBTNAno";
            this.DetailBTNAno.Size = new System.Drawing.Size(192, 23);
            this.DetailBTNAno.TabIndex = 6;
            this.DetailBTNAno.Text = "Último Ano";
            this.DetailBTNAno.UseVisualStyleBackColor = false;
            this.DetailBTNAno.Click += new System.EventHandler(this.DetailBTNAno_Click);
            // 
            // DetailBTNMes
            // 
            this.DetailBTNMes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DetailBTNMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBTNMes.Location = new System.Drawing.Point(7, 128);
            this.DetailBTNMes.Name = "DetailBTNMes";
            this.DetailBTNMes.Size = new System.Drawing.Size(192, 23);
            this.DetailBTNMes.TabIndex = 5;
            this.DetailBTNMes.Text = "Último Mês";
            this.DetailBTNMes.UseVisualStyleBackColor = false;
            this.DetailBTNMes.Click += new System.EventHandler(this.DetailBTNMes_Click);
            // 
            // DetailBTNBuscar
            // 
            this.DetailBTNBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DetailBTNBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBTNBuscar.Location = new System.Drawing.Point(7, 99);
            this.DetailBTNBuscar.Name = "DetailBTNBuscar";
            this.DetailBTNBuscar.Size = new System.Drawing.Size(192, 23);
            this.DetailBTNBuscar.TabIndex = 4;
            this.DetailBTNBuscar.Text = "BUSCAR";
            this.DetailBTNBuscar.UseVisualStyleBackColor = false;
            this.DetailBTNBuscar.Click += new System.EventHandler(this.DetailBTNBuscar_Click);
            // 
            // DetailLabelFim
            // 
            this.DetailLabelFim.AutoSize = true;
            this.DetailLabelFim.Location = new System.Drawing.Point(16, 52);
            this.DetailLabelFim.Name = "DetailLabelFim";
            this.DetailLabelFim.Size = new System.Drawing.Size(23, 13);
            this.DetailLabelFim.TabIndex = 3;
            this.DetailLabelFim.Text = "Fim";
            // 
            // DetailLabelInicio
            // 
            this.DetailLabelInicio.AutoSize = true;
            this.DetailLabelInicio.Location = new System.Drawing.Point(16, 9);
            this.DetailLabelInicio.Name = "DetailLabelInicio";
            this.DetailLabelInicio.Size = new System.Drawing.Size(32, 13);
            this.DetailLabelInicio.TabIndex = 2;
            this.DetailLabelInicio.Text = "Inicio";
            // 
            // DetailDateFim
            // 
            this.DetailDateFim.Location = new System.Drawing.Point(7, 72);
            this.DetailDateFim.Name = "DetailDateFim";
            this.DetailDateFim.Size = new System.Drawing.Size(192, 20);
            this.DetailDateFim.TabIndex = 1;
            // 
            // DetailDateInicio
            // 
            this.DetailDateInicio.Location = new System.Drawing.Point(7, 27);
            this.DetailDateInicio.Name = "DetailDateInicio";
            this.DetailDateInicio.Size = new System.Drawing.Size(192, 20);
            this.DetailDateInicio.TabIndex = 0;
            // 
            // labelQuantDebito
            // 
            this.labelQuantDebito.AutoSize = true;
            this.labelQuantDebito.Location = new System.Drawing.Point(72, 320);
            this.labelQuantDebito.Name = "labelQuantDebito";
            this.labelQuantDebito.Size = new System.Drawing.Size(0, 13);
            this.labelQuantDebito.TabIndex = 8;
            // 
            // labelQuantPix
            // 
            this.labelQuantPix.AutoSize = true;
            this.labelQuantPix.Location = new System.Drawing.Point(55, 294);
            this.labelQuantPix.Name = "labelQuantPix";
            this.labelQuantPix.Size = new System.Drawing.Size(0, 13);
            this.labelQuantPix.TabIndex = 7;
            // 
            // labelQuantCC
            // 
            this.labelQuantCC.AutoSize = true;
            this.labelQuantCC.Location = new System.Drawing.Point(120, 267);
            this.labelQuantCC.Name = "labelQuantCC";
            this.labelQuantCC.Size = new System.Drawing.Size(0, 13);
            this.labelQuantCC.TabIndex = 6;
            // 
            // labelValorGastosTotais
            // 
            this.labelValorGastosTotais.AutoSize = true;
            this.labelValorGastosTotais.Location = new System.Drawing.Point(111, 228);
            this.labelValorGastosTotais.Name = "labelValorGastosTotais";
            this.labelValorGastosTotais.Size = new System.Drawing.Size(0, 13);
            this.labelValorGastosTotais.TabIndex = 5;
            // 
            // labelDebito
            // 
            this.labelDebito.AutoSize = true;
            this.labelDebito.Location = new System.Drawing.Point(17, 320);
            this.labelDebito.Name = "labelDebito";
            this.labelDebito.Size = new System.Drawing.Size(41, 13);
            this.labelDebito.TabIndex = 4;
            this.labelDebito.Text = "Débito:";
            // 
            // labelPix
            // 
            this.labelPix.AutoSize = true;
            this.labelPix.Location = new System.Drawing.Point(17, 294);
            this.labelPix.Name = "labelPix";
            this.labelPix.Size = new System.Drawing.Size(27, 13);
            this.labelPix.TabIndex = 3;
            this.labelPix.Text = "PIX:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(17, 267);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(92, 13);
            this.labelCC.TabIndex = 2;
            this.labelCC.Text = "Cartão de Crédito:";
            this.labelCC.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelGastosTotais
            // 
            this.labelGastosTotais.AutoSize = true;
            this.labelGastosTotais.Location = new System.Drawing.Point(15, 228);
            this.labelGastosTotais.Name = "labelGastosTotais";
            this.labelGastosTotais.Size = new System.Drawing.Size(75, 13);
            this.labelGastosTotais.TabIndex = 1;
            this.labelGastosTotais.Text = "Gastos Totais:";
            // 
            // DetailLabelEstatistica
            // 
            this.DetailLabelEstatistica.AutoSize = true;
            this.DetailLabelEstatistica.Location = new System.Drawing.Point(12, 196);
            this.DetailLabelEstatistica.Name = "DetailLabelEstatistica";
            this.DetailLabelEstatistica.Size = new System.Drawing.Size(65, 13);
            this.DetailLabelEstatistica.TabIndex = 0;
            this.DetailLabelEstatistica.Text = "Estatísticas:";
            this.DetailLabelEstatistica.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabelaFilterForm
            // 
            this.tabelaFilterForm.BackgroundColor = System.Drawing.Color.White;
            this.tabelaFilterForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFilterForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Data,
            this.Descrição,
            this.Pagamento,
            this.Valor});
            this.tabelaFilterForm.GridColor = System.Drawing.Color.White;
            this.tabelaFilterForm.Location = new System.Drawing.Point(212, 9);
            this.tabelaFilterForm.Name = "tabelaFilterForm";
            this.tabelaFilterForm.RowHeadersVisible = false;
            this.tabelaFilterForm.Size = new System.Drawing.Size(998, 642);
            this.tabelaFilterForm.TabIndex = 0;
            this.tabelaFilterForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Data.Width = 140;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descrição.Width = 480;
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
            this.Valor.Width = 180;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1213, 654);
            this.Controls.Add(this.tabelaFilterForm);
            this.Controls.Add(this.labelQuantDebito);
            this.Controls.Add(this.DetailBTNAno);
            this.Controls.Add(this.labelQuantPix);
            this.Controls.Add(this.labelQuantCC);
            this.Controls.Add(this.labelValorGastosTotais);
            this.Controls.Add(this.DetailBTNMes);
            this.Controls.Add(this.labelDebito);
            this.Controls.Add(this.DetailBTNBuscar);
            this.Controls.Add(this.labelPix);
            this.Controls.Add(this.DetailLabelInicio);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.DetailLabelFim);
            this.Controls.Add(this.labelGastosTotais);
            this.Controls.Add(this.DetailDateInicio);
            this.Controls.Add(this.DetailLabelEstatistica);
            this.Controls.Add(this.DetailDateFim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFilterForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DetailBTNAno;
        private System.Windows.Forms.Button DetailBTNMes;
        private System.Windows.Forms.Button DetailBTNBuscar;
        private System.Windows.Forms.Label DetailLabelFim;
        private System.Windows.Forms.Label DetailLabelInicio;
        private System.Windows.Forms.DateTimePicker DetailDateFim;
        private System.Windows.Forms.DateTimePicker DetailDateInicio;
        private System.Windows.Forms.Label DetailLabelEstatistica;
        private System.Windows.Forms.Label labelGastosTotais;
        private System.Windows.Forms.Label labelPix;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelDebito;
        private System.Windows.Forms.DataGridView tabelaFilterForm;
        private System.Windows.Forms.Label labelQuantDebito;
        private System.Windows.Forms.Label labelQuantPix;
        private System.Windows.Forms.Label labelQuantCC;
        private System.Windows.Forms.Label labelValorGastosTotais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}