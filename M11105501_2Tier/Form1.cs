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
    }
}
