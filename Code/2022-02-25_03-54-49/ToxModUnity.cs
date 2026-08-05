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
	[Cpp2IlInjected.Address(RVA = "0x49C1420", Offset = "0x49BFA20", VA = "0x1849C1420", Slot = "6")]
	public override void print_error(string err_msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "7")]
	public override void print_msg(string msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x49C12B0", Offset = "0x49BF8B0", VA = "0x1849C12B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x49C1DB0", Offset = "0x49C03B0", VA = "0x1849C1DB0")]
	internal Printer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x49C1E20", Offset = "0x49C0420", VA = "0x1849C1E20")]
	internal static HandleRef getCPtr(Printer obj)
	{
		return default(HandleRef);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x49C1680", Offset = "0x49BFC80", VA = "0x1849C1680", Slot = "1")]
	~Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x49C1490", Offset = "0x49BFA90", VA = "0x1849C1490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x49C1500", Offset = "0x49BFB00", VA = "0x1849C1500", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49C1EA0", Offset = "0x49C04A0", VA = "0x1849C1EA0", Slot = "6")]
	public virtual void print_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49C20D0", Offset = "0x49C06D0", VA = "0x1849C20D0", Slot = "7")]
	public virtual void print_msg(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49C1C80", Offset = "0x49C0280", VA = "0x1849C1C80")]
	public Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x49C17F0", Offset = "0x49BFDF0", VA = "0x1849C17F0")]
	private void SwigDirectorConnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x49C1700", Offset = "0x49BFD00", VA = "0x1849C1700")]
	private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49C19F0", Offset = "0x49BFFF0", VA = "0x1849C19F0")]
	[MonoPInvokeCallback(typeof(SwigDelegatePrinter_0))]
	private static void SwigDirectorMethodprint_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49C1A70", Offset = "0x49C0070", VA = "0x1849C1A70")]
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
	[Cpp2IlInjected.Address(RVA = "0x49C1DB0", Offset = "0x49C03B0", VA = "0x1849C1DB0")]
	internal ToxModManager(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x49C3CD0", Offset = "0x49C22D0", VA = "0x1849C3CD0", Slot = "1")]
	~ToxModManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x49C3AE0", Offset = "0x49C20E0", VA = "0x1849C3AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x49C3B50", Offset = "0x49C2150", VA = "0x1849C3B50", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x49C3FF0", Offset = "0x49C25F0", VA = "0x1849C3FF0")]
	public void raw_add_audio(float[] float_data, int float_data_len, int audio_frame_rate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x49C3D50", Offset = "0x49C2350", VA = "0x1849C3D50")]
	public static ToxModManager Instance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x49C3E50", Offset = "0x49C2450", VA = "0x1849C3E50")]
	public void initialize_with_player_name(string player_name, string account_id, string api_key, int verbosity, TOX_TRIAGE_SETTING triage_setting)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x49C4240", Offset = "0x49C2840", VA = "0x1849C4240")]
	public TOX_ERROR set_session_name(string session_name)
	{
		return default(TOX_ERROR);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x49C4390", Offset = "0x49C2990", VA = "0x1849C4390")]
	public void uninitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49C40F0", Offset = "0x49C26F0", VA = "0x1849C40F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x49C23C0", Offset = "0x49C09C0", VA = "0x1849C23C0")]
		public static extern void SWIGRegisterExceptionCallbacks_tox_wrap(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x49C2300", Offset = "0x49C0900", VA = "0x1849C2300")]
		public static extern void SWIGRegisterExceptionCallbacksArgument_tox_wrap(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x49C2560", Offset = "0x49C0B60", VA = "0x1849C2560")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x49C2860", Offset = "0x49C0E60", VA = "0x1849C2860")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49C28F0", Offset = "0x49C0EF0", VA = "0x1849C28F0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49C2A10", Offset = "0x49C1010", VA = "0x1849C2A10")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x49C2AA0", Offset = "0x49C10A0", VA = "0x1849C2AA0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x49C2B30", Offset = "0x49C1130", VA = "0x1849C2B30")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x49C2980", Offset = "0x49C0F80", VA = "0x1849C2980")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x49C2BC0", Offset = "0x49C11C0", VA = "0x1849C2BC0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x49C2C50", Offset = "0x49C1250", VA = "0x1849C2C50")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x49C2CE0", Offset = "0x49C12E0", VA = "0x1849C2CE0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49C2D70", Offset = "0x49C1370", VA = "0x1849C2D70")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49C25F0", Offset = "0x49C0BF0", VA = "0x1849C25F0")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x49C26A0", Offset = "0x49C0CA0", VA = "0x1849C26A0")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49C2780", Offset = "0x49C0D80", VA = "0x1849C2780")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x49C2E00", Offset = "0x49C1400", VA = "0x1849C2E00")]
		static SWIGExceptionHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x49C38B0", Offset = "0x49C1EB0", VA = "0x1849C38B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x49C3670", Offset = "0x49C1C70", VA = "0x1849C3670")]
		public static void Set(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x49C34E0", Offset = "0x49C1AE0", VA = "0x1849C34E0")]
		public static Exception Retrieve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x49C3850", Offset = "0x49C1E50", VA = "0x1849C3850")]
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
		[Cpp2IlInjected.Address(RVA = "0x49C3950", Offset = "0x49C1F50", VA = "0x1849C3950")]
		public static extern void SWIGRegisterStringCallback_tox_wrap(SWIGStringDelegate stringDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x531600", Offset = "0x52FC00", VA = "0x180531600")]
		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x49C39E0", Offset = "0x49C1FE0", VA = "0x1849C39E0")]
		static SWIGStringHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public SWIGStringHelper()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	protected static SWIGExceptionHelper swigExceptionHelper;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	protected static SWIGStringHelper swigStringHelper;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x49C4B70", Offset = "0x49C3170", VA = "0x1849C4B70")]
	static tox_wrapPINVOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49C48F0", Offset = "0x49C2EF0", VA = "0x1849C48F0")]
	public static extern void ToxModManager_raw_add_audio(HandleRef jarg1, [In][Out] float[] jarg2, int jarg3, int jarg4);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49C4780", Offset = "0x49C2D80", VA = "0x1849C4780")]
	public static extern IntPtr ToxModManager_Instance();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x49C47F0", Offset = "0x49C2DF0", VA = "0x1849C47F0")]
	public static extern void ToxModManager_initialize_with_player_name(HandleRef jarg1, string jarg2, string jarg3, string jarg4, int jarg5, int jarg6);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x49C4A40", Offset = "0x49C3040", VA = "0x1849C4A40")]
	public static extern int ToxModManager_set_session_name(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x49C4AF0", Offset = "0x49C30F0", VA = "0x1849C4AF0")]
	public static extern void ToxModManager_uninitialize(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x49C49B0", Offset = "0x49C2FB0", VA = "0x1849C49B0")]
	public static extern void ToxModManager_set_printer(HandleRef jarg1, HandleRef jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x49C4C80", Offset = "0x49C3280", VA = "0x1849C4C80")]
	public static extern void delete_ToxModManager(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49C4C00", Offset = "0x49C3200", VA = "0x1849C4C00")]
	public static extern void delete_Printer(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49C45A0", Offset = "0x49C2BA0", VA = "0x1849C45A0")]
	public static extern void Printer_print_error(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49C4500", Offset = "0x49C2B00", VA = "0x1849C4500")]
	public static extern void Printer_print_errorSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49C46E0", Offset = "0x49C2CE0", VA = "0x1849C46E0")]
	public static extern void Printer_print_msg(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49C4640", Offset = "0x49C2C40", VA = "0x1849C4640")]
	public static extern void Printer_print_msgSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49C4D00", Offset = "0x49C3300", VA = "0x1849C4D00")]
	public static extern IntPtr new_Printer();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49C4450", Offset = "0x49C2A50", VA = "0x1849C4450")]
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
