Public Class MainWindow
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        repeaterAmount.Text = "0"
        comparatorAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"

    End Sub

    Private Sub repeaterButton_CheckedChanged(sender As Object, e As EventArgs) Handles repeaterButton.CheckedChanged
        repeaterAmount.Enabled = True
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub comparatorButton_CheckedChanged(sender As Object, e As EventArgs) Handles comparatorButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = True
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        dispenserAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub dispenserButton_CheckedChanged(sender As Object, e As EventArgs) Handles dispenserButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = True
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        dispenserAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub dropperButton_CheckedChanged(sender As Object, e As EventArgs) Handles dropperButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = True
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        dispenserAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub redstoneLampButton_CheckedChanged(sender As Object, e As EventArgs) Handles redstoneLampButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = True
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        dispenserAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub
    Private Sub daylightSensorButton_CheckedChanged(sender As Object, e As EventArgs) Handles daylightSensorButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = True
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub pistonButton_CheckedChanged(sender As Object, e As EventArgs) Handles pistonButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = True
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub stickyPistonButton_CheckedChanged(sender As Object, e As EventArgs) Handles stickyPistonButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = True
        noteblockAmount.Enabled = False
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    Private Sub noteblockButton_CheckedChanged(sender As Object, e As EventArgs) Handles noteblockButton.CheckedChanged
        repeaterAmount.Enabled = False
        comparatorAmount.Enabled = False
        dispenserAmount.Enabled = False
        dropperAmount.Enabled = False
        redstoneLampAmount.Enabled = False
        daylightSensorAmount.Enabled = False
        pistonAmount.Enabled = False
        stickyPistonAmount.Enabled = False
        noteblockAmount.Enabled = True
        pistonAmount.Text = "0"
        stickyPistonAmount.Text = "0"
        noteblockAmount.Text = "0"
        comparatorAmount.Text = "0"
        repeaterAmount.Text = "0"
        dispenserAmount.Text = "0"
        dropperAmount.Text = "0"
        redstoneLampAmount.Text = "0"
        daylightSensorAmount.Text = "0"
    End Sub

    'Przekaznik'
    Private Sub reptxt_TextChanged(sender As Object, e As EventArgs) Handles repeaterAmount.TextChanged
        redstone.Text = Val(repeaterAmount.Text) * 1 'Redstone
        redstoneT.Text = Val(repeaterAmount.Text) * 2  'Pochodnie
        stone.Text = Val(repeaterAmount.Text) * 3  'Kamien
    End Sub

    'Komparator'
    Private Sub comtxt_TextChanged(sender As Object, e As EventArgs) Handles comparatorAmount.TextChanged
        stone.Text = Val(comparatorAmount.Text) * 3 'Kamien
        redstoneT.Text = Val(comparatorAmount.Text) * 3 'Pochodnie
        qua.Text = Val(comparatorAmount.Text) * 1 'Kwarc
    End Sub

    'Dozownik'
    Private Sub distxt_TextChanged(sender As Object, e As EventArgs) Handles dispenserAmount.TextChanged
        Cstone.Text = Val(dispenserAmount.Text) * 7 'Cobel
        bow.Text = Val(dispenserAmount.Text) * 1 'Luk
        redstone.Text = Val(dispenserAmount.Text) * 1 'Redstone
    End Sub

    'Podajnik'
    Private Sub dropptxt_TextChanged(sender As Object, e As EventArgs) Handles dropperAmount.TextChanged
        Cstone.Text = Val(dropperAmount.Text) * 7 'Cobel
        redstone.Text = Val(dropperAmount.Text) * 1 'Redstone
    End Sub

    'Lampa'
    Private Sub lamptxt_TextChanged(sender As Object, e As EventArgs) Handles redstoneLampAmount.TextChanged
        redstone.Text = Val(redstoneLampAmount.Text) * 4 'Redstone
        Gstone.Text = Val(redstoneLampAmount.Text) * 1 'Glowstone
    End Sub

    'Czujnik Światła'
    Private Sub sensortxt_TextChanged(sender As Object, e As EventArgs) Handles daylightSensorAmount.TextChanged
        slab.Text = Val(daylightSensorAmount.Text) * 3 'Polplytki
        qua.Text = Val(daylightSensorAmount.Text) * 3 'Kwarc
        glass.Text = Val(daylightSensorAmount.Text) * 3 'Szklo
    End Sub

    'Tlok'
    Private Sub pistontxt_TextChanged(sender As Object, e As EventArgs) Handles pistonAmount.TextChanged
        Cstone.Text = Val(pistonAmount.Text) * 4 'Cobel
        iron.Text = Val(pistonAmount.Text) * 1 'Zelazo
        redstone.Text = Val(pistonAmount.Text) * 1 'Redstone
        plank.Text = Val(pistonAmount.Text) * 3 'Deski
    End Sub

    'Lepki Tlok'
    Private Sub spistontxt_TextChanged(sender As Object, e As EventArgs) Handles stickyPistonAmount.TextChanged
        Cstone.Text = Val(stickyPistonAmount.Text) * 4 'Cobel
        iron.Text = Val(stickyPistonAmount.Text) * 1 'Zelazo
        redstone.Text = Val(stickyPistonAmount.Text) * 1 'Redstone
        plank.Text = Val(stickyPistonAmount.Text) * 3 'Deski
        slime.Text = Val(stickyPistonAmount.Text) * 1 'Slimeball
    End Sub

    'Noteblock'
    Private Sub notetxt_TextChanged(sender As Object, e As EventArgs) Handles noteblockAmount.TextChanged
        plank.Text = Val(noteblockAmount.Text) * 8 'Deski
        redstone.Text = Val(noteblockAmount.Text) * 1 'Redstone
    End Sub
End Class