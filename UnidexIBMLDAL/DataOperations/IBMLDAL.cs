using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;


namespace UnidexIBMLDAL.DataOperations
{
    public class IBMLDAL
    {

        private readonly string _connetionString;
        private SqlConnection _sqlConnection;
        private StringBuilder sb;
        private string ibmlBatchList;

        public IBMLDAL(string connectionString)
            => _connetionString = connectionString;

        public void OpenConnection()
        {
            _sqlConnection = new SqlConnection { ConnectionString = _connetionString };
            _sqlConnection.Open();
        }

        private void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }

        private void RunQuery(ref string sql)
        {
           

            OpenConnection();
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
               int count= command.ExecuteNonQuery();

            }
            CloseConnection();
        }

        private string RunIBMLBatchListQuery(ref string sql)
        {
            OpenConnection();
            List<string> result = new List<string>();
            string output = "";

            sb = new StringBuilder();

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                using (DbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add($"{dr["BatchID"]}");
                    }
                }

            }
            CloseConnection();

            foreach (string s in result)
            {

                if (!string.IsNullOrEmpty(s))
                    sb.Append(int.Parse(s) + ",");
            }

            if (sb.Length > 0)
                output = sb.ToString().Substring(0, sb.Length - 1);

            return output;


        }


        public List<string> TestSelectQuery(string lData)
        {
            string sql = "";
            OpenConnection();
            List<string> result = new List<string>();
            sql = "Select * from batch where batchid in (" + lData + ")";

            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                //command.CommandType = CommandType.Text;
                //SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);
                //while (dr.Read())
                //{
                //    result.Add($"{dr["BatchID"]}\t{dr["Name"]}\t{dr["ssn"]}");
                //}

                using (DbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result.Add($"{dr["BatchID"]}\t{dr["Name"]}\t{dr["ssn"]}");
                    }
                }


            }
            CloseConnection();
            return result;
        }

        public string GetList(List<string> batchList)
        {
            string output = "";

            sb = new StringBuilder();

            foreach (string s in batchList)
            {
                if (s.ToUpper().Contains("'BMS"))
                    sb.Append(int.Parse(s.Substring(4)) + "M',");
                else
                {
                    if (!string.IsNullOrEmpty(s))
                        sb.Append("'BMS" +int.Parse(s) + "M',");
                }

            }

            if (sb.Length > 0)
                output = sb.ToString().Substring(0, sb.Length - 1);

            return output;

        }

        public void DeleteIBMLBatch(List<string> bList)
        {
            string lData = GetList(bList);
            

            string sql = "";
            //OpenConnection();

            /**** Delete Unidex records associated with IBML Batchnames *****/
            sql = "select batchid from batchtable where batchname in (" + lData + ")";
            string batchList = RunIBMLBatchListQuery(ref sql);

            if (string.IsNullOrEmpty(batchList))
                return;

            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Delete ExportImagePath records associated with IBML BatchID's *****/
            sql = "delete from ExportImagePath   where batchid in  (" + batchList + ")";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Delete ErrorTable  records associated with IBML BatchID's *****/
            sql = "delete from errortable where batchid in (" + batchList + ")";
            RunQuery(ref sql);

            /**** Delete Sessiontable  records associated with IBML BatchID's *****/
            sql = "delete from sessiontable where batchid in  (" + batchList + ")";
            RunQuery(ref sql);

            /**** Delete BarcodeTable  records associated with IBML BatchID's *****/
            sql = "delete from BarcodeTable where batchid in  (" + batchList + ")";
            RunQuery(ref sql);


            /**** Delete DocTable  records associated with IBML BatchID's *****/
            sql = "delete from doctable where batchid in   (" + batchList + ")";
            RunQuery(ref sql);

            /**** Delete BatchTable  records associated with IBML BatchID's *****/
            sql = "delete from batchtable where batchid in   (" + batchList + ")";
            RunQuery(ref sql);

            DeleteBatchFolders(lData);

        }

        private void DeleteBatchFolders(string batches)
        {
            string newBatchList = batches.Replace("'", "");
           string[] batchList = newBatchList.Split(',');

            string deletePath = @"\\us06vwfile\E\RawImages\BUMED";

            foreach (string b in batchList)
            {
               
                    if (Directory.Exists(Path.Combine(deletePath, b)))
                    {
                        Directory.Delete(Path.Combine(deletePath, b), true);
                    }
                    
             
            }

        }
    }
}
