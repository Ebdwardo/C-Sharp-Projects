using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace Project_4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract] 
        string verification(string xmlUrl, string xsdUrl);

        [OperationContract]
        string addTeam(string url, string teamName, string college, string Conference, string qb1, string qb1last, string qb2first, string qb2last, string Number, string Number2, string qbr1, string qbr2, string h1, string h2, string wk1, string wk2, string wk3);

    }

}
