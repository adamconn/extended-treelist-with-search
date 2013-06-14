using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Rules;
using Sitecore.Shell.Applications.ContentEditor;

namespace Marketing.Controls.Search
{
    public class SetStartSearchLocationContext : RuleContext
    {
        public MultilistEx Control { get; set; }
    }
}
