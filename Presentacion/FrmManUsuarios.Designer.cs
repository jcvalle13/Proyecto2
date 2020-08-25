namespace Presentacion
{
    partial class FrmManUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManUsuarios));
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPerfiles = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gdvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnListaUsuario = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Location = new System.Drawing.Point(217, 16);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 44);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnmenu.Location = new System.Drawing.Point(339, 16);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(82, 45);
            this.btnmenu.TabIndex = 30;
            this.btnmenu.Text = "Atrás";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnmodificar.Location = new System.Drawing.Point(113, 16);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 44);
            this.btnmodificar.TabIndex = 29;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnagregar.Location = new System.Drawing.Point(6, 16);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(82, 44);
            this.btnagregar.TabIndex = 28;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(142, 78);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(140, 21);
            this.cboestado.TabIndex = 24;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(142, 52);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(193, 20);
            this.txtcontraseña.TabIndex = 23;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(142, 24);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(193, 20);
            this.txtUsuario.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboPerfiles);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcontraseña);
            this.groupBox1.Controls.Add(this.cboestado);
            this.groupBox1.Location = new System.Drawing.Point(121, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 152);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Perfil";
            // 
            // cboPerfiles
            // 
            this.cboPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfiles.FormattingEnabled = true;
            this.cboPerfiles.Location = new System.Drawing.Point(142, 112);
            this.cboPerfiles.Name = "cboPerfiles";
            this.cboPerfiles.Size = new System.Drawing.Size(140, 21);
            this.cboPerfiles.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // gdvUsuarios
            // 
            this.gdvUsuarios.AllowUserToAddRows = false;
            this.gdvUsuarios.AllowUserToDeleteRows = false;
            this.gdvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvUsuarios.Location = new System.Drawing.Point(553, 65);
            this.gdvUsuarios.Name = "gdvUsuarios";
            this.gdvUsuarios.ReadOnly = true;
            this.gdvUsuarios.RowHeadersVisible = false;
            this.gdvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvUsuarios.Size = new System.Drawing.Size(427, 210);
            this.gdvUsuarios.TabIndex = 35;
            // 
            // btnListaUsuario
            // 
            this.btnListaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnListaUsuario.Location = new System.Drawing.Point(1, 188);
            this.btnListaUsuario.Name = "btnListaUsuario";
            this.btnListaUsuario.Size = new System.Drawing.Size(103, 29);
            this.btnListaUsuario.TabIndex = 34;
            this.btnListaUsuario.Text = "Mostrar Lista";
            this.btnListaUsuario.UseVisualStyleBackColor = true;
            this.btnListaUsuario.Click += new System.EventHandler(this.btnListaUsuario_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnagregar);
            this.groupBox3.Controls.Add(this.btnmodificar);
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.btnmenu);
            this.groupBox3.Location = new System.Drawing.Point(553, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 66);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // FrmManUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 362);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gdvUsuarios);
            this.Controls.Add(this.btnListaUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPerfiles;
        private System.Windows.Forms.DataGridView gdvUsuarios;
        private System.Windows.Forms.Button btnListaUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}