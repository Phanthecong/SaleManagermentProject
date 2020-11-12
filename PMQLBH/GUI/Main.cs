using PMQLBH.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQLBH.GUI
{
    public partial class Main : Form
    {
        List<Role_FormDTO> role_FormDTOList = new List<Role_FormDTO>();
        public Main(List<Role_FormDTO> role_FormDTOList)
        {
            InitializeComponent();
            this.role_FormDTOList = role_FormDTOList;

        }

        private void btnProductManagerment_Click(object sender, EventArgs e)
        {
            ProductManagerment productManagerment = new ProductManagerment(role_FormDTOList);
            productManagerment.Show();
        }

        private void btnUserManagerment_Click(object sender, EventArgs e)
        {
            UserManagerment userManagerment = new UserManagerment(role_FormDTOList);
            userManagerment.Show();
        }
    }
}
