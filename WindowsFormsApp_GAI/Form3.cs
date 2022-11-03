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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void subjects_GaisinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_GaisinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_GaisinDataSet);

        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GaisinDataSet.Subjects_Gaisin". При необходимости она может быть перемещена или удалена.
            this.subjects_GaisinTableAdapter.Fill(this.education_GaisinDataSet.Subjects_Gaisin);

        }
    }
}
