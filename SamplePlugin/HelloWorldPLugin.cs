using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PluginContract;

namespace SamplePlugin
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PluginMetadataExport(PluginName = "HelloWorld")]
    public class HelloWorldPlugin : IPlugin
    {
        public string GetName()
        {
            return "HelloWorld";
        }
    }
}
