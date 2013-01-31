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

namespace Demo._005___Multiple_Results
{
    internal class Program
    {
        private static void Main()
        {
            using (var conn = new SqlConnection("Server=localhost;Database=DapperSample2013;Trusted_Connection=True;"))
            {
                conn.Open();
                using (var qm = conn
                    .QueryMultiple(@"
                        SELECT TOP 1
                                FirstName,
                                LastName,
                                DisplayName
                            FROM Customer WITH(NOLOCK)
                            ORDER BY NEWID()

                        SELECT  TOP 5
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
                            ORDER BY NEWID()

                        SELECT  TOP 5
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
                            ORDER BY NEWID()
                                    "))
                {
                    var salesPerson = qm.Read<SalesPerson>().FirstOrDefault();
                    if (salesPerson == null)
                    {
                        Console.WriteLine("No sales person found");
                        return;
                    }

                    salesPerson.Customers = qm.Read<Customer>().ToList();
                    salesPerson.Leads = qm.Read<Customer>().ToList();

                    Console.WriteLine(
                        "Sales person: {0}\r\nCustomers:\r\n\t{1}\r\nLeads:\r\n\t{2}",
                        salesPerson.DisplayName,
                        string.Join(
                            "\r\n\t",
                            salesPerson.Customers.Select(customer => customer.DisplayName)
                            ),
                        string.Join(
                            "\r\n\t",
                            salesPerson.Leads.Select(lead => lead.DisplayName)
                            )
                        );

                }
            }
        }
    }
}
