using System.ServiceModel;

namespace TodosLosServiciosApi
{
    [ServiceContract]
    public interface IMySoapCalculator
    {
        [OperationContract]
        int Add(int Number1, int Number2);

        [OperationContract]
        int Sub(int Number1, int Number2);

        [OperationContract]
        int Mul(int Number1, int Number2);

        [OperationContract]
        int Div(int Number1, int Number2);
    }
}
