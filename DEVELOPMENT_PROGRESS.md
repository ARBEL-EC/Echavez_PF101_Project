# PF101 development progress

## Task 9 · Final QA and submission packaging

Based on `main` at `2d78b2b`. The existing app and leaderboard were working on Windows per the project owner. The supplied syllabus lists installer creation with Inno Setup as Laboratory Activity No. 4 on page 7, and describes the semester portfolio on page 9. [PF101 syllabus](OOP%20PPT/PF101%20Syllabus.pdf)

| Area | Changes and verification |
| --- | --- |
| Active project | Confirmed that the solution loads the nested .NET Framework 4.7.2 VB project. Inspected 44 compile items, 12 embedded resources, three linked images, 25 navigation routes, six Overview shortcuts, and 47 designer button subscriptions. The week routes remain chronological, with four Week 2 OOP labs and a Week 9 status page. Traced dynamic game, quiz, CRUD, and MDI handlers. |
| Locked restore | A fresh cloud restore reproduced `NU1004` because the Windows-generated lock records four runtime identifiers and the project had left them implicit. The active project now declares the same identifiers, and clean locked Debug and Release builds passed with the out-of-tree Linux build overrides. The existing dependency versions and x86/x64 distribution are retained. |
| Installer and portable ZIP | `Installer/PF101.iss` provides per-user Setup, a Framework prerequisite check, the Start Menu shortcut, an optional desktop shortcut, and uninstall that preserves Local AppData. `Package-Release.ps1` stages the same 18 runtime files for both formats. It excludes older binaries, PDBs, database files, and other build output. The two historical ZIPs lacked assets and SQLite, and the tracked Release EXE is stale. |
| Artifact checks | Both fresh outputs contained all five source-matching GIF and PNG assets, all managed dependencies, and the original x86 and x64 SQLite binaries. Verified Microsoft.Data.Sqlite 10.0.15 and SQLitePCLRaw 2.1.14, plus the generated redirects to SQLitePCLRaw.core 2.1.14.3207 and System.Memory 4.0.5.0. The cloud Release ZIP passed CRC and exact-content checks. An ISCC test double exercised spaced paths and failure handling, including preservation of prior packages. |
| Model checks | Rebuilt the isolated VB harnesses against current sources. Student CRUD, decimal scores, persistence and conflict handling passed. Leaderboard migration, ranking, retention, failure diagnostics and separation from student records passed. Difficulty pacing, both practice quiz banks, and all four DataRow states also passed. |
| Evaluator guide | Updated Overview and Week 15 text for the lesson shortcuts, game controls, SQLite first use and deployment. README includes the source archive and Windows packaging commands. `FINAL_TEST_CHECKLIST.md` covers offline install, update and uninstall, data retention, routes, lessons and runtime checks. |

Native Windows MSBuild, WinForms and Windows SQLite loading still require verification for this revision. Inno Setup was unavailable in the Linux environment, so the installer was not compiled or exercised. The cloud Release ZIP verifies the archive contents using the cloud resource build overrides. Generate the submission binaries on Windows and record the manual results. [Final Windows checklist](FINAL_TEST_CHECKLIST.md)

## Task 7 · Runtime diagnosis and portfolio navigation

Based on `main` at `fb1d8c9`.

- **Leaderboard.** Added schema inspection, a transactional migration for missing leaderboard metadata, and a persistent diagnostic log linked from the game. Tests reproduced the old read and write failures on an incomplete schema and verified that the update retained scores. The reported Windows messages lacked the inner exception, so the cause on that machine is still unconfirmed.
- **Navigation and project pages.** Added collapsible Course Lessons, Practice & Activities, Project Information and Week 2 groups inside the existing sidebar. The profile footer and independent scrolling remain. Overview includes the portfolio purpose and direct links. About This Project, Course Coverage and Developer Information give the professor a clear route to evaluate the work.
- **Catch Game.** Separated the HUD, controls, playfield and compact results card while keeping the existing gameplay and sprites. The playfield can take keyboard focus and uses double buffering. Score and leaderboard errors stay in the results UI with a diagnostic link when available.
- **Audit fixes.** The Week 4 Clear action now disposes removed buttons. Navigation uses cached fonts and catches page construction errors before replacing a working view. Local SQLite files and sidecars are ignored.

