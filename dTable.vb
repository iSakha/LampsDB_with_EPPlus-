Module dTable
    '===================================================================================      
    '                === Create datatable ===
    '===================================================================================
    Sub create_datatable(_rCount As Integer, _colCount As Integer, _rng As Object, _dt As DataTable, _dtName As String)
        Dim i, j As Integer
        Dim row As DataRow
        'Adding the Columns
        For i = 0 To _colCount - 1
            _dt.Columns.Add(_rng.Value(0, i))
        Next i
        _dt.TableName = _dtName
        Select Case _dtName
            Case "dtIN"
                _dt.Columns(0).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(1).DataType = System.Type.GetType("System.DateTime")
                _dt.Columns(2).DataType = System.Type.GetType("System.String")
                _dt.Columns(3).DataType = System.Type.GetType("System.String")
                _dt.Columns(4).DataType = System.Type.GetType("System.String")
                _dt.Columns(5).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(6).DataType = System.Type.GetType("System.String")
                _dt.Columns(7).DataType = System.Type.GetType("System.String")

                'Add Rows from Excel table

                For i = 1 To _rCount - 1
                    row = _dt.Rows.Add()
                    For j = 0 To _colCount - 1
                        If (j = 1) Then
                            row.Item(j) = Date.FromOADate(_rng.Value(i, j))
                        Else
                            row.Item(j) = _rng.Value(i, j)
                        End If
                    Next j
                Next i

            Case "dtOUT"

                _dt.Columns(0).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(1).DataType = System.Type.GetType("System.DateTime")
                _dt.Columns(2).DataType = System.Type.GetType("System.String")
                _dt.Columns(3).DataType = System.Type.GetType("System.String")
                _dt.Columns(4).DataType = System.Type.GetType("System.String")
                _dt.Columns(5).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(6).DataType = System.Type.GetType("System.String")
                _dt.Columns(7).DataType = System.Type.GetType("System.String")
                _dt.Columns(8).DataType = System.Type.GetType("System.String")

                'Add Rows from Excel table

                For i = 1 To _rCount - 1
                    row = _dt.Rows.Add()
                    For j = 0 To _colCount - 1
                        If (j = 1) Then
                            row.Item(j) = Date.FromOADate(_rng.Value(i, j))
                        Else
                            row.Item(j) = _rng.Value(i, j)
                        End If
                    Next j
                Next i

            Case "dtStore"

                _dt.Columns(0).DataType = System.Type.GetType("System.String")
                _dt.Columns(1).DataType = System.Type.GetType("System.String")
                _dt.Columns(2).DataType = System.Type.GetType("System.String")
                _dt.Columns(3).DataType = System.Type.GetType("System.String")
                _dt.Columns(4).DataType = System.Type.GetType("System.String")
                _dt.Columns(5).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(6).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(7).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(8).DataType = System.Type.GetType("System.Int32")
                _dt.Columns(9).DataType = System.Type.GetType("System.String")

                For i = 1 To _rCount - 1
                    row = _dt.Rows.Add()
                    For j = 0 To _colCount - 1
                        'If (i = 19) Then
                        row.Item(j) = _rng.Value(i, j)
                        'MsgBox(_rng.Value(19, j))
                        'Console.WriteLine(_rng.Value(i, j))
                        ' End If
                    Next j
                Next i

            Case Else

                'Add Rows from Excel table

                For i = 1 To _rCount - 1
                    row = _dt.Rows.Add()
                    For j = 0 To _colCount - 1
                        row.Item(j) = _rng.Value(i, j)
                    Next j
                Next i

        End Select

    End Sub
    '===================================================================================      
    '                === Format DataGridView ===
    '===================================================================================

    Sub DGV_format(_dtName As String)

        Select Case _dtName

            Case "dtIN"

                mainForm.DGV_in.Columns(0).Width = 50
                mainForm.DGV_in.Columns(1).Width = 80
                mainForm.DGV_in.Columns(2).Width = 50
                mainForm.DGV_in.Columns(3).Width = 220
                mainForm.DGV_in.Columns(4).Width = 80
                mainForm.DGV_in.Columns(5).Width = 50
                mainForm.DGV_in.Columns(6).Width = 120
                mainForm.DGV_in.Columns(7).Width = 230
                mainForm.DGV_in.Columns(8).Width = 230

                mainForm.DGV_in.Columns(0).HeaderText = "#"
                mainForm.DGV_in.Columns(1).HeaderText = "Date"
                mainForm.DGV_in.Columns(2).HeaderText = "ID_Lamp"
                mainForm.DGV_in.Columns(3).HeaderText = "Name"
                mainForm.DGV_in.Columns(4).HeaderText = "Location"
                mainForm.DGV_in.Columns(5).HeaderText = "Quantity"
                mainForm.DGV_in.Columns(6).HeaderText = "Fixture"
                mainForm.DGV_in.Columns(7).HeaderText = "Notes_1"
                mainForm.DGV_in.Columns(8).HeaderText = "Notes_2"

                For i = 0 To mainForm.rCountIN - 2
                    'mainForm.DGV_in.Rows(i).Cells(1).Value = Date.FromOADate(mainForm.DGV_in.Rows(i).Cells(1).Value)
                    mainForm.DGV_in.RowsDefaultCellStyle.BackColor = Color.Honeydew
                    mainForm.DGV_in.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
                Next i

            Case "dtOUT"

                mainForm.DGV_out.Columns(0).Width = 50
                mainForm.DGV_out.Columns(1).Width = 80
                mainForm.DGV_out.Columns(2).Width = 50
                mainForm.DGV_out.Columns(3).Width = 220
                mainForm.DGV_out.Columns(4).Width = 80
                mainForm.DGV_out.Columns(5).Width = 50
                mainForm.DGV_out.Columns(6).Width = 120
                mainForm.DGV_out.Columns(7).Width = 120
                mainForm.DGV_out.Columns(8).Width = 185
                mainForm.DGV_out.Columns(9).Width = 155

                mainForm.DGV_out.Columns(0).HeaderText = "#"
                mainForm.DGV_out.Columns(1).HeaderText = "Date"
                mainForm.DGV_out.Columns(2).HeaderText = "ID_Lamp"
                mainForm.DGV_out.Columns(3).HeaderText = "Name"
                mainForm.DGV_out.Columns(4).HeaderText = "Location"
                mainForm.DGV_out.Columns(5).HeaderText = "Quantity"
                mainForm.DGV_out.Columns(6).HeaderText = "Fixture"
                mainForm.DGV_out.Columns(7).HeaderText = "Personnel"
                mainForm.DGV_out.Columns(8).HeaderText = "Notes_1"
                mainForm.DGV_out.Columns(9).HeaderText = "Notes_2"

                For i = 0 To mainForm.rCountOUT - 2
                    'mainForm.DGV_out.Rows(i).Cells(1).Value = Date.FromOADate(mainForm.DGV_out.Rows(i).Cells(1).Value)
                    mainForm.DGV_out.RowsDefaultCellStyle.BackColor = Color.MistyRose
                    mainForm.DGV_out.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
                Next i

            Case "dtStore"

                mainForm.DGV_store.Columns(0).Width = 235
                mainForm.DGV_store.Columns(1).Width = 90
                mainForm.DGV_store.Columns(2).Width = 65
                mainForm.DGV_store.Columns(3).Width = 135
                mainForm.DGV_store.Columns(4).Width = 92
                mainForm.DGV_store.Columns(5).Width = 95
                mainForm.DGV_store.Columns(6).Width = 95
                mainForm.DGV_store.Columns(7).Width = 95
                mainForm.DGV_store.Columns(8).Width = 90
                mainForm.DGV_store.Columns(9).Width = 135

                mainForm.DGV_store.Columns(0).HeaderText = "Name"
                mainForm.DGV_store.Columns(1).HeaderText = "PartNumber"
                mainForm.DGV_store.Columns(2).HeaderText = "ID_Lamp"
                mainForm.DGV_store.Columns(3).HeaderText = "Fixture"
                mainForm.DGV_store.Columns(4).HeaderText = "LifeTime"
                mainForm.DGV_store.Columns(5).HeaderText = "Power"
                mainForm.DGV_store.Columns(6).HeaderText = "INcoming"
                mainForm.DGV_store.Columns(7).HeaderText = "OUTgoing"
                mainForm.DGV_store.Columns(8).HeaderText = "Quantity"
                mainForm.DGV_store.Columns(9).HeaderText = "Location"

                For i = 0 To mainForm.rCountStore - 2
                    'mainForm.DGV_store.Rows(i).Cells(1).Value = Date.FromOADate(mainForm.DGV_store.Rows(i).Cells(1).Value)
                    mainForm.DGV_store.RowsDefaultCellStyle.BackColor = Color.Gainsboro
                    mainForm.DGV_store.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
                Next i

        End Select

    End Sub
    '===================================================================================      
    '                === CellClick on DGV ===
    '===================================================================================
    Sub dgv_cellClick(_sender As Object, _e As DataGridViewCellEventArgs)

        Dim index As Integer
        index = _e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = _sender.Rows(index)
        mainForm.selectedPage = mainForm.tabcontrol.SelectedIndex

        Select Case mainForm.selectedPage

            Case 2

                mainForm.numRecord_txt.Text = selectedRow.Cells(0).Value.ToString
                mainForm.DTP.Text = selectedRow.Cells(1).Value.ToString
                mainForm.idLamp_txt.Text = selectedRow.Cells(2).Value.ToString
                mainForm.lampName_cmb.Text = selectedRow.Cells(3).Value.ToString
                mainForm.location_cmb.Text = selectedRow.Cells(4).Value.ToString
                mainForm.qty_txt.Text = selectedRow.Cells(5).Value.ToString
                mainForm.fxt_cmb.Text = selectedRow.Cells(6).Value.ToString
                mainForm.notes1_txt.Text = selectedRow.Cells(7).Value.ToString
                mainForm.notes2_txt.Text = selectedRow.Cells(8).Value.ToString

            Case 3

                mainForm.numRecord_txt.Text = selectedRow.Cells(0).Value.ToString
                mainForm.DTP.Text = selectedRow.Cells(1).Value.ToString
                mainForm.idLamp_txt.Text = selectedRow.Cells(2).Value.ToString
                mainForm.lampName_cmb.Text = selectedRow.Cells(3).Value.ToString
                mainForm.location_cmb.Text = selectedRow.Cells(4).Value.ToString
                mainForm.qty_txt.Text = selectedRow.Cells(5).Value.ToString
                mainForm.fxt_cmb.Text = selectedRow.Cells(6).Value.ToString
                mainForm.pers_cmb.Text = selectedRow.Cells(7).Value.ToString
                mainForm.notes1_txt.Text = selectedRow.Cells(8).Value.ToString
                mainForm.notes2_txt.Text = selectedRow.Cells(9).Value.ToString

        End Select

    End Sub

End Module
