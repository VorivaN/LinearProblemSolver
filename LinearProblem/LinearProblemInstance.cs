﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearProblem
{
    public enum LinearProblemType
    {
        Minimise = 0,
        Maximise = 1
    }

    public class LinearProblemInstance
    {
        private Rational[][] restrMartix = null;
        private Rational[] aimFunction = null;
        private LinearProblemType? problemType = null;
        private bool useUserBasis;
        private Rational[] basis = null;
        
        
        public LinearProblemInstance()
        {

        }
        public LinearProblemInstance(Rational[][] restrMartix, Rational[] aimFunction, LinearProblemType problemType)
        {
            this.restrMartix = restrMartix;
            this.aimFunction = aimFunction;
            this.problemType = problemType;
        }
        public LinearProblemInstance(Rational[][] restrMartix, Rational[] aimFunction, LinearProblemType problemType, Rational[] basis)
        {
            this.restrMartix = restrMartix;
            this.aimFunction = aimFunction;
            this.problemType = problemType;
            this.basis = basis;
            this.useUserBasis = true;
        }
        public Rational[][] Restrictions
        {
            get { return restrMartix; }
            set { restrMartix = value; }
        }
        public Rational[] AimFunction
        {
            get { return aimFunction; }
            set { aimFunction = value; }
        }
        public LinearProblemType? ProblemType
        {
            get { return problemType; }
            set { problemType = value; }
        }
        public Rational[] Basis
        {
            get { return basis; }
            set { basis = value; }
        }
        public bool UseUserBasis
        {
            get { return useUserBasis; }
            set { useUserBasis = value; }
        }
    }
}
