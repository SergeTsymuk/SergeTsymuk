
Console.Write("Please Enter Ammount of tail in m2: ");
int quantity = Convert.ToInt32(Console.ReadLine());

decimal discount = 0;
const decimal minQuantityForDiscount = 500;
bool discountAvailable = quantity >= minQuantityForDiscount;

decimal cost = 20;
decimal totalCost = quantity * cost;


if (discountAvailable) 
{
    const decimal discountPercentage = 20; // % discoint
    discount = totalCost / 100 * discountPercentage;
}
else
{
    const decimal discountPercentage = 10; // % discoint
    discount = totalCost / 100 * discountPercentage;
}

decimal priceAfterDiscount = totalCost - discount;

Console.WriteLine($"{"Ammount of tail: ", - 30} {quantity}");
Console.WriteLine($"{"Cost of tail for 1m2: ", -30} ${cost}");
Console.WriteLine($"{"Total Price: ", -30} ${totalCost}");
Console.WriteLine($"{"Discount: ", -30} ${discount}");
Console.WriteLine($"{"Total Price after discount: ", -30} ${priceAfterDiscount}");
