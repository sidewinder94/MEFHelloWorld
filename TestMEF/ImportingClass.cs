using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

using PluginContract;

namespace TestMEF
{
    public class ImportingClass
    {
        [Import]
        public IPlugin Plugin { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Import]
        public String Name { get; set; }



        public ImportingClass()
        {
            var catalog = new DirectoryCatalog(@".\");
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }
    }
}