Public Class Form2
    Dim r As IO.StreamReader
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        r = New IO.StreamReader("C:\Users\User\Desktop\externaldata.txt")
        ListBox1.Items.Clear()
        While (r.Peek > -1)
            ListBox1.Items.Add(r.ReadLine)
        End While
        r.Close()
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs)
        Dim searchnumber As Integer = CInt(TextBox1.Text) 'Get the search number from
        Dim index As Integer = -1 ' Initialize the index variable to -1

        ' search for the number in the list box
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If CType(ListBox1.Items(i), Integer) = searchnumber Then
                index = i

                Exit For
            End If
        Next

        If index = -1 Then
            Label1.Text = "Number not found in the list."
        Else
            Label1.Text = $"Number found at index{index}."
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click

        Dim target As String = TextBox1.Text ' Change this to the target string you want to search from 

        ' Perform the linear search and display the result 
        Dim index As Integer = LinearSearch(target)

        If index >= 0 Then
            ' Item found, do something with it
            MessageBox.Show("Item found using linear search at : " & index)
        Else
            MessageBox.Show("Item not found using linear search")
        End If
    End Sub

    Public Function LinearSearch(ByVal target As String) As Integer
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i) = target Then
                ' Items found, return the index 
                Return i
            End If
        Next
    End Function

    Public Sub Binarysearch(ByVal target As String)

        Dim lowerbound As Integer = 0
        Dim upperbound As Integer = ListBox1.Items.Count - 1

        While lowerbound <= upperbound
            Dim middle As Integer = (lowerbound + upperbound) \ 2
            Dim currentItem As String = ListBox1.Items(middle)

            If currentItem = target Then
                ' Item found, do something with it 
                MessageBox.Show("Item found using binary search : " & currentItem)
                Exit Sub
            ElseIf currentItem < target Then
                lowerbound = middle + 1
            Else
                upperbound = middle - 1
            End If
        End While

        ' Item not found 
        MessageBox.Show("Item not found: " & target)
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        Dim data As List(Of String) = ListBox1.Items.Cast(Of String)().ToList()
        data.Sort()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(data.ToArray())
        Binarysearch(TextBox1.Text)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class