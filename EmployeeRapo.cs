﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayroll
{
    class EmployeeRapo
    {
        public static string connectionString = "Data Source=(LocalDb)/localdb;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel employeeModel = new EmployeeModel();
                using (this.connection)
                {
                    string Query = @"SELECT EmployeeId,EmployeeName,Phone_Number,Address,Department
                                 Gender,BasicPay,Deduction,TaxablePay,Tax,NetPay,startdate,City,Country";
                    SqlCommand sql = new SqlCommand(Query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = sql.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModel.EmployeeId = dr.GetInt32(0);
                            employeeModel.EmployeeName = dr.GetString(1);
                            employeeModel.Phone_Number = dr.GetString(2);
                            employeeModel.Address = dr.GetString(3);
                            employeeModel.Department = dr.GetString(4);
                            employeeModel.Gender = Convert.ToChar(dr.GetString(5));
                            Console.WriteLine("{0},{1},{2},{3},{4},{5}", employeeModel.EmployeeId, employeeModel.EmployeeName, employeeModel.Phone_Number, employeeModel.Address, employeeModel.Department);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data Found");
                    }
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeId", model.EmployeeId);
                    command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    command.Parameters.AddWithValue("@Phone_Number", model.Phone_Number);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
