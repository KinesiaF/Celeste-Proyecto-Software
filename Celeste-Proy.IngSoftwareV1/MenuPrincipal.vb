Public Class MenuPrincipal
    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If PanelMenu.Width >= 200 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelMenu.Width = 200 Then
            tmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width < 100 Then
            tmMostrarMenu.Enabled = True
        End If


    End Sub

    Private Sub PanelSubMenu()
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub OcultarSubMenu()
        If Panel2.Visible = True Then
            Panel2.Visible = False
        End If
        If Panel3.Visible = True Then
            Panel3.Visible = False
        End If
    End Sub

    Private Sub MostrarSubMenu(subMenu)
        If subMenu.visible = False Then
            OcultarSubMenu()
            subMenu.visible = True
        Else
            subMenu.visible = False
        End If
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelSubMenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarSubMenu(Panel2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OcultarSubMenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OcultarSubMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OcultarSubMenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OcultarSubMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MostrarSubMenu(Panel3)
    End Sub
End Class