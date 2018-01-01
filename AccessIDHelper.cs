using System;
using System.Data.OleDb;

namespace BillingSystem
{
    public class AccessIDHelper
    {
        public static void SetPrimaryKey(OleDbTransaction trans, OleDbRowUpdatedEventArgs e)
        {
            if (e.Status == System.Data.UpdateStatus.Continue && 
                e.StatementType == System.Data.StatementType.Insert)
            {
                // if this is an insert operation...
                var pk = e.Row.Table.PrimaryKey;
                // and primary key column exists...

                if (pk != null && pk.Length == 1)
                {
                    var cmdGetIdentity = new OleDbCommand("SELECT @@IDENTITY", trans.Connection, trans);
                    // Execute the post-update query to fetch the new @IDENTITY
                    e.Row[pk[0]] = Convert.ToInt32(cmdGetIdentity.ExecuteScalar());
                    e.Row.AcceptChanges();
                }
            }
        }
    }
}
