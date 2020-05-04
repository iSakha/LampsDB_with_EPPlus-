Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO


Public Class mainForm

    Public sDir As String
    Public sFileName As String

    Public wsIN, wsOUT As ExcelWorksheet
    Public wsStore, wsTechList As ExcelWorksheet

    Public tbl_IN_Collection As ExcelTableCollection
    Public tbl_OUT_Collection As ExcelTableCollection
    Public tbl_Store_Collection As ExcelTableCollection
    Public tbl_TechList_Collection As ExcelTableCollection

    Public tableIN, tableOUT As ExcelTable
    Public tableStore, tablelampToFixture, tablefxtToLamp As ExcelTable
    Public tableLamps, tablePersonnel, tableLocation As ExcelTable

    Public dtIN, dtOUT As New dataTable()
    Public dtStore, dtlampToFixture, dtfxtToLamp As New DataTable()
    Public dtLamps, dtPersonnel, dtLocation As New DataTable()

    Public rCountIN, rCountOUT As Integer
    Public rCountStore, rCountlampToFixture, rCountfxtToLamp As Integer
    Public rCountLamps, rCountPersonnel, rCountLocation As Integer

    Public colCountIN, colCountOUT, colCountfxtToLamp As Integer
    Public colCountStore, colCountlampToFixture As Integer
    Public colCountLamps, colCountPersonnel, colCountLocation As Integer

    Public tblAddressIN, tblAddressOUT As String
    Public tblAddressStore, tblAddressLamps As String
    Public tblAddressLocation, tblAddressPersonnel As String
    Public tblAddresslampToFixture, tblAddressfxtToLamp As String

    Public rngIN, rngOUT As ExcelRange
    Public rngStore, rngLamps As ExcelRange
    Public rngLocation, rngPersonnel As ExcelRange
    Public rnglampToFixture, rngfxtToLamp As ExcelRange

    Public excelObj, excelFileObj As Object         '   Global vars to use in function "Save"
    Public excelObjTmp, excelFileObjTmp As Object

    Public dbName, sFileNameNew As String

    Public pages() As String = New String() {"Menu", "Store", "IN", "OUT", "Tech", "AddNew"}
    Public selectedPage As String = ""

    Public lampImg() As Image
    '===================================================================================      
    '                === Load mainForm ===
    '===================================================================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lampImg = {My.Resources._1,
                                  My.Resources._2,
                                  My.Resources._3,
                                  My.Resources._4,
                                  My.Resources._5,
                                  My.Resources._6,
                                  My.Resources._7,
                                  My.Resources._8,
                                  My.Resources._9,
                                  My.Resources._10,
                                  My.Resources._11,
                                  My.Resources._13,
                                  My.Resources._16,
                                  My.Resources._17,
                                  My.Resources._18,
                                  My.Resources._19,
                                  My.Resources._20,
                                  My.Resources._21}

        PictureBox1.Visible = False

    End Sub
    '===================================================================================      
    '                === Load button ===
    '===================================================================================
    Private Sub loadBase_btn_Click(sender As Object, e As EventArgs) Handles loadBase_btn.Click

        sDir = Directory.GetCurrentDirectory()

        OFD.InitialDirectory = sDir
        OFD.Title = "Select .omdb file"

        If OFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            sFileName = OFD.FileName

            Dim excelFile = New FileInfo(sFileName)

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Dim Excel As ExcelPackage = New ExcelPackage(excelFile)
            dbName = Excel.File.Name

            excelObj = Excel                            '   Global vars to use in function "Save"
            excelFileObj = excelFile

            wsIN = Excel.Workbook.Worksheets("IN(new)")
            wsOUT = Excel.Workbook.Worksheets("OUT(new)")
            wsStore = Excel.Workbook.Worksheets("Store")
            wsTechList = Excel.Workbook.Worksheets("TechList")

            tbl_IN_Collection = wsIN.Tables
            tbl_OUT_Collection = wsOUT.Tables
            tbl_Store_Collection = wsStore.Tables
            tbl_TechList_Collection = wsTechList.Tables

            tableIN = tbl_IN_Collection.Item(0)
            tableOUT = tbl_OUT_Collection.Item(0)
            tableStore = tbl_Store_Collection.Item(0)
            tableLamps = tbl_TechList_Collection.Item(0)
            tableLocation = tbl_TechList_Collection.Item(1)
            tablePersonnel = tbl_TechList_Collection.Item(2)
            tablelampToFixture = tbl_TechList_Collection.Item(3)
            tablefxtToLamp = tbl_TechList_Collection.Item(4)

            rCountIN = tableIN.Address.Rows
            rCountOUT = tableOUT.Address.Rows
            rCountStore = tableStore.Address.Rows
            rCountLamps = tableLamps.Address.Rows
            rCountLocation = tableLocation.Address.Rows
            rCountPersonnel = tablePersonnel.Address.Rows
            rCountlampToFixture = tablelampToFixture.Address.Rows
            rCountfxtToLamp = tablefxtToLamp.Address.Rows

            colCountIN = tableIN.Address.Columns
            colCountOUT = tableOUT.Address.Columns
            colCountStore = tableStore.Address.Columns
            colCountLamps = tableLamps.Address.Columns
            colCountLocation = tableLocation.Address.Columns
            colCountPersonnel = tablePersonnel.Address.Columns
            colCountlampToFixture = tablelampToFixture.Address.Columns
            colCountfxtToLamp = tablefxtToLamp.Address.Columns

            tblAddressIN = tableIN.Address.Address
            tblAddressOUT = tableOUT.Address.Address
            tblAddressStore = tableStore.Address.Address
            tblAddressLamps = tableLamps.Address.Address
            tblAddressLocation = tableLocation.Address.Address
            tblAddressPersonnel = tablePersonnel.Address.Address
            tblAddresslampToFixture = tablelampToFixture.Address.Address
            tblAddressfxtToLamp = tablefxtToLamp.Address.Address

            rngIN = wsIN.Cells(tblAddressIN)
            rngOUT = wsOUT.Cells(tblAddressOUT)
            rngStore = wsStore.Cells(tblAddressStore)
            rngLamps = wsTechList.Cells(tblAddressLamps)
            rngLocation = wsTechList.Cells(tblAddressLocation)
            rngPersonnel = wsTechList.Cells(tblAddressPersonnel)
            rnglampToFixture = wsTechList.Cells(tblAddresslampToFixture)
            rngfxtToLamp = wsTechList.Cells(tblAddressfxtToLamp)

            create_datatable(rCountIN, colCountIN, rngIN, dtIN, "dtIN")
            DGV_in.DataSource = dtIN
            DGV_format("dtIN")

            create_datatable(rCountOUT, colCountOUT, rngOUT, dtOUT, "dtOUT")
            DGV_out.DataSource = dtOUT
            DGV_format("dtOUT")

            create_datatable(rCountStore, colCountStore, rngStore, dtStore, "dtStore")
            DGV_store.DataSource = dtStore
            DGV_format("dtStore")

            create_datatable(rCountlampToFixture, colCountlampToFixture, rnglampToFixture, dtlampToFixture, "dtlampToFixture")
            create_datatable(rCountfxtToLamp, colCountfxtToLamp, rngfxtToLamp, dtfxtToLamp, "dtfxtToLamp")
            create_datatable(rCountLocation, colCountLocation, rngLocation, dtLocation, "dtLocation")
            create_datatable(rCountPersonnel, colCountPersonnel, rngPersonnel, dtPersonnel, "dtPersonnel")

            addItemsToCombobox(lampName_cmb, rCountlampToFixture, dtlampToFixture)
            addItemsToCombobox(fxt_cmb, rCountfxtToLamp, dtfxtToLamp)
            addItemsToCombobox(location_cmb, rCountLocation, dtLocation)
            addItemsToCombobox(pers_cmb, rCountPersonnel, dtPersonnel)

            selectStore_btn.Enabled = True
            selectIN_btn.Enabled = True
            selectOUT_btn.Enabled = True
            selectTech_btn.Enabled = True
            selectNewType_btn.Enabled = True


        End If

    End Sub
    '===================================================================================      
    '                === Select store page ===
    '===================================================================================
    Private Sub selectStore_btn_Click(sender As Object, e As EventArgs) Handles selectStore_btn.Click
        selectPage(selectStore_btn)
        tabcontrol.SelectedIndex = 1
        selectedPage = pages(1)
    End Sub
    '===================================================================================      
    '                === Select INcoming page ===
    '===================================================================================
    Private Sub selectIN_btn_Click(sender As Object, e As EventArgs) Handles selectIN_btn.Click
        selectPage(selectIN_btn)
        tabcontrol.SelectedIndex = 2
        selectedPage = pages(2)
    End Sub
    '===================================================================================      
    '                === Select OUTgoing page ===
    '===================================================================================
    Private Sub selectOUT_btn_Click(sender As Object, e As EventArgs) Handles selectOUT_btn.Click
        selectPage(selectOUT_btn)
        tabcontrol.SelectedIndex = 3
        selectedPage = pages(3)
    End Sub
    '===================================================================================      
    '                === Select Tech page ===
    '===================================================================================
    Private Sub selectTech_btn_Click(sender As Object, e As EventArgs) Handles selectTech_btn.Click
        selectPage(selectTech_btn)
        tabcontrol.SelectedIndex = 4
        selectedPage = pages(4)
    End Sub
    '===================================================================================      
    '                === Select NewType page ===
    '===================================================================================
    Private Sub selectNewType_btn_Click(sender As Object, e As EventArgs) Handles selectNewType_btn.Click
        selectPage(selectNewType_btn)
        tabcontrol.SelectedIndex = 5
        selectedPage = pages(5)
    End Sub
    '===================================================================================      
    '                === Select exit ===
    '===================================================================================
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click

    End Sub

    '===================================================================================      
    '                === Next page ===
    '===================================================================================
    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        nextPage()
    End Sub
    '===================================================================================      
    '                === Prev page ===
    '===================================================================================
    Private Sub prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        prevPage()
    End Sub

    '===================================================================================
    '               === Change LAMP selection ===
    '===================================================================================

    Private Sub lampName_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lampName_cmb.SelectedIndexChanged

        If (idLamp_txt.BackColor = Color.LightPink) Then
            Dim lampIndex As Integer
            Dim dtlampToFixtureFilter() As DataRow

            dtlampToFixtureFilter = dtlampToFixture.Select("Lamp = " & "'" & lampName_cmb.SelectedItem & "'")
            lampIndex = dtlampToFixtureFilter(0).Item(1).ToString

            'Console.WriteLine(lampIndex)
            idLamp_txt.Text = lampIndex
            idLamp_txt.BackColor = Color.White
            lampName_cmb.BackColor = Color.White
            lampName_cmb.Enabled = False
        End If

        If (RadioButton1.Checked) Then

            selectLamp_Or_Fixture(lampName_cmb, fxt_cmb, colCountlampToFixture, dtlampToFixture)

            If (lampName_cmb.SelectedIndex = 0) Then
                addItemsToCombobox(fxt_cmb, rCountfxtToLamp, dtfxtToLamp)
            End If

        End If
        PictureBox1.Visible = True
        PictureBox1.Image = lampImg(lampName_cmb.SelectedIndex - 1)

    End Sub
    '===================================================================================
    '               === Change FIXTURE selection ===
    '===================================================================================
    Private Sub fxt_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fxt_cmb.SelectedIndexChanged
        If (RadioButton2.Checked) Then
            selectLamp_Or_Fixture(fxt_cmb, lampName_cmb, colCountfxtToLamp, dtfxtToLamp)

            If (fxt_cmb.SelectedIndex = 0) Then
                addItemsToCombobox(lampName_cmb, rCountlampToFixture, dtlampToFixture)
            End If
            ' In case if fixture has can use than one lamp (Sharpy in this case)
            If (lampName_cmb.Items.Count > 1) Then
                idLamp_txt.Text = ""
                idLamp_txt.BackColor = Color.LightPink
                lampName_cmb.Text = ""
                lampName_cmb.BackColor = Color.LightPink
                MsgBox("Select lamp!")
            End If

        End If

        lampName_cmb.Enabled = True
    End Sub
    '===================================================================================
    '             === RadioButton select search by LAMP or by FIXTURE ===
    '===================================================================================
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        lampName_cmb.Items.Clear()
        lampName_cmb.Text = ""
        fxt_cmb.Items.Clear()
        fxt_cmb.Text = ""
        addItemsToCombobox(lampName_cmb, rCountlampToFixture, dtlampToFixture)
        addItemsToCombobox(fxt_cmb, rCountfxtToLamp, dtfxtToLamp)

        lampName_cmb.Items.Clear()
        lampName_cmb.Text = ""
        fxt_cmb.Items.Clear()
        fxt_cmb.Text = ""
        addItemsToCombobox(lampName_cmb, rCountlampToFixture, dtlampToFixture)
        addItemsToCombobox(fxt_cmb, rCountfxtToLamp, dtfxtToLamp)

        idLamp_txt.Text = ""
        lampName_cmb.Enabled = True
    End Sub

    '===================================================================================
    '             === CellClick on DGV ===
    '===================================================================================
    Private Sub DGV_store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_store.CellClick
        dgv_cellClick(sender, e)
    End Sub

    Private Sub DGV_in_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_in.CellClick
        dgv_cellClick(sender, e)
    End Sub

    Private Sub DGV_out_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_out.CellClick
        dgv_cellClick(sender, e)
    End Sub

    '===================================================================================
    '             === ADD data to DB ===
    '===================================================================================
    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles Add_btn.Click

        selectedPage = tabcontrol.SelectedIndex
        Select Case selectedPage
            Case 2
                addData(dtIN, DGV_in, selectedPage)
            Case 3
                addData(dtOUT, DGV_out, selectedPage)
        End Select
        Save_btn.FlatStyle = FlatStyle.Flat
    End Sub
    '===================================================================================
    '             === UPDATE data in DB ===
    '===================================================================================
    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Dim index As Integer
        selectedPage = tabcontrol.SelectedIndex
        Select Case selectedPage
            Case 2
                index = DGV_in.CurrentRow.Index
                updateData(dtIN, DGV_in, selectedPage, index)
            Case 3
                index = DGV_out.CurrentRow.Index
                updateData(dtOUT, DGV_out, selectedPage, index)
        End Select
        Save_btn.FlatStyle = FlatStyle.Flat
    End Sub
    '===================================================================================
    '             === DELETE data from DB ===
    '===================================================================================
    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        Dim index As Integer
        selectedPage = tabcontrol.SelectedIndex
        Select Case selectedPage
            Case 2
                index = DGV_in.CurrentRow.Index
                deleteData(dtIN, DGV_in, selectedPage, index)
            Case 3
                index = DGV_out.CurrentRow.Index
                deleteData(dtOUT, DGV_out, selectedPage, index)
        End Select
        Save_btn.FlatStyle = FlatStyle.Flat
    End Sub
    '===================================================================================
    '             === SAVE data to DB ===
    '===================================================================================
    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles Save_btn.Click

        Dim foundRowsPos() As DataRow
        Dim foundRowsNeg() As DataRow
        Dim currentIDLamp As String = idLamp_txt.Text
        Dim qty, qty_pos, qty_neg As Integer

        Dim copy_dtIN, copy_dtOUT As DataTable

        copy_dtIN = dtIN.Clone
        copy_dtOUT = dtOUT.Clone

        copy_dtIN.Clear()
        foundRowsPos = dtIN.Select("ID_Lamp = " & "'" & currentIDLamp & "'")

        'Console.WriteLine(foundRowsPos.Length)

        copy_dtOUT.Clear()
        foundRowsNeg = dtOUT.Select("ID_Lamp = " & "'" & currentIDLamp & "'")

        For i = 0 To foundRowsPos.Length - 1
            copy_dtIN.ImportRow(foundRowsPos(i))
            'foundRows(i).Delete()
        Next i

        For i = 0 To foundRowsNeg.Length - 1
            copy_dtOUT.ImportRow(foundRowsNeg(i))
            'foundRows(i).Delete()
        Next i

        DGV_in.DataSource = copy_dtIN
        DGV_out.DataSource = copy_dtOUT



        calcLamp()

        Save_btn.FlatStyle = FlatStyle.Standard

    End Sub
    '===================================================================================
    '             === FILTER data in DB ===
    '===================================================================================
    Private Sub filterIN_btn_Click(sender As Object, e As EventArgs) Handles filterIN_btn.Click
        filterData(dtIN, DGV_in)
    End Sub

    Private Sub filterOUT_btn_Click(sender As Object, e As EventArgs) Handles filterOUT_btn.Click
        filterData(dtOUT, DGV_out)
    End Sub
    Private Sub filterStore_btn_Click(sender As Object, e As EventArgs) Handles filterStore_btn.Click

    End Sub
    '===================================================================================
    '             === CLEAR FILTER data in DB ===
    '===================================================================================

    Private Sub clrFilterIN_btn_Click(sender As Object, e As EventArgs) Handles clrFilterIN_btn.Click
        DGV_in.DataSource = dtIN
    End Sub

    Private Sub clrFilterOUT_btn_Click(sender As Object, e As EventArgs) Handles clrFilterOUT_btn.Click
        DGV_out.DataSource = dtOUT
    End Sub

    Private Sub clrFilterStore_brn_Click(sender As Object, e As EventArgs) Handles clrFilterStore_brn.Click

    End Sub
    '===================================================================================
    '             === Run Image form ===
    '===================================================================================
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        imgForm.Show()
        imgForm.PictureBox1.Image = PictureBox1.Image

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = lampImg(4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = lampImg(8)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = lampImg(12)
    End Sub

End Class
