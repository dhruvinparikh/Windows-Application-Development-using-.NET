using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsTab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableStack.RowCount= 1;
            tableQueue.RowCount = 1;
            tableList.RowCount = 1;
        }
        int countS = 0;
        Stack<String> myStack = new Stack<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                countS++;
                tableStack.RowCount = countS;
                Control control = this.tableStack.GetControlFromPosition(0, countS);
                TextBox tb = new TextBox();
                tableStack.Controls.Add(tb, 0, countS);
                myStack.Push(tbName.Text);
                tb.Text = tbName.Text;
                tb.ReadOnly = true;
                tbName.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Stack<String> temp = new Stack<String>();
            String s = "";
            int cnt = myStack.Count;
            if (myStack.Contains(tbName.Text)){
                int i = 0;
                countS = 0;
                int rowcnt = tableStack.RowCount;
                for (int j = 0; j < rowcnt; j++)
                {
                    Control Control = tableStack.GetControlFromPosition(0,j+1);
                    tableStack.Controls.Remove(Control);
                }
                tableStack.RowCount = 1;
                while(myStack.Count != 0)
                {
                    temp.Push(myStack.Pop());
                }
                myStack = new Stack<String>();
                myStack = temp;
                temp = new Stack<String>();
                do
                {
                    s = myStack.Pop();
                    if (s != tbName.Text)
                    {
                        temp.Push(s);
                        countS++;
                        tableStack.RowCount = countS;
                        Control control = this.tableStack.GetControlFromPosition(0, countS);
                        TextBox tb = new TextBox();
                        tableStack.Controls.Add(tb, 0, countS);
                        tb.Text = s;
                        tb.ReadOnly = true;
                    }
                    i++;
                } while (i < cnt);
                tbName.Text = "";
                myStack = new Stack<String>();
                myStack = temp;
            }
            else
            {
                MessageBox.Show("Not found");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int countQ = 0;
        Queue<String> myQueue = new Queue<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbQueue.Text != "")
            {
                countQ++;
                tableQueue.RowCount = countQ;
                Control control = this.tableQueue.GetControlFromPosition(0, countQ);
                TextBox tb = new TextBox();
                tableQueue.Controls.Add(tb, 0, countQ);
                myQueue.Enqueue(tbQueue.Text);
                tb.Text = tbQueue.Text;
                tb.ReadOnly = true;
                tbQueue.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String s = "";
            Queue<String> temp = new Queue<String>();
            if (myQueue.Contains(tbQueue.Text))
            {
                countQ = 0;
                int rowcnt = tableQueue.RowCount;
                for (int j = 0; j < rowcnt; j++)
                {
                    Control Control = tableQueue.GetControlFromPosition(0, j+1);
                    tableQueue.Controls.Remove(Control);
                }
                tableQueue.RowCount = 1;
                do
                {
                    s = myQueue.Dequeue();
                    myQueue.TrimExcess();
                    if (s != tbQueue.Text)
                    {
                        temp.Enqueue(s);
                        countQ++;
                        tableQueue.RowCount = countQ;
                        Control control = this.tableQueue.GetControlFromPosition(0, countQ);
                        TextBox tb = new TextBox();
                        tableQueue.Controls.Add(tb, 0, countQ);
                        tb.Text = s;
                        tb.ReadOnly = true;
                    }
                } while (myQueue.Count != 0);
                tbQueue.Text = "";
                myQueue = new Queue<string>();
                myQueue = temp;
            }
            else
            {
                MessageBox.Show("Not found");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int countL = 0;
        List<String> myList = new List<string>();
        private void button5_Click(object sender, EventArgs e)
        {
            if (tbList.Text != "")
            {
                countL++;
                tableList.RowCount = countL;
                Control control = this.tableList.GetControlFromPosition(0, countL);
                TextBox tb = new TextBox();
                tableList.Controls.Add(tb, 0, countL);
                myList.Add(tbList.Text);
                tb.Text = tbList.Text;
                tb.ReadOnly = true;
                tbList.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = myList.BinarySearch(tbList.Text);
            if (index >= 0)
            {
                myList.RemoveAt(index);
                myList.TrimExcess();

                int rowcnt = tableList.RowCount;
                for (int j = 0; j < rowcnt; j++)
                {
                    Control Control = tableList.GetControlFromPosition(0, j + 1);
                    tableList.Controls.Remove(Control);
                }
                countL = 0;
                myList.ForEach(item => {
                    countL++;
                    tableList.RowCount = countL;
                    Control control = this.tableList.GetControlFromPosition(0, countL);
                    TextBox tb = new TextBox();
                    tableList.Controls.Add(tb, 0, countL);
                    tb.Text = item;
                    tb.ReadOnly = true;
                });
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void list_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (sender == tbList)
                {
                    button5_Click(null, null);
                }
                else if(sender == tbQueue)
                {
                    button2_Click(null, null);
                }
                 else if(sender == tbName)
                {
                    button1_Click(null, null);
                }
                else if(sender == tbDictionary)
                {
                    button6_Click(null, null);
                }
            }
        }
        int countD = 0;
        Dictionary<int, String> myDictionary = new Dictionary<int, string>();
        private void button6_Click(object sender, EventArgs e)
        {
            if (tbDictionary.Text != "")
            {
                countD++;
                tableDictionary.RowCount = countD;
                Control control = this.tableDictionary.GetControlFromPosition(0, countD);
                TextBox tb = new TextBox();
                tableDictionary.Controls.Add(tb, 0, countD);
                int key = 1;
                while (true)
                {
                    if (!myDictionary.ContainsKey(key))
                    {
                        myDictionary.Add(key, tbDictionary.Text);
                        break;
                    }
                    key++;
                }
                tb.Text = tbDictionary.Text;
                tb.ReadOnly = true;
                tbDictionary.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myDictionary.ContainsValue(tbDictionary.Text))
            {
                int index=0;
                foreach (KeyValuePair<int,string> item in myDictionary)
                {
                    if (item.Value.Equals(tbDictionary.Text))
                    {
                        index = item.Key;
                    }
                }
                myDictionary.Remove(index);
                countD = 0;
                int rowcnt = tableDictionary.RowCount;
                MessageBox.Show(rowcnt + "");
                for (int j = 0; j < rowcnt; j++)
                {
                    Control Control = tableDictionary.GetControlFromPosition(0, j + 1);
                    tableDictionary.Controls.Remove(Control);
                }
                tableDictionary.RowCount = 1;

                foreach (KeyValuePair<int, String> item in myDictionary)
                {
                    countD++;
                    tableDictionary.RowCount = countD;
                    Control control = this.tableDictionary.GetControlFromPosition(0, countD);
                    TextBox tb = new TextBox();
                    tableDictionary.Controls.Add(tb, 0, countD);
                    tb.Text = item.Value;
                    tb.ReadOnly = true;
                }

            }
        }
    }
}
