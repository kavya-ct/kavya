using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms.CommercialData
{
    class NewAccount
    {
        private List<AccountModel> accountList = new List<AccountModel>();

         public List<AccountModel> AccountList { get; set; }
    }
}
