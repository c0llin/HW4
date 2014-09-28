
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' set cursor to top textbox

        ' clear textboxes

        ' disable reset button

        'hide net pay label

    End Sub

    Protected Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' declare variables

        ' get user input

        ' validate user input & prompt if illegal entry

        ' remove pretax deductions

        ' calculate taxes 

        ' 18% for those with a gross pay of less than $500 each week. 
        ' Assume tax rate of 22% for
        'those with a gross pay of $500 or more each week
        
        ' remove tax from pay

        ' remove post tax deduction

        ' display net pay

        ' disable calculate button

        ' disable text entry until reset btn is pushed

        ' enable reset button


    End Sub
End Class
