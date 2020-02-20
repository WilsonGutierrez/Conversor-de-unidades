namespace conversiones
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
            this.cbotengo = new System.Windows.Forms.ComboBox();
            this.cboquiero = new System.Windows.Forms.ComboBox();
            this.cbotipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconversor = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtcantidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltipodeconversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbotengo
            // 
            this.cbotengo.FormattingEnabled = true;
            this.cbotengo.Location = new System.Drawing.Point(399, 104);
            this.cbotengo.Name = "cbotengo";
            this.cbotengo.Size = new System.Drawing.Size(121, 21);
            this.cbotengo.TabIndex = 1;
            // 
            // cboquiero
            // 
            this.cboquiero.FormattingEnabled = true;
            this.cboquiero.Location = new System.Drawing.Point(553, 104);
            this.cboquiero.Name = "cboquiero";
            this.cboquiero.Size = new System.Drawing.Size(121, 21);
            this.cboquiero.TabIndex = 1;
            // 
            // cbotipos
            // 
            this.cbotipos.FormattingEnabled = true;
            this.cbotipos.Location = new System.Drawing.Point(202, 33);
            this.cbotipos.Name = "cbotipos";
            this.cbotipos.Size = new System.Drawing.Size(121, 21);
            this.cbotipos.TabIndex = 2;
            this.cbotipos.SelectedIndexChanged += new System.EventHandler(this.cbotipos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convertir de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione unidad: ";
            // 
            // btnconversor
            // 
            this.btnconversor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconversor.Location = new System.Drawing.Point(317, 143);
            this.btnconversor.Name = "btnconversor";
            this.btnconversor.Size = new System.Drawing.Size(128, 45);
            this.btnconversor.TabIndex = 6;
            this.btnconversor.Text = "Convertir";
            this.btnconversor.UseVisualStyleBackColor = false;
            this.btnconversor.Click += new System.EventHandler(this.btnconversor_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(198, 238);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 8;
            // 
            // txtcantidades
            // 
            this.txtcantidades.Location = new System.Drawing.Point(186, 103);
            this.txtcantidades.Name = "txtcantidades";
            this.txtcantidades.Size = new System.Drawing.Size(100, 20);
            this.txtcantidades.TabIndex = 0;
            this.txtcantidades.Click += new System.EventHandler(this.txtcantidades_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad a Convertir:";
            // 
            // lbltipodeconversor
            // 
            this.lbltipodeconversor.AutoSize = true;
            this.lbltipodeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipodeconversor.Location = new System.Drawing.Point(367, 33);
            this.lbltipodeconversor.Name = "lbltipodeconversor";
            this.lbltipodeconversor.Size = new System.Drawing.Size(78, 16);
            this.lbltipodeconversor.TabIndex = 11;
            this.lbltipodeconversor.Text = "Convertir: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 313);
            this.Controls.Add(this.lbltipodeconversor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcantidades);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnconversor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbotipos);
            this.Controls.Add(this.cboquiero);
            this.Controls.Add(this.cbotengo);
            this.Name = "Form1";
            this.Text = "Conversor de unidades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotengo;
        private System.Windows.Forms.ComboBox cboquiero;
        private System.Windows.Forms.ComboBox cbotipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconversor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtcantidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltipodeconversor;
    }
}

