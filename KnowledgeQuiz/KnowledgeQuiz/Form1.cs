using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KnowledgeQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInventory.Text = LinqToXMLObjectModel.GetXmlInventory().ToString(); 
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.InsertNewElement(txtQuestion.Text, txtAnswer1.Text, txtAnswer2.Text, txtAnswer3.Text, txtAnswer4.Text);

            txtInventory.Text = LinqToXMLObjectModel.GetXmlInventory().ToString();
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            LinqToXMLObjectModel.LookUpAnswers(txtLookUp.Text);
        }

  
    }
}
