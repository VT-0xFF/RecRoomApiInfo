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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x266C380", Offset = "0x266B780", VA = "0x18266C380")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate IHLPCODOJJK<TActionKind, TPayload> LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload>(TSerializedAction AFPMOKDLIGA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface HNGGKPPBPCM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AEAAIINGJNL<object, GJDNFLPCNNP>> KMKOBGLALNC(TDeps EIHGNKDHDGF, TRoot FDNIDHBNFHE, TSerializedAction AFPMOKDLIGA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KFIPJICNKGM<TActionKind, TSerializedAction, TRoot, TDeps> : ABNNHKJOOMD where TDeps : JCAMIECDDEF.FOIFKKFBMDJ<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps EGDADDGFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction CJIHCGPHKCG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4CD04B0", Offset = "0x4CCF8B0", VA = "0x184CD04B0")]
	public KFIPJICNKGM([In] TDeps EIHGNKDHDGF, [In] TSerializedAction AFPMOKDLIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CD02F0", Offset = "0x4CCF6F0", VA = "0x184CD02F0", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct IHLPCODOJJK<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DMDIJEKFHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload GCMIPAHJIAM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49D0B40", Offset = "0x49CFF40", VA = "0x1849D0B40")]
	internal IHLPCODOJJK(TActionKind DJHHJMAFLHO, [In] TPayload KGCLHKOHKLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KOPCMKMGOLE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x36B8020", Offset = "0x36B7420", VA = "0x1836B8020")]
	public static IHLPCODOJJK<TActionKind, TPayload> AFLKMMODJAC<TActionKind, TPayload>([In] TActionKind DJHHJMAFLHO, [In] TPayload KGCLHKOHKLJ)
	{
		return default(IHLPCODOJJK<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<AEAAIINGJNL<TOk, TErr>> BBNBGKMDCPC<TRoot, TPayload, TOk, TErr>(TRoot FDNIDHBNFHE, TPayload KGCLHKOHKLJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate AEAAIINGJNL<TOk, TErr> INGMHDLLAAP<TRoot, TPayload, TOk, TErr>(TRoot FDNIDHBNFHE, [In] TPayload KGCLHKOHKLJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LOKNPOBJGCO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JCAMIECDDEF.FOIFKKFBMDJ<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PLPPKGIKLCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LOKNPOBJGCO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x52F2B80", Offset = "0x52F1F80", VA = "0x1852F2B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52F3010", Offset = "0x52F2410", VA = "0x1852F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, HNGGKPPBPCM<TSerializedAction, TRoot, TDeps>> FAPIGIFHLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps EGDADDGFBOH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
	internal LOKNPOBJGCO(Dictionary<TActionKind, HNGGKPPBPCM<TSerializedAction, TRoot, TDeps>> HLJFDFNDKKD, TDeps EIHGNKDHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D98180", Offset = "0x4D97580", VA = "0x184D98180")]
	[AsyncStateMachine(typeof(LOKNPOBJGCO<, , , >.PLPPKGIKLCM))]
	public Task<AEAAIINGJNL<object, GJDNFLPCNNP>> KMKOBGLALNC(TRoot FDNIDHBNFHE, TSerializedAction AFPMOKDLIGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JCAMIECDDEF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FOIFKKFBMDJ<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MCBNPKKPKNJ(TSerializedAction CAMFIHKHJNG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DOEAIPJBEHB(TRoot FDNIDHBNFHE, TSerializedAction AKLHLNJOCEK);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EENKEDKPKDG(TRoot FDNIDHBNFHE, TSerializedAction AKLHLNJOCEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35BFA80", Offset = "0x35BEE80", VA = "0x1835BFA80")]
	internal static LOKNPOBJGCO<TActionKind, TSerializedAction, TRoot, TDeps> AFLKMMODJAC<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, HNGGKPPBPCM<TSerializedAction, TRoot, TDeps>> HLJFDFNDKKD, TDeps EIHGNKDHDGF) where TDeps : FOIFKKFBMDJ<TActionKind, TSerializedAction, TRoot>
	{
		return default(LOKNPOBJGCO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HMIIJJHBENC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, HNGGKPPBPCM<TSerializedAction, TRoot, TDeps>> HJBCNPHNCID;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	private HMIIJJHBENC(Dictionary<TActionKind, HNGGKPPBPCM<TSerializedAction, TRoot, TDeps>> HLJFDFNDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x489C6B0", Offset = "0x489BAB0", VA = "0x18489C6B0")]
	public static HMIIJJHBENC<TActionKind, TSerializedAction, TRoot, TDeps> AFLKMMODJAC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JCAMIECDDEF.FOIFKKFBMDJ<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PAELOLDLBML<TPayload, TOk, TErr> : HNGGKPPBPCM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GJDNFLPCNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload> KJPGHEJHMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly INGMHDLLAAP<TRoot, TPayload, TOk, TErr> DLGKKMKCDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool FFJKHNMAFBJ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1859E50", Offset = "0x1859250", VA = "0x181859E50")]
		public PAELOLDLBML(LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload> MKFCPBKBIJH, INGMHDLLAAP<TRoot, TPayload, TOk, TErr> BJHIGHPCCDF, bool EKHNFKODMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x52972C0", Offset = "0x52966C0", VA = "0x1852972C0", Slot = "4")]
		public Task<AEAAIINGJNL<object, GJDNFLPCNNP>> KMKOBGLALNC(TDeps EIHGNKDHDGF, TRoot FDNIDHBNFHE, TSerializedAction AFPMOKDLIGA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JNOMKPIAKII<TPayload, TOk, TErr> : HNGGKPPBPCM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, GJDNFLPCNNP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BAJNFMJNCBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>t__builder;

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
			public JNOMKPIAKII<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private AEAAIINGJNL<object?, GJDNFLPCNNP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<AEAAIINGJNL<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5ADC8A0", Offset = "0x5ADBCA0", VA = "0x185ADC8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5ADEC30", Offset = "0x5ADE030", VA = "0x185ADEC30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload> KJPGHEJHMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly BBNBGKMDCPC<TRoot, TPayload, TOk, TErr> DLGKKMKCDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool FFJKHNMAFBJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1859E50", Offset = "0x1859250", VA = "0x181859E50")]
		public JNOMKPIAKII(LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload> MKFCPBKBIJH, BBNBGKMDCPC<TRoot, TPayload, TOk, TErr> BJHIGHPCCDF, bool EKHNFKODMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4C176B0", Offset = "0x4C16AB0", VA = "0x184C176B0", Slot = "4")]
		[AsyncStateMachine(typeof(JNOMKPIAKII<, , >.BAJNFMJNCBM))]
		public Task<AEAAIINGJNL<object, GJDNFLPCNNP>> KMKOBGLALNC(TDeps EIHGNKDHDGF, TRoot FDNIDHBNFHE, TSerializedAction AFPMOKDLIGA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HMIIJJHBENC<TActionKind, TSerializedAction, TRoot, TDeps> PFLAJOJDOKC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	private HCJMMGBLEBD(HMIIJJHBENC<TActionKind, TSerializedAction, TRoot, TDeps> AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x48778E0", Offset = "0x4876CE0", VA = "0x1848778E0")]
	public static HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps> AFLKMMODJAC()
	{
		return default(HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BB60", Offset = "0x3A5AF60", VA = "0x183A5BB60")]
	public HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps> AIHFNLJBFJN<TPayload, TOk, TErr>(TActionKind DJHHJMAFLHO, LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload> MKFCPBKBIJH, INGMHDLLAAP<TRoot, TPayload, TOk, TErr> BJHIGHPCCDF, bool EKHNFKODMFE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GJDNFLPCNNP
	{
		return default(HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A5BB60", Offset = "0x3A5AF60", VA = "0x183A5BB60")]
	public HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps> CLHHDCEDFAA<TPayload, TOk, TErr>(TActionKind DJHHJMAFLHO, LAJGDHNGKGP<TActionKind, TSerializedAction, TPayload> MKFCPBKBIJH, BBNBGKMDCPC<TRoot, TPayload, TOk, TErr> BJHIGHPCCDF, bool EKHNFKODMFE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, GJDNFLPCNNP
	{
		return default(HCJMMGBLEBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4877980", Offset = "0x4876D80", VA = "0x184877980")]
	public LOKNPOBJGCO<TActionKind, TSerializedAction, TRoot, TDeps> HBNMGDOLNBI(TDeps EIHGNKDHDGF)
	{
		return default(LOKNPOBJGCO<TActionKind, TSerializedAction, TRoot, TDeps>);
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
