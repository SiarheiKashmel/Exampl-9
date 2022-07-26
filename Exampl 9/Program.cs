
int[] nums = { 8, -45, 3, 25, 7 };
Console.WriteLine($" {nums.Length} почти солнечных дней ) cтемпературой : 8, -45, 3, 25, 7 ");
temperature(nums);

static void temperature (int[] ints)
{
    int result = 0;
    foreach (int number in ints)
    {
        if (number < 8)
        {
            result++;
        }
    }
    Console.WriteLine($"Число дней ниже 8 градусов: {result}");
}
