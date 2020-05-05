Module myFunctions

    '===================================================================================      
    '                === Next page ===
    '===================================================================================
    Sub nextPage()

        Dim index As Integer

        index = mainForm.tabcontrol.SelectedIndex

        If index = 3 Then
            index = -1
        End If
        index = index + 1
        mainForm.tabcontrol.SelectedIndex = index
        mainForm.selectedPage = mainForm.pages(index)

    End Sub
    '===================================================================================      
    '                === Prev page ===
    '===================================================================================
    Sub prevPage()
        Dim index As Integer
        index = mainForm.tabcontrol.SelectedIndex

        If index = 0 Then
            index = 4
        End If
        index = index - 1
        mainForm.tabcontrol.SelectedIndex = index
        mainForm.selectedPage = mainForm.pages(index)
    End Sub
    '===================================================================================      
    '                === Add items to combobox ===
    '===================================================================================
    Sub addItemsToCombobox(_control As Object, _rCount As Integer, _datatable As DataTable)

        Dim i As Integer
        For i = 0 To _rCount - 2
            _control.Items.Add(_datatable.Rows(i).Item(0))
        Next

    End Sub
    '===================================================================================      
    '                === Select Lamp or Fixture ===
    '===================================================================================
    Sub selectLamp_Or_Fixture(_control_1 As Object, _control_2 As Object, _colCount As Integer, _datatable As DataTable)

        Dim index, i, qty As Integer
        Dim dt, dt_lamp, dt_fixture As DataTable

        dt = mainForm.dtStore
        dt_lamp = mainForm.dtlampToFixture
        dt_fixture = mainForm.dtfxtToLamp

        index = _control_1.SelectedIndex
        Console.WriteLine(_datatable.Rows(index).Item(_colCount - 1))
        qty = _datatable.Rows(index).Item(_colCount - 1)
        'MsgBox(qty)
        _control_2.Items.Clear()
        For i = 1 To qty
            If (_datatable.Rows(index).Item(i + 1) Is Nothing) Then
                Exit For
            Else
                _control_2.Items.Add(_datatable.Rows(index).Item(i + 1))
            End If
        Next

        Try
            _control_2.Text = _datatable.Rows(index).Item(i).ToString
            mainForm.idLamp_txt.Text = _datatable.Rows(index).Item(1)
        Catch ex As Exception

        End Try
    End Sub
    '===================================================================================
    '             === ADD data to DB ===
    '===================================================================================
    Sub addData(_dt As DataTable, _dgv As DataGridView, _selectedPage As Integer)

        Dim rCount As Integer
        Dim sRow() As String
        rCount = _dt.Rows.Count
        mainForm.numRecord_txt.Text = _dgv.Rows(rCount - 1).Cells(0).Value + 1

        Select Case _selectedPage
            Case 2

                sRow = New String() {
                mainForm.numRecord_txt.Text,
                mainForm.DTP.Text,
                mainForm.idLamp_txt.Text,
                mainForm.lampName_cmb.Text,
                mainForm.location_cmb.Text,
                mainForm.qty_txt.Text,
                mainForm.fxt_cmb.Text,
                mainForm.notes1_txt.Text,
                mainForm.notes2_txt.Text
            }

            Case 3

                sRow = New String() {
                mainForm.numRecord_txt.Text,
                mainForm.DTP.Text,
                mainForm.idLamp_txt.Text,
                mainForm.lampName_cmb.Text,
                mainForm.location_cmb.Text,
                mainForm.qty_txt.Text,
                mainForm.fxt_cmb.Text,
                mainForm.pers_cmb.Text,
                mainForm.notes1_txt.Text,
                mainForm.notes2_txt.Text
            }

        End Select

        Dim row As DataRow

        row = _dt.Rows.Add()

        For i As Integer = 0 To sRow.Count - 1
            row.Item(i) = sRow(i)
        Next i

        _dgv.DataSource = _dt

    End Sub

    '===================================================================================
    '             === UPDATE data in DB ===
    '===================================================================================

    Sub updateData(_dt As DataTable, _dgv As DataGridView, _selectedPage As Integer, _index As Integer)
        Dim row As DataRow
        row = _dt.Rows(_index)
        Dim sRow() As String

        Select Case _selectedPage
            Case 2

                sRow = New String() {
                mainForm.numRecord_txt.Text,
                mainForm.DTP.Text,
                mainForm.idLamp_txt.Text,
                mainForm.lampName_cmb.Text,
                mainForm.location_cmb.Text,
                mainForm.qty_txt.Text,
                mainForm.fxt_cmb.Text,
                mainForm.notes1_txt.Text,
                mainForm.notes2_txt.Text
            }

            Case 3

                sRow = New String() {
                mainForm.numRecord_txt.Text,
                mainForm.DTP.Text,
                mainForm.idLamp_txt.Text,
                mainForm.lampName_cmb.Text,
                mainForm.location_cmb.Text,
                mainForm.qty_txt.Text,
                mainForm.fxt_cmb.Text,
                mainForm.pers_cmb.Text,
                mainForm.notes1_txt.Text,
                mainForm.notes2_txt.Text
            }

        End Select

        For Each column As DataGridViewColumn In _dgv.Columns
            row.Item(column.Index) = sRow(column.Index)
        Next
        _dgv.DataSource = _dt
    End Sub

    '===================================================================================
    '             === DELETE data from DB ===
    '===================================================================================

    Sub deleteData(_dt As DataTable, _dgv As DataGridView, _selectedPage As Integer, _index As Integer)
        Dim rowCollection As DataRowCollection = _dt.Rows
        rowCollection.RemoveAt(_index)
        _dgv.DataSource = _dt
    End Sub

    '===================================================================================
    '             === FILTER data in DB ===
    '===================================================================================
    Sub filterData(_dt As DataTable, _DGV As DataGridView)

        Dim foundRows() As DataRow
        Dim currentIDLamp As String = mainForm.idLamp_txt.Text
        Dim copy_dt As DataTable

        copy_dt = _dt.Clone
        copy_dt.Clear()
        foundRows = _dt.Select("ID_Lamp = " & "'" & currentIDLamp & "'")

        For i = 0 To foundRows.Length - 1
            copy_dt.ImportRow(foundRows(i))
        Next i

        _DGV.DataSource = copy_dt

    End Sub
    '===================================================================================
    '             === Calculate quantity selected lamps ===
    '===================================================================================
    Sub calcLamp()

        Dim foundRowsPos() As DataRow
        Dim foundRowsNeg() As DataRow
        Dim currentIDLamp As String = mainForm.idLamp_txt.Text
        Dim qty, qty_pos, qty_neg As Integer
        Dim index As Integer = mainForm.lampName_cmb.SelectedIndex

        foundRowsPos = mainForm.dtIN.Select("ID_Lamp = " & "'" & currentIDLamp & "'")
        foundRowsNeg = mainForm.dtOUT.Select("ID_Lamp = " & "'" & currentIDLamp & "'")

        qty = 0
        qty_pos = 0
        qty_neg = 0

        For i = 0 To foundRowsPos.Length - 1
            qty_pos = qty_pos + foundRowsPos(i).Item(5)
        Next i

        Console.WriteLine(qty_pos)

        For i = 0 To foundRowsNeg.Length - 1
            qty_neg = qty_neg + foundRowsNeg(i).Item(5)
        Next i

        Console.WriteLine(qty_neg)

        qty = qty_pos - qty_neg

        Console.WriteLine(qty)

        mainForm.dtStore.Rows(index - 1).Item("INcoming") = qty_pos
        mainForm.dtStore.Rows(index - 1).Item("OUTgoing") = qty_neg
        mainForm.dtStore.Rows(index - 1).Item("Quantity") = qty


    End Sub
    '===================================================================================
    '             === Clear controls ===
    '===================================================================================
    Sub clearControls()

        mainForm.RadioButton1.Checked = True
        mainForm.numRecord_txt.Clear()
        mainForm.idLamp_txt.Clear()
        mainForm.lampName_cmb.Text = ""
        mainForm.lampName_cmb.BackColor = Color.White
        mainForm.pers_cmb.Text = ""
        mainForm.location_cmb.Text = ""
        mainForm.qty_txt.Clear()
        mainForm.fxt_cmb.Text = ""
        mainForm.notes1_txt.Clear()
        mainForm.notes2_txt.Clear()
        mainForm.hide_showLabels(True)

    End Sub

    '===================================================================================      
    '                === Next Lamp ===
    '===================================================================================
    Sub nextLamp()

        Dim index As Integer
        Dim selectedRow As DataGridViewRow

        index = mainForm.DGV_store.CurrentRow.Index

        selectedRow = mainForm.DGV_store.Rows(index)

        mainForm.DGV_store.ClearSelection()
        mainForm.DGV_store.CurrentCell = mainForm.DGV_store.Item(0, index)
        mainForm.DGV_store.Rows(index).Selected = True

        If index = mainForm.DGV_store.Rows.Count - 1 Then
            index = -1
        End If
        index = index + 1
        mainForm.DGV_store.CurrentCell = mainForm.DGV_store.Item(0, index)
        mainForm.DGV_store.Rows(index).Selected = True
        Try
            mainForm.numRecord_txt.Text = ""
            mainForm.DTP.Text = ""
            mainForm.idLamp_txt.Text = selectedRow.Cells(2).Value.ToString
            mainForm.lampName_cmb.Text = selectedRow.Cells(0).Value.ToString
            mainForm.location_cmb.Text = selectedRow.Cells(9).Value.ToString
            mainForm.qty_txt.Text = ""
            mainForm.fxt_cmb.Text = selectedRow.Cells(3).Value.ToString
            mainForm.pers_cmb.Text = ""
            mainForm.notes1_txt.Text = ""
            mainForm.notes2_txt.Text = ""
        Catch

        End Try
    End Sub
    '===================================================================================      
    '                === Prev Lamp ===
    '===================================================================================
    Sub prevLamp()

        Dim index As Integer
        Dim selectedRow As DataGridViewRow

        index = mainForm.DGV_store.CurrentRow.Index

        selectedRow = mainForm.DGV_store.Rows(index)

        mainForm.DGV_store.ClearSelection()
        mainForm.DGV_store.CurrentCell = mainForm.DGV_store.Item(0, index)
        mainForm.DGV_store.Rows(index).Selected = True

        If index = 0 Then
            index = mainForm.DGV_store.Rows.Count
        End If
        index = index - 1
        mainForm.DGV_store.CurrentCell = mainForm.DGV_store.Item(0, index)
        mainForm.DGV_store.Rows(index).Selected = True

        Try
            mainForm.numRecord_txt.Text = ""
            mainForm.DTP.Text = ""
            mainForm.idLamp_txt.Text = selectedRow.Cells(2).Value.ToString
            mainForm.lampName_cmb.Text = selectedRow.Cells(0).Value.ToString
            mainForm.location_cmb.Text = selectedRow.Cells(9).Value.ToString
            mainForm.qty_txt.Text = ""
            mainForm.fxt_cmb.Text = selectedRow.Cells(3).Value.ToString
            mainForm.pers_cmb.Text = ""
            mainForm.notes1_txt.Text = ""
            mainForm.notes2_txt.Text = ""
        Catch

        End Try
    End Sub

End Module
