using nanoFramework.Hardware.Esp32.Rmt;

namespace nanoFrameworkInfrared
{
    public class DevKitInfraredSignalDecoder
    {
        private readonly InfraredSignalComparer _signalComparer;

        public DevKitInfraredSignalDecoder(InfraredSignalComparer infraredSignalComparer)
        {
            _signalComparer = infraredSignalComparer;
        }

        public Button Decode(RmtCommand[] response)
        {
            var exactMatch = _signalComparer.Compare(response, zero);

            if (exactMatch)
            {
                return Button.Zero;
            }
            exactMatch = _signalComparer.Compare(response, one);
            if (exactMatch)
            {
                return Button.One;
            }
            exactMatch = _signalComparer.Compare(response, two);
            if (exactMatch)
            {
                return Button.Two;
            }
            exactMatch = _signalComparer.Compare(response, three);
            if (exactMatch)
            {
                return Button.Three;
            }
            exactMatch = _signalComparer.Compare(response, four);
            if (exactMatch)
            {
                return Button.Four;
            }
            exactMatch = _signalComparer.Compare(response, five);
            if (exactMatch)
            {
                return Button.Five;
            }
            exactMatch = _signalComparer.Compare(response, six);
            if (exactMatch)
            {
                return Button.Six;
            }
            exactMatch = _signalComparer.Compare(response, seven);
            if (exactMatch)
            {
                return Button.Seven;
            }
            exactMatch = _signalComparer.Compare(response, eight);
            if (exactMatch)
            {
                return Button.Eight;
            }
            exactMatch = _signalComparer.Compare(response, nine);
            if (exactMatch)
            {
                return Button.Nine;
            }
            exactMatch = _signalComparer.Compare(response, chanM);
            if (exactMatch)
            {
                return Button.PreviousChannel;
            }
            exactMatch = _signalComparer.Compare(response, chan);
            if (exactMatch)
            {
                return Button.Channel;
            }
            exactMatch = _signalComparer.Compare(response, chanP);
            if (exactMatch)
            {
                return Button.NextChannel;
            }
            exactMatch = _signalComparer.Compare(response, volM);
            if (exactMatch)
            {
                return Button.VolumeDown;
            }
            exactMatch = _signalComparer.Compare(response, volP);
            if (exactMatch)
            {
                return Button.VolumeUp;
            }
            exactMatch = _signalComparer.Compare(response, prev);
            if (exactMatch)
            {
                return Button.Previous;
            }
            exactMatch = _signalComparer.Compare(response, next);
            if (exactMatch)
            {
                return Button.Next;
            }
            exactMatch = _signalComparer.Compare(response, play);
            if (exactMatch)
            {
                return Button.PlayPause;
            }
            exactMatch = _signalComparer.Compare(response, eq);
            if (exactMatch)
            {
                return Button.Eq;
            }
            exactMatch = _signalComparer.Compare(response, plus100);
            if (exactMatch)
            {
                return Button.Plus100;
            }
            exactMatch = _signalComparer.Compare(response, plus200);
            if (exactMatch)
            {
                return Button.Plus200;
            }

            return Button.Unknown;
        }

        ushort[] zero = new ushort[]
        {
            9207, 4490, 601, 595, 573, 596, 574, 594, 574, 595, 596, 572, 597, 572, 574, 595, 597, 571, 574, 1674,
            597, 1651, 574, 1674, 597, 1651, 598, 1650, 574, 1673, 599, 1649, 574, 1674, 598, 571, 574, 1674, 599,
            1649, 597, 572, 598, 1649, 598, 570, 600, 569, 598, 571, 597, 1650, 599, 570, 598, 570, 598, 1650, 598,
            571, 597, 1650, 600, 1648, 598, 1650, 598, 6681, 9218, 2228, 600, 0
        };
        ushort[] one = new ushort[]
        {
            9230, 4468, 624, 572, 597, 571, 599, 571, 598, 571, 623, 547, 599, 570, 599, 572, 599, 571, 598, 1650,
            599, 1650, 599, 1649, 599, 1650, 599, 1650, 598, 1650, 599, 1649, 600, 1650, 599, 548, 621, 546, 623,
            1627, 622, 1625, 623, 546, 624, 544, 625, 545, 623, 546, 624, 1625, 623, 1626, 624, 546, 624, 544, 625,
            1625, 624, 1626, 623, 1625, 624, 1625, 624, 6692, 9221, 2204, 623, 0,
        };

