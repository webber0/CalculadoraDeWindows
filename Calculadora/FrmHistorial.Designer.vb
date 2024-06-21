<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHistorial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstHistorial = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstHistorial
        '
        Me.lstHistorial.FormattingEnabled = True
        Me.lstHistorial.Location = New System.Drawing.Point(12, 12)
        Me.lstHistorial.Name = "lstHistorial"
        Me.lstHistorial.Size = New System.Drawing.Size(202, 238)
        Me.lstHistorial.TabIndex = 0
        '
        'FrmHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 266)
        Me.Controls.Add(Me.lstHistorial)
        Me.Name = "FrmHistorial"
        Me.Text = "Historial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstHistorial As ListBox
End Class
