using System;

class PosisiKarakterGame
{
    public enum State
    {
        Berdiri,
        Jongkok,
        Tengkurap,
        Terbang
    }

    public State state;

    public PosisiKarakterGame()
    {
        state = State.Berdiri;
    }

    public void tekanTombol(string tombol)
    {
        State prevState = state;

        switch (state)
        {
            case State.Berdiri:
                if (tombol == "S") state = State.Jongkok;
                else if (tombol == "W") state = State.Terbang;
                break;

            case State.Jongkok:
                if (tombol == "S") state = State.Tengkurap;
                else if (tombol == "W") state = State.Berdiri;
                break;

            case State.Tengkurap:
                if (tombol == "W") state = State.Jongkok;
                break;

            case State.Terbang:
                if (tombol == "S") state = State.Berdiri;
                break;
        }

        
        if (state == State.Berdiri && prevState != State.Berdiri)
        {
            Console.WriteLine("posisi standby");
        }
        else if (state == State.Tengkurap && prevState != State.Tengkurap)
        {
            Console.WriteLine("posisi istirahat");
        }

        Console.WriteLine("State sekarang: " + state);
    }
}