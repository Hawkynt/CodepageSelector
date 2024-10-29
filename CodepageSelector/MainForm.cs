using System.Drawing;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
  }
  
  public MainForm() {
    this.InitializeComponent();
    this._CreateButtons(this.tlpCharacters);
    this.nudCurrentPage.Select();
    this.bError.BackColor = ColorPalette.Error;
    this.bOther.BackColor = ColorPalette.Others;
    this.bControl.BackColor = ColorPalette.Control;
    this.bWhiteSpace.BackColor = ColorPalette.WhiteSpace;
    this.bPunctuation.BackColor = ColorPalette.Punctuation;
    this.bLower.BackColor = ColorPalette.Lower;
    this.bUpper.BackColor = ColorPalette.Upper;
    this.bLetter.BackColor = ColorPalette.Letter;
    this.bDigit.BackColor = ColorPalette.Digit;
    this.bNumber.BackColor = ColorPalette.Number;

    this._CurrentCodePage = Encoding.Default.CodePage;
  }

  private void _LoadCodePage(int codePageIndex) {
    
    this.lCodepageError.Visible = this.lCodepageSuccess.Visible = false;
    this.lCodepageLoading.Visible = true;
    
    try {
      this._currentEncoding = Encoding.GetEncoding(codePageIndex);
      this.lCodepageSuccess.Visible = true;
    } catch (NotSupportedException) {

      // Codepage can not be loaded
      this._currentEncoding = null;
      this.lCodepageError.Visible = true;
    } catch (ArgumentException) {

      // No valid codepage ID
      this._currentEncoding = null;
      this.lCodepageError.Visible = true;
    } finally {
      
      this.nudCurrentPage.BackColor = this._currentEncoding == null ? Color.Salmon : Color.LightGreen;
      
      this.lCodepageName.Text = this._currentEncoding switch {
        { } e => $"{e.EncodingName} [{e.HeaderName}]",
        null => "Unknown"
      };

      this._DisplayCharacters();
      
      this.lCodepageLoading.Visible = false;
    }

  }

  private void _DisplayCharacters() {
    var knownSelection = SelectionReaderWriter.GetSelection(this._CurrentCodePage);
    var noKnownSelectionPresent = knownSelection == null || knownSelection.All(s => !s);

    var currentCharCode = 0;
    foreach (var charButton in this.tlpCharacters.Controls.OfType<CharacterButton>()) {
      var character = this._currentEncoding?.GetString([(byte)currentCharCode])[0];
      charButton.Character = character;
      if (character == null)
        continue;

      if (noKnownSelectionPresent)
        charButton.IsSelected = char.IsDigit(character.Value) || char.IsLetter(character.Value);
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

  private void _FlipByPredicate(Predicate<char> predicate) {
    foreach (var charButton in this.tlpCharacters.Controls.OfType<CharacterButton>()) {
      var character = charButton.Character;
      if (character != null && predicate(character.Value))
        charButton.IsSelected = !charButton.IsSelected;
    }
  }

  private void btBack_Click(object sender, EventArgs e) {
    var knownEncodings = Encoding.GetEncodings();
    var nextEncoding = knownEncodings.LastOrDefault(e => e.CodePage < this._CurrentCodePage);
    if (nextEncoding != null)
      this._CurrentCodePage = nextEncoding.CodePage;
  }

  private void btForward_Click(object _, EventArgs __) {
    var knownEncodings = Encoding.GetEncodings();
    var nextEncoding = knownEncodings.FirstOrDefault(e => e.CodePage > this._CurrentCodePage);
    if(nextEncoding!=null)
      this._CurrentCodePage=nextEncoding.CodePage;
  }

  private void nudCurrentPage_ValueChanged(object sender, EventArgs e) => this._CurrentCodePage = (int)this.nudCurrentPage.Value;

  private void bError_Click(object sender, EventArgs e) {
    
  }

  private void bControl_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsControl);
  private void bPunctuation_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsPunctuation);
  private void bLower_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsLower);
  private void bUpper_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsUpper);
  private void bLetter_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsLetter);
  private void bDigit_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsDigit);
  private void bNumber_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsNumber);
  private void bWhiteSpace_Click(object sender, EventArgs e) => this._FlipByPredicate(char.IsWhiteSpace);

  private void bOther_Click(object sender, EventArgs e) => this._FlipByPredicate(c=>!(
    char.IsControl(c)
    || char.IsPunctuation(c)
    || char.IsLower(c)
    || char.IsUpper(c)
    || char.IsLetter(c)
    || char.IsDigit(c)
    || char.IsNumber(c)
    || char.IsWhiteSpace(c)
  ));
  
  
}