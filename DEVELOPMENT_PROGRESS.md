# PF101 development progress

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
6. **Weeks 10–12.** Follow the debugger walkthrough in IDE Basics, including Locals and Debug Output. In the MDI lab, create two distinct notes, switch between them in the Window menu, cascade, tile and close each. In the text editor, preview enough plain text for multiple pages and print to Microsoft Print to PDF. Check page breaks and ensure a second preview starts from page one. Check Cancel and the error path without an available printer.
7. **Catch Game and portable Release.** Generate the ZIP using [the Windows packaging instructions](README.md), extract it to a fresh directory and run the EXE. Check overview animation and all three sprites. Check movement, scoring, lives, restart and leaving the game while it runs.

## Remaining assignment decisions

- The supplied syllabus asks for a portfolio compilation and a final defense. Collect the actual submitted console and months lab evidence, the later debugger and printing/MDI outputs, and other section-specific activities.
- The Week 13 XAMPP connection deck explicitly calls for screenshots of the running service, database/table and successful connection, plus a deliberate connection error and recovery. The syllabus names SQL Server/ADO.NET/ODBC. Confirm which provider the instructor expects, whether data access and CRUD belong in this app, and whether separate previously completed work satisfies the lab.
- The Weeks 14–15 data-driven and Inno Setup activities still need their required artifacts. Their dataset, installer and in-app scope depend on the section’s assignment brief. The supplied PowerPoints and syllabus leave those implementation choices open.
