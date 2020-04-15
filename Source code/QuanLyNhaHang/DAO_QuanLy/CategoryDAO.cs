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
    public class CategoryDAO
    {
        public CategoryDAO()
        {
        }

        public List<CategoryDTO> getListCategory()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select id, name, status From FoodCategory where status = 'Active'";
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
                            int id = (int)dr["id"];
                            string name = (string)dr["name"];
                            string status = (string)dr["status"];
                            CategoryDTO dto = new CategoryDTO(id, name, status);
                            list.Add(dto);
                        }
                    }
                }

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public CategoryDTO getCateByID(int id)
        {
            CategoryDTO dto = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select id, name From FoodCategory Where id = @ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", id);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            int idCate = (int)dr["id"];
                            string name = (string)dr["name"];
                            string status = (string)dr["status"];
                            dto = new CategoryDTO(id, name, status);
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

        //public DataTable loadCate()
        //{
        //    DataTable dtCate = null;
        //    SqlConnection con = DBUtils.MakeConnection();
        //    try
        //    {
        //        if(con != null)
        //        {
        //            string sql = "Select id, name From FoodCategory where status = 'Active'";
        //            SqlCommand cmd = new SqlCommand(sql, con);
        //            if(con.State == ConnectionState.Closed)
        //            {
        //                con.Open();
        //            }
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            dtCate = new DataTable();
        //            da.Fill(dtCate);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return dtCate;
        //}

        public bool addCate(CategoryDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Insert FoodCategory(id, name, status) Values (@ID, @Name, @Status)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", dto.Id);
                    cmd.Parameters.AddWithValue("@Name", dto.Name);
                    cmd.Parameters.AddWithValue("@Status", dto.Status);
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

        public bool deleteCate(int id, string status)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Update FoodCategory set status = @Status Where id = @ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ID", id);
                    if (con.State == ConnectionState.Closed)
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

        public bool updateCate(CategoryDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Update FoodCategory set name = @Name Where id = @ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Name", dto.Name);
                    cmd.Parameters.AddWithValue("@ID", dto.Id);
                    if (con.State == ConnectionState.Closed)
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
