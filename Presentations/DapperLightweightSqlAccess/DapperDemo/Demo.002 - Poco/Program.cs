﻿// ----------------------------------------------------------------------------------------------
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

namespace Demo._002___Poco
{
    class Program
    {
        static void Main()
        {
            using (var conn = new SqlConnection("Server=localhost;Database=DapperSample2013;Trusted_Connection=True;"))
            {
                conn.Open();
                foreach (var customer in  conn.Query<Customer>(
                        @"SELECT    TOP 10
                                    CustomerId,
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
                            FROM Customer WITH(NOLOCK)"
                    )
                    )
                {
                    Console.WriteLine(
                        "CustomerId: {0}\tDisplayName: {1}",
                        customer.CustomerId,
                        customer.DisplayName
                        );
                }
            }
        }
    }
}
