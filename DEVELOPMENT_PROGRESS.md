# PF101 development progress

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
5. **Week 8.** Open and save TXT and RTF. Check formatting, clipboard, Undo, and Find. With unsaved text, try Open, sidebar navigation, Overview and closing the app. Exercise Save, Discard and Cancel, including cancelling Save As. Try an invalid RTF and verify prior text remains. Switch the control browser between Details and List and select a different tree node.
6. **Weeks 10–12.** Follow the debugger walkthrough in IDE Basics or Week 10, including Locals and Debug Output. In the MDI lab, create two distinct notes, switch between them in the Window menu, cascade, tile and close each. In the text editor, preview enough plain text for multiple pages and print to Microsoft Print to PDF. Check page breaks and ensure a second preview starts from page one. Check Cancel and the error path without an available printer.
7. **Catch Game and portable Release.** Generate the ZIP using [the Windows packaging instructions](README.md), extract it to a fresh directory and run the EXE. Check overview animation and all three sprites. Check movement, scoring, lives, restart and leaving the game while it runs.

## Task 3 assignment follow-up

- The supplied syllabus asks for a portfolio compilation and a final defense. Collect the actual submitted console and months lab evidence, the later debugger and printing/MDI outputs, and other section-specific activities.
- See Task 4 above for the SQLite adaptation and the remaining evidence for the original XAMPP and installer coursework.
