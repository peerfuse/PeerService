using System.ServiceModel;
using Models;

namespace Interfaces;

[ServiceContract(CallbackContract = typeof(IPingService))]
public interface IContract
{
    Guid Id { get; set; }
    byte[] hash { get; set; }
    Node _firstnode { get; set; }
    DateTime _dateTime { get; set; }
    Node _oldnode { get; set; }
    
    [OperationContract(IsOneWay = true)]
    void SetDate(DateTime dateTime);

    [OperationContract(IsOneWay = true)]
    void SetNode(Node _node);

    [OperationContract(IsOneWay = true)]
    Node getNode();
    
    [OperationContract(IsOneWay = true)]
    DateTime getDateTime();
}