using System.ServiceModel;

namespace SIM.Connect.CallbackContracts.Aircraft.ElectricalSystems
{
	public interface IElectricalSystemsProviderCallback
	{
		[OperationContract(IsOneWay = true)]
		void ElectricalMasterBattery_ValueChanged(object newValue);

	}
}
