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
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A21ED0", Offset = "0x6A208D0", VA = "0x186A21ED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate global::NIOGOAAALCL<TActionKind, TPayload> KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload>(TSerializedAction GLECECAAKBJ);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<global::LFBADEDAHHF<object, GGEPPPFEGHD>> OLPFHOPMCNM(TDeps AAKNFDLFILB, TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OCFJNMJCCFB<TActionKind, TSerializedAction, TRoot, TDeps> : GGEPPPFEGHD where TDeps : MAGHOCDHPLC.CBBFLNCCJDP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps GOBIMGKDLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction EDDIMPCFHGP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D360", Offset = "0x2D1BD60", VA = "0x182D1D360")]
	public OCFJNMJCCFB(in TDeps AAKNFDLFILB, in TSerializedAction GLECECAAKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D230", Offset = "0x2D1BC30", VA = "0x182D1D230", Slot = "5")]
	public override string GMMLNCMCCAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NIOGOAAALCL<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind NKKADKCBGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload EEFKAIKPIBN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35A5790", Offset = "0x35A4190", VA = "0x1835A5790")]
	internal NIOGOAAALCL(TActionKind DICINNDJCFL, in TPayload GJNIFGAPEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JNFBFKOPGGL
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x199AF90", Offset = "0x1999990", VA = "0x18199AF90")]
	public static global::NIOGOAAALCL<TActionKind, TPayload> GILBACJLDCL<TActionKind, TPayload>(in TActionKind DICINNDJCFL, in TPayload GJNIFGAPEDN)
	{
		return default(global::NIOGOAAALCL<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<global::LFBADEDAHHF<TOk, TErr>> IHLHMAOIEOP<TRoot, TPayload, TOk, TErr>(TRoot EAGPPNPHOBG, TPayload GJNIFGAPEDN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate global::LFBADEDAHHF<TOk, TErr> BAEECLJOALP<TRoot, TPayload, TOk, TErr>(TRoot EAGPPNPHOBG, in TPayload GJNIFGAPEDN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HLDDJNBANNB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MAGHOCDHPLC.CBBFLNCCJDP<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PBDIDPCAAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<object, GGEPPPFEGHD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public global::HLDDJNBANNB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<global::LFBADEDAHHF<object, GGEPPPFEGHD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x298E220", Offset = "0x298CC20", VA = "0x18298E220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x298E630", Offset = "0x298D030", VA = "0x18298E630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> LDFIMLMHDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps GOBIMGKDLNH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C16B0", Offset = "0x7C00B0", VA = "0x1807C16B0")]
	internal HLDDJNBANNB(Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> MBNJDCOKLMG, TDeps AAKNFDLFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C620", Offset = "0x3E7B020", VA = "0x183E7C620")]
	[AsyncStateMachine(typeof(global::HLDDJNBANNB<, , , >.PBDIDPCAAGL))]
	public Task<global::LFBADEDAHHF<object, GGEPPPFEGHD>> OLPFHOPMCNM(TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MAGHOCDHPLC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CBBFLNCCJDP<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind BJOAPFDDPBM(TSerializedAction INHKNJBCCPD);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AMDPKPCALMH(TRoot EAGPPNPHOBG, TSerializedAction DAAMKALKLMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F87840", Offset = "0x1F86240", VA = "0x181F87840")]
	internal static global::HLDDJNBANNB<TActionKind, TSerializedAction, TRoot, TDeps> GILBACJLDCL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> MBNJDCOKLMG, TDeps AAKNFDLFILB) where TDeps : CBBFLNCCJDP<TActionKind, TSerializedAction, TRoot>
	{
		return default(global::HLDDJNBANNB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> IMCEHKDCFDD;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x225EE20", Offset = "0x225D820", VA = "0x18225EE20")]
	private IMLANBOIOKG(Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> MBNJDCOKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2878CE0", Offset = "0x28776E0", VA = "0x182878CE0")]
	public static global::IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps> GILBACJLDCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MAGHOCDHPLC.CBBFLNCCJDP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PDPCBEECIGC<TPayload, TOk, TErr> : global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GGEPPPFEGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> EBPGIJOKMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly global::BAEECLJOALP<TRoot, TPayload, TOk, TErr> DIIOCOHFMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool GPJLLNFCLPB;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x299B420", Offset = "0x2999E20", VA = "0x18299B420")]
		public PDPCBEECIGC(global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::BAEECLJOALP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2997C10", Offset = "0x2996610", VA = "0x182997C10", Slot = "4")]
		public Task<global::LFBADEDAHHF<object, GGEPPPFEGHD>> OLPFHOPMCNM(TDeps AAKNFDLFILB, TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class AGFGMNHKLIP<TPayload, TOk, TErr> : global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GGEPPPFEGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> EBPGIJOKMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly global::IHLHMAOIEOP<TRoot, TPayload, TOk, TErr> DIIOCOHFMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool GPJLLNFCLPB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x299B420", Offset = "0x2999E20", VA = "0x18299B420")]
		public AGFGMNHKLIP(global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::IHLHMAOIEOP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2AA98F0", Offset = "0x2AA82F0", VA = "0x182AA98F0", Slot = "4")]
		[AsyncStateMachine(typeof(NOGAIKOODIE))]
		public Task<global::LFBADEDAHHF<object, GGEPPPFEGHD>> OLPFHOPMCNM(TDeps AAKNFDLFILB, TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps> OPJCBHMEIFK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8D19D0", Offset = "0x8D03D0", VA = "0x1808D19D0")]
	private JAOJPBCOGCP(global::IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps> HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3917F10", Offset = "0x3916910", VA = "0x183917F10")]
	public static global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> GILBACJLDCL()
	{
		return default(global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2492B70", Offset = "0x2491570", VA = "0x182492B70")]
	public global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> PJIMIHAINPD<TPayload, TOk, TErr>(TActionKind DICINNDJCFL, global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::BAEECLJOALP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GGEPPPFEGHD
	{
		return default(global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2492B70", Offset = "0x2491570", VA = "0x182492B70")]
	public global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> MFBOMKBJKJE<TPayload, TOk, TErr>(TActionKind DICINNDJCFL, global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::IHLHMAOIEOP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GGEPPPFEGHD
	{
		return default(global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3917FB0", Offset = "0x39169B0", VA = "0x183917FB0")]
	public global::HLDDJNBANNB<TActionKind, TSerializedAction, TRoot, TDeps> GLLHIGHMNHA(TDeps AAKNFDLFILB)
	{
		return default(global::HLDDJNBANNB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
