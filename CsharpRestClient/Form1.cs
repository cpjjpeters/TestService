using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #region UI Event Handlers

        private void button1_Click(object sender, EventArgs e)
        {
            //DebugOutput("This is some output so I can see what is going on!");
            RestClient rClient = new RestClient();
            rClient.endPoint = txtRestURL.Text;

            DebugOutput("Restclient created");
            string strResponse = String.Empty;
            strResponse = rClient.makeRequest();
            DebugOutput(strResponse);
        }

#endregion

        private void DebugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResponse.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strResponse = String.Empty;
        }
    }
}
