
namespace LinearProblemSolverApplication
{
    partial class SolveWindow
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LastStep = new System.Windows.Forms.Button();
            this.PrevStep = new System.Windows.Forms.Button();
            this.NextStep = new System.Windows.Forms.Button();
            this.FirstStep = new System.Windows.Forms.Button();
            this.ViewGroupBox = new System.Windows.Forms.GroupBox();
            this.BasisRadioButton = new System.Windows.Forms.RadioButton();
            this.SymplexRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GraphicsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConclusionTextBox = new System.Windows.Forms.TextBox();
            this.SolveProblem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.ViewGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 10);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(823, 438);
            this.dataGridView.TabIndex = 0;
            // 
            // LastStep
            // 
            this.LastStep.Location = new System.Drawing.Point(938, 257);
            this.LastStep.Name = "LastStep";
            this.LastStep.Size = new System.Drawing.Size(44, 40);
            this.LastStep.TabIndex = 1;
            this.LastStep.Text = ">>";
            this.LastStep.UseVisualStyleBackColor = true;
            this.LastStep.Click += new System.EventHandler(this.LastStep_Click);
            // 
            // PrevStep
            // 
            this.PrevStep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevStep.Location = new System.Drawing.Point(841, 211);
            this.PrevStep.Name = "PrevStep";
            this.PrevStep.Size = new System.Drawing.Size(99, 40);
            this.PrevStep.TabIndex = 2;
            this.PrevStep.Text = "<";
            this.PrevStep.UseVisualStyleBackColor = true;
            this.PrevStep.Click += new System.EventHandler(this.PrevStep_Click);
            // 
            // NextStep
            // 
            this.NextStep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextStep.Location = new System.Drawing.Point(938, 211);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(103, 40);
            this.NextStep.TabIndex = 3;
            this.NextStep.Text = ">";
            this.NextStep.UseVisualStyleBackColor = true;
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // FirstStep
            // 
            this.FirstStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstStep.Location = new System.Drawing.Point(896, 257);
            this.FirstStep.Name = "FirstStep";
            this.FirstStep.Size = new System.Drawing.Size(44, 40);
            this.FirstStep.TabIndex = 4;
            this.FirstStep.Text = "<<";
            this.FirstStep.UseVisualStyleBackColor = true;
            this.FirstStep.Click += new System.EventHandler(this.FirstStep_Click);
            // 
            // ViewGroupBox
            // 
            this.ViewGroupBox.Controls.Add(this.BasisRadioButton);
            this.ViewGroupBox.Controls.Add(this.SymplexRadioButton);
            this.ViewGroupBox.Enabled = false;
            this.ViewGroupBox.Location = new System.Drawing.Point(841, 17);
            this.ViewGroupBox.Name = "ViewGroupBox";
            this.ViewGroupBox.Size = new System.Drawing.Size(200, 75);
            this.ViewGroupBox.TabIndex = 5;
            this.ViewGroupBox.TabStop = false;
            this.ViewGroupBox.Text = "Просмотр";
            // 
            // BasisRadioButton
            // 
            this.BasisRadioButton.AutoSize = true;
            this.BasisRadioButton.Checked = true;
            this.BasisRadioButton.Location = new System.Drawing.Point(6, 22);
            this.BasisRadioButton.Name = "BasisRadioButton";
            this.BasisRadioButton.Size = new System.Drawing.Size(190, 19);
            this.BasisRadioButton.TabIndex = 2;
            this.BasisRadioButton.TabStop = true;
            this.BasisRadioButton.Text = "Метод искусственного базиса";
            this.BasisRadioButton.UseVisualStyleBackColor = true;
            // 
            // SymplexRadioButton
            // 
            this.SymplexRadioButton.AutoSize = true;
            this.SymplexRadioButton.Location = new System.Drawing.Point(6, 47);
            this.SymplexRadioButton.Name = "SymplexRadioButton";
            this.SymplexRadioButton.Size = new System.Drawing.Size(117, 19);
            this.SymplexRadioButton.TabIndex = 1;
            this.SymplexRadioButton.Text = "Симплекс метод";
            this.SymplexRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.GraphicsButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ConclusionTextBox);
            this.panel1.Controls.Add(this.SolveProblem);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.NextStep);
            this.panel1.Controls.Add(this.FirstStep);
            this.panel1.Controls.Add(this.PrevStep);
            this.panel1.Controls.Add(this.ViewGroupBox);
            this.panel1.Controls.Add(this.LastStep);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 594);
            this.panel1.TabIndex = 7;
            // 
            // GraphicsButton
            // 
            this.GraphicsButton.Location = new System.Drawing.Point(841, 158);
            this.GraphicsButton.Name = "GraphicsButton";
            this.GraphicsButton.Size = new System.Drawing.Size(199, 47);
            this.GraphicsButton.TabIndex = 9;
            this.GraphicsButton.Text = "Посмотреть графическое решение";
            this.GraphicsButton.UseVisualStyleBackColor = true;
            this.GraphicsButton.Click += new System.EventHandler(this.GraphicsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ход решения задачи";
            // 
            // ConclusionTextBox
            // 
            this.ConclusionTextBox.AcceptsReturn = true;
            this.ConclusionTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConclusionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConclusionTextBox.HideSelection = false;
            this.ConclusionTextBox.Location = new System.Drawing.Point(12, 478);
            this.ConclusionTextBox.Multiline = true;
            this.ConclusionTextBox.Name = "ConclusionTextBox";
            this.ConclusionTextBox.ReadOnly = true;
            this.ConclusionTextBox.Size = new System.Drawing.Size(823, 105);
            this.ConclusionTextBox.TabIndex = 7;
            this.ConclusionTextBox.Enter += new System.EventHandler(this.ConclusionTextBox_Enter);
            // 
            // SolveProblem
            // 
            this.SolveProblem.Enabled = false;
            this.SolveProblem.Location = new System.Drawing.Point(841, 98);
            this.SolveProblem.Name = "SolveProblem";
            this.SolveProblem.Size = new System.Drawing.Size(200, 54);
            this.SolveProblem.TabIndex = 6;
            this.SolveProblem.Text = "Продолжить решение с текущим базисом";
            this.SolveProblem.UseVisualStyleBackColor = true;
            this.SolveProblem.Click += new System.EventHandler(this.SolveProblem_Click);
            // 
            // SolveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SolveWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SolveWindow";
            this.Load += new System.EventHandler(this.SolveWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ViewGroupBox.ResumeLayout(false);
            this.ViewGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button LastStep;
        private System.Windows.Forms.Button PrevStep;
        private System.Windows.Forms.Button NextStep;
        private System.Windows.Forms.Button FirstStep;
        private System.Windows.Forms.GroupBox ViewGroupBox;
        private System.Windows.Forms.RadioButton BasisRadioButton;
        private System.Windows.Forms.RadioButton SymplexRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ConclusionTextBox;
        private System.Windows.Forms.Button SolveProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GraphicsButton;
    }
}