using System.ServiceModel;

namespace SIM.Connect.CallbackContracts.Aircraft.Fuel
{
	public interface IFuelProviderCallback
	{
		[OperationContract(IsOneWay = true)]
		void FuelTankCenterLevel_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void FuelTankCenterQuantity_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void FuelTankCenterCapacity_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void FuelTotalQuantityWeight_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void FuelTotalQuantity_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void FuelTotalCapacity_ValueChanged(object newValue);

	}
}
