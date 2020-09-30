using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    public abstract class AbClass1
    {
        private string secretName;

        public string SecretName
        {
            get
            {
                return secretName;
            }
            set
            {
                secretName = value;
            }
        }
    }
}
