namespace EqualsEHashCode
{
    internal class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { Nome = value; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Aluno outro = obj as Aluno;
            return this.nome.Equals(outro.nome);
        }
    }
}
