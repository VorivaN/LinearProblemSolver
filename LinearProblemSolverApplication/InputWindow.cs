using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using LinearProblem;

namespace LinearProblemSolverApplication
{
    public partial class InputWindow : Form
    {
        private string jsonFilePath = null;
        private LinearProblemInstance problem = null;
        public InputWindow()
        {
            /*var table = new [] {
                new[] { new Rational(1), new Rational(1), new Rational(1) },
            new[] { new Rational(0), new Rational(1), new Rational(1) },
            new[] { new Rational(-1), new Rational(-1), new Rational(1) }};

            var a = new SymplexTable(new [] { "x1", "x2" }, new[] { "x3", "x4" }, table);

            MessageBox.Show(string.Join("\n", a.GetBasisElements()));*/

            InitializeComponent();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Помогает решать задачи линейного программирования.\nАвтор: Воронин Иван ИТ-31");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            RestrictionsTable.RowHeadersWidth = 60;
            AimFunctionTable.RowHeadersWidth = 60;

            SetColumnsCount(1);
            SetRowsCount(1);

            AimFunctionTable.Rows.Add();
            AimFunctionTable.Rows[0].HeaderCell.Value = "F0";


            RestrictionsTable.ClearSelection();
            AimFunctionTable.ClearSelection();
        }
        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            SetColumnsCount((int)numericUpDownN.Value);
        }
        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {
            SetRowsCount((int)numericUpDownM.Value);
        }
        private void SetColumnsCount(int count)
        {
            numericUpDownN.Value = count;
            int currentCount = Math.Max(0, RestrictionsTable.Columns.Count - 1);

            if (currentCount > 0)
            {
                RestrictionsTable.Columns.RemoveAt(RestrictionsTable.Columns.Count - 1);
                AimFunctionTable.Columns.RemoveAt(AimFunctionTable.Columns.Count - 1);
            }

            if (count > currentCount)
            {
                for (int newCol = currentCount + 1; newCol <= count; ++newCol)
                {
                    string name = "X" + newCol.ToString();

                    //ограничения
                    AddColumn(RestrictionsTable, name);

                    //целевая функция
                    AddColumn(AimFunctionTable, name);
                }
            }
            else
            {
                for (int i = count; i < currentCount; ++i)
                {
                    RestrictionsTable.Columns.RemoveAt(RestrictionsTable.Columns.Count - 1);
                    AimFunctionTable.Columns.RemoveAt(AimFunctionTable.Columns.Count - 1);
                }
            }

            //ограничения
            AddColumn(RestrictionsTable, "C");
            //целевая функция
            AddColumn(AimFunctionTable, "C");

            RestrictionsTable.ClearSelection();
            AimFunctionTable.ClearSelection();
        }

