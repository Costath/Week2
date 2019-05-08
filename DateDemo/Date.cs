using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Date
    {
        int year;
        int month;
        int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public override string ToString()
        {
            return $"{year,4}/{month,2}/{day,2}";
        }
        public void Add(int days)
        {
            day += days;

            Normalize();
        }
        public void Add(int month, int days)
        {
            this.month += month;
            day += days; //or this.day += days;

            Normalize();
        }
        public void Add(Date other)
        {
            day += other.day;
            month += other.month;
            year += other.year;

            Normalize();
        }
        private void Normalize()
        {
            while(this.day > 30)
            {
                this.month++;
                this.day -= 30;
            }
            while (this.month > 12)
            {
                this.year++;
                this.month -= 12;
            }
        }
    }
}
