using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_CEC_DRIVER_CONVERSIONS
{
    public class UserModuleClass_CEC_DRIVER_CONVERSIONS : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput POWERON;
        Crestron.Logos.SplusObjects.DigitalInput POWEROFF;
        Crestron.Logos.SplusObjects.DigitalInput UPARROW;
        Crestron.Logos.SplusObjects.DigitalInput DOWNARROW;
        Crestron.Logos.SplusObjects.DigitalInput LEFTARROW;
        Crestron.Logos.SplusObjects.DigitalInput RIGHTARROW;
        Crestron.Logos.SplusObjects.DigitalInput SELECT;
        Crestron.Logos.SplusObjects.DigitalInput EXIT;
        Crestron.Logos.SplusObjects.DigitalInput HOME;
        Crestron.Logos.SplusObjects.DigitalInput MENU;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMEUP_PRESSED;
        Crestron.Logos.SplusObjects.DigitalInput VOLUMEDOWN_PRESSED;
        Crestron.Logos.SplusObjects.DigitalInput MUTETOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_0;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_1;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_2;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_3;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_4;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_5;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_6;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_7;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_8;
        Crestron.Logos.SplusObjects.DigitalInput BUTTON_9;
        Crestron.Logos.SplusObjects.DigitalInput REQUEST_POWER_STATE;
        Crestron.Logos.SplusObjects.StringInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput POWERON_FB;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        UShortParameter SENDER;
        UShortParameter RECEIVER;
        ushort SEND = 0;
        ushort REC = 0;
        private ushort GETNUMBUTTON (  SplusExecutionContext __context__, ushort NUM ) 
            { 
            ushort BASE = 0;
            ushort RETURNVALUE = 0;
            
            
            __context__.SourceCodeLine = 33;
            BASE = (ushort) ( 32 ) ; 
            __context__.SourceCodeLine = 34;
            RETURNVALUE = (ushort) ( (BASE + NUM) ) ; 
            __context__.SourceCodeLine = 36;
            return (ushort)( RETURNVALUE) ; 
            
            }
            
        private ushort GETBUTTONBYNAME (  SplusExecutionContext __context__, CrestronString CMD ) 
            { 
            
            __context__.SourceCodeLine = 42;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "select"))  ) ) 
                {
                __context__.SourceCodeLine = 42;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 43;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "up"))  ) ) 
                {
                __context__.SourceCodeLine = 43;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 44;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "down"))  ) ) 
                {
                __context__.SourceCodeLine = 44;
                return (ushort)( 2) ; 
                }
            
            __context__.SourceCodeLine = 45;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "left"))  ) ) 
                {
                __context__.SourceCodeLine = 45;
                return (ushort)( 3) ; 
                }
            
            __context__.SourceCodeLine = 46;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "right"))  ) ) 
                {
                __context__.SourceCodeLine = 46;
                return (ushort)( 4) ; 
                }
            
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "exit"))  ) ) 
                {
                __context__.SourceCodeLine = 47;
                return (ushort)( 13) ; 
                }
            
            __context__.SourceCodeLine = 48;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "home"))  ) ) 
                {
                __context__.SourceCodeLine = 48;
                return (ushort)( 9) ; 
                }
            
            __context__.SourceCodeLine = 49;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "menu"))  ) ) 
                {
                __context__.SourceCodeLine = 49;
                return (ushort)( 10) ; 
                }
            
            __context__.SourceCodeLine = 50;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "input_select"))  ) ) 
                {
                __context__.SourceCodeLine = 50;
                return (ushort)( 52) ; 
                }
            
            __context__.SourceCodeLine = 51;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "vol_up"))  ) ) 
                {
                __context__.SourceCodeLine = 51;
                return (ushort)( 65) ; 
                }
            
            __context__.SourceCodeLine = 52;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "vol_down"))  ) ) 
                {
                __context__.SourceCodeLine = 52;
                return (ushort)( 66) ; 
                }
            
            __context__.SourceCodeLine = 53;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "mute_toggle"))  ) ) 
                {
                __context__.SourceCodeLine = 53;
                return (ushort)( 67) ; 
                }
            
            __context__.SourceCodeLine = 54;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "power_on"))  ) ) 
                {
                __context__.SourceCodeLine = 54;
                return (ushort)( 109) ; 
                }
            
            __context__.SourceCodeLine = 55;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "power_off"))  ) ) 
                {
                __context__.SourceCodeLine = 55;
                return (ushort)( 108) ; 
                }
            
            __context__.SourceCodeLine = 56;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "power_off"))  ) ) 
                {
                __context__.SourceCodeLine = 56;
                return (ushort)( 108) ; 
                }
            
            __context__.SourceCodeLine = 57;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CMD == "cr"))  ) ) 
                {
                __context__.SourceCodeLine = 57;
                return (ushort)( 69) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void HANDLEBUTTONNAME (  SplusExecutionContext __context__, CrestronString NAME ) 
            { 
            ushort NUM = 0;
            ushort CR = 0;
            
            
            __context__.SourceCodeLine = 62;
            NUM = (ushort) ( GETBUTTONBYNAME( __context__ , NAME ) ) ; 
            __context__.SourceCodeLine = 63;
            CR = (ushort) ( GETBUTTONBYNAME( __context__ , "cr" ) ) ; 
            __context__.SourceCodeLine = 64;
            MakeString ( TX__DOLLAR__ , "{0}{1}{2}", Functions.Chr ( SEND ) , Functions.Chr ( 68 ) , Functions.Chr ( NUM ) ) ; 
            __context__.SourceCodeLine = 65;
            MakeString ( TX__DOLLAR__ , "{0}{1}", Functions.Chr ( SEND ) , Functions.Chr ( CR ) ) ; 
            
            }
            
        private void HANDLEBUTTONNUMBER (  SplusExecutionContext __context__, ushort NUMBER ) 
            { 
            ushort NUM = 0;
            ushort CR = 0;
            
            
            __context__.SourceCodeLine = 70;
            NUM = (ushort) ( GETNUMBUTTON( __context__ , (ushort)( NUMBER ) ) ) ; 
            __context__.SourceCodeLine = 71;
            CR = (ushort) ( GETBUTTONBYNAME( __context__ , "cr" ) ) ; 
            __context__.SourceCodeLine = 72;
            MakeString ( TX__DOLLAR__ , "{0}{1}{2}", Functions.Chr ( SEND ) , Functions.Chr ( 68 ) , Functions.Chr ( NUM ) ) ; 
            __context__.SourceCodeLine = 73;
            MakeString ( TX__DOLLAR__ , "{0}{1}", Functions.Chr ( SEND ) , Functions.Chr ( CR ) ) ; 
            
            }
            
        object POWERON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 77;
                HANDLEBUTTONNAME (  __context__ , "power_on") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POWEROFF_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 81;
            HANDLEBUTTONNAME (  __context__ , "power_off") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object UPARROW_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 85;
        HANDLEBUTTONNAME (  __context__ , "up") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOWNARROW_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 89;
        HANDLEBUTTONNAME (  __context__ , "down") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LEFTARROW_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 93;
        HANDLEBUTTONNAME (  __context__ , "left") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RIGHTARROW_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 97;
        HANDLEBUTTONNAME (  __context__ , "right") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 101;
        HANDLEBUTTONNAME (  __context__ , "select") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object EXIT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        HANDLEBUTTONNAME (  __context__ , "exit") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOME_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 109;
        HANDLEBUTTONNAME (  __context__ , "home") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MENU_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 113;
        HANDLEBUTTONNAME (  __context__ , "menu") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEUP_PRESSED_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 117;
        HANDLEBUTTONNAME (  __context__ , "vol_up") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUMEDOWN_PRESSED_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 121;
        HANDLEBUTTONNAME (  __context__ , "vol_down") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTETOGGLE_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 125;
        HANDLEBUTTONNAME (  __context__ , "mute_toggle") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_SELECT_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        HANDLEBUTTONNAME (  __context__ , "input_select") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_0_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 133;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_1_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 136;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_2_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 2 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_3_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 3 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_4_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 145;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 4 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_5_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 148;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 5 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_6_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 151;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 6 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_7_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 154;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 7 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_8_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 157;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 8 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BUTTON_9_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 160;
        HANDLEBUTTONNUMBER (  __context__ , (ushort)( 9 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REQUEST_POWER_STATE_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 164;
        MakeString ( TX__DOLLAR__ , "{0}{1}", Functions.Chr ( SEND ) , Functions.Chr ( 143 ) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BYTE1 = 0;
        ushort BYTE2 = 0;
        ushort BYTE3 = 0;
        
        CrestronString TEMP;
        TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
        
        
        __context__.SourceCodeLine = 170;
        TEMP  .UpdateValue ( RX__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 171;
        BYTE1 = (ushort) ( Byte( TEMP , (int)( 1 ) ) ) ; 
        __context__.SourceCodeLine = 172;
        BYTE2 = (ushort) ( Byte( TEMP , (int)( 2 ) ) ) ; 
        __context__.SourceCodeLine = 173;
        BYTE3 = (ushort) ( Byte( TEMP , (int)( 3 ) ) ) ; 
        __context__.SourceCodeLine = 174;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BYTE1 == REC))  ) ) 
            { 
            __context__.SourceCodeLine = 175;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BYTE2 == 144))  ) ) 
                { 
                __context__.SourceCodeLine = 176;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BYTE3 == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 177;
                    POWERON_FB  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 179;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (BYTE3 == 1))  ) ) 
                        { 
                        __context__.SourceCodeLine = 180;
                        POWERON_FB  .Value = (ushort) ( 0 ) ; 
                        } 
                    
                    }
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 187;
        SEND = (ushort) ( ((SENDER  .Value << 4) + RECEIVER  .Value) ) ; 
        __context__.SourceCodeLine = 188;
        REC = (ushort) ( ((RECEIVER  .Value << 4) + SENDER  .Value) ) ; 
        __context__.SourceCodeLine = 189;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    
    POWERON = new Crestron.Logos.SplusObjects.DigitalInput( POWERON__DigitalInput__, this );
    m_DigitalInputList.Add( POWERON__DigitalInput__, POWERON );
    
    POWEROFF = new Crestron.Logos.SplusObjects.DigitalInput( POWEROFF__DigitalInput__, this );
    m_DigitalInputList.Add( POWEROFF__DigitalInput__, POWEROFF );
    
    UPARROW = new Crestron.Logos.SplusObjects.DigitalInput( UPARROW__DigitalInput__, this );
    m_DigitalInputList.Add( UPARROW__DigitalInput__, UPARROW );
    
    DOWNARROW = new Crestron.Logos.SplusObjects.DigitalInput( DOWNARROW__DigitalInput__, this );
    m_DigitalInputList.Add( DOWNARROW__DigitalInput__, DOWNARROW );
    
    LEFTARROW = new Crestron.Logos.SplusObjects.DigitalInput( LEFTARROW__DigitalInput__, this );
    m_DigitalInputList.Add( LEFTARROW__DigitalInput__, LEFTARROW );
    
    RIGHTARROW = new Crestron.Logos.SplusObjects.DigitalInput( RIGHTARROW__DigitalInput__, this );
    m_DigitalInputList.Add( RIGHTARROW__DigitalInput__, RIGHTARROW );
    
    SELECT = new Crestron.Logos.SplusObjects.DigitalInput( SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( SELECT__DigitalInput__, SELECT );
    
    EXIT = new Crestron.Logos.SplusObjects.DigitalInput( EXIT__DigitalInput__, this );
    m_DigitalInputList.Add( EXIT__DigitalInput__, EXIT );
    
    HOME = new Crestron.Logos.SplusObjects.DigitalInput( HOME__DigitalInput__, this );
    m_DigitalInputList.Add( HOME__DigitalInput__, HOME );
    
    MENU = new Crestron.Logos.SplusObjects.DigitalInput( MENU__DigitalInput__, this );
    m_DigitalInputList.Add( MENU__DigitalInput__, MENU );
    
    VOLUMEUP_PRESSED = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEUP_PRESSED__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMEUP_PRESSED__DigitalInput__, VOLUMEUP_PRESSED );
    
    VOLUMEDOWN_PRESSED = new Crestron.Logos.SplusObjects.DigitalInput( VOLUMEDOWN_PRESSED__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUMEDOWN_PRESSED__DigitalInput__, VOLUMEDOWN_PRESSED );
    
    MUTETOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( MUTETOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( MUTETOGGLE__DigitalInput__, MUTETOGGLE );
    
    INPUT_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_SELECT__DigitalInput__, INPUT_SELECT );
    
    BUTTON_0 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_0__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_0__DigitalInput__, BUTTON_0 );
    
    BUTTON_1 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_1__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_1__DigitalInput__, BUTTON_1 );
    
    BUTTON_2 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_2__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_2__DigitalInput__, BUTTON_2 );
    
    BUTTON_3 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_3__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_3__DigitalInput__, BUTTON_3 );
    
    BUTTON_4 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_4__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_4__DigitalInput__, BUTTON_4 );
    
    BUTTON_5 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_5__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_5__DigitalInput__, BUTTON_5 );
    
    BUTTON_6 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_6__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_6__DigitalInput__, BUTTON_6 );
    
    BUTTON_7 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_7__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_7__DigitalInput__, BUTTON_7 );
    
    BUTTON_8 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_8__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_8__DigitalInput__, BUTTON_8 );
    
    BUTTON_9 = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON_9__DigitalInput__, this );
    m_DigitalInputList.Add( BUTTON_9__DigitalInput__, BUTTON_9 );
    
    REQUEST_POWER_STATE = new Crestron.Logos.SplusObjects.DigitalInput( REQUEST_POWER_STATE__DigitalInput__, this );
    m_DigitalInputList.Add( REQUEST_POWER_STATE__DigitalInput__, REQUEST_POWER_STATE );
    
    POWERON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POWERON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWERON_FB__DigitalOutput__, POWERON_FB );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RX__DOLLAR____AnalogSerialInput__, 50, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    SENDER = new UShortParameter( SENDER__Parameter__, this );
    m_ParameterList.Add( SENDER__Parameter__, SENDER );
    
    RECEIVER = new UShortParameter( RECEIVER__Parameter__, this );
    m_ParameterList.Add( RECEIVER__Parameter__, RECEIVER );
    
    
    POWERON.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWERON_OnPush_0, false ) );
    POWEROFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWEROFF_OnPush_1, false ) );
    UPARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( UPARROW_OnPush_2, false ) );
    DOWNARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOWNARROW_OnPush_3, false ) );
    LEFTARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( LEFTARROW_OnPush_4, false ) );
    RIGHTARROW.OnDigitalPush.Add( new InputChangeHandlerWrapper( RIGHTARROW_OnPush_5, false ) );
    SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SELECT_OnPush_6, false ) );
    EXIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( EXIT_OnPush_7, false ) );
    HOME.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOME_OnPush_8, false ) );
    MENU.OnDigitalPush.Add( new InputChangeHandlerWrapper( MENU_OnPush_9, false ) );
    VOLUMEUP_PRESSED.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEUP_PRESSED_OnPush_10, false ) );
    VOLUMEDOWN_PRESSED.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUMEDOWN_PRESSED_OnPush_11, false ) );
    MUTETOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTETOGGLE_OnPush_12, false ) );
    INPUT_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_SELECT_OnPush_13, false ) );
    BUTTON_0.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_0_OnPush_14, false ) );
    BUTTON_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_1_OnPush_15, false ) );
    BUTTON_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_2_OnPush_16, false ) );
    BUTTON_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_3_OnPush_17, false ) );
    BUTTON_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_4_OnPush_18, false ) );
    BUTTON_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_5_OnPush_19, false ) );
    BUTTON_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_6_OnPush_20, false ) );
    BUTTON_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_7_OnPush_21, false ) );
    BUTTON_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_8_OnPush_22, false ) );
    BUTTON_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_9_OnPush_23, false ) );
    REQUEST_POWER_STATE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUEST_POWER_STATE_OnPush_24, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_25, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CEC_DRIVER_CONVERSIONS ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POWERON__DigitalInput__ = 0;
