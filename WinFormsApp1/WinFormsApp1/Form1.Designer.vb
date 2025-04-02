<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        casutatext = New Label()
        Butongenerare = New Button()
        labelnumere = New Label()
        SuspendLayout()
        ' 
        ' casutatext
        ' 
        casutatext.AutoSize = True
        casutatext.Location = New Point(273, 102)
        casutatext.Name = "casutatext"
        casutatext.Size = New Size(273, 15)
        casutatext.TabIndex = 0
        casutatext.Text = "6 numere vor fi afisate mai jos dand click pe buton"
        ' 
        ' Butongenerare
        ' 
        Butongenerare.Location = New Point(350, 291)
        Butongenerare.Name = "Butongenerare"
        Butongenerare.Size = New Size(75, 23)
        Butongenerare.TabIndex = 1
        Butongenerare.Text = "Generare numere"
        Butongenerare.UseVisualStyleBackColor = True
        ' 
        ' labelnumere
        ' 
        labelnumere.AutoSize = True
        labelnumere.Location = New Point(288, 174)
        labelnumere.Name = "labelnumere"
        labelnumere.Size = New Size(137, 15)
        labelnumere.TabIndex = 2
        labelnumere.Text = "Numerele generate sunt:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(labelnumere)
        Controls.Add(Butongenerare)
        Controls.Add(casutatext)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents casutatext As Label
    Friend WithEvents Butongenerare As Button
    Friend WithEvents labelnumere As Label

End Class
