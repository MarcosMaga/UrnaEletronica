using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Imprimir : Form
    {
        string text = "";
        public Imprimir(string _text)
        {
            text = _text;
            InitializeComponent();
        }

        private void Imprimir_Load(object sender, EventArgs e)
        {

        }

        private void CarregarImpressoras()
        {
            comboBox1.Items.Clear();
            foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                comboBox1.Items.Add(impressora);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var pd = new System.Drawing.Printing.PrintDocument())
            {
                pd.PrinterSettings.PrinterName = comboBox1.SelectedItem.ToString();
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
        }

        private void Pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using(var font = new Font("Times new Roman", 14))
            using(var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(text, font, brush, e.MarginBounds);
            }
        }
    }
}