const uint POWEROFF__DigitalInput__ = 1;
const uint UPARROW__DigitalInput__ = 2;
const uint DOWNARROW__DigitalInput__ = 3;
const uint LEFTARROW__DigitalInput__ = 4;
const uint RIGHTARROW__DigitalInput__ = 5;
const uint SELECT__DigitalInput__ = 6;
const uint EXIT__DigitalInput__ = 7;
const uint HOME__DigitalInput__ = 8;
const uint MENU__DigitalInput__ = 9;
const uint VOLUMEUP_PRESSED__DigitalInput__ = 10;
const uint VOLUMEDOWN_PRESSED__DigitalInput__ = 11;
const uint MUTETOGGLE__DigitalInput__ = 12;
const uint INPUT_SELECT__DigitalInput__ = 13;
const uint BUTTON_0__DigitalInput__ = 14;
const uint BUTTON_1__DigitalInput__ = 15;
const uint BUTTON_2__DigitalInput__ = 16;
const uint BUTTON_3__DigitalInput__ = 17;
const uint BUTTON_4__DigitalInput__ = 18;
const uint BUTTON_5__DigitalInput__ = 19;
const uint BUTTON_6__DigitalInput__ = 20;
const uint BUTTON_7__DigitalInput__ = 21;
const uint BUTTON_8__DigitalInput__ = 22;
const uint BUTTON_9__DigitalInput__ = 23;
const uint REQUEST_POWER_STATE__DigitalInput__ = 24;
const uint RX__DOLLAR____AnalogSerialInput__ = 0;
const uint POWERON_FB__DigitalOutput__ = 0;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint SENDER__Parameter__ = 10;
const uint RECEIVER__Parameter__ = 11;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
