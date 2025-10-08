// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼ŠÇ—î•ñƒLƒƒƒbƒVƒ…‚c‚`(ABKANRIJOHOCacheBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2014/04/28@Šâ‰º ˆê”ü
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2014/04/28  000000      V‹Kì¬
// * 2014/06/11  000001      ƒoƒbƒ`ˆ—‚æ‚èƒR[ƒ‹‚³‚ê‚½Û‚ÌƒGƒ‰[C³i“c’†j
// ************************************************************************************************
using System.Linq;
using System.Text;
using System.Web;

namespace Densan.Reams.AB.AB000BB
{

    public class ABKANRIJOHOCacheBClass : ABAtenaKanriJohoBClass
    {

        #region ƒƒ“
        // **
        // * ƒNƒ‰ƒXID’è‹`
        // * 
        private const string THIS_CLASS_NAME = "ABKANRIJOHOCacheBClass";

        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private URLogXClass m_cfLog;                                     // ƒƒOo—ÍƒNƒ‰ƒX

        // ƒLƒƒƒbƒVƒ…ƒNƒ‰ƒX
        private const string ABKANRIJOHO = "ABKANRIJOHO";
        private class CacheDataClass
        {
            public string m_strUpdate;
            public DataSet m_csDS;
        }

        // ˆ¶–¼ŠÇ—î•ñ@Ží•ÊƒL[EŽ¯•ÊƒL[
        private const string SHUBETSUKEY_KOJINJOHOSEIGYO = "20";         // Ží•ÊƒL[:20FŒÂlî•ñ§Œä‹@”\
        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // *                               ByVal cfConfigData As UFConfigDataClass, 
        // *                               ByVal cfRdb As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData    : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfConfigData As UFConfigDataClass : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfRdb As UFRdbClass               : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************

        public ABKANRIJOHOCacheBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData, UFRdbClass cfRdb) : base(cfControlData, cfConfigData, cfRdb)

        {

            // ƒƒOo—ÍƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLog = new URLogXClass(cfControlData, cfConfigData, GetType().Name);

        }
        #endregion

