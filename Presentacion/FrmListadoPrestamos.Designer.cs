namespace Presentacion
{
    partial class FrmListadoPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPrestamos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.dgvprestamos = new System.Windows.Forms.DataGridView();
            this.btnatras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(29, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 86);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnmostrar.Location = new System.Drawing.Point(29, 172);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(93, 47);
            this.btnmostrar.TabIndex = 9;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // dgvprestamos
            // 
            this.dgvprestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprestamos.Location = new System.Drawing.Point(143, 52);
            this.dgvprestamos.Name = "dgvprestamos";
            this.dgvprestamos.Size = new System.Drawing.Size(588, 237);
            this.dgvprestamos.TabIndex = 8;
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnatras.Location = new System.Drawing.Point(29, 242);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(93, 47);
            this.btnatras.TabIndex = 7;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // FrmListadoPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.dgvprestamos);
            this.Controls.Add(this.btnatras);
            this.Name = "FrmListadoPrestamos";
            this.Text = "Lista de solitudes Préstamos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.DataGridView dgvprestamos;
        private System.Windows.Forms.Button btnatras;
    }
}