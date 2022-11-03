using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_GAI
{
    public partial class Students : Form
    {
        private StudentsTable studentstable;
        public Students()
        {
            InitializeComponent();
        }

        private void students_GaisinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students_GaisinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_GaisinDataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GaisinDataSet.Students_Gaisin". При необходимости она может быть перемещена или удалена.
            this.students_GaisinTableAdapter.Fill(this.education_GaisinDataSet.Students_Gaisin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentstable = new StudentsTable();
            studentstable.Visible = true;
        }
    }
}
