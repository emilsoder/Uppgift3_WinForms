using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift3.Data_Layer;

namespace Uppgift3.Model_Layer
{
    public class Model
    {
        private IView view;
        public Model(IView _view)
        {
            view = _view;
        }

        public void GetNameData()
        {
            using (var db = new ContactsDataModel())
            {
                var result = from c in db.Contacts
                             select c;

                List<Contacts> list = result.ToList();

                foreach (Contacts item in list)
                {
                    view.DataSource(item.FirstName + " " + item.LastName);
                }
            }
        }

        public void GetContactInfo(string name)
        {
            using (var db = new ContactsDataModel())
            {
                int ove = name.LastIndexOf(' ');
                string _name = name.Remove(ove);
                string _lastName = name.Remove(0, ove).Trim();

                var resultat = from c in db.Contacts
                               where c.FirstName == _name && c.LastName == _lastName
                               select c;

                List<Contacts> lista = resultat.ToList();

                foreach (var item in lista)
                {
                    view.setLblTitleName = item.FirstName + " " + item.LastName;
                    view.setTxtMobilePhone = item.MobilePhone;
                    view.setTxtPhoneWork = item.WorkPhone;
                    view.setTxtPhoneHome = item.HomePhone;
                    view.setTxtHomeAddress = item.HomeAddress;
                    view.setTxtWorkAddress = item.WorkAddress;
                    view.setTxtOtherAddress = item.OtherAddress;
                }
            }
        }

        public void EditContact(string name)
        {
            using (var db = new ContactsDataModel())
            {

                int ove = name.LastIndexOf(' ');
                string _name = name.Remove(ove);
                string _lastName = name.Remove(0, ove).Trim();

                var resultat = from c in db.Contacts
                               where c.FirstName == _name && c.LastName == _lastName
                               select c;


                Contacts item = resultat.Single();

                item.MobilePhone = view.setTxtMobilePhone;
                item.WorkPhone = view.setTxtPhoneWork;
                item.HomePhone = view.setTxtPhoneHome;
                item.HomeAddress = view.setTxtHomeAddress;
                item.WorkAddress = view.setTxtWorkAddress;
                item.OtherAddress = view.setTxtOtherAddress;

                db.SaveChanges();
            }
        }
    }
}
