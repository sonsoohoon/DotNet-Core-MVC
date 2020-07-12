using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Services
{
    public class IDateTimeImpl : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
