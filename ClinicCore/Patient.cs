using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicCore
{
    public class Patient
    {
    
            public string FullName { get; set; }
            public DateTime BirthDate { get; set; }

            /// <summary>
            /// Вычисляет возраст пациента на текущий день.
            /// Если день рождения в этом году ещё не наступил, возраст уменьшается на 1.
            /// </summary>
            public int CalculateAge()
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;

                // Если день рождения в этом году ещё не был, вычитаем 1
                if (BirthDate.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }
    }


