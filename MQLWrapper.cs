using System;
using System.Runtime.InteropServices;
using System.Text;
using mql4csharp;
using MQL4CSharp.Base.MQL;
using RGiesecke.DllExport;

namespace DTFL.wrapper
{
    public class MQLWrapper
    {
        [DllExport("InitLogging", CallingConvention = CallingConvention.StdCall)]
        public static void InitLogging()
        {
            Logging.InitLogging();
        }

        [DllExport("IsCommandManagerReady", CallingConvention = CallingConvention.StdCall)]
        public static bool IsCommandManagerReady(Int64 ix)
        {
            return DLLObjectWrapper.IsCommandManagerReady(ix);
        }

        [DllExport("SetRatesSize", CallingConvention = CallingConvention.StdCall)]
        public static void SetRatesSize(Int64 ix, int arr_size)
        {
            MQLExpert.SetRatesSize(ix, arr_size);
        }

        [DllExport("IsExecutingOnTick", CallingConvention = CallingConvention.StdCall)]
        public static bool IsExecutingOnTick(Int64 ix)
        {
            return MQLExpert.IsExecutingOnTick(ix);
        }

        [DllExport("IsExecutingOnInit", CallingConvention = CallingConvention.StdCall)]
        public static bool IsExecutingOnInit(Int64 ix)
        {
            return MQLExpert.IsExecutingOnInit(ix);
        }

        [DllExport("IsExecutingOnTimer", CallingConvention = CallingConvention.StdCall)]
        public static bool IsExecutingOnTimer(Int64 ix)
        {
            return MQLExpert.IsExecutingOnTimer(ix);
        }

        [DllExport("IsExecutingOnDeinit", CallingConvention = CallingConvention.StdCall)]
        public static bool IsExecutingOnDeinit(Int64 ix)
        {
            return MQLExpert.IsExecutingOnDeinit(ix);
        }

        [DllExport("ExecOnInit", CallingConvention = CallingConvention.StdCall)]
        public static void ExecOnInit(Int64 ix, [MarshalAs(UnmanagedType.LPWStr)] string CSharpFullTypeName)
        {
            MQLExpert.ExecOnInit(ix, Type.GetType(CSharpFullTypeName));
        }

        [DllExport("InitRates", CallingConvention = CallingConvention.StdCall)]
        public unsafe static void InitRates(Int64 ix, MQLExpert.RateInfo* arr, int arr_size)
        {
            MQLExpert.InitRates(ix, arr, arr_size);
        }

        [DllExport("ExecOnDeinit", CallingConvention = CallingConvention.StdCall)]
        public static void ExecOnDeinit(Int64 ix)
        {
            MQLExpert.ExecOnDeinit(ix);
        }

        [DllExport("ExecOnTick", CallingConvention = CallingConvention.StdCall)]
        public static void ExecOnTick(Int64 ix)
        {
            MQLExpert.ExecOnTick(ix);
        }

        [DllExport("ExecOnTimer", CallingConvention = CallingConvention.StdCall)]
        public static void ExecOnTimer(Int64 ix)
        {
            MQLExpert.ExecOnTimer(ix);
        }

        [DllExport("IsCommandWaiting", CallingConvention = CallingConvention.StdCall)]
        public static int IsCommandWaiting(Int64 ix)
        {
            return MQLCommandManager.IsCommandWaiting(ix);
        }

        [DllExport("GetCommandId", CallingConvention = CallingConvention.StdCall)]
        public static int GetCommandId(Int64 ix, int id)
        {
            return MQLCommandManager.GetCommandId(ix, id);
        }

        [DllExport("GetCommandName", CallingConvention = CallingConvention.StdCall)]
        public static void GetCommandName(Int64 ix, int id, [In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder commandName)
        {
            MQLCommandManager.GetCommandName(ix, id, commandName);
        }

        [DllExport("GetCommandParams", CallingConvention = CallingConvention.StdCall)]
        public static void GetCommandParams(Int64 ix, int id, [In, Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder commandParams)
        {
            MQLCommandManager.GetCommandParams(ix, id, commandParams);
        }

        [DllExport("SetBoolCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetBoolCommandResponse(Int64 ix, int id, bool response, int error)
        {
            MQLCommandManager.SetBoolCommandResponse(ix, id, response, error);
        }

        [DllExport("SetDoubleCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetDoubleCommandResponse(Int64 ix, int id, double response, int error)
        {
            MQLCommandManager.SetDoubleCommandResponse(ix, id, response, error);
        }

        [DllExport("SetIntCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetIntCommandResponse(Int64 ix, int id, int response, int error)
        {
            MQLCommandManager.SetIntCommandResponse(ix, id, response, error);
        }

        [DllExport("SetStringCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetStringCommandResponse(Int64 ix, int id, [MarshalAs(UnmanagedType.LPWStr)] string response, int error)
        {
            MQLCommandManager.SetStringCommandResponse(ix, id, response, error);
        }

        [DllExport("SetVoidCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetVoidCommandResponse(Int64 ix, int id, int error)
        {
            MQLCommandManager.SetVoidCommandResponse(ix, id, error);
        }

        [DllExport("SetLongCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetLongCommandResponse(Int64 ix, int id, long response, int error)
        {
            MQLCommandManager.SetLongCommandResponse(ix, id, response, error);
        }

        [DllExport("SetDateTimeCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetDateTimeCommandResponse(Int64 ix, int id, Int64 response, int error)
        {
            MQLCommandManager.SetDateTimeCommandResponse(ix, id, response, error);
        }

        [DllExport("SetEnumCommandResponse", CallingConvention = CallingConvention.StdCall)]
        public static void SetEnumCommandResponse(Int64 ix, int id, int response, int error)
        {
            MQLCommandManager.SetEnumCommandResponse(ix, id, response, error);
        }

        [DllExport("CommandLock", CallingConvention = CallingConvention.StdCall)]
        public static bool CommandLock(Int64 ix)
        {
            return MQLCommandManager.CommandLock(ix);
        }


        [DllExport("CommandUnlock", CallingConvention = CallingConvention.StdCall)]
        public static bool CommandUnLock(Int64 ix)
        {
            return MQLCommandManager.CommandUnLock(ix);
        }

    }
}
