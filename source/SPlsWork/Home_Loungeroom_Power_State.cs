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

namespace UserModule_HOME_LOUNGEROOM_POWER_STATE
{
    public class UserModuleClass_HOME_LOUNGEROOM_POWER_STATE : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput UI_POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput UI_POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput TV_POWER_FB;
        Crestron.Logos.SplusObjects.DigitalInput CEC_POWER_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SYSTEM_ON;
        Crestron.Logos.SplusObjects.DigitalOutput SYSTEM_OFF;
        ushort SYSTEMSTATE = 0;
        ushort HOLD = 0;
        ushort PERIPHERAL_ON = 0;
        private void CHECKANDCHANGE (  SplusExecutionContext __context__, ushort SETSTATE ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 45;
            I = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 46;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOLD == 1))  ) ) 
                {
                __context__.SourceCodeLine = 46;
                return ; 
                }
            
            __context__.SourceCodeLine = 47;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SYSTEMSTATE != SETSTATE))  ) ) 
                { 
                __context__.SourceCodeLine = 48;
                HOLD = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 50;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SETSTATE == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 51;
                    SYSTEM_ON  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 52;
                    SYSTEM_OFF  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 53;
                    SYSTEMSTATE = (ushort) ( 2 ) ; 
                    __context__.SourceCodeLine = 54;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I < 50 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 55;
                        I = (ushort) ( (I + 1) ) ; 
                        __context__.SourceCodeLine = 56;
                        if ( Functions.TestForTrue  ( ( TV_POWER_FB  .Value)  ) ) 
                            {
                            __context__.SourceCodeLine = 56;
                            break ; 
                            }
                        
                        __context__.SourceCodeLine = 57;
                        Functions.Delay (  (int) ( 1000 ) ) ; 
                        __context__.SourceCodeLine = 54;
                        } 
                    
                    __context__.SourceCodeLine = 59;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I != 50))  ) ) 
                        { 
                        __context__.SourceCodeLine = 60;
                        SYSTEMSTATE = (ushort) ( 1 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 63;
                        SYSTEMSTATE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 64;
                        PERIPHERAL_ON = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 68;
                    SYSTEM_ON  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 69;
                    SYSTEM_OFF  .Value = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 70;
                    SYSTEMSTATE = (ushort) ( 3 ) ; 
                    __context__.SourceCodeLine = 71;
                    while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( I < 50 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 72;
                        I = (ushort) ( (I + 1) ) ; 
                        __context__.SourceCodeLine = 73;
                        if ( Functions.TestForTrue  ( ( Functions.Not( TV_POWER_FB  .Value ))  ) ) 
                            {
                            __context__.SourceCodeLine = 73;
                            break ; 
                            }
                        
                        __context__.SourceCodeLine = 74;
                        Functions.Delay (  (int) ( 1000 ) ) ; 
                        __context__.SourceCodeLine = 71;
                        } 
                    
                    __context__.SourceCodeLine = 76;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (I != 50))  ) ) 
                        { 
                        __context__.SourceCodeLine = 77;
                        SYSTEMSTATE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 78;
                        PERIPHERAL_ON = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 81;
                        SYSTEMSTATE = (ushort) ( 1 ) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 84;
                HOLD = (ushort) ( 0 ) ; 
                } 
            
            
            }
            
        object UI_POWER_ON_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 92;
                CHECKANDCHANGE (  __context__ , (ushort)( 1 )) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object UI_POWER_OFF_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 98;
            CHECKANDCHANGE (  __context__ , (ushort)( 0 )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object TV_POWER_FB_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        if ( Functions.TestForTrue  ( ( TV_POWER_FB  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 105;
            CHECKANDCHANGE (  __context__ , (ushort)( 1 )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 109;
            CHECKANDCHANGE (  __context__ , (ushort)( 0 )) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CEC_POWER_FB_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 115;
        if ( Functions.TestForTrue  ( ( Functions.Not( PERIPHERAL_ON ))  ) ) 
            { 
            __context__.SourceCodeLine = 116;
            CHECKANDCHANGE (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 117;
            PERIPHERAL_ON = (ushort) ( 1 ) ; 
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
        
        __context__.SourceCodeLine = 123;
        SYSTEMSTATE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 124;
        HOLD = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 125;
        SYSTEM_OFF  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 126;
        SYSTEM_ON  .Value = (ushort) ( 0 ) ; 
        
        
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
    
    UI_POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( UI_POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( UI_POWER_ON__DigitalInput__, UI_POWER_ON );
    
    UI_POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( UI_POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( UI_POWER_OFF__DigitalInput__, UI_POWER_OFF );
    
    TV_POWER_FB = new Crestron.Logos.SplusObjects.DigitalInput( TV_POWER_FB__DigitalInput__, this );
    m_DigitalInputList.Add( TV_POWER_FB__DigitalInput__, TV_POWER_FB );
    
    CEC_POWER_FB = new Crestron.Logos.SplusObjects.DigitalInput( CEC_POWER_FB__DigitalInput__, this );
    m_DigitalInputList.Add( CEC_POWER_FB__DigitalInput__, CEC_POWER_FB );
    
    SYSTEM_ON = new Crestron.Logos.SplusObjects.DigitalOutput( SYSTEM_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SYSTEM_ON__DigitalOutput__, SYSTEM_ON );
    
    SYSTEM_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( SYSTEM_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( SYSTEM_OFF__DigitalOutput__, SYSTEM_OFF );
    
    
    UI_POWER_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( UI_POWER_ON_OnChange_0, false ) );
    UI_POWER_OFF.OnDigitalChange.Add( new InputChangeHandlerWrapper( UI_POWER_OFF_OnChange_1, false ) );
    TV_POWER_FB.OnDigitalChange.Add( new InputChangeHandlerWrapper( TV_POWER_FB_OnChange_2, false ) );
    CEC_POWER_FB.OnDigitalPush.Add( new InputChangeHandlerWrapper( CEC_POWER_FB_OnPush_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_HOME_LOUNGEROOM_POWER_STATE ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint UI_POWER_ON__DigitalInput__ = 0;
const uint UI_POWER_OFF__DigitalInput__ = 1;
const uint TV_POWER_FB__DigitalInput__ = 2;
const uint CEC_POWER_FB__DigitalInput__ = 3;
const uint SYSTEM_ON__DigitalOutput__ = 0;
const uint SYSTEM_OFF__DigitalOutput__ = 1;

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
