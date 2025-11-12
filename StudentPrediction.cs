using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPassFailPrediction
{
    internal class StudentPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool Passed;

        public float Probability { get; set; }
        public float Score { get; set; }
    }
}
