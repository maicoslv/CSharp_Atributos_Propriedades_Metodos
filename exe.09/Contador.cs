namespace ExercicioContador
{
    public class Contador
    {
        // Campo privado: guarda o dado real na memória
        private int _quantidade;

        // Propriedade pública somente leitura (get): expõe o valor para consulta externa
        public int Quantidade
        {
            get { return _quantidade; }
        }

        // Construtor opcional para iniciar com valor 0
        public Contador()
        {
            _quantidade = 0;
        }

        // Método para incrementar de 1 em 1
        public void Incrementar()
        {
            _quantidade++;
        }

        // Método para adicionar um valor específico[cite: 18]
        public void Adicionar(int quantidade)
        {
            _quantidade += quantidade;
        }
    }
}