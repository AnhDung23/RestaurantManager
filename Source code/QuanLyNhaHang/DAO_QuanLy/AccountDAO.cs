using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLy
{
    public class AccountDAO
    {
        public AccountDAO()
        {

        }

        public bool checkLogin(string username, string password)
        {
            bool check = false;

            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    String sql = "Select role, status from Account Where username = @Username and password = @Pass";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Pass", password);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            string role = (string)dr["role"];
                            string status = (string)dr["status"];
                            if (status.Equals("Active"))
                            {
                                check = true;
                            }
                        }
                    }    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public AccountDTO getUserByUsername(string userID)
        {
            AccountDTO dto = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select username, password, fullname, role, status From Account Where username = @UserID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            string username = (string)dr["username"];
                            string password = (string)dr["password"];
                            string fullname = (string)dr["fullname"];
                            string role = (string)dr["role"];
                            string status = (string)dr["status"];
                            dto = new AccountDTO(username, password, fullname, role, status);
                        }
                    }
                }
            } 
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dto;
        }

        public bool updateAccount(string username, string password, string fullname)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Update Account " +
                                "Set Password = @Password, fullname = @Fullname " +
                                "Where username = @Username";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Fullname", fullname);
                    cmd.Parameters.AddWithValue("@Username", username);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    check = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public DataTable loadListUser()
        {
            DataTable dtAccount = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Select username, fullname, role " +
                                "From Account Where role = 'member' and status = 'Active'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtAccount = new DataTable();
                    da.Fill(dtAccount);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dtAccount;
        }

        public DataTable searchUserByName(string valueSearch)
        {
            DataTable dtUser = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select username, fullname, role " +
                                "From Account Where role = 'member' and status = 'Active' and fullname like @Fullname";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Fullname", "%" + valueSearch + "%");
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtUser = new DataTable();
                    da.Fill(dtUser);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dtUser;
        }

        public bool deleteAccount(string username, string status)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Update Account set status = @Status Where username = @Username";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Username", username);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    check = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

    }
}
