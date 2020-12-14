﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dec_14
{
    class TestInput
    {
        public static string[] GetTestInput()
        {
            return new string[]
            {
                "mask = XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X",
                "mem[8] = 11",
                "mem[7] = 101",
                "mem[8] = 0"
            };
        }

        public static string[] GetInput()
        {
            return new string[]
            {
                "mask = 100110X100000XX0X100X1100110X001X100",
"mem[21836] = 68949",
"mem[61020] = 7017251",
"mask = X00X0011X11000X1010X0X0X110X0X011000",
"mem[30885] = 231192",
"mem[26930] = 133991367",
"mem[1005] = 121034",
"mem[20714] = 19917",
"mem[55537] = 9402614",
"mask = XXXX001111100011X1110000XX001011100X",
"mem[60166] = 183248310",
"mem[2049] = 5589249",
"mem[51891] = 1099680",
"mem[18978] = 14866",
"mask = 0001X01X10000XX101011001010000000101",
"mem[1005] = 829248",
"mem[27381] = 692",
"mem[34916] = 2837960",
"mem[62276] = 3012",
"mem[5508] = 3266469",
"mem[22080] = 1634946",
"mask = X0010111000000110101X000X1X10001X110",
"mem[37928] = 734",
"mem[4172] = 38261",
"mask = X01X1011000X100110011010X100XXX101X1",
"mem[26256] = 974361",
"mem[40212] = 104631",
"mem[4580] = 7461426",
"mem[33929] = 35725",
"mem[39823] = 119176",
"mem[21859] = 15272544",
"mask = 100X1111X000110110000X101X0100X10100",
"mem[11795] = 1313267",
"mem[56582] = 899018",
"mem[48407] = 76",
"mem[5063] = 106828",
"mem[26465] = 995473759",
"mem[47777] = 106244",
"mask = 10XX1X111000101X1X00X1X010011X101X00",
"mem[38020] = 134151138",
"mem[16744] = 515430161",
"mem[11894] = 86021",
"mem[24612] = 10213071",
"mask = 100X10111110XX00XXX1001X1001101001X0",
"mem[2306] = 485412",
"mem[37241] = 203",
"mask = X00100X11X0XX01001111001011001110XXX",
"mem[64442] = 374",
"mem[30709] = 802578",
"mem[3647] = 238",
"mem[379] = 11694",
"mask = 1X01100000X00X0XX0X1000010X10010X001",
"mem[41455] = 385289",
"mem[48074] = 1316",
"mem[49173] = 19140",
"mem[23822] = 11856263",
"mem[62555] = 44029555",
"mask = 1001X011X1X0100111X01000100100000011",
"mem[23805] = 683093",
"mem[28985] = 40262",
"mem[63420] = 1472",
"mask = 10X110110001X0XXX1XX0011X1011X001110",
"mem[4549] = 319630",
"mem[17028] = 971379",
"mem[9538] = 776918",
"mem[54600] = 47706281",
"mask = 1001101XX0X0000X1X00000010010101XX0X",
"mem[64442] = 43115647",
"mem[61023] = 3521",
"mem[28056] = 40690065",
"mem[1945] = 14234",
"mem[26113] = 77195",
"mem[46480] = 112526302",
"mask = X00101110000001101011X0101XXXX0001XX",
"mem[22335] = 8263",
"mem[53292] = 63795",
"mem[38020] = 1128",
"mem[52793] = 4481832",
"mem[23810] = 3730",
"mem[35499] = 4234754",
"mask = 10011X110000X001X10X00X0101XX0X0X001",
"mem[52740] = 1543935",
"mem[61205] = 57464286",
"mem[3960] = 266031",
"mask = 1X011X11X0001X1111011XX010101110110X",
"mem[15105] = 236636",
"mem[45281] = 152",
"mem[8741] = 130448",
"mem[63567] = 228401361",
"mem[10747] = 63603162",
"mem[3049] = 791520",
"mem[9530] = 1052665",
"mask = X001XX110000010X11010011000X00100100",
"mem[57962] = 870779020",
"mem[57617] = 3681",
"mem[65470] = 901116478",
"mem[53560] = 26187243",
"mem[16761] = 251482",
"mem[32342] = 236520858",
"mask = X001101X0000110X1100XX01010X01111001",
"mem[49925] = 15976004",
"mem[2675] = 11104973",
"mem[22544] = 56525",
"mask = X0010111000000110101X1000101X00XX011",
"mem[36869] = 14141",
"mem[20714] = 597",
"mem[63548] = 2049398",
"mask = 1011X0X1000010001001101X010X100X0111",
"mem[53798] = 16410",
"mem[21580] = 4654733",
"mem[39296] = 52998578",
"mem[4275] = 5632",
"mask = 100X111100001001110XXX0XX011011X10X1",
"mem[6029] = 7239",
"mem[4275] = 2074537",
"mem[52393] = 7979",
"mask = X0011X11000100111101X1101101100010X0",
"mem[33667] = 31539414",
"mem[5162] = 4012",
"mem[42952] = 1304339",
"mem[45281] = 2054251",
"mask = 1011101100011X11X111XX1100000X001010",
"mem[83] = 29642",
"mem[41455] = 190535",
"mem[38551] = 6001919",
"mem[3391] = 10441",
"mask = 10X1X0110XX1101111110001000110011000",
"mem[25613] = 1847933",
"mem[40713] = 50597",
"mem[24007] = 338970",
"mem[58808] = 237130743",
"mem[4175] = 815598415",
"mem[41461] = 4372988",
"mask = 100110100X100100110X01011101X010110X",
"mem[40961] = 50525607",
"mem[2979] = 1433",
"mem[47179] = 952239118",
"mem[30786] = 1015",
"mem[5508] = 3511",
"mem[21799] = 7970816",
"mask = 0X00X0110X10X0110XXX0X11100000X01010",
"mem[22394] = 123755",
"mem[31926] = 269116849",
"mem[13434] = 5403",
"mem[33919] = 55119",
"mask = 10X11X1100001X0X1X0X10000100X0010X00",
"mem[14615] = 285",
"mem[53053] = 41984",
"mem[38562] = 1199",
"mem[23822] = 11061",
"mem[23805] = 10723",
"mask = 0100001001101011000X100X000001X00X11",
"mem[43942] = 11107",
"mem[48672] = 25230161",
"mem[3049] = 1123223",
"mem[1243] = 46493039",
"mem[12736] = 878",
"mask = 10010X110X00X00101X1X011111010001X01",
"mem[58491] = 4086",
"mem[11942] = 1887",
"mem[64773] = 152653648",
"mem[17330] = 15040",
"mem[53297] = 15505042",
"mask = 1001XX1100000XX1X10111X0X001X00X0000",
"mem[61205] = 3951",
"mem[30885] = 44",
"mem[64774] = 1579804",
"mask = 100110111100X0X1X10111X0100111111X00",
"mem[46990] = 518",
"mem[50657] = 972",
"mem[46971] = 185803",
"mask = 00011000XX0X0X10X100X10X100X10001010",
"mem[9668] = 13243",
"mem[30347] = 407",
"mem[54101] = 713",
"mem[51142] = 8233",
"mask = 1X0111110XX00X1X0101100XX101011X011X",
"mem[16930] = 515662323",
"mem[21031] = 2533",
"mem[17436] = 218397",
"mem[56376] = 234929",
"mem[58130] = 2182770",
"mask = 100101110X000011010XX001000001001X00",
"mem[5488] = 960938",
"mem[14175] = 2152023",
"mem[59102] = 11566266",
"mask = 100110XX000X000X1X0111001XX000X10101",
"mem[18182] = 8128000",
"mem[49925] = 131846006",
"mem[62116] = 15650072",
"mem[46990] = 151839329",
"mem[43603] = 620693",
"mem[2789] = 8328",
"mask = 100X1111X00010X1110XX0001XX110101X0X",
"mem[18401] = 17692",
"mem[50456] = 440902",
"mem[17330] = 279",
"mem[59750] = 33221135",
"mem[31693] = 70423",
"mask = 10111X110X0XX100110X1100X001100XX100",
"mem[52781] = 4489",
"mem[18147] = 867156",
"mem[18868] = 27576534",
"mem[6154] = 11354",
"mask = 0001100011010010XX0011X01110100X1011",
"mem[15739] = 1007100",
"mem[40713] = 2065",
"mem[28161] = 480169723",
"mask = 1001X011X00X00XX10011000011100010111",
"mem[9268] = 1098145",
"mem[47853] = 1578",
"mem[21878] = 77227",
"mem[19460] = 7790500",
"mask = 1001101X000X00011X0111X00X101X1X010X",
"mem[46674] = 958287",
"mem[53615] = 818124",
"mem[3589] = 565",
"mask = 10011X11110010011X01X1111100X1X10111",
"mem[2313] = 525996",
"mem[49115] = 3778",
"mask = 10111X1000100010X0110X00010000101X10",
"mem[22795] = 929",
"mem[25613] = 49541543",
"mem[55341] = 82425453",
"mem[57618] = 4843",
"mask = 1X0110X100X1000X11011100X11X111X0100",
"mem[50268] = 95980543",
"mem[12052] = 29335",
"mem[3157] = 6358",
"mem[5098] = 1837",
"mask = X001001X101X0X11011X11X10101011X11X1",
"mem[31123] = 898",
"mem[62473] = 3807",
"mem[37224] = 714",
"mask = 100100X11XX0X001010100101001X0X01000",
"mem[8298] = 2971396",
"mem[43046] = 1813984",
"mem[2032] = 45861947",
"mem[5446] = 165487035",
"mem[12116] = 13116803",
"mask = 00X11X110001001111XXXX0X1101000X1000",
"mem[61602] = 21080561",
"mem[39281] = 264135",
"mask = XX011111010010000X01111X0X1X0111X101",
"mem[18195] = 3425",
"mem[46686] = 2340009",
"mem[53292] = 412",
"mask = 1001110X0X00XX10101111X00X00X00XX101",
"mem[38483] = 252045771",
"mem[63109] = 26212",
"mem[59510] = 9045343",
"mem[54600] = 9681811",
"mask = 100X101000110X0111XX110X0010XX000100",
"mem[41461] = 42716629",
"mem[64930] = 520393",
"mem[28447] = 151770",
"mask = 10X110X01X00000X10011001X1100X000000",
"mem[3773] = 104516831",
"mem[40238] = 4000",
"mem[58211] = 678635",
"mem[40487] = 223654851",
"mask = 100XXX110000X00X0X0111X0X01100110101",
"mem[23993] = 2197243",
"mem[20277] = 12369255",
"mem[3832] = 130058039",
"mem[1960] = 1027399",
"mask = 10011X1100X11111X10X10X00X101X111100",
"mem[37224] = 16913616",
"mem[5556] = 34375592",
"mask = 10010011X10000XXX111011X0XXX010X0100",
"mem[37398] = 15577847",
"mem[12387] = 1354",
"mem[30934] = 109585488",
"mem[41909] = 126",
"mem[52787] = 7576",
"mem[25374] = 508",
"mask = X0X0111100001X01110X010000X111X0X0X1",
"mem[56527] = 15456",
"mem[53539] = 524739437",
"mem[11052] = 249668931",
"mem[35427] = 864899",
"mem[55896] = 258373365",
"mem[61023] = 33688914",
"mask = 10X100110XX00X11111X01X0110010000110",
"mem[54305] = 1039",
"mem[10304] = 15039",
"mem[50914] = 360879545",
"mem[5839] = 7156",
"mask = 1X1111110000X00X100X1X00XX1000110X1X",
"mem[18182] = 24257615",
"mem[64162] = 3209",
"mem[5152] = 512240",
"mem[17141] = 8347231",
"mask = 100XX01111X000011X1100101X0X11010000",
"mem[29847] = 13294167",
"mem[64696] = 22549502",
"mem[27862] = 21958485",
"mem[64644] = 6239",
"mem[37344] = 833043",
"mask = 111110X101010XX110010X001X00X0X1X100",
"mem[18147] = 52335",
"mem[31383] = 132458715",
"mem[24474] = 4542",
"mem[43601] = 4175",
"mask = X001X0XX0X000010010001100100X10X01XX",
"mem[29464] = 2362363",
"mem[43423] = 789506",
"mem[45314] = 659",
"mem[49371] = 649",
"mask = 1001001X0X000X1XX111001000011X0X0X10",
"mem[39828] = 71",
"mem[15204] = 14250",
"mem[34996] = 50623",
"mem[65214] = 2926",
"mem[2472] = 13322",
"mem[18500] = 10766",
"mem[7987] = 844328",
"mask = 1X101X110XX0X0011X0111100XX000X00101",
"mem[41988] = 1267",
"mem[38877] = 5905",
"mem[34356] = 404713788",
"mem[17832] = 28887",
"mem[50228] = 231480263",
"mem[2306] = 16119072",
"mem[40210] = 53486",
"mask = 0X010011010XX0010X011011010000010010",
"mem[33667] = 616",
"mem[28886] = 261243",
"mem[17514] = 105844800",
"mem[19196] = 28362",
"mem[9042] = 248",
"mask = 10111011000110X1011110XX0XX0X10X1011",
"mem[38562] = 171280",
"mem[38018] = 6794823",
"mem[52787] = 965807",
"mem[3338] = 920483750",
"mem[32826] = 1507",
"mem[19459] = 20161",
"mem[21391] = 519434",
"mask = 1X0110100X00X000110001111000X1000110",
"mem[42067] = 616492",
"mem[36918] = 25623",
"mem[46004] = 49289911",
"mem[8554] = 16175",
"mem[13064] = 489",
"mem[44673] = 26",
"mask = X0X110X1000110X1X11XX1111X0011000010",
"mem[29648] = 21170",
"mem[40969] = 873",
"mem[43140] = 1547",
"mem[33038] = 795",
"mask = XX01101000000X011001000011X001100100",
"mem[52652] = 117541",
"mem[62373] = 4021",
"mem[2132] = 80485627",
"mem[30347] = 12623892",
"mask = 100111110X0X100X00XX11X0011100X10100",
"mem[63788] = 1954",
"mem[49775] = 113661",
"mem[22932] = 2660",
"mem[1242] = 2246936",
"mem[61232] = 59505106",
"mem[16421] = 771",
"mem[2032] = 521982",
"mask = X000X0110X100001010X1100XX00X0X11000",
"mem[5839] = 675146",
"mem[17449] = 3913865",
"mem[38220] = 565003",
"mask = 1XX110110XX10X011101X1010X01100011XX",
"mem[43177] = 3673",
"mem[62722] = 297693589",
"mem[44199] = 2814809",
"mem[35355] = 409",
"mem[6053] = 28308115",
"mask = 100110X00001000110011110XX1XX0X1X00X",
"mem[50657] = 936",
"mem[12122] = 398228",
"mem[10356] = 16047544",
"mask = 100X10X0XX0X000010011X01100000XX1X10",
"mem[63929] = 181491",
"mem[24380] = 27034111",
"mask = 100100111X0000101111010X000011110XX1",
"mem[62207] = 7765",
"mem[57429] = 7439614",
"mask = X0X110110X00X110X10X101101011X000000",
"mem[26000] = 18",
"mem[33929] = 835347",
"mem[63788] = 650594681",
"mask = 0001X110100X000101XX000X01X001000X00",
"mem[428] = 3125",
"mem[33893] = 5619",
"mask = 1111X0110X0101XX1X0101XX0111100X110X",
"mem[45851] = 2242668",
"mem[50198] = 2816909",
"mem[23194] = 641710634",
"mask = 1001101X00X100011X011110X01X01000XX0",
"mem[24925] = 30753",
"mem[34996] = 416833",
"mem[60343] = 197936",
"mem[2789] = 102827",
"mask = 10011011X00X101111X11111010010X0X000",
"mem[46480] = 271491133",
"mem[64644] = 499905229",
"mem[40131] = 347021906",
"mask = X00000X1X110001101X1X000100010111001",
"mem[17028] = 1095",
"mem[33960] = 15058",
"mem[55537] = 125799",
"mask = 10011011000XXX1X1101XX1101001XX00X00",
"mem[13716] = 27046206",
"mem[60782] = 160372",
"mem[64423] = 162341740",
"mem[49430] = 1723537",
"mask = 000X001010001X0101011X000100000X0011",
"mem[51741] = 43078104",
"mem[40131] = 54961",
"mem[22080] = 320749",
"mem[53762] = 405633",
"mask = 1X0X10100X00X001100XXX00010000010100",
"mem[28234] = 1982",
"mem[49089] = 974",
"mem[19731] = 601533",
"mem[61660] = 14748",
"mem[34916] = 64727",
"mem[61508] = 117824",
"mem[3687] = 52691",
"mask = X00100110XX000010X011000010000011000",
"mem[2481] = 107587294",
"mem[60603] = 21191",
"mem[40131] = 387944437",
"mem[56086] = 5350",
"mask = 1001X01111X0000X0XX1X000X00X1000X110",
"mem[15738] = 4288",
"mem[43298] = 1461",
"mem[17028] = 1639506",
"mem[26818] = 3648",
"mask = 0X00001X011010110001X0X1X1X0X00101X0",
"mem[58246] = 7619072",
"mem[54699] = 111003254",
"mem[5508] = 11269223",
"mem[4564] = 55473",
"mem[13407] = 206001",
"mem[43960] = 3133869",
"mem[41293] = 900",
"mask = 101XX01100X10010X1000001XX00X0000111",
"mem[47122] = 878",
"mem[39296] = 39508",
"mem[9582] = 4752735",
"mem[6502] = 3641",
"mem[9231] = 9184312",
"mem[15752] = 1582915",
"mask = 10011X000000X0X010X11X0X0X000001X011",
"mem[50765] = 984938",
"mem[51495] = 562",
"mem[10747] = 108482",
"mask = X0010X1X0X00001X01XX00X101X101000110",
"mem[49920] = 5623",
"mem[55819] = 697033",
"mem[38018] = 20713002",
"mask = 1011111X0000100010X11X0001X00X110010",
"mem[36918] = 756231",
"mem[14025] = 93183188",
"mem[59608] = 204236",
"mem[50268] = 125445",
"mem[13923] = 213227",
"mask = 10011010000X000110X1XX010XX0111X0100",
"mem[34116] = 303566",
"mem[23805] = 279259915",
"mem[21435] = 59209228",
"mem[16734] = 958",
"mem[47755] = 434023907",
"mem[60709] = 13033",
"mask = 1001011001000010011XX1X01X0100X0XX11",
"mem[64325] = 20999",
"mem[7987] = 38810809",
"mem[2895] = 166229974",
"mask = X0X110X00XX00XX01XX10100110100100111",
"mem[23822] = 853",
"mem[45314] = 750865",
"mem[6665] = 107773",
"mem[9473] = 131837925",
"mask = 1X11111100XX000010011X0000X10001X00X",
"mem[14175] = 348460",
"mem[822] = 19418535",
"mask = 1001111X0000001101011110001X0001X10X",
"mem[42090] = 2464",
"mem[12052] = 628801",
"mem[39669] = 3631",
"mem[17801] = 2342",
"mask = 1001X011X0X0000101011X0011X11101X1X1",
"mem[32805] = 705539",
"mem[17514] = 992075",
"mem[43384] = 70694",
"mask = X0010011XXX000010101100001011XX0X001",
"mem[65498] = 6327",
"mem[64423] = 66942342",
"mem[45851] = 915243189",
"mem[51543] = 179320037",
"mem[56376] = 5912372",
"mem[38020] = 1815548",
"mem[27381] = 101528557",
"mask = 1001X0111XX000X101X1X11X0101111101X1",
"mem[22199] = 2609",
"mem[60933] = 212368654",
"mem[39198] = 118067182",
"mem[35665] = 8022855",
"mask = 100110X1000111XX110110X1X10111X01100",
"mem[48703] = 7655",
"mem[7735] = 25921",
"mem[57062] = 306051780",
"mem[58402] = 49485",
"mem[34776] = 1499",
"mask = 00010X101000X00101X1000XX1000X000000",
"mem[55875] = 635485",
"mem[64773] = 1823",
"mem[32805] = 238304",
"mask = X00X001111X0X001X1000X01100000X11010",
"mem[7336] = 2832487",
"mem[7735] = 593",
"mem[61739] = 56110",
"mem[43710] = 78470470"
            };
        }
    }
}
