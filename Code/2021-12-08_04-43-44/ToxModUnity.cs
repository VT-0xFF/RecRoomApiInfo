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
	[Cpp2IlInjected.Address(RVA = "0x43BB010", Offset = "0x43BA410", VA = "0x1843BB010", Slot = "6")]
	public override void print_error(string err_msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "7")]
	public override void print_msg(string msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43BAFB0", Offset = "0x43BA3B0", VA = "0x1843BAFB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x43BBAF0", Offset = "0x43BAEF0", VA = "0x1843BBAF0")]
	internal Printer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43BBB50", Offset = "0x43BAF50", VA = "0x1843BBB50")]
	internal static HandleRef getCPtr(Printer obj)
	{
		return default(HandleRef);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43BB260", Offset = "0x43BA660", VA = "0x1843BB260", Slot = "1")]
	~Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43BB080", Offset = "0x43BA480", VA = "0x1843BB080", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43BB0F0", Offset = "0x43BA4F0", VA = "0x1843BB0F0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43BBBD0", Offset = "0x43BAFD0", VA = "0x1843BBBD0", Slot = "6")]
	public virtual void print_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43BBE00", Offset = "0x43BB200", VA = "0x1843BBE00", Slot = "7")]
	public virtual void print_msg(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43BB820", Offset = "0x43BAC20", VA = "0x1843BB820")]
	public Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x43BB3D0", Offset = "0x43BA7D0", VA = "0x1843BB3D0")]
	private void SwigDirectorConnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43BB2E0", Offset = "0x43BA6E0", VA = "0x1843BB2E0")]
	private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43BB5B0", Offset = "0x43BA9B0", VA = "0x1843BB5B0")]
	[MonoPInvokeCallback(typeof(SwigDelegatePrinter_0))]
	private static void SwigDirectorMethodprint_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x43BB630", Offset = "0x43BAA30", VA = "0x1843BB630")]
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
	[Cpp2IlInjected.Address(RVA = "0x43BBAF0", Offset = "0x43BAEF0", VA = "0x1843BBAF0")]
	internal ToxModManager(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x43BD870", Offset = "0x43BCC70", VA = "0x1843BD870", Slot = "1")]
	~ToxModManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x43BD690", Offset = "0x43BCA90", VA = "0x1843BD690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x43BD700", Offset = "0x43BCB00", VA = "0x1843BD700", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x43BDB90", Offset = "0x43BCF90", VA = "0x1843BDB90")]
	public void raw_add_audio(float[] float_data, int float_data_len, int audio_frame_rate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x43BD8F0", Offset = "0x43BCCF0", VA = "0x1843BD8F0")]
	public static ToxModManager Instance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43BD9F0", Offset = "0x43BCDF0", VA = "0x1843BD9F0")]
	public void initialize_with_player_name(string player_name, string account_id, string api_key, int verbosity, TOX_TRIAGE_SETTING triage_setting)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x43BDDE0", Offset = "0x43BD1E0", VA = "0x1843BDDE0")]
	public TOX_ERROR set_session_name(string session_name)
	{
		return default(TOX_ERROR);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43BDF30", Offset = "0x43BD330", VA = "0x1843BDF30")]
	public void uninitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43BDC90", Offset = "0x43BD090", VA = "0x1843BDC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x43BC0F0", Offset = "0x43BB4F0", VA = "0x1843BC0F0")]
		public static extern void SWIGRegisterExceptionCallbacks_tox_wrap(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43BC030", Offset = "0x43BB430", VA = "0x1843BC030")]
		public static extern void SWIGRegisterExceptionCallbacksArgument_tox_wrap(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x43BC290", Offset = "0x43BB690", VA = "0x1843BC290")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x43BC590", Offset = "0x43BB990", VA = "0x1843BC590")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x43BC620", Offset = "0x43BBA20", VA = "0x1843BC620")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x43BC740", Offset = "0x43BBB40", VA = "0x1843BC740")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x43BC7D0", Offset = "0x43BBBD0", VA = "0x1843BC7D0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x43BC860", Offset = "0x43BBC60", VA = "0x1843BC860")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x43BC6B0", Offset = "0x43BBAB0", VA = "0x1843BC6B0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x43BC8F0", Offset = "0x43BBCF0", VA = "0x1843BC8F0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x43BC980", Offset = "0x43BBD80", VA = "0x1843BC980")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x43BCA10", Offset = "0x43BBE10", VA = "0x1843BCA10")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x43BCAA0", Offset = "0x43BBEA0", VA = "0x1843BCAA0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x43BC320", Offset = "0x43BB720", VA = "0x1843BC320")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x43BC3D0", Offset = "0x43BB7D0", VA = "0x1843BC3D0")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x43BC4B0", Offset = "0x43BB8B0", VA = "0x1843BC4B0")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x43BCB30", Offset = "0x43BBF30", VA = "0x1843BCB30")]
		static SWIGExceptionHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x43BD480", Offset = "0x43BC880", VA = "0x1843BD480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x43BD250", Offset = "0x43BC650", VA = "0x1843BD250")]
		public static void Set(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x43BD0D0", Offset = "0x43BC4D0", VA = "0x1843BD0D0")]
		public static Exception Retrieve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x43BD420", Offset = "0x43BC820", VA = "0x1843BD420")]
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
		[Cpp2IlInjected.Address(RVA = "0x43BD520", Offset = "0x43BC920", VA = "0x1843BD520")]
		public static extern void SWIGRegisterStringCallback_tox_wrap(SWIGStringDelegate stringDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5519A0", Offset = "0x550DA0", VA = "0x1805519A0")]
		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x43BD5B0", Offset = "0x43BC9B0", VA = "0x1843BD5B0")]
		static SWIGStringHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public SWIGStringHelper()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	protected static SWIGExceptionHelper swigExceptionHelper;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	protected static SWIGStringHelper swigStringHelper;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x43BE710", Offset = "0x43BDB10", VA = "0x1843BE710")]
	static tox_wrapPINVOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x43BE490", Offset = "0x43BD890", VA = "0x1843BE490")]
	public static extern void ToxModManager_raw_add_audio(HandleRef jarg1, [In][Out] float[] jarg2, int jarg3, int jarg4);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x43BE320", Offset = "0x43BD720", VA = "0x1843BE320")]
	public static extern IntPtr ToxModManager_Instance();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x43BE390", Offset = "0x43BD790", VA = "0x1843BE390")]
	public static extern void ToxModManager_initialize_with_player_name(HandleRef jarg1, string jarg2, string jarg3, string jarg4, int jarg5, int jarg6);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x43BE5E0", Offset = "0x43BD9E0", VA = "0x1843BE5E0")]
	public static extern int ToxModManager_set_session_name(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x43BE690", Offset = "0x43BDA90", VA = "0x1843BE690")]
	public static extern void ToxModManager_uninitialize(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x43BE550", Offset = "0x43BD950", VA = "0x1843BE550")]
	public static extern void ToxModManager_set_printer(HandleRef jarg1, HandleRef jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43BE810", Offset = "0x43BDC10", VA = "0x1843BE810")]
	public static extern void delete_ToxModManager(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43BE790", Offset = "0x43BDB90", VA = "0x1843BE790")]
	public static extern void delete_Printer(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43BE140", Offset = "0x43BD540", VA = "0x1843BE140")]
	public static extern void Printer_print_error(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43BE0A0", Offset = "0x43BD4A0", VA = "0x1843BE0A0")]
	public static extern void Printer_print_errorSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43BE280", Offset = "0x43BD680", VA = "0x1843BE280")]
	public static extern void Printer_print_msg(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x43BE1E0", Offset = "0x43BD5E0", VA = "0x1843BE1E0")]
	public static extern void Printer_print_msgSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x43BE890", Offset = "0x43BDC90", VA = "0x1843BE890")]
	public static extern IntPtr new_Printer();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x43BDFF0", Offset = "0x43BD3F0", VA = "0x1843BDFF0")]
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
