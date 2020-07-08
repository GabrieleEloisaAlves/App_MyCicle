using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MyCicle.Model
    
{
   
       public  class Dados
    
    {
         [PrimaryKey, AutoIncrement]
         public int Id { get; set; }
        [NotNull]
        public string Data { get; set; }
        [NotNull]
        public string DataMestrual { get; set; }
        [NotNull]
        public string Pilula { get; set; }
        [NotNull]
        public string Consulta { get; set; }

        public Dados()
        {
            this.Id = 0;
            this.Data = "";
            this.DataMestrual = "";
            this.Pilula = "";
            this.Consulta = "";
        }
        
    }

    }
