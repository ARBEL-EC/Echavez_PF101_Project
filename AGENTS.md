# Project Context: ECHAVEZ_PF101_PROJECT

## 1. Overview & Purpose

- **Application:** `ECHAVEZ_PF101_PROJECT` (VB.NET Windows Forms desktop application)
- **Course:** PF 101 – Object-Oriented Programming (Quezon City University, Section SBIT-2E, Student: Arlvel L. Echavez)
- **Objective:** Final course portfolio featuring interactive OOP/VB.NET curriculum modules (Weeks 1–8) and a 60 FPS "Animation Catch Game".
- **Submission:** Share with a class representative and professor who may use an older Visual Studio version (e.g., VS 2017/2019) or older .NET runtime.

## 2. Solution & File Structure

Expected structure according to the project brief (inspect the actual solution before assuming every file exists):

```text
ECHAVEZ_PF101_PROJECT/
├── ECHAVEZ_PF101_PROJECT.sln
└── ECHAVEZ_PF101_PROJECT/
    ├── ECHAVEZ_PF101_PROJECT.vbproj
    ├── ThemeManager.vb
    ├── frmMain.vb
    ├── frmOrientations.vb
    ├── frmClassesObjects.vb
    ├── frmEncapsulation.vb
    ├── frmInheritance.vb
    ├── frmPolymorphism.vb
    ├── frmLesson3_IDE.vb
    ├── frmLesson4_Controls.vb
    ├── frmLesson5_DataHandling.vb
    ├── frmLesson6_SelectionRepetition.vb
    ├── frmLesson7_Arrays.vb
    ├── frmLesson8_Controls.vb
    ├── frmCatchGame.vb
    └── Assets/
        ├── background.gif
        ├── player.png
        ├── food.png
        └── bomb.png / hazard.png
```

- `ThemeManager.vb`: Centralized Dark Obsidian theme engine.
- `frmMain.vb`: Main shell, sidebar navigation, Overview dashboard, and child-form loader.
- `frmLesson7_Arrays.vb`: Five tabs: Lesson Notes, Months Lab, 1D Array Analysis, 2D Matrix Grid, PPT Reference.
- `frmLesson8_Controls.vb`: Four tabs: Lesson Notes, Text Editor & Dialogs, TreeView & ListView, PPT Reference.
- `frmCatchGame.vb`: Arcade catch game targeting 60 FPS.
- `Assets/`: Runtime media; ensure assets are copied to the output directory.

## 3. Core Architecture & Rendering Rules

### Anti-Flicker & Dark Titlebar (`frmMain.vb`)

- Uses `WS_EX_COMPOSITED` (`&H2000000`) via `CreateParams` in `frmMain` and `frmCatchGame`.
- Uses `DwmSetWindowAttribute` (attributes `20` and `35`) for Windows 10/11 dark titlebars (`#121316`).
- `LoadView(childForm)` freezes painting via `SendMessage(pnlContent.Handle, WM_SETREDRAW, False, 0)` during form swaps to avoid white flashes. Verify painting is re-enabled even if a form swap fails.

### Color Palette

- Background: `#0C0D0F` / `RGB(15, 17, 23)`
- Sidebar: `#121316` / `RGB(18, 20, 28)`
- Cards: `#181A1E` / `RGB(30, 34, 45)`
- Text: `#F8FAFC` (primary), `#8E95A2` (muted), `#22C55E` (accent green)

### Overview Animated Wallpaper (`frmMain.vb`)

- `pnlOverview` is a designer-built panel within `frmMain`.
- **Do not reparent `pnlSidebar` or `pnlContent`.** Reparenting has previously broken WinForms docking and caused a blank gray screen.
- `picBg` loads `Assets\background.gif` into an `IO.MemoryStream`, animated with `ImageAnimator.Animate`.
- `LayoutOverviewBackground()` sets:

```vb
picBg.SetBounds(-pnlSidebar.Width, 0, pnlOverview.ClientSize.Width + pnlSidebar.Width, pnlOverview.ClientSize.Height)
```

- This layout visually extends the wallpaper behind the sidebar and clips out a bottom-left `imgflip.com` watermark.

### Image Asset Rules

- **Do not serialize images into `.resx` via `PictureBox.Image` in the WinForms Designer.** That has previously led to `System.IO.FileLoadException` involving `System.Resources.Extensions`.
- Load sprites at runtime from `IO.Path.Combine(Application.StartupPath, "Assets", ...)`.

## 4. Known Issues & Current Tasks for Codex

### Task 1 — Release Build Hazard Sprite Mismatch (`frmCatchGame.vb`)

- The source `Assets/` reportedly contains `bomb.png`, while a previous rename to `hazard.png` happened only in `bin\Debug\Assets`.
- A Release build has previously failed with `Could not find file ... hazard.png`.
- **Required fix:** Make the asset loader search for `hazard.png` first, then fall back to `bomb.png`.
- For file-backed images, clone a loaded bitmap to avoid keeping the original file locked, e.g., load with `Image.FromFile(path)` inside a `Using` block and construct `New Bitmap(original)`.
- Verify source PNG files are actually encoded as PNG, not WebP files renamed to `.png` (which may cause GDI+ image-loading errors).
- Inspect current asset paths before modifying code; do not assume the reported state is still current.

### Task 2 — Legacy Visual Studio / Professor Environment Compatibility

- Inspect the actual `.vbproj` and `.sln` before choosing a target framework or changing project format.
- Aim for compatibility with older Visual Studio installations (especially VS 2019, and VS 2017 where feasible) and standard .NET Framework `4.7.2` / `4.8` runtimes, subject to the existing project's dependencies.
- Avoid introducing unnecessary new SDK/project-format requirements or unsupported Visual Basic language features.
- Ensure assets have appropriate project entries, including:

```xml
<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
```

- Check that both `Debug` and `Release` have their required assets and can build and run.
- If older Visual Studio compatibility conflicts with dependencies or features, explain the tradeoff before making breaking changes.

## 5. Working Rules for Codex

1. **Continue the existing project; do not regenerate it from scratch.**
2. Inspect the actual solution and files first. Treat the structure above as a project brief, not a verified inventory.
3. Read the provided PowerPoints as the course requirements. Map each requirement to its current implementation status (complete, partial, missing, or unclear).
4. Preserve existing functional UI, forms, themes, and navigation. Avoid rewriting unrelated code.
5. Do not migrate to C#, WPF, or a newer .NET architecture unless explicitly requested.
6. Make changes in source files and the project manifest, not only under `bin/Debug` or `bin/Release`.
7. Prefer targeted fixes; verify designer-generated files remain consistent with their forms.
8. Build in Debug and Release where supported, verify assets are copied, and report exactly what could and could not be tested.
9. Do not claim that a build works on VS 2017/2019 or a professor's machine unless actually validated there; instead state the compatibility evidence and limitations.
10. Keep a concise change log listing files modified, features completed, and outstanding issues.

## 6. Recommended First Codex Session

1. Inspect the solution, project configuration, form classes, and asset directory.
2. Review all supplied PowerPoints and extract a requirements checklist.
3. Report what is implemented versus what is missing.
4. Prioritize the hazard sprite fallback and asset-copy configuration.
5. Check current target framework and legacy Visual Studio compatibility.
6. Implement the remaining portfolio requirements in small, verifiable steps.
7. Build/test Debug and Release if suitable Windows/.NET tooling is available; document any unverified steps.
