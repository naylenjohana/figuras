namespace Figura
{
    public interface IPuntos
    {
        double x1 { get; set; }
        double x2 { get; set; }
        double y1 { get; set; }
        double y2 { get; set; }

        double CalcularDistancia();
    }
}