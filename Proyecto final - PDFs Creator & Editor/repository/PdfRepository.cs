using Calculator.util;
using Proyecto_final___PDFs_Creator___Editor.model;
using Proyecto_final___PDFs_Creator___Editor.util;

using System.Data.SqlClient;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;



namespace Proyecto_final___PDFs_Creator___Editor.repository
{
    internal class PdfRepository : Repository<Pdf>
    {

        public PdfRepository() { }

        private SqlConnection GetConnection()
        {
            return ConnectionFactory.GetInstance();
        }

        public List<Pdf> FindAll()
        {
            List<Pdf> list = new List<Pdf>();

            using (SqlConnection conn = GetConnection())
            {

                conn.Open();

                string sqlQuery = "Select * From dbo.pdfs_history2";


                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            list.Add(PdfUtils.CreatePdfObject(reader));

                        }
                    }

                }

            }

            return list;
        }

        public Pdf Find(int id)
        {
            string query = "SELECT * FROM dbo.pdfs_history2 WHERE id = @Id";

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
                            pdf = PdfUtils.CreatePdfObject(reader);
                        }
                    }

                }

            }

            return pdf;

        }

        public Pdf Find(string name)
        {
            string query = "SELECT * FROM dbo.pdfs_history2 WHERE file_name = @name";

            Pdf pdf = null;

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pdf = PdfUtils.CreatePdfObject(reader);
                        }
                    }

                }

            }

            return pdf;
        }

        public void Save(Pdf obj)
        {
            Boolean isUpdateable = obj.Id != 0;
            string sqlUpdate = "UPDATE dbo.pdfs_history2 SET file_name = @Name, last_modified= @Date, operation_performed = @Op WHERE id = @Id";
            string sqlInsert = "INSERT INTO dbo.pdfs_history2 (file_name, last_modified, operation_performed) VALUES(@Name, @Date, @Op)";


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
                    cmd.Parameters.AddWithValue("@Date", DateTime.Parse(obj.LastModified.ToString()));
                    cmd.Parameters.AddWithValue("@Op", obj.OperationPerformed);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM dbo.pdfs_history2 WHERE id = @Id";

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
