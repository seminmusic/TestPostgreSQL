using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksaTest.Database;

namespace TaksaTest.Helpers
{
    public class _Data
    {
        public static IEnumerable<Korisnik> GenerateRandomData(int count)
        {
            List<Korisnik> lista = new List<Korisnik>();
            for (int i = 1; i <= count; i++)
            {
                Korisnik korisnik = new Korisnik
                {
                    Ime = "Semin",
                    Prezime = "Musić",
                    Jmbg = "1234567890",
                    Entitet = "FBiH",
                    Zip = 71000,
                    Grad = "Sarajevo",
                    Mjesto = "Čvilla",
                    Adresa = "Nike Neznanovića 99",
                    Status = 3,
                    Registrovan = new DateTime(2012, 5, 24, 15, 45, 32),
                    Osnova = 6.75M,
                    Kartice = new List<Kartica>()
                    {
                        new Kartica { Godina = 2015, Mjesec = 8, Uplaceno = 5.41M, DatumUplate = new DateTime(2015, 10, 16, 20, 15, 47) },
                        new Kartica { Godina = 2015, Mjesec = 8, Uplaceno = 5.41M, DatumUplate = new DateTime(2015, 10, 16, 20, 15, 47) },
                        new Kartica { Godina = 2015, Mjesec = 8, Uplaceno = 5.41M, DatumUplate = new DateTime(2015, 10, 16, 20, 15, 47) },
                        new Kartica { Godina = 2015, Mjesec = 8, Uplaceno = 5.41M, DatumUplate = new DateTime(2015, 10, 16, 20, 15, 47) },
                        new Kartica { Godina = 2015, Mjesec = 8, Uplaceno = 5.41M, DatumUplate = new DateTime(2015, 10, 16, 20, 15, 47) }
                    }
                };
                lista.Add(korisnik);
            }
            return lista;
        }

        public static void InsertTestData(IEnumerable<Korisnik> entitiesCollection, int commitCount = 100, bool recreateContext = true)
        {
            DatabaseContext context = null;
            try
            {
                context = new DatabaseContext();
                context.Configuration.AutoDetectChangesEnabled = false;

                int count = 0;
                foreach (Korisnik entityToInsert in entitiesCollection)
                {
                    ++count;
                    context = AddToContext(context, entityToInsert, count, commitCount, recreateContext);
                }

                context.SaveChanges();
            }
            finally
            {
                if (context != null)
                    context.Dispose();
            }
        }

        private static DatabaseContext AddToContext(DatabaseContext context, Korisnik entity, int count, int commitCount, bool recreateContext)
        {
            context.Korisnici.Add(entity);

            if (count % commitCount == 0)
            {
                context.SaveChanges();

                if (recreateContext)
                {
                    context.Dispose();
                    context = new DatabaseContext();
                    context.Configuration.AutoDetectChangesEnabled = false;
                }
            }

            return context;
        }
    }
}
