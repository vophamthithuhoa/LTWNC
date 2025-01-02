using System;  

class TroChoiDoanSo  
{  
    static void Main(string[] args)  
    {  
        Random random = new Random();  
        int winningNumber = random.Next(1, 101); // Số ngẫu nhiên từ 1 đến 100  
        int userGuess;  
        int chances = 7;  

        Console.WriteLine("Bay gio chung ta se choi tro doan soso!");  
        Console.WriteLine("Tôi đã chọn một số ngẫu nhiên 1->100100.");  
        Console.WriteLine($"Bạn có {chances} cơ hội để đoán.");  

        for (int i = 0; i < chances; i++)  
        {  
            Console.Write($"Cơ hội {i + 1}: Nhập số của bạn: ");  
            userGuess = int.Parse(Console.ReadLine());  

            if (userGuess < winningNumber)  
            {  
                Console.WriteLine("Số bạn đoán nhỏ hơn số tôi đã chọn.");  
            }  
            else if (userGuess > winningNumber)  
            {  
                Console.WriteLine("Số bạn đoán lớn hơn số tôi đã chọn.");  
            }  
            else  
            {  
                Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng số {winningNumber}!");  
                break; // Kết thúc trò chơi nếu đoán đúng  
            }  

            // Kiểm tra cơ hội còn lại  
            if (i == chances - 1)  
            {  
                Console.WriteLine($"Bạn đã hết cơ hội! Số tôi đã chọn là: {winningNumber}");  
            }  
        }  
    }  
}