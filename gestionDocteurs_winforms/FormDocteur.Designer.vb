<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDocteur
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
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TextPrenom = New System.Windows.Forms.TextBox()
        Me.TextNom = New System.Windows.Forms.TextBox()
        Me.TextSpecialite = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxHopital = New System.Windows.Forms.ComboBox()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextID
        '
        Me.TextID.Location = New System.Drawing.Point(202, 74)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(185, 22)
        Me.TextID.TabIndex = 26
        Me.TextID.Visible = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.Color.White
        Me.LoadButton.Location = New System.Drawing.Point(768, 289)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(90, 32)
        Me.LoadButton.TabIndex = 25
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Red
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(768, 383)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(90, 32)
        Me.DeleteButton.TabIndex = 24
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Navy
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(768, 337)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(90, 32)
        Me.UpdateButton.TabIndex = 23
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(742, 214)
        Me.DataGridView1.TabIndex = 22
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.ForeColor = System.Drawing.Color.White
        Me.Insert.Location = New System.Drawing.Point(202, 221)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(90, 32)
        Me.Insert.TabIndex = 21
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(80, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(180, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Gestion des docteurs"
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
        Me.ResetButton.Location = New System.Drawing.Point(308, 221)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(79, 32)
        Me.ResetButton.TabIndex = 27
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'TextPrenom
        '
        Me.TextPrenom.Location = New System.Drawing.Point(202, 130)
        Me.TextPrenom.Name = "TextPrenom"
        Me.TextPrenom.Size = New System.Drawing.Size(185, 22)
        Me.TextPrenom.TabIndex = 17
        '
        'TextNom
        '
        Me.TextNom.Location = New System.Drawing.Point(202, 102)
        Me.TextNom.Name = "TextNom"
        Me.TextNom.Size = New System.Drawing.Size(185, 22)
        Me.TextNom.TabIndex = 18
        '
        'TextSpecialite
        '
        Me.TextSpecialite.Location = New System.Drawing.Point(202, 158)
        Me.TextSpecialite.Name = "TextSpecialite"
        Me.TextSpecialite.Size = New System.Drawing.Size(185, 22)
        Me.TextSpecialite.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(80, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Hopital"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(80, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Specialite"
        '
        'ComboBoxHopital
        '
        Me.ComboBoxHopital.FormattingEnabled = True
        Me.ComboBoxHopital.Location = New System.Drawing.Point(202, 186)
        Me.ComboBoxHopital.Name = "ComboBoxHopital"
        Me.ComboBoxHopital.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxHopital.TabIndex = 32
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(458, 229)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(169, 22)
        Me.SearchTextBox.TabIndex = 33
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(633, 226)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(82, 26)
        Me.SearchButton.TabIndex = 34
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(931, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FormDocteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(931, 474)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.ComboBoxHopital)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextSpecialite)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextNom)
        Me.Controls.Add(Me.TextPrenom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResetButton)
        Me.Name = "FormDocteur"
        Me.Text = "FormDocteur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextID As TextBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Insert As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents ResetButton As Button
    Friend WithEvents TextSpecialite As TextBox
    Friend WithEvents TextNom As TextBox
    Friend WithEvents TextPrenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxHopital As ComboBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
