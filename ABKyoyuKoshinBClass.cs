// ************************************************************************************************
// * ‹Æ–±–¼          ˆ¶–¼ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼        ‹¤—LXV‚a(ABKyoyuKoshinBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯@ì¬ŽÒ   2003/06/06@‘ê‘ò@‹Ô–ç
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 2004/05/17  000001      ‹¤—LXVˆ—ƒƒ\ƒbƒh‚ÉˆÙ“®“úŽž‚ðˆø”‚Æ‚µ‚Ä’Ç‰Á
// * 2004/05/17  000002      ’¼‹ßˆÙ“®”NŒŽ“ú‚ÉˆÙ“®“úŽž‚ðŠi”[‚ÉC³
// * 2006/03/27  000003      ƒ[ƒNƒtƒ[˜AŒgƒƒ\ƒbƒh’Ç‰Á
// * 2006/05/31  000004      —ÝÏXVŽž‚ÉˆÙ“®‘Oƒf[ƒ^‚à’Ç‰Á‚·‚é
// * 2006/09/13  000005      XV•û–@‚ð•ÏX‚·‚é
// *                         —š—ðƒf[ƒ^‚ÌŠJŽn`I—¹‚Éˆø”‚ÌˆÙ“®”NŒŽ“ú‚ª“–‚Ä‚Í‚Ü‚Á‚½ƒf[ƒ^ˆÈ~‚ð
// *                         ˆø”‚ÌcABJutogai‚Ì“à—e‚ÅXV‚·‚éB’A‚µŠJŽnEI—¹EˆÙ“®”NŒŽ“ú‚Íœ‚­
// *                         “–‚Ä‚Í‚Ü‚Á‚½ƒf[ƒ^‚ª’¼‹ß‚Ìê‡‚Í’Êí’Ê‚è•ªŠ„‚·‚é(ƒ}ƒ‹ƒS‘ºŽR)
// * 2007/10/11  000006      ˆ¶–¼•ÒWˆ—‚Ì–¢Žg—pƒNƒ‰ƒX(URŠÇ—î•ñƒLƒƒƒbƒVƒ…ƒNƒ‰ƒX)‚ðíœ‚·‚éi”ä‰Ãj
// * 2010/04/16  000007      VS2008‘Î‰ži”ä‰Ãj
// * 2014/12/24  000008      yAB21080z’†ŠÔƒT[ƒo[‚a‚r˜AŒg‹@”\’Ç‰ÁiÎ‡j
// * 2015/01/08  000009      yAB21080z’†ŠÔƒT[ƒo[‚a‚r˜AŒg‹@”\íœiÎ‡j
// ************************************************************************************************
using System;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Densan.Reams.AB.AB000BB
{

    public class ABKyoyuKoshinBClass
    {

        // **
        // * ƒNƒ‰ƒXID’è‹`
        // * 
        private const string THIS_CLASS_NAME = "ABKyoyuKoshinBClass";

        // **
        // * ƒƒ“ƒo•Ï”
        // *  
        private UFControlData m_cfControlData;                // ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^
        private UFConfigDataClass m_cfConfigData;             // ŠÂ‹«î•ñƒf[ƒ^ƒNƒ‰ƒX
        private UFLogClass m_cfLog;                           // ƒƒOo—ÍƒNƒ‰ƒX
        private UFRdbClass m_cfRdb;                           // RDBƒNƒ‰ƒX
        private UFErrorClass m_cfErrorClass;                  // ƒGƒ‰[ˆ—ƒNƒ‰ƒX
        private UFDateClass m_cfDateClass;                    // “ú•tƒNƒ‰ƒX
        private ABNyuryokuParaXClass m_cNyuryokuParaX;        // “ü—Í‰æ–Êƒpƒ‰ƒ[ƒ^
        private ABCommonClass m_cCommonClass = new ABCommonClass();           // CommonƒNƒ‰ƒX

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass
        // * @@                          ByVal csUFRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@        ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l          ‚È‚µ
        // ************************************************************************************************
        public ABKyoyuKoshinBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass)

        {
            // ƒƒ“ƒo•Ï”ƒZƒbƒg
            m_cfControlData = cfControlData;
            m_cfConfigData = cfConfigDataClass;
            m_cfRdb = cfRdbClass;

            // ƒƒOo—ÍƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfLog = new UFLogClass(cfConfigDataClass, cfControlData.m_strBusinessId);

            // “ú•tƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
            m_cfDateClass = new UFDateClass(m_cfConfigData);
        }


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ‹¤—LXVˆ—
        // * 
        // * \•¶           Public Function UpdateKyoyu(ByVal StrJuminCD As String, _
        // *                        @                  ByVal IntKoshinKB As Integer, _
        // *                                            ByVal cABJutogai As DataSet) As Integer
        // * 
        // * ‹@”\@@       ‹¤—Lƒf[ƒ^‚Ì’Ç‰Á‚ðs‚È‚¤B
        // * 
        // * ˆø”           StrJuminCD As String           : Z–¯ƒR[ƒh
        // *                IntKoshinKB As Intege          : XV‹æ•ª
        // * @@@         cABJutogai As DataSet          : Z“oŠOEntity
        // * 
        // * –ß‚è’l         Œ”
        // ************************************************************************************************
        public int UpdateKyoyu(string StrJuminCD, int IntKoshinKB, string StrIdoYMD, DataSet cABJutogai)


        {

            const string THIS_METHOD_NAME = "UpdateKyoyu";    // ƒƒ\ƒbƒh–¼
            UFErrorStruct objErrorStruct;                 // ƒGƒ‰[’è‹`\‘¢‘Ì
            ABJutogaiBClass cJutogaiB;                    // Z“oŠO‚c‚`
            DataSet csJutogaiEntity;                      // Z“oŠODataSet
            DataRow csJutogaiRow;                         // Z“oŠORow
            DataRow csJutogaiRowN;
            ABAtenaBClass cAtenaB;                        // ˆ¶–¼‚c‚`
            var csAtenaEntity = default(DataSet);                        // ˆ¶–¼Entity
            var cAtenaSearchKey = new ABAtenaSearchKey();       // ˆ¶–¼ŒŸõƒL[
            ABAtenaRirekiBClass cAtenaRirekiB;            // ˆ¶–¼—š—ð‚c‚`
            DataSet csAtenaRirekiEntity;                  // ˆ¶–¼—š—ðEntity
            ABAtenaRuisekiBClass cAtenaRuisekiB;          // ˆ¶–¼—ÝÏ‚c‚`
            DataSet csAtenaRuisekiEntity;                 // ˆ¶–¼—ÝÏEntity
            var intUpdataCount = default(int);                       // XVŒ”
            string strSystemDate;                         // ƒVƒXƒeƒ€“ú•t
            DataRow csDataRow;
            // * corresponds to VS2008 Start 2010/04/16 000007
            var cABEnumDefine = new ABEnumDefine();
            // Dim csColumn As DataColumn
            // * corresponds to VS2008 End 2010/04/16 000007
            // *—š—ð”Ô† 000003 2006/03/27 ’Ç‰ÁŠJŽn
            string strKoshinKB;                           // XV‹æ•ª
                                                          // *—š—ð”Ô† 000003 2006/03/27 ’Ç‰ÁI—¹
                                                          // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁŠJŽn
            DataRow[] csRirekiRows;
            DataRow csRirekiCkinRow;
            // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁI—¹
            // * —š—ð”Ô† 000009 2015/01/08 íœŠJŽn
            // '*—š—ð”Ô† 000008 2014/12/24 ’Ç‰ÁŠJŽn
            // Dim cABBSRenkeiB As ABBSRenkeiBClass                ' ’†ŠÔƒT[ƒo[‚a‚r˜AŒgƒrƒWƒlƒXƒNƒ‰ƒX
            // '*—š—ð”Ô† 000008 2014/12/24 ’Ç‰ÁI—¹
            // * —š—ð”Ô† 000009 2015/01/08 íœI—¹

            try
            {

                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // Z“oŠO‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cJutogaiB = new ABJutogaiBClass(m_cfControlData, m_cfConfigData, m_cfRdb);
                // ˆ¶–¼‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cAtenaB = new ABAtenaBClass(m_cfControlData, m_cfConfigData, m_cfRdb);
                // ˆ¶–¼—š—ð‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cAtenaRirekiB = new ABAtenaRirekiBClass(m_cfControlData, m_cfConfigData, m_cfRdb);
                // ˆ¶–¼—ÝÏ‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cAtenaRuisekiB = new ABAtenaRuisekiBClass(m_cfControlData, m_cfConfigData, m_cfRdb);

                // ƒVƒXƒeƒ€“ú•t‚ÌŽæ“¾
                strSystemDate = m_cfRdb.GetSystemDate().ToString("yyyyMMdd");


                // Z“oŠOƒ}ƒXƒ^‚Ì’Ç‰Á‚ðs‚È‚¤
                if (IntKoshinKB == cABEnumDefine.KoshinKB.Insert)
                {
                    intUpdataCount = cJutogaiB.InsertJutogaiB(cABJutogai.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0));
                }
                else
                {
                    csJutogaiEntity = cJutogaiB.GetJutogaiBHoshu(StrJuminCD);

                    // Z“oŠOƒf[ƒ^‚ª‘¶Ý‚µ‚È‚¢ê‡AƒGƒ‰[‚ð”­¶‚·‚é
                    if (csJutogaiEntity.Tables(ABJutogaiEntity.TABLE_NAME).Rows.Count == 0)
                    {
                        m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾iXV‘ÎÛ‚Ìƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚¹‚ñBFZ“oŠOj
                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001040);
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + default
      /* TODO ERROR: Skipped SkippedTokensTrivia
      oŠO", objErrorStruct.m_strErrorCode)
                      End If

                      csJutogaiRow = csJutogaiEntity.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0)
                      csJutogaiRowN = cABJutogai.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0)

                      csJutogaiRow.BeginEdit()

                      'For Each csColumn In csJutogaiRow.Table.Columns
                      '    csJutogaiRow(csColumn.ColumnName) = csJutogaiRowN(csColumn)
                      'Next csColumn
                      'csJutogaiRow = csJutogaiRowN
                      ' Z“oŠO•ÒWˆ—*/
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
       "Z“
        */
        );
                        EditJutogai(ref csJutogaiRow, csJutogaiRowN);

                        csJutogaiRow.EndEdit();

                        intUpdataCount = cJutogaiB.UpdateJutogaiB(csJutogaiEntity.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0));
                        // intUpdataCount = cJutogaiB.UpdateJutogaiB(csJutogaiRow)
                    }

                    // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                    if (!(intUpdataCount == 1))
                    {
                        m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                        // ƒGƒ‰[’è‹`‚ðŽæ“¾iŠù‚É“¯ˆêƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚·BFZ“oŠOj
                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001044);
                        throw new UFAppException(objErrorStruct.m_strErrorMessage + default
          /* TODO ERROR: Skipped SkippedTokensTrivia
          oŠO", objErrorStruct.m_strErrorCode)
                      End If

                      '**
                      '* ˆ¶–¼ƒ}ƒXƒ^XVˆ—
                      '*
                      cAtenaSearchKey.p_strJuminCD = StrJuminCD

                      ' ˆ¶–¼•ÒWˆ—
                      ' V‹Kì¬‚Ìê‡
                      If IntKoshinKB = cABEnumDefine.KoshinKB.Insert Then
                          csAtenaEntity = m_cfRdb.GetTableSchema(ABAtenaEntity.TABLE_NAME)
                      Else
                          ' ˆ¶–¼ƒ}ƒXƒ^‚ðŽæ“¾‚·‚é*/
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
           "Z“
            */
            );
                        // ˆ¶–¼‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                        cAtenaB = new ABAtenaBClass(m_cfControlData, m_cfConfigData, m_cfRdb);
                        csAtenaEntity = cAtenaB.GetAtenaBHoshu(1, cAtenaSearchKey);
                    }

                    EditAtenaJutogai(IntKoshinKB, StrIdoYMD, cABJutogai, ref csAtenaEntity);

                    foreach (DataRow currentCsDataRow in csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows)
                    {
                        csDataRow = currentCsDataRow;

                        if (IntKoshinKB == cABEnumDefine.KoshinKB.Insert)
                        {
                            // ˆ¶–¼ƒ}ƒXƒ^‚Ì’Ç‰Á‚ðs‚È‚¤
                            intUpdataCount = cAtenaB.InsertAtenaB(csDataRow);
                        }
                        else
                        {
                            // ˆ¶–¼ƒ}ƒXƒ^‚ÌXV‚ðs‚È‚¤
                            intUpdataCount = cAtenaB.UpdateAtenaB(csDataRow);
                        }

                        // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                        if (!(intUpdataCount == 1))
                        {
                            m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                            // ƒGƒ‰[’è‹`‚ðŽæ“¾iŠù‚É“¯ˆêƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚·BFˆ¶–¼j
                            objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001044);
                            throw new UFAppException(objErrorStruct.m_strErrorMessage + "ˆ¶–¼", objErrorStruct.m_strErrorCode);
                        }
                    }

                    // **
                    // * ˆ¶–¼—š—ðƒ}ƒXƒ^XVˆ—
                    // *

                    // ˆ¶–¼—š—ðƒ}ƒXƒ^‚ðŽæ“¾‚·‚é
                    // *—š—ð”Ô† 000005 2006/09/13 C³ŠJŽn
                    // ’¼‹ß‚¾‚¯‚Å‚È‚­‘SŒŽæ“¾‚·‚é
                    // 'csAtenaRirekiEntity = cAtenaRirekiB.GetAtenaRBHoshu(999, cAtenaSearchKey, "99999999", True)
                    csAtenaRirekiEntity = cAtenaRirekiB.GetAtenaRBHoshu(999, cAtenaSearchKey, "", true);

                    // ’¼‹ßƒƒE‚ð‘Þ”ð‚µ‚Ä‚¨‚­
                    csRirekiRows = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Select(ABAtenaRirekiEntity.JUMINJUTOGAIKB + " = '2' AND " + ABAtenaRirekiEntity.RRKED_YMD + " = '99999999'");
                    if (csRirekiRows.Length > 0)
                    {
                        csRirekiCkinRow = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).NewRow();
                        csRirekiCkinRow.ItemArray = csRirekiRows[0].ItemArray;
                    }
                    else
                    {
                        csRirekiCkinRow = default;
                    }
                    // *—š—ð”Ô† 000005 2006/09/13 C³I—¹

                    // ˆ¶–¼—š—ð•ÒWˆ—
                    EditAtenaRireki(StrIdoYMD, csAtenaEntity, ref csAtenaRirekiEntity);

                    // ˆ¶–¼—š—ðƒ}ƒXƒ^‚Ì’Ç‰Á‚ðs‚È‚¤
                    foreach (DataRow currentCsDataRow1 in csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows)
                    {
                        csDataRow = currentCsDataRow1;
                        switch (csDataRow.RowState)
                        {
                            case var @case when @case == DataRowState.Added:
                                {
                                    intUpdataCount = cAtenaRirekiB.InsertAtenaRB(csDataRow);

                                    // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                                    if (!(intUpdataCount == 1))
                                    {
                                        m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                                        // ƒGƒ‰[’è‹`‚ðŽæ“¾iŠù‚É“¯ˆêƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚·BFˆ¶–¼—š—ðj
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001044);
                                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ˆ¶–¼—š—ð", objErrorStruct.m_strErrorCode);
                                    }

                                    break;
                                }
                            case var case1 when case1 == DataRowState.Modified:
                                {
                                    intUpdataCount = cAtenaRirekiB.UpdateAtenaRB(csDataRow);
                                    // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                                    if (!(intUpdataCount == 1))
                                    {
                                        m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                                        // ƒGƒ‰[’è‹`‚ðŽæ“¾iXV‘ÎÛ‚Ìƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚¹‚ñBFˆ¶–¼—š—ðj
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001040);
                                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ˆ¶–¼—š—ð", objErrorStruct.m_strErrorCode);
                                    }

                                    break;
                                }
                        }
                    }

                    // **
                    // * ˆ¶–¼—ÝÏƒ}ƒXƒ^XVˆ—
                    // *

                    // ˆ¶–¼—ÝÏƒ}ƒXƒ^‚ðŽæ“¾‚·‚é
                    csAtenaRuisekiEntity = m_cfRdb.GetTableSchema(ABAtenaRuisekiEntity.TABLE_NAME);

                    // ˆ¶–¼—ÝÏ•ÒWˆ—
                    // *—š—ð”Ô† 000005 2006/09/13 C³ŠJŽn
                    // ‘Þ”ð‚µ‚Ä‚¨‚¢‚½‘€ì‘O‚Ì’¼‹ßƒŒƒR[ƒh‚ðˆø”‚É‰Á‚¦‚é
                    // 'Me.EditAtenaRuiseki(csAtenaRirekiEntity, csAtenaRuisekiEntity)
                    EditAtenaRuiseki(csAtenaRirekiEntity, ref csAtenaRuisekiEntity, csRirekiCkinRow);
                    // *—š—ð”Ô† 000005 2006/09/13 C³I—¹

                    // ˆ¶–¼—ÝÏƒ}ƒXƒ^‚Ì’Ç‰Á‚ðs‚È‚¤
                    foreach (DataRow currentCsDataRow2 in csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).Rows)
                    {
                        csDataRow = currentCsDataRow2;
                        switch (csDataRow.RowState)
                        {
                            case var case2 when case2 == DataRowState.Added:
                                {
                                    intUpdataCount = cAtenaRuisekiB.InsertAtenaRB(csDataRow);

                                    // XVŒ”‚ª‚PŒˆÈŠO‚Ìê‡AƒGƒ‰[‚ð”­¶‚³‚¹‚é
                                    if (!(intUpdataCount == 1))
                                    {
                                        m_cfErrorClass = new UFErrorClass(ABConstClass.THIS_BUSINESSID);
                                        // ƒGƒ‰[’è‹`‚ðŽæ“¾iŠù‚É“¯ˆêƒf[ƒ^‚ª‘¶Ý‚µ‚Ü‚·BFˆ¶–¼—ÝÏj
                                        objErrorStruct = m_cfErrorClass.GetErrorStruct(URErrorClass.URE001044);
                                        throw new UFAppException(objErrorStruct.m_strErrorMessage + "ˆ¶–¼—ÝÏ", objErrorStruct.m_strErrorCode);
                                    }

                                    break;
                                }
                        }

                    }

                    // *—š—ð”Ô† 000003 2006/03/27 ’Ç‰ÁŠJŽn
                    // ˆ—‹æ•ª‚ðŽ‘ŽYÅXV—p‚©‚çƒ[ƒNƒtƒ[˜AŒg—p‚ÉC³‚·‚é
                    switch (IntKoshinKB)
                    {
                        case var case3 when case3 == cABEnumDefine.KoshinKB.Insert:
                            {
                                strKoshinKB = "1";
                                break;
                            }
                        case var case4 when case4 == cABEnumDefine.KoshinKB.Update:
                            {
                                strKoshinKB = "2";
                                break;
                            }
                    }
                    // ƒ[ƒNƒtƒ[˜AŒgˆ—‚ÌŒÄ‚Ño‚µ
                    AtenaDataReplicaKoshin((string)cABJutogai.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0).Item(ABJutogaiEntity.JUMINCD), (string)cABJutogai.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0).Item(ABJutogaiEntity.STAICD), IntKoshinKB.ToString());
                    // *—š—ð”Ô† 000003 2006/03/27 ’Ç‰ÁI—¹

                    // * —š—ð”Ô† 000009 2015/01/08 íœŠJŽn
                    // '*—š—ð”Ô† 000008 2014/12/24 ’Ç‰ÁŠJŽn
                    // ' ’†ŠÔƒT[ƒo[‚a‚r˜AŒgƒrƒWƒlƒXƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    // cABBSRenkeiB = New ABBSRenkeiBClass(m_cfControlData, m_cfConfigData, m_cfRdb)

                    // ' ’†ŠÔƒT[ƒo[‚a‚r˜AŒg‚ÌŽÀs
                    // cABBSRenkeiB.ExecRenkei(StrJuminCD)
                    // '*—š—ð”Ô† 000008 2014/12/24 ’Ç‰ÁI—¹
                    // * —š—ð”Ô† 000009 2015/01/08 íœI—¹

                    // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                    m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
                }
            }

            catch (UFRdbDeadLockException objRdbDeadLockExp)   // ƒfƒbƒhƒƒbƒN‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17849


                Input:
                " + objRdbDeadLockExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 17955


                                Input:
                                " + objRdbDeadLockExp.Message + "z")
                                            ' UFAppException‚ðƒXƒ[‚·‚é
                                            Throw New UFAppException(objRdbDeadLockExp.Message, objRdbDeadLockExp.p_intErrorCode, objRdbDeadLockExp)

                                        Catch objUFRdbUniqueExp As UFRdbUniqueException     ' ˆêˆÓ§–ñˆá”½‚ðƒLƒƒƒbƒ`

                                 */
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18608


                Input:
                " + objUFRdbUniqueExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 18714


                                Input:
                                " + objUFRdbUniqueExp.Message + "z")
                                            ' UFAppException‚ðƒXƒ[‚·‚é
                                            Throw New UFAppException(objUFRdbUniqueExp.Message, objUFRdbUniqueExp.p_intErrorCode, objUFRdbUniqueExp)

                                        Catch objRdbTimeOutExp As UFRdbTimeOutException    ' UFRdbTimeOutException‚ðƒLƒƒƒbƒ`
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19375


                Input:
                " + objRdbTimeOutExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 19480


                                Input:
                                " + objRdbTimeOutExp.Message + "z")
                                            ' UFAppException‚ðƒXƒ[‚·‚é
                                            Throw New UFAppException(objRdbTimeOutExp.Message, objRdbTimeOutExp.p_intErrorCode, objRdbTimeOutExp)

                                        Catch objAppExp As UFAppException    ' UFAppException‚ðƒLƒƒƒbƒ`
                                            ' ƒ[ƒjƒ“ƒOƒƒOo—Í

                                 */
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20116


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20214


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20479


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 20564


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return intUpdataCount;

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     Z“oŠO•ÒWˆ—
        // * 
        // * \•¶           Public Sub EditJutogai(ByVal cfControlData As UFControlData,
        // * @@                               ByVal cNyuryokuParaX As ABNyuryokuParaXClass) As DataSet
        // * 
        // * ‹@”\@@       “ü—Í‰æ–Êƒf[ƒ^‚æ‚èZ“oŠOEntity‚ð’Ç‰ÁE•ÒW‚·‚é
        // * 
        // * ˆø”           csJutogaiEntity As DataSet              : Z“oŠOEntity
        // * @@           cNyuryokuParaX As ABNyuryokuParaXClass  : ŒÂl“ü—Íƒf[ƒ^
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void EditJutogai(ref DataRow csJutogaiRow, DataRow csJutogaiRowN)
        {
            const string THIS_METHOD_NAME = "EditJutogai";    // ƒƒ\ƒbƒh–¼
            var cABJutogaiIF = new ABJutogaiEntity();                   // Z“oŠOƒ}ƒXƒ^ƒRƒ“ƒXƒgƒNƒ‰ƒX

            try
            {
                // **
                // * •ÒWˆ—
                // *
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // Žs’¬‘ºƒR[ƒh
                csJutogaiRow(cABJutogaiIF.SHICHOSONCD) = csJutogaiRowN(cABJutogaiIF.SHICHOSONCD);
                // ‹ŒŽs’¬‘ºƒR[ƒh
                csJutogaiRow(cABJutogaiIF.KYUSHICHOSONCD) = csJutogaiRowN(cABJutogaiIF.KYUSHICHOSONCD);
                // ¢‘ÑƒR[ƒh
                csJutogaiRow(cABJutogaiIF.STAICD) = csJutogaiRowN(cABJutogaiIF.STAICD);
                // ˆ¶–¼ƒf[ƒ^‹æ•ª
                csJutogaiRow(cABJutogaiIF.ATENADATAKB) = csJutogaiRowN(cABJutogaiIF.ATENADATAKB);
                // ˆ¶–¼ƒf[ƒ^Ží•Ê
                csJutogaiRow(cABJutogaiIF.ATENADATASHU) = csJutogaiRowN(cABJutogaiIF.ATENADATASHU);
                // ŒŸõ—pƒJƒi©–¼
                csJutogaiRow(cABJutogaiIF.SEARCHKANASEIMEI) = csJutogaiRowN(cABJutogaiIF.SEARCHKANASEIMEI);
                // ŒŸõ—pƒJƒi©
                csJutogaiRow(cABJutogaiIF.SEARCHKANASEI) = csJutogaiRowN(cABJutogaiIF.SEARCHKANASEI);
                // ŒŸõ—pƒJƒi–¼
                csJutogaiRow(cABJutogaiIF.SEARCHKANAMEI) = csJutogaiRowN(cABJutogaiIF.SEARCHKANAMEI);
                // ƒJƒi–¼Ì1
                csJutogaiRow(cABJutogaiIF.KANAMEISHO1) = csJutogaiRowN(cABJutogaiIF.KANAMEISHO1);
                // Š¿Žš–¼Ì1
                csJutogaiRow(cABJutogaiIF.KANJIMEISHO1) = csJutogaiRowN(cABJutogaiIF.KANJIMEISHO1);
                // ƒJƒi–¼Ì2
                csJutogaiRow(cABJutogaiIF.KANAMEISHO2) = csJutogaiRowN(cABJutogaiIF.KANAMEISHO2);
                // Š¿Žš–¼Ì2
                csJutogaiRow(cABJutogaiIF.KANJIMEISHO2) = csJutogaiRowN(cABJutogaiIF.KANJIMEISHO2);
                // ¶”NŒŽ“ú
                csJutogaiRow(cABJutogaiIF.UMAREYMD) = csJutogaiRowN(cABJutogaiIF.UMAREYMD);
                // ¶˜a—ï”NŒŽ“ú
                csJutogaiRow(cABJutogaiIF.UMAREWMD) = csJutogaiRowN(cABJutogaiIF.UMAREWMD);
                // «•ÊƒR[ƒh
                csJutogaiRow(cABJutogaiIF.SEIBETSUCD) = csJutogaiRowN(cABJutogaiIF.SEIBETSUCD);
                // «•Ê
                csJutogaiRow(cABJutogaiIF.SEIBETSU) = csJutogaiRowN(cABJutogaiIF.SEIBETSU);
                // ‘±•¿ƒR[ƒh
                csJutogaiRow(cABJutogaiIF.ZOKUGARACD) = csJutogaiRowN(cABJutogaiIF.ZOKUGARACD);
                // ‘±•¿
                csJutogaiRow(cABJutogaiIF.ZOKUGARA) = csJutogaiRowN(cABJutogaiIF.ZOKUGARA);
                // ‘æ2‘±•¿ƒR[ƒh
                csJutogaiRow(cABJutogaiIF.DAI2ZOKUGARACD) = csJutogaiRowN(cABJutogaiIF.DAI2ZOKUGARACD);
                // ‘æ2‘±•¿
                csJutogaiRow(cABJutogaiIF.DAI2ZOKUGARA) = csJutogaiRowN(cABJutogaiIF.DAI2ZOKUGARA);
                // Š¿Žš–@l‘ã•\ŽÒŽ–¼
                csJutogaiRow(cABJutogaiIF.KANJIHJNDAIHYOSHSHIMEI) = csJutogaiRowN(cABJutogaiIF.KANJIHJNDAIHYOSHSHIMEI);
                // ”Ä—p‹æ•ª1
                csJutogaiRow(cABJutogaiIF.HANYOKB1) = csJutogaiRowN(cABJutogaiIF.HANYOKB1);
                // Š¿Žš–@lŒ`‘Ô
                csJutogaiRow(cABJutogaiIF.KANJIHJNKEITAI) = csJutogaiRowN(cABJutogaiIF.KANJIHJNKEITAI);
                // ŒÂl–@l‹æ•ª
                csJutogaiRow(cABJutogaiIF.KJNHJNKB) = csJutogaiRowN(cABJutogaiIF.KJNHJNKB);
                // ”Ä—p‹æ•ª2
                csJutogaiRow(cABJutogaiIF.HANYOKB2) = csJutogaiRowN(cABJutogaiIF.HANYOKB2);
                // ŠÇ“àŠÇŠO‹æ•ª
                csJutogaiRow(cABJutogaiIF.KANNAIKANGAIKB) = csJutogaiRowN(cABJutogaiIF.KANNAIKANGAIKB);
                // ‰Æ‰®•~‹æ•ª
                csJutogaiRow(cABJutogaiIF.KAOKUSHIKIKB) = csJutogaiRowN(cABJutogaiIF.KAOKUSHIKIKB);
                // ”õlÅ–Ú
                csJutogaiRow(cABJutogaiIF.BIKOZEIMOKU) = csJutogaiRowN(cABJutogaiIF.BIKOZEIMOKU);
                // —X•Ö”Ô†
                csJutogaiRow(cABJutogaiIF.YUBINNO) = csJutogaiRowN(cABJutogaiIF.YUBINNO);
                // ZŠƒR[ƒh
                csJutogaiRow(cABJutogaiIF.JUSHOCD) = csJutogaiRowN(cABJutogaiIF.JUSHOCD);
                // ZŠ
                csJutogaiRow(cABJutogaiIF.JUSHO) = csJutogaiRowN(cABJutogaiIF.JUSHO);
                // ”Ô’nƒR[ƒh1
                csJutogaiRow(cABJutogaiIF.BANCHICD1) = csJutogaiRowN(cABJutogaiIF.BANCHICD1);
                // ”Ô’nƒR[ƒh2
                csJutogaiRow(cABJutogaiIF.BANCHICD2) = csJutogaiRowN(cABJutogaiIF.BANCHICD2);
                // ”Ô’nƒR[ƒh3
                csJutogaiRow(cABJutogaiIF.BANCHICD3) = csJutogaiRowN(cABJutogaiIF.BANCHICD3);
                // ”Ô’n
                csJutogaiRow(cABJutogaiIF.BANCHI) = csJutogaiRowN(cABJutogaiIF.BANCHI);
                // Œ¨‘ƒtƒ‰ƒO
                csJutogaiRow(cABJutogaiIF.KATAGAKIFG) = csJutogaiRowN(cABJutogaiIF.KATAGAKIFG);
                // Œ¨‘ƒR[ƒh
                csJutogaiRow(cABJutogaiIF.KATAGAKICD) = csJutogaiRowN(cABJutogaiIF.KATAGAKICD);
                // Œ¨‘
                csJutogaiRow(cABJutogaiIF.KATAGAKI) = csJutogaiRowN(cABJutogaiIF.KATAGAKI);
                // ˜A—æ1
                csJutogaiRow(cABJutogaiIF.RENRAKUSAKI1) = csJutogaiRowN(cABJutogaiIF.RENRAKUSAKI1);
                // ˜A—æ2
                csJutogaiRow(cABJutogaiIF.RENRAKUSAKI2) = csJutogaiRowN(cABJutogaiIF.RENRAKUSAKI2);
                // s­‹æƒR[ƒh
                csJutogaiRow(cABJutogaiIF.GYOSEIKUCD) = csJutogaiRowN(cABJutogaiIF.GYOSEIKUCD);
                // s­‹æ–¼
                csJutogaiRow(cABJutogaiIF.GYOSEIKUMEI) = csJutogaiRowN(cABJutogaiIF.GYOSEIKUMEI);
                // ’n‹æƒR[ƒh1
                csJutogaiRow(cABJutogaiIF.CHIKUCD1) = csJutogaiRowN(cABJutogaiIF.CHIKUCD1);
                // ’n‹æ–¼1
                csJutogaiRow(cABJutogaiIF.CHIKUMEI1) = csJutogaiRowN(cABJutogaiIF.CHIKUMEI1);
                // ’n‹æƒR[ƒh2
                csJutogaiRow(cABJutogaiIF.CHIKUCD2) = csJutogaiRowN(cABJutogaiIF.CHIKUCD2);
                // ’n‹æ–¼2
                csJutogaiRow(cABJutogaiIF.CHIKUMEI2) = csJutogaiRowN(cABJutogaiIF.CHIKUMEI2);
                // ’n‹æƒR[ƒh3
                csJutogaiRow(cABJutogaiIF.CHIKUCD3) = csJutogaiRowN(cABJutogaiIF.CHIKUCD3);
                // ’n‹æ–¼3
                csJutogaiRow(cABJutogaiIF.CHIKUMEI3) = csJutogaiRowN(cABJutogaiIF.CHIKUMEI3);
                // “o˜^ˆÙ“®”NŒŽ“ú
                csJutogaiRow(cABJutogaiIF.TOROKUIDOYMD) = csJutogaiRowN(cABJutogaiIF.TOROKUIDOYMD);
                // “o˜^Ž–—RƒR[ƒh
                csJutogaiRow(cABJutogaiIF.TOROKUJIYUCD) = csJutogaiRowN(cABJutogaiIF.TOROKUJIYUCD);
                // ÁœˆÙ“®”NŒŽ“ú
                csJutogaiRow(cABJutogaiIF.SHOJOIDOYMD) = csJutogaiRowN(cABJutogaiIF.SHOJOIDOYMD);
                // ÁœŽ–—RƒR[ƒh
                csJutogaiRow(cABJutogaiIF.SHOJOJIYUCD) = csJutogaiRowN(cABJutogaiIF.SHOJOJIYUCD);
                // ƒŠƒU[ƒu
                csJutogaiRow(cABJutogaiIF.RESERVE) = csJutogaiRowN(cABJutogaiIF.RESERVE);

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }


            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 27974


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28072


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28337


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 28422


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼•ÒWˆ—
        // * 
        // * \•¶           Public Sub EditAtenaJutogai(ByVal csJutogaiEntity As DataSet, _
        // * @@                             ByVal csAtenaEntity As DataSet)
        // * 
        // * ‹@”\@@       Z“oŠOEntity‚æ‚èˆ¶–¼Entity‚ð’Ç‰ÁE•ÒW‚·‚é
        // * 
        // * ˆø”           csJutogaiEntity As DataSet  : Z“oŠO(ABJutogaiEntity)
        // * @@           csAtenaEntity   As DataSet  : ˆ¶–¼(ABAtenaEntity)
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void EditAtenaJutogai(int IntKoshinKB, string StrIdoYMD, DataSet csJutogaiEntity, ref DataSet csAtenaEntity)


        {
            const string THIS_METHOD_NAME = "EditAtenaJutogai";
            // * corresponds to VS2008 Start 2010/04/16 000007
            // Dim objErrorStruct As UFErrorStruct                 ' ƒGƒ‰[’è‹`\‘¢‘Ì
            // Dim cuCityInfo As USSCityInfoClass                  ' Žs’¬‘ºî•ñŠÇ—ƒNƒ‰ƒX
            // * corresponds to VS2008 End 2010/04/16 000007
            DataRow csRow;
            // * corresponds to VS2008 Start 2010/04/16 000007
            // Dim csDataSet As DataSet
            // Dim csColumn As DataColumn
            // * corresponds to VS2008 End 2010/04/16 000007
            string strSystemDate;                         // ƒVƒXƒeƒ€“ú•t
            DataRow csJutogaiRow;                         // Z“oŠODataRow
            ABIdoJiyuBClass cIdoJiyuB;                    // ˆÙ“®Ž–—R‚aƒNƒ‰ƒX
                                                          // * —š—ð”Ô† 000006 2007/10/11 íœŠJŽn
                                                          // * —š—ð”Ô† 000002 2003/08/22 C³ŠJŽn
                                                          // Dim cuKanriJohoB As URKANRIJOHOBClass               ' ŠÇ—î•ñ‚aƒNƒ‰ƒX
                                                          // Dim cuKanriJohoB As URKANRIJOHOCacheBClass          ' ŠÇ—î•ñ‚aƒNƒ‰ƒX(ƒLƒƒƒbƒVƒ…‘Î‰ž”Å)
                                                          // * —š—ð”Ô† 000002 2003/08/22 C³I—¹
                                                          // Dim emKensakShimei As FrnKensakuShimeiType          ' ŠO‘lŒŸõ—pŽ–¼
                                                          // * —š—ð”Ô† 000006 2007/10/11 íœI—¹
                                                          // * corresponds to VS2008 Start 2010/04/16 000007
            var cABEnumDefine = new ABEnumDefine();
            // * corresponds to VS2008 End 2010/04/16 000007
            var cAtenaSearchKey = new ABAtenaSearchKey();       // ˆ¶–¼ŒŸõƒL[
                                                                // * corresponds to VS2008 Start 2010/04/16 000007
                                                                // Dim cAtenaB As ABAtenaBClass                        'ˆ¶–¼‚c‚`
                                                                // * corresponds to VS2008 End 2010/04/16 000007


            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ˆÙ“®Ž–—R‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cIdoJiyuB = new ABIdoJiyuBClass(m_cfControlData, m_cfConfigData);

                // ‚t‚qŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                // * —š—ð”Ô† 000006 2007/10/11 íœŠJŽn
                // * —š—ð”Ô† 000002 2003/08/22 C³ŠJŽn
                // cuKanriJohoB = New URKANRIJOHOBClass(m_cfControlData, m_cfConfigData, m_cfRdb)
                // cuKanriJohoB = New URKANRIJOHOCacheBClass(m_cfControlData, m_cfConfigData, m_cfRdb)
                // * —š—ð”Ô† 000002 2003/08/22 C³I—¹
                // * —š—ð”Ô† 000006 2007/10/11 íœŠJŽn

                // “ú•tƒNƒ‰ƒX‚Ì•K—v‚ÈÝ’è‚ðs‚¤
                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;

                // * —š—ð”Ô† 000006 2007/10/11 íœŠJŽn
                // ' ‚t‚qŠO‘lŒŸõ—pŽ–¼‚ðŽæ“¾‚·‚é   •Û—¯
                // emKensakShimei = cuKanriJohoB.GetFrn_KensakuShimei_Param
                // * —š—ð”Ô† 000006 2007/10/11 íœŠJŽn

                // Z“oŠOƒf[ƒ^Row
                csJutogaiRow = csJutogaiEntity.Tables(ABJutogaiEntity.TABLE_NAME).Rows(0);

                if (IntKoshinKB == cABEnumDefine.KoshinKB.Insert)
                {
                    csRow = csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).NewRow;
                    // DataRow‚Ì‰Šú‰»
                    m_cCommonClass.InitColumnValue(csRow);
                }
                else
                {
                    // ˆ¶–¼ƒ}ƒXƒ^‚ðŽæ“¾‚·‚é
                    // ˆ¶–¼‚c‚`ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                    csRow = csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows(0);
                }

                // **
                // * •ÒWˆ—
                // *
                strSystemDate = m_cfRdb.GetSystemDate().ToString("yyyyMMdd");                                        // ƒVƒXƒeƒ€“ú•t

                csRow(ABAtenaEntity.JUMINCD) = csJutogaiRow(ABJutogaiEntity.JUMINCD);                                // Z–¯ƒR[ƒh
                csRow(ABAtenaEntity.SHICHOSONCD) = csJutogaiRow(ABJutogaiEntity.SHICHOSONCD);                        // Žs’¬‘ºƒR[ƒh
                csRow(ABAtenaEntity.KYUSHICHOSONCD) = csJutogaiRow(ABJutogaiEntity.KYUSHICHOSONCD);                  // ‹ŒŽs’¬‘ºƒR[ƒh
                csRow(ABAtenaEntity.JUMINJUTOGAIKB) = "2";                                                           // Z–¯Z“oŠO‹æ•ª
                csRow(ABAtenaEntity.JUMINYUSENIKB) = "0";                                                            // Z–¯—Dæ‹æ•ª
                csRow(ABAtenaEntity.JUTOGAIYUSENKB) = "1";                                                           // Z“oŠO—Dæ‹æ•ª
                csRow(ABAtenaEntity.ATENADATAKB) = csJutogaiRow(ABJutogaiEntity.ATENADATAKB);                        // ˆ¶–¼ƒf[ƒ^‹æ•ª
                csRow(ABAtenaEntity.STAICD) = csJutogaiRow(ABJutogaiEntity.STAICD);                                  // ¢‘ÑƒR[ƒh
                csRow(ABAtenaEntity.ATENADATASHU) = csJutogaiRow(ABJutogaiEntity.ATENADATASHU);                      // ˆ¶–¼ƒf[ƒ^Ží•Ê
                csRow(ABAtenaEntity.HANYOKB1) = csJutogaiRow(ABJutogaiEntity.HANYOKB1);                              // ”Ä—p‹æ•ª1
                csRow(ABAtenaEntity.KJNHJNKB) = csJutogaiRow(ABJutogaiEntity.KJNHJNKB);                              // ŒÂl–@l‹æ•ª
                csRow(ABAtenaEntity.HANYOKB2) = csJutogaiRow(ABJutogaiEntity.HANYOKB2);                              // ”Ä—p‹æ•ª2
                csRow(ABAtenaEntity.KANNAIKANGAIKB) = csJutogaiRow(ABJutogaiEntity.KANNAIKANGAIKB);                  // ŠÇ“àŠÇŠO‹æ•ª
                csRow(ABAtenaEntity.KANAMEISHO1) = csJutogaiRow(ABJutogaiEntity.KANAMEISHO1);                        // ƒJƒi–¼Ì1
                csRow(ABAtenaEntity.KANJIMEISHO1) = csJutogaiRow(ABJutogaiEntity.KANJIMEISHO1);                      // Š¿Žš–¼Ì1
                csRow(ABAtenaEntity.KANAMEISHO2) = csJutogaiRow(ABJutogaiEntity.KANAMEISHO2);                        // ƒJƒi–¼Ì2
                csRow(ABAtenaEntity.KANJIMEISHO2) = csJutogaiRow(ABJutogaiEntity.KANJIMEISHO2);                      // Š¿Žš–¼Ì2
                csRow(ABAtenaEntity.KANJIHJNKEITAI) = csJutogaiRow(ABJutogaiEntity.KANJIHJNKEITAI);                  // Š¿Žš–@lŒ`‘Ô
                csRow(ABAtenaEntity.KANJIHJNDAIHYOSHSHIMEI) = csJutogaiRow(ABJutogaiEntity.KANJIHJNDAIHYOSHSHIMEI);  // Š¿Žš–@l‘ã•\ŽÒŽ–¼
                csRow(ABAtenaEntity.SEARCHKANJIMEISHO) = csJutogaiRow(ABJutogaiEntity.KANJIMEISHO1);             // ŒŸõ—pŠ¿Žš–¼Ì
                csRow(ABAtenaEntity.SEARCHKANASEIMEI) = csJutogaiRow(ABJutogaiEntity.SEARCHKANASEIMEI);              // ŒŸõ—pƒJƒi©–¼
                csRow(ABAtenaEntity.SEARCHKANASEI) = csJutogaiRow(ABJutogaiEntity.SEARCHKANASEI);                    // ŒŸõ—pƒJƒi©
                csRow(ABAtenaEntity.SEARCHKANAMEI) = csJutogaiRow(ABJutogaiEntity.SEARCHKANAMEI);                    // ŒŸõ—pƒJƒi–¼
                csRow(ABAtenaEntity.RRKST_YMD) = StrIdoYMD;                                                      // —š—ðŠJŽn”NŒŽ“ú
                csRow(ABAtenaEntity.RRKED_YMD) = "99999999";                                                         // —š—ðI—¹”NŒŽ“ú
                csRow(ABAtenaEntity.UMAREYMD) = csJutogaiRow(ABJutogaiEntity.UMAREYMD);                              // ¶”NŒŽ“ú
                csRow(ABAtenaEntity.UMAREWMD) = csJutogaiRow(ABJutogaiEntity.UMAREWMD);                              // ¶˜a—ï”NŒŽ“ú
                csRow(ABAtenaEntity.SEIBETSUCD) = csJutogaiRow(ABJutogaiEntity.SEIBETSUCD);                          // «•ÊƒR[ƒh
                csRow(ABAtenaEntity.SEIBETSU) = csJutogaiRow(ABJutogaiEntity.SEIBETSU);                              // «•Ê
                csRow(ABAtenaEntity.ZOKUGARACD) = csJutogaiRow(ABJutogaiEntity.ZOKUGARACD);                          // ‘±•¿ƒR[ƒh
                csRow(ABAtenaEntity.ZOKUGARA) = csJutogaiRow(ABJutogaiEntity.ZOKUGARA);                              // ‘±•¿
                csRow(ABAtenaEntity.DAI2ZOKUGARACD) = csJutogaiRow(ABJutogaiEntity.DAI2ZOKUGARACD);                  // ‘æ2‘±•¿ƒR[ƒh
                csRow(ABAtenaEntity.DAI2ZOKUGARA) = csJutogaiRow(ABJutogaiEntity.DAI2ZOKUGARA);                      // ‘æ2‘±•¿
                csRow(ABAtenaEntity.YUBINNO) = csJutogaiRow(ABJutogaiEntity.YUBINNO);                                // —X•Ö”Ô†
                csRow(ABAtenaEntity.JUSHOCD) = csJutogaiRow(ABJutogaiEntity.JUSHOCD);                                // ZŠƒR[ƒh
                csRow(ABAtenaEntity.JUSHO) = csJutogaiRow(ABJutogaiEntity.JUSHO);                                    // ZŠ
                csRow(ABAtenaEntity.BANCHICD1) = csJutogaiRow(ABJutogaiEntity.BANCHICD1);                            // ”Ô’nƒR[ƒh1
                csRow(ABAtenaEntity.BANCHICD2) = csJutogaiRow(ABJutogaiEntity.BANCHICD2);                            // ”Ô’nƒR[ƒh2
                csRow(ABAtenaEntity.BANCHICD3) = csJutogaiRow(ABJutogaiEntity.BANCHICD3);                            // ”Ô’nƒR[ƒh3
                csRow(ABAtenaEntity.BANCHI) = csJutogaiRow(ABJutogaiEntity.BANCHI);                                  // ”Ô’n
                csRow(ABAtenaEntity.KATAGAKIFG) = csJutogaiRow(ABJutogaiEntity.KATAGAKIFG);                          // •û‘ƒtƒ‰ƒO
                csRow(ABAtenaEntity.KATAGAKICD) = csJutogaiRow(ABJutogaiEntity.KATAGAKICD);                          // •û‘ƒR[ƒh
                csRow(ABAtenaEntity.KATAGAKI) = csJutogaiRow(ABJutogaiEntity.KATAGAKI);                              // •û‘
                csRow(ABAtenaEntity.RENRAKUSAKI1) = csJutogaiRow(ABJutogaiEntity.RENRAKUSAKI1);                      // ˜A—æ1
                csRow(ABAtenaEntity.RENRAKUSAKI2) = csJutogaiRow(ABJutogaiEntity.RENRAKUSAKI2);                      // ˜A—æ2
                                                                                                                     // ’¼‹ßˆÙ“®”NŒŽ“ú
                                                                                                                     // m_cfDateClass.p_strDateValue = m_cNyuryokuParaX.p_strCkinIdoYMD
                                                                                                                     // *—š—ð”Ô† 000002 2004/05/17 C³ŠJŽn
                                                                                                                     // csRow(ABAtenaEntity.CKINIDOYMD) = strSystemDate                                                      ' —š—ðŠJŽn”NŒŽ“ú
                csRow(ABAtenaEntity.CKINIDOYMD) = StrIdoYMD;
                // *—š—ð”Ô† 000002 2004/05/17 C³I—¹
                // “o˜^ˆÙ“®”NŒŽ“ú
                csRow(ABAtenaEntity.TOROKUIDOYMD) = csJutogaiRow(ABJutogaiEntity.TOROKUIDOYMD);
                // “o˜^ˆÙ“®˜a—ï”NŒŽ“ú
                m_cfDateClass.p_strDateValue = (string)csJutogaiRow(ABJutogaiEntity.TOROKUIDOYMD);
                csRow(ABAtenaEntity.TOROKUIDOWMD) = m_cfDateClass.p_strWarekiYMD;
                csRow(ABAtenaEntity.TOROKUJIYUCD) = csJutogaiRow(ABJutogaiEntity.TOROKUJIYUCD);                      // “o˜^Ž–—RƒR[ƒh
                csRow(ABAtenaEntity.TOROKUJIYU) = cIdoJiyuB.GetIdoJiyu(csJutogaiRow(ABJutogaiEntity.TOROKUJIYUCD).ToString);     // “o˜^Ž–—R
                csRow(ABAtenaEntity.SHOJOIDOYMD) = csJutogaiRow(ABJutogaiEntity.SHOJOIDOYMD);                        // ÁœˆÙ“®”NŒŽ“ú
                csRow(ABAtenaEntity.SHOJOJIYUCD) = csJutogaiRow(ABJutogaiEntity.SHOJOJIYUCD);                        // ÁœŽ–—RƒR[ƒh
                csRow(ABAtenaEntity.SHOJOJIYU) = cIdoJiyuB.GetIdoJiyu(csJutogaiRow(ABJutogaiEntity.SHOJOJIYUCD).ToString);       // ÁœŽ–—R
                csRow(ABAtenaEntity.GYOSEIKUCD) = csJutogaiRow(ABJutogaiEntity.GYOSEIKUCD);                          // s­‹æƒR[ƒh
                csRow(ABAtenaEntity.GYOSEIKUMEI) = csJutogaiRow(ABJutogaiEntity.GYOSEIKUMEI);                        // s­‹æ–¼
                csRow(ABAtenaEntity.CHIKUCD1) = csJutogaiRow(ABJutogaiEntity.CHIKUCD1);                              // ’n‹æƒR[ƒh1
                csRow(ABAtenaEntity.CHIKUMEI1) = csJutogaiRow(ABJutogaiEntity.CHIKUMEI1);                            // ’n‹æ–¼1
                csRow(ABAtenaEntity.CHIKUCD2) = csJutogaiRow(ABJutogaiEntity.CHIKUCD2);                              // ’n‹æƒR[ƒh2
                csRow(ABAtenaEntity.CHIKUMEI2) = csJutogaiRow(ABJutogaiEntity.CHIKUMEI2);                            // ’n‹æ–¼2
                csRow(ABAtenaEntity.CHIKUCD3) = csJutogaiRow(ABJutogaiEntity.CHIKUCD3);                              // ’n‹æƒR[ƒh3
                csRow(ABAtenaEntity.CHIKUMEI3) = csJutogaiRow(ABJutogaiEntity.CHIKUMEI3);                            // ’n‹æ–¼3
                csRow(ABAtenaEntity.KAOKUSHIKIKB) = csJutogaiRow(ABJutogaiEntity.KAOKUSHIKIKB);                      // ‰Æ‰®•~‹æ•ª
                csRow(ABAtenaEntity.BIKOZEIMOKU) = csJutogaiRow(ABJutogaiEntity.BIKOZEIMOKU);                        // ”õlÅ–Ú

                // V‹Kì¬‚Ìê‡
                if (IntKoshinKB == cABEnumDefine.KoshinKB.Insert)
                {
                    csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Rows.Add(csRow);
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }


            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42192


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42290


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42555


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 42640


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—š—ð•ÒWˆ—
        // * 
        // * \•¶           Public Sub EditAtenaRireki(ByVal csAtenaEntity As DataSet, _
        // * @@                                  ByVal csAtenaRirekiEntity As DataSet)
        // * 
        // * ‹@”\@@       ˆ¶–¼—š—ð‚Ì•ÒW‚ðs‚È‚¤B
        // * 
        // * ˆø”           csAtenaEntity        As DataSet  : ˆ¶–¼(ABAtenaEntity)
        // * @@           csAtenaRirekiEntity  As DataSet  : ˆ¶–¼—š—ð(ABAtenaRirekiEntity)
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        private void EditAtenaRireki(string StrIdoYMD, DataSet csAtenaEntity, ref DataSet csAtenaRirekiEntity)

        {
            const string THIS_METHOD_NAME = "EditAtenaRireki";                    // ƒƒ\ƒbƒh–¼
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000007
                                                                                  // Dim objErrorStruct As UFErrorStruct                                     'ƒGƒ‰[’è‹`\‘¢‘Ì
                                                                                  // * corresponds to VS2008 End 2010/04/16 000007
            DataRow csRow;
            DataRow[] csRows;
            DataColumn csColumn;
            var strSearchKana = new string[5];                                          // ŒŸõ—pƒJƒi
            DataRow csAtenaRow;                                               // ˆ¶–¼DataRow
            DataRow[] csAtenaRows;
            // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁŠJŽn
            string strSystemDate;                                             // ƒVƒXƒeƒ€“ú•t
                                                                              // iž‚ÝEƒ\[ƒg‚ðŽ{‚µ‚½ƒŒƒR[ƒh‚½‚¿
            string strST_YMD;                   // ŠJŽn”NŒŽ“ú
            string strED_YMD;                   // I—¹”NŒŽ“ú
            bool blnHit = false;             // “–‚Ä‚Í‚Ü‚Á‚½‚©‚Ç‚¤‚©
            string strRirekiNO;
            // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // •K—v‚ÈÝ’è‚ðs‚¤
                m_cfDateClass.p_enDateSeparator = UFDateSeparator.None;
                m_cfDateClass.p_enEraType = UFEraType.Number;

                strSystemDate = m_cfRdb.GetSystemDate().ToString("yyyyMMdd");        // ƒVƒXƒeƒ€“ú•t

                // ˆ¶–¼Row‚ðŽæ“¾‚·‚é
                csAtenaRows = csAtenaEntity.Tables(ABAtenaEntity.TABLE_NAME).Select(ABAtenaEntity.JUMINJUTOGAIKB + "='2'");
                csAtenaRow = csAtenaRows[0];

                // ˆ¶–¼—š—ð‚æ‚èV‚µ‚¢Row‚ðŽæ“¾‚·‚é
                csRow = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).NewRow;
                // DataRow‚Ì‰Šú‰»
                m_cCommonClass.InitColumnValue(csRow);

                // **
                // * •ÒWˆ—
                // *

                if (csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Count == 0)
                {
                    // —š—ð”Ô†
                    csRow(ABAtenaRirekiEntity.RIREKINO) = "0001";

                    // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁŠJŽn
                    // ˆ¶–¼ƒ}ƒXƒ^‚ðˆ¶–¼—š—ð‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                    foreach (DataColumn currentCsColumn in csAtenaRow.Table.Columns)
                    {
                        csColumn = currentCsColumn;
                        csRow(csColumn.ColumnName) = csAtenaRow(csColumn);
                    }

                    // ˆ¶–¼—š—ð‚Ö’Ç‰Á‚·‚é
                    csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Add(csRow);
                }
                // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁI—¹
                else
                {
                    // *—š—ð”Ô† 000005 2006/09/13 C³ŠJŽn
                    // * corresponds to VS2008 Start 2010/04/16 000007
                    // 'csRows = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Select("", ABAtenaRirekiEntity.RIREKINO + " DESC")
                    // ''' —š—ðI—¹“ú‚ÉƒVƒXƒeƒ€“ú•t‚Ì‘O“ú‚ðÝ’è‚·‚é
                    // 'm_cfDateClass.p_strDateValue = StrIdoYMD
                    // 'csRows(0).BeginEdit()
                    // 'csRows(0).Item(ABAtenaRirekiEntity.RRKED_YMD) = m_cfDateClass.AddDay(-1)
                    // 'csRows(0).EndEdit()

                    // ''' —š—ð”Ô†
                    // 'csRow(ABAtenaRirekiEntity.RIREKINO) = CType((CType(csRows(0).Item(ABAtenaRirekiEntity.RIREKINO), Integer) + 1), String).PadLeft(4, "0"c)
                    // * corresponds to VS2008 End 2010/04/16 000007

                    // ’Ç‰Á‚·‚éƒŒƒR[ƒh—p‚É—š—ð”Ô†‚ðŽæ“¾‚·‚é
                    csRows = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Select("", ABAtenaRirekiEntity.RIREKINO + " DESC");
                    strRirekiNO = ((int)csRows[0].Item(ABAtenaRirekiEntity.RIREKINO) + 1).ToString().RPadLeft(4, '0');

                    // Z–¯Z“oŠO‹æ•ª="2"‚Å’Šo‚µA—š—ðŠJŽn”NŒŽ“ú¸‡E—š—ð”Ô†¸‡‚Éƒ\[ƒg‚·‚é
                    csRows = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Select(ABAtenaRirekiEntity.JUMINJUTOGAIKB + " = '2'", ABAtenaRirekiEntity.RRKST_YMD + " ASC , " + ABAtenaRirekiEntity.RIREKINO + " ASC");

                    // ‚Ç‚ÌƒŒƒR[ƒh‚ÌŠJŽn`I—¹‚É“–‚Ä‚Í‚Ü‚é‚©‚ð’²‚×‚é
                    foreach (var csRirekiRow in csRows)
                    {
                        // ŠJŽnEI—¹”NŒŽ“ú‚ðŽæ“¾
                        strST_YMD = (string)csRirekiRow.Item(ABAtenaRirekiEntity.RRKST_YMD);
                        strED_YMD = (string)csRirekiRow.Item(ABAtenaRirekiEntity.RRKED_YMD);

                        if (blnHit == false)
                        {
                            // ‚Ü‚¾“–‚Ä‚Í‚Ü‚éƒŒƒR[ƒh‚ªŒ©‚Â‚©‚Á‚Ä‚¢‚È‚¢
                            if (Operators.CompareString(strST_YMD, StrIdoYMD, false) > 0)
                            {
                                // ŠJŽn”NŒŽ“ú„StrIdoYMD

                                blnHit = true;   // ƒtƒ‰ƒO‚ðTrue‚É‚µ‚ÄA‚±‚êˆÈ~‚ÌƒŒƒR[ƒh‚ÌXV‚ðs‚¤
                            }

                            else if (Operators.CompareString(strST_YMD, StrIdoYMD, false) <= 0 && Operators.CompareString(StrIdoYMD, strED_YMD, false) <= 0 && strED_YMD != "99999999")
                            {
                                // ŠJŽn”NŒŽ“ú…StrIdoYMD…I—¹”NŒŽ“ú
                                // ‚©‚Â
                                // I—¹”NŒŽ“ú‚ª"99999999"‚Å‚È‚¢

                                blnHit = true;   // ƒtƒ‰ƒO‚ðTrue‚É‚µ‚ÄA‚±‚êˆÈ~‚ÌƒŒƒR[ƒh‚ÌXV‚ðs‚¤

                            }
                        }

                        // “–‚Ä‚Í‚Ü‚éƒŒƒR[ƒh‚ªŒ©‚Â‚©‚Á‚½ê‡
                        if (blnHit == true)
                        {
                            // ˆ¶–¼ƒ}ƒXƒ^‚ðˆ¶–¼—š—ð‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                            foreach (DataColumn currentCsColumn1 in csAtenaRow.Table.Columns)
                            {
                                csColumn = currentCsColumn1;
                                if (csColumn.ColumnName != ABAtenaRirekiEntity.JUMINCD && csColumn.ColumnName != ABAtenaRirekiEntity.RIREKINO && csColumn.ColumnName != ABAtenaRirekiEntity.RRKST_YMD && csColumn.ColumnName != ABAtenaRirekiEntity.RRKED_YMD && csColumn.ColumnName != ABAtenaRirekiEntity.CKINIDOYMD && csColumn.ColumnName != ABAtenaRirekiEntity.SAKUSEINICHIJI && csColumn.ColumnName != ABAtenaRirekiEntity.SAKUSEIUSER)





                                {
                                    // Z–¯CDE—š—ð”Ô†EŠJŽnEI—¹E’¼‹ßˆÙ“®”NŒŽ“úEì¬“úŽžEì¬ƒ†[ƒUˆÈŠO‚ðã‘‚«‚·‚é

                                    csRirekiRow(csColumn.ColumnName) = csAtenaRow(csColumn);
                                }
                            }
                        }

                    }

                    // “–‚Ä‚Í‚Ü‚éƒŒƒR[ƒh‚ªŒ©‚Â‚©‚ç‚È‚©‚Á‚½ê‡A’¼‹ß‚Å•ªŠ„‚·‚é
                    if (blnHit == false)
                    {
                        // Z–¯Z“oŠO‹æ•ª="2"A—š—ðI—¹”NŒŽ“ú="99999999"‚Å’Šo
                        csRows = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Select(ABAtenaRirekiEntity.JUMINJUTOGAIKB + " = '2' AND " + ABAtenaRirekiEntity.RRKED_YMD + " = '99999999'");
                        if (csRows.Length > 0)
                        {
                            m_cfDateClass.p_strDateValue = StrIdoYMD;
                            // ’¼‹ßƒŒƒR[ƒh‚ÌI—¹”NŒŽ“ú‚ðStrIdoYMD‚Ìˆê“ú‘O‚Ì’l‚ÅXV‚·‚é
                            csRows[0].BeginEdit();
                            csRows[0].Item(ABAtenaRirekiEntity.RRKED_YMD) = m_cfDateClass.AddDay(-1);
                            csRows[0].EndEdit();
                        }

                        // ˆ¶–¼ƒ}ƒXƒ^‚ðˆ¶–¼—š—ð‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                        foreach (DataColumn currentCsColumn2 in csAtenaRow.Table.Columns)
                        {
                            csColumn = currentCsColumn2;
                            csRow(csColumn.ColumnName) = csAtenaRow(csColumn);
                        }

                        // —š—ð”Ô†‚ðÝ’è‚·‚é
                        csRow(ABAtenaRirekiEntity.RIREKINO) = strRirekiNO;

                        // ˆ¶–¼—š—ð‚Ö’Ç‰Á‚·‚é
                        csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Add(csRow);
                    }
                    // *—š—ð”Ô† 000005 2006/09/13 C³I—¹
                }

                // *—š—ð”Ô† 000005 2006/09/13 íœŠJŽn
                // * corresponds to VS2008 Start 2010/04/16 000007
                // ''' ˆ¶–¼ƒ}ƒXƒ^‚ðˆ¶–¼—š—ð‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                // 'For Each csColumn In csAtenaRow.Table.Columns
                // '    csRow(csColumn.ColumnName) = csAtenaRow(csColumn)
                // 'Next csColumn

                // ''' ˆ¶–¼—š—ð‚Ö’Ç‰Á‚·‚é
                // 'csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows.Add(csRow)
                // *—š—ð”Ô† 000005 2006/09/13 íœI—¹
                // * corresponds to VS2008 End 2010/04/16 000007

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }


            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52806


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 52904


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53169


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 53254


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ˆ¶–¼—ÝÏˆ—
        // * 
        // * \•¶           Private Sub EditAtenaRuiseki(ByVal csAtenaRirekiEntity As DataSet, _
        // *                                             ByRef csAtenaRuisekiEntity As DataSet, _
        // *                                             ByVal csRirekiCkinRow As DataRow)
        // * 
        // * ‹@”\@@       ˆ¶–¼—š—ð‚Ì•ÒW‚ðs‚È‚¤B
        // * 
        // * ˆø”           csAtenaRirekiEntity   As DataSet  : ˆ¶–¼—š—ð(ABAtenaRirekiEntity)
        // * @@           csAtenaRuisekiEntity  As DataSet  : ˆ¶–¼—ÝÏ(ABAtenaRuisekiEntity)
        // * @@           csRirekiCkinRow       As DataRow  : Žè‚ð‰Á‚¦‚é‘O‚Ì—š—ð’¼‹ßƒƒE
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        // *—š—ð”Ô† 000005 2006/09/13 C³ŠJŽn
        // 'Private Sub EditAtenaRuiseki(ByVal csAtenaRirekiEntity As DataSet, _
        // 'ByRef csAtenaRuisekiEntity As DataSet)
        private void EditAtenaRuiseki(DataSet csAtenaRirekiEntity, ref DataSet csAtenaRuisekiEntity, DataRow csRirekiCkinRow)

        {
            // *—š—ð”Ô† 000005 2006/09/13 C³I—¹
            const string THIS_METHOD_NAME = "EditAtenaRuiseki";                   // ƒƒ\ƒbƒh–¼
                                                                                  // * corresponds to VS2008 Start 2010/04/16 000007
                                                                                  // Dim objErrorStruct As UFErrorStruct                                     ' ƒGƒ‰[’è‹`\‘¢‘Ì
                                                                                  // * corresponds to VS2008 End 2010/04/16 000007
            DataRow csRow;
            DataRow[] csRows;
            DataColumn csColumn;
            var strSearchKana = new string[5];                                          // ŒŸõ—pƒJƒi
                                                                                        // ˆ¶–¼—š—ðDataRow
            string strSystemDate;                                             // ƒVƒXƒeƒ€“ú•t
                                                                              // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁŠJŽn
            bool blnAtoAdd = false;                                        // Œã‚ÌƒŒƒR[ƒh‚ð’Ç‰Á‚µ‚½‚©‚Ç‚¤‚©
                                                                           // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁI—¹

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // *—š—ð”Ô† 000004 2006/05/31 ’Ç‰ÁŠJŽn
                strSystemDate = m_cfRdb.GetSystemDate().ToString("yyyyMMddHHmmssfff");                   // ƒVƒXƒeƒ€“ú•t
                                                                                                         // *—š—ð”Ô† 000004 2006/05/31 ’Ç‰ÁI—¹

                // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁŠJŽn
                // —ÝÏ(‘O)‚ð¶¬‚µ’Ç‰Á‚·‚é
                // —ÝÏ(‘O)‚Í‘€ì‘O‚Ì—š—ð’¼‹ßƒŒƒR[ƒh‚Æ‚·‚é
                if (csRirekiCkinRow is not null)
                {
                    // ˆ¶–¼—ÝÏ‚æ‚èV‚µ‚¢Row‚ðŽæ“¾‚·‚é
                    csRow = csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).NewRow;
                    // DataRow‚Ì‰Šú‰»
                    m_cCommonClass.InitColumnValue(csRow);

                    // ˆ—“úŽž
                    csRow(ABAtenaRuisekiEntity.SHORINICHIJI) = strSystemDate;
                    // ‘OŒã‹æ•ª
                    csRow(ABAtenaRuisekiEntity.ZENGOKB) = "1";

                    // —š—ð¨—ÝÏ
                    foreach (DataColumn currentCsColumn in csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Columns)
                    {
                        csColumn = currentCsColumn;
                        csRow(csColumn.ColumnName) = csRirekiCkinRow(csColumn);
                    }

                    // ˆ¶–¼—ÝÏ‚Ö’Ç‰Á‚·‚é
                    csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).Rows.Add(csRow);
                }
                // *—š—ð”Ô† 000005 2006/09/13 ’Ç‰ÁI—¹

                foreach (DataRow csAtenaRirekiRow in csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Rows)
                {

                    if (csAtenaRirekiRow.RowState == DataRowState.Added)
                    {
                        // ˆ¶–¼—ÝÏ‚æ‚èV‚µ‚¢Row‚ðŽæ“¾‚·‚é
                        csRow = csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).NewRow;
                        // DataRow‚Ì‰Šú‰»
                        m_cCommonClass.InitColumnValue(csRow);

                        // ˆ—“úŽž
                        csRow(ABAtenaRuisekiEntity.SHORINICHIJI) = strSystemDate;
                        // ‘OŒã‹æ•ª
                        csRow(ABAtenaRuisekiEntity.ZENGOKB) = "2";

                        // ˆ¶–¼—š—ðƒ}ƒXƒ^‚ðˆ¶–¼—ÝÏ‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                        foreach (DataColumn currentCsColumn1 in csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Columns)
                        {
                            csColumn = currentCsColumn1;
                            csRow(csColumn.ColumnName) = csAtenaRirekiRow(csColumn);
                        }

                        // ˆ¶–¼—ÝÏ‚Ö’Ç‰Á‚·‚é
                        csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).Rows.Add(csRow);

                        blnAtoAdd = true;
                        break;
                    }
                    // * corresponds to VS2008 Start 2010/04/16 000007
                    // '*—š—ð”Ô† 000005 2006/09/13 íœŠJŽn
                    // '''Select Case csAtenaRirekiRow.RowState
                    // '''    Case DataRowState.Added

                    // '''        ' ˆ¶–¼—ÝÏ‚æ‚èV‚µ‚¢Row‚ðŽæ“¾‚·‚é
                    // '''        csRow = csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).NewRow
                    // '''        ' DataRow‚Ì‰Šú‰»
                    // '''        m_cCommonClass.InitColumnValue(csRow)

                    // '''        '**
                    // '''        '* •ÒWˆ—
                    // '''        '*

                    // '''        ' ˆ—“úŽž
                    // '''        '*—š—ð”Ô† 000004 2006/05/31 íœŠJŽn
                    // '''        'strSystemDate = m_cfRdb.GetSystemDate().ToString("yyyyMMddHHmmssfff")                   'ƒVƒXƒeƒ€“ú•t
                    // '''        '*—š—ð”Ô† 000004 2006/05/31 íœI—¹
                    // '''        csRow(ABAtenaRuisekiEntity.SHORINICHIJI) = strSystemDate

                    // '''        ' ‘OŒã‹æ•ª
                    // '''        csRow(ABAtenaRuisekiEntity.ZENGOKB) = "2"

                    // '''        ' ˆ¶–¼ƒ}ƒXƒ^‚ðˆ¶–¼—š—ð‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                    // '''        For Each csColumn In csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Columns
                    // '''            csRow(csColumn.ColumnName) = csAtenaRirekiRow(csColumn)
                    // '''        Next csColumn

                    // '''        ' ˆ¶–¼—ÝÏ‚Ö’Ç‰Á‚·‚é
                    // '''        csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).Rows.Add(csRow)

                    // '''        '*—š—ð”Ô† 000004 2006/05/31 ’Ç‰ÁŠJŽn
                    // '''    Case DataRowState.Modified
                    // '''        ' ˆ¶–¼—ÝÏ‚æ‚èV‚µ‚¢Row‚ðŽæ“¾‚·‚é
                    // '''        csRow = csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).NewRow
                    // '''        ' DataRow‚Ì‰Šú‰»
                    // '''        m_cCommonClass.InitColumnValue(csRow)

                    // '''        '**
                    // '''        '* •ÒWˆ—
                    // '''        '*

                    // '''        ' ˆ—“úŽž
                    // '''        csRow(ABAtenaRuisekiEntity.SHORINICHIJI) = strSystemDate

                    // '''        ' ‘OŒã‹æ•ª
                    // '''        csRow(ABAtenaRuisekiEntity.ZENGOKB) = "1"

                    // '''        ' ˆ¶–¼—š—ðƒf[ƒ^‚ðˆ¶–¼—ÝÏ‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                    // '''        For Each csColumn In csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Columns
                    // '''            csRow(csColumn.ColumnName) = csAtenaRirekiRow(csColumn)
                    // '''        Next csColumn

                    // '''        ' ˆ¶–¼—ÝÏ‚Ö’Ç‰Á‚·‚é
                    // '''        csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).Rows.Add(csRow)
                    // '''        '*—š—ð”Ô† 000004 2006/05/31 ’Ç‰ÁI—¹
                    // '''End Select
                    // '*—š—ð”Ô† 000005 2006/09/13 íœI—¹
                    // * corresponds to VS2008 End 2010/04/16 000007
                }

                // ‚±‚±‚Å—ÝÏ(Œã)‚ª‚Ü‚¾’Ç‰Á‚³‚ê‚Ä‚¢‚È‚¢ê‡(’Ç‰Á‚È‚µ‚ÅXV‚µ‚½‚¾‚¯‚Ìê‡)
                if (blnAtoAdd == false)
                {
                    // ‘€ìŒã‚Ì—š—ð’¼‹ßƒŒƒR[ƒh‚ðŽæ“¾‚·‚é
                    csRows = csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Select(ABAtenaRirekiEntity.JUMINJUTOGAIKB + " = '2' AND " + ABAtenaRirekiEntity.RRKED_YMD + " = '99999999'");

                    // ˆ¶–¼—ÝÏ‚æ‚èV‚µ‚¢Row‚ðŽæ“¾‚·‚é
                    csRow = csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).NewRow;
                    // DataRow‚Ì‰Šú‰»
                    m_cCommonClass.InitColumnValue(csRow);

                    // ˆ—“úŽž
                    csRow(ABAtenaRuisekiEntity.SHORINICHIJI) = strSystemDate;
                    // ‘OŒã‹æ•ª
                    csRow(ABAtenaRuisekiEntity.ZENGOKB) = "2";

                    // ˆ¶–¼—š—ðƒ}ƒXƒ^‚ðˆ¶–¼—ÝÏ‚Ö‚»‚Ì‚Ü‚Ü•ÒW‚·‚é
                    foreach (DataColumn currentCsColumn2 in csAtenaRirekiEntity.Tables(ABAtenaRirekiEntity.TABLE_NAME).Columns)
                    {
                        csColumn = currentCsColumn2;
                        csRow(csColumn.ColumnName) = csRows[0](csColumn);
                    }

                    // ˆ¶–¼—ÝÏ‚Ö’Ç‰Á‚·‚é
                    csAtenaRuisekiEntity.Tables(ABAtenaRuisekiEntity.TABLE_NAME).Rows.Add(csRow);

                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }


            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63127


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63225


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63490


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 63575


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

        }


        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ŒŸõ—pƒJƒiŽæ“¾
        // * 
        // * \•¶           Public Function GetSearchKana(ByVal strKanaMeisho As String) As String()
        // * 
        // * ‹@”\@@       ŒŸõ—pƒJƒi–¼Ì‚ð•ÒW‚·‚é
        // * 
        // * ˆø”           strKanaMeisho As String     : ƒJƒi–¼Ì
        // * 
        // * –ß‚è’l         String()        : [0]ŒŸõ—pƒJƒi©–¼
        // *                                  : [1]ŒŸõ—pƒJƒi©
        // *                                  : [2]ŒŸõ—pƒJƒi–¼
        // *                                  : [3]ƒJƒi©
        // *                                  : [4]ƒJƒi–¼
        // ************************************************************************************************
        private string[] GetSearchKana(string strKanaMeisho)
        {
            const string THIS_METHOD_NAME = "GetSearchKana";                      // ƒƒ\ƒbƒh–¼
            var strSearchKana = new string[5];                      // ŒŸõ—pƒJƒi
            var cuString = new USStringClass();                 // •¶Žš—ñ•ÒW
            int intIndex;                             // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u

            try
            {
                // ƒfƒoƒbƒOŠJŽnƒƒOo—Í
                m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);

                // ƒJƒi©–¼i‹ó”’‚ð‹l‚ß‚éj
                strSearchKana[0] = cuString.ToKanaKey(strKanaMeisho).Replace(" ", string.Empty);

                // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u‚ð’²‚×‚é
                intIndex = strKanaMeisho.RIndexOf(" ");

                // ‹ó”’‚ª‘¶Ý‚µ‚È‚¢ê‡
                if (intIndex == -1)
                {
                    // ƒJƒi©E–¼
                    strSearchKana[1] = strSearchKana[0];
                    strSearchKana[3] = strKanaMeisho;
                    strSearchKana[2] = string.Empty;
                    strSearchKana[4] = string.Empty;
                }
                else
                {
                    // ƒJƒi©E–¼
                    strSearchKana[1] = cuString.ToKanaKey(strKanaMeisho.RSubstring(0, intIndex));
                    strSearchKana[3] = strKanaMeisho.RSubstring(0, intIndex);

                    // æ“ª‚©‚ç‚Ì‹ó”’ˆÊ’u‚ª•¶Žš—ñ’·‚ÆˆÈãê‡
                    if (intIndex + 1 >= strKanaMeisho.RLength)
                    {
                        strSearchKana[2] = string.Empty;
                        strSearchKana[4] = string.Empty;
                    }
                    else
                    {
                        strSearchKana[2] = cuString.ToKanaKey(strKanaMeisho.RSubstring(intIndex + 1));
                        strSearchKana[4] = strKanaMeisho.RSubstring(intIndex + 1);
                    }
                }

                // ƒfƒoƒbƒOI—¹ƒƒOo—Í
                m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            }


            catch (UFAppException objAppExp)    // UFAppException‚ðƒLƒƒƒbƒ`
            {
                // ƒ[ƒjƒ“ƒOƒƒOo—Í
                m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 66952


                Input:
                " + objAppExp.p_strErrorCode + "z" + _
                                                        "yƒ[ƒjƒ“ƒO“à—e:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67050


                Input:
                " + objAppExp.Message + "z")
                            ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                            Throw objAppExp

                        Catch objExp As Exception
                            ' ƒGƒ‰[ƒƒOo—Í
                            m_cfLog.ErrorWrite(m_cfControlData, _
                                                        "yƒNƒ‰ƒX–¼:
                 */
                ;
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67315


                Input:
                " + THIS_CLASS_NAME + "z" + _
                                                        "yƒƒ\ƒbƒh–¼:
                 */
                ;
                // ƒVƒXƒeƒ€ƒGƒ‰[‚ðƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
                /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 67400


                                Input:
                                " + THIS_METHOD_NAME + "z" + _
                                                                        "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                                 */
                throw objExp;
            }

            return strSearchKana;

        }

        // *—š—ð”Ô† 000003 2006/03/27 ’Ç‰ÁŠJŽn
        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼      ˆ¶–¼ƒŒƒvƒŠƒJƒf[ƒ^XV
        // * 
        // * \•¶            Public Sub AtenaDataReplicaKoshin(ByVal strJuminCD As String, _
        // *                                      ByVal strStaiCD As String, ByVal strKoshinKB As String)
        // * 
        // * ‹@”\@@        ˆ¶–¼ƒŒƒvƒŠƒJƒf[ƒ^‚ÌXVˆ—‚ðs‚È‚¤
        // * 
        // * ˆø”           strJuminCDFZ–¯ƒR[ƒh
        // *                  strStaiCDF¢‘ÑƒR[ƒh
        // *                  strKoshinKBFXV‹æ•ªi’Ç‰ÁF1@C³F2j
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public void AtenaDataReplicaKoshin(string strJuminCD, string strStaiCD, string strKoshinKB)
        {
            const string THIS_METHOD_NAME = "AtenaDataReplicaKoshin";
            const string WORK_FLOW_NAME = default
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
                                                "ˆ¶–¼ˆÙ“®"             ' ƒ[ƒNƒtƒ[–¼
                                                        Const DATA_NAME As String = "ˆ¶–¼"                      'ƒf[ƒ^–¼
                                                        Dim cAtenaKanriJohoB As ABAtenaKanriJohoBClass      'ˆ¶–¼ŠÇ—î•ñ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
                                                        Dim csAtenaKanriEntity As DataSet                   'ˆ¶–¼ŠÇ—î•ñƒf[ƒ^ƒZƒbƒg
                                                        Dim csABToshoPrmEntity As New DataSet()             'ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒZƒbƒg
                                                        Dim csABToshoPrmTable As DataTable                  'ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒe[ƒuƒ‹
                                                        Dim csABToshoPrmRow As DataRow                      'ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒe[ƒuƒ‹
                                                        Dim cABAtenaCnvBClass As ABAtenaCnvBClass


                                                        Try
                                                            ' ƒfƒoƒbƒOƒƒOo—Í
                                                            m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

                                                            ' ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
                                                            cAtenaKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigData, m_cfRdb)
                                                            '  ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[01‚Ìƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚é

                                                 */;/* TODO ERROR: Skipped SkippedTokensTrivia
®"             ' ƒ[ƒNƒtƒ[–¼
        Const DATA_NAME As String = "ˆ¶–¼"                      'ƒf[ƒ^–¼
        Dim cAtenaKanriJohoB As ABAtenaKanriJohoBClass      'ˆ¶–¼ŠÇ—î•ñ‚c‚`ƒrƒWƒlƒXƒNƒ‰ƒX
        Dim csAtenaKanriEntity As DataSet                   'ˆ¶–¼ŠÇ—î•ñƒf[ƒ^ƒZƒbƒg
        Dim csABToshoPrmEntity As New DataSet()             'ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒZƒbƒg
        Dim csABToshoPrmTable As DataTable                  'ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒe[ƒuƒ‹
        Dim csABToshoPrmRow As DataRow                      'ƒŒƒvƒŠƒJì¬—pƒpƒ‰ƒ[ƒ^ƒf[ƒ^ƒe[ƒuƒ‹
        Dim cABAtenaCnvBClass As ABAtenaCnvBClass


        Try
            ' ƒfƒoƒbƒOƒƒOo—Í
            m_cfLog.DebugStartWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME)

            ' ˆ¶–¼ŠÇ—î•ñ‚aƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒXì¬
            cAtenaKanriJohoB = New ABAtenaKanriJohoBClass(m_cfControlData, m_cfConfigData, m_cfRdb)
            '  ˆ¶–¼ŠÇ—î•ñ‚ÌŽí•Ê04Ž¯•ÊƒL[01‚Ìƒf[ƒ^‚ð‘SŒŽæ“¾‚·‚é*/
            csAtenaKanriEntity = cAtenaKanriJohoB.GetKanriJohoHoshu("04", "01");

            // ŠÇ—î•ñ‚Ìƒ[ƒNƒtƒ[ƒŒƒR[ƒh‚ª‘¶Ý‚µAƒpƒ‰ƒ[ƒ^‚ª"1"‚Æ"2"‚ÌŽž‚¾‚¯ƒ[ƒNƒtƒ[ˆ—‚ðs‚¤
            if (!(csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows.Count == 0) && ((string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "1" || (string)csAtenaKanriEntity.Tables(ABAtenaKanriJohoEntity.TABLE_NAME).Rows(0).Item(ABAtenaKanriJohoEntity.PARAMETER) == "2"))

            {

                // ƒf[ƒ^ƒZƒbƒgŽæ“¾ƒNƒ‰ƒX‚ÌƒCƒ“ƒXƒ^ƒ“ƒX‰»
                cABAtenaCnvBClass = new ABAtenaCnvBClass(m_cfControlData, m_cfConfigData, m_cfRdb);
                // ƒe[ƒuƒ‹ƒZƒbƒg‚ÌŽæ“¾
                csABToshoPrmTable = cABAtenaCnvBClass.CreateColumnsToshoPrmData();
                csABToshoPrmTable.TableName = ABToshoPrmEntity.TABLE_NAME;
                // ƒf[ƒ^ƒZƒbƒg‚Éƒe[ƒuƒ‹ƒZƒbƒg‚Ì’Ç‰Á
                csABToshoPrmEntity.Tables.Add(csABToshoPrmTable);

                // V‹KƒƒE‚Ìì¬
                csABToshoPrmRow = csABToshoPrmEntity.Tables(ABToshoPrmEntity.TABLE_NAME).NewRow();
                // ƒŒƒvƒŠƒJƒf[ƒ^ì¬—pƒpƒ‰ƒ[ƒ^‚ÉƒZƒbƒg
                csABToshoPrmRow.Item(ABToshoPrmEntity.JUMINCD) = strJuminCD;                 // Z–¯ƒR[ƒh
                csABToshoPrmRow.Item(ABToshoPrmEntity.STAICD) = strStaiCD;                   // ¢‘ÑƒR[ƒh
                csABToshoPrmRow.Item(ABToshoPrmEntity.KOSHINKB) = strKoshinKB;               // XV‹æ•ªi’Ç‰Á:1 C³:2 ˜_—íœ:9 íœƒf[ƒ^‰ñ•œ:2 •¨—íœ:Dj
                // ƒf[ƒ^ƒZƒbƒg‚ÉƒƒE‚ð’Ç‰Á‚·‚é
                csABToshoPrmEntity.Tables(ABToshoPrmEntity.TABLE_NAME).Rows.Add(csABToshoPrmRow);

                // ƒ[ƒNƒtƒ[‘—Mˆ—ŒÄ‚Ño‚µ
                cABAtenaCnvBClass.WorkFlowExec(csABToshoPrmEntity, WORK_FLOW_NAME, DATA_NAME);

            }

            // ƒfƒoƒbƒOƒƒOo—Í
            m_cfLog.DebugEndWrite(m_cfControlData, THIS_CLASS_NAME, THIS_METHOD_NAME);
            ;
            // ƒ[ƒjƒ“ƒOƒƒOo—Í
#error Cannot convert CatchStatementSyntax - see comment for details
            /* Cannot convert CatchStatementSyntax, CONVERSION ERROR: Conversion for CatchStatement not implemented, please report this issue in 'Catch objAppExp As UFAppExc...' at character 71767


                        Input:

                                Catch objAppExp As UFAppException

                         */
            m_cfLog.WarningWrite(m_cfControlData, "yƒNƒ‰ƒX–¼:" + THIS_CLASS_NAME + "z" + @"yƒƒ\ƒbƒh–¼:" + THIS_METHOD_NAME + "z" + default


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
            /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72172


            Input:
            " + objAppExp.p_strErrorCode + "z" + _
                                                    "yƒ[ƒjƒ“ƒO“à—e:
             */
            ;
#error Cannot convert EmptyStatementSyntax - see comment for details
            /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72270


            Input:
            " + objAppExp.Message + "z")
                        ' ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
                        Throw objAppExp

                    Catch objExp As Exception
                        ' ƒGƒ‰[ƒƒOo—Í
                        m_cfLog.ErrorWrite(m_cfControlData, _
                                                    "yƒNƒ‰ƒX–¼:
             */
            ;
#error Cannot convert EmptyStatementSyntax - see comment for details
            /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72535


            Input:
            " + THIS_CLASS_NAME + "z" + _
                                                    "yƒƒ\ƒbƒh–¼:
             */
            ;
            // ƒGƒ‰[‚ð‚»‚Ì‚Ü‚ÜƒXƒ[‚·‚é
#error Cannot convert EmptyStatementSyntax - see comment for details
            /* Cannot convert EmptyStatementSyntax, CONVERSION ERROR: Conversion for EmptyStatement not implemented, please report this issue in '' at character 72620


                        Input:
                        " + THIS_METHOD_NAME + "z" + _
                                                                "yƒGƒ‰[“à—e:" + objExp.Message + "z")

                         */
            throw objExp;
            ;

#error Cannot convert EndBlockStatementSyntax - see comment for details
            /* Cannot convert EndBlockStatementSyntax, CONVERSION ERROR: Conversion for EndTryStatement not implemented, please report this issue in 'End Try' at character 72807


                        Input:
                                End Try

                         */
        }
        // *—š—ð”Ô† 000003 2006/03/27 ’Ç‰ÁI—¹

    }
}