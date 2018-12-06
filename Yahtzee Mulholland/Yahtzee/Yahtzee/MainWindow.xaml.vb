Class MainWindow
    Dim rollsThisTurn As Integer = 0
    Dim playerOne As Boolean = True
    Dim num1 As Integer
    Dim num2 As Integer
    Dim num3 As Integer
    Dim num4 As Integer
    Dim num5 As Integer

    Dim ones1 As Integer = 0
    Dim ones2 As Integer = 0
    Dim twos1 As Integer = 0
    Dim twos2 As Integer = 0
    Dim threes1 As Integer = 0
    Dim threes2 As Integer = 0
    Dim fours1 As Integer = 0
    Dim fours2 As Integer = 0
    Dim fives1 As Integer = 0
    Dim fives2 As Integer = 0
    Dim sixes1 As Integer = 0
    Dim sixes2 As Integer = 0

    Dim threeOfAKind1 As Integer = 0
    Dim threeOfAKind2 As Integer = 0
    Dim fourOfAKind1 As Integer = 0
    Dim fourOfAKind2 As Integer = 0
    Dim smallStr1 As Integer = 0
    Dim smallStr2 As Integer = 0
    Dim largeStr1 As Integer = 0
    Dim largeStr2 As Integer = 0
    Dim fullHouse1 As Integer = 0
    Dim fullhouse2 As Integer = 0
    Dim yahtzee1 As Integer = 0
    Dim yahtzee2 As Integer = 0

    Dim chance1 As Integer = 0
    Dim chance2 As Integer = 0

    Dim bonusYahtzee1 As Integer = 0
    Dim bonusYahtzee2 As Integer = 0

    Dim bonus1 As Integer = 0
    Dim bonus2 As Integer = 0

    Dim fullHouseCheat As Boolean = False
    Dim straightCheat As Boolean = False
    Dim yahtzeeCheat As Boolean = False


    Private Sub btnRoll_Click(sender As Object, e As RoutedEventArgs) Handles btnRoll.Click
        My.Computer.Audio.Play(My.Resources.diceroll, AudioPlayMode.Background)

        If btnRoll.Opacity = 1 Then
            rollsThisTurn += 1

            If rollsThisTurn > 3 Then
                img1.Opacity = 0.5
                img2.Opacity = 0.5
                img3.Opacity = 0.5
                img4.Opacity = 0.5
                img5.Opacity = 0.5
            End If

            If (yahtzeeCheat = True) Then
                yahtzeeCheat = False
                img1.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img2.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img3.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img4.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img5.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                num1 = 1
                num2 = 1
                num3 = 1
                num4 = 1
                num5 = 1
            ElseIf (fullHouseCheat = True) Then
                fullHouseCheat = False
                img1.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img2.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img3.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img4.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                img5.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                num1 = 1
                num2 = 1
                num3 = 1
                num4 = 2
                num5 = 2
            ElseIf (straightCheat = True) Then
                fullHouseCheat = False
                img1.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                img2.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                img3.Source = New BitmapImage(New Uri("Resources/3.png", UriKind.Relative))
                img4.Source = New BitmapImage(New Uri("Resources/4.png", UriKind.Relative))
                img5.Source = New BitmapImage(New Uri("Resources/5.png", UriKind.Relative))
                num1 = 1
                num2 = 2
                num3 = 3
                num4 = 4
                num5 = 5
            Else
                For i = 1 To 5
                    If i = 1 AndAlso img1.Opacity = 1 Then
                        Randomize()
                        num1 = Int(Rnd() * 6) + 1
                        If num1 = 1 Then
                            img1.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                        ElseIf num1 = 2 Then
                            img1.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                        ElseIf num1 = 3 Then
                            img1.Source = New BitmapImage(New Uri("Resources/3.png", UriKind.Relative))
                        ElseIf num1 = 4 Then
                            img1.Source = New BitmapImage(New Uri("Resources/4.png", UriKind.Relative))
                        ElseIf num1 = 5 Then
                            img1.Source = New BitmapImage(New Uri("Resources/5.png", UriKind.Relative))
                        ElseIf num1 = 6 Then
                            img1.Source = New BitmapImage(New Uri("Resources/6.png", UriKind.Relative))
                        End If
                    ElseIf i = 2 AndAlso img2.Opacity = 1 Then
                        Randomize()
                        num2 = Int(Rnd() * 6) + 1
                        If num2 = 1 Then
                            img2.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                        ElseIf num2 = 2 Then
                            img2.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                        ElseIf num2 = 3 Then
                            img2.Source = New BitmapImage(New Uri("Resources/3.png", UriKind.Relative))
                        ElseIf num2 = 4 Then
                            img2.Source = New BitmapImage(New Uri("Resources/4.png", UriKind.Relative))
                        ElseIf num2 = 5 Then
                            img2.Source = New BitmapImage(New Uri("Resources/5.png", UriKind.Relative))
                        ElseIf num2 = 6 Then
                            img2.Source = New BitmapImage(New Uri("Resources/6.png", UriKind.Relative))
                        End If
                    ElseIf i = 3 AndAlso img3.Opacity = 1 Then
                        Randomize()
                        num3 = Int(Rnd() * 6) + 1
                        If num3 = 1 Then
                            img3.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                        ElseIf num3 = 2 Then
                            img3.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                        ElseIf num3 = 3 Then
                            img3.Source = New BitmapImage(New Uri("Resources/3.png", UriKind.Relative))
                        ElseIf num3 = 4 Then
                            img3.Source = New BitmapImage(New Uri("Resources/4.png", UriKind.Relative))
                        ElseIf num3 = 5 Then
                            img3.Source = New BitmapImage(New Uri("Resources/5.png", UriKind.Relative))
                        ElseIf num3 = 6 Then
                            img3.Source = New BitmapImage(New Uri("Resources/6.png", UriKind.Relative))
                        End If
                    ElseIf i = 4 AndAlso img4.Opacity = 1 Then
                        Randomize()
                        num4 = Int(Rnd() * 6) + 1
                        If num4 = 1 Then
                            img4.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                        ElseIf num4 = 2 Then
                            img4.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                        ElseIf num4 = 3 Then
                            img4.Source = New BitmapImage(New Uri("Resources/3.png", UriKind.Relative))
                        ElseIf num4 = 4 Then
                            img4.Source = New BitmapImage(New Uri("Resources/4.png", UriKind.Relative))
                        ElseIf num4 = 5 Then
                            img4.Source = New BitmapImage(New Uri("Resources/5.png", UriKind.Relative))
                        ElseIf num4 = 6 Then
                            img4.Source = New BitmapImage(New Uri("Resources/6.png", UriKind.Relative))
                        End If
                    ElseIf i = 5 AndAlso img5.Opacity = 1 Then
                        Randomize()
                        num5 = Int(Rnd() * 6) + 1
                        If num5 = 1 Then
                            img5.Source = New BitmapImage(New Uri("Resources/1.png", UriKind.Relative))
                        ElseIf num5 = 2 Then
                            img5.Source = New BitmapImage(New Uri("Resources/2.png", UriKind.Relative))
                        ElseIf num5 = 3 Then
                            img5.Source = New BitmapImage(New Uri("Resources/3.png", UriKind.Relative))
                        ElseIf num5 = 4 Then
                            img5.Source = New BitmapImage(New Uri("Resources/4.png", UriKind.Relative))
                        ElseIf num5 = 5 Then
                            img5.Source = New BitmapImage(New Uri("Resources/5.png", UriKind.Relative))
                        ElseIf num5 = 6 Then
                            img5.Source = New BitmapImage(New Uri("Resources/6.png", UriKind.Relative))
                        End If
                    End If
                Next
            End If



        End If


    End Sub

    Private Sub img1_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles img1.MouseLeftButtonDown
        If rollsThisTurn <> 0 Then
            If img1.Opacity = 1 Then
                img1.Opacity = 0.5
            ElseIf img1.Opacity = 0.5 Then
                img1.Opacity = 1
            End If
        End If
    End Sub

    Private Sub img2_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles img2.MouseLeftButtonDown
        If rollsThisTurn <> 0 Then
            If img2.Opacity = 1 Then
                img2.Opacity = 0.5
            ElseIf img2.Opacity = 0.5 Then
                img2.Opacity = 1
            End If
        End If
    End Sub

    Private Sub img3_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles img3.MouseLeftButtonDown
        If rollsThisTurn <> 0 Then
            If img3.Opacity = 1 Then
                img3.Opacity = 0.5
            ElseIf img3.Opacity = 0.5 Then
                img3.Opacity = 1
            End If
        End If
    End Sub

    Private Sub img4_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles img4.MouseLeftButtonDown
        If rollsThisTurn <> 0 Then
            If img4.Opacity = 1 Then
                img4.Opacity = 0.5
            ElseIf img4.Opacity = 0.5 Then
                img4.Opacity = 1
            End If
        End If
    End Sub

    Private Sub img5_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles img5.MouseLeftButtonDown
        If rollsThisTurn <> 0 Then
            If img5.Opacity = 1 Then
                img5.Opacity = 0.5
            ElseIf img5.Opacity = 0.5 Then
                img5.Opacity = 1
            End If
        End If
    End Sub

    Private Sub btnScore_Click(sender As Object, e As RoutedEventArgs) Handles btnScore.Click
        If btnScore.Opacity = 1 Then
            If rollsThisTurn > 0 Then
                If playerOne = True Then
                    If rdoOnes1.IsChecked = True Then
                        If num1 = 1 Then
                            ones1 += 1
                        End If
                        If num2 = 1 Then
                            ones1 += 1
                        End If
                        If num3 = 1 Then
                            ones1 += 1
                        End If
                        If num4 = 1 Then
                            ones1 += 1
                        End If
                        If num5 = 1 Then
                            ones1 += 1
                        End If
                        rdoOnes1.IsEnabled = False
                        txtOnes1.Text = ones1
                    End If

                    If rdoTwos1.IsChecked = True Then
                        If num1 = 2 Then
                            twos1 += 2
                        End If
                        If num2 = 2 Then
                            twos1 += 2
                        End If
                        If num3 = 2 Then
                            twos1 += 2
                        End If
                        If num4 = 2 Then
                            twos1 += 2
                        End If
                        If num5 = 2 Then
                            twos1 += 2
                        End If
                        rdoTwos1.IsEnabled = False
                        txtTwos1.Text = twos1
                    End If

                    If rdoThrees1.IsChecked = True Then
                        If num1 = 3 Then
                            threes1 += 3
                        End If
                        If num2 = 3 Then
                            threes1 += 3
                        End If
                        If num3 = 3 Then
                            threes1 += 3
                        End If
                        If num4 = 3 Then
                            threes1 += 3
                        End If
                        If num5 = 3 Then
                            threes1 += 3
                        End If
                        rdoThrees1.IsEnabled = False
                        txtThrees1.Text = threes1
                    End If

                    If rdoFours1.IsChecked = True Then
                        If num1 = 4 Then
                            fours1 += 4
                        End If
                        If num2 = 4 Then
                            fours1 += 4
                        End If
                        If num3 = 4 Then
                            fours1 += 4
                        End If
                        If num4 = 4 Then
                            fours1 += 4
                        End If
                        If num5 = 4 Then
                            fours1 += 4
                        End If
                        rdoFours1.IsEnabled = False
                        txtFours1.Text = fours1
                    End If

                    If rdoFives1.IsChecked = True Then
                        If num1 = 5 Then
                            fives1 += 5
                        End If
                        If num2 = 5 Then
                            fives1 += 5
                        End If
                        If num3 = 5 Then
                            fives1 += 5
                        End If
                        If num4 = 5 Then
                            fives1 += 5
                        End If
                        If num5 = 5 Then
                            fives1 += 5
                        End If
                        rdoFives1.IsEnabled = False
                        txtFives1.Text = fives1
                    End If

                    If rdoSixes1.IsChecked = True Then
                        If num1 = 6 Then
                            sixes1 += 6
                        End If
                        If num2 = 6 Then
                            sixes1 += 6
                        End If
                        If num3 = 6 Then
                            sixes1 += 6
                        End If
                        If num4 = 6 Then
                            sixes1 += 6
                        End If
                        If num5 = 6 Then
                            sixes1 += 6
                        End If
                        rdoSixes1.IsEnabled = False
                        txtSixes1.Text = sixes1
                    End If

                    If rdo3OfAKind1.IsChecked = True Then
                        Dim oneCounter31, twoCounter31, threeCounter31, fourCounter31, fiveCounter31, sixCounter31 As Integer
                        If num1 = 1 Then
                            oneCounter31 += 1
                        ElseIf num1 = 2 Then
                            twoCounter31 += 1
                        ElseIf num1 = 3 Then
                            threeCounter31 += 1
                        ElseIf num1 = 4 Then
                            fourCounter31 += 1
                        ElseIf num1 = 5 Then
                            fiveCounter31 += 1
                        ElseIf num1 = 6 Then
                            sixCounter31 += 1
                        End If

                        If num2 = 1 Then
                            oneCounter31 += 1
                        ElseIf num2 = 2 Then
                            twoCounter31 += 1
                        ElseIf num2 = 3 Then
                            threeCounter31 += 1
                        ElseIf num2 = 4 Then
                            fourCounter31 += 1
                        ElseIf num2 = 5 Then
                            fiveCounter31 += 1
                        ElseIf num2 = 6 Then
                            sixCounter31 += 1
                        End If

                        If num3 = 1 Then
                            oneCounter31 += 1
                        ElseIf num3 = 2 Then
                            twoCounter31 += 1
                        ElseIf num3 = 3 Then
                            threeCounter31 += 1
                        ElseIf num3 = 4 Then
                            fourCounter31 += 1
                        ElseIf num3 = 5 Then
                            fiveCounter31 += 1
                        ElseIf num3 = 6 Then
                            sixCounter31 += 1
                        End If

                        If num4 = 1 Then
                            oneCounter31 += 1
                        ElseIf num4 = 2 Then
                            twoCounter31 += 1
                        ElseIf num4 = 3 Then
                            threeCounter31 += 1
                        ElseIf num4 = 4 Then
                            fourCounter31 += 1
                        ElseIf num4 = 5 Then
                            fiveCounter31 += 1
                        ElseIf num4 = 6 Then
                            sixCounter31 += 1
                        End If

                        If num5 = 1 Then
                            oneCounter31 += 1
                        ElseIf num5 = 2 Then
                            twoCounter31 += 1
                        ElseIf num5 = 3 Then
                            threeCounter31 += 1
                        ElseIf num5 = 4 Then
                            fourCounter31 += 1
                        ElseIf num5 = 5 Then
                            fiveCounter31 += 1
                        ElseIf num5 = 6 Then
                            sixCounter31 += 1
                        End If

                        If oneCounter31 >= 3 Or twoCounter31 >= 3 Or threeCounter31 >= 3 Or fourCounter31 >= 3 Or fiveCounter31 >= 3 Or sixCounter31 >= 3 Then
                            threeOfAKind1 = num1 + num2 + num3 + num4 + num5
                        Else
                            threeOfAKind1 = 0
                        End If

                        txt3OfAKind1.Text = threeOfAKind1
                        rdo3OfAKind1.IsEnabled = False
                    End If

                    If rdo4OfAKind1.IsChecked = True Then
                        Dim oneCounter41, twoCounter41, threeCounter41, fourCounter41, fiveCounter41, sixCounter41 As Integer
                        If num1 = 1 Then
                            oneCounter41 += 1
                        ElseIf num1 = 2 Then
                            twoCounter41 += 1
                        ElseIf num1 = 3 Then
                            threeCounter41 += 1
                        ElseIf num1 = 4 Then
                            fourCounter41 += 1
                        ElseIf num1 = 5 Then
                            fiveCounter41 += 1
                        ElseIf num1 = 6 Then
                            sixCounter41 += 1
                        End If

                        If num2 = 1 Then
                            oneCounter41 += 1
                        ElseIf num2 = 2 Then
                            twoCounter41 += 1
                        ElseIf num2 = 3 Then
                            threeCounter41 += 1
                        ElseIf num2 = 4 Then
                            fourCounter41 += 1
                        ElseIf num2 = 5 Then
                            fiveCounter41 += 1
                        ElseIf num2 = 6 Then
                            sixCounter41 += 1
                        End If

                        If num3 = 1 Then
                            oneCounter41 += 1
                        ElseIf num3 = 2 Then
                            twoCounter41 += 1
                        ElseIf num3 = 3 Then
                            threeCounter41 += 1
                        ElseIf num3 = 4 Then
                            fourCounter41 += 1
                        ElseIf num3 = 5 Then
                            fiveCounter41 += 1
                        ElseIf num3 = 6 Then
                            sixCounter41 += 1
                        End If

                        If num4 = 1 Then
                            oneCounter41 += 1
                        ElseIf num4 = 2 Then
                            twoCounter41 += 1
                        ElseIf num4 = 3 Then
                            threeCounter41 += 1
                        ElseIf num4 = 4 Then
                            fourCounter41 += 1
                        ElseIf num4 = 5 Then
                            fiveCounter41 += 1
                        ElseIf num4 = 6 Then
                            sixCounter41 += 1
                        End If

                        If num5 = 1 Then
                            oneCounter41 += 1
                        ElseIf num5 = 2 Then
                            twoCounter41 += 1
                        ElseIf num5 = 3 Then
                            threeCounter41 += 1
                        ElseIf num5 = 4 Then
                            fourCounter41 += 1
                        ElseIf num5 = 5 Then
                            fiveCounter41 += 1
                        ElseIf num5 = 6 Then
                            sixCounter41 += 1
                        End If

                        If oneCounter41 >= 4 Or twoCounter41 >= 4 Or threeCounter41 >= 4 Or fourCounter41 >= 4 Or fiveCounter41 >= 4 Or sixCounter41 >= 4 Then
                            fourOfAKind1 = num1 + num2 + num3 + num4 + num5
                        Else
                            fourOfAKind1 = 0
                        End If

                        txt4OfAKind1.Text = fourOfAKind1
                        rdo4OfAKind1.IsEnabled = False
                    End If

                    If rdoFullHouse1.IsChecked = True Then
                        Dim oneCounterFH1, twoCounterFH1, threeCounterFH1, fourCounterFH1, fiveCounterFH1, sixCounterFH1 As Integer
                        Dim fullHouseBoo1 As Boolean = False
                        If num1 = 1 Then
                            oneCounterFH1 += 1
                        ElseIf num1 = 2 Then
                            twoCounterFH1 += 1
                        ElseIf num1 = 3 Then
                            threeCounterFH1 += 1
                        ElseIf num1 = 4 Then
                            fourCounterFH1 += 1
                        ElseIf num1 = 5 Then
                            fiveCounterFH1 += 1
                        ElseIf num1 = 6 Then
                            sixCounterFH1 += 1
                        End If

                        If num2 = 1 Then
                            oneCounterFH1 += 1
                        ElseIf num2 = 2 Then
                            twoCounterFH1 += 1
                        ElseIf num2 = 3 Then
                            threeCounterFH1 += 1
                        ElseIf num2 = 4 Then
                            fourCounterFH1 += 1
                        ElseIf num2 = 5 Then
                            fiveCounterFH1 += 1
                        ElseIf num2 = 6 Then
                            sixCounterFH1 += 1
                        End If

                        If num3 = 1 Then
                            oneCounterFH1 += 1
                        ElseIf num3 = 2 Then
                            twoCounterFH1 += 1
                        ElseIf num3 = 3 Then
                            threeCounterFH1 += 1
                        ElseIf num3 = 4 Then
                            fourCounterFH1 += 1
                        ElseIf num3 = 5 Then
                            fiveCounterFH1 += 1
                        ElseIf num3 = 6 Then
                            sixCounterFH1 += 1
                        End If

                        If num4 = 1 Then
                            oneCounterFH1 += 1
                        ElseIf num4 = 2 Then
                            twoCounterFH1 += 1
                        ElseIf num4 = 3 Then
                            threeCounterFH1 += 1
                        ElseIf num4 = 4 Then
                            fourCounterFH1 += 1
                        ElseIf num4 = 5 Then
                            fiveCounterFH1 += 1
                        ElseIf num4 = 6 Then
                            sixCounterFH1 += 1
                        End If

                        If num5 = 1 Then
                            oneCounterFH1 += 1
                        ElseIf num5 = 2 Then
                            twoCounterFH1 += 1
                        ElseIf num5 = 3 Then
                            threeCounterFH1 += 1
                        ElseIf num5 = 4 Then
                            fourCounterFH1 += 1
                        ElseIf num5 = 5 Then
                            fiveCounterFH1 += 1
                        ElseIf num5 = 6 Then
                            sixCounterFH1 += 1
                        End If

                        If oneCounterFH1 = 3 Then
                            If twoCounterFH1 = 2 Or threeCounterFH1 = 2 Or fourCounterFH1 = 2 Or fiveCounterFH1 = 2 Or sixCounterFH1 = 2 Then
                                fullHouseBoo1 = True
                            End If
                        ElseIf twoCounterFH1 = 3 Then
                            If oneCounterFH1 = 2 Or threeCounterFH1 = 2 Or fourCounterFH1 = 2 Or fiveCounterFH1 = 2 Or sixCounterFH1 = 2 Then
                                fullHouseBoo1 = True
                            End If
                        ElseIf threeCounterFH1 = 3 Then
                            If twoCounterFH1 = 2 Or oneCounterFH1 = 2 Or fourCounterFH1 = 2 Or fiveCounterFH1 = 2 Or sixCounterFH1 = 2 Then
                                fullHouseBoo1 = True
                            End If
                        ElseIf fourCounterFH1 = 3 Then
                            If twoCounterFH1 = 2 Or threeCounterFH1 = 2 Or oneCounterFH1 = 2 Or fiveCounterFH1 = 2 Or sixCounterFH1 = 2 Then
                                fullHouseBoo1 = True
                            End If
                        ElseIf fiveCounterFH1 = 3 Then
                            If twoCounterFH1 = 2 Or threeCounterFH1 = 2 Or fourCounterFH1 = 2 Or oneCounterFH1 = 2 Or sixCounterFH1 = 2 Then
                                fullHouseBoo1 = True
                            End If
                        ElseIf sixCounterFH1 = 3 Then
                            If twoCounterFH1 = 2 Or threeCounterFH1 = 2 Or fourCounterFH1 = 2 Or fiveCounterFH1 = 2 Or oneCounterFH1 = 2 Then
                                fullHouseBoo1 = True
                            End If
                        End If

                        If fullHouseBoo1 = True Then
                            fullHouse1 = 25
                        Else
                            fullHouse1 = 0
                        End If

                        txtFullHouse1.Text = fullHouse1
                        rdoFullHouse1.IsEnabled = False
                    End If

                    If rdoSmallStr1.IsChecked = True Then
                        Dim smallStr1Nums As String = num1.ToString + num2.ToString + num3.ToString + num4.ToString + num5.ToString
                        Dim smallStr1Boo As Boolean = False

                        If smallStr1Nums.Contains("1") AndAlso smallStr1Nums.Contains("2") AndAlso smallStr1Nums.Contains("3") AndAlso smallStr1Nums.Contains("4") Then
                            smallStr1Boo = True
                        ElseIf smallStr1Nums.Contains("2") AndAlso smallStr1Nums.Contains("3") AndAlso smallStr1Nums.Contains("4") AndAlso smallStr1Nums.Contains("5") Then
                            smallStr1Boo = True
                        ElseIf smallStr1Nums.Contains("3") AndAlso smallStr1Nums.Contains("4") AndAlso smallStr1Nums.Contains("5") AndAlso smallStr1Nums.Contains("6") Then
                            smallStr1Boo = True
                        End If

                        If smallStr1Boo = True Then
                            smallStr1 = 30
                        Else
                            smallStr1 = 0
                        End If

                        txtSmallStr1.Text = smallStr1
                        rdoSmallStr1.IsEnabled = False
                    End If

                    If rdoLargeStr1.IsChecked = True Then
                        Dim largeStr1Nums As String = num1.ToString + num2.ToString + num3.ToString + num4.ToString + num5.ToString
                        Dim largeStr1Boo As Boolean = False

                        If largeStr1Nums.Contains("1") AndAlso largeStr1Nums.Contains("2") AndAlso largeStr1Nums.Contains("3") AndAlso largeStr1Nums.Contains("4") AndAlso largeStr1Nums.Contains("5") Then
                            largeStr1Boo = True
                        ElseIf largeStr1Nums.Contains("2") AndAlso largeStr1Nums.Contains("3") AndAlso largeStr1Nums.Contains("4") AndAlso largeStr1Nums.Contains("5") AndAlso largeStr1Nums.Contains("6") Then
                            largeStr1Boo = True
                        End If

                        If largeStr1Boo = True Then
                            largeStr1 = 40
                        Else
                            largeStr1 = 0
                        End If

                        txtLargeStr1.Text = largeStr1
                        rdoLargeStr1.IsEnabled = False
                    End If


                    If rdoYahtzee1.IsChecked = True Then
                        Dim oneCounterY1, twoCounterY1, threeCounterY1, fourCounterY1, fiveCounterY1, sixCounterY1 As Integer
                        If num1 = 1 Then
                            oneCounterY1 += 1
                        ElseIf num1 = 2 Then
                            twoCounterY1 += 1
                        ElseIf num1 = 3 Then
                            threeCounterY1 += 1
                        ElseIf num1 = 4 Then
                            fourCounterY1 += 1
                        ElseIf num1 = 5 Then
                            fiveCounterY1 += 1
                        ElseIf num1 = 6 Then
                            sixCounterY1 += 1
                        End If

                        If num2 = 1 Then
                            oneCounterY1 += 1
                        ElseIf num2 = 2 Then
                            twoCounterY1 += 1
                        ElseIf num2 = 3 Then
                            threeCounterY1 += 1
                        ElseIf num2 = 4 Then
                            fourCounterY1 += 1
                        ElseIf num2 = 5 Then
                            fiveCounterY1 += 1
                        ElseIf num2 = 6 Then
                            sixCounterY1 += 1
                        End If

                        If num3 = 1 Then
                            oneCounterY1 += 1
                        ElseIf num3 = 2 Then
                            twoCounterY1 += 1
                        ElseIf num3 = 3 Then
                            threeCounterY1 += 1
                        ElseIf num3 = 4 Then
                            fourCounterY1 += 1
                        ElseIf num3 = 5 Then
                            fiveCounterY1 += 1
                        ElseIf num3 = 6 Then
                            sixCounterY1 += 1
                        End If

                        If num4 = 1 Then
                            oneCounterY1 += 1
                        ElseIf num4 = 2 Then
                            twoCounterY1 += 1
                        ElseIf num4 = 3 Then
                            threeCounterY1 += 1
                        ElseIf num4 = 4 Then
                            fourCounterY1 += 1
                        ElseIf num4 = 5 Then
                            fiveCounterY1 += 1
                        ElseIf num4 = 6 Then
                            sixCounterY1 += 1
                        End If

                        If num5 = 1 Then
                            oneCounterY1 += 1
                        ElseIf num5 = 2 Then
                            twoCounterY1 += 1
                        ElseIf num5 = 3 Then
                            threeCounterY1 += 1
                        ElseIf num5 = 4 Then
                            fourCounterY1 += 1
                        ElseIf num5 = 5 Then
                            fiveCounterY1 += 1
                        ElseIf num5 = 6 Then
                            sixCounterY1 += 1
                        End If

                        If oneCounterY1 = 5 Or twoCounterY1 = 5 Or threeCounterY1 = 5 Or fourCounterY1 = 5 Or fiveCounterY1 = 5 Or sixCounterY1 = 5 Then
                            yahtzee1 = 50
                        Else
                            yahtzee1 = 0
                        End If

                        txtYahtzee1.Text = yahtzee1
                        rdoYahtzee1.IsEnabled = False
                    End If


                    If rdoChance1.IsChecked = True Then
                        chance1 = num1 + num2 + num3 + num4 + num5

                        txtChance1.Text = chance1
                        rdoChance1.IsEnabled = False
                    End If

                    If chkBonus1Y1.IsChecked = True Then
                        If yahtzee1 = 50 Then
                            Dim oneCounterY1B1, twoCounterY1B1, threeCounterY1B1, fourCounterY1B1, fiveCounterY1B1, sixCounterY1B1 As Integer
                            If num1 = 1 Then
                                oneCounterY1B1 += 1
                            ElseIf num1 = 2 Then
                                twoCounterY1B1 += 1
                            ElseIf num1 = 3 Then
                                threeCounterY1B1 += 1
                            ElseIf num1 = 4 Then
                                fourCounterY1B1 += 1
                            ElseIf num1 = 5 Then
                                fiveCounterY1B1 += 1
                            ElseIf num1 = 6 Then
                                sixCounterY1B1 += 1
                            End If

                            If num2 = 1 Then
                                oneCounterY1B1 += 1
                            ElseIf num2 = 2 Then
                                twoCounterY1B1 += 1
                            ElseIf num2 = 3 Then
                                threeCounterY1B1 += 1
                            ElseIf num2 = 4 Then
                                fourCounterY1B1 += 1
                            ElseIf num2 = 5 Then
                                fiveCounterY1B1 += 1
                            ElseIf num2 = 6 Then
                                sixCounterY1B1 += 1
                            End If

                            If num3 = 1 Then
                                oneCounterY1B1 += 1
                            ElseIf num3 = 2 Then
                                twoCounterY1B1 += 1
                            ElseIf num3 = 3 Then
                                threeCounterY1B1 += 1
                            ElseIf num3 = 4 Then
                                fourCounterY1B1 += 1
                            ElseIf num3 = 5 Then
                                fiveCounterY1B1 += 1
                            ElseIf num3 = 6 Then
                                sixCounterY1B1 += 1
                            End If

                            If num4 = 1 Then
                                oneCounterY1B1 += 1
                            ElseIf num4 = 2 Then
                                twoCounterY1B1 += 1
                            ElseIf num4 = 3 Then
                                threeCounterY1B1 += 1
                            ElseIf num4 = 4 Then
                                fourCounterY1B1 += 1
                            ElseIf num4 = 5 Then
                                fiveCounterY1B1 += 1
                            ElseIf num4 = 6 Then
                                sixCounterY1B1 += 1
                            End If

                            If num5 = 1 Then
                                oneCounterY1B1 += 1
                            ElseIf num5 = 2 Then
                                twoCounterY1B1 += 1
                            ElseIf num5 = 3 Then
                                threeCounterY1B1 += 1
                            ElseIf num5 = 4 Then
                                fourCounterY1B1 += 1
                            ElseIf num5 = 5 Then
                                fiveCounterY1B1 += 1
                            ElseIf num5 = 6 Then
                                sixCounterY1B1 += 1
                            End If

                            If oneCounterY1B1 = 5 Or twoCounterY1B1 = 5 Or threeCounterY1B1 = 5 Or fourCounterY1B1 = 5 Or fiveCounterY1B1 = 5 Or sixCounterY1B1 = 5 Then
                                bonusYahtzee1 += 100
                            End If

                            txtBonusYahtzee1.Text = bonusYahtzee1
                            chkBonus1Y1.IsEnabled = False
                        End If
                    End If

                    If chkBonus1Y2.IsChecked = True Then
                        If yahtzee1 = 50 Then
                            Dim oneCounterY1B2, twoCounterY1B2, threeCounterY1B2, fourCounterY1B2, fiveCounterY1B2, sixCounterY1B2 As Integer
                            If num1 = 1 Then
                                oneCounterY1B2 += 1
                            ElseIf num1 = 2 Then
                                twoCounterY1B2 += 1
                            ElseIf num1 = 3 Then
                                threeCounterY1B2 += 1
                            ElseIf num1 = 4 Then
                                fourCounterY1B2 += 1
                            ElseIf num1 = 5 Then
                                fiveCounterY1B2 += 1
                            ElseIf num1 = 6 Then
                                sixCounterY1B2 += 1
                            End If

                            If num2 = 1 Then
                                oneCounterY1B2 += 1
                            ElseIf num2 = 2 Then
                                twoCounterY1B2 += 1
                            ElseIf num2 = 3 Then
                                threeCounterY1B2 += 1
                            ElseIf num2 = 4 Then
                                fourCounterY1B2 += 1
                            ElseIf num2 = 5 Then
                                fiveCounterY1B2 += 1
                            ElseIf num2 = 6 Then
                                sixCounterY1B2 += 1
                            End If

                            If num3 = 1 Then
                                oneCounterY1B2 += 1
                            ElseIf num3 = 2 Then
                                twoCounterY1B2 += 1
                            ElseIf num3 = 3 Then
                                threeCounterY1B2 += 1
                            ElseIf num3 = 4 Then
                                fourCounterY1B2 += 1
                            ElseIf num3 = 5 Then
                                fiveCounterY1B2 += 1
                            ElseIf num3 = 6 Then
                                sixCounterY1B2 += 1
                            End If

                            If num4 = 1 Then
                                oneCounterY1B2 += 1
                            ElseIf num4 = 2 Then
                                twoCounterY1B2 += 1
                            ElseIf num4 = 3 Then
                                threeCounterY1B2 += 1
                            ElseIf num4 = 4 Then
                                fourCounterY1B2 += 1
                            ElseIf num4 = 5 Then
                                fiveCounterY1B2 += 1
                            ElseIf num4 = 6 Then
                                sixCounterY1B2 += 1
                            End If

                            If num5 = 1 Then
                                oneCounterY1B2 += 1
                            ElseIf num5 = 2 Then
                                twoCounterY1B2 += 1
                            ElseIf num5 = 3 Then
                                threeCounterY1B2 += 1
                            ElseIf num5 = 4 Then
                                fourCounterY1B2 += 1
                            ElseIf num5 = 5 Then
                                fiveCounterY1B2 += 1
                            ElseIf num5 = 6 Then
                                sixCounterY1B2 += 1
                            End If

                            If oneCounterY1B2 = 5 Or twoCounterY1B2 = 5 Or threeCounterY1B2 = 5 Or fourCounterY1B2 = 5 Or fiveCounterY1B2 = 5 Or sixCounterY1B2 = 5 Then
                                bonusYahtzee1 += 100
                            End If

                            txtBonusYahtzee1.Text = bonusYahtzee1
                            chkBonus1Y2.IsEnabled = False
                        End If
                    End If

                    If chkBonus3Y1.IsChecked = True Then
                        If yahtzee1 = 50 Then
                            Dim oneCounterY1B3, twoCounterY1B3, threeCounterY1B3, fourCounterY1B3, fiveCounterY1B3, sixCounterY1B3 As Integer
                            If num1 = 1 Then
                                oneCounterY1B3 += 1
                            ElseIf num1 = 2 Then
                                twoCounterY1B3 += 1
                            ElseIf num1 = 3 Then
                                threeCounterY1B3 += 1
                            ElseIf num1 = 4 Then
                                fourCounterY1B3 += 1
                            ElseIf num1 = 5 Then
                                fiveCounterY1B3 += 1
                            ElseIf num1 = 6 Then
                                sixCounterY1B3 += 1
                            End If

                            If num2 = 1 Then
                                oneCounterY1B3 += 1
                            ElseIf num2 = 2 Then
                                twoCounterY1B3 += 1
                            ElseIf num2 = 3 Then
                                threeCounterY1B3 += 1
                            ElseIf num2 = 4 Then
                                fourCounterY1B3 += 1
                            ElseIf num2 = 5 Then
                                fiveCounterY1B3 += 1
                            ElseIf num2 = 6 Then
                                sixCounterY1B3 += 1
                            End If

                            If num3 = 1 Then
                                oneCounterY1B3 += 1
                            ElseIf num3 = 2 Then
                                twoCounterY1B3 += 1
                            ElseIf num3 = 3 Then
                                threeCounterY1B3 += 1
                            ElseIf num3 = 4 Then
                                fourCounterY1B3 += 1
                            ElseIf num3 = 5 Then
                                fiveCounterY1B3 += 1
                            ElseIf num3 = 6 Then
                                sixCounterY1B3 += 1
                            End If

                            If num4 = 1 Then
                                oneCounterY1B3 += 1
                            ElseIf num4 = 2 Then
                                twoCounterY1B3 += 1
                            ElseIf num4 = 3 Then
                                threeCounterY1B3 += 1
                            ElseIf num4 = 4 Then
                                fourCounterY1B3 += 1
                            ElseIf num4 = 5 Then
                                fiveCounterY1B3 += 1
                            ElseIf num4 = 6 Then
                                sixCounterY1B3 += 1
                            End If

                            If num5 = 1 Then
                                oneCounterY1B3 += 1
                            ElseIf num5 = 2 Then
                                twoCounterY1B3 += 1
                            ElseIf num5 = 3 Then
                                threeCounterY1B3 += 1
                            ElseIf num5 = 4 Then
                                fourCounterY1B3 += 1
                            ElseIf num5 = 5 Then
                                fiveCounterY1B3 += 1
                            ElseIf num5 = 6 Then
                                sixCounterY1B3 += 1
                            End If

                            If oneCounterY1B3 = 5 Or twoCounterY1B3 = 5 Or threeCounterY1B3 = 5 Or fourCounterY1B3 = 5 Or fiveCounterY1B3 = 5 Or sixCounterY1B3 = 5 Then
                                bonusYahtzee1 += 100
                            End If

                            txtBonusYahtzee1.Text = bonusYahtzee1
                            chkBonus3Y1.IsEnabled = False

                            btnRoll.Opacity = 0
                            btnScore.Opacity = 0
                            btnCrossOff.Opacity = 1
                        End If
                    End If

                    If rdoOnes1.IsChecked = False AndAlso rdoTwos1.IsChecked = False AndAlso rdoThrees1.IsChecked = False AndAlso rdoFours1.IsChecked = False AndAlso rdoFives1.IsChecked = False AndAlso rdoSixes1.IsChecked = False AndAlso rdo3OfAKind1.IsChecked = False AndAlso rdo4OfAKind1.IsChecked = False AndAlso rdoFullHouse1.IsChecked = False AndAlso rdoSmallStr1.IsChecked = False AndAlso rdoLargeStr1.IsChecked = False AndAlso rdoChance1.IsChecked = False AndAlso rdoYahtzee1.IsChecked = False AndAlso chkBonus1Y1.IsChecked = False AndAlso chkBonus2Y1.IsChecked = False AndAlso chkBonus3Y1.IsChecked = False Then
                        MsgBox("Please select a proper response.")
                        playerOne = False
                    End If



                ElseIf playerOne = False Then
                    If rdoOnes2.IsChecked = True Then
                        If num1 = 1 Then
                            ones2 += 1
                        End If
                        If num2 = 1 Then
                            ones2 += 1
                        End If
                        If num3 = 1 Then
                            ones2 += 1
                        End If
                        If num4 = 1 Then
                            ones2 += 1
                        End If
                        If num5 = 1 Then
                            ones2 += 1
                        End If
                        rdoOnes2.IsEnabled = False
                        txtOnes2.Text = ones2
                    End If

                    If rdoTwos2.IsChecked = True Then
                        If num1 = 2 Then
                            twos2 += 2
                        End If
                        If num2 = 2 Then
                            twos2 += 2
                        End If
                        If num3 = 2 Then
                            twos2 += 2
                        End If
                        If num4 = 2 Then
                            twos2 += 2
                        End If
                        If num5 = 2 Then
                            twos2 += 2
                        End If
                        rdoTwos2.IsEnabled = False
                        txtTwos2.Text = twos2
                    End If

                    If rdoThrees2.IsChecked = True Then
                        If num1 = 3 Then
                            threes2 += 3
                        End If
                        If num2 = 3 Then
                            threes2 += 3
                        End If
                        If num3 = 3 Then
                            threes2 += 3
                        End If
                        If num4 = 3 Then
                            threes2 += 3
                        End If
                        If num5 = 3 Then
                            threes2 += 3
                        End If
                        rdoThrees2.IsEnabled = False
                        txtThrees2.Text = threes2
                    End If

                    If rdoFours2.IsChecked = True Then
                        If num1 = 4 Then
                            fours2 += 4
                        End If
                        If num2 = 4 Then
                            fours2 += 4
                        End If
                        If num3 = 4 Then
                            fours2 += 4
                        End If
                        If num4 = 4 Then
                            fours2 += 4
                        End If
                        If num5 = 4 Then
                            fours2 += 4
                        End If
                        rdoFours2.IsEnabled = False
                        txtFours2.Text = fours2
                    End If

                    If rdoFives2.IsChecked = True Then
                        If num1 = 5 Then
                            fives2 += 5
                        End If
                        If num2 = 5 Then
                            fives2 += 5
                        End If
                        If num3 = 5 Then
                            fives2 += 5
                        End If
                        If num4 = 5 Then
                            fives2 += 5
                        End If
                        If num5 = 5 Then
                            fives2 += 5
                        End If
                        rdoFives2.IsEnabled = False
                        txtFives2.Text = fives2
                    End If

                    If rdoSixes2.IsChecked = True Then
                        If num1 = 6 Then
                            sixes2 += 6
                        End If
                        If num2 = 6 Then
                            sixes2 += 6
                        End If
                        If num3 = 6 Then
                            sixes2 += 6
                        End If
                        If num4 = 6 Then
                            sixes2 += 6
                        End If
                        If num5 = 6 Then
                            sixes2 += 6
                        End If
                        rdoSixes2.IsEnabled = False
                        txtSixes2.Text = sixes2
                    End If

                    If rdo3OfAKind2.IsChecked = True Then
                        Dim oneCounter32, twoCounter32, threeCounter32, fourCounter32, fiveCounter32, sixCounter32 As Integer
                        If num1 = 1 Then
                            oneCounter32 += 1
                        ElseIf num1 = 2 Then
                            twoCounter32 += 1
                        ElseIf num1 = 3 Then
                            threeCounter32 += 1
                        ElseIf num1 = 4 Then
                            fourCounter32 += 1
                        ElseIf num1 = 5 Then
                            fiveCounter32 += 1
                        ElseIf num1 = 6 Then
                            sixCounter32 += 1
                        End If

                        If num2 = 1 Then
                            oneCounter32 += 1
                        ElseIf num2 = 2 Then
                            twoCounter32 += 1
                        ElseIf num2 = 3 Then
                            threeCounter32 += 1
                        ElseIf num2 = 4 Then
                            fourCounter32 += 1
                        ElseIf num2 = 5 Then
                            fiveCounter32 += 1
                        ElseIf num2 = 6 Then
                            sixCounter32 += 1
                        End If

                        If num3 = 1 Then
                            oneCounter32 += 1
                        ElseIf num3 = 2 Then
                            twoCounter32 += 1
                        ElseIf num3 = 3 Then
                            threeCounter32 += 1
                        ElseIf num3 = 4 Then
                            fourCounter32 += 1
                        ElseIf num3 = 5 Then
                            fiveCounter32 += 1
                        ElseIf num3 = 6 Then
                            sixCounter32 += 1
                        End If

                        If num4 = 1 Then
                            oneCounter32 += 1
                        ElseIf num4 = 2 Then
                            twoCounter32 += 1
                        ElseIf num4 = 3 Then
                            threeCounter32 += 1
                        ElseIf num4 = 4 Then
                            fourCounter32 += 1
                        ElseIf num4 = 5 Then
                            fiveCounter32 += 1
                        ElseIf num4 = 6 Then
                            sixCounter32 += 1
                        End If

                        If num5 = 1 Then
                            oneCounter32 += 1
                        ElseIf num5 = 2 Then
                            twoCounter32 += 1
                        ElseIf num5 = 3 Then
                            threeCounter32 += 1
                        ElseIf num5 = 4 Then
                            fourCounter32 += 1
                        ElseIf num5 = 5 Then
                            fiveCounter32 += 1
                        ElseIf num5 = 6 Then
                            sixCounter32 += 1
                        End If

                        If oneCounter32 >= 3 Or twoCounter32 >= 3 Or threeCounter32 >= 3 Or fourCounter32 >= 3 Or fiveCounter32 >= 3 Or sixCounter32 >= 3 Then
                            threeOfAKind2 = num1 + num2 + num3 + num4 + num5
                        Else
                            threeOfAKind2 = 0
                        End If

                        txt3OfAKind2.Text = threeOfAKind2
                        rdo3OfAKind2.IsEnabled = False
                    End If

                    If rdo4OfAKind2.IsChecked = True Then
                        Dim oneCounter42, twoCounter42, threeCounter42, fourCounter42, fiveCounter42, sixCounter42 As Integer
                        If num1 = 1 Then
                            oneCounter42 += 1
                        ElseIf num1 = 2 Then
                            twoCounter42 += 1
                        ElseIf num1 = 3 Then
                            threeCounter42 += 1
                        ElseIf num1 = 4 Then
                            fourCounter42 += 1
                        ElseIf num1 = 5 Then
                            fiveCounter42 += 1
                        ElseIf num1 = 6 Then
                            sixCounter42 += 1
                        End If

                        If num2 = 1 Then
                            oneCounter42 += 1
                        ElseIf num2 = 2 Then
                            twoCounter42 += 1
                        ElseIf num2 = 3 Then
                            threeCounter42 += 1
                        ElseIf num2 = 4 Then
                            fourCounter42 += 1
                        ElseIf num2 = 5 Then
                            fiveCounter42 += 1
                        ElseIf num2 = 6 Then
                            sixCounter42 += 1
                        End If

                        If num3 = 1 Then
                            oneCounter42 += 1
                        ElseIf num3 = 2 Then
                            twoCounter42 += 1
                        ElseIf num3 = 3 Then
                            threeCounter42 += 1
                        ElseIf num3 = 4 Then
                            fourCounter42 += 1
                        ElseIf num3 = 5 Then
                            fiveCounter42 += 1
                        ElseIf num3 = 6 Then
                            sixCounter42 += 1
                        End If

                        If num4 = 1 Then
                            oneCounter42 += 1
                        ElseIf num4 = 2 Then
                            twoCounter42 += 1
                        ElseIf num4 = 3 Then
                            threeCounter42 += 1
                        ElseIf num4 = 4 Then
                            fourCounter42 += 1
                        ElseIf num4 = 5 Then
                            fiveCounter42 += 1
                        ElseIf num4 = 6 Then
                            sixCounter42 += 1
                        End If

                        If num5 = 1 Then
                            oneCounter42 += 1
                        ElseIf num5 = 2 Then
                            twoCounter42 += 1
                        ElseIf num5 = 3 Then
                            threeCounter42 += 1
                        ElseIf num5 = 4 Then
                            fourCounter42 += 1
                        ElseIf num5 = 5 Then
                            fiveCounter42 += 1
                        ElseIf num5 = 6 Then
                            sixCounter42 += 1
                        End If

                        If oneCounter42 >= 4 Or twoCounter42 >= 4 Or threeCounter42 >= 4 Or fourCounter42 >= 4 Or fiveCounter42 >= 4 Or sixCounter42 >= 4 Then
                            fourOfAKind2 = num1 + num2 + num3 + num4 + num5
                        Else
                            fourOfAKind2 = 0
                        End If

                        txt4OfAKind2.Text = threeOfAKind2
                        rdo4OfAKind2.IsEnabled = False
                    End If

                    If rdoFullHouse2.IsChecked = True Then
                        Dim oneCounterFH2, twoCounterFH2, threeCounterFH2, fourCounterFH2, fiveCounterFH2, sixCounterFH2 As Integer
                        Dim fullHouseBoo2 As Boolean = False
                        If num1 = 1 Then
                            oneCounterFH2 += 1
                        ElseIf num1 = 2 Then
                            twoCounterFH2 += 1
                        ElseIf num1 = 3 Then
                            threeCounterFH2 += 1
                        ElseIf num1 = 4 Then
                            fourCounterFH2 += 1
                        ElseIf num1 = 5 Then
                            fiveCounterFH2 += 1
                        ElseIf num1 = 6 Then
                            sixCounterFH2 += 1
                        End If

                        If num2 = 1 Then
                            oneCounterFH2 += 1
                        ElseIf num2 = 2 Then
                            twoCounterFH2 += 1
                        ElseIf num2 = 3 Then
                            threeCounterFH2 += 1
                        ElseIf num2 = 4 Then
                            fourCounterFH2 += 1
                        ElseIf num2 = 5 Then
                            fiveCounterFH2 += 1
                        ElseIf num2 = 6 Then
                            sixCounterFH2 += 1
                        End If

                        If num3 = 1 Then
                            oneCounterFH2 += 1
                        ElseIf num3 = 2 Then
                            twoCounterFH2 += 1
                        ElseIf num3 = 3 Then
                            threeCounterFH2 += 1
                        ElseIf num3 = 4 Then
                            fourCounterFH2 += 1
                        ElseIf num3 = 5 Then
                            fiveCounterFH2 += 1
                        ElseIf num3 = 6 Then
                            sixCounterFH2 += 1
                        End If

                        If num4 = 1 Then
                            oneCounterFH2 += 1
                        ElseIf num4 = 2 Then
                            twoCounterFH2 += 1
                        ElseIf num4 = 3 Then
                            threeCounterFH2 += 1
                        ElseIf num4 = 4 Then
                            fourCounterFH2 += 1
                        ElseIf num4 = 5 Then
                            fiveCounterFH2 += 1
                        ElseIf num4 = 6 Then
                            sixCounterFH2 += 1
                        End If

                        If num5 = 1 Then
                            oneCounterFH2 += 1
                        ElseIf num5 = 2 Then
                            twoCounterFH2 += 1
                        ElseIf num5 = 3 Then
                            threeCounterFH2 += 1
                        ElseIf num5 = 4 Then
                            fourCounterFH2 += 1
                        ElseIf num5 = 5 Then
                            fiveCounterFH2 += 1
                        ElseIf num5 = 6 Then
                            sixCounterFH2 += 1
                        End If

                        If oneCounterFH2 = 3 Then
                            If twoCounterFH2 = 2 Or threeCounterFH2 = 2 Or fourCounterFH2 = 2 Or fiveCounterFH2 = 2 Or sixCounterFH2 = 2 Then
                                fullHouseBoo2 = True
                            End If
                        ElseIf twoCounterFH2 = 3 Then
                            If oneCounterFH2 = 2 Or threeCounterFH2 = 2 Or fourCounterFH2 = 2 Or fiveCounterFH2 = 2 Or sixCounterFH2 = 2 Then
                                fullHouseBoo2 = True
                            End If
                        ElseIf threeCounterFH2 = 3 Then
                            If twoCounterFH2 = 2 Or oneCounterFH2 = 2 Or fourCounterFH2 = 2 Or fiveCounterFH2 = 2 Or sixCounterFH2 = 2 Then
                                fullHouseBoo2 = True
                            End If
                        ElseIf fourCounterFH2 = 3 Then
                            If twoCounterFH2 = 2 Or threeCounterFH2 = 2 Or oneCounterFH2 = 2 Or fiveCounterFH2 = 2 Or sixCounterFH2 = 2 Then
                                fullHouseBoo2 = True
                            End If
                        ElseIf fiveCounterFH2 = 3 Then
                            If twoCounterFH2 = 2 Or threeCounterFH2 = 2 Or fourCounterFH2 = 2 Or oneCounterFH2 = 2 Or sixCounterFH2 = 2 Then
                                fullHouseBoo2 = True
                            End If
                        ElseIf sixCounterFH2 = 3 Then
                            If twoCounterFH2 = 2 Or threeCounterFH2 = 2 Or fourCounterFH2 = 2 Or fiveCounterFH2 = 2 Or oneCounterFH2 = 2 Then
                                fullHouseBoo2 = True
                            End If
                        End If

                        If fullHouseBoo2 = True Then
                            fullhouse2 = 25
                        Else
                            fullhouse2 = 0
                        End If

                        txtFullHouse2.Text = fullhouse2
                        rdoFullHouse2.IsEnabled = False
                    End If

                    If rdoSmallStr2.IsChecked = True Then
                        Dim smallStr2Nums As String = num1.ToString + num2.ToString + num3.ToString + num4.ToString + num5.ToString
                        Dim smallStr2Boo As Boolean = False

                        If smallStr2Nums.Contains("1") AndAlso smallStr2Nums.Contains("2") AndAlso smallStr2Nums.Contains("3") AndAlso smallStr2Nums.Contains("4") Then
                            smallStr2Boo = True
                        ElseIf smallStr2Nums.Contains("2") AndAlso smallStr2Nums.Contains("3") AndAlso smallStr2Nums.Contains("4") AndAlso smallStr2Nums.Contains("5") Then
                            smallStr2Boo = True
                        ElseIf smallStr2Nums.Contains("3") AndAlso smallStr2Nums.Contains("4") AndAlso smallStr2Nums.Contains("5") AndAlso smallStr2Nums.Contains("6") Then
                            smallStr2Boo = True
                        End If

                        If smallStr2Boo = True Then
                            smallStr2 = 30
                        Else
                            smallStr2 = 0
                        End If

                        txtSmallStr2.Text = smallStr2
                        rdoSmallStr2.IsEnabled = False
                    End If

                    If rdoLargeStr2.IsChecked = True Then
                        Dim largeStr2Nums As String = num1.ToString + num2.ToString + num3.ToString + num4.ToString + num5.ToString
                        Dim largeStr2Boo As Boolean = False

                        If largeStr2Nums.Contains("1") AndAlso largeStr2Nums.Contains("2") AndAlso largeStr2Nums.Contains("3") AndAlso largeStr2Nums.Contains("4") AndAlso largeStr2Nums.Contains("5") Then
                            largeStr2Boo = True
                        ElseIf largeStr2Nums.Contains("2") AndAlso largeStr2Nums.Contains("3") AndAlso largeStr2Nums.Contains("4") AndAlso largeStr2Nums.Contains("5") AndAlso largeStr2Nums.Contains("6") Then
                            largeStr2Boo = True
                        End If

                        If largeStr2Boo = True Then
                            largeStr2 = 40
                        Else
                            largeStr2 = 0
                        End If

                        txtLargeStr2.Text = largeStr2
                        rdoLargeStr2.IsEnabled = False
                    End If

                    If rdoYahtzee2.IsChecked = True Then
                        Dim oneCounterY2, twoCounterY2, threeCounterY2, fourCounterY2, fiveCounterY2, sixCounterY2 As Integer
                        If num1 = 1 Then
                            oneCounterY2 += 1
                        ElseIf num1 = 2 Then
                            twoCounterY2 += 1
                        ElseIf num1 = 3 Then
                            threeCounterY2 += 1
                        ElseIf num1 = 4 Then
                            fourCounterY2 += 1
                        ElseIf num1 = 5 Then
                            fiveCounterY2 += 1
                        ElseIf num1 = 6 Then
                            sixCounterY2 += 1
                        End If

                        If num2 = 1 Then
                            oneCounterY2 += 1
                        ElseIf num2 = 2 Then
                            twoCounterY2 += 1
                        ElseIf num2 = 3 Then
                            threeCounterY2 += 1
                        ElseIf num2 = 4 Then
                            fourCounterY2 += 1
                        ElseIf num2 = 5 Then
                            fiveCounterY2 += 1
                        ElseIf num2 = 6 Then
                            sixCounterY2 += 1
                        End If

                        If num3 = 1 Then
                            oneCounterY2 += 1
                        ElseIf num3 = 2 Then
                            twoCounterY2 += 1
                        ElseIf num3 = 3 Then
                            threeCounterY2 += 1
                        ElseIf num3 = 4 Then
                            fourCounterY2 += 1
                        ElseIf num3 = 5 Then
                            fiveCounterY2 += 1
                        ElseIf num3 = 6 Then
                            sixCounterY2 += 1
                        End If

                        If num4 = 1 Then
                            oneCounterY2 += 1
                        ElseIf num4 = 2 Then
                            twoCounterY2 += 1
                        ElseIf num4 = 3 Then
                            threeCounterY2 += 1
                        ElseIf num4 = 4 Then
                            fourCounterY2 += 1
                        ElseIf num4 = 5 Then
                            fiveCounterY2 += 1
                        ElseIf num4 = 6 Then
                            sixCounterY2 += 1
                        End If

                        If num5 = 1 Then
                            oneCounterY2 += 1
                        ElseIf num5 = 2 Then
                            twoCounterY2 += 1
                        ElseIf num5 = 3 Then
                            threeCounterY2 += 1
                        ElseIf num5 = 4 Then
                            fourCounterY2 += 1
                        ElseIf num5 = 5 Then
                            fiveCounterY2 += 1
                        ElseIf num5 = 6 Then
                            sixCounterY2 += 1
                        End If

                        If oneCounterY2 = 5 Or twoCounterY2 = 5 Or threeCounterY2 = 5 Or fourCounterY2 = 5 Or fiveCounterY2 = 5 Or sixCounterY2 = 5 Then
                            yahtzee2 = 50
                        Else
                            yahtzee2 = 0
                        End If

                        txtYahtzee2.Text = yahtzee2
                        rdoYahtzee2.IsEnabled = False
                    End If

                    If rdoChance2.IsChecked = True Then
                        chance2 = num1 + num2 + num3 + num4 + num5

                        txtChance2.Text = chance2
                        rdoChance2.IsEnabled = False
                    End If

                    If chkBonus1Y2.IsChecked = True Then
                        If yahtzee2 = 50 Then
                            Dim oneCounterY2B1, twoCounterY2B1, threeCounterY2B1, fourCounterY2B1, fiveCounterY2B1, sixCounterY2B1 As Integer
                            If num1 = 1 Then
                                oneCounterY2B1 += 1
                            ElseIf num1 = 2 Then
                                twoCounterY2B1 += 1
                            ElseIf num1 = 3 Then
                                threeCounterY2B1 += 1
                            ElseIf num1 = 4 Then
                                fourCounterY2B1 += 1
                            ElseIf num1 = 5 Then
                                fiveCounterY2B1 += 1
                            ElseIf num1 = 6 Then
                                sixCounterY2B1 += 1
                            End If

                            If num2 = 1 Then
                                oneCounterY2B1 += 1
                            ElseIf num2 = 2 Then
                                twoCounterY2B1 += 1
                            ElseIf num2 = 3 Then
                                threeCounterY2B1 += 1
                            ElseIf num2 = 4 Then
                                fourCounterY2B1 += 1
                            ElseIf num2 = 5 Then
                                fiveCounterY2B1 += 1
                            ElseIf num2 = 6 Then
                                sixCounterY2B1 += 1
                            End If

                            If num3 = 1 Then
                                oneCounterY2B1 += 1
                            ElseIf num3 = 2 Then
                                twoCounterY2B1 += 1
                            ElseIf num3 = 3 Then
                                threeCounterY2B1 += 1
                            ElseIf num3 = 4 Then
                                fourCounterY2B1 += 1
                            ElseIf num3 = 5 Then
                                fiveCounterY2B1 += 1
                            ElseIf num3 = 6 Then
                                sixCounterY2B1 += 1
                            End If

                            If num4 = 1 Then
                                oneCounterY2B1 += 1
                            ElseIf num4 = 2 Then
                                twoCounterY2B1 += 1
                            ElseIf num4 = 3 Then
                                threeCounterY2B1 += 1
                            ElseIf num4 = 4 Then
                                fourCounterY2B1 += 1
                            ElseIf num4 = 5 Then
                                fiveCounterY2B1 += 1
                            ElseIf num4 = 6 Then
                                sixCounterY2B1 += 1
                            End If

                            If num5 = 1 Then
                                oneCounterY2B1 += 1
                            ElseIf num5 = 2 Then
                                twoCounterY2B1 += 1
                            ElseIf num5 = 3 Then
                                threeCounterY2B1 += 1
                            ElseIf num5 = 4 Then
                                fourCounterY2B1 += 1
                            ElseIf num5 = 5 Then
                                fiveCounterY2B1 += 1
                            ElseIf num5 = 6 Then
                                sixCounterY2B1 += 1
                            End If

                            If oneCounterY2B1 = 5 Or twoCounterY2B1 = 5 Or threeCounterY2B1 = 5 Or fourCounterY2B1 = 5 Or fiveCounterY2B1 = 5 Or sixCounterY2B1 = 5 Then
                                bonusYahtzee2 += 100
                            End If

                            txtBonusYahtzee2.Text = bonusYahtzee2
                            chkBonus1Y2.IsEnabled = False
                        End If
                    End If

                    If chkBonus2Y2.IsChecked = True Then
                        If yahtzee2 = 50 Then
                            Dim oneCounterY2B2, twoCounterY2B2, threeCounterY2B2, fourCounterY2B2, fiveCounterY2B2, sixCounterY2B2 As Integer
                            If num1 = 1 Then
                                oneCounterY2B2 += 1
                            ElseIf num1 = 2 Then
                                twoCounterY2B2 += 1
                            ElseIf num1 = 3 Then
                                threeCounterY2B2 += 1
                            ElseIf num1 = 4 Then
                                fourCounterY2B2 += 1
                            ElseIf num1 = 5 Then
                                fiveCounterY2B2 += 1
                            ElseIf num1 = 6 Then
                                sixCounterY2B2 += 1
                            End If

                            If num2 = 1 Then
                                oneCounterY2B2 += 1
                            ElseIf num2 = 2 Then
                                twoCounterY2B2 += 1
                            ElseIf num2 = 3 Then
                                threeCounterY2B2 += 1
                            ElseIf num2 = 4 Then
                                fourCounterY2B2 += 1
                            ElseIf num2 = 5 Then
                                fiveCounterY2B2 += 1
                            ElseIf num2 = 6 Then
                                sixCounterY2B2 += 1
                            End If

                            If num3 = 1 Then
                                oneCounterY2B2 += 1
                            ElseIf num3 = 2 Then
                                twoCounterY2B2 += 1
                            ElseIf num3 = 3 Then
                                threeCounterY2B2 += 1
                            ElseIf num3 = 4 Then
                                fourCounterY2B2 += 1
                            ElseIf num3 = 5 Then
                                fiveCounterY2B2 += 1
                            ElseIf num3 = 6 Then
                                sixCounterY2B2 += 1
                            End If

                            If num4 = 1 Then
                                oneCounterY2B2 += 1
                            ElseIf num4 = 2 Then
                                twoCounterY2B2 += 1
                            ElseIf num4 = 3 Then
                                threeCounterY2B2 += 1
                            ElseIf num4 = 4 Then
                                fourCounterY2B2 += 1
                            ElseIf num4 = 5 Then
                                fiveCounterY2B2 += 1
                            ElseIf num4 = 6 Then
                                sixCounterY2B2 += 1
                            End If

                            If num5 = 1 Then
                                oneCounterY2B2 += 1
                            ElseIf num5 = 2 Then
                                twoCounterY2B2 += 1
                            ElseIf num5 = 3 Then
                                threeCounterY2B2 += 1
                            ElseIf num5 = 4 Then
                                fourCounterY2B2 += 1
                            ElseIf num5 = 5 Then
                                fiveCounterY2B2 += 1
                            ElseIf num5 = 6 Then
                                sixCounterY2B2 += 1
                            End If

                            If oneCounterY2B2 = 5 Or twoCounterY2B2 = 5 Or threeCounterY2B2 = 5 Or fourCounterY2B2 = 5 Or fiveCounterY2B2 = 5 Or sixCounterY2B2 = 5 Then
                                bonusYahtzee2 += 100
                            End If

                            txtBonusYahtzee2.Text = bonusYahtzee2
                            chkBonus2Y2.IsEnabled = False
                        End If
                    End If

                    If chkBonus3Y2.IsChecked = True Then
                        If yahtzee2 = 50 Then
                            Dim oneCounterY2B3, twoCounterY2B3, threeCounterY2B3, fourCounterY2B3, fiveCounterY2B3, sixCounterY2B3 As Integer
                            If num1 = 1 Then
                                oneCounterY2B3 += 1
                            ElseIf num1 = 2 Then
                                twoCounterY2B3 += 1
                            ElseIf num1 = 3 Then
                                threeCounterY2B3 += 1
                            ElseIf num1 = 4 Then
                                fourCounterY2B3 += 1
                            ElseIf num1 = 5 Then
                                fiveCounterY2B3 += 1
                            ElseIf num1 = 6 Then
                                sixCounterY2B3 += 1
                            End If

                            If num2 = 1 Then
                                oneCounterY2B3 += 1
                            ElseIf num2 = 2 Then
                                twoCounterY2B3 += 1
                            ElseIf num2 = 3 Then
                                threeCounterY2B3 += 1
                            ElseIf num2 = 4 Then
                                fourCounterY2B3 += 1
                            ElseIf num2 = 5 Then
                                fiveCounterY2B3 += 1
                            ElseIf num2 = 6 Then
                                sixCounterY2B3 += 1
                            End If

                            If num3 = 1 Then
                                oneCounterY2B3 += 1
                            ElseIf num3 = 2 Then
                                twoCounterY2B3 += 1
                            ElseIf num3 = 3 Then
                                threeCounterY2B3 += 1
                            ElseIf num3 = 4 Then
                                fourCounterY2B3 += 1
                            ElseIf num3 = 5 Then
                                fiveCounterY2B3 += 1
                            ElseIf num3 = 6 Then
                                sixCounterY2B3 += 1
                            End If

                            If num4 = 1 Then
                                oneCounterY2B3 += 1
                            ElseIf num4 = 2 Then
                                twoCounterY2B3 += 1
                            ElseIf num4 = 3 Then
                                threeCounterY2B3 += 1
                            ElseIf num4 = 4 Then
                                fourCounterY2B3 += 1
                            ElseIf num4 = 5 Then
                                fiveCounterY2B3 += 1
                            ElseIf num4 = 6 Then
                                sixCounterY2B3 += 1
                            End If

                            If num5 = 1 Then
                                oneCounterY2B3 += 1
                            ElseIf num5 = 2 Then
                                twoCounterY2B3 += 1
                            ElseIf num5 = 3 Then
                                threeCounterY2B3 += 1
                            ElseIf num5 = 4 Then
                                fourCounterY2B3 += 1
                            ElseIf num5 = 5 Then
                                fiveCounterY2B3 += 1
                            ElseIf num5 = 6 Then
                                sixCounterY2B3 += 1
                            End If

                            If oneCounterY2B3 = 5 Or twoCounterY2B3 = 5 Or threeCounterY2B3 = 5 Or fourCounterY2B3 = 5 Or fiveCounterY2B3 = 5 Or sixCounterY2B3 = 5 Then
                                bonusYahtzee2 += 100
                            End If

                            txtBonusYahtzee2.Text = bonusYahtzee2
                            chkBonus3Y2.IsEnabled = False
                        End If
                    End If
                    If rdoOnes2.IsChecked = False AndAlso rdoTwos2.IsChecked = False AndAlso rdoThrees2.IsChecked = False AndAlso rdoFours2.IsChecked = False AndAlso rdoFives2.IsChecked = False AndAlso rdoSixes2.IsChecked = False AndAlso rdo3OfAKind2.IsChecked = False AndAlso rdo4OfAKind2.IsChecked = False AndAlso rdoFullHouse2.IsChecked = False AndAlso rdoSmallStr2.IsChecked = False AndAlso rdoLargeStr2.IsChecked = False AndAlso rdoChance2.IsChecked = False AndAlso rdoYahtzee2.IsChecked = False AndAlso chkBonus1Y2.IsChecked = False AndAlso chkBonus2Y2.IsChecked = False AndAlso chkBonus3Y2.IsChecked = False Then
                        MsgBox("Please select a proper response.")
                        playerOne = True
                    End If
                End If
            End If
        End If



        txtTotal1.Text = ones1 + twos1 + threes1 + fours1 + fives1 + sixes1

        If ones1 + twos1 + threes1 + fours1 + fives1 + sixes1 >= 63 Then
            txtTotalUpper1.Text = ones1 + twos1 + threes1 + fours1 + fives1 + sixes1 + 35
            txtBonus1.Text = 35
            bonus1 = 35
        Else
            txtTotalUpper1.Text = ones1 + twos1 + threes1 + fours1 + fives1 + sixes1
            txtBonus1.Text = 0
            bonus1 = 0
        End If

        txtUpperTotal1.Text = ones1 + twos1 + threes1 + fours1 + fives1 + sixes1 + bonus1

        txtLowerTotal1.Text = threeOfAKind1 + fourOfAKind1 + fullHouse1 + largeStr1 + smallStr1 + chance1 + yahtzee1 + bonusYahtzee1

        txtCombined1.Text = ones1 + twos1 + threes1 + fours1 + fives1 + sixes1 + threeOfAKind1 + fourOfAKind1 + fullHouse1 + largeStr1 + smallStr1 + chance1 + yahtzee1 + bonusYahtzee1 + bonus1



        txtTotal2.Text = ones2 + twos2 + threes2 + fours2 + fives2 + sixes2

        If ones2 + twos2 + threes2 + fours2 + fives2 + sixes2 >= 63 Then
            txtTotalUpper2.Text = ones2 + twos2 + threes2 + fours2 + fives2 + sixes2 + 35
            txtBonus2.Text = 35
            bonus2 = 35
        Else
            txtTotalUpper2.Text = ones2 + twos2 + threes2 + fours2 + fives2 + sixes2
            txtBonus2.Text = 0
            bonus2 = 0
        End If

        txtUpperTotal2.Text = ones2 + twos2 + threes2 + fours2 + fives2 + sixes2 + bonus2

        txtLowerTotal2.Text = threeOfAKind2 + fourOfAKind2 + fullhouse2 + largeStr2 + smallStr2 + chance2 + yahtzee2 + bonusYahtzee2

        txtCombined2.Text = ones2 + twos2 + threes2 + fours2 + fives2 + sixes2 + threeOfAKind2 + fourOfAKind2 + fullhouse2 + largeStr2 + smallStr2 + chance2 + yahtzee2 + bonusYahtzee2 + bonus2




        If playerOne = True Then
            playerOne = False
            img1.Opacity = 1
            img2.Opacity = 1
            img3.Opacity = 1
            img4.Opacity = 1
            img5.Opacity = 1
            rollsThisTurn = 0
        ElseIf playerOne = False Then
            playerOne = True
            img1.Opacity = 1
            img2.Opacity = 1
            img3.Opacity = 1
            img4.Opacity = 1
            img5.Opacity = 1
            rollsThisTurn = 0
        End If


        If rdoOnes1.IsEnabled = False AndAlso rdoTwos1.IsEnabled = False AndAlso rdoThrees1.IsEnabled = False AndAlso rdoFours1.IsEnabled = False AndAlso rdoFives1.IsEnabled = False AndAlso rdoSixes1.IsEnabled = False AndAlso rdo3OfAKind1.IsEnabled = False AndAlso rdo4OfAKind1.IsEnabled = False AndAlso rdoSmallStr1.IsEnabled = False AndAlso rdoLargeStr1.IsEnabled = False AndAlso rdoFullHouse1.IsEnabled = False AndAlso rdoChance1.IsEnabled = False AndAlso rdoYahtzee1.IsEnabled = False AndAlso rdoOnes2.IsEnabled = False AndAlso rdoTwos2.IsEnabled = False AndAlso rdoThrees2.IsEnabled = False AndAlso rdoFours2.IsEnabled = False AndAlso rdoFives2.IsEnabled = False AndAlso rdoSixes2.IsEnabled = False AndAlso rdo3OfAKind2.IsEnabled = False AndAlso rdo4OfAKind2.IsEnabled = False AndAlso rdoSmallStr2.IsEnabled = False AndAlso rdoLargeStr2.IsEnabled = False AndAlso rdoFullHouse2.IsEnabled = False AndAlso rdoChance2.IsEnabled = False AndAlso rdoYahtzee2.IsEnabled = False Then
            If txtCombined1.Text > txtCombined2.Text Then
                MsgBox("Player 1 Wins!")
            ElseIf txtCombined1.Text < txtCombined2.Text Then
                MsgBox("Player 2 Wins!")
            Else
                MsgBox("Tie!")
            End If
        End If

    End Sub

    Private Sub btnCrossOff_Click(sender As Object, e As RoutedEventArgs) Handles btnCrossOff.Click
        If btnCrossOff.Opacity = 1 Then
            If playerOne = True Then
                If rdoOnes1.IsChecked = True Then
                    rdoOnes1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoTwos1.IsChecked = True Then
                    rdoTwos1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoThrees1.IsChecked = True Then
                    rdoThrees1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoFours1.IsChecked = True Then
                    rdoFours1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoFives1.IsChecked = True Then
                    rdoFives1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoSixes1.IsChecked = True Then
                    rdoSixes1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdo3OfAKind1.IsChecked = True Then
                    rdo3OfAKind1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdo4OfAKind1.IsChecked = True Then
                    rdo4OfAKind1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoSmallStr1.IsChecked = True Then
                    rdoSmallStr1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoLargeStr1.IsChecked = True Then
                    rdoLargeStr1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoFullHouse1.IsChecked = True Then
                    rdoFullHouse1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoYahtzee1.IsChecked = True Then
                    rdoYahtzee1.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoChance1.IsChecked Then
                    rdoChance1.IsEnabled = True
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                Else
                    MsgBox("Please select a correct option.")
                End If

            ElseIf playerOne = False Then
                If rdoOnes2.IsChecked = True Then
                    rdoOnes2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoTwos2.IsChecked = True Then
                    rdoTwos2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoThrees2.IsChecked = True Then
                    rdoThrees2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoFours2.IsChecked = True Then
                    rdoFours2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoFives2.IsChecked = True Then
                    rdoFives2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoSixes2.IsChecked = True Then
                    rdoSixes2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdo3OfAKind2.IsChecked = True Then
                    rdo3OfAKind2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdo4OfAKind2.IsChecked = True Then
                    rdo4OfAKind2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoSmallStr2.IsChecked = True Then
                    rdoSmallStr2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoLargeStr2.IsChecked = True Then
                    rdoLargeStr2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoFullHouse2.IsChecked = True Then
                    rdoFullHouse2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoYahtzee2.IsChecked = True Then
                    rdoYahtzee2.IsEnabled = False
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                ElseIf rdoChance2.IsChecked Then
                    rdoChance2.IsEnabled = True
                    btnCrossOff.Opacity = 0
                    btnRoll.Opacity = 1
                    btnScore.Opacity = 1
                Else
                    MsgBox("Please select a correct option.")
                End If
            End If
        End If
    End Sub

    Private Sub Window_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.Key.Equals(Key.Y)) Then
            yahtzeeCheat = True
        ElseIf (e.Key.Equals(Key.F)) Then
            fullHouseCheat = True
        ElseIf (e.Key.Equals(Key.S)) Then
            straightCheat = True
        End If
    End Sub
End Class
