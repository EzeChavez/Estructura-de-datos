<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cola
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBCodigo = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBtramite = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LblTramiteEliminado = New System.Windows.Forms.Label()
        Me.LblNombreEliminado = New System.Windows.Forms.Label()
        Me.LblCodigoEliminado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListB = New System.Windows.Forms.ListBox()
        Me.Dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Trámite:"
        '
        'TBCodigo
        '
        Me.TBCodigo.Location = New System.Drawing.Point(91, 39)
        Me.TBCodigo.Name = "TBCodigo"
        Me.TBCodigo.Size = New System.Drawing.Size(125, 27)
        Me.TBCodigo.TabIndex = 3
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(91, 71)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(125, 27)
        Me.TBNombre.TabIndex = 4
        '
        'TBtramite
        '
        Me.TBtramite.Location = New System.Drawing.Point(91, 105)
        Me.TBtramite.Name = "TBtramite"
        Me.TBtramite.Size = New System.Drawing.Size(125, 27)
        Me.TBtramite.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.TBtramite)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 196)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Elemento"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(91, 151)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(125, 29)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.LblTramiteEliminado)
        Me.GroupBox2.Controls.Add(Me.LblNombreEliminado)
        Me.GroupBox2.Controls.Add(Me.LblCodigoEliminado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 196)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Elemento Eliminado"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(78, 151)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(103, 29)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'LblTramiteEliminado
        '
        Me.LblTramiteEliminado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTramiteEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTramiteEliminado.Location = New System.Drawing.Point(78, 105)
        Me.LblTramiteEliminado.Name = "LblTramiteEliminado"
        Me.LblTramiteEliminado.Size = New System.Drawing.Size(103, 25)
        Me.LblTramiteEliminado.TabIndex = 5
        '
        'LblNombreEliminado
        '
        Me.LblNombreEliminado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblNombreEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNombreEliminado.Location = New System.Drawing.Point(78, 73)
        Me.LblNombreEliminado.Name = "LblNombreEliminado"
        Me.LblNombreEliminado.Size = New System.Drawing.Size(103, 25)
        Me.LblNombreEliminado.TabIndex = 4
        '
        'LblCodigoEliminado
        '
        Me.LblCodigoEliminado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblCodigoEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCodigoEliminado.Location = New System.Drawing.Point(78, 42)
        Me.LblCodigoEliminado.Name = "LblCodigoEliminado"
        Me.LblCodigoEliminado.Size = New System.Drawing.Size(103, 25)
        Me.LblCodigoEliminado.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Codigo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Trámite:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Listado en una lista y en una grilla"
        '
        'ListB
        '
        Me.ListB.FormattingEnabled = True
        Me.ListB.ItemHeight = 20
        Me.ListB.Location = New System.Drawing.Point(32, 298)
        Me.ListB.Name = "ListB"
        Me.ListB.Size = New System.Drawing.Size(150, 184)
        Me.ListB.TabIndex = 9
        '
        'Dgv1
        '
        Me.Dgv1.AllowUserToAddRows = False
        Me.Dgv1.AllowUserToDeleteRows = False
        Me.Dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Dgv1.Location = New System.Drawing.Point(237, 298)
        Me.Dgv1.Name = "Dgv1"
        Me.Dgv1.ReadOnly = True
        Me.Dgv1.RowHeadersWidth = 51
        Me.Dgv1.RowTemplate.Height = 29
        Me.Dgv1.Size = New System.Drawing.Size(405, 184)
        Me.Dgv1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Trámite"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Cola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 494)
        Me.Controls.Add(Me.Dgv1)
        Me.Controls.Add(Me.ListB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Cola"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cola"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBCodigo As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBtramite As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblTramiteEliminado As Label
    Friend WithEvents LblNombreEliminado As Label
    Friend WithEvents LblCodigoEliminado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListB As ListBox
    Friend WithEvents Dgv1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
