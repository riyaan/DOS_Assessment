using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Test6.Game
{
    [ServiceContract]
    public interface IGame
    {
        [OperationContract]
        List<Player> GetAllPlayers();
    }

    [DataContract]
    public class Player
    {
        string username;
        string firstName;
        string lastName;
        string country;
        int age;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DataMember]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DataMember]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [DataMember]
        public int Age 
        {
            get { return age; }
            set { age = value; }
        }
    }
}
