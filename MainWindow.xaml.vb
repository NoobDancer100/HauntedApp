Imports System
Imports System.DirectoryServices.AccountManagement
Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim FullName = UserPrincipal.Current.DisplayName

        SpookyText.Text = "I see you, " & FullName.Split()(0)
    End Sub
End Class
