<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlProfile = New System.Windows.Forms.Panel()
        Me.lblAvatar = New System.Windows.Forms.Label()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.lblProfileStatus = New System.Windows.Forms.Label()
        Me.pnlNavList = New System.Windows.Forms.Panel()
        Me.btnNavGame = New System.Windows.Forms.Button()
        Me.btnNavLesson8 = New System.Windows.Forms.Button()
        Me.btnNavLesson7 = New System.Windows.Forms.Button()
        Me.btnNavLesson6 = New System.Windows.Forms.Button()
        Me.btnNavLesson5 = New System.Windows.Forms.Button()
        Me.btnNavLesson4 = New System.Windows.Forms.Button()
        Me.btnNavLesson3 = New System.Windows.Forms.Button()
        Me.pnlNavOOPChildren = New System.Windows.Forms.Panel()
        Me.btnNavPolymorphism = New System.Windows.Forms.Button()
        Me.btnNavInheritance = New System.Windows.Forms.Button()
        Me.btnNavEncapsulation = New System.Windows.Forms.Button()
        Me.btnNavClasses = New System.Windows.Forms.Button()
        Me.btnNavOOPConcepts = New System.Windows.Forms.Button()
        Me.btnNavOrientations = New System.Windows.Forms.Button()
        Me.btnNavOverview = New System.Windows.Forms.Button()
        Me.lblSidebarCategory = New System.Windows.Forms.Label()
        Me.lblSidebarTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlOverview = New System.Windows.Forms.Panel()
        Me.picBg = New System.Windows.Forms.PictureBox()
        Me.tblCards = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCardName = New System.Windows.Forms.Panel()
        Me.lblCardNameSub = New System.Windows.Forms.Label()
        Me.lblCardNameMain = New System.Windows.Forms.Label()
        Me.lblCardNameTitle = New System.Windows.Forms.Label()
        Me.pnlCardCourse = New System.Windows.Forms.Panel()
        Me.lblCardCourseSub = New System.Windows.Forms.Label()
        Me.lblCardCourseMain = New System.Windows.Forms.Label()
        Me.lblCardCourseTitle = New System.Windows.Forms.Label()
        Me.pnlCardModules = New System.Windows.Forms.Panel()
        Me.lblCardModulesSub = New System.Windows.Forms.Label()
        Me.lblCardModulesMain = New System.Windows.Forms.Label()
        Me.lblCardModulesTitle = New System.Windows.Forms.Label()
        Me.pnlCardTheme = New System.Windows.Forms.Panel()
        Me.lblCardThemeSub = New System.Windows.Forms.Label()
        Me.lblCardThemeMain = New System.Windows.Forms.Label()
        Me.lblCardThemeTitle = New System.Windows.Forms.Label()
        Me.lblOverviewHeader = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlProfile.SuspendLayout()
        Me.pnlNavList.SuspendLayout()
        Me.pnlNavOOPChildren.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlOverview.SuspendLayout()
        CType(Me.picBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblCards.SuspendLayout()
        Me.pnlCardName.SuspendLayout()
        Me.pnlCardCourse.SuspendLayout()
        Me.pnlCardModules.SuspendLayout()
        Me.pnlCardTheme.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.pnlProfile)
        Me.pnlSidebar.Controls.Add(Me.pnlNavList)
        Me.pnlSidebar.Controls.Add(Me.lblSidebarCategory)
        Me.pnlSidebar.Controls.Add(Me.lblSidebarTitle)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(12, 16, 12, 14)
        Me.pnlSidebar.Size = New System.Drawing.Size(240, 750)
        Me.pnlSidebar.TabIndex = 1
        '
        'pnlProfile
        '
        Me.pnlProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlProfile.Controls.Add(Me.lblAvatar)
        Me.pnlProfile.Controls.Add(Me.lblProfileName)
        Me.pnlProfile.Controls.Add(Me.lblProfileStatus)
        Me.pnlProfile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlProfile.Location = New System.Drawing.Point(12, 682)
        Me.pnlProfile.Name = "pnlProfile"
        Me.pnlProfile.Padding = New System.Windows.Forms.Padding(8)
        Me.pnlProfile.Size = New System.Drawing.Size(216, 54)
        Me.pnlProfile.TabIndex = 2
        '
        'lblAvatar
        '
        Me.lblAvatar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvatar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblAvatar.Location = New System.Drawing.Point(10, 10)
        Me.lblAvatar.Name = "lblAvatar"
        Me.lblAvatar.Size = New System.Drawing.Size(24, 30)
        Me.lblAvatar.TabIndex = 3
        Me.lblAvatar.Text = "●"
        Me.lblAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfileName
        '
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblProfileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblProfileName.Location = New System.Drawing.Point(38, 8)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(47, 17)
        Me.lblProfileName.TabIndex = 4
        Me.lblProfileName.Text = "ARBEL"
        '
        'lblProfileStatus
        '
        Me.lblProfileStatus.AutoSize = True
        Me.lblProfileStatus.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblProfileStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblProfileStatus.Location = New System.Drawing.Point(38, 27)
        Me.lblProfileStatus.Name = "lblProfileStatus"
        Me.lblProfileStatus.Size = New System.Drawing.Size(72, 13)
        Me.lblProfileStatus.TabIndex = 5
        Me.lblProfileStatus.Text = "BSIT Student"
        '
        'pnlNavList
        '
        Me.pnlNavList.AutoScroll = True
        Me.pnlNavList.BackColor = System.Drawing.Color.Transparent
        Me.pnlNavList.Controls.Add(Me.btnNavGame)
        Me.pnlNavList.Controls.Add(Me.btnNavLesson8)
        Me.pnlNavList.Controls.Add(Me.btnNavLesson7)
        Me.pnlNavList.Controls.Add(Me.btnNavLesson6)
        Me.pnlNavList.Controls.Add(Me.btnNavLesson5)
        Me.pnlNavList.Controls.Add(Me.btnNavLesson4)
        Me.pnlNavList.Controls.Add(Me.btnNavLesson3)
        Me.pnlNavList.Controls.Add(Me.pnlNavOOPChildren)
        Me.pnlNavList.Controls.Add(Me.btnNavOOPConcepts)
        Me.pnlNavList.Controls.Add(Me.btnNavOrientations)
        Me.pnlNavList.Controls.Add(Me.btnNavOverview)
        Me.pnlNavList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavList.Location = New System.Drawing.Point(12, 81)
        Me.pnlNavList.Name = "pnlNavList"
        Me.pnlNavList.Size = New System.Drawing.Size(216, 655)
        Me.pnlNavList.TabIndex = 6
        '
        'btnNavGame
        '
        Me.btnNavGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavGame.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavGame.FlatAppearance.BorderSize = 0
        Me.btnNavGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavGame.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavGame.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavGame.Location = New System.Drawing.Point(0, 536)
        Me.btnNavGame.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavGame.Name = "btnNavGame"
        Me.btnNavGame.Size = New System.Drawing.Size(216, 40)
        Me.btnNavGame.TabIndex = 4
        Me.btnNavGame.Text = "  Animation Catch Game 🍎"
        Me.btnNavGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavGame.UseVisualStyleBackColor = False
        '
        'btnNavLesson8
        '
        Me.btnNavLesson8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLesson8.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavLesson8.FlatAppearance.BorderSize = 0
        Me.btnNavLesson8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLesson8.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavLesson8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavLesson8.Location = New System.Drawing.Point(0, 496)
        Me.btnNavLesson8.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavLesson8.Name = "btnNavLesson8"
        Me.btnNavLesson8.Size = New System.Drawing.Size(216, 40)
        Me.btnNavLesson8.TabIndex = 5
        Me.btnNavLesson8.Text = "  Lesson 8: Controls"
        Me.btnNavLesson8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLesson8.UseVisualStyleBackColor = False
        '
        'btnNavLesson7
        '
        Me.btnNavLesson7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLesson7.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavLesson7.FlatAppearance.BorderSize = 0
        Me.btnNavLesson7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLesson7.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavLesson7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavLesson7.Location = New System.Drawing.Point(0, 456)
        Me.btnNavLesson7.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavLesson7.Name = "btnNavLesson7"
        Me.btnNavLesson7.Size = New System.Drawing.Size(216, 40)
        Me.btnNavLesson7.TabIndex = 6
        Me.btnNavLesson7.Text = "  Lesson 7: Arrays"
        Me.btnNavLesson7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLesson7.UseVisualStyleBackColor = False
        '
        'btnNavLesson6
        '
        Me.btnNavLesson6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLesson6.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavLesson6.FlatAppearance.BorderSize = 0
        Me.btnNavLesson6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLesson6.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavLesson6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavLesson6.Location = New System.Drawing.Point(0, 416)
        Me.btnNavLesson6.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavLesson6.Name = "btnNavLesson6"
        Me.btnNavLesson6.Size = New System.Drawing.Size(216, 40)
        Me.btnNavLesson6.TabIndex = 7
        Me.btnNavLesson6.Text = "  Lesson 6: Selection && Loops"
        Me.btnNavLesson6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLesson6.UseVisualStyleBackColor = False
        '
        'btnNavLesson5
        '
        Me.btnNavLesson5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLesson5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavLesson5.FlatAppearance.BorderSize = 0
        Me.btnNavLesson5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLesson5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavLesson5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavLesson5.Location = New System.Drawing.Point(0, 376)
        Me.btnNavLesson5.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavLesson5.Name = "btnNavLesson5"
        Me.btnNavLesson5.Size = New System.Drawing.Size(216, 40)
        Me.btnNavLesson5.TabIndex = 8
        Me.btnNavLesson5.Text = "  Lesson 5: Data Handling"
        Me.btnNavLesson5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLesson5.UseVisualStyleBackColor = False
        '
        'btnNavLesson4
        '
        Me.btnNavLesson4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLesson4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavLesson4.FlatAppearance.BorderSize = 0
        Me.btnNavLesson4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLesson4.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavLesson4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavLesson4.Location = New System.Drawing.Point(0, 336)
        Me.btnNavLesson4.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavLesson4.Name = "btnNavLesson4"
        Me.btnNavLesson4.Size = New System.Drawing.Size(216, 40)
        Me.btnNavLesson4.TabIndex = 9
        Me.btnNavLesson4.Text = "  Lesson 4: Designing UI"
        Me.btnNavLesson4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLesson4.UseVisualStyleBackColor = False
        '
        'btnNavLesson3
        '
        Me.btnNavLesson3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavLesson3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavLesson3.FlatAppearance.BorderSize = 0
        Me.btnNavLesson3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavLesson3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavLesson3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavLesson3.Location = New System.Drawing.Point(0, 296)
        Me.btnNavLesson3.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavLesson3.Name = "btnNavLesson3"
        Me.btnNavLesson3.Size = New System.Drawing.Size(216, 40)
        Me.btnNavLesson3.TabIndex = 10
        Me.btnNavLesson3.Text = "  Lesson 3: IDE Basics"
        Me.btnNavLesson3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavLesson3.UseVisualStyleBackColor = False
        '
        'pnlNavOOPChildren
        '
        Me.pnlNavOOPChildren.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlNavOOPChildren.Controls.Add(Me.btnNavPolymorphism)
        Me.pnlNavOOPChildren.Controls.Add(Me.btnNavInheritance)
        Me.pnlNavOOPChildren.Controls.Add(Me.btnNavEncapsulation)
        Me.pnlNavOOPChildren.Controls.Add(Me.btnNavClasses)
        Me.pnlNavOOPChildren.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNavOOPChildren.Location = New System.Drawing.Point(0, 120)
        Me.pnlNavOOPChildren.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlNavOOPChildren.Name = "pnlNavOOPChildren"
        Me.pnlNavOOPChildren.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.pnlNavOOPChildren.Size = New System.Drawing.Size(216, 176)
        Me.pnlNavOOPChildren.TabIndex = 21
        '
        'btnNavPolymorphism
        '
        Me.btnNavPolymorphism.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavPolymorphism.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavPolymorphism.FlatAppearance.BorderSize = 0
        Me.btnNavPolymorphism.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavPolymorphism.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavPolymorphism.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavPolymorphism.Location = New System.Drawing.Point(14, 120)
        Me.btnNavPolymorphism.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavPolymorphism.Name = "btnNavPolymorphism"
        Me.btnNavPolymorphism.Size = New System.Drawing.Size(202, 40)
        Me.btnNavPolymorphism.TabIndex = 11
        Me.btnNavPolymorphism.Text = "    Polymorphism"
        Me.btnNavPolymorphism.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavPolymorphism.UseVisualStyleBackColor = False
        '
        'btnNavInheritance
        '
        Me.btnNavInheritance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavInheritance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavInheritance.FlatAppearance.BorderSize = 0
        Me.btnNavInheritance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavInheritance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavInheritance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavInheritance.Location = New System.Drawing.Point(14, 80)
        Me.btnNavInheritance.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavInheritance.Name = "btnNavInheritance"
        Me.btnNavInheritance.Size = New System.Drawing.Size(202, 40)
        Me.btnNavInheritance.TabIndex = 12
        Me.btnNavInheritance.Text = "    Inheritance"
        Me.btnNavInheritance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavInheritance.UseVisualStyleBackColor = False
        '
        'btnNavEncapsulation
        '
        Me.btnNavEncapsulation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavEncapsulation.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavEncapsulation.FlatAppearance.BorderSize = 0
        Me.btnNavEncapsulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavEncapsulation.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavEncapsulation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavEncapsulation.Location = New System.Drawing.Point(14, 40)
        Me.btnNavEncapsulation.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavEncapsulation.Name = "btnNavEncapsulation"
        Me.btnNavEncapsulation.Size = New System.Drawing.Size(202, 40)
        Me.btnNavEncapsulation.TabIndex = 13
        Me.btnNavEncapsulation.Text = "    Encapsulation"
        Me.btnNavEncapsulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavEncapsulation.UseVisualStyleBackColor = False
        '
        'btnNavClasses
        '
        Me.btnNavClasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavClasses.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavClasses.FlatAppearance.BorderSize = 0
        Me.btnNavClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavClasses.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavClasses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavClasses.Location = New System.Drawing.Point(14, 0)
        Me.btnNavClasses.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavClasses.Name = "btnNavClasses"
        Me.btnNavClasses.Size = New System.Drawing.Size(202, 40)
        Me.btnNavClasses.TabIndex = 15
        Me.btnNavClasses.Text = "    Classes && Objects"
        Me.btnNavClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavClasses.UseVisualStyleBackColor = False
        '
        'btnNavOOPConcepts
        '
        Me.btnNavOOPConcepts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavOOPConcepts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavOOPConcepts.FlatAppearance.BorderSize = 0
        Me.btnNavOOPConcepts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavOOPConcepts.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavOOPConcepts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavOOPConcepts.Location = New System.Drawing.Point(0, 80)
        Me.btnNavOOPConcepts.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavOOPConcepts.Name = "btnNavOOPConcepts"
        Me.btnNavOOPConcepts.Size = New System.Drawing.Size(216, 40)
        Me.btnNavOOPConcepts.TabIndex = 14
        Me.btnNavOOPConcepts.Text = "  Lesson 2: OOP Concepts ▾"
        Me.btnNavOOPConcepts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavOOPConcepts.UseVisualStyleBackColor = False
        '
        'btnNavOrientations
        '
        Me.btnNavOrientations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavOrientations.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavOrientations.FlatAppearance.BorderSize = 0
        Me.btnNavOrientations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavOrientations.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavOrientations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavOrientations.Location = New System.Drawing.Point(0, 40)
        Me.btnNavOrientations.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavOrientations.Name = "btnNavOrientations"
        Me.btnNavOrientations.Size = New System.Drawing.Size(216, 40)
        Me.btnNavOrientations.TabIndex = 15
        Me.btnNavOrientations.Text = "  Orientations"
        Me.btnNavOrientations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavOrientations.UseVisualStyleBackColor = False
        '
        'btnNavOverview
        '
        Me.btnNavOverview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavOverview.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavOverview.FlatAppearance.BorderSize = 0
        Me.btnNavOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavOverview.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnNavOverview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnNavOverview.Location = New System.Drawing.Point(0, 0)
        Me.btnNavOverview.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btnNavOverview.Name = "btnNavOverview"
        Me.btnNavOverview.Size = New System.Drawing.Size(216, 40)
        Me.btnNavOverview.TabIndex = 16
        Me.btnNavOverview.Text = "  Overview"
        Me.btnNavOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavOverview.UseVisualStyleBackColor = False
        '
        'lblSidebarCategory
        '
        Me.lblSidebarCategory.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSidebarCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSidebarCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblSidebarCategory.Location = New System.Drawing.Point(12, 51)
        Me.lblSidebarCategory.Name = "lblSidebarCategory"
        Me.lblSidebarCategory.Size = New System.Drawing.Size(216, 30)
        Me.lblSidebarCategory.TabIndex = 17
        Me.lblSidebarCategory.Text = "Lessons"
        '
        'lblSidebarTitle
        '
        Me.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSidebarTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblSidebarTitle.Location = New System.Drawing.Point(12, 16)
        Me.lblSidebarTitle.Name = "lblSidebarTitle"
        Me.lblSidebarTitle.Size = New System.Drawing.Size(216, 35)
        Me.lblSidebarTitle.TabIndex = 18
        Me.lblSidebarTitle.Text = "PF101 OOP"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.pnlOverview)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(240, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1040, 750)
        Me.pnlContent.TabIndex = 19
        '
        'pnlOverview
        '
        Me.pnlOverview.AutoScroll = True
        Me.pnlOverview.Controls.Add(Me.tblCards)
        Me.pnlOverview.Controls.Add(Me.lblOverviewHeader)
        Me.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverview.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverview.Name = "pnlOverview"
        Me.pnlOverview.Padding = New System.Windows.Forms.Padding(36, 28, 36, 28)
        Me.pnlOverview.Size = New System.Drawing.Size(1040, 750)
        Me.pnlOverview.TabIndex = 20
        '
        'picBg
        '
        Me.picBg.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.picBg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBg.Location = New System.Drawing.Point(36, 28)
        Me.picBg.Name = "picBg"
        Me.picBg.Size = New System.Drawing.Size(968, 694)
        Me.picBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBg.TabStop = False
        Me.picBg.TabIndex = 21
        '
        'tblCards
        '
        Me.tblCards.BackColor = System.Drawing.Color.Transparent
        Me.tblCards.ColumnCount = 2
        Me.tblCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCards.Controls.Add(Me.pnlCardName, 0, 0)
        Me.tblCards.Controls.Add(Me.pnlCardCourse, 1, 0)
        Me.tblCards.Controls.Add(Me.pnlCardModules, 0, 1)
        Me.tblCards.Controls.Add(Me.pnlCardTheme, 1, 1)
        Me.tblCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblCards.Location = New System.Drawing.Point(36, 73)
        Me.tblCards.Name = "tblCards"
        Me.tblCards.RowCount = 2
        Me.tblCards.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCards.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCards.Size = New System.Drawing.Size(968, 320)
        Me.tblCards.TabIndex = 22
        '
        'pnlCardName
        '
        Me.pnlCardName.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlCardName.Controls.Add(Me.lblCardNameSub)
        Me.pnlCardName.Controls.Add(Me.lblCardNameMain)
        Me.pnlCardName.Controls.Add(Me.lblCardNameTitle)
        Me.pnlCardName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardName.Location = New System.Drawing.Point(8, 8)
        Me.pnlCardName.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCardName.Name = "pnlCardName"
        Me.pnlCardName.Padding = New System.Windows.Forms.Padding(18, 16, 18, 16)
        Me.pnlCardName.Size = New System.Drawing.Size(468, 144)
        Me.pnlCardName.TabIndex = 23
        '
        'lblCardNameSub
        '
        Me.lblCardNameSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardNameSub.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardNameSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblCardNameSub.Location = New System.Drawing.Point(18, 70)
        Me.lblCardNameSub.Name = "lblCardNameSub"
        Me.lblCardNameSub.Size = New System.Drawing.Size(432, 22)
        Me.lblCardNameSub.TabIndex = 26
        Me.lblCardNameSub.Text = "SBIT-2E"
        '
        'lblCardNameMain
        '
        Me.lblCardNameMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardNameMain.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Bold)
        Me.lblCardNameMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblCardNameMain.Location = New System.Drawing.Point(18, 38)
        Me.lblCardNameMain.Name = "lblCardNameMain"
        Me.lblCardNameMain.Size = New System.Drawing.Size(432, 32)
        Me.lblCardNameMain.TabIndex = 25
        Me.lblCardNameMain.Text = "ARBEL"
        '
        'lblCardNameTitle
        '
        Me.lblCardNameTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardNameTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCardNameTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCardNameTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblCardNameTitle.Name = "lblCardNameTitle"
        Me.lblCardNameTitle.Size = New System.Drawing.Size(432, 22)
        Me.lblCardNameTitle.TabIndex = 24
        Me.lblCardNameTitle.Text = "Name"
        '
        'pnlCardCourse
        '
        Me.pnlCardCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlCardCourse.Controls.Add(Me.lblCardCourseSub)
        Me.pnlCardCourse.Controls.Add(Me.lblCardCourseMain)
        Me.pnlCardCourse.Controls.Add(Me.lblCardCourseTitle)
        Me.pnlCardCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardCourse.Location = New System.Drawing.Point(492, 8)
        Me.pnlCardCourse.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCardCourse.Name = "pnlCardCourse"
        Me.pnlCardCourse.Padding = New System.Windows.Forms.Padding(18, 16, 18, 16)
        Me.pnlCardCourse.Size = New System.Drawing.Size(468, 144)
        Me.pnlCardCourse.TabIndex = 27
        '
        'lblCardCourseSub
        '
        Me.lblCardCourseSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardCourseSub.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardCourseSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCardCourseSub.Location = New System.Drawing.Point(18, 70)
        Me.lblCardCourseSub.Name = "lblCardCourseSub"
        Me.lblCardCourseSub.Size = New System.Drawing.Size(432, 22)
        Me.lblCardCourseSub.TabIndex = 30
        Me.lblCardCourseSub.Text = "Quezon City University"
        '
        'lblCardCourseMain
        '
        Me.lblCardCourseMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardCourseMain.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Bold)
        Me.lblCardCourseMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblCardCourseMain.Location = New System.Drawing.Point(18, 38)
        Me.lblCardCourseMain.Name = "lblCardCourseMain"
        Me.lblCardCourseMain.Size = New System.Drawing.Size(432, 32)
        Me.lblCardCourseMain.TabIndex = 29
        Me.lblCardCourseMain.Text = "PF101 - OOP"
        '
        'lblCardCourseTitle
        '
        Me.lblCardCourseTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardCourseTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCardCourseTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCardCourseTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblCardCourseTitle.Name = "lblCardCourseTitle"
        Me.lblCardCourseTitle.Size = New System.Drawing.Size(432, 22)
        Me.lblCardCourseTitle.TabIndex = 28
        Me.lblCardCourseTitle.Text = "Course"
        '
        'pnlCardModules
        '
        Me.pnlCardModules.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlCardModules.Controls.Add(Me.lblCardModulesSub)
        Me.pnlCardModules.Controls.Add(Me.lblCardModulesMain)
        Me.pnlCardModules.Controls.Add(Me.lblCardModulesTitle)
        Me.pnlCardModules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardModules.Location = New System.Drawing.Point(8, 168)
        Me.pnlCardModules.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCardModules.Name = "pnlCardModules"
        Me.pnlCardModules.Padding = New System.Windows.Forms.Padding(18, 16, 18, 16)
        Me.pnlCardModules.Size = New System.Drawing.Size(468, 144)
        Me.pnlCardModules.TabIndex = 31
        '
        'lblCardModulesSub
        '
        Me.lblCardModulesSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardModulesSub.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardModulesSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblCardModulesSub.Location = New System.Drawing.Point(18, 70)
        Me.lblCardModulesSub.Name = "lblCardModulesSub"
        Me.lblCardModulesSub.Size = New System.Drawing.Size(432, 22)
        Me.lblCardModulesSub.TabIndex = 34
        Me.lblCardModulesSub.Text = "All Weeks Ready"
        '
        'lblCardModulesMain
        '
        Me.lblCardModulesMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardModulesMain.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Bold)
        Me.lblCardModulesMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblCardModulesMain.Location = New System.Drawing.Point(18, 38)
        Me.lblCardModulesMain.Name = "lblCardModulesMain"
        Me.lblCardModulesMain.Size = New System.Drawing.Size(432, 32)
        Me.lblCardModulesMain.TabIndex = 33
        Me.lblCardModulesMain.Text = "8/8 Loaded"
        '
        'lblCardModulesTitle
        '
        Me.lblCardModulesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardModulesTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCardModulesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCardModulesTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblCardModulesTitle.Name = "lblCardModulesTitle"
        Me.lblCardModulesTitle.Size = New System.Drawing.Size(432, 22)
        Me.lblCardModulesTitle.TabIndex = 32
        Me.lblCardModulesTitle.Text = "Modules Status"
        '
        'pnlCardTheme
        '
        Me.pnlCardTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlCardTheme.Controls.Add(Me.lblCardThemeSub)
        Me.pnlCardTheme.Controls.Add(Me.lblCardThemeMain)
        Me.pnlCardTheme.Controls.Add(Me.lblCardThemeTitle)
        Me.pnlCardTheme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardTheme.Location = New System.Drawing.Point(492, 168)
        Me.pnlCardTheme.Margin = New System.Windows.Forms.Padding(8)
        Me.pnlCardTheme.Name = "pnlCardTheme"
        Me.pnlCardTheme.Padding = New System.Windows.Forms.Padding(18, 16, 18, 16)
        Me.pnlCardTheme.Size = New System.Drawing.Size(468, 144)
        Me.pnlCardTheme.TabIndex = 35
        '
        'lblCardThemeSub
        '
        Me.lblCardThemeSub.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardThemeSub.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardThemeSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCardThemeSub.Location = New System.Drawing.Point(18, 70)
        Me.lblCardThemeSub.Name = "lblCardThemeSub"
        Me.lblCardThemeSub.Size = New System.Drawing.Size(432, 22)
        Me.lblCardThemeSub.TabIndex = 38
        Me.lblCardThemeSub.Text = "Centralized Engine Active"
        '
        'lblCardThemeMain
        '
        Me.lblCardThemeMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardThemeMain.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Bold)
        Me.lblCardThemeMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblCardThemeMain.Location = New System.Drawing.Point(18, 38)
        Me.lblCardThemeMain.Name = "lblCardThemeMain"
        Me.lblCardThemeMain.Size = New System.Drawing.Size(432, 32)
        Me.lblCardThemeMain.TabIndex = 37
        Me.lblCardThemeMain.Text = "Dark Obsidian"
        '
        'lblCardThemeTitle
        '
        Me.lblCardThemeTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardThemeTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCardThemeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCardThemeTitle.Location = New System.Drawing.Point(18, 16)
        Me.lblCardThemeTitle.Name = "lblCardThemeTitle"
        Me.lblCardThemeTitle.Size = New System.Drawing.Size(432, 22)
        Me.lblCardThemeTitle.TabIndex = 36
        Me.lblCardThemeTitle.Text = "Runtime Theme"
        '
        'lblOverviewHeader
        '
        Me.lblOverviewHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblOverviewHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOverviewHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblOverviewHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblOverviewHeader.Location = New System.Drawing.Point(36, 28)
        Me.lblOverviewHeader.Name = "lblOverviewHeader"
        Me.lblOverviewHeader.Size = New System.Drawing.Size(968, 45)
        Me.lblOverviewHeader.TabIndex = 21
        Me.lblOverviewHeader.Text = "Overview"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 750)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1024, 620)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PF 101 – Object Oriented Programming       Created By: Echavez, Arlvel L."
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlProfile.ResumeLayout(False)
        Me.pnlProfile.PerformLayout()
        Me.pnlNavList.ResumeLayout(False)
        Me.pnlNavOOPChildren.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlOverview.ResumeLayout(False)
        CType(Me.picBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblCards.ResumeLayout(False)
        Me.pnlCardName.ResumeLayout(False)
        Me.pnlCardCourse.ResumeLayout(False)
        Me.pnlCardModules.ResumeLayout(False)
        Me.pnlCardTheme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents lblAvatar As Label
    Friend WithEvents lblProfileName As Label
    Friend WithEvents lblProfileStatus As Label
    Friend WithEvents pnlNavList As Panel
    Friend WithEvents pnlNavOOPChildren As Panel
    Friend WithEvents btnNavGame As Button
    Friend WithEvents btnNavOverview As Button
    Friend WithEvents btnNavOrientations As Button
    Friend WithEvents btnNavOOPConcepts As Button
    Friend WithEvents btnNavClasses As Button
    Friend WithEvents btnNavEncapsulation As Button
    Friend WithEvents btnNavInheritance As Button
    Friend WithEvents btnNavPolymorphism As Button
    Friend WithEvents btnNavLesson3 As Button
    Friend WithEvents btnNavLesson4 As Button
    Friend WithEvents btnNavLesson5 As Button
    Friend WithEvents btnNavLesson6 As Button
    Friend WithEvents btnNavLesson7 As Button
    Friend WithEvents btnNavLesson8 As Button
    Friend WithEvents lblSidebarCategory As Label
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlOverview As Panel
    Friend WithEvents picBg As PictureBox
    Friend WithEvents lblOverviewHeader As Label
    Friend WithEvents tblCards As TableLayoutPanel
    Friend WithEvents pnlCardName As Panel
    Friend WithEvents lblCardNameTitle As Label
    Friend WithEvents lblCardNameMain As Label
    Friend WithEvents lblCardNameSub As Label
    Friend WithEvents pnlCardCourse As Panel
    Friend WithEvents lblCardCourseTitle As Label
    Friend WithEvents lblCardCourseMain As Label
    Friend WithEvents lblCardCourseSub As Label
    Friend WithEvents pnlCardModules As Panel
    Friend WithEvents lblCardModulesTitle As Label
    Friend WithEvents lblCardModulesMain As Label
    Friend WithEvents lblCardModulesSub As Label
    Friend WithEvents pnlCardTheme As Panel
    Friend WithEvents lblCardThemeTitle As Label
    Friend WithEvents lblCardThemeMain As Label
    Friend WithEvents lblCardThemeSub As Label
End Class