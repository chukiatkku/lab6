namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            LabelName = new Label();
            label2 = new Label();
            loadPikachu = new Button();
            loadMagikarp = new Button();
            loadCastform = new Button();
            loadTogepi = new Button();
            Eevee = new Button();
            loadFletchling = new Button();
            loadArceus = new Button();
            pictureBox2 = new PictureBox();
            LabelMonster = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(36, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(111, 228);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(70, 20);
            LabelName.TabIndex = 1;
            LabelName.Text = "Pokemon";
            LabelName.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 322);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // loadPikachu
            // 
            loadPikachu.Location = new Point(23, 283);
            loadPikachu.Name = "loadPikachu";
            loadPikachu.Size = new Size(160, 29);
            loadPikachu.TabIndex = 3;
            loadPikachu.Text = "load Pokemon";
            loadPikachu.UseVisualStyleBackColor = true;
            loadPikachu.Click += buttonLoad_Click;
            // 
            // loadMagikarp
            // 
            loadMagikarp.Location = new Point(23, 318);
            loadMagikarp.Name = "loadMagikarp";
            loadMagikarp.Size = new Size(160, 29);
            loadMagikarp.TabIndex = 4;
            loadMagikarp.Text = "load Pokemon";
            loadMagikarp.UseVisualStyleBackColor = true;
            loadMagikarp.Click += button1_Click;
            // 
            // loadCastform
            // 
            loadCastform.Location = new Point(23, 353);
            loadCastform.Name = "loadCastform";
            loadCastform.Size = new Size(160, 29);
            loadCastform.TabIndex = 6;
            loadCastform.Text = "load Pokemon";
            loadCastform.UseVisualStyleBackColor = true;
            loadCastform.Click += loadCastform_Click;
            // 
            // loadTogepi
            // 
            loadTogepi.Location = new Point(207, 283);
            loadTogepi.Name = "loadTogepi";
            loadTogepi.Size = new Size(160, 29);
            loadTogepi.TabIndex = 7;
            loadTogepi.Text = "load Pokemon";
            loadTogepi.UseVisualStyleBackColor = true;
            loadTogepi.Click += loadTogepi_Click;
            // 
            // Eevee
            // 
            Eevee.Location = new Point(207, 318);
            Eevee.Name = "Eevee";
            Eevee.Size = new Size(160, 29);
            Eevee.TabIndex = 8;
            Eevee.Text = "load Pokemon";
            Eevee.UseVisualStyleBackColor = true;
            Eevee.Click += Eevee_Click;
            // 
            // loadFletchling
            // 
            loadFletchling.Location = new Point(207, 353);
            loadFletchling.Name = "loadFletchling";
            loadFletchling.Size = new Size(160, 29);
            loadFletchling.TabIndex = 9;
            loadFletchling.Text = "load Pokemon";
            loadFletchling.UseVisualStyleBackColor = true;
            loadFletchling.Click += loadFletchling_Click;
            // 
            // loadArceus
            // 
            loadArceus.Location = new Point(562, 283);
            loadArceus.Name = "loadArceus";
            loadArceus.Size = new Size(183, 29);
            loadArceus.TabIndex = 10;
            loadArceus.Text = "load monster ";
            loadArceus.UseVisualStyleBackColor = true;
            loadArceus.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(523, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // LabelMonster
            // 
            LabelMonster.AutoSize = true;
            LabelMonster.Location = new Point(625, 228);
            LabelMonster.Name = "LabelMonster";
            LabelMonster.Size = new Size(63, 20);
            LabelMonster.TabIndex = 12;
            LabelMonster.Text = "Monster";
            LabelMonster.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelMonster);
            Controls.Add(pictureBox2);
            Controls.Add(loadArceus);
            Controls.Add(loadFletchling);
            Controls.Add(Eevee);
            Controls.Add(loadTogepi);
            Controls.Add(loadCastform);
            Controls.Add(loadMagikarp);
            Controls.Add(loadPikachu);
            Controls.Add(label2);
            Controls.Add(LabelName);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LabelName;
        private Label label2;
        private Button loadPikachu;
        private Button loadMagikarp;
        private Button loadCastform;
        private Button loadTogepi;
        private Button Eevee;
        private Button loadFletchling;
        private Button loadArceus;
        private PictureBox pictureBox2;
        private Label LabelMonster;
    }
}
