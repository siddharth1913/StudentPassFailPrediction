using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPassFailPrediction
{
    internal class StudentData
    {
        [LoadColumn(0)]
        public float StudentHours;

        [LoadColumn(1)]
        public float Attendance;

        [LoadColumn(2), ColumnName("Label")]
        public bool Passed;
    }
}
