using System.Collections.Generic;
using System.ServiceModel;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);

        [OperationContract]
        string GetResult(int Sid, string SName, int M1, int M2, int M3);

        [OperationContract]
        string GetResultS(Student S);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[]ar);

        [OperationContract]
        Student GetTopper(List<Student> LS);
    }
}
