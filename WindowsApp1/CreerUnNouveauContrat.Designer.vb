﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerUnNouveauContrat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreerUnNouveauContrat))
        Me.btnAide = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBoxFraisMensuel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxDateOuverture = New System.Windows.Forms.TextBox()
        Me.btnService = New System.Windows.Forms.Button()
        Me.btnLocationEquipement = New System.Windows.Forms.Button()
        Me.TxtBoxDateCreation = New System.Windows.Forms.TextBox()
        Me.TxtBoxNuméro = New System.Windows.Forms.TextBox()
        Me.CmbBoxFraisRacondement = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbBoxType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxDateVigueur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxFermeture = New System.Windows.Forms.TextBox()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.TxtBoxNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBoxPrenom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtBoxAddresse = New System.Windows.Forms.TextBox()
        Me.TxtBoxVille = New System.Windows.Forms.TextBox()
        Me.TxtBoxTéléphone = New System.Windows.Forms.TextBox()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.TxtBoxNEmployé = New System.Windows.Forms.TextBox()
        Me.TxtBoxCompanie = New System.Windows.Forms.TextBox()
        Me.TxtBoxCodePostal = New System.Windows.Forms.TextBox()
        Me.TxtBoxFax = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAide
        '
        Me.btnAide.Location = New System.Drawing.Point(903, 404)
        Me.btnAide.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(69, 33)
        Me.btnAide.TabIndex = 29
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(817, 404)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(69, 33)
        Me.btnAnnuler.TabIndex = 28
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBoxFraisMensuel)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtBoxDateOuverture)
        Me.GroupBox2.Controls.Add(Me.btnService)
        Me.GroupBox2.Controls.Add(Me.btnLocationEquipement)
        Me.GroupBox2.Controls.Add(Me.TxtBoxDateCreation)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNuméro)
        Me.GroupBox2.Controls.Add(Me.CmbBoxFraisRacondement)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CmbBoxType)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtBoxDateVigueur)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtBoxFermeture)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(488, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(495, 362)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option des Contrats"
        '
        'txtBoxFraisMensuel
        '
        Me.txtBoxFraisMensuel.Location = New System.Drawing.Point(161, 276)
        Me.txtBoxFraisMensuel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxFraisMensuel.Name = "txtBoxFraisMensuel"
        Me.txtBoxFraisMensuel.Size = New System.Drawing.Size(128, 22)
        Me.txtBoxFraisMensuel.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Date d'ouverture"
        '
        'TxtBoxDateOuverture
        '
        Me.TxtBoxDateOuverture.Location = New System.Drawing.Point(161, 137)
        Me.TxtBoxDateOuverture.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxDateOuverture.Name = "TxtBoxDateOuverture"
        Me.TxtBoxDateOuverture.Size = New System.Drawing.Size(128, 22)
        Me.TxtBoxDateOuverture.TabIndex = 31
        '
        'btnService
        '
        Me.btnService.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnService.ForeColor = System.Drawing.Color.Navy
        Me.btnService.Location = New System.Drawing.Point(347, 260)
        Me.btnService.Margin = New System.Windows.Forms.Padding(4)
        Me.btnService.Name = "btnService"
        Me.btnService.Size = New System.Drawing.Size(139, 32)
        Me.btnService.TabIndex = 28
        Me.btnService.Text = "Services"
        Me.btnService.UseVisualStyleBackColor = True
        '
        'btnLocationEquipement
        '
        Me.btnLocationEquipement.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLocationEquipement.ForeColor = System.Drawing.Color.Navy
        Me.btnLocationEquipement.Location = New System.Drawing.Point(347, 302)
        Me.btnLocationEquipement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLocationEquipement.Name = "btnLocationEquipement"
        Me.btnLocationEquipement.Size = New System.Drawing.Size(139, 53)
        Me.btnLocationEquipement.TabIndex = 27
        Me.btnLocationEquipement.Text = "Location des équipements"
        Me.btnLocationEquipement.UseVisualStyleBackColor = True
        '
        'TxtBoxDateCreation
        '
        Me.TxtBoxDateCreation.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtBoxDateCreation.Location = New System.Drawing.Point(161, 98)
        Me.TxtBoxDateCreation.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxDateCreation.Name = "TxtBoxDateCreation"
        Me.TxtBoxDateCreation.Size = New System.Drawing.Size(128, 22)
        Me.TxtBoxDateCreation.TabIndex = 24
        '
        'TxtBoxNuméro
        '
        Me.TxtBoxNuméro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtBoxNuméro.Location = New System.Drawing.Point(329, 23)
        Me.TxtBoxNuméro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxNuméro.Name = "TxtBoxNuméro"
        Me.TxtBoxNuméro.Size = New System.Drawing.Size(155, 22)
        Me.TxtBoxNuméro.TabIndex = 23
        '
        'CmbBoxFraisRacondement
        '
        Me.CmbBoxFraisRacondement.FormattingEnabled = True
        Me.CmbBoxFraisRacondement.Items.AddRange(New Object() {"Installation GRATUITE une semain apres", "Installation a 25$ le jour-j"})
        Me.CmbBoxFraisRacondement.Location = New System.Drawing.Point(161, 68)
        Me.CmbBoxFraisRacondement.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBoxFraisRacondement.Name = "CmbBoxFraisRacondement"
        Me.CmbBoxFraisRacondement.Size = New System.Drawing.Size(323, 24)
        Me.CmbBoxFraisRacondement.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 169)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 17)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Date en Vigueur"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 101)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 17)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Date de Creation"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 276)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 17)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Frais Mensuelles"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 68)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 17)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Frais de Racondement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Numéro"
        '
        'CmbBoxType
        '
        Me.CmbBoxType.FormattingEnabled = True
        Me.CmbBoxType.Items.AddRange(New Object() {"Actif", "Inactif"})
        Me.CmbBoxType.Location = New System.Drawing.Point(68, 28)
        Me.CmbBoxType.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBoxType.Name = "CmbBoxType"
        Me.CmbBoxType.Size = New System.Drawing.Size(128, 24)
        Me.CmbBoxType.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Type"
        '
        'TxtBoxDateVigueur
        '
        Me.TxtBoxDateVigueur.Location = New System.Drawing.Point(161, 174)
        Me.TxtBoxDateVigueur.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxDateVigueur.Name = "TxtBoxDateVigueur"
        Me.TxtBoxDateVigueur.Size = New System.Drawing.Size(128, 22)
        Me.TxtBoxDateVigueur.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date de Fermeture"
        '
        'TxtBoxFermeture
        '
        Me.TxtBoxFermeture.Location = New System.Drawing.Point(161, 212)
        Me.TxtBoxFermeture.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxFermeture.Name = "TxtBoxFermeture"
        Me.TxtBoxFermeture.Size = New System.Drawing.Size(128, 22)
        Me.TxtBoxFermeture.TabIndex = 5
        '
        'btnImprimer
        '
        Me.btnImprimer.Location = New System.Drawing.Point(719, 404)
        Me.btnImprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(81, 33)
        Me.btnImprimer.TabIndex = 27
        Me.btnImprimer.Text = "Imprimer"
        Me.btnImprimer.UseVisualStyleBackColor = True
        '
        'TxtBoxNom
        '
        Me.TxtBoxNom.Location = New System.Drawing.Point(87, 23)
        Me.TxtBoxNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxNom.Name = "TxtBoxNom"
        Me.TxtBoxNom.Size = New System.Drawing.Size(328, 22)
        Me.TxtBoxNom.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 68)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Prénom"
        '
        'TxtBoxPrenom
        '
        Me.TxtBoxPrenom.Location = New System.Drawing.Point(87, 64)
        Me.TxtBoxPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxPrenom.Name = "TxtBoxPrenom"
        Me.TxtBoxPrenom.Size = New System.Drawing.Size(328, 22)
        Me.TxtBoxPrenom.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 107)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Addresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 145)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Ville"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 192)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Télephone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 238)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 279)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "No Employé"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 318)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Compagnie"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(236, 197)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 17)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Fax"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(225, 145)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Code Postal"
        '
        'TxtBoxAddresse
        '
        Me.TxtBoxAddresse.Location = New System.Drawing.Point(87, 101)
        Me.TxtBoxAddresse.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxAddresse.Name = "TxtBoxAddresse"
        Me.TxtBoxAddresse.Size = New System.Drawing.Size(328, 22)
        Me.TxtBoxAddresse.TabIndex = 16
        '
        'TxtBoxVille
        '
        Me.TxtBoxVille.Location = New System.Drawing.Point(87, 142)
        Me.TxtBoxVille.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxVille.Name = "TxtBoxVille"
        Me.TxtBoxVille.Size = New System.Drawing.Size(131, 22)
        Me.TxtBoxVille.TabIndex = 17
        '
        'TxtBoxTéléphone
        '
        Me.TxtBoxTéléphone.Location = New System.Drawing.Point(91, 188)
        Me.TxtBoxTéléphone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxTéléphone.Name = "TxtBoxTéléphone"
        Me.TxtBoxTéléphone.Size = New System.Drawing.Size(113, 22)
        Me.TxtBoxTéléphone.TabIndex = 18
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(91, 235)
        Me.TxtBoxEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(325, 22)
        Me.TxtBoxEmail.TabIndex = 19
        '
        'TxtBoxNEmployé
        '
        Me.TxtBoxNEmployé.Location = New System.Drawing.Point(91, 276)
        Me.TxtBoxNEmployé.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxNEmployé.Name = "TxtBoxNEmployé"
        Me.TxtBoxNEmployé.Size = New System.Drawing.Size(113, 22)
        Me.TxtBoxNEmployé.TabIndex = 20
        '
        'TxtBoxCompanie
        '
        Me.TxtBoxCompanie.Location = New System.Drawing.Point(91, 318)
        Me.TxtBoxCompanie.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxCompanie.Name = "TxtBoxCompanie"
        Me.TxtBoxCompanie.Size = New System.Drawing.Size(325, 22)
        Me.TxtBoxCompanie.TabIndex = 21
        '
        'TxtBoxCodePostal
        '
        Me.TxtBoxCodePostal.Location = New System.Drawing.Point(311, 142)
        Me.TxtBoxCodePostal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxCodePostal.Name = "TxtBoxCodePostal"
        Me.TxtBoxCodePostal.Size = New System.Drawing.Size(104, 22)
        Me.TxtBoxCodePostal.TabIndex = 22
        '
        'TxtBoxFax
        '
        Me.TxtBoxFax.Location = New System.Drawing.Point(271, 193)
        Me.TxtBoxFax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxFax.Name = "TxtBoxFax"
        Me.TxtBoxFax.Size = New System.Drawing.Size(144, 22)
        Me.TxtBoxFax.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBoxFax)
        Me.GroupBox1.Controls.Add(Me.TxtBoxCodePostal)
        Me.GroupBox1.Controls.Add(Me.TxtBoxCompanie)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNEmployé)
        Me.GroupBox1.Controls.Add(Me.TxtBoxEmail)
        Me.GroupBox1.Controls.Add(Me.TxtBoxTéléphone)
        Me.GroupBox1.Controls.Add(Me.TxtBoxVille)
        Me.GroupBox1.Controls.Add(Me.TxtBoxAddresse)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtBoxPrenom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNom)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(436, 362)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identification Client"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Location = New System.Drawing.Point(628, 404)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(69, 33)
        Me.btnOK.TabIndex = 26
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(25, 393)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 64)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'CreerUnNouveauContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 469)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimer)
        Me.Controls.Add(Me.btnOK)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreerUnNouveauContrat"
        Me.Text = "CreerUnNouveauContrat"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAide As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBoxFraisMensuel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxDateOuverture As TextBox
    Friend WithEvents btnService As Button
    Friend WithEvents btnLocationEquipement As Button
    Friend WithEvents TxtBoxDateCreation As TextBox
    Friend WithEvents TxtBoxNuméro As TextBox
    Friend WithEvents CmbBoxFraisRacondement As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbBoxType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxDateVigueur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxFermeture As TextBox
    Friend WithEvents btnImprimer As Button
    Friend WithEvents TxtBoxNom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBoxPrenom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtBoxAddresse As TextBox
    Friend WithEvents TxtBoxVille As TextBox
    Friend WithEvents TxtBoxTéléphone As TextBox
    Friend WithEvents TxtBoxEmail As TextBox
    Friend WithEvents TxtBoxNEmployé As TextBox
    Friend WithEvents TxtBoxCompanie As TextBox
    Friend WithEvents TxtBoxCodePostal As TextBox
    Friend WithEvents TxtBoxFax As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOK As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
