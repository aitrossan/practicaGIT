
namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.RichTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.Urgente = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(297, 369);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(37, 13);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(358, 366);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(124, 20);
            this.txtPrecio.TabIndex = 25;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(300, 155);
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(395, 144);
            this.txtTelegrama.TabIndex = 23;
            this.txtTelegrama.Text = "";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(545, 325);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 45);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "Depurar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Aitor e Ivan";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(297, 125);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(37, 13);
            this.lblText1.TabIndex = 20;
            this.lblText1.Text = "Texto:";
            // 
            // Urgente
            // 
            this.Urgente.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Urgente.Location = new System.Drawing.Point(300, 325);
            this.Urgente.Name = "Urgente";
            this.Urgente.Size = new System.Drawing.Size(85, 17);
            this.Urgente.TabIndex = 27;
            this.Urgente.Text = "Urgente";
            this.Urgente.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.radioButton1.Location = new System.Drawing.Point(397, 325);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.Text = "Ordinario";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 465);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Urgente);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RichTextBox txtTelegrama;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.RadioButton Urgente;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

