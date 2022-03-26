using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addonebtn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(idtextBox.Text)) ||
                (string.IsNullOrEmpty(firstnametextBox.Text)) ||
                (string.IsNullOrEmpty(salarytextBox.Text)))
                return;
            ListViewItem item = new ListViewItem(salarytextBox.Text);
            item.SubItems.Add(idtextBox.Text);
            item.SubItems.Add(firstnametextBox.Text);
            listView.Items.Add(item);
            idtextBox.Clear();
            firstnametextBox.Clear();
            salarytextBox.Clear();

        }

        private void taxbtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView.Items)
            {
                eachItem.SubItems[0].Text = CalcTax(double.Parse(eachItem.SubItems[0].Text)).ToString();
            }
        }

    public double CalcTax(double salary)
    {
        if (salary>0 && salary<6450)
            return salary - salary * 0.1;

        if (salary > 6450 && salary < 9240)
            return salary - salary * 0.14;

        if (salary > 9240 && salary < 14840)
            return salary - salary * 0.20;

        if (salary > 14840 && salary < 20620)
            return salary - salary * 0.31;

        if (salary > 20620 && salary < 42911)
            return salary - salary * 0.35;

        if (salary > 42911)
            return salary - salary * 0.47;

        return 0;
     }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
