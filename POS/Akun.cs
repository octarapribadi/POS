using System;


namespace POS
{
    public class Akun
    {
        String username;
        String namaLengkap;
        Boolean aktif;

        public Akun(string username, string namaLengkap,bool aktif)
        {
            this.username = username;
            this.namaLengkap = namaLengkap;
            this.aktif = aktif;
        }

        public String getUsername() { return username; }
        public String getNamaLengkap() {  return namaLengkap; }
        public Boolean getAKtif() { return aktif; }

        
    }
}