Clean Debug and Release builds passed using the existing cloud overrides. Automated storage checks covered migration, ranked retrieval, retention, and diagnostics on read-only, incompatible and corrupt fixtures. The two-process harness also checked pacing, quizzes and DataRow transitions. A generated verification ZIP passed integrity and x86/x64 dependency checks. [BUG_AUDIT.md](BUG_AUDIT.md) has the findings and outstanding Windows Release, layout and gameplay checks.

## Task 6 · Catch Game, course practice, and demonstrations

Based on `main` at `7ff7812`. The new questions and UI use this project’s course materials and Dark Obsidian controls.

| Feature | Implementation |
| --- | --- |
| Catch Game | `frmCatchGame.vb` adds Easy, Normal and Hard, Pause/Resume, and a final-score summary with Play Again and Top 10. `CatchGameDifficulty.vb` raises the level every 20 seconds of active play up to Level 8. Higher levels spawn items sooner and increase the speed of newly spawned items. A paused round retains its score, lives, falling items and elapsed time. Normal starts at the previous spawn interval and speeds. Movement keys, three lives, hazard chance, sprites and ten points per food follow the existing game. |
| Top ten | `CatchGameLeaderboard.vb` records completed games with the player name, difficulty, score and local display time. One table ranks all difficulties by score, with earlier records first on ties. The database lives at `%LOCALAPPDATA%\Echavez_PF101_Project\CatchGameScores.sqlite3`, alongside the separate student database. A storage error leaves the game playable. |
| Midterm and Finals Practice | `CourseReview.vb` contains 24 original practice questions with explanations and topic references. Midterm covers Weeks 1–8. Finals covers Weeks 10–15. `frmCourseReview.vb` shows progress and score, explains each submitted answer, and offers Retry Practice. `frmMain.vb` gives each quiz its own sidebar entry and attempt. Attempts stay in memory while the app is open and start fresh after a restart. Week 9 still identifies the pending midterm material. |
| Week 11 drawing | The existing Week 11 view in `frmLesson3_IDE.vb` includes a Drawing tab. `DrawingPracticeCanvas.vb` draws rectangles, ellipses and triangles with the chosen fill. The canvas uses double buffering, redraws from its Paint event, and invalidates on changes. |
| Week 14 row states | `frmStudentRecords.vb` links to the DataRow States tab. `DataRowPractice.vb` and `DataRowPracticeView.vb` display real Added, Modified, Deleted and Unchanged states and Original and Current values. Accept, Reject and Reset work on the seeded in-memory DataSet. The exercise has no database connection. |

### Task 6 verification

- Clean Debug and Release builds of the .NET Framework 4.7.2 project passed on Linux with the existing external build overrides. All five sprite and wallpaper assets matched their source files. Both native SQLite libraries were present.
- A VB smoke harness exercised level thresholds and caps, the original Normal starting pace, both quiz banks, duplicate submission prevention, final scoring and retry, and all four DataRow states with Accept/Reject/Reset.
- The same harness wrote and read SQLite scores across two processes. It checked the ten-row limit, ordering and ties, an apostrophe in a player name, and an unchanged student database confirmed by a byte comparison.
- The Release script generated a ZIP containing the application, SQLite dependencies and assets. The verification archive contained no user databases. Source checks confirmed the sidebar routes and preserved game constants. WinForms interaction and rendering still require Windows.

### Task 6 Windows checks

1. Start all three difficulties in Catch Game. Check arrow and A/D movement, food scoring, hazard life loss, and the level after about 20 seconds of active play. Pause and wait through a level interval. Verify that positions and level stay fixed until Resume. Check Restart while playing and paused, Play Again after game over, and Top 10 after reopening the app. At minimum window size and higher DPI, confirm the HUD and the game-over summary remain readable.
2. From the sidebar, open Midterm Practice and Finals Practice. Try a correct answer and an incorrect answer in each, finish an attempt, and verify its score and explanations. Visit another lesson and return to check session progress. Verify Retry Practice resets only the selected quiz.
3. From Week 11, open Drawing, choose each shape and a fill color, then resize or cover and uncover the window. Confirm the shape repaints. Open the existing MDI demo afterward.
4. From Week 14, open DataRow Practice. Add a sample, change the score of one baseline row, delete a different baseline row, and observe all four states and their values. Test Accept, Reject and Reset. Verify the SQLite records grid still shows the real rows.
5. Build with native Windows MSBuild, extract the generated Release ZIP, and repeat the Catch Game and SQLite checks offline.

