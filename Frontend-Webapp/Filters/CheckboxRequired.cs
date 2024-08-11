using System.ComponentModel.DataAnnotations;

namespace Frontend.Webapp.Filters
{
    public class CheckboxRequired : ValidationAttribute

    {
        public override bool IsValid(object? value) => value is bool b && b;
    }

}
