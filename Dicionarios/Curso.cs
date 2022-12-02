using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Dicionarios
{
    class Curso
    {
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }
        private string nome;
        private string instrutor;
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }
        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }
        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            //foreach (var aluno in alunos)
            //{
            //    if (aluno.NumeroMatricula == numeroMatricula)
            //    {
            //        return aluno;
            //    }
            //}
            //throw new Exception($"Aluno de matricula numero {numeroMatricula} não encontrada");
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }
    }
}
