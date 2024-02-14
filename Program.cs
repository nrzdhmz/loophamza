        #region Task1
        
        #region Task2
        int num = 27;
        bool divisible = false;
        if (num == 1)
        {
            Console.WriteLine("Ne sade ne de murekkeb");
        }
        else
        {
            
        for (int i=2; i < num; i++)
        {
            if (num % i == 0) 
            {
                divisible = true;
                break;
            }
        }
        if (divisible)
        {
            Console.WriteLine("Murkekkeb");
        }
        else
        {
            Console.WriteLine("Sade");    
        }
        }
        #endregion
        
        int n = 14;
        int m = 29;
        int count = 0;
        for (int i=n; i < m; i++)
        {
            if (i % 2 == 1)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        #endregion
        #region Task3
        int a = 15;
        int b = 5;
        if (a % b == 0)
        {
            Console.WriteLine("tam bolunur");
        }
        else
        {
            Console.WriteLine("bolunmur");
        }d
        #endregion

