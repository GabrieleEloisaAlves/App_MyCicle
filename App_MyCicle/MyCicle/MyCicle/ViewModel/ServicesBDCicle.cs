using System;
using System.Collections.Generic;
using System.Text;
using MyCicle.Model;
using SQLite;

namespace MyCicle.ViewModel
{
    public class ServicesBDCicle
    {
         
        SQLiteConnection conn;

        public string StatusMessage { get; set; }

        public ServicesBDCicle(string dbPath)
        {
            if (dbPath == "") dbPath = App.DbPath;
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Dados>();
        }
        public void Inserir(Dados dados)
        {
            try
            {
                if (string.IsNullOrEmpty(dados.DataMestrual))
                    throw new Exception("Data menstrual não informada");
                if (string.IsNullOrEmpty(dados.Pilula))
                    throw new Exception("Nome da pílula não informada");
                if (string.IsNullOrEmpty(dados.Consulta))
                    throw new Exception("Data da última consulta não informada");

                int result = conn.Insert(dados);
                if (result != 0)
                {
                    this.StatusMessage =
                        string.Format("{0} registro(s) adicionado(s): [Nota: {1}]",
                        result, dados.DataMestrual);
                }
                else
                {
                    string.Format("0 registro(s) adicionado(s)");

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Dados> Listar()
        {
            List<Dados> lista = new List<Dados>();
            try
            {
                lista = conn.Table<Dados>().ToList();
                this.StatusMessage = "Listagem das Notas";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return lista;
        }


        public void Alterar(Dados dados)
        {
            try
            {
                if (string.IsNullOrEmpty(dados.DataMestrual))
                    throw new Exception("Data menstrual não informada");
                if (string.IsNullOrEmpty(dados.Pilula))
                    throw new Exception("Nome da pílula não informada");
                if (string.IsNullOrEmpty(dados.Consulta))
                    throw new Exception("Data da última consulta não informada");




                if (dados.Id <= 0)
                    throw new Exception("Id da nota não informado");

                int result = conn.Update(dados);
                StatusMessage = string.Format("{0} Registros alterados.", result);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro: {0}", ex.Message));
            }

        }
        public void Excluir(int id)
        {
            try
            {
                int result = conn.Table<Dados>().Delete(r => r.Id == id);
                StatusMessage = string.Format("{0} Registros deletados.", result);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro: {0}", ex.Message));
            }
        }

        
    }
}

   
