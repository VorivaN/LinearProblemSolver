using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LinearProblem;
using LinearProblemSolving;

namespace LinearProblemSolverApplication
{
    public partial class SolveWindow : Form
    {

        string startBasisString = "Нахождение искусственного базиса...";
        string basisConclusionString = "";
        string startProblemString = "";
        string problemConclusionString = "";

        SymplexTable currentSymplexTable = null;
        List<SymplexTable> history = new List<SymplexTable>();
        List<KeyValuePair<int, int>> baseElements = new List<KeyValuePair<int, int>>();


        LinearProblemInstance problem = null;
        bool convertToDecimal;
        public SolveWindow(LinearProblemInstance problem, bool convertToDecimal)
        {
            this.problem = problem;
            this.convertToDecimal = convertToDecimal;
            InitializeComponent();
        }

        private void SolveWindow_Load(object sender, EventArgs e)
        {
            UpdateButtons();
            dataGridView.RowHeadersWidth = 60;

            if (BasisRadioButton.Checked)
            {
                currentSymplexTable = SymplexTable.BuildFirstBasisTable(problem);
                AddNewStep(currentSymplexTable);
            }

            //problemSolver.GetBasisSolveHistory();
        }
        void AddNewStep(SymplexTable table)
        {
            history.Add(currentSymplexTable);
            UpdateForm();
        }
        void UpdateConclusionTextBox()
        {
            if (!baseElements.Any())
            {
                if (BasisRadioButton.Checked)
                {
                    var p0 = dataGridView.Rows[dataGridView.RowCount - 1].Cells[dataGridView.ColumnCount - 1].Value.ToString();
                    if (p0.Equals("0"))
                    {
                        basisConclusionString = "Базис найден";
                        basisConclusionString += "\r\nБазисные переменные: " + string.Join(",", currentSymplexTable.basisVariables.Select(c => "X" + c.ToString()));

                        ConclusionTextBox.ForeColor = Color.Green;
                        SolveProblem.Enabled = true;
                    }
                    else
                    {
                        basisConclusionString = "Исходная система ограничений несовместна";
                        ConclusionTextBox.ForeColor = Color.Red;
                    }
                }
                if (SymplexRadioButton.Checked)
                {
                    startProblemString = "Решение исходной задачи...";

                    problemConclusionString = "Ответ на задачу найден";

                    Rational f0 = -currentSymplexTable.table[currentSymplexTable.table.Length - 1][currentSymplexTable.table[0].Length - 1];
                    if (!problem.IsMinimiseProblem()) f0 = -f0;

                    List<Rational> x = new List<Rational>();
                    for (int i = 0; i < currentSymplexTable.table.Length + currentSymplexTable.table[0].Length - 2; ++i)
                    {
                        if (currentSymplexTable.nonBasisVariables.Contains(i + 1)) x.Add(new Rational(0));
                        else
                        {
                            var row = currentSymplexTable.basisVariables.ToList().IndexOf(i + 1);
                            x.Add(currentSymplexTable.table[row][currentSymplexTable.table[row].Length - 1]);
                        }
                    }

                    if (convertToDecimal) problemConclusionString += string.Format("\r\nf({0})={1}", string.Join(",", x.Select(c => (double)c)), (double)f0);
                    else problemConclusionString += string.Format("\r\nf({0})={1}", string.Join(",", x), f0);

                    if (currentSymplexTable.nonBasisVariables.Length == 2)
                        GraphicsButton.Enabled = true;
                }
            }
            else
            {
                if (BasisRadioButton.Checked) basisConclusionString = "";
                if (SymplexRadioButton.Checked) problemConclusionString = "";
            }
            ConclusionTextBox.Text = string.Join("\r\n", new[] { startBasisString, basisConclusionString, startProblemString, problemConclusionString });
        }
        void UpdateForm()
        {
            FillFormFromTable(currentSymplexTable);

            if (BasisRadioButton.Checked) baseElements = currentSymplexTable.GetBasisElementsForBasis();
            else baseElements = currentSymplexTable.GetBasisElements();
            
            ColorBaseElements();
            UpdateButtons();
            UpdateConclusionTextBox();
        }
        void ColorBaseElements()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            foreach (var baseElem in baseElements)
            {
                dataGridView.Rows[baseElem.Key].Cells[baseElem.Value].Style.BackColor = Color.Aqua;
            }
        }
        void FillFormFromTable(SymplexTable table)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            foreach (var variable in table.nonBasisVariables)
            {
                string name = "X" + variable.ToString();
                AddColumn(dataGridView, name);
            }
            AddColumn(dataGridView, "");

            foreach (var variable in table.basisVariables)
            {
                string name = "X" + variable.ToString();
                int addedRow = dataGridView.Rows.Add();
                dataGridView.Rows[addedRow].HeaderCell.Value = name;
            }
            dataGridView.Rows.Add();

