// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ƒR[ƒh‘¶Ýƒ`ƒFƒbƒN‚a(ABCodeUmuCheckBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/04/21@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/05/22 000001     RDB‚ÌConnect‚ÍÒ¿¯ÄÞ‚Ìæ“ª‚É•ÏX(Žd—l•ÏX)
// * 2010/04/16  000002      VS2008‘Î‰ži”ä‰Ãj
// ************************************************************************************************
using System;
using System.Linq;

namespace Densan.Reams.AB.AB000BB
{

    public class ABCodeUmuCheckBClass
    {

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private bool m_blnCodeUmu;                         // ƒR[ƒh—L–³

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABCodeUmuCheckBClass";            // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh

        // ************************************************************************************************
        // * Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        // ************************************************************************************************

        public bool p_blnCodeUmu
        {
            get
            {
                return m_blnCodeUmu;
            }
            set
            {
                m_blnCodeUmu = value;
            }
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControldata As UFControlData, 
        // *                                 ByVal cfConfigData As UFConfigDataClass,
        // *                                 ByVal cfRdb As UFRdbClass)
        // * 
        // * ‹@”\           ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData        : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                  cfConfigData As UFConfigDataClass     : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                  cfRdb As UFRdbClass                   : ‚q‚c‚aƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public ABCodeUmuCheckBClass(UFControlData cfControldata, UFConfigDataClass cfConfigData)
        {
            // * corresponds to VS2008 Start 2010/04/16 000002
            // Const THIS_METHOD_NAME As String = "New"            'ƒƒ\ƒbƒh–¼
            // * corresponds to VS2008 End 2010/04/16 000002

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControldata;
            m_cfConfigDataClass = cfConfigData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // RDBƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            m_cfRdbClass = new UFRdbClass(THIS_BUSINESSID);

            // ƒƒ“ƒo•Ï”‚Ì‰Šú‰»
            m_blnCodeUmu = false;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      Z–¯ƒR[ƒh—L–³ƒ`ƒFƒbƒN
        // * 
        // * \•¶           Public Sub JuminCDUmuCheck(ByVal strJuminCD As String)
        // * 
        // * ‹@”\@@        Z–¯ƒR[ƒh‚ª‘¶Ý‚·‚é‚©ƒ`ƒFƒbƒN‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String          : Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void JuminCDUmuCheck(string strJuminCD)
        {
            const string THIS_METHOD_NAME = "JuminCDUmuCheck";
            // * corresponds to VS2008 Start 2010/04/16 000002
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000002
            ABAtenaBClass cAtenaB;                        // ˆ¶–¼‚c‚`ƒNƒ‰ƒX
            var cAtenaSearchKey = new ABAtenaSearchKey();       // ˆ¶–¼ŒŸõƒL[
            DataSet csAtenaEntity;                        // ˆ¶–¼Entity
            int intDataCount;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");


                // RDBÚ‘±
                m_cfRdbClass.Connect();

                try
                {
                    // ˆ¶–¼Žæ“¾ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    cAtenaB = new ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                    cAtenaSearchKey.p_strJuminCD = strJuminCD;

                    // ˆ¶–¼‚c‚`ƒNƒ‰ƒX‚Ìˆ¶–¼Žæ“¾ƒƒ]ƒbƒg‚ðŽÀs
                    csAtenaEntity = cAtenaB.GetAtenaBHoshu(1, cAtenaSearchKey, true);

                    intDataCount = csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count();

                    // ƒf[ƒ^‚ª‚OŒ‚Ì‚Æ‚«‚Í
                    if (intDataCount == 0)
                    {
                        m_blnCodeUmu = false;
                    }
                    else
                    {
                        m_blnCodeUmu = true;
                    }
                }

                catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6470


                    Input:
                    " + objRdbTimeOutExp.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6575


                    Input:
                    " + objRdbTimeOutExp.Message + "z")
                                    ' UFAppException‚ðƒXƒ[‚·‚é
                                    Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                Catch
                                    ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                    Throw

                                Finally
                                    ' RDBƒAƒNƒZƒXƒƒOo—Í
                                    m_cfLogClass.RdbWrite(m_cfControlData, _
                                                            "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7025


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                            "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7110


                    Input:
                    " + THIS_METHOD_NAME + "z" + _
                                                            "yŽÀsƒƒ\ƒbƒh–¼:
                     */
                    Disconnect();/* TODO ERROR: Skipped SkippedTokensTrivia
z")
                ' RDBØ’f
                m_cfRdbClass.Disconnect()
            End Try

            ' ƒfƒoƒbƒOƒƒOo—Í
            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        Catch objAppExp As UFAppException
            'ƒ[ƒjƒ“ƒOƒƒOo—Í*/
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7845


                    Input:
                    " + objAppExp.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7943


                    Input:
                    " + objAppExp.Message + "z")
                                'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                                Throw objAppExp

                            Catch objExp As Exception
                                'ƒGƒ‰[ƒƒOo—Í
                                m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                            "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8211


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                            "yƒƒ\ƒbƒh–¼:
                     */
                    ;
                    // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 8296


                                        Input:
                                        " + THIS_METHOD_NAME + "z" + _
                                                                                "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                         */
                    throw objExp;

                }
            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ¢‘ÑƒR[ƒh—L–³ƒ`ƒFƒbƒN
        // * 
        // * \•¶           Public Sub StaiCDUmuCheck(ByVal strStaiCD As String)
        // * 
        // * ‹@”\@@        ¢‘ÑƒR[ƒh‚ª‘¶Ý‚·‚é‚©ƒ`ƒFƒbƒN‚·‚éB
        // * 
        // * ˆø”           strStaiCD As String          : ¢‘ÑƒR[ƒh
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void StaiCDUmuCheck(string strStaiCD)
        {
            const string THIS_METHOD_NAME = "StaiCDUmuCheck";
            // * corresponds to VS2008 Start 2010/04/16 000002
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000002
            ABAtenaBClass cAtenaB;                        // ˆ¶–¼‚c‚`ƒNƒ‰ƒX
            var cAtenaSearchKey = new ABAtenaSearchKey();       // ˆ¶–¼ŒŸõƒL[
            DataSet csAtenaEntity;                        // ˆ¶–¼Entity
            int intDataCount;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");


                // RDBÚ‘±
                m_cfRdbClass.Connect();

                try
                {
                    // ˆ¶–¼Žæ“¾ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    cAtenaB = new ABAtenaBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                    cAtenaSearchKey.p_strStaiCD = strStaiCD;

                    // ˆ¶–¼‚c‚`ƒNƒ‰ƒX‚Ìˆ¶–¼Žæ“¾ƒƒ]ƒbƒg‚ðŽÀs
                    csAtenaEntity = cAtenaB.GetAtenaBHoshu(1, cAtenaSearchKey, true);

                    intDataCount = csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows.Count();

                    // ƒf[ƒ^‚ª‚OŒ‚Ì‚Æ‚«‚Í
                    if (intDataCount == 0)
                    {
                        m_blnCodeUmu = false;
                    }
                    else
                    {
                        m_blnCodeUmu = true;
                    }
                }

                catch (UFRdbTimeOutException objRdbTimeOutExp)    // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11429


                    Input:
                    " + objRdbTimeOutExp.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11534


                    Input:
                    " + objRdbTimeOutExp.Message + "z")
                                    ' UFAppException‚ðƒXƒ[‚·‚é
                                    Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                Catch
                                    ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                                    Throw

                                Finally
                                    ' RDBƒAƒNƒZƒXƒƒOo—Í
                                    m_cfLogClass.RdbWrite(m_cfControlData, _
                                                            "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11984


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                            "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12069


                    Input:
                    " + THIS_METHOD_NAME + "z" + _
                                                            "yŽÀsƒƒ\ƒbƒh–¼:
                     */
                    Disconnect();/* TODO ERROR: Skipped SkippedTokensTrivia
z")
                ' RDBØ’f
                m_cfRdbClass.Disconnect()
            End Try

            ' ƒfƒoƒbƒOƒƒOo—Í
            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        Catch objAppExp As UFAppException
            'ƒ[ƒjƒ“ƒOƒƒOo—Í*/
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12804


                    Input:
                    " + objAppExp.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12902


                    Input:
                    " + objAppExp.Message + "z")
                                'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                                Throw objAppExp

                            Catch objExp As Exception
                                'ƒGƒ‰[ƒƒOo—Í
                                m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                            "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13170


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                            "yƒƒ\ƒbƒh–¼:
                     */
                    ;
                    // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13255


                                        Input:
                                        " + THIS_METHOD_NAME + "z" + _
                                                                                "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                         */
                    throw objExp;

                }
            }

        }

    }
}