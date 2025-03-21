using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace GreedyPigSim
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region fill
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void nMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nMax_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void dataPoints_ValueChanged(object sender, EventArgs e)
        {

        }
        private void target_ValueChanged(object sender, EventArgs e)
        {
            //label1.Text = target.Value.ToString();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            //DialogResult r = pickFolder.ShowDialog();
            if (true)
            {
                bool isGoUntil = checkedListBox1.CheckedItems.Contains("Go until n");
                string type = isGoUntil ? "GoUntilN" : "GoForNRounds";
                using(SpreadsheetDocument doc =  SpreadsheetDocument.Create($"M_Result_{type}.xlsx", SpreadsheetDocumentType.Workbook))
                {
                    WorkbookPart workbookPart = doc.AddWorkbookPart();
                    workbookPart.Workbook = new Workbook();
                    Sheets sheets = doc.WorkbookPart.Workbook.AppendChild(new Sheets());
                    for (int i = 0; i < (nMax.Value-nMin.Value+1)*2; i++)
                    {
                        WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                        worksheetPart.Worksheet = new Worksheet(new SheetData());
                        Sheet sheet;
                        if (i < nMax.Value - nMin.Value + 1)
                        {
                            sheet = new Sheet() { Id = doc.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = (DocumentFormat.OpenXml.UInt32Value.FromUInt32((uint)i + 1)), Name = $"n = {nMin.Value + i}" };
                        }
                        else
                        {
                            sheet = new Sheet() { Id = doc.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = (DocumentFormat.OpenXml.UInt32Value.FromUInt32((uint)i + 1)), Name = $"Freq. n = {nMin.Value + i - (nMax.Value - nMin.Value + 1)}" };
                        }
                        sheets.Append(sheet);
                        workbookPart.Workbook.Save();
                    }
                }

                for (int i = 0; i < nMax.Value - nMin.Value + 1; i++)
                {
                    string[,] data;
                    if (isGoUntil)
                        data = PigGameUntil((int)nMin.Value+i);
                    else
                        data = PigGameRounds((int)nMin.Value + i);

                    WriteFile(data, $"M_Result_{type}.xlsx", isGoUntil, i, false);
                    WriteFile(FrequencyTable(data), $"M_Result_{type}.xlsx", isGoUntil, i+((int)nMax.Value - (int)nMin.Value + 1), true);
                }
            }
        }
        void WriteFile(string[,] sheetInfo, string path, bool isGoUntil, int page, bool firstRowInt)
        {
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(path, true))
            {
                WorkbookPart workbookPart = doc.WorkbookPart;
                Sheet sheet = workbookPart.Workbook.Descendants<Sheet>().ElementAt(page);
                WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(sheet.Id);
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().ElementAt(0);

                //height
                if(firstRowInt)
                {
                    Row firstRow = new Row();
                    CellValue nValue = new CellValue("n Value");
                    Cell firstCell = new Cell()
                    {
                        DataType = CellValues.String,
                        CellValue = nValue
                    };
                    firstRow.Append(firstCell);
                    CellValue nFreq = new CellValue("n Frequency");
                    Cell secondCell = new Cell()
                    {
                        DataType = CellValues.String,
                        CellValue = nFreq
                    };
                    firstRow.Append(secondCell);
                    sheetData.Append(firstRow);
                }
                for (int i = 0; i < sheetInfo.GetLength(1); i++)
                {
                    Row newRow = new Row();
                    //width
                    for (int j = 0; j < sheetInfo.GetLength(0); j++)
                    {
                        CellValue cv = new CellValue();
                        if (j == 1)
                            cv = new CellValue(int.Parse(sheetInfo[j, i]));
                        else
                            cv = new CellValue(sheetInfo[j, i]);
                        //cv = new CellValue(i);

                        Cell cell = new Cell()
                            {
                                DataType = j == 0 ? (firstRowInt ? CellValues.String : CellValues.String) : CellValues.Number,
                                CellValue = cv
                            };
                        newRow.Append(cell);
                    }
                    sheetData.Append(newRow);
                    if (i == 1)
                    {
                        CellValue emptyValue = new CellValue();

                        Cell emptyCell = new Cell()
                        {
                            DataType = CellValues.String,
                            CellValue = emptyValue
                        };
                        newRow.Append(emptyCell);
                        CellValue nameValue = new CellValue("Made By Marcus");

                        Cell nameCell = new Cell()
                        {
                            DataType = CellValues.String,
                            CellValue = nameValue
                        };
                        newRow.Append(nameCell);
                    }
                }
            }
        }

        string[,] PigGameRounds(int n)
        {
            int numTarget = (int)target.Value;
            Random rnd = new Random();
            string[,] data = new string[2, (int)dataPoints.Value];
            for(int i=0; i < dataPoints.Value; i++)
            {
                int roundCount = 0;
                int rollCount = 0;
                int addedValue = 0;
                int currentScore = 0;
                string scoreTrack = "";
                while(currentScore < numTarget)
                {
                    while (rollCount < n)
                    {
                        int roll = rnd.Next(1, 7);
                        if (roll == 1)
                        {
                            break;
                            addedValue = 0;
                        }
                        else
                        {
                            addedValue += roll;
                            rollCount++;
                        }
                    }
                    currentScore += addedValue;

                    if (roundCount == 0) 
                        scoreTrack += $"{currentScore}";
                    else 
                        scoreTrack += $", {currentScore}";

                    roundCount++;
                    rollCount = 0;
                    addedValue = 0;


                    if (currentScore >= numTarget)
                    {
                        data[0, i] = $"{scoreTrack}";
                        data[1, i] = $"{roundCount}";
                        break;
                    }
                }
            }
            return data;
        }

        string[,] PigGameUntil(int n)
        {
            int numTarget = (int)target.Value;
            Random rnd = new Random();
            string[,] data = new string[2, (int)dataPoints.Value];
            for (int i = 0; i < dataPoints.Value; i++)
            {
                int roundCount = 0;
                int addedValue = 0;
                int currentScore = 0;
                string scoreTrack = "";
                while (currentScore < numTarget)
                {
                    while (addedValue < n)
                    {
                        int roll = rnd.Next(1, 7);
                        if (roll == 1)
                        {
                            addedValue = 0;
                            break;
                        }
                        else
                        {
                            addedValue += roll;
                        }
                    }
                    currentScore += addedValue;

                    if (roundCount == 0)
                        scoreTrack += $"{currentScore}";
                    else
                        scoreTrack += $", {currentScore}";

                    roundCount++;
                    addedValue = 0;


                    if (currentScore >= numTarget)
                    {
                        data[0, i] = $"{scoreTrack}";
                        data[1, i] = $"{roundCount}";
                        break;
                    }
                }
            }
            return data;
        }

        string[,] FrequencyTable(string[,] numbers)
        {
            int[] fTableInt = new int[100];
            int min = 0;
            int max = 0;
            for(int i=0; i < numbers.GetLength(1);i++)
            {
                int num = int.Parse(numbers[1,i]);
                if (i==0)
                {
                    min = num;
                    max = num;
                    continue;
                }

                if (min > num)
                    min = num;

                if (max < num)
                    max = num;

                fTableInt[num] = fTableInt[num] + 1;
            }

            string[,] fTableString = new string[2, max - min+1];
            for(int i=0;i< max - min + 1;i++)
            {
                fTableString[0, i] = $"{min + i}";
                fTableString[1, i] = $"{fTableInt[min+i]}";
            }

            return fTableString;
        }

        private void selection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void pickFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
