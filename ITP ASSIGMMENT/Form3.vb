Public Class Form3
    Dim randomnumber(10) As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        ' begin 10 unsorted numbers between 1 and 100
        For i = 0 To 9
            randomnumber(i) = CInt(Rnd() * 100) + 1 ' scale and offset for range 1 to 100
        Next

        'clearing the listbox before new data is being displayed
        ListBox1.Items.Clear()

        'show unsorted numbers
        ListBox1.Items.Add("UNSORTED")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next

        'bubble logic 101.
        Dim swapped As Boolean = True ' method to see if any swaps have been made
        ' 
        'while loop added in the array for multiple loops to start
        'display sorted numbers

        ' bubble sort logic
        For i = 1 To 9 '' start from the second element (index 1)
            Dim key As Integer = randomnumber(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumber(j) > key
                randomnumber(j + 1) = randomnumber(j)
                j -= 1
                If j < 0 Then Exit While ' ensure j doesn't go below 0
            End While
            randomnumber(j + 1) = key

        Next
        ListBox1.Items.Add("")
        ListBox1.Items.Add("SORTED:")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        ' generate random numbers 
        For i = 0 To 9
            randomnumber(i) = CInt(Rnd() * 100) + 1 ' scale And offset range 1 to 100 
        Next

        ' clear listbox before displaying new data
        ListBox1.Items.Clear()

        ' Display unsorted numbers
        ListBox1.Items.Add("UNSORTED:")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next

        ' insetion sort logic

        For i = 1 To 9
            Dim key As Integer = randomnumber(i)
            Dim j As Integer = i - 1
            While j >= 0 AndAlso randomnumber(j) > key
                randomnumber(j + 1) = randomnumber(j)
                j -= 1
                If j < 0 Then Exit While ' ensure j doesn't go below 0
            End While
            randomnumber(j + 1) = key

        Next

        'Display sorted numbers
        ListBox1.Items.Add("")
        ListBox1.Items.Add("SORTED")
        For i = 0 To 9
            ListBox1.Items.Add(randomnumber(i).ToString())
        Next

    End Sub
End Class