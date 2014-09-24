using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerComplainMS
{
    class Complain
    {
        private int serialNo;
        private string complain;
        private string name;


        public Complain(int serialNo ,string name ,string complain)
        {
            this.serialNo = serialNo;
            this.name = name;
            this.complain = complain;
        }

        public int GetSerialNo()
        {
            return serialNo;
        }


        public string GetComplain()
        {
            return complain;
        }

        public string GetName()
        {
            return name;
        }



        public void SetSerialNo(int serisalNo)
        {
            this.serialNo = serialNo;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetComplain(string complain)
        {
            this.complain = complain;
        }



    }
}
