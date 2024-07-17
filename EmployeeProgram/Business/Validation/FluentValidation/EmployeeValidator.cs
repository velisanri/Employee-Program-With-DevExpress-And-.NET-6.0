using Entitiess.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(r => r.Name).NotEmpty().WithMessage("Personel Adı Boş Olamaz");

            RuleFor(r => r.Name).MinimumLength(3).WithMessage("Personel Adı En Az 3 Karakter Olmalıdır");

            RuleFor(r => r.LastName).NotEmpty().WithMessage("Personel Soyadı Boş Olamaz");

            RuleFor(r => r.LastName).MinimumLength(3).WithMessage("Personel Soyadı En Az 3 Karakter Olmalıdır");

            RuleFor(r => r.Salary).GreaterThan(0).WithMessage("Personel ücreti asgari ücretten büyük olmalıdır");

            RuleFor(r => r.BirthDate).LessThan(DateTime.Now.AddYears(-18)).WithMessage("18 Yaşından küçükler işe alınamaz");

            RuleFor(r => r.DepartmentId).GreaterThan(0).WithMessage("Personel bölümü Seçmelisiniz");

            RuleFor(r => r.IdentityNumber).NotEmpty().WithMessage("Tc numarası 11 karakter olmalıdır ve boş olamaz").MinimumLength(11).WithMessage("Tc numarası 11 karakter olmalıdır ve boş olamaz").MaximumLength(11).WithMessage("Tc numarası 11 karakter olmalıdır ve boş olamaz");

        }
    }
}
