Module myFunctions

    '===================================================================================      
    '                === Select page ===
    '===================================================================================
    Sub selectPage(_control As Object)

        mainForm.selectStore_btn.BackColor = Color.Gainsboro
        mainForm.selectIN_btn.BackColor = Color.Gainsboro
        mainForm.selectOUT_btn.BackColor = Color.Gainsboro
        mainForm.selectTech_btn.BackColor = Color.Gainsboro
        mainForm.selectNewType_btn.BackColor = Color.Gainsboro

        _control.BackColor = Color.PeachPuff
        mainForm.GroupBox2.Visible = True

    End Sub
    '===================================================================================      
    '                === Next page ===
    '===================================================================================
    Sub nextPage()

        Dim index As Integer

        index = mainForm.tabcontrol.SelectedIndex

        If index = 5 Then
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
            index = 6
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
        Dim dt As DataTable
        dt = mainForm.dtStore
        index = _control_1.SelectedIndex
        Console.WriteLine(_datatable.Rows(index).Item(_colCount - 2))
        qty = _datatable.Rows(index).Item(_colCount - 2)
        'MsgBox(qty)
        _control_2.Items.Clear()
        For i = 1 To qty
            If (_datatable.Rows(index).Item(i) Is Nothing) Then
                Exit For
            Else
                _control_2.Items.Add(_datatable.Rows(index).Item(i))
            End If
        Next

        Try
            _control_2.Text = _datatable.Rows(index).Item(i - 1).ToString
            mainForm.idLamp_txt.Text = dt.Rows(index - 1).Item(2)
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

End Module
