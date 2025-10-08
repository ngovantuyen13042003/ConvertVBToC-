// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼ˆóŠÓƒ}ƒXƒ^XV(ABAtenaInkanupBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/11/11@‹gàV@sé
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/03/26 000001     ƒrƒWƒlƒXID‚Ì•ÏXC³ 
// * 2007/03/16 000002     ƒGƒ‰[‚ðŽæ“¾‚·‚éŒÂŠ‚Ì•ÏX‚ÆABLOG‚Ö‘‚«ž‚Þˆ—‚Ì’Ç‰Á(‚Œ´)
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{


    public class ABAtenaInkanupBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfABConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^AB
        private UFConfigDataClass m_cfAAConfigDataClass;       // ƒRƒ“ƒtƒBƒOƒf[ƒ^AA
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private string m_strRsBusiId;

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaInkanupBClass";
        private const string AA_BUSSINESS_ID = "AA";            // ‹Æ–±ƒR[ƒh

        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData As UFControlData,
        // * @@                           ByVal cfConfigDataClass As UFConfigDataClass,
        // * @@                           ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@            cfConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * @@            cfRdbClass As UFRdbClass               : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABAtenaInkanupBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            UFConfigDataClass cfAAUFConfigData;
            UFConfigClass cfAAUFConfigClass;

            // ƒRƒ“ƒtƒBƒOƒf[ƒ^‚Ì"AA"‚ÌŠÂ‹«î•ñ‚ðŽæ“¾
            cfAAUFConfigClass = new UFConfigClass();
            cfAAUFConfigData = cfAAUFConfigClass.GetConfig(AA_BUSSINESS_ID);
            m_cfAAConfigDataClass = cfAAUFConfigData;

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfABConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfABConfigDataClass, m_cfControlData.m_strBusinessId);

            // Žó‚¯Žæ‚Á‚½ƒrƒWƒlƒXID‚ðƒƒ“ƒo‚Ö•Û‘¶
            m_strRsBusiId = m_cfControlData.m_strBusinessId;

            // *—š—ð”Ô† 000001 2004/03/26 íœŠJŽn
            // '‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
            // m_cfControlData.m_strBusinessId = "AB"
            // *—š—ð”Ô† 000001 2004/03/26 íœI—¹

        }

        #endregion

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ˆóŠÓƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateAtenaInkan(ByVal cABKobetsuProperty As ABKobetsuInkanProperty) As Integer
        // * 
        // * ‹@”\@@    @  ˆ¶–¼ˆóŠÓƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateAtenaInkan(ABKobetsuInkanProperty[] cABKobetsuProperty)
        {
            const string THIS_METHOD_NAME = "UpdateAtenaInkan";
            int intUpdCnt;
            ABAtenaInkanBClass cABAtenaInkanBClass;
            localhost.AAKOBETSUINKANParamClass[] cAAKOBETSUINKANParamClass;
            localhost.AACommonBSClass cAACommonBSClass;
            DataSet csABAtenaInkanEntity;
            DataRow cDatRow;
            string strControlData;
            var cUSSCItyInfo = new USSCityInfoClass();
            var cfErrorClass = default(UFErrorClass);                    // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFAppException csAppExp;
            var intcnt = default(int);

            try
            {

                // *—š—ð”Ô† 000001 2004/03/26 ’Ç‰ÁŠJŽn
                // ‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
                m_cfControlData.m_strBusinessId = "AB";
                // *—š—ð”Ô† 000001 2004/03/26 ’Ç‰ÁI—¹

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // Žs’¬‘ºî•ñŽæ“¾iŽs’¬‘ºƒR[ƒh)
                cUSSCItyInfo.GetCityInfo(m_cfControlData);

                // ˆ¶–¼ˆóŠÓ‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaInkanBClass = new ABAtenaInkanBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass);

                try
                {
                    var loopTo = cABKobetsuProperty.Length - 1;
                    for (intcnt = 0; intcnt <= loopTo; intcnt++)
                    {

                        // ˆ¶–¼ˆóŠÓƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
                        csABAtenaInkanEntity = cABAtenaInkanBClass.GetAtenaInkan((string)cABKobetsuProperty[intcnt].p_strJUMINCD);

                        // ’Ç‰ÁEXV‚Ì”»’è
                        if (csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).Rows.Count == 0)
                        {

                            cDatRow = csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).NewRow();
                            // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                            cDatRow.Item(ABAtenaInkanEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                            cDatRow.Item(ABAtenaInkanEntity.INKANNO) = cABKobetsuProperty[intcnt].p_strINKANNO;
                            cDatRow.Item(ABAtenaInkanEntity.INKANTOROKUKB) = cABKobetsuProperty[intcnt].p_strINKANTOROKUKB;

                            // Žs’¬‘ºƒR[ƒh
                            cDatRow.Item(ABAtenaInkanEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                            // ‹ŒŽs’¬‘ºƒR[ƒh
                            cDatRow.Item(ABAtenaInkanEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                            // ƒf[ƒ^‚Ì’Ç‰Á
                            // csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).Rows.Add(cDatRow)

                            // ˆ¶–¼ˆóŠÓƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
                            intUpdCnt = cABAtenaInkanBClass.InsertAtenaInkan(cDatRow);
                        }
                        else
                        {

                            cDatRow = csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).Rows(0);
                            // Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
                            cDatRow.Item(ABAtenaInkanEntity.JUMINCD) = cABKobetsuProperty[intcnt].p_strJUMINCD;
                            cDatRow.Item(ABAtenaInkanEntity.INKANNO) = cABKobetsuProperty[intcnt].p_strINKANNO;
                            cDatRow.Item(ABAtenaInkanEntity.INKANTOROKUKB) = cABKobetsuProperty[intcnt].p_strINKANTOROKUKB;

                            // Žs’¬‘ºƒR[ƒh
                            cDatRow.Item(ABAtenaInkanEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);
                            // ‹ŒŽs’¬‘ºƒR[ƒh
                            cDatRow.Item(ABAtenaInkanEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0);

                            // ˆ¶–¼ˆóŠÓƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
                            intUpdCnt = cABAtenaInkanBClass.UpdateAtenaInkan(cDatRow);
                        }

                        // ’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ˆ¶–¼‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                        if (intUpdCnt == 0)
                        {

                            cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                            // ƒGƒ‰[’è‹`‚ðŽæ“¾
                            objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003004);
                            // —áŠO‚ð¶¬
                            csAppExp = new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                            throw csAppExp;
                        }

                    }
                }

                // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁŠJŽn
                catch (UFAppException exAppExp)                   // UFAppException‚ðƒLƒƒƒbƒ`
                {
                    // ¦’Êí‚ÌƒGƒ‰[‚ðƒƒOƒtƒ@ƒCƒ‹‚É‘‚«ž‚Ý
                    // ƒ[ƒjƒ“ƒOƒƒOo—Í
                    m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
      /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
       Parameter name: length
          at System.String.Substring(Int32 startIndex, Int32 length)
          at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
          at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
          at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
       --- End of stack trace from previous location where exception was thrown ---
          at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
          at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

       Input:
       "yƒ[ƒjƒ“
        */
        );
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9397


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9494


                                        Input:
                                        " + exAppExp.Message + "z")

                                                        ' ¦ƒƒOƒtƒ@ƒCƒ‹‘‚«ž‚ÝŒãA˜AŒgƒGƒ‰[—pƒƒbƒZ[ƒW‚ðì¬
                                                        cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾

                                         */
                    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003004);
                    // ¦ABLOG‚Ö‘‚«ž‚Ý
                    SetABLOG(cUSSCItyInfo.p_strShichosonCD(0), "ABKOB", "AC", "ŒÂ•Ê‹LÚXViˆóŠÓj", cABKobetsuProperty[intcnt].p_strJUMINCD, objErrorStruct.m_strErrorMessage);

                    throw exAppExp;
                }
                catch (Exception exExp)                           // Exception‚ðƒLƒƒƒbƒ`
                {
                    // ¦’Êí‚ÌƒGƒ‰[‚ðƒƒOƒtƒ@ƒCƒ‹‚É‘‚«ž‚Ý
                    // ƒGƒ‰[ƒƒOo—Í
                    m_cfLogClass.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                       /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                         Parameter name: length
                                            at System.String.Substring(Int32 startIndex, Int32 length)
                                            at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                            at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                            at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                         --- End of stack trace from previous location where exception was thrown ---
                                            at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                            at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                         Input:
                                         "yƒGƒ‰[“
                                          */
                         );
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10594


                                        Input:
                                        " + exExp.Message + "z")
                                                        ' ¦ƒƒOƒtƒ@ƒCƒ‹‘‚«ž‚ÝŒãA˜AŒgƒGƒ‰[—pƒƒbƒZ[ƒW‚ðì¬
                                                        cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
                                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾

                                         */
                    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003004);
                    // ¦ABLOG‚Ö‘‚«ž‚Ý
                    SetABLOG(cUSSCItyInfo.p_strShichosonCD(0), "ABKOB", "AC", "ŒÂ•Ê‹LÚXViˆóŠÓj", cABKobetsuProperty[intcnt].p_strJUMINCD, objErrorStruct.m_strErrorMessage);

                    throw exExp;
                }
                // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁI—¹


                try
                {
                    // Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
                    cAACommonBSClass = new localhost.AACommonBSClass();
                    cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx";
                    // cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

                    cAAKOBETSUINKANParamClass = new localhost.AAKOBETSUINKANParamClass[cABKobetsuProperty.Length];

                    var loopTo1 = cABKobetsuProperty.Length - 1;
                    for (intcnt = 0; intcnt <= loopTo1; intcnt++)
                    {

                        // ŒÂ•ÊˆóŠÓƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cAAKOBETSUINKANParamClass[intcnt] = new localhost.AAKOBETSUINKANParamClass();

                        // XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
                        cAAKOBETSUINKANParamClass[intcnt].m_strJUMINCD = (string)cABKobetsuProperty[intcnt].p_strJUMINCD;
                        cAAKOBETSUINKANParamClass[intcnt].m_strINKANNO = (string)cABKobetsuProperty[intcnt].p_strINKANNO;
                        cAAKOBETSUINKANParamClass[intcnt].m_strINKANTOROKUKB = (string)cABKobetsuProperty[intcnt].p_strINKANTOROKUKB;
                    }

                    // ZŠîŒÂ•ÊˆóŠÓXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
                    strControlData = UFControlToolClass.ControlGetStr(m_cfControlData);
                    intUpdCnt = cAACommonBSClass.UpdateKBINKAN(strControlData, cAAKOBETSUINKANParamClass);

                    // ’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
                    if (!(intUpdCnt == cABKobetsuProperty.Length))
                    {

                        cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002);
                        // —áŠO‚ð¶¬
                        csAppExp = new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                        throw csAppExp;

                    }
                }

                catch (Global.System.Web.Services.Protocols.SoapException objSoapExp)             // SoapException‚ðƒLƒƒƒbƒ`
                {
                    // OuterXml‚ÉƒGƒ‰[“à—e‚ªŠi”[‚µ‚Ä‚ ‚éB
                    var objExpTool = new UFExceptionTool(objSoapExp.Detail.OuterXml);
                    var objErr = default(UFErrorStruct);

                    // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚©‚Ç‚¤‚©‚Ì”»’è
                    if (objExpTool.IsAppException == true)
                    {
                        // ƒ[ƒjƒ“ƒOƒƒOo—Í
                        m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                       /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                         Parameter name: length
                                            at System.String.Substring(Int32 startIndex, Int32 length)
                                            at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                            at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                            at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                         --- End of stack trace from previous location where exception was thrown ---
                                            at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                            at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                         Input:
                                         "yƒ[ƒjƒ“
                                          */
                         );
                        ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14097


                        Input:
                        " + objExpTool.p_strErrorCode + "z" + _
                                                                    "yƒ[ƒjƒ“ƒO“à—e:
                         */
                        ;

                        // ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14200


                                                Input:
                                                " + objExpTool.p_strErrorMessage + "z")

                                                                    ' •t‰ÁƒƒbƒZ[ƒW‚ðì¬‚·‚é
                                                                    Dim strExtMsg As String = "<P>‘ÎÛZ–¯‚ÌƒŠƒJƒoƒŠˆ—‚ðs‚Á‚Ä‚­‚¾‚³‚¢B<BR>"

                                                 */
                        UFAppException objAppExp;
                        objAppExp = new UFAppException(objExpTool.p_strErrorMessage + strExtMsg, objExpTool.p_strErrorCode);

                        // Šg’£—Ìˆæ‚ÌƒƒbƒZ[ƒW‚É‚à•t‰ÁiŽÀÛ‚É‚Í‚±‚±‚ÌƒƒbƒZ[ƒW‚ª•\Ž¦‚³‚ê‚éj
                        UFErrorToolClass.ErrorStructSetStr(objErr, objExpTool.p_strExt);
                        objErr.m_strErrorMessage += strExtMsg;
                        objAppExp.p_strExt = UFErrorToolClass.ErrorStructGetStr(objErr);
                        // ƒƒbƒZ[ƒW‚ð•t‰Á‚µ‚È‚¢ê‡‚ÍˆÈ‰º
                        // objAppExp.p_strExt = objExpTool.p_strExt
                        // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁŠJŽn
                        // ¦ƒƒOƒtƒ@ƒCƒ‹‘‚«ž‚ÝŒãA˜AŒgƒGƒ‰[—pƒƒbƒZ[ƒW‚ðì¬
                        cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002);
                        // ¦ABLOG‚Ö‘‚«ž‚Ý
                        // ¦@’@¦@ˆø”‚ÅZ–¯ƒR[ƒh‚ð“n‚·ŒÂŠ‚Å‚·‚ªAcABKobetsuProperty‚ª•¡”‚Å‚ ‚Á‚Ä‚à
                        // @@@@@@‚`‚`‚©‚ç–ß‚Á‚Ä‚«‚½ƒGƒ‰[‚Å‚Í‰½”Ô–Ú‚Å—Ž‚¿‚½‚©”»’f‚Å‚«‚È‚¢‚Ì‚ÅAˆÈ‰ºŒÅ’è‚ÅIndex(0)‚ð“n‚µ‚Ü‚·B
                        SetABLOG(cUSSCItyInfo.p_strShichosonCD(0), "ABKOB", "AC", "ŒÂ•Ê‹LÚXViˆóŠÓj", cABKobetsuProperty[0].p_strJUMINCD, objErrorStruct.m_strErrorMessage);
                        // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁI—¹

                        throw objAppExp;
                    }
                    else
                    {
                        // ƒVƒXƒeƒ€—áŠO‚Ìê‡
                        // ƒGƒ‰[ƒƒOo—Í
                        m_cfLogClass.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                           /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                                 Parameter name: length
                                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                                 --- End of stack trace from previous location where exception was thrown ---
                                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                                 Input:
                                                 "yƒGƒ‰[“
                                                  */
                             );
                        ;
                        // ¦ƒƒOƒtƒ@ƒCƒ‹‘‚«ž‚ÝŒãA˜AŒgƒGƒ‰[—pƒƒbƒZ[ƒW‚ðì¬
