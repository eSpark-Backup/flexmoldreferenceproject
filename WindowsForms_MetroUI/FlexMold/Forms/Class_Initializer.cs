using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace FlexMold.Forms
{
    public static class Class_Initializer
    {
        public static Dictionary<string, string> dictLoadDataMainSettings = new Dictionary<string, string>();
        public static Dictionary<string, string> dictLoadErrorLogPCB = new Dictionary<string, string>();
        public static List<Dictionary<string, string>> dictLoadErrorLogPCB_List = new List<Dictionary<string,string>>();

        public static string ParentFolder = ConfigurationManager.AppSettings["ParentFolderPath"].ToString();
        public static string ProjectsFolder = ConfigurationManager.AppSettings["ProjectsFolderPath"].ToString();
        public static string ProjectsDBFile = ConfigurationManager.AppSettings["ProjectsDBFile"].ToString();



        public static SQLiteConnection sqlite_conn =new SQLiteConnection(CreateConnection());
        //CreateTable(sqlite_conn);
        //Insert_UpdateData(sqlite_conn);
        //ReadMainSettingsData(sqlite_conn);
        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            bool DB_Exist = false;
            if (File.Exists(Class_Initializer.ProjectsDBFile))
                DB_Exist = true;

            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= " + Class_Initializer.ProjectsDBFile + "; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Database Connecion Error " + ex.Message);
            }

            if(!DB_Exist)
                CreateData(sqlite_conn);

            return sqlite_conn;
        }

        //static void CreateTable(SQLiteConnection conn)
        //{

        //    SQLiteCommand sqlite_cmd;
        //    string Createsql = "CREATE TABLE "MainSettings" (
        // "MotorTotalMotors"	INTEGER,
        // "MotorCurrentPrcnt"	INTEGER,
        // "MotorDelayTime"	TEXT,
        // "MotorPowerUpSpeed"	TEXT,
        // "MotorSpeed"	TEXT,
        // "MBCurrentVal"	TEXT,
        // "MBDelayTime"	INTEGER,
        // "InfoSize"	TEXT,
        // "InfoMinRadius"	TEXT,
        // "InfoMotorCnt"	INTEGER,
        // "InfoMotorErrors"	INTEGER,
        // "InfoPartsProduced"	INTEGER,
        // "InfoLastShape"	TEXT,
        // "Info36VPowStatus"	INTEGER,
        // "InfoStopButton"	TEXT
        //)";
        //   sqlite_cmd = conn.CreateCommand();
        //    sqlite_cmd.CommandText = Createsql;
        //    sqlite_cmd.ExecuteNonQuery();
        //    sqlite_cmd.CommandText = Createsql1;
        //    sqlite_cmd.ExecuteNonQuery();

        //}

        public static void Insert_UpdateData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            // sqlite_cmd.CommandText = "INSERT INTO MainSettings (MotorTotalMotors,MotorCurrentPrcnt,MotorDelayTime,MotorPowerUpSpeed,MotorSpeed,MBCurrentVal,MBDelayTime,InfoSize,InfoMinRadius,InfoMotorCnt,InfoMotorErrors,InfoPartsProduced,InfoLastShape,Info36VPowStatus,InfoStopButton ) VALUES ('"
            //           + "'" + dictLoadDataMainSettings["MotorTotalMotors"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["MotorCurrentPrcnt"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["MotorDelayTime"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["MotorPowerUpSpeed"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["MotorSpeed"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["MBCurrentVal"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["MBDelayTime"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoSize"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoMinRadius"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoMotorCnt"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoMotorErrors"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoPartsProduced"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoLastShape"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["Info36VPowStatus"].ToString() + "', "
            //           + "'" + dictLoadDataMainSettings["InfoStopButton"].ToString() + "', "
            //     + " )";
            //////sqlite_cmd.CommandText = "INSERT INTO MainSettings(MotorTotalMotors,MotorCurrentPrcnt,MotorDelayTime,MotorPowerUpSpeed,MotorSpeed,MBCurrentVal,MBDelayTime,InfoSize,InfoMinRadius,InfoMotorCnt,InfoMotorErrors,InfoPartsProduced,InfoLastShape,Info36VPowStatus,InfoStopButton,InfoTotalOperTime) VALUES('405', '50', '10', '1X1', '7000', '150', '10', '2.7X1.5', '0.28', '405', '1', '10000', 'X24 2022/1APL', '1', '0','36 days 22 hours 34 min')";
            //sqlite_cmd.ExecuteNonQuery();

            if (Class_Initializer.dictLoadDataMainSettings.Count > 0)
                sqlite_cmd.CommandText = "UPDATE MainSettings SET " +
                      "   MotorTotalMotors='" + Class_Initializer.dictLoadDataMainSettings["MotorTotalMotors"].ToString()
                    + "', MotorCurrentPrcnt= '" + Class_Initializer.dictLoadDataMainSettings["MotorCurrentPrcnt"].ToString()
                    + "', MotorDelayTime= '" + Class_Initializer.dictLoadDataMainSettings["MotorDelayTime"].ToString()
                    + "', MotorPowerUpSpeed= '" + Class_Initializer.dictLoadDataMainSettings["MotorPowerUpSpeed"].ToString()
                    + "', MotorSpeed= '" + Class_Initializer.dictLoadDataMainSettings["MotorSpeed"].ToString()
                    + "', MBCurrentVal= '" + Class_Initializer.dictLoadDataMainSettings["MBCurrentVal"].ToString()
                    + "', MBDelayTime=  '" + Class_Initializer.dictLoadDataMainSettings["MBDelayTime"].ToString()
                    + "', InfoSize= '" + Class_Initializer.dictLoadDataMainSettings["InfoSize"].ToString()
                    + "', InfoMinRadius= '" + Class_Initializer.dictLoadDataMainSettings["InfoMinRadius"].ToString()
                    + "', InfoMotorCnt= '" + Class_Initializer.dictLoadDataMainSettings["InfoMotorCnt"].ToString()
                    + "', InfoMotorErrors= '" + Class_Initializer.dictLoadDataMainSettings["InfoMotorErrors"].ToString()
                    + "', InfoPartsProduced= '" + Class_Initializer.dictLoadDataMainSettings["InfoPartsProduced"].ToString()
                    + "', InfoLastShape= '" + Class_Initializer.dictLoadDataMainSettings["InfoLastShape"].ToString()
                    + "', Info36VPowStatus= '" + Class_Initializer.dictLoadDataMainSettings["Info36VPowStatus"].ToString()
                    + "', Info230VPowStatus= '" + Class_Initializer.dictLoadDataMainSettings["Info230VPowStatus"].ToString()
                    + "', InfoStopButton= '" + Class_Initializer.dictLoadDataMainSettings["InfoStopButton"].ToString()
                    + "', InfoTotalOperTime= '" + Class_Initializer.dictLoadDataMainSettings["InfoTotalOperTime"].ToString()
                    + "' )";
            sqlite_cmd.ExecuteNonQuery();

        }

        public static void ReadMainSettingsData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM MainSettings";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                Class_Initializer.dictLoadDataMainSettings = new Dictionary<string, string>();
                Class_Initializer.dictLoadDataMainSettings.Add("MotorTotalMotors", sqlite_datareader["MotorTotalMotors"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("MotorCurrentPrcnt", sqlite_datareader["MotorCurrentPrcnt"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("MotorDelayTime", sqlite_datareader["MotorDelayTime"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("MotorPowerUpSpeed", sqlite_datareader["MotorPowerUpSpeed"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("MotorSpeed", sqlite_datareader["MotorSpeed"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("MBCurrentVal", sqlite_datareader["MBCurrentVal"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("MBDelayTime", sqlite_datareader["MBDelayTime"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoSize", sqlite_datareader["InfoSize"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoMinRadius", sqlite_datareader["InfoMinRadius"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoMotorCnt", sqlite_datareader["InfoMotorCnt"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoMotorErrors", sqlite_datareader["InfoMotorErrors"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoPartsProduced", sqlite_datareader["InfoPartsProduced"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoLastShape", sqlite_datareader["InfoLastShape"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("Info36VPowStatus", sqlite_datareader["Info36VPowStatus"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("Info230VPowStatus", sqlite_datareader["Info230VPowStatus"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoStopButton", sqlite_datareader["InfoStopButton"].ToString());
                Class_Initializer.dictLoadDataMainSettings.Add("InfoTotalOperTime", sqlite_datareader["InfoTotalOperTime"].ToString());

                //string myreader = sqlite_datareader[].GetString(0);
                //Console.WriteLine(myreader);
            }
            sqlite_datareader.Close();
            //conn.Close();
        }

        public static void ReadErrorLogsData(SQLiteConnection conn)
        {

            //            CREATE TABLE "ErrorLogs"(
            //    "ErrorDate" TEXT,
            //    "ErrorTime" TEXT,
            //    "ErrorCodeName" TEXT,
            //    "ErrorDetails"  TEXT,
            //    "ErrorSource"   TEXT
            //)
            //"INSERT INTO ErrorLogs VALUES ('11/8/2022','3:11 PM','Motor_Page1_Error1','Some Errors Occured 123','Only for Test')"

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM ErrorLogs";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                Class_Initializer.dictLoadErrorLogPCB = new Dictionary<string, string>();

                Class_Initializer.dictLoadErrorLogPCB.Add("ErrorDate", sqlite_datareader["ErrorDate"].ToString());
                Class_Initializer.dictLoadErrorLogPCB.Add("ErrorTime", sqlite_datareader["ErrorTime"].ToString());
                Class_Initializer.dictLoadErrorLogPCB.Add("ErrorCodeName", sqlite_datareader["ErrorCodeName"].ToString());
                Class_Initializer.dictLoadErrorLogPCB.Add("ErrorDetails", sqlite_datareader["ErrorDetails"].ToString());
                Class_Initializer.dictLoadErrorLogPCB.Add("ErrorSource", sqlite_datareader["ErrorSource"].ToString());

                Class_Initializer.dictLoadErrorLogPCB_List.Add(Class_Initializer.dictLoadErrorLogPCB);
                //string myreader = sqlite_datareader[].GetString(0);
                //Console.WriteLine(myreader);
            }
            sqlite_datareader.Close();
            //conn.Close();
        }

        public static void CreateData(SQLiteConnection conn)
        {
            //SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = "CREATE TABLE MainSettings('MotorTotalMotors'  INTEGER,'MotorCurrentPrcnt' INTEGER,'MotorDelayTime'    TEXT,'MotorPowerUpSpeed' TEXT,'MotorSpeed'    TEXT,'MBCurrentVal'  TEXT,'MBDelayTime'   INTEGER,'InfoSize'  TEXT,'InfoMinRadius' TEXT,'InfoMotorCnt'  INTEGER,'InfoMotorErrors'   INTEGER, 'InfoPartsProduced' INTEGER,'InfoLastShape' TEXT, 'Info36VPowStatus'  INTEGER,'Info230VPowStatus'  INTEGER, 'InfoStopButton'    TEXT, 'InfoTotalOperTime'   TEXT)";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO MainSettings(MotorTotalMotors,MotorCurrentPrcnt,MotorDelayTime,MotorPowerUpSpeed,MotorSpeed,MBCurrentVal,MBDelayTime,InfoSize,InfoMinRadius,InfoMotorCnt,InfoMotorErrors,InfoPartsProduced,InfoLastShape,Info36VPowStatus,Info230VPowStatus,InfoStopButton,InfoTotalOperTime) VALUES('405', '50', '10', '1X1', '7000', '150', '10', '2.7X1.5', '0.28', '405', '1', '10000', 'X24 2022/1APL', '1','1', '0','36 days 22 hours 34 min')";
            sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = "CREATE TABLE 'ErrorLogs'('ErrorDate' TEXT, 'ErrorTime' TEXT, 'ErrorCodeName' TEXT, 'ErrorDetails'  TEXT, 'ErrorSource'   TEXT)";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "INSERT INTO ErrorLogs VALUES ('11/8/2022','3:11 PM','This is a test Message','Some Errors Occured 123','Only for Test')";
            sqlite_cmd.ExecuteNonQuery();

        }

    }
    }
