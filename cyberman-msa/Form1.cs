using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace cyberman_msa
{
    public partial class Form1 : Form
    {
        public static OleDbDataReader r; 
        public Form1()
        {
            InitializeComponent();
            PC.list = new List<PC>();
            PC.total = new List<PC>();
            data.Columns.Add("Id", "Id");
            data.Columns.Add("PC", "PC");
            data.Columns.Add("Inicio", "Inicio");
            data.Columns.Add("Tiempo", "Tiempo");
            data.Columns.Add("Total", "Total");
            data.Columns[3].Width = 130;
            data.Columns[3].Width = 130;
            r = MSAConnection.read("select * from item");
            while (r.Read())
            {
                String d = "";
                PC p = new PC();
                p.id = r.GetInt32(0);
                p.precio = r.GetInt32(2);
                if (!r.IsDBNull(3))
                {
                    //d = r.GetDateTime(3).ToString();
                    DateTime x = r.GetDateTime(3);
                    d = x.Hour + ":" + x.Minute + ":" + x.Second;
                    p.inicio = r.GetDateTime(3);
                    PC.list.Add(p);
                }
                PC.total.Add(p);
                data.Rows.Add(r.GetInt32(0), r.GetString(1), d);
            }
//            MessageBox.Show(PC.total.Count + "");
         
            thetimer.Start();
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (data.Rows[e.RowIndex].Cells[2].Value != "")
                {
                    PCForm.action = "del";
                    PCForm.data = data;
                    PCForm.r_index = e.RowIndex;
                    PCForm.pc_tiempo = data.Rows[e.RowIndex].Cells[3].Value.ToString();
                    PCForm.pc_total = data.Rows[e.RowIndex].Cells[4].Value.ToString();
                    PCForm.pc_inicio = data.Rows[e.RowIndex].Cells[2].Value.ToString();
                    PCForm.pc_id = data.Rows[e.RowIndex].Cells[0].Value.ToString();
                    PCForm.pc_name = data.Rows[e.RowIndex].Cells[1].Value.ToString();
                    PCForm p = new PCForm();
                    p.ShowDialog();
                }
                else
                {
                    PCForm.action = "add";
                    PCForm.data = data;
                    PCForm.r_index = e.RowIndex;
                    PCForm.pc_id= data.Rows[e.RowIndex].Cells[0].Value.ToString();
                    PCForm.pc_name= data.Rows[e.RowIndex].Cells[1].Value.ToString();
                    PCForm p = new PCForm();
                    p.ShowDialog();
                }
            }
            catch (NullReferenceException ne) { }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Rows.Count-1;i++ )
            {
                try
                {
                    if (data.Rows[i].Cells[2].Value != "")
                    {
                        DateTime now = DateTime.Now;
                        DateTime inicio = now;
                        double precio = 0;
                        foreach (PC p in PC.list)
                        {
                            if (data.Rows[i].Cells[0].Value.ToString() == p.id.ToString())
                            {
                                inicio = p.inicio;
                                precio = p.precio;
                            }
                        }
                        if (inicio != now)
                        {
                            double p = precio;
                            double s = 0;
                             s += int.Parse((now - inicio).Hours.ToString())*60*60;
                             s += int.Parse((now - inicio).Minutes.ToString()) * 60;
                             s += int.Parse((now - inicio).Seconds.ToString());
                             double c = (s / 60 / 60) * p;
                             data.Rows[i].Cells[3].Value = (now - inicio).Hours + ":" + (now - inicio).Minutes + ":" + (now - inicio).Seconds;
                             data.Rows[i].Cells[4].Value = c.ToString("C");
                        }
                    }
                }
                catch (ExecutionEngineException ne) { }
            }
        }

        private void acercaDeCyberManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
    }
}
