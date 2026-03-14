namespace TP_MODUL4_103022400008 
{
    public class KodePos 
    {
        public enum Kelurahan { 
            BATUNUNGGAL,
            KUJANGSARI,
            MENGGER, 
            WATES,
            CIJAURA,
            JATISARI,
            MARGASARI,
            SEKEJATI,
            KEBONWARU,
            MALEER
        }

        public static int getKodePos(Kelurahan kelurahan) {
            int[] postCode = {40266,40287,40267,40256,40287,40286,40286,40286,40272,40274};

            return postCode[(int)kelurahan];
        }
    }
}