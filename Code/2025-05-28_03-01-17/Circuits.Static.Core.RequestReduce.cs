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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2845CC0", Offset = "0x2844AC0", VA = "0x182845CC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate HHJJMLJIOEH<TActionKind, TPayload> IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload>(TSerializedAction CLHIECPCHOL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> MOAAHFNEEOI(TDeps JCFBNAHPHAO, TRoot IPCOMOHMNHK, TSerializedAction CLHIECPCHOL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PCCFJNEOJMK<TActionKind, TSerializedAction, TRoot, TDeps> : MCNPHLHCLED where TDeps : GGBCFBLMLAI.HLFJKDAONLJ<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JLPOGPHFPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction OOFOCLLLPEK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x576E0B0", Offset = "0x576CEB0", VA = "0x18576E0B0")]
	public PCCFJNEOJMK([In] TDeps JCFBNAHPHAO, [In] TSerializedAction CLHIECPCHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x576DE90", Offset = "0x576CC90", VA = "0x18576DE90", Slot = "7")]
	public override string EEHOEKHGKPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HHJJMLJIOEH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind IFBOFNJDKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload FCGPNMGBCDJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C230", Offset = "0x4C2B030", VA = "0x184C2C230")]
	internal HHJJMLJIOEH(TActionKind IPELDGJNKCL, [In] TPayload DKEBGKJJPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FINMBDGMKFC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x38E8340", Offset = "0x38E7140", VA = "0x1838E8340")]
	public static HHJJMLJIOEH<TActionKind, TPayload> NBEICDCLFEE<TActionKind, TPayload>([In] TActionKind IPELDGJNKCL, [In] TPayload DKEBGKJJPPO)
	{
		return default(HHJJMLJIOEH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<JKEBLLKKBOM<TOk, TErr>> CENKALDPCAM<TRoot, TPayload, TOk, TErr>(TRoot IPCOMOHMNHK, TPayload DKEBGKJJPPO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate JKEBLLKKBOM<TOk, TErr> JPCHDFEFHHM<TRoot, TPayload, TOk, TErr>(TRoot IPCOMOHMNHK, [In] TPayload DKEBGKJJPPO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct LIFNMMADNGB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GGBCFBLMLAI.HLFJKDAONLJ<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HPMLLCGDGKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LIFNMMADNGB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4C5A9C0", Offset = "0x4C597C0", VA = "0x184C5A9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4C5AE50", Offset = "0x4C59C50", VA = "0x184C5AE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps>> ONHNAELOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JLPOGPHFPCB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	internal LIFNMMADNGB(Dictionary<TActionKind, OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps>> HCLILBCGAAK, TDeps JCFBNAHPHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51952F0", Offset = "0x51940F0", VA = "0x1851952F0")]
	[AsyncStateMachine(typeof(LIFNMMADNGB<, , , >.HPMLLCGDGKD))]
	public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> MOAAHFNEEOI(TRoot IPCOMOHMNHK, TSerializedAction CLHIECPCHOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GGBCFBLMLAI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HLFJKDAONLJ<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EPJEAABIPHE(TSerializedAction FPFHIDBMBMI);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AFCGINBNKJC(TRoot IPCOMOHMNHK, TSerializedAction CFDGGKIIHOI);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BBNJCFLNKHE(TRoot IPCOMOHMNHK, TSerializedAction CFDGGKIIHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36A6200", Offset = "0x36A5000", VA = "0x1836A6200")]
	internal static LIFNMMADNGB<TActionKind, TSerializedAction, TRoot, TDeps> NBEICDCLFEE<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps>> HCLILBCGAAK, TDeps JCFBNAHPHAO) where TDeps : HLFJKDAONLJ<TActionKind, TSerializedAction, TRoot>
	{
		return default(LIFNMMADNGB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class JDALMPLDFAK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps>> INMBFFCIHMA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	private JDALMPLDFAK(Dictionary<TActionKind, OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps>> HCLILBCGAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F6F500", Offset = "0x4F6E300", VA = "0x184F6F500")]
	public static JDALMPLDFAK<TActionKind, TSerializedAction, TRoot, TDeps> NBEICDCLFEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GGBCFBLMLAI.HLFJKDAONLJ<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AGKCJKHLCGH<TPayload, TOk, TErr> : OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CHEIGOJMDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload> CHFBPCOEJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JPCHDFEFHHM<TRoot, TPayload, TOk, TErr> ELDGDEPEAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DOAFJCPBPAN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1A07990", Offset = "0x1A06790", VA = "0x181A07990")]
		public AGKCJKHLCGH(IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload> IEGKPEFFNAB, JPCHDFEFHHM<TRoot, TPayload, TOk, TErr> DIMEGLNLPJN, bool HAMDCIMKHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4C90B50", Offset = "0x4C8F950", VA = "0x184C90B50", Slot = "4")]
		public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> MOAAHFNEEOI(TDeps JCFBNAHPHAO, TRoot IPCOMOHMNHK, TSerializedAction CLHIECPCHOL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NIBIMJIFGEJ<TPayload, TOk, TErr> : OOHHIKPNMIJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CHEIGOJMDOJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct FDJIPIGOEDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

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
			public NIBIMJIFGEJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private JKEBLLKKBOM<object?, CHEIGOJMDOJ> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<JKEBLLKKBOM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4A4B2E0", Offset = "0x4A4A0E0", VA = "0x184A4B2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4A4DC10", Offset = "0x4A4CA10", VA = "0x184A4DC10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload> CHFBPCOEJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CENKALDPCAM<TRoot, TPayload, TOk, TErr> ELDGDEPEAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DOAFJCPBPAN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A07990", Offset = "0x1A06790", VA = "0x181A07990")]
		public NIBIMJIFGEJ(IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload> IEGKPEFFNAB, CENKALDPCAM<TRoot, TPayload, TOk, TErr> DIMEGLNLPJN, bool HAMDCIMKHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x54BF800", Offset = "0x54BE600", VA = "0x1854BF800", Slot = "4")]
		[AsyncStateMachine(typeof(NIBIMJIFGEJ<, , >.FDJIPIGOEDA))]
		public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> MOAAHFNEEOI(TDeps JCFBNAHPHAO, TRoot IPCOMOHMNHK, TSerializedAction CLHIECPCHOL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JDALMPLDFAK<TActionKind, TSerializedAction, TRoot, TDeps> CJNIBAPGIPF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	private KGGHGOBAEGL(JDALMPLDFAK<TActionKind, TSerializedAction, TRoot, TDeps> FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50A62F0", Offset = "0x50A50F0", VA = "0x1850A62F0")]
	public static KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps> NBEICDCLFEE()
	{
		return default(KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6930", Offset = "0x3BB5730", VA = "0x183BB6930")]
	public KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps> LMJFHLLBLMO<TPayload, TOk, TErr>(TActionKind IPELDGJNKCL, IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload> IEGKPEFFNAB, JPCHDFEFHHM<TRoot, TPayload, TOk, TErr> DIMEGLNLPJN, bool HAMDCIMKHFM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CHEIGOJMDOJ
	{
		return default(KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6930", Offset = "0x3BB5730", VA = "0x183BB6930")]
	public KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps> KICLDBMKPAG<TPayload, TOk, TErr>(TActionKind IPELDGJNKCL, IIJFPMGIMCI<TActionKind, TSerializedAction, TPayload> IEGKPEFFNAB, CENKALDPCAM<TRoot, TPayload, TOk, TErr> DIMEGLNLPJN, bool HAMDCIMKHFM = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CHEIGOJMDOJ
	{
		return default(KGGHGOBAEGL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50A6230", Offset = "0x50A5030", VA = "0x1850A6230")]
	public LIFNMMADNGB<TActionKind, TSerializedAction, TRoot, TDeps> JPGAHJPOIJM(TDeps JCFBNAHPHAO)
	{
		return default(LIFNMMADNGB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
