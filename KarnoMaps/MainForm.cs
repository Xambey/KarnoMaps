using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarnoMaps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initialTable();
        }

        private void initialTable()
        {
            dataGridView1.Rows.Add(15);
        }

        private void incrementByte(ref BitArray n, int i)
        {
            if (i >= 15) return;
            for (int j = 0; i < n.Count; i++)
            {
                if (n[j])
                    n[j] = false;
                else
                    return;
            }
        }

        private void fillTable(string s)
        {
            BitArray n = new BitArray(4, false);
            string bin = "";
            s = new string(s.Reverse<char>().ToArray());
            int k = 0;
            

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if(j == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(i, 16);
                    }
                    else if(j < 5)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = n[k] ? "1" : "0";
                        k++;
                    }
                    else if(j == 5)
                    {
                        bin = Convert.ToString(Convert.ToInt32(s[i].ToString(), 16), 2);
                        while(bin.Count() - 4 != 0)
                        {
                            bin = "0" + bin;
                        }
                        k = 0;
                        dataGridView1.Rows[i].Cells[j].Value = s[i];
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = bin[k];
                        k++;
                    }
                }
                k = 0;
                incrementByte(ref n, i);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            fillTable(textBox1.Text);
        }
    }
}
