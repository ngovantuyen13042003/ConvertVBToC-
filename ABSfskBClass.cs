// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‘—•tæƒ}ƒXƒ^‚c‚`(ABSfskBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/08@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/02/25 000001     ’ŠoðŒ‚©‚ç‹Æ–±“àŽí•ÊƒR[ƒh‚ð‚Í‚¸‚·‚Æ‚ ‚é‚ªA‹Æ–±“àŽí•ÊƒR[ƒh‚ð String.Empty‚Æ‚µ‚ÄŽæ“¾‚·‚é
// * 2003/03/10 000002     ZŠ‚b‚c“™‚Ì®‡«ƒ`ƒFƒbƒN‚ÉŒë‚è
// * 2003/03/17 000003     ’Ç‰ÁŽžA‹¤’Ê€–Ú‚ðÝ’è‚·‚é
// * 2003/03/27 000004     ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌŽQÆæ‚ð"AB"ŒÅ’è‚É‚·‚é
// * 2003/04/23 000005     I—¹”NŒŽ®‡«ƒ`ƒFƒbƒN‚Å"999999"‚ð‹–‚·
// * 2003/05/06 000006     ®‡«ƒ`ƒFƒbƒN•ÏX
// * 2003/05/21 000007     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/28 000008     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/10/30 000009     Žd—l•ÏXAƒJƒ^ƒJƒiƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2004/08/27 000010     ‘¬“x‰ü‘PFi‹{‘òj
// * 2005/01/25 000011     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 2005/06/05 000012     ƒfƒoƒbƒNƒƒO‚Ìˆê•”‚ð‚Í‚¸‚·
// * 2005/06/16 000013     SQL•¶‚ðInsert,Update,Delete‚ÌŠeƒƒ\ƒbƒh‚ªŒÄ‚Î‚ê‚½Žž‚ÉŠeŽ©ì¬‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/12/14 000014     Žd—l•ÏXFs­‹æ‚b‚c‚Ìƒ`ƒFƒbƒNANK‚É•ÏX(ƒ}ƒ‹ƒS‘ºŽR)
// * 2007/03/09 000015     ‘—•tæî•ñŽæ“¾SQL‚Ìƒ\[ƒg‡‚ð•ÏX(‚Œ´)
// * 2010/03/04 000016     ‘—•tæƒ}ƒXƒ^’Šoˆ—‚ÌƒI[ƒo[ƒ[ƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2010/04/16 000017     VS2008‘Î‰ži”ä‰Ãj
// * 2020/08/21 000018     yAB32006z‘ã”[E‘—•tæƒƒ“ƒeƒiƒ“ƒXiÎ‡j
// * 2023/03/10 000019     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2023/08/22 000020     yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰ÁiàV–Øj
// * 2023/10/20 000021     yAB-0840-1z‘—•tæŠÇ—€–Ú’Ç‰Á(‘è)
// * 2023/12/05 000022     yAB-0840-1z‘—•tæŠÇ—€–Ú’Ç‰Á_’Ç‰ÁC³i’‡¼j
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABSfskBClass
    {
        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private string m_strUpdateSQL;                        // UPDATE—pSQL
        private string m_strDeleteSQL;                        // DELETE—pSQLi•¨—j
        private string m_strDelRonriSQL;                      // DELETE—pSQLi˜_—j
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;      // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“i•¨—j
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“i˜_—j

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABSfskBClass";
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh
                                                                                      // *—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
        private const int THIS_ONE = 1;
        private const string ALL0_YMD = "00000000";                                   // ”NŒŽ“úƒI[ƒ‹‚O
        private const string ALL9_YMD = "99999999";                                   // ”NŒŽ“úƒI[ƒ‹‚X
                                                                                      // *—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                                                                                      // * —š—ð”Ô† 000010 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        public bool m_blnBatch = false;               // ƒoƒbƒ`ƒtƒ‰ƒO
        private DataSet m_csDataSchma;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
                                         // * —š—ð”Ô† 000010 2004/08/27 ’Ç‰ÁI—¹
        private DataSet m_csDataSchma_Hyojun;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg_•W€”Å
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
        public ABSfskBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒƒ“ƒo•Ï”‚Ì‰Šú‰»
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDeleteSQL = string.Empty;
            m_strDelRonriSQL = string.Empty;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDeleteUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String  :Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsSfskEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABSfskEntity
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD)
        {
            return GetSfskBHoshu(strJuminCD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String, 
        // *                                                        ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String    :Z–¯ƒR[ƒh
        // *                blnSakujoFG As Boolean  :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsSfskEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABSfskEntity
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetSfskBHoshu";              // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csSfskEntity;                                     // ‘—•tæƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                               // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABSfskEntity.TABLE_NAME);

                // * —š—ð”Ô† 000010 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABSfskEntity.TABLE_NAME, false);
                }
                // * —š—ð”Ô† 000010 2004/08/27 ’Ç‰ÁI—¹

                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABSfskEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABSfskEntity.KEY_JUMINCD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABSfskEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");
                }
                // ORDER•¶Œ‹‡
                // *—š—ð”Ô† 000015 2007/03/09 C³ŠJŽn
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABSfskEntity.GYOMUCD);
                strSQL.Append(" ASC, ");
                strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD);
                strSQL.Append(" ASC, ");
                // *—š—ð”Ô† 000020 2023/08/22 C³ŠJŽn
                strSQL.Append(ABSfskEntity.STYMD);
                strSQL.Append(" ASC;");
                // strSQL.Append(ABSfskEntity.STYM)
                // strSQL.Append(" ASC;")
                // *—š—ð”Ô† 000020 2023/08/22 C³I—¹
                // strSQL.Append(" ORDER BY ")
                // strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)
                // strSQL.Append(" ASC")
                // *—š—ð”Ô† 000015 2007/03/09 C³I—¹

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                // 'RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                // * —š—ð”Ô† 000011 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                if (m_blnBatch == false)
                {
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
                    // *—š—ð”Ô† 000008 2003/08/28 C³I—¹

                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                    // * —š—ð”Ô† 000010 2004/08/27 XVŠJŽni‹{‘òj
                    // csSfskEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11598


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If
                                                    '* —š—ð”Ô† 000011 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                         */
                    csSfskEntity = m_csDataSchma.Clone();
                    // m_csDataSchma.Clear()
                    // csSfskEntity = m_csDataSchma
                    csSfskEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csSfskEntity, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                    // * —š—ð”Ô† 000010 2004/08/27 XVI—¹

                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12970


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13073


                                Input:
                                " + exAppException.Message + "z")
                                            'ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13613


                Input:
                " + exException.Message + "z")
                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csSfskEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
                    '* 
                    '* \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String, 
                    '*                                                        ByVal strGyomuCD As String, 
                    '*                                                        ByVal strGyomunaiSHUCD As String, 
                    '*                                                        ByVal strKikanYMD As String) As DataSet
                    '* 
                    '* ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
        // *                strGyomuCD As String          :‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strKikanYMD As String         :ŠúŠÔ”NŒŽ“ú
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsSfskEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABSfskEntity
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, string strKikanYMD)
        {
            return GetSfskBHoshu(strJuminCD, strGyomuCD, strGyomunaiSHUCD, strKikanYMD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal strJuminCD As String, 
        // *                                                        ByVal strGyomuCD As String, 
        // *                                                        ByVal strGyomunaiSHUCD As String, 
        // *                                                        ByVal strKikanYMD As String, 
        // *                                                        ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
        // *                strGyomuCD As String          :‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strKikanYMD As String         :ŠúŠÔ”NŒŽ“ú
        // *                blnSakujoFG As Boolean        :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsSfskEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABSfskEntity
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, string strKikanYMD, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetSfskBHoshu";              // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csSfskEntity;                                     // ‘—•tæƒ}ƒXƒ^ƒf[ƒ^
            string strSQL;                                            // SQL•¶•¶Žš—ñ
                                                                      // * corresponds to VS2008 Start 2010/04/16 000017
                                                                      // Dim cfUFParameterClass As UFParameterClass                      'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                      // * corresponds to VS2008 End 2010/04/16 000017
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnSakujo;                                        // íœƒf[ƒ^“Ç‚Ýž‚Ý

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // * —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é
                int intWkKensu;
                intWkKensu = m_cfRdbClass.p_intMaxRows();
                // * —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é

                // SQL,ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                blnSakujo = blnSakujoFG;
                cfUFParameterCollectionClass = new UFParameterCollectionClass();
                strSQL = this.CreateSql_Param(strJuminCD, strGyomuCD, strGyomunaiSHUCD, true, strKikanYMD, blnSakujo, cfUFParameterCollectionClass);

                // *—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                // 'RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                // * —š—ð”Ô† 000011 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
                if (m_blnBatch == false)
                {
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default
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
                    // *—š—ð”Ô† 000008 2003/08/28 C³I—¹

                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // * —š—ð”Ô† 000010 2004/08/27 XVŠJŽni‹{‘òj
                    // csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19426


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If
                                                    '* —š—ð”Ô† 000011 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                         */
                    csSfskEntity = m_csDataSchma.Clone();
                    csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, csSfskEntity, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                    // * —š—ð”Ô† 000010 2004/08/27 XVI—¹

                    // * —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj•¡”Œ•Ô‚·ê‡‚ÍAæ“ª‚Æ“¯‚¶‹Æ–±“àŽí•ÊˆÈŠO‚Ì‚à‚Ì‚Ííœ‚·‚é
                    // ã‚Ì”Ô†‚Åˆê“xì¬‚µ‚½‚ªA•K—v‚È‚­‚È‚Á‚½‚Ì‚Åíœ
                    // If (strGyomuCD = "*1") Then
                    // If (csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows.Count > 1) Then
                    // Dim csDataRow As DataRow
                    // Dim csDataTable As DataTable
                    // Dim intRowCount As Integer
                    // csDataTable = csSfskEntity.Tables(ABSfskEntity.TABLE_NAME)
                    // csDataRow = csDataTable.Rows(0)
                    // For intRowCount = csDataTable.Rows.Count - 1 To 1 Step -1
                    // If (CType(csDataRow.Item(ABSfskEntity.GYOMUNAISHU_CD), String) <> CType(csDataTable.Rows(intRowCount).Item(ABSfskEntity.GYOMUNAISHU_CD), String)) Then
                    // csDataTable.Rows(intRowCount).Delete()
                    // End If
                    // Next
                    // csDataTable.AcceptChanges()
                    // End If
                    // End If
                    // * —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj•¡”Œ•Ô‚·ê‡‚ÍAæ“ª‚Æ“¯‚¶‹Æ–±“àŽí•ÊˆÈŠO‚Ì‚à‚Ì‚Ííœ‚·‚é

                    // * —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚µ‚½‚à‚Ì‚ðŒ³‚É–ß‚·
                    m_cfRdbClass.p_intMaxRows = intWkKensu;
                    // * —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚µ‚½‚à‚Ì‚ðŒ³‚É–ß‚·

                    // * —š—ð”Ô† 000011 2005/01/25 íœŠJŽni‹{‘òjã‚Å‘S•”“Ç‚Ýž‚Þ—l‚É‚µ‚½‚Ì‚Åíœ
                    // 'Žæ“¾Œ”
                    // If (csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows.Count() = 0) Then
                    // 'Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                    // If (strGyomunaiSHUCD <> "") Then
                    // 'SQL,ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                    // cfUFParameterCollectionClass = New UFParameterCollectionClass()
                    // strSQL = Me.CreateSql_Param(strJuminCD, strGyomuCD, strGyomunaiSHUCD, False, strKikanYM, blnSakujo, cfUFParameterCollectionClass)
                    // '*—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                    // ''RDBƒAƒNƒZƒXƒƒOo—Í
                    // 'm_cfLogClass.RdbWrite(m_cfControlData, _
                    // '                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // '                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // '                    "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // '                    "ySQL“à—e:" + strSQL + "z")

                    // ' RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                    // '*—š—ð”Ô† 000008 2003/08/28 C³I—¹
                    // 'SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass)
                    // 'Žæ“¾Œ”
                    // If (csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows.Count() = 0) Then
                    // 'Žæ“¾Œ”‚ª‚OŒ‚ÌŽž
                    // 'SQL,ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                    // cfUFParameterCollectionClass = New UFParameterCollectionClass()
                    // strSQL = Me.CreateSql_Param(strJuminCD, "00", strGyomunaiSHUCD, False, strKikanYM, blnSakujo, cfUFParameterCollectionClass)
                    // '*—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                    // ''RDBƒAƒNƒZƒXƒƒOo—Í
                    // 'm_cfLogClass.RdbWrite(m_cfControlData, _
                    // '                "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // '                "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // '                "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // '                "ySQL“à—e:" + strSQL + "z")

                    // ' RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                    // '*—š—ð”Ô† 000008 2003/08/28 C³I—¹
                    // 'SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass)
                    // End If
                    // ElseIf (strGyomuCD <> "00") Then
                    // 'SQL,ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                    // cfUFParameterCollectionClass = New UFParameterCollectionClass()
                    // strSQL = Me.CreateSql_Param(strJuminCD, "00", strGyomunaiSHUCD, False, strKikanYM, blnSakujo, cfUFParameterCollectionClass)
                    // '*—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                    // ''RDBƒAƒNƒZƒXƒƒOo—Í
                    // 'm_cfLogClass.RdbWrite(m_cfControlData, _
                    // '                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // '                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // '                    "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // '                    "ySQL“à—e:" + strSQL + "z")

                    // ' RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                    // '*—š—ð”Ô† 000008 2003/08/28 C³I—¹
                    // 'SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass)
                    // End If
                    // End If
                    // * —š—ð”Ô† 000011 2005/01/25 íœI—¹i‹{‘òjã‚Å‘S•”“Ç‚Ýž‚Þ—l‚É‚µ‚½‚Ì‚Åíœ

                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27565


                Input:
                " + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27666


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28202


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csSfskEntity

                    End Function

                    '*—š—ð”Ô† 000016 2010/03/04 ’Ç‰ÁŠJŽn

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
        // * 
        // * \•¶           Public Overloads Function GetSfskBHoshu(ByVal cABSfskGetParaX As ABSFSKGetParaXClass) As DataSet
        // * 
        // * ‹@”\@@    @ ‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”           cABSfskGetParaX   :   ‘—•tæî•ñƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsSfskEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABSfskEntity
        // ************************************************************************************************
        public DataSet GetSfskBHoshu(ABSFSKGetParaXClass cABSfskGetParaX)
        {
            const string THIS_METHOD_NAME = "GetSfskBHoshu";              // ƒƒ\ƒbƒh–¼
            DataSet csSfskEntity;                                     // ‘—•tæƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnAndFg = false;                                 // AND”»’èƒtƒ‰ƒO
            string strWork;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒXƒL[ƒ}Žæ“¾ˆ—
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABSfskEntity.TABLE_NAME, false);
                }
                else
                {
                }

                // SQL•¶‚Ìì¬
                // SELECT‹å
                strSQL.Append("SELECT * ");

                strSQL.Append(" FROM ").Append(ABSfskEntity.TABLE_NAME);

                // WHERE‹å
                strSQL.Append(" WHERE ");
                // ---------------------------------------------------------------------------------
                // Z–¯ƒR[ƒh
                if (cABSfskGetParaX.p_strJuminCD.Trim != string.Empty)
                {
                    // Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡

                    strSQL.Append(ABSfskEntity.JUMINCD).Append(" = ");
                    strSQL.Append(ABSfskEntity.KEY_JUMINCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD;
                    cfUFParameterClass.Value = (string)cABSfskGetParaX.p_strJuminCD;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // ‹Æ–±ƒR[ƒh
                if (cABSfskGetParaX.p_strGyomuCD.Trim != string.Empty)
                {
                    // ‹Æ–±ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABSfskEntity.GYOMUCD).Append(" = ");
                    strSQL.Append(ABSfskEntity.KEY_GYOMUCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD;
                    cfUFParameterClass.Value = cABSfskGetParaX.p_strGyomuCD;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // ‹Æ–±“àŽí•ÊƒR[ƒh
                if (cABSfskGetParaX.p_strGyomuneiSHU_CD.Trim != string.Empty)
                {
                    // ‹Æ–±“àŽí•ÊƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD).Append(" = ");
                    strSQL.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD;
                    cfUFParameterClass.Value = cABSfskGetParaX.p_strGyomuneiSHU_CD;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }

                // ---------------------------------------------------------------------------------
                // ŠúŠÔ
                if (cABSfskGetParaX.p_strKikanYM.Trim != string.Empty)
                {
                    // ŠúŠÔ‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append("(");
                    // *—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                    // strSQL.Append(ABSfskEntity.STYM)                    'ŠJŽn”NŒŽ
                    // strSQL.Append(" <= ")
                    // strSQL.Append(ABSfskEntity.KEY_STYM)
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABSfskEntity.EDYM)                    'I—¹”NŒŽ
                    // strSQL.Append(" >= ")
                    // strSQL.Append(ABSfskEntity.KEY_EDYM)
                    strSQL.Append(ABSfskEntity.STYMD);                    // ŠJŽn”NŒŽ
                    strSQL.Append(" <= ");
                    strSQL.Append(ABSfskEntity.KEY_STYMD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABSfskEntity.EDYMD);                    // I—¹”NŒŽ
                    strSQL.Append(" >= ");
                    strSQL.Append(ABSfskEntity.KEY_EDYMD);
                    // *—š—ð”Ô† 000021 2023/10/20 C³I—¹
                    strSQL.Append(")");

                    // ŠJŽn”NŒŽ
                    cfUFParameterClass = new UFParameterClass();
                    // *—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                    // cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYM
                    cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYMD;
                    // *—š—ð”Ô† 000021 2023/10/20 C³I—¹
                    cfUFParameterClass.Value = cABSfskGetParaX.p_strKikanYM;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // I—¹”NŒŽ
                    cfUFParameterClass = new UFParameterClass();
                    // *—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                    // cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYM
                    cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYMD;
                    // *—š—ð”Ô† 000021 2023/10/20 C³I—¹
                    cfUFParameterClass.Value = cABSfskGetParaX.p_strKikanYM;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // íœƒtƒ‰ƒO
                if (cABSfskGetParaX.p_strSakujoFG.Trim == string.Empty)
                {
                    // íœƒtƒ‰ƒOŽw’è‚ª‚È‚¢ê‡Aíœƒf[ƒ^‚Í’Šo‚µ‚È‚¢
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }
                    strSQL.Append(ABSfskEntity.SAKUJOFG).Append(" <> '1'");
                }

                // íœƒtƒ‰ƒOŽw’è‚ª‚ ‚éê‡Aíœƒf[ƒ^‚à’Šo‚·‚é
                else if (blnAndFg == true)
                {
                }
                // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡ASQL•¶¶¬ˆ—‚ðI—¹
                else
                {
                    // AND”»’èƒtƒ‰ƒO‚ª"False"‚Ìê‡ASQL•¶‚©‚ç¢WHERE£‚ðíœ
                    // íœ‚µ‚½SQL‚ðˆêŽž‘Þ”ð
                    strWork = strSQL.ToString().Replace("WHERE", string.Empty);

                    // strSQL‚ðƒNƒŠƒA‚µA‘Þ”ð‚µ‚½SQL‚ðƒZƒbƒg
                    strSQL.Length = 0;
                    strSQL.Append(strWork);
                }
                // ---------------------------------------------------------------------------------

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37816


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csSfskEntity = m_csDataSchma.Clone();
                csSfskEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csSfskEntity, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass, false);


                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38739


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38842


                                Input:
                                " + exAppException.Message + "z")
                                            'ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39382


                Input:
                " + exException.Message + "z")
                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csSfskEntity

                    End Function
                    '*—š—ð”Ô† 000016 2010/03/04 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }

        // *—š—ð”Ô† 000018 2020/08/21 ’Ç‰ÁŠJŽn
        #region ”

        /// <summary>
    /// ”í‘—•tæƒ}ƒXƒ^’Šo
    /// </summary>
    /// <param name="strJuminCD">Z–¯ƒR[ƒh</param>
    /// <returns>”í‘—•tæƒ}ƒXƒ^</returns>
    /// <remarks></remarks>
        public DataSet GetHiSfskBHoshu(string strJuminCD)
        {
            return GetHiSfskBHoshu(strJuminCD, false);
        }

        /// <summary>
    /// ”í‘—•tæƒ}ƒXƒ^’Šo
    /// </summary>
    /// <param name="strJuminCD">Z–¯ƒR[ƒh</param>
    /// <param name="blnSakujoFG">íœƒtƒ‰ƒO</param>
    /// <returns>”í‘—•tæƒ}ƒXƒ^</returns>
    /// <remarks></remarks>
        public DataSet GetHiSfskBHoshu(string strJuminCD, bool blnSakujoFG)

        {

            string THIS_METHOD_NAME = System.Reflection.MethodBase.GetCurrentMethod().Name;
            UFParameterClass cfParameterClass;
            UFParameterCollectionClass cfParameterCollectionClass;
            var csDataSet = default(DataSet);
            StringBuilder csSQL;

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒXƒL[ƒ}Žæ“¾ˆ—
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(string.Empty, ABSfskEntity.TABLE_NAME, false);
                }
                else
                {
                    // noop
                }

                // SQL•¶‚Ìì¬    
                csSQL = new StringBuilder();

                csSQL.AppendFormat("SELECT A.* FROM {0} AS A", ABSfskEntity.TABLE_NAME);
                csSQL.AppendFormat(" LEFT JOIN {0} AS B", ABBikoEntity.TABLE_NAME);
                csSQL.AppendFormat(" ON A.{0} = B.{1}", ABSfskEntity.JUMINCD, ABBikoEntity.DATAKEY1);
                csSQL.AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.GYOMUCD, ABBikoEntity.DATAKEY2);
                csSQL.AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.GYOMUNAISHU_CD, ABBikoEntity.DATAKEY3);
                // *—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                // * —š—ð”Ô† 000020 2023/08/22 C³ŠJŽn
                // .AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.STYMD, ABBikoEntity.DATAKEY4)
                // .AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.EDYMD, ABBikoEntity.DATAKEY5)
                // .AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.STYM, ABBikoEntity.DATAKEY4)
                // .AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.EDYM, ABBikoEntity.DATAKEY5)
                csSQL.AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.TOROKURENBAN, ABBikoEntity.DATAKEY4);
                csSQL.AppendFormat(" AND A.{0} = B.{1}", ABSfskEntity.RRKNO, ABBikoEntity.DATAKEY5);
                // * —š—ð”Ô† 000020 2023/08/22 C³I—¹
                // *—š—ð”Ô† 000021 2023/10/20 C³I—¹
                csSQL.Append(" WHERE");
                csSQL.AppendFormat(" B.{0} = '{1}'", ABBikoEntity.BIKOKBN, ABBikoEntity.DEFAULT.BIKOKBN.SFSK);
                csSQL.AppendFormat(" AND B.{0} = {1} AND B.{0} IS NOT NULL AND RTRIM(LTRIM(B.{0})) <> ''", ABBikoEntity.RESERVE, ABBikoEntity.PARAM_RESERVE);
                if (blnSakujoFG == true)
                {
                }
                // noop
                else
                {
                    csSQL.AppendFormat(" AND A.{0} <> '1'", ABSfskEntity.SAKUJOFG);
                }
                csSQL.Append(" ORDER BY");
                csSQL.AppendFormat(" A.{0} ASC,", ABSfskEntity.GYOMUCD);
                csSQL.AppendFormat(" A.{0} ASC,", ABSfskEntity.GYOMUNAISHU_CD);
                // * —š—ð”Ô† 000020 2023/08/22 C³ŠJŽn
                csSQL.AppendFormat(" A.{0} DESC", ABSfskEntity.STYMD);
                // .AppendFormat(" A.{0} DESC", ABSfskEntity.STYM)
                // * —š—ð”Ô† 000020 2023/08/22 C³I—¹

                csSQL.Append(";");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cfParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[‚ðì¬
                cfParameterClass = new UFParameterClass();
                cfParameterClass.ParameterName = ABBikoEntity.PARAM_RESERVE;
                cfParameterClass.Value = strJuminCD;

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^[ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚Éƒpƒ‰ƒ[ƒ^[ƒNƒ‰ƒX‚ð’Ç‰Á
                cfParameterCollectionClass.Add(cfParameterClass);

                // ƒoƒbƒ`”»’è
                if (m_blnBatch == false)
                {
                    m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + default



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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 44449


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(csSQL.ToString, cfParameterCollectionClass) + "z")
                                                    Else
                                                        ' noop
                                                    End If

                                                    ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csDataSet = m_csDataSchma.Clone();
                    csDataSet = m_cfRdbClass.GetDataSet(csSQL.ToString(), csDataSet, ABSfskEntity.TABLE_NAME, cfParameterCollectionClass, true);

                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
            }

            catch (UFAppException cfAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45411


                Input:
                " + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45508


                Input:
                " + cfAppExp.Message + "z")

                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45768


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;

                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45853


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                                 */
                throw;

            }

            return csDataSet;

        }

        #endregion
        // *—š—ð”Ô† 000018 2020/08/21 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertSfskB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @  ‘—•tæƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚éB
        // * 
        // * ˆø”           csDataRow As DataRow  :’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l         ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertSfskB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertSfskB";                // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intInsCnt;                                        // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateInsertSQL(csDataRow);
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁI—¹
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");          // ì¬“úŽž

                // *—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                // ŒÂ•Ê€–Ú•ÒW‚ðs‚¤
                csDataRow(ABSfskEntity.RRKNO) = THIS_ONE.ToString();                 // —š—ð”Ô†
                                                                                     // *—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABSfskEntity.TANMATSUID) = m_cfControlData.m_strClientId;  // ’[––‚h‚c
                csDataRow(ABSfskEntity.SAKUJOFG) = "0";                              // íœƒtƒ‰ƒO
                csDataRow(ABSfskEntity.KOSHINCOUNTER) = decimal.Zero;                // XVƒJƒEƒ“ƒ^
                csDataRow(ABSfskEntity.SAKUSEINICHIJI) = strUpdateDateTime;          // ì¬“úŽž
                csDataRow(ABSfskEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;   // ì¬ƒ†[ƒU[
                csDataRow(ABSfskEntity.KOSHINNICHIJI) = strUpdateDateTime;           // XV“úŽž
                csDataRow(ABSfskEntity.KOSHINUSER) = m_cfControlData.m_strUserId;    // XVƒ†[ƒU[

                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString.Trim);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strInsertSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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

                // SQL‚ÌŽÀs
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 50294


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000008 2003/08/28 C³I—¹

                                 */
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51173


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51276


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51818


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^XV
                    '* 
                    '* \•¶           Public Function UpdateSfskB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateSfskB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateSfskB";                // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                          // * corresponds to VS2008 Start 2010/04/16 000017
                                                                          // Dim csDataColumn As DataColumn
                                                                          // * corresponds to VS2008 End 2010/04/16 000017
            int intUpdCnt;                                        // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateUpdateSQL(csDataRow);
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁI—¹
                }

                // *—š—ð”Ô† 000022 2023/12/05 íœŠJŽn
                // '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                // '—š—ð”Ô†‚ÌƒJƒEƒ“ƒgƒAƒbƒv
                // csDataRow(ABSfskEntity.RRKNO) = CDec(csDataRow(ABSfskEntity.RRKNO)) + 1                             '—š—ð”Ô†
                // '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000022 2023/12/05 íœI—¹

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABSfskEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABSfskEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABSfskEntity.KOSHINCOUNTER) + 1m;             // XVƒJƒEƒ“ƒ^
                csDataRow(ABSfskEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // XV“úŽž
                csDataRow(ABSfskEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABSfskEntity.PREFIX_KEY.RLength) == ABSfskEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABSfskEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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

                // SQL‚ÌŽÀs
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 56578


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000008 2003/08/28 C³I—¹

                                 */
                intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 57457


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 57560


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 58102


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intUpdCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^íœi˜_—j
                    '* 
                    '* \•¶           Public Function DeleteSfskB(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðíœi˜_—j‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :íœƒf[ƒ^
        // * 
        // * –ß‚è’l         íœi˜_—jŒ”(Integer)
        // ************************************************************************************************
        public int DeleteSfskB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "DeleteSfskBi˜_—j";                // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                                  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000017
                                                                                  // Dim csDataColumn As DataColumn
                                                                                  // * corresponds to VS2008 End 2010/04/16 000017
            int intDelCnt;                                        // íœŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDelRonriSQL is null | string.IsNullOrEmpty(m_strDelRonriSQL) | m_cfDelRonriUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateDeleteRonriSQL(csDataRow);
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁI—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABSfskEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                  // ’[––‚h‚c
                csDataRow(ABSfskEntity.SAKUJOFG) = 1;                                                                // íœƒtƒ‰ƒO
                csDataRow(ABSfskEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABSfskEntity.KOSHINCOUNTER) + 1m;             // XVƒJƒEƒ“ƒ^
                csDataRow(ABSfskEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // XV“úŽž
                csDataRow(ABSfskEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                    // XVƒ†[ƒU[

                // *—š—ð”Ô† 000022 2023/12/05 íœŠJŽn
                // '* —š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                // csDataRow(ABSfskEntity.RRKNO) = CDec(csDataRow(ABSfskEntity.RRKNO)) + 1                             '—š—ð”Ô†
                // '* —š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000022 2023/12/05 íœI—¹

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABSfskEntity.PREFIX_KEY.RLength) == ABSfskEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfDelRonriUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strDelRonriSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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

                // SQL‚ÌŽÀs
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62734


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000008 2003/08/28 C³I—¹

                                 */
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63621


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63724


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw exAppException;
            }

            catch (Exception exException) // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 64267


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intDelCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^íœi•¨—j
                    '* 
                    '* \•¶           Public Overloads Function DeleteSfskB(ByVal csDataRow As DataRow, 
                    '*                                                      ByVal strSakujoKB As String) As Integer
                    '* 
                    '* ‹@”\@@    @  ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðíœi•¨—j‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow      :íœƒf[ƒ^
        // *                strSakujoKB As String     :íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         íœi•¨—jŒ”(Integer)
        // ************************************************************************************************
        public int DeleteSfskB(DataRow csDataRow, string strSakujoKB)
        {
            const string THIS_METHOD_NAME = "DeleteSfskBi•¨—j";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                          // * corresponds to VS2008 Start 2010/04/16 000017
                                                          // Dim csDataColumn As DataColumn
                                                          // * corresponds to VS2008 End 2010/04/16 000017
            int intDelCnt;                            // íœŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆø”‚Ìíœ‹æ•ª‚ðƒ`ƒFƒbƒN
                if (strSakujoKB != "D")
                {
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_DELETE_SAKUJOKB);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDeleteSQL is null | string.IsNullOrEmpty(m_strDeleteSQL) | m_cfDeleteUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateDeleteButsuriSQL(csDataRow);
                    // * —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁI—¹
                }

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDeleteUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABSfskEntity.PREFIX_KEY.RLength) == ABSfskEntity.PREFIX_KEY)
                    {
                        this.m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABSfskEntity.PREFIX_KEY.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000008 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strDeleteSQL + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                m_cfLogClass.RdbWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + default



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

                // SQL‚ÌŽÀs
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 68590


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000008 2003/08/28 C³I—¹

                                 */
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 69469


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intDelCnt

                    End Function

                    '* corresponds to VS2008 Start 2010/04/16 000017
                    ''* —š—ð”Ô† 000013 2005/06/16 íœŠJŽn
                    '''''************************************************************************************************
                    '''''* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
                    '''''* 
                    '''''* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '''''* 
                    '''''* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '''''* 
                    '''''* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '''''* 
                    '''''* –ß‚è’l         ‚È‚µ
                    '''''************************************************************************************************
                    ''''Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    ''''    Const THIS_METHOD_NAME As String = "CreateSQL"              '‚±‚Ìƒƒ\ƒbƒh–¼
                    ''''    Dim csDataColumn As DataColumn
                    ''''    Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                    ''''    Dim strInsertColumn As String                               '’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
                    ''''    Dim strInsertParam As String                                '’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
                    ''''    Dim strDelRonriSQL As New StringBuilder()                   '˜_—íœSQL•¶•¶Žš—ñ
                    ''''    Dim strDeleteSQL As New StringBuilder()                     '•¨—íœSQL•¶•¶Žš—ñ
                    ''''    Dim strWhere As New StringBuilder()                         'XVíœSQL•¶Where•¶•¶Žš—ñ

                    ''''    Try
                    ''''        'ƒfƒoƒbƒOƒƒOo—Í
                    ''''        m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                    ''''        'SELECT SQL•¶‚Ìì¬
                    ''''        m_strInsertSQL = "INSERT INTO " + ABSfskEntity.TABLE_NAME + " "
                    ''''        strInsertColumn = ""
                    ''''        strInsertParam = ""

                    ''''        'XVíœWhere•¶ì¬
                    ''''        strWhere.Append(" WHERE ")
                    ''''        strWhere.Append(ABSfskEntity.JUMINCD)
                    ''''        strWhere.Append(" = ")
                    ''''        strWhere.Append(ABSfskEntity.KEY_JUMINCD)
                    ''''        strWhere.Append(" AND ")
                    ''''        strWhere.Append(ABSfskEntity.GYOMUCD)
                    ''''        strWhere.Append(" = ")
                    ''''        strWhere.Append(ABSfskEntity.KEY_GYOMUCD)
                    ''''        strWhere.Append(" AND ")
                    ''''        strWhere.Append(ABSfskEntity.GYOMUNAISHU_CD)
                    ''''        strWhere.Append(" = ")
                    ''''        strWhere.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                    ''''        strWhere.Append(" AND ")
                    ''''        strWhere.Append(ABSfskEntity.STYM)
                    ''''        strWhere.Append(" = ")
                    ''''        strWhere.Append(ABSfskEntity.KEY_STYM)
                    ''''        strWhere.Append(" AND ")
                    ''''        strWhere.Append(ABSfskEntity.EDYM)
                    ''''        strWhere.Append(" = ")
                    ''''        strWhere.Append(ABSfskEntity.KEY_EDYM)
                    ''''        strWhere.Append(" AND ")
                    ''''        strWhere.Append(ABSfskEntity.KOSHINCOUNTER)
                    ''''        strWhere.Append(" = ")
                    ''''        strWhere.Append(ABSfskEntity.KEY_KOSHINCOUNTER)

                    ''''        'UPDATE SQL•¶‚Ìì¬
                    ''''        m_strUpdateSQL = "UPDATE " + ABSfskEntity.TABLE_NAME + " SET "

                    ''''        'DELETEi˜_—j SQL•¶‚Ìì¬
                    ''''        strDelRonriSQL.Append("UPDATE ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.TABLE_NAME)
                    ''''        strDelRonriSQL.Append(" SET ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.TANMATSUID)
                    ''''        strDelRonriSQL.Append(" = ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.PARAM_TANMATSUID)
                    ''''        strDelRonriSQL.Append(", ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.SAKUJOFG)
                    ''''        strDelRonriSQL.Append(" = ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.PARAM_SAKUJOFG)
                    ''''        strDelRonriSQL.Append(", ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.KOSHINCOUNTER)
                    ''''        strDelRonriSQL.Append(" = ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.PARAM_KOSHINCOUNTER)
                    ''''        strDelRonriSQL.Append(", ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.KOSHINNICHIJI)
                    ''''        strDelRonriSQL.Append(" = ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.PARAM_KOSHINNICHIJI)
                    ''''        strDelRonriSQL.Append(", ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.KOSHINUSER)
                    ''''        strDelRonriSQL.Append(" = ")
                    ''''        strDelRonriSQL.Append(ABSfskEntity.PARAM_KOSHINUSER)
                    ''''        strDelRonriSQL.Append(strWhere.ToString)
                    ''''        m_strDelRonriSQL = strDelRonriSQL.ToString

                    ''''        'DELETEi•¨—j SQL•¶‚Ìì¬
                    ''''        strDeleteSQL.Append("DELETE FROM ")
                    ''''        strDeleteSQL.Append(ABSfskEntity.TABLE_NAME)
                    ''''        strDeleteSQL.Append(strWhere.ToString)
                    ''''        m_strDeleteSQL = strDeleteSQL.ToString

                    ''''        'SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''''        m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass()

                    ''''        'UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''''        m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass()

                    ''''        'DELETEi˜_—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''''        m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass()

                    ''''        'DELETEi•¨—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    ''''        m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass()

                    ''''        'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                    ''''        For Each csDataColumn In csDataRow.Table.Columns
                    ''''            cfUFParameterClass = New UFParameterClass()

                    ''''            'INSERT SQL•¶‚Ìì¬
                    ''''            strInsertColumn += csDataColumn.ColumnName + ", "
                    ''''            strInsertParam += ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                    ''''            'SQL•¶‚Ìì¬
                    ''''            m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                    ''''            'INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''''            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                    ''''            m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''''            'UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''''            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                    ''''            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''''        Next csDataColumn

                    ''''        'INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                    ''''        strInsertColumn = strInsertColumn.Trim()
                    ''''        strInsertColumn = strInsertColumn.Trim(CType(",", Char))
                    ''''        strInsertParam = strInsertParam.Trim()
                    ''''        strInsertParam = strInsertParam.Trim(CType(",", Char))
                    ''''        m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")"

                    ''''        'UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                    ''''        m_strUpdateSQL = m_strUpdateSQL.Trim()
                    ''''        m_strUpdateSQL = m_strUpdateSQL.Trim(CType(",", Char))

                    ''''        'UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                    ''''        m_strUpdateSQL += strWhere.ToString

                    ''''        'UPDATE,DELETE(•¨—) ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                    ''''        'Z–¯ƒR[ƒh
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                    ''''        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        '‹Æ–±ƒR[ƒh
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                    ''''        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        '‹Æ–±“àŽí•ÊƒR[ƒh
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                    ''''        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'ŠJŽn”NŒŽ
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYM
                    ''''        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'I—¹”NŒŽ
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYM
                    ''''        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'XVƒJƒEƒ“ƒ^
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_KOSHINCOUNTER
                    ''''        m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''''        'DELETEi˜_—j ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    ''''        '’[––‚h‚c
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_TANMATSUID
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'íœƒtƒ‰ƒO
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_SAKUJOFG
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'XVƒJƒEƒ“ƒ^
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_KOSHINCOUNTER
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'XV“úŽž
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_KOSHINNICHIJI
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'XVƒ†[ƒU
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_KOSHINUSER
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'Z–¯ƒR[ƒh
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        '‹Æ–±ƒR[ƒh
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        '‹Æ–±“àŽí•ÊƒR[ƒh
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'ŠJŽn”NŒŽ
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYM
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'I—¹”NŒŽ
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYM
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                    ''''        'XVƒJƒEƒ“ƒ^
                    ''''        cfUFParameterClass = New UFParameterClass()
                    ''''        cfUFParameterClass.ParameterName = ABSfskEntity.KEY_KOSHINCOUNTER
                    ''''        m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                    ''''        ' ƒfƒoƒbƒOƒƒOo—Í
                    ''''        m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                    ''''    Catch exAppException As UFAppException
                    ''''        ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                    ''''        m_cfLogClass.WarningWrite(m_cfControlData, _
                    ''''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    ''''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    ''''                                    "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                    ''''                                    "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                    ''''        ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                    ''''        Throw exAppException

                    ''''    Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                    ''''        ' ƒGƒ‰[ƒƒOo—Í
                    ''''        m_cfLogClass.ErrorWrite(m_cfControlData, _
                    ''''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    ''''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    ''''                                    "yƒGƒ‰[“à—e:" + exException.Message + "z")
                    ''''        ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                    ''''        Throw exException

                    ''''    End Try
                    ''''End Sub
                    ''* —š—ð”Ô† 000013 2005/06/16 íœI—¹
                    '* corresponds to VS2008 Start 2010/04/16 000017

                    '* —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Insert—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           INSERT—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateInsertSQL"
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim csInsertColumn As StringBuilder                        '’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
                        Dim csInsertParam As StringBuilder                         '’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'INSERT SQL•¶‚Ìì¬
                            m_strInsertSQL = "INSERT INTO " + ABSfskEntity.TABLE_NAME + " "
                            csInsertColumn = New StringBuilder
                            csInsertParam = New StringBuilder

                            'INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass

                            'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                cfUFParameterClass = New UFParameterClass

                                ' INSERT SQL•¶‚Ìì¬
                                csInsertColumn.Append(csDataColumn.ColumnName)
                                csInsertColumn.Append(", ")

                                csInsertParam.Append(ABSfskEntity.PARAM_PLACEHOLDER)
                                csInsertParam.Append(csDataColumn.ColumnName)
                                csInsertParam.Append(", ")

                                'INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                            Next csDataColumn

                            'INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strInsertSQL += "(" + csInsertColumn.ToString.Trim().Trim(CType(",", Char)) + ")" _
                                    + " VALUES (" + csInsertParam.ToString.Trim().TrimEnd(CType(",", Char)) + ")"

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Update—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           UPDATE—p‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateUpdateSQL"
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strWhere As New StringBuilder                           'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABSfskEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.GYOMUNAISHU_CD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                            strWhere.Append(" AND ")
                            '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                            'strWhere.Append(ABSfskEntity.STYM)
                            'strWhere.Append(" = ")
                            'strWhere.Append(ABSfskEntity.KEY_STYM)
                            'strWhere.Append(" AND ")
                            'strWhere.Append(ABSfskEntity.EDYM)
                            'strWhere.Append(" = ")
                            'strWhere.Append(ABSfskEntity.KEY_EDYM)
                            strWhere.Append(ABSfskEntity.TOROKURENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_TOROKURENBAN)
                            '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_KOSHINCOUNTER)

                            'UPDATE SQL•¶‚Ìì¬
                            m_strUpdateSQL = "UPDATE " + ABSfskEntity.TABLE_NAME + " SET "

                            'UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                'Z–¯‚b‚cEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                                If Not (csDataColumn.ColumnName = ABSfskEntity.JUMINCD) AndAlso _
                                    Not (csDataColumn.ColumnName = ABSfskEntity.SAKUSEIUSER) AndAlso _
                                     Not (csDataColumn.ColumnName = ABSfskEntity.SAKUSEINICHIJI) Then
                                    cfUFParameterClass = New UFParameterClass

                                    'SQL•¶‚Ìì¬
                                    m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                    'UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                    cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                    m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                                End If

                            Next csDataColumn

                            'UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpdateSQL = m_strUpdateSQL.Trim()
                            m_strUpdateSQL = m_strUpdateSQL.Trim(CType(",", Char))

                            'UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpdateSQL += strWhere.ToString

                            'UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                            ''ŠJŽn”NŒŽ
                            'cfUFParameterClass = New UFParameterClass
                            'cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYM
                            'm_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            ''I—¹”NŒŽ
                            'cfUFParameterClass = New UFParameterClass
                            'cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYM
                            'm_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            '“o˜^˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_TOROKURENBAN
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                            'XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˜_—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           ˜_—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateDeleteRonriSQL"
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strDelRonriSQL As New StringBuilder                     '˜_—íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder                           'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABSfskEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.GYOMUNAISHU_CD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                            strWhere.Append(" AND ")
                            '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                            'strWhere.Append(ABSfskEntity.STYM)
                            'strWhere.Append(" = ")
                            'strWhere.Append(ABSfskEntity.KEY_STYM)
                            'strWhere.Append(" AND ")
                            'strWhere.Append(ABSfskEntity.EDYM)
                            'strWhere.Append(" = ")
                            'strWhere.Append(ABSfskEntity.KEY_EDYM)
                            strWhere.Append(ABSfskEntity.TOROKURENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_TOROKURENBAN)
                            '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_KOSHINCOUNTER)

                            'DELETEi˜_—j SQL•¶‚Ìì¬
                            strDelRonriSQL.Append("UPDATE ")
                            strDelRonriSQL.Append(ABSfskEntity.TABLE_NAME)
                            strDelRonriSQL.Append(" SET ")
                            strDelRonriSQL.Append(ABSfskEntity.TANMATSUID)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskEntity.PARAM_TANMATSUID)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskEntity.SAKUJOFG)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskEntity.PARAM_SAKUJOFG)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskEntity.KOSHINCOUNTER)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskEntity.PARAM_KOSHINCOUNTER)
                            '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskEntity.RRKNO)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskEntity.PARAM_RRKNO)
                            '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskEntity.KOSHINNICHIJI)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskEntity.PARAM_KOSHINNICHIJI)
                            strDelRonriSQL.Append(", ")
                            strDelRonriSQL.Append(ABSfskEntity.KOSHINUSER)
                            strDelRonriSQL.Append(" = ")
                            strDelRonriSQL.Append(ABSfskEntity.PARAM_KOSHINUSER)
                            strDelRonriSQL.Append(strWhere.ToString)
                            m_strDelRonriSQL = strDelRonriSQL.ToString

                            'DELETEi˜_—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDelRonriUFParameterCollectionClass = New UFParameterCollectionClass

                            'DELETEi˜_—j ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            '’[––‚h‚c
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_TANMATSUID
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'íœƒtƒ‰ƒO
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_SAKUJOFG
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                            '—š—ð”Ô†
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_RRKNO
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                            'XV“úŽž
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_KOSHINNICHIJI
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'XVƒ†[ƒU
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.PARAM_KOSHINUSER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                            ''ŠJŽn”NŒŽ
                            'cfUFParameterClass = New UFParameterClass
                            'cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYM
                            'm_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            ''I—¹”NŒŽ
                            'cfUFParameterClass = New UFParameterClass
                            'cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYM
                            'm_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '“o˜^˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_TOROKURENBAN
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                            'XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_KOSHINCOUNTER
                            m_cfDelRonriUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •¨—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateButsuriSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           •¨—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateDeleteButsuriSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateDeleteButsuriSQL"
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strDeleteSQL As New StringBuilder                       '•¨—íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder                           'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            'XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABSfskEntity.JUMINCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_JUMINCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.GYOMUNAISHU_CD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                            strWhere.Append(" AND ")
                            '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                            'strWhere.Append(ABSfskEntity.STYM)
                            'strWhere.Append(" = ")
                            'strWhere.Append(ABSfskEntity.KEY_STYM)
                            'strWhere.Append(" AND ")
                            'strWhere.Append(ABSfskEntity.EDYM)
                            'strWhere.Append(" = ")
                            'strWhere.Append(ABSfskEntity.KEY_EDYM)
                            strWhere.Append(ABSfskEntity.TOROKURENBAN)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_TOROKURENBAN)
                            '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                            strWhere.Append(" AND ")
                            strWhere.Append(ABSfskEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABSfskEntity.KEY_KOSHINCOUNTER)

                            'DELETEi•¨—j SQL•¶‚Ìì¬
                            strDeleteSQL.Append("DELETE FROM ")
                            strDeleteSQL.Append(ABSfskEntity.TABLE_NAME)
                            strDeleteSQL.Append(strWhere.ToString)
                            m_strDeleteSQL = strDeleteSQL.ToString

                            'DELETEi•¨—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass

                            'DELETE(•¨—) ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '‹Æ–±“àŽí•ÊƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                            ''ŠJŽn”NŒŽ
                            'cfUFParameterClass = New UFParameterClass
                            'cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYM
                            'm_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ''I—¹”NŒŽ
                            'cfUFParameterClass = New UFParameterClass
                            'cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYM
                            'm_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '“o˜^˜A”Ô
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_TOROKURENBAN
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                            'XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_KOSHINCOUNTER
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Sub
                    '* —š—ð”Ô† 000013 2005/06/16 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String,
                    '*                                             ByVal strValue As String)
                    '* 
                    '* ‹@”\@@       ‘—•tæƒ}ƒXƒ^‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¢‚Ü‚·B
                    '* 
                    '* ˆø”           strColumnName As String
                    '*                strValue As String
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue As String)
                        Const THIS_METHOD_NAME As String = "CheckColumnValue"       '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim objErrorStruct As UFErrorStruct                         'ƒGƒ‰[’è‹`\‘¢‘Ì

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            'm_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            If (IsNothing(m_cfDateClass)) Then
                                m_cfDateClass = New UFDateClass(m_cfConfigDataClass)
                                ' “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None
                            End If

                            Select Case strColumnName.ToUpper()
                                Case ABSfskEntity.JUMINCD                               'Z–¯ƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_JUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SHICHOSONCD                           'Žs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.KYUSHICHOSONCD                        '‹ŒŽs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_KYUSHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.GYOMUCD                               '‹Æ–±ƒR[ƒh
                                    If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_GYOMUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.GYOMUNAISHU_CD                        '‹Æ–±“àŽí•ÊƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_GYOMUNAISHU_CD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                '*—š—ð”Ô† 000021 2023/10/20 C³ŠJŽn
                                'Case ABSfskEntity.STYM                                  'ŠJŽn”NŒŽ
                                '    If Not (strValue = String.Empty Or strValue = "000000") Then
                                '        m_cfDateClass.p_strDateValue = strValue + "01"
                                '        If (Not m_cfDateClass.CheckDate()) Then
                                '            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                '            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                '            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_STYM)
                                '            '—áŠO‚ð¶¬
                                '            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                '        End If
                                '    End If
                                'Case ABSfskEntity.EDYM                                  'I—¹”NŒŽ
                                '    If Not (strValue = String.Empty Or strValue = "000000" Or strValue = "999999") Then
                                '        m_cfDateClass.p_strDateValue = strValue + "01"
                                '        If (Not m_cfDateClass.CheckDate()) Then
                                '            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                '            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                '            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_EDYM)
                                '            '—áŠO‚ð¶¬
                                '            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                '        End If
                                '    End If
                                Case ABSfskEntity.STYMD                                  'ŠJŽn”NŒŽ“ú
                                    If (Not (strValue = String.Empty Or strValue = ALL0_YMD)) Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_STYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If
                                Case ABSfskEntity.EDYMD                                  'I—¹”NŒŽ“ú
                                    If (Not (strValue = String.Empty Or strValue = ALL0_YMD Or strValue = ALL9_YMD)) Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_EDYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If
                                '*—š—ð”Ô† 000021 2023/10/20 C³I—¹
                                Case ABSfskEntity.SFSKDATAKB                            '‘—•tæƒf[ƒ^‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKDATAKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKKANNAIKANGAIKB                    '‘—•tæŠÇ“àŠÇŠO‹æ•ª
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKKANNAIKANGAIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKKANAMEISHO                        '‘—•tæƒJƒi–¼Ì
                                    '*—š—ð”Ô† 000009 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000009 2003/10/30 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKKANAMEISHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKKANJIMEISHO                       '‘—•tæŠ¿Žš–¼Ì
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKKANJIMEISHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKYUBINNO                           '‘—•tæ—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKYUBINNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKZJUSHOCD                          '‘—•tæZŠƒR[ƒh
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKZJUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKJUSHO                             '‘—•tæZŠ
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKJUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKBANCHI                            '‘—•tæ”Ô’n
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKBANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKKATAGAKI                          '‘—•tæ•û‘
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKKATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKRENRAKUSAKI1                      '‘—•tæ˜A—æ1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKRENRAKUSAKI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKRENRAKUSAKI2                      '‘—•tæ˜A—æ2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKRENRAKUSAKI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKGYOSEIKUCD                        '‘—•tæs­‹æƒR[ƒh
                                    '* —š—ð”Ô† 000014 2005/12/14 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '* —š—ð”Ô† 000014 2005/12/14 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKGYOSEIKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKGYOSEIKUMEI                       '‘—•tæs­‹æ–¼
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKGYOSEIKUMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKCHIKUCD1                          '‘—•tæ’n‹æƒR[ƒh1
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKCHIKUCD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKCHIKUMEI1                         '‘—•tæ’n‹æ–¼1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKCHIKUMEI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKCHIKUCD2                          '‘—•tæ’n‹æƒR[ƒh2
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKCHIKUCD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKCHIKUMEI2                         '‘—•tæ’n‹æ–¼2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKCHIKUMEI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKCHIKUCD3                          '‘—•tæ’n‹æƒR[ƒh3
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKCHIKUCD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SFSKCHIKUMEI3                         '‘—•tæ’n‹æ–¼3
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SFSKCHIKUMEI3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.RESERVE                               'ƒŠƒU[ƒu
                                    '‰½‚à‚µ‚È‚¢
                                Case ABSfskEntity.TANMATSUID                            '’[––ID
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SAKUJOFG                              'íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.KOSHINCOUNTER                         'XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SAKUSEINICHIJI                        'ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.SAKUSEIUSER                           'ì¬ƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.KOSHINNICHIJI                         'XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABSfskEntity.KOSHINUSER                            'XVƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                            '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                                Case ABSfskEntity.TOROKURENBAN                          '“o˜^˜A”Ô
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        '*—š—ð”Ô† 000022 2023/12/05 C³ŠJŽn
                                        ''—áŠO‚ð¶¬
                                        'Throw New UFAppException("”Žš€–Ú“ü—ÍƒGƒ‰[F‚`‚a‘—•tæ@“o˜^˜A”Ô", UFAppException.ERR_EXCEPTION)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_TOROKURENBAN)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        '*—š—ð”Ô† 000022 2023/12/05 C³I—¹
                                    End If

                                Case ABSfskEntity.RRKNO                                 '—š—ð”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        '*—š—ð”Ô† 000022 2023/12/05 C³ŠJŽn
                                        ''—áŠO‚ð¶¬
                                        'Throw New UFAppException("”Žš€–Ú“ü—ÍƒGƒ‰[F‚`‚a‘—•tæ@—š—ð”Ô†", UFAppException.ERR_EXCEPTION)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABSFSKB_RDBDATATYPE_RRKNO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        '*—š—ð”Ô† 000022 2023/12/05 C³I—¹
                                    End If
                                    '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                            End Select

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            'm_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException
                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException
                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‚r‚p‚k•¶Eƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ì¬
                    '* 
                    '* \•¶           Private Function CreateSql_Param(ByVal strJuminCD As String, 
                    '*                                                 ByVal strGyomuCD As String, 
                    '*                                                 ByVal strGyomunaiSHUCD As String, 
                    '*                                                 ByVal blnGyomunaiSHUCD As Boolean, 
                    '*                                                 ByVal strKikanYMD As String, 
                    '*                                                 ByVal blnSakujoFG As Boolean,
                    '*                                                 ByVal cfUFParameterCollectionClass As UFParameterCollectionClass)
                    '                                            As String
                    '* 
                    '* ‹@”\@@    @@‚r‚p‚k•¶‹y‚Ñƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚µˆø‚«“n‚·B
                    '* 
                    '* ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
                    '*                strGyomuCD As String          :‹Æ–±ƒR[ƒh
                    '*                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
                    '*                blnGyomunaiSHUCD As Boolean   :‹Æ–±“àŽí•ÊƒR[ƒh‚Ì—L–³iTrue:—L‚è,False:–³‚µj
                    '*                strKikanYMD As String         :ŠúŠÔ”NŒŽ“ú
                    '*                blnSakujo As Boolean          :íœƒf[ƒ^‚Ì—L–³(True:—L‚è,False:–³‚µ)
                    '*                cfUFParameterCollectionClass As UFParameterCollectionClass  :ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                    '* 
                    '* –ß‚è’l         ‚r‚p‚k•¶(String)
                    '*                ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX(UFParameterCollectionClass)
                    '************************************************************************************************
                    Private Function CreateSql_Param(ByVal strJuminCD As String, ByVal strGyomuCD As String,
                                                     ByVal strGyomunaiSHUCD As String, ByVal blnGyomunaiSHUCD As Boolean,
                                                     ByVal strKikanYMD As String, ByVal blnSakujoFG As Boolean,
                                                     ByVal cfUFParameterCollectionClass As UFParameterCollectionClass) As String
                        Const THIS_METHOD_NAME As String = "CreateSql_Param"            '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim strSQL As New StringBuilder                                 'SQL•¶•¶Žš—ñ
                        Dim cfUFParameterClass As UFParameterClass                      'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL•¶‚Ìì¬
                            strSQL.Append("SELECT * FROM ")
                            strSQL.Append(ABSfskEntity.TABLE_NAME)

                            '* —š—ð”Ô† 000010 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
                            If (m_csDataSchma Is Nothing) Then
                                m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABSfskEntity.TABLE_NAME, False)
                            End If
                            '* —š—ð”Ô† 000010 2004/08/27 ’Ç‰ÁI—¹

                            ' WHERE•¶Œ‹‡
                            strSQL.Append(" WHERE ")
                            strSQL.Append(ABSfskEntity.JUMINCD)                 'Z–¯ƒR[ƒh
                            strSQL.Append(" = ")
                            strSQL.Append(ABSfskEntity.KEY_JUMINCD)
                            If Not (strGyomuCD = "*1") Then
                                '* —š—ð”Ô† 000011 2005/01/25 XVŠJŽni‹{‘òj‹¤’Ê‚àˆê“x‚É“Ç‚Ýž‚Þ
                                'strSQL.Append(" AND ")
                                'strSQL.Append(ABSfskEntity.GYOMUCD)             '‹Æ–±ƒR[ƒh
                                'strSQL.Append(" = ")
                                'strSQL.Append(ABSfskEntity.KEY_GYOMUCD)
                                strSQL.Append(" AND ")
                                strSQL.Append(ABSfskEntity.GYOMUCD)             '‹Æ–±ƒR[ƒh
                                strSQL.Append(" IN(")
                                strSQL.Append(ABSfskEntity.KEY_GYOMUCD)
                                strSQL.Append(",'00')")
                                '* —š—ð”Ô† 000011 2005/01/25 XVI—¹i‹{‘òj

                                '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é
                                m_cfRdbClass.p_intMaxRows = 1
                                '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é
                            End If
                            strSQL.Append(" AND ")
                            '* —š—ð”Ô† 000011 2005/01/25 XVŠJŽni‹{‘òj‹¤’ÊŽí•Ê‚àˆê“x‚É“Ç‚Ýž‚Þ
                            'strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)      '‹Æ–±“àŽí•ÊƒR[ƒh
                            'strSQL.Append(" = ")
                            'strSQL.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                            If Not (strGyomuCD = "*1") Then
                                strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" IN(")
                                strSQL.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                                strSQL.Append(" ,'')")
                            Else
                                strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" = ")
                                strSQL.Append("''")
                            End If
                            '* —š—ð”Ô† 000011 2005/01/25 XVI—¹i‹{‘òj‹¤’ÊŽí•Ê‚àˆê“x‚É“Ç‚Ýž‚Þ

                            strSQL.Append(" AND (")
                            strSQL.Append(ABSfskEntity.STYMD)                    'ŠJŽn”NŒŽ“ú
                            strSQL.Append(" <= ")
                            strSQL.Append(ABSfskEntity.KEY_STYMD)
                            strSQL.Append(" AND ")
                            strSQL.Append(ABSfskEntity.EDYMD)                    'I—¹”NŒŽ“ú
                            strSQL.Append(" >= ")
                            strSQL.Append(ABSfskEntity.KEY_EDYMD)
                            strSQL.Append(")")
                            If Not (blnSakujoFG) Then
                                strSQL.Append(" AND ")
                                strSQL.Append(ABSfskEntity.SAKUJOFG)            'íœƒtƒ‰ƒO
                                strSQL.Append(" <> 1")
                            End If

                            '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òjˆê“x‚Å“Ç‚ñ‚¾‚à‚Ì‚ðƒ\[ƒg‚µ‚Äæ“ª‚Ì‚PŒ‚ð‘ÎÛ‚É‚·‚é
                            If Not (strGyomuCD = "*1") Then
                                strSQL.Append(" ORDER BY ")
                                strSQL.Append(ABSfskEntity.GYOMUCD)
                                strSQL.Append(" DESC,")
                                strSQL.Append(ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" DESC")
                            End If
                            '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òjˆê“x‚Å“Ç‚ñ‚¾‚à‚Ì‚ðƒ\[ƒg‚µ‚Äæ“ª‚Ì‚PŒ‚ð‘ÎÛ‚É‚·‚é

                            'ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                            cfUFParameterClass.Value = strJuminCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                            cfUFParameterClass.Value = strGyomuCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                            ' ‹Æ–±“àŽí•ÊƒR[ƒh
                            If Not (strGyomuCD = "*1") Then
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                                If (blnGyomunaiSHUCD) Then
                                    cfUFParameterClass.Value = strGyomunaiSHUCD
                                Else
                                    cfUFParameterClass.Value = String.Empty
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If
                            '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj

                            ' ŠJŽn”NŒŽ
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYMD
                            cfUFParameterClass.Value = strKikanYMD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' I—¹”NŒŽ
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYMD
                            cfUFParameterClass.Value = strKikanYMD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return strSQL.ToString

                    End Function
                    '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^ƒXƒL[ƒ}Žæ“¾
                    '* 
                    '* \•¶           Public Function GetSfskSchemaBHoshu() As DataSet
                    '* 
                    '* ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èƒXƒL[ƒ}Žæ“¾
                    '* 
                    '* 
                    '* –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌƒXƒL[ƒ}
                    '************************************************************************************************
                    Public Overloads Function GetSfskSchemaBHoshu() As DataSet
                        Const THIS_METHOD_NAME As String = "GetSfskSchemaBHoshu"              '‚±‚Ìƒƒ\ƒbƒh–¼

                        Try
                            If (m_csDataSchma Is Nothing) Then
                                Dim strSQL As New StringBuilder                                 'SQL•¶•¶Žš—ñ
                                'ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                'SQL•¶‚Ìì¬
                                strSQL.Append("SELECT * FROM ")
                                strSQL.Append(ABSfskEntity.TABLE_NAME)

                                m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABSfskEntity.TABLE_NAME, False)
                            End If
                            Return (m_csDataSchma.Clone)
                        Catch exAppException As UFAppException
                            'ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            'ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Function
                    '* —š—ð”Ô† 000011 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj

                    '*—š—ð”Ô† 000019 2023/03/10 ’Ç‰ÁŠJŽn
                #Region "‘—•tæƒ}ƒXƒ^’Šo_•W€”Å"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^’Šo_•W€”Å
                    '* 
                    '* \•¶           Public Overloads Function GetSfskBHoshu_Hyojun(ByVal strJuminCD As String, 
                    '*                                                        ByVal strGyomuCD As String, 
                    '*                                                        ByVal strGyomunaiSHUCD As String, 
                    '*                                                        ByVal strKikanYMD As String, 
                    '*                                                        ByVal blnSakujoFG As Boolean) As DataSet
                    '* 
                    '* ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
                    '* 
                    '* ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
                    '*                strGyomuCD As String          :‹Æ–±ƒR[ƒh
                    '*                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
                    '*                strKikanYMD As String         :ŠúŠÔ”NŒŽ“ú
                    '*                blnSakujoFG As Boolean        :íœƒtƒ‰ƒO
                    '* 
                    '* –ß‚è’l         Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
                    '*                   \‘¢FcsSfskEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABSfskEntity
                    '************************************************************************************************
                    Public Overloads Function GetSfskBHoshu_Hyojun(ByVal strJuminCD As String,
                                                            ByVal strGyomuCD As String,
                                                            ByVal strGyomunaiSHUCD As String,
                                                            ByVal strKikanYMD As String,
                                                            ByVal blnSakujoFG As Boolean) As DataSet
                        Const THIS_METHOD_NAME As String = "GetSfskBHoshu_Hyojun"       '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim csSfskEntity As DataSet                                     '‘—•tæƒ}ƒXƒ^ƒf[ƒ^
                        Dim strSQL As String                                            'SQL•¶•¶Žš—ñ
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass  'ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                        Dim blnSakujo As Boolean                                        'íœƒf[ƒ^“Ç‚Ýž‚Ý

                        Try
                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Dim intWkKensu As Integer
                            intWkKensu = m_cfRdbClass.p_intMaxRows()

                            'SQL,ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            blnSakujo = blnSakujoFG
                            cfUFParameterCollectionClass = New UFParameterCollectionClass()
                            strSQL = Me.CreateSql_Param_Hyojun(strJuminCD, strGyomuCD, strGyomunaiSHUCD, True, strKikanYMD, blnSakujo, cfUFParameterCollectionClass)

                            If (m_blnBatch = False) Then
                                m_cfLogClass.RdbWrite(m_cfControlData,
                                                            "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                                                            "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                                                            "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                                                            "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                            End If

                            'SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                            csSfskEntity = m_csDataSchma_Hyojun.Clone()
                            csSfskEntity = m_cfRdbClass.GetDataSet(strSQL, csSfskEntity, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

                            m_cfRdbClass.p_intMaxRows = intWkKensu

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csSfskEntity

                    End Function
                #End Region

                #Region "‚r‚p‚k•¶Eƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ì¬_•W€”Å"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‚r‚p‚k•¶Eƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ì¬_•W€”Å
                    '* 
                    '* \•¶           Private Function CreateSql_Param_Hyojun(ByVal strJuminCD As String, 
                    '*                                                 ByVal strGyomuCD As String, 
                    '*                                                 ByVal strGyomunaiSHUCD As String, 
                    '*                                                 ByVal blnGyomunaiSHUCD As Boolean, 
                    '*                                                 ByVal strKikanYMD As String, 
                    '*                                                 ByVal blnSakujoFG As Boolean,
                    '*                                                 ByVal cfUFParameterCollectionClass As UFParameterCollectionClass)
                    '                                            As String
                    '* 
                    '* ‹@”\@@    @@‚r‚p‚k•¶‹y‚Ñƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚µˆø‚«“n‚·B
                    '* 
                    '* ˆø”           strJuminCD As String          :Z–¯ƒR[ƒh
                    '*                strGyomuCD As String          :‹Æ–±ƒR[ƒh
                    '*                strGyomunaiSHUCD As String    :‹Æ–±“àŽí•ÊƒR[ƒh
                    '*                blnGyomunaiSHUCD As Boolean   :‹Æ–±“àŽí•ÊƒR[ƒh‚Ì—L–³iTrue:—L‚è,False:–³‚µj
                    '*                strKikanYMD As String         :ŠúŠÔ”NŒŽ“ú
                    '*                blnSakujo As Boolean          :íœƒf[ƒ^‚Ì—L–³(True:—L‚è,False:–³‚µ)
                    '*                cfUFParameterCollectionClass As UFParameterCollectionClass  :ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                    '* 
                    '* –ß‚è’l         ‚r‚p‚k•¶(String)
                    '*                ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX(UFParameterCollectionClass)
                    '************************************************************************************************
                    Private Function CreateSql_Param_Hyojun(ByVal strJuminCD As String, ByVal strGyomuCD As String,
                                                     ByVal strGyomunaiSHUCD As String, ByVal blnGyomunaiSHUCD As Boolean,
                                                     ByVal strKikanYMD As String, ByVal blnSakujoFG As Boolean,
                                                     ByVal cfUFParameterCollectionClass As UFParameterCollectionClass) As String
                        Const THIS_METHOD_NAME As String = "CreateSql_Param_Hyojun"     '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim strSQL As New StringBuilder                                 'SQL•¶•¶Žš—ñ
                        Dim cfUFParameterClass As UFParameterClass                      'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL•¶‚Ìì¬
                            strSQL.Append("SELECT ")
                            ' ‘—•tæƒ}ƒXƒ^‚Ì‘S€–ÚƒZƒbƒg
                            strSQL.AppendFormat(" {0}.*", ABSfskEntity.TABLE_NAME)
                            ' ‘—•tæƒ}ƒXƒ^_•W€‚Ì€–ÚƒZƒbƒg
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKANAKATAGAKI)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKTSUSHO)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKANATSUSHO)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHIMEIYUSENKB)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKEIJISHIMEI)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKANJISHIMEI)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHINSEISHAKANKEICD)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHINSEISHAMEI)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHIKUCHOSONCD)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKMACHIAZACD)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKTODOFUKEN)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHIKUCHOSON)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKMACHIAZA)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKBANCHICD1)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKBANCHICD2)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKBANCHICD3)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKATAGAKICD)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKRENRAKUSAKIKB)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKBN)
                            strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKTOROKUYMD)

                            strSQL.Append(" FROM ")
                            strSQL.Append(ABSfskEntity.TABLE_NAME)

                            ' ‘—•tæƒ}ƒXƒ^_•W€‚ð•t‰Á
                            strSQL.AppendFormat(" LEFT OUTER JOIN {0} ", ABSfskHyojunEntity.TABLE_NAME)
                            strSQL.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.JUMINCD,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.JUMINCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUCD,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.GYOMUCD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUNAISHU_CD,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.GYOMUNAISHU_CD)
                            strSQL.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.TOROKURENBAN,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.TOROKURENBAN)

                            If (m_csDataSchma_Hyojun Is Nothing) Then
                                m_csDataSchma_Hyojun = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABSfskEntity.TABLE_NAME, False)
                            End If

                            ' WHERE•¶Œ‹‡
                            strSQL.Append(" WHERE ")
                            strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.JUMINCD)               'Z–¯ƒR[ƒh
                            strSQL.Append(" = ")
                            strSQL.Append(ABSfskEntity.KEY_JUMINCD)
                            If Not (strGyomuCD = "*1") Then
                                strSQL.Append(" AND ")
                                strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUCD)           '‹Æ–±ƒR[ƒh
                                strSQL.Append(" IN(")
                                strSQL.Append(ABSfskEntity.KEY_GYOMUCD)
                                strSQL.Append(",'00')")

                                m_cfRdbClass.p_intMaxRows = 1
                            End If
                            strSQL.Append(" AND ")
                            If Not (strGyomuCD = "*1") Then
                                strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" IN(")
                                strSQL.Append(ABSfskEntity.KEY_GYOMUNAISHU_CD)
                                strSQL.Append(" ,'')")
                            Else
                                strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" = ")
                                strSQL.Append("''")
                            End If

                            strSQL.Append(" AND (")
                            strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.STYMD)                 'ŠJŽn”NŒŽ“ú
                            strSQL.Append(" <= ")
                            strSQL.Append(ABSfskEntity.KEY_STYMD)
                            strSQL.Append(" AND ")
                            strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.EDYMD)                 'I—¹”NŒŽ“ú
                            strSQL.Append(" >= ")
                            strSQL.Append(ABSfskEntity.KEY_EDYMD)
                            strSQL.Append(")")
                            If Not (blnSakujoFG) Then
                                strSQL.Append(" AND ")
                                strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.SAKUJOFG)            'íœƒtƒ‰ƒO
                                strSQL.Append(" <> 1")
                            End If

                            If Not (strGyomuCD = "*1") Then
                                strSQL.Append(" ORDER BY ")
                                strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUCD)
                                strSQL.Append(" DESC,")
                                strSQL.AppendFormat("{0}.{1}", ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUNAISHU_CD)
                                strSQL.Append(" DESC")
                            End If

                            'ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            'Z–¯ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_JUMINCD
                            cfUFParameterClass.Value = strJuminCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUCD
                            cfUFParameterClass.Value = strGyomuCD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ‹Æ–±“àŽí•ÊƒR[ƒh
                            If Not (strGyomuCD = "*1") Then
                                cfUFParameterClass = New UFParameterClass
                                cfUFParameterClass.ParameterName = ABSfskEntity.KEY_GYOMUNAISHU_CD
                                If (blnGyomunaiSHUCD) Then
                                    cfUFParameterClass.Value = strGyomunaiSHUCD
                                Else
                                    cfUFParameterClass.Value = String.Empty
                                End If
                                ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            End If

                            ' ŠJŽn”NŒŽ
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_STYMD
                            cfUFParameterClass.Value = strKikanYMD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' I—¹”NŒŽ
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABSfskEntity.KEY_EDYMD
                            cfUFParameterClass.Value = strKikanYMD
                            ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return strSQL.ToString

                    End Function
                #End Region

                #Region "‘—•tæƒ}ƒXƒ^ƒXƒL[ƒ}Žæ“¾_•W€”Å"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ‘—•tæƒ}ƒXƒ^ƒXƒL[ƒ}Žæ“¾_•W€”Å
                    '* 
                    '* \•¶           Public Function GetSfskSchemaBHoshu_Hyojun() As DataSet
                    '* 
                    '* ‹@”\@@    @@‘—•tæƒ}ƒXƒ^‚æ‚èƒXƒL[ƒ}Žæ“¾
                    '* 
                    '* 
                    '* –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘—•tæƒ}ƒXƒ^‚ÌƒXƒL[ƒ}
                    '************************************************************************************************
                    Public Overloads Function GetSfskSchemaBHoshu_Hyojun() As DataSet
                        Const THIS_METHOD_NAME As String = "GetSfskSchemaBHoshu_Hyojun"         '‚±‚Ìƒƒ\ƒbƒh–¼

                        Try
                            If (m_csDataSchma_Hyojun Is Nothing) Then
                                Dim strSQL As New StringBuilder                                 'SQL•¶•¶Žš—ñ
                                'ƒfƒoƒbƒOƒƒOo—Í
                                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                ' SQL•¶‚Ìì¬
                                strSQL.Append("SELECT ")
                                ' ‘—•tæƒ}ƒXƒ^‚Ì‘S€–ÚƒZƒbƒg
                                strSQL.AppendFormat(" {0}.*", ABSfskEntity.TABLE_NAME)
                                ' ‘—•tæƒ}ƒXƒ^_•W€‚Ì€–ÚƒZƒbƒg
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKANAKATAGAKI)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKTSUSHO)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKANATSUSHO)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHIMEIYUSENKB)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKEIJISHIMEI)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKANJISHIMEI)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHINSEISHAMEI)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHINSEISHAKANKEICD)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHIKUCHOSONCD)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKMACHIAZACD)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKTODOFUKEN)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKSHIKUCHOSON)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKMACHIAZA)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKBANCHICD1)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKBANCHICD2)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKBANCHICD3)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKATAGAKICD)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKRENRAKUSAKIKB)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKKBN)
                                strSQL.AppendFormat(", {0}.{1}", ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.SFSKTOROKUYMD)

                                strSQL.Append(" FROM ")
                                strSQL.Append(ABSfskEntity.TABLE_NAME)

                                ' ‘—•tæƒ}ƒXƒ^_•W€‚ð•t‰Á
                                strSQL.AppendFormat(" LEFT OUTER JOIN {0} ", ABSfskHyojunEntity.TABLE_NAME)
                                strSQL.AppendFormat(" ON {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.JUMINCD,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.JUMINCD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUCD,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.GYOMUCD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.GYOMUNAISHU_CD,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.GYOMUNAISHU_CD)
                                strSQL.AppendFormat(" AND {0}.{1} = {2}.{3} ",
                                                    ABSfskEntity.TABLE_NAME, ABSfskEntity.TOROKURENBAN,
                                                    ABSfskHyojunEntity.TABLE_NAME, ABSfskHyojunEntity.TOROKURENBAN)

                                m_csDataSchma_Hyojun = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABSfskEntity.TABLE_NAME, False)
                            End If
                            Return (m_csDataSchma_Hyojun.Clone)
                        Catch exAppException As UFAppException
                            'ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            'ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Function
                #End Region
                    '*—š—ð”Ô† 000019 2023/03/10 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     AB‘ã”[‘—•tæ—ÝÏŽæ“¾
                    '* 
                    '* \•¶           Public Overloads Function GetABdainosfskruiseki(ByVal csDataRow As DataRow) As String
                    '* 
                    '* ‹@”\           AB‘ã”[‘—•tæ—ÝÏ‚æ‚è“o˜^˜A”Ô‚ðŽæ“¾
                    '* 
                    '* ˆø”           csDataRow As DataRow          :sƒf[ƒ^
                    '* 
                    '* –ß‚è’l         “o˜^˜A”Ô
                    '************************************************************************************************
                    Public Overloads Function GetABdainosfskruiseki(ByVal csDataRow As DataRow) As String
                        Const THIS_METHOD_NAME As String = "GetABdainosfskruiseki"      ' ‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim strSQL As New StringBuilder                                 ' SQL•¶•¶Žš—ñ
                        Dim csSfskEntity As DataSet                                     ' ‘—•tæƒ}ƒXƒ^ƒf[ƒ^
                        Dim cfUFParameterCollectionClass As UFParameterCollectionClass  ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
                        Dim strTorokurenban As String                                   ' “o˜^˜A”Ô

                        Try

                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ƒXƒL[ƒ}Žæ“¾ˆ—
                            If (m_csDataSchma Is Nothing) Then
                                m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString, ABSfskEntity.TABLE_NAME, False)
                            Else
                            End If

                            'SQL•¶‚Ìì¬
                            strSQL.Append("SELECT ")
                            strSQL.Append("MAX( ")
                            strSQL.Append(ABDainoSfskRuisekiEntity.TOROKURENBAN)
                            strSQL.Append(") ")
                            strSQL.Append(" FROM ")
                            strSQL.Append(ABDainoSfskRuisekiEntity.TABLE_NAME)

                            strSQL.Append(" WHERE ")
                            'Z–¯ƒR[ƒh++
                            strSQL.Append(ABDainoSfskRuisekiEntity.JUMINCD)
                            strSQL.Append(" = ")
                            strSQL.Append(csDataRow(ABDainoSfskRuisekiEntity.JUMINCD))
                            '‹Æ–±ƒR[ƒh
                            strSQL.Append(" AND ")
                            strSQL.Append(ABDainoSfskRuisekiEntity.GYOMUCD)
                            strSQL.Append(" = ")
                            strSQL.Append(csDataRow(ABDainoSfskRuisekiEntity.GYOMUCD))
                            '‹Æ–±“àŽí•ÊƒR[ƒh
                            strSQL.Append(" AND ")
                            strSQL.Append(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD)
                            strSQL.Append(" = ")
                            If (csDataRow(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD).ToString = String.Empty) Then
                                strSQL.Append("''")
                            Else
                                strSQL.Append(csDataRow(ABDainoSfskRuisekiEntity.GYOMUNAISHU_CD))
                            End If
                            'ˆ—‹æ•ª
                            strSQL.Append(" AND ")
                            strSQL.Append(ABDainoSfskRuisekiEntity.SHORIKB)
                            strSQL.Append(" IN ('")
                            strSQL.Append(ABConstClass.SFSK_ADD)            ' ’Ç‰Ái‘—•tæj
                            strSQL.Append("','")
                            strSQL.Append(ABConstClass.SFSK_SHUSEI)         ' C³i‘—•tæj
                            strSQL.Append("','")
                            strSQL.Append(ABConstClass.SFSK_DELETE)         ' íœi‘—•tæj
                            strSQL.Append("')")

                           ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                 "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                  "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                  "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                                                  "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                            csSfskEntity = m_csDataSchma.Clone()
                            csSfskEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csSfskEntity, ABSfskEntity.TABLE_NAME, cfUFParameterCollectionClass, False)

                            'ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            '“o˜^˜A”Ô‚ðŽæ“¾‚·‚éB
                            If (csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows.Count > 0) Then
                                If (Not (IsDBNull(csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows(0).Item(0)))) Then
                                    strTorokurenban = csSfskEntity.Tables(ABSfskEntity.TABLE_NAME).Rows(0).Item(0).ToString()
                                End If
                            End If

                            '“o˜^˜A”Ô‚ªŽæ“¾‚Å‚«‚È‚¢ê‡0‚ðƒZƒbƒg‚·‚é
                            If (strTorokurenban = String.Empty) Then
                                strTorokurenban = "0"
                            End If

                            Return strTorokurenban

                        Catch exAppException As UFAppException
                            'ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            'ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw exAppException

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            'ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try
                    End Function
                    '*—š—ð”Ô† 000021 2023/10/20 ’Ç‰ÁI—¹
                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}