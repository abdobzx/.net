using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PERSONNES
    {
        public int Create(PERSONNESModel PERSONNES)
        {
            return PERSONNES.id;

        }
        public PERSONNESModel Read(int id) 
        {
            PERSONNESModel P = new PERSONNESModel();
            return P;
        }
        public bool Update(PERSONNESModel P)
        {
            return true;

        }
        public bool Update(int id)
        {
            return true;

        }
        public List<PERSONNESModel> All() { 
            
            var list = new List<PERSONNESModel>();
            PERSONNESModel P1 = new PERSONNESModel { id = 1, Valeur = "said" };
            PERSONNESModel P2 = new PERSONNESModel { id = 1, Valeur = "said" };
            PERSONNESModel P3 = new PERSONNESModel { id = 1, Valeur = "said" };
            list.Add(P1);
            list.Add(P2);
            list.Add(P3);

            return list;
        }

    }
}
