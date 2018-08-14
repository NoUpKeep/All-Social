' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
''' <seealso cref="Windows.UI.Xaml.Controls.Page" />
''' <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector" />
''' <seealso cref="Windows.UI.Xaml.Markup.IComponentConnector2" />
Public NotInheritable Class Settings
    Inherits Page

    Private Sub CHK_FB_Click(sender As Object, e As RoutedEventArgs) Handles CHK_FB.Click
        If CHK_FB.IsChecked Then
            txtCHECKBOX.Text = "Checked"
        Else
            txtCHECKBOX.Text = "Unchecked"
        End If
    End Sub

    Private Sub CANCEL_Click(sender As Object, e As RoutedEventArgs) Handles CANCEL.Click
        Frame.Navigate(GetType(MainPage))
    End Sub
End Class
