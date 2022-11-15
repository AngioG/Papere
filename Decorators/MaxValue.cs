using System.ComponentModel.DataAnnotations;

namespace Papere.Decorators
{
    public class MaxValue : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value == null) return false;

            int val = (int)value;

            if (val < 5) return true;

            return false;
        }
    }
}
