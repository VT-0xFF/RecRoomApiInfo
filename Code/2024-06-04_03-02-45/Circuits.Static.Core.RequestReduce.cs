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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D580", Offset = "0x1F4BD80", VA = "0x181F4D580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KAPLCJNFCJL<TActionKind, TPayload> NICLNCGALGC<TActionKind, TSerializedAction, TPayload>(TSerializedAction LCGDIHOFJNP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CDCJHCKLPHN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> HBHJMBFCIJJ(TDeps DNJOEPEBEMJ, TRoot AHKBBGKKCNK, TSerializedAction LCGDIHOFJNP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PCGKDBODHFK<TActionKind, TSerializedAction, TRoot, TDeps> : FDKFIPGCOGB where TDeps : OPEEJNJBEAD.OHFECBHGEAO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction CPJICIJNFAA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x464E910", Offset = "0x464D110", VA = "0x18464E910")]
	public PCGKDBODHFK([In] TDeps DNJOEPEBEMJ, [In] TSerializedAction LCGDIHOFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x464E740", Offset = "0x464CF40", VA = "0x18464E740", Slot = "7")]
	public override string ILHCPMBLOJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KAPLCJNFCJL<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind MHBLMPPGBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload ABIAICEECGE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4076500", Offset = "0x4074D00", VA = "0x184076500")]
	internal KAPLCJNFCJL(TActionKind CDFGKJPKLFB, [In] TPayload EMIMPCIEFOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EJKLPIEBNKP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2919650", Offset = "0x2917E50", VA = "0x182919650")]
	public static KAPLCJNFCJL<TActionKind, TPayload> OJFFIHPLODM<TActionKind, TPayload>([In] TActionKind CDFGKJPKLFB, [In] TPayload EMIMPCIEFOP)
	{
		return default(KAPLCJNFCJL<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<MEKCEIEFNPI<TOk, TErr>> HBHIBNDGNME<TRoot, TPayload, TOk, TErr>(TRoot AHKBBGKKCNK, TPayload EMIMPCIEFOP);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate MEKCEIEFNPI<TOk, TErr> KBPPENFDHGA<TRoot, TPayload, TOk, TErr>(TRoot AHKBBGKKCNK, [In] TPayload EMIMPCIEFOP);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HLOBOENKPAF<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : OPEEJNJBEAD.OHFECBHGEAO<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NEMNGOECOFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HLOBOENKPAF<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<MEKCEIEFNPI<object, MNGIPKBLGNG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4428AD0", Offset = "0x44272D0", VA = "0x184428AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4429420", Offset = "0x4427C20", VA = "0x184429420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CDCJHCKLPHN<TSerializedAction, TRoot, TDeps>> EBCCAALBLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	internal HLOBOENKPAF(Dictionary<TActionKind, CDCJHCKLPHN<TSerializedAction, TRoot, TDeps>> ICKHHKMHBGL, TDeps DNJOEPEBEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3130", Offset = "0x3CB1930", VA = "0x183CB3130")]
	[AsyncStateMachine(typeof(HLOBOENKPAF<, , , >.NEMNGOECOFC))]
	public Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> HBHJMBFCIJJ(TRoot AHKBBGKKCNK, TSerializedAction LCGDIHOFJNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OPEEJNJBEAD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OHFECBHGEAO<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind COFDKCFNEPN(TSerializedAction EGJINJKGIAK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBEEDOCHEMG(TRoot AHKBBGKKCNK, TSerializedAction BMOCGPMNBAF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LKDDOFFKCML(TRoot AHKBBGKKCNK, TSerializedAction BMOCGPMNBAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2831290", Offset = "0x282FA90", VA = "0x182831290")]
	internal static HLOBOENKPAF<TActionKind, TSerializedAction, TRoot, TDeps> OJFFIHPLODM<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CDCJHCKLPHN<TSerializedAction, TRoot, TDeps>> ICKHHKMHBGL, TDeps DNJOEPEBEMJ) where TDeps : OHFECBHGEAO<TActionKind, TSerializedAction, TRoot>
	{
		return default(HLOBOENKPAF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HPEHODKDFBC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CDCJHCKLPHN<TSerializedAction, TRoot, TDeps>> DPNDGIBODIJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	private HPEHODKDFBC(Dictionary<TActionKind, CDCJHCKLPHN<TSerializedAction, TRoot, TDeps>> ICKHHKMHBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0570", Offset = "0x3CCED70", VA = "0x183CD0570")]
	public static HPEHODKDFBC<TActionKind, TSerializedAction, TRoot, TDeps> OJFFIHPLODM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, OPEEJNJBEAD.OHFECBHGEAO<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HDICBCBJGJI<TPayload, TOk, TErr> : CDCJHCKLPHN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MNGIPKBLGNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NICLNCGALGC<TActionKind, TSerializedAction, TPayload> PGNIOANMPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KBPPENFDHGA<TRoot, TPayload, TOk, TErr> NHGACEBAONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool LCGNDANOENB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3C916A0", Offset = "0x3C8FEA0", VA = "0x183C916A0")]
		public HDICBCBJGJI(NICLNCGALGC<TActionKind, TSerializedAction, TPayload> MICDANHOBDP, KBPPENFDHGA<TRoot, TPayload, TOk, TErr> NALFDFFNJKB, bool FHNBEGBFPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3C84020", Offset = "0x3C82820", VA = "0x183C84020", Slot = "4")]
		public Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> HBHJMBFCIJJ(TDeps DNJOEPEBEMJ, TRoot AHKBBGKKCNK, TSerializedAction LCGDIHOFJNP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class DDJIJDIDDCI<TPayload, TOk, TErr> : CDCJHCKLPHN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MNGIPKBLGNG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PIKDGJBDKBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MEKCEIEFNPI<object?, MNGIPKBLGNG>> <>t__builder;

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
			public DDJIJDIDDCI<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private MEKCEIEFNPI<object?, MNGIPKBLGNG> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MEKCEIEFNPI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x465AED0", Offset = "0x46596D0", VA = "0x18465AED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x465BE70", Offset = "0x465A670", VA = "0x18465BE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly NICLNCGALGC<TActionKind, TSerializedAction, TPayload> PGNIOANMPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HBHIBNDGNME<TRoot, TPayload, TOk, TErr> NHGACEBAONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool LCGNDANOENB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3C916A0", Offset = "0x3C8FEA0", VA = "0x183C916A0")]
		public DDJIJDIDDCI(NICLNCGALGC<TActionKind, TSerializedAction, TPayload> MICDANHOBDP, HBHIBNDGNME<TRoot, TPayload, TOk, TErr> NALFDFFNJKB, bool FHNBEGBFPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x56E9380", Offset = "0x56E7B80", VA = "0x1856E9380", Slot = "4")]
		[AsyncStateMachine(typeof(DDJIJDIDDCI<, , >.PIKDGJBDKBO))]
		public Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> HBHJMBFCIJJ(TDeps DNJOEPEBEMJ, TRoot AHKBBGKKCNK, TSerializedAction LCGDIHOFJNP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HPEHODKDFBC<TActionKind, TSerializedAction, TRoot, TDeps> LEJBFAOMBPP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	private IMNPCNCFILD(HPEHODKDFBC<TActionKind, TSerializedAction, TRoot, TDeps> MLKNGAFFKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FA20", Offset = "0x3D9E220", VA = "0x183D9FA20")]
	public static IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps> OJFFIHPLODM()
	{
		return default(IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2999EA0", Offset = "0x29986A0", VA = "0x182999EA0")]
	public IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps> EKGNBFMDDFO<TPayload, TOk, TErr>(TActionKind CDFGKJPKLFB, NICLNCGALGC<TActionKind, TSerializedAction, TPayload> MICDANHOBDP, KBPPENFDHGA<TRoot, TPayload, TOk, TErr> NALFDFFNJKB, bool FHNBEGBFPCE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MNGIPKBLGNG
	{
		return default(IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2999EA0", Offset = "0x29986A0", VA = "0x182999EA0")]
	public IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps> PHFHFEEKGLC<TPayload, TOk, TErr>(TActionKind CDFGKJPKLFB, NICLNCGALGC<TActionKind, TSerializedAction, TPayload> MICDANHOBDP, HBHIBNDGNME<TRoot, TPayload, TOk, TErr> NALFDFFNJKB, bool FHNBEGBFPCE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MNGIPKBLGNG
	{
		return default(IMNPCNCFILD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F960", Offset = "0x3D9E160", VA = "0x183D9F960")]
	public HLOBOENKPAF<TActionKind, TSerializedAction, TRoot, TDeps> AICBEBBPJOO(TDeps DNJOEPEBEMJ)
	{
		return default(HLOBOENKPAF<TActionKind, TSerializedAction, TRoot, TDeps>);
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
