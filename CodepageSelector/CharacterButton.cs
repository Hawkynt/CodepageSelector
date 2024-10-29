using System.Drawing;
using System.Windows.Forms;

namespace CodepageSelector;

internal class CharacterButton : Label {

  private bool _isSelected;
  public bool IsSelected {
    get => this._isSelected;
    set {
      this._isSelected = value && this.Character != null;
      this._AdjustColor();
    }
  }

  public char? Character {
    get => this.Text.Length == 1 ? this.Text[0] : null;
    set {
      this.Text = value == null ? string.Empty : value.ToString();
      this.IsSelected = false;
    }
  }

  public CharacterButton() => this.IsSelected = false;

  #region Overrides of Control
  protected override void OnMouseDown(MouseEventArgs e) {
    base.OnMouseDown(e);
    this.Capture = false;
    this._Toggle();
  }

  #endregion

  private void _Toggle() => this.IsSelected = !this.IsSelected;

  private void _AdjustColor() {
    var chr = this.Character;
    if (chr == null) {
      this.BackColor = Color.Black;
      this.ForeColor = Color.Black;
      return;
    }

    if (this._isSelected) {
      this.BackColor = SystemColors.Highlight;
      this.ForeColor = SystemColors.HighlightText;
    } else {
      this.BackColor = GetCharacterClassColor(chr.Value);
      this.ForeColor = SystemColors.ControlText;
    }

    return;

    static Color GetCharacterClassColor(char character) =>
      character switch {

        _ when char.IsControl(character) => Color.Salmon,
        _ when char.IsWhiteSpace(character) => Color.LightSkyBlue,
        _ when char.IsPunctuation(character) => Color.Lavender,

        _ when char.IsLower(character) => Color.LightGoldenrodYellow,
        _ when char.IsUpper(character) => Color.LightYellow,
        _ when char.IsLetter(character) => Color.Yellow,

        _ when char.IsDigit(character) => Color.LimeGreen,
        _ when char.IsNumber(character) => Color.PaleGreen,

        _ => Color.White
      };
  }

}
