Public Class Form3
    Private Sub TargetsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TargetsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TargetsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Targets1DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Targets1DataSet.Targets' table. You can move, or remove it, as needed.
        Me.TargetsTableAdapter.Fill(Me.Targets1DataSet.Targets)

        If Form1.bltmore = True Then


            If Form1.currentLocation <> 1 Then

                btnBalt.Visible = True

            End If

            lblBalt.Visible = True
            Dim baltTargets = From targets In Targets1DataSet.Targets
                              Where targets.Current_Location = "Baltimore, Maryland"
                              Order By targets.Name Ascending

            TargetsBindingSource.DataSource = baltTargets
        End If

        If Form1.caracas = True Then


            If Form1.currentLocation <> 2 Then

                btnCarac.Visible = True

            End If

            lblCarac.Visible = True
            Dim baltTargets = From targets In Targets1DataSet.Targets
                              Where targets.Current_Location = "Caracas, Venezuela"
                              Order By targets.Name Ascending

            TargetsBindingSource.DataSource = baltTargets
        End If

        If Form1.barcelone = True Then

            If Form1.currentLocation <> 3 Then
                btnBarcel.Visible = True

            End If

            lblBarc.Visible = True
            Dim baltTargets = From targets In Targets1DataSet.Targets
                              Where targets.Current_Location = "Barcelona, Spain"
                              Order By targets.Name Ascending

            TargetsBindingSource.DataSource = baltTargets

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Form1.caracas = False
        Form1.barcelone = False
        Form1.bltmore = False

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBalt.Click

        Dim dlgButton As DialogResult

        If Form1.currentLocation <> 1 Then

            If Form1.currentLocation = 2 Then

                dlgButton = MessageBox.Show("Fly To Baltimore, Maryland?" + vbCrLf + vbCrLf + "This trip will take 3 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    Form1.intHours = Form1.intHours - 3
                    Form1.currentLocation = 1
                    Form1.lblCurrentLocation.Text = "Baltimore, Maryland"
                    Form1.lblCurrentLocation.ForeColor = Color.Coral
                    btnBalt.Enabled = False

                Else

                    Exit Sub

                End If

            End If

            If Form1.currentLocation = 3 Then

                dlgButton = MessageBox.Show("Fly To Baltimore, Maryland?" + vbCrLf + vbCrLf + "This trip will take 5 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    Form1.intHours = Form1.intHours - 5
                    Form1.currentLocation = 1

                    Form1.lblCurrentLocation.Text = "Baltimore, Maryland"
                    Form1.lblCurrentLocation.ForeColor = Color.Coral
                    btnBalt.Enabled = False

                Else


                End If

            End If

        End If
    End Sub

    Private Sub btnBarcel_Click(sender As Object, e As EventArgs) Handles btnBarcel.Click

        Dim dlgButton As DialogResult

        If Form1.currentLocation <> 3 Then

            If Form1.currentLocation = 2 Then

                dlgButton = MessageBox.Show("Fly To Barcelona, Spain?" + vbCrLf + vbCrLf + "This trip will take 6 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    Form1.intHours = Form1.intHours - 6
                    Form1.currentLocation = 3
                    Form1.lblCurrentLocation.Text = "Barcelona, Spain"
                    Form1.lblCurrentLocation.ForeColor = Color.Red
                    btnBarcel.Enabled = False
                Else

                    Exit Sub

                End If

            End If


            If Form1.currentLocation = 1 Then

                dlgButton = MessageBox.Show("Fly To Barcelona, Spain?" + vbCrLf + vbCrLf + "This trip will take 5 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    Form1.intHours = Form1.intHours - 5
                    Form1.currentLocation = 3
                    Form1.lblCurrentLocation.Text = "Barcelona, Spain"
                    Form1.lblCurrentLocation.ForeColor = Color.Red
                    btnBarcel.Enabled = False

                Else
                    Exit Sub

                End If

            End If
        End If
    End Sub

    Private Sub btnCarac_Click(sender As Object, e As EventArgs) Handles btnCarac.Click


        Dim dlgButton As DialogResult

        If Form1.currentLocation <> 2 Then

            If Form1.currentLocation = 1 Then

                dlgButton = MessageBox.Show("Fly To Caracas, Venezuela?" + vbCrLf + "This trip will take 3 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    Form1.intHours = Form1.intHours - 3
                    Form1.currentLocation = 2
                    Form1.lblCurrentLocation.Text = "Caracas, Venezuela"
                    Form1.lblCurrentLocation.ForeColor = Color.Blue
                    btnCarac.Enabled = False
                Else
                    Exit Sub

                End If

            End If

            If Form1.currentLocation = 3 Then

                dlgButton = MessageBox.Show("Fly To Caracas, Venezuela?" + vbCrLf + vbCrLf + "This trip will take 6 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    Form1.intHours = Form1.intHours - 6
                    Form1.currentLocation = 2

                    Form1.lblCurrentLocation.Text = "Caracas, Venezuela"
                    Form1.lblCurrentLocation.ForeColor = Color.Blue
                    btnCarac.Enabled = False

                Else

                    Exit Sub

                End If

            End If
        End If
    End Sub
End Class