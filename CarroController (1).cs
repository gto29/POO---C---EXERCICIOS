using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class CarroController : Controller
    {
        [HttpGet("VerificacaoDeDadosCarro")]
        public string VerificacaoDeDadosCarro(string marcaCarro, string modeloCarro,
                                              string placaCarro,
                                              string corCarro,
                                              int numeroMarchaCarro,
                                              string fabricacaoCarro,
                                              int anoModeloCarro,
                                              int velocidadeCarro,
                                              bool ligadoCarro,
                                              bool desligadoCarro)
        {
            Carro carro = new Carro();
            carro.marca = marcaCarro;
            carro.modelo = modeloCarro;
            carro.placa = placaCarro;
            carro.cor = corCarro;
            carro.numeroMarcha = numeroMarchaCarro;
            carro.fabricacao = fabricacaoCarro;
            carro.anoModelo = anoModeloCarro;
            carro.velocidade = velocidadeCarro;
            carro.ligado = ligadoCarro;
            carro.desligado = desligadoCarro;


            return $"Marca do Carro:{carro.marca}\r\n" +
                $"Modelo do Carro:{carro.modelo}\r\n" +
                $"placa do carro:{carro.placa}\r\n" +
                $"cor do carro:{carro.cor}\r\n" +
                $"numero de marchas:{ carro.fabricacao}\r\n" +
                $"fabricação do carro:{carro.fabricacao}\r\n" +
                $"ano do carro:{carro.anoModelo}\r\n" +
                $"Velocidade do carro:{carro.velocidade}\r\n" +
                $"o carro esta:{carro.ligado}\r\n" +
                $"o carro esta desligado:{carro.desligado}\r\n";


        }   
        }
    }



