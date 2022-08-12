Public Class Form1


    Dim numerito1
    Dim numerito2
    Dim operacion
    Dim result

    Dim service As New ServiceReference1.WebService1SoapClient

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtVentana.TextChanged

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventana = txtVentana.Text
        ventana += "1"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventana = txtVentana.Text
        ventana += "2"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ventana = txtVentana.Text
        ventana += "3"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ventana = txtVentana.Text
        ventana += "4"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ventana = txtVentana.Text
        ventana += "5"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ventana = txtVentana.Text
        ventana += "6"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ventana = txtVentana.Text
        ventana += "7"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim ventana = txtVentana.Text
        ventana += "8"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim ventana = txtVentana.Text
        ventana += "9"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ventana = txtVentana.Text
        ventana += "."
        txtVentana.Text = ventana
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim ventana = txtVentana.Text
        ventana += "0"
        txtVentana.Text = ventana
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Clear button'
        txtVentana.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        numerito1 = TomarValor()
        operacion = "Suma"
        txtVentana.Text = ""

    End Sub

    Public Function TomarValor()
        Dim answer = txtVentana.Text
        Dim number = 0
        Try
            number = Convert.ToDouble(answer)
            txtPrenumber.Text = number.ToString()
        Catch ex As Exception
            txtPrenumber.Text = ""
        End Try


        Return number
    End Function

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        numerito2 = TomarValor()
        If (operacion = "Suma") Then
            result = service.SumaOperaciones(numerito1, numerito2)
        ElseIf (operacion = "Resta") Then
            result = service.Restar(numerito1, numerito2)
        ElseIf (operacion = "Xcion") Then
            result = service.multiplicacion(numerito1, numerito2)
        ElseIf (operacion = "Division") Then
            result = service.dividir(numerito1, numerito2)
        ElseIf (operacion = "Porcentaje") Then
            result = service.porcentaje(numerito1, numerito2)
        ElseIf (operacion = "Factorial") Then
            result = service.factorial(numerito1)
        ElseIf (operacion = "Logaritmo") Then
            result = service.logaritmo(numerito1)
        ElseIf (operacion = "ValorAbsoluto") Then
            result = service.vabsoluto(numerito1)
        ElseIf (operacion = "Raiz") Then
            result = service.Raiz(numerito1)
        ElseIf (operacion = "Potencia") Then
            result = service.PotenciaOperaciones(numerito1, numerito2)
        End If



        txtVentana.Text = result.ToString()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        numerito1 = TomarValor()
        operacion = "Resta"
        txtVentana.Text = ""
    End Sub

    Private Sub btnXcion_Click(sender As Object, e As EventArgs) Handles btnXcion.Click
        numerito1 = TomarValor()
        operacion = "Xcion"
        txtVentana.Text = ""
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        numerito1 = TomarValor()
        operacion = "Division"
        txtVentana.Text = ""
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        numerito1 = TomarValor()
        operacion = "Porcentaje"
        txtVentana.Text = ""
    End Sub

    Private Sub btnFact_Click(sender As Object, e As EventArgs) Handles btnFact.Click
        numerito1 = TomarValor()
        operacion = "Factorial"
        txtVentana.Text = ""
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        numerito1 = TomarValor()
        operacion = "Logaritmo"
        txtVentana.Text = ""
    End Sub

    Private Sub btnValorAbsoluto_Click(sender As Object, e As EventArgs) Handles btnValorAbsoluto.Click
        numerito1 = TomarValor()
        operacion = "ValorAbsoluto"
        txtVentana.Text = ""
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        numerito1 = TomarValor()
        operacion = "Raiz"
        txtVentana.Text = ""
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        numerito1 = TomarValor()
        operacion = "Potencia"
        txtVentana.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtPrenumber.TextChanged

    End Sub
End Class
