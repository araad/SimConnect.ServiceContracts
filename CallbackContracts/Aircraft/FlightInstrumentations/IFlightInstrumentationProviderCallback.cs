using System.ServiceModel;

namespace SIM.Connect.CallbackContracts.Aircraft.FlightInstrumentation
{
	public interface IFlightInstrumentationProviderCallback
	{
		[OperationContract(IsOneWay = true)]
		void IndicatedAirspeed_ValueChanged(object newValue);

	}
}
