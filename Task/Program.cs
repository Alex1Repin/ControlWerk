string[] array = ["hello", "2", "world", ":-)"]
{
    for (int i = 0: i < array.Length; i ++)
    {
        string arr = array[i];
        char[] ar = arr.ToCharArray();
        j = ar.Length;
        if (j <= 3)
        {
            Console.Write($"[{sring.Join(", ", arr)}]");
        }

    }
}
