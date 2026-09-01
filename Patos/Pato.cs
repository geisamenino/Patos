namespace Patos
{
    internal class Pato
    {
        private String nome;
        protected ModoVoo voo;

        public Pato()
        {
            Console.WriteLine("Estou nascendo");
            this.voo = new VoarComAsas();
        }

        public void voar()
        {
            this.voo.voar();
        }

        public void setModoVoo(ModoVoo novoModo) 
        { 
            this.voo = novoModo;
        }

        public void andar()
        {
            Console.WriteLine("Estou andando");
        }

        public void mergulhar()
        {
            Console.WriteLine("Estou mergulhando");
        }
    }
}
