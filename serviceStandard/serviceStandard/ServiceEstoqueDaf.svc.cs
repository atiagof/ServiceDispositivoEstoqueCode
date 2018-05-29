﻿using System;

namespace serviceStandard
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ServiceEstoqueDaf : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Dispositvo GetDispositivoEstoque(double numDispositvo)
        {
            var Num_Sequencial = (numDispositvo + Convert.ToDouble(1));

            var ObjDispositivo = new Dispositvo
            {
                CodigoEmpresa = "1",
                CodigoPosto = "40142",
                CodigoProduto = "008",
                Sequencial = Num_Sequencial.ToString(),
                Tipo = "Comodato",
                Status = "Válido",
                Mensagem = "Dispositivo Válido",
                TipoChamada = "Solicitacao"
            };

            return ObjDispositivo;
        }
    }
}
