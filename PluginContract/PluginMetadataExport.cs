using System;
using System.ComponentModel.Composition;

namespace PluginContract
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PluginMetadataExport : ExportAttribute
    {
        public PluginMetadataExport() : base(typeof(IPlugin))
        {

        }

        public string PluginName { get; set; }
    }
}