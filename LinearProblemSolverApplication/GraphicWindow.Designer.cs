
namespace LinearProblemSolverApplication
{
    partial class GraphicWindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaxXUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScaleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PtSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MaxXUpDown
            // 
            this.MaxXUpDown.Location = new System.Drawing.Point(610, 30);
            this.MaxXUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxXUpDown.Name = "MaxXUpDown";
            this.MaxXUpDown.Size = new System.Drawing.Size(184, 23);
            this.MaxXUpDown.TabIndex = 1;
            this.MaxXUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MaxXUpDown.ValueChanged += new System.EventHandler(this.MaxXUpDown_ValueChanged);
            // 
            // ScaleUpDown
            // 
            this.ScaleUpDown.Location = new System.Drawing.Point(610, 87);
            this.ScaleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleUpDown.Name = "ScaleUpDown";
            this.ScaleUpDown.Size = new System.Drawing.Size(184, 23);
            this.ScaleUpDown.TabIndex = 2;
            this.ScaleUpDown.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.ScaleUpDown.ValueChanged += new System.EventHandler(this.ScaleUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Максимальный X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество пикселей в ед. изм.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер точек (px)";
            // 
            // PtSizeUpDown
            // 
            this.PtSizeUpDown.Location = new System.Drawing.Point(611, 136);
            this.PtSizeUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PtSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PtSizeUpDown.Name = "PtSizeUpDown";
            this.PtSizeUpDown.Size = new System.Drawing.Size(183, 23);
            this.PtSizeUpDown.TabIndex = 6;
            this.PtSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PtSizeUpDown.ValueChanged += new System.EventHandler(this.PtSizeUpDown_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(613, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 17);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "- графики ограничений";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(613, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 17);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "- допустимыe решения";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(613, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 17);
            this.panel3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "- целевая функция";
            // 
            // GraphicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PtSizeUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleUpDown);
            this.Controls.Add(this.MaxXUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GraphicWindow";
            this.Text = "GraphicWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtSizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown MaxXUpDown;
        private System.Windows.Forms.NumericUpDown ScaleUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PtSizeUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
    }
}