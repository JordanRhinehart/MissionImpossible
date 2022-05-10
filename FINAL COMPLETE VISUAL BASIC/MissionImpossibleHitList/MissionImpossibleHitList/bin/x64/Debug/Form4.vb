Public Class Form4

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)


    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If Form1.searched = True Then

        Else
            Dim MyForm As New Form5
            MyForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Close()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.called = True Then

            btnEnd.Visible = True

        End If

        If Form1.searched = True Then

            btnFind.Enabled = False

        End If

        If Form1.asked = True Then

            btnTime.Enabled = False

        End If

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        Dim dlgButton As DialogResult


        If Form1.bankAccount > 2500000 Then

            dlgButton = MessageBox.Show("You decide to use the money you made taking lives to pay the kidnappers their ransom. After making the phonecall, you demand that you speak to wife and children on the phone in order to ensure their safety. To your relief, you get to talk to your loving wife. The kidnappers tell you to bring the cash to the end of a pier in Venezuela.", "", MessageBoxButtons.OK)
            btnEnd.Visible = True
            Form1.called = True
            btnPay.Enabled = False
        Else
            dlgButton = MessageBox.Show("You do not have enough funds to pay the ransom for your family.", "", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click

        Dim dlgButton As DialogResult

        Dim randNum(0) As Integer                   'Beginning of random number generator
        For i As Integer = 0 To randNum.Length - 1
            randNum(i) = GetRandom(1, 100)
        Next

        If Form1.currentLocation = 2 Then

            If randNum(0) > 50 Then

                dlgButton = MessageBox.Show("You make your way to the pier as instructed, cautious, but excited to see your family. You park your car about two blocks away from the meeting point, and stash one pistol in each of your boots. You check your body armor to ensure that it is in good condition, as you don't know what you could be walking into. You get back into your van, and drive to the pier. At the edge, you can see 4 silhouettes standing in the distance. Halfway through the pier, you get out of your van and begin walking towards the unidentified figures. As you make your way to the end of the pier, you are ambushed held up at gunpoint by 4 masked men, who were hiding in the surrounding abandoned structures. The men escort you to the edge of the pier, where you are met with your family and a red hooded man. He and 3 other men have your wife and three children at gunpoint. The red hooded man turns around, and your heart suddenly sinks. You see that the man is Zion Risdon, one of your targets. He explains that he was at the head of the infamous plane crash that led to the deaths of 1200 innocent civilians. He used you and your family as a way to eliminate his associates without there being any trace back to him. With his allies now out of the way, and with the money you raised for him, he can escape into hiding. Zion explains that he is not worried about you, as he knows of the gruesome crimes you have committed. Your family, however, could pose as a threat to him. Zion slowly aims his pistol at your wife and, in an extreme panick, you charge at him with everything you have. You are able to tackle Zion to the ground, and in a haste, you bite down on the middle of his neck with all of the jaw strength that any man can use. In shock and confusion, Zion's men know not what to do. You use this time to take out the two pistols that you have hidden boots, one in each hand, and open fire on the seven men in sight. You are able to take out five of the men, and cause the other two to retreat further back to where there is cover by the abandoned structures. Having no time to waste you rush the target on the right side, and use the firefight to make him fall further back towards the road. After firing several rounds, you are finally able to eliminate him. You look around the structures, preparing yourself for any surprise attacks. After about 3 minutes of searching both sides of the pier, you are unable to spot the remaining target. Then, a thought comes to your mind that nearly brings you to your knees. You rush back to where your family is tied up, and are met with fire from both a now seemingly recovered Zion and his remaining associate. Each time you try to fire back, the two men hide behind crying wife and children as cover. This continues for about 4 minutes, until a helicopter begins to hover over Zion and your family. You try to shoot the pilot, but before you can you are hit by the sniper sitting at the edge of the chopper. Your wife and children are forced to helicopter along with Zion. You try to get onto your feet, but by the time you do, the helicopter has long taken off. You never see your family again.", "", MessageBoxButtons.OK)
                If dlgButton = DialogResult.OK Then

                    Form1.btnAcceptTarget.Enabled = False
                    Form1.btnBack.Enabled = False
                    Form1.btnKidnappers.Enabled = False
                    Form1.btnNext.Enabled = False
                    btnEnd.Enabled = False
                    btnPay.Enabled = False
                    btnTime.Enabled = False
                    btnFind.Enabled = False
                    Form1.btnBarcQuery.Enabled = False
                    Form1.btnBltQuery.Enabled = False
                    Form1.btnCaracQuery.Enabled = False

                End If
            Else
                dlgButton = MessageBox.Show("You make your way to the pier as instructed, cautious, but excited to see your family. You park your car about two blocks away from the meeting point, and stash one pistol in each of your boots. You check your body armor to ensure that it is in good condition, as you don't know what you could be walking into. You get back into your van, and drive to the pier. At the edge, you can see 4 silhouettes standing in the distance. Halfway through the pier, you get out of your van and begin walking towards the unidentified figures. As you make your way to the end of the pier, you are ambushed held up at gunpoint by 4 masked men, who were hiding in the surrounding abandoned structures. The men escort you to the edge of the pier, where you are met with your family and a red hooded man. He and 3 other men have your wife and three children at gunpoint. The red hooded man turns around, and your heart suddenly sinks. You see that the man is Zion Risdon, one of your targets. He explains that he was at the head of the infamous plane crash that led to the deaths of 1200 innocent civilians. He used you and your family as a way to eliminate his associates without there being any trace back to him. With his allies now out of the way, and with the money you raised for him, he can escape into hiding. Zion explains that he is not worried about you, as he knows of the gruesome crimes you have committed. Your family, however, could pose as a threat to him. Zion slowly aims his pistol at your wife and, in an extreme panick, you charge at him with everything you have. You are able to tackle Zion to the ground, and in a haste, you bite down on the middle of his neck with all of the jaw strength that any man can use. In shock and confusion, Zion's men know not what to do. You use this time to take out the two pistols that you have hidden boots, one in each hand, and open fire on the seven men in sight. You are able to take out five of the men, and cause the other two to retreat further back to where there is cover by the abandoned structures. Having no time to waste you rush the target on the right side, and use the firefight to make him fall further back towards the road. After firing several rounds, you are finally able to eliminate him. You look around the structures, preparing yourself for any surprise attacks. After about 3 minutes of searching both sides of the pier, you are unable to spot the remaining target. Then, a thought comes to your mind that nearly brings you to your knees. You rush back to where your family is tied up, and are met with fire from both a now seemingly recovered Zion and his remaining associate. Each time you try to fire back, the two men hide behind crying wife and children as cover. This continues for about 4 minutes, until a helicopter begins to hover over Zion and your family. You try to shoot the pilot, but before you can you are hit by the sniper sitting at the edge of the chopper. Your wife and children are forced to board the helicopter along with Zion. You make your way onto your, and shoot at the pilot once again. This time, your target finds its mark. The helicopter spins out of control, crashing into the nearby ground next to the pier. With your wife and children still on the pier, you quickly shoot Zion in the head before he tries to take them hostage again. Zion's brains explode, and he falls to the ground, for good this time. Your quickly untie your family, and you all make your way your van. You hug and kiss your wife and children, and tears betake you all.", "", MessageBoxButtons.OK)
                If dlgButton = DialogResult.OK Then

                    MessageBox.Show("Congratulations!! You win!!", "")
                    Form1.btnAcceptTarget.Enabled = False
                    Form1.btnBack.Enabled = False
                    Form1.btnKidnappers.Enabled = False
                    Form1.btnNext.Enabled = False
                    btnEnd.Enabled = False
                    btnPay.Enabled = False
                    btnTime.Enabled = False
                    btnFind.Enabled = False
                    Form1.btnBarcQuery.Enabled = False
                    Form1.btnBltQuery.Enabled = False
                    Form1.btnCaracQuery.Enabled = False

                End If

            End If

        Else

            dlgButton = MessageBox.Show("Make your way to Venezuela!", "", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click

        Dim dlgButton As DialogResult

        Dim randNum(0) As Integer                   'Beginning of random number generator
        For i As Integer = 0 To randNum.Length - 1
            randNum(i) = GetRandom(1, 100)
        Next
        If randNum(0) > 50 Then

            Form1.intHours = Form1.intHours + 10

            dlgButton = MessageBox.Show("After constant whining and debating with the kidnappers, they agree to grant you 10 more hours", "", MessageBoxButtons.OK)


        Else
            dlgButton = MessageBox.Show("The kidnappers deny your request", "", MessageBoxButtons.OK)


        End If

        btnTime.Enabled = False
        Form1.asked = True

    End Sub
End Class