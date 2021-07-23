using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;


namespace UnidexIBMLDAL.DataOperations
{
    public class UnidexDAL
    {
        private readonly string _connetionString;
        private SqlConnection _sqlConnection;
        private StringBuilder sb;

        public UnidexDAL(string connectionString)
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

        public void ResetBatch(string resetType, List<string> batchList, string connection)
        {
            string listData;
            string sql = "";

            listData = GetList(batchList);
            OpenConnection();


            switch (resetType)
            {
                case "Pulled Priority":
                    {
                        sql = "Update batch set BatchStatusID = 52, StatusDescription = 'Manual reset to Pulled Priority Returned as Non Navy'," +
                            "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + listData + ")";
                        break;
                    }
                case "QA at MNRA":
                    {
                        sql = "Update batch set BatchStatusID = 54, StatusDescription = 'Manual reset to QA at NMRA'," +
                                                   "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + listData + ")";
                        break;

                    }
                case "Unidex Finished":
                    {
                        sql = "Update batch set BatchStatusID = 72, StatusDescription = 'Manual reset to Unidex Finished'," +
                                                    "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + listData + ")";
                        break;

                    }
                case "PDFA Finished":
                    {
                        sql = "Update batch set BatchStatusID = 51, StatusDescription = 'Manual reset to PDFA Finished'," +
                                                    "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + listData + ")";

                        break;
                    }
                case "Unitizer Finished":
                    {
                        sql = "Update batch set BatchStatusID = 69, StatusDescription = 'Manual reset to Unitizer Finished'," +
                                                     "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + listData + ")";

                        break;
                    }
                case "Ready For Blank Check":
                    {
                        sql = "Update batch set BatchStatusID = 70, StatusDescription = 'Manual reset to Ready For Blank Check'," +
                                                    "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + listData + ")";

                        break;
                    }
                case "Reset Batch to Prep Complete":
                    {

                        break;
                    }
                case "Test Select Query":
                    {
                        TestSelectQuery(listData);
                        break;
                    }
            }
            RunQuery(ref sql);

           
        }

        private void RunQuery(ref string sql)
        {
            int results = 0;
            OpenConnection();
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                results=command.ExecuteNonQuery();
            }
            CloseConnection();
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

        public void CreateLoosePaperBox()
        {
            string sql = "exec [dbo].[WebPortal_INSBox] " +
              " @AgencyLocationID = 4855," +
              " @ConversionTypeID = 2," +
              " @LoosePaper = true," +
              " @UserName = 'rkode'," +
           " @MachineName = 'US06VWAP212'," +
           "    @SF66 = false; ";
        }

        public void ResetBatchToPrepComplete(string lData)
        {
            string sql = "";
            OpenConnection();

            /**** Delete Unidex records associated with BatchID's *****/
            sql = "Delete from unidex where batchid in (" + lData + ")";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Delete Scan table records associated with BatchID's *****/
            sql = "Delete from scan where batchname in (Select [name] from batch where batchid in (" + lData + "))";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Delete Transaction table records associated with BatchID's *****/
            sql = "Delete from [transaction] where batchid in (" + lData + ")";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Update batch table records associated with BatchID's *****/
            sql = "Update batch set BatchStatusID = 26, StatusDescription = 'Manual reset to Prep complete'," +
                                                    "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + lData + ")";
            RunQuery(ref sql);
            ////using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            ////{
            ////    command.ExecuteNonQuery();
            ////}

        }

        public void RunBatchesThroughPDFA(string lData)
        {
            string sql = "";
            OpenConnection();

            /**** Delete Unidex records associated with BatchID's *****/
            sql = "Delete from [transaction] where batchid in  (" + lData + ")";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Delete Scan table records associated with BatchID's *****/
            sql = "update unidex set DocumentDeliveryStatusID = 1,ImageDeliveryStatusID = 1,VirtualSide = '' where batchid in  (" + lData + "))";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Delete Transaction table records associated with BatchID's *****/
            sql = "update batch set batchstatusid = 35,Username = 'mbrown',MachineName = 'US06MBROWN',datetimestamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' StatusDescription = 'Manual reset to PDFA ready'where batchid in(" + lData + ")";
            RunQuery(ref sql);
            //using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            //{
            //    command.ExecuteNonQuery();
            //}

            /**** Update batch table records associated with BatchID's *****/
            sql = "Update batch set BatchStatusID = 26, StatusDescription = 'Manual reset to Prep complete'," +
                                                    "UserName ='mbrown',MachineName = 'us06mbrown',DateTimeStamp ='" + string.Format("{0:MM/dd/yyyy hh:mm:ss}", DateTime.Now) +
                                                    "' Where batchid in (" + lData + ")";
            RunQuery(ref sql);
        }

        public string GetList(List<string> batchList)
        {
            string output = "";

            sb = new StringBuilder();

            foreach (string s in batchList)
            {
                if (s.ToUpper().Contains("BMS"))
                    sb.Append(int.Parse(s.Substring(4)) + ",");
                else
                {
                    if (!string.IsNullOrEmpty(s))
                        sb.Append(int.Parse(s) + ",");
                }

            }

            if (sb.Length > 0)
                output = sb.ToString().Substring(0, sb.Length - 1);

            return output;

        }
    }


}
