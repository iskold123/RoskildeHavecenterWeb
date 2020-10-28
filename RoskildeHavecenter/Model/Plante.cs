using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanteShopService.Model
{
    public class Plante
    {
        private int _planteId;
        private string _planteType;
        private string _planteNavn;
        private int _price;
        private int _maksHoejde;

        public Plante()
        {
        }

        public Plante(int planteId, string planteType, string planteNavn, int price, int maksHoejde)
        {
            _planteId = planteId;
            _planteType = planteType;
            _planteNavn = planteNavn;
            _price = price;
            _maksHoejde = maksHoejde;
        }

        public int PlanteId
        {
            get => _planteId;
            set => _planteId = value;
        }

        public string PlanteType
        {
            get => _planteType;
            set => _planteType = value;
        }

        public string PlanteNavn
        {
            get => _planteNavn;
            set => _planteNavn = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public int MaksHoejde
        {
            get => _maksHoejde;
            set => _maksHoejde = value;
        }

        public override string ToString()
        {
            return $"{nameof(PlanteId)}: {PlanteId}, {nameof(PlanteType)}: {PlanteType}, {nameof(PlanteNavn)}: {PlanteNavn}, {nameof(Price)}: {Price}, {nameof(MaksHoejde)}: {MaksHoejde}";
        }
    }
}
