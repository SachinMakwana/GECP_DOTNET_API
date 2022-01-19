using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP_DOT_NET_API.Repository
{
    public class Demo:IDemo
    {
        public IList<string> GetNames()
        {
            return new List<string>(){
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        }
    }
}
