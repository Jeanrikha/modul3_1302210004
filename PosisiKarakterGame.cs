using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302210004
{
    internal class PosisiKarakterGame
    {
        private State state;

        private enum State
        {
            Berdiri,
            Terbang,
            Jongkok,
            Tengkruap
        }

        public PosisiKarakterGame()
        {
            state = State.Berdiri;
        }

        public void TombolW() 
        {
            if (state == State.Berdiri)
            {
                state = State.Terbang;

            }
            else if (state == State.Tengkruap)
            {
                state = State.Jongkok;
            }
            else if (state == State.Jongkok)
            {
                state = State.Berdiri;
                Console.WriteLine("posisis standby");
            }
        }

        public void TombolS()
        {
            if (state == State.Berdiri)
            {
                state = State.Jongkok;

            }
            else if (state == State.Jongkok)
            {
                state = State.Tengkruap;
                Console.WriteLine("posisi istirahat");
            }
            else if (state == State.Terbang)
            {
                state = State.Berdiri;
                Console.WriteLine("posisis standby");
            }
        }

        public void TombolX()
        {
            if (state == State.Terbang)
            {
                state = State.Jongkok;

            }
        }
    }
}