## Task 5 · Sidebar and editor navigation

- `frmMain.Designer.vb` reserves the header and bottom profile space before docking the scrollable navigation panel. The navigation buttons keep their existing appearance and routing.
- `frmMain.vb` removes the editor confirmation from lesson changes, Overview, and app close. `frmLesson8_Controls.vb` keeps the file replacement confirmation private to Open. Editor tabs share the same document.

Clean cloud Debug and Release builds passed with the existing external build overrides. Both outputs contained the five game assets and the managed and native SQLite libraries. Source checks confirmed the sidebar docking order, all existing routes, and the Open-only confirmation. The two-process SQLite CRUD smoke test also passed. Windows interaction remains unverified.

### Task 5 Windows checks

1. At the minimum window size, expand OOP Concepts and scroll to Animation Catch Game. Confirm the button is fully visible and opens the game while the profile footer stays fixed. Check Weeks 9–15 and the SQLite records screen. Repeat after maximizing and restoring the window.
2. In Week 8, type text, switch tabs, and return. The text should still be present. With unsaved changes, select another lesson or Overview, or close the app. Expect silent discard and check that the saved file still contains its previous contents.
3. Save a TXT and an RTF explicitly and reopen each. With unsaved text, choose another file through Open and verify the replacement confirmation. Cancel and check that the text stays in the editor. Try an invalid RTF and verify the file error and preserved document.

## Task 4 · Weeks 9–15 and SQLite

Based on `main` at `893d886`. The application still targets .NET Framework 4.7.2 and uses the existing WinForms sidebar, Dark Obsidian theme, and Catch Game.

| Requirement | Implementation |
| --- | --- |
| Week 9 | The sidebar displays a pending view. The syllabus lists a midterm and the supplied deck set has no Week 9 presentation. |
| Weeks 10–12 | `frmMain.vb` opens specific tabs in the existing IDE and editor forms. `frmLesson3_IDE.vb` separates the debugging walkthrough and MDI launcher into tabs. `frmLesson8_Controls.vb` selects the existing editor for the Week 12 print exercise. |
| Weeks 13–15 | `frmStudentRecords.vb` hosts the records grid, a DataSet explanation with a live snapshot count, and offline deployment instructions. `StudentRecordsStore.vb` opens a local SQLite connection, initializes its schema, and reads and writes using typed SQL parameters. |
| CRUD and validation | Add, read, select to edit, confirmed delete, literal case-insensitive name search, and refresh. A record includes a student name, assessment, and a score from 0 to 100 with up to two decimal places. The store uses integer hundredths for exact score storage. A revision check prevents stale edits and deletes from overwriting newer changes. |
| First use and persistence | Opening the module first creates `%LOCALAPPDATA%\Echavez_PF101_Project\StudentPerformance.sqlite3`. It preserves existing rows and opens the same file on subsequent launches. The form reports busy, missing dependency, damaged database and file-access errors. |
| Offline distribution | The active `.vbproj` and `packages.lock.json` pin Microsoft.Data.Sqlite, SQLitePCLRaw and support assemblies. The Any CPU build includes both Windows native architectures. `Package-Release.ps1` restores the locked dependencies and checks them, the notices and game assets before replacing a ZIP. |

### Task 4 verification

- Clean Debug and Release builds passed on Linux with the .NET Framework 4.7.2 reference assemblies and external overrides for non-SDK package resolution and resource generation. The source project stays a legacy VB project. Native Windows MSBuild is the distribution build path.
- A two-process VB harness compiled the actual storage code and ran it against SQLite using the same provider and native bundle versions. It verified first-use initialization, add, read, Unicode and literal searches, exact scores, validation, persistence after process restart, update, delete, stale revisions, and invalid or corrupt database paths.
- Both build outputs contained the five unchanged game assets and byte-matched x86 and x64 SQLite DLLs. The packaging script passed an archive-content check with the cloud MSBuild wrapper and rejected a missing x64 DLL while preserving the previous archive. PE inspection confirmed the two native architectures.
- Source inspection checked sidebar routing and reuse of the earlier labs. UI, Windows native loading, and native Windows packaging remain unverified.

