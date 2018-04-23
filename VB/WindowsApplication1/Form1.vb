Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports System.Collections

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
				End Function

		Public Sub New()
			InitializeComponent()
			dataGridView1.DataSource = CreateTable(20)
			dataNavigator1.DataSource = dataGridView1.DataSource
		End Sub
	End Class

	Public Class DataNavigatorButtonCaptionHelper
		Inherits Component

		Private _SelectedNavigator As DataNavigator
		Public Property SelectedNavigator() As DataNavigator
			Get
				Return _SelectedNavigator
			End Get
			Set(ByVal value As DataNavigator)
				BeforeSelectedNavigatorChanged(value)
				_SelectedNavigator = value
				AfterSelectedNavigatorChanged()
			End Set
		End Property

		Public _imageList As ImageList

		Private Sub BeforeSelectedNavigatorChanged(ByVal newNavigator As DataNavigator)
			If _SelectedNavigator IsNot Nothing Then
				_SelectedNavigator.Buttons.ImageList = Nothing
			End If
			If newNavigator IsNot Nothing Then
				newNavigator.Buttons.ImageList = _imageList
			End If
		End Sub


		Private Sub TraverseCollection(ByVal collection As ICollection)
			Dim col1 As NavigatorButtonCollectionBase = TryCast(collection, NavigatorButtonCollectionBase)
			Dim col2 As NavigatorCustomButtons = TryCast(collection, NavigatorCustomButtons)
			For i As Integer = 0 To collection.Count - 1
				Dim button As NavigatorButtonBase = Nothing
				If col1 IsNot Nothing Then
					button = col1(i)
				Else
					button = col2(i)
				End If
				If button.Tag Is Nothing Then
					Continue For
				End If
				_imageList.Images.Add(GetBitmap(button.Tag))
				button.ImageIndex = _imageList.Images.Count - 1
			Next i
		End Sub
		Private Sub AfterSelectedNavigatorChanged()
			If SelectedNavigator Is Nothing Then
				Return
			End If
			TraverseCollection(SelectedNavigator.Buttons.ButtonCollection)
			TraverseCollection(SelectedNavigator.Buttons.CustomButtons)
		End Sub



		Private Function GetBitmap(ByVal text As Object) As Bitmap
			Dim image As New Bitmap(_imageList.ImageSize.Width, _imageList.ImageSize.Height)
			Dim g As Graphics = Graphics.FromImage(image)
			Dim rect As New Rectangle(New Point(0, 0), image.Size)
			g.FillRectangle(Brushes.White, rect)
			Dim sf As New StringFormat()
			sf.Alignment = StringAlignment.Center
			g.DrawString(text.ToString(), AppearanceObject.DefaultFont, Brushes.Black, rect, sf)
			image.MakeTransparent()
			Return image
		End Function



		Public Sub New()
			_imageList = New ImageList()
			_imageList.ImageSize = New Size(70, 20)
		End Sub
	End Class
End Namespace