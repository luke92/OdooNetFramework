using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooIntegration.ConsoleApp.Many2ManyHelpers
{
    public class OdooResponseAuthenticateWrapper
    {
        public bool IsOk { get; set; }
        public OdooAuthenticateResponseModel ResponseOk { get; set; }
        public OdooResponseModel ResponseError { get; set; }

        public string SessionId
        {
            get
            {
                if (ResponseOk != null && ResponseOk.Result != null)
                    return ResponseOk.Result.SessionId;
                return null;
            }
        }

        public bool HasSessionId
        {
            get
            {
                return !string.IsNullOrEmpty(SessionId);
            }
        }

    }
}