### Task 4 Windows checks

1. On the development computer, restore packages and rebuild Debug and Release in Visual Studio 2019 or later. In the sidebar, check Week 9 pending, Weeks 10–12 lab selection, Weeks 13–15 tabs, and continued access to earlier lessons and the Catch Game.
2. In Student Performance Records, add `José O'Neil`, assessment `Quiz 1`, score `99.99` (use the local decimal separator). Search for `JOSÉ`. Select the row, edit it, and confirm it appears after refresh. Exercise No and Yes on delete confirmation. Verify empty names, scores outside 0–100, and scores with excess precision are stopped.
3. Generate the ZIP using [README.md](README.md). On a compatible Windows computer under a fresh standard-user profile, extract the full archive, disconnect from the network, and start the EXE. Check Local AppData before and after the first visit to Week 13. Save a record, restart, and verify the record remains. Check the Week 14 snapshot updates and the Week 15 path matches the saved file. Where available, exercise both x86 and x64 processes.
4. In a disposable Windows profile, test a corrupt or inaccessible database and recovery after resolving the problem. Exercise the earlier MDI, printing, navigation and Catch Game smoke tests below.

The user selected SQLite for this application. The XAMPP screenshots and Inno Setup lab, if the instructor still requires them separately, are separate coursework. The portable ZIP covers the requested offline distribution.

---

## Task 3 · Earlier coursework

Task 3 builds on GitHub `main` at `31bc109`. The coursework changes are in the workspace on `feature/pf101-coursework`. The active application remains a Visual Basic Windows Forms project targeting .NET Framework 4.7.2. The Task 2 Catch Game files and Windows Release packaging script remain as supplied.

## What was implemented

| Requirements | Changes and files |
| --- | --- |
| Week 6 selection, repetition, strings and Date/Time | `frmLesson6_SelectionRepetition.vb` aligns the If and Select Case boundaries, makes signed stepping safe, caps traces at 1,000 passes, and demonstrates Continue While and Exit. It reverses strings by text element with StringBuilder and reports the local time in the date lab. Its designer clarifies what the Exit checkbox checks. |
| Weeks 1 and 2 grading and encapsulation | `frmOrientations.vb` validates final-grade inputs. `frmEncapsulation.vb` handles an oversized deposit without losing the current balance. Both use more readable status colors on the existing dark background. |
| Week 3 IDE and Week 10 debugging | `frmLesson3_IDE.vb` guards a cleared selection, corrects the console sample, and adds a walkthrough using the months array and editor error paths. Weeks 7 and 8 emit related Debug Output. |
| Week 4 form controls | `frmLesson4_Controls.vb` gives the test-window launcher a visible layout row, opens the window by user action, and reapplies the selected properties when reopening it. |
| Week 5 scope, conversions and operators | `frmLesson5_DataHandling.vb` resets the actual Static value, reports UTF-16 code units, handles text concatenation, and guards integer division and modulo. Notes show constants, conditional compilation directives and precedence. |
| Week 7 arrays and collections | `frmLesson7_Arrays.vb` clears and reloads the months ListBox, collects matches in a List(Of Integer), handles decimal-comma input, and computes grid totals from a rectangular Decimal array. Accumulation overflow reports an error. |
| Week 8 dialogs, editing and controls | `frmLesson8_Controls.vb` adds a ListView mode selector and protects unsaved editing and failed file reads. `frmMain.vb` honors the editor’s save/discard/cancel choice during navigation and close, and retains the current view if the next view fails to initialize. |
| Week 11 MDI and Week 12 printing | `frmLesson3_IDE.vb` launches an MDI parent with a MenuStrip, multiple editable children and Window commands. `ThemeManager.vb` keeps MDI child window chrome and continues to theme their contents. `frmLesson8_Controls.vb` adds native Print and Print Preview for paginated plain text. |
| Requirements tracking | `PROJECT_AUDIT.md` updates the coverage checklist and retains links to all 15 decks and the syllabus. This file records work and verification. |

