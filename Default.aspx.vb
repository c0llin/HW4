
Partial Class _Default
    Inherits System.Web.UI.Page

    Sub reset()
        'enable input
        tbDeductionpretax.Enabled = True
        tbhrworked.Enabled = True
        tbPostDeduction.Enabled = True
        tbwage.Enabled = True

        ' set cursor to top textbox
        tbwage.Focus()

        ' clear textboxes
        tbDeductionpretax.Text = String.Empty
        tbhrworked.Text = String.Empty
        tbPostDeduction.Text = String.Empty
        tbwage.Text = String.Empty

        ' disable reset button
        btnReset.Enabled = False
        'hide net pay label
        lblDisplayNet.Visible = False
        lblnetpay.Visible = False
    End Sub 'reset


    Function CalcPay(ByVal wage As Decimal, ByVal hour As Decimal, ByVal preD As Decimal, ByVal postD As Decimal) As Decimal


        ' 18% for those with a gross pay of less than $500 each week. 
        ' Assume tax rate of 22% for
        'those with a gross pay of $500 or more each week

        'declare variables, set tax rates
        Dim pay As Decimal
        Dim littleTax As Double = 0.18
        Dim bigTax As Double = 0.22

        ' pre tax deductions
        wage = (wage * hour) - preD

        ' validate user input and preform calculations
        Select Case wage
            Case 0
                'error code
                pay = -1
            Case Is < 0
                'error code
                pay = -1
            Case 0 To 499.99
                ' calculate taxes 
                pay = wage * (1 - littleTax)
                pay = pay - postD
            Case Is > 499.99
                ' calculate taxes 
                pay = wage * (1 - bigTax)
                pay = pay - postD
        End Select

        'return net pay
        Return pay
    End Function 'CalcPay

    Protected Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' calls reset sub
        reset()

    End Sub

    Protected Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' declare variables
        Dim wage, hrwork, preDeduction, postDeduction, netPay As Decimal
        ' get user input
        wage = Val(tbwage.Text)
        hrwork = Val(tbhrworked.Text)
        preDeduction = Val(tbDeductionpretax.Text)
        postDeduction = Val(tbPostDeduction.Text)


        ' call calc function
        netPay = CalcPay(wage, hrwork, preDeduction, postDeduction)

        If netPay > 0 Then
            ' display net pay
            lblDisplayNet.Visible = True
            lblnetpay.Visible = True

            lblnetpay.Text = FormatCurrency(CStr(netPay))

            ' disable calculate button
            btnCalc.Enabled = False

            ' enable reset button
            btnReset.Enabled = True
            ' disable text entry until reset btn is pushed
            tbDeductionpretax.Enabled = False
            tbhrworked.Enabled = False
            tbPostDeduction.Enabled = False
            tbwage.Enabled = False
        Else

        End If



        






    End Sub

    Protected Sub tbwage_TextChanged(sender As Object, e As EventArgs) Handles tbwage.TextChanged
        'enable calc button
        btnCalc.Enabled = True
        btnReset.Enabled = True
    End Sub

    Protected Sub tbhrworked_TextChanged(sender As Object, e As EventArgs) Handles tbhrworked.TextChanged
        'enable calc button
        btnCalc.Enabled = True
        btnReset.Enabled = True
    End Sub

    Protected Sub tbDeductionpretax_TextChanged(sender As Object, e As EventArgs) Handles tbDeductionpretax.TextChanged
        'enable calc button
        btnCalc.Enabled = True
        btnReset.Enabled = True
    End Sub

    Protected Sub tbPostDeduction_TextChanged(sender As Object, e As EventArgs) Handles tbPostDeduction.TextChanged
        'enable calc button
        btnCalc.Enabled = True
        btnReset.Enabled = True
    End Sub
End Class
