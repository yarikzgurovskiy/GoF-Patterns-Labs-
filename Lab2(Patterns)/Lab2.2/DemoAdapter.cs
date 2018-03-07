using System.Collections.Generic;

namespace Lab2._2 {
    class DemoAdapter {
        static void Main(string[] args) {
            //create turnstile
            Turnstile turnstile = new Turnstile();

            IPay pay1 = new PayAdapter(new CardPassenger(3));
            IPay pay2 = new PayAdapter(new TokenPassenger(new List<int>() {5, 5}));

            for(int i = 0; i < 4; i++) {
                turnstile.Verify(pay1);
            }

            for(int i = 0; i < 4; i++) {
                turnstile.Verify(pay2);
            }
        }
    }
}
