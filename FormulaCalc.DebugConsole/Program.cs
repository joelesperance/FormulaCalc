namespace FormulaCalc.DebugConsole
{
    using NCalc;
    using ExcelDna.Integration;
    using Microsoft.Office.Interop.Excel;
    internal class Program
    {
        static void Main(string[] args)
        {
            Application excelApp = new Application();

           // Workbook workbook = excelApp.Workbooks.Open("");

            double sum = excelApp.WorksheetFunction.Sum(2, 2);

            Console.WriteLine(sum);

            // ExcelDna






            // NCalc

            //while (true)
            //{

            //    Console.Write("X: ");
            //    double x = double.Parse(Console.ReadLine());

            //    Console.Write("Y: ");
            //    double y = double.Parse(Console.ReadLine());

            //    add.Parameters["x"] = x;
            //    add.Parameters["y"] = y;

            //    Console.WriteLine(add.Evaluate());

            //}
        }
    }
}