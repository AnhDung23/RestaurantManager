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
    public class BillDAO
    {
        public BillDAO()
        {

        }

        public int getBillUnCheckoutByNameTable(string nameTable, string status)
        {
            int billID = 0;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select id From Bill " +
                                 "Where nameTable = @NameTable and status = @Status";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@NameTable", nameTable);
                    cmd.Parameters.AddWithValue("@Status", status);

                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        billID = (int)dr["id"];
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
            return billID;
        }
        
        public int getMaxIDBill()
        {
            int max = 0;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Select MAX(id) as max from Bill";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (con.State == ConnectionState.Closed)
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return max;
        }
        public bool insertBill(BillDTO dto)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Insert Bill(id,dateCheckIn,nameTable,status) Values(@ID,@Date,@Table,@Status)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@ID", dto.ID);
                    cmd.Parameters.AddWithValue("@Date", dto.DateCheckIn);
                    cmd.Parameters.AddWithValue("@Table", dto.NameTable);
                    cmd.Parameters.AddWithValue("@Status", dto.Status);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    check = cmd.ExecuteNonQuery() > 0;
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public bool updateStatus(int idBill, string status, string staff)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try {
                if(con != null)
                {
                    string sql = "Update Bill set status = @Status, staff = @Staff Where id = @ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Staff", staff);
                    cmd.Parameters.AddWithValue("@ID", idBill);
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
        public bool checkoutBill(int id, string staff, int total, string status, DateTime checkOutDate)
        {
            bool check = false;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if(con != null)
                {
                    string sql = "Update Bill " +
                        "set dateCheckOut = @Date, staff = @Staff, total = @Total, status = @Status " +
                        "Where id = @ID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Date", checkOutDate);
                    cmd.Parameters.AddWithValue("@Staff", staff);
                    cmd.Parameters.AddWithValue("@Total", total);
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

        public DataTable getListBillByDate(DateTime dateFrom, DateTime dateTo, string status)
        {
            DataTable dtBill = null;
            SqlConnection con = DBUtils.MakeConnection();
            try
            {
                if (con != null)
                {
                    string sql = "Select * From Bill Where dateCheckOut <= @DateTo and dateCheckOut >= @DateFrom and status = @Status";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@DateTo", dateTo);
                    cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
                    cmd.Parameters.AddWithValue("@Status", status);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtBill = new DataTable();
                    da.Fill(dtBill);
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
            return dtBill;
        }

    }   
}
