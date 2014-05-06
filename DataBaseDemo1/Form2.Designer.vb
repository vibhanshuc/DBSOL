<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StepSampleDataSet = New DataBaseDemo1.StepSampleDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New DataBaseDemo1.StepSampleDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New DataBaseDemo1.StepSampleDataSetTableAdapters.TableAdapterManager()
        Me.StepSampleDataSet1 = New DataBaseDemo1.StepSampleDataSet1()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter1 = New DataBaseDemo1.StepSampleDataSet1TableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager1 = New DataBaseDemo1.StepSampleDataSet1TableAdapters.TableAdapterManager()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StepSampleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StepSampleDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StepSampleDataSet
        '
        Me.StepSampleDataSet.DataSetName = "StepSampleDataSet"
        Me.StepSampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.StepSampleDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BankAccountTableAdapter = Nothing
        Me.TableAdapterManager.CourseCatalogTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.OrderEntryTableAdapter = Nothing
        Me.TableAdapterManager.StateRegionTableAdapter = Nothing
        Me.TableAdapterManager.UnitOfMeasureTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataBaseDemo1.StepSampleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StepSampleDataSet1
        '
        Me.StepSampleDataSet1.DataSetName = "StepSampleDataSet1"
        Me.StepSampleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.StepSampleDataSet1
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BankAccountTableAdapter = Nothing
        Me.TableAdapterManager1.CourseCatalogTableAdapter = Nothing
        Me.TableAdapterManager1.CustomerTableAdapter = Me.CustomerTableAdapter1
        Me.TableAdapterManager1.OrderEntryTableAdapter = Nothing
        Me.TableAdapterManager1.StateRegionTableAdapter = Nothing
        Me.TableAdapterManager1.UnitOfMeasureTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = DataBaseDemo1.StepSampleDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource1
        Me.CustomerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(636, 473)
        Me.CustomerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FullName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Address1"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "WebSite"
        Me.DataGridViewTextBoxColumn5.HeaderText = "WebSite"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 473)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.StepSampleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StepSampleDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StepSampleDataSet As DataBaseDemo1.StepSampleDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As DataBaseDemo1.StepSampleDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As DataBaseDemo1.StepSampleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StepSampleDataSet1 As DataBaseDemo1.StepSampleDataSet1
    Friend WithEvents CustomerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter1 As DataBaseDemo1.StepSampleDataSet1TableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager1 As DataBaseDemo1.StepSampleDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
