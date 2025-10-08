// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        –@l–¼Ì(ABHojinMeishoBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2002/12/18@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2003/09/11 000001     ƒ`ƒ…[ƒjƒ“ƒO
// * 2015/04/23 000002     Žx“X–¼‚Ì˜AŒ‹Žž‚É’l—L–³”»’è‚ð’Ç‰ÁiÎ‡j
// ************************************************************************************************
using System;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABHojinMeishoBClass
    {
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABHojinMeishoBClass";

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private string m_strKeitaiFuyoKB;             // ‹æ•ªi1Œ…j
        private string m_strKeitaiSeiRyakuKB;         // ‹æ•ªi1Œ…j
        private string m_strKanjiHjnKeitai;           // Œ`‘Ôi‘SŠp@Max‚P‚O•¶Žšj
        private string m_strKanjiMeisho1;             // –¼Ìi‘SŠp@Max‚S‚O•¶Žšj
        private string m_strKanjiMeisho2;             // –¼Ìi‘SŠp@Max‚S‚O•¶Žšj

        // Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        public string p_strKeitaiFuyoKB
        {
            set
            {
                m_strKeitaiFuyoKB = value;
            }
        }
        public string p_strKeitaiSeiRyakuKB
        {
            set
            {
                m_strKeitaiSeiRyakuKB = value;
            }
        }
        public string p_strKanjiHjnKeitai
        {
            set
            {
                m_strKanjiHjnKeitai = value;
            }
        }
        public string p_strKanjiMeisho1
        {
            set
            {
                m_strKanjiMeisho1 = value;
            }
        }
        public string p_strKanjiMeisho2
        {
            set
            {
                m_strKanjiMeisho2 = value;
            }
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶            Public Sub New(ByVal cfUFControlData As UFControlData, 
        // *                               ByVal cfUFConfigData As UFConfigDataClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”            cfUFControlData As UFControlData         : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // *                 cfUFConfigData As UFConfigDataClass      : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg 
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABHojinMeishoBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;
            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);
            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strKeitaiFuyoKB = string.Empty;
            m_strKeitaiSeiRyakuKB = string.Empty;
            m_strKanjiHjnKeitai = string.Empty;
            m_strKanjiMeisho1 = string.Empty;
            m_strKanjiMeisho2 = string.Empty;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      –@l–¼Ì•ÒW
        // * 
        // * \•¶            Public Function GetHojinMeisho() As String
        // * 
        // * ‹@”\@@        –@lŒ`‘Ô•t—^‹æ•ªA–@lŒ`‘Ô³Ž®—ªÌ‹æ•ªA–@lŒ`‘ÔA–¼Ì‚PA–¼Ì‚Q‚æ‚è–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          •ÒW–¼ÌiStringj
        // ************************************************************************************************
        public string GetHojinMeisho()
        {
            // *—š—ð”Ô† 000001 2003/09/11 C³ŠJŽn
            // Dim strKanjiMeisho As String = String.Empty

            // Try
            // 'ƒfƒoƒbƒOŠJŽnƒƒOo—Í
            // m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetHojinMeisho")

            // '–@l‚Ì–¼Ì‚Ì•ÒW
            // Select Case m_strKeitaiFuyoKB
            // Case "1"
            // Select Case m_strKeitaiSeiRyakuKB
            // Case "1"
            // strKanjiMeisho = m_strKanjiHjnKeitai + m_strKanjiMeisho1 + "@" + m_strKanjiMeisho2
            // Case Else
            // strKanjiMeisho = m_strKanjiHjnKeitai + "@" + m_strKanjiMeisho1 + "@" + m_strKanjiMeisho2
            // End Select
            // Case "2"
            // Select Case m_strKeitaiSeiRyakuKB
            // Case "1"
            // strKanjiMeisho = m_strKanjiMeisho1 + m_strKanjiHjnKeitai + m_strKanjiMeisho2
            // Case Else
            // strKanjiMeisho = m_strKanjiMeisho1 + "@" + m_strKanjiHjnKeitai + "@" + m_strKanjiMeisho2
            // End Select
            // Case Else
            // strKanjiMeisho = m_strKanjiMeisho1 + "@" + m_strKanjiMeisho2
            // End Select

            // 'ƒfƒoƒbƒOI—¹ƒƒOo—Í
            // m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, "GetHojinMeisho")
            // Catch objExp As Exception
            // 'ƒGƒ‰[ƒƒOo—Í
            // m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "zyƒƒ\ƒbƒh–¼:GetKjnhjnzyƒGƒ‰[“à—e:" + objExp.Message + "z")
            // 'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
            // Throw objExp
            // End Try

            // Return strKanjiMeisho

            StringBuilder strKanjiMeisho;
            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);

                strKanjiMeisho = new StringBuilder();
                // –@l‚Ì–¼Ì‚Ì•ÒW
                switch (m_strKeitaiFuyoKB ?? "")
                {
                    case "1":
                        {
                            switch (m_strKeitaiSeiRyakuKB ?? "")
                            {
                                case "1":
                                    {
                                        // *—š—ð”Ô† 000002 2015/04/23 C³ŠJŽn
                                        // strKanjiMeisho.Append(m_strKanjiHjnKeitai).Append(m_strKanjiMeisho1).Append("@").Append(m_strKanjiMeisho2)
                                        strKanjiMeisho.Append(m_strKanjiHjnKeitai).Append(m_strKanjiMeisho1);
                                        // *—š—ð”Ô† 000002 2015/04/23 C³I—¹
                                        strKanjiMeisho = AppendShitenmei(strKanjiMeisho, m_strKanjiMeisho2);
                                        break;
                                    }

                                default:
                                    {
                                        // *—š—ð”Ô† 000002 2015/04/23 C³ŠJŽn
                                        // strKanjiMeisho.Append(m_strKanjiHjnKeitai).Append("@").Append(m_strKanjiMeisho1).Append("@").Append(m_strKanjiMeisho2)
                                        strKanjiMeisho.Append(m_strKanjiHjnKeitai).Append("@").Append(m_strKanjiMeisho1);
                                        strKanjiMeisho = AppendShitenmei(strKanjiMeisho, m_strKanjiMeisho2);
                                        break;
                                    }
                                    // *—š—ð”Ô† 000002 2015/04/23 C³I—¹
                            }

                            break;
                        }
                    case "2":
                        {
                            switch (m_strKeitaiSeiRyakuKB ?? "")
                            {
                                case "1":
                                    {
                                        strKanjiMeisho.Append(m_strKanjiMeisho1).Append(m_strKanjiHjnKeitai).Append(m_strKanjiMeisho2);
                                        break;
                                    }

                                default:
                                    {
                                        // *—š—ð”Ô† 000002 2015/04/23 C³ŠJŽn
                                        // strKanjiMeisho.Append(m_strKanjiMeisho1).Append("@").Append(m_strKanjiHjnKeitai).Append("@").Append(m_strKanjiMeisho2)
                                        strKanjiMeisho.Append(m_strKanjiMeisho1).Append("@").Append(m_strKanjiHjnKeitai);
                                        strKanjiMeisho = AppendShitenmei(strKanjiMeisho, m_strKanjiMeisho2);
                                        break;
                                    }
                                    // *—š—ð”Ô† 000002 2015/04/23 C³I—¹
                            }

                            break;
                        }

                    default:
                        {
                            // *—š—ð”Ô† 000002 2015/04/23 C³ŠJŽn
                            // strKanjiMeisho.Append(m_strKanjiMeisho1).Append("@").Append(m_strKanjiMeisho2)
                            strKanjiMeisho.Append(m_strKanjiMeisho1);
                            strKanjiMeisho = AppendShitenmei(strKanjiMeisho, m_strKanjiMeisho2);
                            break;
                        }
                        // *—š—ð”Ô† 000002 2015/04/23 C³I—¹
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            catch (Exception objExp)
            {
                // ƒGƒ‰[ƒƒOo—Í
                m_cfUFLogClass.ErrorWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + GetType().Name + "z" + @"yƒƒ\ƒbƒh–¼:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9336


                Input:
                " + objExp.Message + "z")
                            Throw objExp
                        End Try


                        Return strKanjiMeisho.ToString
                        '*—š—ð”Ô† 000001 2003/09/11 C³I—¹

                 */
            }

            return default;

        }

        // *—š—ð”Ô† 000002 2015/04/23 ’Ç‰ÁŠJŽn
        /// <summary>
    /// –@l–¼i‚¨‚æ‚Ñ–@lŒ`‘Ôj‚ÉŽx“X–¼‚ð˜AŒ‹‚µ‚Ä•ÔM‚µ‚Ü‚·B
    /// </summary>
    /// <param name="csHojinmei">–@l–¼i‚¨‚æ‚Ñ–@lŒ`‘Ôj</param>
    /// <param name="strShitenmei">Žx“X–¼</param>
    /// <returns></returns>
    /// <remarks>’l—L–³”»’èA‚¨‚æ‚ÑÝ’è’l‚Ì‘OŒã‹ó”’‚Íœ‹Ž‚µ‚È‚¢B</remarks>
        private StringBuilder AppendShitenmei(StringBuilder csHojinmei, string strShitenmei)

        {

            try
            {


                // Žx“X–¼‚ª‘¶Ý‚·‚éê‡‚ÉA‘SŠp‹ó”’{Žx“X–¼‚ð˜AŒ‹‚·‚éB
                if (strShitenmei.RLength > 0)
                {
                    csHojinmei.Append("@");
                    csHojinmei.Append(strShitenmei);
                }
                else
                {
                    // noop

                }
            }

            catch (Exception csExp)
            {
                throw;
            }

            return csHojinmei;

        }
        // *—š—ð”Ô† 000002 2015/04/23 ’Ç‰ÁI—¹

    }
}