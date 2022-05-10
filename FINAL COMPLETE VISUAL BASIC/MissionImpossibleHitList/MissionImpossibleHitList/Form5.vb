Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.Items.Add(1)
        ListBox1.Items.Add(5)
        ListBox1.Items.Add(7)
        ListBox1.Items.Add(10)
        ListBox1.Items.Add(12)
        ListBox1.Items.Add(16)
        ListBox1.Items.Add(20)
        ListBox1.SelectedIndex = "0"

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Form4.btnFind.Visible = False

        Form1.searched = True
        Form1.intHours = Form1.intHours - ListBox1.SelectedItem

        Dim dlgButton As DialogResult

        Dim randNum(0) As Integer                   'Beginning of random number generator
        For i As Integer = 0 To randNum.Length - 1
            randNum(i) = GetRandom(1, 1000000 / ListBox1.SelectedItem * 100)
        Next


        Dim luck(0) As Integer                   'Beginning of random number generator
        For i As Integer = 0 To luck.Length - 1
            luck(i) = GetRandom(1, 100)

        Next

        If luck(0) > randNum(0) Then

            dlgButton = MessageBox.Show("After " + ListBox1.SelectedItem.ToString + " hours of hacking, making phone calls, and driving around the city, you successfully find your family!! You easily eliminate the poorly armed kidnappers and fly your family to a safe location! Congratulations!", "", MessageBoxButtons.OK)

        Else
            dlgButton = MessageBox.Show("After " + ListBox1.SelectedItem.ToString + " hours of hacking, making phone calls, and driving around the city, you are unable to find your family", "", MessageBoxButtons.OK)

        End If

        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm As New Form4
        MyForm.Show()
        Me.Close()


    End Sub
End Class