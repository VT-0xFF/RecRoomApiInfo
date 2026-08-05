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
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD6660", Offset = "0xCD5A60", VA = "0x180CD6660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
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
	Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> OLPFHOPMCNM(TDeps AAKNFDLFILB, TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ);
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
	[Cpp2IlInjected.Address(RVA = "0x2CA8890", Offset = "0x2CA7C90", VA = "0x182CA8890")]
	public OCFJNMJCCFB(in TDeps AAKNFDLFILB, in TSerializedAction GLECECAAKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8760", Offset = "0x2CA7B60", VA = "0x182CA8760", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x349D280", Offset = "0x349C680", VA = "0x18349D280")]
	internal NIOGOAAALCL(TActionKind DICINNDJCFL, in TPayload GJNIFGAPEDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JNFBFKOPGGL
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1EF1210", Offset = "0x1EF0610", VA = "0x181EF1210")]
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
		public AsyncTaskMethodBuilder<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>t__builder;

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
		private TaskAwaiter<global::LFBADEDAHHF<object, KIHHJLOCPGF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2845460", Offset = "0x2844860", VA = "0x182845460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2845870", Offset = "0x2844C70", VA = "0x182845870", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EB0F0", Offset = "0x7EA4F0", VA = "0x1807EB0F0")]
	internal HLDDJNBANNB(Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> MBNJDCOKLMG, TDeps AAKNFDLFILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AA78B0", Offset = "0x3AA6CB0", VA = "0x183AA78B0")]
	[AsyncStateMachine(typeof(global::HLDDJNBANNB<, , , >.PBDIDPCAAGL))]
	public Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> OLPFHOPMCNM(TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ)
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
	[Cpp2IlInjected.Address(RVA = "0x1A96680", Offset = "0x1A95A80", VA = "0x181A96680")]
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
	[Cpp2IlInjected.Address(RVA = "0x1622680", Offset = "0x1621A80", VA = "0x181622680")]
	private IMLANBOIOKG(Dictionary<TActionKind, global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps>> MBNJDCOKLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x25003D0", Offset = "0x24FF7D0", VA = "0x1825003D0")]
	public static global::IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps> GILBACJLDCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MAGHOCDHPLC.CBBFLNCCJDP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PDPCBEECIGC<TPayload, TOk, TErr> : global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KIHHJLOCPGF
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
		[Cpp2IlInjected.Address(RVA = "0x28532C0", Offset = "0x28526C0", VA = "0x1828532C0")]
		public PDPCBEECIGC(global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::BAEECLJOALP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28524D0", Offset = "0x28518D0", VA = "0x1828524D0", Slot = "4")]
		public Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> OLPFHOPMCNM(TDeps AAKNFDLFILB, TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class AGFGMNHKLIP<TPayload, TOk, TErr> : global::HEMFLHNFHJH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KIHHJLOCPGF
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
		[Cpp2IlInjected.Address(RVA = "0x28532C0", Offset = "0x28526C0", VA = "0x1828532C0")]
		public AGFGMNHKLIP(global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::IHLHMAOIEOP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B9ACC0", Offset = "0x2B9A0C0", VA = "0x182B9ACC0", Slot = "4")]
		[AsyncStateMachine(typeof(NOGAIKOODIE))]
		public Task<global::LFBADEDAHHF<object, KIHHJLOCPGF>> OLPFHOPMCNM(TDeps AAKNFDLFILB, TRoot EAGPPNPHOBG, TSerializedAction GLECECAAKBJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly global::IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps> OPJCBHMEIFK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
	private JAOJPBCOGCP(global::IMLANBOIOKG<TActionKind, TSerializedAction, TRoot, TDeps> HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF240", Offset = "0x3BEE640", VA = "0x183BEF240")]
	public static global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> GILBACJLDCL()
	{
		return default(global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D480", Offset = "0x1A3C880", VA = "0x181A3D480")]
	public global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> PJIMIHAINPD<TPayload, TOk, TErr>(TActionKind DICINNDJCFL, global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::BAEECLJOALP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KIHHJLOCPGF
	{
		return default(global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1A3D480", Offset = "0x1A3C880", VA = "0x181A3D480")]
	public global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps> MFBOMKBJKJE<TPayload, TOk, TErr>(TActionKind DICINNDJCFL, global::KFIPCCHHFEN<TActionKind, TSerializedAction, TPayload> HDHDJBNDCIF, global::IHLHMAOIEOP<TRoot, TPayload, TOk, TErr> FOGHGKKIMKN, bool LIIDFMCAPGF = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KIHHJLOCPGF
	{
		return default(global::JAOJPBCOGCP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF2E0", Offset = "0x3BEE6E0", VA = "0x183BEF2E0")]
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
