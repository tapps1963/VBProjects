<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim User_loginLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.QBDataSet = New _003_DBConnect.QBDataSet()
        Me.Tbl_usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_usersTableAdapter = New _003_DBConnect.QBDataSetTableAdapters.tbl_usersTableAdapter()
        Me.TableAdapterManager = New _003_DBConnect.QBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_usersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_usersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.User_loginTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        User_loginLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        CType(Me.QBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_usersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_usersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_loginLabel
        '
        User_loginLabel.AutoSize = True
        User_loginLabel.Location = New System.Drawing.Point(11, 45)
        User_loginLabel.Name = "User_loginLabel"
        User_loginLabel.Size = New System.Drawing.Size(55, 13)
        User_loginLabel.TabIndex = 3
        User_loginLabel.Text = "user login:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(11, 73)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(55, 13)
        First_nameLabel.TabIndex = 4
        First_nameLabel.Text = "first name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(11, 99)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(55, 13)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "last name:"
        '
        'QBDataSet
        '
        Me.QBDataSet.DataSetName = "QBDataSet"
        Me.QBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_usersBindingSource
        '
        Me.Tbl_usersBindingSource.DataMember = "tbl_users"
        Me.Tbl_usersBindingSource.DataSource = Me.QBDataSet
        '
        'Tbl_usersTableAdapter
        '
        Me.Tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_usersTableAdapter = Me.Tbl_usersTableAdapter
        Me.TableAdapterManager.UpdateOrder = _003_DBConnect.QBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_usersBindingNavigator
        '
        Me.Tbl_usersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_usersBindingNavigator.BindingSource = Me.Tbl_usersBindingSource
        Me.Tbl_usersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_usersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_usersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_usersBindingNavigatorSaveItem})
        Me.Tbl_usersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_usersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_usersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_usersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_usersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_usersBindingNavigator.Name = "Tbl_usersBindingNavigator"
        Me.Tbl_usersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_usersBindingNavigator.Size = New System.Drawing.Size(398, 25)
        Me.Tbl_usersBindingNavigator.TabIndex = 2
        Me.Tbl_usersBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_usersBindingNavigatorSaveItem
        '
        Me.Tbl_usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_usersBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_usersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_usersBindingNavigatorSaveItem.Name = "Tbl_usersBindingNavigatorSaveItem"
        Me.Tbl_usersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_usersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'User_loginTextBox
        '
        Me.User_loginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_usersBindingSource, "user_login", True))
        Me.User_loginTextBox.Location = New System.Drawing.Point(72, 42)
        Me.User_loginTextBox.Name = "User_loginTextBox"
        Me.User_loginTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_loginTextBox.TabIndex = 4
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_usersBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(72, 70)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_nameTextBox.TabIndex = 5
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_usersBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(72, 96)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(398, 223)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(User_loginLabel)
        Me.Controls.Add(Me.User_loginTextBox)
        Me.Controls.Add(Me.Tbl_usersBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "MyForm"
        CType(Me.QBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_usersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_usersBindingNavigator.ResumeLayout(False)
        Me.Tbl_usersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QBDataSet As QBDataSet
    Friend WithEvents Tbl_usersBindingSource As BindingSource
    Friend WithEvents Tbl_usersTableAdapter As QBDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents TableAdapterManager As QBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_usersBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_usersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents User_loginTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
End Class
