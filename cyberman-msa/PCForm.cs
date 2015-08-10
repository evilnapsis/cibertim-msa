using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cyberman_msa
{
    public partial class PCForm : Form
    {
        public static String action = "";
        public static int r_index;
        public static DataGridView data;
        public static String pc_id = "";
        public static String pc_name = "";
        public static String pc_inicio="";
        public static String pc_tiempo="";
        public static String pc_total="";
        public PCForm()
        {
            InitializeComponent();

            foreach (PC px in PC.total)
            {
                if (px.id.ToString() == data.Rows[r_index].Cells[0].Value.ToString())
                {
                    price.Text = px.precio.ToString();
                }
            }

            name.Text = pc_name;
            if (action == "add")
            {
                btn_stop.Enabled = false;
            }
            else if (action == "del")
            {
                inicio.Text = pc_inicio;
                tiempo.Text = pc_tiempo;
                t.Text = pc_total;
                btn_start.Enabled = false;
                change_price.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSAConnection.execute("update item set inicio = \"" + DateTime.Now + "\" where id=" + data.Rows[r_index].Cells[0].Value.ToString());
            DateTime n = DateTime.Now;
            data.Rows[r_index].Cells[2].Value = n.Hour + ":" + n.Minute + ":" + n.Second;
            double price = 0;
            foreach (PC px in PC.total)
            {
                if (px.id.ToString() == data.Rows[r_index].Cells[0].Value.ToString())
                {
                    price = px.precio;
                }
            }
            PC p = new PC();
            p.id = int.Parse(data.Rows[r_index].Cells[0].Value.ToString());
            p.precio = price;

            p.inicio = DateTime.Now;
            PC.list.Add(p);
            Dispose();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            MSAConnection.execute("update item set inicio = NULL where id=" + data.Rows[r_index].Cells[0].Value.ToString());
            data.Rows[r_index].Cells[2].Value = "";
            data.Rows[r_index].Cells[3].Value = "";
            data.Rows[r_index].Cells[4].Value = "";
            for (int i = 0; i < PC.list.Count; i++)
            {
                if (PC.list[i].id.ToString() == data.Rows[r_index].Cells[0].Value.ToString())
                {
                    PC.list.RemoveAt(i);
                }

            }
            Dispose();
        }

        private void PCForm_Load(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (price.Text != "")
            {

                MSAConnection.execute("update item set precio = " + price.Text + "  where id = " + pc_id);
                MessageBox.Show("Se ha actualizado extisamente el precio, debe reiniciar el programa para ver el cambio.");
            }
            else
            {

                MessageBox.Show("No puedes dejar el campo de precio en blanco!");
            }

        }
    }
}
