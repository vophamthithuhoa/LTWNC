using System;  

class PhuongTrinhBacHai  
{  
    static void Main(string[] args)  
    {  
        // Nhập hệ số a, b, c  
        Console.Write("Nhập hệ số a: ");  
        double a = double.Parse(Console.ReadLine());  

        Console.Write("Nhập hệ số b: ");  
        double b = double.Parse(Console.ReadLine());  

        Console.Write("Nhập hệ số c: ");  
        double c = double.Parse(Console.ReadLine());  

        // Tính delta  
        double delta = b*b-4*a*c;  

        // Tính nghiệm  
        if (delta > 0)  
        {  
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);  
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);  
            Console.WriteLine($"Nghiệm pbiệt: x1 = {root1}, x2 = {root2}");  
        }  
        else if (delta == 0)  
        {  
            double root = -b / (2 * a);  
            Console.WriteLine($"Nghiệm kép: x = {root}");  
        }  
        else  
        {  
            Console.WriteLine("Phương trình không có nghiệm.");  
        }  
    }  
}