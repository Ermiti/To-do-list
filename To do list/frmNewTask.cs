using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_do_list.context;
using To_do_list.IRepository;


namespace To_do_list
{
    public partial class frmNewTask : Form
    {
        private UnitOfWork db;
        public frmNewTask()
        {
            InitializeComponent();
        }

        private void frmNewTask_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            db = new UnitOfWork();

            LIstComponent list = new LIstComponent()
            {
                Title = txtTitle.Text,
                Discription = txtDiscription.Text
            };

            // db.IToDoList.Add(list);
            db.Save();
            db.Dispose();
            DialogResult = DialogResult.OK;
        }
           
        
    }
} 
