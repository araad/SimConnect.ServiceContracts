using System.ServiceModel;

namespace SIM.Connect.CallbackContracts.Aircraft
{
	public interface IAircraftProviderCallback
	{
		[OperationContract(IsOneWay = true)]
		void AircraftTitle_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void AircraftTotalWeight_ValueChanged(object newValue);

	}
}
