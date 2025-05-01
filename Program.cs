using System;
using System.Collections.Generic;

namespace ShepardPinCodeGenerator;

public class PinCodeGenerator
{
    private HashSet<string> generatedCodes = new HashSet<string>();
    private int period;
    private int codeLength;

    public PinCodeGenerator(int period, int codeLength)
    {
        this.period = period;
        this.codeLength = codeLength;
    }

    public string GeneratePinCode(int x)
    {
        string pinCode = GenerateCode(x);

        // Проверка на уникальность
        if (generatedCodes.Count >= period)
        {
            generatedCodes.Clear(); // Сброс, если достигнут период
        }

        while (generatedCodes.Contains(pinCode))
        {
            x++; // Изменяем x, чтобы получить новое значение
            pinCode = GenerateCode(x);
        }

        generatedCodes.Add(pinCode);
        return pinCode;
    }

    private string GenerateCode(int x)
    {
        string code = "";

        for (int i = 0; i < codeLength; i++)
        {
            int value = (int)Math.Round(4.5 * Math.Sin((2 * Math.PI / (16 << i)) * (x + 0)) + 4.5);
            // Ограничиваем значение до 10, чтобы получить цифры от 0 до 9
            code += (value % 10).ToString();
        }

        return code;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int period = 10; // Задаем период
        int codeLength = 8; // Длина PIN-кода
        PinCodeGenerator generator = new PinCodeGenerator(period, codeLength);

        for (int i = 0; i < 20; i++)
        {
            string pinCode = generator.GeneratePinCode(i);
            Console.WriteLine($"Generated PIN code for x={i}: {pinCode}");
        }
    }
}