#error Cannot convert EmptyStatementSyntax - see comment for details
                        /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 16407


                                                Input:
                                                " + objExpTool.p_strErrorMessage + "z")

                                                                    '*—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁŠJŽn

                                                 */
                        cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾
                        objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002);
                        // ¦ABLOG‚Ö‘‚«ž‚Ý
                        SetABLOG(cUSSCItyInfo.p_strShichosonCD(0), "ABKOB", "AC", "ŒÂ•Ê‹LÚXViˆóŠÓj", cABKobetsuProperty[0].p_strJUMINCD, objErrorStruct.m_strErrorMessage);
                        // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁI—¹
                        throw objSoapExp;
                    }
                }
                catch (UFAppException exAppExp)                   // UFAppException‚ðƒLƒƒƒbƒ`
                {
                    // ƒ[ƒjƒ“ƒOƒƒOo—Í
                    m_cfLogClass.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                           /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                                 Parameter name: length
                                                    at System.String.Substring(Int32 startIndex, Int32 length)
                                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                                    at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                                    at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                                 --- End of stack trace from previous location where exception was thrown ---
                                                    at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                                    at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                                 Input:
                                                 "yƒ[ƒjƒ“
                                                  */
                             );
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17635


                    Input:
                    " + exAppExp.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
                    // ¦ƒƒOƒtƒ@ƒCƒ‹‘‚«ž‚ÝŒãA˜AŒgƒGƒ‰[—pƒƒbƒZ[ƒW‚ðì¬
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17732


                                        Input:
                                        " + exAppExp.Message + "z")

                                                        '*—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁŠJŽn

                                         */
                    cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002);
                    // ¦ABLOG‚Ö‘‚«ž‚Ý
                    SetABLOG(cUSSCItyInfo.p_strShichosonCD(0), "ABKOB", "AC", "ŒÂ•Ê‹LÚXViˆóŠÓj", cABKobetsuProperty[0].p_strJUMINCD, objErrorStruct.m_strErrorMessage);
                    // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁI—¹

                    throw exAppExp;
                }
                catch (Exception exExp)                           // Exception‚ðƒLƒƒƒbƒ`
                {
                    // ƒGƒ‰[ƒƒOo—Í
                    m_cfLogClass.ErrorWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


#error Cannot convert LiteralExpressionSyntax - see comment for details
                       /* Cannot convert LiteralExpressionSyntax, System.ArgumentOutOfRangeException: Length cannot be less than zero.
                                         Parameter name: length
                                            at System.String.Substring(Int32 startIndex, Int32 length)
                                            at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetQuotedStringTextForUser(String textForUser, String valueTextForCompiler)
                                            at ICSharpCode.CodeConverter.CSharp.LiteralConversions.GetLiteralExpression(Object value, String textForUser, ITypeSymbol convertedType)
                                            at ICSharpCode.CodeConverter.CSharp.ExpressionNodeVisitor.<VisitLiteralExpression>d__43.MoveNext()
                                         --- End of stack trace from previous location where exception was thrown ---
                                            at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
                                            at ICSharpCode.CodeConverter.CSharp.CommentConvertingVisitorWrapper.<ConvertHandledAsync>d__12`1.MoveNext()

                                         Input:
                                         "yƒGƒ‰[“
                                          */
                         );
                    ;
                    // ¦ƒƒOƒtƒ@ƒCƒ‹‘‚«ž‚ÝŒãA˜AŒgƒGƒ‰[—pƒƒbƒZ[ƒW‚ðì¬
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18881


                                        Input:
                                        " + exExp.Message + "z")

                                                        '*—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁŠJŽn

                                         */
                    cfErrorClass = new UFErrorClass(m_cfControlData.m_strBusinessId);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002);
                    // ¦ABLOG‚Ö‘‚«ž‚Ý
                    SetABLOG(cUSSCItyInfo.p_strShichosonCD(0), "ABKOB", "AC", "ŒÂ•Ê‹LÚXViˆóŠÓj", cABKobetsuProperty[0].p_strJUMINCD, objErrorStruct.m_strErrorMessage);
                    // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁI—¹

                    throw exExp;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                // Œ³‚ÌƒrƒWƒlƒXID‚ð“ü‚ê‚é
                m_cfControlData.m_strBusinessId = m_strRsBusiId;
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

            }

            return intUpdCnt;

        }

        // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁŠJŽn
        #region ˆ¶–¼XVƒGƒ‰[ƒƒOSET
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼XVƒGƒ‰[ƒƒOSETˆ—
        // * 
        // * \•¶           SetABLOG(ByVal strShichosonCD As String, _
        // * @@                    ByVal strShoriID As String, _
        // * @@                    ByVal strShoriShu As String, _
        // * @@                    ByVal strBasho As String, _
        // * @@                    ByVal strJuminCD As String, _
        // * @@                    ByVal strErrMsg As String)
        // * 
        // * ‹@”\           ABLOG—pƒGƒ‰[ƒƒbƒZ[ƒW‚ðSET‚·‚é
        // * 
        // * ˆø”           ByVal strShichosonCD As String : Žs’¬‘ºƒR[ƒh
        // * @@           ByVal strShoriID as string     : ˆ—‚h‚c
        // * @@           ByVal strShoriShu As String    : ˆ—Ží•Ê
        // * @@           ByVal strBasho As String       : ƒGƒ‰[”­¶êŠ
        // * @@           ByVal strJuminCD As String     : ŠY“–Z–¯ƒR[ƒh
        // * @@           ByVal strErrMsg As String      : ƒGƒ‰[ƒƒbƒZ[ƒW
        // * 
        // * –ß‚è’l         Dim intCnt As Integer          : ƒGƒ‰[’Ç‰ÁŒ”
        // ************************************************************************************************
        private int SetABLOG(string strShichosonCD, string strShoriID, string strShoriShu, string strBasho, string strJuminCD, string strErrMsg)




        {
            ABErrLogBClass cABErrLog;
            ABErrLogXClass cABErrLogPrm;
            int intCnt;

            cABErrLog = new ABErrLogBClass(m_cfControlData, m_cfABConfigDataClass);
            cABErrLogPrm = new ABErrLogXClass();

            // ŠeŽí€–Ú‚ðƒpƒ‰ƒ[ƒ^‚ÉƒZƒbƒg
            cABErrLogPrm.p_strShichosonCD = strShichosonCD;
            cABErrLogPrm.p_strShoriID = strShoriID;
            cABErrLogPrm.p_strShoriShu = strShoriShu;
            cABErrLogPrm.p_strMsg5 = strBasho;
            cABErrLogPrm.p_strMsg6 = strJuminCD;
            cABErrLogPrm.p_strMsg7 = strErrMsg;

            intCnt = cABErrLog.InsertABErrLog(cABErrLogPrm);

            return intCnt;

        }

        #endregion
        // *—š—ð”Ô† 000002 2007/03/16 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000002 2007/03/16 íœŠJŽn
        // ¦Try-Catch‚Ìì‚è‚ð‘å•‚É•Ï‚¦‚é‚Ì‚Å‹Œƒ\[ƒX‚ð‚»‚Ì‚Ü‚ÜŽc‚µ‚Ä‚¨‚«‚Ü‚·B
        #region ‹Œƒ\[ƒX UpdateAtenaInkan
        // '************************************************************************************************
        // '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ˆóŠÓƒ}ƒXƒ^XV
        // '* 
        // '* \•¶           Public Function UpdateAtenaInkan(ByVal cABKobetsuProperty As ABKobetsuInkanProperty) As Integer
        // '* 
        // '* ‹@”\@@    @  ˆ¶–¼ˆóŠÓƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // '* 
        // '* ˆø”           cABKobetsuProperty As ABKobetsuProperty  :XVƒf[ƒ^
        // '* 
        // '* –ß‚è’l         XVŒ”(Integer)
        // '************************************************************************************************
        // Public Function UpdateAtenaInkan(ByVal cABKobetsuProperty() As ABKobetsuInkanProperty) As Integer
        // Const THIS_METHOD_NAME As String = "UpdateAtenaInkan"
        // Dim intUpdCnt As Integer
        // Dim cABAtenaInkanBClass As ABAtenaInkanBClass
        // Dim cAAKOBETSUINKANParamClass() As localhost.AAKOBETSUINKANParamClass
        // Dim cAACommonBSClass As localhost.AACommonBSClass
        // Dim csABAtenaInkanEntity As DataSet
        // Dim cDatRow As DataRow
        // Dim strControlData As String
        // Dim cUSSCItyInfo As New USSCityInfoClass()
        // Dim cfErrorClass As UFErrorClass                    'ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
        // Dim csAppExp As UFAppException
        // Dim intcnt As Integer

        // Try

        // '*—š—ð”Ô† 000001 2004/03/26 ’Ç‰ÁŠJŽn
        // '‹Æ–±ID‚ðˆ¶–¼(AB)‚É•ÏX
        // m_cfControlData.m_strBusinessId = "AB"
        // '*—š—ð”Ô† 000001 2004/03/26 ’Ç‰ÁI—¹

        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // 'Žs’¬‘ºî•ñŽæ“¾iŽs’¬‘ºƒR[ƒh)
        // cUSSCItyInfo.GetCityInfo(m_cfControlData)

        // 'ˆ¶–¼ˆóŠÓ‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // cABAtenaInkanBClass = New ABAtenaInkanBClass(m_cfControlData, m_cfABConfigDataClass, m_cfRdbClass)

        // For intcnt = 0 To cABKobetsuProperty.Length - 1

        // 'ˆ¶–¼ˆóŠÓƒ}ƒXƒ^’ŠoŒÄ‚Ño‚µ
        // csABAtenaInkanEntity = cABAtenaInkanBClass.GetAtenaInkan(CStr(cABKobetsuProperty(intcnt).p_strJUMINCD))

        // '’Ç‰ÁEXV‚Ì”»’è
        // If csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).Rows.Count = 0 Then

        // cDatRow = csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).NewRow()
        // 'Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
        // cDatRow.Item(ABAtenaInkanEntity.JUMINCD) = cABKobetsuProperty(intcnt).p_strJUMINCD
        // cDatRow.Item(ABAtenaInkanEntity.INKANNO) = cABKobetsuProperty(intcnt).p_strINKANNO
        // cDatRow.Item(ABAtenaInkanEntity.INKANTOROKUKB) = cABKobetsuProperty(intcnt).p_strINKANTOROKUKB

        // 'Žs’¬‘ºƒR[ƒh
        // cDatRow.Item(ABAtenaInkanEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0)
        // '‹ŒŽs’¬‘ºƒR[ƒh
        // cDatRow.Item(ABAtenaInkanEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0)

        // 'ƒf[ƒ^‚Ì’Ç‰Á
        // 'csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).Rows.Add(cDatRow)

        // 'ˆ¶–¼ˆóŠÓƒ}ƒXƒ^’Ç‰Áƒƒ\ƒbƒhŒÄ‚Ño‚µ
        // intUpdCnt = cABAtenaInkanBClass.InsertAtenaInkan(cDatRow)
        // Else

        // cDatRow = csABAtenaInkanEntity.Tables(ABAtenaInkanEntity.TABLE_NAME).Rows(0)
        // 'Še€–Ú‚ðƒvƒƒpƒeƒB‚©‚çŽæ“¾
        // cDatRow.Item(ABAtenaInkanEntity.JUMINCD) = cABKobetsuProperty(intcnt).p_strJUMINCD
        // cDatRow.Item(ABAtenaInkanEntity.INKANNO) = cABKobetsuProperty(intcnt).p_strINKANNO
        // cDatRow.Item(ABAtenaInkanEntity.INKANTOROKUKB) = cABKobetsuProperty(intcnt).p_strINKANTOROKUKB

        // 'Žs’¬‘ºƒR[ƒh
        // cDatRow.Item(ABAtenaInkanEntity.SHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0)
        // '‹ŒŽs’¬‘ºƒR[ƒh
        // cDatRow.Item(ABAtenaInkanEntity.KYUSHICHOSONCD) = cUSSCItyInfo.p_strShichosonCD(0)

        // 'ˆ¶–¼ˆóŠÓƒ}ƒXƒ^XVƒƒ\ƒbƒhŒÄ‚Ño‚µ
        // intUpdCnt = cABAtenaInkanBClass.UpdateAtenaInkan(cDatRow)
        // End If

        // '’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ˆ¶–¼‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
        // If intUpdCnt = 0 Then

        // cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003004)
        // '—áŠO‚ð¶¬
        // csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
        // Throw csAppExp
        // End If

        // Next

        // 'Webservice‚ÌURL‚ðWebConfig‚©‚çŽæ“¾‚µ‚ÄÝ’è‚·‚é
        // cAACommonBSClass = New localhost.AACommonBSClass()
        // cAACommonBSClass.Url = m_cfAAConfigDataClass.p_strWebServiceDomain + m_cfAAConfigDataClass.p_strWWWroot + "AA001BS/AACommonBSClass.asmx"
        // 'cAACommonBSClass.Url = "http://localhost/Densan/Reams/AA/AA001BS/AACommonBSClass.asmx"

        // ReDim cAAKOBETSUINKANParamClass(cABKobetsuProperty.Length - 1)

        // For intcnt = 0 To cABKobetsuProperty.Length - 1

        // 'ŒÂ•ÊˆóŠÓƒpƒ‰ƒ[ƒ^‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // cAAKOBETSUINKANParamClass(intcnt) = New localhost.AAKOBETSUINKANParamClass()

        // 'XVE’Ç‰Á‚µ‚½€–Ú‚ðŽæ“¾
        // cAAKOBETSUINKANParamClass(intcnt).m_strJUMINCD = CStr(cABKobetsuProperty(intcnt).p_strJUMINCD)
        // cAAKOBETSUINKANParamClass(intcnt).m_strINKANNO = CStr(cABKobetsuProperty(intcnt).p_strINKANNO)
        // cAAKOBETSUINKANParamClass(intcnt).m_strINKANTOROKUKB = CStr(cABKobetsuProperty(intcnt).p_strINKANTOROKUKB)
        // Next

        // ' ZŠîŒÂ•ÊˆóŠÓXVƒƒ\ƒbƒh‚ðŽÀs‚·‚é
        // strControlData = UFControlToolClass.ControlGetStr(m_cfControlData)
        // intUpdCnt = cAACommonBSClass.UpdateKBINKAN(strControlData, cAAKOBETSUINKANParamClass)

        // '’Ç‰ÁEXVŒ”‚ª0Œ‚ÌŽžƒƒbƒZ[ƒW"ZŠî‚ÌŒÂ•ÊŽ–€‚ÌXV‚Í³í‚És‚¦‚Ü‚¹‚ñ‚Å‚µ‚½"‚ð•Ô‚·
        // If Not (intUpdCnt = cABKobetsuProperty.Length) Then

        // cfErrorClass = New UFErrorClass(m_cfControlData.m_strBusinessId)
        // 'ƒGƒ‰[’è‹`‚ðŽæ“¾
        // objErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003002)
        // '—áŠO‚ð¶¬
        // csAppExp = New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
        // Throw csAppExp

        // End If

        // Catch objSoapExp As Web.Services.Protocols.SoapException             ' SoapException‚ðƒLƒƒƒbƒ`
        // ' OuterXml‚ÉƒGƒ‰[“à—e‚ªŠi”[‚µ‚Ä‚ ‚éB
        // Dim objExpTool As UFExceptionTool = New UFExceptionTool(objSoapExp.Detail.OuterXml)
        // Dim objErr As UFErrorStruct

        // ' ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚©‚Ç‚¤‚©‚Ì”»’è
        // If (objExpTool.IsAppException = True) Then
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLogClass.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objExpTool.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + objExpTool.p_strErrorMessage + "z")

        // ' •t‰ÁƒƒbƒZ[ƒW‚ðì¬‚·‚é
        // Dim strExtMsg As String = "<P>‘ÎÛZ–¯‚ÌƒŠƒJƒoƒŠˆ—‚ðs‚Á‚Ä‚­‚¾‚³‚¢B<BR>"

        // ' ƒAƒvƒŠƒP[ƒVƒ‡ƒ“—áŠO‚ðì¬‚·‚é
        // Dim objAppExp As UFAppException
        // objAppExp = New UFAppException(objExpTool.p_strErrorMessage + strExtMsg, objExpTool.p_strErrorCode)

        // ' Šg’£—Ìˆæ‚ÌƒƒbƒZ[ƒW‚É‚à•t‰ÁiŽÀÛ‚É‚Í‚±‚±‚ÌƒƒbƒZ[ƒW‚ª•\Ž¦‚³‚ê‚éj
        // UFErrorToolClass.ErrorStructSetStr(objErr, objExpTool.p_strExt)
        // objErr.m_strErrorMessage += strExtMsg
        // objAppExp.p_strExt = UFErrorToolClass.ErrorStructGetStr(objErr)
        // ' ƒƒbƒZ[ƒW‚ð•t‰Á‚µ‚È‚¢ê‡‚ÍˆÈ‰º
        // 'objAppExp.p_strExt = objExpTool.p_strExt

        // Throw objAppExp
        // Else
        // ' ƒVƒXƒeƒ€—áŠO‚Ìê‡
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLogClass.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + objExpTool.p_strErrorMessage + "z")
        // Throw objSoapExp
        // End If
        // Catch exAppExp As UFAppException                   ' UFAppException‚ðƒLƒƒƒbƒ`
        // ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // m_cfLogClass.WarningWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppExp.p_strErrorCode + "z" + _
        // "yƒ[ƒjƒ“ƒO“à—e:" + exAppExp.Message + "z")
        // Throw exAppExp
        // Catch exExp As Exception                           ' Exception‚ðƒLƒƒƒbƒ`
        // ' ƒGƒ‰[ƒƒOo—Í
        // m_cfLogClass.ErrorWrite(m_cfControlData, _
        // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // "yƒGƒ‰[“à—e:" + exExp.Message + "z")
        // Throw exExp
        // Finally
        // 'Œ³‚ÌƒrƒWƒlƒXID‚ð“ü‚ê‚é
        // m_cfControlData.m_strBusinessId = m_strRsBusiId
        // ' ƒfƒoƒbƒOƒƒOo—Í
        // m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // End Try

        // Return intUpdCnt

        // End Function
        #endregion
        // *—š—ð”Ô† 000002 2007/03/16 íœI—¹
    }
}