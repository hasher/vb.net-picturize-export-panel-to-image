    Function picturize(ByVal target As Panel, Optional ByVal dir As String = "")

        Dim picture As New Bitmap(target.Width, target.Height)
        Panel1.DrawToBitmap(picture, New Rectangle(0, 0, Width, Height))
        Dim name As String = InputBox("Picture Name :")
        picture.Save(Application.StartupPath & "\" & dir & name & ".png", System.Drawing.Imaging.ImageFormat.Png)

        Return Nothing

    End Function
