using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile";
        nurse.shoes = "sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}