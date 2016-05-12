using System;
using System.ComponentModel.Composition;

namespace SamplePlugin
{
    public class HolleWorldPropertyPlugin
    {
        [Export]
        public String GetName
        {
            get
            {
                return "HelloProperty!!";
            }
        }
    }

}