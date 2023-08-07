using Crm;
using System.Collections.Generic;
public sealed class ClientService
{
    public Client CreateClient(ClientInfo clientInfo)
    {
        return new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender
        };
    }   
    public Client CreateOrder(ClientOrder clientOrder)
    {
        return new()
        {
            OrderSpecification = clientOrder.OrderSpecification,
            OrderId = clientOrder.OrderId
        };
    }
    private static List<Client> _listOfClients = new();
    public static List<Client> ListOfClients
    {
        get{ _listOfClients; }
    }
    public Client addClient( Client client)
    {
        _listOfClients.Add = client;
    }
}
interface ClientMustHave
    {
        void CheckForClient();
    }
    abstract class CheckoutClient : ClientMustHave
    {
        abstract public bool CheckForClient(Client client)
        {
            bool b = client.FirstName != "";
            bool c = client.LastName != "";
            if (b == true && c == true) return true;
            return false;
        }
    }