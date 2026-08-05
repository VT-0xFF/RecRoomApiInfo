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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x277F520", Offset = "0x277DD20", VA = "0x18277F520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate ADAEHAOBIIA<TActionKind, TPayload> MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction BEIFOCNMEIA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface IDHLPBBFNIC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> GPFOEJOAFKH(TDeps ILEBEOADOPL, TRoot PNDCHGJLEGG, TSerializedAction BEIFOCNMEIA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class AGGCMBIHLOF<TActionKind, TSerializedAction, TRoot, TDeps> : FHIEBGLCLNJ where TDeps : APKEIIBCNIN.OAGAKJIEFFI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DDCMACNPPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KKGMHPGMACC;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x49E8C90", Offset = "0x49E7490", VA = "0x1849E8C90")]
	public AGGCMBIHLOF([In] TDeps ILEBEOADOPL, [In] TSerializedAction BEIFOCNMEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49E8B70", Offset = "0x49E7370", VA = "0x1849E8B70", Slot = "7")]
	public override string KCDPOCMBOHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ADAEHAOBIIA<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CAPIEEHCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DNPFBLDOGJH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x495B460", Offset = "0x4959C60", VA = "0x18495B460")]
	internal ADAEHAOBIIA(TActionKind GIONMBAGJCK, [In] TPayload JDGDKOENECG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPCHJGEIBEP
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3936CA0", Offset = "0x39354A0", VA = "0x183936CA0")]
	public static ADAEHAOBIIA<TActionKind, TPayload> CJOJELENPLJ<TActionKind, TPayload>([In] TActionKind GIONMBAGJCK, [In] TPayload JDGDKOENECG)
	{
		return default(ADAEHAOBIIA<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<HCGBMJDNFKJ<TOk, TErr>> NCCLAPBGOJG<TRoot, TPayload, TOk, TErr>(TRoot PNDCHGJLEGG, TPayload JDGDKOENECG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate HCGBMJDNFKJ<TOk, TErr> FOOAAKNAJFH<TRoot, TPayload, TOk, TErr>(TRoot PNDCHGJLEGG, [In] TPayload JDGDKOENECG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FMMNACDHFCL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : APKEIIBCNIN.OAGAKJIEFFI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MJBNIIGJFAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FMMNACDHFCL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x52136F0", Offset = "0x5211EF0", VA = "0x1852136F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5213B70", Offset = "0x5212370", VA = "0x185213B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, IDHLPBBFNIC<TSerializedAction, TRoot, TDeps>> GMAPBMKGOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DDCMACNPPHA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	internal FMMNACDHFCL(Dictionary<TActionKind, IDHLPBBFNIC<TSerializedAction, TRoot, TDeps>> PDFOIBNBMDN, TDeps ILEBEOADOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48E2150", Offset = "0x48E0950", VA = "0x1848E2150")]
	[AsyncStateMachine(typeof(FMMNACDHFCL<, , , >.MJBNIIGJFAH))]
	public Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> GPFOEJOAFKH(TRoot PNDCHGJLEGG, TSerializedAction BEIFOCNMEIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class APKEIIBCNIN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OAGAKJIEFFI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind IHNOCKBGIME(TSerializedAction NFOGFJOGLPE);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AOHFDNDMPLM(TRoot PNDCHGJLEGG, TSerializedAction GFMBHCHPLDH);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CLHOBFLKMMJ(TRoot PNDCHGJLEGG, TSerializedAction GFMBHCHPLDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35D0060", Offset = "0x35CE860", VA = "0x1835D0060")]
	internal static FMMNACDHFCL<TActionKind, TSerializedAction, TRoot, TDeps> CJOJELENPLJ<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, IDHLPBBFNIC<TSerializedAction, TRoot, TDeps>> PDFOIBNBMDN, TDeps ILEBEOADOPL) where TDeps : OAGAKJIEFFI<TActionKind, TSerializedAction, TRoot>
	{
		return default(FMMNACDHFCL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DDABANHPLDB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, IDHLPBBFNIC<TSerializedAction, TRoot, TDeps>> NJEKODOBFED;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	private DDABANHPLDB(Dictionary<TActionKind, IDHLPBBFNIC<TSerializedAction, TRoot, TDeps>> PDFOIBNBMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68BB7B0", Offset = "0x68B9FB0", VA = "0x1868BB7B0")]
	public static DDABANHPLDB<TActionKind, TSerializedAction, TRoot, TDeps> CJOJELENPLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, APKEIIBCNIN.OAGAKJIEFFI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HOKENFGNPBD<TPayload, TOk, TErr> : IDHLPBBFNIC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CPMHOEMAGED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload> CONILBOMMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FOOAAKNAJFH<TRoot, TPayload, TOk, TErr> NNFNMABLOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool EPBLBGEOCON;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1954220", Offset = "0x1952A20", VA = "0x181954220")]
		public HOKENFGNPBD(MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload> DMGICBKNMNB, FOOAAKNAJFH<TRoot, TPayload, TOk, TErr> GLAEKHGABFB, bool GABFBPNBPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4A6EAB0", Offset = "0x4A6D2B0", VA = "0x184A6EAB0", Slot = "4")]
		public Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> GPFOEJOAFKH(TDeps ILEBEOADOPL, TRoot PNDCHGJLEGG, TSerializedAction BEIFOCNMEIA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ECBMIKLILFN<TPayload, TOk, TErr> : IDHLPBBFNIC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CPMHOEMAGED
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NKHLOHBMGPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>t__builder;

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
			public ECBMIKLILFN<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private HCGBMJDNFKJ<object?, CPMHOEMAGED> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HCGBMJDNFKJ<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x53503E0", Offset = "0x534EBE0", VA = "0x1853503E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x53520F0", Offset = "0x53508F0", VA = "0x1853520F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload> CONILBOMMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly NCCLAPBGOJG<TRoot, TPayload, TOk, TErr> NNFNMABLOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool EPBLBGEOCON;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1954220", Offset = "0x1952A20", VA = "0x181954220")]
		public ECBMIKLILFN(MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload> DMGICBKNMNB, NCCLAPBGOJG<TRoot, TPayload, TOk, TErr> GLAEKHGABFB, bool GABFBPNBPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x43E2260", Offset = "0x43E0A60", VA = "0x1843E2260", Slot = "4")]
		[AsyncStateMachine(typeof(ECBMIKLILFN<, , >.NKHLOHBMGPI))]
		public Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> GPFOEJOAFKH(TDeps ILEBEOADOPL, TRoot PNDCHGJLEGG, TSerializedAction BEIFOCNMEIA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DDABANHPLDB<TActionKind, TSerializedAction, TRoot, TDeps> CJGIMNHODLA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	private LAEAOCNGGLP(DDABANHPLDB<TActionKind, TSerializedAction, TRoot, TDeps> NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC3420", Offset = "0x4FC1C20", VA = "0x184FC3420")]
	public static LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps> CJOJELENPLJ()
	{
		return default(LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3992A90", Offset = "0x3991290", VA = "0x183992A90")]
	public LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps> GGBOOEKDKEK<TPayload, TOk, TErr>(TActionKind GIONMBAGJCK, MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload> DMGICBKNMNB, FOOAAKNAJFH<TRoot, TPayload, TOk, TErr> GLAEKHGABFB, bool GABFBPNBPCK = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CPMHOEMAGED
	{
		return default(LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3992A90", Offset = "0x3991290", VA = "0x183992A90")]
	public LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps> ADDBICLIKFE<TPayload, TOk, TErr>(TActionKind GIONMBAGJCK, MMIKDBKLCFJ<TActionKind, TSerializedAction, TPayload> DMGICBKNMNB, NCCLAPBGOJG<TRoot, TPayload, TOk, TErr> GLAEKHGABFB, bool GABFBPNBPCK = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CPMHOEMAGED
	{
		return default(LAEAOCNGGLP<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FC3360", Offset = "0x4FC1B60", VA = "0x184FC3360")]
	public FMMNACDHFCL<TActionKind, TSerializedAction, TRoot, TDeps> AHCBKJCMCHB(TDeps ILEBEOADOPL)
	{
		return default(FMMNACDHFCL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
