using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyCicle.Model
{
    public class Horario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string HorarioPilula { get; set; }


        public Horario()
            {
            this.Id = 0;
            this.HorarioPilula = "";
            
        }
    }
}
