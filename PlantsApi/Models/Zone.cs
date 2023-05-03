
namespace PlantsApi.Models;

public class Zone
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int ZoneMin { get; set; } = 0; //Farenheight
    public int ZoneMax { get; } //Farenheight

    public Zone()
    {
        ZoneMax = ZoneMin + 5;
    }

    //public double ConvertToCelsius(int degreesFarenheight)
    //{
    //    double celsius = (degreesFarenheight - 32) / (5 / 9);
    //    return celsius;
    //}

    //public double ConvertToFarenheight(int degreesCelsius)
    //{
    //    double farenheight = degreesCelsius * (9/5) + 32;
    //    return farenheight;
    //}
}