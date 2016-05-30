Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tlvl.SelectedIndex = 0
        tltree.SelectedIndex = 0
        sosstr.SelectedIndex = 0
        tlj.SelectedIndex = 0
        incdmgbox.Items.Clear()
        For n As Integer = 0 To 2000
            incdmgbox.Items.Add(n.ToString)
        Next
        incdmgbox.SelectedIndex = 0
        moredmg.Items.Clear()
        For m As Decimal = 1.0 To 5.0 Step 0.01

            moredmg.Items.Add(m.ToString)
        Next
        moredmg.SelectedIndex = 0
    End Sub

    Private Sub tlvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tlvl.SelectedIndexChanged
        berechnen()


    End Sub


    Private Sub tltree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tltree.SelectedIndexChanged
        berechnen()
        


    End Sub

    Private Sub sosstr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sosstr.SelectedIndexChanged
        berechnen()


    End Sub

    Private Sub tlj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tlj.SelectedIndexChanged
        berechnen()



    End Sub

    Private Sub berechnen()
        Dim totemlife As Integer
        Dim tlifet, tlifespire, tlifej As Double
        If tlvl.SelectedIndex = 0 Then totemlife = "108"
        If tlvl.SelectedIndex = 1 Then totemlife = "135"
        If tlvl.SelectedIndex = 2 Then totemlife = "176"
        If tlvl.SelectedIndex = 3 Then totemlife = "246"
        If tlvl.SelectedIndex = 4 Then totemlife = "332"
        If tlvl.SelectedIndex = 5 Then totemlife = "441"
        If tlvl.SelectedIndex = 6 Then totemlife = "573"
        If tlvl.SelectedIndex = 7 Then totemlife = "737"
        If tlvl.SelectedIndex = 8 Then totemlife = "934"
        If tlvl.SelectedIndex = 9 Then totemlife = "1114"
        If tlvl.SelectedIndex = 10 Then totemlife = "1317"
        If tlvl.SelectedIndex = 11 Then totemlife = "1555"
        If tlvl.SelectedIndex = 12 Then totemlife = "1828"
        If tlvl.SelectedIndex = 13 Then totemlife = "2146"
        If tlvl.SelectedIndex = 14 Then totemlife = "2507"
        If tlvl.SelectedIndex = 15 Then totemlife = "2928"
        If tlvl.SelectedIndex = 16 Then totemlife = "3407"
        If tlvl.SelectedIndex = 17 Then totemlife = "3957"
        If tlvl.SelectedIndex = 18 Then totemlife = "4589"
        If tlvl.SelectedIndex = 19 Then totemlife = "5312"
        If tlvl.SelectedIndex = 20 Then totemlife = "5853"
        If tlvl.SelectedIndex = 21 Then totemlife = "6444"
        If tlvl.SelectedIndex = 22 Then totemlife = "7088"
        If tlvl.SelectedIndex = 23 Then totemlife = "7793"
        If tlvl.SelectedIndex = 24 Then totemlife = "8564"
        If tlvl.SelectedIndex = 25 Then totemlife = "9405"
        If tlvl.SelectedIndex = 26 Then totemlife = "10322"
        If tlvl.SelectedIndex = 27 Then totemlife = "11327"
        If tlvl.SelectedIndex = 28 Then totemlife = "12421"
        If tlvl.SelectedIndex = 29 Then totemlife = "13615"

        If tltree.SelectedIndex = 0 Then tlifet = totemlife
        If tltree.SelectedIndex >= 1 Then tlifet = totemlife + totemlife * tltree.SelectedIndex / 100

        If sosstr.SelectedIndex = 0 Then tlifespire = tlifet
        If sosstr.SelectedIndex >= 1 Then tlifespire = tlifet + tlifet * 0.03 * sosstr.SelectedIndex

        If tlj.SelectedIndex = 0 Then tlifej = tlifespire
        If tlj.SelectedIndex >= 1 Then tlifej = tlifespire + tlifespire * tlj.SelectedIndex / 100

        tlife.Text = tlifej
        tdmg.Text = tlifej * 0.5 * (50 - tlvl.SelectedIndex) / 100
        tdmgfinal.Text = tdmg.Text * (1 + incdmgbox.SelectedItem / 100) * moredmg.SelectedItem
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        berechnen()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        berechnen()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
        berechnen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub incdmgbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles incdmgbox.SelectedIndexChanged
        berechnen()
    End Sub

    Private Sub moredmg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles moredmg.SelectedIndexChanged
        berechnen()

    End Sub
End Class
