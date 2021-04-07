using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMedical.Data.Utils
{
    public static class IdGenerator
    {

        public static string Generate()
        {
            return Guid.NewGuid().ToString().Trim() + DateTime.Now.ToString().Trim();
        }
        

    }
}
