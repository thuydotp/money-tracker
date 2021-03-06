﻿using System;

namespace MoneyTracker.Persistence
{
    public class TransactionDA
    {
        public Guid ID { get; set; }

        public SpendingTypeDA Type { get; set; }
        
        public decimal ChangeValue { get; set; }

        public string Description { get; set; }

        public Guid CategoryID { get; set; }

        public virtual CategoryDA Category { get; set; }
        
        public Guid SpendingAccountID { get; set; }
        
        public virtual SpendingAccountDA SpendingAccount { get; set; }
        
        public DateTime RecordDate { get; set; }
    }

    public enum SpendingTypeDA
    {
        Expense = 0,
        Income = 1
    }
}
