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

    Private Sub repeaterAmount_TextChanged(sender As Object, e As EventArgs) Handles repeaterAmount.TextChanged
        redstoneResult.Text = Val(repeaterAmount.Text) * 1
        redstoneTorchResult.Text = Val(repeaterAmount.Text) * 2
        stoneResult.Text = Val(repeaterAmount.Text) * 3
    End Sub

    Private Sub comparatorAmount_TextChanged(sender As Object, e As EventArgs) Handles comparatorAmount.TextChanged
        stoneResult.Text = Val(comparatorAmount.Text) * 3
        redstoneTorchResult.Text = Val(comparatorAmount.Text) * 3
        quartzResult.Text = Val(comparatorAmount.Text) * 1
    End Sub

    'Dozownik'
    Private Sub dispenserAmount_TextChanged(sender As Object, e As EventArgs) Handles dispenserAmount.TextChanged
        cobblestoneResult.Text = Val(dispenserAmount.Text) * 7
        bowResult.Text = Val(dispenserAmount.Text) * 1
        redstoneResult.Text = Val(dispenserAmount.Text) * 1
    End Sub

    Private Sub dropperAmount_TextChanged(sender As Object, e As EventArgs) Handles dropperAmount.TextChanged
        cobblestoneResult.Text = Val(dropperAmount.Text) * 7
        redstoneResult.Text = Val(dropperAmount.Text) * 1
    End Sub

    Private Sub redstoneLampAmount_TextChanged(sender As Object, e As EventArgs) Handles redstoneLampAmount.TextChanged
        redstoneResult.Text = Val(redstoneLampAmount.Text) * 4
        glowstoneResult.Text = Val(redstoneLampAmount.Text) * 1
    End Sub

    Private Sub daylightSensorAmount_TextChanged(sender As Object, e As EventArgs) Handles daylightSensorAmount.TextChanged
        woodenSlabResult.Text = Val(daylightSensorAmount.Text) * 3
        quartzResult.Text = Val(daylightSensorAmount.Text) * 3
        glassResult.Text = Val(daylightSensorAmount.Text) * 3
    End Sub

    Private Sub pistonAmount_TextChanged(sender As Object, e As EventArgs) Handles pistonAmount.TextChanged
        cobblestoneResult.Text = Val(pistonAmount.Text) * 4
        ironIngotResult.Text = Val(pistonAmount.Text) * 1
        redstoneResult.Text = Val(pistonAmount.Text) * 1
        woodenPlanksResult.Text = Val(pistonAmount.Text) * 3
    End Sub

    Private Sub stickyPistonAmount_TextChanged(sender As Object, e As EventArgs) Handles stickyPistonAmount.TextChanged
        cobblestoneResult.Text = Val(stickyPistonAmount.Text) * 4
        ironIngotResult.Text = Val(stickyPistonAmount.Text) * 1
        redstoneResult.Text = Val(stickyPistonAmount.Text) * 1
        woodenPlanksResult.Text = Val(stickyPistonAmount.Text) * 3
        slimeResult.Text = Val(stickyPistonAmount.Text) * 1
    End Sub

    Private Sub noteblockAmount_TextChanged(sender As Object, e As EventArgs) Handles noteblockAmount.TextChanged
        woodenPlanksResult.Text = Val(noteblockAmount.Text) * 8
        redstoneResult.Text = Val(noteblockAmount.Text) * 1
    End Sub
End Class