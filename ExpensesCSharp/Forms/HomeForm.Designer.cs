using ExpensesCSharp.Forms;

namespace ExpensesCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.PainelPrincipal = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(26, 360);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "D\r\n\r\nA\r\n\r\nT\r\n\r\nA";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails.ForeColor = System.Drawing.Color.White;
            this.buttonDetails.Location = new System.Drawing.Point(0, 359);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(26, 361);
            this.buttonDetails.TabIndex = 1;
            this.buttonDetails.Text = "D\r\n\r\nE\r\n\r\nT\r\n\r\nA\r\n\r\nL\r\n\r\nH\r\n\r\nE\r\n\r\nS";
            this.buttonDetails.UseVisualStyleBackColor = false;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.Location = new System.Drawing.Point(49, 25);
            this.PainelPrincipal.Name = "PainelPrincipal";
            this.PainelPrincipal.Size = new System.Drawing.Size(1213, 654);
            this.PainelPrincipal.TabIndex = 11;
            this.PainelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelPrincipal_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1255, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.PainelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Panel PainelPrincipal;
        private System.Windows.Forms.Button btnClose;
    }
}

