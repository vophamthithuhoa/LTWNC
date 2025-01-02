using System;  

class SoNguyenTo  
{  
    static void Main(string[] args)  
    {  
        int n;  

        // Yêu cầu người dùng nhập n  
        do  
        {  
            Console.Write("Nhập một số nguyên n (n >= 2): ");  
            n = int.Parse(Console.ReadLine());  

            // Kiểm tra nếu n < 2  
            if (n < 2)  
            {  
                Console.WriteLine("Vui lòng nhập một số nguyên lớn hơn hoặc bằng 2.");  
            }  

        } while (n < 2); // Lặp lại cho đến khi người dùng nhập đúng  

        // Kiểm tra số nguyên tố  
        bool isPrime = true;  

        for (int i = 2; i <= Math.Sqrt(n); i++)  
        {  
            if (n % i == 0)  
            {  
                isPrime = false; // Nếu chia hết cho i, không phải số nguyên tố  
                break;  
            }  
        }  

        // Kết quả  
        if (isPrime)  
        {  
            Console.WriteLine($"{n} là số nguyên tố.");  
        }  
        else  
        {  
            Console.WriteLine($"{n} không phải là số nguyên tố.");  
        }  
    }  
}