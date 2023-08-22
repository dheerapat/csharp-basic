int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

foreach (int value in values)
{
    if (value >= 20 && value <=29) {
        continue;
    }

    Console.WriteLine(value);
    
    if (value >= 40) {
        break;
    }
}