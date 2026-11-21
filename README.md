# Echavez_PF101_Project

## Build on Windows

Install the Visual Studio **.NET desktop development** workload and the **.NET Framework 4.7.2 Developer Pack**. Use Visual Studio 2019 or later for the NuGet restore and native-library copy. Open the solution in a version that supports `.slnx`, or open the nested [VB project](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.vbproj) directly. Restore NuGet packages from nuget.org on the development machine. The checked-in lock file records the versions and content hashes.

Build **Debug** and **Release** with **Any CPU**. Both configurations copy `background.gif`, `player.png`, `food.png`, `hazard.png`, and `Bomb.png` to `Assets` next to the executable. The Catch Game prefers `hazard.png` and tries `Bomb.png` if the first image is missing or unreadable.

## Weeks 9–15

- **Week 9** marks the midterm materials pending.
- **Weeks 10–12** open the existing debugging walkthrough, MDI lab and print editor from the sidebar.
- **Week 13** opens Student Performance Records. Enter a name, assessment and a score from 0 to 100 with up to two decimal places. Select a saved row to edit or delete it. Search matches a literal substring of the student name, ignoring case. Show All / Refresh clears the search.
- **Weeks 14–15** open the same module at its DataSet and offline-deployment tabs. The grid displays a disconnected DataTable, while parameterized commands write changes back to SQLite.

The database is created the first time Student Performance Records opens under each Windows account. The file is stored at `%LOCALAPPDATA%\Echavez_PF101_Project\StudentPerformance.sqlite3`. Replacing or moving an extracted app folder keeps records available to the same Windows account.

## Package a Windows Release

From the repository root in a Visual Studio Developer PowerShell, run the packaging script with a destination ZIP path.

```powershell
.\Package-Release.ps1 -OutputPath "$env:TEMP\ECHAVEZ_PF101_PROJECT_App.zip"
```

The script restores the locked packages and rebuilds into a fresh temporary directory. It checks the executable, config, game assets, third-party notices, managed SQLite dependencies and both native `e_sqlite3.dll` files before creating the archive. A successful run replaces an existing ZIP at the requested destination.

Distribute the freshly generated ZIP. On the recipient’s computer, extract the entire archive and run `ECHAVEZ_PF101_PROJECT.exe` with .NET Framework 4.7.2 or a supported later 4.x runtime. Keep the `runtimes/win-x86/native` and `runtimes/win-x64/native` folders in place. The Any CPU build uses the native SQLite binary that matches the process architecture. The recipient can run offline without Visual Studio, NuGet, XAMPP or a database server.

## Windows smoke test

1. Rebuild Debug and Release in Visual Studio. Check the five assets next to each executable and open the Catch Game in both configurations.
2. Generate the ZIP, extract it to a new folder, and run the extracted executable. Check the animated overview, player, food, and hazard art. Start and restart the game, move with the arrows and A/D, catch food, and confirm hitting a hazard removes a life.
3. In separate copies of the extracted folder, remove `hazard.png` or replace it with an invalid image. Reopen the app and verify that `Bomb.png` appears without a warning. With both hazard files unavailable, verify that the warning appears and the game continues with a crimson fallback. While the game is open, check that the sprite files can be renamed in a disposable test copy.

4. On Windows, open each of Weeks 9–15 and verify its starting view. In Week 13, add a record, select it and save an edit, search by name, and exercise both responses to the delete confirmation. Open Week 14 and compare the snapshot row count with the grid. Close and reopen the app to confirm persistence.
5. Test the extracted Windows ZIP offline under a fresh standard-user account. Open Week 13 and confirm that the database is created in Local AppData. Exercise both process architectures on supported Windows targets. In a disposable test profile, check the error shown when the database location is inaccessible or corrupt.

The Linux cloud build can verify compilation, asset copying, and file formats. Run these smoke tests on Windows to verify WinForms and GDI+ behavior, including compatibility with the intended Visual Studio installation.
