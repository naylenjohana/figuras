namespace Figuras
{
    public interface IPunto
    {
        double x1 { get; set; }
        double y1 { get; set; }    

        double CalcularDistancia(IPunto punto2);
    }
}