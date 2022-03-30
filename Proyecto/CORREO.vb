
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Module CORREO
    Friend Sub ENVIAR_CORREO(ByVal TITULO As String, ByVal CUERPO_MENSAJE As String, ByVal CORREO_ESTUDIANTE As String, ByVal DIRECCION_DEL_ARCHIVO As String, ByVal CUENTA_DESDE_DONDE_SE_ENVIA_CORREO As String, ByVal CLAVE_DE_CORREO As String)
        'Try
        Dim destino As New SmtpClient("smtp.office365.com")
        destino.Port = 587
        destino.EnableSsl = True
        destino.UseDefaultCredentials = False
        destino.Credentials = New NetworkCredential(CUENTA_DESDE_DONDE_SE_ENVIA_CORREO, CLAVE_DE_CORREO)

        'DIRECCION DEL ARCHIVO QUE SE VA ADJUNTAR
        Dim ARCHIVO_ADJUNTO As New System.Net.Mail.Attachment(DIRECCION_DEL_ARCHIVO)


        'Se usan <br/> para representar saltos de linea en el string
        'Dim destinoHTML As String = NOMBRE_PACIENTE
        'Dim saludoHTML As String = "Estimado (a) paciente:"
        Dim cuerpoHTML As String = CUERPO_MENSAJE
        Dim CUERPO_CORREO As String
        CUERPO_CORREO = CUERPO_MENSAJE
        'Dim nombreDestinoHTML As String = ""
        'Dim emisorHTML As String = "Desamparados carretera al COLYPRO"
        'Dim departamentoHTML As String = "1 kilometro sureste de la Guardia de Asistencia Rural."
        'Dim paisHTML As String = "Alajuela, Costa Rica"
        'Dim diseno As String = "<html>" +
        '"<head>" +
        '"<meta charset='utf-8' />" +
        '"<link href='estilo.css' rel='stylesheet' />" +
        '"<style>" +
        '"p{" +
        '"padding-left:15px;" +
        '"padding-right:15px;}" +
        '"p,.T,.Z{ " +
        '"font-size: 15px;" +
        '"text-align: left;" +
        '" margin: auto;}" +
        '".T {" +
        '"text-align:center;" +
        '"font-size:19px;}" +
        '".T {" +
        '"text-align:center;" +
        '"font-size:19px;}" +
        '"img {" +
        '"width:1011px;" +
        '"height:636px;" +
        '"}" +
        '".O {" +
        '"text-decoration:double;}" +
        '".Z,.F{text-align:right;}" +
        '".F {font-size:13px;}" +
        '".Caja{" +
        '"margin: auto;" +
        '"max-width: 680px;}" +
        '"</style>" +
        '"</head>" +
        '"<body>" +
        '"<form class='Caja'>" +
        '"<p>" +
        '"<br/>" + saludoHTML + " " + "<strong>" + destinoHTML + "</strong><br/>" +
        '"<br/>" + cuerpoHTML +
        '"</p>" +
        '"<br/>" +
        '"<br/>" +
        '"<p class='T'><strong>" + nombreDestinoHTML + "</strong></p>" +
        '"<center><img src='cid:imagen'/></center>" +
        '"<p class='Z'><br/><br/>Estamos ubicados en:<br /><strong><u>" + emisorHTML + "<br/>" +
        '"</u></strong><span class='F'><i>" + departamentoHTML + "</i><br/><strong>" + paisHTML + "</strong></span></p>" +
        '"</form>" +
        '"</body>" +
        '"</html>"
        Dim emisor As New MailMessage
        emisor.From = New MailAddress(CUENTA_DESDE_DONDE_SE_ENVIA_CORREO)
        emisor.To.Add(CORREO_ESTUDIANTE)
        emisor.Subject = TITULO
        emisor.Body = CUERPO_CORREO
        emisor.Attachments.Add(ARCHIVO_ADJUNTO)
        emisor.Priority = MailPriority.High
        emisor.IsBodyHtml = False

        'Dim vista As AlternateView = AlternateView.CreateAlternateViewFromString(diseno, Nothing, MediaTypeNames.Text.Html)

        'Dim img As LinkedResource = New LinkedResource("CUENTA_BANCARIA.jpg", MediaTypeNames.Image.Jpeg)
        'img.ContentId = "imagen"

        'vista.LinkedResources.Add(img)
        'emisor.AlternateViews.Add(vista)

        destino.Send(emisor)

        ' Exit Try
        'Catch ex As Exception
        'MsgBox("Ha ocurrido el siguiente inconveniente: " & vbNewLine + vbNewLine & ex.Message, vbCritical + vbOKOnly, "Problemas en el envío")
        'Exit Try
        'MsgBox("El correo electrónico no pudo ser enviado", vbExclamation + vbOKOnly, "Envío fallido")
        'End Try
    End Sub


End Module
