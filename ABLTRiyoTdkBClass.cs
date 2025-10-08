// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ‚`‚a‚…‚k‚s‚`‚w—˜—p“Íƒ}ƒXƒ^‚c‚`(ABLTRiyoTdkBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯           2008/11/10
// *
// * ì¬ŽÒ@@@     ”ä‰Ã@Œv¬
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2008/11/18   000001     ’Ç‰Áˆ—AXVˆ—ƒƒ\ƒbƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2008/11/27   000002     —˜—p“Íƒf[ƒ^Žæ“¾Vƒƒ\ƒbƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2009/07/27   000003     —˜—p“Ío˜AŒg‹@”\’Ç‰Á‚É”º‚¤‰üCi”ä‰Ãj
// * 2009/11/16   000004     ŒŸõðŒ:ƒJƒiŽ–¼‚ðŒŸõƒJƒiŽ–¼‚ÉC³i”ä‰Ãj
// * 2010/02/22   000005     íœˆ—ƒƒ\ƒbƒh‚ð’Ç‰Ái”ä‰Ãj
// * 2010/04/16   000006     VS2008‘Î‰ži”ä‰Ãj
// * 2014/08/15   000007     yAB21010zŒÂl”Ô†§“x‘Î‰ž “dŽq\iŠâ‰ºj
// * 2015/03/19   000008     yAB21010zŒÂl”Ô†§“x‘Î‰ž “dŽq\ SQL•s‹ï‡C³iŠâ‰ºj
// * 2020/11/06   000009     yAB00189z—˜—p“Ío•¡””[ÅŽÒID‘Î‰ži{]j
// * 2024/01/09   000010     yAB-0770-1z—˜—p“Íoƒf[ƒ^ŠÇ—‘Î‰žiŒ´–ìj
// ************************************************************************************************
using System;
// *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Densan.Reams.AB.AB000BB
{
    // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

    public class ABLTRiyoTdkBClass
    {

        #region ƒƒ“
        // ƒƒ“ƒo•Ï”‚Ì’è‹`
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigDataClass;        // ƒRƒ“ƒtƒBƒOƒf[ƒ^
        private UFRdbClass m_cfRdbClass;                      // ‚q‚c‚aƒNƒ‰ƒX
        private UFLogClass m_cfLogClass;                      // ƒƒOo—ÍƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private DataSet m_csDataSchma;                        // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg:‘S€–Ú—p
        private DataSet m_csDataSchma_Select;                 // ƒXƒL[ƒ}•ÛŠÇ—pƒf[ƒ^ƒZƒbƒg:”[ÅŽÒID,—˜—pŽÒID

        // *—š—ð”Ô† 000001 2008/11/17 ’Ç‰ÁŠJŽn
        private string m_strInsertSQL;
        private string m_strUpDateSQL;
        private UFParameterCollectionClass m_cfInsertUFParameterCollectionClass;  // INSERT—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
        private UFParameterCollectionClass m_cfUpdateUFParameterCollectionClass;  // UPDATE—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
                                                                                  // *—š—ð”Ô† 000001 2008/11/17 ’Ç‰ÁI—¹
                                                                                  // *—š—ð”Ô† 000005 2010/02/22 ’Ç‰ÁŠJŽn
        private string m_strDeleteSQL;
        private UFParameterCollectionClass m_cfDeleteUFParameterCollectionClass;  // Delete—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“
                                                                                  // *—š—ð”Ô† 000005 2010/02/22 ’Ç‰ÁI—¹

        // ƒRƒ“ƒXƒ^ƒ“ƒg’è‹`
        private const string THIS_CLASS_NAME = "ABLTRiyoTdkBClass";
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
        public ABLTRiyoTdkBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigDataClass = cfConfigDataClass;
            m_cfRdbClass = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLogClass = new UFLogClass(m_cfConfigDataClass, m_cfControlData.m_strBusinessId);

            // SQL•¶‚Ìì¬
            // ‘S€–Ú’Šo—pƒXƒL[ƒ}
            m_csDataSchma = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT * FROM " + ABLtRiyoTdkEntity.TABLE_NAME, ABLtRiyoTdkEntity.TABLE_NAME, false);
            // ”[ÅŽÒIDA—˜—pŽÒID—pƒXƒL[ƒ}
            m_csDataSchma_Select = m_cfRdbClass.GetTableSchemaNoRestriction("SELECT NOZEIID,RIYOSHAID FROM " + ABLtRiyoTdkEntity.TABLE_NAME, ABLtRiyoTdkEntity.TABLE_NAME, false);

        }
        #endregion

        #region ƒƒ\ƒbƒh

        #region eLTAX—˜—p“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAX—˜—p“Íƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function GetLTRiyoTdkData(ByVal csABLTRiyoTdkParaX As ABLTRiyoTdkParaXClass) As DataSet
        // * 
        // * ‹@”\@@     —˜—p“Íoƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         csABLTRiyoTdkParaX As ABLTRiyoTdkParaXClass   : —˜—p“Íoƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½—˜—p“Íoƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsLtRiyoTdkEntity    
        // ************************************************************************************************
        // *—š—ð”Ô† 000002 2008/11/27 C³ŠJŽn
        // Public Function GetLTRiyoTdkData(ByVal csABLTRiyoTdkParaX As ABLTRiyoTdkParaXClass) As DataSet
        public DataSet GetLTRiyoTdkData(ABLTRiyoTdkParaXClass csABLTRiyoTdkParaX)
        {
            // *—š—ð”Ô† 000002 2008/11/27 C³I—¹
            const string THIS_METHOD_NAME = "GetLTRiyoTdkData";
            UFErrorStruct objErrorStruct;                             // ƒGƒ‰[’è‹`\‘¢‘Ì
            DataSet csLtRiyoTdkEntity;                                // —˜—p“Íoƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnAndFg = false;                                 // AND”»’èƒtƒ‰ƒO

            // —š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn
            var csRetLtRiyoTdkEntity = default(DataSet);
            DataRow[] csLtRiyoTdkRow;
            string strFilter;
            string strSort;
            ABAtenaKanriJohoBClass cABAtenaKanriJohoB;              // ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX
            string strKanriJoho;
            List<string> csHenkyakuFuyoGyomuCDList;              // •Ô‹p•s—v‹Æ–±CDƒŠƒXƒg
            string strBreakKey;
            DataRow NewDataRow;
            // —š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒpƒ‰ƒ[ƒ^ƒ`ƒFƒbƒN
                if (csABLTRiyoTdkParaX.p_strJuminCD.Trim == string.Empty && csABLTRiyoTdkParaX.p_strZeimokuCD == ABEnumDefine.ZeimokuCDType.Empty)
                {
                    // ƒpƒ‰ƒ[ƒ^:Z–¯CDAÅ–ÚCD‚ªÝ’è‚³‚ê‚Ä‚¢‚È‚¢ê‡‚Íˆø”ƒGƒ‰[
                    // ƒƒbƒZ[ƒWw•K{€–Ú‚ª“ü—Í‚³‚ê‚Ä‚¢‚Ü‚¹‚ñBFZ–¯ƒR[ƒh¤Å–ÚƒR[ƒh‚Ì‚¢‚¸‚ê‚©‚ðÝ’è‚µ‚Ä‚­‚¾‚³‚¢Bx
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage + "Z–¯ƒR[ƒh¤Å–ÚƒR[ƒh‚Ì‚¢‚¸‚ê‚©‚ðÝ’è‚µ‚Ä‚­‚¾‚³‚¢B", objErrorStruct.m_strErrorCode);
                }
                else
                {
                }

                // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn
                if (!(csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "" || csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "1" || csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "2" || csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "3" || csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "4"))



                {
                    // ƒpƒ‰ƒ[ƒ^:—˜—p‹æ•ª‚ª–¢Ý’èA–”‚Í"1"`"4"‚Ì‚¢‚¸‚ê‚Å‚à‚È‚¢ê‡‚Íˆø”ƒGƒ‰[
                    // ƒƒbƒZ[ƒWw—˜—p“Ío—˜—p‹æ•ªx
                    m_cfErrorClass = new UFErrorClass(THIS_BUSINESSID);
                    // ƒGƒ‰[’è‹`‚ðŽæ“¾
                    objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001002);
                    // —áŠO‚ð¶¬
                    throw new UFAppException(objErrorStruct.m_strErrorMessage + default
      /* TODO ERROR: Skipped SkippedTokensTrivia
      Ío—˜—p‹æ•ª", objErrorStruct.m_strErrorCode)
                  End If
                  '*—š—ð”Ô† 000009 2020/11/06*/
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
       "—˜—p“
        */
        );

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                    cfUFParameterCollectionClass = new UFParameterCollectionClass();

                    // SQL•¶‚Ìì¬
                    // SELECT‹å
                    // *—š—ð”Ô† 000009 2020/11/06 C³ŠJŽn
                    // If (csABLTRiyoTdkParaX.p_strOutKB = "1") Then
                    // ' o—Í‹æ•ª‚ª"1"‚Ìê‡Aw”[ÅŽÒID¤—˜—pŽÒIDx‚ð’Šo
                    // strSQL.Append("SELECT ")
                    // strSQL.Append(ABLtRiyoTdkEntity.NOZEIID).Append(", ")
                    // strSQL.Append(ABLtRiyoTdkEntity.RIYOSHAID)
                    // Else
                    // ' o—Í‹æ•ª‚ª"1"ˆÈŠO‚Ìê‡A‘S€–Ú’Šo
                    // strSQL.Append("SELECT * ")
                    // End If
                    // o—Í‹æ•ª‚ª"1"ˆÈŠO‚Ìê‡A‘S€–Ú’Šo
                    strSQL.Append("SELECT * ");
                    // *—š—ð”Ô† 000009 2020/11/06 C³I—¹

                    strSQL.Append(" FROM ").Append(ABLtRiyoTdkEntity.TABLE_NAME);

                    // WHERE‹å
                    strSQL.Append(" WHERE ");

                    // Z–¯ƒR[ƒh
                    if (csABLTRiyoTdkParaX.p_strJuminCD.Trim != string.Empty)
                    {
                        // Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                        strSQL.Append(ABLtRiyoTdkEntity.JUMINCD).Append(" = ");
                        strSQL.Append(ABLtRiyoTdkEntity.KEY_JUMINCD);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_JUMINCD;
                        cfUFParameterClass.Value = csABLTRiyoTdkParaX.p_strJuminCD;

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);

                        // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                        blnAndFg = true;
                    }
                    else
                    {
                        // Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚È‚¢ê‡A‰½‚àƒZƒbƒg‚µ‚È‚¢
                    }

                    // Å–ÚƒR[ƒh
                    if (csABLTRiyoTdkParaX.p_strZeimokuCD != ABEnumDefine.ZeimokuCDType.Empty)
                    {
                        // Å–ÚƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡A’ŠoðŒ‚É‚·‚é
                        if (blnAndFg == true)
                        {
                            // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                            strSQL.Append(" AND ");
                        }

                        strSQL.Append(ABLtRiyoTdkEntity.TAXKB).Append(" = ");
                        strSQL.Append(ABLtRiyoTdkEntity.KEY_TAXKB);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_TAXKB;
                        cfUFParameterClass.Value = (string)csABLTRiyoTdkParaX.p_strZeimokuCD;

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                        cfUFParameterCollectionClass.Add(cfUFParameterClass);

                        // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                        blnAndFg = true;
                    }
                    else
                    {
                    }

                    // ”pŽ~ƒtƒ‰ƒO
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    if (csABLTRiyoTdkParaX.p_blnHaishiFG == false)
                    {
                        // ”pŽ~‹æ•ª‚ª"False"‚Ìê‡A”pŽ~‹æ•ª‚ª”pŽ~‚Å‚È‚¢‚à‚Ì‚ðŽæ“¾‚·‚é
                        // * AND (HAISHIFG <> '1' OR HAISHIFG <> '2') AND SAKUJOFG <> '1'
                        strSQL.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" <> '1' AND ");
                        strSQL.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" <> '2' AND ");
                        strSQL.Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'");
                    }
                    else
                    {
                        // * AND SAKUJOFG <> '1'
                        strSQL.Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'");
                    }

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
                    // *—š—ð”Ô† 000009 2020/11/06 C³ŠJŽn
                    // If (csABLTRiyoTdkParaX.p_strOutKB = "1") Then
                    // csLtRiyoTdkEntity = m_csDataSchma_Select.Clone()
                    // csLtRiyoTdkEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csLtRiyoTdkEntity, ABLtRiyoTdkEntity.TABLE_NAME, cfUFParameterCollectionClass, False)
                    // Else
                    // csLtRiyoTdkEntity = m_csDataSchma.Clone()
                    // csLtRiyoTdkEntity = m_cfRdbClass.GetDataSet(strSQL.ToString, csLtRiyoTdkEntity, ABLtRiyoTdkEntity.TABLE_NAME, cfUFParameterCollectionClass, False)
                    // End If
                    // ‚±‚ÌŽž“_‚Å‚ÍcsLtRiyoTdkEntity‚Í‘S€–Ú‚Æ‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                    /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 13226


                                        Input:
                                        " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                                    ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                         */
                    csLtRiyoTdkEntity = m_csDataSchma.Clone();
                    csLtRiyoTdkEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csLtRiyoTdkEntity, ABLtRiyoTdkEntity.TABLE_NAME, cfUFParameterCollectionClass, false);
                    // *—š—ð”Ô† 000009 2020/11/06 C³I—¹

                    // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn

                    // ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    cABAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                    // ŠÇ—î•ñi10-46j‚ðŽæ“¾
                    strKanriJoho = cABAtenaKanriJohoB.GetHenkyakuFuyoGyomuCD_Param.Trim;
                    csHenkyakuFuyoGyomuCDList = new List<string>(strKanriJoho.Split(','));

                    // ˆê’U—Dæ‡ˆÊ‚ð•t‚¯‚Äƒ\[ƒg‚³‚¹‚Ä‚©‚çŽæŽÌ‘I‘ð‚·‚éŽ–‚©‚çƒNƒ[ƒ“csRetLtRiyoTdkEntity‚ðì¬
                    // csRetLtRiyoTdkEntity = csLtRiyoTdkEntity.Clone()

                    if (csABLTRiyoTdkParaX.p_strOutKB == "1")
                    {
                        // o—Í‹æ•ª'1'‚Ìê‡‚Í”[ÅŽÒID‚Æ—˜—pŽÒID‚Ì‚Ý•Ô‹p‚·‚é‚½‚ßA2€–Ú‚Ì‚Ý‚Æ‚·‚é
                        csRetLtRiyoTdkEntity = m_csDataSchma_Select.Clone();
                    }
                    else
                    {
                        csRetLtRiyoTdkEntity = m_csDataSchma.Clone();
                    }

                    // ŠÇ—î•ñi10-46j‚ÉŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚é‚©”Û‚©‚Å§Œä‚ðs‚¤
                    if (csHenkyakuFuyoGyomuCDList.Contains(m_cfControlData.m_strBusinessId) == true)
                    {
                        // ŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚½ê‡i‹¤’Ê”[Å‚Í•Ô‹p•s—v‚Æ‚È‚éj

                        switch (csABLTRiyoTdkParaX.p_strRiyoKB.Trim)
                        {

                            case "":
                            case "1":
                                {
                                    // ‹¤’Ê„\„‹¤’Ê”[Å‚Ì—Dæ‡i‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                    strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                    strSort = string.Format("{0},{1},{2},{3}", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                    break;
                                }

                            case "2":
                                {
                                    // \„‹¤’Ê‚Ì—Dæ‡
                                    strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                    strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                    break;
                                }

                            case "3":
                                {
                                    // ‹¤’Ê”[Å„‹¤’Ê‚Ì—Dæ‡i‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                    strFilter = string.Format("{0}='{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "1");
                                    strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                    break;
                                }

                            case "4":
                                {
                                    // i‚èž‚Ý‚È‚µi‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                    strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                    strSort = string.Empty;
                                    break;
                                }

                        }
                    }

                    else
                    {
                        // ŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚È‚¢ê‡

                        switch (csABLTRiyoTdkParaX.p_strRiyoKB.Trim)
                        {

                            case "":
                            case "1":
                                {
                                    // ‹¤’Ê„\„‹¤’Ê”[Å‚Ì—Dæ‡
                                    strFilter = string.Empty;
                                    strSort = string.Format("{0},{1},{2},{3}", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                    break;
                                }

                            case "2":
                                {
                                    // \„‹¤’Ê‚Ì—Dæ‡
                                    strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                    strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                    break;
                                }

                            case "3":
                                {
                                    // ‹¤’Ê”[Å„‹¤’Ê‚Ì—Dæ‡
                                    strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "2");
                                    strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                    break;
                                }

                            case "4":
                                {
                                    // i‚èž‚Ý‚È‚µ
                                    strFilter = string.Empty;
                                    strSort = string.Empty;
                                    break;
                                }

                        }

                    }

                    csLtRiyoTdkRow = csLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Select(strFilter, strSort);

                    // csRetLtRiyoTdkEntity‚Ö‚ÌƒZƒbƒg
                    if (csLtRiyoTdkRow.Length > 0)
                    {
                        // Žæ“¾Œ”‚ª0ŒˆÈã‚Ìê‡

                        if (csABLTRiyoTdkParaX.p_strOutKB == "1")
                        {
                            // o—Í‹æ•ª'1'‚Ìê‡‚Í”[ÅŽÒID‚Æ—˜—pŽÒID‚Ì‚Ý•Ô‹p‚·‚é‚½‚ßAcsRetLtRiyoTdkEntity‚Í‚»‚Ì2€–Ú‚Ì‚ÝƒZƒbƒg‚·‚é

                            if (csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "4")
                            {
                                // ˆø”F—˜—p‹æ•ª"4"‚Ìê‡‚Í‘SŒ•Ô‹p‚·‚éB
                                for (int i = 0, loopTo = csLtRiyoTdkRow.Length - 1; i <= loopTo; i++)
                                {
                                    NewDataRow = csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).NewRow();                     // ’Ç‰Á‚·‚éƒf[ƒ^ƒe[ƒuƒ‹‚ÌV‹Ks‚Æ‚·‚é
                                    NewDataRow.Item(ABLtRiyoTdkEntity.NOZEIID) = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.NOZEIID);      // ”[ÅŽÒID
                                    NewDataRow.Item(ABLtRiyoTdkEntity.RIYOSHAID) = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.RIYOSHAID);  // —˜—pŽÒID
                                    csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Rows.Add(NewDataRow);                      // •Ô‹p—pƒf[ƒ^ƒe[ƒuƒ‹‚És’Ç‰Á
                                }
                            }
                            else
                            {
                                // ˆø”F—˜—p‹æ•ª‚"4"‚Ìê‡‚ÍAZ–¯ƒR[ƒhAÅ–Ú‹æ•ªA”pŽ~ƒtƒ‰ƒO‚ÌƒuƒŒƒCƒNŽž‚É1Œ•Ô‹p‚·‚éB
                                strBreakKey = "";

                                for (int i = 0, loopTo1 = csLtRiyoTdkRow.Length - 1; i <= loopTo1; i++)
                                {
                                    if (strBreakKey != csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString)
                                    {
                                        NewDataRow = csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).NewRow();                     // ’Ç‰Á‚·‚éƒf[ƒ^ƒe[ƒuƒ‹‚ÌV‹Ks‚Æ‚·‚é
                                        NewDataRow.Item(ABLtRiyoTdkEntity.NOZEIID) = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.NOZEIID);      // ”[ÅŽÒID
                                        NewDataRow.Item(ABLtRiyoTdkEntity.RIYOSHAID) = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.RIYOSHAID);  // —˜—pŽÒID
                                        csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Rows.Add(NewDataRow);                      // •Ô‹p—pƒf[ƒ^ƒe[ƒuƒ‹‚És’Ç‰Á
                                        strBreakKey = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString;
                                    }
                                }

                            }
                        }
                        // o—Í‹æ•ª'1'ˆÈŠO‚Ìê‡‚Í‚»‚Ì‚Ü‚ÜIMPORT‚·‚éB

                        else if (csABLTRiyoTdkParaX.p_strRiyoKB.Trim == "4")
                        {
                            // ˆø”F—˜—p‹æ•ª"4"‚Ìê‡‚Í‘SŒ•Ô‹p‚·‚éB
                            for (int i = 0, loopTo2 = csLtRiyoTdkRow.Length - 1; i <= loopTo2; i++)
                                csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow[i]);
                        }
                        else
                        {
                            // ˆø”F—˜—p‹æ•ª‚"4"‚Ìê‡‚ÍAZ–¯ƒR[ƒhAÅ–Ú‹æ•ªA”pŽ~ƒtƒ‰ƒO‚ÌƒuƒŒƒCƒNŽž‚É1Œ•Ô‹p‚·‚éB
                            strBreakKey = "";
                            for (int i = 0, loopTo3 = csLtRiyoTdkRow.Length - 1; i <= loopTo3; i++)
                            {
                                if (strBreakKey != csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString)
                                {
                                    csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow[i]);
                                    strBreakKey = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString;
                                }
                            }
                        }

                    }
                    // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23176


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23279


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                // Return csLtRiyoTdkEntity
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 23811


                                Input:
                                " + exException.Message + "z")
                                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                                            Throw

                                        End Try

                                        '*—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn

                                 */
                return csRetLtRiyoTdkEntity;
            }

            return default;
            // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

        }
        #endregion

        // *—š—ð”Ô† 000002 2008/11/27 ’Ç‰ÁŠJŽn
        #region eLTAX—˜—p“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAX—˜—p“Íƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh‚Q
        // * 
        // * \•¶         Public Overloads Function GetLTRiyoTdkData(ByVal cABLTRiyoTdkPara2X As ABLTRiyoTdkPara2XClass) As DataSet
        // * 
        // * ‹@”\@@     —˜—p“Íoƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         cABLTRiyoTdkPara2X As ABLTRiyoTdkPara2XClass   : —˜—p“Íoƒpƒ‰ƒ[ƒ^‚QƒNƒ‰ƒX
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½—˜—p“Íoƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsLtRiyoTdkEntity    
        // ************************************************************************************************
        public DataSet GetLTRiyoTdkData(ABLTRiyoTdkPara2XClass cABLTRiyoTdkPara2X)
        {
            const string THIS_METHOD_NAME = "GetLTRiyoTdkData";
            // * corresponds to VS2008 Start 2010/04/16 000006
            // Dim objErrorStruct As UFErrorStruct                             ' ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000006
            DataSet csLtRiyoTdkEntity;                                // —˜—p“Íoƒ}ƒXƒ^ƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnAndFg = false;                                 // AND”»’èƒtƒ‰ƒO

            // —š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn
            var csRetLtRiyoTdkEntity = default(DataSet);
            DataRow[] csLtRiyoTdkRow;
            var strFilter = default(string);
            var strSort = default(string);
            ABAtenaKanriJohoBClass cABAtenaKanriJohoB;              // ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX
            string strKanriJoho;
            List<string> csHenkyakuFuyoGyomuCDList;              // •Ô‹p•s—v‹Æ–±CDƒŠƒXƒg
            string strBreakKey;
            // —š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // SQL•¶‚Ìì¬
                // SELECT‹å
                // *—š—ð”Ô† 000010 2024/01/09 C³ŠJŽn
                // strSQL.Append("SELECT * ")
                strSQL.Append("SELECT ");
                strSQL.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".*");
                // *—š—ð”Ô† 000010 2024/01/09 C³I—¹

                strSQL.Append(" FROM ").Append(ABLtRiyoTdkEntity.TABLE_NAME);

                // *—š—ð”Ô† 000010 2024/01/09 ’Ç‰ÁŠJŽn
                if (cABLTRiyoTdkPara2X.p_strMyNumber.Trim != string.Empty)
                {
                    strSQL.Append(" INNER JOIN ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME);
                    strSQL.Append(" ON ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.JUMINCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.JUMINCD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.MYNUMBER);
                    strSQL.Append(" = ");
                    strSQL.Append(ABMyNumberEntity.PARAM_MYNUMBER);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.CKINKB);
                    strSQL.Append(" = ");
                    strSQL.Append("'").Append(ABMyNumberEntity.DEFAULT.CKINKB.CKIN).Append("'");
                    strSQL.Append(" AND ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.SAKUJOFG);
                    strSQL.Append(" <> '1'");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABMyNumberEntity.PARAM_MYNUMBER;
                    cfUFParameterClass.Value = (string)cABLTRiyoTdkPara2X.p_strMyNumber;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                }
                // *—š—ð”Ô† 000010 2024/01/09 ’Ç‰ÁI—¹

                // WHERE‹å
                strSQL.Append(" WHERE ");
                // ---------------------------------------------------------------------------------
                // Å–Ú‹æ•ª
                if (cABLTRiyoTdkPara2X.p_strTaxKB.Trim != string.Empty)
                {
                    // Å–Ú‹æ•ª‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡

                    strSQL.Append(ABLtRiyoTdkEntity.TAXKB).Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_TAXKB);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_TAXKB;
                    cfUFParameterClass.Value = (string)cABLTRiyoTdkPara2X.p_strTaxKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // ”[ÅŽÒID
                if (cABLTRiyoTdkPara2X.p_strNozeiID.Trim != string.Empty)
                {
                    // ”[ÅŽÒID‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABLtRiyoTdkEntity.NOZEIID).Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_NOZEIID);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_NOZEIID;
                    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strNozeiID;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // —˜—pŽÒID
                if (cABLTRiyoTdkPara2X.p_strRiyoshaID.Trim != string.Empty)
                {
                    // —˜—pŽÒID‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABLtRiyoTdkEntity.RIYOSHAID).Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_RIYOSHAID);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RIYOSHAID;
                    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strRiyoshaID;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // *—š—ð”Ô† 000010 2024/01/09 íœŠJŽn
                // '*—š—ð”Ô† 000007 2014/08/15 ’Ç‰ÁŠJŽn
                // '---------------------------------------------------------------------------------
                // ' ŒÂl”Ô†
                // 'If (cABLTRiyoTdkPara2X.p_strMyNumber.Trim <> String.Empty) Then
                // '    Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                // '    If (blnAndFg = True) Then
                // '        AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                // '        strSQL.Append(" AND ")
                // '    End If

                // '    strSQL.Append(ABLtRiyoTdkEntity.RESERVE1).Append(" = ")
                // '    strSQL.Append(ABLtRiyoTdkEntity.KEY_RESERVE1)

                // '    ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // '    cfUFParameterClass = New UFParameterClass
                // '    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RESERVE1
                // '    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strMyNumber

                // '    ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                // '    cfUFParameterCollectionClass.Add(cfUFParameterClass)

                // '    AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                // '    blnAndFg = True
                // 'Else
                // 'End If
                // '*—š—ð”Ô† 000007 2014/08/15 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000010 2024/01/09 íœI—¹
                // ---------------------------------------------------------------------------------
                // Z–¯ƒR[ƒh
                if (cABLTRiyoTdkPara2X.p_strJuminCD.Trim != string.Empty)
                {
                    // Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABLtRiyoTdkEntity.JUMINCD).Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_JUMINCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_JUMINCD;
                    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strJuminCD;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // Žó•t”Ô†
                if (cABLTRiyoTdkPara2X.p_strRcptNO.Trim != string.Empty)
                {
                    // Žó•t”Ô†‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABLtRiyoTdkEntity.RCPTNO).Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_RCPTNO);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RCPTNO;
                    cfUFParameterClass.Value = (string)cABLTRiyoTdkPara2X.p_strRcptNO;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // Žó•t“ú
                if (cABLTRiyoTdkPara2X.p_strRcptYMD_From.Trim != string.Empty && cABLTRiyoTdkPara2X.p_strRcptYMD_To.Trim != string.Empty)
                {
                    // Žó•t“ú‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABLtRiyoTdkEntity.RCPTYMD).Append(" >= ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_RCPTYMD + "1");

                    strSQL.Append(" AND ");

                    strSQL.Append(ABLtRiyoTdkEntity.RCPTYMD).Append(" <= ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_RCPTYMD + "2");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RCPTYMD + "1";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strRcptYMD_From).RPadRight(17, '0');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RCPTYMD + "2";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strRcptYMD_To).RPadRight(17, '9');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // *—š—ð”Ô† 000003 2009/07/27 ’Ç‰ÁŠJŽn
                // ˆ—“ú
                if (cABLTRiyoTdkPara2X.p_strShoriYMD_From.Trim != string.Empty && cABLTRiyoTdkPara2X.p_strShoriYMD_To.Trim != string.Empty)
                {
                    // ˆ—“ú‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    strSQL.Append(ABLtRiyoTdkEntity.KOSHINNICHIJI).Append(" >= ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "1");

                    strSQL.Append(" AND ");

                    strSQL.Append(ABLtRiyoTdkEntity.KOSHINNICHIJI).Append(" <= ");
                    strSQL.Append(ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "2");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "1";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strShoriYMD_From).RPadRight(17, '0');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "2";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strShoriYMD_To).RPadRight(17, '9');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // ƒJƒiEŠ¿Žš–¼Ì
                // ƒJƒi–¼Ì
                if (!(cABLTRiyoTdkPara2X.p_strKanaMeisho.Trim == string.Empty))
                {
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    if (cABLTRiyoTdkPara2X.p_strKanaMeisho.RIndexOf("%") == -1)
                    {
                        // *—š—ð”Ô† 000004 2009/11/16 C³ŠJŽn
                        strSQL.Append(ABLtRiyoTdkEntity.SEARCHKANAMEISHO);
                        // strSQL.Append(ABLtRiyoTdkEntity.KANAMEISHO)
                        // *—š—ð”Ô† 000004 2009/11/16 C³I—¹
                        strSQL.Append(" = ");
                        strSQL.Append(ABLtRiyoTdkEntity.KEY_KANAMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANAMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanaMeisho;
                    }
                    else
                    {
                        // *—š—ð”Ô† 000004 2009/11/16 C³ŠJŽn
                        strSQL.Append(ABLtRiyoTdkEntity.SEARCHKANAMEISHO);
                        // strSQL.Append(ABLtRiyoTdkEntity.KANAMEISHO)
                        // *—š—ð”Ô† 000004 2009/11/16 C³I—¹
                        strSQL.Append(" LIKE ");
                        strSQL.Append(ABLtRiyoTdkEntity.KEY_KANAMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANAMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanaMeisho.TrimEnd;
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }

                // ŒŸõ—pŠ¿Žš–¼Ì
                if (!(cABLTRiyoTdkPara2X.p_strKanjiMeisho.Trim == string.Empty))
                {
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    if (cABLTRiyoTdkPara2X.p_strKanjiMeisho.RIndexOf("%") == -1)
                    {
                        strSQL.Append(ABLtRiyoTdkEntity.KANJIMEISHO);
                        strSQL.Append(" = ");
                        strSQL.Append(ABLtRiyoTdkEntity.KEY_KANJIMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANJIMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanjiMeisho;
                    }
                    else
                    {
                        strSQL.Append(ABLtRiyoTdkEntity.KANJIMEISHO);
                        strSQL.Append(" LIKE ");
                        strSQL.Append(ABLtRiyoTdkEntity.KEY_KANJIMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANJIMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanjiMeisho.TrimEnd;

                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                // *—š—ð”Ô† 000003 2009/07/27 ’Ç‰ÁI—¹
                // ---------------------------------------------------------------------------------
                // ”pŽ~ƒtƒ‰ƒO
                if (cABLTRiyoTdkPara2X.p_strHaishiFG.Trim != string.Empty)
                {
                    // ”pŽ~ƒtƒ‰ƒO‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strSQL.Append(" AND ");
                    }

                    switch (cABLTRiyoTdkPara2X.p_strHaishiFG)
                    {
                        case "0":    // —LŒø‚Ì‚Ý
                            {
                                strSQL.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" <> '1' AND ");
                                strSQL.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" <> '2'");
                                break;
                            }

                        case "1":    // ”pŽ~‚Ì‚Ý
                            {
                                strSQL.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" = '1'");
                                break;
                            }

                        case "2":    // Å–Úíœ‚Ì‚Ý
                            {
                                strSQL.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" = '2'");
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // íœƒtƒ‰ƒO
                if (blnAndFg == true)
                {
                    // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                    strSQL.Append(" AND ");
                    // *—š—ð”Ô† 000010 2024/01/09 C³ŠJŽn
                    // strSQL.Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'")
                    strSQL.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'");
                }
                // *—š—ð”Ô† 000010 2024/01/09 C³I—¹

                else
                {
                    // *—š—ð”Ô† 000010 2024/01/09 C³ŠJŽn
                    // strSQL.Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'")
                    strSQL.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'");
                    // *—š—ð”Ô† 000010 2024/01/09 C³I—¹
                }
                // ---------------------------------------------------------------------------------
                // Å‘åŽæ“¾Œ”
                if (cABLTRiyoTdkPara2X.p_intGetCountMax != 0)
                {
                    m_cfRdbClass.p_intMaxRows = cABLTRiyoTdkPara2X.p_intGetCountMax;
                }
                else
                {
                }

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 45590


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csLtRiyoTdkEntity = m_csDataSchma.Clone();
                csLtRiyoTdkEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csLtRiyoTdkEntity, ABLtRiyoTdkEntity.TABLE_NAME, cfUFParameterCollectionClass, false);

                // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn

                // ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ŠÇ—î•ñi10-46j‚ðŽæ“¾
                strKanriJoho = cABAtenaKanriJohoB.GetHenkyakuFuyoGyomuCD_Param.Trim;
                csHenkyakuFuyoGyomuCDList = new List<string>(strKanriJoho.Split(','));

                csRetLtRiyoTdkEntity = csLtRiyoTdkEntity.Clone();

                if (csHenkyakuFuyoGyomuCDList.Contains(m_cfControlData.m_strBusinessId) == true)
                {
                    // ŠÇ—î•ñi10-46j‚ÉŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚½ê‡‚Í‹¤’Ê”[Å‚Í•s—v

                    switch (cABLTRiyoTdkPara2X.p_strRiyoKB.Trim)
                    {

                        case "":
                        case "1":
                            {
                                // ‹¤’Ê„\„‹¤’Ê”[Å‚Ì—Dæ‡i‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Format("{0},{1},{2},{3}", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "2":
                            {
                                // \„‹¤’Ê‚Ì—Dæ‡
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "3":
                            {
                                // ‹¤’Ê”[Å„‹¤’Ê‚Ì—Dæ‡i‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                strFilter = string.Format("{0}='{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "1");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "4":
                            {
                                // i‚èž‚Ý‚È‚µi‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Empty;
                                break;
                            }

                    }
                }

                else
                {
                    // ŠÇ—î•ñi10-46j‚ÉŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚È‚¢ê‡

                    switch (cABLTRiyoTdkPara2X.p_strRiyoKB.Trim)
                    {

                        case "":
                        case "1":
                            {
                                // ‹¤’Ê„\„‹¤’Ê”[Å‚Ì—Dæ‡
                                strFilter = string.Empty;
                                strSort = string.Format("{0},{1},{2},{3}", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "2":
                            {
                                // \„‹¤’Ê‚Ì—Dæ‡
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "3":
                            {
                                // ‹¤’Ê”[Å„‹¤’Ê‚Ì—Dæ‡
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "2");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "4":
                            {
                                // i‚èž‚Ý‚È‚µ
                                strFilter = string.Empty;
                                strSort = string.Empty;
                                break;
                            }

                    }

                }

                csLtRiyoTdkRow = csLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Select(strFilter, strSort);

                if (csLtRiyoTdkRow.Length > 0)
                {
                    // Žæ“¾Œ”‚ª0ŒˆÈã‚Ìê‡
                    if (cABLTRiyoTdkPara2X.p_strRiyoKB.Trim == "4")
                    {
                        // ˆø”F—˜—p‹æ•ª"4"‚Ìê‡‚Í‘SŒ•Ô‹p‚·‚éB
                        for (int i = 0, loopTo = csLtRiyoTdkRow.Length - 1; i <= loopTo; i++)
                            csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow[i]);
                    }
                    else
                    {
                        // csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow(0))
                        // ˆø”F—˜—p‹æ•ª‚"4"‚Ìê‡‚ÍAZ–¯ƒR[ƒhAÅ–Ú‹æ•ªA”pŽ~ƒtƒ‰ƒO‚ÌƒuƒŒƒCƒNŽž‚É1Œ•Ô‹p‚·‚éB
                        strBreakKey = "";
                        for (int i = 0, loopTo1 = csLtRiyoTdkRow.Length - 1; i <= loopTo1; i++)
                        {
                            if (strBreakKey != csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString)
                            {
                                csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow[i]);
                                strBreakKey = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString;
                            }
                        }
                    }
                }
                // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51790


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 51893


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                // Return csLtRiyoTdkEntity
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52425


                                Input:
                                " + exException.Message + "z")
                                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                                            Throw

                                        End Try

                                        '*—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn

                                 */
                return csRetLtRiyoTdkEntity;
            }

            return default;
            // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

        }
        #endregion
        // *—š—ð”Ô† 000002 2008/11/27 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000003 2009/07/27 ’Ç‰ÁŠJŽn
        #region eLTAX—˜—p“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAX—˜—p“Íƒf[ƒ^Žæ“¾ƒƒ\ƒbƒh‚R
        // * 
        // * \•¶         Public Overloads Function GetLTRiyoTdkData(ByVal cABLTRiyoTdkPara2X As ABLTRiyoTdkPara2XClass, _
        // *                                                         ByRef intAllCount As Integer) As DataSet
        // * 
        // * ‹@”\@@     —˜—p“Íoƒ}ƒXƒ^‚æ‚èŠY“–ƒf[ƒ^‚ðŽæ“¾‚·‚éB
        // * 
        // * ˆø”         cABLTRiyoTdkPara2X As ABLTRiyoTdkPara2XClass    : —˜—p“Íoƒpƒ‰ƒ[ƒ^‚QƒNƒ‰ƒX
        // *              intAllCount As Integer                          : ‘Sƒf[ƒ^Œ”
        // * 
        // * –ß‚è’l       Žæ“¾‚µ‚½—˜—p“Íoƒ}ƒXƒ^‚ÌŠY“–ƒf[ƒ^iDataSetj
        // *                 \‘¢FcsLtRiyoTdkEntity    
        // ************************************************************************************************
        public DataSet GetLTRiyoTdkData(ABLTRiyoTdkPara2XClass cABLTRiyoTdkPara2X, ref int intAllCount)
        {
            const string THIS_METHOD_NAME = "GetLTRiyoTdkData";
            const string COL_COUNT = "COUNT";
            // * corresponds to VS2008 Start 2010/04/16 000006
            // Dim objErrorStruct As UFErrorStruct                             ' ƒGƒ‰[’è‹`\‘¢‘Ì
            // * corresponds to VS2008 End 2010/04/16 000006
            DataSet csLtRiyoTdkEntity;                                // —˜—p“Íoƒ}ƒXƒ^ƒf[ƒ^
            DataSet csLtRiyoTdk_AllCount;                             // —˜—p“Íoƒ}ƒXƒ^‘SŒŽæ“¾ƒf[ƒ^
            var strSQL = new StringBuilder();                                 // SQL•¶•¶Žš—ñ
            var strSQL_Conut = new StringBuilder();                           // ‘SŒ’Šo
            var strWhere = new StringBuilder();                               // WHERE•¶•¶Žš—ñ
            UFParameterClass cfUFParameterClass;                      // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            UFParameterCollectionClass cfUFParameterCollectionClass;  // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX
            bool blnAndFg = false;                                 // AND”»’èƒtƒ‰ƒO
                                                                   // *—š—ð”Ô† 000007 2014/08/15 ’Ç‰ÁŠJŽn
            var strSQLMyNumber = new StringBuilder();                         // ‹¤’Ê”Ô†SQL
                                                                              // *—š—ð”Ô† 000007 2014/08/15 ’Ç‰ÁI—¹

            // —š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn
            var csRetLtRiyoTdkEntity = default(DataSet);
            DataRow[] csLtRiyoTdkRow;
            var strFilter = default(string);
            var strSort = default(string);
            ABAtenaKanriJohoBClass cABAtenaKanriJohoB;              // ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX
            string strKanriJoho;
            List<string> csHenkyakuFuyoGyomuCDList;              // •Ô‹p•s—v‹Æ–±CDƒŠƒXƒg
            string strBreakKey;
            // —š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚ðì¬
                cfUFParameterCollectionClass = new UFParameterCollectionClass();

                // SQL•¶‚Ìì¬
                // SELECT‹å
                // *—š—ð”Ô† 000010 2024/01/09 C³ŠJŽn
                // strSQL.Append("SELECT * ")
                strSQL.Append("SELECT ");
                strSQL.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".*");
                // *—š—ð”Ô† 000010 2024/01/09 C³I—¹
                strSQL.Append(" FROM ").Append(ABLtRiyoTdkEntity.TABLE_NAME);

                strSQL_Conut.Append("SELECT COUNT(*) AS ").Append(COL_COUNT);
                strSQL_Conut.Append(" FROM ").Append(ABLtRiyoTdkEntity.TABLE_NAME);

                // *—š—ð”Ô† 000010 2024/01/09 ’Ç‰ÁŠJŽn
                if (cABLTRiyoTdkPara2X.p_strMyNumber.Trim != string.Empty)
                {
                    strSQL.Append(" INNER JOIN ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME);
                    strSQL.Append(" ON ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.JUMINCD);
                    strSQL.Append(" = ");
                    strSQL.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.JUMINCD);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.MYNUMBER);
                    strSQL.Append(" = ");
                    strSQL.Append(ABMyNumberEntity.PARAM_MYNUMBER);
                    strSQL.Append(" AND ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.CKINKB);
                    strSQL.Append(" = ");
                    strSQL.Append("'").Append(ABMyNumberEntity.DEFAULT.CKINKB.CKIN).Append("'");
                    strSQL.Append(" AND ");
                    strSQL.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.SAKUJOFG);
                    strSQL.Append(" <> '1' ");

                    strSQL_Conut.Append(" INNER JOIN ");
                    strSQL_Conut.Append(ABMyNumberEntity.TABLE_NAME);
                    strSQL_Conut.Append(" ON ");
                    strSQL_Conut.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.JUMINCD);
                    strSQL_Conut.Append(" = ");
                    strSQL_Conut.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.JUMINCD);
                    strSQL_Conut.Append(" AND ");
                    strSQL_Conut.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.MYNUMBER);
                    strSQL_Conut.Append(" = ");
                    strSQL_Conut.Append(ABMyNumberEntity.PARAM_MYNUMBER);
                    strSQL_Conut.Append(" AND ");
                    strSQL_Conut.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.CKINKB);
                    strSQL_Conut.Append(" = ");
                    strSQL_Conut.Append("'").Append(ABMyNumberEntity.DEFAULT.CKINKB.CKIN).Append("'");
                    strSQL_Conut.Append(" AND ");
                    strSQL_Conut.Append(ABMyNumberEntity.TABLE_NAME).Append(".").Append(ABMyNumberEntity.SAKUJOFG);
                    strSQL_Conut.Append(" <> '1' ");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABMyNumberEntity.PARAM_MYNUMBER;
                    cfUFParameterClass.Value = (string)cABLTRiyoTdkPara2X.p_strMyNumber;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);
                }
                else
                {
                }
                // *—š—ð”Ô† 000010 2024/01/09 ’Ç‰ÁI—¹

                // WHERE‹å
                strWhere.Append(" WHERE ");
                // ---------------------------------------------------------------------------------
                // Å–Ú‹æ•ª
                if (cABLTRiyoTdkPara2X.p_strTaxKB.Trim != string.Empty)
                {
                    // Å–Ú‹æ•ª‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡

                    strWhere.Append(ABLtRiyoTdkEntity.TAXKB).Append(" = ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_TAXKB);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_TAXKB;
                    cfUFParameterClass.Value = (string)cABLTRiyoTdkPara2X.p_strTaxKB;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // ”[ÅŽÒID
                if (cABLTRiyoTdkPara2X.p_strNozeiID.Trim != string.Empty)
                {
                    // ”[ÅŽÒID‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    strWhere.Append(ABLtRiyoTdkEntity.NOZEIID).Append(" = ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_NOZEIID);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_NOZEIID;
                    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strNozeiID;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // —˜—pŽÒID
                if (cABLTRiyoTdkPara2X.p_strRiyoshaID.Trim != string.Empty)
                {
                    // —˜—pŽÒID‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    strWhere.Append(ABLtRiyoTdkEntity.RIYOSHAID).Append(" = ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_RIYOSHAID);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RIYOSHAID;
                    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strRiyoshaID;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // *—š—ð”Ô† 000010 2024/01/09 íœŠJŽn
                // '*—š—ð”Ô† 000007 2014/08/15 ’Ç‰ÁŠJŽn
                // '---------------------------------------------------------------------------------
                // ' ŒÂl”Ô†
                // If (cABLTRiyoTdkPara2X.p_strMyNumber.Trim <> String.Empty) Then
                // '*—š—ð”Ô† 000007 2014/08/15 C³ŠJŽn
                // '' Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                // 'If (blnAndFg = True) Then
                // '    ' AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                // '    strSQL.Append(" AND ")
                // 'End If

                // 'strSQL.Append(ABLtRiyoTdkEntity.RESERVE1).Append(" = ")
                // 'strSQL.Append(ABLtRiyoTdkEntity.KEY_RESERVE1)
                // ' ŒÂl”Ô†‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                // If (blnAndFg = True) Then
                // ' AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                // strWhere.Append(" AND ")
                // End If

                // strWhere.Append(ABLtRiyoTdkEntity.RESERVE1).Append(" = ")
                // strWhere.Append(ABLtRiyoTdkEntity.KEY_RESERVE1)
                // '*—š—ð”Ô† 000007 2014/08/15 C³I—¹

                // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                // cfUFParameterClass = New UFParameterClass
                // cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RESERVE1
                // cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strMyNumber

                // ' ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                // cfUFParameterCollectionClass.Add(cfUFParameterClass)

                // ' AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                // blnAndFg = True
                // Else
                // End If
                // '*—š—ð”Ô† 000007 2014/08/15 ’Ç‰ÁI—¹
                // *—š—ð”Ô† 000010 2024/01/09 íœI—¹
                // ---------------------------------------------------------------------------------
                // Z–¯ƒR[ƒh
                if (cABLTRiyoTdkPara2X.p_strJuminCD.Trim != string.Empty)
                {
                    // Z–¯ƒR[ƒh‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    strWhere.Append(ABLtRiyoTdkEntity.JUMINCD).Append(" = ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_JUMINCD);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_JUMINCD;
                    cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strJuminCD;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // Žó•t”Ô†
                if (cABLTRiyoTdkPara2X.p_strRcptNO.Trim != string.Empty)
                {
                    // Žó•t”Ô†‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    strWhere.Append(ABLtRiyoTdkEntity.RCPTNO).Append(" = ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_RCPTNO);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RCPTNO;
                    cfUFParameterClass.Value = (string)cABLTRiyoTdkPara2X.p_strRcptNO;

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // Žó•t“ú
                if (cABLTRiyoTdkPara2X.p_strRcptYMD_From.Trim != string.Empty && cABLTRiyoTdkPara2X.p_strRcptYMD_To.Trim != string.Empty)
                {
                    // Žó•t“ú‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    strWhere.Append(ABLtRiyoTdkEntity.RCPTYMD).Append(" >= ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_RCPTYMD + "1");

                    strWhere.Append(" AND ");

                    strWhere.Append(ABLtRiyoTdkEntity.RCPTYMD).Append(" <= ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_RCPTYMD + "2");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RCPTYMD + "1";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strRcptYMD_From).RPadRight(17, '0');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_RCPTYMD + "2";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strRcptYMD_To).RPadRight(17, '9');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // *—š—ð”Ô† 000003 2009/07/27 ’Ç‰ÁŠJŽn
                // ˆ—“ú
                if (cABLTRiyoTdkPara2X.p_strShoriYMD_From.Trim != string.Empty && cABLTRiyoTdkPara2X.p_strShoriYMD_To.Trim != string.Empty)
                {
                    // ˆ—“ú‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    strWhere.Append(ABLtRiyoTdkEntity.KOSHINNICHIJI).Append(" >= ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "1");

                    strWhere.Append(" AND ");

                    strWhere.Append(ABLtRiyoTdkEntity.KOSHINNICHIJI).Append(" <= ");
                    strWhere.Append(ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "2");

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "1";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strShoriYMD_From).RPadRight(17, '0');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                    cfUFParameterClass = new UFParameterClass();
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KOSHINNICHIJI + "2";
                    cfUFParameterClass.Value = ((string)cABLTRiyoTdkPara2X.p_strShoriYMD_To).RPadRight(17, '9');

                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // ƒJƒiEŠ¿Žš–¼Ì
                // ƒJƒi–¼Ì
                if (!(cABLTRiyoTdkPara2X.p_strKanaMeisho.Trim == string.Empty))
                {
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    if (cABLTRiyoTdkPara2X.p_strKanaMeisho.RIndexOf("%") == -1)
                    {
                        // *—š—ð”Ô† 000004 2009/11/16 C³ŠJŽn
                        strWhere.Append(ABLtRiyoTdkEntity.SEARCHKANAMEISHO);
                        // strWhere.Append(ABLtRiyoTdkEntity.KANAMEISHO)
                        // *—š—ð”Ô† 000004 2009/11/16 C³I—¹
                        strWhere.Append(" = ");
                        strWhere.Append(ABLtRiyoTdkEntity.KEY_KANAMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANAMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanaMeisho;
                    }
                    else
                    {
                        // *—š—ð”Ô† 000004 2009/11/16 C³ŠJŽn
                        strWhere.Append(ABLtRiyoTdkEntity.SEARCHKANAMEISHO);
                        // strWhere.Append(ABLtRiyoTdkEntity.KANAMEISHO)
                        // *—š—ð”Ô† 000004 2009/11/16 C³I—¹
                        strWhere.Append(" LIKE ");
                        strWhere.Append(ABLtRiyoTdkEntity.KEY_KANAMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANAMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanaMeisho.TrimEnd;
                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }

                // ŒŸõ—pŠ¿Žš–¼Ì
                if (!(cABLTRiyoTdkPara2X.p_strKanjiMeisho.Trim == string.Empty))
                {
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    if (cABLTRiyoTdkPara2X.p_strKanjiMeisho.RIndexOf("%") == -1)
                    {
                        strWhere.Append(ABLtRiyoTdkEntity.KANJIMEISHO);
                        strWhere.Append(" = ");
                        strWhere.Append(ABLtRiyoTdkEntity.KEY_KANJIMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANJIMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanjiMeisho;
                    }
                    else
                    {
                        strWhere.Append(ABLtRiyoTdkEntity.KANJIMEISHO);
                        strWhere.Append(" LIKE ");
                        strWhere.Append(ABLtRiyoTdkEntity.KEY_KANJIMEISHO);

                        // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^‚ðì¬
                        cfUFParameterClass = new UFParameterClass();
                        cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.KEY_KANJIMEISHO;
                        cfUFParameterClass.Value = cABLTRiyoTdkPara2X.p_strKanjiMeisho.TrimEnd;

                    }
                    // ŒŸõðŒ‚Ìƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒIƒuƒWƒFƒNƒg‚Éƒpƒ‰ƒ[ƒ^ƒIƒuƒWƒFƒNƒg‚Ì’Ç‰Á
                    cfUFParameterCollectionClass.Add(cfUFParameterClass);

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                // *—š—ð”Ô† 000003 2009/07/27 ’Ç‰ÁI—¹
                // ---------------------------------------------------------------------------------
                // ”pŽ~ƒtƒ‰ƒO
                if (cABLTRiyoTdkPara2X.p_strHaishiFG.Trim != string.Empty)
                {
                    // ”pŽ~ƒtƒ‰ƒO‚ªÝ’è‚³‚ê‚Ä‚¢‚éê‡
                    if (blnAndFg == true)
                    {
                        // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                        strWhere.Append(" AND ");
                    }

                    switch (cABLTRiyoTdkPara2X.p_strHaishiFG)
                    {
                        case "0":    // —LŒø‚Ì‚Ý
                            {
                                strWhere.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" <> '1' AND ");
                                strWhere.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" <> '2'");
                                break;
                            }

                        case "1":    // ”pŽ~‚Ì‚Ý
                            {
                                strWhere.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" = '1'");
                                break;
                            }

                        case "2":    // Å–Úíœ‚Ì‚Ý
                            {
                                strWhere.Append(ABLtRiyoTdkEntity.HAISHIFG).Append(" = '2'");
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }

                    // AND”»’èƒtƒ‰ƒO‚ðƒZƒbƒg
                    blnAndFg = true;
                }
                else
                {
                }
                // ---------------------------------------------------------------------------------
                // íœƒtƒ‰ƒO
                if (blnAndFg == true)
                {
                    // AND”»’èƒtƒ‰ƒO‚ª"True"‚Ìê‡AAND‹å‚ðƒZƒbƒg
                    strWhere.Append(" AND ");
                    // *—š—ð”Ô† 000010 2024/01/09 C³ŠJŽn
                    // strWhere.Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'")
                    strWhere.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'");
                }
                // *—š—ð”Ô† 000010 2024/01/09 C³I—¹
                else
                {
                    // *—š—ð”Ô† 000010 2024/01/09 C³ŠJŽn
                    // strWhere.Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'")
                    strWhere.Append(ABLtRiyoTdkEntity.TABLE_NAME).Append(".").Append(ABLtRiyoTdkEntity.SAKUJOFG).Append(" <> '1'");
                    // *—š—ð”Ô† 000010 2024/01/09 C³I—¹
                }
                // ---------------------------------------------------------------------------------
                // Å‘åŽæ“¾Œ”
                if (cABLTRiyoTdkPara2X.p_intGetCountMax != 0)
                {
                    m_cfRdbClass.p_intMaxRows = cABLTRiyoTdkPara2X.p_intGetCountMax;
                }
                else
                {
                }

                // SQL•¶Œ‹‡ˆ—
                strSQL.Append(strWhere.ToString());
                strSQL_Conut.Append(strWhere.ToString());

                // ‘SŒŽæ“¾ˆ—
                csLtRiyoTdk_AllCount = m_cfRdbClass.GetDataSet(strSQL_Conut.ToString(), cfUFParameterCollectionClass);

                intAllCount = (int)csLtRiyoTdk_AllCount.Tables(0).Rows(0)(COL_COUNT);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 77337


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(strSQL.ToString, cfUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs DataSet‚ÌŽæ“¾

                                 */
                csLtRiyoTdkEntity = m_csDataSchma.Clone();
                csLtRiyoTdkEntity = m_cfRdbClass.GetDataSet(strSQL.ToString(), csLtRiyoTdkEntity, ABLtRiyoTdkEntity.TABLE_NAME, cfUFParameterCollectionClass, false);

                // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn

                // ŠÇ—î•ñƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaKanriJohoB = new ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigDataClass, m_cfRdbClass);

                // ŠÇ—î•ñi10-46j‚ðŽæ“¾
                strKanriJoho = cABAtenaKanriJohoB.GetHenkyakuFuyoGyomuCD_Param.Trim;
                csHenkyakuFuyoGyomuCDList = new List<string>(strKanriJoho.Split(','));

                csRetLtRiyoTdkEntity = csLtRiyoTdkEntity.Clone();

                if (csHenkyakuFuyoGyomuCDList.Contains(m_cfControlData.m_strBusinessId) == true)
                {
                    // ŠÇ—î•ñi10-46j‚ÉŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚½ê‡‚Í‹¤’Ê”[Å‚Í•s—v

                    switch (cABLTRiyoTdkPara2X.p_strRiyoKB.Trim)
                    {

                        case "":
                        case "1":
                            {
                                // ‹¤’Ê„\„‹¤’Ê”[Å‚Ì—Dæ‡i‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Format("{0},{1},{2},{3}", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "2":
                            {
                                // \„‹¤’Ê‚Ì—Dæ‡
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "3":
                            {
                                // ‹¤’Ê”[Å„‹¤’Ê‚Ì—Dæ‡i‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                strFilter = string.Format("{0}='{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "1");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "4":
                            {
                                // i‚èž‚Ý‚È‚µi‚½‚¾‚µA‹¤’Ê”[Å‚ÍœŠO‚·‚éj
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Empty;
                                break;
                            }

                    }
                }

                else
                {
                    // ŠÇ—î•ñi10-46j‚ÉŠY“–‚·‚é‹Æ–±CD‚ªÝ’è‚³‚ê‚Ä‚¢‚È‚¢ê‡

                    switch (cABLTRiyoTdkPara2X.p_strRiyoKB.Trim)
                    {

                        case "":
                        case "1":
                            {
                                // ‹¤’Ê„\„‹¤’Ê”[Å‚Ì—Dæ‡
                                strFilter = string.Empty;
                                strSort = string.Format("{0},{1},{2},{3}", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "2":
                            {
                                // \„‹¤’Ê‚Ì—Dæ‡
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "3");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "3":
                            {
                                // ‹¤’Ê”[Å„‹¤’Ê‚Ì—Dæ‡
                                strFilter = string.Format("{0}<>'{1}'", ABLtRiyoTdkEntity.RESERVE2.Trim, "2");
                                strSort = string.Format("{0},{1},{2},{3} DESC", ABLtRiyoTdkEntity.JUMINCD, ABLtRiyoTdkEntity.TAXKB, ABLtRiyoTdkEntity.HAISHIFG, ABLtRiyoTdkEntity.RESERVE2.Trim);
                                break;
                            }

                        case "4":
                            {
                                // i‚èž‚Ý‚È‚µ
                                strFilter = string.Empty;
                                strSort = string.Empty;
                                break;
                            }

                    }

                }

                csLtRiyoTdkRow = csLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).Select(strFilter, strSort);

                if (csLtRiyoTdkRow.Length > 0)
                {
                    // Žæ“¾Œ”‚ª0ŒˆÈã‚Ìê‡
                    if (cABLTRiyoTdkPara2X.p_strRiyoKB.Trim == "4")
                    {
                        // ˆø”F—˜—p‹æ•ª"4"‚Ìê‡‚Í‘SŒ•Ô‹p‚·‚éB
                        for (int i = 0, loopTo = csLtRiyoTdkRow.Length - 1; i <= loopTo; i++)
                            csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow[i]);
                    }
                    else
                    {
                        // csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow(0))
                        // ˆø”F—˜—p‹æ•ª‚"4"‚Ìê‡‚ÍAZ–¯ƒR[ƒhAÅ–Ú‹æ•ªA”pŽ~ƒtƒ‰ƒO‚ÌƒuƒŒƒCƒNŽž‚É1Œ•Ô‹p‚·‚éB
                        strBreakKey = "";
                        for (int i = 0, loopTo1 = csLtRiyoTdkRow.Length - 1; i <= loopTo1; i++)
                        {
                            if (strBreakKey != csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString)
                            {
                                csRetLtRiyoTdkEntity.Tables(ABLtRiyoTdkEntity.TABLE_NAME).ImportRow(csLtRiyoTdkRow[i]);
                                strBreakKey = csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.JUMINCD).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.TAXKB).ToString + csLtRiyoTdkRow[i].Item(ABLtRiyoTdkEntity.HAISHIFG).ToString;
                            }
                        }
                    }
                }
                // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 83537


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 83640


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                // Return csLtRiyoTdkEntity
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 84172


                                Input:
                                " + exException.Message + "z")
                                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                                            Throw

                                        End Try

                                        '*—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁŠJŽn

                                 */
                return csRetLtRiyoTdkEntity;
            }

            return default;
            // *—š—ð”Ô† 000009 2020/11/06 ’Ç‰ÁI—¹

        }
        #endregion
        // *—š—ð”Ô† 000003 2009/07/27 ’Ç‰ÁI—¹

        // *—š—ð”Ô† 000001 2008/11/18 ’Ç‰ÁŠJŽn
        #region eLTAX—˜—p“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAX—˜—p“Íƒf[ƒ^’Ç‰Áƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function InsertLTRiyoTdk(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     —˜—p“Íoƒ}ƒXƒ^‚ÉV‹Kƒf[ƒ^‚ð’Ç‰Á‚·‚éB
        // * 
        // * ˆø”         csDataRow As DataRow   : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       ’Ç‰ÁŒ”(Integer)
        // ************************************************************************************************
        public int InsertLTRiyoTdk(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "InsertLTRiyoTdk";                                 // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                               // * corresponds to VS2008 Start 2010/04/16 000006
                                                                                               // Dim csDataColumn As DataColumn                                  ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                               // * corresponds to VS2008 End 2010/04/16 000006
            int intInsCnt;                                        // ’Ç‰ÁŒ”
            string strUpdateDateTime;                                 // ƒVƒXƒeƒ€“ú•t

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strInsertSQL is null | string.IsNullOrEmpty(m_strInsertSQL) | m_cfInsertUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }
                else
                {
                }

                // XV“úŽž‚ÌŽæ“¾
                strUpdateDateTime = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");        // ì¬“úŽž

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABLtRiyoTdkEntity.TANMATSUID) = m_cfControlData.m_strClientId;             // ’[––‚h‚c
                csDataRow(ABLtRiyoTdkEntity.SAKUJOFG) = "0";                                         // íœƒtƒ‰ƒO
                csDataRow(ABLtRiyoTdkEntity.KOSHINCOUNTER) = decimal.Zero;                           // XVƒJƒEƒ“ƒ^
                csDataRow(ABLtRiyoTdkEntity.SAKUSEINICHIJI) = strUpdateDateTime;                     // ì¬“úŽž
                csDataRow(ABLtRiyoTdkEntity.SAKUSEIUSER) = m_cfControlData.m_strUserId;              // ì¬ƒ†[ƒU[
                csDataRow(ABLtRiyoTdkEntity.KOSHINNICHIJI) = strUpdateDateTime;                      // XV“úŽž
                csDataRow(ABLtRiyoTdkEntity.KOSHINUSER) = m_cfControlData.m_strUserId;               // XVƒ†[ƒU[


                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                foreach (UFParameterClass cfParam in m_cfInsertUFParameterCollectionClass)
                    this.m_cfInsertUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLtRiyoTdkEntity.PARAM_PLACEHOLDER.RLength)).ToString();

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
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 87955


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strInsertSQL, m_cfInsertUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intInsCnt = m_cfRdbClass.ExecuteSQL(m_strInsertSQL, m_cfInsertUFParameterCollectionClass)

                                            ' ƒfƒoƒbƒOƒƒOo—Í
                                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                        Catch exAppException As UFAppException
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 88730


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 88833


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 89365


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intInsCnt

                    End Function
                #End Region

                #Region "eLTAX—˜—p“Íƒf[ƒ^XVƒƒ\ƒbƒh"

                 */
            }

            return default;
        }
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAX—˜—p“Íƒf[ƒ^XVƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function UpdateLTRiyoTdk(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     —˜—p“Íoƒ}ƒXƒ^‚Ìƒf[ƒ^‚ðXV‚·‚éB
        // * 
        // * ˆø”         csDataRow As DataRow   : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       XVŒ”(Integer)
        // ************************************************************************************************
        public int UpdateLTRiyoTdk(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "UpdateLTRiyoTdk";                         // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                       // * corresponds to VS2008 Start 2010/04/16 000006
                                                                                       // Dim csDataColumn As DataColumn                          ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                       // * corresponds to VS2008 End 2010/04/16 000006
            int intUpdCnt;                                // XVŒ”

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // SQL‚ªì¬‚³‚ê‚Ä‚¢‚È‚¯‚ê‚Îì¬
                if (m_strUpDateSQL is null | string.IsNullOrEmpty(m_strUpDateSQL) | m_cfUpdateUFParameterCollectionClass is null)
                {
                    CreateSQL(csDataRow);
                }
                else
                {
                }

                // ‹¤’Ê€–Ú‚Ì•ÒW‚ðs‚¤
                csDataRow(ABLtRiyoTdkEntity.TANMATSUID) = m_cfControlData.m_strClientId;                                 // ’[––‚h‚c
                csDataRow(ABLtRiyoTdkEntity.KOSHINCOUNTER) = (decimal)csDataRow(ABLtRiyoTdkEntity.KOSHINCOUNTER) + 1m;       // XVƒJƒEƒ“ƒ^
                csDataRow(ABLtRiyoTdkEntity.KOSHINNICHIJI) = m_cfRdbClass.GetSystemDate.ToString("yyyyMMddHHmmssfff");   // XV“úŽž
                csDataRow(ABLtRiyoTdkEntity.KOSHINUSER) = m_cfControlData.m_strUserId;                                   // XVƒ†[ƒU[

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚ÖXVs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfUpdateUFParameterCollectionClass)
                {
                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABLtRiyoTdkEntity.PREFIX_KEY.RLength) == ABLtRiyoTdkEntity.PREFIX_KEY)
                    {
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLtRiyoTdkEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                    else
                    {
                        // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ö’l‚ÌÝ’è
                        this.m_cfUpdateUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLtRiyoTdkEntity.PARAM_PLACEHOLDER.RLength), DataRowVersion.Current).ToString();
                    }
                }

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
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 92990


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intUpdCnt = m_cfRdbClass.ExecuteSQL(m_strUpDateSQL, m_cfUpdateUFParameterCollectionClass)

                                            ' ƒfƒoƒbƒOƒƒOo—Í
                                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                        Catch exAppException As UFAppException
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 93765


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 93868


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94400


                Input:
                " + exException.Message + "z")

                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intUpdCnt

                    End Function
                #End Region

                #Region " SQL•¶‚Ìì¬"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼   SQL•¶‚Ìì¬
                    '* 
                    '* \•¶         Private Sub CreateSQL(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\@@     INSERT, UPDATE‚ÌŠeSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”         csDataRow As DataRow :
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 94941


                Input:
                 XV‘ÎÛ‚Ìs

                 */
            }

            return default;
        }
        // * 
        // * –ß‚è’l       ‚È‚µ
        // ************************************************************************************************
        private void CreateSQL(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "CreateSQL";
            UFParameterClass cfUFParameterClass;                  // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
            string strInsertColumn;                               // ’Ç‰ÁSQL•¶€–Ú•¶Žš—ñ
            string strInsertParam;                                // ’Ç‰ÁSQL•¶ƒpƒ‰ƒ[ƒ^•¶Žš—ñ
            var strWhere = new StringBuilder();                           // XVíœSQL•¶Where•¶•¶Žš—ñ

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // INSERT SQL•¶‚Ìì¬
                m_strInsertSQL = "INSERT INTO " + ABLtRiyoTdkEntity.TABLE_NAME + " ";
                strInsertColumn = "";
                strInsertParam = "";

                // UPDATE SQL•¶‚Ìì¬
                m_strUpDateSQL = "UPDATE " + ABLtRiyoTdkEntity.TABLE_NAME + " SET ";

                // UPDATE Where•¶ì¬
                strWhere.Append(" WHERE ");
                strWhere.Append(ABLtRiyoTdkEntity.NOZEIID);
                strWhere.Append(" = ");
                strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.NOZEIID);
                strWhere.Append(" AND ");
                strWhere.Append(ABLtRiyoTdkEntity.RCPTSHICHOSONCD);
                strWhere.Append(" = ");
                strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.RCPTSHICHOSONCD);
                strWhere.Append(" AND ");
                strWhere.Append(ABLtRiyoTdkEntity.TAXKB);
                strWhere.Append(" = ");
                strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.TAXKB);
                strWhere.Append(" AND ");
                strWhere.Append(ABLtRiyoTdkEntity.KOSHINCOUNTER);
                strWhere.Append(" = ");
                strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.KOSHINCOUNTER);

                // SELECT ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfInsertUFParameterCollectionClass = new UFParameterCollectionClass();

                // UPDATE ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                m_cfUpdateUFParameterCollectionClass = new UFParameterCollectionClass();

                // ƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚Ìì¬
                foreach (DataColumn csDataColumn in csDataRow.Table.Columns)
                {
                    cfUFParameterClass = new UFParameterClass();

                    // INSERT SQL•¶‚Ìì¬
                    strInsertColumn += csDataColumn.ColumnName + ", ";
                    strInsertParam += ABLtRiyoTdkEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                    // UPDATE SQL•¶‚Ìì¬
                    m_strUpDateSQL += csDataColumn.ColumnName + " = " + ABLtRiyoTdkEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName + ", ";

                    // INSERT ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfInsertUFParameterCollectionClass.Add(cfUFParameterClass);

                    // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                    cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PARAM_PLACEHOLDER + csDataColumn.ColumnName;
                    m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

                }

                // INSERT SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                strInsertColumn = strInsertColumn.Trim();
                strInsertColumn = strInsertColumn.Trim(",");
                strInsertParam = strInsertParam.Trim();
                strInsertParam = strInsertParam.Trim(",");
                m_strInsertSQL += "(" + strInsertColumn + ")" + " VALUES (" + strInsertParam + ")";

                // UPDATE SQL•¶‚ÌƒgƒŠƒ~ƒ“ƒO
                m_strUpDateSQL = m_strUpDateSQL.Trim();
                m_strUpDateSQL = m_strUpDateSQL.Trim(",");

                // UPDATE SQL•¶‚ÉWHERE‹å‚Ì’Ç‰Á
                m_strUpDateSQL += strWhere.ToString();

                // UPDATE ƒRƒŒƒNƒVƒ‡ƒ“‚ÉƒL[î•ñ‚ð’Ç‰Á
                // ”[ÅŽÒID
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.NOZEIID;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // Žó•tŽs’¬‘ºº°ÄÞ
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.RCPTSHICHOSONCD;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // Å–Ú‹æ•ª
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.TAXKB;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);
                // XVƒJƒEƒ“ƒ^
                cfUFParameterClass = new UFParameterClass();
                cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.KOSHINCOUNTER;
                m_cfUpdateUFParameterCollectionClass.Add(cfUFParameterClass);

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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 100751


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 100854


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 101386


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try
                    End Sub
                #End Region
                    '*—š—ð”Ô† 000001 2008/11/18 ’Ç‰ÁI—¹

                 */
            }
        }

        // *—š—ð”Ô† 000005 2010/02/22 ’Ç‰ÁŠJŽn
        #region eLTAX—˜—p“
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼   eLTAX—˜—p“Íƒf[ƒ^íœ(•¨—)ƒƒ\ƒbƒh
        // * 
        // * \•¶         Public Function DeleteLTRiyoTdk(ByVal csDataRow As DataRow) As Integer
        // * 
        // * ‹@”\@@     —˜—p“Íoƒ}ƒXƒ^‚©‚çŠY“–ƒf[ƒ^‚ð•¨—íœ‚·‚éB
        // * 
        // * ˆø”         csDataRow As DataRow   : —˜—p“Íƒf[ƒ^(ABeLTAXRiyoTdk)
        // * 
        // * –ß‚è’l       íœŒ”(Integer)
        // ************************************************************************************************
        public int DeleteLTRiyoTdk(DataRow csDataRow)
        {
            const string THIS_METHOD_NAME = "DeleteLTRiyoTdk";                                 // ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                                                                                               // * corresponds to VS2008 Start 2010/04/16 000006
                                                                                               // Dim csDataColumn As DataColumn                                  ' ƒf[ƒ^ƒJƒ‰ƒ€
                                                                                               // * corresponds to VS2008 End 2010/04/16 000006
            int intDelCnt;                                        // íœŒ”
                                                                  // * corresponds to VS2008 Start 2010/04/16 000006
                                                                  // Dim strUpdateDateTime As String                                 ' ƒVƒXƒeƒ€“ú•t
                                                                  // * corresponds to VS2008 End 2010/04/16 000006

            try
            {
                // ƒfƒoƒbƒOƒƒOo—Í
                m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // íœ—p‚Ìƒpƒ‰ƒ[ƒ^•tDELETE•¶•¶Žš—ñ‚Æƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                if (m_strDeleteSQL is null || string.IsNullOrEmpty(m_strDeleteSQL) || m_cfDeleteUFParameterCollectionClass == null)
                {
                    CreateSQL_Delete(csDataRow);
                }
                else
                {
                }

                // ì¬Ï‚Ý‚Ìƒpƒ‰ƒ[ƒ^‚Öíœs‚©‚ç’l‚ðÝ’è‚·‚éB
                foreach (UFParameterClass cfParam in m_cfDeleteUFParameterCollectionClass)
                {

                    // ƒL[€–Ú‚ÍXV‘O‚Ì’l‚ÅÝ’è
                    if (cfParam.ParameterName.RSubstring(0, ABLtRiyoTdkEntity.PREFIX_KEY.RLength) == ABLtRiyoTdkEntity.PREFIX_KEY)
                    {
                        this.m_cfDeleteUFParameterCollectionClass(cfParam.ParameterName).Value = csDataRow(cfParam.ParameterName.RSubstring(ABLtRiyoTdkEntity.PREFIX_KEY.RLength), DataRowVersion.Original).ToString();
                    }
                }


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
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 104459


                                Input:
                                " + m_cfRdbClass.GetDevelopmentSQLString(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass) + "z")

                                            ' SQL‚ÌŽÀs
                                            intDelCnt = m_cfRdbClass.ExecuteSQL(m_strDeleteSQL, m_cfDeleteUFParameterCollectionClass)


                                            ' ƒfƒoƒbƒOƒƒOo—Í
                                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                        Catch exAppException As UFAppException
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 105235


                Input:
                " + exAppException.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 105338


                                Input:
                                " + exAppException.Message + "z")
                                            ' ƒ[ƒjƒ“ƒO‚ðƒXƒ[‚·‚é

                                 */
                throw;
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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 105870


                Input:
                " + exException.Message + "z")
                            ' ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
                            Throw

                        End Try

                        Return intDelCnt

                    End Function
                #End Region

                #Region "SQL•¶ì¬(•¨—íœ)"
                    '************************************************************************************************
                    '* ƒƒ\ƒbƒh–¼     •¨—íœ—pSQL•¶‚Ìì¬
                    '* 
                    '* \•¶           Private Sub CreateSQL_Delete(ByVal csDataRow As DataRow)
                    '* 
                    '* ‹@”\           •¨—DELETE—p‚ÌSQL‚ðì¬Aƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ðì¬‚·‚é
                    '* 
                    '* ˆø”           csDataRow As DataRow : XV‘ÎÛ‚Ìs
                    '* 
                    '* –ß‚è’l         ‚È‚µ
                    '************************************************************************************************
                    Private Sub CreateSQL_Delete(ByVal csDataRow As DataRow)
                        Const THIS_METHOD_NAME As String = "CreateSQL_Delete"
                        Dim cfUFParameterClass As UFParameterClass              ' ƒpƒ‰ƒ[ƒ^ƒNƒ‰ƒX
                        Dim strWhere As New StringBuilder                       ' WHERE’è‹`

                        Try
                            ' ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                            m_cfLogClass.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                            ' WHERE•¶‚Ìì¬
                            strWhere.Append(" WHERE ")
                            strWhere.Append(ABLtRiyoTdkEntity.NOZEIID)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.NOZEIID)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLtRiyoTdkEntity.RCPTSHICHOSONCD)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.RCPTSHICHOSONCD)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLtRiyoTdkEntity.TAXKB)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.TAXKB)
                            strWhere.Append(" AND ")
                            strWhere.Append(ABLtRiyoTdkEntity.KOSHINCOUNTER)
                            strWhere.Append(" = ")
                            strWhere.Append(ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.KOSHINCOUNTER)

                            ' •¨—DELETE SQL•¶‚Ìì¬
                            m_strDeleteSQL = "DELETE FROM " + ABLtRiyoTdkEntity.TABLE_NAME + strWhere.ToString

                            ' •¨—íœ—pƒpƒ‰ƒ[ƒ^ƒRƒŒƒNƒVƒ‡ƒ“‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                            m_cfDeleteUFParameterCollectionClass = New UFParameterCollectionClass

                            ' •¨—íœ—pƒRƒŒƒNƒVƒ‡ƒ“‚Éƒpƒ‰ƒ[ƒ^‚ð’Ç‰Á
                            ' ”[ÅŽÒID
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.NOZEIID
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Žó•tŽs’¬‘ºº°ÄÞ
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.RCPTSHICHOSONCD
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' Å–Ú‹æ•ª
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.TAXKB
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)
                            ' XVƒJƒEƒ“ƒ^
                            cfUFParameterClass = New UFParameterClass
                            cfUFParameterClass.ParameterName = ABLtRiyoTdkEntity.PREFIX_KEY + ABLtRiyoTdkEntity.KOSHINCOUNTER
                            m_cfDeleteUFParameterCollectionClass.Add(cfUFParameterClass)

                            ' ƒfƒoƒbƒOI—¹ƒƒOo—Í
                            m_cfLogClass.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                        Catch objAppExp As UFAppException
                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í
                            m_cfLogClass.WarningWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒ[ƒjƒ“ƒOƒR[ƒh:" + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:" + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLogClass.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + _
                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw
                        End Try

                    End Sub
                #End Region
                    '*—š—ð”Ô† 000005 2010/02/22 ’Ç‰ÁI—¹

                #End Region

                End Class

                 */
            }

            return default;
        }
    }
}