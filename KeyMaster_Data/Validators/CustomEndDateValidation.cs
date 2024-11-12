using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyMaster_Data.Validators
{
    internal class CustomEndDateValidation : ValidationAttribute
    {
        private readonly string _startDatePropertyName;

        public CustomEndDateValidation(string startDatePropertyName)
        {
            _startDatePropertyName = startDatePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var startDateProperty = validationContext.ObjectType.GetProperty(_startDatePropertyName);
            if (startDateProperty == null)
            {
                return new ValidationResult($"Unknown property: {_startDatePropertyName}");
            }

            var startDate = (DateTime?)startDateProperty.GetValue(validationContext.ObjectInstance);
            var endDate = (DateTime?)value;

            if (startDate.HasValue && endDate.HasValue && endDate <= startDate)
            {
                return new ValidationResult(ErrorMessage ?? "Ngày kết thúc phải sau ngày bắt đầu.");
            }

            return ValidationResult.Success;
        }
    }
}
