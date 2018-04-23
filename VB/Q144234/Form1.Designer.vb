Imports Microsoft.VisualBasic
Imports System
Namespace Q144234
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myTreeList1 = New DXSample.MyTreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.myTreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myTreeList1
			' 
			Me.myTreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
			Me.myTreeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myTreeList1.Location = New System.Drawing.Point(0, 0)
			Me.myTreeList1.Name = "myTreeList1"
			Me.myTreeList1.BeginUnboundLoad()
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, -1)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, 0)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, -1)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, 2)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, -1)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, 4)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, -1)
			Me.myTreeList1.AppendNode(New Object() { Nothing, Nothing}, 6)
			Me.myTreeList1.EndUnboundLoad()
			Me.myTreeList1.OptionsBehavior.ShowEditorOnMouseUp = True
			Me.myTreeList1.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.myTreeList1.OptionsSelection.MultiSelect = True
			Me.myTreeList1.OptionsView.ShowFocusedFrame = False
			Me.myTreeList1.Size = New System.Drawing.Size(445, 268)
			Me.myTreeList1.TabIndex = 0
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.MinWidth = 38
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "treeListColumn2"
			Me.treeListColumn2.FieldName = "treeListColumn2"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(445, 268)
			Me.Controls.Add(Me.myTreeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myTreeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myTreeList1 As DXSample.MyTreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn




	End Class
End Namespace

