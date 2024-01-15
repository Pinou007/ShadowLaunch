Imports System.IO

Module ConsoleRedirectorModule
    Private originalConsoleOut As TextWriter
    Private consoleWriter As MyConsoleWriter ' Utilisez MyConsoleWriter au lieu de ConsoleWriter

    Public Sub RedirectConsoleOutput(textBox As TextBox)
        ' Sauvegarder la sortie console originale
        originalConsoleOut = Console.Out

        ' Créer une instance de MyConsoleWriter qui met à jour la TextBox
        consoleWriter = New MyConsoleWriter(textBox)

        ' Rediriger la sortie de la console vers consoleWriter
        Console.SetOut(consoleWriter)
    End Sub

    Public Sub RestoreConsoleOutput()
        ' Restaurer la sortie console originale
        Console.SetOut(originalConsoleOut)
    End Sub

    ' Classe personnalisée pour rediriger la sortie de la console vers une TextBox
    Private Class MyConsoleWriter
        Inherits TextWriter

        Private textBox As TextBox

        Public Sub New(textBox As TextBox)
            Me.textBox = textBox
        End Sub

        Public Overrides Sub Write(value As Char)
            ' Mettre à jour la TextBox avec le caractère actuel
            textBox.AppendText(value.ToString())
        End Sub

        Public Overrides Sub Write(value As String)
            ' Mettre à jour la TextBox avec la chaîne actuelle
            textBox.AppendText(value)
        End Sub

        Public Overrides Sub WriteLine(value As String)
            ' Mettre à jour la TextBox avec la chaîne actuelle suivie d'un retour à la ligne
            textBox.AppendText(value & vbCrLf)
        End Sub

        Public Overrides ReadOnly Property Encoding As System.Text.Encoding
            Get
                Return System.Text.Encoding.Default
            End Get
        End Property
    End Class
End Module
