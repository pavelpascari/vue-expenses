﻿using System.Collections.Generic;
using vue_expenses_api.Infrastructure;

namespace vue_expenses_api.Domain
{
    public class ExpenseCategory : Entity
    {
        protected ExpenseCategory()
        {
        }

        public ExpenseCategory(
            string name,
            string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}