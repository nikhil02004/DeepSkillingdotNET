using System;

namespace EcommerceSearchDemo
{
    class SearchDemo
    {
        public static int LinearSearch(Product[] products, string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(Product[] products, string name)
        {
            int low = 0, high = products.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);
                if (comparison == 0)
                    return mid;
                else if (comparison < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
    }
}
