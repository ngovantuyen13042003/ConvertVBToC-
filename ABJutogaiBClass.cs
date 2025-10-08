// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aZ“oŠOƒ}ƒXƒ^‚c‚`(ABJutogaiBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2002/12/20@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/12 000001     —LŒøŒ…”‚Ì‘Î‰ž
// * 2003/03/25 000002     —X•Ö”Ô†‚ª’Ç‰Á‚É‚È‚è‚Ü‚µ‚½B
// * 2003/04/16 000003     ¶˜a—ï”NŒŽ“ú‚Ì“ú•tƒ`ƒFƒbƒN‚ð”’lƒ`ƒFƒbƒN‚É•ÏX
// *                       ŒŸõ—pƒJƒi‚Ì”¼ŠpƒJƒiƒ`ƒFƒbƒN‚ð‚`‚m‚jƒ`ƒFƒbƒN‚É•ÏX
// * 2003/05/21 000004     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/28 000005     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2003/09/11 000006     ’[––‚h‚c®‡«ƒ`ƒFƒbƒN‚ðANK‚É‚·‚é
// * 2003/10/09 000007     ì¬ƒ†[ƒU[EXVƒ†[ƒU[ƒ`ƒFƒbƒN‚Ì•ÏX
// * 2003/10/30 000008     Žd—l•ÏXAƒJƒ^ƒJƒiƒ`ƒFƒbƒN‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2004/05/13 000009     Žd—l•ÏXA”Ä—p‹æ•ª‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2005/01/15 000010     Žd—l•ÏXAZŠƒR[ƒh‚ðANKƒ`ƒFƒbƒN‚É•ÏX
// * 2005/06/16 000011     SQL•¶‚ðInsert,Update,˜_—Delete,•¨—Delete‚ÌŠeƒƒ\ƒbƒh‚ªŒÄ‚Î‚ê‚½Žž‚ÉŠeŽ©ì¬‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2005/12/26 000012     Žd—l•ÏXFs­‹æ‚b‚c‚ðANKƒ`ƒFƒbƒN‚É•ÏX(ƒ}ƒ‹ƒS‘ºŽR)
// * 2010/04/16 000013     VS2008‘Î‰ži”ä‰Ãj
// * 2011/10/24 000014     yAB17010zƒZŠî–@‰ü³‘Î‰ž„ˆ¶–¼•tƒ}ƒXƒ^’Ç‰Á   (¬¼)
// * 2023/08/14 000015    yAB-0820-1zZ“oŠOŠÇ—€–Ú’Ç‰Á(‘è)
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
    // * Z“oŠOƒ}ƒXƒ^Žæ“¾Žž‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
    // *
    // ************************************************************************************************
    public class ABJutogaiBClass
    {
        #region ƒƒ“
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private string m_strInsertSQL;                        // INSERT—pSQL
        private string m_strUpdateSQL;                        // UPDATE—pSQL
        private string m_strDelRonriSQL;                      // ˜_—íœ—pSQL
        private string m_strDelButuriSQL;                     // •¨—íœ—pSQL
        private UFParameterCollectionClass m_cfInsertUFParameterCollection;       // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollection;       // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelRonriUFParameterCollection;     // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDelButuriUFParameterCollection;    // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁŠJŽn
        private ABSekoYMDHanteiBClass m_csSekoYMDHanteiB;             // Ž{s“ú”»’èB¸×½
        private ABAtenaFZYBClass m_csAtenaFZYB;                       // ˆ¶–¼•tƒ}ƒXƒ^B¸×½
        private string m_strJukihoKaiseiKB;                           // ZŠî–@‰ü³‹æ•ª
                                                                      // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁI—¹
                                                                      // *—š—ð”Ô† 000015 2023/08/14 ’Ç‰ÁŠJŽn
        private bool m_blnJukihoKaiseiFG = false;
        // *—š—ð”Ô† 000015 2023/08/14 ’Ç‰ÁI—¹

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABJutogaiBClass";                 // ƒNƒ‰ƒX–¼
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh
        private const string JUKIHOKAISEIKB_ON = "1";

        #endregion

        #region ƒvƒƒpƒeƒB
        // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁŠJŽn
        public string p_strJukihoKaiseiKB      // ZŠî–@‰ü³‹æ•ª
        {
            set
            {
                m_strJukihoKaiseiKB = value;
            }
        }
        // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁI—¹
        #endregion


        #region ƒRƒ“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass, 
        // * @@                          ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABJutogaiBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strInsertSQL = string.Empty;
            m_strUpdateSQL = string.Empty;
            m_strDelRonriSQL = string.Empty;
            m_strDelButuriSQL = string.Empty;
            m_cfInsertUFParameterCollection = (object)null;
            m_cfUpdateUFParameterCollection = (object)null;
            m_cfDelRonriUFParameterCollection = (object)null;
            m_cfDelButuriUFParameterCollection = (object)null;

            // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁŠJŽn
            m_strJukihoKaiseiKB = string.Empty;
            // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁI—¹
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetJutogaiBHoshu() As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½Z“oŠOƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetJutogaiBHoshu()
        {

            return GetJutogaiBHoshu(false);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetJutogaiBHoshu(ByVal blnSakujoFG As Boolean) As DataSet
        // * 
        // * ‹@”\           Z“oŠOƒ}ƒXƒ^‚æ‚è‘SŒƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           blnSakujoFG   : íœƒtƒ‰ƒOiÈ—ª‰Âj
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½Z“oŠOƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetJutogaiBHoshu(bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetJutogaiBHoshu";
            DataSet csJutogaiEntity;
            string strSQL;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                if (blnSakujoFG == true)
                {
                    strSQL = "SELECT * FROM " + ABJutogaiEntity.TABLE_NAME;
                }
                else
                {
                    strSQL = "SELECT * FROM " + ABJutogaiEntity.TABLE_NAME + " WHERE " + ABJutogaiEntity.SAKUJOFG + " <> '1';";
                }

                // *—š—ð”Ô† 000015 2023/08/14 ’Ç‰ÁŠJŽn
                // Ž{s“úˆÈ~ƒtƒ‰ƒO‚ðŽæ“¾‚·‚é
                m_csSekoYMDHanteiB = new ABSekoYMDHanteiBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                m_blnJukihoKaiseiFG = m_csSekoYMDHanteiB.CheckAfterSekoYMD();

                // ZŠî–@‰ü³ˆÈ~‚Ì‚Æ‚«A‚Íˆ¶–¼_•W€Aˆ¶–¼•t_•W€‚ðLEFT OUTER JOIN‚µ‚ÄŽæ“¾‚·‚é
                if (m_blnJukihoKaiseiFG)
                {
                    strSQL = "SELECT A.* FROM (" + strSQL + ") A";
                    strSQL = strSQL + " LEFT OUTER JOIN " + ABAtenaHyojunEntity.TABLE_NAME + " B ON A." + ABJutogaiEntity.JUMINCD + "  = B." + ABAtenaHyojunEntity.JUMINCD;
                    strSQL = strSQL + " LEFT OUTER JOIN " + ABAtenaFZYHyojunEntity.TABLE_NAME + " C ON A." + ABJutogaiEntity.JUMINCD + " = C." + ABAtenaFZYHyojunEntity.JUMINCD;
                }
                // *—š—ð”Ô† 000015 2023/08/14 ’Ç‰ÁI—¹

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                // "ySQL“à—e:" + strSQL + "z")

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                csJutogaiEntity = m_cfRdbClass.GetDataSet(strSQL, ABJutogaiEntity.TABLE_NAME);


                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10574


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10670


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 10938


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11021


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csJutogaiEntity;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetJutogaiBHoshu(ByVal strJuminCD As String) As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒhiÈ—ª‰Âj
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½Z“oŠOƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetJutogaiBHoshu(string strJuminCD)
        {

            return GetJutogaiBHoshu(strJuminCD, false);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^’Šo
        // * 
        // * \•¶           Public Function GetJutogaiBHoshu(Optional ByVal strJuminCD As String = "", _
        // *                                Optional ByVal blnSakujoFG As Boolean = False) As DataSet
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           strJuminCD    : Z–¯ƒR[ƒh
        // *                blnSakujoFG   : íœƒtƒ‰ƒO
        // * 
        // * –ß‚è’l         DataSet : Žæ“¾‚µ‚½Z“oŠOƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^
        // ************************************************************************************************
        public DataSet GetJutogaiBHoshu(string strJuminCD, bool blnSakujoFG)
        {
            const string THIS_METHOD_NAME = "GetJutogaiBHoshu";
            DataSet csJutogaiEntity;
            var strSQL = new StringBuilder();
            UFParameterClass cfUFParameterClass;
            UFParameterCollectionClass cfUFParameterCollectionClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                // *—š—ð”Ô† 000014 2011/10/24 C³ŠJŽn
                // ZŠî–@‰ü³ˆÈ~‚Íˆ¶–¼•tƒ}ƒXƒ^‚ð•t‰Á
                if ((m_strJukihoKaiseiKB ?? "") == JUKIHOKAISEIKB_ON)
                {
                    strSQL.AppendFormat("SELECT {0}.* ", ABJutogaiEntity.TABLE_NAME);
                    SetFZYEntity(ref strSQL);
                    strSQL.AppendFormat(" FROM {0} ", ABJutogaiEntity.TABLE_NAME);
                    SetFZYJoin(ref strSQL);
                    strSQL.AppendFormat(" WHERE {0}.{1}={2} ", ABJutogaiEntity.TABLE_NAME, ABJutogaiEntity.JUMINCD, ABJutogaiEntity.KEY_JUMINCD);
                    if (blnSakujoFG == false)
                    {
                        strSQL.AppendFormat(" AND {0}.{1} <> '1' ", ABJutogaiEntity.TABLE_NAME, ABJutogaiEntity.SAKUJOFG);
                    }
                }
                else
                {
                    strSQL.Append("SELECT * FROM ");
                    strSQL.Append(ABJutogaiEntity.TABLE_NAME);
                    strSQL.Append(" WHERE ");
                    strSQL.Append(ABJutogaiEntity.JUMINCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABJutogaiEntity.KEY_JUMINCD);
                    if (blnSakujoFG == false)
                    {
                        strSQL.Append(" AND ");
                        strSQL.Append(ABJutogaiEntity.SAKUJOFG);
                        strSQL.Append(" <> '1';");
                    }
                }
                // *—š—ð”Ô† 000014 2011/10/24 C³I—¹

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaJiteEntity.KEY_JUMINCD;
                cfUFParameterClass.Value = strJuminCD;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
                csJutogaiEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABJutogaiEntity.TABLE_NAME, cfUFParameterCollectionClass);


                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17173


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17269


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17537


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17620


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return csJutogaiEntity;

        }

        // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒf[ƒ^€–Ú•ÒW
        // * 
        // * \•¶           Private SetFZYEntity()
        // * 
        // * ‹@”\           ˆ¶–¼•tƒf[ƒ^‚Ì€–Ú•ÒW‚ð‚µ‚Ü‚·B
        // * 
        // * ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void SetFZYEntity(ref StringBuilder strAtenaSQLsb)
        {
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TABLEINSERTKB);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.LINKNO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINHYOJOTAIKBN);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKYOCHITODOKEFLG);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.HONGOKUMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANAHONGOKUMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANJIHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANAHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANJITSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KANATSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KATAKANAHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.UMAREFUSHOKBN);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TSUSHOMEITOUROKUYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUKIKANCD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUKIKANMEISHO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUSHACD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUSHAMEISHO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.ZAIRYUCARDNO);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KOFUYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KOFUYOTEISTYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.KOFUYOTEIEDYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOIDOYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYUCD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOJIYU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDYMD);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUKITAISHOSHASHOJOTDKDTUCIKB);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.FRNSTAINUSMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.FRNSTAINUSKANAMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSKANAHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.STAINUSKANATSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENUMAEJ_STAINUSMEI_KYOTSU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENUMAEJ_STAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENUMAEJ_STAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSMEI_KYOTSU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUYOTEISTAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSMEI_KYOTSU);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSHEIKIMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.TENSHUTSUKKTISTAINUSTSUSHOMEI);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE1);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE2);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE3);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE4);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE5);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE6);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE7);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE8);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE9);
            strAtenaSQLsb.AppendFormat(", {0}.{1}", ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.RESERVE10);
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•tƒe[ƒuƒ‹JOIN‹åì¬
        // * 
        // * \•¶           Private SetFZYJoin()
        // * 
        // * ‹@”\           ˆ¶–¼•tƒe[ƒuƒ‹‚ÌJOIN‹å‚ðì¬‚µ‚Ü‚·B
        // * 
        // * ˆø”           strAtenaSQLsb@F@ˆ¶–¼Žæ“¾—pSQL  
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void SetFZYJoin(ref StringBuilder strAtenaSQLsb)
        {
            strAtenaSQLsb.AppendFormat(" LEFT OUTER JOIN {0} ", ABAtenaFZYEntity.TABLE_NAME);
            strAtenaSQLsb.AppendFormat(" ON {0}.{1} = {2}.{3} ", ABJutogaiEntity.TABLE_NAME, ABJutogaiEntity.JUMINCD, ABAtenaFZYEntity.TABLE_NAME, ABAtenaFZYEntity.JUMINCD);
        }
        // *—š—ð”Ô† 000014 2011/10/24 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^’Ç‰Á
        // * 
        // * \•¶           Public Function InsertJutogaiB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ’Ç‰Á‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ’Ç‰Á‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int InsertJutogaiB(DataRow csDataRow)
        {

            // * corresponds to VS2008 Start 2010/04/16 000013
            // Dim csInstRow As DataRow
            // * corresponds to VS2008 End 2010/04/16 000013
            const string THIS_METHOD_NAME = "InsertJutogaiB";
            int intInsCnt;        // ’Ç‰ÁŒ”
            string strUpdateDateTime;


            try
            {

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollection is null)
                {
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateInsertSQL(csDataRow);
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");  // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABJutogaiEntity.TANMATSUID) = m_cfControlData.m_strClientId;   // ’[––‚h‚c
                csDataRow(ABJutogaiEntity.SAKUJOFG) = "0";                               // íœƒtƒ‰ƒO
                csDataRow(ABJutogaiEntity.KOSHINCOUNTER) = decimal.Zero;                 // XVƒJƒEƒ“ƒ^
                csDataRow(ABJutogaiEntity.SAKUSEINICHIJI) = strUpdateDateTime;           // ì¬“úŽž
                csDataRow(ABJutogaiEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;    // ì¬ƒ†[ƒU[
                csDataRow(ABJutogaiEntity.KOSHINNICHIJI) = strUpdateDateTime;            // XV“úŽž
                csDataRow(ABJutogaiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;     // XVƒ†[ƒU[

                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow[csDataColumn.ColumnName].ToString().Trim());

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollection)
                    cfParam.Value = csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strInsertSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollection) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollection);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30052


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30148


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30416


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30499


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return intInsCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^XV
        // * 
        // * \•¶           Public Function UpdateJutogaiB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : XV‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int UpdateJutogaiB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateJutogaiB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000013
                                                                                  // Dim csDataColumn As DataColumn
                                                                                  // * corresponds to VS2008 End 2010/04/16 000013
            int intUpdCnt;                            // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollection is null)
                {
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateUpdateSQL(csDataRow);
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABJutogaiEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                   // ’[––‚h‚c
                csDataRow(ABJutogaiEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABJutogaiEntity.KOSHINCOUNTER)) + 1m;           // XVƒJƒEƒ“ƒ^
                csDataRow(ABJutogaiEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABJutogaiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                     // XVƒ†[ƒU[


                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollection)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABJutogaiEntity.PREFIX_KEY.RLength) == ABJutogaiEntity.PREFIX_KEY)
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollection(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        this.m_cfUpdateUFParameterCollection(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollection) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpdateSQL, m_cfUpdateUFParameterCollection);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, "UpdateKinyuKikan");
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 35997


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36093


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36361


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36444


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return intUpdCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^íœ
        // * 
        // * \•¶           Public Function DeleteJutogaiB(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð˜_—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : ˜_—íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : ˜_—íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteJutogaiB(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateJutogaiB";                     // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000013
                                                                                  // Dim csDataColumn As DataColumn
                                                                                  // * corresponds to VS2008 End 2010/04/16 000013
            int intDelCnt;                            // íœŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strDelRonriSQL is null | string.IsNullOrEmpty(m_strDelRonriSQL) | m_cfDelRonriUFParameterCollection is null)
                {
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateDeleteRonriSQL(csDataRow);
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹
                }


                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABJutogaiEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                     // ’[––‚h‚c
                csDataRow(ABJutogaiEntity.SAKUJOFG) = "1";                                                                   // íœƒtƒ‰ƒO
                csDataRow(ABJutogaiEntity.KOSHINCOUNTER) = Conversions.ToDecimal(csDataRow(ABJutogaiEntity.KOSHINCOUNTER)) + 1m;               // XVƒJƒEƒ“ƒ^
                csDataRow(ABJutogaiEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");     // XV“úŽž
                csDataRow(ABJutogaiEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                       // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelRonriUFParameterCollection)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABJutogaiEntity.PREFIX_KEY.RLength) == ABJutogaiEntity.PREFIX_KEY)
                    {
                        this.m_cfDelRonriUFParameterCollection(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        this.m_cfDelRonriUFParameterCollection(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelRonriSQL, m_cfDelRonriUFParameterCollection) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelRonriSQL, m_cfDelRonriUFParameterCollection);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42073


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42169


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42437


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42520


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return intDelCnt;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠOƒ}ƒXƒ^•¨—íœ
        // * 
        // * \•¶           Public Function DeleteJutogaiB(ByVal csDataRow As DataRow, _
        // *                                               ByVal strSakujoKB As String) As Integer
        // * 
        // * ‹@”\@@    @@Z“oŠOƒ}ƒXƒ^‚Ìƒf[ƒ^‚ð•¨—íœ‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : íœ‚·‚éƒf[ƒ^‚ÌŠÜ‚Ü‚ê‚éDataRowƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         Integer : íœ‚µ‚½ƒf[ƒ^‚ÌŒ”
        // ************************************************************************************************
        public int DeleteJutogaiB(DataRow csDataRow, string strSakujoKB)
        {
            const string THIS_METHOD_NAME = "DeleteJutogaiB";
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
                                                          // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                          // * corresponds to VS2008 Start 2010/04/16 000013
                                                          // Dim csDataColumn As DataColumn
                                                          // * corresponds to VS2008 End 2010/04/16 000013
            int intDelCnt;                            // íœŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // íœ‹æ•ª‚Ìƒ`ƒFƒbƒN‚ðs‚¤
                if (!(strSakujoKB == "D"))
                {
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_DELETE_SAKUJOKB);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode);
                }

                // íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                if (m_strDelButuriSQL is null | string.IsNullOrEmpty(m_strDelButuriSQL) | m_cfDelButuriUFParameterCollection == null)
                {
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
                    // Call CreateSQL(csDataRow)
                    CreateDeleteButsuriSQL(csDataRow);
                    // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹
                }

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDelButuriUFParameterCollection)
                {

                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABJutogaiEntity.PREFIX_KEY.RLength) == ABJutogaiEntity.PREFIX_KEY)
                    {
                        this.m_cfDelButuriUFParameterCollection(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABJutogaiEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                }


                // *—š—ð”Ô† 000005 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                // "ySQL“à—e:" + m_strUpdateSQL + "z")

                // ' RDBƒAƒNƒZƒXƒƒOo—Íi2024/04/18 DBƒAƒNƒZƒX‘¬“x‰ü‘P‚Ì‚½‚ßƒRƒƒ“ƒgƒAƒEƒgj
                // m_cfLogClass.RdbWrite(m_cfControlData,
                // "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" +
                // "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" +
                // "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" +
                // "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDelButuriSQL, m_cfDelButuriUFParameterCollection) + "z")
                // *—š—ð”Ô† 000005 2003/08/28 C³I—¹

                // SQL‚ÌŽÀs
                intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDelButuriSQL, m_cfDelButuriUFParameterCollection);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47634


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47730


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 47998


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 48081


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

            return intDelCnt;

        }

        // * corresponds to VS2008 Start 2010/04/16 000013
        // '* —š—ð”Ô† 000011 2005/06/16 íœŠJŽn
        // ''''************************************************************************************************
        // ''''* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
        // ''''* 
        // ''''* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
        // ''''* 
        // ''''* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // ''''* 
        // ''''* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // ''''* 
        // ''''* –ß‚è’l         ‚È‚µ
        // ''''************************************************************************************************
        // '''Private Sub CreateSQL(ByVal csDataRow As DataRow)

        // '''    Const THIS_METHOD_NAME As String = "CreateSQL"
        // '''    Dim csDataColumn As DataColumn
        // '''    Dim strInsertColumn As String                       'INSERT—pƒJƒ‰ƒ€
        // '''    Dim strInsertParam As String
        // '''    Dim cfUFParameterClass As UFParameterClass
        // '''    Dim strUpdateWhere As String
        // '''    Dim strUpdateParam As String
        // '''    Dim csDelRonriSQL As New StringBuilder()            '˜_—íœ—pSQL

        // '''    Try
        // '''        ' ƒfƒoƒbƒOƒƒOo—Í
        // '''        m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // '''        ' SELECT SQL•¶‚Ìì¬
        // '''        m_strInsertSQL = "INSERT INTO " + ABJutogaiEntity.TABLE_NAME + " "
        // '''        strInsertColumn = ""
        // '''        strInsertParam = ""

        // '''        ' UPDATE SQL•¶‚Ìì¬
        // '''        m_strUpdateSQL = "UPDATE " + ABJutogaiEntity.TABLE_NAME + " SET "
        // '''        strUpdateParam = ""
        // '''        strUpdateWhere = ""

        // '''        ' ˜_—DELETE SQL•¶‚Ìì¬
        // '''        csDelRonriSQL.Append("UPDATE ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.TABLE_NAME)
        // '''        csDelRonriSQL.Append(" SET ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.TANMATSUID)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.PARAM_TANMATSUID)
        // '''        csDelRonriSQL.Append(", ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.SAKUJOFG)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.PARAM_SAKUJOFG)
        // '''        csDelRonriSQL.Append(", ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.KOSHINCOUNTER)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.PARAM_KOSHINCOUNTER)
        // '''        csDelRonriSQL.Append(", ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.KOSHINNICHIJI)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.PARAM_KOSHINNICHIJI)
        // '''        csDelRonriSQL.Append(", ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.KOSHINUSER)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.PARAM_KOSHINUSER)
        // '''        csDelRonriSQL.Append(" WHERE ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.JUMINCD)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.KEY_JUMINCD)
        // '''        csDelRonriSQL.Append(" AND ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.KOSHINCOUNTER)
        // '''        csDelRonriSQL.Append(" = ")
        // '''        csDelRonriSQL.Append(ABJutogaiEntity.KEY_KOSHINCOUNTER)


        // '''        ' •¨—DELETE SQL•¶‚Ìì¬
        // '''        m_strDelButuriSQL = "DELETE FROM " + ABJutogaiEntity.TABLE_NAME + " WHERE " + _
        // '''                         ABJutogaiEntity.JUMINCD + " = " + ABJutogaiEntity.KEY_JUMINCD + " AND " + _
        // '''                         ABJutogaiEntity.KOSHINCOUNTER + " = " + ABJutogaiEntity.KEY_KOSHINCOUNTER

        // '''        ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''        m_cfInsertUFParameterCollection = New UFParameterCollectionClass()

        // '''        ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''        m_cfUpdateUFParameterCollection = New UFParameterCollectionClass()

        // '''        ' ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''        m_cfDelRonriUFParameterCollection = New UFParameterCollectionClass()

        // '''        ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
        // '''        m_cfDelButuriUFParameterCollection = New UFParameterCollectionClass()

        // '''        ' ƒfƒoƒbƒOƒƒOo—Í
        // '''        m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME, "UFParameterCollectionClass End")


        // '''        ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
        // '''        For Each csDataColumn In csDataRow.Table.Columns
        // '''            cfUFParameterClass = New UFParameterClass()

        // '''            ' INSERT SQL•¶‚Ìì¬
        // '''            strInsertColumn += csDataColumn.ColumnName + ", "
        // '''            strInsertParam += ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

        // '''            ' UPDATE SQL•¶‚Ìì¬
        // '''            m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

        // '''            ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // '''            cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
        // '''            m_cfInsertUFParameterCollection.Add(cfUFParameterClass)

        // '''            ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // '''            cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
        // '''            m_cfUpdateUFParameterCollection.Add(cfUFParameterClass)

        // '''        Next csDataColumn

        // '''        ' INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
        // '''        strInsertColumn = strInsertColumn.Trim()
        // '''        strInsertColumn = strInsertColumn.Trim(CType(",", Char))
        // '''        strInsertParam = strInsertParam.Trim()
        // '''        strInsertParam = strInsertParam.Trim(CType(",", Char))

        // '''        m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")"

        // '''        ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
        // '''        m_strUpdateSQL = m_strUpdateSQL.Trim()
        // '''        m_strUpdateSQL = m_strUpdateSQL.Trim(CType(",", Char))

        // '''        ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
        // '''        m_strUpdateSQL += " WHERE " + ABJutogaiEntity.JUMINCD + " = " + ABJutogaiEntity.KEY_JUMINCD + " AND " + _
        // '''                                      ABJutogaiEntity.KOSHINCOUNTER + " = " + ABJutogaiEntity.KEY_KOSHINCOUNTER


        // '''        ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_JUMINCD
        // '''        m_cfUpdateUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_KOSHINCOUNTER
        // '''        m_cfUpdateUFParameterCollection.Add(cfUFParameterClass)

        // '''        ' ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_TANMATSUID
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_SAKUJOFG
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_KOSHINCOUNTER
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_KOSHINNICHIJI
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_KOSHINUSER
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_JUMINCD
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_KOSHINCOUNTER
        // '''        m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass)

        // '''        ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_JUMINCD
        // '''        m_cfDelButuriUFParameterCollection.Add(cfUFParameterClass)

        // '''        cfUFParameterClass = New UFParameterClass()
        // '''        cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_KOSHINCOUNTER
        // '''        m_cfDelButuriUFParameterCollection.Add(cfUFParameterClass)


        // '''        'ƒpƒ‰ƒ[ƒ^•Ï”‚ÖŠi”[
        // '''        m_strDelRonriSQL = csDelRonriSQL.ToString

        // '''        ' ƒfƒoƒbƒOƒƒOo—Í
        // '''        m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

        // '''    Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
        // '''        ' ƒ[ƒjƒ“ƒOƒƒOo—Í
        // '''        m_cfLogClass.WarningWrite(m_cfControlData, _
        // '''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // '''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // '''                                    "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
        // '''                                    "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
        // '''        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
        // '''        Throw objAppExp

        // '''    Catch objExp As Exception
        // '''        ' ƒGƒ‰[ƒƒOo—Í
        // '''        m_cfLogClass.ErrorWrite(m_cfControlData, _
        // '''                                    "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
        // '''                                    "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
        // '''                                    "yƒGƒ‰[“à—e:" + objExp.Message + "z")
        // '''        ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
        // '''        Throw objExp

        // '''    End Try

        // '''End Sub
        // '* —š—ð”Ô† 000011 2005/06/16 íœI—¹
        // * corresponds to VS2008 End 2010/04/16 000013
        // * —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Insert—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateInsertSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           INSERT—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateInsertSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateInsertSQL";
            StringBuilder csInsertColumn;                 // INSERT—pƒJƒ‰ƒ€’è‹`
            StringBuilder csInsertParam;                  // INSERT—pƒpƒ‰ƒ[ƒ^’è‹`
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABJutogaiEntity.TABLE_NAME + " ";
                csInsertColumn = new StringBuilder();
                csInsertParam = new StringBuilder();

                // INSERT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollection = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();

                    // INSERT SQL•¶‚Ìì¬
                    csInsertColumn.Append(csDataColumn.ColumnName);
                    csInsertColumn.Append(", ");
                    csInsertParam.Append(ABJutogaiEntity.PARAM_PLACEHOLDER);
                    csInsertParam.Append(csDataColumn.ColumnName);
                    csInsertParam.Append(", ");

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollection.Add(cfUFParameterClass);

                }

                // ÅŒã‚ÌƒJƒ“ƒ}‚ðŽæ‚èœ‚¢‚ÄINSERT•¶‚ðì¬
                m_strInsertSQL += "(" + csInsertColumn.ToString().Trim().Trim(",") + ")" + " VALUES (" + csInsertParam.ToString().Trim().TrimEnd(",") + ")";

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62107


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62203


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62471


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 62554


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Update—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateUpdateSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           UPDATE—p‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateUpdateSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateUpdateSQL";
            UFParameterClass cfUFParameterClass;
            StringBuilder csUpdateParam;                  // UPDATE—pSQL’è‹`

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // UPDATE SQL•¶‚Ìì¬
                m_strUpdateSQL = "UPDATE " + ABJutogaiEntity.TABLE_NAME + " SET ";
                csUpdateParam = new StringBuilder();

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollection = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    // Z–¯‚b‚cEì¬“úŽžEì¬ƒ†[ƒU‚ÍXV‚µ‚È‚¢
                    if (!(csDataColumn.ColumnName == ABJutogaiEntity.JUMINCD) && !(csDataColumn.ColumnName == ABJutogaiEntity.SAKUSEIUSER) && !(csDataColumn.ColumnName == ABJutogaiEntity.SAKUSEINICHIJI))
                    {

                        cfUFParameterClass = new UFParameterClass();

                        // UPDATE SQL•¶‚Ìì¬
                        m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                        // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                        cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                        m_cfUpdateUFParameterCollection.Add(cfUFParameterClass);
                    }

                }

                // UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strUpdateSQL = m_strUpdateSQL.ToString().Trim();
                m_strUpdateSQL = m_strUpdateSQL.ToString().Trim(",");

                // UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                m_strUpdateSQL += " WHERE " + ABJutogaiEntity.JUMINCD + " = " + ABJutogaiEntity.KEY_JUMINCD + " AND " + ABJutogaiEntity.KOSHINCOUNTER + " = " + ABJutogaiEntity.KEY_KOSHINCOUNTER;

                // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_JUMINCD;
                m_cfUpdateUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_KOSHINCOUNTER;
                m_cfUpdateUFParameterCollection.Add(cfUFParameterClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66669


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66765


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67033


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67116


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˜_—íœ—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateDeleteRonriSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           ˜_—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateDeleteRonriSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateDeleteRonriSQL";
            UFParameterClass cfUFParameterClass;
            var csDelRonriSQL = new StringBuilder();            // ˜_—íœ—pSQL

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˜_—DELETE SQL•¶‚Ìì¬
                csDelRonriSQL.Append("UPDATE ");
                csDelRonriSQL.Append(ABJutogaiEntity.TABLE_NAME);
                csDelRonriSQL.Append(" SET ");
                csDelRonriSQL.Append(ABJutogaiEntity.TANMATSUID);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.PARAM_TANMATSUID);
                csDelRonriSQL.Append(", ");
                csDelRonriSQL.Append(ABJutogaiEntity.SAKUJOFG);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.PARAM_SAKUJOFG);
                csDelRonriSQL.Append(", ");
                csDelRonriSQL.Append(ABJutogaiEntity.KOSHINCOUNTER);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.PARAM_KOSHINCOUNTER);
                csDelRonriSQL.Append(", ");
                csDelRonriSQL.Append(ABJutogaiEntity.KOSHINNICHIJI);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.PARAM_KOSHINNICHIJI);
                csDelRonriSQL.Append(", ");
                csDelRonriSQL.Append(ABJutogaiEntity.KOSHINUSER);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.PARAM_KOSHINUSER);
                csDelRonriSQL.Append(" WHERE ");
                csDelRonriSQL.Append(ABJutogaiEntity.JUMINCD);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.KEY_JUMINCD);
                csDelRonriSQL.Append(" AND ");
                csDelRonriSQL.Append(ABJutogaiEntity.KOSHINCOUNTER);
                csDelRonriSQL.Append(" = ");
                csDelRonriSQL.Append(ABJutogaiEntity.KEY_KOSHINCOUNTER);

                // ˜_—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfDelRonriUFParameterCollection = new UFParameterCollectionClass();

                // ˜_—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_TANMATSUID;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_SAKUJOFG;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_KOSHINCOUNTER;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_KOSHINNICHIJI;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.PARAM_KOSHINUSER;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_JUMINCD;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_KOSHINCOUNTER;
                m_cfDelRonriUFParameterCollection.Add(cfUFParameterClass);

                // ƒpƒ‰ƒ[ƒ^•Ï”‚ÖŠi”[
                m_strDelRonriSQL = csDelRonriSQL.ToString();

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72324


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72420


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72688


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72771


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     •¨—íœ—pSQL•¶‚Ìì¬
        // * 
        // * \•¶           Private Sub CreateButsuriSQL(ByVal csDataRow As DataRow)
        // * 
        // * ‹@”\           •¨—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
        // * 
        // * ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void CreateDeleteButsuriSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateDeleteButsuriSQL";
            UFParameterClass cfUFParameterClass;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // •¨—DELETE SQL•¶‚Ìì¬
                m_strDelButuriSQL = "DELETE FROM " + ABJutogaiEntity.TABLE_NAME + " WHERE " + ABJutogaiEntity.JUMINCD + " = " + ABJutogaiEntity.KEY_JUMINCD + " AND " + ABJutogaiEntity.KOSHINCOUNTER + " = " + ABJutogaiEntity.KEY_KOSHINCOUNTER;

                // •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfDelButuriUFParameterCollection = new UFParameterCollectionClass();

                // •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_JUMINCD;
                m_cfDelButuriUFParameterCollection.Add(cfUFParameterClass);

                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABJutogaiEntity.KEY_KOSHINCOUNTER;
                m_cfDelButuriUFParameterCollection.Add(cfUFParameterClass);

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 75472


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 75568


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 75836


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 75919


                Input:
                " + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp

                        End Try

                    End Sub
                    '* —š—ð”Ô† 000011 2005/06/16 ’Ç‰ÁI—¹

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue as String)
                    '* 
                    '* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           strColumnName As String : Z“oŠOƒ}ƒXƒ^ƒf[ƒ^ƒZƒbƒg‚Ì€–Ú–¼
                    '*                strValue As String     : €–Ú‚É‘Î‰ž‚·‚é’l
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CheckColumnValue(ByVal strColumnName As String, ByVal strValue As String)
                        Const THIS_METHOD_NAME As String = "CheckColumnValue"
                        Const TABLENAME As String = "Z“oŠOD"
                        Dim objErrorStruct As UFErrorStruct                 ' ƒGƒ‰[’è‹`\‘¢‘Ì


                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME, strColumnName + "'" + strValue + "'")

                            ' “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            If (IsNothing(m_cfDateClass)) Then
                                m_cfDateClass = New UFDateClass(m_cfConfigDataClass)
                                ' “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None
                            End If

                            Select Case strColumnName.ToUpper()

                                Case ABJutogaiEntity.JUMINCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_JUMINCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SHICHOSONCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KYUSHICHOSONCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KYUSHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.STAICD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_STAICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.ATENADATAKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_ATENADATAKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.ATENADATASHU
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_ATENADATASHU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SEARCHKANASEIMEI
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©–¼", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SEARCHKANASEI
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi©", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SEARCHKANAMEI
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(‰p”ŽšE”¼ŠpƒJƒi€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002017)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "ŒŸõ—pƒJƒi–¼", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANAMEISHO1
                                    '*—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANAMEISHO1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANJIMEISHO1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANJIMEISHO1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANAMEISHO2
                                    '*—š—ð”Ô† 000008 2003/10/30 C³ŠJŽn
                                    'If (Not UFStringClass.CheckKataKana(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '*—š—ð”Ô† 000008 2003/10/30 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANAMEISHO2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANJIMEISHO2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANJIMEISHO2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.UMAREYMD
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_UMAREYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABJutogaiEntity.UMAREWMD               '¶˜a—ï”NŒŽ“ú
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾(”Žš€–Ú“ü—Í‚ÌŒë‚è‚Å‚·BF)
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002013)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "¶˜a—ï”NŒŽ“ú", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SEIBETSUCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SEIBETSUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SEIBETSU
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SEIBETSU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.ZOKUGARACD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_ZOKUGARACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.ZOKUGARA
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_ZOKUGARA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.DAI2ZOKUGARACD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_DAI2ZOKUGARACD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.DAI2ZOKUGARA
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_DAI2ZOKUGARA)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANJIHJNDAIHYOSHSHIMEI
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANJIHJNDAIHYOSHSHIMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.HANYOKB1
                                    '*—š—ð”Ô† 000009 2004/05/13 C³ŠJŽn
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'If (Not UFStringClass.CheckNumber(strValue)) Then
                                        '*—š—ð”Ô† 000009 2004/05/13 C³ŠJŽn
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_HANYOKB1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANJIHJNKEITAI
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANJIHJNKEITAI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KJNHJNKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KJNHJNKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.HANYOKB2
                                    '*—š—ð”Ô† 000009 2004/05/13 C³ŠJŽn
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'If (Not UFStringClass.CheckNumber(strValue)) Then
                                        '*—š—ð”Ô† 000009 2004/05/13 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_HANYOKB2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KANNAIKANGAIKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KANNAIKANGAIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KAOKUSHIKIKB
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KAOKUSHIKIKB)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.BIKOZEIMOKU
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_BIKOZEIMOKU)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.YUBINNO                '—X•Ö”Ô†
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABE002013)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage + TABLENAME + "—X•Ö”Ô†", objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.JUSHOCD
                                    '*—š—ð”Ô† 000010 2005/01/15 C³ŠJŽn
                                    'If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '*—š—ð”Ô† 000010 2005/01/15 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_JUSHOCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.JUSHO
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_JUSHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.BANCHICD1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_BANCHICD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.BANCHICD2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_BANCHICD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.BANCHICD3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_BANCHICD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.BANCHI
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_BANCHI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KATAGAKIFG
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KATAGAKIFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KATAGAKICD
                                    If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KATAGAKICD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KATAGAKI
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KATAGAKI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.RENRAKUSAKI1
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_RENRAKUSAKI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.RENRAKUSAKI2
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_RENRAKUSAKI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.GYOSEIKUCD
                                    '* —š—ð”Ô† 000012 2005/12/26 C³ŠJŽn
                                    ''If (Not UFStringClass.CheckNumber(strValue.TrimStart)) Then
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        '* —š—ð”Ô† 000012 2005/12/26 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_GYOSEIKUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.GYOSEIKUMEI
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_GYOSEIKUMEI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.CHIKUCD1
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_CHIKUCD1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.CHIKUMEI1
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_CHIKUMEI1)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.CHIKUCD2
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_CHIKUCD2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.CHIKUMEI2
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_CHIKUMEI2)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.CHIKUCD3
                                    If (Not UFStringClass.CheckANK(strValue.TrimStart)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_CHIKUCD3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.CHIKUMEI3
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_CHIKUMEI3)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.TOROKUIDOYMD
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_TOROKUIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABJutogaiEntity.TOROKUJIYUCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_TOROKUJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SHOJOIDOYMD
                                    If Not (strValue = String.Empty Or strValue = "00000000") Then
                                        m_cfDateClass.p_strDateValue = strValue
                                        If (Not m_cfDateClass.CheckDate()) Then
                                            'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                            m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                            objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SHOJOIDOYMD)
                                            '—áŠO‚ð¶¬
                                            Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                        End If
                                    End If

                                Case ABJutogaiEntity.SHOJOJIYUCD
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SHOJOJIYUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.RESERVE
                                        'ƒ`ƒFƒbƒN‚È‚µ

                                Case ABJutogaiEntity.TANMATSUID
                                    '* —š—ð”Ô† 000006 2003/09/11 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000006 2003/09/11 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SAKUJOFG
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KOSHINCOUNTER
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SAKUSEINICHIJI
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.SAKUSEIUSER
                                    '* —š—ð”Ô† 000007 2003/10/09 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000007 2003/10/09 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KOSHINNICHIJI
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                                Case ABJutogaiEntity.KOSHINUSER
                                    '* —š—ð”Ô† 000007 2003/10/09 C³ŠJŽn
                                    'If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        '* —š—ð”Ô† 000007 2003/10/09 C³I—¹
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABJUTOGAIB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If

                            End Select

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw objExp
                        End Try

                    End Sub

                #End Region

                End Class
                 */
            }
        }
    }
}