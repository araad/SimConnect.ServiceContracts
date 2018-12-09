using System.ServiceModel;

namespace SIM.Connect.CallbackContracts.Simconnect
{
    public interface ISimconnectProviderCallback
    {
        [OperationContract(IsOneWay = true)]
        void SimName_ValueChanged(string newValue);
    }
}
