using System.Drawing;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CodepageSelector.Classes;

namespace CodepageSelector;

public partial class MainForm : Form {

  private readonly Font _unicodeFont = new("Arial Unicode MS", 12);
  
  private Encoding? _currentEncoding;

  private int _currentCodePage;
  private int _CurrentCodePage {
    get => this._currentCodePage;
    set {
      if (this._currentCodePage == value)
        return;

      this._SaveSelection();
      this.nudCurrentPage.Value = this._currentCodePage = value;
      this._LoadCodePage(value);
      this.nudCurrentPage.BackColor = this._currentEncoding == null ? Color.Salmon : Color.LightGreen;
    }
  }
  
  public MainForm() {
    this.InitializeComponent();
    this._CreateButtons(this.tlpCharacters);
    this._CurrentCodePage = Encoding.Default.CodePage;
  }

  private void _LoadCodePage(int codePageIndex) {
    try {
      this._currentEncoding = Encoding.GetEncoding(codePageIndex);
    } catch (NotSupportedException) {
      
      // Codepage can not be loaded
      this._currentEncoding = null;
    } catch (ArgumentException) {
      
      // No valid codepage ID
      this._currentEncoding = null;
    }

    this._DisplayCharacters();
  }

  private void _DisplayCharacters() {
    var knownSelection = SelectionReaderWriter.GetSelection(this._CurrentCodePage);
    var noKnownSelectionPresent = knownSelection == null || knownSelection.All(s => !s);
    
    var currentCharCode = 0;
    foreach (var charButton in this.tlpCharacters.Controls.OfType<CharacterButton>()) {
      var character = this._currentEncoding?.GetString([(byte)currentCharCode])[0];
      charButton.Character = character;
      if(character==null)
        continue;

      if (noKnownSelectionPresent)
        charButton.IsSelected = currentCharCode>=0x80 && (char.IsDigit(character.Value) || char.IsLetter(character.Value));
      else
        charButton.IsSelected = knownSelection[currentCharCode];
      
      ++currentCharCode;
    }
  }

  private void _SaveSelection() 
    => SelectionReaderWriter.SetSelection(
      this._CurrentCodePage,
      this.tlpCharacters.Controls.OfType<CharacterButton>().Select(b => b.IsSelected).ToArray()
    );
  
  private void _CreateButtons(TableLayoutPanel container) {
    bool? currentDragMode = null;
    
    for (var i = 0; i < 256; ++i) {
      var charButton = new CharacterButton {
        Dock = DockStyle.Fill,
        Padding = Padding.Empty,
        Margin = new(1),
        Font = this._unicodeFont,
        AutoSize = true,
        TextAlign = ContentAlignment.MiddleCenter,
      };
      
      charButton.MouseUp += (_, _) => currentDragMode = null;
      charButton.MouseDown += (sender, _) => {
        if (sender is not CharacterButton button)
          return;
        
        currentDragMode = !button.IsSelected;
      };
      charButton.MouseEnter += (sender, _) => {
        if (sender is not CharacterButton button || currentDragMode == null)
          return;

        button.IsSelected=currentDragMode.Value;
      };

      container.Controls.Add(charButton);
      container.SetRow(charButton, 1+(i / 16));
      container.SetColumn(charButton, 1+(i % 16));
    }

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