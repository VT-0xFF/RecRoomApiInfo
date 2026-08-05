using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2550D70", Offset = "0x254F970", VA = "0x182550D70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct FBMDPCLLCIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> GJFHHAHPEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int ADCBECJLAEI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
	public FBMDPCLLCIL(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> CGMLDHEADFF, int KKHFKGIPICC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FKFPHCKPKHB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class OBLACGIDLEK : PPKJLHGEEMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct LFEOEAGEENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly HMHIJEGPIOM<byte> HMDLABGJBCE;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24E60B0", Offset = "0x24E4CB0", VA = "0x1824E60B0")]
		public LFEOEAGEENI(HMHIJEGPIOM<byte> FOLLKKLPOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x25508B0", Offset = "0x254F4B0", VA = "0x1825508B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BLLKNLFJIGM : PPKJLHGEEMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct DEBKBLCADAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> OIEGIGNDNLL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public DEBKBLCADAJ(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> GCEIMBFAIJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CIKCGHODHPF
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class PMPCAHLGJLF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PPKJLHGEEMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HHBPANAKADO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly CIKCGHODHPF MKJNFEKLNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly ENBGACDEBPI<PPKJLHGEEMB> JCLJIAHMKEO;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		public HHBPANAKADO(CIKCGHODHPF ACBKGIPMJCO, ENBGACDEBPI<PPKJLHGEEMB> GHGGHFFONEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IKKKJJIGGIF : PPKJLHGEEMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct JINMPJKHBLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ILNPJDNJJFD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public JINMPJKHBLC(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class PAOHGJKHGFE : PPKJLHGEEMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JMOABDNPMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GJKMACPKIMD BBDFGMHPIPC;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public JMOABDNPMGK(GJKMACPKIMD GIKNLPJAAEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2550410", Offset = "0x254F010", VA = "0x182550410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal ONEIGDDHEHF<PMPCAHLGJLF, HHBPANAKADO> DJCDFOOFODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal ONEIGDDHEHF<OBLACGIDLEK, LFEOEAGEENI> MBNCJIEJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ONEIGDDHEHF<BLLKNLFJIGM, DEBKBLCADAJ> JMDLOJOHAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal ONEIGDDHEHF<IKKKJJIGGIF, JINMPJKHBLC> GDGJELFEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ONEIGDDHEHF<PAOHGJKHGFE, JMOABDNPMGK> DBJOMHKKHFB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x254F510", Offset = "0x254E110", VA = "0x18254F510")]
	private FKFPHCKPKHB([In] ONEIGDDHEHF<PMPCAHLGJLF, HHBPANAKADO> BBBJPGEHKDE, [In] ONEIGDDHEHF<OBLACGIDLEK, LFEOEAGEENI> CNNCGFILMJK, [In] ONEIGDDHEHF<BLLKNLFJIGM, DEBKBLCADAJ> GHLGFGCPILO, [In] ONEIGDDHEHF<IKKKJJIGGIF, JINMPJKHBLC> CONJIGGJFDE, [In] ONEIGDDHEHF<PAOHGJKHGFE, JMOABDNPMGK> FIEFOLGFGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x254F3D0", Offset = "0x254DFD0", VA = "0x18254F3D0")]
	public static FKFPHCKPKHB JPHABLICNHB()
	{
		return default(FKFPHCKPKHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IGDOALAKIFI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x254F960", Offset = "0x254E560", VA = "0x18254F960")]
	public static void LOIALHEPEBI(this FKFPHCKPKHB DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum AGGGECAAFLL
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct GFDAJBPCGNG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class OJNKOBAOBKE : ILJLNPECGBP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct GPHIEIBLOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> GBABACJJJBA;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public GPHIEIBLOHD(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> EDEFPEDKGNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum JFGLNDNPNDF
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class BDNDLNLFDMO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ILJLNPECGBP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct JIBNHAMACBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly JFGLNDNPNDF MKJNFEKLNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly ENBGACDEBPI<ILJLNPECGBP> JCLJIAHMKEO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		public JIBNHAMACBL(JFGLNDNPNDF ACBKGIPMJCO, ENBGACDEBPI<ILJLNPECGBP> GHGGHFFONEM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ONEIGDDHEHF<BDNDLNLFDMO, JIBNHAMACBL> DJCDFOOFODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ONEIGDDHEHF<OJNKOBAOBKE, GPHIEIBLOHD> ENKMJKMCNLI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x254B460", Offset = "0x254A060", VA = "0x18254B460")]
	private GFDAJBPCGNG([In] ONEIGDDHEHF<BDNDLNLFDMO, JIBNHAMACBL> BBBJPGEHKDE, [In] ONEIGDDHEHF<OJNKOBAOBKE, GPHIEIBLOHD> MOMONACEBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x254F600", Offset = "0x254E200", VA = "0x18254F600")]
	public static GFDAJBPCGNG JPHABLICNHB()
	{
		return default(GFDAJBPCGNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KBHNCMCOKLM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2550430", Offset = "0x254F030", VA = "0x182550430")]
	public static void LOIALHEPEBI(this GFDAJBPCGNG DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JGLCEGBOKBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public OACMJNHPIGJ<int> JNIBALFBJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public OACMJNHPIGJ<int> CNKKEHCCGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int HOMBLDAHIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int IJOONCAMJKO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25501C0", Offset = "0x254EDC0", VA = "0x1825501C0")]
	private JGLCEGBOKBA([In] OACMJNHPIGJ<int> OCBKDOGFGFG, [In] OACMJNHPIGJ<int> LHJMAMDNGNJ, int MMIABBIFDOO, int GAKPJPBFNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2550120", Offset = "0x254ED20", VA = "0x182550120")]
	public static JGLCEGBOKBA JPHABLICNHB()
	{
		return default(JGLCEGBOKBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OFJJAJFKILP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2550DF0", Offset = "0x254F9F0", VA = "0x182550DF0")]
	public static void LOIALHEPEBI(this JGLCEGBOKBA DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CNABDBPFNLB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum HAHOIIHOPMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class BHNHNFGAFAG : BPAGJCBBFAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct ALDFIIFMMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly ENBGACDEBPI<CIDMBGEGHGN> DJGKHFCPBIG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public ALDFIIFMMJH(ENBGACDEBPI<CIDMBGEGHGN> JJBJIOFJKKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class NONCGDBHDIG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class BPAGJCBBFAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct HOBADAIODKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly HAHOIIHOPMK MKJNFEKLNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly ENBGACDEBPI<BPAGJCBBFAN> JCLJIAHMKEO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		private HOBADAIODKN(HAHOIIHOPMK ACBKGIPMJCO, ENBGACDEBPI<BPAGJCBBFAN> GHGGHFFONEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x254F930", Offset = "0x254E530", VA = "0x18254F930")]
		public static HOBADAIODKN JPHABLICNHB(HAHOIIHOPMK ACBKGIPMJCO, ENBGACDEBPI<BPAGJCBBFAN> GHGGHFFONEM)
		{
			return default(HOBADAIODKN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FOJMBLHHBDF : BPAGJCBBFAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct JAANFDGKHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly ENBGACDEBPI<CIDMBGEGHGN> DJGKHFCPBIG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public JAANFDGKHDH(ENBGACDEBPI<CIDMBGEGHGN> JJBJIOFJKKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CIDMBGEGHGN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct BOPHJKCPALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OACMJNHPIGJ<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> FKJECPNOBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OACMJNHPIGJ<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> KMIHHDKAKBH;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x254B460", Offset = "0x254A060", VA = "0x18254B460")]
		private BOPHJKCPALL([In] OACMJNHPIGJ<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> IGHJGAIMPFD, [In] OACMJNHPIGJ<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> LLMMBKNODAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x254B3E0", Offset = "0x2549FE0", VA = "0x18254B3E0")]
		public static BOPHJKCPALL JPHABLICNHB()
		{
			return default(BOPHJKCPALL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal ONEIGDDHEHF<NONCGDBHDIG, HOBADAIODKN> DJCDFOOFODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal ONEIGDDHEHF<FOJMBLHHBDF, JAANFDGKHDH> LCGGLDEMKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ONEIGDDHEHF<BHNHNFGAFAG, ALDFIIFMMJH> ILBGBKDCBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OACMJNHPIGJ<(ENBGACDEBPI<NONCGDBHDIG> CallId, ENBGACDEBPI<CIDMBGEGHGN> IOId)> EFPGGFHNCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal ONEIGDDHEHF<CIDMBGEGHGN, BOPHJKCPALL> GHOIKOLMOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal ALPCOFPOCAO<CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> MFOJMJOMKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal ALPCOFPOCAO<CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> JELBNNCPGHD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x254B6F0", Offset = "0x254A2F0", VA = "0x18254B6F0")]
	private CNABDBPFNLB([In] ONEIGDDHEHF<NONCGDBHDIG, HOBADAIODKN> BBBJPGEHKDE, [In] ONEIGDDHEHF<FOJMBLHHBDF, JAANFDGKHDH> CEGDPMHOPGM, [In] ONEIGDDHEHF<BHNHNFGAFAG, ALDFIIFMMJH> GKMAOPPGCIB, [In] OACMJNHPIGJ<(ENBGACDEBPI<NONCGDBHDIG> CallId, ENBGACDEBPI<CIDMBGEGHGN> IOId)> BOGMFKICBFD, [In] ONEIGDDHEHF<CIDMBGEGHGN, BOPHJKCPALL> IHLHAKMKIIF, [In] ALPCOFPOCAO<CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FGGCNBPDLNK, [In] ALPCOFPOCAO<CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> GEBDJHKDIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x254B550", Offset = "0x254A150", VA = "0x18254B550")]
	public static CNABDBPFNLB JPHABLICNHB()
	{
		return default(CNABDBPFNLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JBKOBDEAHHF
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x254FE10", Offset = "0x254EA10", VA = "0x18254FE10")]
	private static void LOIALHEPEBI(this CNABDBPFNLB.BOPHJKCPALL DKGDAEBOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x254FC00", Offset = "0x254E800", VA = "0x18254FC00")]
	public static void LOIALHEPEBI(this CNABDBPFNLB DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DGBBCGBGJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OACMJNHPIGJ<byte> PHILPGOHBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CNABDBPFNLB OKMCGLDBCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal DOBGJJENJPB MKIKONNHDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> KIEIMCNHKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal FKFPHCKPKHB BIJFFKKHAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal GFDAJBPCGNG AACNPLCNBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal ALPCOFPOCAO<BEIDLONMPPN, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>?> OHEAEPLBPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OACMJNHPIGJ<ENBGACDEBPI<BEIDLONMPPN>> DMIDOEDICCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> KHHAGEAMJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> GPKJPLLFOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> HLJLAHHKPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal GNIFFBFCNFA PFFDBKEHAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal IGLIPIEKBHG CMODDBPLJJN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x254C4F0", Offset = "0x254B0F0", VA = "0x18254C4F0")]
	private DGBBCGBGJJC([In] OACMJNHPIGJ<byte> BKILIAMAKII, [In] CNABDBPFNLB KDBBGAAEFAE, [In] DOBGJJENJPB MMKHMEHHPID, [In] FKFPHCKPKHB KPDDJGGGLKJ, [In] GFDAJBPCGNG DDNLOPAKGIC, [In] ALPCOFPOCAO<BEIDLONMPPN, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>?> AFDNFGHFMAI, [In] OACMJNHPIGJ<ENBGACDEBPI<BEIDLONMPPN>> HEBPNHCJMMB, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> OBHBMJLHDMF, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> KLJGPJIHKFE, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> DCKLEAIJINF, [In] GNIFFBFCNFA LLMOCOLNGFM, [In] IGLIPIEKBHG KJLDAJHAMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x254BB40", Offset = "0x254A740", VA = "0x18254BB40")]
	public static DGBBCGBGJJC JPHABLICNHB()
	{
		return default(DGBBCGBGJJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EEIDLDBPNIG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct CNONKNKFCPM : JNDEKFKEBHA<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>, ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x254B7C0", Offset = "0x254A3C0", VA = "0x18254B7C0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x254B870", Offset = "0x254A470", VA = "0x18254B870", Slot = "4")]
		public ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> OKFDGHGJJNG(int BIEEMEKMINN)
		{
			return default(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		public bool LCNFHNCPJKP(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "5")]
		private bool HMOIHLMKJKC(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x254B7B0", Offset = "0x254A3B0", VA = "0x18254B7B0", Slot = "6")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MBBGCKEGAJM(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct PAJALBBAIKE : PHJBAONJFED<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>, ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2550FC0", Offset = "0x254FBC0", VA = "0x182550FC0")]
		public OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>> OAFHKFBOGGF(int DNPLKCEEDFF, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2550F00", Offset = "0x254FB00", VA = "0x182550F00")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2550E40", Offset = "0x254FA40", VA = "0x182550E40", Slot = "6")]
		public void LAEDGDKAKDM(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2550FC0", Offset = "0x254FBC0", VA = "0x182550FC0", Slot = "4")]
		private OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>> OLKPDDPFNNP(int DNPLKCEEDFF, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2550FB0", Offset = "0x254FBB0", VA = "0x182550FB0", Slot = "5")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MLCEEPDABFF(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct KPIGFBDOPIN : JNDEKFKEBHA<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>, ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x25507D0", Offset = "0x254F3D0", VA = "0x1825507D0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2550880", Offset = "0x254F480", VA = "0x182550880", Slot = "4")]
		public ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> OKFDGHGJJNG(int BIEEMEKMINN)
		{
			return default(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		public bool LCNFHNCPJKP(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "5")]
		private bool KGCIDFGDCMG(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25507C0", Offset = "0x254F3C0", VA = "0x1825507C0", Slot = "6")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> DELDEELKBBK(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct JGNLIECMIBL : PHJBAONJFED<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>, ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2550220", Offset = "0x254EE20", VA = "0x182550220")]
		public OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>> OAFHKFBOGGF(int DNPLKCEEDFF, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2550360", Offset = "0x254EF60", VA = "0x182550360")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25502A0", Offset = "0x254EEA0", VA = "0x1825502A0", Slot = "6")]
		public void LAEDGDKAKDM(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2550220", Offset = "0x254EE20", VA = "0x182550220", Slot = "4")]
		private OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>> GJPLMKDOJFI(int DNPLKCEEDFF, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2550290", Offset = "0x254EE90", VA = "0x182550290", Slot = "5")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> HDCPBBNLEPC(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> BIEEMEKMINN, [In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct PKNMHPPCHPJ : JNDEKFKEBHA<ENBGACDEBPI<NKOHBHOJOIJ>, ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x25510C0", Offset = "0x254FCC0", VA = "0x1825510C0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2551190", Offset = "0x254FD90", VA = "0x182551190", Slot = "4")]
		public ENBGACDEBPI<NKOHBHOJOIJ> OKFDGHGJJNG(int BIEEMEKMINN)
		{
			return default(ENBGACDEBPI<NKOHBHOJOIJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2551040", Offset = "0x254FC40", VA = "0x182551040")]
		public bool LCNFHNCPJKP(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2551040", Offset = "0x254FC40", VA = "0x182551040", Slot = "5")]
		private bool MHDOKCPPBPA(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2551030", Offset = "0x254FC30", VA = "0x182551030", Slot = "6")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> CLEFMOLIBCH(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MHNAKPGMIDN : PHJBAONJFED<ENBGACDEBPI<NKOHBHOJOIJ>, ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2550B40", Offset = "0x254F740", VA = "0x182550B40")]
		public OACMJNHPIGJ<ENBGACDEBPI<NKOHBHOJOIJ>> OAFHKFBOGGF(int DNPLKCEEDFF, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<ENBGACDEBPI<NKOHBHOJOIJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2550CA0", Offset = "0x254F8A0", VA = "0x182550CA0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2550BC0", Offset = "0x254F7C0", VA = "0x182550BC0", Slot = "6")]
		public void LAEDGDKAKDM(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2550B40", Offset = "0x254F740", VA = "0x182550B40", Slot = "4")]
		private OACMJNHPIGJ<ENBGACDEBPI<NKOHBHOJOIJ>> CBDPABGJNNI(int DNPLKCEEDFF, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<ENBGACDEBPI<NKOHBHOJOIJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2550BB0", Offset = "0x254F7B0", VA = "0x182550BB0", Slot = "5")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> EBFNGGDHNBA(ENBGACDEBPI<NKOHBHOJOIJ> BIEEMEKMINN, [In] ALPCOFPOCAO<NKOHBHOJOIJ, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>?> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct CHBCACBPIOK : JNDEKFKEBHA<int, OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x254B4B0", Offset = "0x254A0B0", VA = "0x18254B4B0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC23D30", Offset = "0xC22930", VA = "0x180C23D30", Slot = "4")]
		public int OKFDGHGJJNG(int BIEEMEKMINN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		public bool LCNFHNCPJKP(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "5")]
		private bool FKEKHMFPKAC(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x254B4A0", Offset = "0x254A0A0", VA = "0x18254B4A0", Slot = "6")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> KGMFIPAMEMH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct MFPMMPEBLIG : PHJBAONJFED<int, OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2550920", Offset = "0x254F520", VA = "0x182550920")]
		public OACMJNHPIGJ<int> OAFHKFBOGGF(int DNPLKCEEDFF, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2550AA0", Offset = "0x254F6A0", VA = "0x182550AA0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2550990", Offset = "0x254F590", VA = "0x182550990", Slot = "6")]
		public void LAEDGDKAKDM(int BIEEMEKMINN, OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2550920", Offset = "0x254F520", VA = "0x182550920", Slot = "4")]
		private OACMJNHPIGJ<int> BCFLEECGFAD(int DNPLKCEEDFF, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2550A90", Offset = "0x254F690", VA = "0x182550A90", Slot = "5")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> LKHADCENEII(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> VariableId, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<MCIANNAFDDF>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct IKDMCONBBLE : JNDEKFKEBHA<int, OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x254FB60", Offset = "0x254E760", VA = "0x18254FB60")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC23D30", Offset = "0xC22930", VA = "0x180C23D30", Slot = "4")]
		public int OKFDGHGJJNG(int BIEEMEKMINN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		public bool LCNFHNCPJKP(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "5")]
		private bool CODCKBPNIEM(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x254FB50", Offset = "0x254E750", VA = "0x18254FB50", Slot = "6")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> GLLPGANKHFN(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct JCLLBKBANOF : PHJBAONJFED<int, OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x254FE70", Offset = "0x254EA70", VA = "0x18254FE70")]
		public OACMJNHPIGJ<int> OAFHKFBOGGF(int DNPLKCEEDFF, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x254FFD0", Offset = "0x254EBD0", VA = "0x18254FFD0")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x254FEE0", Offset = "0x254EAE0", VA = "0x18254FEE0", Slot = "6")]
		public void LAEDGDKAKDM(int BIEEMEKMINN, OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x254FE70", Offset = "0x254EA70", VA = "0x18254FE70", Slot = "4")]
		private OACMJNHPIGJ<int> JBEEMEDABGN(int DNPLKCEEDFF, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x254FE60", Offset = "0x254EA60", VA = "0x18254FE60", Slot = "5")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> DNGLAGELFMB(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct JFAHNPHHMII : JNDEKFKEBHA<int, OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2550080", Offset = "0x254EC80", VA = "0x182550080")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC23D30", Offset = "0xC22930", VA = "0x180C23D30", Slot = "4")]
		public int OKFDGHGJJNG(int BIEEMEKMINN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		public bool LCNFHNCPJKP(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "5")]
		private bool CODCKBPNIEM(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2550070", Offset = "0x254EC70", VA = "0x182550070", Slot = "6")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> GLLPGANKHFN(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct COMCDDMCGFB : PHJBAONJFED<int, OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x254B8B0", Offset = "0x254A4B0", VA = "0x18254B8B0")]
		public OACMJNHPIGJ<int> OAFHKFBOGGF(int DNPLKCEEDFF, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x254BA20", Offset = "0x254A620", VA = "0x18254BA20")]
		public ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x254B920", Offset = "0x254A520", VA = "0x18254B920", Slot = "6")]
		public void LAEDGDKAKDM(int BIEEMEKMINN, OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x254B8B0", Offset = "0x254A4B0", VA = "0x18254B8B0", Slot = "4")]
		private OACMJNHPIGJ<int> JBEEMEDABGN(int DNPLKCEEDFF, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(OACMJNHPIGJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x254B8A0", Offset = "0x254A4A0", VA = "0x18254B8A0", Slot = "5")]
		private ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> DNGLAGELFMB(int BIEEMEKMINN, [In] OACMJNHPIGJ<(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> Target, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> ByteCodeWriteLocation)> FKBJBKHIAAE)
		{
			return default(ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct GAGGBFKPNID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> IJKLPJOOADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool GGKOEKECBHO;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1BE03D0", Offset = "0x1BDEFD0", VA = "0x181BE03D0")]
		public GAGGBFKPNID(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL, bool IHMALFDKNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x254F5E0", Offset = "0x254E1E0", VA = "0x18254F5E0")]
		public void EALEPKLOIDH([Out] ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL, [Out] bool IHMALFDKNNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FNLCOECCPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly ENBGACDEBPI<NKOHBHOJOIJ> AOBDDKJNMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> IJKLPJOOADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool GGKOEKECBHO;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x254F5D0", Offset = "0x254E1D0", VA = "0x18254F5D0")]
		public FNLCOECCPNB(ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL, bool IHMALFDKNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x254F5A0", Offset = "0x254E1A0", VA = "0x18254F5A0")]
		public void EALEPKLOIDH([Out] ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL, [Out] bool IHMALFDKNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x254F5B0", Offset = "0x254E1B0", VA = "0x18254F5B0")]
		public void EALEPKLOIDH([Out] ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL, [Out] ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO, [Out] bool IHMALFDKNNK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct GDCGOFLLEJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly ENBGACDEBPI<NKOHBHOJOIJ> AOBDDKJNMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> IJKLPJOOADA;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		public GDCGOFLLEJI(ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x254F5F0", Offset = "0x254E1F0", VA = "0x18254F5F0")]
		public void EALEPKLOIDH([Out] ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL, [Out] ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x254E6D0", Offset = "0x254D2D0", VA = "0x18254E6D0")]
	public static void LOIALHEPEBI(this DGBBCGBGJJC DKGDAEBOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x254CFF0", Offset = "0x254BBF0", VA = "0x18254CFF0")]
	public static void BHKGJLIPKCG(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> ENEEOPOJIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x254F060", Offset = "0x254DC60", VA = "0x18254F060")]
	public static void PBBIGPADFDN(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> ENEEOPOJIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x254E430", Offset = "0x254D030", VA = "0x18254E430")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>? LJIFDNJPACC([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x254EDC0", Offset = "0x254D9C0", VA = "0x18254EDC0")]
	public static ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> OHPMMEFEAAF([In] this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x254E9A0", Offset = "0x254D5A0", VA = "0x18254E9A0")]
	private static void LPPGEBDIBBP(this DGBBCGBGJJC DKGDAEBOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x254CE50", Offset = "0x254BA50", VA = "0x18254CE50")]
	private static ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>? AHOMCLEJNOO([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x254E010", Offset = "0x254CC10", VA = "0x18254E010")]
	public static void JMAMCNHPICL(this DGBBCGBGJJC DKGDAEBOJKO, [In] OACMJNHPIGJ<FBMDPCLLCIL> PAKFKDLMBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x254D9E0", Offset = "0x254C5E0", VA = "0x18254D9E0")]
	public static FKFPHCKPKHB.CIKCGHODHPF GPBGNAGGCFC([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
	{
		return default(FKFPHCKPKHB.CIKCGHODHPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x254D640", Offset = "0x254C240", VA = "0x18254D640")]
	public static HMHIJEGPIOM<byte> FJJGBLIMDNI([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
	{
		return default(HMHIJEGPIOM<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x254EE20", Offset = "0x254DA20", VA = "0x18254EE20")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> OJLLECMPIIL([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x254D200", Offset = "0x254BE00", VA = "0x18254D200")]
	public static GJKMACPKIMD DPGJFDCJDMI([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
	{
		return default(GJKMACPKIMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31CD670", Offset = "0x31CC270", VA = "0x1831CD670")]
	private static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> GGNDPADFNEG<TMJoin>(this DGBBCGBGJJC DKGDAEBOJKO, FKFPHCKPKHB.CIKCGHODHPF ACBKGIPMJCO, ENBGACDEBPI<TMJoin> GHGGHFFONEM) where TMJoin : FKFPHCKPKHB.PPKJLHGEEMB
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x254D540", Offset = "0x254C140", VA = "0x18254D540")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> FFAEAAPNDCP(this DGBBCGBGJJC DKGDAEBOJKO, bool GHNOFMLAHPB)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x254D4B0", Offset = "0x254C0B0", VA = "0x18254D4B0")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> FDAFDAOFGDI(this DGBBCGBGJJC DKGDAEBOJKO, HMHIJEGPIOM<byte> FOLLKKLPOMJ)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x254D5C0", Offset = "0x254C1C0", VA = "0x18254D5C0")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> FJIHPIEFODI(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> GCEIMBFAIJM)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x254E3B0", Offset = "0x254CFB0", VA = "0x18254E3B0")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> KNMILJCMBEO(this DGBBCGBGJJC DKGDAEBOJKO, int FIPLCPBKKGG)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x254F130", Offset = "0x254DD30", VA = "0x18254F130")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> PBLILDDAGPE(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31CE980", Offset = "0x31CD580", VA = "0x1831CE980")]
	private static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> PIPABIOOHDF<TMJoin>(this DGBBCGBGJJC DKGDAEBOJKO, GFDAJBPCGNG.JFGLNDNPNDF ACBKGIPMJCO, ENBGACDEBPI<TMJoin> GHGGHFFONEM) where TMJoin : GFDAJBPCGNG.ILJLNPECGBP
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x254D9A0", Offset = "0x254C5A0", VA = "0x18254D9A0")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> GMNLLAJLEGM(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x254EC40", Offset = "0x254D840", VA = "0x18254EC40")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> NJAHMADFCKL(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x254D790", Offset = "0x254C390", VA = "0x18254D790")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> FKDJADHKGFN(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> EDEFPEDKGNC)
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x254EB10", Offset = "0x254D710", VA = "0x18254EB10")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> MADIHKFKONB(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x254EBF0", Offset = "0x254D7F0", VA = "0x18254EBF0")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> NDGLLEKNINK(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x254F2A0", Offset = "0x254DEA0", VA = "0x18254F2A0")]
	public static CNABDBPFNLB.HAHOIIHOPMK PMFJJPJJAGL([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> FOLMKAEPAGK)
	{
		return default(CNABDBPFNLB.HAHOIIHOPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x254D1C0", Offset = "0x254BDC0", VA = "0x18254D1C0")]
	public static DAKBGFCIKOO<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>, EBIENHCLMFJ<CNABDBPFNLB.CIDMBGEGHGN>> DJALJPFEBHJ([In] this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(DAKBGFCIKOO<ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>, EBIENHCLMFJ<CNABDBPFNLB.CIDMBGEGHGN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x254E4F0", Offset = "0x254D0F0", VA = "0x18254E4F0")]
	public static ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> LLIMGEIPONJ([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> FOLMKAEPAGK)
	{
		return default(ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x254D430", Offset = "0x254C030", VA = "0x18254D430")]
	public static CNABDBPFNLB.BOPHJKCPALL FCNNAGBPOFH([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> JJBJIOFJKKC)
	{
		return default(CNABDBPFNLB.BOPHJKCPALL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x254F1B0", Offset = "0x254DDB0", VA = "0x18254F1B0")]
	public static CNABDBPFNLB.BOPHJKCPALL PIDDBGLBOGM(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> JJBJIOFJKKC)
	{
		return default(CNABDBPFNLB.BOPHJKCPALL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31CCB90", Offset = "0x31CB790", VA = "0x1831CCB90")]
	private static ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> ABLDKDEFPEM<TMJoin>(this DGBBCGBGJJC DKGDAEBOJKO, CNABDBPFNLB.HAHOIIHOPMK ACBKGIPMJCO, ENBGACDEBPI<TMJoin> GHGGHFFONEM) where TMJoin : CNABDBPFNLB.BPAGJCBBFAN
	{
		return default(ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x254CCA0", Offset = "0x254B8A0", VA = "0x18254CCA0")]
	public static (ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>) ABJLGEJANON(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default((ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x254DC80", Offset = "0x254C880", VA = "0x18254DC80")]
	public static (ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>) HPHDHHNEJEO(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default((ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x254CFA0", Offset = "0x254BBA0", VA = "0x18254CFA0")]
	public static ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> BFNEAACPNNC(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x254CF10", Offset = "0x254BB10", VA = "0x18254CF10")]
	public static void AIAFNFEBFCL(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN> JJBJIOFJKKC, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> PBJBPKOJBOL, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>> OFJOOKNGNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31CD720", Offset = "0x31CC320", VA = "0x1831CD720")]
	public static GAGGBFKPNID HDPLAFNLKPJ<TDeps, TStateSys>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO) where TDeps : DAOEJMOICFP<TStateSys>
	{
		return default(GAGGBFKPNID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31CD3D0", Offset = "0x31CBFD0", VA = "0x1831CD3D0")]
	public static FNLCOECCPNB FOHDOFCFPAE<TDeps, TStateSys>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, int KLJFFOHNJFC) where TDeps : DAOEJMOICFP<TStateSys>
	{
		return default(FNLCOECCPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x31CE540", Offset = "0x31CD140", VA = "0x1831CE540")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>? MECOAPJDGFC<TDeps, TStateSys>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, [In] ReadOnlySpan<int> JGHCCABCLEJ, [In] Span<GDCGOFLLEJI> FDLLCGOBION) where TDeps : DAOEJMOICFP<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31CCD00", Offset = "0x31CB900", VA = "0x1831CCD00")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> EJDBFFPJODO<TDeps, TStateSys>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI) where TDeps : DAOEJMOICFP<TStateSys>
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x254DE30", Offset = "0x254CA30", VA = "0x18254DE30")]
	public static DOBGJJENJPB.OMNJNFMEFIB IILNKOJOMOG([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ)
	{
		return default(DOBGJJENJPB.OMNJNFMEFIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x254DB90", Offset = "0x254C790", VA = "0x18254DB90")]
	public static DOBGJJENJPB.GKKLHPEEJEK HEHALOAAFJH([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ)
	{
		return default(DOBGJJENJPB.GKKLHPEEJEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x254DF20", Offset = "0x254CB20", VA = "0x18254DF20")]
	public static DOBGJJENJPB.KIGJCHBJPLD IMAAGANMMPP([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ)
	{
		return default(DOBGJJENJPB.KIGJCHBJPLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x254D810", Offset = "0x254C410", VA = "0x18254D810")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FNJEJPAKLEJ(this DGBBCGBGJJC DKGDAEBOJKO, int? MNLJDPKDNPN, string BGKKCEGMOKH)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x254E180", Offset = "0x254CD80", VA = "0x18254E180")]
	public static DOBGJJENJPB.PBGILJNMAFF JNGKCGJPEAN([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ)
	{
		return default(DOBGJJENJPB.PBGILJNMAFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x254D080", Offset = "0x254BC80", VA = "0x18254D080")]
	public static DOBGJJENJPB.DOIIPMICCBB BMNLPJPLIFM([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ)
	{
		return default(DOBGJJENJPB.DOIIPMICCBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x254F230", Offset = "0x254DE30", VA = "0x18254F230")]
	public static int? PKAOABOKKAH([In] this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31CD2D0", Offset = "0x31CBED0", VA = "0x1831CD2D0")]
	private static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FLAEDFGFDKH<TMJoin>(this DGBBCGBGJJC DKGDAEBOJKO, int? MNLJDPKDNPN, DOBGJJENJPB.DOIIPMICCBB ACBKGIPMJCO, ENBGACDEBPI<TMJoin> GHGGHFFONEM) where TMJoin : DOBGJJENJPB.LNKBHFFPIOK
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x254D380", Offset = "0x254BF80", VA = "0x18254D380")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EPAPJDDPFKP(this DGBBCGBGJJC DKGDAEBOJKO, int? MNLJDPKDNPN, ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> FOLMKAEPAGK, int BIEEMEKMINN)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x254ED60", Offset = "0x254D960", VA = "0x18254ED60")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> OHMILHNOOKC(this DGBBCGBGJJC DKGDAEBOJKO, int? MNLJDPKDNPN)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x254EF10", Offset = "0x254DB10", VA = "0x18254EF10")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> PAIMBMOEDHN(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? EMAMDMAMIPI, int? MNLJDPKDNPN)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x254D2F0", Offset = "0x254BEF0", VA = "0x18254D2F0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ELHEMOMFPDF(this DGBBCGBGJJC DKGDAEBOJKO, int? MNLJDPKDNPN, int BIEEMEKMINN)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x254D730", Offset = "0x254C330", VA = "0x18254D730")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FKAMMLMDIIP(this DGBBCGBGJJC DKGDAEBOJKO, int? MNLJDPKDNPN)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x254E270", Offset = "0x254CE70", VA = "0x18254E270")]
	public static void KGLINJMLNID(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN, ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> FOLMKAEPAGK, int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x254DA60", Offset = "0x254C660", VA = "0x18254DA60")]
	public static void HBLFJMEGLDB(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN, int BIEEMEKMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x254EC90", Offset = "0x254D890", VA = "0x18254EC90")]
	public static void NOEECDPAALJ(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x254EB60", Offset = "0x254D760", VA = "0x18254EB60")]
	public static void MBBOBDMMADD(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> EJGAMJDEIEL, ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> GIIDHMHHDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x254D0F0", Offset = "0x254BCF0", VA = "0x18254D0F0")]
	public static void DFCFILAPGGE(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN, ENBGACDEBPI<GGAFINAEHPA<MCGEGAIJEIH>> GDDJBLIDEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x31CCC30", Offset = "0x31CB830", VA = "0x1831CCC30")]
	public static void CMDBFPKGJEE<M>(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MHCKKKKMPAN, ENBGACDEBPI<GGAFINAEHPA<FFOBBLBAKLA<M>>> GDDJBLIDEEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DAOEJMOICFP<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENBGACDEBPI<MFILLNOKJPM> AEELMOIABNO(TStateSys LOHDLCHLPCK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENBGACDEBPI<MFILLNOKJPM> AIMDEIEFEFD(TStateSys LOHDLCHLPCK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENBGACDEBPI<MFILLNOKJPM> AMOHNJLBADM(TStateSys LOHDLCHLPCK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ENBGACDEBPI<MFILLNOKJPM> OIIDJBIFDAD(TStateSys LOHDLCHLPCK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> FJKNKFFBBCD(TStateSys LOHDLCHLPCK, DGBBCGBGJJC PNLNPPEIKNP, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> PADIJFHJDMI(TStateSys LOHDLCHLPCK, DGBBCGBGJJC PNLNPPEIKNP, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OHDHOCBBKEC(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENBGACDEBPI<BEIDLONMPPN> PPHGCKNIAPB(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO, int LIILEGNGJIN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AGGGECAAFLL HHBHCIHPGAJ(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NNFEHIPFKON(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int ADMBMADLAFK(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HMHIJEGPIOM<byte> KDPIONCACOF(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(HMHIJEGPIOM<byte>, ENBGACDEBPI<MFILLNOKJPM>) NJAFNPPHDJL(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int HHGHONIFCAC(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ENBGACDEBPI<NKOHBHOJOIJ> CHPKMJFPIGM(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI, int KLJFFOHNJFC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ENBGACDEBPI<NKOHBHOJOIJ> KMDCHBBKCNA(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, int KLJFFOHNJFC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int GGDHLFOPPOK(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? IHIDGMBNLJI(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int PJBHAKBOLIK(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? LNEDBKONLPK(TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, int BIEEMEKMINN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AOALPMPJKFH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AC58D0", Offset = "0x3AC44D0", VA = "0x183AC58D0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA?> HLNCOMECHII<T, TOpInput, TOpOutput>(this DGBBCGBGJJC DKGDAEBOJKO, T IFMENDFGFGN, T DPEOCFNLADP, int IEFHJEAPMAM, IntPtr IGAJDACOHDK)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5E60", Offset = "0x3AC4A60", VA = "0x183AC5E60")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA?> JIOBIJDDANM<T, TOpInput, TOpOutput>(this DGBBCGBGJJC DKGDAEBOJKO, T IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP, int IEFHJEAPMAM, IntPtr IGAJDACOHDK)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6E60", Offset = "0x3AC5A60", VA = "0x183AC6E60")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA?> PJJDEONFLAP<TOpInput, TOpOutput>(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP, int IEFHJEAPMAM, IntPtr IGAJDACOHDK)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2548680", Offset = "0x2547280", VA = "0x182548680")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FBKHHPEEFGH(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2549040", Offset = "0x2547C40", VA = "0x182549040")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> GFOPIEPBNKA(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2547AC0", Offset = "0x25466C0", VA = "0x182547AC0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DKCPOIMNMDL(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2548580", Offset = "0x2547180", VA = "0x182548580")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FBJFBFABEPK(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2546F20", Offset = "0x2545B20", VA = "0x182546F20")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BMLKLEDBCFN(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2547C00", Offset = "0x2546800", VA = "0x182547C00")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ECKPEBMENLI(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2548820", Offset = "0x2547420", VA = "0x182548820")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FFCHNNCJKHJ(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2546BA0", Offset = "0x25457A0", VA = "0x182546BA0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BFIIGMGCBKJ(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x25492D0", Offset = "0x2547ED0", VA = "0x1825492D0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> GPKBKKFADHK(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2547E80", Offset = "0x2546A80", VA = "0x182547E80")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EFJMEBJJFMC(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, int DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x25498D0", Offset = "0x25484D0", VA = "0x1825498D0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGMOOBEHLKP(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2546DE0", Offset = "0x25459E0", VA = "0x182546DE0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BJECGJENEFP(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x25466C0", Offset = "0x25452C0", VA = "0x1825466C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> APKJAAIJHKL(this DGBBCGBGJJC DKGDAEBOJKO, float IFMENDFGFGN, float DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x254A2D0", Offset = "0x2548ED0", VA = "0x18254A2D0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KDCGDADIJCD(this DGBBCGBGJJC DKGDAEBOJKO, float IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x25477D0", Offset = "0x25463D0", VA = "0x1825477D0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DCIEOKBDIAI(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2549250", Offset = "0x2547E50", VA = "0x182549250")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> GOAIDEGBMCJ(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, int DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x254B130", Offset = "0x2549D30", VA = "0x18254B130")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> PDEGLGIHBNC(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x254AE50", Offset = "0x2549A50", VA = "0x18254AE50")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> OCLGDMEPAGE(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x25499F0", Offset = "0x25485F0", VA = "0x1825499F0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HOBEPELLLEL(this DGBBCGBGJJC DKGDAEBOJKO, float IFMENDFGFGN, float DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2547040", Offset = "0x2545C40", VA = "0x182547040")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CAHCKHLGCNG(this DGBBCGBGJJC DKGDAEBOJKO, float IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x25472C0", Offset = "0x2545EC0", VA = "0x1825472C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CEMOBJDIMGF(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x254B1B0", Offset = "0x2549DB0", VA = "0x18254B1B0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> PFKCKBDLOEL(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, int DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2546900", Offset = "0x2545500", VA = "0x182546900")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BAOBDOMMJHF(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2548D60", Offset = "0x2547960", VA = "0x182548D60")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FLGKANNDHFO(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2549DF0", Offset = "0x25489F0", VA = "0x182549DF0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IMKPOKHAIOP(this DGBBCGBGJJC DKGDAEBOJKO, float IFMENDFGFGN, float DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x254A480", Offset = "0x2549080", VA = "0x18254A480")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KJAMLNLNECG(this DGBBCGBGJJC DKGDAEBOJKO, float IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x254A250", Offset = "0x2548E50", VA = "0x18254A250")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KBLOJDJOKFJ(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x25462D0", Offset = "0x2544ED0", VA = "0x1825462D0")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> AKMNCEPFMKC(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2546CC0", Offset = "0x25458C0", VA = "0x182546CC0")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> BGHOGDKHINK(this DGBBCGBGJJC DKGDAEBOJKO, int MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2546D40", Offset = "0x2545940", VA = "0x182546D40")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> BILEOGAGJCP(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x254A0A0", Offset = "0x2548CA0", VA = "0x18254A0A0")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> JMEBPEOCPIM(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> OENGBGILKAL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2547A40", Offset = "0x2546640", VA = "0x182547A40")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> DIJHNHPOEOE(this DGBBCGBGJJC DKGDAEBOJKO, int MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x254A700", Offset = "0x2549300", VA = "0x18254A700")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> KMPDNLOPBFJ(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2548920", Offset = "0x2547520", VA = "0x182548920")]
	public static (ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>) FJBCPONCDIB(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<MHPCJABLLBH> NEMHIINOFLB, [In] ReadOnlySpan<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> IGHJGAIMPFD, [In] ReadOnlySpan<int?> FBIDEBECJDF, [In] Span<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> DDEPMEKNPNI)
	{
		return default((ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2549490", Offset = "0x2548090", VA = "0x182549490")]
	public static (ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>) HFOJJHHFIND(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<APPBJBEGGDM> PLKMDIGGPIL, [In] ReadOnlySpan<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> IGHJGAIMPFD, [In] ReadOnlySpan<int?> FBIDEBECJDF, [In] Span<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> DDEPMEKNPNI)
	{
		return default((ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4A20", Offset = "0x3AC3620", VA = "0x183AC4A20")]
	public static (ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<MFILLNOKJPM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<TMarker>>, ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>) BNNELJNGJCA<TMarker>(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<MFILLNOKJPM> IICPLMMDIKM, [In] ReadOnlySpan<byte> LLDJIJICLJF)
	{
		return default((ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<GGAFINAEHPA<MFILLNOKJPM>>, ENBGACDEBPI<GGAFINAEHPA<DCHNPJGMAPI>>, ENBGACDEBPI<GGAFINAEHPA<TMarker>>, ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x25484C0", Offset = "0x25470C0", VA = "0x1825484C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EMLOHMCGPGG(this DGBBCGBGJJC DKGDAEBOJKO, int POLACNBCNMG, [Optional] ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2547460", Offset = "0x2546060", VA = "0x182547460")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CGJPADBADHK(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> POLACNBCNMG, [Optional] ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2549160", Offset = "0x2547D60", VA = "0x182549160")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> GLEJANCNCMG(this DGBBCGBGJJC DKGDAEBOJKO, [In] ReadOnlySpan<byte> POLACNBCNMG, [Optional] ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x25480A0", Offset = "0x2546CA0", VA = "0x1825480A0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EKHIHJAKDGD(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> POLACNBCNMG, int FJJGAGKDECJ, [Optional] ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2549E70", Offset = "0x2548A70", VA = "0x182549E70")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IPMPKAFPNNG(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2549F80", Offset = "0x2548B80", VA = "0x182549F80")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> JGCEFAMEBEP(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2547690", Offset = "0x2546290", VA = "0x182547690")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CKDOHGPHAOL(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x25471C0", Offset = "0x2545DC0", VA = "0x1825471C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CCODBNEJMAK(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x254AB00", Offset = "0x2549700", VA = "0x18254AB00")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MBFHODJCBDC(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2546190", Offset = "0x2544D90", VA = "0x182546190")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ABCLMEMKJKP(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2549410", Offset = "0x2548010", VA = "0x182549410")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HDPPKHKHPAA(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, int DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x25487A0", Offset = "0x25473A0", VA = "0x1825487A0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FCJGBHINFNJ(this DGBBCGBGJJC DKGDAEBOJKO, int IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x254A400", Offset = "0x2549000", VA = "0x18254A400")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KFKBFOKGIBG(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IFMENDFGFGN, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> DPEOCFNLADP)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x254AC20", Offset = "0x2549820", VA = "0x18254AC20")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> OBLAKHHFFDO(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x254AD20", Offset = "0x2549920", VA = "0x18254AD20")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> OCIGEANHOKG(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2546580", Offset = "0x2545180", VA = "0x182546580")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> AOCOHKBNBOF(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x254A500", Offset = "0x2549100", VA = "0x18254A500")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KKDHPGFDAHK(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x254A7A0", Offset = "0x25493A0", VA = "0x18254A7A0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> LGJCIIFNODE(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2547D40", Offset = "0x2546940", VA = "0x182547D40")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EECONAPFGLK(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2548780", Offset = "0x2547380", VA = "0x182548780")]
	public static ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>> FBMBGBEDOKH(this DGBBCGBGJJC DKGDAEBOJKO)
	{
		return default(ENBGACDEBPI<GGAFINAEHPA<GGAFINAEHPA<JGCKKAOPKLM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x254A600", Offset = "0x2549200", VA = "0x18254A600")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KMFLGNEHADM(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2547340", Offset = "0x2545F40", VA = "0x182547340")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CGBIIJEJPIA(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x254A9C0", Offset = "0x25495C0", VA = "0x18254A9C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> LPCKOCGEJPM(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2546480", Offset = "0x2545080", VA = "0x182546480")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ANODANKADGB(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x254AED0", Offset = "0x2549AD0", VA = "0x18254AED0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ONHGHPKLNBK(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2547550", Offset = "0x2546150", VA = "0x182547550")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CIPGDCFBDIC(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x25470C0", Offset = "0x2545CC0", VA = "0x1825470C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> CBIIAAIIPEJ(this DGBBCGBGJJC DKGDAEBOJKO, int MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2546080", Offset = "0x2544C80", VA = "0x182546080")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> AAIJIEPEEMF(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> MPDLOLIOGJL)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2549F70", Offset = "0x2548B70", VA = "0x182549F70")]
	public static void JDMBLHOKKLF(this DGBBCGBGJJC DKGDAEBOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x254A8C0", Offset = "0x25494C0", VA = "0x18254A8C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> LHDBNMGFIHP(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, float KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2546980", Offset = "0x2545580", VA = "0x182546980")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BCFAEKLGGKD(this DGBBCGBGJJC DKGDAEBOJKO, float NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x25467C0", Offset = "0x25453C0", VA = "0x1825467C0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BALLPDBDINE(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2546AA0", Offset = "0x25456A0", VA = "0x182546AA0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> BEPBALKCJEH(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2548F20", Offset = "0x2547B20", VA = "0x182548F20")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> GBHHOHINJGE(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x254AFF0", Offset = "0x2549BF0", VA = "0x18254AFF0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> PBCDGJENIOG(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2549A70", Offset = "0x2548670", VA = "0x182549A70")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> IAHPHAMHHEO(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> JOPDEKJEBBI, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> HBIFEJADHLL)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x254B230", Offset = "0x2549E30", VA = "0x18254B230")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> PPHCDDGCEKH(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, int KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2547F80", Offset = "0x2546B80", VA = "0x182547F80")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EFNKPHDLPCJ(this DGBBCGBGJJC DKGDAEBOJKO, int NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2548DE0", Offset = "0x25479E0", VA = "0x182548DE0")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> FNNKFFPKILP(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> NFOAEGAEIHO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> KHFMJJLPPNM)
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5330", Offset = "0x3AC3F30", VA = "0x183AC5330")]
	public static void GEFHBEHJFGN<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<MHPCJABLLBH> NEMHIINOFLB, [In] ReadOnlySpan<ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>> IEOAKNHPDBF, [In] ReadOnlySpan<int?> FBIDEBECJDF, [In] Span<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> DDEPMEKNPNI, [In] Span<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> ODPKBEICCAF, [In] ReadOnlySpan<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>?> LLLEDGIKFBD) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4480", Offset = "0x3AC3080", VA = "0x183AC4480")]
	public static void BJGMCKLLMED<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<APPBJBEGGDM> ONHFNCNDFHG, [In] ReadOnlySpan<ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>> GMDPKPLBKKL, [In] ReadOnlySpan<int?> FBIDEBECJDF, [In] Span<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> DDEPMEKNPNI, [In] Span<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>> ODPKBEICCAF, [In] ReadOnlySpan<ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>?> LLLEDGIKFBD) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4070", Offset = "0x3AC2C70", VA = "0x183AC4070")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ANBODDFNECJ<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EMAMDMAMIPI, [Optional] ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4B20", Offset = "0x3AC3720", VA = "0x183AC4B20")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> EHAAGIIIOBM<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> EDEFPEDKGNC, [Optional] ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4250", Offset = "0x3AC2E50", VA = "0x183AC4250")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> BBLNBAONJFC<TDeps, TStateSys>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK) where TDeps : notnull, DAOEJMOICFP<TStateSys> where TStateSys : notnull
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6C50", Offset = "0x3AC5850", VA = "0x183AC6C50")]
	public static ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO> PBLDJPPFBDO<TDeps, TStateSys>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK) where TDeps : notnull, DAOEJMOICFP<TStateSys> where TStateSys : notnull
	{
		return default(ENBGACDEBPI<GFDAJBPCGNG.BDNDLNLFDMO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2547910", Offset = "0x2546510", VA = "0x182547910")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> DHCAALHGAFC(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> MPCCLHPEAIM, IntPtr CECPEDGBGOI, IntPtr ENMHFFCFECP)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x25481C0", Offset = "0x2546DC0", VA = "0x1825481C0")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> ELBEHJNOAGL(this DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> HHBOBAMOAHC, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> ABKCOBPLGGJ, IntPtr CKMPKKIBGNL, IntPtr OLDNAEOCBMF, IntPtr BGMAKHKCFDB, bool KLCPOHNCMGP)
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6520", Offset = "0x3AC5120", VA = "0x183AC6520")]
	public static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> KANHCNPEJFC<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<MHPCJABLLBH> IEDGDICHEDN, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> HHBOBAMOAHC, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> ABKCOBPLGGJ, int? COPMHPGBKNL, [Optional] IntPtr LKNCHKHJIGC) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6200", Offset = "0x3AC4E00", VA = "0x183AC6200")]
	private static ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> KANHCNPEJFC<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<MHPCJABLLBH> IEDGDICHEDN, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> HHBOBAMOAHC, ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF> ABKCOBPLGGJ, int? COPMHPGBKNL) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
		return default(ENBGACDEBPI<FKFPHCKPKHB.PMPCAHLGJLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC4F80", Offset = "0x3AC3B80", VA = "0x183AC4F80")]
	public static ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> ENLLEPEKKHM<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> POLACNBCNMG, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>? LDFAIJKGKCP) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
		return default(ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC5BD0", Offset = "0x3AC47D0", VA = "0x183AC5BD0")]
	public static void IEECHGPNODH<TDeps, TState>(this DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TState CMPEMMPBPLC, int CMBELIJPOEK) where TDeps : notnull, DAOEJMOICFP<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct ANPBIGKBJKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> KDANPNIGCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> NJKPFLIMCLF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
	public ANPBIGKBJKB(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> PMCPPBFHOPP, ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> PPNAAANJLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2546070", Offset = "0x2544C70", VA = "0x182546070")]
	public static ANPBIGKBJKB JPHABLICNHB(ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>> PMCPPBFHOPP)
	{
		return default(ANPBIGKBJKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DOBGJJENJPB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class IHLOONGCOEJ : LNKBHFFPIOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct OMNJNFMEFIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> DINGFBIBBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int AHDPANGFLKC;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		public OMNJNFMEFIB(ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> FOLMKAEPAGK, int BIEEMEKMINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class KDBIEPKDEFP : LNKBHFFPIOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GKKLHPEEJEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int AHDPANGFLKC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public GKKLHPEEJEK(int BIEEMEKMINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class DPIHOGKOECK : LNKBHFFPIOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct KIGJCHBJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> DINGFBIBBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int AHDPANGFLKC;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
		public KIGJCHBJPLD(ENBGACDEBPI<CNABDBPFNLB.NONCGDBHDIG> FOLMKAEPAGK, int BIEEMEKMINN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum DOIIPMICCBB
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class DCEHOFHHJEA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class LNKBHFFPIOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct ICKMJMDPKHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? JHMAOFFFOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ANPBIGKBJKB DHEJJMAFGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public DOIIPMICCBB MKJNFEKLNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ENBGACDEBPI<LNKBHFFPIOK> JCLJIAHMKEO;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x254F940", Offset = "0x254E540", VA = "0x18254F940")]
		public ICKMJMDPKHG(int? MNLJDPKDNPN, [In] ANPBIGKBJKB CFIPCOFJLMO, DOIIPMICCBB ACBKGIPMJCO, ENBGACDEBPI<LNKBHFFPIOK> GHGGHFFONEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LCIOIFNDJLO : LNKBHFFPIOK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct PBGILJNMAFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int AHDPANGFLKC;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
		public PBGILJNMAFF(int BIEEMEKMINN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal GPKOLMDBKGI<DCEHOFHHJEA, ICKMJMDPKHG> DJCDFOOFODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal GPKOLMDBKGI<IHLOONGCOEJ, OMNJNFMEFIB> DENMMIJKKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal GPKOLMDBKGI<DPIHOGKOECK, KIGJCHBJPLD> FFBKNEOOEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal GPKOLMDBKGI<LCIOIFNDJLO, PBGILJNMAFF> JDNDPAHDGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal GPKOLMDBKGI<KDBIEPKDEFP, GKKLHPEEJEK> CDPEKNFOEHA;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x254CB70", Offset = "0x254B770", VA = "0x18254CB70")]
	private DOBGJJENJPB([In] GPKOLMDBKGI<DCEHOFHHJEA, ICKMJMDPKHG> BBBJPGEHKDE, [In] GPKOLMDBKGI<IHLOONGCOEJ, OMNJNFMEFIB> FMNBIGJCPLC, [In] GPKOLMDBKGI<DPIHOGKOECK, KIGJCHBJPLD> ABACJFIAIFA, [In] GPKOLMDBKGI<LCIOIFNDJLO, PBGILJNMAFF> DHJFHLPOPFM, [In] GPKOLMDBKGI<KDBIEPKDEFP, GKKLHPEEJEK> CKDHICPONJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x254C980", Offset = "0x254B580", VA = "0x18254C980")]
	public static DOBGJJENJPB JPHABLICNHB()
	{
		return default(DOBGJJENJPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EICAIJHGCPA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x254F320", Offset = "0x254DF20", VA = "0x18254F320")]
	public static void LOIALHEPEBI(this DOBGJJENJPB DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KCIKHKCBLMK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2550490", Offset = "0x254F090", VA = "0x182550490")]
	public static void BDNCCGGPJGH(DGBBCGBGJJC DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct GNIFFBFCNFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, JGLCEGBOKBA> ANMKMPNFEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int OBIAEIBLIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int FAIMCANGMIO;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x254F8F0", Offset = "0x254E4F0", VA = "0x18254F8F0")]
	private GNIFFBFCNFA([In] ALPCOFPOCAO<CNABDBPFNLB.CIDMBGEGHGN, JGLCEGBOKBA> BFFDJIBIMNN, int CNNIHBFAOOH, int NPNJLKHNNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x254F690", Offset = "0x254E290", VA = "0x18254F690")]
	public static GNIFFBFCNFA JPHABLICNHB()
	{
		return default(GNIFFBFCNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x254F700", Offset = "0x254E300", VA = "0x18254F700")]
	public void LOIALHEPEBI([In] DGBBCGBGJJC EKINCLIIKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x337BDC0", Offset = "0x337A9C0", VA = "0x18337BDC0")]
	public static void BDNCCGGPJGH<TDeps, TStateSys>(DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC) where TDeps : notnull, DAOEJMOICFP<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KNJFNNCNOOI
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x25505F0", Offset = "0x254F1F0", VA = "0x1825505F0")]
	public static void BDNCCGGPJGH(DGBBCGBGJJC DKGDAEBOJKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IGLIPIEKBHG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface KPLNKLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OGLNAOIDMDJ(OACMJNHPIGJ<byte> BKILIAMAKII, int GABFPHMLAAI);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct DLMHIKIAJBA : KPLNKLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x254C850", Offset = "0x254B450", VA = "0x18254C850", Slot = "4")]
		public void OGLNAOIDMDJ(OACMJNHPIGJ<byte> BKILIAMAKII, int GABFPHMLAAI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct DLONPJLDOBO : KPLNKLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x254C8D0", Offset = "0x254B4D0", VA = "0x18254C8D0", Slot = "4")]
		public void OGLNAOIDMDJ(OACMJNHPIGJ<byte> BKILIAMAKII, int GABFPHMLAAI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct DEAGGFOGIJK : KPLNKLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x254BAC0", Offset = "0x254A6C0", VA = "0x18254BAC0", Slot = "4")]
		public void OGLNAOIDMDJ(OACMJNHPIGJ<byte> BKILIAMAKII, int GABFPHMLAAI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct BMJKJMDEKHC : KPLNKLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x254B330", Offset = "0x2549F30", VA = "0x18254B330", Slot = "4")]
		public void OGLNAOIDMDJ(OACMJNHPIGJ<byte> BKILIAMAKII, int GABFPHMLAAI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class AIMGJBBCLMC<TCallProcessorDeps> where TCallProcessorDeps : struct, KPLNKLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps IHDBCEJNIED;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2B9DCD0", Offset = "0x2B9C8D0", VA = "0x182B9DCD0")]
		public static int BDNCCGGPJGH<TDeps, TStateSys>(TDeps CJMMHNIMOJB, TStateSys CMPEMMPBPLC, DGBBCGBGJJC EKINCLIIKLE, [In] OACMJNHPIGJ<byte> PFKGDFIHPGJ, int INIPHPCGJHP) where TDeps : DAOEJMOICFP<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private OACMJNHPIGJ<FBMDPCLLCIL> CMDIKPKHAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>> HBCAGHDFLKI;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x254FB10", Offset = "0x254E710", VA = "0x18254FB10")]
	private IGLIPIEKBHG([In] OACMJNHPIGJ<FBMDPCLLCIL> PAKFKDLMBOJ, Dictionary<ENBGACDEBPI<GGAFINAEHPA<JGCKKAOPKLM>>, ENBGACDEBPI<CNABDBPFNLB.CIDMBGEGHGN>> FEPEKPGKJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x254FA10", Offset = "0x254E610", VA = "0x18254FA10")]
	public static IGLIPIEKBHG JPHABLICNHB()
	{
		return default(IGLIPIEKBHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x254FAD0", Offset = "0x254E6D0", VA = "0x18254FAD0")]
	public void LOIALHEPEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x33B2E00", Offset = "0x33B1A00", VA = "0x1833B2E00")]
	public static void BDNCCGGPJGH<TDeps, TStateSys>(DGBBCGBGJJC DKGDAEBOJKO, TDeps CJMMHNIMOJB, TStateSys LOHDLCHLPCK) where TDeps : DAOEJMOICFP<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class POHEHKIAPPB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct NDOEDAIMNLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> JCMKLEGGAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int EJBAHDBNKHB;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int OIBKGLOHECO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int FPFCKKDGFPC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x25511C0", Offset = "0x254FDC0", VA = "0x1825511C0")]
	public static void BDNCCGGPJGH(DGBBCGBGJJC DKGDAEBOJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2551AF0", Offset = "0x25506F0", VA = "0x182551AF0")]
	private static void NOOHGOLPGBO([In] DGBBCGBGJJC DKGDAEBOJKO, ENBGACDEBPI<DOBGJJENJPB.DCEHOFHHJEA> HGEMPDBGGBJ, OACMJNHPIGJ<byte> OHIFLJNONAB, List<NDOEDAIMNLA> PAJPCCLEFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x25519B0", Offset = "0x25505B0", VA = "0x1825519B0")]
	private static void NOOHGOLPGBO(OACMJNHPIGJ<byte> OHIFLJNONAB, int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2551880", Offset = "0x2550480", VA = "0x182551880")]
	private static void FICAPDPGFLN(DGBBCGBGJJC DKGDAEBOJKO, List<NDOEDAIMNLA> PAJPCCLEFHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NLBCCDAOEBI<TDeps, TIndex, TValues> where TDeps : struct, PHJBAONJFED<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps IHDBCEJNIED;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4E58820", Offset = "0x4E57420", VA = "0x184E58820")]
	public static void BDNCCGGPJGH([In] OACMJNHPIGJ<FBMDPCLLCIL> PAKFKDLMBOJ, int DNPLKCEEDFF, TValues FKBJBKHIAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface PHJBAONJFED<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OACMJNHPIGJ<TIndex> OAFHKFBOGGF(int DNPLKCEEDFF, [In] TValues FKBJBKHIAAE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(TIndex BIEEMEKMINN, [In] TValues FKBJBKHIAAE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAEDGDKAKDM(TIndex BIEEMEKMINN, TValues FKBJBKHIAAE, ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MPDLOLIOGJL);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface JNDEKFKEBHA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex OKFDGHGJJNG(int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCNFHNCPJKP(TIndex BIEEMEKMINN, [In] TValues FKBJBKHIAAE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENBGACDEBPI<GGAFINAEHPA<MCIANNAFDDF>> MDCDDFFJPLH(TIndex BIEEMEKMINN, [In] TValues FKBJBKHIAAE);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IFIIFJKCHFH<TDeps, TIndex, TValues> where TDeps : struct, JNDEKFKEBHA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps IHDBCEJNIED;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x46F27E0", Offset = "0x46F13E0", VA = "0x1846F27E0")]
	public static OACMJNHPIGJ<TIndex> BDNCCGGPJGH(int DNPLKCEEDFF, [In] TValues FKBJBKHIAAE)
	{
		return default(OACMJNHPIGJ<TIndex>);
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
