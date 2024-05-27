
bool SadəEdedMi(int n)
{
    if (n <= 1)
        return false; // 1 və ya 1-dən kiçik ədədlər sadə deyil

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 10)
            return false; // Əgər ədəd başqa bir ədədə bölünürsə, sadə deyil
    }

    return true; // Ədəd sadədir

    bool MurekkebEdedMi(int n)
    {
        // Sadə ədəd deyilsə, o zaman mürəkkəbdir
        return !SadəEdedMi(n);
    }

}


