using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Example
{
	//費用請求レポートのinterface
    public interface IExpenseReport
    {
		Decimal Total { get;  }
    }

	//承認者のinterface
	public interface IExpenseApprover
	{
		ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
	}

	//承認処理のタイプ
	public enum ApprovalResponse
	{
		Denied,
		Approved,
		BeyondApprovalLimit,
	}
}