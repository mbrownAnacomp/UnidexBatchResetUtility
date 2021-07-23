using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using UnidexIBMLDAL;
using System.Configuration;
using System.Data.SqlClient;

namespace TestUnidexDAL
{
    public partial class Form1 : Form
    {
        private string dataProvider;
        private string connectionString;
        private UnidexIBMLDAL.DataOperations.UnidexDAL unidex ;
        private UnidexIBMLDAL.DataOperations.IBMLDAL ibml;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(comboBox1.Text))
            {
                string dataProvider = ConfigurationManager.AppSettings["provider"];
                   
                switch (comboBox1.Text)
                {
                    case "UnidexBumed":
                        connectionString = ConfigurationManager.AppSettings["unidexBumedConnectionString"];
                        break;
                    case "UnidexBumedLoosePaper":
                        connectionString = ConfigurationManager.AppSettings["unidexBumedLoosePaperConnectionString"];
                        break;
                    case "UnidexUAT":
                        connectionString = ConfigurationManager.AppSettings["unidexUATConnectionString"];
                        break;
                    case "UnidexLoosePaperUAT":
                        connectionString = ConfigurationManager.AppSettings["unidexUATConnectionString"];
                        break;
                }
                 
                //SqlConnection connetion = new SqlConnection(connectionString);
                unidex = new UnidexIBMLDAL.DataOperations.UnidexDAL(connectionString);

            }
            else
            {
                MessageBox.Show("Please select  a project Database ","No database selected from dropdown");
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                // we use this collection to keep all the Selected Items
                List<object> selectedItemList = new List<object>();
                foreach (object row in listBox1.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();

                    // Keep on adding selected item into a new List of Object
                    selectedItemList.Add(row);
                }
                sb.Remove(sb.Length - 1, 1);    // Just to avoid copying last empty row                
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
                // Removing selected items from the ListBox
                foreach (object ln in selectedItemList)
                {
                    listBox1.Items.Remove(ln);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting Text from Clip board
                string s = Clipboard.GetText();
                //Parsing criteria: New Line
                string[] lines = s.Split('\n');
                foreach (string ln in lines)
                {
                    listBox1.Items.Add(ln.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestSQL();
        }

        private void TestSQL()
        {
            List<string> list = new List<string>();
            if (unidex == null)
            {
                MessageBox.Show("Please select a database from the menu.", "No database selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBox1.Items.Count > 0)
            {
                for (int l = 0; l < listBox1.Items.Count; l++)
                {
                    list.Add(listBox1.Items[l].ToString());
                }

                string listData = unidex.GetList(list);
                List<string> returnList = unidex.TestSelectQuery(listData);
                foreach (string r in returnList)
                {
                    listBox2.Items.Add(r);
                }

            }
        }

        private void rbBUMED_CheckedChanged(object sender, EventArgs e)
        {
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["unidexBumedConnectionString"];
            unidex = new UnidexIBMLDAL.DataOperations.UnidexDAL(connectionString);
        }

        private void rbLoosePaper_CheckedChanged(object sender, EventArgs e)
        {
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["unidexBumedLoosePaperConnectionString"];
            unidex = new UnidexIBMLDAL.DataOperations.UnidexDAL(connectionString);
        }

        private void rbBumedUAT_CheckedChanged(object sender, EventArgs e)
        {
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["unidexUATConnectionString"];
            unidex = new UnidexIBMLDAL.DataOperations.UnidexDAL(connectionString);
        }

        private void rbLoosePaperUAT_CheckedChanged(object sender, EventArgs e)
        {
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["unidexUATConnectionString"];
            unidex = new UnidexIBMLDAL.DataOperations.UnidexDAL(connectionString);
        }

        private void grpOperation_Validated(object sender, EventArgs e)
        {
            GroupBox g = sender as GroupBox;
            var a = from RadioButton r in g.Controls where r.Checked == true select r.Name;
            label3.Text = a.First();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<string> list = new List<string>();
            if (unidex == null)
            {
                MessageBox.Show("Please select a database from the menu.", "No database selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBox1.Items.Count > 0)
            {
                label3.Text = "Processing Started";
                for (int l = 0; l < listBox1.Items.Count; l++)
                {
                    list.Add(listBox1.Items[l].ToString());                    
                }

                string listData = unidex.GetList(list);
                if (rbPulledPriority.Checked)
                {
                    unidex.ResetBatch("Pulled Priority", list,connectionString);
                    listBox2.Items.Add("Ressting batches to Pulled Priority completed");
                }
                if (rbQAMNRA.Checked)
                {
                    unidex.ResetBatch("QA at MNRA", list, connectionString);
                    listBox2.Items.Add("Ressting batches to QA at NMRA completed");
                }
                if (rbUnidexFinished.Checked)
                {
                    unidex.ResetBatch("Unidex Finished", list, connectionString);
                    listBox2.Items.Add("Ressting batches to Unidex Finish completed");
                }
                if (rbPDFAFinish.Checked)
                {
                    unidex.ResetBatch("PDFA Finished", list, connectionString);
                    listBox2.Items.Add("Ressting batches to PDFA Finish completed");
                }
                if (rbUnitizerFinished.Checked)
                {
                    unidex.ResetBatch("Unitizer Finished", list, connectionString);
                    listBox2.Items.Add("Ressting batches to Unitizer Finish completed");
                }
                if (rbPrepComplete.Checked)
                {
                    string batchIDList = unidex.GetList(list);
                    unidex.ResetBatchToPrepComplete(batchIDList);
                    listBox2.Items.Add("Ressting batches to Prep Complete completed");
                }
                if (rbDeleteIBMLBatch.Checked)
                {
                   
                    string dataProvider = ConfigurationManager.AppSettings["provider"];
                    connectionString = ConfigurationManager.AppSettings["unidexIBMLBumedConnectionString"];
                    ibml = new UnidexIBMLDAL.DataOperations.IBMLDAL(connectionString);
                    ibml.OpenConnection();
                    ibml.DeleteIBMLBatch(list);
                    listBox2.Items.Add("Deleting IBML Batches completed");
                }

                //if (rbCreateBox.Checked)
                //{
                //    unidex.CreateLoosePaperBox();
                //}


            }

            if (rbCreateBox.Checked)
            {
                unidex.CreateLoosePaperBox();
            }

            label3.Text = "Processing Completed";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
