using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.clock.BL
{
    class Class1
    {
        public Class1()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public Class1(int hours)
        {
            this.hours = hours;
        }
        public Class1(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public Class1(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public int hours;
        public int minutes;
        public int seconds;
        public void increaseSecond()
        {
            seconds++;
        }
        public void increaseHours()
        {
            hours++;
        }
        public void increaseMinutes()
        {
            minutes++;
        }
        public void PrintTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int hours, int minutes, int seconds)
        {
            if(this.hours == hours && this.minutes == minutes && this.seconds == seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(Class1 time)
        {
            if(hours == time.hours && minutes == time.minutes && seconds == time.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ElapsedTime()
        {
           hours = hours - 00;
           minutes = minutes - 00;
           seconds= seconds - 00;
            Console.ReadKey();
        }
        public void RemainingTime(Class1 time)
        {
            if (hours != 24)
            {
                hours = 23 - hours;
                minutes = 59 - minutes;
                seconds = 59 - seconds;
            }
            else
            {
                hours = 24 - hours;
                minutes = 0;
                seconds = 0;
            }
           
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
            Console.ReadKey();
        }
        public void Difference(Class1 time1,Class1 time2)
        {
            if (time1.hours > time2.hours)
            {
                hours = time1.hours - time2.hours;
                if (time1.minutes >= time2.minutes)
                {
                    minutes = time1.minutes - time2.minutes;
                }
                else
                {
                    minutes = 60 - time1.minutes;
                    hours--;
                }
                if(time1.seconds >= time2.seconds)
                {
                    seconds = time1.seconds - time2.seconds;
                }
                else
                {
                    seconds = 60 - time1.seconds;
                    seconds--;
                }
            }
            else
            {
                hours = time2.hours - time1.hours;
                if (time2.minutes > time1.minutes)
                {
                    minutes = time2.minutes - time1.minutes;
                }
                else
                {
                    minutes = 60 - time2.minutes;
                    hours--;
                }
                if (time2.seconds >= time1.seconds)
                {
                    seconds = time2.seconds - time1.seconds;
                }
                else
                {
                    seconds = 60 - time2.seconds;
                    seconds--;
                }
            }
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
            Console.ReadKey();
            
            
        }
        
    }
    
}
