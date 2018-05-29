using System.Runtime.Serialization;
using System.ServiceModel;

namespace serviceStandard
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Adicione suas operações de serviço aqui
        [OperationContract]
        Dispositvo GetDispositivoEstoque(double numDispositvo);

    }

    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class Dispositvo
    {
        string codigoEmpresa;
        string codigoPosto;
        string codigoProduto;
        string sequencial;
        string tipo;
        string statusValor;
        string mensagem;
        string tipoChamada;

        [DataMember]
        public string CodigoEmpresa
        {
            get { return codigoEmpresa; }
            set { codigoEmpresa = value; }
        }

        [DataMember]
        public string CodigoPosto
        {
            get { return codigoPosto; }
            set { codigoPosto = value; }
        }

        [DataMember]
        public string CodigoProduto
        {
            get { return codigoProduto; }
            set { codigoProduto = value; }
        }

        [DataMember]
        public string Sequencial
        {
            get { return sequencial; }
            set { sequencial = value; }
        }

        [DataMember]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        [DataMember]
        public string Status
        {
            get { return statusValor; }
            set { statusValor = value; }
        }

        [DataMember]
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        [DataMember]
        public string TipoChamada
        {
            get { return tipoChamada; }
            set { tipoChamada = value; }
        }
    }
}
