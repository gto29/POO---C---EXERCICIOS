using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class Exemplo2HerancaVeiculoController : Controller
    {
        [HttpGet("RetornarDadosVeiculo")]
        public string RetornarDadosVeiculo(string marcaVeiculo,
                                           string modeloVeiculo,
                                           string corVeiculo,
                                           int anoVeiculo)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Marca = marcaVeiculo;
            veiculo.Modelo = modeloVeiculo;
            veiculo.Cor = corVeiculo;
            veiculo.Ano = anoVeiculo;
            
            return veiculo.RetornarDados();
        }

        [HttpGet("RetornarDadosCarro")]
        public string RetornarDadosCarro(string marcaVeiculo,
                                           string modeloVeiculo,
                                           string corVeiculo,
                                           int anoVeiculo,
                                           int numeroPortasCarro)
        {
            Carro carro = new Carro();
            carro.Marca = marcaVeiculo;
            carro.Modelo = modeloVeiculo;
            carro.Cor = corVeiculo;
            carro.Ano = anoVeiculo;

            carro.NumeroPortas = numeroPortasCarro;

            return carro.RetornarDados() +
                   $"Número de Portas do Carro: {numeroPortasCarro}\r\n";
        }

        [HttpGet("RetornarDadosMoto")]
        public string RetornarDadosMoto(string marcaVeiculo,
                                           string modeloVeiculo,
                                           string corVeiculo,
                                           int anoVeiculo,
                                           int cilindradasMoto)
        {
            Moto moto = new Moto();
            moto.Marca = marcaVeiculo;
            moto.Modelo = modeloVeiculo;
            moto.Cor = corVeiculo;
            moto.Ano = anoVeiculo;

            moto.Cilindradas = cilindradasMoto;

            return moto.RetornarDados() +
                   $"Número de Cilindradas da Moto: {cilindradasMoto}\r\n";
        }
        [HttpGet("RetornarDadosCaminhao")]
        public string RetornarDadosCaminhao(string marcaVeiculo,
                                           string modeloVeiculo,
                                           string corVeiculo,
                                           int anoVeiculo,
                                           double capacidadeCargaCaminhao)
        {
            Caminhao caminhao = new Caminhao();
            caminhao.Marca = marcaVeiculo;
            caminhao.Modelo = modeloVeiculo;
            caminhao.Cor = corVeiculo;
            caminhao.Ano = anoVeiculo;

            caminhao.CapacidadeCarga = capacidadeCargaCaminhao;

            return caminhao.RetornarDados() +
                   $"Capacidade de Carga do Caminhão: {capacidadeCargaCaminhao}\r\n";
        }
    }
}
