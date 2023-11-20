namespace firtsGame_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new PictureBox();
            TuboAbajo = new PictureBox();
            Barra = new PictureBox();
            TuboArriba = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Puntaje = new Label();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TuboAbajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TuboArriba).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.AccessibleName = "Player";
            Player.BackColor = Color.Transparent;
            Player.BackgroundImageLayout = ImageLayout.None;
            Player.Image = Properties.Resources.fr1;
            Player.Location = new Point(0, 194);
            Player.Name = "Player";
            Player.Size = new Size(78, 61);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // TuboAbajo
            // 
            TuboAbajo.AccessibleName = "Tuboabajo";
            TuboAbajo.BackColor = Color.Transparent;
            TuboAbajo.BackgroundImageLayout = ImageLayout.Stretch;
            TuboAbajo.Image = (Image)resources.GetObject("TuboAbajo.Image");
            TuboAbajo.Location = new Point(126, 283);
            TuboAbajo.Name = "TuboAbajo";
            TuboAbajo.Size = new Size(82, 266);
            TuboAbajo.SizeMode = PictureBoxSizeMode.StretchImage;
            TuboAbajo.TabIndex = 1;
            TuboAbajo.TabStop = false;
            // 
            // Barra
            // 
            Barra.AccessibleName = "Barra";
            Barra.BackColor = Color.Black;
            Barra.BackgroundImageLayout = ImageLayout.Stretch;
            Barra.Image = (Image)resources.GetObject("Barra.Image");
            Barra.Location = new Point(-223, 435);
            Barra.Name = "Barra";
            Barra.Size = new Size(963, 40);
            Barra.SizeMode = PictureBoxSizeMode.StretchImage;
            Barra.TabIndex = 2;
            Barra.TabStop = false;
            // 
            // TuboArriba
            // 
            TuboArriba.AccessibleName = "TuboArriba";
            TuboArriba.BackColor = Color.Transparent;
            TuboArriba.BackgroundImageLayout = ImageLayout.Stretch;
            TuboArriba.Image = (Image)resources.GetObject("TuboArriba.Image");
            TuboArriba.Location = new Point(126, -85);
            TuboArriba.Name = "TuboArriba";
            TuboArriba.Size = new Size(82, 271);
            TuboArriba.SizeMode = PictureBoxSizeMode.StretchImage;
            TuboArriba.TabIndex = 3;
            TuboArriba.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 10;
            timer3.Tick += timer3_Tick;
            // 
            // Puntaje
            // 
            Puntaje.AutoSize = true;
            Puntaje.BackColor = Color.IndianRed;
            Puntaje.BorderStyle = BorderStyle.Fixed3D;
            Puntaje.Font = new Font("Modern No. 20", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Puntaje.ForeColor = Color.Snow;
            Puntaje.Location = new Point(12, 9);
            Puntaje.Name = "Puntaje";
            Puntaje.Size = new Size(28, 31);
            Puntaje.TabIndex = 6;
            Puntaje.Text = "0";
            Puntaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(292, 464);
            Controls.Add(Puntaje);
            Controls.Add(TuboArriba);
            Controls.Add(Barra);
            Controls.Add(TuboAbajo);
            Controls.Add(Player);
            DoubleBuffered = true;
            MaximumSize = new Size(308, 503);
            MinimumSize = new Size(308, 503);
            Name = "Form1";
            Text = "FlapppyGon";
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)TuboAbajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barra).EndInit();
            ((System.ComponentModel.ISupportInitialize)TuboArriba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player;
        private PictureBox TuboAbajo;
        private PictureBox Barra;
        private PictureBox TuboArriba;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label Puntaje;
    }
}