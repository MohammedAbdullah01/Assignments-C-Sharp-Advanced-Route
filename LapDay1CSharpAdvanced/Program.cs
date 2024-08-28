using System.Collections;

namespace LapDay1CSharpAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question => 1
            //Range<int> range = new Range<int>(10 , 20);
            //Range<int> range = new Range<int>(20 , 10); // throw new ArgumentException("Minimum should not be greater than Maximum.");

            //Console.WriteLine(range.IsInRange(15)); // True
            //Console.WriteLine(range.IsInRange(30)); // False
            //Console.WriteLine(range.Length()); // 10 
            #endregion

            #region Question => 2

            //ArrayList arrayList = new ArrayList(){ 1 , 2 , 3 , true , "Mohamed"  , "Ahmed" , 50.20};

            //Console.WriteLine("Before Reversing");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Helper.ReverseElement(arrayList);

            //Console.WriteLine("After Reversing");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question => 3
            //List<int> arrayList = new List<int> { 1, 4, 5, 6, 8, 9, 7, 12, 52, 80, 40 }, 

            // arrayListEven = Helper.FilterNumberEvenOfArray(arrayList);

            //Console.WriteLine($"Even Numbers: ");
            //foreach (int item in arrayListEven)
            //{
            //    Console.WriteLine($"{item}");
            //} 
            #endregion

        }
    }
}
