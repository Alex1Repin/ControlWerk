string[] array = {"hello", "2", "world", ":-)"};

void Array(string[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        string arr = array[i];
        char[] ar = arr.ToCharArray();
        if (ar.Length <= 3)
        {
            Console.Write($"[{string.Join(", ", arr)}]");
        }

    }
}
Array(array);