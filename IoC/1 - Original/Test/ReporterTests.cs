using System;
using BusinessFacade;
using Xunit;

namespace Test
{
	public class ReporterTests
	{
		[Fact]
		public void IfNotReportsThenThrowException()
		{
			var reporter = new Reporter();

			reporter.SendReports();
		}
	}
}