using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DesignWorkflow
{
    public partial class fActionCommand : DevExpress.XtraEditors.XtraForm
    {
       public  string Command = "";
       public string AfterUpdateCommand = "";
       
        public fActionCommand()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (tCommand.Text == "")
            //{
            //    MessageBox.Show("Lệnh rỗng");
            //}
            //else
            //{
            Command = tCommand.Text;
            AfterUpdateCommand = tAfterUpdate.Text;
            this.Dispose();
            //}
        }

        private void fActionCommand_Load(object sender, EventArgs e)
        {
            tCommand.Text = Command;
            tAfterUpdate.Text = AfterUpdateCommand;
        }
    }
}