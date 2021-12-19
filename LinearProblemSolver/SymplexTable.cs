using LinearProblem;
using System.Collections.Generic;
using System.Linq;

namespace LinearProblemSolving
{
    public class SymplexTable
    {
        public int[] basisVariables;
        public int[] nonBasisVariables;
        public Rational[][] table;

        public SymplexTable(int[] basisVariables, int[] nonBasisVariables, Rational[][] table)
        {
            this.basisVariables = basisVariables;
            this.nonBasisVariables = nonBasisVariables;
            this.table = table;
        }

        public List<KeyValuePair<int, int>> GetBasisElements()
        {
            List<KeyValuePair<int, int>> res = new List<KeyValuePair<int, int>>();
            for (int j = 0; j + 1 < table[0].Length; ++j)
            {
                if (table[table.Length - 1][j] >= 0) continue;

                Rational minRes = new Rational(1000000000);
                List<int> minIdxs = new List<int>();

                for (int i = 0; i < table.Length - 1; ++i)
                {
                    if (table[i][j] <= 0) continue;

                    if (minRes == table[i][table[0].Length - 1] / table[i][j])
                    {
                        minIdxs.Add(i);
                    }
                    if (minRes > table[i][table[0].Length - 1] / table[i][j])
                    {
                        minIdxs = new List<int> { i };
                        minRes = table[i][table[0].Length - 1] / table[i][j];
                    }
                }

                foreach (var idx in minIdxs)
                {
                    res.Add(new KeyValuePair<int, int>(idx, j));
                }
            }
            return res;
        }
        public List<KeyValuePair<int, int>> GetBasisElementsForBasis()
        {
            List<KeyValuePair<int, int>> res = new List<KeyValuePair<int, int>>();

            if (basisVariables.Max() <= nonBasisVariables.Length)
            {
                for (int j = 0; j + 1 < table[0].Length; ++j)
                {
                    if (table[table.Length - 1][j] <= 0 || nonBasisVariables[j] > nonBasisVariables.Length) continue;

                    Rational minRes = new Rational(1000000000);
                    List<int> minIdxs = new List<int>();

                    for (int i = 0; i < table.Length - 1; ++i)
                    {
                        if (table[i][j] >= 0 || basisVariables[i] <= nonBasisVariables.Length) continue;
                        if (minRes == table[i][table[0].Length - 1] / table[i][j]) minIdxs.Add(i);
                        if (minRes > table[i][table[0].Length - 1] / table[i][j])
                        {
                            minIdxs = new List<int> { i };
                            minRes = table[i][table[0].Length - 1] / table[i][j];
                        }
                    }

                    foreach (var idx in minIdxs)
                        res.Add(new KeyValuePair<int, int>(idx, j));
                }
            }
            else
            {
                for (int j = 0; j + 1 < table[0].Length; ++j)
                {
                    if (table[table.Length - 1][j] >= 0 || nonBasisVariables[j] > nonBasisVariables.Length) continue;

                    Rational minRes = new Rational(100000000);
                    List<int> minIdxs = new List<int>();

                    for (int i = 0; i < table.Length - 1; ++i)
                    {
                        if (table[i][j] <= 0 || basisVariables[i] <= nonBasisVariables.Length) continue;
                        if (minRes == table[i][table[0].Length - 1] / table[i][j]) minIdxs.Add(i);

                        if (minRes > (table[i][table[0].Length - 1] / table[i][j]))
                        {
                            minIdxs = new List<int> { i };
                            minRes = table[i][table[0].Length - 1] / table[i][j];
                        }
                    }

                    foreach (var idx in minIdxs)
                        res.Add(new KeyValuePair<int, int>(idx, j));
                }
            }
            return res;
        }
        public SymplexTable NextStep(int i, int j)
        {
            int[] basis = (int [])this.basisVariables.Clone();
            int[] nonBasis = (int[]) this.nonBasisVariables.Clone();

            var t = basis[i];
            basis[i] = nonBasis[j];
            nonBasis[j] = t;

            Rational[][] table = new Rational[this.table.Length][];
            for (int k = 0; k < table.Length; ++k)
                table[k] = new Rational[this.table[0].Length];

            table[i][j] = (new Rational(1)) / this.table[i][j];

            for (int k = 0; k < table[0].Length; ++k)
                if (k != j)
                    table[i][k] = this.table[i][k] * table[i][j];

            for (int k = 0; k < table.Length; ++k)
                if (k != i)
                    table[k][j] = this.table[k][j] * (-table[i][j]);

            for (int k = 0; k < table.Length; ++k)
                for (int l = 0; l < table[0].Length; ++l)
                    if (k != i && l != j)
                        table[k][l] = this.table[k][l] - this.table[k][j] * table[i][l];

            return new SymplexTable(basis, nonBasis, table);
        }

    }
}