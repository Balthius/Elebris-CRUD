using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elebris.Tooling.Areas.Identity
{
    public class TokenProvider
    {
        public string XsrfToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
