using System.ServiceModel;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();
    }
}
