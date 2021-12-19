using LinearProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearProblemSolving
{
    public class LinearProblemSolver
    {
        LinearProblemInstance problem = null;
        public LinearProblemSolver(LinearProblemInstance problem)
        {
            this.problem = problem;
        }


        public List<SymplexTable> GetBasisSolveHistory()
        {
            var res = new List<SymplexTable> { BuildFirstBasisTable() };

            while (true)
            {
                var lastTable = res.Last();
                var baseElems = lastTable.GetBasisElementsForBasis();
                if (!baseElems.Any())
                    break;
                res.Add(lastTable.NextStep(baseElems.First().Key, baseElems.First().Value));
            }
            return res;
        }

        public List<Rational> GetMinimiseAimFunction()
        {
            var res = problem.AimFunction.ToList();

            if (problem.ProblemType == LinearProblemType.Maximise)
                res = res.Select(c => -c).ToList();

            return res;
        }

        public SymplexTable BuildFirstBasisTable()
        {
            var basisVars = new List<int>();
            var nonBasisVars = new List<int>();
            var table = new Rational[problem.Restrictions.Length + 1][];
            table[problem.Restrictions.Length] = new Rational[problem.Restrictions[0].Length];

            for (int i = 0; i < problem.Restrictions[0].Length; ++i)
            {
                table[problem.Restrictions.Length][i] = new Rational(0);
            }

            for (int i = problem.Restrictions[0].Length; i < problem.Restrictions[0].Length + problem.Restrictions.Length; ++i)
            {
                basisVars.Add(i);
            }

            for (int i = 1; i < problem.Restrictions[0].Length; ++i)
            {
                nonBasisVars.Add(i);
            }


            for (int i = 0; i < problem.Restrictions.Length; ++i)
            {
                table[i] = new Rational[problem.Restrictions[0].Length];

                for (int j = 0; j < problem.Restrictions[0].Length; ++j)
                {
                    table[i][j] = problem.Restrictions[i][j];
                    table[problem.Restrictions.Length][j] -= table[i][j];
                }
            }

            return new SymplexTable(basisVars.ToArray(), nonBasisVars.ToArray(), table);
        }
    }
}
