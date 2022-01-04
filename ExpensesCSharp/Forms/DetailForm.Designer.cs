namespace ExpensesCSharp.Forms
{
    partial class DetailForm
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
            this.btnDetailFormUpdate = new System.Windows.Forms.Button();
            this.btnDetailFormCancel = new System.Windows.Forms.Button();
            this.txtDetailFormDescricao = new System.Windows.Forms.TextBox();
            this.dtpDetailForm = new System.Windows.Forms.DateTimePicker();
            this.cbDetailForm = new System.Windows.Forms.ComboBox();
            this.txtDetailFormValor = new System.Windows.Forms.TextBox();
            this.lblDetailFormId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDetailFormUpdate
            // 
            this.btnDetailFormUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetailFormUpdate.Location = new System.Drawing.Point(126, 412);
            this.btnDetailFormUpdate.Name = "btnDetailFormUpdate";
            this.btnDetailFormUpdate.Size = new System.Drawing.Size(200, 35);
            this.btnDetailFormUpdate.TabIndex = 0;
            this.btnDetailFormUpdate.Text = "Update";
            this.btnDetailFormUpdate.UseVisualStyleBackColor = true;
            this.btnDetailFormUpdate.Click += new System.EventHandler(this.btnDetailFormUpdate_Click);
            // 
            // btnDetailFormCancel
            // 
            this.btnDetailFormCancel.Location = new System.Drawing.Point(379, 424);
            this.btnDetailFormCancel.Name = "btnDetailFormCancel";
            this.btnDetailFormCancel.Size = new System.Drawing.Size(59, 23);
            this.btnDetailFormCancel.TabIndex = 1;
            this.btnDetailFormCancel.Text = "Cancel";
            this.btnDetailFormCancel.UseVisualStyleBackColor = true;
            this.btnDetailFormCancel.Click += new System.EventHandler(this.btnDetailFormCancel_Click);
            // 
            // txtDetailFormDescricao
            // 
            this.txtDetailFormDescricao.Location = new System.Drawing.Point(94, 88);
            this.txtDetailFormDescricao.Multiline = true;
            this.txtDetailFormDescricao.Name = "txtDetailFormDescricao";
            this.txtDetailFormDescricao.Size = new System.Drawing.Size(259, 171);
            this.txtDetailFormDescricao.TabIndex = 2;
            // 
            // dtpDetailForm
            // 
            this.dtpDetailForm.Location = new System.Drawing.Point(94, 39);
            this.dtpDetailForm.Name = "dtpDetailForm";
            this.dtpDetailForm.Size = new System.Drawing.Size(259, 20);
            this.dtpDetailForm.TabIndex = 3;
            // 
            // cbDetailForm
            // 
            this.cbDetailForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDetailForm.FormattingEnabled = true;
            this.cbDetailForm.Items.AddRange(new object[] {
            "Débito",
            "Cartão de Crédito",
            "PIX"});
            this.cbDetailForm.Location = new System.Drawing.Point(126, 288);
            this.cbDetailForm.Name = "cbDetailForm";
            this.cbDetailForm.Size = new System.Drawing.Size(200, 21);
            this.cbDetailForm.TabIndex = 4;
            this.cbDetailForm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDetailFormValor
            // 
            this.txtDetailFormValor.Location = new System.Drawing.Point(126, 338);
            this.txtDetailFormValor.Name = "txtDetailFormValor";
            this.txtDetailFormValor.Size = new System.Drawing.Size(200, 20);
            this.txtDetailFormValor.TabIndex = 5;
            // 
            // lblDetailFormId
            // 
            this.lblDetailFormId.AutoSize = true;
            this.lblDetailFormId.Location = new System.Drawing.Point(27, 13);
            this.lblDetailFormId.Name = "lblDetailFormId";
            this.lblDetailFormId.Size = new System.Drawing.Size(18, 13);
            this.lblDetailFormId.TabIndex = 6;
            this.lblDetailFormId.Text = "ID";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(450, 488);
            this.Controls.Add(this.lblDetailFormId);
            this.Controls.Add(this.txtDetailFormValor);
            this.Controls.Add(this.cbDetailForm);
            this.Controls.Add(this.dtpDetailForm);
            this.Controls.Add(this.txtDetailFormDescricao);
            this.Controls.Add(this.btnDetailFormCancel);
            this.Controls.Add(this.btnDetailFormUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetailFormUpdate;
        private System.Windows.Forms.Button btnDetailFormCancel;
        private System.Windows.Forms.TextBox txtDetailFormDescricao;
        private System.Windows.Forms.DateTimePicker dtpDetailForm;
        private System.Windows.Forms.ComboBox cbDetailForm;
        private System.Windows.Forms.TextBox txtDetailFormValor;
        private System.Windows.Forms.Label lblDetailFormId;
    }
}