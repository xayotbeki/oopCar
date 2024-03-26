using System;

public class Car
{
    private string _model;
    private int _year;
    private decimal _price;
    private decimal _speed; 
    public string Modeli
    { 
        get{return _model;} 
        set{_model = value;} 
    }
    public int Year
    {
        get {return _year;}
        set {_year = value;}
    }
    public decimal Price
    {
        get {return _price;}
        set {_price = value;}
    }
    public decimal Speed
    {
        get {return _speed;}
        set {_speed = value;}
    }
    public string Marka { get; set; }
    public Car(string marka,string model, int yil, decimal narx, decimal speed)
    {
        Modeli = model;
        Year = yil;
        Price = narx;
        Marka = marka; 
        Speed = speed;
    }
    public string GetCarInfo()
    {
        string result = $"Car\nMarkasi: {Marka}\nModeli: {_model}\nYil: {_year}\nNarxi: {_price}\nTezigi: {_speed}";
        return result;
    }
    
    public void CalculateDepreciation(int years)
    {
        int yil = years - _year;
        for(int i=0; i<yil; i++)
        {
            decimal narx = _price;
            decimal qiymat = (narx * 10)/100;
            _price = qiymat;
        }
        System.Console.WriteLine($"{yil}yilda shu narxga tushib qoldi {_price}$");
    }
}
