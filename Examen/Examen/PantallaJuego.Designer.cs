namespace Examen
{
    partial class PantallaJuego
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TB_Puntos = new System.Windows.Forms.TextBox();
            this.TB_PuntosText = new System.Windows.Forms.TextBox();
            this.PB_FantasmaRosa = new System.Windows.Forms.PictureBox();
            this.PB_FantasmaRojo = new System.Windows.Forms.PictureBox();
            this.PB_Pacman = new System.Windows.Forms.PictureBox();
            this.PB_Cherry = new System.Windows.Forms.PictureBox();
            this.PB_Pear = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FantasmaRosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FantasmaRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TB_Puntos
            // 
            this.TB_Puntos.BackColor = System.Drawing.SystemColors.InfoText;
            this.TB_Puntos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Puntos.Enabled = false;
            this.TB_Puntos.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_Puntos.Location = new System.Drawing.Point(500, 7);
            this.TB_Puntos.Name = "TB_Puntos";
            this.TB_Puntos.Size = new System.Drawing.Size(43, 13);
            this.TB_Puntos.TabIndex = 132;
            this.TB_Puntos.Text = "000000";
            // 
            // TB_PuntosText
            // 
            this.TB_PuntosText.BackColor = System.Drawing.SystemColors.InfoText;
            this.TB_PuntosText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PuntosText.Enabled = false;
            this.TB_PuntosText.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_PuntosText.Location = new System.Drawing.Point(436, 7);
            this.TB_PuntosText.Name = "TB_PuntosText";
            this.TB_PuntosText.Size = new System.Drawing.Size(58, 13);
            this.TB_PuntosText.TabIndex = 133;
            this.TB_PuntosText.Text = "PUNTOS:";
            this.TB_PuntosText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PB_FantasmaRosa
            // 
            this.PB_FantasmaRosa.Image = global::Examen.Properties.Resources.pink_left1;
            this.PB_FantasmaRosa.Location = new System.Drawing.Point(461, 259);
            this.PB_FantasmaRosa.Name = "PB_FantasmaRosa";
            this.PB_FantasmaRosa.Size = new System.Drawing.Size(20, 20);
            this.PB_FantasmaRosa.TabIndex = 135;
            this.PB_FantasmaRosa.TabStop = false;
            this.PB_FantasmaRosa.UseWaitCursor = true;
            // 
            // PB_FantasmaRojo
            // 
            this.PB_FantasmaRojo.Image = global::Examen.Properties.Resources.red_left1;
            this.PB_FantasmaRojo.Location = new System.Drawing.Point(101, 87);
            this.PB_FantasmaRojo.Name = "PB_FantasmaRojo";
            this.PB_FantasmaRojo.Size = new System.Drawing.Size(20, 20);
            this.PB_FantasmaRojo.TabIndex = 134;
            this.PB_FantasmaRojo.TabStop = false;
            this.PB_FantasmaRojo.UseWaitCursor = true;
            // 
            // PB_Pacman
            // 
            this.PB_Pacman.Image = global::Examen.Properties.Resources.pacman_left;
            this.PB_Pacman.Location = new System.Drawing.Point(267, 189);
            this.PB_Pacman.Name = "PB_Pacman";
            this.PB_Pacman.Size = new System.Drawing.Size(20, 20);
            this.PB_Pacman.TabIndex = 131;
            this.PB_Pacman.TabStop = false;
            this.PB_Pacman.UseWaitCursor = true;
            // 
            // PB_Cherry
            // 
            this.PB_Cherry.Image = global::Examen.Properties.Resources.cherry;
            this.PB_Cherry.Location = new System.Drawing.Point(371, 87);
            this.PB_Cherry.Name = "PB_Cherry";
            this.PB_Cherry.Size = new System.Drawing.Size(20, 20);
            this.PB_Cherry.TabIndex = 136;
            this.PB_Cherry.TabStop = false;
            this.PB_Cherry.UseWaitCursor = true;
            this.PB_Cherry.Visible = false;
            // 
            // PB_Pear
            // 
            this.PB_Pear.Image = global::Examen.Properties.Resources.tile114;
            this.PB_Pear.Location = new System.Drawing.Point(446, 87);
            this.PB_Pear.Name = "PB_Pear";
            this.PB_Pear.Size = new System.Drawing.Size(20, 20);
            this.PB_Pear.TabIndex = 137;
            this.PB_Pear.TabStop = false;
            this.PB_Pear.UseWaitCursor = true;
            this.PB_Pear.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(65, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 139;
            this.label3.Text = "Tiempo";
            // 
            // PantallaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(555, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PB_Pear);
            this.Controls.Add(this.PB_Cherry);
            this.Controls.Add(this.PB_FantasmaRosa);
            this.Controls.Add(this.PB_FantasmaRojo);
            this.Controls.Add(this.TB_PuntosText);
            this.Controls.Add(this.TB_Puntos);
            this.Controls.Add(this.PB_Pacman);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(571, 462);
            this.MinimumSize = new System.Drawing.Size(571, 462);
            this.Name = "PantallaJuego";
            this.Text = "PantallaJuego";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PantallaJuego_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PB_FantasmaRosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_FantasmaRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_Pacman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TB_Puntos;
        private System.Windows.Forms.TextBox TB_PuntosText;
        private System.Windows.Forms.PictureBox PB_FantasmaRojo;
        private System.Windows.Forms.PictureBox PB_FantasmaRosa;
        private System.Windows.Forms.PictureBox PB_Cherry;
        private System.Windows.Forms.PictureBox PB_Pear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}