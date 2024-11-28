using DiskLab_2;
namespace InterfaceDiskLab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ComboBox_Count_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox_Count.SelectedIndex)
            {
                case 0:
                    TableFunction.Columns.Clear();
                    FillTable(2);
                    break;
                case 1:
                    TableFunction.Columns.Clear();
                    FillTable(3);
                    break;
                case 2:
                    TableFunction.Columns.Clear();
                    FillTable(4);
                    break;
                case 3:
                    TableFunction.Columns.Clear();
                    FillTable(5);
                    break;
            }
        }
        void FillTable(int count)
        {
            string nameVariables = "abcde";
            for (int i = 0; i < count + 1; i++)
            {
                if (i == count)
                {
                    DataGridViewTextBoxColumn cell = new DataGridViewTextBoxColumn();
                    cell.HeaderText = "F()";
                    TableFunction.Columns.Add(cell);
                }
                else
                {
                    DataGridViewTextBoxColumn cell = new DataGridViewTextBoxColumn();
                    cell.HeaderText = nameVariables[i].ToString();
                    TableFunction.Columns.Add(cell);
                }
            }
            for (int i = 0; i < Math.Pow(2, count); i++)
            {
                string[] tableValues = new string[count + 1];
                string binNumRow = Convert.ToString(i, 2);
                int numRow = int.Parse(binNumRow);
                binNumRow = numRow.ToString($"D{count}");
                for (int j = 0; j < count; j++)
                {
                    tableValues[j] = binNumRow[j].ToString();
                }
                TableFunction.Rows.Add(tableValues);
            }
        }
        void FillFunction(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < Math.Pow(2, count); i++)
            {
                TableFunction.Rows[i].Cells[count].Value = rnd.Next(2);
            }
        }
        private void RandomFunction_Click(object sender, EventArgs e)
        {
            if (TableFunction.Columns.Count == 0)
                MessageBox.Show("Сначала создайте таблицу");
            else
            {
                switch (ComboBox_Count.SelectedIndex)
                {
                    case 0:
                        FillFunction(2);
                        break;
                    case 1:
                        FillFunction(3);
                        break;
                    case 2:
                        FillFunction(4);
                        break;
                    case 3:
                        FillFunction(5);
                        break;
                }
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            bool isCalculate = true;
            for (int i = 0; i < TableFunction.Rows.Count && isCalculate; i++)
            {
                for (int j = 0; j < TableFunction.Columns.Count && isCalculate; j++)
                {
                    if (TableFunction.Rows[i].Cells[j].Value == null)
                    {
                        isCalculate = false;
                    }
                }
            }
            if (isCalculate)
            {
                string[] arr = new string[(int)Math.Pow(2, TableFunction.Columns.Count - 1)];
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < TableFunction.Columns.Count; j++)
                    {
                        if (j == TableFunction.Columns.Count - 1)
                        {
                            arr[i] += " ";
                        }
                        arr[i] += TableFunction.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ShowInfo form = new ShowInfo(LaboratoryWork.Execute(arr, TableFunction.Columns.Count - 1));
                form.Show();
                //MessageBox.Show(LaboratoryWork.Execute(arr, TableFunction.Columns.Count - 1));
            }
            else
                MessageBox.Show("Заполните все значения функций");
        }
    }
}
