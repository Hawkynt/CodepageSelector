using System;

namespace CodepageSelector;

internal static class Program {
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main() {
    System.Windows.Forms.Application.Run(new MainForm());
  }
}