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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x25DE0D0", Offset = "0x25DD4D0", VA = "0x1825DE0D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate OHEPFANKILP<TActionKind, TPayload> DCDGJNLILFO<TActionKind, TSerializedAction, TPayload>(TSerializedAction LINFLHMIJCC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LKPPEGHBNGN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PHLGGJNOBDN<object, MEENKFHCKIP>> AIDNGKCAKPA(TDeps BDKFMFBFJII, TRoot HAIKBOLEOOP, TSerializedAction LINFLHMIJCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class AHPNNJEGHLC<TActionKind, TSerializedAction, TRoot, TDeps> : MJOPIANFEAH where TDeps : DPEINBLHDDE.AAMEMANMBDM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction ANPCLJCECPP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4723680", Offset = "0x4722A80", VA = "0x184723680")]
	public AHPNNJEGHLC([In] TDeps BDKFMFBFJII, [In] TSerializedAction LINFLHMIJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4723560", Offset = "0x4722960", VA = "0x184723560", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OHEPFANKILP<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind OEEIFIMPBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload FLOPAAJFMBG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5250", Offset = "0x4FA4650", VA = "0x184FA5250")]
	internal OHEPFANKILP(TActionKind ILAPHICMJMF, [In] TPayload IILBHIALBMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EMBAHOOAGPC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3316060", Offset = "0x3315460", VA = "0x183316060")]
	public static OHEPFANKILP<TActionKind, TPayload> KMDIICJFNJF<TActionKind, TPayload>([In] TActionKind ILAPHICMJMF, [In] TPayload IILBHIALBMC)
	{
		return default(OHEPFANKILP<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PHLGGJNOBDN<TOk, TErr>> AGLBHKNNHAN<TRoot, TPayload, TOk, TErr>(TRoot HAIKBOLEOOP, TPayload IILBHIALBMC);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PHLGGJNOBDN<TOk, TErr> KMGGJGIHPKA<TRoot, TPayload, TOk, TErr>(TRoot HAIKBOLEOOP, [In] TPayload IILBHIALBMC);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FCAHJOKIPDH<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DPEINBLHDDE.AAMEMANMBDM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BEEEPKHCMDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FCAHJOKIPDH<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x597C9C0", Offset = "0x597BDC0", VA = "0x18597C9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x597D220", Offset = "0x597C620", VA = "0x18597D220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, LKPPEGHBNGN<TSerializedAction, TRoot, TDeps>> PDDFPOPIJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
	internal FCAHJOKIPDH(Dictionary<TActionKind, LKPPEGHBNGN<TSerializedAction, TRoot, TDeps>> NCHBFGLJDAD, TDeps BDKFMFBFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x44EC6A0", Offset = "0x44EBAA0", VA = "0x1844EC6A0")]
	[AsyncStateMachine(typeof(FCAHJOKIPDH<, , , >.BEEEPKHCMDN))]
	public Task<PHLGGJNOBDN<object, MEENKFHCKIP>> AIDNGKCAKPA(TRoot HAIKBOLEOOP, TSerializedAction LINFLHMIJCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DPEINBLHDDE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AAMEMANMBDM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FNNAPONHAJH(TSerializedAction IIICNLIAPBJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NAMJEBEDBFA(TRoot HAIKBOLEOOP, TSerializedAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OHFOBIOOPLD(TRoot HAIKBOLEOOP, TSerializedAction NJNJGNMEACN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32CD6C0", Offset = "0x32CCAC0", VA = "0x1832CD6C0")]
	internal static FCAHJOKIPDH<TActionKind, TSerializedAction, TRoot, TDeps> KMDIICJFNJF<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, LKPPEGHBNGN<TSerializedAction, TRoot, TDeps>> NCHBFGLJDAD, TDeps BDKFMFBFJII) where TDeps : AAMEMANMBDM<TActionKind, TSerializedAction, TRoot>
	{
		return default(FCAHJOKIPDH<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IOKFMBCDHKL<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, LKPPEGHBNGN<TSerializedAction, TRoot, TDeps>> GCLNBDDACOK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	private IOKFMBCDHKL(Dictionary<TActionKind, LKPPEGHBNGN<TSerializedAction, TRoot, TDeps>> NCHBFGLJDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x483FB90", Offset = "0x483EF90", VA = "0x18483FB90")]
	public static IOKFMBCDHKL<TActionKind, TSerializedAction, TRoot, TDeps> KMDIICJFNJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DPEINBLHDDE.AAMEMANMBDM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BEJLCBCHAGP<TPayload, TOk, TErr> : LKPPEGHBNGN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MEENKFHCKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DCDGJNLILFO<TActionKind, TSerializedAction, TPayload> JMALLONEBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KMGGJGIHPKA<TRoot, TPayload, TOk, TErr> NCJKIIEEJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KDIIBNDJDGN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4A0CCE0", Offset = "0x4A0C0E0", VA = "0x184A0CCE0")]
		public BEJLCBCHAGP(DCDGJNLILFO<TActionKind, TSerializedAction, TPayload> HAOOEFFPNCA, KMGGJGIHPKA<TRoot, TPayload, TOk, TErr> IDMLCOKKEON, bool AFFIINHJOEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5983080", Offset = "0x5982480", VA = "0x185983080", Slot = "4")]
		public Task<PHLGGJNOBDN<object, MEENKFHCKIP>> AIDNGKCAKPA(TDeps BDKFMFBFJII, TRoot HAIKBOLEOOP, TSerializedAction LINFLHMIJCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JFAOBBGLJOK<TPayload, TOk, TErr> : LKPPEGHBNGN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, MEENKFHCKIP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct CJEBDFGDMNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>t__builder;

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
			public JFAOBBGLJOK<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PHLGGJNOBDN<object?, MEENKFHCKIP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PHLGGJNOBDN<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6077120", Offset = "0x6076520", VA = "0x186077120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6078B50", Offset = "0x6077F50", VA = "0x186078B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DCDGJNLILFO<TActionKind, TSerializedAction, TPayload> JMALLONEBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly AGLBHKNNHAN<TRoot, TPayload, TOk, TErr> NCJKIIEEJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KDIIBNDJDGN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4A0CCE0", Offset = "0x4A0C0E0", VA = "0x184A0CCE0")]
		public JFAOBBGLJOK(DCDGJNLILFO<TActionKind, TSerializedAction, TPayload> HAOOEFFPNCA, AGLBHKNNHAN<TRoot, TPayload, TOk, TErr> IDMLCOKKEON, bool AFFIINHJOEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4A0C3B0", Offset = "0x4A0B7B0", VA = "0x184A0C3B0", Slot = "4")]
		[AsyncStateMachine(typeof(JFAOBBGLJOK<, , >.CJEBDFGDMNJ))]
		public Task<PHLGGJNOBDN<object, MEENKFHCKIP>> AIDNGKCAKPA(TDeps BDKFMFBFJII, TRoot HAIKBOLEOOP, TSerializedAction LINFLHMIJCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IOKFMBCDHKL<TActionKind, TSerializedAction, TRoot, TDeps> MLAAAKIINKP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	private KLJEJOPBIHF(IOKFMBCDHKL<TActionKind, TSerializedAction, TRoot, TDeps> MJFOKKFMONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4B357A0", Offset = "0x4B34BA0", VA = "0x184B357A0")]
	public static KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps> KMDIICJFNJF()
	{
		return default(KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x385F000", Offset = "0x385E400", VA = "0x18385F000")]
	public KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps> LJGNBFEJCAF<TPayload, TOk, TErr>(TActionKind ILAPHICMJMF, DCDGJNLILFO<TActionKind, TSerializedAction, TPayload> HAOOEFFPNCA, KMGGJGIHPKA<TRoot, TPayload, TOk, TErr> IDMLCOKKEON, bool AFFIINHJOEF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MEENKFHCKIP
	{
		return default(KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x385F000", Offset = "0x385E400", VA = "0x18385F000")]
	public KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps> OPCNIBENBOK<TPayload, TOk, TErr>(TActionKind ILAPHICMJMF, DCDGJNLILFO<TActionKind, TSerializedAction, TPayload> HAOOEFFPNCA, AGLBHKNNHAN<TRoot, TPayload, TOk, TErr> IDMLCOKKEON, bool AFFIINHJOEF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, MEENKFHCKIP
	{
		return default(KLJEJOPBIHF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4B356E0", Offset = "0x4B34AE0", VA = "0x184B356E0")]
	public FCAHJOKIPDH<TActionKind, TSerializedAction, TRoot, TDeps> KIFNJPGIHBF(TDeps BDKFMFBFJII)
	{
		return default(FCAHJOKIPDH<TActionKind, TSerializedAction, TRoot, TDeps>);
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
