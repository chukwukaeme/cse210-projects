using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1._givenName = "Joseph";
        person1._familyName = "Smith";
        person1.ShowWesternName();
        
        Person person2 = new Person();
        person2._givenName = "Emma";
        person2._familyName = "John";
        person2.ShowEasternName();

        Blind blind1 = new Blind();
        blind1._color = "blue";
        blind1._height = 22.3;
        blind1._width = 12;
        blind1.answer();

        Blind kitchen = new Blind();
        kitchen._color = "red";
        kitchen._height = 31.43;
        kitchen._width = 9.1;
        double materialAmount = kitchen.GetArea();
        kitchen.answers();

        House johnsonHome = new House();
        johnsonHome._kitchen = new Blind();
        johnsonHome._livingRoom = new Blind();
        johnsonHome._owner = "Johnson Family";
        johnsonHome._kitchen._width = 60;
    }
}