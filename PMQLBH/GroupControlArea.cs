using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMQLBH.DTO;
using PMQLBH.GUI;

namespace PMQLBH
{
    public partial class GroupControlArea : UserControl
    {
        public GroupControlArea()
        {
            InitializeComponent();
           
        }

        public void SetEnabledControl(Role_FormDTO role_FormDTO)
        {
            btnAdd.Enabled = role_FormDTO.AllowAdd;
            btnDelete.Enabled = role_FormDTO.AllowDelete;
            btnUpdate.Enabled = role_FormDTO.AllowUpdate;
            btnImport.Enabled = role_FormDTO.AllowImport;
            btnExport.Enabled = role_FormDTO.AllowExport;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
