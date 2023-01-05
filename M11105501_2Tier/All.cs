using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11105501_2Tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'concouDataSet.country' 資料表。您可以視需要進行移動或移除。
            this.countryTableAdapter.Fill(this.concouDataSet.country);
            // TODO: 這行程式碼會將資料載入 'concouDataSet.Continent' 資料表。您可以視需要進行移動或移除。
            this.continentTableAdapter1.Fill(this.concouDataSet.Continent);
            // TODO: 這行程式碼會將資料載入 'conLoDataSet1.Continent' 資料表。您可以視需要進行移動或移除。
            this.continentTableAdapter.Fill(this.conLoDataSet1.Continent);
            // TODO: 這行程式碼會將資料載入 'conLoDataSet.Location' 資料表。您可以視需要進行移動或移除。
            this.locationTableAdapter.Fill(this.conLoDataSet.Location);
            // TODO: 這行程式碼會將資料載入 'conLoDataSet.Continent' 資料表。您可以視需要進行移動或移除。
            this.continentTableAdapter.Fill(this.conLoDataSet.Continent);
            // TODO: 這行程式碼會將資料載入 'dlDataSet.Detail1' 資料表。您可以視需要進行移動或移除。
            //this.detail1TableAdapter1.Fill(this.dlDataSet.Detail1);
            // TODO: 這行程式碼會將資料載入 'dlDataSet.list1' 資料表。您可以視需要進行移動或移除。
            //this.list1TableAdapter.Fill(this.dlDataSet.list1);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet3.list' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter.Fill(this.lLSDataSet3.list);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet2.Detail' 資料表。您可以視需要進行移動或移除。
            this.detailTableAdapter1.Fill(this.lLSDataSet2.Detail);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet2.Detail' 資料表。您可以視需要進行移動或移除。
            this.detailTableAdapter1.Fill(this.lLSDataSet2.Detail);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet2.list' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter.Fill(this.lLSDataSet2.list);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet1.Detail' 資料表。您可以視需要進行移動或移除。
            this.detailTableAdapter1.Fill(this.lLSDataSet1.Detail);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet1.list' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter.Fill(this.lLSDataSet1.list);
            // TODO: 這行程式碼會將資料載入 'lLSDataSet.list' 資料表。您可以視需要進行移動或移除。
            this.listTableAdapter.Fill(this.lLSDataSet.list);
            // TODO: 這行程式碼會將資料載入 'detailDataSet1.Detail2' 資料表。您可以視需要進行移動或移除。
            this.detail2TableAdapter.Fill(this.detailDataSet1.Detail2);
            // TODO: 這行程式碼會將資料載入 'detailDataSet3.Detail1' 資料表。您可以視需要進行移動或移除。
            this.detail1TableAdapter.Fill(this.detailDataSet3.Detail1);
            // TODO: 這行程式碼會將資料載入 'detailDataSet2.Detail1' 資料表。您可以視需要進行移動或移除。
            this.detail1TableAdapter.Fill(this.detailDataSet2.Detail1);
            // TODO: 這行程式碼會將資料載入 'detailDataSet2.Detail1' 資料表。您可以視需要進行移動或移除。
            this.detail1TableAdapter.Fill(this.detailDataSet2.Detail1);
            // TODO: 這行程式碼會將資料載入 'detailDataSet1.Detail1' 資料表。您可以視需要進行移動或移除。
            this.detail1TableAdapter.Fill(this.detailDataSet1.Detail1);
            // TODO: 這行程式碼會將資料載入 'detailDataSet.Detail' 資料表。您可以視需要進行移動或移除。
            this.detailTableAdapter.Fill(this.detailDataSet.Detail);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.detailTableAdapter.FillBy(this.detailDataSet.Detail);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.detailTableAdapter.FillBy(this.detailDataSet.Detail);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy(this.detailDataSet.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy(this.detailDataSet1.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy(this.detailDataSet.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy(this.detailDataSet.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy1(this.detailDataSet.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy2(this.detailDataSet.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy2(this.detailDataSet3.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy2(this.detailDataSet.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy3(this.detailDataSet1.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.detail1TableAdapter.FillBy3(this.detailDataSet2.Detail1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                //this.location1TableAdapter.FillBy(this.lLSDataSet.Location1, new System.Nullable<double>(((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            location1TableAdapter.FillBy(this.lLSDataSet.Location1, comboBox1.SelectedIndex + 1);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.location1TableAdapter.Fill(this.lLSDataSet.Location1, new System.Nullable<double>(((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_6(object sender, EventArgs e)
        {
            try
            {
                //this.detailTableAdapter1.FillBy(this.lLSDataSet.Detail, new System.Nullable<double>(((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_7(object sender, EventArgs e)
        {
            try
            {
                //this.detailTableAdapter1.FillBy(this.lLSDataSet2.Detail, new System.Nullable<double>(((double)(System.Convert.ChangeType(listToolStripTextBox.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
               // this.detailTableAdapter1.FillBy(this.lLSDataSet1.Detail, new System.Nullable<double>(((double)(System.Convert.ChangeType(listToolStripTextBox1.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
               // this.detailTableAdapter1.FillBy(this.lLSDataSet.Detail, new System.Nullable<double>(((double)(System.Convert.ChangeType(listToolStripTextBox2.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            location1TableAdapter.FillBy(this.lLSDataSet3.Location1, comboBox1.SelectedIndex );
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            detail11TableAdapter.Fill(this.dlDataSet.Detail11, comboBox1.SelectedIndex);
        }

        private void fillByToolStripButton_Click_8(object sender, EventArgs e)
        {
            try
            {
               // this.locationTableAdapter.FillBy(this.conLoDataSet.Location, cToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            locationTableAdapter.FillBy(this.conLoDataSet.Location, comboBox2.SelectedText);
        }

        private void fillByToolStripButton_Click_9(object sender, EventArgs e)
        {
            try
            {
                //this.locationTableAdapter.FillBy(this.conLoDataSet.Location, cToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
