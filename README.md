# Echavez_PF101_Project

## Build on Windows

Install the Visual Studio **.NET desktop development** workload and the **.NET Framework 4.7.2 Developer Pack**. Open the solution in a Visual Studio version that supports `.slnx`. In Visual Studio 2017 or 2019, open the nested [VB project](ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT/ECHAVEZ_PF101_PROJECT.vbproj) directly.

Build **Debug** and **Release** with **Any CPU**. Both configurations copy `background.gif`, `player.png`, `food.png`, `hazard.png`, and `Bomb.png` to `Assets` next to the executable. The Catch Game prefers `hazard.png` and tries `Bomb.png` if the first image is missing or unreadable.

## Package a Windows Release

From the repository root in a Visual Studio Developer PowerShell, run the packaging script with a destination ZIP path.

```powershell
.\Package-Release.ps1 -OutputPath "$env:TEMP\ECHAVEZ_PF101_PROJECT_App.zip"
```

The script rebuilds the nested project into a fresh temporary directory, checks the executable, configuration and assets, then archives the complete build output. A successful run replaces an existing ZIP at the requested destination. Distribute the freshly generated ZIP. Recipients should extract the whole archive before running `ECHAVEZ_PF101_PROJECT.exe` on Windows with .NET Framework 4.7.2 or a supported later 4.x runtime.

## Windows smoke test

1. Rebuild Debug and Release in Visual Studio. Check the five assets next to each executable and open the Catch Game in both configurations.
2. Generate the ZIP, extract it to a new folder, and run the extracted executable. Check the animated overview, player, food, and hazard art. Start and restart the game, move with the arrows and A/D, catch food, and confirm hitting a hazard removes a life.
3. In separate copies of the extracted folder, remove `hazard.png` or replace it with an invalid image. Reopen the app and verify that `Bomb.png` appears without a warning. With both hazard files unavailable, verify that the warning appears and the game continues with a crimson fallback. While the game is open, check that the sprite files can be renamed in a disposable test copy.

The Linux cloud build can verify compilation, asset copying, and file formats. Run these smoke tests on Windows to verify WinForms and GDI+ behavior, including compatibility with the intended Visual Studio installation.
