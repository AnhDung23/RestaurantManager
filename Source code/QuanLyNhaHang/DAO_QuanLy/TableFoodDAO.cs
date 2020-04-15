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
    public class TableFoodDAO
    {
        public TableFoodDAO()
        {
        }

        public List<TableFoodDTO> LoadAllTable()
        {
            List<TableFoodDTO> listTable = new List<TableFoodDTO>();
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    String sql = "Select name, status From TableFood where status != 'Inactive'";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string name = (string)dr["name"];
                            string status = (string)dr["status"];
                            TableFoodDTO dto = new TableFoodDTO(name, status);

                            listTable.Add(dto);
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
            return listTable;
        }

        public bool updateStatusTable(string nameTb, string status)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Update TableFood set status = @Status Where name = @Name";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Name", nameTb);
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

        public DataTable searchTableByName(string valueSearch)
        {
            DataTable dtTable = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    String sql = "Select name, status From TableFood where status != 'Inactive' and name like @Name";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Name", "%" + valueSearch + "%");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtTable = new DataTable();
                    da.Fill(dtTable);
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
            return dtTable;
        }

        public bool addTable(TableFoodDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Insert TableFood(name, status) " +
                                "Values(@Name, @Status)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Name", dto.Name);
                    cmd.Parameters.AddWithValue("@Status", dto.Status);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    check = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("duplicate")) throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public bool deleteTable(TableFoodDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                string sql = "Update TableFood Set status = @Status Where name = @Name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Status", dto.Status);
                cmd.Parameters.AddWithValue("@Name", dto.Name);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                check = cmd.ExecuteNonQuery() > 0;
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
