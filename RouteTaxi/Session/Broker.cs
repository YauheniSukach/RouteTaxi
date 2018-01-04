using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using Domain;
using System.Data;

namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Qwerty Twerty\Documents\Visual Studio 2017\Projects\RouteTaxi\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }
        public Broker()
        {
            ConnectTo();
        }

        public void Insert(Person p)
        {
            try
            {
                command.CommandText = "INSERT INTO TPersons (Login, Pass, FirstName, LastName) VALUES('" + p.Login + "','" + p.Pass + "','" + p.FirstName + "','" + p.LastName + "')";

                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }

        }
        public List<Person> ComboBox()
        {
            List<Person> userlist = new List<Person>();
            try
            {
                command.CommandText = "SELECT * FROM FromTo";
                command.CommandType = CommandType.Text;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Person p = new Person();

                    p.From = reader["Fromm"].ToString();
                    p.To = reader["To"].ToString();
                    p.When = Convert.ToDateTime(reader["When"]);
                    p.Time = Convert.ToDateTime(reader["Time"]);

                    userlist.Add(p);
                }
                return userlist;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }

        }
    }
        
    }








