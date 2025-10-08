// ************************************************************************************************
// * ‹Æ–±–¼           ˆ¶–¼ŠÇ—ƒVƒXƒeƒ€
// * 
// * ƒNƒ‰ƒX–¼         ‚`‚aˆ¶–¼ZŠîƒoƒbƒ`XV(ABBatchJukiKoshinBClass)
// * 
// * ƒo[ƒWƒ‡ƒ“î•ñ   Ver 1.0
// * 
// * “ú•t‚¯           2009/05/12@
// *
// * ì¬ŽÒ           ”ä‰Ã@Œv¬
// *
// * ’˜ìŒ           iŠ”j“dŽZ
// ************************************************************************************************
// * C³—š—ð@@—š—ð”Ô†@@C³“à—e
// * 
// ************************************************************************************************

namespace Densan.Reams.AB.AB000BB
{

    public class ABBatchJukiKoshinBClass : ABJukiKoshinBClass           // ZŠîXV‚aƒNƒ‰ƒX‚ðŒp³
    {

        // ************************************************************************************************
        // * ƒƒ\ƒbƒh–¼     ƒRƒ“ƒXƒgƒ‰ƒNƒ^
        // * 
        // * \•¶           Public Sub New(ByVal cfControlData As UFControlData, 
        // * @@                          ByVal cfConfigDataClass As UFConfigDataClass,
        // *                               ByVal cfRdbClass As UFRdbClass)
        // * 
        // * ‹@”\@@       ‰Šú‰»ˆ—
        // * 
        // * ˆø”           cfControlData As UFControlData          : ƒRƒ“ƒgƒ[ƒ‹ƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfConfigDataClass as UFConfigDataClass  : ƒRƒ“ƒtƒBƒOƒf[ƒ^ƒIƒuƒWƒFƒNƒg
        // * @@           cfRdbClass as UFRdbClass                : ƒf[ƒ^ƒx[ƒXƒAƒNƒZƒX—pƒIƒuƒWƒFƒNƒg
        // * 
        // * –ß‚è’l         ‚È‚µ
        // ************************************************************************************************
        public ABBatchJukiKoshinBClass(UFControlData cfControlData, UFConfigDataClass cfConfigDataClass, UFRdbClass cfRdbClass) : base(cfControlData, cfConfigDataClass, cfRdbClass)

        {
            m_blnBatch = true;

        }
    }
}