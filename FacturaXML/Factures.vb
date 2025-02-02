Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SQLite
Imports System.IO

Public Class Factures
    Dim DT_Empreses As New DataTable
    Dim DT_Solucions As New DataTable
    Private idEmpresa As Integer
    Private idSolucio As Integer
    Private CarregarDades As Boolean
    Private tipusSolucio, monitor, ordinador As String


    'Carrega les empreses per omplir el combobox
    Private Sub Factures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadesFactura()
    End Sub
    Private Sub Factures_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If idEmpresaFactura <> 0 Then
            CarregarDadesFactura()
        End If
    End Sub
    Private Sub CarregarDadesFactura()
        Dim SQL As String
        Dim conexion As New SQLiteConnection()
        Dim strCommand As SQLiteCommand

        conexion = New SQLiteConnection(cadena)
        conexion.Open()

        Debug.WriteLine(idEmpresaFactura & " - " & idSolucioFactura)
        If idEmpresaFactura <> 0 Then
            CarregarDades = False
        Else
            CarregarDades = True
        End If

        If CarregarDades = True Then
            SQL = "SELECT * FROM Empreses ORDER BY Nom ASC"
            Try
                If conexion.State = ConnectionState.Open Then
                    Dim DA_Empreses As New SQLiteDataAdapter(SQL, conexion)
                    DA_Empreses.Fill(DT_Empreses)
                    CB_Empreses.DataSource = DT_Empreses
                    CB_Empreses.DisplayMember = "Nom"
                    CB_Empreses.Text = "Selecciona empresa"
                    CB_Empreses.ValueMember = "Id"
                End If

            Catch ex As Exception
                MsgBox("No s'han pogut carregar les empreses desde la base de dades", vbCritical, "Error")
            End Try

        Else
            CB_Empreses.Enabled = False
            CB_Solucions.Enabled = False
            FacturaSolucio.Enabled = False


            Try

                If conexion.State = ConnectionState.Open Then
                    SQL = "SELECT * FROM Empreses WHERE Id=" & idEmpresaFactura

                    strCommand = New SQLiteCommand(SQL, conexion)

                    Dim lector As SQLiteDataReader = strCommand.ExecuteReader

                    If lector.Read Then

                        EmpresaNom.Text = lector.GetString("Nom")
                        EmpresaNif.Text = lector.GetString("Nif")
                        EmpresaCiutat.Text = lector.GetString("Ciutat")
                        EmpresaDireccio.Text = lector.GetString("Direccio")
                        EmpresaCodiPostal.Text = lector.GetString("CodiPostal")
                        EmpresaProvincia.Text = lector.GetString("Provincia")
                        EmpresaPais.Text = lector.GetString("Pais")
                    End If
                    lector.Close()

                    SQL = "SELECT Solucions.idSolucio,
                                     Solucions.IdEmpresa,
                                     TipusSolucions.Nom,
                                     Solucions.Contracte,
                                     Solucions.DataFactura,
                                     Solucions.DataPagament,
                                     Justificacions.TotalSolucio,
                                     Justificacions.Percentatge,
                                     Justificacions.Subvencio,
                                     Justificacions.Factura,
                                     Justificacions.FabricantSolucio,
                                     Justificacions.Monitor
                                     FROM Solucions
                                     INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                     INNER JOIN Justificacions ON Solucions.Id= Justificacions.idSolucio  
                                     WHERE idEmpresa=" & idEmpresaFactura & " AND Solucions.Id=" & idSolucioFactura

                    strCommand = New SQLiteCommand(SQL, conexion)
                    lector = strCommand.ExecuteReader

                    If lector.Read Then

                        FacturaAcord.Text = lector.GetString("Contracte")
                        FacturaSolucio.Text = lector.GetString("Nom")
                        FacturaImportSolucio.Text = lector.GetValue("TotalSolucio")
                        FacturaData.Text = Format(lector.GetString("DataFactura"), "Short Date")
                        TB_DataCobrament.Text = Format(lector.GetString("DataPagament"), "Short Date")
                        FacturaImportSubvencionat.Text = lector.GetValue("Subvencio").ToString
                        FacturaNumero.Text = lector.GetString("Factura")
                        monitor = lector.GetString("Monitor")
                        ordinador = lector.GetString("FabricantSolucio")

                        Debug.WriteLine(monitor & " - " & ordinador)

                        If lector.GetValue("Percentatge") <> 100 Then
                            Vigila.Visible = True
                        Else
                            Vigila.Visible = False
                        End If
                    End If
                    lector.Close()
                End If
            Catch ex As Exception
                MsgBox("No s'han pogut carregar les dades", vbCritical, "Error")
            End Try

        End If
        conexion.Close()

        idSolucioFactura = 0
        idEmpresaFactura = 0
    End Sub
    'Controla els caracters que es poden introduir al textbox
    Private Sub CompruebaTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FacturaImportSolucio.KeyPress, FacturaImportSubvencionat.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = ","
    End Sub

    'Fa els calculs de l'iva
    Private Sub CanviaImportSolucio(sender As Object, e As EventArgs) Handles FacturaImportSolucio.TextChanged

        Dim i As Double
        Dim x As Double

        If (FacturaImportSolucio.Text <> "") Then
            i = CDbl(FacturaImportSolucio.Text) * 0.21
            x = CDbl(FacturaImportSolucio.Text) + i
            FacturaImportIVA.Text = i.ToString
            FacturaImportTotal.Text = x.ToString
        Else
            FacturaImportTotal.Text = "0"
            FacturaImportIVA.Text = "0"
        End If

        TB_ImportFactura.Text = FacturaImportSolucio.Text
    End Sub
    'Prepara l'arxiu per a ser guardat o mostrat
    Private Sub PreparaArxiu()

        Dim totalString, solucioString, ivaString, subvencioString, dataInici, dataFi, textFinançament As String
        Dim totalDecimal, solucioDecimal, IvaDecimal, SubvencioDecimal As Decimal

        If FacturaImportSubvencionat.Text = "" Then FacturaImportSubvencionat.Text = 0

        If (FacturaImportSolucio.Text <> "") Then
            totalDecimal = FacturaImportTotal.Text
            solucioDecimal = FacturaImportSolucio.Text
            IvaDecimal = FacturaImportIVA.Text
            SubvencioDecimal = FacturaImportSubvencionat.Text
        Else
            totalDecimal = 0
            solucioDecimal = 0
            IvaDecimal = 0
            SubvencioDecimal = 0
        End If

        If (FacturaAcord.Text.Substring(0, 2) = "KD") Then
            textFinançament = "Financiado por el Programa KIT Digital. Plan de Recuperación, Transformación y Resiliencia de España Next Generation EU."
        Else
            textFinançament = "Financiado por el Programa Agentes del Cambio – Kit Consulting, Plan de Recuperación, Transformación y Resiliencia España-Next Generation EU"
        End If

        totalString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", totalDecimal)
        solucioString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", solucioDecimal)
        ivaString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", IvaDecimal)
        subvencioString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", SubvencioDecimal)

        dataInici = Format(FacturaData.Value.Date, "yyyy-MM-dd")
        dataFi = Format(FacturaData.Value.AddYears(1).Date, "yyyy-MM-dd")

        '
        'Texto XML
        '

        textoXML.Clear()
        textoXML.Append("<fe:Facturae xmlns:fe = ""http://www.facturae.es/Facturae/2014/v3.2.1/Facturae"" xmlns:ds = ""http://www.w3.org/2000/09/xmldsig#"">")

        'FileHeader

        textoXML.AppendLine("<FileHeader>
        <SchemaVersion>3.2.1</SchemaVersion>
        <Modality>I</Modality>
        <InvoiceIssuerType>EM</InvoiceIssuerType>
        <Batch>
            <BatchIdentifier>A0886144582208021</BatchIdentifier>
            <InvoicesCount>1</InvoicesCount>
            <TotalInvoicesAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalInvoicesAmount>
            <TotalOutstandingAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalOutstandingAmount>
            <TotalExecutableAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalExecutableAmount>
            <InvoiceCurrencyCode>EUR</InvoiceCurrencyCode>
        </Batch>
    </FileHeader>")


        ' Parties

        textoXML.AppendLine("<Parties>
        <SellerParty>
            <TaxIdentification>
                <PersonTypeCode>J</PersonTypeCode>
                <ResidenceTypeCode>R</ResidenceTypeCode>
                <TaxIdentificationNumber>B61904520</TaxIdentificationNumber>
            </TaxIdentification>
            <LegalEntity>
                <CorporateName>" & My.Settings.Empresa & "</CorporateName>
                <AddressInSpain>
                    <Address>" & My.Settings.Direccio & "</Address>
                    <PostCode>" & My.Settings.CodiPostal & "</PostCode>
                    <Town>" & My.Settings.Ciuat & "</Town>
                    <Province>" & My.Settings.Provincia & "</Province>
                    <CountryCode>ESP</CountryCode>
                </AddressInSpain>
            </LegalEntity>
        </SellerParty>
        <BuyerParty>
            <TaxIdentification>
                <PersonTypeCode>J</PersonTypeCode>
                <ResidenceTypeCode>R</ResidenceTypeCode>
                <TaxIdentificationNumber>" & EmpresaNif.Text & "</TaxIdentificationNumber>
            </TaxIdentification>
            <LegalEntity>
                <CorporateName>" & EmpresaNom.Text & "</CorporateName>
                <AddressInSpain>
                    <Address>" & EmpresaDireccio.Text & "</Address>
                    <PostCode>" & EmpresaCodiPostal.Text & "</PostCode>
                    <Town>" & EmpresaCiutat.Text & "</Town>
                    <Province>" & EmpresaProvincia.Text & "</Province>
                    <CountryCode>ESP</CountryCode>
                </AddressInSpain>
            </LegalEntity>
        </BuyerParty>
    </Parties>")

        ' Invoices

        textoXML.AppendLine(" <Invoices>
        <Invoice>
            <InvoiceHeader>
                <InvoiceNumber>" & FacturaNumero.Text & "</InvoiceNumber>
                <InvoiceSeriesCode>1</InvoiceSeriesCode>
                <InvoiceDocumentType>FC</InvoiceDocumentType>
                <InvoiceClass>OO</InvoiceClass>
            </InvoiceHeader>
            <InvoiceIssueData>
                <IssueDate>" & dataInici & "</IssueDate>
                <InvoiceCurrencyCode>EUR</InvoiceCurrencyCode>
                <TaxCurrencyCode>EUR</TaxCurrencyCode>
                <LanguageName>es</LanguageName>
            </InvoiceIssueData>
            <TaxesOutputs>
                <Tax>
                    <TaxTypeCode>01</TaxTypeCode>
                    <TaxRate>21.0</TaxRate>
                    <TaxableBase>
                        <TotalAmount>" & solucioString & "</TotalAmount>
                    </TaxableBase>
                    <TaxAmount>
                        <TotalAmount>" & ivaString & "</TotalAmount>
                    </TaxAmount>
                </Tax>
            </TaxesOutputs>
            <InvoiceTotals>
                <TotalGrossAmount>" & solucioString & "</TotalGrossAmount>
                <TotalGeneralDiscounts>0.0</TotalGeneralDiscounts>
                <TotalGeneralSurcharges>0.0</TotalGeneralSurcharges>
                <TotalGrossAmountBeforeTaxes>" & solucioString & "</TotalGrossAmountBeforeTaxes>
                <TotalTaxOutputs>" & ivaString & "</TotalTaxOutputs>
                <TotalTaxesWithheld>0.0</TotalTaxesWithheld>
                <InvoiceTotal>" & totalString & "</InvoiceTotal>
                <TotalOutstandingAmount>" & totalString & "</TotalOutstandingAmount>
                <TotalExecutableAmount>" & totalString & "</TotalExecutableAmount>
                <TotalReimbursableExpenses>0.0</TotalReimbursableExpenses>
            </InvoiceTotals>
            <Items>
                <InvoiceLine>
                    <ItemDescription>" & FacturaAcord.Text & " - " & FacturaSolucio.Text & "</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>" & solucioString & "</UnitPriceWithoutTax>
                    <TotalCost>" & solucioString & "</TotalCost>
                    <GrossAmount>" & solucioString & "</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>" & solucioString & "</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>" & ivaString & "</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>
                    <LineItemPeriod>
                        <StartDate>" & dataInici & "</StartDate>
                        <EndDate>" & dataFi & "</EndDate>
                    </LineItemPeriod>
                </InvoiceLine>
            </Items>
            <AdditionalData>
                <InvoiceAdditionalInformation>" & textFinançament & " IMPORTE SUBVENCIONADO: " & FacturaImportSubvencionat.Text & "€</InvoiceAdditionalInformation>
            </AdditionalData>
        </Invoice>
    </Invoices>
</fe:Facturae>")



    End Sub
    Private Sub PreparaArxiuPuestoSeguroPortatil()

        Dim totalString, solucioString, ivaString, subvencioString, dataInici, dataFi As String
        Dim totalDecimal, solucioDecimal, IvaDecimal, SubvencioDecimal As Decimal

        If FacturaImportSubvencionat.Text = "" Then FacturaImportSubvencionat.Text = 0
        If (FacturaImportSolucio.Text <> "") Then
            totalDecimal = FacturaImportTotal.Text
            solucioDecimal = FacturaImportSolucio.Text
            IvaDecimal = FacturaImportIVA.Text
            SubvencioDecimal = FacturaImportSubvencionat.Text
        Else
            totalDecimal = 0
            solucioDecimal = 0
            IvaDecimal = 0
            SubvencioDecimal = 0
        End If

        totalString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", totalDecimal)
        solucioString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", solucioDecimal)
        ivaString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", IvaDecimal)
        subvencioString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", SubvencioDecimal)

        dataInici = Format(FacturaData.Value.Date, "yyyy-MM-dd")
        dataFi = Format(FacturaData.Value.AddYears(1).Date, "yyyy-MM-dd")

        '
        'Texto XML
        '

        textoXML.Clear()
        textoXML.Append("<fe:Facturae xmlns:fe = ""http://www.facturae.es/Facturae/2014/v3.2.1/Facturae"" xmlns:ds = ""http://www.w3.org/2000/09/xmldsig#"">")

        'FileHeader

        textoXML.AppendLine("<FileHeader>
        <SchemaVersion>3.2.1</SchemaVersion>
        <Modality>I</Modality>
        <InvoiceIssuerType>EM</InvoiceIssuerType>
        <Batch>
            <BatchIdentifier>A0886144582208021</BatchIdentifier>
            <InvoicesCount>1</InvoicesCount>
            <TotalInvoicesAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalInvoicesAmount>
            <TotalOutstandingAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalOutstandingAmount>
            <TotalExecutableAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalExecutableAmount>
            <InvoiceCurrencyCode>EUR</InvoiceCurrencyCode>
        </Batch>
    </FileHeader>")


        ' Parties

        textoXML.AppendLine("<Parties>
        <SellerParty>
            <TaxIdentification>
                <PersonTypeCode>J</PersonTypeCode>
                <ResidenceTypeCode>R</ResidenceTypeCode>
                <TaxIdentificationNumber>B61904520</TaxIdentificationNumber>
            </TaxIdentification>
            <LegalEntity>
                <CorporateName>" & My.Settings.Empresa & "</CorporateName>
                <AddressInSpain>
                    <Address>" & My.Settings.Direccio & "</Address>
                    <PostCode>" & My.Settings.CodiPostal & "</PostCode>
                    <Town>" & My.Settings.Ciuat & "</Town>
                    <Province>" & My.Settings.Provincia & "</Province>
                    <CountryCode>ESP</CountryCode>
                </AddressInSpain>
            </LegalEntity>
        </SellerParty>
        <BuyerParty>
            <TaxIdentification>
                <PersonTypeCode>J</PersonTypeCode>
                <ResidenceTypeCode>R</ResidenceTypeCode>
                <TaxIdentificationNumber>" & EmpresaNif.Text & "</TaxIdentificationNumber>
            </TaxIdentification>
            <LegalEntity>
                <CorporateName>" & EmpresaNom.Text & "</CorporateName>
                <AddressInSpain>
                    <Address>" & EmpresaDireccio.Text & "</Address>
                    <PostCode>" & EmpresaCodiPostal.Text & "</PostCode>
                    <Town>" & EmpresaCiutat.Text & "</Town>
                    <Province>" & EmpresaProvincia.Text & "</Province>
                    <CountryCode>ESP</CountryCode>
                </AddressInSpain>
            </LegalEntity>
        </BuyerParty>
    </Parties>")

        ' Invoices

        textoXML.AppendLine(" <Invoices>
        <Invoice>
            <InvoiceHeader>
                <InvoiceNumber>" & FacturaNumero.Text & "</InvoiceNumber>
                <InvoiceSeriesCode>1</InvoiceSeriesCode>
                <InvoiceDocumentType>FC</InvoiceDocumentType>
                <InvoiceClass>OO</InvoiceClass>
            </InvoiceHeader>
            <InvoiceIssueData>
                <IssueDate>" & dataInici & "</IssueDate>
                <InvoicingPeriod>
                    <StartDate>" & dataInici & "</StartDate>
                    <EndDate>" & dataFi & "</EndDate>
                </InvoicingPeriod>
                <InvoiceCurrencyCode>EUR</InvoiceCurrencyCode>
                <TaxCurrencyCode>EUR</TaxCurrencyCode>
                <LanguageName>es</LanguageName>
            </InvoiceIssueData>
            <TaxesOutputs>
                <Tax>
                    <TaxTypeCode>01</TaxTypeCode>
                    <TaxRate>21.0</TaxRate>
                    <TaxableBase>
                        <TotalAmount>" & solucioString & "</TotalAmount>
                    </TaxableBase>
                    <TaxAmount>
                        <TotalAmount>" & ivaString & "</TotalAmount>
                    </TaxAmount>
                </Tax>
            </TaxesOutputs>
            <InvoiceTotals>
                <TotalGrossAmount>" & solucioString & "</TotalGrossAmount>
                <TotalGeneralDiscounts>0.0</TotalGeneralDiscounts>
                <TotalGeneralSurcharges>0.0</TotalGeneralSurcharges>
                <TotalGrossAmountBeforeTaxes>" & solucioString & "</TotalGrossAmountBeforeTaxes>
                <TotalTaxOutputs>" & ivaString & "</TotalTaxOutputs>
                <TotalTaxesWithheld>0.0</TotalTaxesWithheld>
                <InvoiceTotal>" & totalString & "</InvoiceTotal>
                <TotalOutstandingAmount>" & totalString & "</TotalOutstandingAmount>
                <TotalExecutableAmount>" & totalString & "</TotalExecutableAmount>
                <TotalReimbursableExpenses>0.0</TotalReimbursableExpenses>
            </InvoiceTotals>
            <Items>
                <InvoiceLine>
                    <ItemDescription>94</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>" & solucioString & "</UnitPriceWithoutTax>
                    <TotalCost>" & solucioString & "</TotalCost>
                    <GrossAmount>" & solucioString & "</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>" & solucioString & "</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>" & ivaString & "</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                    
                </InvoiceLine>
                <InvoiceLine>
                    <ItemDescription>" & FacturaAcord.Text & " - Puesto de trabajo seguro</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                   
                </InvoiceLine>
                    <InvoiceLine>
                    <ItemDescription>" & ordinador & "</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                   
                </InvoiceLine>                  
                <InvoiceLine>
                    <ItemDescription>Financiado por el Programa KIT Digital. Plan de Recuperación, Transformación y Resiliencia de España Next Generation EU. IMPORTE SUBVENCIONADO: 1000€</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                   
                </InvoiceLine>   
            </Items>
            <LegalLiterals>
                <LegalReference>Solución Kit Digital Puesto de trabajo seguro Nº de acuerdo: " & FacturaAcord.Text & " Financiado por el Programa Kit Digital. Plan de Recuperación, Transformación y Resiliencia de España Next Generation EU IMPORTE SUBVENCIONADO: 1000€</LegalReference>
            </LegalLiterals>                
        </Invoice>
    </Invoices>
</fe:Facturae>")

    End Sub
    Private Sub PreparaArxiuPuestoSeguroSobremesa()

        Dim totalString, solucioString, ivaString, subvencioString, dataInici, dataFi As String
        Dim totalDecimal, solucioDecimal, IvaDecimal, SubvencioDecimal As Decimal

        If FacturaImportSubvencionat.Text = "" Then FacturaImportSubvencionat.Text = 0
        If (FacturaImportSolucio.Text <> "") Then
            totalDecimal = FacturaImportTotal.Text
            solucioDecimal = FacturaImportSolucio.Text
            IvaDecimal = FacturaImportIVA.Text
            SubvencioDecimal = FacturaImportSubvencionat.Text
        Else
            totalDecimal = 0
            solucioDecimal = 0
            IvaDecimal = 0
            SubvencioDecimal = 0
        End If

        totalString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", totalDecimal)
        solucioString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", solucioDecimal)
        ivaString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", IvaDecimal)
        subvencioString = String.Format(Globalization.CultureInfo.InvariantCulture, "{0:F1}", SubvencioDecimal)

        dataInici = Format(FacturaData.Value.Date, "yyyy-MM-dd")
        dataFi = Format(FacturaData.Value.AddYears(1).Date, "yyyy-MM-dd")

        '
        'Texto XML
        '

        textoXML.Clear()
        textoXML.Append("<fe:Facturae xmlns:fe = ""http://www.facturae.es/Facturae/2014/v3.2.1/Facturae"" xmlns:ds = ""http://www.w3.org/2000/09/xmldsig#"">")

        'FileHeader

        textoXML.AppendLine("<FileHeader>
        <SchemaVersion>3.2.1</SchemaVersion>
        <Modality>I</Modality>
        <InvoiceIssuerType>EM</InvoiceIssuerType>
        <Batch>
            <BatchIdentifier>A0886144582208021</BatchIdentifier>
            <InvoicesCount>1</InvoicesCount>
            <TotalInvoicesAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalInvoicesAmount>
            <TotalOutstandingAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalOutstandingAmount>
            <TotalExecutableAmount>
                <TotalAmount>" & totalString & "</TotalAmount>
            </TotalExecutableAmount>
            <InvoiceCurrencyCode>EUR</InvoiceCurrencyCode>
        </Batch>
    </FileHeader>")


        ' Parties

        textoXML.AppendLine("<Parties>
        <SellerParty>
            <TaxIdentification>
                <PersonTypeCode>J</PersonTypeCode>
                <ResidenceTypeCode>R</ResidenceTypeCode>
                <TaxIdentificationNumber>B61904520</TaxIdentificationNumber>
            </TaxIdentification>
            <LegalEntity>
                <CorporateName>" & My.Settings.Empresa & "</CorporateName>
                <AddressInSpain>
                    <Address>" & My.Settings.Direccio & "</Address>
                    <PostCode>" & My.Settings.CodiPostal & "</PostCode>
                    <Town>" & My.Settings.Ciuat & "</Town>
                    <Province>" & My.Settings.Provincia & "</Province>
                    <CountryCode>ESP</CountryCode>
                </AddressInSpain>
            </LegalEntity>
        </SellerParty>
        <BuyerParty>
            <TaxIdentification>
                <PersonTypeCode>J</PersonTypeCode>
                <ResidenceTypeCode>R</ResidenceTypeCode>
                <TaxIdentificationNumber>" & EmpresaNif.Text & "</TaxIdentificationNumber>
            </TaxIdentification>
            <LegalEntity>
                <CorporateName>" & EmpresaNom.Text & "</CorporateName>
                <AddressInSpain>
                    <Address>" & EmpresaDireccio.Text & "</Address>
                    <PostCode>" & EmpresaCodiPostal.Text & "</PostCode>
                    <Town>" & EmpresaCiutat.Text & "</Town>
                    <Province>" & EmpresaProvincia.Text & "</Province>
                    <CountryCode>ESP</CountryCode>
                </AddressInSpain>
            </LegalEntity>
        </BuyerParty>
    </Parties>")

        ' Invoices

        textoXML.AppendLine(" <Invoices>
        <Invoice>
            <InvoiceHeader>
                <InvoiceNumber>" & FacturaNumero.Text & "</InvoiceNumber>
                <InvoiceSeriesCode>1</InvoiceSeriesCode>
                <InvoiceDocumentType>FC</InvoiceDocumentType>
                <InvoiceClass>OO</InvoiceClass>
            </InvoiceHeader>
            <InvoiceIssueData>
                <IssueDate>" & dataInici & "</IssueDate>
                <InvoicingPeriod>
                    <StartDate>" & dataInici & "</StartDate>
                    <EndDate>" & dataFi & "</EndDate>
                </InvoicingPeriod>
                <InvoiceCurrencyCode>EUR</InvoiceCurrencyCode>
                <TaxCurrencyCode>EUR</TaxCurrencyCode>
                <LanguageName>es</LanguageName>
            </InvoiceIssueData>
            <TaxesOutputs>
                <Tax>
                    <TaxTypeCode>01</TaxTypeCode>
                    <TaxRate>21.0</TaxRate>
                    <TaxableBase>
                        <TotalAmount>" & solucioString & "</TotalAmount>
                    </TaxableBase>
                    <TaxAmount>
                        <TotalAmount>" & ivaString & "</TotalAmount>
                    </TaxAmount>
                </Tax>
            </TaxesOutputs>
            <InvoiceTotals>
                <TotalGrossAmount>" & solucioString & "</TotalGrossAmount>
                <TotalGeneralDiscounts>0.0</TotalGeneralDiscounts>
                <TotalGeneralSurcharges>0.0</TotalGeneralSurcharges>
                <TotalGrossAmountBeforeTaxes>" & solucioString & "</TotalGrossAmountBeforeTaxes>
                <TotalTaxOutputs>" & ivaString & "</TotalTaxOutputs>
                <TotalTaxesWithheld>0.0</TotalTaxesWithheld>
                <InvoiceTotal>" & totalString & "</InvoiceTotal>
                <TotalOutstandingAmount>" & totalString & "</TotalOutstandingAmount>
                <TotalExecutableAmount>" & totalString & "</TotalExecutableAmount>
                <TotalReimbursableExpenses>0.0</TotalReimbursableExpenses>
            </InvoiceTotals>
            <Items>
                <InvoiceLine>
                    <ItemDescription>94</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>" & solucioString & "</UnitPriceWithoutTax>
                    <TotalCost>" & solucioString & "</TotalCost>
                    <GrossAmount>" & solucioString & "</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>" & solucioString & "</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>" & ivaString & "</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                    
                </InvoiceLine>
                <InvoiceLine>
                    <ItemDescription>" & FacturaAcord.Text & " - Puesto de trabajo seguro</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                    
                </InvoiceLine>
                     <InvoiceLine>
                    <ItemDescription>Financiado por el Programa KIT Digital. Plan de Recuperación, Transformación y Resiliencia de España Next Generation EU. IMPORTE SUBVENCIONADO: 1000€</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                   
                </InvoiceLine>   
                <InvoiceLine>
                    <ItemDescription>" & ordinador & "</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                   
                </InvoiceLine>
                    <InvoiceLine>
                    <ItemDescription>" & monitor & "</ItemDescription>
                    <Quantity>1</Quantity>
                    <UnitOfMeasure>01</UnitOfMeasure>
                    <UnitPriceWithoutTax>0</UnitPriceWithoutTax>
                    <TotalCost>0</TotalCost>
                    <GrossAmount>0</GrossAmount>
                    <TaxesOutputs>
                        <Tax>
                            <TaxTypeCode>01</TaxTypeCode>
                            <TaxRate>21</TaxRate>
                            <TaxableBase>
                                <TotalAmount>0</TotalAmount>
                            </TaxableBase>
                            <TaxAmount>
                                <TotalAmount>0</TotalAmount>
                            </TaxAmount>
                        </Tax>
                    </TaxesOutputs>                   
                </InvoiceLine>                  
               
            </Items>
            <LegalLiterals>
                <LegalReference>Solución Kit Digital Puesto de trabajo seguro Nº de acuerdo: " & FacturaAcord.Text & " Financiado por el Programa Kit Digital. Plan de Recuperación, Transformación y Resiliencia de España Next Generation EU IMPORTE SUBVENCIONADO: 1000€</LegalReference>
            </LegalLiterals>                
        </Invoice>
    </Invoices>
</fe:Facturae>")

    End Sub


    'Crea l'arxiu
    Private Sub CreaArxiu()

        Try

            Dim saveFileDialog As New SaveFileDialog
            Dim path, filename As String
            Dim escritor As StreamWriter

            filename = "Factura XML " & EmpresaNom.Text & ".xml"
            saveFileDialog.Title = "Guardar Factura XML"
            saveFileDialog.Filter = "XML (*.xml)|*.xml"
            saveFileDialog.FileName = filename

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                path = IO.Path.GetFullPath(saveFileDialog.FileName)
                escritor = File.AppendText(path)
                escritor.Write(textoXML)
                escritor.Flush()
                escritor.Close()
                MessageBox.Show("S'ha guardat la factura amb éxit")
            End If

        Catch ex As Exception
            MessageBox.Show("No s'ha pogut guardar la factura")
        End Try

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        textoXML.Clear()

        If ComprovaDades() = True Then
            If FacturaSolucio.Text = "Puesto de trabajo seguro" Then
                If monitor = "" Then
                    PreparaArxiuPuestoSeguroPortatil()
                Else
                    PreparaArxiuPuestoSeguroSobremesa()
                End If

            Else
                PreparaArxiu()
            End If

            CreaArxiu()
        End If
    End Sub
    Private Sub Visualitzar_Click(sender As Object, e As EventArgs) Handles Btn_Visualitzar.Click
        textoXML.Clear()

        If FacturaSolucio.Text = "Puesto de trabajo seguro" Then
            If monitor = "" Then
                PreparaArxiuPuestoSeguroPortatil()
            Else
                PreparaArxiuPuestoSeguroSobremesa()
            End If

        Else
            PreparaArxiu()
        End If

        Dim vistaPrevia As New VistaPrevia(textoXML)
        OpenSubForm(vistaPrevia)
    End Sub
    Private Sub EsborraDades(v As Integer)

        Select Case v
            'Bloc empresa
            Case 1 ' Esborrar tot
                CB_Empreses.Text = "Selecciona empresa"
                EmpresaNom.Clear()
                EmpresaNif.Clear()
                EmpresaDireccio.Clear()
                EmpresaCodiPostal.Clear()
                EmpresaCiutat.Clear()
                EmpresaProvincia.Clear()
                EmpresaPais.Clear()
                'Bloc solucio
                CB_Solucions.Text = ""
                CB_Solucions.DataSource = Nothing
                FacturaNumero.Clear()
                FacturaAcord.Clear()
                FacturaImportSolucio.Clear()
                FacturaImportIVA.Clear()
                FacturaImportTotal.Clear()
                FacturaImportSubvencionat.Clear()
                FacturaSolucio.Text = ""
                FacturaData.Value = Date.Now
                'Bloc declaració
                TB_DataCobrament.Clear()
                TB_DataFactura.Clear()
                TB_Rao.Clear()
                TB_Nif.Clear()
                TB_NoAcord.Clear()
                TB_NoFactura.Clear()
                TB_ImportFactura.Clear()
                TB_ImportAbonat.Clear()
            Case 2 ' Empresa seleccionada
                'Bloc solucio
                CB_Solucions.Text = ""
                CB_Solucions.DataSource = Nothing
                FacturaNumero.Clear()
                FacturaAcord.Clear()
                FacturaImportSolucio.Clear()
                FacturaImportIVA.Clear()
                FacturaImportTotal.Clear()
                FacturaImportSubvencionat.Clear()
                FacturaSolucio.Text = ""
                FacturaData.Value = Date.Now
                'Bloc declaració
                TB_DataCobrament.Clear()
                TB_DataFactura.Clear()
                TB_Rao.Clear()
                TB_Nif.Clear()
                TB_NoAcord.Clear()
                TB_NoFactura.Clear()
                TB_ImportFactura.Clear()
                TB_ImportAbonat.Clear()
            Case 3 'Solucio seleccionada
                'Bloc Factura
                FacturaNumero.Clear()
                FacturaAcord.Clear()
                FacturaImportSolucio.Clear()
                FacturaImportIVA.Clear()
                FacturaImportTotal.Clear()
                FacturaImportSubvencionat.Clear()
                FacturaSolucio.Text = ""
                FacturaData.Value = Date.Now
                'Bloc declaració
                TB_DataCobrament.Clear()
                TB_DataFactura.Clear()
                TB_NoAcord.Clear()
                TB_NoFactura.Clear()
                TB_ImportFactura.Clear()
                TB_ImportAbonat.Clear()
        End Select

    End Sub
    'Comprova que les dades introduides son correctes
    Private Function ComprovaDades() As Boolean
        For Each control As Windows.Forms.Control In Me.Controls
            If TypeOf control Is GroupBox Then
                For Each controlText As Windows.Forms.Control In Me.GroupBox2.Controls
                    If TypeOf controlText Is TextBox Then
                        If (controlText.Text = "") Then
                            controlText.Select()
                            MsgBox("Et falten dades per introduir", vbExclamation, "No es pot crear l'arxiu")
                            Return False

                        End If
                    End If
                Next

                For Each controlText As Windows.Forms.Control In Me.GroupBox1.Controls
                    If TypeOf controlText Is TextBox Then
                        If (controlText.Text = "") Then
                            controlText.Select()
                            Return False
                        End If
                    End If
                Next
            End If
        Next
        Return True
    End Function



    Private Sub CB_Empreses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Empreses.SelectionChangeCommitted
        EsborraDades(2)
        Dim row As DataRowView = DirectCast(CB_Empreses.SelectedItem, DataRowView)
        EmpresaNom.Text = row.Item("Nom").ToString
        EmpresaNif.Text = row.Item("Nif").ToString
        EmpresaCiutat.Text = row.Item("Ciutat").ToString
        EmpresaDireccio.Text = row.Item("Direccio").ToString
        EmpresaCodiPostal.Text = row.Item("CodiPostal").ToString
        EmpresaProvincia.Text = row.Item("Provincia").ToString
        EmpresaPais.Text = row.Item("Pais").ToString
        Vigila.Visible = False
        CarregaSolucions(CB_Empreses.SelectedValue)
    End Sub
    Private Sub CB_Solucions_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Solucions.SelectionChangeCommitted
        Dim row As DataRowView = DirectCast(CB_Solucions.SelectedItem, DataRowView)
        EsborraDades(3)
        FacturaAcord.Text = row.Item("Contracte").ToString
        FacturaSolucio.Text = row.Item("Nom").ToString
        FacturaImportSolucio.Text = row.Item("TotalSolucio")
        FacturaImportSubvencionat.Text = row.Item("Subvencio").ToString
        FacturaNumero.Text = row.Item("Factura")
        TB_DataCobrament.Text = Format(row.Item("DataPagament"), "short date")
        tipusSolucio = row.Item("Nom").ToString
        monitor = row.Item("Monitor")
        ordinador = row.Item("FabricantSolucio")

        Debug.WriteLine(monitor & " - " & ordinador)

        If row.Item("DataFactura") <> "" Then
            FacturaData.Value = row.Item("DataFactura")
        Else
            FacturaData.Value = Now.Date
        End If

        If row.Item("Percentatge") <> 100 Then
            Vigila.Visible = True
        Else
            Vigila.Visible = False
        End If

    End Sub
    'Carrega les dades de la solucio rebuda per Id de la empresa
    Private Sub CarregaSolucions(id As Integer)

        Dim conexion As New SQLiteConnection()
        Try
            conexion = New SQLiteConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                DT_Solucions.Clear()
                Dim Sql As String = "SELECT Solucions.idSolucio,
                                            Solucions.IdEmpresa,
                                            TipusSolucions.Nom,
                                            Solucions.Contracte,
                                            Solucions.DataFactura,
                                            Solucions.DataPagament,
                                            Justificacions.TotalSolucio,
                                            Justificacions.Percentatge,
                                            Justificacions.Subvencio,
                                            Justificacions.Factura,
                                            Justificacions.Monitor,
                                            Justificacions.FabricantSolucio
                                     FROM Solucions
                                     INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                     INNER JOIN Justificacions ON Solucions.Id= Justificacions.idSolucio  
                                     WHERE idEmpresa=" & id
                Dim DA_Solucions As New SQLiteDataAdapter(Sql, conexion)
                DA_Solucions.Fill(DT_Solucions)
                CB_Solucions.DataSource = DT_Solucions
                CB_Solucions.DisplayMember = "Nom"
                CB_Solucions.Text = "Selecciona solució"
                If DT_Solucions.Rows.Count = 0 Then CB_Solucions.Text = "No hi ha solucions"
            End If

        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions desde la base de dades",, "Error")
        End Try
        conexion.Close()
    End Sub

    Private Sub EmpresaNom_TextChanged(sender As Object, e As EventArgs) Handles EmpresaNom.TextChanged
        TB_Rao.Text = EmpresaNom.Text
    End Sub

    Private Sub EmpresaNif_TextChanged(sender As Object, e As EventArgs) Handles EmpresaNif.TextChanged
        TB_Nif.Text = EmpresaNif.Text
    End Sub

    Private Sub CopiarRaoSocial_Click(sender As Object, e As EventArgs) Handles CopiarRaoSocial.Click
        If TB_Rao.Text <> "" Then My.Computer.Clipboard.SetText(TB_Rao.Text)
    End Sub

    Private Sub CopiarNif_Click(sender As Object, e As EventArgs) Handles CopiarNif.Click
        If TB_Nif.Text <> "" Then My.Computer.Clipboard.SetText(TB_Nif.Text)
    End Sub

    Private Sub CopiarNoAcord_Click(sender As Object, e As EventArgs) Handles CopiarNoAcord.Click
        If TB_NoAcord.Text <> "" Then My.Computer.Clipboard.SetText(TB_NoAcord.Text)
    End Sub

    Private Sub CopiarDataFactura_Click(sender As Object, e As EventArgs) Handles CopiarDataFactura.Click
        If TB_DataFactura.Text <> "" Then My.Computer.Clipboard.SetText(TB_DataFactura.Text)
    End Sub

    Private Sub CopiarNoFactura_Click(sender As Object, e As EventArgs) Handles CopiarNoFactura.Click
        If TB_NoFactura.Text <> "" Then My.Computer.Clipboard.SetText(TB_NoFactura.Text)
    End Sub

    Private Sub CopiarImportFactura_Click(sender As Object, e As EventArgs) Handles CopiarImportFactura.Click
        If TB_ImportFactura.Text <> "" Then My.Computer.Clipboard.SetText(TB_ImportFactura.Text)
    End Sub

    Private Sub CopiarImportAbonat_Click(sender As Object, e As EventArgs) Handles CopiarImportAbonat.Click
        If TB_ImportAbonat.Text <> "" Then My.Computer.Clipboard.SetText(TB_ImportAbonat.Text)
    End Sub

    Private Sub CopiarDataCobrament_Click(sender As Object, e As EventArgs) Handles CopiarDataCobrament.Click
        If TB_DataCobrament.Text <> "" Then My.Computer.Clipboard.SetText(TB_DataCobrament.Text)
    End Sub

    Private Sub FacturaAcord_TextChanged(sender As Object, e As EventArgs) Handles FacturaAcord.TextChanged
        TB_NoAcord.Text = FacturaAcord.Text
    End Sub

    Private Sub FacturaData_ValueChanged(sender As Object, e As EventArgs) Handles FacturaData.ValueChanged
        TB_DataFactura.Text = Format(FacturaData.Value.Date, "dd/MM/yyyy")
    End Sub

    Private Sub FacturaNumero_TextChanged(sender As Object, e As EventArgs) Handles FacturaNumero.TextChanged
        TB_NoFactura.Text = FacturaNumero.Text
    End Sub

    Private Sub FacturaImportIVA_TextChanged(sender As Object, e As EventArgs) Handles FacturaImportIVA.TextChanged
        TB_ImportAbonat.Text = FacturaImportIVA.Text
    End Sub

    Private Sub Btn_EsborraDades_Click(sender As Object, e As EventArgs) Handles Btn_EsborraDades.Click
        EsborraDades(1)
    End Sub

    Private Sub CB_Solucions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Solucions.SelectedIndexChanged

    End Sub
End Class