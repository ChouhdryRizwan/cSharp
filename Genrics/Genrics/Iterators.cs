//static IEnumerable<int> GetNumbers()
//{
//    //Console.WriteLine("start");
//yield return 1;
//yield return 2;
//yield return 3;
//yield return 4;
//yield return 5;
//    //Console.WriteLine("end");
//}


//foreach (int num in GetNumbers())
//{
//    Console.WriteLine(num);
//}


//static IEnumerable<int> GetNumbers6()
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        if (i > 6)
//        {
//            yield break;  // Stop iteration if number is greater than 5
//        }

//        yield return i;
//    }
//}


static IEnumerable<int> GetNumbers(List<int> nums)
{
    foreach (int num in nums)
    {
        yield return num;  // Lazily returning each number
    }
}

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Using foreach with iterator
foreach (int num in GetNumbers(numbers))
{
    Console.WriteLine(num);
}