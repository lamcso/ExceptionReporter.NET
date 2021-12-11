using System;
using System.Collections.Generic;
using ExceptionReporting.Shared.Network.Events;

#pragma warning disable 1591

namespace ExceptionReporting.Shared.Core
{
  /// <summary>
  /// The interface (contract) for an ExceptionReport dialog/View
  /// </summary>
  public interface IExceptionReportView : IReportSendEvent
  {
	string ProgressMessage { set; }
	bool EnableEmailButton { set; }
	bool ShowProgressBar { set; }
	bool ShowFullDetail { get; set; }
	string UserExplanation { get; }

	void MapiSendCompleted();
	void SetInProgressState();
	void PopulateExceptionTab(IEnumerable<Exception> exceptions);
	void PopulateAssembliesTab();
	void PopulateSysInfoTab();
	void SetProgressCompleteState();
	void ToggleShowFullDetail();
	void ShowWindow();
  }
}

#pragma warning restore 1591
