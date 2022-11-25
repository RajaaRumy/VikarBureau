using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikarBureau.Models
{
    public class Vikar : INotifyPropertyChanged
    {
         
            private int id;
            private string firstName;
            private string lastName;
            private string address; 
            private string city;
            private int zipCode;

          public event PropertyChangedEventHandler PropertyChanged;
          protected void OnPropertychanged(string PropertyName)
          {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(firstName));
            }
          }
            public int ID { 
            
                get { return id; }
                set
                {
                    id = value;
                    OnPropertychanged("ID");
                }
            }
            public string FirstName { 
        
                get { return firstName; }
                set
                {
                    firstName = value;
                    OnPropertychanged("FirstName");
                }
            }
            public string LastName { 
        
                get { return lastName; }
                set
                {
                    lastName = value;
                    OnPropertychanged("LastName");
                }
            }

            public string Address { 
        
                get { return address; }
                set
                {
                    address = value;
                    OnPropertychanged("Address");
                }
            }
            public string City { 
        
                get { return city; }
                set
                {
                     city = value;
                    OnPropertychanged("City");
                }
            }
            public int ZipCode { 
        
                get { return zipCode; }
                set
                {
                    zipCode = value;
                    OnPropertychanged("ZipCode");
                }
            }

      
    }



}
    

