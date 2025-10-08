// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼XVƒGƒ‰[ƒƒO‚c‚aŠÇ—(ABErrLogBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2007/02/05@“àŽR Œ˜‘¾˜Y
// * 
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    public class ABErrLogBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFConfigDataClass m_cfConfigDataClass;                      // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFControlData m_cfControlData;                              // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFLogClass m_cfLogClass;                                    // ƒƒOo—ÍƒNƒ‰ƒX
        private UFParameterCollectionClass m_cfInsParamCollection;          // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private string m_strInsertSQL;                                      // INSERT—pSQL
        private string m_strRsBusinId;                                      // ƒrƒWƒlƒX‚h‚c•Û‘¶—p

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string TAISHOKBN_MIKAKUNIN = "0";                     // –¢Šm”F
        private const string TAISHOKBN_ZUMI = "1";                          // Šm”FÏ
        private const string JOKYOKBN_NORMAL = "0";                         // ³íI—¹
        private const string JOKYOKBN_ERR = "9";                            // ˆÙíI—¹
        private const string SPACE = " ";                                   // SPACE

        private const string THIS_CLASS_NAME = "ABErrLogBClass";            // ƒNƒ‰ƒX–¼

        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfControlData As UFControlData,
        // * @@                           ByVal cfConfigDataClass As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@            cfConfigDataClass As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABErrLogBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass)
        {

            // ƒƒ“ƒo•Ï”‚ÖƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;

            // ƒƒOo—ÍƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // Žó‚¯Žæ‚Á‚½ƒrƒWƒlƒXID‚ðƒƒ“ƒo‚Ö•Û‘¶
            m_strRsBusinId = m_cfControlData.m_strBusinessId;

            // ƒƒ“ƒo•Ï”‚Ì‰Šú‰»
            m_strInsertSQL = string.Empty;
            m_cfInsParamCollection = (object)null;

        }

        #endregion

        #region ƒGƒ‰[ƒƒOŽæ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒGƒ‰[ƒƒOŽæ“¾
        // * 
        // * \•¶            Public Function GetABErrLog() As String()
        // * 
        // * ‹@”\            ƒGƒ‰[ƒƒO‚ÌŽæ“¾‚ðs‚È‚¤
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          String()FƒGƒ‰[”­¶êŠ‚ÆƒGƒ‰[ƒƒbƒZ[ƒW
        // ************************************************************************************************
        public string[] GetABErrLog()
        {

            const string THIS_METHOD_NAME = "GetABErrLog";
            UFRdbClass cfRdb;
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;
            DataSet csABErrLogEntity;
            int intCnt;
            string strGyomuMei;
            string strErrMSG;
            var strReturn = default(string[]);
            var strSQL = new StringBuilder();

            try
            {
                // ‹Æ–±‚h‚c‚ðˆ¶–¼(AB)‚É•ÏX
                m_cfControlData.m_strBusinessId = "AB";

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");



                // RDBƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cfRdb = new UFRdbClass(m_cfControlData.m_strBusinessId);

                // RDBÚ‘±
                cfRdb.Connect();

                // SelectSQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABErrLogEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABErrLogEntity.TAISHOKB);
                strSQL.Append(" = ");
                strSQL.Append(ABErrLogEntity.KEY_TAISHOKB);
                strSQL.Append(" AND ");
                strSQL.Append(ABErrLogEntity.JOKYOKB);
                strSQL.Append(" = ");
                strSQL.Append(ABErrLogEntity.KEY_JOKYOKB);
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABErrLogEntity.LOGNO);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_TAISHOKB;          // ‘Îˆ‹æ•ª
                cfUFParameterClass.Value = TAISHOKBN_MIKAKUNIN;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_JOKYOKB;           // ó‹µ‹æ•ª
                cfUFParameterClass.Value = JOKYOKBN_ERR;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
       "ySQL“
        */
        );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7161


                                Input:
                                " + cfRdb.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQLŽÀs DataSetŽæ“¾

                                 */
                csABErrLogEntity = cfRdb.GetDataSet(strSQL.ToString(), ABErrLogEntity.TABLE_NAME, cfUFParameterCollectionClass);

                // –ß‚è’l•ÒW—p”z—ñ‰Šú‰»
                var strRet = new string[csABErrLogEntity.Tables(ABErrLogEntity.TABLE_NAME).Rows.Count];

                // –ß‚è’l•ÒW
                // For intCnt = 0 To csABErrLogEntity.Tables(ABErrLogEntity.TABLE_NAME).Rows.Count - 1
                // csDataRow = csABErrLogEntity.Tables(ABErrLogEntity.TABLE_NAME).Rows(intCnt)
                // strGyomuMei = CType(csDataRow(ABErrLogEntity.MSG5), String).Trim
                // strErrMSG = CType(csDataRow(ABErrLogEntity.MSG7), String).Trim
                // strRet(intCnt) = strGyomuMei + "," + strErrMSG
                // Next intCnt

                intCnt = 0;
                foreach (DataRow csDataRow in csABErrLogEntity.Tables(ABErrLogEntity.TABLE_NAME).Rows)
                {
                    strGyomuMei = ((string)csDataRow(ABErrLogEntity.MSG5)).Trim;          // ƒGƒ‰[”­¶êŠ
                    strErrMSG = ((string)csDataRow(ABErrLogEntity.MSG7)).Trim;            // ƒGƒ‰[ƒƒbƒZ[ƒW
                    strRet[intCnt] = strGyomuMei + "," + strErrMSG;
                    intCnt += 1;
                }

                // –ß‚è’lƒZƒbƒg
                strReturn = strRet;
            }

            catch (UFRdbException objRdbExp)                          // RdbException‚ðƒLƒƒƒbƒ`
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
                // ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                throw objRdbExp;
            }

            catch (UFRdbDeadLockException objRdbDeadLockExp)          // ƒfƒbƒhƒƒbƒN‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9522


                Input:
                " + objRdbDeadLockExp.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9625


                                Input:
                                " + objRdbDeadLockExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw objRdbDeadLockExp;
            }

            catch (UFRdbUniqueException objUFRdbUniqueExp)            // ˆêˆÓ§–ñˆá”½‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10191


                Input:
                " + objUFRdbUniqueExp.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10294


                                Input:
                                " + objUFRdbUniqueExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw objUFRdbUniqueExp;
            }

            catch (UFRdbTimeOutException objRdbTimeOutExp)            // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10869


                Input:
                " + objRdbTimeOutExp.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10971


                                Input:
                                " + objRdbTimeOutExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw objRdbTimeOutExp;
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11490


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11590


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException)                             // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12148


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        Finally
                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                 "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12400


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                 "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12478


                Input:
                " + THIS_METHOD_NAME + "z" + _
                                                 "yŽÀsƒƒ\ƒbƒh–¼:
                 */
                Disconnect();/* TODO ERROR: Skipped SkippedTokensTrivia
z")

            ' RDBØ’f
            cfRdb.Disconnect()

            ' Œ³‚ÌƒrƒWƒlƒXID‚ð“ü‚ê‚é*/
                m_cfControlData.m_strBusinessId = m_strRsBusinId;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

            }

            // –ß‚è’lÝ’è
            return strReturn;

        }

        #endregion

        #region ƒGƒ‰[ƒƒO’Ç‰Á
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒGƒ‰[ƒƒO’Ç‰Á
        // * 
        // * \•¶            Public Function InsertABErrLog(ByVal cABErrLogXClass As ABErrLogXClass) As Integer
        // * 
        // * ‹@”\            ƒGƒ‰[ƒƒO‚Ì’Ç‰Á‚ðs‚È‚¤
        // * 
        // * ˆø”            cABErrLogXClass As ABErrLogXClass : ’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l          Integer F ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertABErrLog(ABErrLogXClass cABErrLogXClass)
        {

            const string THIS_METHOD_NAME = "InsertABErrLog";
            ABAkibanShutokuBClass cABAkibanShutokuBClass;          // ƒGƒ‰[ƒƒO”Ô†‹ó”ÔŽæ“¾
            UFErrorClass cfErrorClass;                             // ƒGƒ‰[ƒNƒ‰ƒX
            UFErrorStruct cfErrorStruct;                           // ƒGƒ‰[’è‹`\‘¢‘Ì
            UFRdbClass cfRdb;
            UFParameterClass cfUFParameterClass;
            int intCheckCnt;
            var intInsCnt = default(int);
            string strErrLogNo;
            string strSystemDateTime;
            string strSystemDate;
            string strSystemTime;

            try
            {
                // ‹Æ–±‚h‚c‚ðˆ¶–¼(AB)‚É•ÏX
                m_cfControlData.m_strBusinessId = "AB";

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Connectz");



                // RDBƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cfRdb = new UFRdbClass(m_cfControlData.m_strBusinessId);

                // RDBÚ‘±
                cfRdb.Connect();

                // ˆø”ƒ`ƒFƒbƒN
                // ‹ó”’ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strShichosonCD.Trim == string.Empty)          // Žs’¬‘ºƒR[ƒh
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "Žs’¬‘ºƒR[ƒhz", cfErrorStruct.m_strErrorCode);
                }

                // •¶Žš”ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strShichosonCD.RLength > 6)                   // Žs’¬‘ºƒR[ƒh
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001030);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "Žs’¬‘ºƒR[ƒhz", cfErrorStruct.m_strErrorCode);
                }

                // ”’lƒ`ƒFƒbƒN
                var loopTo = Len(cABErrLogXClass.p_strShichosonCD);
                for (intCheckCnt = 1; intCheckCnt <= loopTo; intCheckCnt++)            // Žs’¬‘ºƒR[ƒh
                {
                    if (!LikeOperator.LikeString(Strings.Mid(cABErrLogXClass.p_strShichosonCD, intCheckCnt, 1), "[0-9]", CompareMethod.Binary))
                    {
                        cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                        cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001014);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "Žs’¬‘ºƒR[ƒhz", cfErrorStruct.m_strErrorCode);
                    }
                }

                // ‹ó”’ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strShoriID.Trim == string.Empty)              // ˆ—‚h‚c
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ˆ—‚h‚cz", cfErrorStruct.m_strErrorCode);
                }

                // •¶Žš”ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strShoriID.RLength > 5)                       // ˆ—‚h‚c
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001030);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ˆ—‚h‚cz", cfErrorStruct.m_strErrorCode);
                }

                // ”¼Špƒ`ƒFƒbƒN
                var loopTo1 = Len(cABErrLogXClass.p_strShoriID);
                for (intCheckCnt = 1; intCheckCnt <= loopTo1; intCheckCnt++)                // ˆ—‚h‚c
                {
                    if (!LikeOperator.LikeString(Strings.Mid(cABErrLogXClass.p_strShoriID, intCheckCnt, 1), "[0-9a-zA-Z]", CompareMethod.Binary))
                    {
                        cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                        cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001080);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ˆ—‚h‚cz", cfErrorStruct.m_strErrorCode);
                    }
                }

                // ‹ó”’ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strShoriShu.Trim == string.Empty)             // ˆ—Ží•Ê
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ˆ—Ží•Êz", cfErrorStruct.m_strErrorCode);
                }

                // •¶Žš”ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strShoriShu.RLength > 4)                      // ˆ—Ží•Ê
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001030);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ˆ—Ží•Êz", cfErrorStruct.m_strErrorCode);
                }

                // ”¼Špƒ`ƒFƒbƒN
                var loopTo2 = Len(cABErrLogXClass.p_strShoriShu);
                for (intCheckCnt = 1; intCheckCnt <= loopTo2; intCheckCnt++)               // ˆ—Ží•Ê
                {
                    if (!LikeOperator.LikeString(Strings.Mid(cABErrLogXClass.p_strShoriShu, intCheckCnt, 1), "[0-9a-zA-Z]", CompareMethod.Binary))
                    {
                        cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                        cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001080);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ˆ—Ží•Êz", cfErrorStruct.m_strErrorCode);
                    }
                }

                // ‹ó”’ƒ`ƒFƒbƒN
                if (cABErrLogXClass.p_strMsg5.Trim == string.Empty)                 // ƒƒbƒZ[ƒW‚TiƒGƒ‰[”­¶êŠj
                {
                    cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                    cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                    // —áŠO‚ð¶¬
                    /* TODO ERROR: Skipped SkippedTokensTrivia
    ­¶êŠz", cfErrorStruct.m_strErrorCode)
                End If

                ' ‹ó”*/
                    throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ƒGƒ‰[");
                    if (cABErrLogXClass.p_strMsg6.Trim == string.Empty)                 // ƒƒbƒZ[ƒW‚UiZ–¯ƒR[ƒhj
                    {
                        cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                        cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒhz", cfErrorStruct.m_strErrorCode);
                    }

                    // ‹ó”’ƒ`ƒFƒbƒN
                    if (cABErrLogXClass.p_strMsg7.Trim == string.Empty)                 // ƒƒbƒZ[ƒW‚ViƒGƒ‰[ƒƒbƒZ[ƒWj
                    {
                        cfErrorClass = new UFErrorClass(URCommonXClass.GYOMUCD_REAMS);
                        cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                        // —áŠO‚ð¶¬
                        throw new UFAppException(cABErrLogXClass.p_strMsg7.Trim + @"\ny" + cfErrorStruct.m_strErrorMessage + "ƒGƒ‰[ƒƒbƒZ[ƒWz", cfErrorStruct.m_strErrorCode);
                    }

                    // InsertSQL•¶‚Ì—Œ`‚ðì¬
                    CreateInsertSQL();

                    // ‹ó”ÔŽæ“¾ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    cABAkibanShutokuBClass = new ABAkibanShutokuBClass(m_cfControlData, m_cfConfigDataClass);
                    cABAkibanShutokuBClass.GetErrLogNo();

                    // ƒGƒ‰[ƒƒO”Ô†‚ðŽæ“¾
                    strErrLogNo = cABAkibanShutokuBClass.p_strBango;

                    // ‚c‚a“úŽž‚ÌŽæ“¾
                    strSystemDateTime = cfRdb.GetSystemDate().ToString("yyyyMMddHHmmssfff");          // ‚c‚a“úŽž
                    strSystemDate = cfRdb.GetSystemDate.ToString("yyyyMMdd");                         // ‚c‚a“ú•t
                    strSystemTime = cfRdb.GetSystemDate.ToString("HHmmss");                           // ‚c‚aŽžŠÔ

                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    m_cfInsParamCollection = new UFParameterCollectionClass();

                    // €–Ú‚Ì•ÒW
                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_LOGNO;                   // ƒƒO”Ô†
                    cfUFParameterClass.Value = strErrLogNo;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ST_YMD;                  // ŠJŽn”NŒŽ“ú
                    cfUFParameterClass.Value = strSystemDate;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ST_TIME;                 // ŠJŽnŽžŠÔ
                    cfUFParameterClass.Value = strSystemTime;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHORIID;                 // ˆ—‚h‚c
                    cfUFParameterClass.Value = cABErrLogXClass.p_strShoriID.Trim;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHORISHU;                // ˆ—Ží•Ê
                    cfUFParameterClass.Value = cABErrLogXClass.p_strShoriShu.Trim;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_TAISHOKB;                // ‘Îˆ‹æ•ª
                    cfUFParameterClass.Value = TAISHOKBN_MIKAKUNIN;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_JOKYOKB;                 // ó‹µ‹æ•ª
                    cfUFParameterClass.Value = JOKYOKBN_ERR;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHINCHOKURITSU;          // i’»—¦
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_STS1;                    // ƒXƒe[ƒ^ƒX‚P
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_STS2;                    // ƒXƒe[ƒ^ƒX‚Q
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ED_YMD;                  // I—¹”NŒŽ“ú
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ED_TIME;                 // I—¹ŽžŠÔ
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG1;                    // ƒƒbƒZ[ƒW‚P
                                                                                                   // •¶Žš”ƒ`ƒFƒbƒN
                    if (cABErrLogXClass.p_strMsg1.RLength > 8)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg1.RSubstring(0, 8).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg1.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG2;                    // ƒƒbƒZ[ƒW‚Q
                    if (cABErrLogXClass.p_strMsg2.RLength > 8)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg2.RSubstring(0, 8).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg2.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG3;                    // ƒƒbƒZ[ƒW‚R
                    if (cABErrLogXClass.p_strMsg3.RLength > 8)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg3.RSubstring(0, 8).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg3.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG4;                    // ƒƒbƒZ[ƒW‚S
                    if (cABErrLogXClass.p_strMsg4.RLength > 8)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg4.RSubstring(0, 8).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg4.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG5;                    // ƒƒbƒZ[ƒW‚T
                    if (cABErrLogXClass.p_strMsg5.RLength > 15)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg5.RSubstring(0, 15).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg5.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG6;                    // ƒƒbƒZ[ƒW‚U
                    if (cABErrLogXClass.p_strMsg6.RLength > 40)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg6.RSubstring(0, 40).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg6.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG7;                    // ƒƒbƒZ[ƒW‚V
                    if (cABErrLogXClass.p_strMsg7.RLength > 100)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg7.RSubstring(0, 100).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg7.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG8;                    // ƒƒbƒZ[ƒW‚W
                    if (cABErrLogXClass.p_strMsg8.RLength > 120)
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg8.RSubstring(0, 120).Trim;
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABErrLogXClass.p_strMsg8.Trim;
                    }
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_LOGFILEMEI;              // ƒƒOƒtƒ@ƒCƒ‹–¼
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHICHOSONCD;             // Žs’¬‘ºƒR[ƒh
                    cfUFParameterClass.Value = cABErrLogXClass.p_strShichosonCD.Trim;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KYUSHICHOSONCD;          // ‹ŒŽs’¬‘ºƒR[ƒh
                    cfUFParameterClass.Value = cABErrLogXClass.p_strShichosonCD.Trim;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_RESERVE30BYTE;           // ƒŠƒU[ƒu
                    cfUFParameterClass.Value = string.Empty;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_TANMATSUID;              // ’[––‚h‚c
                    cfUFParameterClass.Value = m_cfControlData.m_strClientId;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SAKUJOFG;                // íœƒtƒ‰ƒO
                    cfUFParameterClass.Value = "0";
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KOSHINCOUNTER;           // XVƒJƒEƒ“ƒ^
                    cfUFParameterClass.Value = decimal.Zero;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SAKUSEINICHIJI;          // ì¬“úŽž
                    cfUFParameterClass.Value = strSystemDateTime;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SAKUSEIUSER;             // ì¬ƒ†[ƒU[
                    cfUFParameterClass.Value = m_cfControlData.m_strUserId;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KOSHINNICHIJI;           // XV“úŽž
                    cfUFParameterClass.Value = strSystemDateTime;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // ƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KOSHINUSER;              // XVƒ†[ƒU[
                    cfUFParameterClass.Value = m_cfControlData.m_strUserId;
                    // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    m_cfInsParamCollection.Add(cfUFParameterClass);

                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:INSERTz" + default



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
                                     "ySQL“
                                      */
                         );
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36756


                                        Input:
                                        " + cfRdb.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsParamCollection) + "z")

                                                    ' SQLŽÀs
                                                    intInsCnt = cfRdb.ExecuteSQL(m_strInsertSQL, m_cfInsParamCollection)

                                                Catch objRdbExp As UFRdbException                          ' RdbException‚ðƒLƒƒƒbƒ`
                                                    ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                         */
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
                    // ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                    throw objRdbExp;
                }
            }

            catch (UFRdbDeadLockException objRdbDeadLockExp)          // ƒfƒbƒhƒƒbƒN‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37945


                Input:
                " + objRdbDeadLockExp.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38048


                                Input:
                                " + objRdbDeadLockExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw objRdbDeadLockExp;
            }

            catch (UFRdbUniqueException objUFRdbUniqueExp)            // ˆêˆÓ§–ñˆá”½‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38614


                Input:
                " + objUFRdbUniqueExp.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38717


                                Input:
                                " + objUFRdbUniqueExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw objUFRdbUniqueExp;
            }

            catch (UFRdbTimeOutException objRdbTimeOutExp)            // UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39292


                Input:
                " + objRdbTimeOutExp.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39394


                                Input:
                                " + objRdbTimeOutExp.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw objRdbTimeOutExp;
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39913


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40013


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException)                             // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40571


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        Finally
                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                 "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40823


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                 "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40901


                Input:
                " + THIS_METHOD_NAME + "z" + _
                                                 "yŽÀsƒƒ\ƒbƒh–¼:
                 */
                Disconnect();/* TODO ERROR: Skipped SkippedTokensTrivia
z")

            ' RDBØ’f
            cfRdb.Disconnect()

            ' Œ³‚ÌƒrƒWƒlƒXID‚ð“ü‚ê‚é*/
                m_cfControlData.m_strBusinessId = m_strRsBusinId;

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

            }

            // –ß‚è’lÝ’è
            return intInsCnt;

        }

        #endregion

        #region InsertSQL•¶‚Ì—Œ`‚ðì¬
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      InsertSQL•¶‚Ì—Œ`‚ðì¬
        // * 
        // * \•¶            Private Sub CreateInsertSQL()
        // * 
        // * ‹@”\@@    @@InsertSQL‚Ì—Œ^‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        private void CreateInsertSQL()
        {

            const string THIS_METHOD_NAME = "CreateInsertSQL";
            UFParameterClass cfUFParameterClass;
            var strInsertColumn = new StringBuilder();
            var strInsertParam = new StringBuilder();
            var strInsertSQL = new StringBuilder();

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // InsertSQL•¶‚Ìì¬
                strInsertSQL.Append("INSERT INTO ");
                strInsertSQL.Append(ABErrLogEntity.TABLE_NAME);
                strInsertSQL.Append(" ");

                // INSERTƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsParamCollection = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                cfUFParameterClass = new UFParameterClass();

                // InsertSQL•¶‚Ìì¬
                strInsertColumn.Append(ABErrLogEntity.LOGNO);                   // ƒƒO”Ô†
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.ST_YMD);                  // ŠJŽn”NŒŽ“ú
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.ST_TIME);                 // ŠJŽnŽžŠÔ
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SHORIID);                 // ˆ—‚h‚c
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SHORISHU);                // ˆ—Ží•Ê
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.TAISHOKB);                // ‘Îˆ‹æ•ª
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.JOKYOKB);                 // ó‹µ‹æ•ª
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SHINCHOKURITSU);          // i’»—¦
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.STS1);                    // ƒXƒe[ƒ^ƒX‚P
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.STS2);                    // ƒXƒe[ƒ^ƒX‚Q
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.ED_YMD);                  // I—¹”NŒŽ“ú
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.ED_TIME);                 // I—¹ŽžŠÔ
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG1);                    // ƒƒbƒZ[ƒW‚P
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG2);                    // ƒƒbƒZ[ƒW‚Q
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG3);                    // ƒƒbƒZ[ƒW‚R
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG4);                    // ƒƒbƒZ[ƒW‚S
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG5);                    // ƒƒbƒZ[ƒW‚T
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG6);                    // ƒƒbƒZ[ƒW‚U
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG7);                    // ƒƒbƒZ[ƒW‚V
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.MSG8);                    // ƒƒbƒZ[ƒW‚W
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.LOGFILEMEI);              // ƒƒOƒtƒ@ƒCƒ‹–¼
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SHICHOSONCD);             // Žs’¬‘ºƒR[ƒh
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.KYUSHICHOSONCD);          // ‹ŒŽs’¬‘ºƒR[ƒh
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.RESERVE30BYTE);           // ƒŠƒU[ƒu
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.TANMATSUID);              // ’[––‚h‚c
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SAKUJOFG);                // íœƒtƒ‰ƒO
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.KOSHINCOUNTER);           // XVƒJƒEƒ“ƒ^
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SAKUSEINICHIJI);          // ì¬“úŽž
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.SAKUSEIUSER);             // ì¬ƒ†[ƒU[
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.KOSHINNICHIJI);           // XV“úŽž
                strInsertColumn.Append(", ");
                strInsertColumn.Append(ABErrLogEntity.KOSHINUSER);              // XVƒ†[ƒU[

                strInsertParam.Append(ABErrLogEntity.KEY_LOGNO);                   // ƒƒO”Ô†
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_ST_YMD);                  // ŠJŽn”NŒŽ“ú
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_ST_TIME);                 // ŠJŽnŽžŠÔ
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SHORIID);                 // ˆ—‚h‚c
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SHORISHU);                // ˆ—Ží•Ê
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_TAISHOKB);                // ‘Îˆ‹æ•ª
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_JOKYOKB);                 // ó‹µ‹æ•ª
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SHINCHOKURITSU);          // i’»—¦
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_STS1);                    // ƒXƒe[ƒ^ƒX‚P
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_STS2);                    // ƒXƒe[ƒ^ƒX‚Q
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_ED_YMD);                  // I—¹”NŒŽ“ú
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_ED_TIME);                 // I—¹ŽžŠÔ
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG1);                    // ƒƒbƒZ[ƒW‚P
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG2);                    // ƒƒbƒZ[ƒW‚Q
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG3);                    // ƒƒbƒZ[ƒW‚R
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG4);                    // ƒƒbƒZ[ƒW‚S
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG5);                    // ƒƒbƒZ[ƒW‚T
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG6);                    // ƒƒbƒZ[ƒW‚U
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG7);                    // ƒƒbƒZ[ƒW‚V
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_MSG8);                    // ƒƒbƒZ[ƒW‚W
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_LOGFILEMEI);              // ƒƒOƒtƒ@ƒCƒ‹–¼
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SHICHOSONCD);             // Žs’¬‘ºƒR[ƒh
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_KYUSHICHOSONCD);          // ‹ŒŽs’¬‘ºƒR[ƒh
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_RESERVE30BYTE);           // ƒŠƒU[ƒu
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_TANMATSUID);              // ’[––‚h‚c
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SAKUJOFG);                // íœƒtƒ‰ƒO
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_KOSHINCOUNTER);           // XVƒJƒEƒ“ƒ^
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SAKUSEINICHIJI);          // ì¬“úŽž
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_SAKUSEIUSER);             // ì¬ƒ†[ƒU[
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_KOSHINNICHIJI);           // XV“úŽž
                strInsertParam.Append(", ");
                strInsertParam.Append(ABErrLogEntity.KEY_KOSHINUSER);              // XVƒ†[ƒU[

                // INSERTƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_LOGNO;                   // ƒƒO”Ô†
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ST_YMD;                  // ŠJŽn”NŒŽ“ú
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ST_TIME;                 // ŠJŽnŽžŠÔ
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHORIID;                 // ˆ—‚h‚c
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHORISHU;                // ˆ—Ží•Ê
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_TAISHOKB;                // ‘Îˆ‹æ•ª
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_JOKYOKB;                 // ó‹µ‹æ•ª
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHINCHOKURITSU;          // i’»—¦
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_STS1;                    // ƒXƒe[ƒ^ƒX‚P
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_STS2;                    // ƒXƒe[ƒ^ƒX‚Q
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ED_YMD;                  // I—¹”NŒŽ“ú
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_ED_TIME;                 // I—¹ŽžŠÔ
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG1;                    // ƒƒbƒZ[ƒW‚P
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG2;                    // ƒƒbƒZ[ƒW‚Q
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG3;                    // ƒƒbƒZ[ƒW‚R
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG4;                    // ƒƒbƒZ[ƒW‚S
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG5;                    // ƒƒbƒZ[ƒW‚T
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG6;                    // ƒƒbƒZ[ƒW‚U
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG7;                    // ƒƒbƒZ[ƒW‚V
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_MSG8;                    // ƒƒbƒZ[ƒW‚W
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_LOGFILEMEI;              // ƒƒOƒtƒ@ƒCƒ‹–¼
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SHICHOSONCD;             // Žs’¬‘ºƒR[ƒh
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KYUSHICHOSONCD;          // ‹ŒŽs’¬‘ºƒR[ƒh
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_RESERVE30BYTE;           // ƒŠƒU[ƒu
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_TANMATSUID;              // ’[––‚h‚c
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SAKUJOFG;                // íœƒtƒ‰ƒO
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KOSHINCOUNTER;           // XVƒJƒEƒ“ƒ^
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SAKUSEINICHIJI;          // ì¬“úŽž
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_SAKUSEIUSER;             // ì¬ƒ†[ƒU[
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KOSHINNICHIJI;           // XV“úŽž
                m_cfInsParamCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABErrLogEntity.KEY_KOSHINUSER;              // XVƒ†[ƒU[
                m_cfInsParamCollection.Add(cfUFParameterClass);

                // InsertSQL•¶‚ÌŒ‹‡
                strInsertSQL.Append("(");
                strInsertSQL.Append(strInsertColumn);
                strInsertSQL.Append(")");
                strInsertSQL.Append(" VALUES (");
                strInsertSQL.Append(strInsertParam);
                strInsertSQL.Append(")");

                // StringŒ^‚É•ÏŠ·
                m_strInsertSQL = strInsertSQL.ToString();
            }

            catch (UFAppException exAppException)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 58570


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                     "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 58670


                Input:
                " + exAppException.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception          ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                   "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 58986


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                   "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 59066


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                   "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                 */
                throw exException;
            }
            finally
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

            }

        }

        #endregion

    }
}