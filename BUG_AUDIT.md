# PF101 application bug audit

23 November 2026. Reviewed the active project referenced by [the solution](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.slnx). It is the [nested .NET Framework 4.7.2 project](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.vbproj). The outer project is an older copy. The application changes were made in the nested project. The checks below distinguish source findings, reproduced behavior and Windows results.

## Leaderboard failure

The reported Windows build displayed “Score could not be saved” after a round and “Could not open the local leaderboard” from Top 10. Before this change both screens caught several exception types and used Debug Output for the details. The two messages give no exception type, SQLite code, or failing statement. The actual Windows database, extracted ZIP and exception were unavailable for this audit.

| Check | Evidence and outcome |
| --- | --- |
| Fresh database and existing current schema | The previous implementation and the updated implementation both saved and read scores on the Linux test harness. The existing SQL parameters and the current table definition work with the tested SQLite provider. |
| Existing table lacks newer metadata | Reproduced both failures on a disposable table with Id, Player and Score. The old CREATE TABLE IF NOT EXISTS did not add Difficulty or CompletedUtc. INSERT and SELECT failed because Difficulty was absent. The fix checks the schema and adds only missing metadata columns inside a transaction. Existing scores and IDs are retained. Missing historical metadata displays as Unknown. |
| Unsupported schema or corrupt database | The new store logs the failure and leaves the file in place. Tests verified that a table lacking required columns and a non-SQLite file stayed byte-for-byte unchanged. |
| File permissions | A read-only fixture produced SQLite code 8 at insert. The diagnostic captured the phase and code. Its existing score still loaded in Top 10. The app retains the per-user database location and gives permission failures a diagnostic rather than moving records. |
| Runtime loading and package composition | The two tracked historical Release ZIPs have four entries and omit the SQLite libraries. They predate the leaderboard. A fresh verification ZIP from Package-Release.ps1 contains the managed provider and matching x86/x64 SQLite DLLs. The PE machine types were checked. Actual runtime loading under Windows .NET Framework is pending. |
| Persistence and ranking | Automated checks wrote and reopened scores across two processes and verified descending scores, stable ties, the ten-row cap, recovery of migrated scores, and that the student database stayed byte-for-byte identical. |

The leaderboard remains at `%LOCALAPPDATA%\Echavez_PF101_Project\CatchGameScores.sqlite3`. A failing operation now records the operation, phase, architecture, native DLL presence, SQLite codes when applicable, and original exception. Use **Open diagnostics** in the game-over card or Top 10 dialog. The log is normally `%LOCALAPPDATA%\Echavez_PF101_Project\LeaderboardDiagnostics.log`, with `PF101-LeaderboardDiagnostics.log` under the current user's temporary directory as a fallback. Ordinary users see a short status message.

The incomplete-schema failure is verified and fixed. The cause of the specific Windows report remains unconfirmed pending a fresh Windows run with the diagnostic. [Store source](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT/CatchGameLeaderboard.vb)

## Active application findings

| Area inspected | Findings and changes |
| --- | --- |
| Main shell and Overview | The long flat sidebar obscured the course structure. Course Lessons, Practice & Activities, Project Information and the Week 2 group now collapse independently. The profile footer keeps its bottom docking and the scroll viewport has its own space. The 25 unique destinations share one route registry. Buttons reuse cached fonts for active-state changes. Page factories now run inside the guarded swap, and a failed construction leaves the current view available. The Overview uses the existing GIF in a small illustration and releases the owned image and stream during disposal. |
| Catch Game | The HUD and inputs shared rows, and the game-over label used oversized wrapped text. The HUD now has labeled metrics, a separate controls row, and a compact results card with actions and diagnostics. The playfield explicitly supports focus and double buffering. Resizing clamps positions and preserves round state. The component-owned timer, round clock, pictures and source streams follow the disposal path. The timer interval, starting lives, movement, collision and scoring remain as before. |
| Orientation and OOP labs | Reviewed grade validation, instance inputs, deposit overflow handling, inheritance, and polymorphic handlers. Existing range and overflow handling is retained. The interface's simulated print and Week 12 live printing stay separate. Windows controls still need a smoke pass. |
| Week 3, Week 10 and Week 11 | Reviewed IDE selection, debugging notes, MDI and Paint handling. The GDI+ exercise owns and disposes its brush and pen each paint. The MDI parent uses a scoped dialog. Actual repaint, child arrangement and closing are Windows checks. |
| Week 4 | Clear detached dynamic buttons without disposing them. It now removes their event handlers and disposes each button. The separate test window already closes when the lesson handle is destroyed. |
| Weeks 5–7 | Reviewed conversion boundaries, integer division, scoped counters, bounded loops, array indexing, and matrix parsing and overflow. Existing guards and demonstrations are retained. |
| Week 8 and Week 12 | Reviewed Open staging, explicit saving, format and clipboard handlers, and PrintDocument disposal. Cancelled Open and failed reads preserve the document. Navigation and close intentionally discard unsaved editor text as specified in Task 5. Printer, clipboard and dialog behavior still need Windows verification. |
| Weeks 9, 13–15 and practice quizzes | Week 9 retains its pending view. Student CRUD uses its original database and revision checks. The practice DataSet is memory-only and the two quiz sessions are independent. The automated checks covered quiz retry and DataRow transitions. The active project keeps the restored SQLite dependencies and adds ignore rules for local `.sqlite3` files and sidecars. |
| Source, assets and event wire-up | Static validation checked 44 active source entries, referenced resources and route uniqueness. All five assets copied byte-for-byte. The outer project, historical packages, and SQLite package lock were left in place. Existing ThemeManager hooks use per-control state to avoid duplicate registrations. |

## Windows Release verification still required

1. Build with native Windows MSBuild using the nested project and generate a fresh ZIP with [Package-Release.ps1](Package-Release.ps1). Extract the entire archive under a standard user account.
2. In the extracted app, finish a game and open Top 10, then restart the app and check that scores persisted. Repeat using the existing Windows leaderboard. If either operation fails, open the diagnostics and capture the original exception and phase. Keep the existing StudentPerformance and CatchGameScores databases in place.
3. At minimum and maximized window sizes, and at 125% or 150% scaling, expand and collapse each sidebar group. Verify all pages and the fixed profile footer. Check Overview shortcuts, active-page highlighting and the three Project Information pages.
4. With every difficulty, verify arrows and A/D, pause/resume, restart, HUD wrapping, final score and life loss, and Play Again and Top 10 in the centered results card. Resize during a run. Switch away with the timer running and verify a clean re-entry.
5. Exercise the Week 4 dynamic buttons and test window, Week 8 file dialogs, Week 11 MDI and painting, Week 12 printing, Week 13 SQLite editing, and the Week 14 practice DataSet. Where possible, verify both x86 and x64 process loading.

Cloud Debug and Release compilation, the SQLite and game-logic harnesses, and package-content checks passed. Windows WinForms, GDI+, and native SQLite runtime verification were unavailable in the Linux cloud environment.
