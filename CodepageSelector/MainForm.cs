using System.Drawing;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodepageSelector.Classes;

namespace CodepageSelector;

public partial class MainForm : Form {

  private readonly Font _unicodeFont = new("Arial Unicode MS", 12);
  
  private Encoding? currentEncoding;

  private int _currentCodePage;
  private int _CurrentCodePage {
    get => this._currentCodePage;
    set {
      if (this._currentCodePage == value)
        return;

      this.SaveSelection();
      this.nudCurrentPage.Value = this._currentCodePage = value;
      this.LoadCodePage(value);
    }
  }
  
  public MainForm() {
    this.InitializeComponent();
    this.CreateButtons(this.tlpCharacters);
    this._CurrentCodePage = Encoding.Default.CodePage;
  }

  private void LoadCodePage(int codePageIndex) {
    try {
      this.currentEncoding = Encoding.GetEncoding(codePageIndex);
    } catch (NotSupportedException) {
      this.currentEncoding = null;
    }

    this.DisplayCharacters();
  }

  private void DisplayCharacters() {
    var knownSelection = SelectionReaderWriter.GetSelection(this._CurrentCodePage);

    var i = 0;
    foreach (var charButton in this.tlpCharacters.Controls.OfType<Button>()) {
      charButton.Text = this.currentEncoding?.GetString([(byte)i]) ?? "???";
      SetButton(charButton, knownSelection != null && knownSelection[i]);
      ++i;
    }
  }

  private void SaveSelection() {
    var selected = this.tlpCharacters.Controls.OfType<Button>().Select(b => b.Tag is true).ToArray();
    SelectionReaderWriter.SetSelection(this._CurrentCodePage,selected);
  }


  private void CreateButtons(TableLayoutPanel container) {
    for (var i = 0; i < 256; ++i) {
      var charButton = new Button {
        Text = string.Empty,
        Dock = DockStyle.Fill,
        Padding = Padding.Empty,
        Margin = Padding.Empty,
        Font = this._unicodeFont,
        BackColor = SystemColors.ButtonFace,
        AutoSize = true,
        Tag=false,
      };
      charButton.Click += this.CharButton_Click;
      container.Controls.Add(charButton);
      container.SetRow(charButton, 1+(i / 16));
      container.SetColumn(charButton, 1+(i % 16));
    }
  }

  private static void SetButton(Button button, bool state) {
    if (state) {
      button.Tag = true;
      button.BackColor = SystemColors.Highlight;
      button.ForeColor = SystemColors.HighlightText;
    } else {
      button.Tag = false;
      button.BackColor = GetCharacterClassColor(button.Text.Length == 1 ? button.Text[0] : null) ?? SystemColors.Control;
      button.ForeColor = SystemColors.ControlText;
    }
  }

  private static Color? GetCharacterClassColor(char? character) =>
    character switch {
      { } c when char.IsControl(c) => Color.Salmon,
      { } c when char.IsWhiteSpace(c) => Color.LightSkyBlue,
      { } c when char.IsLower(c) => Color.Yellow,
      { } c when char.IsUpper(c) => Color.LightYellow,
      { } c when char.IsLetter(c) => Color.LightGoldenrodYellow,
      { } c when char.IsDigit(c) => Color.LimeGreen,
      { } c when char.IsNumber(c) => Color.PaleGreen,
      { } c when char.IsPunctuation(c) => Color.LightPink,
      _ => null
    };

  private static void ToggleButton(Button button) => SetButton(button, button.Tag is not true);

  private void CharButton_Click(object sender, EventArgs e) {
    if (sender is Button button)
      ToggleButton(button);
  }

  private void btBack_Click(object sender, EventArgs e) {
    if (this._CurrentCodePage > this.nudCurrentPage.Minimum)
      --this._CurrentCodePage;
  }

  private void btForward_Click(object sender, EventArgs e) {
    if (this._CurrentCodePage < this.nudCurrentPage.Maximum)
      ++this._CurrentCodePage;
  }

  private void nudCurrentPage_ValueChanged(object sender, EventArgs e) => this._CurrentCodePage = (int)this.nudCurrentPage.Value;
  
}
