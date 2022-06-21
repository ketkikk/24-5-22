using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentApp
{
    class Program
    {
        static void Main2(string[] args)
        {
            Appointment obj = new Appointment("Tuesday", 15);
            var res = obj.CheckSlot();
        }



        public class Appointment
        {
            string Day
            {
                get;
                set;
            }

            int Time
            {
                get;
                set;
            }

            public Appointment(string Day, int Time)
            {
                this.Day = Day;
                this.Time = Time;
            }


            public string CheckSlot()
            {
                if (Day == "Monday" && Time >= 8 && Time <= 17) return "Available";
                if (Day == "Tuesday" && Time >= 8 && Time <= 15) return "Available";
                if (Day == "Wednesday" && Time >= 8 && Time <= 13) return "Available";
                if (Day == "Thrusday" && Time >= 8 && Time <= 11) return "Available";
                if (Day == "Friday" && Time >= 8 && Time <= 9) return "Available";

                return "Not Available";
            }
            private Dictionary<string, int> GetTimeSlots()
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                dict.Add("Monday", 17);
                dict.Add("Tuesday", 15);
                dict.Add("Wednesday", 13);
                dict.Add("Thrusday", 11);
                dict.Add("Friday", 9);
                return dict;
            }
        }
    }
}