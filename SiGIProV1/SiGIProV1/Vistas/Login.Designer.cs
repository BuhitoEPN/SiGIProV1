﻿namespace SiGIProV1.Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lEmpresa = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lMensajeError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lEmpresa
            // 
            this.lEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lEmpresa.AutoSize = true;
            this.lEmpresa.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpresa.ForeColor = System.Drawing.Color.Gainsboro;
            this.lEmpresa.Location = new System.Drawing.Point(12, 312);
            this.lEmpresa.Name = "lEmpresa";
            this.lEmpresa.Size = new System.Drawing.Size(82, 9);
            this.lEmpresa.TabIndex = 12;
            this.lEmpresa.Text = "Provisto por Nogal S.A.";
            // 
            // tPassword
            // 
            this.tPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tPassword.Location = new System.Drawing.Point(307, 167);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(417, 27);
            this.tPassword.TabIndex = 18;
            this.tPassword.Text = "CONTRASEÑA";
            this.tPassword.Enter += new System.EventHandler(this.tPassword_Enter);
            this.tPassword.Leave += new System.EventHandler(this.tPassword_Leave);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Location = new System.Drawing.Point(558, 269);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(164, 40);
            this.bSalir.TabIndex = 19;
            this.bSalir.TabStop = false;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bAceptar.FlatAppearance.BorderSize = 0;
            this.bAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bAceptar.Location = new System.Drawing.Point(307, 269);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(247, 40);
            this.bAceptar.TabIndex = 20;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tUsuario
            // 
            this.tUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.tUsuario.Location = new System.Drawing.Point(307, 106);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(417, 27);
            this.tUsuario.TabIndex = 17;
            this.tUsuario.Text = "USUARIO";
            this.tUsuario.Enter += new System.EventHandler(this.tUsuario_Enter);
            this.tUsuario.Leave += new System.EventHandler(this.tUsuario_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(406, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "SiGIProV-RUESCO";
            // 
            // lMensajeError
            // 
            this.lMensajeError.AutoSize = true;
            this.lMensajeError.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajeError.ForeColor = System.Drawing.Color.Gainsboro;
            this.lMensajeError.Image = ((System.Drawing.Image)(resources.GetObject("lMensajeError.Image")));
            this.lMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lMensajeError.Location = new System.Drawing.Point(305, 223);
            this.lMensajeError.Name = "lMensajeError";
            this.lMensajeError.Size = new System.Drawing.Size(113, 17);
            this.lMensajeError.TabIndex = 21;
            this.lMensajeError.Text = "Mensaje de Error";
            this.lMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lMensajeError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lMensajeError);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "LoginCargoDAO";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lEmpresa;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lMensajeError;
    }
}