using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestfulWCFSample
{
	public class SampleService : ISampleService
	{
		public string GetSomeData(string param1)
		{
			return $"You sent '{param1}'";
		}

		public SomeDTO PostSomeData(string param1, string param2)
		{
			// Do some work!
			// If you try to HTTP Get this endpoint, you will get "Method not allowed."

			return new SomeDTO(param1, param2);
		}

		public SomeDTO PostSomeDataInTheBody(SomeDTO input)
		{
			SomeDTO output = input;
			output.Property1 = $"Your input was '{input.Property1}'";

			return output;
		}

		#region SomeDTO

		[DataContract]
		public class SomeDTO
		{
			[DataMember]
			public string Property1 { get; set; }
			[DataMember]
			public string Property2 { get; set; }

			// Not marked as a DataMember, will not be serialized.
			public string Property3 { get; set; } = "DefaultValue";

			public SomeDTO(string prop1, string prop2)
			{
				Property1 = prop1;
				Property2 = prop2;
			}
		}

		#endregion SomeDTO
	}
}
