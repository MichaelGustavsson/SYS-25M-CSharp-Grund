namespace domain.Models;

public class Show : MovieFlixBase
{
    public int Episodes { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} \n\tEpisodes: {Episodes}";
    }
}
