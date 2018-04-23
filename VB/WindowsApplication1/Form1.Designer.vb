Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
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
			Me.components = New System.ComponentModel.Container()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.dataNavigatorButtonCaptionHelper1 = New WindowsApplication1.DataNavigatorButtonCaptionHelper()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Buttons.Append.ImageIndex = 6
			Me.dataNavigator1.Buttons.Append.Tag = "Append"
			Me.dataNavigator1.Buttons.CancelEdit.ImageIndex = 9
			Me.dataNavigator1.Buttons.CancelEdit.Tag = "Cancel"
			Me.dataNavigator1.Buttons.EndEdit.ImageIndex = 8
			Me.dataNavigator1.Buttons.EndEdit.Tag = "EndEdit"
			Me.dataNavigator1.Buttons.First.ImageIndex = 0
			Me.dataNavigator1.Buttons.First.Tag = "First"
			Me.dataNavigator1.Buttons.Last.ImageIndex = 5
			Me.dataNavigator1.Buttons.Last.Tag = "Last"
			Me.dataNavigator1.Buttons.Next.ImageIndex = 3
			Me.dataNavigator1.Buttons.Next.Tag = "Next"
			Me.dataNavigator1.Buttons.NextPage.ImageIndex = 4
			Me.dataNavigator1.Buttons.NextPage.Tag = "NP"
			Me.dataNavigator1.Buttons.Prev.ImageIndex = 2
			Me.dataNavigator1.Buttons.Prev.Tag = "Prev"
			Me.dataNavigator1.Buttons.PrevPage.ImageIndex = 1
			Me.dataNavigator1.Buttons.PrevPage.Tag = "PrevPage"
			Me.dataNavigator1.Buttons.Remove.ImageIndex = 7
			Me.dataNavigator1.Buttons.Remove.Tag = "Remove"
			Me.dataNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() { New DevExpress.XtraEditors.NavigatorCustomButton(-1, 10, True, True, "", "<Custom>")})
			Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.dataNavigator1.Location = New System.Drawing.Point(0, 499)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(987, 28)
			Me.dataNavigator1.TabIndex = 0
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(987, 499)
			Me.dataGridView1.TabIndex = 1
			' 
			' dataNavigatorButtonCaptionHelper1
			' 
			Me.dataNavigatorButtonCaptionHelper1.SelectedNavigator = Me.dataNavigator1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(987, 527)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private dataNavigatorButtonCaptionHelper1 As DataNavigatorButtonCaptionHelper
	End Class
End Namespace

