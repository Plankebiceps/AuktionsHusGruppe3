using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer
{
    public class Test
    {
        public void auctionDifference()
        {
            DateTime auctionStart = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime auctionEnd = new DateTime(2010, 8, 18, 13, 30, 30);
            TimeSpan difference = auctionEnd - auctionStart;
            Console.WriteLine("{0} - {1}", auctionEnd, auctionStart, difference.ToString());

        }
    }

}
