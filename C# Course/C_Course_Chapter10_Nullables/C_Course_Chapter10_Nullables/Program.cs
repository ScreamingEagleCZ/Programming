using Microsoft.VisualBasic;

namespace C_Course_Chapter10_Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullables - Datatype - can be empty or not -
            // good fe. for DBs when not all elements are filled for similar entries
            int? num1 = null;   // ? - for definition of nullable
            int? num2 = 1337;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();

            Console.WriteLine("Our nullable numbers are: *{0}*, *{1}*, *{2}*, *{3}*", num1, num2, num3, num4);
            Console.WriteLine("And nullable bool value: *{0}*", boolval);

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is male");
            } else if(isMale == false)
            {
                Console.WriteLine("User is female");
            } else {
                Console.WriteLine("User is propabbly an Attack helicopter");
            }
            double? num6 = 13.1;
            double? num7 = null;
            double? num8;
            if(num6 == null)
            {
                num8 = 0;
            }
            else
            {
                num8 = num6;
                // num8 = (double)num6;  -historically casting was required to store nullable to double
            }
            Console.WriteLine("Value of num8: {0}", num8);  // 13.1

            // Shorter version - THE NULL COALESCING OPERATOR ??
            // conversion from nullable to non-nullable variable
            num8 = num6 ?? 8.53;    // num6 is not null so the num8 will keep 13.1
            Console.WriteLine("Value of num8: {0}", num8);  // 13.1
            num8 = num7 ?? 8.53;    // num7 is null so the 8.53 will be stored in num8
            Console.WriteLine("Value of num8: {0}", num8);  // 8.53
        }
    }
}
