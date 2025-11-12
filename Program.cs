using Microsoft.ML;

namespace StudentPassFailPrediction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load Data
            var context = new MLContext();
            var data = context.Data.LoadFromTextFile<StudentData>
                (
                    path: @"F:\Win 10 Pc\Student.csv",
                    hasHeader: false,
                    separatorChar: ','
                );

            // Define Pipeline
            // Choose Algorithm - BinaryClassification and use SDCA or FastTree
            var pipeline = context.Transforms
                .Concatenate("Features", nameof(StudentData.StudentHours), nameof(StudentData.Attendance))
                .Append(context.BinaryClassification.Trainers.SdcaLogisticRegression(
                    new Microsoft.ML.Trainers.SdcaLogisticRegressionBinaryTrainer.Options
                    {
                        MaximumNumberOfIterations = 10,
                    }));

            //
            Console.WriteLine("Training Started...");
            // Train the model
            var model = pipeline.Fit(data);
            Console.WriteLine("Training Completed.");

            // Create prediction engine (for single prediction)
            var predictor = context.Model.CreatePredictionEngine<StudentData, StudentPrediction>(model);

           

            // Student Info
            StudentData newstudent = new StudentData();

            Console.Write("Enter Study Hours: ");
            newstudent.StudentHours = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Students Attendance: ");
            newstudent.Attendance = float.Parse(Console.ReadLine());


            // Predict

            var result = predictor.Predict(newstudent);

            Console.WriteLine($"Study Hours: {newstudent.StudentHours}, Attendance: {newstudent.Attendance}");
            Console.WriteLine($"Will Pass: {result.Passed}, Probability: {result.Probability:P2}");

            Console.ReadKey();
        }
    }
}
