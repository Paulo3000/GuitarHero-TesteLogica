namespace GuitarHv001
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
            picBlue = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            picGreen = new PictureBox();
            picRed = new PictureBox();
            picYellow = new PictureBox();
            picOrange = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            picPeca01 = new PictureBox();
            picPeca02 = new PictureBox();
            picPeca03 = new PictureBox();
            picPeca05 = new PictureBox();
            picPeca04 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPeca01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPeca02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPeca03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPeca05).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPeca04).BeginInit();
            SuspendLayout();
            // 
            // picBlue
            // 
            picBlue.BackColor = Color.DodgerBlue;
            picBlue.Location = new Point(415, 385);
            picBlue.Name = "picBlue";
            picBlue.Size = new Size(61, 57);
            picBlue.TabIndex = 0;
            picBlue.TabStop = false;
            picBlue.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(732, 23);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // picGreen
            // 
            picGreen.BackColor = Color.LimeGreen;
            picGreen.Location = new Point(209, 385);
            picGreen.Name = "picGreen";
            picGreen.Size = new Size(61, 57);
            picGreen.TabIndex = 2;
            picGreen.TabStop = false;
            // 
            // picRed
            // 
            picRed.BackColor = Color.Firebrick;
            picRed.Location = new Point(279, 385);
            picRed.Name = "picRed";
            picRed.Size = new Size(61, 57);
            picRed.TabIndex = 3;
            picRed.TabStop = false;
            // 
            // picYellow
            // 
            picYellow.BackColor = Color.Yellow;
            picYellow.Location = new Point(347, 385);
            picYellow.Name = "picYellow";
            picYellow.Size = new Size(61, 57);
            picYellow.TabIndex = 4;
            picYellow.TabStop = false;
            // 
            // picOrange
            // 
            picOrange.BackColor = Color.OrangeRed;
            picOrange.Location = new Point(483, 385);
            picOrange.Name = "picOrange";
            picOrange.Size = new Size(61, 57);
            picOrange.TabIndex = 5;
            picOrange.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // picPeca01
            // 
            picPeca01.BackColor = Color.LimeGreen;
            picPeca01.Location = new Point(211, 0);
            picPeca01.Name = "picPeca01";
            picPeca01.Size = new Size(41, 38);
            picPeca01.TabIndex = 6;
            picPeca01.TabStop = false;
            // 
            // picPeca02
            // 
            picPeca02.BackColor = Color.Red;
            picPeca02.Location = new Point(279, 73);
            picPeca02.Name = "picPeca02";
            picPeca02.Size = new Size(41, 38);
            picPeca02.TabIndex = 7;
            picPeca02.TabStop = false;
            // 
            // picPeca03
            // 
            picPeca03.BackColor = Color.Yellow;
            picPeca03.Location = new Point(347, 184);
            picPeca03.Name = "picPeca03";
            picPeca03.Size = new Size(41, 38);
            picPeca03.TabIndex = 8;
            picPeca03.TabStop = false;
            // 
            // picPeca05
            // 
            picPeca05.BackColor = Color.OrangeRed;
            picPeca05.Location = new Point(483, 143);
            picPeca05.Name = "picPeca05";
            picPeca05.Size = new Size(41, 38);
            picPeca05.TabIndex = 9;
            picPeca05.TabStop = false;
            // 
            // picPeca04
            // 
            picPeca04.BackColor = Color.DodgerBlue;
            picPeca04.Location = new Point(415, 32);
            picPeca04.Name = "picPeca04";
            picPeca04.Size = new Size(41, 38);
            picPeca04.TabIndex = 10;
            picPeca04.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picPeca04);
            Controls.Add(picPeca05);
            Controls.Add(picPeca03);
            Controls.Add(picPeca02);
            Controls.Add(picOrange);
            Controls.Add(picYellow);
            Controls.Add(picRed);
            Controls.Add(picGreen);
            Controls.Add(label1);
            Controls.Add(picBlue);
            Controls.Add(picPeca01);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)picYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPeca01).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPeca02).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPeca03).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPeca05).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPeca04).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBlue;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox picGreen;
        private PictureBox picRed;
        private PictureBox picYellow;
        private PictureBox picOrange;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picPeca01;
        private PictureBox picPeca02;
        private PictureBox picPeca03;
        private PictureBox picPeca05;
        private PictureBox picPeca04;
    }
}