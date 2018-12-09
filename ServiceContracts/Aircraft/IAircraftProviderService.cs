using System.ServiceModel;
using SIM.Connect.CallbackContracts.Aircraft;

namespace SIM.Connect.ServiceContracts.Aircraft
{
	[ServiceContract(Namespace = "http://SIM.Connect.Services.Aircraft.AircraftProviderService",
		CallbackContract = typeof(IAircraftProviderCallback))]
	public interface IAircraftProviderService
	{
		[OperationContract(IsOneWay = true)]
		void Subscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void Unsubscribe_ProviderService();

	}
}
