Public Class MainWindow
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        reptxt.Text = "0"
        comtxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"

    End Sub

    Private Sub repeaterButton_CheckedChanged(sender As Object, e As EventArgs) Handles repeaterButton.CheckedChanged
        reptxt.Enabled = True
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub comparatorButton_CheckedChanged(sender As Object, e As EventArgs) Handles comparatorButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = True
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        distxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub dispenserButton_CheckedChanged(sender As Object, e As EventArgs) Handles dispenserButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = True
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        distxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub dropperButton_CheckedChanged(sender As Object, e As EventArgs) Handles dropperButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = True
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        distxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub redstoneLampButton_CheckedChanged(sender As Object, e As EventArgs) Handles redstoneLampButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = True
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        distxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub
    Private Sub daylightSensorButton_CheckedChanged(sender As Object, e As EventArgs) Handles daylightSensorButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = True
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub pistonButton_CheckedChanged(sender As Object, e As EventArgs) Handles pistonButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = True
        spistontxt.Enabled = False
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub stickyPistonButton_CheckedChanged(sender As Object, e As EventArgs) Handles stickyPistonButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = True
        notetxt.Enabled = False
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    Private Sub noteblockButton_CheckedChanged(sender As Object, e As EventArgs) Handles noteblockButton.CheckedChanged
        reptxt.Enabled = False
        comtxt.Enabled = False
        distxt.Enabled = False
        dropptxt.Enabled = False
        lamptxt.Enabled = False
        sensortxt.Enabled = False
        pistontxt.Enabled = False
        spistontxt.Enabled = False
        notetxt.Enabled = True
        pistontxt.Text = "0"
        spistontxt.Text = "0"
        notetxt.Text = "0"
        comtxt.Text = "0"
        reptxt.Text = "0"
        distxt.Text = "0"
        dropptxt.Text = "0"
        lamptxt.Text = "0"
        sensortxt.Text = "0"
    End Sub

    'Przekaznik'
    Private Sub reptxt_TextChanged(sender As Object, e As EventArgs) Handles reptxt.TextChanged
        redstone.Text = Val(reptxt.Text) * 1 'Redstone
        redstoneT.Text = Val(reptxt.Text) * 2  'Pochodnie
        stone.Text = Val(reptxt.Text) * 3  'Kamien
    End Sub

    'Komparator'
    Private Sub comtxt_TextChanged(sender As Object, e As EventArgs) Handles comtxt.TextChanged
        stone.Text = Val(comtxt.Text) * 3 'Kamien
        redstoneT.Text = Val(comtxt.Text) * 3 'Pochodnie
        qua.Text = Val(comtxt.Text) * 1 'Kwarc
    End Sub

    'Dozownik'
    Private Sub distxt_TextChanged(sender As Object, e As EventArgs) Handles distxt.TextChanged
        Cstone.Text = Val(distxt.Text) * 7 'Cobel
        bow.Text = Val(distxt.Text) * 1 'Luk
        redstone.Text = Val(distxt.Text) * 1 'Redstone
    End Sub

    'Podajnik'
    Private Sub dropptxt_TextChanged(sender As Object, e As EventArgs) Handles dropptxt.TextChanged
        Cstone.Text = Val(dropptxt.Text) * 7 'Cobel
        redstone.Text = Val(dropptxt.Text) * 1 'Redstone
    End Sub

    'Lampa'
    Private Sub lamptxt_TextChanged(sender As Object, e As EventArgs) Handles lamptxt.TextChanged
        redstone.Text = Val(lamptxt.Text) * 4 'Redstone
        Gstone.Text = Val(lamptxt.Text) * 1 'Glowstone
    End Sub

    'Czujnik Światła'
    Private Sub sensortxt_TextChanged(sender As Object, e As EventArgs) Handles sensortxt.TextChanged
        slab.Text = Val(sensortxt.Text) * 3 'Polplytki
        qua.Text = Val(sensortxt.Text) * 3 'Kwarc
        glass.Text = Val(sensortxt.Text) * 3 'Szklo
    End Sub

    'Tlok'
    Private Sub pistontxt_TextChanged(sender As Object, e As EventArgs) Handles pistontxt.TextChanged
        Cstone.Text = Val(pistontxt.Text) * 4 'Cobel
        iron.Text = Val(pistontxt.Text) * 1 'Zelazo
        redstone.Text = Val(pistontxt.Text) * 1 'Redstone
        plank.Text = Val(pistontxt.Text) * 3 'Deski
    End Sub

    'Lepki Tlok'
    Private Sub spistontxt_TextChanged(sender As Object, e As EventArgs) Handles spistontxt.TextChanged
        Cstone.Text = Val(spistontxt.Text) * 4 'Cobel
        iron.Text = Val(spistontxt.Text) * 1 'Zelazo
        redstone.Text = Val(spistontxt.Text) * 1 'Redstone
        plank.Text = Val(spistontxt.Text) * 3 'Deski
        slime.Text = Val(spistontxt.Text) * 1 'Slimeball
    End Sub

    'Noteblock'
    Private Sub notetxt_TextChanged(sender As Object, e As EventArgs) Handles notetxt.TextChanged
        plank.Text = Val(notetxt.Text) * 8 'Deski
        redstone.Text = Val(notetxt.Text) * 1 'Redstone
    End Sub
End Class