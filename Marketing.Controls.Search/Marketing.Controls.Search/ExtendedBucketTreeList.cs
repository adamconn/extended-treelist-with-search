using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Buckets.FieldTypes;
using Sitecore.Data.Items;
using Sitecore.Rules;

namespace Marketing.Controls.Search
{
    public class ExtendedBucketTreeList : BucketTreeList
    {
        protected override Item[] GetItems(Item current)
        {
            var sourceItem = current.Database.GetItem(this.Source);
            var ruleList = RuleFactory.GetRules<SetStartSearchLocationContext>(sourceItem.Fields["Rule"]);
            if (ruleList != null && ruleList.Count > 0)
            {
                var context = new SetStartSearchLocationContext();
                context.Item = current;
                context.Control = this;
                ruleList.Run(context);
            }
            return base.GetItems(current);
        }
    }
}
