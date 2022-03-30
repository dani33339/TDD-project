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
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(salarytextBox.Text);
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
                double newsalary =  CalcTax(double.Parse(eachItem.SubItems[1].Text));
                newsalary = Math.Floor(newsalary * 100) / 100;
                eachItem.SubItems[0].Text = newsalary.ToString();
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

        private void addmorebtn_Click(object sender, EventArgs e)
        {
            AddEmployees(10000);
        }

        public ListView getListView()
        {
            return listView;
        }

        public void AddEmployees(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int namelength = 7;

                // creating a StringBuilder object()
                StringBuilder name = new StringBuilder();
                Random random = new Random();

                char letter;

                for (int j = 0; j < namelength; j++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    name.Append(letter);
                }
                String id = random.Next(10000000, 99999999).ToString("D6");
                String salary = random.Next(0, 100000).ToString();


                ListViewItem item = new ListViewItem();
                item.SubItems.Add(salary);
                item.SubItems.Add(id);
                item.SubItems.Add(name.ToString());
                listView.Items.Add(item);
            }
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            
            SortBySalary();
        }

        public void SortBySalary()
        {     
            ////bubble sort runtime O(n^2)
            //ListView SortedlistView = new ListView();
            //int n = listView.Items.Count;
            //for (int i = 0; i < n - 1; i++)
            //    for (int j = 0; j < n - i - 1; j++)
            //        if (double.Parse(listView.Items[j].SubItems[1].Text) > double.Parse(listView.Items[j + 1].SubItems[1].Text))
            //        {                        
            //            ListViewItem temp1 = listView.Items[j];
            //            ListViewItem temp2 = listView.Items[j+1];
            //            listView.Items.Remove(temp1);
            //            listView.Items.Insert(j+1, temp1);
            //            listView.Items.Remove(temp2);
            //            listView.Items.Insert(j, temp2);
            //        }

            ListViewItem[] items = new ListViewItem[listView.Items.Count];
            listView.Items.CopyTo(items, 0);

            sort(items, 0, listView.Items.Count - 1);

            void merge(ListViewItem[] items, int l, int m, int r)
            {
                // Find sizes of two
                // subarrays to be merged
                int n1 = m - l + 1;
                int n2 = r - m;

                // Create temp arrays
                ListViewItem [] L = new ListViewItem[n1];
                ListViewItem [] R = new ListViewItem[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = items[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = items[m + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarray array
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (double.Parse(items[j].SubItems[1].Text) > double.Parse(items[j + 1].SubItems[1].Text))
                    {
                        items[k] = L[i];
                        i++;
                    }
                    else
                    {
                        items[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1)
                {
                    items[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2)
                {
                    items[k] = R[j];
                    j++;
                    k++;
                }
            }

            // Main function that
            // sorts arr[l..r] using
            // merge()
            void sort(ListViewItem [] items, int l, int r)
            {
                if (l < r)
                {
                    // Find the middle
                    // point
                    int m = l + (r - l) / 2;

                    // Sort first and
                    // second halves
                    sort(items, l, m);
                    sort(items, m + 1, r);

                    // Merge the sorted halves
                    merge(items, l, m, r);
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
