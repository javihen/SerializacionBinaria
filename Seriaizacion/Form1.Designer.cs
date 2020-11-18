namespace Seriaizacion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsSerializar = new System.Windows.Forms.ToolStripLabel();
            this.tsDeserializar = new System.Windows.Forms.ToolStripLabel();
            this.tsSalir = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSerializar,
            this.tsDeserializar,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serializacion de cadena";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(19, 78);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(827, 265);
            this.txtCadena.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Seriaizacion.Properties.Resources.documento;
            this.pictureBox1.Location = new System.Drawing.Point(19, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tsSerializar
            // 
            this.tsSerializar.Image = global::Seriaizacion.Properties.Resources.GUARDAR2;
            this.tsSerializar.Name = "tsSerializar";
            this.tsSerializar.Size = new System.Drawing.Size(84, 22);
            this.tsSerializar.Text = "SERIALIZAR";
            this.tsSerializar.Click += new System.EventHandler(this.tsSerializar_Click);
            // 
            // tsDeserializar
            // 
            this.tsDeserializar.Image = global::Seriaizacion.Properties.Resources.ABRIR;
            this.tsDeserializar.Name = "tsDeserializar";
            this.tsDeserializar.Size = new System.Drawing.Size(98, 22);
            this.tsDeserializar.Text = "DESERIALIZAR";
            this.tsDeserializar.Click += new System.EventHandler(this.tsDeserializar_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Image = global::Seriaizacion.Properties.Resources.SALIR;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(53, 22);
            this.tsSalir.Text = "SALIR";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(863, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsSerializar;
        private System.Windows.Forms.ToolStripLabel tsDeserializar;
        private System.Windows.Forms.ToolStripLabel tsSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

