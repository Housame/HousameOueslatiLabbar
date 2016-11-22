using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousameOueslatiLabb3
{
    public class Event : User
    {
        public string Place { get; set; }//  //Plats info
        public DateTime Date { get; set; }   //Datum för evenemanget
        public string Type { get; set; }     //Typ av evenemanget
        public int AllowedAge { get; set; }  //Tillåtet ålder för att boka
        public string EventName { get; set; }//Evenemangets namn
        public int Price { get; set; }       //Priset
        

        public override string ToString()// en override på ToString just för att skriva ut infon på events på ett passande sätt
        {
            return string.Format("{0}: {1}  \nPlace: {2} \nTime: {3} \nPrice: {4} $ ", Type, EventName, Place, Date, Price);
        }

    }
}