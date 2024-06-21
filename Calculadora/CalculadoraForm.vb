Public Class CalculadoraForm
    '-------------------------------------
    'Variables
    '-------------------------------------
    Dim operacionActual As ClsOperacion

    '-------------------------------------
    'Control de Eventos
    '-------------------------------------
    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        txtPantalla.Text = txtPantalla.Text + "0"
    End Sub

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        txtPantalla.Text = txtPantalla.Text + "1"
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        txtPantalla.Text = txtPantalla.Text + "2"
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        txtPantalla.Text = txtPantalla.Text + "3"
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        txtPantalla.Text = txtPantalla.Text + "4"
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        txtPantalla.Text = txtPantalla.Text + "5"
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        txtPantalla.Text = txtPantalla.Text + "6"
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        txtPantalla.Text = txtPantalla.Text + "7"
    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        txtPantalla.Text = txtPantalla.Text + "8"
    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        txtPantalla.Text = txtPantalla.Text + "9"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        operacionActual.NumeroUno = Double.Parse(txtPantalla.Text)
        txtPantalla.Clear()
    End Sub
End Class
