// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚a‘ã”[ƒ}ƒXƒ^‚c‚`(ABDainoBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/06@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/02/25 000001     ’ŠoðŒ‚©‚ç‹Æ–±“àŽí•ÊƒR[ƒh‚ð‚Í‚¸‚·‚Æ‚ ‚é‚ªA‹Æ–±“àŽí•ÊƒR[ƒh‚ð String.Empty‚Æ‚µ‚ÄŽæ“¾‚·‚é
// * 2003/03/27 000002     ƒGƒ‰[ˆ—ƒNƒ‰ƒX‚ÌŽQÆæ‚ð"AB"ŒÅ’è‚É‚·‚é
// * 2003/04/21 000003     ®‡«ƒ`ƒFƒbƒN•ÏX(‹Æ–±“àŽí•ÊEŠJŽn”NŒŽEI—¹”NŒŽ)
// * 2003/05/06 000004     ®‡«ƒ`ƒFƒbƒN•ÏX
// * 2003/05/20 000005     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/28 000006     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/09/11 000007     ’[––‚h‚c®‡«ƒ`ƒFƒbƒN‚ðANK‚É‚·‚é
// * 2003/10/09 000008     ì¬ƒ†[ƒU[EXVƒ†[ƒU[ƒ`ƒFƒbƒN‚Ì•ÏX
// * 2004/08/27 000009     ‘¬“x‰ü‘PFi‹{‘òj
// * 2005/01/25 000010     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 2005/06/16 000011     SQL•¶‚ðInsert,Update,Delete‚ÌŠeƒƒ\ƒbƒh‚ªŒÄ‚Î‚ê‚½Žž‚ÉŠeŽ©ì¬‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2006/12/22 000012     –{“Xî•ñŽæ“¾ƒƒ\ƒbƒh‚ð’Ç‰ÁB
// * 2007/03/09 000013     ‘ã”[î•ñŽæ“¾SQL‚Ìƒ\[ƒg‡‚ð•ÏX(‚Œ´)
// * 2010/03/05 000014     ‘ã”[ƒ}ƒXƒ^’Šoˆ—‚ÌƒI[ƒo[ƒ[ƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2010/04/16 000015     VS2008‘Î‰ži”ä‰Ãj
// * 2023/03/10 000016     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// * 2023/04/20 000017     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ž_Žb’è‘Î‰ži’‡¼j
// * 2023/10/19 000018     yAB-0840-1z‘—•tæŠÇ—€–Ú’Ç‰Á‘Î‰žiŒ©éj
// * 2023/12/05 000019     yAB-0840-1z‘—•tæŠÇ—€–Ú’Ç‰Á‘Î‰ž_’Ç‰ÁC³i’‡¼j
// ************************************************************************************************
using System;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    // ************************************************************************************************
    // *
    // * ‘ã”[ƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABDainoBClass
    {
        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private string m_strUpdateSQL;                        // UPDATE—pSQL
        private string m_strDelRonriSQL;                      // ˜_—íœ—pSQL
        private string m_strDelButuriSQL;                     // •¨—íœ—pSQL
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;      // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;      // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollectionClass;    // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelButuriUFParameterCollectionClass;   // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfParameterCollectionClass;            // “Çž—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABDainoBClass";                       // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                                  // ‹Æ–±ƒR[ƒh

        // * —š—ð”Ô† 000009 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        public bool m_blnBatch = false;               // ƒoƒbƒ`ƒtƒ‰ƒO
        private DataSet m_csDataSchma;   // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg
                                         // * —š—ð”Ô† 000009 2004/08/27 ’Ç‰ÁI—¹
                                         // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
        private const string ALL0_YMD = "00000000";            // ”NŒŽ“úƒI[ƒ‹‚O
        private const string ALL9_YMD = "99999999";            // ”NŒŽ“úƒI[ƒ‹‚X
                                                               // * —š—ð”Ô† 000018 2023/10/19 C³I—¹

        #endregion

        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // *                               ByVal cfConfigDataClass As UFConfigDataClass, 
        // *                               ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABDainoBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”‰Šú‰»
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDelRonriSQL = string.Empty;
            m_strDelButuriSQL = string.Empty;
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDelRonriUFParameterCollectionClass = (object)null;
            m_cfDelButuriUFParameterCollectionClass = (object)null;
            m_cfParameterCollectionClass = (object)null;
            // * —š—ð”Ô† 000009 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABDainoEntity.TABLE_NAME, ABDainoEntity.TABLE_NAME, false);
            // * —š—ð”Ô† 000009 2004/08/27 ’Ç‰ÁI—¹
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetDainoBHoshu(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetDainoBHoshu(string strJuminCD)
        {
            return GetDainoBHoshu(strJuminCD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetDainoBHoshu(ByVal strJuminCD As String,
        // *                                               ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒh
        // *                blnSakujoFG  : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetDainoBHoshu(string strJuminCD, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetDainoBHoshu";
            // * corresponds to VS2008 Start 2010/04/16 000015
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000015
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;
            var csDataSet = default(DataSet);                            // ƒf[ƒ^ƒZƒbƒg
            var strSQL = new StringBuilder("");

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // ‚È‚µ

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬    
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABDainoEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABDainoEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABDainoEntity.KEY_JUMINCD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");
                }
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABDainoEntity.GYOMUCD);
                strSQL.Append(" ASC, ");
                strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                strSQL.Append(" ASC");
                // *—š—ð”Ô† 000013 2007/03/09 ’Ç‰ÁŠJŽn
                strSQL.Append(", ");
                strSQL.Append(ABDainoEntity.STYMD);
                strSQL.Append(" ASC");
                // *—š—ð”Ô† 000013 2007/03/09 ’Ç‰ÁI—¹
                strSQL.Append(";");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
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
                    // *—š—ð”Ô† 000006 2003/08/28 C³I—¹

                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // * —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11458


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If
                                                    '* —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                         */
                    csDataSet = m_csDataSchma.Clone();
                    csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, true);
                    // * —š—ð”Ô† 000009 2004/08/27 XVI—¹


                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
            }

            catch (UFAppException objAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12742


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12840


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13110


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13195


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csDataSet;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetDainoBHoshu(ByVal strJuminCD As String,
        // *                                               ByVal strGyomuCD As String,
        // *                                               ByVal strGyomunaiSHUCD As String,
        // *                                               ByVal strKikanYMD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD        : Z–¯ƒR[ƒh
        // *                strGyomuCD        : ‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strKikanYM        : ŠúŠÔ”NŒŽ“ú
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetDainoBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, string strKikanYMD)
        {
            return GetDainoBHoshu(strJuminCD, strGyomuCD, strGyomunaiSHUCD, strKikanYMD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetDainoBHoshu(ByVal strJuminCD As String,
        // *                                               ByVal strGyomuCD As String,
        // *                                               ByVal strGyomunaiSHUCD As String,
        // *                                               ByVal strKikanYMD As String,
        // *                                               ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD        : Z–¯ƒR[ƒh
        // *                strGyomuCD        : ‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strKikanYMD       : ŠúŠÔ”NŒŽ“ú
        // *                blnSakujoFG       : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetDainoBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, string strKikanYMD, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetDainoBHoshu";
            // * corresponds to VS2008 Start 2010/04/16 000015
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000015
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;
            var csDataSet = default(DataSet);                            // ƒf[ƒ^ƒZƒbƒg
            StringBuilder strSQL;
            UFDateClass cfDateClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // ‚È‚µ

                // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é
                int intWkKensu;
                intWkKensu = m_cfRdbClass.p_intMaxRows();
                // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é

                // SQL•¶‚Ìì¬    
                strSQL = new StringBuilder();
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABDainoEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABDainoEntity.JUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABDainoEntity.KEY_JUMINCD);
                if (!(strGyomuCD == "*1"))
                {
                    // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òj‹¤’Ê‘ã”[‚àˆê“x‚É“Ç‚Þ
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.GYOMUCD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_GYOMUCD)
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.GYOMUCD);
                    strSQL.Append(" IN(");
                    strSQL.Append(ABDainoEntity.KEY_GYOMUCD);
                    strSQL.Append(",'00')");
                    // * —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òj‹¤’Ê‘ã”[‚àˆê“x‚É“Ç‚Þ

                    // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é
                    m_cfRdbClass.p_intMaxRows = 1;
                    // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚·‚é
                }
                strSQL.Append(" AND ");

                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjŽí•Ê–³‚µ‚àˆê“x‚É“Ç‚Þ
                // strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD)
                // strSQL.Append(" = ")
                // strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD)
                if (!(strGyomuCD == "*1"))
                {
                    strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                    strSQL.Append(" IN(");
                    strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD);
                    strSQL.Append(" ,'')");
                }
                else
                {
                    strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                    strSQL.Append(" = ");
                    strSQL.Append("''");
                }
                // * —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjŽí•Ê–³‚µ‚àˆê“x‚É“Ç‚Þ

                strSQL.Append(" AND ");
                strSQL.Append(ABDainoEntity.STYMD);
                strSQL.Append(" <= ");
                strSQL.Append(ABDainoEntity.KEY_STYMD);
                strSQL.Append(" AND ");
                strSQL.Append(ABDainoEntity.EDYMD);
                strSQL.Append(" >= ");
                strSQL.Append(ABDainoEntity.KEY_EDYMD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");
                }

                // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òjˆê“x‚Å“Ç‚ñ‚¾‚à‚Ì‚ðƒ\[ƒg‚µ‚Äæ“ª‚Ì‚PŒ‚ð‘ÎÛ‚É‚·‚é
                if (!(strGyomuCD == "*1"))
                {
                    strSQL.Append(" ORDER BY ");
                    strSQL.Append(ABDainoEntity.GYOMUCD);
                    strSQL.Append(" DESC,");
                    strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                    strSQL.Append(" DESC");
                }
                // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁI—¹i‹{‘òjˆê“x‚Å“Ç‚ñ‚¾‚à‚Ì‚ðƒ\[ƒg‚µ‚Äæ“ª‚Ì‚PŒ‚ð‘ÎÛ‚É‚·‚é

                strSQL.Append(";");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf•¶‚ÅˆÍ‚Þ
                if (!(strGyomuCD == "*1"))
                {
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD;
                    cfUFParameterClass.Value = strGyomuCD;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                // * —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf•¶‚ÅˆÍ‚Þ

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                if (!(strGyomuCD == "*1"))
                {
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD;
                    cfUFParameterClass.Value = strGyomunaiSHUCD;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYMD;
                if (strKikanYMD.Trim().Length == 6)
                {
                    if (strKikanYMD.Trim() == "000000")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                    }
                    else if (strKikanYMD.Trim() == "999999")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                    }
                    else
                    {
                        cfDateClass = new UFDateClass(m_cfConfigDataClass);
                        cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                        // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                        // cfDateClass.p_strDateValue = strKikanYMD.Trim + "01"
                        cfDateClass.p_strDateValue = strKikanYMD.Trim() + "00";
                        // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                        cfUFParameterClass.Value = cfDateClass.GetLastDay();
                    }
                }
                else
                {
                    cfUFParameterClass.Value = strKikanYMD;
                }
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYMD;
                if (strKikanYMD.Trim().Length == 6)
                {
                    if (strKikanYMD.Trim() == "000000")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                    }
                    else if (strKikanYMD.Trim() == "999999")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                    }
                    else
                    {
                        // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                        // cfUFParameterClass.Value = strKikanYMD.Trim + "01"
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                        // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                    }
                }
                else
                {
                    cfUFParameterClass.Value = strKikanYMD;
                }
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
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
                    // *—š—ð”Ô† 000006 2003/08/28 C³I—¹

                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // * —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25152


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If
                                                    '* —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                         */
                    csDataSet = m_csDataSchma.Clone();
                    csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, true);
                    // * —š—ð”Ô† 000009 2004/08/27 XVI—¹

                    // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj•¡”Œ•Ô‚·ê‡‚ÍAæ“ª‚Æ“¯‚¶‹Æ–±“àŽí•ÊˆÈŠO‚Ì‚à‚Ì‚Ííœ‚·‚é
                    // ã‚Ì”Ô†‚Åˆê“xì¬‚µ‚½‚ªA•K—v‚È‚­‚È‚Á‚½‚Ì‚Åíœ
                    // If (strGyomuCD = "*1") Then
                    // If (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count > 1) Then
                    // Dim csDataRow As DataRow
                    // Dim csDataTable As DataTable
                    // Dim intRowCount As Integer
                    // csDataTable = csDataSet.Tables(ABDainoEntity.TABLE_NAME)
                    // csDataRow = csDataTable.Rows(0)
                    // For intRowCount = csDataTable.Rows.Count - 1 To 1 Step -1
                    // If (CType(csDataRow.Item(ABDainoEntity.GYOMUNAISHU_CD), String) <> CType(csDataTable.Rows(intRowCount).Item(ABDainoEntity.GYOMUNAISHU_CD), String)) Then
                    // csDataTable.Rows(intRowCount).Delete()
                    // End If
                    // Next
                    // csDataTable.AcceptChanges()
                    // End If
                    // End If
                    // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj•¡”Œ•Ô‚·ê‡‚ÍAæ“ª‚Æ“¯‚¶‹Æ–±“àŽí•ÊˆÈŠO‚Ì‚à‚Ì‚Ííœ‚·‚é

                    // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚µ‚½‚à‚Ì‚ðŒ³‚É–ß‚·
                    m_cfRdbClass.p_intMaxRows = intWkKensu;
                    // * —š—ð”Ô† 000010 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj‚PŒ‚¾‚¯“Ç‚Ýž‚Þ—l‚É‚µ‚½‚à‚Ì‚ðŒ³‚É–ß‚·

                    // * —š—ð”Ô† 000010 2005/01/25 íœŠJŽni‹{‘òj
                    // ' ƒf[ƒ^Œ”ƒ`ƒFƒbƒN
                    // If (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count = 0) Then

                    // ' ‹Æ–±“àŽí•Ê‚ªŽw’è‚³‚ê‚Ä‚¢‚½ê‡
                    // If Not (strGyomunaiSHUCD = String.Empty) Then

                    // ' SQL•¶‚Ìì¬
                    // strSQL = Nothing
                    // strSQL = New StringBuilder()
                    // strSQL.Append("SELECT * FROM ")
                    // strSQL.Append(ABDainoEntity.TABLE_NAME)
                    // strSQL.Append(" WHERE ")
                    // strSQL.Append(ABDainoEntity.JUMINCD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_JUMINCD)
                    // If Not (strGyomuCD = "*1") Then
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.GYOMUCD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_GYOMUCD)
                    // End If
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD)
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.STYM)
                    // strSQL.Append(" <= ")
                    // strSQL.Append(ABDainoEntity.KEY_STYM)
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.EDYM)
                    // strSQL.Append(" >= ")
                    // strSQL.Append(ABDainoEntity.KEY_EDYM)
                    // If Not blnSakujoFG Then
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.SAKUJOFG)
                    // strSQL.Append(" <> 1")
                    // End If
                    // strSQL.Append(";")

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    // cfUFParameterCollectionClass = New UFParameterCollectionClass()

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_JUMINCD
                    // cfUFParameterClass.Value = strJuminCD
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // If Not (strGyomuCD = "*1") Then
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD
                    // cfUFParameterClass.Value = strGyomuCD
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)
                    // End If

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD
                    // cfUFParameterClass.Value = ""
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYM
                    // cfUFParameterClass.Value = strKikanYM
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYM
                    // cfUFParameterClass.Value = strKikanYM
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // '*—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                    // '' RDBƒAƒNƒZƒXƒƒOo—Í
                    // 'm_cfLogClass.RdbWrite(m_cfControlData, _
                    // '                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // '                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // '                    "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // '                    "ySQL“à—e:" + strSQL.ToString + "z")

                    // ' RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                    // '*—š—ð”Ô† 000006 2003/08/28 C³I—¹

                    // ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // '* —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                    // 'csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
                    // csDataSet = m_csDataSchma.Clone()
                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, True)
                    // '* —š—ð”Ô† 000009 2004/08/27 XVI—¹


                    // End If

                    // End If

                    // ' ƒf[ƒ^Œ”ƒ`ƒFƒbƒN
                    // If (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count = 0) Then

                    // ' ‹Æ–±ƒR[ƒhih00hˆÈŠOj‚ªŽw’è‚³‚ê‚Ä‚¢‚½ê‡
                    // If Not (strGyomuCD = "00") Then

                    // ' SQL•¶‚Ìì¬
                    // strSQL = Nothing
                    // strSQL = New StringBuilder()
                    // strSQL.Append("SELECT * FROM ")
                    // strSQL.Append(ABDainoEntity.TABLE_NAME)
                    // strSQL.Append(" WHERE ")
                    // strSQL.Append(ABDainoEntity.JUMINCD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_JUMINCD)
                    // If Not (strGyomuCD = "*1") Then
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.GYOMUCD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_GYOMUCD)
                    // End If
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD)
                    // strSQL.Append(" = ")
                    // strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD)
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.STYM)
                    // strSQL.Append(" <= ")
                    // strSQL.Append(ABDainoEntity.KEY_STYM)
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.EDYM)
                    // strSQL.Append(" >= ")
                    // strSQL.Append(ABDainoEntity.KEY_EDYM)
                    // If Not blnSakujoFG Then
                    // strSQL.Append(" AND ")
                    // strSQL.Append(ABDainoEntity.SAKUJOFG)
                    // strSQL.Append(" <> 1")
                    // End If
                    // strSQL.Append(";")

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    // cfUFParameterCollectionClass = New UFParameterCollectionClass()

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_JUMINCD
                    // cfUFParameterClass.Value = strJuminCD
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // If Not (strGyomuCD = "*1") Then
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD
                    // cfUFParameterClass.Value = "00"
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)
                    // End If

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD
                    // cfUFParameterClass.Value = ""
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYM
                    // cfUFParameterClass.Value = strKikanYM
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    // cfUFParameterClass = New UFParameterClass()
                    // cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYM
                    // cfUFParameterClass.Value = strKikanYM
                    // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                    // '*—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                    // '' RDBƒAƒNƒZƒXƒƒOo—Í
                    // 'm_cfLogClass.RdbWrite(m_cfControlData, _
                    // '                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                    // '                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                    // '                    "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // '                    "ySQL“à—e:" + strSQL.ToString + "z")

                    // ' RDBƒAƒNƒZƒXƒƒOo—Í
                    // m_cfLogClass.RdbWrite(m_cfControlData, _
                    // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                    // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                    // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                    // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                    // '*—š—ð”Ô† 000006 2003/08/28 C³I—¹

                    // ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // '* —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                    // 'csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
                    // csDataSet = m_csDataSchma.Clone()
                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, True)
                    // '* —š—ð”Ô† 000009 2004/08/27 XVI—¹

                    // End If

                    // End If
                    // * —š—ð”Ô† 000010 2005/01/25 íœI—¹i‹{‘òj

                    // ƒNƒ‰ƒX‚Ì‰ð•ú
                    strSQL = null;

                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
            }

            catch (UFAppException objAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 39936


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40032


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40300


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 40383


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csDataSet;

        }


        // *—š—ð”Ô† 000014 2010/03/05 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^’Šo(µ°ÊÞ°Û°ÄÞ)
        // * 
        // * \•¶           Public Overloads Function GetDainoBHoshu(ByVal cABDainoGetParaX As ABDainoGetParaXClass) As DataSet
        // * 
        // * 
        // * ‹@”\@@    @ ‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           cABDainoGetParaX      :   ‘ã”[î•ñƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // *  
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetDainoBHoshu(ABDainoGetParaXClass cABDainoGetParaX)
        {
            const string THIS_METHOD_NAME = "GetDainoBHoshu";             // ƒƒ\ƒbƒh–¼
            DataSet csDainoEntity;                                    // ‘ã”[ƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnAndFg = false;                                 // AND”»’èƒtƒ‰ƒO
            string strWork;
            UFDateClass cfDateClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒXƒL[ƒ}Žæ“¾ˆ—
                if (m_csDataSchma is null)
                {
                    m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction(strSQL.ToString(), ABDainoEntity.TABLE_NAME, false);
                }
                else
                {
                }

                // SQL•¶‚Ìì¬
                // SELECT‹å
                strSQL.Append("SELECT * ");

                strSQL.Append(" FROM ").Append(ABDainoEntity.TABLE_NAME);

                // WHERE‹å
                strSQL.Append(" WHERE ");
                // ---------------------------------------------------------------------------------
                // Z–¯ƒR[ƒh
                if (cABDainoGetParaX.p_strJuminCD.Trim != string.Empty)
                {
                    // Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡

                    strSQL.Append(ABDainoEntity.JUMINCD).Append(" = ");
                    strSQL.Append(ABDainoEntity.KEY_JUMINCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_JUMINCD;
                    cfUFParameterClass.Value = (string)cABDainoGetParaX.p_strJuminCD;

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
                if (cABDainoGetParaX.p_strGyomuCD.Trim != string.Empty)
                {
                    // ‹Æ–±ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABDainoEntity.GYOMUCD).Append(" = ");
                    strSQL.Append(ABDainoEntity.KEY_GYOMUCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD;
                    cfUFParameterClass.Value = cABDainoGetParaX.p_strGyomuCD;

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
                if (cABDainoGetParaX.p_strGyomuneiSHU_CD.Trim != string.Empty)
                {
                    // ‹Æ–±“àŽí•ÊƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD).Append(" = ");
                    strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD;
                    cfUFParameterClass.Value = cABDainoGetParaX.p_strGyomuneiSHU_CD;

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
                // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                // If (cABDainoGetParaX.p_strKikanYM.Trim <> String.Empty) Then
                if (cABDainoGetParaX.p_strKikanYMD.Trim != string.Empty)
                {
                    // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                    // ŠúŠÔ‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append("(");
                    strSQL.Append(ABDainoEntity.STYMD);                    // ŠJŽn”NŒŽ“ú
                    strSQL.Append(" <= ");
                    strSQL.Append(ABDainoEntity.KEY_STYMD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.EDYMD);                    // I—¹”NŒŽ“ú
                    strSQL.Append(" >= ");
                    strSQL.Append(ABDainoEntity.KEY_EDYMD);
                    strSQL.Append(")");

                    // ŠJŽn”NŒŽ“ú
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYMD;
                    // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                    // If (cABDainoGetParaX.p_strKikanYM.Trim.Length = 6) Then
                    // If (cABDainoGetParaX.p_strKikanYM.Trim = "000000") Then
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM.Trim + "01"
                    // ElseIf (cABDainoGetParaX.p_strKikanYM.Trim = "999999") Then
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM.Trim + "99"
                    // Else
                    // cfDateClass = New UFDateClass(m_cfConfigDataClass)
                    // cfDateClass.p_enDateSeparator = UFDateSeparator.None
                    // cfDateClass.p_strDateValue = cABDainoGetParaX.p_strKikanYM.Trim + "01"
                    // cfUFParameterClass.Value = cfDateClass.GetLastDay()
                    // End If
                    // Else
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM
                    // End If

                    if (cABDainoGetParaX.p_strKikanYMD.Trim.Length == 6)
                    {
                        if (cABDainoGetParaX.p_strKikanYMD.Trim == ALL0_YMD)
                        {
                            cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD.Trim + "00";
                        }
                        else if (cABDainoGetParaX.p_strKikanYMD.Trim == ALL9_YMD)
                        {
                            cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD.Trim + "99";
                        }
                        else
                        {
                            cfDateClass = new UFDateClass(m_cfConfigDataClass);
                            cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                            cfDateClass.p_strDateValue = cABDainoGetParaX.p_strKikanYMD.Trim + "00";
                            cfUFParameterClass.Value = cfDateClass.GetLastDay();
                        }
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD;
                    }
                    // * —š—ð”Ô† 000018 2023/10/19 C³I—¹

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // I—¹”NŒŽ“ú
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYMD;
                    // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                    // If (cABDainoGetParaX.p_strKikanYM.Trim.Length = 6) Then
                    // If (cABDainoGetParaX.p_strKikanYM.Trim = "000000") Then
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM.Trim + "01"
                    // ElseIf (cABDainoGetParaX.p_strKikanYM.Trim = "999999") Then
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM.Trim + "99"
                    // Else
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM.Trim + "01"
                    // End If
                    // Else
                    // cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYM
                    // End If
                    if (cABDainoGetParaX.p_strKikanYMD.Trim.Length == 6)
                    {
                        if (cABDainoGetParaX.p_strKikanYMD.Trim == ALL0_YMD)
                        {
                            cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD.Trim + "00";
                        }
                        else if (cABDainoGetParaX.p_strKikanYMD.Trim == ALL9_YMD)
                        {
                            cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD.Trim + "99";
                        }
                        else
                        {
                            cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD.Trim + "00";
                        }
                    }
                    else
                    {
                        cfUFParameterClass.Value = cABDainoGetParaX.p_strKikanYMD;
                    }
                    // * —š—ð”Ô† 000018 2023/10/19 C³I—¹

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
                if (cABDainoGetParaX.p_strSakujoFG.Trim == string.Empty)
                {
                    // íœƒtƒ‰ƒOŽw’è‚ª‚È‚¢ê‡Aíœƒf[ƒ^‚Í’Šo‚µ‚È‚¢
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }
                    strSQL.Append(ABDainoEntity.SAKUJOFG).Append(" <> '1'");
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52914


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csDainoEntity = m_csDataSchma.Clone();
                csDainoEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDainoEntity, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, false);


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53843


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53946


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 54487


                Input:
                " + exException.Message + "z")
                            'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csDainoEntity

                    End Function
                    '*—š—ð”Ô† 000014 2010/03/05 ’Ç‰ÁI—¹

                 */
            }

            return default;
        }


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”í‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetHiDainoBHoshu(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒh
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetHiDainoBHoshu(string strJuminCD)
        {
            return GetHiDainoBHoshu(strJuminCD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”í‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetHiDainoBHoshu(ByVal strJuminCD As String,
        // *                                                 ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒh
        // *                blnSakujoFG   : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetHiDainoBHoshu(string strJuminCD, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetHiDainoBHoshu";
            // * corresponds to VS2008 Start 2010/04/16 000015
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000015
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;
            var csDataSet = default(DataSet);                            // ƒf[ƒ^ƒZƒbƒg
            var strSQL = new StringBuilder("");

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // ‚È‚µ

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬    
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABDainoEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABDainoEntity.DAINOJUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABDainoEntity.KEY_DAINOJUMINCD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");
                }
                strSQL.Append(" ORDER BY ");
                strSQL.Append(ABDainoEntity.GYOMUCD);
                strSQL.Append(" ASC, ");
                strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                strSQL.Append(" ASC");
                // *—š—ð”Ô† 000013 2007/03/09 ’Ç‰ÁŠJŽn
                strSQL.Append(", ");
                strSQL.Append(ABDainoEntity.STYMD);
                strSQL.Append(" ASC");
                // *—š—ð”Ô† 000013 2007/03/09 ’Ç‰ÁI—¹
                strSQL.Append(";");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_DAINOJUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
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
                    // *—š—ð”Ô† 000006 2003/08/28 C³I—¹

                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // * —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 59638


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If
                                                    '* —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                         */
                    csDataSet = m_csDataSchma.Clone();
                    csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, true);
                    // * —š—ð”Ô† 000009 2004/08/27 XVI—¹


                    // ƒfƒoƒbƒOƒƒOo—Í
                    m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
            }

            catch (UFAppException objAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 60922


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 61020


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 61290


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 61375


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csDataSet;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”í‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetHiDainoBHoshu(ByVal strJuminCD As String,
        // *                                                 ByVal strGyomuCD As String,
        // *                                                 ByVal strGyomunaiSHUCD As String,
        // *                                                 ByVal strKikanYMD As String) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD        : Z–¯ƒR[ƒh
        // *                strGyomuCD        : ‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strKikanYM        : ŠúŠÔ”NŒŽ“ú
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetHiDainoBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, string strKikanYMD)
        {
            return GetHiDainoBHoshu(strJuminCD, strGyomuCD, strGyomunaiSHUCD, strKikanYMD, false);
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ”í‘ã”[ƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetHiDainoBHoshu(ByVal strJuminCD As String,
        // *                                                 ByVal strGyomuCD As String,
        // *                                                 ByVal strGyomunaiSHUCD As String,
        // *                                                 ByVal strKikanYMD As String,
        // *                                                 ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD        : Z–¯ƒR[ƒh
        // *                strGyomuCD        : ‹Æ–±ƒR[ƒh
        // *                strGyomunaiSHUCD  : ‹Æ–±“àŽí•ÊƒR[ƒh
        // *                strKikanYM        : ŠúŠÔ”NŒŽ“ú
        // *                blnSakujoFG       : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½‘ã”[ƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetHiDainoBHoshu(string strJuminCD, string strGyomuCD, string strGyomunaiSHUCD, string strKikanYMD, bool blnSakujoFG)
        {

            const string THIS_METHOD_NAME = "GetHiDainoBHoshu";
            // * corresponds to VS2008 Start 2010/04/16 000015
            // Dim objErrorStruct As UFErrorStruct                 'ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000015
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;
            var csDataSet = default(DataSet);                            // ƒf[ƒ^ƒZƒbƒg
            StringBuilder strSQL;
            UFDateClass cfDateClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                // ‚È‚µ

                // ˆ¶–¼ŒŸõƒL[‚Ìƒ`ƒFƒbƒN
                // ‚È‚µ

                // SQL•¶‚Ìì¬    
                strSQL = new StringBuilder();
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABDainoEntity.TABLE_NAME);
                strSQL.Append(" WHERE ");
                strSQL.Append(ABDainoEntity.DAINOJUMINCD);
                strSQL.Append(" = ");
                strSQL.Append(ABDainoEntity.KEY_DAINOJUMINCD);
                if (!(strGyomuCD == "*1"))
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.GYOMUCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABDainoEntity.KEY_GYOMUCD);
                }
                strSQL.Append(" AND ");
                strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                strSQL.Append(" = ");
                strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD);
                strSQL.Append(" AND ");
                strSQL.Append(ABDainoEntity.STYMD);
                strSQL.Append(" <= ");
                strSQL.Append(ABDainoEntity.KEY_STYMD);
                strSQL.Append(" AND ");
                strSQL.Append(ABDainoEntity.EDYMD);
                strSQL.Append(" >= ");
                strSQL.Append(ABDainoEntity.KEY_EDYMD);
                if (!blnSakujoFG)
                {
                    strSQL.Append(" AND ");
                    strSQL.Append(ABDainoEntity.SAKUJOFG);
                    strSQL.Append(" <> 1");
                }
                strSQL.Append(";");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_DAINOJUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                if (!(strGyomuCD == "*1"))
                {
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD;
                    cfUFParameterClass.Value = strGyomuCD;
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD;
                cfUFParameterClass.Value = strGyomunaiSHUCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYMD;
                if (strKikanYMD.Trim().Length == 6)
                {
                    if (strKikanYMD.Trim() == "000000")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                    }
                    else if (strKikanYMD.Trim() == "999999")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                    }
                    else
                    {
                        cfDateClass = new UFDateClass(m_cfConfigDataClass);
                        cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                        // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                        // cfDateClass.p_strDateValue = strKikanYMD.Trim + "01"
                        cfDateClass.p_strDateValue = strKikanYMD.Trim() + "00";
                        // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                        cfUFParameterClass.Value = cfDateClass.GetLastDay();
                    }
                }
                else
                {
                    cfUFParameterClass.Value = strKikanYMD;
                }
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYMD;
                if (strKikanYMD.Trim().Length == 6)
                {
                    if (strKikanYMD.Trim() == "000000")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                    }
                    else if (strKikanYMD.Trim() == "999999")
                    {
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                    }
                    else
                    {
                        // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                        // cfUFParameterClass.Value = strKikanYMD.Trim + "01"
                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                        // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                    }
                }
                else
                {
                    cfUFParameterClass.Value = strKikanYMD;
                }
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
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
                    // *—š—ð”Ô† 000006 2003/08/28 C³I—¹

                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                    // * —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 71223


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                    End If
                                                    '* —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                         */
                    csDataSet = m_csDataSchma.Clone();
                    csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, true);
                    // * —š—ð”Ô† 000009 2004/08/27 XVI—¹

                    // ƒf[ƒ^Œ”ƒ`ƒFƒbƒN
                    if (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count == 0)
                    {

                        // ‹Æ–±“àŽí•Ê‚ªŽw’è‚³‚ê‚Ä‚¢‚½ê‡
                        if (!string.IsNullOrEmpty(strGyomunaiSHUCD))
                        {

                            // SQL•¶‚Ìì¬
                            strSQL = null;
                            strSQL = new StringBuilder();
                            strSQL.Append("SELECT * FROM ");
                            strSQL.Append(ABDainoEntity.TABLE_NAME);
                            strSQL.Append(" WHERE ");
                            strSQL.Append(ABDainoEntity.DAINOJUMINCD);
                            strSQL.Append(" = ");
                            strSQL.Append(ABDainoEntity.KEY_DAINOJUMINCD);
                            if (!(strGyomuCD == "*1"))
                            {
                                strSQL.Append(" AND ");
                                strSQL.Append(ABDainoEntity.GYOMUCD);
                                strSQL.Append(" = ");
                                strSQL.Append(ABDainoEntity.KEY_GYOMUCD);
                            }
                            strSQL.Append(" AND ");
                            strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                            strSQL.Append(" = ");
                            strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD);
                            strSQL.Append(" AND ");
                            strSQL.Append(ABDainoEntity.STYMD);
                            strSQL.Append(" <= ");
                            strSQL.Append(ABDainoEntity.KEY_STYMD);
                            strSQL.Append(" AND ");
                            strSQL.Append(ABDainoEntity.EDYMD);
                            strSQL.Append(" >= ");
                            strSQL.Append(ABDainoEntity.KEY_EDYMD);
                            if (!blnSakujoFG)
                            {
                                strSQL.Append(" AND ");
                                strSQL.Append(ABDainoEntity.SAKUJOFG);
                                strSQL.Append(" <> 1");
                            }
                            strSQL.Append(";");

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                            cfUFParameterCollectionClass = new UFParameterCollectionClass();

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfUFParameterClass = new UFParameterClass();
                            cfUFParameterClass.ParameterName = ABDainoEntity.KEY_DAINOJUMINCD;
                            cfUFParameterClass.Value = strJuminCD;
                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass);

                            if (!(strGyomuCD == "*1"))
                            {
                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = new UFParameterClass();
                                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD;
                                cfUFParameterClass.Value = strGyomuCD;
                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                            }

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfUFParameterClass = new UFParameterClass();
                            cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD;
                            cfUFParameterClass.Value = "";
                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfUFParameterClass = new UFParameterClass();
                            cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYMD;
                            if (strKikanYMD.Trim().Length == 6)
                            {
                                if (strKikanYMD.Trim() == "000000")
                                {
                                    cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                                }
                                else if (strKikanYMD.Trim() == "999999")
                                {
                                    cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                                }
                                else
                                {
                                    cfDateClass = new UFDateClass(m_cfConfigDataClass);
                                    cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                                    // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                                    // cfDateClass.p_strDateValue = strKikanYMD.Trim + "01"
                                    cfDateClass.p_strDateValue = strKikanYMD.Trim() + "00";
                                    // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                                    cfUFParameterClass.Value = cfDateClass.GetLastDay();
                                }
                            }
                            else
                            {
                                cfUFParameterClass.Value = strKikanYMD;
                            }
                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass);

                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                            cfUFParameterClass = new UFParameterClass();
                            cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYMD;
                            if (strKikanYMD.Trim().Length == 6)
                            {
                                if (strKikanYMD.Trim() == "000000")
                                {
                                    cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                                }
                                else if (strKikanYMD.Trim() == "999999")
                                {
                                    cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                                }
                                else
                                {
                                    // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                                    // cfUFParameterClass.Value = strKikanYMD.Trim + "01"
                                    cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                                    // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                                }
                            }
                            else
                            {
                                cfUFParameterClass.Value = strKikanYMD;
                            }
                            // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                            cfUFParameterCollectionClass.Add(cfUFParameterClass);

                            // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                            // ' RDBƒAƒNƒZƒXƒƒOo—Í
                            // m_cfLogClass.RdbWrite(m_cfControlData, _
                            // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                            // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                            // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                            // "ySQL“à—e:" + strSQL.ToString + "z")

                            // RDBƒAƒNƒZƒXƒƒOo—Í
                            // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
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
                                // *—š—ð”Ô† 000006 2003/08/28 C³I—¹

                                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                                // * —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                                // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 79031


                                                                Input:
                                                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                                                    End If
                                                                                    '* —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                                                 */
                                csDataSet = m_csDataSchma.Clone();
                                csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, true);
                                // * —š—ð”Ô† 000009 2004/08/27 XVI—¹


                            }

                        }

                        // ƒf[ƒ^Œ”ƒ`ƒFƒbƒN
                        if (csDataSet.Tables(ABDainoEntity.TABLE_NAME).Rows.Count == 0)
                        {

                            // ‹Æ–±ƒR[ƒhih00hˆÈŠOj‚ªŽw’è‚³‚ê‚Ä‚¢‚½ê‡
                            if (!(strGyomuCD == "00"))
                            {

                                // SQL•¶‚Ìì¬
                                strSQL = null;
                                strSQL = new StringBuilder();
                                strSQL.Append("SELECT * FROM ");
                                strSQL.Append(ABDainoEntity.TABLE_NAME);
                                strSQL.Append(" WHERE ");
                                strSQL.Append(ABDainoEntity.DAINOJUMINCD);
                                strSQL.Append(" = ");
                                strSQL.Append(ABDainoEntity.KEY_DAINOJUMINCD);
                                if (!(strGyomuCD == "*1"))
                                {
                                    strSQL.Append(" AND ");
                                    strSQL.Append(ABDainoEntity.GYOMUCD);
                                    strSQL.Append(" = ");
                                    strSQL.Append(ABDainoEntity.KEY_GYOMUCD);
                                }
                                strSQL.Append(" AND ");
                                strSQL.Append(ABDainoEntity.GYOMUNAISHU_CD);
                                strSQL.Append(" = ");
                                strSQL.Append(ABDainoEntity.KEY_GYOMUNAISHU_CD);
                                strSQL.Append(" AND ");
                                strSQL.Append(ABDainoEntity.STYMD);
                                strSQL.Append(" <= ");
                                strSQL.Append(ABDainoEntity.KEY_STYMD);
                                strSQL.Append(" AND ");
                                strSQL.Append(ABDainoEntity.EDYMD);
                                strSQL.Append(" >= ");
                                strSQL.Append(ABDainoEntity.KEY_EDYMD);
                                if (!blnSakujoFG)
                                {
                                    strSQL.Append(" AND ");
                                    strSQL.Append(ABDainoEntity.SAKUJOFG);
                                    strSQL.Append(" <> 1");
                                }
                                strSQL.Append(";");

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = new UFParameterClass();
                                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_DAINOJUMINCD;
                                cfUFParameterClass.Value = strJuminCD;
                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                                if (!(strGyomuCD == "*1"))
                                {
                                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                    cfUFParameterClass = new UFParameterClass();
                                    cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUCD;
                                    cfUFParameterClass.Value = "00";
                                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                                }

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = new UFParameterClass();
                                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_GYOMUNAISHU_CD;
                                cfUFParameterClass.Value = "";
                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = new UFParameterClass();
                                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_STYMD;
                                if (strKikanYMD.Trim().Length == 6)
                                {
                                    if (strKikanYMD.Trim() == "000000")
                                    {
                                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                                    }
                                    else if (strKikanYMD.Trim() == "999999")
                                    {
                                        cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                                    }
                                    else
                                    {
                                        cfDateClass = new UFDateClass(m_cfConfigDataClass);
                                        cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                                        // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                                        // cfDateClass.p_strDateValue = strKikanYMD.Trim + "01"
                                        cfDateClass.p_strDateValue = strKikanYMD.Trim() + "00";
                                        // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                                        cfUFParameterClass.Value = cfDateClass.GetLastDay();
                                    }
                                }
                                else
                                {
                                    cfUFParameterClass.Value = strKikanYMD;
                                }
                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                                cfUFParameterClass = new UFParameterClass();
                                cfUFParameterClass.ParameterName = ABDainoEntity.KEY_EDYMD;
                                if (strKikanYMD.Trim().Length == 6)
                                {
                                    if (strKikanYMD.Trim() == "000000")
                                    {
                                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                                    }
                                    else if (strKikanYMD.Trim() == "999999")
                                    {
                                        cfUFParameterClass.Value = strKikanYMD.Trim() + "99";
                                    }
                                    else
                                    {
                                        // * —š—ð”Ô† 000018 2023/10/19 C³ŠJŽn
                                        // cfUFParameterClass.Value = strKikanYMD.Trim + "01"
                                        cfUFParameterClass.Value = strKikanYMD.Trim() + "00";
                                        // * —š—ð”Ô† 000018 2023/10/19 C³I—¹
                                    }
                                }
                                else
                                {
                                    cfUFParameterClass.Value = strKikanYMD;
                                }
                                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
                                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                                // m_cfLogClass.RdbWrite(m_cfControlData, _
                                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                                // "ySQL“à—e:" + strSQL.ToString + "z")

                                // RDBƒAƒNƒZƒXƒƒOo—Í
                                // * —š—ð”Ô† 000010 2005/01/25 XVŠJŽni‹{‘òjIf •¶‚ÅˆÍ‚Þ
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
                                    // *—š—ð”Ô† 000006 2003/08/28 C³I—¹

                                    // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                                    // * —š—ð”Ô† 000009 2004/08/27 XVŠJŽni‹{‘òj
                                    // csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass)
#error Cannot convert EmptyStatementSyntax - see comment for details
                                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 86951


                                                                        Input:
                                                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                                                                            End If
                                                                                            '* —š—ð”Ô† 000010 2005/01/25 XVI—¹i‹{‘òjIf •¶‚ÅˆÍ‚Þ

                                                                         */
                                    csDataSet = m_csDataSchma.Clone();
                                    csDataSet = m_cfRdbClass.GetDataSet(strSQL.ToString(), csDataSet, ABDainoEntity.TABLE_NAME, cfUFParameterCollectionClass, true);
                                    // * —š—ð”Ô† 000009 2004/08/27 XVI—¹

                                }

                            }

                            // ƒNƒ‰ƒX‚Ì‰ð•ú
                            strSQL = null;

                            // ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                        }
                    }
                }
            }

            catch (UFAppException objAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 88400


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 88496


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 88764


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 88847


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csDataSet;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertDainoB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertDainoB(DataRow csDataRow)
        {

            // * corresponds to VS2008 Start 2010/04/16 000015
            // Dim csInstRow As DataRow
            // * corresponds to VS2008 End 2010/04/16 000015
            const string THIS_METHOD_NAME = "InsertDainoB";     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            int intInsCnt;            // ’Ç‰ÁŒ”
            string strUpdateDateTime;

            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateInsertSQL(csDataRow);
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹
                }


                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABDainoEntity.TANMATSUID) = m_cfControlData.m_strClientId; // ’[––‚h‚c
                csDataRow(ABDainoEntity.SAKUJOFG) = "0";                             // íœƒtƒ‰ƒO
                csDataRow(ABDainoEntity.KOSHINCOUNTER) = decimal.Zero;               // XVƒJƒEƒ“ƒ^
                csDataRow(ABDainoEntity.SAKUSEINICHIJI) = strUpdateDateTime;         // ì¬“úŽž
                csDataRow(ABDainoEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;  // ì¬ƒ†[ƒU[
                csDataRow(ABDainoEntity.KOSHINNICHIJI) = strUpdateDateTime;          // XV“úŽž
                csDataRow(ABDainoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;   // XVƒ†[ƒU[


                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow[csDataColumn.ColumnName].ToString().Trim());


                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABDainoEntity.PARAM_PLACEHOLDER.RLength)).ToString();


                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 93062


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000006 2003/08/28 C³I—¹

                                 */
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 93938


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94036


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94306


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94391


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return intInsCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘ã”[ƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateDainoB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@‘ã”[ƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateDainoB(DataRow csDataRow)
        {

            const string THIS_METHOD_NAME = "UpdateDainoB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                // * corresponds to VS2008 Start 2010/04/16 000015
                                                                                // Dim csDataColumn As DataColumn
                                                                                // * corresponds to VS2008 End 2010/04/16 000015
            int intUpdCnt;                            // XVŒ”


            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateUpdateSQL(csDataRow);
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABDainoEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABDainoEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABDainoEntity.KOSHINCOUNTER)) + 1m;               // XVƒJƒEƒ“ƒ^
                csDataRow(ABDainoEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABDainoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[
                                                                                                                       // * —š—ð”Ô† 000019 2023/12/05 íœŠJŽn
                                                                                                                       // '* —š—ð”Ô† 000018 2023/10/19 ’Ç‰ÁŠJŽn
                                                                                                                       // csDataRow(ABDainoEntity.RRKNO) = CDec(csDataRow(ABDainoEntity.RRKNO)) + 1                             '—š—ð”Ô†
                                                                                                                       // '* —š—ð”Ô† 000018 2023/10/19 ’Ç‰ÁI—¹
                                                                                                                       // * —š—ð”Ô† 000019 2023/12/05 íœI—¹

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABDainoEntity.PREFIX_KEY.RLength) == ABDainoEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABDainoEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABDainoEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABDainoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABDainoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000006 2003/08/28 C³ŠJŽn
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
            }

            return default;
        }
    }
}