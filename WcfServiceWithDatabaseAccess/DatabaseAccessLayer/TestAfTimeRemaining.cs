using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceWithDatabaseAccess.DatabaseAccessLayer
{
    public class TestAfTimeRemaining
    {
        //public void auctiondifference()
        //{
        //    datetime auctionstart = new datetime(2010, 1, 1, 8, 0, 15);
        //    datetime auctionend = new datetime(2010, 8, 18, 13, 30, 30);
        //    timespan difference = auctionend - auctionstart;
        //    console.writeline("{0} - {1}", auctionend, auctionstart, difference.tostring());

        //}
        public void auctionDifference()
        {
        DateTime auctionStart = new DateTime(2010, 05, 12, 13, 15, 00);
        DateTime auctionEnd = new DateTime(2010, 05, 12, 13, 45, 00);
        Console.WriteLine(auctionEnd.Subtract(auctionStart).TotalMinutes);
        }
    }

}
