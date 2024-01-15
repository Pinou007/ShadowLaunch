Imports System.IO

Public Class Start

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Rediriger la sortie de la console vers la TextBox ErrorList
        ConsoleRedirectorModule.RedirectConsoleOutput(ErrorList)

        ' Exemple : Écrire quelque chose dans la console

        Console.WriteLine("APPLICATION LANCER")


        ' Ce gestionnaire d'événements est déclenché lorsque le formulaire Start est chargé

        ' Obtient le chemin du dossier de démarrage de l'application
        Dim startPath As String = Directory.GetCurrentDirectory()

        ' Liste des dossiers à vérifier ou créer
        Dim foldersToCheck As String() = {"config", "program", "logs", "license", "program/error", "extension", "extension/update", "extension/pinou", "extension/custom", "extension/custom/exemple"}

        ' Vérifie et crée les dossiers nécessaires
        For Each folder In foldersToCheck
            ' Combine le chemin de démarrage avec le nom du dossier actuel
            Dim folderPath As String = Path.Combine(startPath, folder)

            ' Vérifie si le dossier existe
            If Not Directory.Exists(folderPath) Then
                ' Si le dossier n'existe pas, le crée
                Directory.CreateDirectory(folderPath)
                Console.WriteLine($"Dossier créé : {folderPath}")
            Else
                ' Si le dossier existe déjà, affiche un message
                Console.WriteLine($"Le dossier existe déjà : {folderPath}")
            End If
        Next

        ' Exemple de création de documents dans un dossier spécifique
        ' Appelle la fonction CreateDocument avec le nom du document, le dossier de destination et sans contenu
        CreateDocument("launch-program.slconfig", "config", String.Empty)
        CreateDocument("company.slconfig", "config", String.Empty)
        CreateDocument("key.sl", "license", String.Empty)
        CreateDocument("hello.sllog", "logs", String.Empty)

        ' Cette ligne permet de maintenir la fenêtre ouverte jusqu'à ce que l'utilisateur la ferme
        Console.ReadLine()





        ' Chemin du fichier de configuration
        Dim configFilePath As String = Path.Combine(Application.StartupPath, "config/launch-program.slconfig")

        ' Vérifier si le fichier de configuration existe
        If File.Exists(configFilePath) Then
            ' Lire toutes les lignes du fichier
            Dim lines() As String = File.ReadAllLines(configFilePath)

            ' Parcourir chaque ligne pour trouver les configurations
            For Each line As String In lines
                ' Vérifier si la ligne contient "program :"
                If line.Contains("program :") OrElse line.Contains("programAdmin :") Then
                    ' Extraire les noms de fichiers entre les parenthèses
                    Dim programs As String = line.Split("("c)(1).Split(")"c)(0).Trim()

                    ' Séparer les noms de fichiers en fonction de la virgule
                    Dim programNames() As String = programs.Split(","c)

                    ' Exécuter chaque programme
                    For Each programName As String In programNames
                        ' Construire le chemin complet du programme en supprimant les guillemets éventuels
                        Dim programPath As String = Path.Combine(Application.StartupPath, "program", programName.Trim().Trim(""""c))

                        ' Vérifier si le fichier du programme existe
                        If File.Exists(programPath) Then
                            ' Exécuter le programme (vous pouvez personnaliser cette partie selon vos besoins)
                            ExecuteProgram(programPath)
                        Else
                            Console.WriteLine($"Le fichier du programme n'existe pas : {programPath}")
                            Me.Show()
                        End If
                    Next
                End If
            Next
        Else
            Console.WriteLine("Le fichier de configuration n'existe pas.")
        End If
    End Sub

    Private Sub ExecuteProgram(programPath As String)
        ' Configurer les informations de démarrage du processus
        Dim startInfo As New ProcessStartInfo(programPath)
        startInfo.WindowStyle = ProcessWindowStyle.Hidden ' Cela rendra la fenêtre invisible

        ' Exécuter le programme avec les informations configurées
        Try
            Process.Start(startInfo)
        Catch ex As Exception
            Console.WriteLine($"Erreur lors de l'exécution du programme : {ex.Message}")
            Me.Show()
        End Try
    End Sub


    ' Fonction pour créer un document avec le nom, le dossier de destination et éventuellement le contenu spécifiés
    Private Sub CreateDocument(documentName As String, destinationFolder As String, Optional content As String = "")
        ' Obtient le chemin complet du dossier de destination
        Dim destinationPath As String = Path.Combine(Directory.GetCurrentDirectory(), destinationFolder)

        ' Vérifie si le dossier de destination existe
        If Not Directory.Exists(destinationPath) Then
            ' Si le dossier de destination n'existe pas, le crée
            Directory.CreateDirectory(destinationPath)
            Console.WriteLine($"Dossier créé : {destinationPath}")
            Console.WriteLine("Attention cella veut dire qu'il est vide est donc n'on utilisable")
            Me.Show()
        Else
            ' Si le dossier de destination existe déjà, affiche un message
            Console.WriteLine($"Le dossier de destination existe déjà : {destinationPath}")
        End If

        ' Obtient le chemin complet du document en combinant le dossier de destination avec le nom du document
        Dim documentPath As String = Path.Combine(destinationPath, documentName)

        ' Vérifie si le document existe
        If Not File.Exists(documentPath) Then
            ' Si le document n'existe pas, le crée
            File.WriteAllText(documentPath, content)
            Console.WriteLine($"Document créé : {documentPath}")
            Console.WriteLine("Attention cella veut dire qu'il est vide est donc n'on utilisable")
            Me.Show()
        Else
            ' Si le document existe déjà, affiche un message
            Console.WriteLine($"Le document existe déjà : {documentPath}")
        End If








    End Sub

    Private Sub Start_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Restaurer la sortie console originale avant de fermer le formulaire
        ConsoleRedirectorModule.RestoreConsoleOutput()
    End Sub

End Class
