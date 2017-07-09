Public Class Letreiro
    Public Posição As Integer 'posição do primeiro char.
    Public Buffer As Integer 'Tamanho de caracteres
    Public Controle As PictureBox
    Public fonte As Font
    Public cor As Brush
    Public Sub SetControle(ByRef PictBox As PictureBox)
        Controle = PictBox
    End Sub
    Public Sub SetBuffer(ByVal Tamanho As Integer)
        Buffer = Tamanho
    End Sub
    Public Sub SetCor(ByVal tCor As Brush)
        cor = tCor
    End Sub
    Public Sub SetFonte(ByVal tfonte As Font)
        fonte = tfonte
    End Sub
    Public Sub Andar()
        Dim bmp As New Bitmap(Controle.Width, Controle.Height)
        Dim texto As String
        texto = Space(Buffer) & Controle.Tag.ToString
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.Clear(Controle.BackColor)
        texto = Mid(texto, Posição + 1, Buffer)
        g.DrawString(texto, fonte, cor, 0, 0)
        Controle.Image = bmp
        g.Dispose()
        g = Nothing

        texto = Space(Buffer) & Controle.Tag.ToString
        Posição += 1
        If Posição > Len(texto) Then
            Posição = 0
        End If
    End Sub
    Public Sub New()
        'fonte = New Font("Courier New", 20, FontStyle.Regular)
        fonte = New Font("Algerian", 20, FontStyle.Regular)
        cor = Brushes.Black



    End Sub








End Class
