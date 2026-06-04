# CI/CD Pipeline — CodepageSelector

Event-driven pipeline (no cron). Workflows live here; their helper scripts live
in `scripts/`.

| File | Trigger | Purpose |
|------|---------|---------|
| `ci.yml` | push + PR on `master` + `workflow_call` | Build the whole solution on windows (net48) |
| `release.yml` | **manual dispatch** | Build the app, then cut the dated `vyyyyMMdd` Release |
| `nightly.yml` | successful CI on `master` + manual | Publish `nightly-yyyyMMdd` prerelease and prune old ones |
| `_build.yml` | `workflow_call` (internal) | Publish the Windows app zip |
| `scripts/version.pl` | invoked by workflows | Stamp each project's own `<Version>` + its folder's commit count (`--stamp`) |
| `scripts/update-changelog.mjs` | invoked by workflows | Bucketise commits into release notes by `+ - * # !` prefix |
| `scripts/prune-nightlies.mjs` | invoked by workflows | GFS retention: 7 daily + 4 weekly + 3 monthly |

## Notes

- **Versioning — files drive, never tags.** The app (`CodepageSelector`) carries
  its own `<Version>`; `version.pl --stamp` appends the folder commit count. The
  repo-level Release/tag is the date marker `vyyyyMMdd`.
- **net48 app** — the build/publish runs on windows (framework-dependent folder
  output, zipped for the release).
- **Behaviour change vs the old `UpdateVersions.pl`:** publishing is a manual
  dispatch; nightlies and changelog notes are automatic.
