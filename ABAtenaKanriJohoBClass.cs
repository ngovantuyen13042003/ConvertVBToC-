// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼ŠÇ—î•ñ‚c‚`(ABAtenaKanriJohoBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/14@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/03/17 000001     ’Ç‰ÁŽžA‹¤’Ê€–Ú‚ðÝ’è‚·‚é
// * 2003/04/14 000002     Ží•Ê‚ðƒL[‚ÉŽæ“¾‚·‚éƒƒ\ƒbƒh‚ð’Ç‰Á
// * 2003/05/21 000003     ƒGƒ‰[A“ú•tƒNƒ‰ƒX‚Ì²Ý½ÀÝ½‚ðºÝ½Ä×¸À‚É•ÏX
// * 2003/08/28 000004     RDBƒAƒNƒZƒXƒƒO‚ÌC³
// * 2005/01/17 000005     ˆ¶–¼ŠÇ—î•ñ‚ÌŽ¯•ÊƒL[‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðC³(”Žš¨‰p”Žš)
// * 2007/07/27 000006     “¯ˆêl‘ã•\ŽÒŽæ“¾ƒƒ\ƒbƒh’Ç‰Á(‹gàV)
// * 2007/10/03 000007     XVŽž‚Éu”õlv‚Í‰½‚àƒ`ƒFƒbƒN‚µ‚È‚¢‚æ‚¤‚É•ÏX(‹gàV)
// * 2008/02/13 000008     Ž–¼Š‡ŒÊ•ÒW§ŒäŽæ“¾ƒƒ\ƒbƒh’Ç‰Ái”ä‰Ãj
// * 2010/04/16 000009     VS2008‘Î‰ži”ä‰Ãj
// * 2010/05/12 000010     –{Ð•M“ªŽÒŽæ“¾‹æ•ªŽæ“¾ƒƒ\ƒbƒhAŠOŽšƒtƒ‰ƒOŽæ“¾‹æ•ªŽæ“¾ƒƒ\ƒbƒh’Ç‰Ái”ä‰Ãj
// * 2011/05/18 000011     –{–¼E’ÊÌ–¼—DæÝ’è§Œäƒpƒ‰ƒ[ƒ^Žæ“¾ƒƒ\ƒbƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2014/12/18 000012     yAB21040z”Ô†§“x@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ªƒpƒ‰ƒ[ƒ^[Žæ“¾ƒƒ\ƒbƒh‚ð’Ç‰ÁiÎ‡j
// * 2015/01/05 000013     yAB21034z”Ô†§“x@–@l”Ô†—˜—pŠJŽn“úƒpƒ‰ƒ[ƒ^[Žæ“¾ƒƒ\ƒbƒh‚ð’Ç‰ÁiÎ‡j
// * 2015/03/05 000014     yAB21034z”Ô†§“x@–@l”Ô†—˜—pŠJŽn“ú‚ÌƒGƒ‰[ƒƒbƒZ[ƒW‚ð•ÏXiÎ‡j
// * 2018/05/07 000015     yAB27002z”õlŠÇ—iÎ‡j
// * 2018/05/22 000016     yAB24011z˜A—æŠÇ—€–Ú’Ç‰ÁiÎ‡j
// * 2020/08/03 000017     yAB32008z‘ã”[E‘—•tæ”õlŠÇ—iÎ‡j
// * 2020/08/21 000018     yAB32006z‘ã”[E‘—•tæƒƒ“ƒeƒiƒ“ƒXiÎ‡j
// * 2020/11/10 000019     yAB00189z—˜—p“Ío•¡””[ÅŽÒID‘Î‰ži{]j
// * 2023/12/22 000020     yAB-0970-1_2zˆ¶–¼GET“ú•t€–ÚÝ’è‘Î‰ž(‰º‘º)
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAtenaKanriJohoBClass
    {
        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private string m_strInsertSQL;                                            // INSERT—pSQL
        private string m_strUpdateSQL;                                            // UPDATE—pSQL
        private string m_strDeleteSQL;                                            // DELETE—pSQL
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;  // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;  // DELETE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“

        // *—š—ð”Ô† 000006 2007/07/27 ’Ç‰ÁŠJŽn
        private string[] m_strDoitsuHantei_Param = new[] { "10", "07" };             // “¯ˆêl‘ã•\ŽÒ‚ÌŽæ“¾”»’è
                                                                                     // *—š—ð”Ô† 000006 2007/07/27 ’Ç‰ÁI—¹
                                                                                     // *—š—ð”Ô† 000008 2008/02/13 ’Ç‰ÁŠJŽn
        private string[] m_strShimeiKakkoKB_Param = new[] { "10", "15" };            // Ž–¼Š‡ŒÊ•ÒW§Œä
                                                                                     // *—š—ð”Ô† 000008 2008/02/13 ’Ç‰ÁI—¹
                                                                                     // *—š—ð”Ô† 000010 2010/05/12 ’Ç‰ÁŠJŽn
        private string[] m_strHonsekiKB_Param = new[] { "10", "18" };                // –{ÐŽæ“¾‹æ•ª
        private string[] m_strShoriTeishiKB_Param = new[] { "10", "19" };            // ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ª
                                                                                     // *—š—ð”Ô† 000010 2010/05/12 ’Ç‰ÁI—¹
                                                                                     // *—š—ð”Ô† 000011 2011/05/18 ’Ç‰ÁŠJŽn
        private string[] m_strHonmyoTsushomeiYusenKB_Param = new[] { "10", "23" };   // –{–¼’ÊÌ–¼—Dæ‹æ•ªŽæ“¾‹æ•ª
                                                                                     // *—š—ð”Ô† 000011 2011/05/18 ’Ç‰ÁI—¹
                                                                                     // *—š—ð”Ô† 000019 2020/11/10 ’Ç‰ÁŠJŽn
        private string[] m_strHenkyakuFuyoGyomuCD_Param = new[] { "10", "46" };      // “ÆŽ©ˆ—@—˜—p“Ío‹¤’Ê”[Å•Ô‹p•s—v‹Æ–±
                                                                                     // *—š—ð”Ô† 000019 2020/11/10 ’Ç‰ÁI—¹
                                                                                     // *—š—ð”Ô† 000012 2014/12/18 ’Ç‰ÁŠJŽn
        private string[] m_strMyNumberChokkinSearchKB_Param = new string[] { "35", "29" };   // ”Ô†§“x@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ª
                                                                                             // *—š—ð”Ô† 000012 2014/12/18 ’Ç‰ÁI—¹
                                                                                             // *—š—ð”Ô† 000013 2015/01/05 ’Ç‰ÁŠJŽn
        private string[] m_strHojinBangoRiyoKaishiYMD_Param = new string[] { "35", "30" };   // ”Ô†§“x@–@l”Ô†—˜—pŠJŽn“ú
                                                                                             // *—š—ð”Ô† 000013 2015/01/05 ’Ç‰ÁI—¹
                                                                                             // *—š—ð”Ô† 000015 2018/05/07 ’Ç‰ÁŠJŽn
        private string[] m_strJutogaiBikoUmu_Param = new string[] { "40", "07" };            // ŽŸŠú‚q‚…‚‚‚“@Z“oŠO”õl—L–³
                                                                                             // *—š—ð”Ô† 000015 2018/05/07 ’Ç‰ÁI—¹
                                                                                             // *—š—ð”Ô† 000016 2018/05/22 ’Ç‰ÁŠJŽn
        private string[] m_strRenrakusakiKakuchoUmu_Param = new string[] { "40", "08" };     // ŽŸŠú‚q‚…‚‚‚“@˜A—æŠg’£—L–³
                                                                                             // *—š—ð”Ô† 000016 2018/05/22 ’Ç‰ÁI—¹
                                                                                             // *—š—ð”Ô† 000017 2020/08/03 ’Ç‰ÁŠJŽn
        private string[] m_strDainoSfskBikoUmu_Param = new string[] { "40", "15" };          // ‘ã”[E‘—•tæ”õl—L–³
                                                                                             // *—š—ð”Ô† 000017 2020/08/03 ’Ç‰ÁI—¹
                                                                                             // *—š—ð”Ô† 000018 2020/08/21 ’Ç‰ÁŠJŽn
        private string[] m_strZeimokuCDConvertTable_Param = new string[] { "10", "40" };     // Å–ÚƒR[ƒh•ÏŠ·ƒe[ƒuƒ‹
        private string[] m_strDainoSfskMainteShiyoUmu_Param = new string[] { "12", "25" };   // ‘ã”[E‘—•tæƒƒ“ƒeƒiƒ“ƒXŽg—p—L–³
                                                                                             // *—š—ð”Ô† 000018 2020/08/21 ’Ç‰ÁI—¹
        private string[] m_strUmareYMDHenkan_Param = new string[] { "51", "01" };            // •W€€‹’‘Î‰žˆ¶–¼GET —ðã“ú•ÏŠ·“ú•ti¶”NŒŽ“új
        private string[] m_strShojoIdobiHenkan_Param = new string[] { "51", "02" };          // •W€€‹’‘Î‰žˆ¶–¼GET —ðã“ú•ÏŠ·“ú•tiÁœˆÙ“®“új
        private string[] m_strCknIdobiHenkan_Param = new string[] { "51", "03" };            // •W€€‹’‘Î‰žˆ¶–¼GET —ðã“ú•ÏŠ·“ú•ti’¼‹ßˆÙ“®“új

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAtenaKanriJohoBClass";
        private const string THIS_BUSINESSID = "AB";                              // ‹Æ–±ƒR[ƒh
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
        public ABAtenaKanriJohoBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

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
            m_cfInsertUFParameterCollectionClass = (object)null;
            m_cfUpdateUFParameterCollectionClass = (object)null;
            m_cfDeleteUFParameterCollectionClass = (object)null;
        }
        #endregion

        #region ƒƒ\ƒbƒh
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼ŠÇ—î•ñ’Šo
        // * 
        // * \•¶           Public Overloads Function GetKanriJohoHoshu() As DataSet
        // * 
        // * ‹@”\@@    @@ˆ¶–¼ŠÇ—î•ñ‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½ˆ¶–¼ŠÇ—î•ñ‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsAtenaKanriJohoEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABAtenaKanriJohoEntity
        // ************************************************************************************************
        public DataSet GetKanriJohoHoshu()
        {
            const string THIS_METHOD_NAME = "GetKanriJohoHoshu";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csAtenaKanriJohoEntity;                           // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABAtenaKanriJohoEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABAtenaKanriJohoEntity.KANRINENDO);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_KANRINENDO);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.GYOMUCD);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_GYOMUCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // ŠÇ—”N“x
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_KANRINENDO;
                cfUFParameterClass.Value = "0000";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_GYOMUCD;
                cfUFParameterClass.Value = "AB";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
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

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11653


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                                 */
                csAtenaKanriJohoEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABAtenaKanriJohoEntity.TABLE_NAME, cfUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12594


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12697


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13249


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csAtenaKanriJohoEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ŠÇ—î•ñ’Šo(µ°ÊÞ°Û°ÄÞ)
                    '* 
                    '* \•¶           Public Overloads Function GetKanriJohoHoshu(ByVal strSHUKey As String, 
                    '*                                                            ByVal strShikibetsuKey As String) As DataSet
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼ŠÇ—î•ñ‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strSHUKey As String           :Ží•ÊƒL[
        // *                strShikibetsuKey As String    :Ž¯•ÊƒL[
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½ˆ¶–¼ŠÇ—î•ñ‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsAtenaKanriJohoEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABAtenaKanriJohoEntity
        // ************************************************************************************************
        public DataSet GetKanriJohoHoshu(string strSHUKey, string strShikibetsuKey)
        {
            const string THIS_METHOD_NAME = "GetKanriJohoHoshu(Overloads)";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csAtenaKanriJohoEntity;                           // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABAtenaKanriJohoEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABAtenaKanriJohoEntity.KANRINENDO);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_KANRINENDO);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.GYOMUCD);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_GYOMUCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.SHUKEY);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_SHUKEY);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.SHIKIBETSUKEY);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_SHIKIBETSUKEY);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // ŠÇ—”N“x
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_KANRINENDO;
                cfUFParameterClass.Value = "0000";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_GYOMUCD;
                cfUFParameterClass.Value = "AB";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // Ží•ÊƒL[
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_SHUKEY;
                cfUFParameterClass.Value = strSHUKey;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // Ž¯•ÊƒL[
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_SHIKIBETSUKEY;
                cfUFParameterClass.Value = strShikibetsuKey;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
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

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18669


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                                 */
                csAtenaKanriJohoEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABAtenaKanriJohoEntity.TABLE_NAME, cfUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19610


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19713


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20265


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csAtenaKanriJohoEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ŠÇ—î•ñ’Šo(µ°ÊÞ°Û°ÄÞ)
                    '* 
                    '* \•¶           Public Overloads Function GetKanriJohoHoshu(ByVal strSHUKey As String) As DataSet
                    '* 
                    '* ‹@”\@@    @@ˆ¶–¼ŠÇ—î•ñ‚æ‚èŠY“–ƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           strSHUKey As String           :Ží•ÊƒL[
        // * 
        // * –ß‚è’l         Žæ“¾‚µ‚½ˆ¶–¼ŠÇ—î•ñ‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                   \‘¢FcsAtenaKanriJohoEntity    ƒCƒ“ƒeƒŠƒZƒ“ƒXFABAtenaKanriJohoEntity
        // ************************************************************************************************
        public DataSet GetKanriJohoHoshu(string strSHUKey)
        {
            const string THIS_METHOD_NAME = "GetKanriJohoHoshu(Overloads)";          // ‚±‚Ìƒƒ\ƒbƒh–¼
            DataSet csAtenaKanriJohoEntity;                           // ˆ¶–¼ŠÇ—î•ñƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL•¶‚Ìì¬
                strSQL.Append("SELECT * FROM ");
                strSQL.Append(ABAtenaKanriJohoEntity.TABLE_NAME);
                // WHERE•¶Œ‹‡
                strSQL.Append(" WHERE ");
                strSQL.Append(ABAtenaKanriJohoEntity.KANRINENDO);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_KANRINENDO);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.GYOMUCD);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_GYOMUCD);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.SHUKEY);
                strSQL.Append(" = ");
                strSQL.Append(ABAtenaKanriJohoEntity.KEY_SHUKEY);
                strSQL.Append(" AND ");
                strSQL.Append(ABAtenaKanriJohoEntity.SAKUJOFG);
                strSQL.Append(" <> 1");

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // ŠÇ—”N“x
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_KANRINENDO;
                cfUFParameterClass.Value = "0000";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // ‹Æ–±ƒR[ƒh
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_GYOMUCD;
                cfUFParameterClass.Value = "AB";
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);
                // Ží•ÊƒL[
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_SHUKEY;
                cfUFParameterClass.Value = strSHUKey;
                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                cfUFParameterCollectionClass.Add(cfUFParameterClass);

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                // ' RDBƒAƒNƒZƒXƒƒOo—Í
                // m_cfLogClass.RdbWrite(m_cfControlData, _
                // "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                // "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                // "yŽÀsƒƒ\ƒbƒh–¼:GetDataSetz" + _
                // "ySQL“à—e:" + strSQL.ToString + "z")

                // RDBƒAƒNƒZƒXƒƒOo—Í
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

                // SQL‚ÌŽÀs DataSet‚ÌŽæ“¾
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 24913


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                                 */
                csAtenaKanriJohoEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), ABAtenaKanriJohoEntity.TABLE_NAME, cfUFParameterCollectionClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25854


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 25957


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 26509


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return csAtenaKanriJohoEntity

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ŠÇ—î•ñ’Ç‰Á
                    '* 
                    '* \•¶           Public Function InsertKanriJoho(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ˆ¶–¼ŠÇ—î•ñ‚Éƒf[ƒ^‚ð’Ç‰Á‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :’Ç‰Áƒf[ƒ^
        // * 
        // * –ß‚è’l         ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertKanriJoho(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertKanriJoho";            // ‚±‚Ìƒƒ\ƒbƒh–¼
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
                    CreateSQL(csDataRow);
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");          // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaKanriJohoEntity.TANMATSUID) = m_cfControlData.m_strClientId;            // ’[––‚h‚c
                csDataRow(ABAtenaKanriJohoEntity.SAKUJOFG) = "0";                                        // íœƒtƒ‰ƒO
                csDataRow(ABAtenaKanriJohoEntity.KOSHINCOUNTER) = decimal.Zero;                          // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaKanriJohoEntity.SAKUSEINICHIJI) = strUpdateDateTime;                    // ì¬“úŽž
                csDataRow(ABAtenaKanriJohoEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;             // ì¬ƒ†[ƒU[
                csDataRow(ABAtenaKanriJohoEntity.KOSHINNICHIJI) = strUpdateDateTime;                     // XV“úŽž
                csDataRow(ABAtenaKanriJohoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;              // XVƒ†[ƒU[

                // “–ƒNƒ‰ƒX‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¤
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                    // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    CheckColumnValue(csDataColumn.ColumnName, csDataRow(csDataColumn.ColumnName).ToString.Trim);

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER.RLength)).ToString();

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 30606


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31505


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 31608


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 32160


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intInsCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ŠÇ—î•ñXV
                    '* 
                    '* \•¶           Public Function UpdateKanriJoho(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ˆ¶–¼ŠÇ—î•ñ‚Ìƒf[ƒ^‚ðXV‚·‚éB

                 */
            }

            return default;
        }
        // * 
        // * ˆø”           csDataRow As DataRow  :XVƒf[ƒ^
        // * 
        // * –ß‚è’l         XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateKanriJoho(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateKanriJoho";         // ‚±‚Ìƒƒ\ƒbƒh–¼
                                                                       // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                       // * corresponds to VS2008 Start 2010/04/16 000009
                                                                       // Dim csDataColumn As DataColumn
                                                                       // * corresponds to VS2008 End 2010/04/16 000009
            int intUpdCnt;                            // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpdateSQL is null | string.IsNullOrEmpty(m_strUpdateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABAtenaKanriJohoEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                    // ’[––‚h‚c
                csDataRow(ABAtenaKanriJohoEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABAtenaKanriJohoEntity.KOSHINCOUNTER) + 1m;     // XVƒJƒEƒ“ƒ^
                csDataRow(ABAtenaKanriJohoEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate().ToString("yyyyMMddHHmmssfff");    // XV“úŽž
                csDataRow(ABAtenaKanriJohoEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                      // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABAtenaKanriJohoEntity.PREFIX_KEY.RLength) == ABAtenaKanriJohoEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                        CheckColumnValue(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER.RLength), csDataRow(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString.Trim);
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

                // *—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 36495


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpdateSQL, m_cfUpdateUFParameterCollectionClass) + "z")
                                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37394


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 37497


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 38049


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw exException

                        End Try

                        Return intUpdCnt

                    End Function

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ¶–¼ŠÇ—î•ñíœi•¨—j
                    '* 
                    '* \•¶           Public Overloads Function DeleteKanriJoho(ByVal csDataRow As DataRow) As Integer
                    '* 
                    '* ‹@”\@@    @  ˆ¶–¼ŠÇ—î•ñ‚Ìƒf[ƒ^‚ðíœi•¨—j‚·‚éB
                    '* 
                    '* ˆø”           csDataRow As DataRow      :íœƒf[ƒ^
                    '* 
                    '* –ß‚è’l         íœi•¨—jŒ”(Integer)
                    '************************************************************************************************
                    Public Overloads Function DeleteKanriJoho(ByVal csDataRow As DataRow) As Integer
                        Const THIS_METHOD_NAME As String = "DeleteKanriJohoi•¨—j"
                        Dim cfParam As UFParameterClass                                 'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        '* corresponds to VS2008 Start 2010/04/16 000009
                        'Dim csDataColumn As DataColumn
                        'Dim objErrorStruct As UFErrorStruct                             'ƒGƒ‰[’è‹`\‘¢‘Ì
                        '* corresponds to VS2008 End 2010/04/16 000009
                        Dim intDelCnt As Integer                                        'íœŒ”

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                            If (m_strDeleteSQL Is Nothing Or m_strDeleteSQL = String.Empty Or _
                                m_cfDeleteUFParameterCollectionClass Is Nothing) Then
                                Call CreateSQL(csDataRow)
                            End If

                            ' ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                            For Each cfParam In m_cfDeleteUFParameterCollectionClass
                                ' ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                                If (cfParam.ParameterName.RSubstring(0, ABAtenaKanriJohoEntity.PREFIX_KEY.RLength) = ABAtenaKanriJohoEntity.PREFIX_KEY) Then
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value =
                                            csDataRow(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PREFIX_KEY.RLength),
                                                      DataRowVersion.Original).ToString()
                                Else
                                    ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                                    m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value _
                                            = csDataRow(cfParam.ParameterName.RSubstring(ABAtenaKanriJohoEntity.PREFIX_KEY.RLength), DataRowVersion.Current).ToString()
                                End If
                            Next cfParam

                            '*—š—ð”Ô† 000004 2003/08/28 C³ŠJŽn
                            '' RDBƒAƒNƒZƒXƒƒOo—Í
                            'm_cfLogClass.RdbWrite(m_cfControlData, _
                            '                            "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                            '                            "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                            '                            "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                            '                            "ySQL“à—e:" + m_strDeleteSQL + "z")

                            ' RDBƒAƒNƒZƒXƒƒOo—Í
                            m_cfLogClass.RdbWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + Me.GetType.Name + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod.Name + "z" + _
                                                        "yŽÀsƒƒ\ƒbƒh–¼:ExecuteSQLz" + _
                                                        "ySQL“à—e:" + m_cfRdbClass.GetDevelopmentSQLString(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass) + "z")
                            '*—š—ð”Ô† 000004 2003/08/28 C³I—¹

                            ' SQL‚ÌŽÀs
                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass)

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

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     SQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@    @@INSERT, UPDATE, DELETE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateSQL(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateSQL"              '‚±‚Ìƒƒ\ƒbƒh–¼
                        Dim csDataColumn As DataColumn
                        Dim cfUFParameterClass As UFParameterClass                  'ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strInsertColumn As String                               '’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
                        Dim strInsertParam As String                                '’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
                        Dim strDeleteSQL As New StringBuilder                       'íœSQL•¶•¶Žš—ñ
                        Dim strWhere As New StringBuilder                           'XVíœSQL•¶Where•¶•¶Žš—ñ

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' SELECT SQL•¶‚Ìì¬
                            m_strInsertSQL = "INSERT INTO " + ABAtenaKanriJohoEntity.TABLE_NAME + " "
                            strInsertColumn = ""
                            strInsertParam = ""

                            ' XVíœWhere•¶ì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KANRINENDO)
                            strWhere.Append(" = ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KEY_KANRINENDO)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABAtenaKanriJohoEntity.GYOMUCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KEY_GYOMUCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABAtenaKanriJohoEntity.SHUKEY)
                            strWhere.Append(" = ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KEY_SHUKEY)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABAtenaKanriJohoEntity.SHIKIBETSUKEY)
                            strWhere.Append(" = ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KEY_SHIKIBETSUKEY)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABAtenaKanriJohoEntity.KEY_KOSHINCOUNTER)

                            ' UPDATE SQL•¶‚Ìì¬
                            m_strUpdateSQL = "UPDATE " + ABAtenaKanriJohoEntity.TABLE_NAME + " SET "

                            ' DELETEi•¨—j SQL•¶‚Ìì¬
                            strDeleteSQL.Append("DELETE FROM ")
                            strDeleteSQL.Append(ABAtenaKanriJohoEntity.TABLE_NAME)
                            strDeleteSQL.Append(strWhere.ToString)
                            m_strDeleteSQL = strDeleteSQL.ToString

                            ' SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfInsertUFParameterCollectionClass = New UFParameterCollectionClass

                            ' UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfUpdateUFParameterCollectionClass = New UFParameterCollectionClass

                            ' DELETEi•¨—j ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass

                            ' ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                            For Each csDataColumn In csDataRow.Table.Columns
                                cfUFParameterClass = New UFParameterClass

                                ' INSERT SQL•¶‚Ìì¬
                                strInsertColumn += csDataColumn.ColumnName + ", "
                                strInsertParam += ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' SQL•¶‚Ìì¬
                                m_strUpdateSQL += csDataColumn.ColumnName + " = " + ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", "

                                ' INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass)

                                ' UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                                cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName
                                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)

                            Next csDataColumn

                            ' INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            strInsertColumn = strInsertColumn.Trim()
                            strInsertColumn = strInsertColumn.Trim(CType(",", Char))
                            strInsertParam = strInsertParam.Trim()
                            strInsertParam = strInsertParam.Trim(CType(",", Char))
                            m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")"

                            ' UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                            m_strUpdateSQL = m_strUpdateSQL.Trim()
                            m_strUpdateSQL = m_strUpdateSQL.Trim(CType(",", Char))

                            ' UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                            m_strUpdateSQL += strWhere.ToString

                            ' UPDATE,DELETE(•¨—) ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                            ' ŠÇ—”N“x
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_KANRINENDO
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' ‹Æ–±ƒR[ƒh
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_GYOMUCD
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Ží•ÊƒL[
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_SHUKEY
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Ž¯•ÊƒL[
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_SHIKIBETSUKEY
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABAtenaKanriJohoEntity.KEY_KOSHINCOUNTER
                            m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass)
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

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ƒf[ƒ^®‡«ƒ`ƒFƒbƒN
                    '* 
                    '* \•¶           Private Sub CheckColumnValue(ByVal strColumnName As String,
                    '*                                             ByVal strValue As String)
                    '* 
                    '* ‹@”\@@       ˆ¶–¼ŠÇ—î•ñ‚Ìƒf[ƒ^®‡«ƒ`ƒFƒbƒN‚ðs‚¢‚Ü‚·B
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
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Select Case strColumnName.ToUpper()
                                Case ABAtenaKanriJohoEntity.SHICHOSONCD                 'Žs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.KYUSHICHOSONCD              '‹ŒŽs’¬‘ºƒR[ƒh
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_KYUSHICHOSONCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.KANRINENDO                  'ŠÇ—”N“x
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_KANRINENDO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.GYOMUCD                     '‹Æ–±ƒR[ƒh
                                    If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_GYOMUCD)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SHUKEY                      'Ží•ÊƒL[
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SHUKEY)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SHIKIBETSUKEY               'Ž¯•ÊƒL[
                                    '*—š—ð”Ô† 000005 2006/01/17 C³ŠJŽn
                                    If (Not UFStringClass.CheckAlphabetNumber(strValue)) Then
                                        'If (Not UFStringClass.CheckNumber(strValue)) Then
                                        '*—š—ð”Ô† 000005 2006/01/17 C³I—¹
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SHIKIBETSUKEY)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SHUKEYMEISHO                'Ží•ÊƒL[–¼Ì
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SHUKEYMEISHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SHIKIBETSUKEYMEISHO         'Ž¯•ÊƒL[–¼Ì
                                    If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SHIKIBETSUKEYMEISHO)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.PARAMETER                   'ƒpƒ‰ƒ[ƒ^
                                    '‰½‚à‚µ‚È‚¢
                                Case ABAtenaKanriJohoEntity.BIKO                        '”õl
                                    '*—š—ð”Ô† 000007 2007/10/01 íœŠJŽn
                                    'If (Not UFStringClass.CheckKanjiCode(strValue, m_cfConfigDataClass)) Then
                                    '    m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                    '    'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                    '    objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_BIKO)
                                    '    '—áŠO‚ð¶¬
                                    '    Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    'End If
                                    '*—š—ð”Ô† 000007 2007/10/01 íœI—¹
                                Case ABAtenaKanriJohoEntity.RESERVE                     'ƒŠƒU[ƒu
                                    '‰½‚à‚µ‚È‚¢
                                Case ABAtenaKanriJohoEntity.TANMATSUID                  '’[––ID
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_TANMATSUID)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SAKUJOFG                    'íœƒtƒ‰ƒO
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SAKUJOFG)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.KOSHINCOUNTER               'XVƒJƒEƒ“ƒ^
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_KOSHINCOUNTER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SAKUSEINICHIJI              'ì¬“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SAKUSEINICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.SAKUSEIUSER                 'ì¬ƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_SAKUSEIUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.KOSHINNICHIJI               'XV“úŽž
                                    If (Not UFStringClass.CheckNumber(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_KOSHINNICHIJI)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                                Case ABAtenaKanriJohoEntity.KOSHINUSER                  'XVƒ†[ƒU
                                    If (Not UFStringClass.CheckANK(strValue)) Then
                                        m_cfErrorClass = New UFErrorClass(THIS_BUSINESSID)
                                        'ƒGƒ‰[’è‹`‚ðŽæ“¾
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(ABErrorClass.ABATENAKANRIJOHOB_RDBDATATYPE_KOSHINUSER)
                                        '—áŠO‚ð¶¬
                                        Throw New UFAppException(objErrorStruct.m_strErrorMessage, objErrorStruct.m_strErrorCode)
                                    End If
                            End Select

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

                    '*—š—ð”Ô† 000006 2007/07/27 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     “¯ˆêl‘ã•\ŽÒŽæ“¾‚Ì”»’èƒpƒ‰ƒ[ƒ^Žæ“¾
                    '* 
                    '* \•¶           Public Function GetDoitsuHantei_Param() As DataSet
                    '* 
                    '* ‹@”\           “¯ˆêl‘ã•\ŽÒŽæ“¾‚Ì”»’èƒpƒ‰ƒ[ƒ^‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           strShichosonCD As String : Žs’¬‘ºƒR[ƒh
                    '* 
                    '* –ß‚è’l         String : 
                    '************************************************************************************************
                    Public Function GetDoitsuHantei_Param() As String
                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetDoitsuHantei_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strDoitsuHantei_Param(0), m_strDoitsuHantei_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA–{lî•ñ‚ÌŽæ“¾‚Æ‚·‚é
                                strRet = ABConstClass.PRM_HONNIN
                            ElseIf CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER)) = ABConstClass.PRM_DAIHYO Then
                                'ƒpƒ‰ƒ[ƒ^‚ª“¯ˆêl‘ã•\ŽÒŽæ“¾‚Ìê‡‚ÍA“¯ˆêl‘ã•\ŽÒ‚ÌŽæ“¾‚Æ‚·‚é
                                strRet = ABConstClass.PRM_DAIHYO
                            Else
                                'ã‹LˆÈŠO‚ÍA–{lî•ñ‚ÌŽæ“¾‚Æ‚·‚é
                                strRet = ABConstClass.PRM_HONNIN
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

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
                    End Function
                    '*—š—ð”Ô† 000006 2007/07/27 ’Ç‰ÁI—¹
                    '*—š—ð”Ô† 000008 2008/02/13 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     Ž–¼Š‡ŒÊ•ÒW§Œäƒpƒ‰ƒ[ƒ^Žæ“¾
                    '* 
                    '* \•¶           Public Function GetShimeiKakkoKB_Param() As DataSet
                    '* 
                    '* ‹@”\           Ž–¼Š‡ŒÊ•ÒW§Œä‚Ì”»’èƒpƒ‰ƒ[ƒ^‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         String : 
                    '************************************************************************************************
                    Public Function GetShimeiKakkoKB_Param() As String
                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetShimeiKakkoKB_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strShimeiKakkoKB_Param(0), m_strShimeiKakkoKB_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA•W€‚Æ‚·‚é
                                strRet = "0"
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function
                    '*—š—ð”Ô† 000008 2008/02/13 ’Ç‰ÁI—¹
                    '*—š—ð”Ô† 000010 2010/05/12 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     –{ÐŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^Žæ“¾
                    '* 
                    '* \•¶           Public Function GetHonsekiKB_Param() As DataSet
                    '* 
                    '* ‹@”\           –{ÐŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         String 
                    '************************************************************************************************
                    Public Function GetHonsekiKB_Param() As String
                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetHonsekiKB_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strHonsekiKB_Param(0), m_strHonsekiKB_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = "0"
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^Žæ“¾
                    '* 
                    '* \•¶           Public Function GetShoriteishiKB_Param() As DataSet
                    '* 
                    '* ‹@”\           ˆ—’âŽ~‹æ•ªŽæ“¾‹æ•ªƒpƒ‰ƒ[ƒ^‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         String 
                    '************************************************************************************************
                    Public Function GetShoriteishiKB_Param() As String
                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetShoriteishiKB_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strShoriTeishiKB_Param(0), m_strShoriTeishiKB_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = "0"
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function
                    '*—š—ð”Ô† 000010 2010/05/12 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000011 2011/05/18 ’Ç‰ÁŠJŽn
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     –{–¼E’ÊÌ–¼—Dæ§Œä‹æ•ªƒpƒ‰ƒ[ƒ^Žæ“¾
                    '* 
                    '* \•¶           Public Function GetHonmyoTsushomeiYusenKB_Param() As String
                    '* 
                    '* ‹@”\           –{–¼E’ÊÌ–¼—Dæ§Œä‹æ•ªƒpƒ‰ƒ[ƒ^‚ðŽæ“¾‚·‚é
                    '* 
                    '* ˆø”           ‚È‚µ
                    '* 
                    '* –ß‚è’l         String 
                    '************************************************************************************************
                    Public Function GetHonmyoTsushomeiYusenKB_Param() As String
                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetHonmyoTsushomeiYusenKB_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strHonmyoTsushomeiYusenKB_Param(0), m_strHonmyoTsushomeiYusenKB_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = "0"
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function
                    '*—š—ð”Ô† 000011 2011/05/18 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000012 2014/12/18 ’Ç‰ÁŠJŽn
                #Region "”Ô†§“x@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ª@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' ”Ô†§“x@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ª@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>”Ô†§“x@ˆ¶–¼Žæ“¾@’¼‹ßŒŸõ‹æ•ª</returns>
                    ''' <remarks></remarks>
                    Public Function GetMyNumberChokkinSearchKB_Param() As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csDataSet As DataSet
                        Dim strResult As String

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strMyNumberChokkinSearchKB_Param(0), m_strMyNumberChokkinSearchKB_Param(1))

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then

                                strResult = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString

                                Select Case strResult

                                    Case ABEnumDefine.MyNumberChokkinSearchKB.CKIN.GetHashCode.ToString, _
                                         ABEnumDefine.MyNumberChokkinSearchKB.RRK.GetHashCode.ToString
                                        ' noop
                                    Case Else

                                        ' ‹K’è’lˆÈŠOi’l‚È‚µ‚ðŠÜ‚Þj‚Ìê‡‚ÍA"2"i—š—ð‚ðŠÜ‚ß‚ÄŒŸõj‚ðÝ’è‚·‚éB
                                        strResult = ABEnumDefine.MyNumberChokkinSearchKB.RRK.GetHashCode.ToString

                                End Select

                            Else

                                ' ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA"2"i—š—ð‚ðŠÜ‚ß‚ÄŒŸõj‚ðÝ’è‚·‚éB
                                strResult = ABEnumDefine.MyNumberChokkinSearchKB.RRK.GetHashCode.ToString

                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return strResult

                    End Function

                #End Region
                    '*—š—ð”Ô† 000012 2014/12/18 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000013 2015/01/05 ’Ç‰ÁŠJŽn
                #Region "”Ô†§“x@–@l”Ô†—˜—pŠJŽn“ú@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' ”Ô†§“x@–@l”Ô†—˜—pŠJŽn“ú@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>”Ô†§“x@–@l”Ô†—˜—pŠJŽn“ú</returns>
                    ''' <remarks></remarks>
                    Public Function GetHojinBangoRiyoKaishiYMD_Param() As String

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csDataSet As DataSet
                        Dim strResult As String
                        Dim cfDate As UFDateClass                           ' “ú•tƒNƒ‰ƒX
                        Dim cfErrorClass As UFErrorClass                    ' ƒGƒ‰[ƒNƒ‰ƒX
                        Dim cfErrorStruct As UFErrorStruct                  ' ƒGƒ‰[’è‹`\‘¢‘Ì

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strHojinBangoRiyoKaishiYMD_Param(0), m_strHojinBangoRiyoKaishiYMD_Param(1))

                            ' ƒpƒ‰ƒ[ƒ^[’l‚ÌŽæ‚èo‚µ
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then
                                strResult = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString
                            Else
                                strResult = String.Empty
                            End If

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            cfDate = New UFDateClass(m_cfConfigDataClass, UFDateSeparator.None, UFDateFillType.Zero, UFEraType.Number, False, False)
                            cfDate.p_strDateValue = strResult
                            If (cfDate.CheckDate = True) Then
                                strResult = cfDate.p_strSeirekiYMD
                            Else

                                ' ŽÀÝ“úˆÈŠO‚Ìê‡‚ÍAƒGƒ‰[‚Æ‚·‚éBi‹Æ‹¤‚Ì“®‚«‚É€‹’‚³‚¹‚éBj
                                '*—š—ð”Ô† 000014 2015/03/05 C³ŠJŽn
                                'cfErrorClass = New UFErrorClass
                                'cfErrorStruct = cfErrorClass.GetErrorStruct(URErrorClass.URE001053)
                                'Throw New Exception(cfErrorStruct.m_strErrorMessage)
                                cfErrorClass = New UFErrorClass(ABConstClass.THIS_BUSINESSID)
                                cfErrorStruct = cfErrorClass.GetErrorStruct(ABErrorClass.ABE003144)
                                Throw New Exception(String.Format("{0} ˆ¶–¼ŠÇ—î•ñ F Ží•ÊƒL[y{1}zAŽ¯•ÊƒL[y{2}z", _
                                                                  cfErrorStruct.m_strErrorMessage, _
                                                                  m_strHojinBangoRiyoKaishiYMD_Param(0), _
                                                                  m_strHojinBangoRiyoKaishiYMD_Param(1)))
                                '*—š—ð”Ô† 000014 2015/03/05 C³I—¹

                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return strResult

                    End Function

                #End Region
                    '*—š—ð”Ô† 000013 2015/01/05 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000015 2018/05/07 ’Ç‰ÁŠJŽn
                #Region "ŽŸŠú‚q‚…‚‚‚“@Z“oŠO”õl—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' ŽŸŠú‚q‚…‚‚‚“@Z“oŠO”õl—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>ŽŸŠú‚q‚…‚‚‚“@Z“oŠO”õl—L–³</returns>
                    ''' <remarks></remarks>
                    Public Function GetJutogaiBikoUmu_Param() As Boolean

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim blnResult As Boolean = False
                        Dim csDataSet As DataSet
                        Dim strParameter As String

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strJutogaiBikoUmu_Param(0), m_strJutogaiBikoUmu_Param(1))

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then

                                strParameter = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString

                                If (strParameter.Trim = "1") Then
                                    blnResult = True
                                Else
                                    blnResult = False
                                End If

                            Else
                                blnResult = False
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return blnResult

                    End Function

                #End Region
                    '*—š—ð”Ô† 000015 2018/05/07 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000016 2018/05/22 ’Ç‰ÁŠJŽn
                #Region "ŽŸŠú‚q‚…‚‚‚“@˜A—æŠg’£—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' ŽŸŠú‚q‚…‚‚‚“@˜A—æŠg’£—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>ŽŸŠú‚q‚…‚‚‚“@˜A—æŠg’£—L–³</returns>
                    ''' <remarks></remarks>
                    Public Function GetRenrakusakiKakuchoUmu_Param() As Boolean

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim blnResult As Boolean = False
                        Dim csDataSet As DataSet
                        Dim strParameter As String

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strRenrakusakiKakuchoUmu_Param(0), m_strRenrakusakiKakuchoUmu_Param(1))

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then

                                strParameter = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString

                                If (strParameter.Trim = "1") Then
                                    blnResult = True
                                Else
                                    blnResult = False
                                End If

                            Else
                                blnResult = False
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return blnResult

                    End Function

                #End Region
                    '*—š—ð”Ô† 000016 2018/05/22 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000017 2020/08/03 ’Ç‰ÁŠJŽn
                #Region "‘ã”[E‘—•tæ”õl—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' ‘ã”[E‘—•tæ”õl—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>‘ã”[E‘—•tæ”õl—L–³</returns>
                    ''' <remarks></remarks>
                    Public Function GetDainoSfskBikoUmu_Param() As Boolean

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim blnResult As Boolean = False
                        Dim csDataSet As DataSet
                        Dim strParameter As String

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strDainoSfskBikoUmu_Param(0), m_strDainoSfskBikoUmu_Param(1))

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then

                                strParameter = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString

                                If (strParameter.Trim = "1") Then
                                    blnResult = True
                                Else
                                    blnResult = False
                                End If

                            Else
                                blnResult = False
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return blnResult

                    End Function

                #End Region
                    '*—š—ð”Ô† 000017 2020/08/03 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000018 2020/08/21 ’Ç‰ÁŠJŽn
                #Region "Å–ÚƒR[ƒh•ÏŠ·ƒe[ƒuƒ‹@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' Å–ÚƒR[ƒh•ÏŠ·ƒe[ƒuƒ‹@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>Å–ÚƒR[ƒh•ÏŠ·ƒe[ƒuƒ‹</returns>
                    ''' <remarks></remarks>
                    Public Function GetZeikokuCDConvertTable_Param() As Hashtable

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim csResult As Hashtable
                        Dim csDataSet As DataSet
                        Dim strParameter As String
                        Dim a_strParameter() As String
                        Dim a_strValue() As String

                        Const SEPARATOR_SLASH As Char = "/"c
                        Const SEPARATOR_COMMA As Char = ","c

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' •ÔMƒIƒuƒWƒFƒNƒg‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            csResult = New Hashtable

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strZeimokuCDConvertTable_Param(0), m_strZeimokuCDConvertTable_Param(1))

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then

                                ' ƒpƒ‰ƒ[ƒ^[‚ðŽæ“¾
                                strParameter = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString

                                ' ƒXƒ‰ƒbƒVƒ…‚Å‹æØ‚é
                                a_strParameter = strParameter.Split(SEPARATOR_SLASH)

                                ' ‹Æ–±”•ªƒ‹[ƒv
                                For Each strValue As String In a_strParameter

                                    ' ƒJƒ“ƒ}‚Å‹æØ‚é
                                    a_strValue = strValue.Split(SEPARATOR_COMMA)

                                    ' €–Ú”•ªƒ‹[ƒv
                                    If (a_strValue.Count > 1) Then

                                        ' d•¡ƒ`ƒFƒbƒN‚ðs‚¢‚È‚ª‚çAƒnƒbƒVƒ…‚Ö’Ç‰Á‚·‚é
                                        If (csResult.ContainsKey(a_strValue(0)) = True) Then
                                            ' noop
                                        Else
                                            csResult.Add(a_strValue(0), a_strValue(1))
                                        End If

                                    Else
                                        ' noop
                                    End If

                                Next strValue

                            Else
                                ' noop
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")

                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return csResult

                    End Function

                #End Region

                #Region "‘ã”[E‘—•tæƒƒ“ƒeƒiƒ“ƒXŽg—p—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' ‘ã”[E‘—•tæƒƒ“ƒeƒiƒ“ƒXŽg—p—L–³@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>‘ã”[E‘—•tæƒƒ“ƒeƒiƒ“ƒXŽg—p—L–³</returns>
                    ''' <remarks></remarks>
                    Public Function GetDainoSfskMainteShiyoUmu_Param() As Boolean

                        Dim THIS_METHOD_NAME As String = Reflection.MethodBase.GetCurrentMethod.Name
                        Dim blnResult As Boolean
                        Dim csDataSet As DataSet
                        Dim strParameter As String

                        Try

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' •ÔMƒIƒuƒWƒFƒNƒg‚Ì‰Šú‰»
                            blnResult = False

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDataSet = GetKanriJohoHoshu(m_strDainoSfskMainteShiyoUmu_Param(0), m_strDainoSfskMainteShiyoUmu_Param(1))

                            ' Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count > 0) Then

                                ' ƒpƒ‰ƒ[ƒ^[‚ðŽæ“¾
                                strParameter = csDataSet.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER).ToString

                                ' Žæ“¾Œ‹‰Ê‚ð”»’è
                                If (strParameter.Trim = "1") Then
                                    blnResult = True
                                Else
                                    blnResult = False
                                End If

                            Else
                                ' noop
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch cfAppExp As UFAppException

                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + cfAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + cfAppExp.Message + "z")

                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch csExp As Exception

                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + csExp.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return blnResult

                    End Function

                #End Region
                    '*—š—ð”Ô† 000018 2020/08/21 ’Ç‰ÁI—¹

                    '*—š—ð”Ô† 000019 2020/11/10 ’Ç‰ÁŠJŽn
                #Region "“ÆŽ©ˆ—@—˜—p“Ío‹¤’Ê”[Å•Ô‹p•s—v‹Æ–±@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' “ÆŽ©ˆ—@—˜—p“Ío‹¤’Ê”[Å•Ô‹p•s—v‹Æ–±@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>“ÆŽ©ˆ—@—˜—p“Ío‹¤’Ê”[Å•Ô‹p•s—v‹Æ–±</returns>
                    ''' <remarks></remarks>
                    Public Function GetHenkyakuFuyoGyomuCD_Param() As String

                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetHenkyakuFuyoGyomuCD_Param"


                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strHenkyakuFuyoGyomuCD_Param(0), m_strHenkyakuFuyoGyomuCD_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = ""
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function

                #End Region
                    '*—š—ð”Ô† 000019 2020/11/10 ’Ç‰ÁI—¹

                #Region "•W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•ti¶”NŒŽ“új@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' •W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•ti¶”NŒŽ“új@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>•W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•ti¶”NŒŽ“új</returns>
                    ''' <remarks></remarks>
                    Public Function GetUmareYMDHenkanHizuke_Param() As String

                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetUmareYMDHenkanHizuke_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strUmareYMDHenkan_Param(0), m_strUmareYMDHenkan_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = String.Empty
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function

                #End Region

                #Region "•W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•tiÁœˆÙ“®“új@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' •W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•tiÁœˆÙ“®“új@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>•W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•tiÁœˆÙ“®“új</returns>
                    ''' <remarks></remarks>
                    Public Function GetShojoIdobiHenkanHizuke_Param() As String

                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetShojoIdobiHenkanHizuke_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strShojoIdobiHenkan_Param(0), m_strShojoIdobiHenkan_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = String.Empty
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function

                #End Region

                #Region "•W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•ti’¼‹ßˆÙ“®“új@ƒpƒ‰ƒ[ƒ^[Žæ“¾"

                    ''' <summary>
                    ''' •W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•ti’¼‹ßˆÙ“®“új@ƒpƒ‰ƒ[ƒ^[Žæ“¾
                    ''' </summary>
                    ''' <returns>•W€€‹’‘Î‰žˆ¶–¼GET@—ðã“ú•ÏŠ·“ú•ti’¼‹ßˆÙ“®“új</returns>
                    ''' <remarks></remarks>
                    Public Function GetCknIdobiHenkanHizuke_Param() As String

                        Dim csDS As DataSet
                        Dim strRet As String
                        Const THIS_METHOD_NAME As String = "GetCknIdobiHenkanHizuke_Param"

                        Try
                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' ŠÇ—î•ñ‚©‚çƒf[ƒ^‚ðŽæ“¾
                            csDS = GetKanriJohoHoshu(m_strCknIdobiHenkan_Param(0), m_strCknIdobiHenkan_Param(1))

                            'Žæ“¾ƒf[ƒ^‚Ìƒ`ƒFƒbƒN
                            If (csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count) = 0 Then
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡‚ÍA‹ó”’‚Æ‚·‚é
                                strRet = String.Empty
                            Else
                                'ƒŒƒR[ƒh‚ª‘¶Ý‚·‚éê‡‚ÍAŠÇ—î•ñ‚ðƒZƒbƒg‚·‚é
                                strRet = CStr(csDS.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER))
                            End If

                            ' ƒfƒoƒbƒOƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            Return strRet

                        Catch exAppException As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + exAppException.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + exAppException.Message + "z")
                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é
                            Throw

                        Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData,
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" +
                                                        "yƒGƒ‰[“à—e:" + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Function

                #End Region
                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}