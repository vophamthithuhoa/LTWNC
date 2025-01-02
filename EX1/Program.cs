using System;
class Program
{
    static void Main(string[] args)
    {
        //// Nhập hai số nguyên
        Console.Write("Nhap a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b:");
        int b = int.Parse(Console.ReadLine());

        //Nhập toán tử
        Console.Write("Nhap mot toán tử ( +, -, *, /)");
        string operatorInput = Console.ReadLine();

        //Tính toán
        double result = 0;
        bool isValidOperator = true;

        switch (operatorInput)
        {
            case "+":
            result = a+b;
            break;
            case "-":
            result = a-b;
            break;
            case "*":
            result = a*b;
            break;
            case "/":
              if (b!=0)
              {
                result = (double)a/b;
              }    
              else
              {
                Console.WriteLine("Lỗi: Không thể chia hết cho số 0");
                isValidOperator = false;
              }
              break;
              default:
              Console.WriteLine("Lỗi: Toán Tử Không Đúng.");
              isValidOperator = false;
              break;
        }
        //In ket qua
        if(isValidOperator)
        {
            Console.WriteLine($"Ket qua cua {a} {operatorInput} {b} la: {result}");
        }
}
}
