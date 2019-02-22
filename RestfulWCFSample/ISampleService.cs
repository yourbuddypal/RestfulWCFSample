using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static RestfulWCFSample.SampleService;

namespace RestfulWCFSample
{
	[ServiceContract]
	public interface ISampleService
	{
		[OperationContract, WebInvoke(Method = "GET"
			, UriTemplate = "/GetSomeData?param1={param1}"
			, BodyStyle = WebMessageBodyStyle.Bare
			, RequestFormat = WebMessageFormat.Json
			, ResponseFormat = WebMessageFormat.Json)]
		string GetSomeData(string param1);

		[OperationContract, WebInvoke(Method = "POST"
			, UriTemplate = "/PostSomeData?param1={param1}&param2={param2}"
			, BodyStyle = WebMessageBodyStyle.Bare
			, RequestFormat = WebMessageFormat.Json
			, ResponseFormat = WebMessageFormat.Json)]
		SomeDTO PostSomeData(string param1, string param2);

		[OperationContract, WebInvoke(Method = "POST"
			, RequestFormat = WebMessageFormat.Json
			, ResponseFormat = WebMessageFormat.Json)]
		SomeDTO PostSomeDataInTheBody(SomeDTO input);
	}
}