        private void AddColumn(DataGridView grid, string name)
        {
            int addedCol = grid.Columns.Add(name, name);
            grid.Columns[addedCol].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void SetRowsCount(int count)
        {
            numericUpDownM.Value = count;
            int currentCount = RestrictionsTable.Rows.Count;
            if (count > currentCount)
            {
                for (int newRow = currentCount + 1; newRow <= count; ++newRow)
                {
                    //ограничения
                    string name = "F" + newRow.ToString();
                    int addedRow = RestrictionsTable.Rows.Add();
                    RestrictionsTable.Rows[addedRow].HeaderCell.Value = name;
                }
            }
            else
            {
                for (int i = count; i < currentCount; ++i)
                {
                    RestrictionsTable.Rows.RemoveAt(RestrictionsTable.Rows.Count - 1);
                }
            }

            RestrictionsTable.ClearSelection();
            AimFunctionTable.ClearSelection();
        }
        private string GetPathFromOpenDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
        private string GetPathFromSaveDialog()
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
        private void ParseJson(string json)
        {
            try
            {
                problem = JsonConvert.DeserializeObject<LinearProblemInstance>(json);
            }
            catch
            {
                MessageBox.Show("Невозможно загрузкить задачу из этого файла");
            }
        }
        private string GetJson()
        {
            //rationalProblem = new LinearProblem<Rational>(new Rational[][] { new Rational[] { new Rational(1), new Rational(1) }, new Rational[] { new Rational(1), new Rational(1) } },
            // new Rational[] { new Rational(1), new Rational(1) }, LinearProblemType.Minimise, new Rational[] { new Rational(1), new Rational(1, 2) });

            if (problem != null) return JsonConvert.SerializeObject(problem);
            return null;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            problem = null;

            jsonFilePath = GetPathFromOpenDialog();
            if (jsonFilePath != null)
            {
                string fileContent = File.ReadAllText(jsonFilePath);
                ParseJson(fileContent);

                if (problem != null)
                {
                    if (DecimalNumbers.Checked) FillFormFromProblem(problem, true);
                    else FillFormFromProblem(problem, false);
                }
            }
        }
        private void FillFormFromProblem(LinearProblemInstance problem, bool convertToDecimal)
        {
            SetColumnsCount(problem.Restrictions[0].Count() - 1);
            SetRowsCount(problem.Restrictions.Count());

            for (int i = 0; i < RestrictionsTable.Rows.Count; ++i)
            {
                for (int j = 0; j < RestrictionsTable.Columns.Count; ++j)
                {
                    if(convertToDecimal) RestrictionsTable.Rows[i].Cells[j].Value = ((double)problem.Restrictions[i][j]).ToString();
                    else RestrictionsTable.Rows[i].Cells[j].Value = problem.Restrictions[i][j].ToString();
                }
            }

            for (int j = 0; j < RestrictionsTable.Columns.Count; ++j)
            {
                if (convertToDecimal) AimFunctionTable.Rows[0].Cells[j].Value = ((double)problem.AimFunction[j]).ToString();
                else AimFunctionTable.Rows[0].Cells[j].Value = problem.AimFunction[j].ToString();
            }

            if (problem.ProblemType == LinearProblemType.Minimise) MinimumRadioButton.Checked = true;
            else MaximumRadioButton.Checked = true;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(jsonFilePath == null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }
            try
            {
                FillProblemFromForm();
            }
            catch
            {
                MessageBox.Show("Неправильно заполнены данные");
                return;
            }
            File.WriteAllText(jsonFilePath, GetJson());
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jsonFilePath = GetPathFromSaveDialog();
            if (jsonFilePath != null)
            {
                try
                {
                    FillProblemFromForm();
                }
                catch
                {
                    MessageBox.Show("Неправильно заполнены данные");
                    return;
                }
                File.WriteAllText(jsonFilePath, GetJson());
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            problem = null;
            SetColumnsCount(1);
            SetRowsCount(1);
            RestrictionsTable.Rows[0].Cells[0].Value = "";
            AimFunctionTable.Rows[0].Cells[0].Value = "";
            MinimumRadioButton.Checked = true;
            DecimalNumbers.Checked = true;
        }

        void FillProblemFromForm()
        {
            if (problem == null) problem = new LinearProblemInstance();

            var aim = new Rational[AimFunctionTable.Columns.Count];
            for (int i = 0; i < AimFunctionTable.Columns.Count; ++i)
            {
                aim[i] = Rational.Parse(AimFunctionTable.Rows[0].Cells[i].Value.ToString());
            }
            problem.AimFunction = aim;

            var restr = new Rational[RestrictionsTable.Rows.Count][];
            for (int i = 0; i < RestrictionsTable.Rows.Count; ++i)
            {
                restr[i] = new Rational[RestrictionsTable.ColumnCount];
                for (int j = 0; j < RestrictionsTable.ColumnCount; ++j)
                {
                    restr[i][j] = Rational.Parse(RestrictionsTable.Rows[i].Cells[j].Value.ToString());
                }
            }
            problem.Restrictions = restr;

            if (MinimumRadioButton.Checked) problem.ProblemType = LinearProblemType.Minimise;
            else problem.ProblemType = LinearProblemType.Maximise;
        }
        private void SolveButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillProblemFromForm();
            }
            catch
            {
                MessageBox.Show("Неправильно заполнены данные");
                return;
            }
            
            var solveWindow = new SolveWindow(problem, DecimalNumbers.Checked);
            solveWindow.Owner = this;
            solveWindow.ShowDialog();
        }
    }
}