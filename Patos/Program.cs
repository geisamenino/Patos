namespace Patos;

public class Program
{
    public static void Main(string[] args)
    {
        PatoDeFerro donald = new PatoDeFerro();
        donald.voar();
        donald.setModoVoo(new VoarComBalao());
        donald.voar();
    }
}