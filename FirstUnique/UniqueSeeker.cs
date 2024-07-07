namespace FirstUnique;

public static class UniqueSeeker
{
    public static int Check(int[] numbers)
    {
        var unique = -1;

        for (var i = 0; i < numbers.Length; i += 1)
        {
            var isUnique = true;
            for (var j = 0; j < numbers.Length; j += 1)
            {
                // skip self
                if (i == j)
                {
                    continue;
                }

                // found duplicate
                if (numbers[i] == numbers[j])
                {
                    isUnique = false;
                    break;
                }
            }

            if (isUnique)
            {
                unique = numbers[i];
                break;
            }
        }

        return unique;
    }
}