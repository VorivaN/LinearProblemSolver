
namespace LinearProblemSolverApplication
{
    partial class InputWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SolveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MinimumRadioButton = new System.Windows.Forms.RadioButton();
            this.MaximumRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RationalNumbers = new System.Windows.Forms.RadioButton();
            this.DecimalNumbers = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AimFunctionTable = new System.Windows.Forms.DataGridView();
            this.RestrictionsTable = new System.Windows.Forms.DataGridView();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.Variables = new System.Windows.Forms.Label();
            this.Restrictions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AimFunctionTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictionsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(749, 21);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(248, 29);
            this.SolveButton.TabIndex = 10;
            this.SolveButton.Text = "Сохранить и перейти к решению";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MinimumRadioButton);
            this.groupBox2.Controls.Add(this.MaximumRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(268, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ищем";
            // 
            // MinimumRadioButton
            // 
            this.MinimumRadioButton.AutoSize = true;
            this.MinimumRadioButton.Checked = true;
            this.MinimumRadioButton.Location = new System.Drawing.Point(16, 25);
            this.MinimumRadioButton.Name = "MinimumRadioButton";
            this.MinimumRadioButton.Size = new System.Drawing.Size(81, 19);
            this.MinimumRadioButton.TabIndex = 1;
            this.MinimumRadioButton.TabStop = true;
            this.MinimumRadioButton.Text = "Минимум";
            this.MinimumRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaximumRadioButton
            // 
            this.MaximumRadioButton.AutoSize = true;
            this.MaximumRadioButton.Location = new System.Drawing.Point(16, 50);
            this.MaximumRadioButton.Name = "MaximumRadioButton";
            this.MaximumRadioButton.Size = new System.Drawing.Size(85, 19);
            this.MaximumRadioButton.TabIndex = 0;
            this.MaximumRadioButton.Text = "Максимум";
            this.MaximumRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RationalNumbers);
            this.groupBox1.Controls.Add(this.DecimalNumbers);
            this.groupBox1.Location = new System.Drawing.Point(498, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип дробных чисел";
            // 
            // RationalNumbers
            // 
            this.RationalNumbers.AutoSize = true;
            this.RationalNumbers.Checked = true;
            this.RationalNumbers.Location = new System.Drawing.Point(16, 25);
            this.RationalNumbers.Name = "RationalNumbers";
            this.RationalNumbers.Size = new System.Drawing.Size(111, 19);
            this.RationalNumbers.TabIndex = 1;
            this.RationalNumbers.TabStop = true;
            this.RationalNumbers.Text = "Простые дроби";
            this.RationalNumbers.UseVisualStyleBackColor = true;
            // 
            // DecimalNumbers
            // 
            this.DecimalNumbers.AutoSize = true;
            this.DecimalNumbers.Location = new System.Drawing.Point(16, 50);
            this.DecimalNumbers.Name = "DecimalNumbers";
            this.DecimalNumbers.Size = new System.Drawing.Size(129, 19);
            this.DecimalNumbers.TabIndex = 0;
            this.DecimalNumbers.Text = "Десятичные дроби";
            this.DecimalNumbers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Целевая функция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Матрица ограничений";
            // 
            // AimFunctionTable
            // 
            this.AimFunctionTable.AllowUserToAddRows = false;
            this.AimFunctionTable.AllowUserToDeleteRows = false;
            this.AimFunctionTable.AllowUserToResizeColumns = false;
            this.AimFunctionTable.AllowUserToResizeRows = false;
            this.AimFunctionTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimFunctionTable.Location = new System.Drawing.Point(11, 123);
            this.AimFunctionTable.Name = "AimFunctionTable";
            this.AimFunctionTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AimFunctionTable.RowHeadersWidth = 50;
            this.AimFunctionTable.RowTemplate.Height = 25;
            this.AimFunctionTable.Size = new System.Drawing.Size(1028, 66);
            this.AimFunctionTable.TabIndex = 5;
            // 
            // RestrictionsTable
            // 
            this.RestrictionsTable.AllowUserToAddRows = false;
            this.RestrictionsTable.AllowUserToDeleteRows = false;
            this.RestrictionsTable.AllowUserToResizeColumns = false;
            this.RestrictionsTable.AllowUserToResizeRows = false;
            this.RestrictionsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestrictionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestrictionsTable.Location = new System.Drawing.Point(11, 220);
            this.RestrictionsTable.Name = "RestrictionsTable";
            this.RestrictionsTable.RowHeadersWidth = 50;
            this.RestrictionsTable.RowTemplate.Height = 25;
            this.RestrictionsTable.Size = new System.Drawing.Size(1028, 337);
            this.RestrictionsTable.TabIndex = 4;
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(186, 13);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(51, 23);
            this.numericUpDownN.TabIndex = 0;
            this.numericUpDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.ValueChanged += new System.EventHandler(this.numericUpDownN_ValueChanged);
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(186, 39);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(51, 23);
            this.numericUpDownM.TabIndex = 1;
            this.numericUpDownM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.numericUpDownM_ValueChanged);
            // 
            // Variables
            // 
            this.Variables.AutoSize = true;
            this.Variables.Location = new System.Drawing.Point(11, 21);
            this.Variables.Name = "Variables";
            this.Variables.Size = new System.Drawing.Size(145, 15);
            this.Variables.TabIndex = 2;
            this.Variables.Text = "Количество переменных";
            // 
            // Restrictions
            // 
            this.Restrictions.AutoSize = true;
            this.Restrictions.Location = new System.Drawing.Point(11, 47);
            this.Restrictions.Name = "Restrictions";
            this.Restrictions.Size = new System.Drawing.Size(148, 15);
            this.Restrictions.TabIndex = 3;
            this.Restrictions.Text = "Количество ограничений";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.RestrictionsTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AimFunctionTable);
            this.panel1.Controls.Add(this.SolveButton);
            this.panel1.Controls.Add(this.Variables);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Restrictions);
            this.panel1.Controls.Add(this.numericUpDownN);
            this.panel1.Controls.Add(this.numericUpDownM);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 567);
            this.panel1.TabIndex = 2;
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "InputWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinearProblemSolver";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AimFunctionTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestrictionsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton MinimumRadioButton;
        private System.Windows.Forms.RadioButton MaximumRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RationalNumbers;
        private System.Windows.Forms.RadioButton DecimalNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AimFunctionTable;
        private System.Windows.Forms.DataGridView RestrictionsTable;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Label Variables;
        private System.Windows.Forms.Label Restrictions;
        private System.Windows.Forms.Panel panel1;
    }
}

