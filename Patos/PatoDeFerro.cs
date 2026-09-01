namespace Patos
{
    internal class PatoDeFerro : Pato
    {
        public PatoDeFerro()
        {
            this.voo = new NaoVoar();
        }

        public void queimar()
        {
            Console.WriteLine("Estou esquentando");
        }
    }
}
