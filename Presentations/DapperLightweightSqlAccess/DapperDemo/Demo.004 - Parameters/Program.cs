// ----------------------------------------------------------------------------------------------
// Copyright (c) WCOM AB.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------

using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Demo._004___Parameters
{
    class Program
    {
        static void Main()
        {
            const int customerId = 26123;
            var customer = GetCustomerById(customerId);
            if (customer == null)
                Console.WriteLine(
                    "Customer {0} not found",
                    customerId
                    );
            else
                Console.WriteLine(
                    "Hello {0}",
                    customer.FirstName
                    );
        }



        static Customer GetCustomerById(long customerId)
        {
             using (var conn = new SqlConnection("Server=localhost;Database=DapperSample2013;Trusted_Connection=True;"))
            {
                conn.Open();
                return conn.Query<Customer>(
                    @"SELECT    CustomerId,
                                FirstName,
                                LastName,
                                DisplayName,
                                CellPhoneNumber,
                                WorkPhoneNumber,
                                HomePhoneNumber,
                                EmailAddress,
                                Password,
                                ModifiedDate,
                                Created
                        FROM Customer WITH(NOLOCK)
                        WHERE CustomerId = @CustomerId",
                                                   new
                                                       {
                                                           CustomerId = customerId
                                                       }
                    ).FirstOrDefault();
            }
        }
    }
}
