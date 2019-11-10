using System;
using System.Collections.Generic;
using System.Text;

namespace TRIALLogic
{
   public class SludinajumsManager
    {
        private int CurrentId;
        public List<Sludinajums> Sludinajumi;
        public List<Sludinajums> GetByCategory(int categoryId)
        {
            var sludinajumi = Sludinajumi.FindAll(i => i.CategoryId == categoryId);

            return sludinajumi;
        }

        public Sludinajums Create(Sludinajums sludinajums)
        {
            sludinajums.Id = CurrentId;
            Sludinajumi.Add(sludinajums);
            CurrentId++;

            return sludinajums;
        }
        public Sludinajums Get(int id)
        {
            var item = Sludinajumi.Find(i => i.Id == id);
            return item;
        }

        public void Seed()
        {
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 1,
                CategoryId = 1,
                Title = "ghdhj",
                Price = 89,
                Place = "Riga",
                Phone = "iuiufiurhgoijoi",
                Email = "test@mail.com",
                Photo = "data:image/",
                Description = "users of assistive technologies - such as screen readers - or to colorblind users"
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 2,
                CategoryId = 2,
                Title = "ghdhj",
                Price = 74,
                Place = "Riga",
                Phone = "iuiufiurhgoijoi",
                Email = "test2@mail.com",
                Photo = "data:image/",
                Description = "Note that many native select menus—namely in Safari"
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 3,
                CategoryId = 3,
                Title = "ghdhj",
                Price = 4,
                Place = "Riga",
                Phone = "iuiufiurhgoijoi",
                Email = "test1@mail.com",
                Photo = "data:image/",
                Description = "provides a visual indication, which will not be conveyed to users of assistive "
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 4,
                CategoryId = 4,
                Title = "ghdhj",
                Price = 22,
                Place = "Daugavpils",
                Phone = "iuiufiurhgoijoi",
                Email = "mara@mail.com",
                Photo = "data:image/",
                Description = "A block of help text that breaks onto a new line and may extend beyond one line."
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 5,
                CategoryId = 5,
                Title = "ghdhj",
                Price = 12,
                Place = "Liepaja",
                Phone = "iuiufiurhgoijoi",
                Email = "pauls@mail.com",
                Photo = "data:image/",
                Description = "hhfidjfpirkporkrojogjprjog"
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 6,
                CategoryId = 6,
                Title = "ghdhj",
                Price = 33,
                Place = "London",
                Phone = "iuiufiurhgoijoi",
                Email = "lisa@mail.com",
                Photo = "data:image/",
                Description = "or in Internet Explorer 11. In addition, even in browsers that do"
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 7,
                CategoryId = 7,
                Title = "ghdhj",
                Price = 834,
                Place = "Berlin",
                Phone = "iuiufiurhgoijoi",
                Email = "otto@mail.com",
                Photo = "data:image/",
                Description = "So to be safe, use custom JavaScript to disable such links."
            });
            Sludinajumi.Add(new Sludinajums()
            {
                Id = 8,
                CategoryId = 8,
                Title = "ghdhj",
                Price = 47,
                Place = "Frankfurt",
                Phone = "iuiufiurhgoijoi",
                Email = "ann@mail.com",
                Photo = "data:image/",
                Description = "Parties certify by electronic signatures of their representatives and which is signed in a manner that is applicable under"
            });
        }
    }
}
