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
	[Cpp2IlInjected.Address(RVA = "0x1B7CDC0", Offset = "0x1B7B5C0", VA = "0x181B7CDC0", Slot = "6")]
	public override void print_error(string err_msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "7")]
	public override void print_msg(string msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1B7CC50", Offset = "0x1B7B450", VA = "0x181B7CC50")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B7D750", Offset = "0x1B7BF50", VA = "0x181B7D750")]
	internal Printer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D7C0", Offset = "0x1B7BFC0", VA = "0x181B7D7C0")]
	internal static HandleRef getCPtr(Printer obj)
	{
		return default(HandleRef);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D020", Offset = "0x1B7B820", VA = "0x181B7D020", Slot = "1")]
	~Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1B7CE30", Offset = "0x1B7B630", VA = "0x181B7CE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1B7CEA0", Offset = "0x1B7B6A0", VA = "0x181B7CEA0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D840", Offset = "0x1B7C040", VA = "0x181B7D840", Slot = "6")]
	public virtual void print_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1B7DA70", Offset = "0x1B7C270", VA = "0x181B7DA70", Slot = "7")]
	public virtual void print_msg(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D620", Offset = "0x1B7BE20", VA = "0x181B7D620")]
	public Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D190", Offset = "0x1B7B990", VA = "0x181B7D190")]
	private void SwigDirectorConnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D0A0", Offset = "0x1B7B8A0", VA = "0x181B7D0A0")]
	private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D390", Offset = "0x1B7BB90", VA = "0x181B7D390")]
	[MonoPInvokeCallback(typeof(SwigDelegatePrinter_0))]
	private static void SwigDirectorMethodprint_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1B7D410", Offset = "0x1B7BC10", VA = "0x181B7D410")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B7D750", Offset = "0x1B7BF50", VA = "0x181B7D750")]
	internal ToxModManager(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F670", Offset = "0x1B7DE70", VA = "0x181B7F670", Slot = "1")]
	~ToxModManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F480", Offset = "0x1B7DC80", VA = "0x181B7F480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F4F0", Offset = "0x1B7DCF0", VA = "0x181B7F4F0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F990", Offset = "0x1B7E190", VA = "0x181B7F990")]
	public void raw_add_audio(float[] float_data, int float_data_len, int audio_frame_rate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F6F0", Offset = "0x1B7DEF0", VA = "0x181B7F6F0")]
	public static ToxModManager Instance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1B7F7F0", Offset = "0x1B7DFF0", VA = "0x181B7F7F0")]
	public void initialize_with_player_name(string player_name, string account_id, string api_key, int verbosity, TOX_TRIAGE_SETTING triage_setting)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FBE0", Offset = "0x1B7E3E0", VA = "0x181B7FBE0")]
	public TOX_ERROR set_session_name(string session_name)
	{
		return default(TOX_ERROR);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FD30", Offset = "0x1B7E530", VA = "0x181B7FD30")]
	public void uninitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FA90", Offset = "0x1B7E290", VA = "0x181B7FA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B7DD60", Offset = "0x1B7C560", VA = "0x181B7DD60")]
		public static extern void SWIGRegisterExceptionCallbacks_tox_wrap(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1B7DCA0", Offset = "0x1B7C4A0", VA = "0x181B7DCA0")]
		public static extern void SWIGRegisterExceptionCallbacksArgument_tox_wrap(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1B7DF00", Offset = "0x1B7C700", VA = "0x181B7DF00")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E200", Offset = "0x1B7CA00", VA = "0x181B7E200")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E290", Offset = "0x1B7CA90", VA = "0x181B7E290")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E3B0", Offset = "0x1B7CBB0", VA = "0x181B7E3B0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E440", Offset = "0x1B7CC40", VA = "0x181B7E440")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E4D0", Offset = "0x1B7CCD0", VA = "0x181B7E4D0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E320", Offset = "0x1B7CB20", VA = "0x181B7E320")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E560", Offset = "0x1B7CD60", VA = "0x181B7E560")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E5F0", Offset = "0x1B7CDF0", VA = "0x181B7E5F0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E680", Offset = "0x1B7CE80", VA = "0x181B7E680")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E710", Offset = "0x1B7CF10", VA = "0x181B7E710")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1B7DF90", Offset = "0x1B7C790", VA = "0x181B7DF90")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E040", Offset = "0x1B7C840", VA = "0x181B7E040")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E120", Offset = "0x1B7C920", VA = "0x181B7E120")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1B7E7A0", Offset = "0x1B7CFA0", VA = "0x181B7E7A0")]
		static SWIGExceptionHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
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
			[Cpp2IlInjected.Address(RVA = "0x1B7F250", Offset = "0x1B7DA50", VA = "0x181B7F250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1B7F010", Offset = "0x1B7D810", VA = "0x181B7F010")]
		public static void Set(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1B7EE80", Offset = "0x1B7D680", VA = "0x181B7EE80")]
		public static Exception Retrieve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1B7F1F0", Offset = "0x1B7D9F0", VA = "0x181B7F1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B7F2F0", Offset = "0x1B7DAF0", VA = "0x181B7F2F0")]
		public static extern void SWIGRegisterStringCallback_tox_wrap(SWIGStringDelegate stringDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCD0", Offset = "0x5CE4D0", VA = "0x1805CFCD0")]
		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1B7F380", Offset = "0x1B7DB80", VA = "0x181B7F380")]
		static SWIGStringHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public SWIGStringHelper()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	protected static SWIGExceptionHelper swigExceptionHelper;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	protected static SWIGStringHelper swigStringHelper;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1B80510", Offset = "0x1B7ED10", VA = "0x181B80510")]
	static tox_wrapPINVOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B80290", Offset = "0x1B7EA90", VA = "0x181B80290")]
	public static extern void ToxModManager_raw_add_audio(HandleRef jarg1, [In][Out] float[] jarg2, int jarg3, int jarg4);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B80120", Offset = "0x1B7E920", VA = "0x181B80120")]
	public static extern IntPtr ToxModManager_Instance();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1B80190", Offset = "0x1B7E990", VA = "0x181B80190")]
	public static extern void ToxModManager_initialize_with_player_name(HandleRef jarg1, string jarg2, string jarg3, string jarg4, int jarg5, int jarg6);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B803E0", Offset = "0x1B7EBE0", VA = "0x181B803E0")]
	public static extern int ToxModManager_set_session_name(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B80490", Offset = "0x1B7EC90", VA = "0x181B80490")]
	public static extern void ToxModManager_uninitialize(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B80350", Offset = "0x1B7EB50", VA = "0x181B80350")]
	public static extern void ToxModManager_set_printer(HandleRef jarg1, HandleRef jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B80620", Offset = "0x1B7EE20", VA = "0x181B80620")]
	public static extern void delete_ToxModManager(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1B805A0", Offset = "0x1B7EDA0", VA = "0x181B805A0")]
	public static extern void delete_Printer(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FF40", Offset = "0x1B7E740", VA = "0x181B7FF40")]
	public static extern void Printer_print_error(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FEA0", Offset = "0x1B7E6A0", VA = "0x181B7FEA0")]
	public static extern void Printer_print_errorSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B80080", Offset = "0x1B7E880", VA = "0x181B80080")]
	public static extern void Printer_print_msg(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FFE0", Offset = "0x1B7E7E0", VA = "0x181B7FFE0")]
	public static extern void Printer_print_msgSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1B806A0", Offset = "0x1B7EEA0", VA = "0x181B806A0")]
	public static extern IntPtr new_Printer();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FDF0", Offset = "0x1B7E5F0", VA = "0x181B7FDF0")]
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
