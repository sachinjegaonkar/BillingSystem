namespace BillingSystem
{
    partial class BillingDBDataSet
    {
    }
}

namespace BillingSystem.BillingDBDataSetTableAdapters
{
    partial class ItemsSoldTableAdapter
    {
        public void SubscribeRowUpdatedEvent(bool subscribe)
        {
            if (subscribe)
                _adapter.RowUpdated += _adapter_RowUpdated;
            else
                _adapter.RowUpdated -= _adapter_RowUpdated;
        }

        private void _adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            AccessIDHelper.SetPrimaryKey(this.Transaction, e);
        }
    }

    public partial class InvoicesTableAdapter
    {
        public void SubscribeRowUpdatedEvent(bool subscribe)
        {
            if (subscribe)
                _adapter.RowUpdated += _adapter_RowUpdated;
            else
                _adapter.RowUpdated -= _adapter_RowUpdated;
        }

        private void _adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            AccessIDHelper.SetPrimaryKey(this.Transaction, e);
        }
    }
}