        #region ƒƒ\ƒbƒh
        #region ŠÇ—î•ñƒ}ƒXƒ^’Šo
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÇ—î•ñƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Private Function GetKanriJohoHoshu() As DataSet
        // * 
        // * ‹@”\           Žw’è‚³‚ê‚½ŠÇ—î•ñƒ}ƒXƒ^‚ððŒ‚É‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ŠÇ—î•ñƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public new DataSet GetKanriJohoHoshu()
        {
            return GetKanriJohoHoshu(string.Empty, string.Empty);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÇ—î•ñƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Private Function GetKanriJohoHoshu(ByVal strShuKEY As String) As DataSet
        // * 
        // * ‹@”\           Žw’è‚³‚ê‚½ŠÇ—î•ñƒ}ƒXƒ^‚ððŒ‚É‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ŠÇ—î•ñƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public new DataSet GetKanriJohoHoshu(string strShuKEY)
        {
            const string THIS_METHOD_NAME = "GetKanriJohoHoshu";     // ƒƒ\ƒbƒh–¼
            DataSet csRet;
            string strMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            try
            {
                m_cfLog.DebugStartWrite(strMethodName);

                // ƒLƒƒƒbƒVƒ…‚©‚çƒf[ƒ^‚ðŽæ“¾
                csRet = GetKanriJohoHoshu(strShuKEY, string.Empty);

                m_cfLog.DebugEndWrite(strMethodName);

                return csRet;
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite("yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z", default

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
          */);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4953


                Input:
                " + objAppExp.p_strErrorCode + "z", _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5050


                Input:
                " + objAppExp.Message + "z")
                            Throw objAppExp
                        Catch objExp As Exception
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite("yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5213


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 5298


                                Input:
                                " + THIS_METHOD_NAME + "z", _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÇ—î•ñƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Private Function GetKanriJohoHoshu(ByVal strShuKEY As String, _
        // *                                                      ByVal strShikibetsuKEY As String) As DataSet
        // * 
        // * ‹@”\           Žw’è‚³‚ê‚½ŠÇ—î•ñƒ}ƒXƒ^‚ððŒ‚É‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strShuKEY As String        : Ží•ÊƒL[iŠÇ—î•ñƒ}ƒXƒ^Žæ“¾Žž‚ÌƒL[j
        // *                strShikibetsuKEY As String : Ž¯•ÊƒL[iŠÇ—î•ñƒ}ƒXƒ^Žæ“¾Žž‚ÌƒL[j
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½ŠÇ—î•ñƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public new DataSet GetKanriJohoHoshu(string strShuKEY, string strShikibetsuKEY)
        {
            DataSet csDS;
            DataSet csRetDS;
            var csDRs = default(DataRow[]);
            int intI;
            DataTable csRetDT;
            var csSB = new StringBuilder();

            // ƒLƒƒƒbƒVƒ…‚©‚çŠÇ—î•ñ‚ÌŽæ“¾
            csDS = GetDataFromCache();

            // FilterðŒ‚Ìì¬
            if (!string.IsNullOrEmpty(strShuKEY))
            {
                csSB.Append(ABAtenaKanriJohoEntity.SHUKEY).Append(" = '").Append(strShuKEY).Append("'");
                if (!string.IsNullOrEmpty(strShikibetsuKEY))
                {
                    csSB.Append(" AND ");
                }
            }
            if (!string.IsNullOrEmpty(strShikibetsuKEY))
            {
                csSB.Append(ABAtenaKanriJohoEntity.SHIKIBETSUKEY).Append(" = '").Append(strShikibetsuKEY).Append("'");
            }
            if (csSB.RLength > 0)
            {
                csDRs = csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Select(csSB.ToString());
            }

            csRetDS = csDS.Clone;
            csRetDT = csRetDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME);
            var loopTo = csDRs.Length - 1;
            for (intI = 0; intI <= loopTo; intI++)
                csRetDT.ImportRow(csDRs[intI]);
            return csRetDS;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÇ—î•ñƒ}ƒXƒ^Žæ“¾
        // * 
        // * \•¶           Private Function GetDataFromCache() As DataSet
        // * 
        // * ‹@”\           ŠÇ—î•ñƒ}ƒXƒ^‚ðƒLƒƒƒbƒVƒ…‚©‚çŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet
        // ************************************************************************************************
        private DataSet GetDataFromCache()
        {
            const string THIS_METHOD_NAME = "GetDataFromCache";     // ƒƒ\ƒbƒh–¼
            var cCacheData = default(CacheDataClass);
            DataSet csRet;

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(THIS_METHOD_NAME);

                lock (typeof(HttpContext))
                {
                    try
                    {
                        cCacheData = (CacheDataClass)HttpContext.Current.Cache[ABKANRIJOHO];
                    }
                    catch
                    {
                    }
                    if (cCacheData is null)
                    {
                        // *—š—ð”Ô† 000001 2014/06/11 C³ŠJŽn
                        // m_cfLog.DebugWrite("ƒLƒƒƒbƒVƒ…ì¬(ABKANRIJOHO)")
                        // cCacheData = New CacheDataClass()
                        // cCacheData.m_csDS = MyBase.GetKanriJohoHoshu(SHUBETSUKEY_KOJINJOHOSEIGYO)
                        // cCacheData.m_strUpdate = String.Empty
                        // HttpContext.Current.Cache(ABKANRIJOHO) = cCacheData

                        csRet = base.GetKanriJohoHoshu(SHUBETSUKEY_KOJINJOHOSEIGYO);

                        if (HttpContext.Current is not null)
                        {
                            // HttpContext.Current‚ªNothing‚Å‚È‚¢ê‡
                            m_cfLog.DebugWrite("ƒLƒƒƒbƒVƒ…ì¬(ABKANRIJOHO)");
                            cCacheData = new CacheDataClass();
                            cCacheData.m_csDS = csRet;
                            cCacheData.m_strUpdate = string.Empty;
                            HttpContext.Current.Cache[ABKANRIJOHO] = cCacheData;
                        }
                        else
                        {
                            // ‚»‚êˆÈŠO‚Ìê‡Aˆ—‚È‚µ
                        }
                    }
                    // *—š—ð”Ô† 000001 2014/06/11 C³I—¹
                    else
                    {
                        m_cfLog.DebugWrite("ƒLƒƒƒbƒVƒ…’†‚Éƒf[ƒ^—L");
                        // *—š—ð”Ô† 000001 2014/06/11 ’Ç‰ÁŠJŽn
                        csRet = cCacheData.m_csDS;
                        // *—š—ð”Ô† 000001 2014/06/11 ’Ç‰ÁI—¹
                    }
                    // *—š—ð”Ô† 000001 2014/06/11 íœŠJŽn
                    // csRet = cCacheData.m_csDS
                    // *—š—ð”Ô† 000001 2014/06/11 íœI—¹

                }

                m_cfLog.DebugEndWrite(THIS_METHOD_NAME);

                return csRet;
            }

            catch (UFAppException objAppExp)
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite("yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z", default

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
                                                 */);
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11022


                Input:
                " + objAppExp.p_strErrorCode + "z", _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11119


                Input:
                " + objAppExp.Message + "z")
                            Throw objAppExp
                        Catch objExp As Exception
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite("yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11282


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11367


                                Input:
                                " + THIS_METHOD_NAME + "z", _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }
        }
        #endregion
        #endregion

    }
}