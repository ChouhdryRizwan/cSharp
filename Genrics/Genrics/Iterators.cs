static IEnumerable<int> GetNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
}


foreach (int num in GetNumbers())
{
    Console.WriteLine(num);
}


static IEnumerable<int> GetNumbers6()
{
    for (int i = 1; i <= 10; i++)
    {
        if (i > 6)
        {
            yield break;  // Stop iteration if number is greater than 6
        }

        yield return i;
    }
}


foreach (int num in GetNumbers6())
{
    Console.WriteLine(num);
}
