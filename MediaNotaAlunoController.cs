using Microsoft.AspNetCore.Mvc;

namespace ApiWebExercicioRevisaoLogica.Controllers
{
    public class MediaNotaAlunoController : Controller
    {
        [HttpPost("MediaNotaAluno")]
        public string MediaNotaAluno(double nota1Aluno, double nota2Aluno, int faltaAluno)
        {

            //ENTRADA

            double nota1, nota2, mediaNota;
            int falta;
            string situacaoAluno = "";

            nota1 = nota1Aluno;
            nota2 = nota2Aluno;
            falta = faltaAluno;


            //PROCESSAMETO


            mediaNota = (nota1 + nota2) / 2;

            if ((mediaNota >= 7) && (falta <= 10))
            {
                situacaoAluno = "APROVADO";
            }
            else if ((mediaNota < 7) && (falta <= 10))
            {
                situacaoAluno = "REPROVADO";
            }


            else if (falta > 10)
            {
                situacaoAluno = "Reprovado por FALTA";
            }


            //saida


            return $"Média Nota Aluno: {mediaNota}\r\nsituação: {situacaoAluno}";
        }
    }
}
