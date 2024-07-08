using MagicVilla_Web.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla_Web.Models.ViewModel
{
    public class NumeroVillaDeleteViewModel
    {
        public NumeroVillaDto NumeroVilla { get; set; }
        public IEnumerable<SelectListItem> VillaList { get; set; }

        public NumeroVillaDeleteViewModel()
        {
            NumeroVilla = new NumeroVillaDto();

        }


    }
}
