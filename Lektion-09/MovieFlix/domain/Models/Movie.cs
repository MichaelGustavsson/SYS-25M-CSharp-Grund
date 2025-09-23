namespace domain.Models;

public class Movie : MovieFlixBase
{
    public string Director { get; set; } = "";
    public int Duration { get; set; }
    public override string ToString()
    {
        return $"{base.ToString()} \n\tDirector: {Director} \n\tDuration: {Duration}";
    }
}
