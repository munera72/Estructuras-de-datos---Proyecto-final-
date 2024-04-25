using Calculator.util;
using Proyecto_final___PDFs_Creator___Editor.model;
using Proyecto_final___PDFs_Creator___Editor.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_final___PDFs_Creator___Editor.repository
{
    internal class PdfRepository : Repository<Pdf>
    {

        public PdfRepository() { }

        private SqlConnection GetConnection()
        {
            return ConnectionFactory.GetInstance();
        }

        List<Pdf> Repository<Pdf>.FindAll()
        {
            List<Pdf> list = new List<Pdf>();

            using (SqlConnection conn = GetConnection())
            {

                conn.Open();

                string sqlQuery = "Select * From dbo.pdfs_history";


                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            list.Add(PdfUtils.CreatePdf(reader));

                        }
                    }

                }

            }

            return list;
        }


        Pdf Repository<Pdf>.Find(int id)
        {
            string query = "SELECT * FROM dbo.pdfs_history WHERE id = @Id";

            Pdf pdf = null;

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pdf = PdfUtils.CreatePdf(reader);
                        }
                    }

                }

            }

            return pdf;

        }

        void Repository<Pdf>.Save(Pdf obj)
        {
            Boolean isUpdateable = obj.Id != 0;
            string sqlUpdate = "UPDATE dbo.pdfs_history SET file_name = @Name, last_modified= @Date, operation_perfomed = @Op WHERE id = @Id";
            string sqlInsert = "INSERT INTO dbo.objs (file_name, last_modified, operation_perfomed) VALUES(@Name, @Date, @Op)";


            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(isUpdateable ? sqlUpdate : sqlInsert, conn))
                {
                    if (isUpdateable)
                    {
                        cmd.Parameters.AddWithValue("@Id", obj.Id);
                    }

                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Date", obj.LastModified);
                    cmd.Parameters.AddWithValue("@Op", obj.OperationPerformed);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        void Repository<Pdf>.Delete(int id)
        {
            string sql = "DELETE FROM dbo.pdfs_history WHERE id = @Id";

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();


                }
            }
        }
    }
}
