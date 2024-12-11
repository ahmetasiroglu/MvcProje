using DAL.Entitiy;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.ValidationsRule
{
    public class CategoryValidations : AbstractValidator<Category>
    {
        public CategoryValidations()
        {
            RuleFor(x => x.CatagoryName).NotEmpty().WithMessage("Kategori Addını Boş Geçemessiniz!");
            RuleFor(x => x.CatagoryDescriptions).NotEmpty().WithMessage("Açıklamayı Boş Geçemessiniz!");
            RuleFor(x => x.CatagoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karekter girişi yapın!");
            RuleFor(x => x.CatagoryName).MaximumLength(20).WithMessage("Lütfen 20 karekterden fazla değer girişi yapmayın!");
        }
    }
}