            for (int i = 0; i < table.table.Length; ++i)
            {
                for (int j = 0; j < table.table[0].Length; ++j)
                {
                    if (convertToDecimal) dataGridView.Rows[i].Cells[j].Value = ((double)table.table[i][j]).ToString();
                    else dataGridView.Rows[i].Cells[j].Value = table.table[i][j].ToString();
                }
            }
            dataGridView.ClearSelection();
        }
        private void UpdateButtons()
        {
            SolveProblem.Enabled = false;
            GraphicsButton.Enabled = false;

            if (history.Count > 1)
            {
                PrevStep.Enabled = true;
                FirstStep.Enabled = true;
            }
            else
            {
                PrevStep.Enabled = false;
                FirstStep.Enabled = false;
            }

            if (baseElements.Any())
            {
                NextStep.Enabled = true;
                LastStep.Enabled = true;
            }
            else
            {
                NextStep.Enabled = false;
                LastStep.Enabled = false;
            }
        }
        private void NextStep_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedCells.Count != 1)
            {
                MessageBox.Show("Выберите ровно один опорный элемент");
                return;
            }
            DataGridViewCell selectedCell = null;
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                selectedCell = cell;
            }
            if (!baseElements.Contains(new KeyValuePair<int, int>(selectedCell.RowIndex, selectedCell.ColumnIndex)))
            {
                MessageBox.Show("Выберите опорный элемент. Они подсвечены другим цветом.");
                return;
            }
            currentSymplexTable = currentSymplexTable.NextStep(selectedCell.RowIndex, selectedCell.ColumnIndex);
            AddNewStep(currentSymplexTable);
        }
        private void AddColumn(DataGridView grid, string name)
        {
            int addedCol = grid.Columns.Add(name, name);
            grid.Columns[addedCol].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void PrevStep_Click(object sender, EventArgs e)
        {
            history.Remove(history.Last());
            currentSymplexTable = history.Last();
            UpdateForm();
        }
        private void FirstStep_Click(object sender, EventArgs e)
        {
            while (history.Count > 1)
            {
                PrevStep_Click(sender, e);
            }
        }
        private void LastStep_Click(object sender, EventArgs e)
        {
            while (baseElements.Any())
            {
                var baseElem = baseElements.First();
                currentSymplexTable = currentSymplexTable.NextStep(baseElem.Key, baseElem.Value);
                AddNewStep(currentSymplexTable);
            }
            UpdateForm();
        }
        private void ConclusionTextBox_Enter(object sender, EventArgs e)
        {
            panel1.Focus();
        }
        private void BuildNewSymplexTable()
        {
            history.Clear();

            var aimFunction = problem.GetMinimiseAimFunction();

            var basis = (int[])currentSymplexTable.basisVariables.Clone();
            var nonBasis = ((int[])currentSymplexTable.nonBasisVariables.Clone()).Where(c => c < aimFunction.Count()).ToArray();

            var table = new Rational[currentSymplexTable.table.Length][];

            for (int i = 0; i < table.Length; ++i)
            {
                table[i] = new Rational[currentSymplexTable.table[0].Length - currentSymplexTable.table.Length + 1];

                for (int j = 0, k = 0; j < currentSymplexTable.table[0].Length - 1; ++j)
                {
                    if (currentSymplexTable.nonBasisVariables[j] < aimFunction.Count())
                    {
                        table[i][k++] = currentSymplexTable.table[i][j];
                    }
                }

                table[i][currentSymplexTable.table[0].Length - currentSymplexTable.table.Length] = currentSymplexTable.table[i][currentSymplexTable.table[i].Length - 1];
            }

            for (int i = 0; i < table[0].Length; ++i)
                table[table.Length - 1][i] = new Rational(0);


            for (int i = 0; i < aimFunction.Count() - 1; ++i)
            {
                if (basis.Contains(i + 1))
                {
                    var row = basis.ToList().IndexOf(i + 1);

                    for (int j = 0; j < table[row].Length - 1; ++j)
                    {
                        table[table.Length - 1][j] -= aimFunction[i] * table[row][j];
                    }
                    table[table.Length - 1][table[row].Length - 1] -= aimFunction[i] * table[row][table[row].Length - 1];
                }
                else
                {
                    var row = nonBasis.ToList().IndexOf(i + 1);
                    table[table.Length - 1][row] += aimFunction[i];
                }
            }

            table[table.Length - 1][table[0].Length - 1] -= aimFunction.Last();

            currentSymplexTable = new SymplexTable(basis, nonBasis, table);

            history.Add(currentSymplexTable);
        }
        private void SolveProblem_Click(object sender, EventArgs e)
        {
            BasisRadioButton.Checked = false;
            SymplexRadioButton.Checked = true;
            UpdateConclusionTextBox();
            BuildNewSymplexTable();
            UpdateForm();
        }

        private void GraphicsButton_Click(object sender, EventArgs e)
        {
            var graphWindow = new GraphicWindow(currentSymplexTable, problem);
            graphWindow.Owner = this;
            graphWindow.ShowDialog();
        }
    }
}
