using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;
using Sitecore.Diagnostics;
using Sitecore.Rules.Actions;

namespace Marketing.Controls.Search
{
    public class SetStartSearchLocation<T> : RuleAction<T> where T : SetStartSearchLocationContext
    {
        public ID SearchRootItemId { get; set; }
        public override void Apply(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            Assert.ArgumentNotNull(ruleContext.Control, "ruleContext.Control");
            if (!ID.IsNullOrEmpty(this.SearchRootItemId))
            {
                ruleContext.Control.Source = string.Format("StartSearchLocation={0}", this.SearchRootItemId.ToString());
            }
        }
    }
}
