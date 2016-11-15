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
            var db = new ContactsDataModel();
            try
            {
                foreach (Contacts item in (from c in db.Contacts select c).ToList())
                {
                    Task.Factory.StartNew(() => view.DataSource(string.Format("{0} {1}", item.FirstName, item.LastName))).Wait();
                }
            }
            finally
            {
                if (db != null)
                {
                    var t = Task.Factory.StartNew(() => db.Dispose());
                    t.Wait();
                }
            }
        }

        public void GetContactInfo(string name)
        {
            var db = new ContactsDataModel();
            try
            {
                string _name = name.Remove(name.LastIndexOf(' '));
                string _lastName = name.Remove(0, name.LastIndexOf(' ')).Trim();

                foreach (var item in (from c in db.Contacts
                                      where c.FirstName == _name
                                      && c.LastName == _lastName
                                      select c).ToList())
                {
                    view.setTxtContactName = string.Format("{0} {1}", item.FirstName, item.LastName);
                    view.setTxtMobilePhone = item.MobilePhone;
                    view.setTxtPhoneWork = item.WorkPhone;
                    view.setTxtPhoneHome = item.HomePhone;
                    view.setTxtHomeAddress = item.HomeAddress;
                    view.setTxtWorkAddress = item.WorkAddress;
                    view.setTxtOtherAddress = item.OtherAddress;
                }
            }
            finally
            {
                if (db != null)
                {
                    var t = Task.Factory.StartNew(() => db.Dispose());
                    t.Wait();
                }
            }
        }

        public void EditContact(string name)
        {
            var db = new ContactsDataModel();
            try
            {
                int ove = name.LastIndexOf(' ');
                string _name = name.Remove(ove);
                string _lastName = name.Remove(0, ove).Trim();

                var resultat = from c in db.Contacts
                               where c.FirstName == _name && c.LastName == _lastName select c;
                resultat.Single().MobilePhone = view.setTxtMobilePhone;
                resultat.Single().WorkPhone = view.setTxtPhoneWork;
                resultat.Single().HomePhone = view.setTxtPhoneHome;
                resultat.Single().HomeAddress = view.setTxtHomeAddress;
                resultat.Single().WorkAddress = view.setTxtWorkAddress;
                resultat.Single().OtherAddress = view.setTxtOtherAddress;

                var t = Task.Factory.StartNew(() => db.SaveChanges());
                t.Wait();
            }
            finally
            {
                if (db != null)
                {
                    var t1 = Task.Factory.StartNew(() => db.Dispose());
                    t1.Wait();
                }
            }
        }
    }
}
