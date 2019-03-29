Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim DB As DBxdataset.TCTransferDataTable = New DBxdataset.TCTransferDataTable
        Dim Ap As DBxdatasetTableAdapters.TCTransferTableAdapter = New DBxdatasetTableAdapters.TCTransferTableAdapter
        Ap.Fill(DB, "%C01%")
        For Each data As DBxdataset.TCTransferRow In DB

            '    data.LotEndTime = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Next
        DataGridView1.DataSource = DB
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CbCartNo.Items.Clear()
        Dim DBCart As DBxdataset.CartNoDataTable = New DBxdataset.CartNoDataTable
        Dim ApCart As DBxdatasetTableAdapters.CartNoTableAdapter = New DBxdatasetTableAdapters.CartNoTableAdapter
        ApCart.Fill(DBCart)
        For Each data As DBxdataset.CartNoRow In DBCart
            CbCartNo.Items.Add(data.Cart)
        Next
        CbCartNo.SelectedIndex = 0
    End Sub
    Enum Mode
        GetdataCart
        CancelCart
    End Enum
    Private Function getCart(CartNo As String, Optional GetMode As Int16 = Mode.GetdataCart) As DBxdataset.TCTransferDataTable
        Dim DB As DBxdataset.TCTransferDataTable = New DBxdataset.TCTransferDataTable
        Dim Ap As DBxdatasetTableAdapters.TCTransferTableAdapter = New DBxdatasetTableAdapters.TCTransferTableAdapter
        Ap.Fill(DB, "%" & CartNo & "%")
        If GetMode = Mode.CancelCart Then
            For Each data As DBxdataset.TCTransferRow In DB

                data.LotEndTime = Format(Now, "yyyy-MM-dd HH:mm:ss")
            Next
            Ap.Update(DB)
        End If

        ' DataGridView1.DataSource = DB
        Return DB
    End Function
    Private Sub AscButton1_Click(sender As Object, e As EventArgs) Handles AscButton1.Click
        Dim frm As Password = New Password
        If frm.ShowDialog() = DialogResult.OK Then
            DataGridView1.DataSource = getCart(CbCartNo.Text, Mode.CancelCart)
            MsgBox("Remove from cart สำเร็จ")
        End If

    End Sub

    Private Sub CbCartNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCartNo.SelectedIndexChanged
        DataGridView1.DataSource = getCart(CbCartNo.Text)
    End Sub

    Private Sub APCSStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APCSStaffToolStripMenuItem.Click
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/ApcsStaff", AppWinStyle.NormalFocus)
    End Sub
End Class
