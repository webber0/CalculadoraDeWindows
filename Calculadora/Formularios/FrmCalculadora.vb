

Public Class FrmCalculadora
    '-------------------------------------
    'Variables
    '-------------------------------------
    Dim dblnumeroUno As Double
    Dim dblnumeroDos As Double
    Dim dblnumero As Double 'Esto es mas que nada para el cambio de signo
    Dim objOperacionActual As ClsOperacion
    Dim boolHabilitarComa As Boolean = True 'Para no escribir más de una vez la coma
    Dim objHistorial As ClsHistorialDeOperaciones
    Dim objBaseDeDatos As ClsBaseDeDatos
    Dim dtHistorial As DataTable



    '-------------------------------------
    'Control de Eventos
    '-------------------------------------
    Private Sub FrmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objBaseDeDatos = New ClsBaseDeDatos("Data Source=MS0036;Initial Catalog=HistorialEjecucion;User ID=sa; Password=Drowssap12;")
        'objBaseDeDatos.connectToDatabase()
        objHistorial = New ClsHistorialDeOperaciones()
    End Sub

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
        dblnumeroUno = Double.Parse(txtPantalla.Text)
        habilitarComa()
        txtPantalla.Clear()
        objOperacionActual = New ClsOperacionSuma(dblnumeroUno, 0, "+")
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        dblnumeroDos = Double.Parse(txtPantalla.Text)
        txtPantalla.Clear()
        objOperacionActual.NumeroDos = dblnumeroDos
        objOperacionActual.calcular()
        txtPantalla.Text = objOperacionActual.Resultado
        objHistorial.agregarElemento(objOperacionActual)
        objBaseDeDatos.saveToDatabase(objOperacionActual.retornarOperacion)

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        dblnumeroUno = Double.Parse(txtPantalla.Text)
        habilitarComa()
        txtPantalla.Clear()
        objOperacionActual = New ClsOperacionResta(dblnumeroUno, 0, "-")
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        dblnumeroUno = Double.Parse(txtPantalla.Text)
        habilitarComa()
        txtPantalla.Clear()
        objOperacionActual = New ClsOperacionMultiplicacion(dblnumeroUno, 0, "x")
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        dblnumeroUno = Double.Parse(txtPantalla.Text)
        habilitarComa()
        txtPantalla.Clear()
        objOperacionActual = New ClsOperacionDivision(dblnumeroUno, 0, "/")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtPantalla.Clear()

    End Sub

    Private Sub btnCambiarSigno_Click(sender As Object, e As EventArgs) Handles btnCambiarSigno.Click
        dblnumero = Double.Parse(txtPantalla.Text)
        dblnumero *= -1
        txtPantalla.Text = dblnumero
    End Sub

    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        If (boolHabilitarComa) Then
            txtPantalla.Text = txtPantalla.Text + ","
        End If
        boolHabilitarComa = False
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim frm As FrmHistorial = New FrmHistorial
        frm.dgvHistorial.DataSource = objBaseDeDatos.retriveFromDatabase
        frm.Show()
    End Sub

    Private Sub FrmCalculadoraFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        objBaseDeDatos.disconnectFromDatabase()
    End Sub


    '-------------------------------------
    'Rutinas privadas
    '-------------------------------------

    Private Sub habilitarComa()
        boolHabilitarComa = True
    End Sub




End Class
