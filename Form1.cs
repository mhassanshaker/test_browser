using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(string.Format("{0}/staticpage.html",Application.StartupPath));
           
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //get the main div HTML element by ID
            var cke1ContentsElements = webBrowser1.Document.GetElementById("cke_1_contents");
            //from main div select all HTML elements with the tag name "textarea"
            var cke1TextareaList = cke1ContentsElements.GetElementsByTagName("textarea");
            //from the selected list of items set value attribute for first element 
            cke1TextareaList[0].SetAttribute("value", "Send This String To TextArea ");
           
        }
    }
}
