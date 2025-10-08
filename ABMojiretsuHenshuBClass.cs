// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         •¶Žš—ñ•ÒW‚aƒNƒ‰ƒX(ABMojiretsuHenshuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2008/02/13  ”ä‰Ã@Œv¬
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************

namespace Densan.Reams.AB.AB000BB
{

    public class ABMojiretsuHenshuBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFControlData m_cfControlData;                        // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;                // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                              // ‚q‚c‚aƒNƒ‰ƒX
        private UFLogClass m_cfLogClass;                              // ƒƒOo—ÍƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                          // ƒGƒ‰[ˆ—ƒNƒ‰ƒX

        private ABAtenaKanriJohoBClass m_cABAtenaKanriJohoB;          // ŠÇ—î•ñ‚aƒNƒ‰ƒX
        private string m_strShimeiKakkoKB_param;                      // Ž–¼Š‡ŒÊ§Œä‹æ•ªƒpƒ‰ƒ[ƒ^
        private ABMojiretsuHenshuBClass m_cABMojiRetsuHenshuB;        // •¶Žš—ñ•ÒW‚aƒNƒ‰ƒX 


        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABMojiretsuHenshuBClass";
        private const string THIS_BUSINESSID = "AB";          // ‹Æ–±ƒR[ƒh

        private const string HIDARI_KAKKO = "i";
        private const string MIGI_KAKKO = "j";
        private const string STR_10 = "10";
        private const string STR_20 = "20";

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
        public ABMojiretsuHenshuBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass)
        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = new UFRdbClass(m_cfControlData.m_strBusinessId);

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // ŠÇ—î•ñŽæ“¾‚ðs‚¤
            if (m_strShimeiKakkoKB_param is null)
            {
                // ƒƒ“ƒo‚É–³‚¢ê‡‚Ì‚ÝƒCƒ“ƒXƒ^ƒ“ƒX‰»‚ðs‚¤
                if (m_cABAtenaKanriJohoB is null)
                {
                    m_cABAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);
                }
                else
                {
                }
                // ŠÇ—î•ñ‚æ‚èŽæ“¾
                m_strShimeiKakkoKB_param = m_cABAtenaKanriJohoB.GetShimeiKakkoKB_Param();
            }
            else
            {
            }

        }
        #endregion

        #region ƒƒ\ƒbƒh
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Ž–¼ŠÈ—ª•¶Žš•ÒW
        // * 
        // * \•¶           Public Overloads Function EditKanryakuMeisho(ByVal strMeisho As String) As String
        // * 
        // * ‹@”\           Ž–¼–¼Ì‚©‚çŠ‡ŒÊ‚Ìíœˆ—‚ðs‚¤s
        // * 
        // * ˆø”           strMeisho  •¶Žš—ñ
        // *
        // * –ß‚è’l         String     •ÒW‚µ‚½•¶Žš—ñ
        // *
        // **********************************************************************************************************************
        public string EditKanryakuMeisho(string strMeisho)
        {

            return EditKanryakuMeisho(STR_10, STR_20, strMeisho);
        }

        #region EditKanryakuMeisho:Ž–¼ŠÈ—ª•¶Žš•ÒW
        // **********************************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Ž–¼ŠÈ—ª•¶Žš•ÒW
        // * 
        // * \•¶           Public Overloads Function EditKanryakuMeisho(ByVal strDataKB As String, _
        // *                                                             ByVal strDataShu As String, _
        // *                                                             ByVal strMeisho As String) As String
        // * 
        // * ‹@”\           Ž–¼–¼Ì‚©‚çŠ‡ŒÊ‚Ìíœˆ—‚ðs‚¤
        // * 
        // * ˆø”           strDataKB     ƒf[ƒ^‹æ•ª
        // *                strDataShu    ƒf[ƒ^Ží•Ê               
        // *                strMeisho     •¶Žš—ñ
        // *
        // * –ß‚è’l         String        •ÒW‚µ‚½•¶Žš—ñ
        // *
        // **********************************************************************************************************************
        public string EditKanryakuMeisho(string strDataKB, string strDataShu, string strMeisho)

        {
            string THIS_METHOD_NAME = "EditKanryakuMeisho";
            int intIndexFrom;
            int intIndexTo;
            string strWkMeisho;
            string strRet = string.Empty;

            do
            {
                try
                {
                    // ƒ[ƒN‚É–¼Ì‚ðƒZƒbƒg
                    strWkMeisho = strMeisho;

                    // ŠÇ—î•ñFŽ–¼Š‡ŒÊ•ÒW§Œä[10,15]‚ª"1"‚Ìê‡AŠ‡ŒÊ‚ðŽæ‚èœ‚­
                    if (m_strShimeiKakkoKB_param == "1")
                    {
                    }
                    else
                    {
                        // •ÒW‚Í‚µ‚È‚¢
                        strRet = strWkMeisho;
                        break;
                    }

                    // ƒf[ƒ^‹æ•ª‚ªŒÂl(1%) ‚©‚Â ƒf[ƒ^Ží•Ê‚ªŠO‘l(2%)‚Ìê‡AŠ‡ŒÊ‚ðŽæ‚èœ‚­
                    if (strDataKB.RSubstring(0, 1) == "1" && strDataShu.RSubstring(0, 1) == "2")
                    {
                    }
                    else
                    {
                        // •ÒW‚Í‚µ‚È‚¢
                        strRet = strWkMeisho;
                        break;
                    }

                    // ‹ó”’‚Ü‚½‚ÍA“ª‚P•¶Žš‚ª”Žš‚à‚µ‚­‚ÍƒAƒ‹ƒtƒ@ƒxƒbƒg‚Ìê‡‚ÍAs‚í‚È‚¢
                    if (!string.IsNullOrEmpty(strWkMeisho.TrimEnd()))
                    {
                        if (!UFStringClass.CheckAlphabetNumber(UFStringClass.ConvertWideToNarrow(strWkMeisho.RSubstring(0, 1))))
                        {
                            // ¶Š‡ŒÊ‚ð‘{‚·
                            intIndexFrom = strWkMeisho.RIndexOf(HIDARI_KAKKO);

                            while (intIndexFrom >= 0)
                            {

                                // ‰EŠ‡ŒÊ‚ð‘{‚·
                                intIndexTo = strWkMeisho.RSubstring(intIndexFrom + 1).RIndexOf(MIGI_KAKKO);

                                if (intIndexTo >= 0)
                                {
                                    // Š‡ŒÊ‚ðíœ‚·‚é
                                    strRet = strRet + strWkMeisho.RSubstring(0, intIndexFrom);                // ¶Š‡ŒÊ‚Ì’¼‘O‚Ü‚Åo—Í‘ÎÛ

                                    // ƒ[ƒN•¶Žš—ñ‚æ‚èŠ‡ŒÊœ‹Ž•¶Žš—ñ‚ª’·‚¢ê‡‚Í‹ó”’‚ðƒZƒbƒg
                                    if (strWkMeisho.RLength > intIndexFrom + intIndexTo + 2)
                                    {
                                        strWkMeisho = strWkMeisho.RSubstring(intIndexFrom + intIndexTo + 2);      // ‰EŠ‡ŒÊ‚ÌŽŸ‚©‚çƒ[ƒN‚ÉƒZƒbƒg
                                    }
                                    else
                                    {
                                        strWkMeisho = string.Empty;
                                    }

                                    // ¶Š‡ŒÊ‚ð‘{‚·
                                    intIndexFrom = strWkMeisho.RIndexOf(HIDARI_KAKKO);
                                }

                                else
                                {
                                    break;
                                }

                            }

                            // ƒ[ƒN‚Ì’l‚ð–ß‚è’l‚É’Ç‰ÁƒZƒbƒg
                            strRet = strRet + strWkMeisho;
                        }
                        else
                        {
                            // •ÒW‚Í‚µ‚È‚¢
                            strRet = strWkMeisho;
                        }
                    }
                    else
                    {
                        // •ÒW‚Í‚µ‚È‚¢
                        strRet = strWkMeisho;
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
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9158


                    Input:
                    " + exAppException.p_strErrorCode + "z" + _
                                                            "yƒ[ƒjƒ“ƒO“à—e:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9261


                    Input:
                    " + exAppException.Message + "z")
                                Throw

                            Catch exException As Exception 'ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒLƒƒƒbƒ`
                                ' ƒGƒ‰[ƒƒOo—Í
                                m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                            "yƒNƒ‰ƒX–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9516


                    Input:
                    " + THIS_CLASS_NAME + "z" + _
                                                            "yƒƒ\ƒbƒh–¼:
                     */
                    ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9601


                                        Input:
                                        " + THIS_METHOD_NAME + "z" + _
                                                                                "yƒGƒ‰[“à—e:" + exException.Message + "z")

                                         */
                    throw;
                }
            }

            while (false);

            return strRet;
        }
        #endregion

        #endregion

    }
}