using System;
using System.IO;



namespace Copy_Functionality
{

    public class Math
    {
        private static bool Calculation(double dCopyExpresion, double Epsilon)
        {
            return System.Math.Abs(dCopyExpresion) <= Epsilon;
        }

        public static bool Compare(double first, double second, double epsilon)
        {
            return Calculation(first - second, epsilon);          
        }
    }

    public class ReportAction
    {
        public static void PositiveResults()
        {
            Ranorex.Report.Success("Sucessfully Performed");
        }

        public static void NegativeReport(double dActual, double dHardcoded, int iErrorLine)
        {
            string errorLine = "Error on Line: " + (iErrorLine + 1);
            Ranorex.Report.Error(errorLine);

            string actualValue = "Actual Value is: " + dActual;
            Ranorex.Report.Error(actualValue);

            string hardcodedValue = "Hardcoded Value is: " + dHardcoded;
            Ranorex.Report.Error(hardcodedValue);
        }
    }


    class UtilityRun
    {
        public static void RunCopy(string Actual, string Hardcoded)
        {
            string[] readActualValues = File.ReadAllLines(Actual);
            string[] readHardcodedValues = File.ReadAllLines(Hardcoded);

            //to test all possible options for File./////

            int iNumActualRows = readActualValues.Length;
            int iNumHardcodedRows = readHardcodedValues.Length;

            bool bAllCopyResultsOK = true;

            for (int i = 0; i < iNumActualRows; i++)
            {
                double dActualResults;
                double dHardcodedResults;
                Double.TryParse(readActualValues[i], out dActualResults);
                Double.TryParse(readHardcodedValues[i], out dHardcodedResults);

                try
                {
                    bool bSimilar = Math.Compare(dActualResults, dHardcodedResults, 0.000);

                    if (!bSimilar)
                    {
                                                
                        ReportAction.NegativeReport(dActualResults, dHardcodedResults, i);
                    }
                }
                catch (Exception)
                {

                }
            }

            if (bAllCopyResultsOK)
            {
                ReportAction.PositiveResults();
            }

        }
    }
}
