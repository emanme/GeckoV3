Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        browser.Navigate("https://bsz.ibs-bw.de/aDISWeb/app?service=direct/0/Home/$DirectLink&sp=S127.0.0.1:23298")


    End Sub

   

    Private Sub browser_Navigated(sender As Object, e As Gecko.GeckoNavigatedEventArgs) Handles browser.Navigated
        loadingImage.Visible = False
    End Sub

    Private Sub browser_Navigating(sender As Object, e As Gecko.Events.GeckoNavigatingEventArgs) Handles browser.Navigating
        loadingImage.Visible = True
    End Sub
End Class
