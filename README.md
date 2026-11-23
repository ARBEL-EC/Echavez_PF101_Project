# ECHAVEZ_PF101_PROJECT

PF101 Object-Oriented Programming portfolio by **Arlvel L. Echavez**, BSIT SBIT-2E, Quezon City University. Explore VB.NET, Windows Forms, and SQLite through weekly labs, practice quizzes, and the Animation Catch Game.

## Run on Windows

Use a compatible Windows 10 or 11 PC with x86 or x64 support and **.NET Framework 4.7.2 or a compatible later 4.x release**. The distributed app runs offline with its bundled SQLite libraries. The recipient needs no Visual Studio, Inno Setup, NuGet, or database server.

- **Installer.** Run `ECHAVEZ_PF101_PROJECT_Setup.exe` and open **ECHAVEZ_PF101_PROJECT** from Start. Setup installs for the current user and offers a desktop shortcut. If Setup reports that the required .NET Framework is missing, install an appropriate version for the PC and rerun Setup. [Microsoft .NET Framework downloads](https://dotnet.microsoft.com/download/dotnet-framework)
- **Portable ZIP.** Extract all of `ECHAVEZ_PF101_PROJECT_App.zip` to a new folder and run `ECHAVEZ_PF101_PROJECT.exe`. Keep the `Assets` and `runtimes` folders beside the executable.

## Evaluate the portfolio

1. Open **Overview** for shortcuts or **Project Information → Course Coverage** for the learning objective for each week.
2. Under **Course Lessons**, expand **Week 2 · OOP Concepts** for the four OOP labs. Weeks 3–15 follow in order. The Week 9 page explains that the supplied midterm materials are pending.
3. Under **Practice & Activities**, open **Midterm Practice** or **Finals Practice** for review questions and explanations. In **Animation Catch Game**, choose a difficulty and start. Move with A/D or the arrow keys to collect food and avoid hazards, and open **Top 10** to see saved scores.
4. Open **Week 13 · SQLite Records** and add a name, assessment, and score from 0 to 100. Select a row to edit or delete it, or search by student name. Week 14 shows DataSets and isolated DataRow states. Week 15 explains offline deployment.

Each Windows account has its own `StudentPerformance.sqlite3` and `CatchGameScores.sqlite3` under `%LOCALAPPDATA%\Echavez_PF101_Project`. The app creates each database on first use. Setup, updates, and uninstall leave both databases in place.

## Build the active project

On the development PC, install the Visual Studio **.NET desktop development** workload and **.NET Framework 4.7.2 Developer Pack**. Use Visual Studio 2019 or later with NuGet access. An IDE with `.slnx` support can open the solution. Otherwise open the nested `.vbproj` directly. [Active solution](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.slnx) · [Active VB project](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.vbproj)

Restore the pinned NuGet packages and rebuild **Debug** and **Release**, **Any CPU**. The package lock pins Microsoft.Data.Sqlite **10.0.15** and SQLitePCLRaw **2.1.14**. The build generates the executable configuration with its binding redirects. Both builds copy the five game assets, SQLite notices, managed dependencies, and the x86 and x64 SQLite DLLs. Keep the supplied native directories intact so SQLite can select the library for the current process.

## Create the submission files

From the repository root in a **Visual Studio Developer PowerShell on Windows**, build the portable Release ZIP.

```powershell
.\Package-Release.ps1 -OutputPath '.\dist\ECHAVEZ_PF101_PROJECT_App.zip'
```

For the ZIP and installer together, install **Inno Setup 6.3 or later** and point `-InnoSetupPath` at its compiler. If `ISCC.exe` is on PATH, omit that argument. [Inno Setup downloads](https://jrsoftware.org/isdl.php)

```powershell
.\Package-Release.ps1 -OutputPath '.\dist\ECHAVEZ_PF101_PROJECT_App.zip' -BuildInstaller `
    -InnoSetupPath 'C:\Program Files (x86)\Inno Setup 6\ISCC.exe'
```

The script restores locked packages, rebuilds the nested project in temporary folders, and checks the runtime files before packaging. The ZIP and Setup use the same staged payload. Setup is written next to the ZIP. The script excludes build caches, debug symbols, source, and database files. [Inno Setup script](Installer/PF101.iss)

From a Git checkout with the intended submission commit checked out, archive just the active project, packaging scripts, and documentation with the course references. Run this after generating or creating the `dist` folder.

```powershell
git archive --format=zip --output=dist/ECHAVEZ_PF101_PROJECT_Source.zip HEAD -- `
    AGENTS.md README.md FINAL_TEST_CHECKLIST.md DEVELOPMENT_PROGRESS.md PROJECT_AUDIT.md BUG_AUDIT.md `
    Package-Release.ps1 Installer 'OOP PPT' `
    ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.slnx `
    ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT `
    ':(exclude,icase,glob)**/.vs/**' ':(exclude,icase,glob)**/bin/**' `
    ':(exclude,icase,glob)**/obj/**' ':(exclude,icase,glob)**/*.user'
```

Use the Windows checklist on a fresh standard-user account before handing over the source ZIP, portable ZIP, and any compiled Setup. The Linux verification build uses resource-generation overrides. Build and validate the submission binaries with native Windows MSBuild and Inno Setup. [FINAL_TEST_CHECKLIST.md](FINAL_TEST_CHECKLIST.md)
