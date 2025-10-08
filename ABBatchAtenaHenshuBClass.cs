// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aƒoƒbƒ`—pˆ¶–¼•ÒWƒNƒ‰ƒX(ABBatchAtenaHenshuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/08/22@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/08/27 000001     ‘¬“x‰ü‘PFi‹{‘òj
// * 2005/01/25 000002     ‘¬“x‰ü‘P‚QFi‹{‘òj
// * 
// ************************************************************************************************
using System.Security;

namespace Densan.Reams.AB.AB000BB
{

    public class ABBatchAtenaHenshuBClass : ABAtenaHenshuBClass        // ˆ¶–¼•ÒW‚aƒNƒ‰ƒX‚ðŒp³
    {

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        protected new const string THIS_CLASS_NAME = "ABBatchAtenaHenshuBClass";      // ƒNƒ‰ƒX–¼

        // * —š—ð”Ô† 000001 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        private URKANRIJOHOBClass m_cURKanriJohoB;              // ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
                                                                // * —š—ð”Ô† 000001 2004/08/27 ’Ç‰ÁI—¹

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass,
        // *                               ByVal cfUFRdbClass as UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABBatchAtenaHenshuBClass(UFControlData cfUFControlData, UFConfigDataClass cfUFConfigDataClass, UFRdbClass cfUFRdbClass) : base(cfUFControlData, cfUFConfigDataClass, cfUFRdbClass)
        {
        }
        // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass,
        // *                               ByVal cfUFRdbClass as UFRdbClass)
        // * @@                          ByVal blnSelectAll as boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABBatchAtenaHenshuBClass(UFControlData cfUFControlData, UFConfigDataClass cfUFConfigDataClass, UFRdbClass cfUFRdbClass, ABEnumDefine.AtenaGetKB blnSelectAll) : base(cfUFControlData, cfUFConfigDataClass, cfUFRdbClass, blnSelectAll)
        {
        }
        // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‘—•tæZŠs­‹æ•ÒW‹æ•ªŽæ“¾
        // * 
        // * \•¶           Private Function GetSofuJushoGyoseikuType() As SofuJushoGyoseikuType
        // * 
        // * ‹@”\@@    @@‘—•tæZŠs­‹æ•ÒW‹æ•ª‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         SofuJushoGyoseikuType
        // ************************************************************************************************
        [SecuritySafeCritical]
        protected override SofuJushoGyoseikuType GetSofuJushoGyoseikuType()
        {
            const string THIS_METHOD_NAME = "GetSofuJushoGyoseikuType";
            // * —š—ð”Ô† 000001 2004/08/27 íœŠJŽni‹{‘òj
            // Dim cURKanriJohoB As URKANRIJOHOBClass              'ŠÇ—î•ñŽæ“¾ƒNƒ‰ƒX
            // * —š—ð”Ô† 000001 2004/08/27 íœI—¹
            SofuJushoGyoseikuType cSofuJushoGyoseikuType;

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŠÇ—î•ñŽæ“¾‚a‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // * —š—ð”Ô† 000001 2004/08/27 XVŠJŽni‹{‘òj
                // cURKanriJohoB = New URKANRIJOHOBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass)
                if (m_cURKanriJohoB is null)
                {
                    m_cURKanriJohoB = new URKANRIJOHOBClass(m_cfUFControlData, m_cfUFConfigDataClass, m_cfUFRdbClass);
                }
                // * —š—ð”Ô† 000001 2004/08/27 XVI—¹

                // * —š—ð”Ô† 000002 2005/01/25 XVŠJŽni‹{‘òj
                // cSofuJushoGyoseikuType = m_cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param
                if (m_bSofuJushoGyoseikuTypeFlg == false)
                {
                    m_cSofuJushoGyoseikuType = m_cURKanriJohoB.GetSofuJushoGyoseiku_SofuJushoGyoseiku_Param;
                    m_bSofuJushoGyoseikuTypeFlg = true;
                }
                cSofuJushoGyoseikuType = m_cSofuJushoGyoseikuType;
                // * —š—ð”Ô† 000002 2005/01/25 XVI—¹i‹{‘òj

                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }

            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfUFLogClass.WarningWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6788


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6884


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp
                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfUFLogClass.ErrorWrite(m_cfUFControlData,
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7155


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7238


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return cSofuJushoGyoseikuType;

        }

    }
}