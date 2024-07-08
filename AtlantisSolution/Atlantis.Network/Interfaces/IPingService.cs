using System.ServiceModel;
using Hosts;

namespace Interfaces;

[ServiceContract(CallbackContract = typeof(IPingService))]
public interface IPingService
{
    [OperationContract(IsOneWay = true)]
    void Ping(HostInfo info);

    [OperationContract(IsOneWay = true)]
    void SearchFiles(string searchTeram, Guid clientId);


}