using System.Data.Common;
using System.Data.SqlClient;
using Cwiczenia04.btos;

namespace Cwiczenia04.Controllers;


public class WarehouseController
{
    private IConfiguration _configuration;

    public WarehouseController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task <int>AddWarehouse(){
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        using var com = new SqlCommand();
        await con.OpenAsync();
        DbTransaction tran = await con.BeginTransactionAsync();
        com.Transaction =(SqlTransaction)tran;
        try{
            var list =newList<Animal>();
            using (var dr = await com.ExecuteReaderAsync())
            {
                while (await dr.ReadAsync())
                {
                    list.Add(newAnimal{Name = dr["Name"].ToString(),
                        Description = dr["Description"].ToString()
                    });
                }
            }
            com.Parameters.Clear();
            com.CommandText ="UPDATE Animal SET Name=Name+'a'WHERE Name=@Name";
            com.Parameters.AddWithValue("@Name", list[0].Name);
            await com.ExecuteNonQueryAsync();
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@Name", list[1].Name);
            await com.ExecuteNonQueryAsync();
            await tran.CommitAsync();
            /*{
            using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
            con.Open();

            using var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Animal VALUES(@Name, @Description, @Category, @Area)";
            cmd.Parameters.AddWithValue("@Name", animal.Name);
            cmd.Parameters.AddWithValue("@Description", animal.Description);
            cmd.Parameters.AddWithValue("@Category", animal.Category);
            cmd.Parameters.AddWithValue("@Area", animal.Area);

            var affectedCount = cmd.ExecuteNonQuery();
            return affectedCount;
        }*/
        }
        catch(SqlException exc){
            //...awaits
            await tran.RollbackAsync();
        }
        catch(Exception exc){
            //...awaits
            tran.RollbackAsync();
        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      //await tran.CommitAsync();}

    
}