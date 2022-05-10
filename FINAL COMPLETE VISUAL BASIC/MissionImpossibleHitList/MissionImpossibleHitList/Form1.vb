Public Class Form1

    Public trys As Integer = 0    'My next and back button variable

    Public intHours As Double = 72
    Public intMinutes As Double = 0
    Public intSeconds As Double = 0

    Public currentLocation As Integer = 1
    Public targetLocation As Integer = 3
    Public bankAccount As Integer = 10000

    Public searched As Boolean = False
    Public called As Boolean = False
    Public asked As Boolean = False

    Public bltmore As Boolean = False
    Public barcelone As Boolean = False
    Public caracas As Boolean = False


    Public missionOneComplete As Boolean = False
    Public missionTwoComplete As Boolean = False
    Public missionThreeComplete As Boolean = False
    Public missionFourComplete As Boolean = False
    Public missionFiveComplete As Boolean = False
    Public missionSixComplete As Boolean = False
    Public missionSevenComplete As Boolean = False
    Public missionEightComplete As Boolean = False
    Public missionNineComplete As Boolean = False
    Public missionTenComplete As Boolean = False
    Public missionElevenComplete As Boolean = False
    Public missionTwelveComplete As Boolean = False
    Public missionThirteenComplete As Boolean = False
    Public missionFourteenComplete As Boolean = False
    Public missionFifteenComplete As Boolean = False
    Public missionSixteenComplete As Boolean = False
    Public missionSeventeenComplete As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        'TODO: This line of code loads data into the 'Targets1DataSet.Targets' table. You can move, or remove it, as needed.

        Me.TargetsTableAdapter.Fill(Me.Targets1DataSet.Targets)

        Dim strButton As DialogResult

        strButton = MessageBox.Show("You receive a phone call from a unknown number, and to your horror, you hear your wife and children crying frantically. You ask your wife what is wrong, but before she can answer, a man briefs you that your family has been kidnapped. He says you have 72 hours to wire him 2.5 million dollars, or you will never see your family again. Before you get a chance to say anything, the kidnapper hangs up the phone. You call back several times, but your calls are ignored.", "")
        If strButton = DialogResult.OK Then

            MessageBox.Show("You have 72 hours to come up with $2.5 Million dollars to pay your family's ransom" + vbCrLf + vbCrLf + "You call your friend, and he gives you a list of people that you can kill in order to make that kind of money as fast as possible." + vbCrLf + vbCrLf + "Every move you make will cost time." + vbCrLf + vbCrLf + "You have a much more likely to chance to complete missions if you take the time to prepare for them, so do not rush through every mission." + vbCrLf + vbCrLf + "The higher the threat level of the target, the harder it will be for you to kill the target successfully.", "Your Family Has Been Kidnapped")

        End If

        BackgroundWorker1.RunWorkerAsync()

        btnBack.Enabled = False

        Dim data As String = Targets1DataSet.Targets(trys).Offense()
        Dim data2 As String = Targets1DataSet.Targets(trys).Name()
        Dim data3 As String = Targets1DataSet.Targets(trys).Ethinicity()
        Dim data4 As String = Targets1DataSet.Targets(trys).Height()
        Dim data5 As String = Targets1DataSet.Targets(trys).Weight()
        Dim data6 As String = Targets1DataSet.Targets(trys).Priority()
        Dim data7 As String = Targets1DataSet.Targets(trys).Current_Location()
        Dim data8 As String = Targets1DataSet.Targets(trys).Code_Name()

        Label1.Text = intHours.ToString + " : " + intMinutes.ToString + " : " + intSeconds.ToString

        Label2.Text = "Target Wanted For:" + vbCrLf + vbCrLf + data

        Label3.Text = "Real Name: " + data2 + vbCrLf + vbCrLf + "Ethnicity: " + data3 + vbCrLf + vbCrLf + "Height: " + data4 + vbCrLf + vbCrLf + "Weight: " + data5 + vbCrLf + vbCrLf + "Known Threat Level: " + data6 + vbCrLf + vbCrLf + "Current Location: " + data7

        Label4.Text = data8

        Label5.Text = "$85,000"

    End Sub

    Private Sub TargetsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Me.Validate()
        Me.TargetsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Targets1DataSet)

    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)

    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        Me.Close()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If intHours < 0.0 Then
            Dim dlgButton As DialogResult

            dlgButton = MessageBox.Show("Your time has ran out. You receive a phone call from the kidnappers> They let you speak to your family one last time before your hear loud noises and crying over the phone. 'I'm sorry', says the man on the phone, 'you will never see your family again'. He hangs up the phone")

            btnAcceptTarget.Enabled = False
            btnNext.Enabled = False
            btnBack.Enabled = False
            btnBankAccount.Enabled = False
            btnKidnappers.Enabled = False
            btnLottery.Enabled = False
            btnBarcQuery.Enabled = False
            btnBltQuery.Enabled = False
            btnCaracQuery.Enabled = False

        End If

        trys = trys + 1

        'Code to display database cells onto specific labels
        Dim data As String = Targets1DataSet.Targets(trys).Offense()
        Dim data2 As String = Targets1DataSet.Targets(trys).Name()
        Dim data3 As String = Targets1DataSet.Targets(trys).Ethinicity()
        Dim data4 As String = Targets1DataSet.Targets(trys).Height()
        Dim data5 As String = Targets1DataSet.Targets(trys).Weight()
        Dim data6 As String = Targets1DataSet.Targets(trys).Priority()
        Dim data7 As String = Targets1DataSet.Targets(trys).Current_Location()
        Dim data8 As String = Targets1DataSet.Targets(trys).Code_Name()

        Label2.Text = "Target Wanted For:" + vbCrLf + vbCrLf + data

        Label3.Text = "Real Name: " + data2 + vbCrLf + vbCrLf + "Ethnicity: " + data3 + vbCrLf + vbCrLf + "Height: " + data4 + vbCrLf + vbCrLf + "Weight: " + data5 + vbCrLf + vbCrLf + "Known Threat Level: " + data6 + vbCrLf + vbCrLf + "Current Location: " + data7

        Label4.Text = data8


        'Target Locations, 1 = Baltimore, Maryland
        '2 = Caracas, Venezuela
        '3 = Barcenlona, Spain

        If trys = 0 Then
            picTwo.Visible = False
            picOne.Visible = True
            btnBack.Enabled = False
            picSeven.Visible = False

            Label5.Text = "$85,000"

            If missionOneComplete = True Then

                picOne.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3


        ElseIf trys = 1 Then

            picTwo.Visible = True
            picOne.Visible = False
            picThree.Visible = False
            btnBack.Enabled = True
            Label5.Text = "$150,000"

            If missionTwoComplete = True Then

                picTwo.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 2 Then

            picThree.Visible = True
            picTwo.Visible = False
            picFour.Visible = False
            Label5.Text = "$250,000"

            If missionThreeComplete = True Then

                picThree.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 3 Then

            picThree.Visible = False
            picFive.Visible = False
            picFour.Visible = True
            Label5.Text = "$220,000"

            If missionFourComplete = True Then

                picFour.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 4 Then

            picFive.Visible = True
            picSix.Visible = False
            picFour.Visible = False
            Label5.Text = "$170,000"

            If missionFiveComplete = True Then

                picFive.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 5 Then

            picSix.Visible = True
            picFive.Visible = False
            picSeven.Visible = False
            Label5.Text = "$1,050,000"

            If missionSixComplete = True Then

                picSix.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 6 Then

            picSeven.Visible = True
            picEight.Visible = False
            picSix.Visible = False
            Label5.Text = "$120,000"

            If missionSevenComplete = True Then

                picSeven.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1


        ElseIf trys = 7 Then

            picEight.Visible = True
            picSeven.Visible = False
            picNine.Visible = False
            Label5.Text = "$440,000"

            If missionEightComplete = True Then

                picEight.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 8 Then

            picNine.Visible = True
            picTen.Visible = False
            picEight.Visible = False
            Label5.Text = "$150,000"

            If missionNineComplete = True Then

                picNine.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 9 Then

            picTen.Visible = True
            picEleven.Visible = False
            picNine.Visible = False
            Label5.Text = "$50,000"

            If missionTenComplete = True Then

                picTen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 10 Then

            picEleven.Visible = True
            picTen.Visible = False
            picTwelve.Visible = False
            Label5.Text = "$20,000"

            If missionElevenComplete = True Then

                picEleven.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 11 Then

            picTwelve.Visible = True
            picEleven.Visible = False
            picThirteen.Visible = False
            Label5.Text = "$350,000"

            If missionTwelveComplete = True Then

                picTwelve.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 12 Then

            picThirteen.Visible = True
            picTwelve.Visible = False
            picFourteen.Visible = False
            Label5.Text = "$150,000"

            If missionThirteenComplete = True Then

                picThirteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 13 Then

            picFourteen.Visible = True
            picThirteen.Visible = False
            picFifteen.Visible = False
            Label5.Text = "$1,000,000"

            If missionFourteenComplete = True Then

                picFourteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 14 Then

            picFifteen.Visible = True
            picFourteen.Visible = False
            picSixteen.Visible = False
            Label5.Text = "$550,000"

            If missionFifteenComplete = True Then

                picFifteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 15 Then

            picSixteen.Visible = True
            picFifteen.Visible = False
            picSeventeen.Visible = False
            btnNext.Enabled = True
            Label5.Text = "$750,000"

            If missionSixteenComplete = True Then

                picSixteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 16 Then

            picSeventeen.Visible = True
            picSixteen.Visible = False
            btnNext.Enabled = False
            Label5.Text = "$1,500,500"

            If missionSeventeenComplete = True Then

                picSeventeen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If intHours < 0.0 Then
            Dim dlgButton As DialogResult

            dlgButton = MessageBox.Show("Your time has ran out. You receive a phone call from the kidnappers> They let you speak to your family one last time before your hear loud noises and crying over the phone. 'I'm sorry', says the man on the phone, 'you will never see your family again'. He hangs up the phone")

            btnAcceptTarget.Enabled = False
            btnNext.Enabled = False
            btnBack.Enabled = False
            btnBankAccount.Enabled = False
            btnKidnappers.Enabled = False
            btnLottery.Enabled = False
            btnBarcQuery.Enabled = False
            btnBltQuery.Enabled = False
            btnCaracQuery.Enabled = False

        End If

        trys = trys - 1

        'Code to display database cells onto specific labels
        Dim data As String = Targets1DataSet.Targets(trys).Offense()
        Dim data2 As String = Targets1DataSet.Targets(trys).Name()
        Dim data3 As String = Targets1DataSet.Targets(trys).Ethinicity()
        Dim data4 As String = Targets1DataSet.Targets(trys).Height()
        Dim data5 As String = Targets1DataSet.Targets(trys).Weight()
        Dim data6 As String = Targets1DataSet.Targets(trys).Priority()
        Dim data7 As String = Targets1DataSet.Targets(trys).Current_Location()
        Dim data8 As String = Targets1DataSet.Targets(trys).Code_Name()

        Label2.Text = "Target Wanted For:" + vbCrLf + vbCrLf + data

        Label3.Text = "Real Name: " + data2 + vbCrLf + vbCrLf + "Ethnicity: " + data3 + vbCrLf + vbCrLf + "Height: " + data4 + vbCrLf + vbCrLf + "Weight: " + data5 + vbCrLf + vbCrLf + "Known Threat Level: " + data6 + vbCrLf + vbCrLf + "Current Location: " + data7

        Label4.Text = data8


        'Target Locations, 1 = Baltimore, Maryland
        '2 = Caracas, Venezuela
        '3 = Barcenlona, Spain

        If trys = 0 Then
            picTwo.Visible = False
            picOne.Visible = True
            btnBack.Enabled = False
            picSeven.Visible = False

            Label5.Text = "$85,000"

            If missionOneComplete = True Then

                picOne.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3


        ElseIf trys = 1 Then

            picTwo.Visible = True
            picOne.Visible = False
            picThree.Visible = False
            btnBack.Enabled = True
            Label5.Text = "$150,000"

            If missionTwoComplete = True Then

                picTwo.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 2 Then

            picThree.Visible = True
            picTwo.Visible = False
            picFour.Visible = False
            Label5.Text = "$250,000"

            If missionThreeComplete = True Then

                picThree.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 3 Then

            picThree.Visible = False
            picFive.Visible = False
            picFour.Visible = True
            Label5.Text = "$220,000"

            If missionFourComplete = True Then

                picFour.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 4 Then

            picFive.Visible = True
            picSix.Visible = False
            picFour.Visible = False
            Label5.Text = "$170,000"

            If missionFiveComplete = True Then

                picFive.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 5 Then

            picSix.Visible = True
            picFive.Visible = False
            picSeven.Visible = False
            Label5.Text = "$1,050,000"

            If missionSixComplete = True Then

                picSix.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 6 Then

            picSeven.Visible = True
            picEight.Visible = False
            picSix.Visible = False
            Label5.Text = "$120,000"

            If missionSevenComplete = True Then

                picSeven.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1


        ElseIf trys = 7 Then

            picEight.Visible = True
            picSeven.Visible = False
            picNine.Visible = False
            Label5.Text = "$440,000"

            If missionEightComplete = True Then

                picEight.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 8 Then

            picNine.Visible = True
            picTen.Visible = False
            picEight.Visible = False
            Label5.Text = "$150,000"

            If missionNineComplete = True Then

                picNine.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 9 Then

            picTen.Visible = True
            picEleven.Visible = False
            picNine.Visible = False
            Label5.Text = "$50,000"

            If missionTenComplete = True Then

                picTen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 10 Then

            picEleven.Visible = True
            picTen.Visible = False
            picTwelve.Visible = False
            Label5.Text = "$20,000"

            If missionElevenComplete = True Then

                picEleven.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 11 Then

            picTwelve.Visible = True
            picEleven.Visible = False
            picThirteen.Visible = False
            Label5.Text = "$350,000"

            If missionTwelveComplete = True Then

                picTwelve.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 12 Then

            picThirteen.Visible = True
            picTwelve.Visible = False
            picFourteen.Visible = False
            Label5.Text = "$150,000"

            If missionThirteenComplete = True Then

                picThirteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 2

        ElseIf trys = 13 Then

            picFourteen.Visible = True
            picThirteen.Visible = False
            picFifteen.Visible = False
            Label5.Text = "$1,000,000"

            If missionFourteenComplete = True Then

                picFourteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 14 Then

            picFifteen.Visible = True
            picFourteen.Visible = False
            picSixteen.Visible = False
            Label5.Text = "$550,000"

            If missionFifteenComplete = True Then

                picFifteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 1

        ElseIf trys = 15 Then

            picSixteen.Visible = True
            picFifteen.Visible = False
            picSeventeen.Visible = False
            btnNext.Enabled = True
            Label5.Text = "$750,000"

            If missionSixteenComplete = True Then

                picSixteen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        ElseIf trys = 16 Then

            picSeventeen.Visible = True
            picSixteen.Visible = False
            btnNext.Enabled = False
            Label5.Text = "$1,500,500"

            If missionSeventeenComplete = True Then

                picSeventeen.Visible = False
                btnAcceptTarget.Enabled = False

            Else

                btnAcceptTarget.Enabled = True

            End If

            targetLocation = 3

        End If


    End Sub

    Public Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        For intHoursNext As Integer = intHours To 0 Step -1

            intHours = intHoursNext.ToString()

            For intMinutesNext As Integer = intMinutes To 0 Step -1

                intMinutes = intMinutesNext.ToString()

                Me.Refresh()

                For intSecondsNext As Integer = intSeconds To 0 Step -1

                    intSeconds = intSecondsNext.ToString()

                    Me.Refresh()

                    Label1.Text = intHours.ToString + " : " + intMinutes.ToString + " : " + intSeconds.ToString


                    If intSeconds > 59 Then
                        intSecondsNext = 59
                        intSeconds = 59


                    End If

                    If intMinutes > 60 Then
                        intMinutesNext = 60
                        intMinutes = 60

                    End If

                    Me.Refresh()
                    System.Threading.Thread.Sleep(1000)


                    If intHours = "0" AndAlso intMinutes = "0" AndAlso intSeconds = "0" Then

                        MessageBox.Show("Time's UP!", "", MessageBoxButtons.OK)

                    ElseIf intMinutes = "0" And intSeconds = "0" Then

                        intMinutes = 59.1
                        intSeconds = 59.1

                    End If

                    If intHours = "0" AndAlso intMinutes = "0" AndAlso intSeconds = "0" Then

                        MessageBox.Show("Time's UP!", "", MessageBoxButtons.OK)

                    ElseIf intSeconds = "0" Then

                        intSeconds = 59.1


                    End If


                    If intHours < 36 Then

                        Label1.ForeColor = Color.Orange

                    End If

                    If intHours < 24 Then

                        Label1.ForeColor = Color.OrangeRed

                    End If

                    If intHours < 12 Then

                        Label1.ForeColor = Color.Red

                    End If
                    If intHours < 6 Then

                        Label1.ForeColor = Color.DarkRed

                    End If

                    If intHours < 0.0 Then
                        Dim dlgButton As DialogResult

                        dlgButton = MessageBox.Show("Your time has ran out. You receive a phone call from the kidnappers> They let you speak to your family one last time before your hear loud noises and crying over the phone. 'I'm sorry', says the man on the phone, 'you will never see your family again'. He hangs up the phone")

                        btnAcceptTarget.Enabled = False
                        btnNext.Enabled = False
                        btnBack.Enabled = False
                        btnBankAccount.Enabled = False
                        btnKidnappers.Enabled = False
                        btnLottery.Enabled = False
                        btnBarcQuery.Enabled = False
                        btnBltQuery.Enabled = False
                        btnCaracQuery.Enabled = False

                        Label1.Text = "0 : 0 : 0"
                        Label1.ForeColor = Color.DarkRed
                        Exit Sub

                    End If


                Next intSecondsNext
            Next intMinutesNext
        Next intHoursNext
    End Sub

    Private Sub btnAcceptTarget_Click(sender As Object, e As EventArgs) Handles btnAcceptTarget.Click

        Me.Refresh()

        Dim dlgButton As DialogResult

        If intHours < 0.0 Then

            dlgButton = MessageBox.Show("Your time has ran out. You receive a phone call from the kidnappers> They let you speak to your family one last time before your hear loud noises and crying over the phone. 'I'm sorry', says the man on the phone, 'you will never see your family again'. He hangs up the phone")

            btnAcceptTarget.Enabled = False
            btnNext.Enabled = False
            btnBack.Enabled = False
            btnBankAccount.Enabled = False
            btnKidnappers.Enabled = False
            btnLottery.Enabled = False
            btnBarcQuery.Enabled = False
            btnBltQuery.Enabled = False
            btnCaracQuery.Enabled = False

        End If

        If currentLocation <> targetLocation Then

            If currentLocation = 1 AndAlso targetLocation = 2 Then

                dlgButton = MessageBox.Show("Fly To Caracas, Venezuala?" + vbCrLf + "This trip will take 3 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    intHours = intHours - 3
                    currentLocation = 2
                    lblCurrentLocation.Text = "Caracas, Venezuela"
                    lblCurrentLocation.ForeColor = Color.Blue

                End If

            ElseIf currentLocation = 1 AndAlso targetLocation = 3 Then

                dlgButton = MessageBox.Show("Fly To Barcelona, Spain?" + vbCrLf + vbCrLf + "This trip will take 5 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    intHours = intHours - 5
                    currentLocation = 3
                    lblCurrentLocation.Text = "Barcelona, Spain"
                    lblCurrentLocation.ForeColor = Color.Red

                Else
                    Exit Sub

                End If

            ElseIf currentLocation = 2 AndAlso targetLocation = 1 Then

                dlgButton = MessageBox.Show("Fly To Baltimore, Maryland?" + vbCrLf + vbCrLf + "This trip will take 3 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    intHours = intHours - 3
                    currentLocation = 1
                    lblCurrentLocation.Text = "Baltimore, Maryland"
                    lblCurrentLocation.ForeColor = Color.Coral
                Else
                    Exit Sub

                End If

            ElseIf currentLocation = 2 AndAlso targetLocation = 3 Then

                dlgButton = MessageBox.Show("Fly To Barcelona, Spain?" + vbCrLf + vbCrLf + "This trip will take 6 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    intHours = intHours - 6
                    currentLocation = 3
                    lblCurrentLocation.Text = "Barcelona, Spain"
                    lblCurrentLocation.ForeColor = Color.Red
                Else

                    Exit Sub

                End If

            ElseIf currentLocation = 3 AndAlso targetLocation = 1 Then

                dlgButton = MessageBox.Show("Fly To Baltimore, Maryland?" + vbCrLf + vbCrLf + "This trip will take 5 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    intHours = intHours - 5
                    currentLocation = 1

                    lblCurrentLocation.Text = "Baltimore, Maryland"
                    lblCurrentLocation.ForeColor = Color.Coral
                Else


                End If

            ElseIf currentLocation = 3 AndAlso targetLocation = 2 Then

                dlgButton = MessageBox.Show("Fly To Caracas, Venezuela?" + vbCrLf + vbCrLf + "This trip will take 6 hours", "Spend Time Using the Airplane?", MessageBoxButtons.OKCancel)
                If dlgButton = DialogResult.OK Then

                    intHours = intHours - 6
                    currentLocation = 2

                    lblCurrentLocation.Text = "Caracas, Venezuela"
                    lblCurrentLocation.ForeColor = Color.Blue
                Else
                    Exit Sub

                End If

            Else

                If trys = 0 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblLondonBrief.Visible = True
                    MyForm.picLondon.Visible = True


                End If

                If trys = 1 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblVerandoBrief.Visible = True
                    MyForm.picVerando.Visible = True


                End If


                If trys = 2 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblDevanBrief.Visible = True
                    MyForm.picDevan.Visible = True


                End If

                If trys = 3 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblIvoBrief.Visible = True
                    MyForm.picIvo.Visible = True


                End If

                If trys = 4 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblJaceBrief.Visible = True
                    MyForm.picJace.Visible = True


                End If

                If trys = 5 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblGlennBrief.Visible = True
                    MyForm.picGlenn.Visible = True


                End If

                If trys = 6 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblZionBrief.Visible = True
                    MyForm.picZion.Visible = True


                End If

                If trys = 7 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblPeytonBrief.Visible = True
                    MyForm.picPeyton.Visible = True


                End If

                If trys = 8 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblGaetanoBrief.Visible = True
                    MyForm.picGaetano.Visible = True


                End If

                If trys = 9 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblSenofonteBrief.Visible = True
                    MyForm.picSenofonte.Visible = True


                End If
                If trys = 10 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblCarleyBrief.Visible = True
                    MyForm.picCarley.Visible = True


                End If

                If trys = 11 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblTiffanyBrief.Visible = True
                    MyForm.picTiffany.Visible = True


                End If


                If trys = 12 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblMamanteBrief.Visible = True
                    MyForm.picMamante.Visible = True


                End If

                If trys = 13 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblVinicioBrief.Visible = True
                    MyForm.picVinicio.Visible = True


                End If

                If trys = 14 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblRemondoBrief.Visible = True
                    MyForm.picRemondo.Visible = True


                End If

                If trys = 15 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblJonasBrief.Visible = True
                    MyForm.picJonas.Visible = True


                End If

                If trys = 16 Then

                    Dim MyForm As New Form2

                    MyForm.Show()
                    MyForm.lblGiottoBrief.Visible = True
                    MyForm.picGiootto.Visible = True


                End If

            End If

        Else

            If trys = 0 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblLondonBrief.Visible = True
                MyForm.picLondon.Visible = True


            End If

            If trys = 1 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblVerandoBrief.Visible = True
                MyForm.picVerando.Visible = True


            End If


            If trys = 2 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblDevanBrief.Visible = True
                MyForm.picDevan.Visible = True


            End If

            If trys = 3 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblIvoBrief.Visible = True
                MyForm.picIvo.Visible = True


            End If

            If trys = 4 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblJaceBrief.Visible = True
                MyForm.picJace.Visible = True


            End If

            If trys = 5 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblGlennBrief.Visible = True
                MyForm.picGlenn.Visible = True


            End If

            If trys = 6 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblZionBrief.Visible = True
                MyForm.picZion.Visible = True


            End If

            If trys = 7 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblPeytonBrief.Visible = True
                MyForm.picPeyton.Visible = True


            End If

            If trys = 8 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblGaetanoBrief.Visible = True
                MyForm.picGaetano.Visible = True


            End If

            If trys = 9 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblSenofonteBrief.Visible = True
                MyForm.picSenofonte.Visible = True


            End If
            If trys = 10 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblCarleyBrief.Visible = True
                MyForm.picCarley.Visible = True


            End If

            If trys = 11 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblTiffanyBrief.Visible = True
                MyForm.picTiffany.Visible = True


            End If


            If trys = 12 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblMamanteBrief.Visible = True
                MyForm.picMamante.Visible = True


            End If

            If trys = 13 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblVinicioBrief.Visible = True
                MyForm.picVinicio.Visible = True


            End If

            If trys = 14 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblRemondoBrief.Visible = True
                MyForm.picRemondo.Visible = True


            End If

            If trys = 15 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblJonasBrief.Visible = True
                MyForm.picJonas.Visible = True


            End If

            If trys = 16 Then

                Dim MyForm As New Form2

                MyForm.Show()
                MyForm.lblGiottoBrief.Visible = True
                MyForm.picGiootto.Visible = True


            End If

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBankAccount.Click


        MessageBox.Show("$" + bankAccount.ToString, "", MessageBoxButtons.OK)



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnLottery.Click


        Try

            Dim luckies(0) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To luckies.Length - 1
                luckies(i) = GetRandom(1, 20000)
                bankAccount = bankAccount + luckies(0) * 1000000
            Next
            MessageBox.Show("Money added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End Try

        btnLottery.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKidnappers.Click

        If intHours < 0.0 Then
            Dim dlgButton As DialogResult

            dlgButton = MessageBox.Show("Your time has ran out. You receive a phone call from the kidnappers> They let you speak to your family one last time before your hear loud noises and crying over the phone. 'I'm sorry', says the man on the phone, 'you will never see your family again'. He hangs up the phone")

            btnAcceptTarget.Enabled = False
            btnNext.Enabled = False
            btnBack.Enabled = False
            btnBankAccount.Enabled = False
            btnKidnappers.Enabled = False
            btnLottery.Enabled = False

        End If

        If called = True Then

            Form4.btnEnd.Visible = True

        End If
        If searched = True Then
            Form4.btnFind.Enabled = False

            Dim MyForm As New Form4

            Form4.btnFind.Enabled = False
            MyForm.Show()
        Else
            Dim MyForm As New Form4

            MyForm.Show()
        End If

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

        Application.Restart()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click

        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnBltQuery.Click

        bltmore = True


        Dim frm = New Form3
        frm.Show()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnBarcQuery.Click

        barcelone = True


        Dim frm = New Form3
        frm.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnCaracQuery.Click

        caracas = True


        Dim frm = New Form3
        frm.Show()


    End Sub
End Class

