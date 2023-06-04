using Humanizer;

namespace MyApp // Note: actual namespace depends on the project name.
{
    partial class Program
    {
        public class P17
        {
            public P17()
            {
                Console.Write("How many products are there in your store: ");
                var numberOfProducts = Convert.ToInt64(Console.ReadLine());

                float salesmansMoney = 0f;
                long totalSales = 0;

                for(var i = 0; i < numberOfProducts; i++)
                {
                    Console.Write("Please enter the {0} product's degree: ", (i+1).ToOrdinalWords());
                    var degree = Convert.ToByte(Console.ReadLine());

                    Console.Write("Please enter the price of the product here: ");
                    var price = Convert.ToInt64(Console.ReadLine());

                    Console.Write("Please enter how many of this product has been sold: ");
                    var numberOfItemSold = Convert.ToInt64(Console.ReadLine());

                    var totalSalesOfTheItem = numberOfItemSold * price;

                    totalSales += totalSalesOfTheItem;

                    switch (degree)
                    {
                        case 1:
                            if(numberOfItemSold <= 1000000)
                                salesmansMoney += (float)0.06 * totalSalesOfTheItem;
                            else if(numberOfItemSold > 1000000 && numberOfItemSold < 2000000)
                                salesmansMoney += (float)0.07 * totalSalesOfTheItem;
                            else
                                salesmansMoney += (float)0.1 * totalSalesOfTheItem;
                            break;

                        case 2:
                            if(numberOfItemSold < 100000)
                                salesmansMoney += (float)0.04 * totalSalesOfTheItem;
                            else
                                salesmansMoney += (float)0.06 * totalSalesOfTheItem;
                            break;

                        case 3:
                            salesmansMoney += (float)0.412 * totalSalesOfTheItem;
                            break;

                        case 4:
                            salesmansMoney += (float)0.05 * totalSalesOfTheItem;
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("\t\t\t*******result*******");
                Console.WriteLine("\t\tTotal Sales = {0}, Salesman Money = {1}", totalSales, salesmansMoney);
            }
        }
    }
}

