Public Class Form2

    Dim prepOne As Boolean = False
    Dim prepThree As Boolean = False

    Dim lifeNumber As Integer = 10
    Dim dead As Boolean = False
    Dim completed As Boolean = False

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)

    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        System.Threading.Thread.Sleep(500)
        Me.Refresh()
        'lblTime.Text = "Threat Level: " + Form1.Targets1DataSet.Targets(Form1.trys).Priority()
        Label4.Text = Form1.lblCurrentLocation.Text
        Label3.Text = "Payout " + Form1.Label5.Text


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOnePrep.Click

        Form1.intHours = Form1.intHours - 1
        prepOne = True
        btnOnePrep.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnThreePrep.Click

        Form1.intHours = Form1.intHours - 3
        prepThree = True
        btnThreePrep.Enabled = False

    End Sub

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        If Form1.trys = 0 Then 'London Bellofatto


            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 40

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 60


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 20)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 90)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblLondonBrief.Visible = False
                lblLondonWin.Visible = True

                Form1.bankAccount = Form1.bankAccount + 85000
                completed = True
                Form1.missionOneComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picOne.Visible = False


                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblLondonBrief.Visible = False
                lblLondonWin.Visible = True

                Form1.bankAccount = Form1.bankAccount + 85000
                Form1.missionOneComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picOne.Visible = False

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblLondonBrief.Visible = False
                lblLondonWin.Visible = True
                Form1.missionOneComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picOne.Visible = False

                Form1.bankAccount = Form1.bankAccount + 85000
                completed = True
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 1 Then 'Venerando Allegro

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 35

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 50


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 40)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 80)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblVerandoBrief.Visible = False
                lblVerendoLose.Visible = True
                Form1.missionTwoComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTwo.Visible = False
                Form1.intHours = Form1.intHours - 2

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblVerandoBrief.Visible = False
                lblVerendoLose.Visible = True
                Form1.missionTwoComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTwo.Visible = False
                Form1.intHours = Form1.intHours - 2


                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblVerandoBrief.Visible = False
                lblVerendoLose.Visible = True
                Form1.missionTwoComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTwo.Visible = False
                Form1.intHours = Form1.intHours - 2

                Form1.bankAccount = Form1.bankAccount + 150000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 2 Then 'Devan Sciarretta

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 50


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 20)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 88)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblDevanBrief.Visible = False
                lblDevanLose.Visible = True
                Form1.missionThreeComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picThree.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblDevanBrief.Visible = False
                lblDevanBadWin.Visible = True
                Form1.missionThreeComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picThree.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblDevanBrief.Visible = False
                lblDevanWin.Visible = True
                Form1.missionThreeComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picThree.Visible = False
                Form1.intHours = Form1.intHours - 2


                Form1.bankAccount = Form1.bankAccount + 250000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 3 Then 'Ivo Schettini

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 40


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 30)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 65)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblIvoBrief.Visible = False
                lblIvoLose.Visible = True
                Form1.missionFourComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFour.Visible = False
                dead = True

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblIvoBrief.Visible = False
                lblIvoLose.Visible = True
                Form1.missionFourComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFour.Visible = False
                dead = True

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblIvoBrief.Visible = False
                lblIvoWin.Visible = True
                Form1.missionFourComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFour.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 220000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 4 Then 'Jace Zezza

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 25

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 45


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 30)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 90)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblJaceBrief.Visible = False
                lblJaceLose.Visible = True
                Form1.missionFiveComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFive.Visible = False
                Form1.intHours = Form1.intHours - 10


                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblJaceBrief.Visible = False
                lblJaceRandLose.Visible = True
                Form1.missionFiveComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFive.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblJaceBrief.Visible = False
                lblJaceWin.Visible = True
                Form1.missionFiveComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFive.Visible = False
                Form1.intHours = Form1.intHours - 1


                Form1.bankAccount = Form1.bankAccount + 170000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 5 Then 'Glenn Bollen

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 15

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 25


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 5

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 10)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 100)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblGlennBrief.Visible = False
                lblGlennLose.Visible = True
                Form1.missionSixComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSix.Visible = False
                Form1.intHours = Form1.intHours - 9

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblGlennBrief.Visible = False
                lblGlennRandLose.Visible = True
                Form1.missionSixComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSix.Visible = False
                Form1.intHours = Form1.intHours - 9

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblGlennBrief.Visible = False
                lblGlennWin.Visible = True
                Form1.missionSixComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSix.Visible = False
                Form1.intHours = Form1.intHours - 5


                Form1.bankAccount = Form1.bankAccount + 1050000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 6 Then 'Zion Risdon

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 40

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 60


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 20)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 75)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblZionBrief.Visible = False
                lblZionBadWin.Visible = True
                Form1.missionSevenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSeven.Visible = False
                Form1.intHours = Form1.intHours - 3
                Form1.bankAccount = Form1.bankAccount + 120000


                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(20) Then

                lblZionBrief.Visible = False
                lblZionBadWin.Visible = True
                Form1.missionSevenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSeven.Visible = False
                Form1.intHours = Form1.intHours - 3

                completed = True
                Form1.bankAccount = Form1.bankAccount + 120000


            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblZionBrief.Visible = False
                lblZionWin.Visible = True
                Form1.missionSevenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSeven.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 120000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 7 Then 'Peyton Burry

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 40


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 20)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 80)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblPeytonBrief.Visible = False
                lblPeytonLose.Visible = True
                Form1.missionEightComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picEight.Visible = False
                Form1.intHours = Form1.intHours - 5

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Then

                lblPeytonBrief.Visible = False
                lblPeytonRandLose.Visible = True
                Form1.missionEightComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picEight.Visible = False
                Form1.intHours = Form1.intHours - 5

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblPeytonBrief.Visible = False
                lblPeytonWin.Visible = True
                Form1.missionEightComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picEight.Visible = False
                Form1.intHours = Form1.intHours - 5

                Form1.bankAccount = Form1.bankAccount + 440000
                completed = True
            End If


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 8 Then 'Gaetano Worthley

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 30

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 40


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 30)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 70)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblGaetanoBrief.Visible = False
                lblGaetanoLose.Visible = True
                Form1.missionNineComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picNine.Visible = False
                Form1.intHours = Form1.intHours - 4

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Then

                lblGaetanoBrief.Visible = False
                lblGaetanoRandLose.Visible = True
                Form1.missionNineComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picNine.Visible = False
                Form1.intHours = Form1.intHours - 4

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblGaetanoBrief.Visible = False
                lblGaetanoWin.Visible = True
                Form1.missionNineComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picNine.Visible = False
                Form1.intHours = Form1.intHours - 4

                Form1.bankAccount = Form1.bankAccount + 150000
                completed = True

            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf Form1.trys = 9 Then 'Senofonte Codner

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 40

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 60


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 40)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 50)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblSenofonteBrief.Visible = False
                lblSenofonteLose.Visible = True
                Form1.missionTenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTen.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Then

                lblSenofonteBrief.Visible = False
                lblSenofonteLose.Visible = True
                Form1.missionTenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTen.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblSenofonteBrief.Visible = False
                lblSenofonteLose.Visible = True
                Form1.missionTenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTen.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 50000
                completed = True
            End If


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 10 Then 'Carley Corvo

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 30


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 50)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 70)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblCarleyBrief.Visible = False
                lblCarleyLose.Visible = True
                Form1.missionElevenComplete = True
                dead = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picEleven.Visible = False

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblCarleyBrief.Visible = False
                lblCarleyRandLose.Visible = True
                Form1.missionElevenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picEleven.Visible = False

                dead = True
                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblCarleyBrief.Visible = False
                lblCarleyWin.Visible = True
                Form1.missionElevenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picEleven.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 520000
                completed = True
            End If



            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 11 Then 'Tiffany Cawood

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 30


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 40)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 90)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblTiffanyBrief.Visible = False
                lblTiffanyLose.Visible = True
                Form1.missionTwelveComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTwelve.Visible = False


                dead = True
                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblTiffanyBrief.Visible = False
                lblTiffanyRandLose.Visible = True
                Form1.missionTwelveComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTwelve.Visible = False

                dead = True
                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblTiffanyBrief.Visible = False
                lblTiffanyWinLose.Visible = True
                Form1.missionTwelveComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picTwelve.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True

            End If


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 12 Then 'Mamante Gamby

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 40

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 60


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 40)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 70)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblMamanteBrief.Visible = False
                lblMamanteLose.Visible = True
                Form1.missionThirteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picThirteen.Visible = False
                Form1.intHours = Form1.intHours - 1


                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblMamanteBrief.Visible = False
                lblMamanteRandLose.Visible = True
                Form1.missionThirteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picThirteen.Visible = False
                Form1.intHours = Form1.intHours - 1

                completed = True

            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblMamanteBrief.Visible = False
                lblMamanteWin.Visible = True
                Form1.missionThirteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picThirteen.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 150000
                completed = True
            End If



            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        ElseIf Form1.trys = 13 Then 'Vinicio Sander

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 15

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 20


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 5

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 10)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 90)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblVinicioBrief.Visible = False
                lblVinicioLose.Visible = True
                Form1.missionFourteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFourteen.Visible = False

                dead = True

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblVinicioBrief.Visible = False
                lblVinicioRandLose.Visible = True
                Form1.missionFourteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFourteen.Visible = False
                dead = True

                completed = True
            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblVinicioBrief.Visible = False
                lblVinicioWin.Visible = True
                Form1.missionFourteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFourteen.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 1000000
                completed = True
            End If




            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 14 Then 'Remondo Tempest


            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 40


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 30)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 80)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblRemondoBrief.Visible = False
                lblRemondoLose.Visible = True
                Form1.missionFifteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFifteen.Visible = False
                Form1.intHours = Form1.intHours - 2

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblRemondoBrief.Visible = False
                lblRemondoRandLose.Visible = True
                Form1.missionFifteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFifteen.Visible = False
                Form1.intHours = Form1.intHours - 1


                completed = True
            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblRemondoBrief.Visible = False
                lblRemondoWin.Visible = True
                Form1.missionFifteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picFifteen.Visible = False
                Form1.intHours = Form1.intHours - 1

                Form1.bankAccount = Form1.bankAccount + 550000
                completed = True
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ElseIf Form1.trys = 15 Then 'Jonas Del Pino

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 40


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 10

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 25)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 85)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblJonasBrief.Visible = False
                lblJonasLose.Visible = True
                Form1.missionSixteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSixteen.Visible = False
                dead = True

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblJonasBrief.Visible = False
                lblJonasLose.Visible = True
                Form1.missionSixteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSixteen.Visible = False
                dead = True

                completed = True
            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblJonasBrief.Visible = False
                lblJonasWin.Visible = True
                Form1.missionSixteenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSixteen.Visible = False
                Form1.intHours = Form1.intHours - 1


                Form1.bankAccount = Form1.bankAccount + 750000
                completed = True
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf Form1.trys = 16 Then 'Giotto Mollica

            If prepOne = False AndAlso prepThree = True Then 'Preparation for three hours


                lifeNumber = lifeNumber + 20

            ElseIf prepOne = True AndAlso prepThree = True Then 'Preparation for four hours

                lifeNumber = lifeNumber + 25


            ElseIf prepOne = True AndAlso prepThree = False Then 'Preparation for One hour

                lifeNumber = lifeNumber + 5

            Else

            End If


            Dim unlucky(20) As Integer                   'Beginning of random number generator
            For i As Integer = 0 To unlucky.Length - 1
                unlucky(i) = GetRandom(1, 100)
            Next

            Dim help(0) As Integer                   'Help variable for assistance of player random number generator, varies depending on mission difficulty
            For i As Integer = 0 To help.Length - 1
                help(i) = GetRandom(1, 15)
            Next

            lifeNumber = lifeNumber + help(0)

            Dim randoms(0) As Integer
            For i As Integer = 0 To randoms.Length - 1
                randoms(i) = GetRandom(1, 95)
            Next                                           'End of random number generator

            If randoms(0) > lifeNumber Then 'Mission Lose Code

                lblGiottoBrief.Visible = False
                lblGiottoLose.Visible = True
                Form1.missionSeventeenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSeventeen.Visible = False
                dead = True

                completed = True
                'Failing mission Randomly Code Below

            ElseIf randoms(0) = unlucky(0) Or randoms(0) = unlucky(1) Or randoms(0) = unlucky(2) Or randoms(0) = unlucky(3) Or randoms(0) = unlucky(5) Or randoms(0) = unlucky(6) Or randoms(0) = unlucky(7) Or randoms(0) = unlucky(8) Or randoms(0) = unlucky(9) Or randoms(0) = unlucky(10) Or randoms(0) = unlucky(11) Or randoms(0) = unlucky(12) Or randoms(0) = unlucky(13) Or randoms(0) = unlucky(14) Or randoms(0) = unlucky(15) Or randoms(0) = unlucky(16) Or randoms(0) = unlucky(17) Or randoms(0) = unlucky(18) Or randoms(0) = unlucky(19) Or randoms(0) = unlucky(20) Then

                lblGiottoBrief.Visible = False
                lblGiottoRandLose.Visible = True
                Form1.missionSeventeenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSeventeen.Visible = False
                dead = True

                completed = True
            ElseIf randoms(0) < lifeNumber Then 'Mission Win Code

                lblGiottoBrief.Visible = False
                lblGiottoWin.Visible = True
                Form1.missionSeventeenComplete = True
                Form1.btnAcceptTarget.Enabled = False
                Form1.picSeventeen.Visible = False
                Form1.intHours = Form1.intHours - 3

                Form1.bankAccount = Form1.bankAccount + 1500500
                completed = True
            End If



        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnBegin.Enabled = False
        btnOnePrep.Enabled = False
        btnThreePrep.Enabled = False

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim dlgButton As DialogResult


        If completed = False Then

            dlgButton = MessageBox.Show("Are you sure you wish to leave this mission? All preparation time for this target will be lost", "", MessageBoxButtons.OKCancel)

            If dlgButton = DialogResult.OK Then

                prepOne = False
                prepThree = False
                lifeNumber = 10

                If dead = True Then

                    MessageBox.Show("You are dead", "", MessageBoxButtons.OK)
                    Form1.btnAcceptTarget.Enabled = False
                    Form1.btnNext.Enabled = False
                    Form1.btnBack.Enabled = False
                    Form1.btnBankAccount.Enabled = False
                    Form1.btnKidnappers.Enabled = False
                    Form1.btnLottery.Enabled = False
                    Form1.btnBarcQuery.Enabled = False
                    Form1.btnBltQuery.Enabled = False
                    Form1.btnCaracQuery.Enabled = False

                End If

                Me.Close()

            Else

                Exit Sub


            End If

        Else

            If dead = True Then

                MessageBox.Show("You are dead", "", MessageBoxButtons.OK)

                Form1.btnAcceptTarget.Enabled = False
                Form1.btnNext.Enabled = False
                Form1.btnBack.Enabled = False
                Form1.btnBankAccount.Enabled = False
                Form1.btnKidnappers.Enabled = False
                Form1.btnLottery.Enabled = False
                Form1.btnBarcQuery.Enabled = False
                Form1.btnBltQuery.Enabled = False
                Form1.btnCaracQuery.Enabled = False

            End If

            prepOne = False

            prepThree = False

            lifeNumber = 10

            completed = False

            Me.Close()

        End If
    End Sub

End Class