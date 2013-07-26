using System;
using System.Collections.Generic;

namespace Salesforce
{
	public class ReadRequest : IRestRequest
	{
		public String RequestType { get; set; }

		public ISalesforceResource Resource {	get ; set ; }

		public IDictionary<string, string> Headers { get ; set ; }

		public String Method { get { return HttpMethod.Get; }}

		public IDictionary<string, string> Options { get; private set; }

		public ReadRequest ()
		{
			Options = new Dictionary<string,string> ();
			Headers = new Dictionary<string,string> ();
		}

		public override string ToString ()
		{
			return string.Format (@"{0} {1}", Method, Resource);
		}
	}
}
