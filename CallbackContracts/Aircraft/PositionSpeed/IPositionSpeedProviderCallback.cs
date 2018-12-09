using System.ServiceModel;

namespace SIM.Connect.CallbackContracts.Aircraft.PositionSpeed
{
	public interface IPositionSpeedProviderCallback
	{
		[OperationContract(IsOneWay = true)]
		void Latitude_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void Longitude_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void MSLAltitude_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void AGLAltitude_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void MagneticHeading_ValueChanged(object newValue);

		[OperationContract(IsOneWay = true)]
		void TrueHeading_ValueChanged(object newValue);

	}
}
