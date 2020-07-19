Imports POSLink
Public Class Form1

    Private CARD_TYPES() As String = {"CREDIT", "DEBIT", "GIFT"}
    Private CREDIT_TRANS_TYPES() As String = {"SALE", "AUTH", "RETURN", "POSTAUTH", "FORCEAUTH", "VOID", "ADJUST"}
    Private DEBIT_TRANS_TYPES() As String = {"SALE", "RETURN"}
    Private GIFT_TRANS_TYPES() As String = {"SALE", "RETURN", "RELOAD", "ACTIVATE", "DEACTIVATE", "INQUIRE"}
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim posl As POSLink.PosLink = New POSLink.PosLink()
        Dim myReboot As New ManageRequest()
        myReboot.TransType = 13 ' reboot request
        posl.ManageRequest = myReboot
        Dim com1 As CommSetting = New CommSetting()

        ' tcp
        com1.CommType = "TCP"
        com1.DestIP = "192.168.1.35"
        com1.DestPort = "10009"
        com1.TimeOut = "50000"
        posl.CommSetting = com1

        Dim result As ProcessTransResult = posl.ProcessTrans() '// Blocking call, will return when the transaction is complete.
        posl.Dispose()
    End Sub
    Private Sub btnSend_Image_Click(sender As Object, e As EventArgs) Handles btnSend_Image.Click
        Dim posl As POSLink.PosLink = New POSLink.PosLink()
        Dim myImage As New ManageRequest()
        myImage.TransType = 9 ' update Image
        myImage.ImagePath = "C:\Temp\pics.zip"
        posl.ManageRequest = myImage
        Dim com1 As CommSetting = New CommSetting()

        ' tcp
        com1.CommType = "TCP"
        com1.DestIP = "192.168.1.35"
        com1.DestPort = "10009"
        com1.TimeOut = "50000"
        posl.CommSetting = com1

        Dim result As ProcessTransResult = posl.ProcessTrans() '// Blocking call, will return when the transaction is complete.
        Select Case (result.Code)

            Case ProcessTransResultCode.OK
                Dim r As ManageResponse = posl.ManageResponse
                MessageBox.Show("ResultCode : " + r.ResultCode + "ResultTxt :" + r.ResultTxt + "ExtData :" + r.ExtData, result.Msg)

            Case ProcessTransResultCode.ERROR
                MessageBox.Show(result.Msg, "CALLED ERR")

            Case Else
                MessageBox.Show(result.Msg, "Error Processing Payment")

        End Select

        posl.Dispose()
    End Sub
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click


        Dim posl As POSLink.PosLink = New POSLink.PosLink()

        Dim payRequest As PaymentRequest = New PaymentRequest()  ' Setup a request object.

        Dim com1 As CommSetting = New CommSetting()
        'uart
        '     com1.CommType = "UART";
        '     com1.SerialPort = "COM16";
        '     com1.TimeOut = "50000";
        '     posl.CommSetting = com1;
        '     //tcp
        com1.CommType = "TCP"
        com1.DestIP = "192.168.1.34"
        com1.DestPort = "10009"
        com1.TimeOut = "50000"
        posl.CommSetting = com1

        payRequest.TenderType = payRequest.ParseTenderType(cmbCardType.SelectedItem)
        payRequest.TransType = payRequest.ParseTransType(cmbTransType.SelectedItem)
        payRequest.ECRRefNum = txtRef.Text
        payRequest.SigSavePath = "C:\Temp\"
        payRequest.ExtData = "<SignatureCapture>1</SignatureCapture><GetSign>1</GetSign><SignUploadFlag>1</SignUploadFlag><ReceiptPrint>2</ReceiptPrint>"
        'payRequest.Amount = "1050"   ' this will seed the transaction amount

        posl.PaymentRequest = payRequest

        Dim result As ProcessTransResult = posl.ProcessTrans() '// Blocking call, will return when the transaction is complete.



        ' There will be 2 separate results that you must handle.  First is the ProcessTransResult, this will give you the result of the 
        ' request to call poslink.  PaymentResponse should only be checked if ShowPageResult.Code == OK.  
        ' PaymentResponse is the result of the financial transaction to the payment server.
        Select (result.Code)

            Case ProcessTransResultCode.OK
                Dim r As PaymentResponse = posl.PaymentResponse
                MessageBox.Show("ResultCode : " + r.ResultCode + "ResultTxt :" + r.ResultTxt + "ExtData :" + r.ExtData, result.Msg)

            Case ProcessTransResultCode.ERROR
                MessageBox.Show(result.Msg, "CALLED ERR")

            Case Else
                MessageBox.Show(result.Msg, "Error Processing Payment")

        End Select

    End Sub

