using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "SecretNumber?lower={lower}&upper={upper}", ResponseFormat = WebMessageFormat.Json)]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        [WebGet(UriTemplate = "checkNumber?userNum={userNum}&SecretNum={SecretNum}", ResponseFormat = WebMessageFormat.Json)]
        String checkNumber(int userNum, int SecretNum);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