## Verification performed in the cloud

| Check | Result |
| --- | --- |
| Clean Debug and Release | Passed with .NET SDK 10.0.404, the installed 4.7.2 reference assemblies, and the existing external resource override. Outputs and intermediate files were placed outside the repository. |
| Artifacts and project resources | Both builds produced the EXE and its config. All five runtime assets matched their source bytes. All declared compile, embedded resource and content files resolved. The project target remains 4.7.2. |
| Navigation and event wiring | Static inspection mapped all 12 sidebar routes to their original child forms and confirmed the Overview and OOP group handlers. Builds compiled the event references for the modified forms. |
| Weeks 5–7 logic | A temporary VB harness ran the actual handlers with stub controls. It covered zero and negative steps, reversed and mismatched ranges, post-test behavior, 1,000/1,001 passes, extreme 32-bit integers, Continue/Exit, grade boundary agreement, surrogate-pair reversal, Static reset, whitespace as a Char, concatenation, integer division or modulo edge cases, both score input formats, months load/clear, matrix totals and matrix overflow. |
| Scope and regressions | `git diff --check` passed. Catch Game sources, assets, project and solution manifests, generated Windows build files, and Release script match the baseline. |
| Windows UI | Pending for Task 3. Cloud compilation and source checks did not run the Windows UI, dialogs, GDI+ printing or game loop. |

## Windows smoke tests

Use the Visual Studio .NET desktop workload and the .NET Framework 4.7.2 Developer Pack. In an IDE that does not open the `.slnx`, open the [nested project](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.vbproj) directly. Rebuild Debug and Release using Any CPU.

1. **Navigation and existing demos.** Open every sidebar entry including all four OOP topics. Check Overview, tab labels, keyboard tab order, dark contrast, and alternate DPI. In Week 4, open the live test window and change border, opacity and TopMost. Navigate away and verify the auxiliary window closes. Enter out-of-range final grades and attempt an overflowing bank deposit. Confirm the active view and selected sidebar entry agree.
2. **Week 5.** Increment the Static counter twice, reset it and confirm the next click shows 1. Concatenate `Visual ` and `Basic`. Check `-2147483648 \ -1`, a divisor of `0.4`, and an operand outside the rounded 32-bit range. Convert a single space to Char and look for `U+0020`.
3. **Week 6.** Evaluate `96.995` in both decision modes and confirm 1.25. Try `5, 1, -2` in pre-test Do and verify 5, 3, 1 with sum 9. Try `1, 10, -1` and verify zero values in pre-test Do. Try `8, 2, 1` and verify one value in post-test Do. Try a range with more than 1,000 passes and verify the lab returns promptly. Try While with `1, 5, 1` and confirm both even values are skipped. Enable Exit and check a range through 7.
4. **Week 7.** Load, select and clear the months. Enter `1,5; 1,5; 2,5` on a comma-decimal system and find both matches for `1,5`. Fill the 3×4 grid with 1–12 and verify row totals 10, 26, 42, column totals 15, 18, 21, 24 and grand total 78. Check invalid cells and Reset.
5. **Week 8.** Open and save TXT and RTF. Check formatting, clipboard, Undo, and Find. Use the Task 5 Windows checks for Open and navigation behavior. Switch the control browser between Details and List and select a different tree node.
6. **Weeks 10–12.** Follow the debugger walkthrough in IDE Basics or Week 10, including Locals and Debug Output. In the MDI lab, create two distinct notes, switch between them in the Window menu, cascade, tile and close each. In the text editor, preview enough plain text for multiple pages and print to Microsoft Print to PDF. Check page breaks and ensure a second preview starts from page one. Check Cancel and the error path without an available printer.
7. **Catch Game and portable Release.** Generate the ZIP using [the Windows packaging instructions](README.md), extract it to a fresh directory and run the EXE. Check overview animation and all three sprites. Check movement, scoring, lives, restart and leaving the game while it runs.

## Task 3 assignment follow-up

- The supplied syllabus asks for a portfolio compilation and a final defense. Collect the actual submitted console and months lab evidence, the later debugger and printing/MDI outputs, and other section-specific activities.
- See Task 4 above for the SQLite adaptation and the remaining evidence for the original XAMPP and installer coursework.
