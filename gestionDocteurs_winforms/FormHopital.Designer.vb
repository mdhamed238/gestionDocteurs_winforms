<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHopital
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextAdresse = New System.Windows.Forms.TextBox()
        Me.TextNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Insert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(253, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestion des hopitales"
        '
        'TextAdresse
        '
        Me.TextAdresse.Location = New System.Drawing.Point(296, 163)
        Me.TextAdresse.Name = "TextAdresse"
        Me.TextAdresse.Size = New System.Drawing.Size(185, 22)
        Me.TextAdresse.TabIndex = 4
        '
        'TextNom
        '
        Me.TextNom.Location = New System.Drawing.Point(296, 122)
        Me.TextNom.Name = "TextNom"
        Me.TextNom.Size = New System.Drawing.Size(185, 22)
        Me.TextNom.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(152, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(152, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nom"
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.ForeColor = System.Drawing.Color.White
        Me.Insert.Location = New System.Drawing.Point(296, 201)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(90, 32)
        Me.Insert.TabIndex = 9
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(155, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(521, 221)
        Me.DataGridView1.TabIndex = 10
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Navy
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(744, 392)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(90, 32)
        Me.UpdateButton.TabIndex = 11
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Red
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(744, 442)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(90, 32)
        Me.DeleteButton.TabIndex = 12
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.Color.White
        Me.LoadButton.Location = New System.Drawing.Point(744, 340)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(90, 32)
        Me.LoadButton.TabIndex = 13
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(296, 85)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(185, 22)
        Me.TextID.TabIndex = 14
        Me.TextID.Visible = False
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.DarkGray
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(402, 201)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(79, 32)
        Me.ResetButton.TabIndex = 15
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(588, 239)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(82, 26)
        Me.SearchButton.TabIndex = 36
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(413, 241)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(169, 22)
        Me.SearchTextBox.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(998, 25)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FormHopital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(998, 496)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextNom)
        Me.Controls.Add(Me.TextAdresse)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHopital"
        Me.Text = "FormHopital"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextAdresse As TextBox
    Friend WithEvents TextNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Insert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DeleteButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents TextID As TextBox
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents ResetButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
