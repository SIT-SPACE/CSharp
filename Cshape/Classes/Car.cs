using System;

namespace Cshape.Classes;

public class Car //public class อื่นสามารถเรียกใช้ได้
{
    public string Model;
    public string Color;
    public double Speed;
    public double Fuel;
    public double TotalMile;
    public double UseFuelRate; // xxx mile per liter


    public Car(string model, double speed, double fuel) // Construtor ตัวสร้างงง ซึ่งมีพารามิเตอร์
    {
        this.Model = model; //this. อ้างถึงสมาชิกของคลาส
        this.Speed = speed;
        this.Fuel = fuel;
    }
    public void Run(double mile) // xxx liter per Mile และนี่คือ Method ซึ่งกำหนดพฤติกรรมหรือฟังก์ชันของคลาส
    {
        this.TotalMile += mile; //อ้าง Member ภายใน Class
        var use_fuel = mile * this.UseFuelRate;
        this.Fuel -= use_fuel;
    }

    public uint TimeUseForRun(double mile)
    {
        var timeuse = mile /Speed;
        this.Run(mile);
        return Convert.ToUInt16(timeuse);
    }

    public string ShowInfo()
    {
        var info = $"Model : {this.Model}\nTotal Mile : {this.TotalMile}\nFuel : {this.Fuel}";
        return info;
    }

}
