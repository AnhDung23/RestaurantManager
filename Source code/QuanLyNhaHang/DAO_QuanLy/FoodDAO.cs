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
    public class FoodDAO
    {
        public FoodDAO()
        {

        }

        public FoodDTO getFoodByName(string nameFood)
        {
            FoodDTO dto = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select name, idCategory, price, status " +
                                "From Food Where name = @Name";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Name", nameFood);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string name = (string)dr["name"];
                        int idCategory = (int)dr["idCategory"];
                        int price = (int)dr["price"];
                        string stt = (string)dr["status"];
                        dto = new FoodDTO(name, idCategory, price, stt);
                    }
                }
            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dto;
        } 

        public List<FoodDTO> getListFoodByCateID(int idCate)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select name, idCategory, price, status " +
                                "From Food Where idCategory = @IDCategory and status = 'Active'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@IDCategory", idCate);

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
                            int idCategory = (int)dr["idCategory"];
                            int price = (int)dr["price"];
                            string stt = (string)dr["status"];
                            FoodDTO dto = new FoodDTO(name, idCategory, price, stt);
                            list.Add(dto);
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

            return list;
        }

        public DataTable loadFood()
        {
            DataTable dtFood = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select F.name as Food, C.name as Category, F.price as Price " +
                                "from Food F, FoodCategory C " +
                                "Where F.idCategory = C.id and F.status = 'Active' and C.status = 'Active'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtFood = new DataTable();
                    da.Fill(dtFood);
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
            return dtFood;
        }

        public bool addFood(FoodDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Insert Food(name, idCategory, price, status) " +
                                "Values(@Name, @ID, @Price, @Status)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Name", dto.Name);
                    cmd.Parameters.AddWithValue("@ID", dto.IdCategory);
                    cmd.Parameters.AddWithValue("@Price", dto.Price);
                    cmd.Parameters.AddWithValue("@Status", dto.Status);
                    if(con.State== ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    check = cmd.ExecuteNonQuery() > 0;
                }
            } 
            catch(Exception e)
            {
                if (e.Message.Contains("duplicate")) throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public bool deleteFood(string nameFood, string status)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                string sql = "Update Food Set status = @Status Where name = @Name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Name", nameFood);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                check = cmd.ExecuteNonQuery() > 0;
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

        public bool updateFood(string name, int idCate, int price)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                string sql = "Update Food Set idCategory = @IDCate, price = @Price Where name = @Name";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IDCate", idCate);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Name", name);
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

        public DataTable searchFoodByName(string valueSearch)
        {
            DataTable dtFood = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Select F.name as Food, C.name as Category, F.price as Price " +
                                "from Food F, FoodCategory C " +
                                "Where F.idCategory = C.id and F.status = 'Active' and F.name like @Name";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Name", "%" + valueSearch + "%");
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtFood = new DataTable();
                    da.Fill(dtFood);
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
            return dtFood;
        }
    }
}
