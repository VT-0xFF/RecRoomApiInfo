using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CSharpDerivedPrinter : Printer
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2039BA0", Offset = "0x20381A0", VA = "0x182039BA0", Slot = "6")]
	public override void print_error(string err_msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "7")]
	public override void print_msg(string msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2039A30", Offset = "0x2038030", VA = "0x182039A30")]
	public CSharpDerivedPrinter()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class Printer : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate void SwigDelegatePrinter_0(string output);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void SwigDelegatePrinter_1(string output);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private HandleRef swigCPtr;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected bool swigCMemOwn;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static Printer _statichelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private SwigDelegatePrinter_0 swigDelegate0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private SwigDelegatePrinter_1 swigDelegate1;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Type[] swigMethodTypes0;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static Type[] swigMethodTypes1;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x203A530", Offset = "0x2038B30", VA = "0x18203A530")]
	internal Printer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x203A5A0", Offset = "0x2038BA0", VA = "0x18203A5A0")]
	internal static HandleRef getCPtr(Printer obj)
	{
		return default(HandleRef);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2039E00", Offset = "0x2038400", VA = "0x182039E00", Slot = "1")]
	~Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2039C10", Offset = "0x2038210", VA = "0x182039C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2039C80", Offset = "0x2038280", VA = "0x182039C80", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x203A620", Offset = "0x2038C20", VA = "0x18203A620", Slot = "6")]
	public virtual void print_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x203A850", Offset = "0x2038E50", VA = "0x18203A850", Slot = "7")]
	public virtual void print_msg(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x203A400", Offset = "0x2038A00", VA = "0x18203A400")]
	public Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2039F70", Offset = "0x2038570", VA = "0x182039F70")]
	private void SwigDirectorConnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2039E80", Offset = "0x2038480", VA = "0x182039E80")]
	private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x203A170", Offset = "0x2038770", VA = "0x18203A170")]
	[MonoPInvokeCallback(typeof(SwigDelegatePrinter_0))]
	private static void SwigDirectorMethodprint_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x203A1F0", Offset = "0x20387F0", VA = "0x18203A1F0")]
	[MonoPInvokeCallback(typeof(SwigDelegatePrinter_1))]
	private static void SwigDirectorMethodprint_msg(string output)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum TOX_ERROR
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TOX_NO_ERROR,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TOX_UNKNOWN_ERROR,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	TOX_BAD_INSTANCE,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	TOX_BAD_CONFIG,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	TOX_BAD_ACCOUNT_UUID,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	TOX_BAD_API_KEY,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TOX_BAD_PLAYER_NAME,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TOX_BAD_SESSION_NAME,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TOX_BAD_AUDIO,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TOX_BAD_SAMPLE_RATE,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TOX_SAMPLES_SKIPPED,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	TOX_NO_SESSION_SET,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	TOX_UPLOAD_METADATA_FAILED,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	TOX_BAD_TENANT_PREFIX
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum TOX_TRIAGE_SETTING
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	TOX_NONE,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	TOX_LIGHT,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TOX_HEAVY
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ToxModManager : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HandleRef swigCPtr;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	protected bool swigCMemOwn;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x203A530", Offset = "0x2038B30", VA = "0x18203A530")]
	internal ToxModManager(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x203C450", Offset = "0x203AA50", VA = "0x18203C450", Slot = "1")]
	~ToxModManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x203C260", Offset = "0x203A860", VA = "0x18203C260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x203C2D0", Offset = "0x203A8D0", VA = "0x18203C2D0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x203C770", Offset = "0x203AD70", VA = "0x18203C770")]
	public void raw_add_audio(float[] float_data, int float_data_len, int audio_frame_rate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x203C4D0", Offset = "0x203AAD0", VA = "0x18203C4D0")]
	public static ToxModManager Instance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x203C5D0", Offset = "0x203ABD0", VA = "0x18203C5D0")]
	public void initialize_with_player_name(string player_name, string account_id, string api_key, int verbosity, TOX_TRIAGE_SETTING triage_setting)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x203C9C0", Offset = "0x203AFC0", VA = "0x18203C9C0")]
	public TOX_ERROR set_session_name(string session_name)
	{
		return default(TOX_ERROR);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x203CB10", Offset = "0x203B110", VA = "0x18203CB10")]
	public void uninitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x203C870", Offset = "0x203AE70", VA = "0x18203C870")]
	public void set_printer(Printer new_printer)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class tox_wrapPINVOKE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	protected class SWIGExceptionHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate void ExceptionDelegate(string message);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public delegate void ExceptionArgumentDelegate(string message, string paramName);

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static ExceptionDelegate applicationDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static ExceptionDelegate arithmeticDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static ExceptionDelegate divideByZeroDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static ExceptionDelegate indexOutOfRangeDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static ExceptionDelegate invalidCastDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static ExceptionDelegate invalidOperationDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static ExceptionDelegate ioDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static ExceptionDelegate nullReferenceDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static ExceptionDelegate outOfMemoryDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static ExceptionDelegate overflowDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static ExceptionDelegate systemDelegate;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static ExceptionArgumentDelegate argumentDelegate;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static ExceptionArgumentDelegate argumentNullDelegate;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x203AB40", Offset = "0x2039140", VA = "0x18203AB40")]
		public static extern void SWIGRegisterExceptionCallbacks_tox_wrap(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x203AA80", Offset = "0x2039080", VA = "0x18203AA80")]
		public static extern void SWIGRegisterExceptionCallbacksArgument_tox_wrap(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x203ACE0", Offset = "0x20392E0", VA = "0x18203ACE0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x203AFE0", Offset = "0x20395E0", VA = "0x18203AFE0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x203B070", Offset = "0x2039670", VA = "0x18203B070")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x203B190", Offset = "0x2039790", VA = "0x18203B190")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x203B220", Offset = "0x2039820", VA = "0x18203B220")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x203B2B0", Offset = "0x20398B0", VA = "0x18203B2B0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x203B100", Offset = "0x2039700", VA = "0x18203B100")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x203B340", Offset = "0x2039940", VA = "0x18203B340")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x203B3D0", Offset = "0x20399D0", VA = "0x18203B3D0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x203B460", Offset = "0x2039A60", VA = "0x18203B460")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x203B4F0", Offset = "0x2039AF0", VA = "0x18203B4F0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x203AD70", Offset = "0x2039370", VA = "0x18203AD70")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x203AE20", Offset = "0x2039420", VA = "0x18203AE20")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x203AF00", Offset = "0x2039500", VA = "0x18203AF00")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x203B580", Offset = "0x2039B80", VA = "0x18203B580")]
		static SWIGExceptionHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public SWIGExceptionHelper()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SWIGPendingException
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[ThreadStatic]
		private static Exception pendingException;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static int numExceptionsPending;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static object exceptionsLock;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool Pending
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x203C030", Offset = "0x203A630", VA = "0x18203C030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x203BDF0", Offset = "0x203A3F0", VA = "0x18203BDF0")]
		public static void Set(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x203BC60", Offset = "0x203A260", VA = "0x18203BC60")]
		public static Exception Retrieve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x203BFD0", Offset = "0x203A5D0", VA = "0x18203BFD0")]
		static SWIGPendingException()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	protected class SWIGStringHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate string SWIGStringDelegate(string message);

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static SWIGStringDelegate stringDelegate;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x203C0D0", Offset = "0x203A6D0", VA = "0x18203C0D0")]
		public static extern void SWIGRegisterStringCallback_tox_wrap(SWIGStringDelegate stringDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647020", VA = "0x180648A20")]
		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x203C160", Offset = "0x203A760", VA = "0x18203C160")]
		static SWIGStringHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
		public SWIGStringHelper()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	protected static SWIGExceptionHelper swigExceptionHelper;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	protected static SWIGStringHelper swigStringHelper;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x203D2F0", Offset = "0x203B8F0", VA = "0x18203D2F0")]
	static tox_wrapPINVOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x203D070", Offset = "0x203B670", VA = "0x18203D070")]
	public static extern void ToxModManager_raw_add_audio(HandleRef jarg1, [In][Out] float[] jarg2, int jarg3, int jarg4);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x203CF00", Offset = "0x203B500", VA = "0x18203CF00")]
	public static extern IntPtr ToxModManager_Instance();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x203CF70", Offset = "0x203B570", VA = "0x18203CF70")]
	public static extern void ToxModManager_initialize_with_player_name(HandleRef jarg1, string jarg2, string jarg3, string jarg4, int jarg5, int jarg6);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x203D1C0", Offset = "0x203B7C0", VA = "0x18203D1C0")]
	public static extern int ToxModManager_set_session_name(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x203D270", Offset = "0x203B870", VA = "0x18203D270")]
	public static extern void ToxModManager_uninitialize(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x203D130", Offset = "0x203B730", VA = "0x18203D130")]
	public static extern void ToxModManager_set_printer(HandleRef jarg1, HandleRef jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x203D400", Offset = "0x203BA00", VA = "0x18203D400")]
	public static extern void delete_ToxModManager(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x203D380", Offset = "0x203B980", VA = "0x18203D380")]
	public static extern void delete_Printer(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x203CD20", Offset = "0x203B320", VA = "0x18203CD20")]
	public static extern void Printer_print_error(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x203CC80", Offset = "0x203B280", VA = "0x18203CC80")]
	public static extern void Printer_print_errorSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x203CE60", Offset = "0x203B460", VA = "0x18203CE60")]
	public static extern void Printer_print_msg(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x203CDC0", Offset = "0x203B3C0", VA = "0x18203CDC0")]
	public static extern void Printer_print_msgSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x203D480", Offset = "0x203BA80", VA = "0x18203D480")]
	public static extern IntPtr new_Printer();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x203CBD0", Offset = "0x203B1D0", VA = "0x18203CBD0")]
	public static extern void Printer_director_connect(HandleRef jarg1, Printer.SwigDelegatePrinter_0 delegate0, Printer.SwigDelegatePrinter_1 delegate1);
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}
