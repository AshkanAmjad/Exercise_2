//Ashkan Motahari
float score = 100F;
if (score > 100)
{
    Console.WriteLine("Score is not Valid!");
}
else
{
    if (score > 80)
    {
        Console.WriteLine("Score A");
    }
    else
    {
        if(score >= 60)
        {
            Console.WriteLine("Score B");
        }
        else
        {
            if(score >= 40)
            {
                Console.WriteLine("Score C");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}