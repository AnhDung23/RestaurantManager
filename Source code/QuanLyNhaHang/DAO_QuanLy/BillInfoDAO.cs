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
    public class BillInfoDAO
    {
        public BillInfoDAO()
        {

        }

        public List<BillInfoDTO> getListBillInfoByIdBill(int idBillLoad)
        {
            List<BillInfoDTO> list = new List<BillInfoDTO>();
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Select id, idBill, nameFood, quantity " +
                                "From BillInfo Where idBill = @IdBill";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@IdBill", idBillLoad);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtTable = new DataTable();
                    da.Fill(dtTable);
                    foreach(DataRow table in dtTable.Rows)
                    {
                        int id = (int)table["id"];
                        int idBill = (int)table["idBill"];
                        string nameFood = (string)table["nameFood"];
                        int quantity = (int)table["quantity"];
                        BillInfoDTO dto = new BillInfoDTO(id, idBill, nameFood, quantity);
                        list.Add(dto);
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
            return list;
        }

        public int getMaxIDBillInfo()
        {
            int max = 0;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select MAX(id) as max From BillInfo";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            max = (int)dr["max"];
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
            return max;
        }

        public bool insertBillInfo(BillInfoDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Insert BillInfo(id, idBill, nameFood, quantity) Values(@ID, @IDBill, @Food, @Quantity)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", dto.Id);
                    cmd.Parameters.AddWithValue("@IDBill", dto.IdBill);
                    cmd.Parameters.AddWithValue("@Food", dto.NameFood);
                    cmd.Parameters.AddWithValue("@Quantity", dto.Quantity);
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

        public BillInfoDTO checkExistFoodInBill(int idBillFind, string food)
        {
            BillInfoDTO dto = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select id, idBill, nameFood, quantity From BillInfo Where idBill = @IDBill and nameFood = @Food";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@IDBill", idBillFind);
                    cmd.Parameters.AddWithValue("@Food", food);
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            int id = (int)dr["id"];
                            int idBill = (int)dr["idBill"];
                            string nameFood = (string)dr["nameFood"];
                            int quantity = (int)dr["quantity"];
                            dto = new BillInfoDTO(id, idBill, nameFood, quantity);
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

        public bool updateQuantityBillInfo(int id, int quantity)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Update BillInfo set quantity = @Quantity Where id = @ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@ID", id);
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
    }
}
