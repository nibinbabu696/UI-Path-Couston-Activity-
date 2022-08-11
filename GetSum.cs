using RPA.Genie.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSum
{
    public class GetSum : Activity
    {
        public InProperty<int> FirstValue { get; set; }
        public InProperty<int> SecondValue { get; set; }
        public OutProperty<int> ResultSum { get; set; }
        public override ExecutionResult Execute(IActivityContext activityContext)
        {
            int firstValue = FirstValue.GetValue(activityContext);
            int secoundValue = SecondValue.GetValue(activityContext);

            int result = firstValue + secoundValue;
            ResultSum.SetValue(activityContext, result);
            return ExecutionResult.Empty;
        }
    }
}
