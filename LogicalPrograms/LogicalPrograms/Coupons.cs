//-----------------------------------------------------------------------
// <copyright file="Coupons.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace LogicalPrograms
{
    using System;

    /// <summary>
    /// this is Coupons class
    /// </summary>
    public class Coupons
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coupons"/> class.
        /// </summary>
        public Coupons()
        {
            int distinct = 0, count = 0;
            Console.WriteLine("Enter a number of given distinct coupons:");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            bool[] isCollected = new bool[couponNo];
            while (distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;
                if (!isCollected[newCoupon])
                {
                    distinct++;
                    isCollected[newCoupon] = true;
                }
            }

            Console.WriteLine("Total random number needed to have all distinct coupons:" + count);
        }
    }
}
