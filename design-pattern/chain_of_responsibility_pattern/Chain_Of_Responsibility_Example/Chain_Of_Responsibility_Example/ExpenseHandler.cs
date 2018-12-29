using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Chain_Of_Responsibility_Example
{
	public interface IExpenseHandler
	{
		ApprovalResponse approve(IExpenseReport report);
		void registerNext(IExpenseHandler handler);
	}

	public class ExpenseHandler : IExpenseHandler
	{
		private IExpenseApprover _approver;
		private IExpenseHandler _next;

		public ExpenseHandler(IExpenseApprover approver)
		{
			this._approver = approver;
			this._next = EndOfChainExpenseHandler.Instance;
		}

		//Make it so that if the amount is beyond approval limit, make the next one in responsibility chain handle the approval
		public ApprovalResponse approve(IExpenseReport report)
		{
			var response = _approver.ApproveExpense(report);

			if (response == ApprovalResponse.BeyondApprovalLimit) return _next.approve(report);
			else return response;
		}

		//responsibility chainの次のオブジェクトを設定する
		public void registerNext(IExpenseHandler handler)
		{
			_next = handler;
		}
	}

	class EndOfChainExpenseHandler : IExpenseHandler
	{
		//Singleton instanceを返す
		public static EndOfChainExpenseHandler Instance { get; } = new EndOfChainExpenseHandler();

		//誰も承認ができないため、Deniedを返す
		public ApprovalResponse approve(IExpenseReport report) => ApprovalResponse.Denied;

		//Responsibility Chainの最後なので、Exceptionを返す
		public void registerNext(IExpenseHandler handler) => throw new System.InvalidOperationException("end of chain!");
	}
}