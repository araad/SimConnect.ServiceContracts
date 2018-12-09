using System.ServiceModel;
using SIM.Connect.CallbackContracts.Aircraft.FlightInstrumentation;

namespace SIM.Connect.ServiceContracts.Aircraft.FlightInstrumentation
{
	[ServiceContract(Namespace = "http://SIM.Connect.Services.Aircraft.FlightInstrumentation.FlightInstrumentationProviderService",
		CallbackContract = typeof(IFlightInstrumentationProviderCallback))]
	public interface IFlightInstrumentationProviderService
	{
		[OperationContract(IsOneWay = true)]
		void Subscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void Unsubscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void SetIndicatedAirspeed(object newValue);

	}
}
