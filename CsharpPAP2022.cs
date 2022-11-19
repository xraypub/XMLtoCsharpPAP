// -- Version-Datetime: Sat Nov 19 18:47:29 2022


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace YourNamespaceHere
{

internal class PAP2022Data
{



/* <!-- PROGRAMMABLAUFPLAN, PAP Seite 14 -->
    < MAIN >
      <EXECUTE method = "MPARA" / >
      <EXECUTE method = "MRE4JL" / >
       <EVAL exec = "VBEZBSO= BigDecimal.ZERO" / >
       <EVAL exec = "KENNVMT= 0" / >
       <EXECUTE method = "MRE4" / >
       <EXECUTE method = "MRE4ABZ" / >
       <EXECUTE method = "MBERECH" / >
       <EXECUTE method = "MSONST" / >
       <EXECUTE method = "MVMT" / >
    < / MAIN> */


// INPUT Properties -----------------------

private  int  _af = 1;

public   int af
        {
          get { return _af;  }
          set {

          if ( _af != value) {
               _af = value;
            }
          }
        }

private  int  _AJAHR;

public   int AJAHR
        {
          get { return _AJAHR;  }
          set {

          if ( _AJAHR != value) {
               _AJAHR = value;
            }
          }
        }

private  int  _ALTER1;

public   int ALTER1
        {
          get { return _ALTER1;  }
          set {

          if ( _ALTER1 != value) {
               _ALTER1 = value;
            }
          }
        }

private  decimal  _ENTSCH = 0.00000m;

public   decimal ENTSCH
        {
          get { return _ENTSCH;  }
          set {

          if ( _ENTSCH != value) {
               _ENTSCH = value;
            }
          }
        }

private  double  _f = 1.0d;

public   double f
        {
          get { return _f;  }
          set {

          if ( _f != value) {
               _f = value;
            }
          }
        }

private  decimal  _JFREIB;

public   decimal JFREIB
        {
          get { return _JFREIB;  }
          set {

          if ( _JFREIB != value) {
               _JFREIB = value;
            }
          }
        }

private  decimal  _JHINZU;

public   decimal JHINZU
        {
          get { return _JHINZU;  }
          set {

          if ( _JHINZU != value) {
               _JHINZU = value;
            }
          }
        }

private  decimal  _JRE4;

public   decimal JRE4
        {
          get { return _JRE4;  }
          set {

          if ( _JRE4 != value) {
               _JRE4 = value;
            }
          }
        }

private  decimal  _JVBEZ;

public   decimal JVBEZ
        {
          get { return _JVBEZ;  }
          set {

          if ( _JVBEZ != value) {
               _JVBEZ = value;
            }
          }
        }

private  int  _KRV;

public   int KRV
        {
          get { return _KRV;  }
          set {

          if ( _KRV != value) {
               _KRV = value;
            }
          }
        }

private  decimal  _KVZ;

public   decimal KVZ
        {
          get { return _KVZ;  }
          set {

          if ( _KVZ != value) {
               _KVZ = value;
            }
          }
        }

private  int  _LZZ;

public   int LZZ
        {
          get { return _LZZ;  }
          set {

          if ( _LZZ != value) {
               _LZZ = value;
            }
          }
        }

private  decimal  _LZZFREIB;

public   decimal LZZFREIB
        {
          get { return _LZZFREIB;  }
          set {

          if ( _LZZFREIB != value) {
               _LZZFREIB = value;
            }
          }
        }

private  decimal  _LZZHINZU;

public   decimal LZZHINZU
        {
          get { return _LZZHINZU;  }
          set {

          if ( _LZZHINZU != value) {
               _LZZHINZU = value;
            }
          }
        }

private  decimal  _MBV;

public   decimal MBV
        {
          get { return _MBV;  }
          set {

          if ( _MBV != value) {
               _MBV = value;
            }
          }
        }

private  decimal  _PKPV = 0.00000m;

public   decimal PKPV
        {
          get { return _PKPV;  }
          set {

          if ( _PKPV != value) {
               _PKPV = value;
            }
          }
        }

private  int  _PKV = 0;

public   int PKV
        {
          get { return _PKV;  }
          set {

          if ( _PKV != value) {
               _PKV = value;
            }
          }
        }

private  int  _PVS = 0;

public   int PVS
        {
          get { return _PVS;  }
          set {

          if ( _PVS != value) {
               _PVS = value;
            }
          }
        }

private  int  _PVZ = 0;

public   int PVZ
        {
          get { return _PVZ;  }
          set {

          if ( _PVZ != value) {
               _PVZ = value;
            }
          }
        }

private  int  _R;

public   int R
        {
          get { return _R;  }
          set {

          if ( _R != value) {
               _R = value;
            }
          }
        }

private  decimal  _RE4;

public   decimal RE4
        {
          get { return _RE4;  }
          set {

          if ( _RE4 != value) {
               _RE4 = value;
            }
          }
        }

private  decimal  _SONSTB;

public   decimal SONSTB
        {
          get { return _SONSTB;  }
          set {

          if ( _SONSTB != value) {
               _SONSTB = value;
            }
          }
        }

private  decimal  _STERBE;

public   decimal STERBE
        {
          get { return _STERBE;  }
          set {

          if ( _STERBE != value) {
               _STERBE = value;
            }
          }
        }

private  int  _STKL;

public   int STKL
        {
          get { return _STKL;  }
          set {

          if ( _STKL != value) {
               _STKL = value;
            }
          }
        }

private  decimal  _VBEZ;

public   decimal VBEZ
        {
          get { return _VBEZ;  }
          set {

          if ( _VBEZ != value) {
               _VBEZ = value;
            }
          }
        }

private  decimal  _VBEZM;

public   decimal VBEZM
        {
          get { return _VBEZM;  }
          set {

          if ( _VBEZM != value) {
               _VBEZM = value;
            }
          }
        }

private  decimal  _VBEZS;

public   decimal VBEZS
        {
          get { return _VBEZS;  }
          set {

          if ( _VBEZS != value) {
               _VBEZS = value;
            }
          }
        }

private  decimal  _VBS;

public   decimal VBS
        {
          get { return _VBS;  }
          set {

          if ( _VBS != value) {
               _VBS = value;
            }
          }
        }

private  int  _VJAHR;

public   int VJAHR
        {
          get { return _VJAHR;  }
          set {

          if ( _VJAHR != value) {
               _VJAHR = value;
            }
          }
        }

private  decimal  _VKAPA;

public   decimal VKAPA
        {
          get { return _VKAPA;  }
          set {

          if ( _VKAPA != value) {
               _VKAPA = value;
            }
          }
        }

private  decimal  _VMT;

public   decimal VMT
        {
          get { return _VMT;  }
          set {

          if ( _VMT != value) {
               _VMT = value;
            }
          }
        }

private  decimal  _ZKF;

public   decimal ZKF
        {
          get { return _ZKF;  }
          set {

          if ( _ZKF != value) {
               _ZKF = value;
            }
          }
        }

private  int  _ZMVB;

public   int ZMVB
        {
          get { return _ZMVB;  }
          set {

          if ( _ZMVB != value) {
               _ZMVB = value;
            }
          }
        }

private  decimal  _JRE4ENT;

public   decimal JRE4ENT
        {
          get { return _JRE4ENT;  }
          set {

          if ( _JRE4ENT != value) {
               _JRE4ENT = value;
            }
          }
        }

private  decimal  _SONSTENT;

public   decimal SONSTENT
        {
          get { return _SONSTENT;  }
          set {

          if ( _SONSTENT != value) {
               _SONSTENT = value;
            }
          }
        }

// OUTPUT Properties ---------------------

private  decimal  _BK = 0.00000m;

public   decimal BK
        {
          get { return _BK;  }
          set {

          if ( _BK != value) {
               _BK = value;
            }
          }
        }

private  decimal  _BKS = 0.00000m;

public   decimal BKS
        {
          get { return _BKS;  }
          set {

          if ( _BKS != value) {
               _BKS = value;
            }
          }
        }

private  decimal  _BKV = 0.00000m;

public   decimal BKV
        {
          get { return _BKV;  }
          set {

          if ( _BKV != value) {
               _BKV = value;
            }
          }
        }

private  decimal  _LSTLZZ = 0.00000m;

public   decimal LSTLZZ
        {
          get { return _LSTLZZ;  }
          set {

          if ( _LSTLZZ != value) {
               _LSTLZZ = value;
            }
          }
        }

private  decimal  _SOLZLZZ = 0.00000m;

public   decimal SOLZLZZ
        {
          get { return _SOLZLZZ;  }
          set {

          if ( _SOLZLZZ != value) {
               _SOLZLZZ = value;
            }
          }
        }

private  decimal  _SOLZS = 0.00000m;

public   decimal SOLZS
        {
          get { return _SOLZS;  }
          set {

          if ( _SOLZS != value) {
               _SOLZS = value;
            }
          }
        }

private  decimal  _SOLZV = 0.00000m;

public   decimal SOLZV
        {
          get { return _SOLZV;  }
          set {

          if ( _SOLZV != value) {
               _SOLZV = value;
            }
          }
        }

private  decimal  _STS = 0.00000m;

public   decimal STS
        {
          get { return _STS;  }
          set {

          if ( _STS != value) {
               _STS = value;
            }
          }
        }

private  decimal  _STV = 0.00000m;

public   decimal STV
        {
          get { return _STV;  }
          set {

          if ( _STV != value) {
               _STV = value;
            }
          }
        }

private  decimal  _VKVLZZ = 0.00000m;

public   decimal VKVLZZ
        {
          get { return _VKVLZZ;  }
          set {

          if ( _VKVLZZ != value) {
               _VKVLZZ = value;
            }
          }
        }

private  decimal  _VKVSONST = 0.00000m;

public   decimal VKVSONST
        {
          get { return _VKVSONST;  }
          set {

          if ( _VKVSONST != value) {
               _VKVSONST = value;
            }
          }
        }

private  decimal  _VFRB = 0.00000m;

public   decimal VFRB
        {
          get { return _VFRB;  }
          set {

          if ( _VFRB != value) {
               _VFRB = value;
            }
          }
        }

private  decimal  _VFRBS1 = 0.00000m;

public   decimal VFRBS1
        {
          get { return _VFRBS1;  }
          set {

          if ( _VFRBS1 != value) {
               _VFRBS1 = value;
            }
          }
        }

private  decimal  _VFRBS2 = 0.00000m;

public   decimal VFRBS2
        {
          get { return _VFRBS2;  }
          set {

          if ( _VFRBS2 != value) {
               _VFRBS2 = value;
            }
          }
        }

private  decimal  _WVFRB = 0.00000m;

public   decimal WVFRB
        {
          get { return _WVFRB;  }
          set {

          if ( _WVFRB != value) {
               _WVFRB = value;
            }
          }
        }

private  decimal  _WVFRBO = 0.00000m;

public   decimal WVFRBO
        {
          get { return _WVFRBO;  }
          set {

          if ( _WVFRBO != value) {
               _WVFRBO = value;
            }
          }
        }

private  decimal  _WVFRBM = 0.00000m;

public   decimal WVFRBM
        {
          get { return _WVFRBM;  }
          set {

          if ( _WVFRBM != value) {
               _WVFRBM = value;
            }
          }
        }

// INTERNAL Fields ------------------------

public  decimal  ALTE = 0.00000m;


public  decimal  ANP = 0.00000m;


public  decimal  ANTEIL1 = 0.00000m;


public  decimal  BMG = 0.00000m;


public  decimal  BBGKVPV = 0.00000m;


public  decimal  bd = 0.00000m;


public  decimal  BBGRV = 0.00000m;


public  decimal  DIFF = 0.00000m;


public  decimal  EFA = 0.00000m;


public  decimal  FVB = 0.00000m;


public  decimal  FVBSO = 0.00000m;


public  decimal  FVBZ = 0.00000m;


public  decimal  FVBZSO = 0.00000m;


public  decimal  GFB = 0.00000m;


public  decimal  HBALTE = 0.00000m;


public  decimal  HFVB = 0.00000m;


public  decimal  HFVBZ = 0.00000m;


public  decimal  HFVBZSO = 0.00000m;


public  int  J = 0;


public  decimal  JBMG = 0.00000m;


public  decimal  JLFREIB = 0.00000m;


public  decimal  JLHINZU = 0.00000m;


public  decimal  JW = 0.00000m;


public  int  K = 0;


public  int  KENNVMT = 0;


public  decimal  KFB = 0.00000m;


public  decimal  KVSATZAG = 0.00000m;


public  decimal  KVSATZAN = 0.00000m;


public  int  KZTAB = 0;


public  decimal  LSTJAHR = 0.00000m;


public  decimal  LST1 = 0.00000m;


public  decimal  LST2 = 0.00000m;


public  decimal  LST3 = 0.00000m;


public  decimal  LSTOSO = 0.00000m;


public  decimal  LSTSO = 0.00000m;


public  decimal  MIST = 0.00000m;


public  decimal  PVSATZAG = 0.00000m;


public  decimal  PVSATZAN = 0.00000m;


public  decimal  RVSATZAN = 0.00000m;


public  decimal  RW = 0.00000m;


public  decimal  SAP = 0.00000m;


public  decimal  SOLZFREI = 0.00000m;


public  decimal  SOLZJ = 0.00000m;


public  decimal  SOLZMIN = 0.00000m;


public  decimal  SOLZSBMG = 0.00000m;


public  decimal  SOLZSZVE = 0.00000m;


public  decimal  SOLZVBMG = 0.00000m;


public  decimal  ST = 0.00000m;


public  decimal  ST1 = 0.00000m;


public  decimal  ST2 = 0.00000m;


public  decimal  STOVMT = 0.00000m;


public  decimal  TBSVORV = 0.00000m;


public  decimal  VBEZB = 0.00000m;


public  decimal  VBEZBSO = 0.00000m;


public  decimal  VHB = 0.00000m;


public  decimal  VSP = 0.00000m;


public  decimal  VSPN = 0.00000m;


public  decimal  VSP1 = 0.00000m;


public  decimal  VSP2 = 0.00000m;


public  decimal  VSP3 = 0.00000m;


public  decimal  W1STKL5 = 0.00000m;


public  decimal  W2STKL5 = 0.00000m;


public  decimal  W3STKL5 = 0.00000m;


public  decimal  VSPMAX1 = 0.00000m;


public  decimal  VSPMAX2 = 0.00000m;


public  decimal  VSPO = 0.00000m;


public  decimal  VSPREST = 0.00000m;


public  decimal  VSPVOR = 0.00000m;


public  decimal  X = 0.00000m;


public  decimal  Y = 0.00000m;


public  decimal  ZRE4 = 0.00000m;


public  decimal  ZRE4J = 0.00000m;


public  decimal  ZRE4VP = 0.00000m;


public  decimal  ZTABFB = 0.00000m;


public  decimal  ZVBEZ = 0.00000m;


public  decimal  ZVBEZJ = 0.00000m;


public  decimal  ZVE = 0.00000m;


public  decimal  ZX = 0.00000m;


public  decimal  ZZX = 0.00000m;


public  decimal  HOCH = 0.00000m;


public  decimal  VERGL = 0.00000m;


public  decimal  VKV = 0.00000m;


// CONSTANTS --------------------------

public readonly  List<decimal> TAB1 = new() { 0.0m, 0.4m, 0.384m, 0.368m, 0.352m, 0.336m, 0.32m, 0.304m, 0.288m, 0.272m, 0.256m, 0.24m, 0.224m, 0.208m, 0.192m, 0.176m, 0.16m, 0.152m, 0.144m, 0.136m, 0.128m, 0.12m, 0.112m, 0.104m, 0.096m, 0.088m, 0.08m, 0.072m, 0.064m, 0.056m, 0.048m, 0.04m, 0.032m, 0.024m, 0.016m, 0.008m, 0.0m };

public readonly  List<decimal> TAB2 = new() { 0m, 3000m, 2880m, 2760m, 2640m, 2520m, 2400m, 2280m, 2160m, 2040m, 1920m, 1800m, 1680m, 1560m, 1440m, 1320m, 1200m, 1140m, 1080m, 1020m, 960m, 900m, 840m, 780m, 720m, 660m, 600m, 540m, 480m, 420m, 360m, 300m, 240m, 180m, 120m, 60m, 0m };

public readonly  List<decimal> TAB3 = new() { 0m, 900m, 864m, 828m, 792m, 756m, 720m, 684m, 648m, 612m, 576m, 540m, 504m, 468m, 432m, 396m, 360m, 342m, 324m, 306m, 288m, 270m, 252m, 234m, 216m, 198m, 180m, 162m, 144m, 126m, 108m, 90m, 72m, 54m, 36m, 18m, 0m };

public readonly  List<decimal> TAB4 = new() { 0.0m, 0.4m, 0.384m, 0.368m, 0.352m, 0.336m, 0.32m, 0.304m, 0.288m, 0.272m, 0.256m, 0.24m, 0.224m, 0.208m, 0.192m, 0.176m, 0.16m, 0.152m, 0.144m, 0.136m, 0.128m, 0.12m, 0.112m, 0.104m, 0.096m, 0.088m, 0.08m, 0.072m, 0.064m, 0.056m, 0.048m, 0.04m, 0.032m, 0.024m, 0.016m, 0.008m, 0.0m };

public readonly  List<decimal> TAB5 = new() { 0m, 1900m, 1824m, 1748m, 1672m, 1596m, 1520m, 1444m, 1368m, 1292m, 1216m, 1140m, 1064m, 988m, 912m, 836m, 760m, 722m, 684m, 646m, 608m, 570m, 532m, 494m, 456m, 418m, 380m, 342m, 304m, 266m, 228m, 190m, 152m, 114m, 76m, 38m, 0m };

public readonly  decimal ZAHL1 = 1m;

public readonly  decimal ZAHL2 = 2m;

public readonly  decimal ZAHL5 = 5m;

public readonly  decimal ZAHL7 = 7m;

public readonly  decimal ZAHL12 = 12m;

public readonly  decimal ZAHL100 = 100m;

public readonly  decimal ZAHL360 = 360m;

public readonly  decimal ZAHL500 = 500m;

public readonly  decimal ZAHL700 = 700m;

public readonly  decimal ZAHL1000 = 1000m;

public readonly  decimal ZAHL10000 = 10000m;



// Method Begin:  MPARA--------------------------------------------------------


public void MPARA()
        {

         if ( KRV < 2 ) 

           {

              //to do's

         if ( KRV == 0 ) 

           {

              //to do's


                BBGRV = 84600m;


           }
        
         else
            {
              //to do's


                BBGRV = 81000m;


            }


                RVSATZAN = 0.093m;


                TBSVORV = 0.88m;


           }
        
         else
            {
              //to do's


            }


                BBGKVPV = 58050m;


                bd = 2m;


                KVSATZAN = (KVZ / (bd) / (ZAHL100)) + (0.07m);


                KVSATZAG = 0.0065m + 0.07m;

         if ( PVS == 1 ) 

           {

              //to do's


                PVSATZAN = 0.02025m;


                PVSATZAG = 0.01025m;


           }
        
         else
            {
              //to do's


                PVSATZAN =  0.01525m;


                PVSATZAG =  0.01525m;


            }

         if ( PVZ == 1 ) 

           {

              //to do's


                PVSATZAN = PVSATZAN + (0.0035m);


           }

                W1STKL5 = 11793m;


                W2STKL5 = 29298m;


                W3STKL5 = 222260m;


                GFB = 10347m;


                SOLZFREI = 16956m;

        }// End of Method:  MPARA





// Method Begin:  MRE4JL--------------------------------------------------------


public void MRE4JL()
        {

         if ( LZZ == 1 ) 

           {

              //to do's


                ZRE4J = Decimal.Floor( ( RE4 / ZAHL100) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( ( VBEZ / ZAHL100) * 100m ) / 100m;


                JLFREIB = Decimal.Floor( ( LZZFREIB / ZAHL100) * 100m ) / 100m;


                JLHINZU = Decimal.Floor( ( LZZHINZU / ZAHL100) * 100m ) / 100m;


           }
        
         else
            {
              //to do's

         if ( LZZ == 2 ) 

           {

              //to do's


                ZRE4J = Decimal.Floor( ( (RE4 *  (ZAHL12)) / ZAHL100) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( ( (VBEZ *  (ZAHL12)) / ZAHL100) * 100m ) / 100m;


                JLFREIB = Decimal.Floor( ( (LZZFREIB *  (ZAHL12)) / ZAHL100) * 100m ) / 100m;


                JLHINZU = Decimal.Floor( ( (LZZHINZU *  (ZAHL12)) / ZAHL100) * 100m ) / 100m;


           }
        
         else
            {
              //to do's

         if ( LZZ == 3 ) 

           {

              //to do's


                ZRE4J = Decimal.Floor( ( (RE4 *  (ZAHL360)) / ZAHL700) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( ( (VBEZ *  (ZAHL360)) / ZAHL700) * 100m ) / 100m;


                JLFREIB = Decimal.Floor( ( (LZZFREIB *  (ZAHL360)) / ZAHL700) * 100m ) / 100m;


                JLHINZU = Decimal.Floor( ( (LZZHINZU *  (ZAHL360)) / ZAHL700) * 100m ) / 100m;


           }
        
         else
            {
              //to do's


                ZRE4J = Decimal.Floor( ( (RE4 *  (ZAHL360)) / ZAHL100) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( ( (VBEZ *  (ZAHL360)) / ZAHL100) * 100m ) / 100m;


                JLFREIB = Decimal.Floor( ( (LZZFREIB *  (ZAHL360)) / ZAHL100) * 100m ) / 100m;


                JLHINZU = Decimal.Floor( ( (LZZHINZU *  (ZAHL360)) / ZAHL100) * 100m ) / 100m;


            }


            }


            }

         if ( af == 0 ) 

           {

              //to do's


                f= 1;


           }
        }// End of Method:  MRE4JL





// Method Begin:  MRE4--------------------------------------------------------


public void MRE4()
        {

         if ( ZVBEZJ.CompareTo (Decimal.Zero) == 0 ) 

           {

              //to do's


                FVBZ= Decimal.Zero;


                FVB= Decimal.Zero;


                FVBZSO= Decimal.Zero;


                FVBSO= Decimal.Zero;


           }
        
         else
            {
              //to do's

         if ( VJAHR < 2006 ) 

           {

              //to do's


                J= 1;


           }
        
         else
            {
              //to do's

         if ( VJAHR < 2040 ) 

           {

              //to do's


                J= VJAHR - 2004;


           }
        
         else
            {
              //to do's


                J= 36;


            }


            }

         if ( LZZ == 1 ) 

           {

              //to do's


                VBEZB= (VBEZM *  ( (decimal) ZMVB)) +  (VBEZS);


                HFVB= TAB2[J] /  (ZAHL12) *  ( (decimal) ZMVB);


                FVBZ = Decimal.Ceiling( (  TAB3[J] /  (ZAHL12) *  ( (decimal) ZMVB) ) ) ;


           }
        
         else
            {
              //to do's


                VBEZB = Decimal.Floor( (  ((VBEZM *  (ZAHL12)) +  (VBEZS)) ) * 100m ) / 100m;


                HFVB= TAB2[J];


                FVBZ= TAB3[J];


            }


                FVB = Decimal.Ceiling( (  ((VBEZB *  (TAB1[J]))) /  (ZAHL100) ) * 100m ) / 100m;

         if ( FVB.CompareTo (HFVB) == 1 ) 

           {

              //to do's


                FVB = HFVB;


           }
         if ( FVB.CompareTo (ZVBEZJ) == 1 ) 

           {

              //to do's


                FVB = ZVBEZJ;


           }

                FVBSO = Decimal.Ceiling( (  (FVB + ((VBEZBSO *  (TAB1[J])) /  (ZAHL100))) ) * 100m ) / 100m;

         if ( FVBSO.CompareTo (TAB2[J]) == 1 ) 

           {

              //to do's


                FVBSO = TAB2[J];


           }

                HFVBZSO = Decimal.Floor( (  (((VBEZB + (VBEZBSO)) /  (ZAHL100)) -  (FVBSO)) ) * 100m ) / 100m;


                FVBZSO = Decimal.Ceiling( (  (FVBZ + ((VBEZBSO) /  (ZAHL100))) ) ) ;

         if ( FVBZSO.CompareTo (HFVBZSO) == 1 ) 

           {

              //to do's


                FVBZSO  = Decimal.Ceiling( (  HFVBZSO ) ) ;


           }
         if ( FVBZSO.CompareTo (TAB3[J]) == 1 ) 

           {

              //to do's


                FVBZSO = TAB3[J];


           }

                HFVBZ = Decimal.Floor( (  ((VBEZB /  (ZAHL100)) -  (FVB)) ) * 100m ) / 100m;

         if ( FVBZ.CompareTo (HFVBZ) == 1 ) 

           {

              //to do's


                FVBZ  = Decimal.Ceiling( (  HFVBZ ) ) ;


           }

            }


                MRE4ALTE();

        }// End of Method:  MRE4





// Method Begin:  MRE4ALTE--------------------------------------------------------


public void MRE4ALTE()
        {

         if ( ALTER1 == 0 ) 

           {

              //to do's


                ALTE= Decimal.Zero;


           }
        
         else
            {
              //to do's

         if ( AJAHR < 2006 ) 

           {

              //to do's


                K= 1;


           }
        
         else
            {
              //to do's

         if ( AJAHR < 2040 ) 

           {

              //to do's


                K= AJAHR - 2004;


           }
        
         else
            {
              //to do's


                K= 36;


            }


            }


                BMG= ZRE4J -  (ZVBEZJ);


                ALTE  = Decimal.Ceiling( (  (BMG * (TAB4[K])) ) ) ;


                HBALTE= TAB5[K];

         if ( ALTE.CompareTo (HBALTE) == 1 ) 

           {

              //to do's


                ALTE= HBALTE;


           }

            }

        }// End of Method:  MRE4ALTE





// Method Begin:  MRE4ABZ--------------------------------------------------------


public void MRE4ABZ()
        {


                ZRE4 = Decimal.Floor( (  (ZRE4J -  (FVB) -    (ALTE) -  (JLFREIB) +  (JLHINZU)) ) * 100m ) / 100m;

         if ( ZRE4.CompareTo (Decimal.Zero) == -1 ) 

           {

              //to do's


                ZRE4= Decimal.Zero;


           }

                ZRE4VP= ZRE4J;

         if ( KENNVMT == 2 ) 

           {

              //to do's


                ZRE4VP  = Decimal.Floor( (  ZRE4VP - (ENTSCH / (ZAHL100)) ) * 100m ) / 100m;


           }

                ZVBEZ  = Decimal.Floor( (  ZVBEZJ - (FVB) ) * 100m ) / 100m;

         if ( ZVBEZ.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's


                ZVBEZ = Decimal.Zero;


           }
        }// End of Method:  MRE4ABZ





// Method Begin:  MBERECH--------------------------------------------------------


public void MBERECH()
        {


                MZTABFB();


                VFRB  = Decimal.Floor(   ((ANP + (FVB + (FVBZ))) * (ZAHL100))  ) ;


                MLSTJAHR();


                WVFRB  = Decimal.Floor(   ((ZVE - (GFB)) * (ZAHL100))  ) ;

         if ( WVFRB.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's


                WVFRB =  0m ;


           }

                LSTJAHR  = Decimal.Floor(   (ST * ( (decimal) f))  ) ;


                UPLSTLZZ();


                UPVKVLZZ();

         if ( ZKF.CompareTo(Decimal.Zero) == 1 ) 

           {

              //to do's


                ZTABFB = ZTABFB + (KFB);


                MRE4ABZ();


                MLSTJAHR();


                JBMG  = Decimal.Floor(   (ST * ( (decimal) f))  ) ;


           }
        
         else
            {
              //to do's


                JBMG = LSTJAHR;


            }


                MSOLZ();

        }// End of Method:  MBERECH





// Method Begin:  MZTABFB--------------------------------------------------------


public void MZTABFB()
        {


                ANP= Decimal.Zero;

         if ( ZVBEZ.CompareTo (Decimal.Zero) >= 0 && ZVBEZ.CompareTo(FVBZ) == -1 ) 

           {

              //to do's


                FVBZ =  (decimal) Math.Truncate( ZVBEZ );


           }
         if ( STKL < 6 ) 

           {

              //to do's

         if ( ZVBEZ.CompareTo (Decimal.Zero) == 1 ) 

           {

              //to do's

         if ( (ZVBEZ -  (FVBZ)).CompareTo (102m) == -1 ) 

           {

              //to do's


                ANP = Decimal.Ceiling( (  (ZVBEZ -  (FVBZ)) ) ) ;


           }
        
         else
            {
              //to do's


                ANP= 102m;


            }


           }

           }
        
         else
            {
              //to do's


                FVBZ= 0m;


                FVBZSO= 0m;


            }

         if ( STKL < 6 ) 

           {

              //to do's

         if ( ZRE4.CompareTo(ZVBEZ) == 1 ) 

           {

              //to do's

         if ( ZRE4 - (ZVBEZ).CompareTo(1200m) == -1 ) 

           {

              //to do's


                ANP  = Decimal.Ceiling( (  ANP + (ZRE4) - (ZVBEZ) ) ) ;


           }
        
         else
            {
              //to do's


                ANP = ANP + (1200m);


            }


           }

           }

                KZTAB= 1;

         if ( STKL == 1 ) 

           {

              //to do's


                SAP= 36m;


                KFB = Decimal.Floor(   (ZKF *  (8388m))  ) ;


           }
        
         else
            {
              //to do's

         if ( STKL == 2 ) 

           {

              //to do's


                EFA= 4008m;


                SAP= 36m;


                KFB = Decimal.Floor(   (ZKF *  (8388m))  ) ;


           }
        
         else
            {
              //to do's

         if ( STKL == 3 ) 

           {

              //to do's


                KZTAB= 2;


                SAP= 36m;


                KFB = Decimal.Floor(   (ZKF *  (8388m))  ) ;


           }
        
         else
            {
              //to do's

         if ( STKL == 4 ) 

           {

              //to do's


                SAP= 36m;


                KFB = Decimal.Floor(   (ZKF *  (4194m))  ) ;


           }
        
         else
            {
              //to do's

         if ( STKL == 5 ) 

           {

              //to do's


                SAP= 36m;


                KFB= Decimal.Zero;


           }
        
         else
            {
              //to do's


                KFB= Decimal.Zero;


            }


            }


            }


            }


            }


                ZTABFB = Decimal.Floor( (  (EFA +  (ANP) +  (SAP) +  (FVBZ)) ) * 100m ) / 100m;

        }// End of Method:  MZTABFB





// Method Begin:  MLSTJAHR--------------------------------------------------------


public void MLSTJAHR()
        {


                UPEVP();

         if ( KENNVMT != 1 ) 

           {

              //to do's


                ZVE = Decimal.Floor( (  (ZRE4 -  (ZTABFB) -  (VSP)) ) * 100m ) / 100m;


                UPMLST();


           }
        
         else
            {
              //to do's


                ZVE = Decimal.Floor( (  (ZRE4 -  (ZTABFB) -  (VSP) -  ((VMT) /  (ZAHL100)) -  ((VKAPA) /  (ZAHL100))) ) * 100m ) / 100m;

         if ( ZVE.CompareTo (Decimal.Zero) == -1 ) 

           {

              //to do's


                 ZVE  = Decimal.Floor( (  ZVE + (VMT / (ZAHL100)) + (VKAPA / (ZAHL100)) / (ZAHL5) ) * 100m ) / 100m;


                UPMLST();


                ST = Decimal.Floor(   (ST *  (ZAHL5))  ) ;


           }
        
         else
            {
              //to do's


                UPMLST();


                STOVMT= ST;


                ZVE = Decimal.Floor( (  (ZVE + (((VMT +  (VKAPA)) /  (ZAHL500)))) ) * 100m ) / 100m;


                UPMLST();


                ST = Decimal.Floor(   (((ST -  (STOVMT)) *  (ZAHL5)) +  (STOVMT))  ) ;


            }


            }

        }// End of Method:  MLSTJAHR





// Method Begin:  UPVKVLZZ--------------------------------------------------------


public void UPVKVLZZ()
        {


                UPVKV();


                JW = VKV;


                UPANTEIL();


                VKVLZZ = ANTEIL1;

        }// End of Method:  UPVKVLZZ





// Method Begin:  UPVKV--------------------------------------------------------


public void UPVKV()
        {

         if ( PKV > 0 ) 

           {

              //to do's

         if ( VSP2.CompareTo(VSP3) == 1 ) 

           {

              //to do's


                VKV = VSP2 * (ZAHL100);


           }
        
         else
            {
              //to do's


                VKV = VSP3 * (ZAHL100);


            }


           }
        
         else
            {
              //to do's


                VKV = Decimal.Zero;


            }

        }// End of Method:  UPVKV





// Method Begin:  UPLSTLZZ--------------------------------------------------------


public void UPLSTLZZ()
        {


                JW = LSTJAHR * (ZAHL100);


                UPANTEIL();


                LSTLZZ = ANTEIL1;

        }// End of Method:  UPLSTLZZ





// Method Begin:  UPMLST--------------------------------------------------------


public void UPMLST()
        {

         if ( ZVE.CompareTo (ZAHL1) == -1 ) 

           {

              //to do's


                ZVE= Decimal.Zero;


                X= Decimal.Zero;


           }
        
         else
            {
              //to do's


                X = Decimal.Floor(   (ZVE /  ( (decimal) KZTAB))  ) ;


            }

         if ( STKL < 5 ) 

           {

              //to do's


                UPTAB22();


           }
        
         else
            {
              //to do's


                MST5_6();


            }

        }// End of Method:  UPMLST





// Method Begin:  UPEVP--------------------------------------------------------


public void UPEVP()
        {

         if ( KRV > 1 ) 

           {

              //to do's


                VSP1= Decimal.Zero;


           }
        
         else
            {
              //to do's

         if ( ZRE4VP.CompareTo(BBGRV) == 1 ) 

           {

              //to do's


                ZRE4VP = BBGRV;


           }

                VSP1  = Decimal.Floor( (  (TBSVORV * (ZRE4VP)) ) * 100m ) / 100m;


                VSP1  = Decimal.Floor( (  (VSP1 * (RVSATZAN)) ) * 100m ) / 100m;


            }


                VSP2  = Decimal.Floor( (  (ZRE4VP * (0.12m)) ) * 100m ) / 100m;

         if ( STKL == 3 ) 

           {

              //to do's


                VHB = 3000m;


           }
        
         else
            {
              //to do's


                VHB = 1900m;


            }

         if ( VSP2.CompareTo (VHB) == 1 ) 

           {

              //to do's


                VSP2= VHB;


           }

                VSPN = Decimal.Ceiling( (  (VSP1 +  (VSP2)) ) ) ;


                MVSP();

         if ( VSPN.CompareTo (VSP) == 1 ) 

           {

              //to do's


                VSP = Decimal.Floor( (  VSPN ) * 100m ) / 100m;


           }
        }// End of Method:  UPEVP





// Method Begin:  MVSP--------------------------------------------------------


public void MVSP()
        {

         if ( ZRE4VP.CompareTo(BBGKVPV) == 1 ) 

           {

              //to do's


                ZRE4VP = BBGKVPV;


           }
         if ( PKV > 0 ) 

           {

              //to do's

         if ( STKL == 6 ) 

           {

              //to do's


                VSP3 = Decimal.Zero;


           }
        
         else
            {
              //to do's


                VSP3 = PKPV * (ZAHL12) / (ZAHL100);

         if ( PKV == 2 ) 

           {

              //to do's


                VSP3  = Decimal.Floor( (  VSP3 - ( ZRE4VP * ( KVSATZAG + (PVSATZAG))) ) * 100m ) / 100m;


           }

            }


           }
        
         else
            {
              //to do's


                VSP3  = Decimal.Floor( (  ZRE4VP * (KVSATZAN + (PVSATZAN)) ) * 100m ) / 100m;


            }


                VSP  = Decimal.Ceiling( (  VSP3 + (VSP1) ) ) ;

        }// End of Method:  MVSP





// Method Begin:  MST5_6--------------------------------------------------------


public void MST5_6()
        {


                ZZX= X;

         if ( ZZX.CompareTo(W2STKL5) == 1 ) 

           {

              //to do's


                ZX= W2STKL5;


                UP5_6();

         if ( ZZX.CompareTo (W3STKL5) == 1 ) 

           {

              //to do's


                ST = Decimal.Floor(   (ST +  ((W3STKL5 -  (W2STKL5)) *  (0.42m)))  ) ;


                ST = Decimal.Floor(   (ST +  ((ZZX -  (W3STKL5)) *  (0.45m)))  ) ;


           }
        
         else
            {
              //to do's


                ST = Decimal.Floor(   (ST +  ((ZZX -  (W2STKL5)) *  (0.42m)))  ) ;


            }


           }
        
         else
            {
              //to do's


                ZX= ZZX;


                UP5_6();

         if ( ZZX.CompareTo (W1STKL5) == 1 ) 

           {

              //to do's


                VERGL= ST;


                ZX= W1STKL5;


                UP5_6();


                HOCH = Decimal.Floor(   (ST +  ((ZZX -  (W1STKL5)) *  (0.42m)))  ) ;

         if ( HOCH.CompareTo (VERGL) == -1 ) 

           {

              //to do's


                ST= HOCH;


           }
        
         else
            {
              //to do's


                ST= VERGL;


            }


           }

            }

        }// End of Method:  MST5_6





// Method Begin:  UP5_6--------------------------------------------------------


public void UP5_6()
        {


                X = Decimal.Floor( (  (ZX *  (1.25m)) ) * 100m ) / 100m;


                UPTAB22();


                ST1= ST;


                X = Decimal.Floor( (  (ZX *  (0.75m)) ) * 100m ) / 100m;


                UPTAB22();


                ST2= ST;


                DIFF= (ST1 -  (ST2)) *  (ZAHL2);


                MIST = Decimal.Floor(   (ZX *  (0.14m))  ) ;

         if ( MIST.CompareTo (DIFF) == 1 ) 

           {

              //to do's


                ST= MIST;


           }
        
         else
            {
              //to do's


                ST= DIFF;


            }

        }// End of Method:  UP5_6





// Method Begin:  MSOLZ--------------------------------------------------------


public void MSOLZ()
        {


                SOLZFREI = (SOLZFREI * ( (decimal) KZTAB));

         if ( JBMG.CompareTo (SOLZFREI) == 1 ) 

           {

              //to do's


                SOLZJ = Decimal.Floor( (  (JBMG *  (5.5m)) / (ZAHL100) ) * 100m ) / 100m;


                SOLZMIN = Decimal.Floor( (  (JBMG -  (SOLZFREI)) *  (11.9m) /  (ZAHL100) ) * 100m ) / 100m;

         if ( SOLZMIN.CompareTo (SOLZJ) == -1 ) 

           {

              //to do's


                SOLZJ= SOLZMIN;


           }

                JW = Decimal.Floor(   SOLZJ *  (ZAHL100)  ) ;


                UPANTEIL();


                SOLZLZZ= ANTEIL1;


           }
        
         else
            {
              //to do's


                SOLZLZZ= Decimal.Zero;


            }

         if ( R > 0 ) 

           {

              //to do's


                JW= JBMG *  (ZAHL100);


                UPANTEIL();


                BK= ANTEIL1;


           }
        
         else
            {
              //to do's


                BK= Decimal.Zero;


            }

        }// End of Method:  MSOLZ





// Method Begin:  UPANTEIL--------------------------------------------------------


public void UPANTEIL()
        {

         if ( LZZ == 1 ) 

           {

              //to do's


                ANTEIL1= JW;


           }
        
         else
            {
              //to do's

         if ( LZZ == 2 ) 

           {

              //to do's


                ANTEIL1 = Decimal.Floor( ( JW / ZAHL12)  );


           }
        
         else
            {
              //to do's

         if ( LZZ == 3 ) 

           {

              //to do's


                ANTEIL1 = Decimal.Floor( ( (JW *  (ZAHL7)) / ZAHL360)  );


           }
        
         else
            {
              //to do's


                ANTEIL1 = Decimal.Floor( ( JW / ZAHL360)  );


            }


            }


            }

        }// End of Method:  UPANTEIL





// Method Begin:  MSONST--------------------------------------------------------


public void MSONST()
        {


                LZZ= 1;

         if ( ZMVB == 0 ) 

           {

              //to do's


                ZMVB= 12;


           }
         if ( SONSTB.CompareTo (Decimal.Zero) == 0 && MBV.CompareTo (Decimal.Zero) == 0 ) 

           {

              //to do's


                VKVSONST= Decimal.Zero;


                LSTSO= Decimal.Zero;


                STS= Decimal.Zero;


                SOLZS= Decimal.Zero;


                BKS= Decimal.Zero;


           }
        
         else
            {
              //to do's


                MOSONST();


                UPVKV();


                VKVSONST = VKV;


                ZRE4J = Decimal.Floor( (  ((JRE4 +  (SONSTB)) /  (ZAHL100)) ) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( (  ((JVBEZ +  (VBS)) /  (ZAHL100)) ) * 100m ) / 100m;


                VBEZBSO= STERBE;


                MRE4SONST();


                MLSTJAHR();


                WVFRBM  = Decimal.Floor( (  (ZVE - (GFB)) * (ZAHL100) ) * 100m ) / 100m;

         if ( WVFRBM.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's


                WVFRBM = Decimal.Zero;


           }

                UPVKV();


                VKVSONST = VKV - (VKVSONST);


                LSTSO= ST *  (ZAHL100);


                STS  = Decimal.Floor( ( LSTSO - (LSTOSO) * ( (decimal) f) / ZAHL100)  ) * (ZAHL100);


                STSMIN();


            }

        }// End of Method:  MSONST





// Method Begin:  STSMIN--------------------------------------------------------


public void STSMIN()
        {

         if ( STS.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's

         if ( MBV.CompareTo(Decimal.Zero) == 0 ) 

           {

              //to do's


           }
        
         else
            {
              //to do's


                LSTLZZ = LSTLZZ + (STS);

         if ( LSTLZZ.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's


                LSTLZZ = Decimal.Zero;


           }

                SOLZLZZ  = Decimal.Floor(   SOLZLZZ + (STS * (5.5m / (ZAHL100)))  ) ;

         if ( SOLZLZZ.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's


                SOLZLZZ = Decimal.Zero;


           }

                BK = BK + (STS);

         if ( BK.CompareTo(Decimal.Zero) == -1 ) 

           {

              //to do's


                BK = Decimal.Zero;


           }

            }


                STS = Decimal.Zero;


                SOLZS = Decimal.Zero;


           }
        
         else
            {
              //to do's


                MSOLZSTS();


            }

         if ( R > 0 ) 

           {

              //to do's


                BKS = STS;


           }
        
         else
            {
              //to do's


                BKS = Decimal.Zero;


            }

        }// End of Method:  STSMIN





// Method Begin:  MSOLZSTS--------------------------------------------------------


public void MSOLZSTS()
        {

         if ( ZKF.CompareTo(Decimal.Zero) == 1 ) 

           {

              //to do's


                SOLZSZVE= ZVE - (KFB);


           }
        
         else
            {
              //to do's


                SOLZSZVE= ZVE;


            }

         if ( SOLZSZVE.CompareTo(Decimal.One) == -1 ) 

           {

              //to do's


                SOLZSZVE= Decimal.Zero;


                X= Decimal.Zero;


           }
        
         else
            {
              //to do's


                X = Decimal.Floor( ( SOLZSZVE /  (decimal) KZTAB)  );


            }

         if ( STKL < 5 ) 

           {

              //to do's


                UPTAB22();


           }
        
         else
            {
              //to do's


                MST5_6();


            }


                SOLZSBMG = Decimal.Floor(   ST * ( (decimal) f)  ) ;

         if ( SOLZSBMG.CompareTo(SOLZFREI) == 1 ) 

           {

              //to do's


                SOLZS = Decimal.Floor( ( STS * (5.5m) / ZAHL100)  );


           }
        
         else
            {
              //to do's


                SOLZS= Decimal.Zero;


            }

        }// End of Method:  MSOLZSTS





// Method Begin:  MVMT--------------------------------------------------------


public void MVMT()
        {

         if ( VKAPA.CompareTo (Decimal.Zero) == -1 ) 

           {

              //to do's


                VKAPA= Decimal.Zero;


           }
         if ( (VMT +  (VKAPA)).CompareTo (Decimal.Zero) == 1 ) 

           {

              //to do's

         if ( LSTSO.CompareTo (Decimal.Zero) == 0 ) 

           {

              //to do's


                MOSONST();


                LST1= LSTOSO;


           }
        
         else
            {
              //to do's


                LST1= LSTSO;


            }


                VBEZBSO= STERBE +  (VKAPA);


                ZRE4J = Decimal.Floor( (  ((JRE4 +  (SONSTB) +  (VMT) +  (VKAPA)) /  (ZAHL100)) ) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( (  ((JVBEZ +  (VBS) +  (VKAPA)) /  (ZAHL100)) ) * 100m ) / 100m;


                KENNVMT = 2;


                MRE4SONST();


                MLSTJAHR();


                LST3= ST *  (ZAHL100);


                MRE4ABZ();


                ZRE4VP = ZRE4VP - (JRE4ENT / (ZAHL100)) - (SONSTENT / (ZAHL100));


                KENNVMT= 1;


                MLSTJAHR();


                LST2= ST *  (ZAHL100);


                STV= LST2 -  (LST1);


                LST3= LST3 -  (LST1);

         if ( LST3.CompareTo (STV) == -1 ) 

           {

              //to do's


                STV= LST3;


           }
         if ( STV.CompareTo (Decimal.Zero) == -1 ) 

           {

              //to do's


                STV= Decimal.Zero;


           }
        
         else
            {
              //to do's


                STV  = Decimal.Floor( ( STV * ( (decimal) f) / ZAHL100)  ) * (ZAHL100);


            }


                SOLZVBMG = Decimal.Floor( (STV / ZAHL100)  ) + (JBMG);

         if ( SOLZVBMG.CompareTo(SOLZFREI) == 1 ) 

           {

              //to do's


                SOLZV = Decimal.Floor( ( STV * (5.5m) / ZAHL100)  );


           }
        
         else
            {
              //to do's


                SOLZV= Decimal.Zero;


            }

         if ( R > 0 ) 

           {

              //to do's


                BKV= STV;


           }
        
         else
            {
              //to do's


                BKV= Decimal.Zero;


            }


           }
        
         else
            {
              //to do's


                STV= Decimal.Zero;


                SOLZV= Decimal.Zero;


                BKV= Decimal.Zero;


            }

        }// End of Method:  MVMT





// Method Begin:  MOSONST--------------------------------------------------------


public void MOSONST()
        {


                ZRE4J = Decimal.Floor( (  (JRE4 /  (ZAHL100)) ) * 100m ) / 100m;


                ZVBEZJ = Decimal.Floor( (  (JVBEZ /  (ZAHL100)) ) * 100m ) / 100m;


                JLFREIB = Decimal.Floor( ( JFREIB / ZAHL100) * 100m ) / 100m;


                JLHINZU = Decimal.Floor( ( JHINZU / ZAHL100) * 100m ) / 100m;


                MRE4();


                MRE4ABZ();


                ZRE4VP = ZRE4VP - (JRE4ENT / (ZAHL100));


                MZTABFB();


                VFRBS1  = Decimal.Floor( (  ((ANP + (FVB + (FVBZ))) * (ZAHL100)) ) * 100m ) / 100m;


                MLSTJAHR();


                WVFRBO  = Decimal.Floor( (  ((ZVE - (GFB)) * (ZAHL100)) ) * 100m ) / 100m;

         if ( WVFRBO.CompareTo(Decimal.Zero) == -1  ) 

           {

              //to do's


                WVFRBO = Decimal.Zero;


           }

                LSTOSO= ST *  (ZAHL100);

        }// End of Method:  MOSONST





// Method Begin:  MRE4SONST--------------------------------------------------------


public void MRE4SONST()
        {


                MRE4();


                FVB= FVBSO;


                MRE4ABZ();


                ZRE4VP = ZRE4VP + (MBV / (ZAHL100)) - (JRE4ENT / (ZAHL100)) - (SONSTENT / (ZAHL100));


                FVBZ= FVBZSO;


                MZTABFB();


                VFRBS2 = ((((ANP + (FVB) + (FVBZ))) * (ZAHL100))) - (VFRBS1);

        }// End of Method:  MRE4SONST





// Method Begin:  UPTAB22--------------------------------------------------------


public void UPTAB22()
        {

         if ( X.CompareTo(GFB + (ZAHL1)) == -1 ) 

           {

              //to do's


                ST= Decimal.Zero;


           }
        
         else
            {
              //to do's

         if ( X.CompareTo (14927m) == -1 ) 

           {

              //to do's


                Y  = Decimal.Floor( ( (X - (GFB)) / ZAHL10000) * 1000000m ) / 1000000m;


                RW= Y *  (1088.67m);


                RW= RW +  (1400m);


                ST = Decimal.Floor(   (RW *  (Y))  ) ;


           }
        
         else
            {
              //to do's

         if ( X.CompareTo (58597m) == -1 ) 

           {

              //to do's


                Y = Decimal.Floor( ( (X -  (14926m)) / ZAHL10000) * 1000000m ) / 1000000m;


                RW= Y *  (206.43m);


                RW= RW +  (2397m);


                RW= RW *  (Y);


                ST = Decimal.Floor(   (RW +  (869.32m))  ) ;


           }
        
         else
            {
              //to do's

         if ( X.CompareTo (277826m) == -1 ) 

           {

              //to do's


                ST = Decimal.Floor(   ((X *  (0.42m )) -  (9336.45m ))  ) ;


           }
        
         else
            {
              //to do's


                ST = Decimal.Floor(   ((X *  (0.45m )) -  (17671.2m ))  ) ;


            }


            }


            }


            }


                ST= ST *  ( (decimal) KZTAB);

        }// End of Method:  UPTAB22




}  //End class
}  //End namespace