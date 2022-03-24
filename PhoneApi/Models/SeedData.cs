using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneApi.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace PhoneApi.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new PhoneContext(serviceProvider.GetRequiredService<DbContextOptions<PhoneContext>>()))
            {

                if (context.Countries.Any())
                {
                    return;
                }
                context.Countries.AddRange(
                    new Country
                    {
                        CountryCode = "234",
                        Name = "Nigeria",
                        CountryIso = "NG"
                    },
                    new Country
                    {
                        CountryCode = "233",
                        Name = "Ghana",
                        CountryIso = "Gh"
                    },
                     new Country
                     {
                         CountryCode = "229",
                         Name = "Benin Republic",
                         CountryIso = "BN"
                     },
                      new Country
                      {
                          CountryCode = "225",
                          Name = "Cote d'Ivoire",
                          CountryIso = "CIV"
                      }
                    );
                context.SaveChanges();

                context.CountryDetails.AddRange(
                    new CountryDetails
                    {
                        CountryId = 1,
                        Operator = "MTN Nigeria",
                        OperatorCode = "MTN NG",
                    },
                     new CountryDetails
                     {
                         CountryId = 1,
                         Operator = "Airtel Nigeria",
                         OperatorCode = "ANG",
                     },
                      new CountryDetails
                      {
                          CountryId = 1,
                          Operator = "9 Mobile Nigeria",
                          OperatorCode = "ETN",
                      },
                       new CountryDetails
                       {
                           CountryId = 1,
                           Operator = "Globacom Nigeria",
                           OperatorCode = "GLO NG",
                       },
                        new CountryDetails
                        {
                            CountryId = 2,
                            Operator = "Vodafone Ghana",
                            OperatorCode = "Vodafone GH",
                        },
                         new CountryDetails
                         {
                             CountryId = 2,
                             Operator = "MTN Ghana",
                             OperatorCode = "MTN Ghana",
                         },
                          new CountryDetails
                          {
                              CountryId = 2,
                              Operator = "TIGO Ghana",
                              OperatorCode = "Tigo Ghana",
                          },
                           new CountryDetails
                           {
                               CountryId = 3,
                               Operator = "MTN Benin",
                               OperatorCode = "MTN Benin",
                           },
                            new CountryDetails
                            {
                                CountryId = 3,
                                Operator = "Moov Benin",
                                OperatorCode = "Moov Benin",
                            },
                             new CountryDetails
                             {
                                 CountryId = 4,
                                 Operator = "MTN Cote V'Ivoire",
                                 OperatorCode = "MTN CIV",
                             }
                    );
                context.SaveChanges();
            }
           
        }
    }
}
