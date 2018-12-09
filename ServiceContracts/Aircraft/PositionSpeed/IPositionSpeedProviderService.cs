using System.ServiceModel;
using SIM.Connect.CallbackContracts.Aircraft.PositionSpeed;

namespace SIM.Connect.ServiceContracts.Aircraft.PositionSpeed
{
	[ServiceContract(Namespace = "http://SIM.Connect.Services.Aircraft.PositionSpeed.PositionSpeedProviderService",
		CallbackContract = typeof(IPositionSpeedProviderCallback))]
	public interface IPositionSpeedProviderService
	{
		[OperationContract(IsOneWay = true)]
		void Subscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void Unsubscribe_ProviderService();

		[OperationContract(IsOneWay = true)]
		void SetLatitude(object newValue);

		[OperationContract(IsOneWay = true)]
		void SetLongitude(object newValue);

		[OperationContract(IsOneWay = true)]
		void SetMSLAltitude(object newValue);

		[OperationContract(IsOneWay = true)]
		void SetAGLAltitude(object newValue);

		[OperationContract(IsOneWay = true)]
		void SetMagneticHeading(object newValue);

		[OperationContract(IsOneWay = true)]
		void SetTrueHeading(object newValue);

	}
}
