using System;
using System.Collections.Generic;

namespace Uppgift3
{
    public interface IView
    {
        void DataSource(string value);
        string setTxtPhoneWork { get; set; }
        string setTxtPhoneHome { get; set; }
        string setTxtMobilePhone { get; set; }
        string setTxtContactName { get; set; }
        string setTxtHomeAddress { get; set; }
        string setTxtWorkAddress { get; set; }
        string setTxtOtherAddress { get; set; }
    }
}
