# Agent guide — CodepageSelector

Working agreement for **all** coding agents and human contributors working in
this repository. These rules are not optional. The full house spec lives in
the `Hawkynt/project-template` repo (`STANDARD.md`); this file is the
per-repo distillation.

## What this is

An interactive **WinForms C# app** for navigating code pages and picking
characters from a 16x16 grid. Solution `CodepageSelector.sln` (net48
SDK-style — note `GenerateResourceUsePreserializedResources` +
`System.Resources.Extensions` for non-string resources). Depends on
`FrameworkExtensions.Corlib`.

## Commits

- **Group changes semantically/logically** — one concern per commit.
- **Every subject line starts with a prefix**: `+` added · `-` removed ·
  `*` changed · `#` bug fixed · `!` critical todo.
- Never start a subject with "fix"/"bugfix"/"changed"/"modified".
- **No AI traces anywhere**: no `Co-Authored-By` AI lines, no "Generated
  with" footers, no agent mentions in messages, comments, or authorship.

## The loop (always, in this order)

1. **Before committing**: `dotnet build CodepageSelector.sln -c Release`
   until green; UI changes get a manual run and an updated `GUI.png`
   screenshot. Update the README's features/usage when behavior changes.
2. **Commit** (rules above) and **push**.
3. **Wait for CI**; on `main` a green CI triggers the nightly (prerelease +
   GFS prune, same-day replace). Fix and loop until everything is green.

Stable releases are **manual** (`gh workflow run release.yml`) — never cut
one unless explicitly asked.

## Code conventions

- Latest C# features the net48 target allows — polyfill via
  `FrameworkExtensions` packages rather than downgrading syntax.
- Encoding handling is the product: code-page math gets tests/asserts at
  the boundaries (0, 1, 65535, unregistered pages) — never assume a page
  exists.

## README & repo conventions

- Standard frame: title → badges → one-line `>` blockquote → screenshot
  (`GUI.png` — keep it current); fixed emoji mapping for the standard
  sections (`## ✨ Features`, `## 📦 Installation`, `## 🚀 Usage`,
  `## ❤️ Support`, `## 📜 License`).
- License is LGPL-3.0-or-later; the `## ❤️ Support` section and
  `.github/FUNDING.yml` stay intact.
