using System.ServiceModel;
namespace VideoStore.Contracts
{
	[ServiceContract(Namespace = "http://ht.com/VideoStore/VideoLookup")]
	public interface IVideoLookup
	{
		[OperationContract]
		string GetTitleOfTopSellingVideo();
	}
}