        ushort[] two = new ushort[]
        {
            9244, 4468, 626, 572, 598, 572, 598, 573, 598, 571, 599, 572, 598, 572, 599, 571, 598, 573, 597, 1652,
            598, 1651, 598, 1651, 598, 1652, 598, 1652, 597, 1653, 598, 1652, 598, 1652, 599, 548, 624, 571, 597,
            573, 597, 1651, 599, 1651, 598, 546, 625, 546, 622, 548, 622, 1651, 599, 1650, 598, 1628, 622, 542, 628,
            542, 625, 1624, 625, 1623, 626, 1623, 626, 6687, 9207, 2204, 647, 0,

        };

        ushort[] three = new ushort[]
        {
            9235, 4470, 620, 575, 595, 574, 573, 596, 593, 575, 595, 574, 594, 575, 594, 574, 596, 572, 595, 1653,
            596, 1652, 573, 1675, 593, 1655, 594, 1653, 572, 1675, 595, 1653, 595, 1652, 595, 573, 595, 1652, 593,
            1654, 593, 1654, 595, 1652, 571, 596, 593, 1654, 571, 597, 594, 1652, 572, 596, 596, 571, 596, 549, 619,
            548, 618, 1652, 596, 572, 597, 1650, 597, 6690, 9199, 2205, 621, 0,
        };
        // 4
        ushort[] four = new ushort[]
        {
            9228, 4468, 624, 573, 597, 572, 597, 572, 597, 573, 597, 571, 598, 572, 597, 572, 598, 571, 598, 1651,
            598, 1651, 597, 1652, 597, 1652, 598, 1651, 597, 1652, 597, 1651, 598, 1651, 597, 573, 596, 573, 597,
            573, 596, 1652, 597, 573, 597, 572, 597, 573, 596, 573, 596, 1653, 598, 1651, 596, 1653, 598, 572, 596,
            1652, 597, 1651, 598, 1651, 596, 1653, 598, 6685, 9218, 2231, 597, 0,
        };

        //5
        ushort[] five = new ushort[]
        {
            9210, 4491, 602, 595, 596, 573, 600, 570, 600, 569, 599, 571, 576, 593, 599, 571, 600, 570, 599, 1649,
            601, 1648, 600, 1649, 601, 1648, 602, 1648, 601, 1649, 600, 1648, 602, 1647, 603, 567, 602, 568, 601,
            1647, 601, 1648, 602, 1647, 602, 567, 601, 569, 602, 567, 602, 1647, 602, 1647, 603, 567, 602, 567, 601,
            568, 602, 1646, 603, 1646, 602, 1647, 626, 6663, 9241, 2228, 601, 0,
        };

        // 6
        ushort[] six = new ushort[]
        {
            9270, 4436, 659, 538, 630, 513, 657, 538, 630, 514, 655, 513, 656, 514, 657, 511, 654, 515, 657, 1619,
            628, 1598, 639, 1633, 629, 1596, 627, 1619, 653, 1594, 628, 1620, 627, 1621, 626, 542, 624, 1625, 624,
            544, 623, 1625, 624, 1625, 623, 545, 623, 1625, 623, 545, 622, 1625, 623, 545, 623, 1625, 622, 545, 623,
            545, 624, 1624, 624, 544, 649, 1599, 649, 6667, 9243, 2179, 649, 0,
        };

        // 7
        ushort[] seven = new ushort[]
        {
            9277, 4441, 628, 542, 626, 543, 625, 544, 625, 544, 625, 544, 650, 519, 626, 543, 625, 544, 626, 1623,
            624, 1624, 624, 1624, 626, 1623, 625, 1623, 624, 1625, 624, 1624, 624, 1625, 624, 545, 624, 1623, 624,
            546, 623, 545, 624, 545, 623, 546, 624, 1624, 623, 545, 624, 1625, 624, 544, 624, 1625, 624, 1624, 623,
            1625, 625, 1624, 625, 544, 650, 1598, 625, 6691, 9247, 2181, 624, 0,
        };

