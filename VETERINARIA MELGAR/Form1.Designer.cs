namespace VETERINARIA_MELGAR
{
    partial class VeterinariaMelgar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeterinariaMelgar));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.rdbfemenino = new System.Windows.Forms.RadioButton();
            this.rdbmasc = new System.Windows.Forms.RadioButton();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblimporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grcliente = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grbmascota = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbdias = new System.Windows.Forms.RadioButton();
            this.rdbaño = new System.Windows.Forms.RadioButton();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnommascota = new System.Windows.Forms.TextBox();
            this.lstAtención = new System.Windows.Forms.ListBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.txtatencion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtidatencion = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.grcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbmascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(80, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(155, 30);
            this.txtnombre.TabIndex = 0;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(10, 89);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(58, 21);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Nombre";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(13, 133);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(37, 21);
            this.lblsexo.TabIndex = 7;
            this.lblsexo.Text = "Sexo";
            // 
            // rdbfemenino
            // 
            this.rdbfemenino.AutoSize = true;
            this.rdbfemenino.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemenino.Location = new System.Drawing.Point(59, 131);
            this.rdbfemenino.Name = "rdbfemenino";
            this.rdbfemenino.Size = new System.Drawing.Size(85, 25);
            this.rdbfemenino.TabIndex = 2;
            this.rdbfemenino.TabStop = true;
            this.rdbfemenino.Text = "Femenino";
            this.rdbfemenino.UseVisualStyleBackColor = true;
            // 
            // rdbmasc
            // 
            this.rdbmasc.AutoSize = true;
            this.rdbmasc.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmasc.Location = new System.Drawing.Point(150, 131);
            this.rdbmasc.Name = "rdbmasc";
            this.rdbmasc.Size = new System.Drawing.Size(85, 25);
            this.rdbmasc.TabIndex = 3;
            this.rdbmasc.TabStop = true;
            this.rdbmasc.Text = "Masculino";
            this.rdbmasc.UseVisualStyleBackColor = true;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(11, 188);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(55, 21);
            this.lblcodigo.TabIndex = 8;
            this.lblcodigo.Text = "Código ";
            this.lblcodigo.Click += new System.EventHandler(this.lblcodigo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(72, 183);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(155, 30);
            this.txtcodigo.TabIndex = 4;
            // 
            // lblimporte
            // 
            this.lblimporte.AutoSize = true;
            this.lblimporte.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimporte.ForeColor = System.Drawing.Color.Blue;
            this.lblimporte.Location = new System.Drawing.Point(566, 269);
            this.lblimporte.Name = "lblimporte";
            this.lblimporte.Size = new System.Drawing.Size(74, 23);
            this.lblimporte.TabIndex = 5;
            this.lblimporte.Text = "Importe $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo";
            // 
            // grcliente
            // 
            this.grcliente.Controls.Add(this.pictureBox2);
            this.grcliente.Controls.Add(this.lblnombre);
            this.grcliente.Controls.Add(this.txtnombre);
            this.grcliente.Controls.Add(this.lblsexo);
            this.grcliente.Controls.Add(this.txtcodigo);
            this.grcliente.Controls.Add(this.rdbfemenino);
            this.grcliente.Controls.Add(this.lblcodigo);
            this.grcliente.Controls.Add(this.rdbmasc);
            this.grcliente.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grcliente.Location = new System.Drawing.Point(14, 13);
            this.grcliente.Name = "grcliente";
            this.grcliente.Size = new System.Drawing.Size(248, 227);
            this.grcliente.TabIndex = 0;
            this.grcliente.TabStop = false;
            this.grcliente.Text = "Cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VETERINARIA_MELGAR.Properties.Resources.persona1;
            this.pictureBox2.Location = new System.Drawing.Point(10, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // grbmascota
            // 
            this.grbmascota.Controls.Add(this.pictureBox1);
            this.grbmascota.Controls.Add(this.rdbdias);
            this.grbmascota.Controls.Add(this.rdbaño);
            this.grbmascota.Controls.Add(this.cbotipo);
            this.grbmascota.Controls.Add(this.txtedad);
            this.grbmascota.Controls.Add(this.txtnommascota);
            this.grbmascota.Controls.Add(this.label1);
            this.grbmascota.Controls.Add(this.label2);
            this.grbmascota.Controls.Add(this.label3);
            this.grbmascota.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbmascota.ForeColor = System.Drawing.Color.Blue;
            this.grbmascota.Location = new System.Drawing.Point(286, 13);
            this.grbmascota.Name = "grbmascota";
            this.grbmascota.Size = new System.Drawing.Size(233, 227);
            this.grbmascota.TabIndex = 1;
            this.grbmascota.TabStop = false;
            this.grbmascota.Text = "Mascota";
            this.grbmascota.Enter += new System.EventHandler(this.grbmascota_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VETERINARIA_MELGAR.Properties.Resources.green_pets_icon_icons_com_59415;
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rdbdias
            // 
            this.rdbdias.AutoSize = true;
            this.rdbdias.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdias.Location = new System.Drawing.Point(141, 196);
            this.rdbdias.Name = "rdbdias";
            this.rdbdias.Size = new System.Drawing.Size(51, 25);
            this.rdbdias.TabIndex = 7;
            this.rdbdias.TabStop = true;
            this.rdbdias.Text = "dias";
            this.rdbdias.UseVisualStyleBackColor = true;
            // 
            // rdbaño
            // 
            this.rdbaño.AutoSize = true;
            this.rdbaño.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbaño.Location = new System.Drawing.Point(141, 174);
            this.rdbaño.Name = "rdbaño";
            this.rdbaño.Size = new System.Drawing.Size(55, 25);
            this.rdbaño.TabIndex = 6;
            this.rdbaño.TabStop = true;
            this.rdbaño.Text = "años";
            this.rdbaño.UseVisualStyleBackColor = true;
            // 
            // cbotipo
            // 
            this.cbotipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbotipo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.ItemHeight = 23;
            this.cbotipo.Location = new System.Drawing.Point(85, 79);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(129, 31);
            this.cbotipo.TabIndex = 0;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.Location = new System.Drawing.Point(85, 183);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(40, 30);
            this.txtedad.TabIndex = 2;
            // 
            // txtnommascota
            // 
            this.txtnommascota.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnommascota.Location = new System.Drawing.Point(85, 133);
            this.txtnommascota.Name = "txtnommascota";
            this.txtnommascota.Size = new System.Drawing.Size(129, 30);
            this.txtnommascota.TabIndex = 1;
            // 
            // lstAtención
            // 
            this.lstAtención.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAtención.ForeColor = System.Drawing.Color.Blue;
            this.lstAtención.FormattingEnabled = true;
            this.lstAtención.ItemHeight = 21;
            this.lstAtención.Location = new System.Drawing.Point(559, 125);
            this.lstAtención.Name = "lstAtención";
            this.lstAtención.Size = new System.Drawing.Size(197, 130);
            this.lstAtención.TabIndex = 3;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(556, 55);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 2;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(646, 272);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(124, 20);
            this.txtimporte.TabIndex = 6;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Blue;
            this.btnnuevo.Location = new System.Drawing.Point(28, 257);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(77, 35);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.ForeColor = System.Drawing.Color.Blue;
            this.btngrabar.Location = new System.Drawing.Point(111, 257);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(78, 35);
            this.btngrabar.TabIndex = 0;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // txtatencion
            // 
            this.txtatencion.AutoSize = true;
            this.txtatencion.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtatencion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtatencion.Location = new System.Drawing.Point(555, 13);
            this.txtatencion.Name = "txtatencion";
            this.txtatencion.Size = new System.Drawing.Size(69, 23);
            this.txtatencion.TabIndex = 8;
            this.txtatencion.Text = "Atención";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(557, 92);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(199, 20);
            this.txtdescripcion.TabIndex = 9;
            // 
            // txtidatencion
            // 
            this.txtidatencion.Location = new System.Drawing.Point(656, 16);
            this.txtidatencion.Name = "txtidatencion";
            this.txtidatencion.Size = new System.Drawing.Size(100, 20);
            this.txtidatencion.TabIndex = 10;
            this.txtidatencion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblnum.Location = new System.Drawing.Point(630, 16);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(26, 23);
            this.lblnum.TabIndex = 11;
            this.lblnum.Text = "n°";
            // 
            // VeterinariaMelgar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(778, 310);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.txtidatencion);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtatencion);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lstAtención);
            this.Controls.Add(this.grbmascota);
            this.Controls.Add(this.grcliente);
            this.Controls.Add(this.lblimporte);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VeterinariaMelgar";
            this.Text = "Veterinaria Melgar";
            this.Load += new System.EventHandler(this.grbdueño_Load);
            this.grcliente.ResumeLayout(false);
            this.grcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbmascota.ResumeLayout(false);
            this.grbmascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.RadioButton rdbfemenino;
        private System.Windows.Forms.RadioButton rdbmasc;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblimporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grcliente;
        private System.Windows.Forms.GroupBox grbmascota;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnommascota;
        private System.Windows.Forms.ListBox lstAtención;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rdbdias;
        private System.Windows.Forms.RadioButton rdbaño;
        private System.Windows.Forms.Label txtatencion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtidatencion;
        private System.Windows.Forms.Label lblnum;
    }
}

