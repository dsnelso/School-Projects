Public Class Form1
    Dim Base, Hgt, Area, Perimeter
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click

        Base = CDbl(TxtBase.Text)
        Hgt = CDbl(TxtHeight.Text)
        Area = Base * Hgt
        Perimeter = Base + Base + Hgt + Hgt
        LstResults.Items.Add("Area: " & Area)
        LstResults.Items.Add("Perimeter: " & Perimeter)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
