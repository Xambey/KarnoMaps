using System;
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
            dataGridView1.Rows.Add(14);
        }

        private void fillTable()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                }
            }
        }
    }
}
