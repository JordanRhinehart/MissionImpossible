<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Targets1DataSet = New MissionImpossibleHitList.Targets1DataSet()
        Me.TargetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TargetsTableAdapter = New MissionImpossibleHitList.Targets1DataSetTableAdapters.TargetsTableAdapter()
        Me.TableAdapterManager = New MissionImpossibleHitList.Targets1DataSetTableAdapters.TableAdapterManager()
        Me.TargetsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TargetsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TargetsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBalt = New System.Windows.Forms.Label()
        Me.lblBarc = New System.Windows.Forms.Label()
        Me.lblCarac = New System.Windows.Forms.Label()
        Me.btnBalt = New System.Windows.Forms.Button()
        Me.btnCarac = New System.Windows.Forms.Button()
        Me.btnBarcel = New System.Windows.Forms.Button()
        CType(Me.Targets1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TargetsBindingNavigator.SuspendLayout()
        CType(Me.TargetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Targets1DataSet
        '
        Me.Targets1DataSet.DataSetName = "Targets1DataSet"
        Me.Targets1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TargetsBindingSource
        '
        Me.TargetsBindingSource.DataMember = "Targets"
        Me.TargetsBindingSource.DataSource = Me.Targets1DataSet
        '
        'TargetsTableAdapter
        '
        Me.TargetsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TargetsTableAdapter = Me.TargetsTableAdapter
        Me.TableAdapterManager.UpdateOrder = MissionImpossibleHitList.Targets1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TargetsBindingNavigator
        '
        Me.TargetsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TargetsBindingNavigator.BindingSource = Me.TargetsBindingSource
        Me.TargetsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TargetsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TargetsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TargetsBindingNavigatorSaveItem})
        Me.TargetsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TargetsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TargetsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TargetsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TargetsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TargetsBindingNavigator.Name = "TargetsBindingNavigator"
        Me.TargetsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TargetsBindingNavigator.Size = New System.Drawing.Size(942, 25)
        Me.TargetsBindingNavigator.TabIndex = 0
        Me.TargetsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TargetsBindingNavigatorSaveItem
        '
        Me.TargetsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TargetsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TargetsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TargetsBindingNavigatorSaveItem.Name = "TargetsBindingNavigatorSaveItem"
        Me.TargetsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TargetsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TargetsDataGridView
        '
        Me.TargetsDataGridView.AutoGenerateColumns = False
        Me.TargetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TargetsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TargetsDataGridView.DataSource = Me.TargetsBindingSource
        Me.TargetsDataGridView.Location = New System.Drawing.Point(46, 38)
        Me.TargetsDataGridView.Name = "TargetsDataGridView"
        Me.TargetsDataGridView.Size = New System.Drawing.Size(844, 249)
        Me.TargetsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Offense"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Offense"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Height"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Height"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Weight"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ethinicity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ethinicity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Current Location"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Current Location"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Priority"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Priority"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(376, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(163, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBalt
        '
        Me.lblBalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalt.ForeColor = System.Drawing.Color.Coral
        Me.lblBalt.Location = New System.Drawing.Point(157, 304)
        Me.lblBalt.Name = "lblBalt"
        Me.lblBalt.Size = New System.Drawing.Size(589, 86)
        Me.lblBalt.TabIndex = 3
        Me.lblBalt.Text = "Baltimore, Maryland"
        Me.lblBalt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBalt.Visible = False
        '
        'lblBarc
        '
        Me.lblBarc.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarc.ForeColor = System.Drawing.Color.Red
        Me.lblBarc.Location = New System.Drawing.Point(157, 304)
        Me.lblBarc.Name = "lblBarc"
        Me.lblBarc.Size = New System.Drawing.Size(589, 86)
        Me.lblBarc.TabIndex = 4
        Me.lblBarc.Text = "Barcelona, Spain"
        Me.lblBarc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBarc.Visible = False
        '
        'lblCarac
        '
        Me.lblCarac.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarac.ForeColor = System.Drawing.Color.Blue
        Me.lblCarac.Location = New System.Drawing.Point(222, 304)
        Me.lblCarac.Name = "lblCarac"
        Me.lblCarac.Size = New System.Drawing.Size(589, 86)
        Me.lblCarac.TabIndex = 5
        Me.lblCarac.Text = "Caracas, Venezuela"
        Me.lblCarac.Visible = False
        '
        'btnBalt
        '
        Me.btnBalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalt.ForeColor = System.Drawing.Color.Blue
        Me.btnBalt.Location = New System.Drawing.Point(816, 364)
        Me.btnBalt.Name = "btnBalt"
        Me.btnBalt.Size = New System.Drawing.Size(114, 26)
        Me.btnBalt.TabIndex = 6
        Me.btnBalt.Text = "Fly To Baltimore"
        Me.btnBalt.UseVisualStyleBackColor = True
        Me.btnBalt.Visible = False
        '
        'btnCarac
        '
        Me.btnCarac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarac.ForeColor = System.Drawing.Color.Red
        Me.btnCarac.Location = New System.Drawing.Point(816, 381)
        Me.btnCarac.Name = "btnCarac"
        Me.btnCarac.Size = New System.Drawing.Size(114, 26)
        Me.btnCarac.TabIndex = 7
        Me.btnCarac.Text = "Fly To Caracas"
        Me.btnCarac.UseVisualStyleBackColor = True
        Me.btnCarac.Visible = False
        '
        'btnBarcel
        '
        Me.btnBarcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcel.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnBarcel.Location = New System.Drawing.Point(816, 396)
        Me.btnBarcel.Name = "btnBarcel"
        Me.btnBarcel.Size = New System.Drawing.Size(114, 26)
        Me.btnBarcel.TabIndex = 8
        Me.btnBarcel.Text = "Fly To Barcelona"
        Me.btnBarcel.UseVisualStyleBackColor = True
        Me.btnBarcel.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(942, 450)
        Me.Controls.Add(Me.btnBarcel)
        Me.Controls.Add(Me.btnCarac)
        Me.Controls.Add(Me.btnBalt)
        Me.Controls.Add(Me.lblCarac)
        Me.Controls.Add(Me.lblBarc)
        Me.Controls.Add(Me.lblBalt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TargetsDataGridView)
        Me.Controls.Add(Me.TargetsBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.Targets1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TargetsBindingNavigator.ResumeLayout(False)
        Me.TargetsBindingNavigator.PerformLayout()
        CType(Me.TargetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Targets1DataSet As Targets1DataSet
    Friend WithEvents TargetsBindingSource As BindingSource
    Friend WithEvents TargetsTableAdapter As Targets1DataSetTableAdapters.TargetsTableAdapter
    Friend WithEvents TableAdapterManager As Targets1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TargetsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TargetsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TargetsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnExit As Button
    Friend WithEvents lblBalt As Label
    Friend WithEvents lblBarc As Label
    Friend WithEvents lblCarac As Label
    Friend WithEvents btnBalt As Button
    Friend WithEvents btnCarac As Button
    Friend WithEvents btnBarcel As Button
End Class
