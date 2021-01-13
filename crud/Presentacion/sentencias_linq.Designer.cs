
namespace crud.Presentacion
{
    partial class sentencias_linq
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
            this.dgvanidado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbdatos = new System.Windows.Forms.ComboBox();
            this.chbmayor = new System.Windows.Forms.CheckBox();
            this.chbmenor = new System.Windows.Forms.CheckBox();
            this.chbigual = new System.Windows.Forms.CheckBox();
            this.tbcon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvanidado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvanidado
            // 
            this.dgvanidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvanidado.Location = new System.Drawing.Point(12, 108);
            this.dgvanidado.Name = "dgvanidado";
            this.dgvanidado.Size = new System.Drawing.Size(776, 330);
            this.dgvanidado.TabIndex = 0;
            this.dgvanidado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Condicion";
            // 
            // cbdatos
            // 
            this.cbdatos.FormattingEnabled = true;
            this.cbdatos.Location = new System.Drawing.Point(121, 25);
            this.cbdatos.Name = "cbdatos";
            this.cbdatos.Size = new System.Drawing.Size(121, 21);
            this.cbdatos.TabIndex = 2;
            this.cbdatos.TextChanged += new System.EventHandler(this.cbdatos_TextChanged);
            // 
            // chbmayor
            // 
            this.chbmayor.AutoSize = true;
            this.chbmayor.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbmayor.Location = new System.Drawing.Point(270, 25);
            this.chbmayor.Name = "chbmayor";
            this.chbmayor.Size = new System.Drawing.Size(72, 20);
            this.chbmayor.TabIndex = 4;
            this.chbmayor.Text = "Mayor";
            this.chbmayor.UseVisualStyleBackColor = true;
            // 
            // chbmenor
            // 
            this.chbmenor.AutoSize = true;
            this.chbmenor.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbmenor.Location = new System.Drawing.Point(370, 25);
            this.chbmenor.Name = "chbmenor";
            this.chbmenor.Size = new System.Drawing.Size(72, 20);
            this.chbmenor.TabIndex = 5;
            this.chbmenor.Text = "Menor";
            this.chbmenor.UseVisualStyleBackColor = true;
            // 
            // chbigual
            // 
            this.chbigual.AutoSize = true;
            this.chbigual.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbigual.Location = new System.Drawing.Point(470, 25);
            this.chbigual.Name = "chbigual";
            this.chbigual.Size = new System.Drawing.Size(72, 20);
            this.chbigual.TabIndex = 6;
            this.chbigual.Text = "Igual";
            this.chbigual.UseVisualStyleBackColor = true;
            // 
            // tbcon
            // 
            this.tbcon.Location = new System.Drawing.Point(570, 25);
            this.tbcon.Name = "tbcon";
            this.tbcon.Size = new System.Drawing.Size(100, 20);
            this.tbcon.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbres
            // 
            this.lbres.AutoSize = true;
            this.lbres.Location = new System.Drawing.Point(48, 76);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(35, 13);
            this.lbres.TabIndex = 9;
            this.lbres.Text = "label2";
            // 
            // sentencias_linq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbcon);
            this.Controls.Add(this.chbigual);
            this.Controls.Add(this.chbmenor);
            this.Controls.Add(this.chbmayor);
            this.Controls.Add(this.cbdatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvanidado);
            this.Name = "sentencias_linq";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.sentencias_linq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvanidado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvanidado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdatos;
        private System.Windows.Forms.CheckBox chbmayor;
        private System.Windows.Forms.CheckBox chbmenor;
        private System.Windows.Forms.CheckBox chbigual;
        private System.Windows.Forms.TextBox tbcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbres;
    }
}