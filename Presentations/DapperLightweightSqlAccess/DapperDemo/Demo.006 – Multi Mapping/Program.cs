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
using Dapper;

namespace Demo._006___Multi_Mapping
{
    internal class Program
    {
        private static void Main()
        {
            using (var conn = new SqlConnection("Server=localhost;Database=DapperSample2013;Trusted_Connection=True;"))
            {
                conn.Open();
                foreach (var deal in conn.Query<SalesPerson, Customer, Deal>(
                    @"SELECT    TOP 10
                                    a.CustomerId,
                                    a.FirstName,
                                    a.LastName,
                                    a.DisplayName,
                                    b.CustomerId,
                                    b.FirstName,
                                    b.LastName,
                                    b.DisplayName
                            FROM Customer a WITH(NOLOCK)
                                INNER JOIN Customer b WITH(NOLOCK) ON a.CustomerId = b.CustomerId + 10
                            ORDER BY NEWID()",
                    splitOn: "CustomerId",
                    map:
                        (salesPerson, customer)
                        => new Deal
                               {
                                   SalesPerson = salesPerson,
                                   Customer = customer
                               }
                    )
                    )
                {
                    Console.WriteLine(
                        "SalesPerson: {0}\tCustomer: {1}",
                        deal.SalesPerson.DisplayName,
                        deal.Customer.DisplayName
                        );
                }
            }
        }
    }
}