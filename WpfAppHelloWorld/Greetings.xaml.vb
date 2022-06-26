Class MainWindow
    Private Sub DisplayButton_Click(sender As Object, e As RoutedEventArgs) Handles DisplayButton.Click
        If HelloButton.IsChecked = True Then
            MessageBox.Show("Hello.")
        ElseIf GoodbyeButton.IsChecked = True Then
            MessageBox.Show("Goodbye.")
        End If
    End Sub
End Class
