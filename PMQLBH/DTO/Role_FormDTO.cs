using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQLBH.DTO
{
    public class Role_FormDTO
    {
        int _roleId;
        int _formID;
        string _formName;
        bool _allowAccess;
        bool _allowAdd;
        bool _allowDelete;
        bool _allowUpdate;
        bool _allowImport;
        bool _allowExport;


        public int RoleId { get => _roleId; set => _roleId = value; }
        public int FormID { get => _formID; set => _formID = value; }
        public bool AllowAccess { get => _allowAccess; set => _allowAccess = value; }
        public bool AllowAdd { get => _allowAdd; set => _allowAdd = value; }
        public bool AllowDelete { get => _allowDelete; set => _allowDelete = value; }
        public bool AllowUpdate { get => _allowUpdate; set => _allowUpdate = value; }
        public bool AllowImport { get => _allowImport; set => _allowImport = value; }
        public bool AllowExport { get => _allowExport; set => _allowExport = value; }
        public string FormName { get => _formName; set => _formName = value; }
    }
}
