namespace Presentacion
{
    partial class FrmListadoxEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoxEstado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnatras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlistaclientes = new System.Windows.Forms.DataGridView();
            this.cboestado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 131);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(9, 330);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(73, 38);
            this.btnatras.TabIndex = 13;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione el estado que desea buscar.";
            // 
            // dgvlistaclientes
            // 
            this.dgvlistaclientes.AllowUserToAddRows = false;
            this.dgvlistaclientes.AllowUserToDeleteRows = false;
            this.dgvlistaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistaclientes.Location = new System.Drawing.Point(175, 78);
            this.dgvlistaclientes.Name = "dgvlistaclientes";
            this.dgvlistaclientes.ReadOnly = true;
            this.dgvlistaclientes.Size = new System.Drawing.Size(655, 290);
            this.dgvlistaclientes.TabIndex = 10;
            // 
            // cboestado
            // 
            this.cboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(175, 44);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(176, 28);
            this.cboestado.TabIndex = 15;
            // 
            // FrmListadoxEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 388);
            this.Controls.Add(this.cboestado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlistaclientes);
            this.Name = "FrmListadoxEstado";
            this.Text = "Listado de Clientes por Estado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlistaclientes;
        private System.Windows.Forms.ComboBox cboestado;
    }
}