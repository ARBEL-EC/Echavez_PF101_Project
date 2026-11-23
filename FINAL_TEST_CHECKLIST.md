# PF101 final Windows verification checklist

Test the artifacts from the intended submission commit. Record the commit, Windows version and architecture, .NET Framework version, display scaling, Visual Studio/MSBuild version, and Inno Setup version alongside the results. Use a fresh standard-user test account and dummy names and scores. A separate disposable account can hold database and asset fixtures for failure checks.

## Build and inspect the artifacts

- [ ] Open the solution or its nested VB project. Restore locked packages, then clean and rebuild Debug and Release as Any CPU. Verify the target stays .NET Framework 4.7.2 and the build log identifies the nested project.
- [ ] In both build folders, check the executable and its config, SQLite notices, all five files under Assets, the managed SQLite assemblies, and `runtimes\win-x86\native\e_sqlite3.dll` and `runtimes\win-x64\native\e_sqlite3.dll`.
- [ ] Check the generated `ECHAVEZ_PF101_PROJECT.exe.config`. Verify the SQLitePCLRaw.core redirect matches the bundled assembly at `2.1.14.3207` and System.Memory matches `4.0.5.0`. The Microsoft.Data.Sqlite package version is `10.0.15` and the SQLitePCLRaw bundle is `2.1.14`. Assembly versions and NuGet package versions use different numbering.
- [ ] Generate the source ZIP and open its solution or nested project after extraction. Confirm the project restores and builds. Check that there is one project, and no bin, obj, .vs, build caches, or personal files.
- [ ] Generate the portable ZIP and Setup with the README commands. Check that the ZIP contains the executable, configuration, managed and native dependencies, notices, and assets. Verify that the package contains no databases, logs, PDBs, development sources, or historical archives. Save the artifact SHA-256 hashes with the test results.

## Portable ZIP and installer

- [ ] Disconnect a compatible Windows PC from the network. Under a standard account, extract the full portable ZIP to a fresh folder with spaces in its name. Launch the executable and open both SQLite activities.
- [ ] Run Setup from a standard account. Verify the application and developer names, per-user destination, default Start Menu shortcut, and optional desktop shortcut. Install and launch offline. Confirm both shortcuts start the installed executable when offered, and the optional shortcut is absent when unchecked.
- [ ] On an otherwise eligible Windows test VM lacking the required Framework, verify Setup stops with a .NET Framework 4.7.2 prerequisite message. Include a supported PC with a later Framework in the install tests.
- [ ] Create a dummy student record and finish a game in the installed copy. Confirm the two databases appear in `%LOCALAPPDATA%\Echavez_PF101_Project`. Reinstall or update using the same Setup identity and confirm both sets of data persist. Uninstall from Windows Settings. Confirm the program and its shortcuts are removed and both databases remain. Reinstall and verify the rows are still visible.
- [ ] Exercise a supported x64 PC and a supported x86 lab system if available. Record the process architecture used on each. Verify both the leaderboard and student records open successfully in each tested configuration.

## Navigation and lessons

- [ ] At minimum and maximized sizes, and at 125% or 150% scaling, open all sidebar groups and verify every page is reachable by scrolling. The profile footer stays fixed and the active page is highlighted. Check all six Overview shortcuts and the three Project Information pages.
- [ ] Open Week 1 and verify grade calculation and input limits. Open all four Week 2 labs and try object creation, a bank transaction, inheritance, polymorphism, and the interface example.
- [ ] Open the Week 3 IDE/console lab. In Week 4 change window properties, add and clear dynamic controls, and verify the test window closes when leaving the lesson.
- [ ] In Week 5 reset a static count, convert a character, and exercise a divide-by-zero error. In Week 6 compare the two selection modes and try positive, negative, and zero loop steps. In Week 7 load/clear the months and fill the matrix to check totals.
- [ ] In Week 8 open/save TXT and RTF, use Find, switch tabs, and navigate to another lesson. Tabs retain the current document during the visit. Navigation does not prompt or save files. Confirm a cancelled or failed Open preserves the editor.
- [ ] Verify Week 9 shows the pending materials message. Open the Week 10 debugging walkthrough. In Week 11 switch between MDI children and draw each shape with a chosen color. In Week 12 preview a multipage document and print to PDF.
- [ ] Open Midterm Practice and Finals Practice. Submit correct and incorrect answers, read the explanations, and complete an attempt. Verify the score, progress, navigation back to an in-progress quiz, and retry behavior.

## Catch Game and SQLite

- [ ] Start Easy, Normal, and Hard rounds. Use A/D and arrows, catch food, hit hazards, and verify that score and lives change correctly. Confirm the level rises after active play. Pause, wait through a level interval, then resume and verify the game only advances during play.
- [ ] Resize during a round and verify the HUD and controls remain usable. Restart while playing and while paused. Verify that Play Again from Game Over starts a clean round. Leave the game mid-round and return to confirm the new game is ready.
- [ ] Check game-over results, open Top 10, then close and reopen the app. Confirm scores persist, higher scores rank first, and equal scores keep their order. If the app reports a leaderboard failure, capture **Open diagnostics** and note the failing phase.
- [ ] In a disposable portable copy, remove `hazard.png` and verify `Bomb.png` is used. With both missing, verify the warning and fallback drawing. While a round is open in that copy, confirm that sprites can be renamed.
- [ ] In Week 13 add a student name with an apostrophe and a score with two decimal places. Search by name, edit the row, and confirm it persists when the app restarts. Verify that invalid inputs are rejected and that both responses to the delete confirmation behave correctly.
- [ ] In Week 14 compare the snapshot count to the records grid. Exercise Added, Modified, Deleted, and Unchanged in the separate DataRow practice and verify student records are unaffected. In Week 15 verify the deployment guide explains the ZIP, Setup, and first-run data location.
- [ ] In a disposable test account, try an inaccessible or corrupt leaderboard or student database. Confirm the error is recoverable after restoring the test conditions. Keep the original user files in place.

## Submission handoff

- [ ] Include `ECHAVEZ_PF101_PROJECT_Source.zip`, the tested portable Release ZIP, and the tested installer if available. The source ZIP includes the .iss, README, notices, and checklists in their project paths.
- [ ] Attach the verification results and any lab, report, or defense evidence requested by the professor. The syllabus names the Inno Setup exercise as Laboratory Activity No. 4. [PF101 syllabus](OOP%20PPT/PF101%20Syllabus.pdf)