        // 8
        ushort[] eight = new ushort[]
        {
            9258, 4433, 661, 538, 629, 516, 654, 515, 655, 511, 660, 513, 654, 514, 656, 513, 657, 512, 656, 1620,
            628, 1621, 629, 1594, 654, 1595, 655, 1593, 655, 1593, 629, 1620, 629, 1621, 626, 543, 626, 1624, 626,
            543, 625, 545, 625, 1624, 625, 545, 625, 1624, 650, 520, 625, 1624, 627, 544, 625, 1625, 626, 1623, 626,
            544, 627, 1623, 652, 518, 652, 1598, 651, 6667, 9241, 2181, 647, 0,
        };

        // 9
        ushort[] nine = new ushort[]
        {


            9208, 4468, 626, 571, 597, 572, 597, 571, 598, 571, 597, 572, 597, 571, 598, 571, 597, 572, 596, 1652,
            596, 1652, 621, 1627, 597, 1652, 596, 1651, 605, 1642, 597, 1652, 596, 1652, 596, 572, 596, 1652, 596,
            572, 596, 1652, 595, 573, 596, 572, 596, 1651, 596, 572, 596, 1652, 595, 573, 596, 1652, 595, 573, 595,
            1652, 595, 1652, 596, 573, 594, 1652, 597, 6693, 9216, 2231, 595, 0,
        };

        //vol -
        ushort[] volM = new ushort[]
        {
            9228, 4468, 625, 571, 622, 548, 598, 571, 597, 572, 598, 571, 598, 571, 597, 573, 596, 572, 597, 1651,
            597, 1652, 596, 1652, 596, 1652, 597, 1652, 597, 1651, 597, 1652, 596, 1652, 597, 1652, 597, 1652, 597,
            1651, 597, 551, 618, 574, 595, 574, 597, 572, 596, 550, 620, 548, 621, 573, 597, 546, 623, 1651, 598,
            1652, 596, 1652, 598, 1625, 623, 1624, 625, 6689, 9253, 2180, 648, 0,
        };

        // vol +
        ushort[] volP = new ushort[]
        {
            9203, 4492, 624, 572, 598, 571, 600, 569, 600, 570, 600, 569, 601, 569, 599, 570, 601, 568, 601, 1648,
            603, 1647, 604, 1646, 604, 1647, 604, 1647, 629, 1621, 604, 1646, 629, 1622, 604, 1625, 625, 541, 628,
            1624, 626, 541, 628, 1623, 625, 543, 626, 543, 626, 544, 625, 545, 625, 1625, 625, 544, 625, 1626, 625,
            545, 624, 1626, 625, 1626, 649, 1601, 625, 6713, 9232, 2205, 626, 0,
        };

        // EQ
        ushort[] eq = new ushort[]
        {
            9211,4471,601,596,573,596,573,595,573,595,573,596,575,594,573,596,573,595,573,1675,573,1675,573,1676,573,1675,597,1651,597,1651,575,1674,575,1674,598,1650,600,571,597,572,598,1650,599,571,596,573,600,569,599,570,598,572,574,1674,599,1650,598,571,600,1649,599,1649,600,1649,600,1649,601,6693,9226,2229,601,0,
        };

        //prev
        ushort[] prev = new ushort[]
        {
            9218, 4469, 625, 571, 596, 573, 596, 573, 595, 573, 596, 573, 596, 572, 595, 574, 595, 574, 595, 1652,
            596, 1652, 595, 1653, 595, 1653, 597, 1651, 597, 1651, 597, 1651, 598, 1651, 597, 546, 622, 546, 623,
            1651, 597, 544, 625, 543, 625, 544, 624, 1624, 649, 519, 638, 1611, 623, 1624, 625, 544, 624, 1624, 624,
            1624, 625, 1623, 649, 519, 625, 1624, 648, 6666, 9220, 2203, 625, 0,
        };

