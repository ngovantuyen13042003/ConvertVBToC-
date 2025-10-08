// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ˆ¶–¼‹ó”ÔŽæ“¾(ABAkibanShutokuBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/01/20@ŽRè@•q¶
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/04/19  000001      Z–¯ƒR[ƒhŽæ“¾(ˆ¶–¼–@l—p)E(ˆ¶–¼‹¤—L—p)ˆ—’Ç‰Á 
// * 2007/02/05  000002      ˆ¶–¼XVƒGƒ‰[ƒƒO”Ô†Žæ“¾ˆ—’Ç‰Ái“àŽR(Œ˜)j
// * 2007/04/02  000003      ƒR[ƒhŽæ“¾Žž‚Ì‘¶Ýƒ`ƒFƒbƒNˆ—‚ðC³i”ä‰Ãj
// ************************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{

    public class ABAkibanShutokuBClass
    {

        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFLogClass m_cfUFLogClass;            // ƒƒOo—ÍƒNƒ‰ƒX
        private UFControlData m_cfUFControlData;      // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^

        // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
        private string m_strBango;                    // Žæ“¾”Ô†

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABAkibanShutokuBClass";

        // Šeƒƒ“ƒo•Ï”‚ÌƒvƒƒpƒeƒB’è‹`
        public string p_strBango
        {
            get
            {
                return m_strBango;
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
        public ABAkibanShutokuBClass(UFControlData cfControlData, UFConfigDataClass cfConfigData)
        {

            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfUFControlData = cfControlData;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfUFLogClass = new UFLogClass(cfConfigData, cfControlData.m_strBusinessId);

            // ƒpƒ‰ƒ[ƒ^‚Ìƒƒ“ƒo•Ï”
            m_strBango = string.Empty;
        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      Z–¯ƒR[ƒhŽæ“¾
        // * 
        // * \•¶            Public Sub GetJuminCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetJuminCD()
        {
            const string THIS_METHOD_NAME = "GetJuminCD";             // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0001", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                // ƒR[ƒh‘¶Ýƒ`ƒFƒbƒN
                AtenaDBChecKCD(cuGetNum, "0");

                // 'Z–¯ƒR[ƒh‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
       "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
        */
       );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 4262


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      Z–¯ƒR[ƒhŽæ“¾iˆ¶–¼—pj

                 */
            }
        }
        // * 
        // * \•¶            Public Sub GetAtenaJuminCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetAtenaJuminCD()
        {
            const string THIS_METHOD_NAME = "GetAtenaJuminCD";            // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0002", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                AtenaDBChecKCD(cuGetNum, "0");

                // 'Z–¯ƒR[ƒhiˆ¶–¼—pj‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 6051


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      ¢‘ÑƒR[ƒhŽæ“¾

                 */
            }
        }
        // * 
        // * \•¶            Public Sub GetSetaiCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetSetaiCD()
        {
            const string THIS_METHOD_NAME = "GetSetaiCD";             // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0003", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                AtenaDBChecKCD(cuGetNum, "1");

                // '¢‘ÑƒR[ƒh‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 7806


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      ¢‘ÑƒR[ƒhŽæ“¾iˆ¶–¼—pj

                 */
            }
        }
        // * 
        // * \•¶            Public Sub GetAtenaSetaiCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetAtenaSetaiCD()
        {
            const string THIS_METHOD_NAME = "GetAtenaSetaiCD";        // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0004", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                AtenaDBChecKCD(cuGetNum, "1");

                // '¢‘ÑƒR[ƒhiˆ¶–¼—pj‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 9591


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      ‹¤—LŽÒƒR[ƒhŽæ“¾

                 */
            }
        }
        // * 
        // * \•¶            Public Sub GetKyoyuCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetKyoyuCD()
        {
            const string THIS_METHOD_NAME = "GetKyoyuCD";             // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0005", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                AtenaDBChecKCD(cuGetNum, "0");

                // '‹¤—LŽÒƒR[ƒh‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 11350


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub

                    '*—š—ð”Ô† 000001 2004/04/19 ’Ç‰ÁŠJŽn

                 */
            }
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      Z–¯ƒR[ƒhŽæ“¾iˆ¶–¼–@l—pj
        // * 
        // * \•¶            Public Sub GetAtenaHojinCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetAtenaHojinCD()
        {
            const string THIS_METHOD_NAME = "GetAtenaHojinCD";            // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0006", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                AtenaDBChecKCD(cuGetNum, "0");

                // 'Z–¯ƒR[ƒhiˆ¶–¼—pj‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13185


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub

                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼      Z–¯ƒR[ƒhŽæ“¾iˆ¶–¼‹¤—L—pj

                 */
            }
        }
        // * 
        // * \•¶            Public Sub GetAtenaKyoyuCD()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetAtenaKyoyuCD()
        {
            const string THIS_METHOD_NAME = "GetAtenaKyoyuCD";            // ‚±‚Ìƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "0007", "0000");

                // *—š—ð”Ô† 000003 2007/04/02 C³ŠJŽn
                AtenaDBChecKCD(cuGetNum, "0");

                // 'Z–¯ƒR[ƒhiˆ¶–¼—pj‚ð‚PŒŽæ“¾
                // cuGetNum.GetNum(m_cfUFControlData)

                // 'Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                // m_strBango = cuGetNum.p_strBango(0)
                // *—š—ð”Ô† 000003 2007/04/02 C³I—¹

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 14978


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try
                    End Sub
                    '*—š—ð”Ô† 000001 2004/04/19 ’Ç‰ÁI—¹

                 */
            }
        }

        // *—š—ð”Ô† 000003 2007/04/02 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒR[ƒhŽæ“¾Žž‚Ì‘¶Ýƒ`ƒFƒbƒN
        // * 
        // * \•¶            Public Sub AtenaDBChecKCD(ByVal cuGetNum As USSnumgetClass, ByVal strChkCD As String)
        // * 
        // * ‹@”\@@        Žæ“¾‚µ‚½ƒR[ƒh‚ªˆ¶–¼‚c‚aã‚É‘¶Ý‚µ‚È‚¢‚©ƒ`ƒFƒbƒN‚ðs‚¤B
        // * 
        // * ˆø”            cuGetNum As USSnumgetClass   :”Ô†Žæ“¾ƒNƒ‰ƒX 
        // *                 strChkCD As String           :ƒR[ƒhŽæ“¾”»’èƒtƒ‰ƒO
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void AtenaDBChecKCD(USSnumgetClass cuGetNum, string strChkCD)
        {
            const string THIS_METHOD_NAME = "AtenaDBChecKCD";     // ƒƒ\ƒbƒh–¼
            UFRdbClass cfRdb;                                 // RDBƒNƒ‰ƒX
            bool blnChkCD = true;                          // ƒR[ƒh‘¶Ýƒ`ƒFƒbƒNƒtƒ‰ƒO
            StringBuilder csSB;
            UFParameterCollectionClass cfParamCollection;     // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            UFDataReaderClass cfDataReder;                    // ƒf[ƒ^ƒŠ[ƒ_[ƒNƒ‰ƒX

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒCƒ“ƒXƒ^ƒ“ƒX‰»
                csSB = new StringBuilder();
                cfParamCollection = new UFParameterCollectionClass();

                // SQLì¬
                // * SELECT JUMINCD FROM ABATENA WHERE JUMINCD = @JUMINCD
                // * SELECT JUMINCD FROM ABATENA WHERE STAICD = @STAICD
                csSB.Append("SELECT ").Append(ABAtenaEntity.JUMINCD);
                csSB.Append(" FROM ").Append(ABAtenaEntity.TABLE_NAME);
                if (strChkCD == "0")
                {
                    // Z–¯ƒR[ƒh‚Ì‘¶Ý’lƒ`ƒFƒbƒN
                    csSB.Append(" WHERE ").Append(ABAtenaEntity.JUMINCD);
                    csSB.Append(" = ").Append(ABAtenaEntity.PARAM_JUMINCD);
                }
                else
                {
                    // ¢‘ÑƒR[ƒh‚Ì‘¶Ý’lƒ`ƒFƒbƒN
                    csSB.Append(" WHERE ").Append(ABAtenaEntity.STAICD);
                    csSB.Append(" = ").Append(ABAtenaEntity.PARAM_STAICD);
                }

                // RDBƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                cfRdb = new UFRdbClass(m_cfUFControlData.m_strBusinessId);
                // RDBÚ‘±
                cfRdb.Connect();

                try
                {
                    // ‹ó‚«ƒR[ƒh‚ªŒ©‚Â‚©‚é‚Ü‚ÅŒJ‚è•Ô‚·
                    while (blnChkCD)
                    {
                        // ‹ó”ÔŽæ“¾
                        cuGetNum.GetNum(m_cfUFControlData);

                        cfParamCollection.Clear();
                        // Z–¯ƒR[ƒh‚©¢‘ÑƒR[ƒh‚©”»’f
                        if (strChkCD == "0")
                        {
                            // Z–¯ƒR[ƒh‚Ìê‡
                            cfParamCollection.Add(ABAtenaEntity.PARAM_JUMINCD, cuGetNum.p_strBango(0));
                        }
                        else
                        {
                            // ¢‘ÑƒR[ƒh‚Ìê‡
                            cfParamCollection.Add(ABAtenaEntity.PARAM_STAICD, cuGetNum.p_strBango(0));
                        }

                        cfDataReder = cfRdb.GetDataReader(csSB.ToString(), cfParamCollection);
                        if (cfDataReder.Read == false)
                        {
                            // ƒR[ƒh‚ª‘¶Ý‚µ‚È‚¢ê‡
                            // ƒ`ƒFƒbƒNƒtƒ‰ƒO‚ðFalse‚É‚·‚é
                            blnChkCD = false;
                        }
                        cfDataReder.Close();

                    }
                }
                catch
                {
                    // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[
                    throw;
                }
                finally
                {
                    // RDBƒAƒNƒZƒXƒƒOo—Í
                    m_cfUFLogClass.RdbWrite(m_cfUFControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + @"yŽÀsƒƒ\ƒbƒh–¼:Disconnectz");


                    // RDBØ’f
                    cfRdb.Disconnect();
                }

                // Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                m_strBango = cuGetNum.p_strBango(0);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19836


                Input:
                " + objExp.Message + "z")
                            'ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Sub
                    '*—š—ð”Ô† 000003 2007/04/02 ’Ç‰ÁI—¹

                 */
            }
        }

        // *—š—ð”Ô† 000002 2007/02/05 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ˆ¶–¼XVƒGƒ‰[ƒƒO”Ô†Žæ“¾
        // * 
        // * \•¶            Public Sub GetErrLogNo()
        // * 
        // * ‹@”\@@        ‹ó”Ô‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”            ‚È‚µ
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public void GetErrLogNo()
        {

            const string THIS_METHOD_NAME = "GetErrLogNo";          // ƒƒ\ƒbƒh–¼

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfUFLogClass.DebugStartWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ”Ô†Žæ“¾ƒNƒ‰ƒXƒRƒ“ƒXƒgƒ‰ƒNƒ^ƒZƒbƒg
                var cuGetNum = new USSnumgetClass("AB", "2001", "0000");

                // ˆ¶–¼XVƒGƒ‰[ƒƒO”Ô†‚ð‚PŒŽæ“¾
                cuGetNum.GetNum(m_cfUFControlData);

                // Žæ“¾”Ô†‚ðƒvƒƒpƒeƒB‚ÉƒZƒbƒg
                m_strBango = cuGetNum.p_strBango(0);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfUFLogClass.DebugEndWrite(m_cfUFControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
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
                "zyƒƒ\ƒbƒh–¼:THIS_METHOD_NAMEzyƒGƒ‰[“
                 */
                );
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 21555


                Input:
                " + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objExp

                        End Try

                    End Sub
                    '*—š—ð”Ô† 000002 2007/02/05 ’Ç‰ÁI—¹

                 */
            }
        }

    }
}