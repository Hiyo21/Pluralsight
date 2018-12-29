using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Example
{
	class Employee : IExpenseApprover
	{
		private readonly Decimal _approvalLimit;
		public string Name { get; private set; }


		public Employee(string name, Decimal approvalLimit)
		{
			this.Name = name;
			this._approvalLimit = approvalLimit;
		}

		public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
		{
			return expenseReport.Total > _approvalLimit
				? ApprovalResponse.BeyondApprovalLimit
				: ApprovalResponse.Approved;
		}
	}
}
