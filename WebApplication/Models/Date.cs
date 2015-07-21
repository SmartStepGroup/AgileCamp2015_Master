using System;

namespace WebApplication.Models
{
    public class Date : IDate
    {
        public DateTime Today
        {
            get { return DateTime.Today; }
        }
    }
}