using PMQLBH.BUS;
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
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void btnEndInfoDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CompanyInfoBUS companyInfoBUS = new CompanyInfoBUS();
        FieldBUS fieldBUS = new FieldBUS();
        CompanyInfo companyInfo = new CompanyInfo();
        private void InformationForm_Load(object sender, EventArgs e)
        {
            companyInfo = companyInfoBUS.LoadInfo();
            txtCompanyName.Text = companyInfo.CompanyName.ToString();
            txtCompanyAddress.Text = companyInfo.Address.ToString();
            txtCompanyPhoneNumber.Text = companyInfo.PhoneNumber.ToString();
            txtCompanyFax.Text = companyInfo.Fax.ToString();
            txtCompanyWebsite.Text = companyInfo.Website.ToString();
            txtCompanyEmail.Text = companyInfo.Email.ToString();
            txtCompanyTax.Text = companyInfo.Tax.ToString();

            
            cbbCompanyField.DataSource = fieldBUS.LoadInfo();
            cbbCompanyField.DisplayMember = "FieldName";
            cbbCompanyField.ValueMember = "FieldID";
            cbbCompanyField.SelectedValue = companyInfo.FiledID;
            txtCompanyGDKD.Text = companyInfo.GPKD.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            companyInfo.CompanyName = txtCompanyName.Text;
            companyInfo.Address = txtCompanyAddress.Text;
            companyInfo.PhoneNumber = txtCompanyPhoneNumber.Text;
            companyInfo.Fax = txtCompanyFax.Text;
            companyInfo.Website = txtCompanyWebsite.Text;
            companyInfo.Email = txtCompanyEmail.Text;
            companyInfo.FiledID = int.Parse(cbbCompanyField.SelectedValue.ToString());
            companyInfo.Tax = txtCompanyTax.Text;
            companyInfo.GPKD = txtCompanyGDKD.Text;

            companyInfoBUS.UpdateInfo(companyInfo);

            MessageBox.Show("Update Successful!!!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
