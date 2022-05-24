using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	[ServiceContract]
	public interface myInterface
	{ // Use interface to define contracts 
		[OperationContract] int secretNumber(int lower, int upper);
		[OperationContract] string checkNumber(int userNum, int SecretNum);
	}
	public class myService : myInterface  // implementation of interface
	{
		public int secretNumber(int lower, int upper)
		{
			DateTime currentDate = DateTime.Now;
			int seed = (int)currentDate.Ticks;
			Random random = new Random(seed);
			int sNumber = random.Next(lower, upper);
			return sNumber;

		}
		public string checkNumber(int userNum, int SecretNum)
		{
			if (userNum == SecretNum)
				return "correct";
			else
				if (userNum > SecretNum)
					return "too big";
				else return "too small";

		}
	}  // not yet complete, to add hosting code next

	class Program
    {
        static void Main(string[] args)
        {
			Uri baseAddress = new Uri("http://localhost:8000/Service");
			ServiceHost selfHost = new ServiceHost(typeof(myService),baseAddress);
			selfHost.AddServiceEndpoint(typeof(myInterface), new WSHttpBinding(),"myService");
			System.ServiceModel.Description.ServiceMetadataBehavior smb = new System.ServiceModel.Description.ServiceMetadataBehavior();
			smb.HttpGetEnabled = true;
			selfHost.Description.Behaviors.Add(smb);
			selfHost.Open();
			Console.WriteLine("myService developed in WCF is ready to take requests. Please create a client to these services.");
			Console.WriteLine("If you want to quit this service, simply press <ENTER>.\n");
			Console.ReadLine();
			selfHost.Close();
		}
	}
}
