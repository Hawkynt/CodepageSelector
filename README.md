# CodepageSelector

[![License](https://img.shields.io/github/license/Hawkynt/CodepageSelector)](https://github.com/Hawkynt/CodepageSelector/blob/main/LICENSE)
[![Language](https://img.shields.io/github/languages/top/Hawkynt/CodepageSelector?color=8957D5)](https://github.com/Hawkynt/CodepageSelector)

[![CI](https://github.com/Hawkynt/CodepageSelector/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/Hawkynt/CodepageSelector/actions/workflows/ci.yml)
![Last Commit](https://img.shields.io/github/last-commit/Hawkynt/CodepageSelector?branch=main)
![Activity](https://img.shields.io/github/commit-activity/m/Hawkynt/CodepageSelector)

[![Stars](https://img.shields.io/github/stars/Hawkynt/CodepageSelector?color=FFD700)](https://github.com/Hawkynt/CodepageSelector/stargazers)
[![Forks](https://img.shields.io/github/forks/Hawkynt/CodepageSelector?color=008080)](https://github.com/Hawkynt/CodepageSelector/network/members)
[![Issues](https://img.shields.io/github/issues/Hawkynt/CodepageSelector)](https://github.com/Hawkynt/CodepageSelector/issues)
![Code Size](https://img.shields.io/github/languages/code-size/Hawkynt/CodepageSelector?color=4CAF50)
![Repo Size](https://img.shields.io/github/repo-size/Hawkynt/CodepageSelector?color=FF9800)

[![Release](https://img.shields.io/github/v/release/Hawkynt/CodepageSelector?sort=semver)](https://github.com/Hawkynt/CodepageSelector/releases/latest)
[![Nightly](https://img.shields.io/github/v/release/Hawkynt/CodepageSelector?include_prereleases&sort=date&label=nightly&color=FF9800)](https://github.com/Hawkynt/CodepageSelector/releases)
[![Downloads](https://img.shields.io/github/downloads/Hawkynt/CodepageSelector/total)](https://github.com/Hawkynt/CodepageSelector/releases)

> An interactive C# application for navigating code pages and picking characters from a 16x16 grid — useful for developers, linguists, and anyone wrangling character encodings.

![Screenshot](GUI.png)

## ✨ Features

- **Code Page Navigation**: Users can navigate through different code pages using the "Back" and "Forward" buttons or by directly entering a code page number and pressing the TAB-key.
- **Character Selection**: Each code page is displayed in a 16x16 grid, allowing users to select or deselect characters by clicking on them. By default, letters and digits are pre-selected when a new code page is loaded.
- **Character Categorizing**: Characters are colored by their category to distinguish whitespace, letters, digits, numbers, and control characters.
- **Data Storage**: Selected characters can be stored in a dictionary file (`Selection.dict`), which is saved in the `Data` folder. Each entry in this file represents a code page and a list of consecutive selected character ranges in hexadecimal notation. Single characters are stored as a range of length zero. The format is as follows:

  ```cs
  { CodePageNumber, [StartRange..EndRange, StartRange..EndRange, ...] }
  ```

  - CodePageNumber: The number of the code page.
  - StartRange..EndRange: A range of selected characters in hexadecimal format. Each range specifies the start and end of a contiguous block of selected characters.
  - Example:

    ```cs
    { 1252, [0x80..0x80, 0xF8..0xFF] }
    ```

    Indicates that for Codepage `1252` the selected characters include the single character `0x80` and the characters from `0xF8` to `0xFF`.
  
  This format provides an efficient way to store character selections, especially when dealing with large sets of characters or multiple code pages. Additionally, it is directly usable in C# code if you create a `Dictionary<int, Range[]>` and utilize the collection initialization syntax.

## Requirements

- .NET Framework 4.8 or later
- Windows operating system or something else with support for WinForms

## 📦 Installation

1. Clone or download this repository.
2. Ensure [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) or later is installed on your system.
3. Open the project in Visual Studio or your preferred IDE that supports .NET Framework applications.
4. Build and run the application.

## 🚀 Usage

1. **Navigating Code Pages**: Use the "Back" and "Forward" buttons to scroll through code pages. You can also enter a specific code page number in the input box between the navigation buttons.
2. **Selecting Characters**: Click on any character in the 16x16 grid to select or deselect it. Selected characters are highlighted. Dragging over multiple characters is supported.
3. **Saving Selection**: The selected characters are saved in the `Selection.dict` file located in the `Data` folder. Saving is automatically, loading occurs whenever the codepage is changed.

## Project Structure

- **`Program.cs`**: The main entry point for the application - nothing to see here.
- **`MainForm.cs`**: Contains the main form for the user interface and handles code page navigation and character selection.
- **`Data\Selection.dict`**: A dictionary file that stores selected characters. This file is updated whenever codepage is changed.
- **`Properties`**: Contains project metadata such as version information and assembly attributes.

## Dependencies

- [**FrameworkExtensions.Corlib**](https://www.nuget.org/packages/FrameworkExtensions.Corlib): This package provides essential extensions for .NET Framework applications.

## 🤝 Contributing

- give credit to ***Hawkynt*** when using
- please do **pull**-requests if you add something
- report issues to and get in contact at [GitHub](https://github.com/Hawkynt/CodepageSelector)

## ❤️ Support

If this project saves you time or money, consider supporting its development:

[![GitHub Sponsors](https://img.shields.io/badge/GitHub-Sponsor-EA4AAA?logo=githubsponsors)](https://github.com/sponsors/Hawkynt)
[![PayPal](https://img.shields.io/badge/PayPal-Donate-00457C?logo=paypal)](https://www.paypal.me/hawkynt)

## 📜 License

Licensed under LGPL-3.0-or-later — see [LICENSE](LICENSE).
