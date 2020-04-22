using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opUsuario = ObterOpUsuario();

            while (opUsuario.ToUpper() != "X")
            
            {
                switch (opUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;   
                        }else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;
                        for(int i = 0; i < alunos.Length; i++)
                        {
                             if (!string.IsNullOrEmpty(alunos[i].Nome))
                             {
                                 notaTotal = notaTotal + alunos[i].Nota;
                                 numAlunos++;
                             }
                        }
                        var mediaGeral = notaTotal/numAlunos;
                        ConceitoEnum conceitoGeral;
                        if (mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }else if(mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }else if(mediaGeral <6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }else if(mediaGeral < 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }else
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opUsuario = ObterOpUsuario();
            }
        }

        private static string ObterOpUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opUsuario = Console.ReadLine();
            Console.WriteLine();
            return opUsuario;
        }
    }
}
