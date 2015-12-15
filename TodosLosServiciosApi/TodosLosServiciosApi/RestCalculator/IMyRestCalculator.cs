using System.ServiceModel;
using System.ServiceModel.Web;

namespace TodosLosServiciosApi
{
    [ServiceContract]
    public interface IMyRestCalculator
    {

        [OperationContract]
        [WebGet(UriTemplate = "/Add/{Number1}/{Number2}", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        int AddRest(string Number1, string Number2);

        [OperationContract]
        [WebGet(UriTemplate = "/Sub/{Number1}/{Number2}", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        int SubRest(string Number1, string Number2);

        [OperationContract]
        [WebGet(UriTemplate = "/Mul/{Number1}/{Number2}", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        int MulRest(string Number1, string Number2);

        [OperationContract]
        [WebGet(UriTemplate = "/Div/{Number1}/{Number2}", 
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        int DivRest(string Number1, string Number2);
    }
}