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
    Sub selectLamp_Or_Fixture(_control_1 As Object, _control_2 As Object, _colCount As Integer, _datatable As DataTable, _IDtxt As Object)
        Dim index, i, qty As Integer
        Dim dt As DataTable
        dt = mainForm.dtStore
        index = _control_1.SelectedIndex
        qty = _datatable.Rows(index).Item(_colCount - 1)
        'MsgBox(qty)
        _control_2.Items.Clear()
        For i = 1 To qty
            If (_datatable.Rows(index).Item(i) Is Nothing) Then
                Exit For
            Else
                _control_2.Items.Add(_datatable.Rows(index).Item(i))
            End If
        Next
        _control_2.Text = _datatable.Rows(index).Item(i - 1).ToString
        _IDtxt.Text = dt.Rows(index - 1).Item(2)

    End Sub


End Module
