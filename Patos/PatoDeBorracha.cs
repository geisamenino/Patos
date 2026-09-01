namespace Patos
{
    internal class PatoDeBorracha : Pato
    {
        public PatoDeBorracha() {
            this.voo = new NaoVoar();
        }

        public void mudarSkin()
        {
            Console.WriteLine("Mudei skin");
        }
    }
}
