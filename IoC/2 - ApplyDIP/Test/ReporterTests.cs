using System;
using System.Collections.Generic;
using BusinessFacade;
using Domain;
using Moq;
using Xunit;

namespace Test
{
	public class ReporterTests
	{
		[Fact]
		public void IfNotReportsThenThrowException()
		{
			var builder = new Mock<IReportBuilder>();
			builder.Setup(m => m.CreateReports()).Returns(new List<Report>());

			var sender = new Mock<IReportSender>();

			var reporter = new Reporter(builder.Object, sender.Object);

			Assert.Throws<NoReportsException>(() => reporter.SendReports());
		}
	}
}