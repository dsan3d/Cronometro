Imports System.Drawing
''' <summary>
''' Formulario Windows Form principal de la aplicación.
''' </summary>
''' <remarks></remarks>
Public Class FrmCronos
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Variable para controlar el movimiento del formulario
    ''' </summary>
    ''' <remarks>Variable de tipo de datos de estructura Point, que guarda un punto de un eje de coordenadas XY </remarks>
    Private mouse_offset As Point



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblMinuto As System.Windows.Forms.Label
    Friend WithEvents lblsegundo As System.Windows.Forms.Label
    Friend WithEvents lbldecimas As System.Windows.Forms.Label
    Friend WithEvents CmdComenzar As System.Windows.Forms.Button
    Friend WithEvents CmdReset As System.Windows.Forms.Button
    Friend WithEvents CmdParar As System.Windows.Forms.Button
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents CmdCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCronos))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldecimas = New System.Windows.Forms.Label
        Me.lblsegundo = New System.Windows.Forms.Label
        Me.lblMinuto = New System.Windows.Forms.Label
        Me.CmdComenzar = New System.Windows.Forms.Button
        Me.CmdReset = New System.Windows.Forms.Button
        Me.CmdParar = New System.Windows.Forms.Button
        Me.lblHora = New System.Windows.Forms.Label
        Me.CmdCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lbldecimas
        '
        Me.lbldecimas.AutoSize = True
        Me.lbldecimas.BackColor = System.Drawing.SystemColors.Window
        Me.lbldecimas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldecimas.Location = New System.Drawing.Point(216, 136)
        Me.lbldecimas.Name = "lbldecimas"
        Me.lbldecimas.Size = New System.Drawing.Size(42, 34)
        Me.lbldecimas.TabIndex = 3
        Me.lbldecimas.Text = "00"
        '
        'lblsegundo
        '
        Me.lblsegundo.AutoSize = True
        Me.lblsegundo.BackColor = System.Drawing.SystemColors.Window
        Me.lblsegundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsegundo.Location = New System.Drawing.Point(184, 64)
        Me.lblsegundo.Name = "lblsegundo"
        Me.lblsegundo.Size = New System.Drawing.Size(42, 34)
        Me.lblsegundo.TabIndex = 2
        Me.lblsegundo.Text = "00"
        '
        'lblMinuto
        '
        Me.lblMinuto.AutoSize = True
        Me.lblMinuto.BackColor = System.Drawing.SystemColors.Window
        Me.lblMinuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinuto.Location = New System.Drawing.Point(72, 64)
        Me.lblMinuto.Name = "lblMinuto"
        Me.lblMinuto.Size = New System.Drawing.Size(42, 34)
        Me.lblMinuto.TabIndex = 1
        Me.lblMinuto.Text = "00"
        '
        'CmdComenzar
        '
        Me.CmdComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdComenzar.Location = New System.Drawing.Point(64, 208)
        Me.CmdComenzar.Name = "CmdComenzar"
        Me.CmdComenzar.Size = New System.Drawing.Size(72, 24)
        Me.CmdComenzar.TabIndex = 1
        Me.CmdComenzar.Text = "&Comenzar"
        '
        'CmdReset
        '
        Me.CmdReset.BackColor = System.Drawing.SystemColors.Control
        Me.CmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdReset.Location = New System.Drawing.Point(120, 96)
        Me.CmdReset.Name = "CmdReset"
        Me.CmdReset.Size = New System.Drawing.Size(56, 24)
        Me.CmdReset.TabIndex = 2
        Me.CmdReset.Text = "&Reset"
        '
        'CmdParar
        '
        Me.CmdParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdParar.Location = New System.Drawing.Point(152, 208)
        Me.CmdParar.Name = "CmdParar"
        Me.CmdParar.Size = New System.Drawing.Size(64, 24)
        Me.CmdParar.TabIndex = 3
        Me.CmdParar.Text = "&Parar"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.SystemColors.Window
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(56, 128)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(42, 34)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "00"
        '
        'CmdCerrar
        '
        Me.CmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdCerrar.Location = New System.Drawing.Point(120, 160)
        Me.CmdCerrar.Name = "CmdCerrar"
        Me.CmdCerrar.Size = New System.Drawing.Size(48, 23)
        Me.CmdCerrar.TabIndex = 5
        Me.CmdCerrar.Text = "Cerrar"
        '
        'FrmCronos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(304, 304)
        Me.Controls.Add(Me.CmdCerrar)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.CmdParar)
        Me.Controls.Add(Me.CmdReset)
        Me.Controls.Add(Me.CmdComenzar)
        Me.Controls.Add(Me.lblMinuto)
        Me.Controls.Add(Me.lblsegundo)
        Me.Controls.Add(Me.lbldecimas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCronos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cronometro"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Procedimientos de evento de los controles del formulario"
    ''' <summary>
    ''' Procedimiento de evento. Por cada segundo que pasa actualizamos el reloj del formulario
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto Timer que dispara el evento.</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>El parámetro sender es de tipo System.Object y el parámetro e es de tipo System.EventArgs.</remarks>
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lbldecimas.Text = CInt(Me.lbldecimas.Text) + 10
        'mostramos las décimas de segundo
        If Me.lbldecimas.Text = "100" Then
            Me.lbldecimas.Text = "00"
            Me.lblsegundo.Text = CInt(Me.lblsegundo.Text) + 1
            'mostramos los segundos
            If Me.lblsegundo.Text = "60" Then
                Me.lblsegundo.Text = "00"
                Me.lblMinuto.Text = CInt(Me.lblMinuto.Text) + 1
                'mostramos los minutos
                If Me.lblMinuto.Text = "60" Then
                    Me.lblMinuto.Text = "00"
                    'mostramos la hora
                    Me.lblHora.Text = CInt(Me.lblHora.Text) + 1
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Procedimiento de evento. Al pulsar el botón CmdComenzar activamos el objeto timer del formulario
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto CmdComenzar que dispara el evento Onclick.</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Al pulsar el botón Comenzar del formulario se dispara el evento Onclick(). El parámetro e es de tipo System.EventArgs
    ''' y el parámetro sender es de tipo System.Object</remarks>
    Private Sub CmdComenzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdComenzar.Click
        Me.Timer1.Stop()
        Me.Timer1.Enabled = True
        Me.Timer1.Start()
    End Sub
    ''' <summary>
    ''' Procedimiento de evento. Al pulsar el botón CmdReset ponemos el reloj del formulario a cero.
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto CmdReset que dispara el evento Onclick.</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Al pulsar el botón CmdReset ponemos el reloj del formulario a cero y desactivamos el objeto Timer1 del formulario.
    ''' <para>El parámetro e es de tipo System.EventArgs. El parámetro sender es de tipo System.Object</para></remarks>
    Private Sub CmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdReset.Click
        Me.lbldecimas.Text = "00"
        Me.lblHora.Text = "00"
        Me.lblMinuto.Text = "00"
        Me.lblsegundo.Text = "00"
        Me.Timer1.Enabled = False
        Me.Timer1.Stop()

    End Sub
    ''' <summary>
    ''' Procedimiento de evento. Al pulsar el botón CmdParar paramos el reloj
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto CmdReset que dispara el evento Onclick.</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Al pulsar el botón CmdParar paramos el reloj y para ello ejecutamos el método Stop() del objeto Timer del formulario.</remarks>
    Private Sub CmdParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdParar.Click
        Me.Timer1.Stop()
    End Sub
    ''' <summary>
    ''' Procedimiento de evento. Al pulsar el botón CmdCerrar cerramos el formulario
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto CmdReset que dispara el evento Onclick.</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Con este procedimiento se cierra el formulario y al ser el formulario el principal de la aplicación también se finaliza el programa.</remarks>
    Private Sub CmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCerrar.Click
        Me.Close()
    End Sub

#End Region
#Region "Procedimientos de evento del formulario"
    ''' <summary>
    ''' Procedimiento de evento para dibujar el formulario como un círculo
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto FrmCronos que dispara el evento OnPaint().</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Este procedimiento dibuja al formulario en pantalla con forma circular y usamos una imagen de la esfera de un reloj.</remarks>
    Private Sub FrmCronos_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Manejador de evento para dibujar el formulario como un circulo
        'creamos un rectángulo con el tamaño del formulario.
        Dim rectangulo As Rectangle = New Rectangle(0, 0, Me.Size.Width, Me.Size.Height)
        Dim camino As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        'Creamos un círculo del tamaño del rectángulo
        camino.AddArc(rectangulo, 0, 359)
        'metemos al círculo en una región que servirá como lienzo
        Dim area As Region = New Region(camino)
        'asociamos la región creada al formulario
        Me.Region = area
    End Sub
    ''' <summary>
    ''' Procedimiento de evento que sirve para controlar el movimiento del formulario
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto FrmCronos que dispara el evento OnMouseDown().</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Este procedimiento se ejecuta cuando pulsamos con el ratón sobre el formulario. 
    ''' <para>Capturamos la posición del ratón en el eje de coordenadas XY. Se guarda en el campo <see>mouse_offset</see>.</para></remarks>
    Private Sub FrmCronos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'cogemos el punto XY del argumento e
        mouse_offset = New Point(-e.X, -e.Y)

    End Sub
    ''' <summary>
    ''' Procedimiento de evento que sirve para controlar el movimiento del formulario.
    ''' </summary>
    ''' <param name="sender">parámetro que referencia al objeto FrmCronos que dispara el evento OnMouseMove().</param>
    ''' <param name="e">parámetro que sirve para pasarle argumentos opcionales al procedimiento.</param>
    ''' <remarks>Al mover el ratón arrastramos el formulario por la pantalla.</remarks>
    Private Sub FrmCronos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'miramos si está pulsado el botón izquierdo del ratón
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            'miramos la posición del ratón en la pantalla
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            'y la asociamos a la propiedad Location del formulario y así se va moviendo.
            Location = mousePos
        End If

    End Sub
#End Region

End Class
