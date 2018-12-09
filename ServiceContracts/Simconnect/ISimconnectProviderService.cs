using System;
using System.ServiceModel;
using SIM.Connect.CallbackContracts.Simconnect;
using System.ComponentModel;

namespace SIM.Connect.ServiceContracts.Simconnect
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://SIM.Connect.Services.Simconnect.SimconnectProviderService",
        CallbackContract = typeof(ISimconnectProviderCallback))]
    public interface ISimconnectProviderService
    {
        [OperationContract(IsOneWay = true)]
        void Subscribe_ProviderService();

        [OperationContract(IsOneWay = true)]
        void Unsubscribe_ProviderService();

        [OperationContract(IsOneWay = true)]
        void JoinSimulation();

        [OperationContract(IsOneWay = true)]
        void LeaveSimulation();
    }
}
