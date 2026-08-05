using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B78A10", Offset = "0x2B77010", VA = "0x182B78A10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LIOBLHDBJFH<TActionKind, TPayload> OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload>(TSerializedAction GAKJNKICNIN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MMGMDOOFJHH<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CKPAOGHIJHA<object, HCKLGFJODKO>> ODENFLGLKHE(TDeps NBGHBGMICNM, TRoot BOCNDANOLJJ, TSerializedAction GAKJNKICNIN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OAAIPAJHGLM<TActionKind, TSerializedAction, TRoot, TDeps> : MMOOADNOMBF where TDeps : LMEHLEPPJPK.IHCLIKODIEL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps EHPINPNKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction NHHAFELDPAN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AEA0", Offset = "0x5B894A0", VA = "0x185B8AEA0")]
	public OAAIPAJHGLM([In] TDeps NBGHBGMICNM, [In] TSerializedAction GAKJNKICNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AD70", Offset = "0x5B89370", VA = "0x185B8AD70", Slot = "7")]
	public override string GAEFJPMCOGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LIOBLHDBJFH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BJPALGCILNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload IMADFNFLOAJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57CA960", Offset = "0x57C8F60", VA = "0x1857CA960")]
	internal LIOBLHDBJFH(TActionKind BNAEEMDMFEH, [In] TPayload JFAOAIPNPMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AFGCNLPDMMP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x32FD560", Offset = "0x32FBB60", VA = "0x1832FD560")]
	public static LIOBLHDBJFH<TActionKind, TPayload> CPNHECDILPK<TActionKind, TPayload>([In] TActionKind BNAEEMDMFEH, [In] TPayload JFAOAIPNPMB)
	{
		return default(LIOBLHDBJFH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CKPAOGHIJHA<TOk, TErr>> APAKCGALBIG<TRoot, TPayload, TOk, TErr>(TRoot BOCNDANOLJJ, TPayload JFAOAIPNPMB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CKPAOGHIJHA<TOk, TErr> OEAJJHIIOCK<TRoot, TPayload, TOk, TErr>(TRoot BOCNDANOLJJ, [In] TPayload JFAOAIPNPMB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PLCNFAGFDBO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LMEHLEPPJPK.IHCLIKODIEL<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DDPFGENIDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<object?, HCKLGFJODKO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PLCNFAGFDBO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CKPAOGHIJHA<object, HCKLGFJODKO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4648EF0", Offset = "0x46474F0", VA = "0x184648EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4649370", Offset = "0x4647970", VA = "0x184649370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MMGMDOOFJHH<TSerializedAction, TRoot, TDeps>> DOFHAGPANFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps EHPINPNKKID;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
	internal PLCNFAGFDBO(Dictionary<TActionKind, MMGMDOOFJHH<TSerializedAction, TRoot, TDeps>> LAPGKPNKAIA, TDeps NBGHBGMICNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CDE6B0", Offset = "0x5CDCCB0", VA = "0x185CDE6B0")]
	[AsyncStateMachine(typeof(PLCNFAGFDBO<, , , >.DDPFGENIDDK))]
	public Task<CKPAOGHIJHA<object, HCKLGFJODKO>> ODENFLGLKHE(TRoot BOCNDANOLJJ, TSerializedAction GAKJNKICNIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LMEHLEPPJPK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IHCLIKODIEL<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DLPGBAIKFIB(TSerializedAction JNMMMBJNOND);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GPACBGPMJLI(TRoot BOCNDANOLJJ, TSerializedAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CMKHFMAEDCA(TRoot BOCNDANOLJJ, TSerializedAction PMBBLAOPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C61780", Offset = "0x3C5FD80", VA = "0x183C61780")]
	internal static PLCNFAGFDBO<TActionKind, TSerializedAction, TRoot, TDeps> CPNHECDILPK<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MMGMDOOFJHH<TSerializedAction, TRoot, TDeps>> LAPGKPNKAIA, TDeps NBGHBGMICNM) where TDeps : IHCLIKODIEL<TActionKind, TSerializedAction, TRoot>
	{
		return default(PLCNFAGFDBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PNPCJNANOAP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MMGMDOOFJHH<TSerializedAction, TRoot, TDeps>> EEMFMJCFCKK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	private PNPCJNANOAP(Dictionary<TActionKind, MMGMDOOFJHH<TSerializedAction, TRoot, TDeps>> LAPGKPNKAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2DF0", Offset = "0x5CF13F0", VA = "0x185CF2DF0")]
	public static PNPCJNANOAP<TActionKind, TSerializedAction, TRoot, TDeps> CPNHECDILPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LMEHLEPPJPK.IHCLIKODIEL<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KKJIPADNEMC<TPayload, TOk, TErr> : MMGMDOOFJHH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HCKLGFJODKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload> ANFLCBAIDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OEAJJHIIOCK<TRoot, TPayload, TOk, TErr> DDNKMKLHAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool AGPEADBJIAF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2010", Offset = "0x1CF0610", VA = "0x181CF2010")]
		public KKJIPADNEMC(OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload> FNKMPBBNJMC, OEAJJHIIOCK<TRoot, TPayload, TOk, TErr> MLALEODDEAK, bool ECCHBLNCEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x56C9B40", Offset = "0x56C8140", VA = "0x1856C9B40", Slot = "4")]
		public Task<CKPAOGHIJHA<object, HCKLGFJODKO>> ODENFLGLKHE(TDeps NBGHBGMICNM, TRoot BOCNDANOLJJ, TSerializedAction GAKJNKICNIN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HKNIIDANPCF<TPayload, TOk, TErr> : MMGMDOOFJHH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HCKLGFJODKO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct OCJICPKILNG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CKPAOGHIJHA<object?, HCKLGFJODKO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HKNIIDANPCF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CKPAOGHIJHA<object?, HCKLGFJODKO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CKPAOGHIJHA<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5B99A60", Offset = "0x5B98060", VA = "0x185B99A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5B9A3C0", Offset = "0x5B989C0", VA = "0x185B9A3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload> ANFLCBAIDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly APAKCGALBIG<TRoot, TPayload, TOk, TErr> DDNKMKLHAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool AGPEADBJIAF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1CF2010", Offset = "0x1CF0610", VA = "0x181CF2010")]
		public HKNIIDANPCF(OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload> FNKMPBBNJMC, APAKCGALBIG<TRoot, TPayload, TOk, TErr> MLALEODDEAK, bool ECCHBLNCEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x516C860", Offset = "0x516AE60", VA = "0x18516C860", Slot = "4")]
		[AsyncStateMachine(typeof(HKNIIDANPCF<, , >.OCJICPKILNG))]
		public Task<CKPAOGHIJHA<object, HCKLGFJODKO>> ODENFLGLKHE(TDeps NBGHBGMICNM, TRoot BOCNDANOLJJ, TSerializedAction GAKJNKICNIN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly PNPCJNANOAP<TActionKind, TSerializedAction, TRoot, TDeps> NAGACDOJNOK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
	private BIFLEGHODJM(PNPCJNANOAP<TActionKind, TSerializedAction, TRoot, TDeps> CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6A40", Offset = "0x6AF5040", VA = "0x186AF6A40")]
	public static BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps> CPNHECDILPK()
	{
		return default(BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F31450", Offset = "0x3F2FA50", VA = "0x183F31450")]
	public BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps> PKBFBJDKDLC<TPayload, TOk, TErr>(TActionKind BNAEEMDMFEH, OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload> FNKMPBBNJMC, OEAJJHIIOCK<TRoot, TPayload, TOk, TErr> MLALEODDEAK, bool ECCHBLNCEHI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HCKLGFJODKO
	{
		return default(BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F31450", Offset = "0x3F2FA50", VA = "0x183F31450")]
	public BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps> JKJKCAOIHJI<TPayload, TOk, TErr>(TActionKind BNAEEMDMFEH, OMBCLLLFEEN<TActionKind, TSerializedAction, TPayload> FNKMPBBNJMC, APAKCGALBIG<TRoot, TPayload, TOk, TErr> MLALEODDEAK, bool ECCHBLNCEHI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HCKLGFJODKO
	{
		return default(BIFLEGHODJM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6AD0", Offset = "0x6AF50D0", VA = "0x186AF6AD0")]
	public PLCNFAGFDBO<TActionKind, TSerializedAction, TRoot, TDeps> KBLDJAMLPDO(TDeps NBGHBGMICNM)
	{
		return default(PLCNFAGFDBO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
namespace Cpp2IlInjected
{
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
}
