using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    internal static class Sabitler
    {
        public static VeritabaniEntities db = new VeritabaniEntities();

        public static string YoneticiAdiSoyadi;

        public static void MesajGoster(string yazi, bool hata = false)
        {
            if (hata)
            {
                MessageBox.Show(yazi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(yazi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}