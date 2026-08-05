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
	[Cpp2IlInjected.Address(RVA = "0x4AB4590", Offset = "0x4AB3390", VA = "0x184AB4590", Slot = "6")]
	public override void print_error(string err_msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "7")]
	public override void print_msg(string msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4420", Offset = "0x4AB3220", VA = "0x184AB4420")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AB4F20", Offset = "0x4AB3D20", VA = "0x184AB4F20")]
	internal Printer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4F90", Offset = "0x4AB3D90", VA = "0x184AB4F90")]
	internal static HandleRef getCPtr(Printer obj)
	{
		return default(HandleRef);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4AB47F0", Offset = "0x4AB35F0", VA = "0x184AB47F0", Slot = "1")]
	~Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4600", Offset = "0x4AB3400", VA = "0x184AB4600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4670", Offset = "0x4AB3470", VA = "0x184AB4670", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5010", Offset = "0x4AB3E10", VA = "0x184AB5010", Slot = "6")]
	public virtual void print_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5240", Offset = "0x4AB4040", VA = "0x184AB5240", Slot = "7")]
	public virtual void print_msg(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4DF0", Offset = "0x4AB3BF0", VA = "0x184AB4DF0")]
	public Printer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4960", Offset = "0x4AB3760", VA = "0x184AB4960")]
	private void SwigDirectorConnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4870", Offset = "0x4AB3670", VA = "0x184AB4870")]
	private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4B60", Offset = "0x4AB3960", VA = "0x184AB4B60")]
	[MonoPInvokeCallback(typeof(SwigDelegatePrinter_0))]
	private static void SwigDirectorMethodprint_error(string output)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB4BE0", Offset = "0x4AB39E0", VA = "0x184AB4BE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4AB4F20", Offset = "0x4AB3D20", VA = "0x184AB4F20")]
	internal ToxModManager(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6E40", Offset = "0x4AB5C40", VA = "0x184AB6E40", Slot = "1")]
	~ToxModManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6C50", Offset = "0x4AB5A50", VA = "0x184AB6C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6CC0", Offset = "0x4AB5AC0", VA = "0x184AB6CC0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7160", Offset = "0x4AB5F60", VA = "0x184AB7160")]
	public void raw_add_audio(float[] float_data, int float_data_len, int audio_frame_rate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6EC0", Offset = "0x4AB5CC0", VA = "0x184AB6EC0")]
	public static ToxModManager Instance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6FC0", Offset = "0x4AB5DC0", VA = "0x184AB6FC0")]
	public void initialize_with_player_name(string player_name, string account_id, string api_key, int verbosity, TOX_TRIAGE_SETTING triage_setting)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4AB73B0", Offset = "0x4AB61B0", VA = "0x184AB73B0")]
	public TOX_ERROR set_session_name(string session_name)
	{
		return default(TOX_ERROR);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7500", Offset = "0x4AB6300", VA = "0x184AB7500")]
	public void uninitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7260", Offset = "0x4AB6060", VA = "0x184AB7260")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AB5530", Offset = "0x4AB4330", VA = "0x184AB5530")]
		public static extern void SWIGRegisterExceptionCallbacks_tox_wrap(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5470", Offset = "0x4AB4270", VA = "0x184AB5470")]
		public static extern void SWIGRegisterExceptionCallbacksArgument_tox_wrap(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4AB56D0", Offset = "0x4AB44D0", VA = "0x184AB56D0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingApplicationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4AB59D0", Offset = "0x4AB47D0", VA = "0x184AB59D0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5A60", Offset = "0x4AB4860", VA = "0x184AB5A60")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5B80", Offset = "0x4AB4980", VA = "0x184AB5B80")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5C10", Offset = "0x4AB4A10", VA = "0x184AB5C10")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5CA0", Offset = "0x4AB4AA0", VA = "0x184AB5CA0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5AF0", Offset = "0x4AB48F0", VA = "0x184AB5AF0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingIOException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5D30", Offset = "0x4AB4B30", VA = "0x184AB5D30")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5DC0", Offset = "0x4AB4BC0", VA = "0x184AB5DC0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5E50", Offset = "0x4AB4C50", VA = "0x184AB5E50")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingOverflowException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5EE0", Offset = "0x4AB4CE0", VA = "0x184AB5EE0")]
		[MonoPInvokeCallback(typeof(ExceptionDelegate))]
		private static void SetPendingSystemException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5760", Offset = "0x4AB4560", VA = "0x184AB5760")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5810", Offset = "0x4AB4610", VA = "0x184AB5810")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4AB58F0", Offset = "0x4AB46F0", VA = "0x184AB58F0")]
		[MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4AB5F70", Offset = "0x4AB4D70", VA = "0x184AB5F70")]
		static SWIGExceptionHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4AB6A20", Offset = "0x4AB5820", VA = "0x184AB6A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4AB67E0", Offset = "0x4AB55E0", VA = "0x184AB67E0")]
		public static void Set(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4AB6650", Offset = "0x4AB5450", VA = "0x184AB6650")]
		public static Exception Retrieve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4AB69C0", Offset = "0x4AB57C0", VA = "0x184AB69C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AB6AC0", Offset = "0x4AB58C0", VA = "0x184AB6AC0")]
		public static extern void SWIGRegisterStringCallback_tox_wrap(SWIGStringDelegate stringDelegate);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D1F60", Offset = "0x5D0D60", VA = "0x1805D1F60")]
		[MonoPInvokeCallback(typeof(SWIGStringDelegate))]
		private static string CreateString(string cString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4AB6B50", Offset = "0x4AB5950", VA = "0x184AB6B50")]
		static SWIGStringHelper()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public SWIGStringHelper()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	protected static SWIGExceptionHelper swigExceptionHelper;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	protected static SWIGStringHelper swigStringHelper;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7CE0", Offset = "0x4AB6AE0", VA = "0x184AB7CE0")]
	static tox_wrapPINVOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7A60", Offset = "0x4AB6860", VA = "0x184AB7A60")]
	public static extern void ToxModManager_raw_add_audio(HandleRef jarg1, [In][Out] float[] jarg2, int jarg3, int jarg4);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4AB78F0", Offset = "0x4AB66F0", VA = "0x184AB78F0")]
	public static extern IntPtr ToxModManager_Instance();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7960", Offset = "0x4AB6760", VA = "0x184AB7960")]
	public static extern void ToxModManager_initialize_with_player_name(HandleRef jarg1, string jarg2, string jarg3, string jarg4, int jarg5, int jarg6);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7BB0", Offset = "0x4AB69B0", VA = "0x184AB7BB0")]
	public static extern int ToxModManager_set_session_name(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7C60", Offset = "0x4AB6A60", VA = "0x184AB7C60")]
	public static extern void ToxModManager_uninitialize(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7B20", Offset = "0x4AB6920", VA = "0x184AB7B20")]
	public static extern void ToxModManager_set_printer(HandleRef jarg1, HandleRef jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7DF0", Offset = "0x4AB6BF0", VA = "0x184AB7DF0")]
	public static extern void delete_ToxModManager(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7D70", Offset = "0x4AB6B70", VA = "0x184AB7D70")]
	public static extern void delete_Printer(HandleRef jarg1);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7710", Offset = "0x4AB6510", VA = "0x184AB7710")]
	public static extern void Printer_print_error(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7670", Offset = "0x4AB6470", VA = "0x184AB7670")]
	public static extern void Printer_print_errorSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7850", Offset = "0x4AB6650", VA = "0x184AB7850")]
	public static extern void Printer_print_msg(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB77B0", Offset = "0x4AB65B0", VA = "0x184AB77B0")]
	public static extern void Printer_print_msgSwigExplicitPrinter(HandleRef jarg1, string jarg2);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4AB7E70", Offset = "0x4AB6C70", VA = "0x184AB7E70")]
	public static extern IntPtr new_Printer();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4AB75C0", Offset = "0x4AB63C0", VA = "0x184AB75C0")]
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
