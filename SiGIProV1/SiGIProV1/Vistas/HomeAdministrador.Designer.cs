namespace SiGIProV1.Vistas
{
    partial class HomeAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdministrador));
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.panelEscritorio.Controls.Add(this.labelFecha);
            this.panelEscritorio.Controls.Add(this.labelSaludo);
            this.panelEscritorio.Controls.Add(this.labelHora);
            this.panelEscritorio.Controls.Add(this.pictureUsuario);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(0, 0);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1080, 609);
            this.panelEscritorio.TabIndex = 7;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.labelFecha.Location = new System.Drawing.Point(178, 368);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(173, 63);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "label1";
            // 
            // labelSaludo
            // 
            this.labelSaludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.labelSaludo.Location = new System.Drawing.Point(310, 18);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(459, 41);
            this.labelSaludo.TabIndex = 2;
            this.labelSaludo.Text = "Bienvenido, Administrador";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.labelHora.Location = new System.Drawing.Point(368, 488);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(249, 91);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "label1";
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.Image")));
            this.pictureUsuario.Location = new System.Drawing.Point(402, 71);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(275, 252);
            this.pictureUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario.TabIndex = 0;
            this.pictureUsuario.TabStop = false;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // HomeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 609);
            this.Controls.Add(this.panelEscritorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeAdministrador";
            this.Text = "HomeAdministrador";
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox pictureUsuario;
        private System.Windows.Forms.Timer horaFecha;
    }
}