        // next
        ushort[] next = new ushort[]
        {

            9227, 4462, 657, 516, 652, 515, 631, 563, 628, 515, 630, 542, 652, 514, 656, 539, 603, 539, 654, 1620,
            628, 1620, 629, 1621, 628, 1620, 603, 1645, 602, 1646, 603, 1621, 628, 1621, 627, 538, 631, 537, 631,
            538, 630, 537, 631, 538, 631, 538, 631, 1620, 652, 514, 630, 1645, 602, 1646, 630, 1618, 629, 1619, 632,
            1617, 618, 1630, 606, 539, 654, 1618, 607, 6693, 9214, 2226, 602, 0,
        };


        // play
        ushort[] play = new ushort[]
        {
            9221, 4460, 657, 539, 605, 538, 650, 518, 628, 538, 654, 513, 654, 515, 653, 513, 630, 538, 655, 1597,
            649, 1597, 653, 1594, 654, 1593, 654, 1595, 654, 1595, 652, 1595, 653, 1594, 629, 1620, 626, 1622, 627,
            542, 625, 543, 624, 545, 623, 545, 624, 1624, 625, 544, 624, 545, 624, 545, 624, 1624, 624, 1625, 623,
            1625, 648, 1601, 624, 544, 624, 1625, 624, 6694, 9248, 2177, 651, 0,
        };
        //ch -
        ushort[] chanM = new ushort[]
        {
            9254, 4438, 633, 565, 628, 514, 656, 514, 655, 538, 630, 539, 630, 539, 605, 541, 651, 516, 649, 1623,
            630, 1618, 629, 1620, 606, 1643, 604, 1644, 605, 1643, 630, 1618, 606, 1621, 629, 1642, 629, 540, 605,
            1643, 605, 564, 604, 538, 632, 537, 653, 1621, 629, 514, 629, 539, 632, 1642, 629, 515, 630, 1644, 605,
            1643, 630, 1618, 630, 512, 655, 1597, 652, 6671, 9247, 2176, 630, 0,
        };
        // ch +
        ushort[] chanP = new ushort[]
        {
            9217, 4469, 625, 572, 597, 571, 598, 571, 598, 571, 599, 570, 598, 571, 624, 546, 597, 572, 622, 1626,
            598, 1652, 621, 1628, 598, 1651, 599, 1650, 598, 1651, 598, 1651, 598, 1651, 623, 1627, 597, 1651, 599,
            1651, 622, 547, 597, 571, 598, 572, 621, 1628, 622, 547, 622, 547, 621, 548, 597, 572, 597, 1652, 597,
            1652, 621, 1627, 598, 572, 597, 1652, 598, 6709, 9242, 2206, 597, 0,
        };

        // CH
        ushort[] chan = new ushort[]
        {
            9227, 4471, 648, 548, 597, 572, 597, 572, 622, 548, 596, 573, 596, 573, 620, 549, 596, 574, 595, 1653,
            596, 1653, 598, 1652, 597, 1652, 598, 1652, 598, 1652, 596, 1653, 596, 1653, 597, 572, 596, 1653, 596,
            1654, 595, 574, 596, 573, 596, 574, 595, 1654, 596, 573, 596, 1653, 596, 574, 595, 573, 595, 1654, 595,
            1654, 597, 1652, 597, 573, 595, 1653, 597, 6712, 9214, 2233, 597, 0,
        };

        //100+
        ushort[] plus100 = new ushort[]
                {9251,4436,657,516,652,540,628,541,629,516,650,518,652,540,627,517,651,516,628,1644,630,1618,624,1624,629,1619,628,1620,629,1619,628,1620,630,1618,630,1618,629,515,655,515,653,1619,629,1619,628,515,629,539,629,540,627,542,652,1619,629,1619,628,515,626,542,627,1645,629,1618,627,1621,626,6665,9208,2204,626,0,
  };
        //200+
        private ushort[] plus200 = new ushort[]
        {
            9206, 4465, 622, 547, 622, 546, 621, 546, 623, 545, 621, 546, 621, 547, 620, 548, 620, 547, 621, 1626, 620,
            1627, 620, 1628, 620, 1625, 621, 1628, 618, 1629, 618, 1628, 620, 1628, 619, 1628, 619, 548, 619, 1628, 620,
            1629, 617, 550, 618, 550, 617, 550, 618, 551, 616, 551, 617, 1631, 616, 551, 616, 552, 615, 1632, 616, 1632,
            615, 1632, 615, 1633, 615, 6699, 9191, 2239, 588, 0,
        };


    }
}