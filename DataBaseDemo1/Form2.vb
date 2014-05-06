Public Class Form2

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StepSampleDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StepSampleDataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.StepSampleDataSet1.Customer)
        'TODO: This line of code loads data into the 'StepSampleDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.StepSampleDataSet.Customer)

    End Sub
End Class