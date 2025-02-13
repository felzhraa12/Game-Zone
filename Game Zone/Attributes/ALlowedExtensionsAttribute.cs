namespace Game_Zone.Attributes
{
    public class ALlowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string _allowedExtensions;
        public ALlowedExtensionsAttribute( string allowedExtensions) 
        { 
            _allowedExtensions = allowedExtensions;
        }

        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension (file.FileName);

                var isAllowed = _allowedExtensions.Split(',').Contains(extension, StringComparer.OrdinalIgnoreCase);

                if (!isAllowed)
                {
                    return new ValidationResult($"Only {_allowedExtensions} are allowed!");
                }
                
            }
            return ValidationResult.Success;
        }
    }

}
