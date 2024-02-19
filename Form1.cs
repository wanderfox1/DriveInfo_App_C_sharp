using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_02_files_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int temp = allDrives.Length;
            dataGridView1.Columns.Add("Drive", "Drive");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("TotalSize", "Total Size");
            dataGridView1.Columns.Add("FreeSpace", "Free Space");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                string[] row = {
                    drive.Name,
                    drive.DriveType.ToString(),
                    drive.TotalSize.ToString(),
                    drive.TotalFreeSpace.ToString(),
                };

                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
