﻿using Dio.Bank.Classes;
using System.Collections.Generic;

namespace Dio.Bank.Domain.Services.Interfaces
{
    public interface IAcoesContaService
    {
        void Depositar(int indiceConta, double valorDeposito);
        void InserirConta(int entradaTipoConta, string entradaNome, double entradaSaldo, double entradaCredito);
        List<Conta> ListarContas();
        void Sacar(int indiceConta, double valorSaque);
        void Transferir(int indiceContaOrigem, int indiceContaDestino, double valorTransferencia);
    }
}
