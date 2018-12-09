using System.ServiceModel;
using SIM.Connect.CallbackContracts.Aircraft.ElectricalSystems;

namespace SIM.Connect.ServiceContracts.Aircraft.ElectricalSystems
{
	[ServiceContract(Namespace = "http://SIM.Connect.Services.Aircraft.ElectricalSystems.ElectricalSystemsProviderService",
		CallbackContract = typeof(IElectricalSystemsProviderCallback))]
	public interface IElectricalSystemsProviderService
	{
		[OperationContract(IsOneWay = true)]
		void Subscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void Unsubscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void SetElectricalMasterBattery(object newValue);

	}
}
