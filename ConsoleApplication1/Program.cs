
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How Many Number Do You Have?:");
            string strNumberCount =
                System.Console.ReadLine();
            int intNumberCount =
                System.Convert.ToInt32(strNumberCount);

            int[] intNumbers = new int[intNumberCount];

            int intIndex = 1;
            while (intIndex <= intNumberCount)
            {
                string strMessage =
                    string.Format("[{0}]: ", intIndex);
                System.Console.Write(strMessage);

                string strNumber =
                    System.Console.ReadLine();
                int intNumber =
                    System.Convert.ToInt32(strNumber);

                intNumbers[intIndex - 1] = intNumber;

                intIndex++;
            }

            int intSum = 0;

            for (int intCurrentIndex = 0; intCurrentIndex < intNumberCount; intCurrentIndex++)
            {
                intSum +=
                    intNumbers[intCurrentIndex];
            }

            string strResult =
                string.Format("The sum of these numbers is: {0}", intSum);


            System.Console.WriteLine(strResult);


            System.Console.Write("Press [ENTER] To Exit...");
            System.Console.ReadLine();

        }
    }
}
