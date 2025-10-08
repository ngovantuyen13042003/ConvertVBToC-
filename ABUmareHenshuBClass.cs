// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‚`‚aˆ¶–¼Q¶”NŒŽ“ú•ÒW
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/24@–F‘ò@¸
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/06/27 000001     •ÏŠ·Œ³‚Ì’l‚ªSteing.Empty‚Ìê‡ƒGƒ‰[‚·‚éƒoƒO‚ðC³
// * 2023/03/10 000002     yAB-0970-1zˆ¶–¼GETŽæ“¾€–Ú•W€‰»‘Î‰ži’‡¼j
// ************************************************************************************************
using System;

namespace Densan.Reams.AB.AB000BB
{

    public class ABUmareHenshuBClass
    {
        // ************************************************************************************************
        // *
        // * ¶”NŒŽ“ú•ÒW‚ÉŽg—p‚·‚éƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // *
        // ************************************************************************************************
        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private UFLogClass m_cfUFLogClass;                // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;          // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfUFConfigDataClass;  // ƒRƒ“ƒtƒBƒOƒf[ƒ^

        private string m_strDataKB;                       // ‹æ•ª(2Œ…)
        private string m_strJuminSHU;                     // Ží•Ê(2Œ…)
        private string m_strUmareYMD;                     // ¶”NŒŽ“ú
        private string m_strUmareWMD;                     // ¶˜a—ï”NŒŽ“ú
        private string m_strHyojiUmareYMD;                // •\Ž¦—p¶”NŒŽ“ú
        private string m_strShomeiUmareYMD;               // Ø–¾—p¶”NŒŽ“ú
        private UFDateClass m_cfDateClass;                // “ú•t•ÒW 

        // @ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABUmareHenshuBClass";             // ƒNƒ‰ƒX–¼

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigDataClass As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfUFControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                cfUFConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABUmareHenshuBClass(UFControlData cfUFControlData, UFConfigDataClass cfUFConfigDataClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfUFControlData;
            m_cfUFConfigDataClass = cfUFConfigDataClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfUFConfigDataClass, cfUFControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”‰Šú‰»
            m_strDataKB = string.Empty;
            m_strJuminSHU = string.Empty;
            m_strUmareYMD = string.Empty;
            m_strUmareWMD = string.Empty;
            m_strHyojiUmareYMD = string.Empty;
            m_strShomeiUmareYMD = string.Empty;
            // “ú•tˆ—ƒNƒ‰ƒXƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfDateClass = new UFDateClass(m_cfUFConfigDataClass);

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ¶”NŒŽ“ú•ÒW
        // * 
        // * \•¶           Public Sub HenshuUmare()
        // * 
        // * ‹@”\@@       ¶”NŒŽ“úE¶˜a—ï”NŒŽ“ú‚æ‚è•\Ž¦—p¶”NŒŽ“úEØ–¾—p”NŒŽ“ú‚ð•ÒW‚·‚é
        // * 
        // * ˆø”           ‚È‚µ
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void HenshuUmare()
        {
            string strNengo = string.Empty;
            string strUmareYmd = string.Empty;

            do
            {
                try
                {


                    // ˜a—ï‚P•¶Žš–Ú‚ðŽæ“¾
                    strNengo = m_strUmareWMD.RSubstring(0, 1);
                    if (strNengo == "0" | strNengo == "8" | strNengo == "9")
                    {
                        if (string.IsNullOrEmpty(m_strUmareYMD.Trim()))
                        {
                            switch (strNengo ?? "")
                            {
                                case "0":
                                    {
                                        strUmareYmd = "20" + m_strUmareWMD.RSubstring(1);
                                        break;
                                    }
                                case "8":
                                    {
                                        strUmareYmd = "18" + m_strUmareWMD.RSubstring(1);
                                        break;
                                    }
                                case "9":
                                    {
                                        strUmareYmd = "19" + m_strUmareWMD.RSubstring(1);
                                        break;
                                    }

                                default:
                                    {
                                        strUmareYmd = "20" + m_strUmareWMD.RSubstring(1);
                                        break;
                                    }
                            }
                            m_cfDateClass.p_strDateValue = strUmareYmd;
                        }
                        else
                        {
                            m_cfDateClass.p_strDateValue = m_strUmareYMD;
                        }

                        if (!m_cfDateClass.CheckDate())
                        {
                            m_strHyojiUmareYMD = string.Empty;
                            m_strShomeiUmareYMD = string.Empty;
                            break;
                        }

                        // ¶”NŒŽ“ú‚æ‚è•\Ž¦—p“ú•t‚Ì•ÒW‚ðs‚¤
                        m_cfDateClass.p_enDateSeparator = UFDateSeparator.Period;
                        m_cfDateClass.p_blnWideType = false;
                        m_cfDateClass.p_enDateFillType = UFDateFillType.Zero;
                        m_strHyojiUmareYMD = m_cfDateClass.p_strSeirekiYMD;

                        // ¶”NŒŽ“ú‚æ‚èØ–¾—p“ú•t‚Ì•ÒW‚ðs‚¤
                        m_cfDateClass.p_enDateSeparator = UFDateSeparator.Japanese;
                        m_cfDateClass.p_blnWideType = true;
                        m_cfDateClass.p_enEraType = UFEraType.Kanji;
                        m_cfDateClass.p_enDateFillType = UFDateFillType.Blank;
                        m_strShomeiUmareYMD = m_cfDateClass.p_strSeirekiYMD;
                    }
                    else
                    {
                        // ¶˜a—ï”NŒŽ“ú‚æ‚è•\Ž¦—p“ú•t‚Ì•ÒW‚ðs‚¤
                        m_cfDateClass.p_strDateValue = m_strUmareWMD;

                        if (!m_cfDateClass.CheckDate())
                        {
                            m_strHyojiUmareYMD = string.Empty;
                            m_strShomeiUmareYMD = string.Empty;
                            break;
                        }

                        m_cfDateClass.p_blnWideType = false;
                        m_cfDateClass.p_enEraType = UFEraType.KanjiRyaku;
                        m_cfDateClass.p_enDateFillType = UFDateFillType.Zero;
                        m_cfDateClass.p_enDateSeparator = UFDateSeparator.Period;
                        m_strHyojiUmareYMD = m_cfDateClass.p_strWarekiYMD;

                        // ¶˜a—ï”NŒŽ“ú‚æ‚èØ–¾—p“ú•t‚Ì•ÒW‚ðs‚¤
                        m_cfDateClass.p_enDateSeparator = UFDateSeparator.Japanese;
                        m_cfDateClass.p_blnWideType = true;
                        m_cfDateClass.p_enEraType = UFEraType.Kanji;
                        m_cfDateClass.p_enDateFillType = UFDateFillType.Blank;
                        m_strShomeiUmareYMD = m_cfDateClass.p_strWarekiYMD;
                    }
                }
                catch (Exception objExp)
                {
                    // ƒGƒ‰[ƒƒOo—Í
                    m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + default
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
           "zyƒƒ\ƒbƒh–¼:HenshuUmarezyƒGƒ‰[“
            */
           );
                    ;
                    // m_strUmareYMD = Value
                    // * —š—ð”Ô† 000001 2003/06/27 C³I—¹
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7403


                                        Input:
                                        " + objExp.Message + "z")
                                                    'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                                                    Throw objExp
                                                End Try

                                            End Sub

                                            '************************************************************************************************
                                            '* Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
                                            '************************************************************************************************
                                            Public WriteOnly Property p_strDataKB() As String
                                                Set(ByVal Value As String)
                                                    m_strDataKB = Value
                                                End Set
                                            End Property
                                            Public WriteOnly Property p_strJuminSHU() As String
                                                Set(ByVal Value As String)
                                                    m_strJuminSHU = Value
                                                End Set
                                            End Property
                                            Public WriteOnly Property p_strUmareYMD() As String
                                                Set(ByVal Value As String)
                                                    '* —š—ð”Ô† 000001 2003/06/27 C³ŠJŽn

                                         */
                    m_strUmareYMD = Value.RPadRight(8);
                    ;
#error Cannot convert EndBlockStatementSyntax - see comment for details
                    /* Cannot convert EndBlockStatementSyntax, CONVERSION ERROR: Conversion for EndSetStatement not implemented, please report this issue in 'End Set' at character 8363


                    Input:
                                '* —š—ð”Ô† 000001 2003/06/27 C³I—¹
                            End Set

                     */
                    ;
#error Cannot convert EndBlockStatementSyntax - see comment for details
                    /* Cannot convert EndBlockStatementSyntax, CONVERSION ERROR: Conversion for EndPropertyStatement not implemented, please report this issue in 'End Property' at character 8375


                    Input:
                        End Property

                     */
                }
            }
            while (false);
        }

        public string p_strUmareWMD
        {
            set
            {
                // * —š—ð”Ô† 000001 2003/06/27 C³ŠJŽn
                // m_strUmareWMD = Value
                m_strUmareWMD = value.RPadRight(7);
                // * —š—ð”Ô† 000001 2003/06/27 C³I—¹
            }
        }
        public string p_strHyojiUmareYMD
        {
            get
            {
                return m_strHyojiUmareYMD;
            }
        }
        public string p_strShomeiUmareYMD
        {
            get
            {
                return m_strShomeiUmareYMD;
            }
        }

    }
}