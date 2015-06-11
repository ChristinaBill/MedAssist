using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedAssist.Model;
using System.Data.SqlClient;
using System.Data;

namespace MedAssist.DAL
{
    /// <summary>
    /// Interacts with the Visit Table
    /// </summary>
    class VisitDAL
    {
        public VisitDAL() { }

        /// <summary>
        /// Inserts a visit into the Visit Table
        /// </summary>
        /// <param name="visit">The Visit to enter into the table</param>
        /// <returns>The visit ID that was inserted</returns>
        public int createVisit(Visit visit)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string insertStatement = "INSERT INTO Visits " +
                "(VisitDate, NurseID, PatientID, DoctorID, Diagnosis, Systolic, Diastolic, " +
                    "Temperature, RespirationRate, HeartRate, Symptoms) " +
                "VALUES (@VisitDate, @NurseID, @PatientID, @DoctorID, @Diagnosis, @Systolic, @Diastolic, " +
                    "@Temperature, @RespirationRate, @HeartRate, @Symptoms)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@VisitDate", visit.VisitDate);
            insertCommand.Parameters.AddWithValue("@NurseID", visit.NurseID);
            insertCommand.Parameters.AddWithValue("@PatientID", visit.PatientID);
            insertCommand.Parameters.AddWithValue("@DoctorID", visit.DoctorID);
            insertCommand.Parameters.AddWithValue("@Diagnosis", visit.Diagnosis);
            insertCommand.Parameters.AddWithValue("@Systolic", visit.Systolic);
            insertCommand.Parameters.AddWithValue("@Diastolic", visit.Diastolic);
            insertCommand.Parameters.AddWithValue("@Temperature", visit.Temperature);
            insertCommand.Parameters.AddWithValue("@RespirationRate", visit.RespirationRate);
            insertCommand.Parameters.AddWithValue("@HeartRate", visit.HeartRate);
            insertCommand.Parameters.AddWithValue("@Symptoms", visit.Symptoms);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('Visits') FROM Visits";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int visitID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return visitID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        /// <summary>
        /// Gets List of visits for patients by there first and last name
        /// Added by Greene
        /// </summary>
        /// <returns></returns>
        public static List<Visit> GetVisitForPatient(string fName, string lName)
        {
            List<Visit> visitList = new List<Visit>();
            SqlConnection connection = MedassistDB.GetConnection();

            var selectStatement = string.Format(@"
                SELECT        
                    Visits.VisitID
                    ,Visits.VisitDate
                    ,Visits.PatientID
                    ,Visits.Diagnosis
                    ,Visits.Systolic
                    ,Visits.Diastolic
                    ,Visits.Temperature
                    ,Visits.RespirationRate
                    ,Visits.HeartRate
                    ,Visits.Symptoms
                    ,Patients.FirstName
                    ,Patients.MInit
                    ,Patients.LastName
                    ,Patients.DOB
                    ,Orders.Result
                    ,Orders.TestID
                    ,Tests.TestName
                FROM Visits 
                INNER JOIN Patients
                ON Visits.PatientID = Patients.PatientID
                INNER JOIN Orders ON Visits.VisitID = Orders.VisitID
                INNER JOIN Tests ON Orders.TestID = Tests.TestID
                WHERE
                    Patients.FirstName = '{0}'
                    AND Patients.LastName = '{1}'", fName, lName);

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Visit visit = new Visit();
                    visit.VisitID = (int)reader["VisitID"];
                    visit.VisitDate = (DateTime)reader["VisitDate"];
                    visit.PatientID = (int)reader["PatientID"];
                    visit.FirstName = reader["FirstName"].ToString();
                    visit.MInit = reader["MInit"].ToString();
                    visit.LastName = reader["LastName"].ToString();
                    visit.DOB = (DateTime)reader["DOB"];
                    visit.Systolic = (int)reader["Systolic"];
                    visit.Diastolic = (int)reader["Diastolic"];
                    visit.Temperature = (decimal)reader["Temperature"];
                    visit.RespirationRate = (int)reader["RespirationRate"];
                    visit.HeartRate = (int)reader["HeartRate"];
                    visit.Symptoms = reader["Symptoms"].ToString();
                    visit.Result = reader["Result"].ToString();
                    visit.TestID = (int)reader["TestID"];
                    visit.TestName = reader["TestName"].ToString();
                    visit.Diagnosis = reader["Diagnosis"].ToString();
                    visitList.Add(visit);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return visitList;
        }
     

    /// <summary>
        /// Gets List of visits for patients by there first and last name
        /// Added by Greene
        /// </summary>
        /// <returns></returns>
        public static List<Visit> GetVisitForPatientWithDobAndLName(string lName,  DateTime patientDob)
        {
            List<Visit> visitList = new List<Visit>();
            SqlConnection connection = MedassistDB.GetConnection();
            var selectStatement = string.Format(@"
                SELECT        
                    Visits.VisitID
                    ,Visits.VisitDate
                    ,Visits.PatientID
                    ,Visits.Diagnosis
                    ,Visits.Systolic
                    ,Visits.Diastolic
                    ,Visits.Temperature
                    ,Visits.RespirationRate
                    ,Visits.HeartRate
                    ,Visits.Symptoms
                    ,Patients.FirstName
                    ,Patients.MInit
                    ,Patients.LastName
                    ,Patients.DOB
                    ,Orders.Result
                    ,Orders.TestID
                    ,Tests.TestName
                FROM Visits 
                INNER JOIN Patients
                ON Visits.PatientID = Patients.PatientID
                INNER JOIN Orders ON Visits.VisitID = Orders.VisitID
                INNER JOIN Tests ON Orders.TestID = Tests.TestID
                WHERE
                    
                    Patients.LastName = '{0}'
                    AND Patients.DOB = '{1}'", lName, patientDob);

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Visit visit = new Visit();
                    visit.VisitID = (int)reader["VisitID"];
                    visit.VisitDate = (DateTime)reader["VisitDate"];
                    visit.PatientID = (int)reader["PatientID"];
                    visit.FirstName = reader["FirstName"].ToString();
                    visit.MInit = reader["MInit"].ToString();
                    visit.LastName = reader["LastName"].ToString();
                    visit.DOB = (DateTime)reader["DOB"];
                    visit.Systolic = (int)reader["Systolic"];
                    visit.Diastolic = (int)reader["Diastolic"];
                    visit.Temperature = (decimal)reader["Temperature"];
                    visit.RespirationRate = (int)reader["RespirationRate"];
                    visit.HeartRate = (int)reader["HeartRate"];
                    visit.Symptoms = reader["Symptoms"].ToString();
                    visit.Result = reader["Result"].ToString();
                    visit.TestID = (int)reader["TestID"];
                    visit.TestName = reader["TestName"].ToString();
                    visit.Diagnosis = reader["Diagnosis"].ToString();
                    visitList.Add(visit);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return visitList;
        }

        /// <summary>
        /// Gets List of visits for patients by there first and last name
        /// Added by Greene
        /// </summary>
        /// <returns></returns>
        public static List<Visit> GetPatientsByDOB(DateTime patientDob)
        {
            List<Visit> visitList = new List<Visit>();
            SqlConnection connection = MedassistDB.GetConnection();

            var selectStatement = string.Format(@"
                SELECT        
                    Visits.VisitID
                    ,Visits.VisitDate
                    ,Visits.PatientID
                    ,Visits.Diagnosis
                    ,Visits.Systolic
                    ,Visits.Diastolic
                    ,Visits.Temperature
                    ,Visits.RespirationRate
                    ,Visits.HeartRate
                    ,Visits.Symptoms
                    ,Patients.FirstName
                    ,Patients.MInit
                    ,Patients.LastName
                    ,Patients.DOB
                    ,Orders.Result
                    ,Orders.TestID
                    ,Tests.TestName
                FROM Visits
                LEFT JOIN Patients
                ON Visits.PatientID = Patients.PatientID
                LEFT JOIN Orders ON Visits.VisitID = Orders.VisitID
                LEFT JOIN Tests ON Orders.TestID = Tests.TestID
                WHERE
                  
                   Patients.DOB = '{0}'", patientDob);

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Visit visit = new Visit();
                    visit.VisitID = (int)reader["VisitID"];
                    visit.VisitDate = (DateTime)reader["VisitDate"];
                    visit.PatientID = (int)reader["PatientID"];
                    visit.FirstName = reader["FirstName"].ToString();
                    visit.MInit = reader["MInit"].ToString();
                    visit.LastName = reader["LastName"].ToString();
                    visit.DOB = (DateTime)reader["DOB"];
                    visit.Systolic = (int)reader["Systolic"];
                    visit.Diastolic = (int)reader["Diastolic"];
                    visit.Temperature = (decimal)reader["Temperature"];
                    visit.RespirationRate = (int)reader["RespirationRate"];
                    visit.HeartRate = (int)reader["HeartRate"];
                    visit.Symptoms = reader["Symptoms"].ToString();
                    visit.Result = reader["Result"].ToString();
                    visit.TestID = (int)reader["TestID"];
                    visit.TestName = reader["TestName"].ToString();
                    visit.Diagnosis = reader["Diagnosis"].ToString();
                    visitList.Add(visit);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return visitList;
        }

        /// <summary>
        /// Updates the Visits Diagnosis
        /// </summary>
        /// <param name="visit">the new visit</param>
        /// <param name="oldVisit">the old visit</param>
        /// <returns>false</returns>
        public static bool UpdateDiagnosis(Visit visit, Visit oldVisit)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string updateStatement =
                "UPDATE Visits SET " +
                "Diagnosis = @Diagnosis " +
                "WHERE VisitID = @VisitID " +
                "AND Diagnosis = @OldDiagnosis";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@OldDiagnosis", oldVisit.Diagnosis);
            updateCommand.Parameters.AddWithValue("@VisitID", oldVisit.VisitID);
            updateCommand.Parameters.AddWithValue("@Diagnosis", visit.Diagnosis);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        public static bool UpdateVisit(Visit oldVisit, Visit newVisit)
        {
            SqlConnection connection = MedassistDB.GetConnection();
            string updateStatement =
                "UPDATE Visits SET " +
                "Diagnosis = @NewDiagnosis " +
                "WHERE VisitID = @OldVisitID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewDiagnosis", newVisit.Diagnosis);
            updateCommand.Parameters.AddWithValue("@OldVisitID", oldVisit.VisitID);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        public static Visit GetVisitToUpdate(int visitID)
        {
            Visit visit = new Visit();
            SqlConnection connection = MedassistDB.GetConnection();
            string selectStatement =
                "SELECT Visits.VisitID, Visits.VisitDate, Visits.PatientID, Visits.DoctorID, Employees.FirstName, Visits.Diagnosis, Visits.Systolic, Visits.Diastolic, " +
                "Visits.Temperature, Visits.RespirationRate, Visits.HeartRate, Visits.Symptoms " +
                "FROM Visits " + 
                "JOIN Employees ON Visits.DoctorID = Employees.EmployeeID " +
                "JOIN Patients ON Visits.PatientID = Patients.PatientID " +
                "WHERE Visits.VisitID = @VisitID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            selectCommand.Parameters.AddWithValue("@VisitID", visitID);
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    visit.VisitID = (int)reader["VisitID"];
                    visit.PatientID = (int)reader["PatientID"];
                    visit.Systolic = (int)reader["Systolic"];
                    visit.Diastolic = (int)reader["Diastolic"];
                    visit.Temperature = (decimal)reader["Temperature"];
                    visit.RespirationRate = (int)reader["RespirationRate"];
                    visit.HeartRate = (int)reader["HeartRate"];
                    visit.Symptoms = reader["Symptoms"].ToString();
                    visit.Diagnosis = reader["Diagnosis"].ToString();
                    visit.PatientID = (int)reader["PatientID"];
                    visit.DoctorID = (int)reader["DoctorID"];
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return visit;
        }

        public static List<Visit> GetListVisitDates(string firstName, string lastName)
        {
            List<Visit> visitList = new List<Visit>();
            SqlConnection connection = MedassistDB.GetConnection();
            String selectStatement = "SELECT VisitID, VisitDate " +
                "FROM Visits JOIN Patients ON Visits.PatientID = Patients.PatientID " +
                "WHERE Patients.FirstName = @FirstName AND Patients.LastName = @LastName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;
            selectCommand.Parameters.AddWithValue("@FirstName", firstName);
            selectCommand.Parameters.AddWithValue("@LastName", lastName);
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
      
                while (reader.Read())
                {
                    Patient patient = new Patient();
                    Visit visit = new Visit();
                    visit.VisitID = (int)reader["VisitID"];
                    visit.VisitDate = (DateTime)reader["VisitDate"];
                    visitList.Add(visit);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return visitList;
        }




     }
}

