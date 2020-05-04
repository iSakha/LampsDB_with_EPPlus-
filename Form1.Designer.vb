<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabcontrol = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.selectNewType_btn = New System.Windows.Forms.Button()
        Me.selectTech_btn = New System.Windows.Forms.Button()
        Me.selectOUT_btn = New System.Windows.Forms.Button()
        Me.selectIN_btn = New System.Windows.Forms.Button()
        Me.selectStore_btn = New System.Windows.Forms.Button()
        Me.loadBase_btn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.filterStore_btn = New System.Windows.Forms.Button()
        Me.clrFilterStore_brn = New System.Windows.Forms.Button()
        Me.DGV_store = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.filterIN_btn = New System.Windows.Forms.Button()
        Me.clrFilterIN_btn = New System.Windows.Forms.Button()
        Me.DGV_in = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.filterOUT_btn = New System.Windows.Forms.Button()
        Me.clrFilterOUT_btn = New System.Windows.Forms.Button()
        Me.DGV_out = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Save_btn = New System.Windows.Forms.Button()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.numRecord_txt = New System.Windows.Forms.TextBox()
        Me.location_cmb = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.notes2_txt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.notes1_txt = New System.Windows.Forms.TextBox()
        Me.qty_txt = New System.Windows.Forms.TextBox()
        Me.fxt_cmb = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.idLamp_txt = New System.Windows.Forms.TextBox()
        Me.pers_cmb = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.lampName_cmb = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.prev_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tabcontrol.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGV_in, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGV_out, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabcontrol
        '
        Me.tabcontrol.Controls.Add(Me.TabPage1)
        Me.tabcontrol.Controls.Add(Me.TabPage2)
        Me.tabcontrol.Controls.Add(Me.TabPage3)
        Me.tabcontrol.Controls.Add(Me.TabPage4)
        Me.tabcontrol.Controls.Add(Me.TabPage5)
        Me.tabcontrol.Controls.Add(Me.TabPage6)
        Me.tabcontrol.Location = New System.Drawing.Point(4, 0)
        Me.tabcontrol.Name = "tabcontrol"
        Me.tabcontrol.SelectedIndex = 0
        Me.tabcontrol.Size = New System.Drawing.Size(1174, 684)
        Me.tabcontrol.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.exit_btn)
        Me.TabPage1.Controls.Add(Me.selectNewType_btn)
        Me.TabPage1.Controls.Add(Me.selectTech_btn)
        Me.TabPage1.Controls.Add(Me.selectOUT_btn)
        Me.TabPage1.Controls.Add(Me.selectIN_btn)
        Me.TabPage1.Controls.Add(Me.selectStore_btn)
        Me.TabPage1.Controls.Add(Me.loadBase_btn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1166, 658)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(48, 572)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(253, 49)
        Me.exit_btn.TabIndex = 9
        Me.exit_btn.Text = "Выход"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'selectNewType_btn
        '
        Me.selectNewType_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.selectNewType_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectNewType_btn.Enabled = False
        Me.selectNewType_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.selectNewType_btn.Location = New System.Drawing.Point(48, 486)
        Me.selectNewType_btn.Name = "selectNewType_btn"
        Me.selectNewType_btn.Size = New System.Drawing.Size(253, 49)
        Me.selectNewType_btn.TabIndex = 9
        Me.selectNewType_btn.Text = "Добавить новый тип лампы"
        Me.selectNewType_btn.UseVisualStyleBackColor = False
        '
        'selectTech_btn
        '
        Me.selectTech_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.selectTech_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectTech_btn.Enabled = False
        Me.selectTech_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.selectTech_btn.Location = New System.Drawing.Point(48, 400)
        Me.selectTech_btn.Name = "selectTech_btn"
        Me.selectTech_btn.Size = New System.Drawing.Size(253, 49)
        Me.selectTech_btn.TabIndex = 9
        Me.selectTech_btn.Text = "Технические характеристики"
        Me.selectTech_btn.UseVisualStyleBackColor = False
        '
        'selectOUT_btn
        '
        Me.selectOUT_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.selectOUT_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectOUT_btn.Enabled = False
        Me.selectOUT_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.selectOUT_btn.Location = New System.Drawing.Point(48, 314)
        Me.selectOUT_btn.Name = "selectOUT_btn"
        Me.selectOUT_btn.Size = New System.Drawing.Size(253, 49)
        Me.selectOUT_btn.TabIndex = 9
        Me.selectOUT_btn.Text = "Записать расход"
        Me.selectOUT_btn.UseVisualStyleBackColor = False
        '
        'selectIN_btn
        '
        Me.selectIN_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.selectIN_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectIN_btn.Enabled = False
        Me.selectIN_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.selectIN_btn.Location = New System.Drawing.Point(48, 228)
        Me.selectIN_btn.Name = "selectIN_btn"
        Me.selectIN_btn.Size = New System.Drawing.Size(253, 49)
        Me.selectIN_btn.TabIndex = 9
        Me.selectIN_btn.Text = "Записать приход"
        Me.selectIN_btn.UseVisualStyleBackColor = False
        '
        'selectStore_btn
        '
        Me.selectStore_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.selectStore_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectStore_btn.Enabled = False
        Me.selectStore_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.selectStore_btn.Location = New System.Drawing.Point(48, 142)
        Me.selectStore_btn.Name = "selectStore_btn"
        Me.selectStore_btn.Size = New System.Drawing.Size(253, 49)
        Me.selectStore_btn.TabIndex = 9
        Me.selectStore_btn.Text = "Посмотреть что в наличии"
        Me.selectStore_btn.UseVisualStyleBackColor = False
        '
        'loadBase_btn
        '
        Me.loadBase_btn.BackColor = System.Drawing.Color.Gainsboro
        Me.loadBase_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loadBase_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.loadBase_btn.Location = New System.Drawing.Point(48, 56)
        Me.loadBase_btn.Name = "loadBase_btn"
        Me.loadBase_btn.Size = New System.Drawing.Size(253, 49)
        Me.loadBase_btn.TabIndex = 9
        Me.loadBase_btn.Text = "Загрузить базу"
        Me.loadBase_btn.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.filterStore_btn)
        Me.TabPage2.Controls.Add(Me.clrFilterStore_brn)
        Me.TabPage2.Controls.Add(Me.DGV_store)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1166, 658)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Store"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'filterStore_btn
        '
        Me.filterStore_btn.Location = New System.Drawing.Point(104, 583)
        Me.filterStore_btn.Name = "filterStore_btn"
        Me.filterStore_btn.Size = New System.Drawing.Size(75, 23)
        Me.filterStore_btn.TabIndex = 3
        Me.filterStore_btn.Text = "Filter"
        Me.filterStore_btn.UseVisualStyleBackColor = True
        '
        'clrFilterStore_brn
        '
        Me.clrFilterStore_brn.Location = New System.Drawing.Point(23, 583)
        Me.clrFilterStore_brn.Name = "clrFilterStore_brn"
        Me.clrFilterStore_brn.Size = New System.Drawing.Size(75, 23)
        Me.clrFilterStore_brn.TabIndex = 3
        Me.clrFilterStore_brn.Text = "ClearFilter"
        Me.clrFilterStore_brn.UseVisualStyleBackColor = True
        '
        'DGV_store
        '
        Me.DGV_store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_store.Location = New System.Drawing.Point(-4, 3)
        Me.DGV_store.Name = "DGV_store"
        Me.DGV_store.Size = New System.Drawing.Size(1170, 532)
        Me.DGV_store.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.filterIN_btn)
        Me.TabPage3.Controls.Add(Me.clrFilterIN_btn)
        Me.TabPage3.Controls.Add(Me.DGV_in)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1166, 658)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "IN"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'filterIN_btn
        '
        Me.filterIN_btn.Location = New System.Drawing.Point(104, 583)
        Me.filterIN_btn.Name = "filterIN_btn"
        Me.filterIN_btn.Size = New System.Drawing.Size(75, 23)
        Me.filterIN_btn.TabIndex = 2
        Me.filterIN_btn.Text = "Filter"
        Me.filterIN_btn.UseVisualStyleBackColor = True
        '
        'clrFilterIN_btn
        '
        Me.clrFilterIN_btn.Location = New System.Drawing.Point(23, 583)
        Me.clrFilterIN_btn.Name = "clrFilterIN_btn"
        Me.clrFilterIN_btn.Size = New System.Drawing.Size(75, 23)
        Me.clrFilterIN_btn.TabIndex = 2
        Me.clrFilterIN_btn.Text = "ClearFilter"
        Me.clrFilterIN_btn.UseVisualStyleBackColor = True
        '
        'DGV_in
        '
        Me.DGV_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_in.Location = New System.Drawing.Point(-4, 3)
        Me.DGV_in.MultiSelect = False
        Me.DGV_in.Name = "DGV_in"
        Me.DGV_in.Size = New System.Drawing.Size(1170, 532)
        Me.DGV_in.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.filterOUT_btn)
        Me.TabPage4.Controls.Add(Me.clrFilterOUT_btn)
        Me.TabPage4.Controls.Add(Me.DGV_out)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1166, 658)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "OUT"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'filterOUT_btn
        '
        Me.filterOUT_btn.Location = New System.Drawing.Point(104, 583)
        Me.filterOUT_btn.Name = "filterOUT_btn"
        Me.filterOUT_btn.Size = New System.Drawing.Size(75, 23)
        Me.filterOUT_btn.TabIndex = 3
        Me.filterOUT_btn.Text = "Filter"
        Me.filterOUT_btn.UseVisualStyleBackColor = True
        '
        'clrFilterOUT_btn
        '
        Me.clrFilterOUT_btn.Location = New System.Drawing.Point(23, 583)
        Me.clrFilterOUT_btn.Name = "clrFilterOUT_btn"
        Me.clrFilterOUT_btn.Size = New System.Drawing.Size(75, 23)
        Me.clrFilterOUT_btn.TabIndex = 3
        Me.clrFilterOUT_btn.Text = "ClearFilter"
        Me.clrFilterOUT_btn.UseVisualStyleBackColor = True
        '
        'DGV_out
        '
        Me.DGV_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_out.Location = New System.Drawing.Point(-4, 3)
        Me.DGV_out.Name = "DGV_out"
        Me.DGV_out.Size = New System.Drawing.Size(1170, 532)
        Me.DGV_out.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1166, 658)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Tech"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1166, 658)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Add New"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.numRecord_txt)
        Me.GroupBox2.Controls.Add(Me.location_cmb)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.notes2_txt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.notes1_txt)
        Me.GroupBox2.Controls.Add(Me.qty_txt)
        Me.GroupBox2.Controls.Add(Me.fxt_cmb)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.idLamp_txt)
        Me.GroupBox2.Controls.Add(Me.pers_cmb)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.DTP)
        Me.GroupBox2.Controls.Add(Me.lampName_cmb)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 690)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1176, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Save_btn)
        Me.GroupBox3.Controls.Add(Me.Delete_btn)
        Me.GroupBox3.Controls.Add(Me.Update_btn)
        Me.GroupBox3.Controls.Add(Me.Add_btn)
        Me.GroupBox3.Location = New System.Drawing.Point(962, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 102)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        '
        'Save_btn
        '
        Me.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Save_btn.FlatAppearance.BorderSize = 2
        Me.Save_btn.Location = New System.Drawing.Point(105, 59)
        Me.Save_btn.Name = "Save_btn"
        Me.Save_btn.Size = New System.Drawing.Size(87, 27)
        Me.Save_btn.TabIndex = 13
        Me.Save_btn.Text = "Save"
        Me.Save_btn.UseVisualStyleBackColor = True
        '
        'Delete_btn
        '
        Me.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_btn.Location = New System.Drawing.Point(6, 59)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(87, 27)
        Me.Delete_btn.TabIndex = 13
        Me.Delete_btn.Text = "Delete"
        Me.Delete_btn.UseVisualStyleBackColor = True
        '
        'Update_btn
        '
        Me.Update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_btn.Location = New System.Drawing.Point(105, 16)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(87, 27)
        Me.Update_btn.TabIndex = 13
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = True
        '
        'Add_btn
        '
        Me.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_btn.Location = New System.Drawing.Point(6, 16)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(87, 27)
        Me.Add_btn.TabIndex = 13
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'numRecord_txt
        '
        Me.numRecord_txt.BackColor = System.Drawing.Color.White
        Me.numRecord_txt.Enabled = False
        Me.numRecord_txt.Location = New System.Drawing.Point(6, 19)
        Me.numRecord_txt.Name = "numRecord_txt"
        Me.numRecord_txt.Size = New System.Drawing.Size(52, 20)
        Me.numRecord_txt.TabIndex = 62
        '
        'location_cmb
        '
        Me.location_cmb.BackColor = System.Drawing.Color.White
        Me.location_cmb.FormattingEnabled = True
        Me.location_cmb.Location = New System.Drawing.Point(813, 19)
        Me.location_cmb.Name = "location_cmb"
        Me.location_cmb.Size = New System.Drawing.Size(143, 21)
        Me.location_cmb.TabIndex = 72
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(688, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Notes2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(809, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Location"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(688, 1)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Personnel"
        '
        'notes2_txt
        '
        Me.notes2_txt.BackColor = System.Drawing.Color.White
        Me.notes2_txt.Location = New System.Drawing.Point(691, 68)
        Me.notes2_txt.Name = "notes2_txt"
        Me.notes2_txt.Size = New System.Drawing.Size(265, 20)
        Me.notes2_txt.TabIndex = 70
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(370, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Notes1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(251, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 69)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(1, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "Search by Fixture"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(1, 11)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Search by Lamp"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(84, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Fixture"
        '
        'notes1_txt
        '
        Me.notes1_txt.BackColor = System.Drawing.Color.White
        Me.notes1_txt.Location = New System.Drawing.Point(373, 69)
        Me.notes1_txt.Name = "notes1_txt"
        Me.notes1_txt.Size = New System.Drawing.Size(306, 20)
        Me.notes1_txt.TabIndex = 69
        '
        'qty_txt
        '
        Me.qty_txt.BackColor = System.Drawing.Color.White
        Me.qty_txt.Location = New System.Drawing.Point(6, 68)
        Me.qty_txt.Name = "qty_txt"
        Me.qty_txt.Size = New System.Drawing.Size(52, 20)
        Me.qty_txt.TabIndex = 64
        '
        'fxt_cmb
        '
        Me.fxt_cmb.BackColor = System.Drawing.Color.White
        Me.fxt_cmb.FormattingEnabled = True
        Me.fxt_cmb.Location = New System.Drawing.Point(87, 68)
        Me.fxt_cmb.Name = "fxt_cmb"
        Me.fxt_cmb.Size = New System.Drawing.Size(153, 21)
        Me.fxt_cmb.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Quantity"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "#"
        '
        'idLamp_txt
        '
        Me.idLamp_txt.BackColor = System.Drawing.Color.White
        Me.idLamp_txt.Location = New System.Drawing.Point(193, 19)
        Me.idLamp_txt.Name = "idLamp_txt"
        Me.idLamp_txt.Size = New System.Drawing.Size(52, 20)
        Me.idLamp_txt.TabIndex = 63
        '
        'pers_cmb
        '
        Me.pers_cmb.BackColor = System.Drawing.Color.White
        Me.pers_cmb.FormattingEnabled = True
        Me.pers_cmb.Location = New System.Drawing.Point(691, 18)
        Me.pers_cmb.Name = "pers_cmb"
        Me.pers_cmb.Size = New System.Drawing.Size(116, 21)
        Me.pers_cmb.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(370, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Lamp name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(70, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Date"
        '
        'DTP
        '
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(73, 19)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(112, 20)
        Me.DTP.TabIndex = 65
        Me.DTP.Value = New Date(2020, 4, 19, 0, 0, 0, 0)
        '
        'lampName_cmb
        '
        Me.lampName_cmb.BackColor = System.Drawing.Color.White
        Me.lampName_cmb.FormattingEnabled = True
        Me.lampName_cmb.Location = New System.Drawing.Point(373, 18)
        Me.lampName_cmb.Name = "lampName_cmb"
        Me.lampName_cmb.Size = New System.Drawing.Size(312, 21)
        Me.lampName_cmb.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(190, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "ID Lamp"
        '
        'prev_btn
        '
        Me.prev_btn.Location = New System.Drawing.Point(493, 798)
        Me.prev_btn.Name = "prev_btn"
        Me.prev_btn.Size = New System.Drawing.Size(75, 23)
        Me.prev_btn.TabIndex = 2
        Me.prev_btn.Text = "<<< "
        Me.prev_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(621, 798)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 2
        Me.next_btn.Text = ">>>"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(357, 591)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 621)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LampDB_new.My.Resources.Resources._4
        Me.PictureBox1.Location = New System.Drawing.Point(203, 541)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 833)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.prev_btn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tabcontrol)
        Me.Name = "mainForm"
        Me.Text = "Form1"
        Me.tabcontrol.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGV_store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGV_in, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DGV_out, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcontrol As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DGV_store As DataGridView
    Friend WithEvents DGV_in As DataGridView
    Friend WithEvents DGV_out As DataGridView
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents exit_btn As Button
    Friend WithEvents selectNewType_btn As Button
    Friend WithEvents selectTech_btn As Button
    Friend WithEvents selectOUT_btn As Button
    Friend WithEvents selectIN_btn As Button
    Friend WithEvents selectStore_btn As Button
    Friend WithEvents loadBase_btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Save_btn As Button
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Update_btn As Button
    Friend WithEvents Add_btn As Button
    Friend WithEvents numRecord_txt As TextBox
    Friend WithEvents location_cmb As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents notes2_txt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents notes1_txt As TextBox
    Friend WithEvents qty_txt As TextBox
    Friend WithEvents fxt_cmb As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents idLamp_txt As TextBox
    Friend WithEvents pers_cmb As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents lampName_cmb As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents prev_btn As Button
    Friend WithEvents next_btn As Button
    Friend WithEvents clrFilterStore_brn As Button
    Friend WithEvents clrFilterIN_btn As Button
    Friend WithEvents clrFilterOUT_btn As Button
    Friend WithEvents filterStore_btn As Button
    Friend WithEvents filterIN_btn As Button
    Friend WithEvents filterOUT_btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
