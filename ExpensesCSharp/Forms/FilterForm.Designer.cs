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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DetailBTNAno.BackColor = System.Drawing.Color.SteelBlue;
            this.DetailBTNAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBTNAno.ForeColor = System.Drawing.Color.White;
            this.DetailBTNAno.Location = new System.Drawing.Point(8, 157);
            this.DetailBTNAno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailBTNAno.Name = "DetailBTNAno";
            this.DetailBTNAno.Size = new System.Drawing.Size(224, 23);
            this.DetailBTNAno.TabIndex = 6;
            this.DetailBTNAno.Text = "Último Ano";
            this.DetailBTNAno.UseVisualStyleBackColor = false;
            this.DetailBTNAno.Click += new System.EventHandler(this.DetailBTNAno_Click);
            // 
            // DetailBTNMes
            // 
            this.DetailBTNMes.BackColor = System.Drawing.Color.SteelBlue;
            this.DetailBTNMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBTNMes.ForeColor = System.Drawing.Color.White;
            this.DetailBTNMes.Location = new System.Drawing.Point(8, 128);
            this.DetailBTNMes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailBTNMes.Name = "DetailBTNMes";
            this.DetailBTNMes.Size = new System.Drawing.Size(224, 23);
            this.DetailBTNMes.TabIndex = 5;
            this.DetailBTNMes.Text = "Último Mês";
            this.DetailBTNMes.UseVisualStyleBackColor = false;
            this.DetailBTNMes.Click += new System.EventHandler(this.DetailBTNMes_Click);
            // 
            // DetailBTNBuscar
            // 
            this.DetailBTNBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.DetailBTNBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBTNBuscar.ForeColor = System.Drawing.Color.White;
            this.DetailBTNBuscar.Location = new System.Drawing.Point(8, 99);
            this.DetailBTNBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailBTNBuscar.Name = "DetailBTNBuscar";
            this.DetailBTNBuscar.Size = new System.Drawing.Size(224, 23);
            this.DetailBTNBuscar.TabIndex = 4;
            this.DetailBTNBuscar.Text = "BUSCAR";
            this.DetailBTNBuscar.UseVisualStyleBackColor = false;
            this.DetailBTNBuscar.Click += new System.EventHandler(this.DetailBTNBuscar_Click);
            // 
            // DetailLabelFim
            // 
            this.DetailLabelFim.AutoSize = true;
            this.DetailLabelFim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabelFim.ForeColor = System.Drawing.Color.White;
            this.DetailLabelFim.Location = new System.Drawing.Point(19, 52);
            this.DetailLabelFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetailLabelFim.Name = "DetailLabelFim";
            this.DetailLabelFim.Size = new System.Drawing.Size(27, 14);
            this.DetailLabelFim.TabIndex = 3;
            this.DetailLabelFim.Text = "Fim";
            // 
            // DetailLabelInicio
            // 
            this.DetailLabelInicio.AutoSize = true;
            this.DetailLabelInicio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabelInicio.ForeColor = System.Drawing.Color.White;
            this.DetailLabelInicio.Location = new System.Drawing.Point(19, 9);
            this.DetailLabelInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetailLabelInicio.Name = "DetailLabelInicio";
            this.DetailLabelInicio.Size = new System.Drawing.Size(40, 14);
            this.DetailLabelInicio.TabIndex = 2;
            this.DetailLabelInicio.Text = "Inicio";
            // 
            // DetailDateFim
            // 
            this.DetailDateFim.Location = new System.Drawing.Point(8, 72);
            this.DetailDateFim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailDateFim.Name = "DetailDateFim";
            this.DetailDateFim.Size = new System.Drawing.Size(223, 21);
            this.DetailDateFim.TabIndex = 1;
            // 
            // DetailDateInicio
            // 
            this.DetailDateInicio.Location = new System.Drawing.Point(8, 27);
            this.DetailDateInicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetailDateInicio.Name = "DetailDateInicio";
            this.DetailDateInicio.Size = new System.Drawing.Size(223, 21);
            this.DetailDateInicio.TabIndex = 0;
            // 
            // labelQuantDebito
            // 
            this.labelQuantDebito.AutoSize = true;
            this.labelQuantDebito.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantDebito.ForeColor = System.Drawing.Color.White;
            this.labelQuantDebito.Location = new System.Drawing.Point(84, 320);
            this.labelQuantDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantDebito.Name = "labelQuantDebito";
            this.labelQuantDebito.Size = new System.Drawing.Size(0, 14);
            this.labelQuantDebito.TabIndex = 8;
            // 
            // labelQuantPix
            // 
            this.labelQuantPix.AutoSize = true;
            this.labelQuantPix.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantPix.ForeColor = System.Drawing.Color.White;
            this.labelQuantPix.Location = new System.Drawing.Point(64, 294);
            this.labelQuantPix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantPix.Name = "labelQuantPix";
            this.labelQuantPix.Size = new System.Drawing.Size(0, 14);
            this.labelQuantPix.TabIndex = 7;
            // 
            // labelQuantCC
            // 
            this.labelQuantCC.AutoSize = true;
            this.labelQuantCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantCC.ForeColor = System.Drawing.Color.White;
            this.labelQuantCC.Location = new System.Drawing.Point(143, 267);
            this.labelQuantCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantCC.Name = "labelQuantCC";
            this.labelQuantCC.Size = new System.Drawing.Size(0, 14);
            this.labelQuantCC.TabIndex = 6;
            // 
            // labelValorGastosTotais
            // 
            this.labelValorGastosTotais.AutoSize = true;
            this.labelValorGastosTotais.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorGastosTotais.ForeColor = System.Drawing.Color.White;
            this.labelValorGastosTotais.Location = new System.Drawing.Point(130, 228);
            this.labelValorGastosTotais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorGastosTotais.Name = "labelValorGastosTotais";
            this.labelValorGastosTotais.Size = new System.Drawing.Size(0, 14);
            this.labelValorGastosTotais.TabIndex = 5;
            // 
            // labelDebito
            // 
            this.labelDebito.AutoSize = true;
            this.labelDebito.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebito.ForeColor = System.Drawing.Color.White;
            this.labelDebito.Location = new System.Drawing.Point(20, 320);
            this.labelDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDebito.Name = "labelDebito";
            this.labelDebito.Size = new System.Drawing.Size(52, 14);
            this.labelDebito.TabIndex = 4;
            this.labelDebito.Text = "Débito:";
            // 
            // labelPix
            // 
            this.labelPix.AutoSize = true;
            this.labelPix.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPix.ForeColor = System.Drawing.Color.White;
            this.labelPix.Location = new System.Drawing.Point(20, 294);
            this.labelPix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPix.Name = "labelPix";
            this.labelPix.Size = new System.Drawing.Size(32, 14);
            this.labelPix.TabIndex = 3;
            this.labelPix.Text = "PIX:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.ForeColor = System.Drawing.Color.White;
            this.labelCC.Location = new System.Drawing.Point(20, 267);
            this.labelCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(120, 14);
            this.labelCC.TabIndex = 2;
            this.labelCC.Text = "Cartão de Crédito:";
            this.labelCC.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelGastosTotais
            // 
            this.labelGastosTotais.AutoSize = true;
            this.labelGastosTotais.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGastosTotais.ForeColor = System.Drawing.Color.White;
            this.labelGastosTotais.Location = new System.Drawing.Point(18, 228);
            this.labelGastosTotais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGastosTotais.Name = "labelGastosTotais";
            this.labelGastosTotais.Size = new System.Drawing.Size(93, 14);
            this.labelGastosTotais.TabIndex = 1;
            this.labelGastosTotais.Text = "Gastos Totais:";
            // 
            // DetailLabelEstatistica
            // 
            this.DetailLabelEstatistica.AutoSize = true;
            this.DetailLabelEstatistica.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLabelEstatistica.ForeColor = System.Drawing.Color.White;
            this.DetailLabelEstatistica.Location = new System.Drawing.Point(14, 196);
            this.DetailLabelEstatistica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetailLabelEstatistica.Name = "DetailLabelEstatistica";
            this.DetailLabelEstatistica.Size = new System.Drawing.Size(100, 18);
            this.DetailLabelEstatistica.TabIndex = 0;
            this.DetailLabelEstatistica.Text = "Estatísticas:";
            this.DetailLabelEstatistica.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabelaFilterForm
            // 
            this.tabelaFilterForm.AllowUserToAddRows = false;
            this.tabelaFilterForm.AllowUserToDeleteRows = false;
            this.tabelaFilterForm.AllowUserToResizeColumns = false;
            this.tabelaFilterForm.AllowUserToResizeRows = false;
            this.tabelaFilterForm.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.tabelaFilterForm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tabelaFilterForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFilterForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Data,
            this.Descrição,
            this.Pagamento,
            this.Valor});
            this.tabelaFilterForm.GridColor = System.Drawing.Color.SteelBlue;
            this.tabelaFilterForm.Location = new System.Drawing.Point(247, 9);
            this.tabelaFilterForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabelaFilterForm.MultiSelect = false;
            this.tabelaFilterForm.Name = "tabelaFilterForm";
            this.tabelaFilterForm.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaFilterForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaFilterForm.RowHeadersVisible = false;
            this.tabelaFilterForm.Size = new System.Drawing.Size(964, 650);
            this.tabelaFilterForm.TabIndex = 0;
            this.tabelaFilterForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Data.Width = 140;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descrição.Width = 480;
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
            this.Valor.Width = 180;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
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
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FilterForm";
            this.Opacity = 0.95D;
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