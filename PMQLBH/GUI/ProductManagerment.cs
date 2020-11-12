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
    public partial class ProductManagerment : Form
    {
        public ProductManagerment(List<Role_FormDTO> role_FormDTOList)
        {
            InitializeComponent();
            //this.Tag = 1;
            //foreach(var c in role_FormDTOList)
            //{
            //    if(c.FormID == int.Parse(this.Tag.ToString()))
            //    {
            //        grControl.SetEnabledControl(c);
            //        break;
            //    }
            //}
            
        }
    }
}
