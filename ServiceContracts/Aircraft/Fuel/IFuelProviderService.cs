using System.ServiceModel;
using SIM.Connect.CallbackContracts.Aircraft.Fuel;

namespace SIM.Connect.ServiceContracts.Aircraft.Fuel
{
	[ServiceContract(Namespace = "http://SIM.Connect.Services.Aircraft.Fuel.FuelProviderService",
		CallbackContract = typeof(IFuelProviderCallback))]
	public interface IFuelProviderService
	{
		[OperationContract(IsOneWay = true)]
		void Subscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void Unsubscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void SetFuelTankCenterLevel(object newValue);

		[OperationContract(IsOneWay = true)]
		void SetFuelTankCenterQuantity(object newValue);

	}
}
