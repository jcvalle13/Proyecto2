namespace Presentacion
{
    partial class FrmEnvioMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnvioMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCorreos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnatras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbcarga2 = new System.Windows.Forms.ProgressBar();
            this.pbcarga = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(164, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de correo electrónico";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEnviar.Location = new System.Drawing.Point(320, 83);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(148, 83);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(148, 49);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(247, 21);
            this.txtcorreo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo electrónico";
            // 
            // dgvCorreos
            // 
            this.dgvCorreos.AllowUserToAddRows = false;
            this.dgvCorreos.AllowUserToDeleteRows = false;
            this.dgvCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEliminar,
            this.txtmail});
            this.dgvCorreos.Location = new System.Drawing.Point(164, 201);
            this.dgvCorreos.Name = "dgvCorreos";
            this.dgvCorreos.ReadOnly = true;
            this.dgvCorreos.RowHeadersVisible = false;
            this.dgvCorreos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorreos.Size = new System.Drawing.Size(453, 150);
            this.dgvCorreos.TabIndex = 1;
            this.dgvCorreos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorreos_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Visible = false;
            // 
            // txtmail
            // 
            this.txtmail.HeaderText = "CorreoElectronico";
            this.txtmail.Name = "txtmail";
            this.txtmail.ReadOnly = true;
            this.txtmail.Width = 450;
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnatras.Location = new System.Drawing.Point(22, 311);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(74, 40);
            this.btnatras.TabIndex = 9;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(22, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pbcarga2
            // 
            this.pbcarga2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbcarga2.Location = new System.Drawing.Point(444, 169);
            this.pbcarga2.Name = "pbcarga2";
            this.pbcarga2.Size = new System.Drawing.Size(173, 17);
            this.pbcarga2.TabIndex = 19;
            // 
            // pbcarga
            // 
            this.pbcarga.BackColor = System.Drawing.SystemColors.Control;
            this.pbcarga.ForeColor = System.Drawing.Color.DarkOrange;
            this.pbcarga.Location = new System.Drawing.Point(293, 169);
            this.pbcarga.Name = "pbcarga";
            this.pbcarga.Size = new System.Drawing.Size(155, 17);
            this.pbcarga.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmEnvioMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 363);
            this.Controls.Add(this.pbcarga2);
            this.Controls.Add(this.pbcarga);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.dgvCorreos);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envío correo electrónico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCorreos;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtmail;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbcarga2;
        private System.Windows.Forms.ProgressBar pbcarga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}