#Region "UI CODE"

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbCardType.BeginUpdate()
        cmbCardType.Items.Clear()
        cmbCardType.Items.AddRange(CARD_TYPES)
        cmbCardType.SelectedItem = CARD_TYPES(0)
        cmbCardType.EndUpdate() ' this will trigger a changed event on this controll which is where we load the trans types.
    End Sub

    Private Sub cmbCardType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCardType.SelectedIndexChanged

        cmbTransType.BeginUpdate()
        cmbTransType.Items.Clear()

        If (cmbCardType.SelectedIndex = 0) Then
            cmbTransType.Items.AddRange(CREDIT_TRANS_TYPES)
        ElseIf (cmbCardType.SelectedIndex = 1) Then
            cmbTransType.Items.AddRange(DEBIT_TRANS_TYPES)
        Else
            cmbTransType.Items.AddRange(GIFT_TRANS_TYPES)
        End If

        cmbTransType.EndUpdate()
    End Sub

    Private Sub btnSend_Lines_Click(sender As Object, e As EventArgs) Handles btnSend_Lines.Click
        Dim posl As POSLink.PosLink = New POSLink.PosLink()
        Dim myMessage As New ManageRequest()
        myMessage.TransType = 7 ' clear existing message
        posl.ManageRequest = myMessage
        Dim com1 As CommSetting = New CommSetting()

        ' tcp
        com1.CommType = "TCP"
        com1.DestIP = "192.168.1.35"
        com1.DestPort = "10009"
        com1.TimeOut = "50000"
        posl.CommSetting = com1

        Dim result As ProcessTransResult = posl.ProcessTrans() '// Blocking call, will return when the transaction is complete.

        myMessage.TransType = 6  ' display the message here
        myMessage.Title = "My Title"
        myMessage.TopDown = "N"
        myMessage.DisplayMessage = "\CThis is line 2."
        result = posl.ProcessTrans()
        myMessage.DisplayMessage = "\CThis is line 1."
        result = posl.ProcessTrans()
        ' Wait 5 seconds then reset the terminal
        Wait(5)
        myMessage.TransType = 8
        result = posl.ProcessTrans
        posl.Dispose()
    End Sub

#End Region
    Private Sub Wait(ByVal Seconds As Integer)
        Dim Right_Now As Date

        Right_Now = Now
        While DateDiff(DateInterval.Second, Right_Now, Now) < Seconds
            System.Windows.Forms.Application.DoEvents()
        End While
    End Sub

    Private Sub btnSend_Init_Click(sender As Object, e As EventArgs) Handles btnSend_Init.Click
        Dim posl As POSLink.PosLink = New POSLink.PosLink()
        Dim myInit As New ManageRequest()
        myInit.TransType = 1 ' Send INIT command
        posl.ManageRequest = myInit
        Dim com1 As CommSetting = New CommSetting()

        ' tcp
        com1.CommType = "TCP"
        com1.DestIP = "192.168.1.31"
        com1.DestPort = "10009"
        com1.TimeOut = "50000"
        posl.CommSetting = com1

        Dim result As ProcessTransResult = posl.ProcessTrans() '// Blocking call, will return when the transaction is complete.
        Select Case (result.Code)

            Case ProcessTransResultCode.OK
                Dim r As ManageResponse = posl.ManageResponse
                MessageBox.Show("ResultCode : " + r.ResultCode + "ResultTxt :" + r.ResultTxt + "ExtData :" + r.ExtData, result.Msg)
                MessageBox.Show("Terminal ID: " & r.SN & vbCrLf & "MAC Address: " & r.MacAddress, "Device Stats")

            Case ProcessTransResultCode.ERROR
                MessageBox.Show(result.Msg, "CALLED ERR")

            Case Else
                MessageBox.Show(result.Msg, "Error Processing Payment")

        End Select

        posl.Dispose()
    End Sub
End Class
