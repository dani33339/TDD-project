using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            AddEmployees(100);
        }

        public ListView getListView()
        {
            return listView;
        }

        public void AddEmployees(int n)
        {
            for (int i = 0; i < n; i++)
            {
                String[] First_names = { "Liam","Noah","Oliver","Elijah","William","James","Benjamin","Lucas","Henry","Alexander"};
                String[] Last_Names = { "Smith","Johnson","Scottis","Williams","WelshBrown","WelshGarcia","Davis","Welsh","Rodriguez","Martinez"};
                // creating a StringBuilder object()
                StringBuilder name = new StringBuilder();
                Random random = new Random();

               
                String id = random.Next(10000000, 99999999).ToString("D6");
                String salary = random.Next(0, 100000).ToString();

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(salary);
                item.SubItems.Add(id);
                item.SubItems.Add(First_names[random.Next(First_names.Length)]);
                listView.Items.Add(item);
            }
        }

        private void sortbtn_Click(object sender, EventArgs e)
        {
            Stopwatch MyTimer = new Stopwatch();
            MyTimer.Start();
            SortBySalary();
            MyTimer.Stop();
            MessageBox.Show("it takes: " + MyTimer.ElapsedMilliseconds + " " + "Millisecond");
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
            //            ListViewItem temp2 = listView.Items[j + 1];
            //            listView.Items.Remove(temp1);
            //            listView.Items.Insert(j + 1, temp1);
            //            listView.Items.Remove(temp2);
            //            listView.Items.Insert(j, temp2);
            //        }

            //heap sort runtime O(nlog(n))
            int n = listView.Items.Count;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(listView, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {

                // Move current root to end
                ListViewItem temp1 = listView.Items[0];
                ListViewItem temp2 = listView.Items[i];
                listView.Items.Remove(temp1);
                listView.Items.Insert(i, temp1);
                listView.Items.Remove(temp2);
                listView.Items.Insert(0, temp2);



                // call max heapify on the reduced heap
                heapify(listView, i, 0);
            }


            // To heapify a subtree rooted with node i which is
            // an index in arr[]. n is size of heap
            void heapify(ListView arr, int n, int i)
            {
                int largest = i; // Initialize largest as root
                int l = 2 * i + 1; // left = 2*i + 1
                int r = 2 * i + 2; // right = 2*i + 2

                // If left child is larger than root
                if (l < n && double.Parse(listView.Items[l].SubItems[1].Text) > double.Parse(listView.Items[largest].SubItems[1].Text))
                    largest = l;

                // If right child is larger than largest so far
                if (r < n && double.Parse(listView.Items[r].SubItems[1].Text) > double.Parse(listView.Items[largest].SubItems[1].Text))
                    largest = r;

                // If largest is not root
                if (largest != i)
                {
                    ListViewItem temp1 = listView.Items[i];
                    ListViewItem temp2 = listView.Items[largest];
                    listView.Items.Remove(temp1);
                    listView.Items.Insert(largest, temp1);
                    listView.Items.Remove(temp2);
                    listView.Items.Insert(i, temp2);

                    // Recursively heapify the affected sub-tree
                    heapify(arr, n, largest);
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adresstextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
