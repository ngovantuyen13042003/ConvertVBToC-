// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aƒoƒbƒ`—pˆ¶–¼Žæ“¾(ABBatchAtenaGetClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/08/21@‘ê‘ò@‹Ô–ç
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

    public class ABBatchAtenaGetBClass : ABAtenaGetBClass           // ˆ¶–¼Žæ“¾‚aƒNƒ‰ƒX‚ðŒp³
    {

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        protected new ABBatchAtenaHenshuBClass m_cABAtenaHenshuB;             // ˆ¶–¼•ÒWƒNƒ‰ƒX(ƒoƒbƒ`—p)

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        protected new const string THIS_CLASS_NAME = "ABBatchAtenaGetBClass"; // ƒNƒ‰ƒX–¼

        // * —š—ð”Ô† 000001 2004/08/27 ’Ç‰ÁŠJŽni‹{‘òj
        private URAtenaKanriJohoBClass m_cfURAtenaKanriJoho;    // ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX
                                                                // * —š—ð”Ô† 000001 2004/08/27 ’Ç‰ÁI—¹


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABBatchAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass) : base(cfControlData, cfConfigDataClass)
        {
            m_blnBatch = true;
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            if (m_cABAtenaBRef is not null)
            {
                m_cABAtenaBRef.m_blnBatch = true;
            }
            if (m_cABAtenaRirekiBRef is not null)
            {
                m_cABAtenaRirekiBRef.m_blnBatch = true;
            }
            if (m_cABDainoBRef is not null)
            {
                m_cABDainoBRef.m_blnBatch = true;
            }
            if (m_cABSfskBRef is not null)
            {
                m_cABSfskBRef.m_blnBatch = true;
            }
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        }
        // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * @@                          ByVal blnSelectAll as boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABBatchAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, bool blnSelectAll) : base(cfControlData, cfConfigDataClass, blnSelectAll)
        {
            m_blnBatch = true;
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            if (m_cABAtenaBRef is not null)
            {
                m_cABAtenaBRef.m_blnBatch = true;
            }
            if (m_cABAtenaRirekiBRef is not null)
            {
                m_cABAtenaRirekiBRef.m_blnBatch = true;
            }
            if (m_cABDainoBRef is not null)
            {
                m_cABDainoBRef.m_blnBatch = true;
            }
            if (m_cABSfskBRef is not null)
            {
                m_cABSfskBRef.m_blnBatch = true;
            }
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        }
        // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABBatchAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass) : base(cfControlData, cfConfigDataClass, cfRdbClass)
        {
            m_blnBatch = true;
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            if (m_cABAtenaBRef is not null)
            {
                m_cABAtenaBRef.m_blnBatch = true;
            }
            if (m_cABAtenaRirekiBRef is not null)
            {
                m_cABAtenaRirekiBRef.m_blnBatch = true;
            }
            if (m_cABDainoBRef is not null)
            {
                m_cABDainoBRef.m_blnBatch = true;
            }
            if (m_cABSfskBRef is not null)
            {
                m_cABSfskBRef.m_blnBatch = true;
            }
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        }

        // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass)
        // * @@                          ByVal blnSelectAll as boolean)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * @@           ByVal blnSelectAll As Boolean           : True‚Ìê‡‘S€–ÚAFalse‚Ìê‡ŠÈˆÕ€–Ú‚Ì‚ÝŽæ“¾
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABBatchAtenaGetBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass, bool blnSelectAll) : base(cfControlData, cfConfigDataClass, cfRdbClass, blnSelectAll)
        {
            m_blnBatch = true;
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
            if (m_cABAtenaBRef is not null)
            {
                m_cABAtenaBRef.m_blnBatch = true;
            }
            if (m_cABAtenaRirekiBRef is not null)
            {
                m_cABAtenaRirekiBRef.m_blnBatch = true;
            }
            if (m_cABDainoBRef is not null)
            {
                m_cABDainoBRef.m_blnBatch = true;
            }
            if (m_cABSfskBRef is not null)
            {
                m_cABSfskBRef.m_blnBatch = true;
            }
            // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁŠJŽni‹{‘òj
        }
        // * —š—ð”Ô† 000002 2005/01/25 ’Ç‰ÁI—¹i‹{‘òj

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŠÇ—î•ñŽæ“¾i“à•”ˆ—j
        // * 
        // * \•¶           Private Function GetKanriJoho()
        // * 
        // * ‹@”\@@    @@ŠÇ—î•ñ‚ðŽæ“¾‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        [SecuritySafeCritical]
        protected override void GetKanriJoho()
        {
            const string THIS_METHOD_NAME = "GetKanriJoho";
            // * —š—ð”Ô† 000001 2004/08/27 íœŠJŽni‹{‘òj
            // Dim cfURAtenaKanriJoho As URAtenaKanriJohoBClass    'ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX
            // * —š—ð”Ô† 000001 2004/08/27 íœI—¹

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                if (m_blnKanriJoho)
                {
                    return;
                }

                // ŠÇ—î•ñƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                // * —š—ð”Ô† 000001 2004/08/27 XVŠJŽni‹{‘òj
                // cfURAtenaKanriJoho = New URAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass)
                if (m_cfURAtenaKanriJoho is null)
                {
                    m_cfURAtenaKanriJoho = new URAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                }
                // * —š—ð”Ô† 000001 2004/08/27 XVI—¹

                m_intHyojiketaJuminCD = m_cfURAtenaKanriJoho.p_intHyojiketaJuminCD;                // Z–¯ƒR[ƒh•\Ž¦Œ…”
                m_intHyojiketaStaiCD = m_cfURAtenaKanriJoho.p_intHyojiketaSetaiCD;                 // ¢‘ÑƒR[ƒh•\Ž¦Œ…”
                m_intHyojiketaJushoCD = m_cfURAtenaKanriJoho.p_intHyojiketaJushoCD;                // ZŠƒR[ƒh•\Ž¦Œ…”iŠÇ“à‚Ì‚Ýj
                m_intHyojiketaGyoseikuCD = m_cfURAtenaKanriJoho.p_intHyojiketaGyoseikuCD;          // s­‹æƒR[ƒh•\Ž¦Œ…”
                m_intHyojiketaChikuCD1 = m_cfURAtenaKanriJoho.p_intHyojiketaChikuCD1;              // ’n‹æƒR[ƒh‚P•\Ž¦Œ…”
                m_intHyojiketaChikuCD2 = m_cfURAtenaKanriJoho.p_intHyojiketaChikuCD2;              // ’n‹æƒR[ƒh‚Q•\Ž¦Œ…”
                m_intHyojiketaChikuCD3 = m_cfURAtenaKanriJoho.p_intHyojiketaChikuCD3;              // ’n‹æƒR[ƒh‚R•\Ž¦Œ…”
                m_strChikuCD1HyojiMeisho = m_cfURAtenaKanriJoho.p_strChikuCD1HyojiMeisho;          // ’n‹æƒR[ƒh‚P•\Ž¦–¼Ì
                m_strChikuCD2HyojiMeisho = m_cfURAtenaKanriJoho.p_strChikuCD2HyojiMeisho;          // ’n‹æƒR[ƒh‚Q•\Ž¦–¼Ì
                m_strChikuCD3HyojiMeisho = m_cfURAtenaKanriJoho.p_strChikuCD3HyojiMeisho;          // ’n‹æƒR[ƒh‚R•\Ž¦–¼Ì
                m_strRenrakusaki1HyojiMeisho = m_cfURAtenaKanriJoho.p_strRenrakusaki1HyojiMeisho;  // ˜A—æ‚P•\Ž¦–¼Ì
                m_strRenrakusaki2HyojiMeisho = m_cfURAtenaKanriJoho.p_strRenrakusaki2HyojiMeisho;  // ˜A—æ‚Q•\Ž¦–¼Ì

                // ŠÇ—î•ñŽæ“¾Ï‚Ýƒtƒ‰ƒOÝ’è
                m_blnKanriJoho = true;

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12116


                Input:
                " + objAppExp.p_strErrorCode + "z" +
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12212


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12480


                Input:
                " + THIS_CLASS_NAME + "z" +
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 12563


                                Input:
                                " + THIS_METHOD_NAME + "z" +
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;

            }

        }

    }
}