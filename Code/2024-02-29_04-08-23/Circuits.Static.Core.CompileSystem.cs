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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D94B00", Offset = "0x1D93900", VA = "0x181D94B00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HNADBGOMMEB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class EOPPHKKIAJP
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal HNMIFFNBPEC<EOPPHKKIAJP> JLHOFAPGPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal FKJDGDHDMEC<EOPPHKKIAJP, object> JPLAKHOHHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal Dictionary<object, HIGDJMOGOKB<EOPPHKKIAJP>> BGLFICKOAAF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F770", Offset = "0x1D8E570", VA = "0x181D8F770")]
	private HNADBGOMMEB([In] HNMIFFNBPEC<EOPPHKKIAJP> CADFBCLDGMG, [In] FKJDGDHDMEC<EOPPHKKIAJP, object> EAFGMLDDPJN, Dictionary<object, HIGDJMOGOKB<EOPPHKKIAJP>> MMMOIALNLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F550", Offset = "0x1D8E350", VA = "0x181D8F550")]
	public static HNADBGOMMEB KJKFMOENPNA()
	{
		return default(HNADBGOMMEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HBAOGGLBPMH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F4E0", Offset = "0x1D8E2E0", VA = "0x181D8F4E0")]
	public static void ECEAPGIDAKG(this HNADBGOMMEB CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F3F0", Offset = "0x1D8E1F0", VA = "0x181D8F3F0")]
	public static HIGDJMOGOKB<HNADBGOMMEB.EOPPHKKIAJP> DPHBDCJJBOL(this HNADBGOMMEB CNFBJPGPBBJ, object NHLNHJGAONN)
	{
		return default(HIGDJMOGOKB<HNADBGOMMEB.EOPPHKKIAJP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MKLBGAPCFDM
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct INAEPGBHNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public LGHDEKJBNJM<int> KFBFHPAMJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public LGHDEKJBNJM<int> DAPICNEPHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public int JNLBOAAAAEE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F870", Offset = "0x1D8E670", VA = "0x181D8F870")]
	private INAEPGBHNCF([In] LGHDEKJBNJM<int> KFEJLOPOCJD, [In] LGHDEKJBNJM<int> JGFJPKHAJJF, int HEMIEGKGBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F7E0", Offset = "0x1D8E5E0", VA = "0x181D8F7E0")]
	public static INAEPGBHNCF KJKFMOENPNA()
	{
		return default(INAEPGBHNCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MFCKNELLHEA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D94AB0", Offset = "0x1D938B0", VA = "0x181D94AB0")]
	public static void ECEAPGIDAKG(this INAEPGBHNCF CNFBJPGPBBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OMNMDCGADIH
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class CIKLDCJLMNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum BNEEJGJNIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		External
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CFLGMNPBOIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public LGHDEKJBNJM<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> KFBFHPAMJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LGHDEKJBNJM<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> DAPICNEPHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HIGDJMOGOKB<PHODGCNBLJG<PCNJNOPPCJP>> HIIHGEGNPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BNEEJGJNIJJ MABMHLENLGH;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D9C0", Offset = "0x1D8C7C0", VA = "0x181D8D9C0")]
		private CFLGMNPBOIG([In] LGHDEKJBNJM<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> KFEJLOPOCJD, [In] LGHDEKJBNJM<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> JGFJPKHAJJF, HIGDJMOGOKB<PHODGCNBLJG<PCNJNOPPCJP>> NBGIEIGHHPB, BNEEJGJNIJJ EJKIJBMDFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D920", Offset = "0x1D8C720", VA = "0x181D8D920")]
		public static CFLGMNPBOIG KJKFMOENPNA(BNEEJGJNIJJ EJKIJBMDFPJ)
		{
			return default(CFLGMNPBOIG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal BOCFOHCFNAL<CIKLDCJLMNP, CFLGMNPBOIG> BGHGJOGHNDA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D95050", Offset = "0x1D93E50", VA = "0x181D95050")]
	private OMNMDCGADIH([In] BOCFOHCFNAL<CIKLDCJLMNP, CFLGMNPBOIG> BBGGHKHBHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D94FE0", Offset = "0x1D93DE0", VA = "0x181D94FE0")]
	public static OMNMDCGADIH KJKFMOENPNA()
	{
		return default(OMNMDCGADIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDHFBNCPAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F940", Offset = "0x1D8E740", VA = "0x181D8F940")]
	public static void ECEAPGIDAKG(this OMNMDCGADIH.CFLGMNPBOIG CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F990", Offset = "0x1D8E790", VA = "0x181D8F990")]
	public static void ECEAPGIDAKG(this OMNMDCGADIH CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FC30", Offset = "0x1D8EA30", VA = "0x181D8FC30")]
	public static HNMIFFNBPEC<OMNMDCGADIH.CIKLDCJLMNP> GADKBIOAGLF([In] this OMNMDCGADIH CNFBJPGPBBJ)
	{
		return default(HNMIFFNBPEC<OMNMDCGADIH.CIKLDCJLMNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FB20", Offset = "0x1D8E920", VA = "0x181D8FB20")]
	public static HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> FBMBFONJJMK(this OMNMDCGADIH CNFBJPGPBBJ)
	{
		return default(HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FCF0", Offset = "0x1D8EAF0", VA = "0x181D8FCF0")]
	public static HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> LCKLJCIJAMO(this OMNMDCGADIH CNFBJPGPBBJ)
	{
		return default(HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FC70", Offset = "0x1D8EA70", VA = "0x181D8FC70")]
	public static void JFJHMLBBICD(this OMNMDCGADIH CNFBJPGPBBJ, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> DGIBOINMLED, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F8C0", Offset = "0x1D8E6C0", VA = "0x181D8F8C0")]
	public static void DEMPLJKJEAJ(this OMNMDCGADIH CNFBJPGPBBJ, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> DGIBOINMLED, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KHJFAGMNDBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public LGHDEKJBNJM<byte> CMFLLGPDCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public OMNMDCGADIH HMKANFLNDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public OMGCGDLOJKF JAOKKDOCMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal HNADBGOMMEB PODKMBBIFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal Dictionary<string, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> IJMBBONENOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FKJDGDHDMEC<HJFCJGNOMLH, DCOBHNIJDOJ?> IFOPAGKHGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LGHDEKJBNJM<HIGDJMOGOKB<HJFCJGNOMLH>> JHICAHGLOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FKJDGDHDMEC<KGOIHNMDLLG, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>>?> HNHACPKEBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LGHDEKJBNJM<(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> VariableId, HIGDJMOGOKB<PHODGCNBLJG<BLKLOMIFLGC<PDPBMBHAAHN>>> ByteCodeWriteLocation)> CIBOPCPENEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal LGHDEKJBNJM<(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> Target, HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> ByteCodeWriteLocation)> GIEIFFONNGL;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D947E0", Offset = "0x1D935E0", VA = "0x181D947E0")]
	private KHJFAGMNDBA([In] LGHDEKJBNJM<byte> HNCGANJEKFF, [In] OMNMDCGADIH HCIKDGFJGBE, [In] OMGCGDLOJKF IHAMHOFGHMN, [In] HNADBGOMMEB FFMMGGHONJL, [In] FKJDGDHDMEC<HJFCJGNOMLH, DCOBHNIJDOJ?> IAOEIOJPOIN, [In] LGHDEKJBNJM<HIGDJMOGOKB<HJFCJGNOMLH>> EPNMAFAOOAE, [In] FKJDGDHDMEC<KGOIHNMDLLG, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>>?> BAPPCPNCHGA, [In] LGHDEKJBNJM<(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> VariableId, HIGDJMOGOKB<PHODGCNBLJG<BLKLOMIFLGC<PDPBMBHAAHN>>> ByteCodeWriteLocation)> GCKMCPEAFFD, [In] LGHDEKJBNJM<(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> Target, HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> ByteCodeWriteLocation)> JLDNDOHCJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D94060", Offset = "0x1D92E60", VA = "0x181D94060")]
	public static KHJFAGMNDBA KJKFMOENPNA()
	{
		return default(KHJFAGMNDBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GAILPOMGIDP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E860", Offset = "0x1D8D660", VA = "0x181D8E860")]
	public static void ECEAPGIDAKG(this KHJFAGMNDBA CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EBE0", Offset = "0x1D8D9E0", VA = "0x181D8EBE0")]
	public static HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> FMNNAADAPAF(this KHJFAGMNDBA CNFBJPGPBBJ)
	{
		return default(HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26EBE60", Offset = "0x26EAC60", VA = "0x1826EBE60")]
	public static void ALGFCCNAILO<M>(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA, HIGDJMOGOKB<PHODGCNBLJG<BLKLOMIFLGC<M>>> DAANJLHNNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F040", Offset = "0x1D8DE40", VA = "0x181D8F040")]
	public static void JHLJEDOHAKO(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> KAKJJOAALHM, HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> NLNPBNKODKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F380", Offset = "0x1D8E180", VA = "0x181D8F380")]
	public static void OIOFGPOIGLL(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, HIGDJMOGOKB<PHODGCNBLJG<PCNJNOPPCJP>> NBGIEIGHHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E7B0", Offset = "0x1D8D5B0", VA = "0x181D8E7B0")]
	public static void DHGONOBCOPM(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F0D0", Offset = "0x1D8DED0", VA = "0x181D8F0D0")]
	public static void KKPJJDDECBE(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ, [In] DCOBHNIJDOJ OBGJJALGIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EDB0", Offset = "0x1D8DBB0", VA = "0x181D8EDB0")]
	public static void HMIEJOKLODD(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ, [In] DCOBHNIJDOJ OBGJJALGIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D8ECF0", Offset = "0x1D8DAF0", VA = "0x181D8ECF0")]
	public static DCOBHNIJDOJ? GBAAFHKDPJP([In] this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26EBF20", Offset = "0x26EAD20", VA = "0x1826EBF20")]
	public static DCOBHNIJDOJ CBAKGHPJLFA<TDeps, TStateSys>(this KHJFAGMNDBA CNFBJPGPBBJ, TDeps DNHMNAAINOD, TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB) where TDeps : MGIBOMEJMIH<TStateSys>
	{
		return default(DCOBHNIJDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EEE0", Offset = "0x1D8DCE0", VA = "0x181D8EEE0")]
	private static void HPCEPKGGIPJ(this KHJFAGMNDBA CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E720", Offset = "0x1D8D520", VA = "0x181D8E720")]
	private static HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>>? ANBAEDCAFMF([In] this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E460", Offset = "0x1D8D260", VA = "0x181D8E460")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> AMCPKFJDKOH(this KHJFAGMNDBA CNFBJPGPBBJ, [In] string OHHBGJPCFJD, int HMCIMNDCLML)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26EEAD0", Offset = "0x26ED8D0", VA = "0x1826EEAD0")]
	public static CJHGMOIFGDE PPFBNLOKDKC<TDeps, TStateSys>(this KHJFAGMNDBA CNFBJPGPBBJ, TDeps DNHMNAAINOD, TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ) where TDeps : MGIBOMEJMIH<TStateSys>
	{
		return default(CJHGMOIFGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EA80", Offset = "0x1D8D880", VA = "0x181D8EA80")]
	public static void EFCKLDOCFGD(this KHJFAGMNDBA CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26EC980", Offset = "0x26EB780", VA = "0x1826EC980")]
	public static int NEPEAPPPEFC<TDeps, TStateSys>(this KHJFAGMNDBA CNFBJPGPBBJ, TDeps DNHMNAAINOD, TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, FKJDGDHDMEC<OMNMDCGADIH.CIKLDCJLMNP, INAEPGBHNCF> NKMJMFOMPPM) where TDeps : MGIBOMEJMIH<TStateSys>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F1B0", Offset = "0x1D8DFB0", VA = "0x181D8F1B0")]
	public static void NAKIGBLGNDE(this KHJFAGMNDBA CNFBJPGPBBJ, [In] FKJDGDHDMEC<OMNMDCGADIH.CIKLDCJLMNP, INAEPGBHNCF> CPKGJOMIPIH, int CJFAMEDFPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DCOBHNIJDOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum HDOGDCPLDCH
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Register
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct HMAOHAJBLDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> DGAIHEKNJDM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		public HMAOHAJBLDE(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> LKAJOANHPNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BNMKPLGDBHI : IEquatable<BNMKPLGDBHI>, NLAOOBBGEHG<BNMKPLGDBHI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public ReadOnlyMemory<byte> EFAGEEFKDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public HHJNEFOBLKN JCIANLFJGBH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D8F0", Offset = "0x1D8C6F0", VA = "0x181D8D8F0")]
		private BNMKPLGDBHI([In] ReadOnlyMemory<byte> JAHCJGGEGHK, HHJNEFOBLKN LJILJPFFIMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D330", Offset = "0x1D8C130", VA = "0x181D8D330")]
		public static BNMKPLGDBHI ANLJLJGGOHL(bool GGGDOMHCMFC)
		{
			return default(BNMKPLGDBHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D600", Offset = "0x1D8C400", VA = "0x181D8D600")]
		public static BNMKPLGDBHI LALLKEDANCB([In] ReadOnlyMemory<byte> JAHCJGGEGHK)
		{
			return default(BNMKPLGDBHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D390", Offset = "0x1D8C190", VA = "0x181D8D390")]
		public static BNMKPLGDBHI EMAONFCGPOL(int PELHPFDKBCB)
		{
			return default(BNMKPLGDBHI);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D530", Offset = "0x1D8C330", VA = "0x181D8D530")]
		public static bool JACCNGOPODK([In] BNMKPLGDBHI EHBONBMIDMA, [In] BNMKPLGDBHI MKAKMHGMJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D3E0", Offset = "0x1D8C1E0", VA = "0x181D8D3E0", Slot = "4")]
		public bool Equals(BNMKPLGDBHI FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D530", Offset = "0x1D8C330", VA = "0x181D8D530")]
		public bool JNFOCAILINO([In] BNMKPLGDBHI FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D450", Offset = "0x1D8C250", VA = "0x181D8D450", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D5A0", Offset = "0x1D8C3A0", VA = "0x181D8D5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D640", Offset = "0x1D8C440", VA = "0x181D8D640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D530", Offset = "0x1D8C330", VA = "0x181D8D530", Slot = "5")]
		private bool GIOCOOMEKGJ([In] BNMKPLGDBHI FPEEGIOMOFF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct AAOLJHBFAJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> NDJILCAAJJN;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		public AAOLJHBFAJF(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly HMAOHAJBLDE IMBJPJMPEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly BNMKPLGDBHI GNLPCDODLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly AAOLJHBFAJF NLHDMBJLIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly HDOGDCPLDCH AAEHLJMIJDF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DC60", Offset = "0x1D8CA60", VA = "0x181D8DC60")]
	private DCOBHNIJDOJ(HMAOHAJBLDE LHLNFAAIBAP, [In] BNMKPLGDBHI DNEOMBJDGDD, AAOLJHBFAJF ACFNOJOHDBH, HDOGDCPLDCH OLFMGNHAIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DB80", Offset = "0x1D8C980", VA = "0x181D8DB80")]
	public static DCOBHNIJDOJ OIEABEFGHNC(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> LKAJOANHPNH)
	{
		return default(DCOBHNIJDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DBD0", Offset = "0x1D8C9D0", VA = "0x181D8DBD0")]
	public static DCOBHNIJDOJ PBFCIOKANIO(bool GGGDOMHCMFC)
	{
		return default(DCOBHNIJDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DAB0", Offset = "0x1D8C8B0", VA = "0x181D8DAB0")]
	public static DCOBHNIJDOJ CIOOKGGGJJO([In] ReadOnlyMemory<byte> JAHCJGGEGHK)
	{
		return default(DCOBHNIJDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DA20", Offset = "0x1D8C820", VA = "0x181D8DA20")]
	public static DCOBHNIJDOJ ACMMCGFJFGG(int PELHPFDKBCB)
	{
		return default(DCOBHNIJDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DB20", Offset = "0x1D8C920", VA = "0x181D8DB20")]
	public static DCOBHNIJDOJ LMEKJFMLHFF(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DOLHIHAINOO)
	{
		return default(DCOBHNIJDOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IFLGPLPHPPD
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0")]
	public static CJHGMOIFGDE LLNMAKKDIPB([In] this DCOBHNIJDOJ CNFBJPGPBBJ)
	{
		return default(CJHGMOIFGDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct CJHGMOIFGDE
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum CDALGDKDPGL
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		OutNode,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Branch
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly CDALGDKDPGL AAEHLJMIJDF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
	private CJHGMOIFGDE(CDALGDKDPGL OLFMGNHAIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0")]
	public static CJHGMOIFGDE OIEABEFGHNC()
	{
		return default(CJHGMOIFGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0")]
	public static CJHGMOIFGDE EGNPHCIEMMH([In] DCOBHNIJDOJ AIFJDDMPMMF)
	{
		return default(CJHGMOIFGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0")]
	public static CJHGMOIFGDE BFHIODCJFNB()
	{
		return default(CJHGMOIFGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB840", VA = "0x1808ACA40")]
	public static CJHGMOIFGDE MJEPDKKLNBM()
	{
		return default(CJHGMOIFGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x89B220", Offset = "0x89A020", VA = "0x18089B220")]
	public static CJHGMOIFGDE DDDMKKBCHLH()
	{
		return default(CJHGMOIFGDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MGIBOMEJMIH<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIGDJMOGOKB<CMMELENHHKO> IJCMLIDPICF(TStateSys JLJCCKNNIPG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CJHGMOIFGDE MFLHIBCIGPG(TStateSys JLJCCKNNIPG, KHJFAGMNDBA JHAHLMIAKAN, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCOBHNIJDOJ CHHICCKNOOO(TStateSys JLJCCKNNIPG, KHJFAGMNDBA JHAHLMIAKAN, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KMFKLEEBBFN(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HIGDJMOGOKB<HJFCJGNOMLH> PNHJEHEAJAP(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB, int BMOJCFBHBND);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MKLBGAPCFDM BIHIBJDKODB(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LCDBDNAONAG(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NMONFMPMGJF(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NDFFLICPAGJ<byte> COEDHNADPEP(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	object JJEHHONEHAH(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<KGOIHNMDLLG> PABKLBOPHNB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OHLMLAAMIIP(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HIGDJMOGOKB<KGOIHNMDLLG> FAGCFAFMHEO(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, HIGDJMOGOKB<HJFCJGNOMLH> DGADLNLIIAJ, int GODKNDIGFNM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "12")]
	int CIADPJEJGGA(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int ENOKMHPILHA(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "14")]
	int OCFIGBDDNCP(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int DKLEKNMHLIL(TStateSys JLJCCKNNIPG, HIGDJMOGOKB<IAFEEIBLHGA> MOJJMHEPCMN, int ENPOKNEMOMH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JOHAIDCGGOB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D90340", Offset = "0x1D8F140", VA = "0x181D90340")]
	public static HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> BEDEJMFINND([In] this KHJFAGMNDBA CNFBJPGPBBJ)
	{
		return default(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D92480", Offset = "0x1D91280", VA = "0x181D92480")]
	private static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> IDKEBNEPCIN(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, int ENPOKNEMOMH, int HMCIMNDCLML)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D93480", Offset = "0x1D92280", VA = "0x181D93480")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> OMKNIBMKMEJ(this KHJFAGMNDBA CNFBJPGPBBJ, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D93400", Offset = "0x1D92200", VA = "0x181D93400")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> OEKJEGCJOCG(this KHJFAGMNDBA CNFBJPGPBBJ, int DDGPJFNNFJK)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D93890", Offset = "0x1D92690", VA = "0x181D93890")]
	private static void PEHBCHAKEKP(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D90D40", Offset = "0x1D8FB40", VA = "0x181D90D40")]
	public static void DGNDDPDDICO(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D90CC0", Offset = "0x1D8FAC0", VA = "0x181D90CC0")]
	private static void DEMPLJKJEAJ(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1D92910", Offset = "0x1D91710", VA = "0x181D92910")]
	private static void JFJHMLBBICD(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x275FBF0", Offset = "0x275E9F0", VA = "0x18275FBF0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP?> NILEOHBMCBC<T, TOpInput, TOpOutput>(this KHJFAGMNDBA CNFBJPGPBBJ, T EHBONBMIDMA, T MKAKMHGMJJL, int PBNNOKPLLEC, IntPtr KAOAFEJOOJA)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x275F890", Offset = "0x275E690", VA = "0x18275F890")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP?> GDPDNAHCKOM<T, TOpInput, TOpOutput>(this KHJFAGMNDBA CNFBJPGPBBJ, T EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL, int PBNNOKPLLEC, IntPtr KAOAFEJOOJA)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x275FB00", Offset = "0x275E900", VA = "0x18275FB00")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP?> MCFIKAEGOHN<TOpInput, TOpOutput>(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL, int PBNNOKPLLEC, IntPtr KAOAFEJOOJA)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1D910B0", Offset = "0x1D8FEB0", VA = "0x181D910B0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EFIEABJHKKP(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, float EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D93050", Offset = "0x1D91E50", VA = "0x181D93050")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MFCGFPGIKBG(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D922F0", Offset = "0x1D910F0", VA = "0x181D922F0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> HNKIDOGJKDO(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D92B00", Offset = "0x1D91900", VA = "0x181D92B00")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> KJBIINKHOMM(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, int EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D90280", Offset = "0x1D8F080", VA = "0x181D90280")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BCGPFBFDGKO(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FFA0", Offset = "0x1D8EDA0", VA = "0x181D8FFA0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> AGIHPDNCCKJ(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D90F20", Offset = "0x1D8FD20", VA = "0x181D90F20")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> ECMMGOIHJCM(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, DCOBHNIJDOJ EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D91690", Offset = "0x1D90490", VA = "0x181D91690")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FLCMMJLDHAL(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, int EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D903A0", Offset = "0x1D8F1A0", VA = "0x181D903A0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BGKINJEEPGD(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D91820", Offset = "0x1D90620", VA = "0x181D91820")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FNLHIPNOCCI(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1D923E0", Offset = "0x1D911E0", VA = "0x181D923E0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> ICCJCACLAPH(this KHJFAGMNDBA CNFBJPGPBBJ, int EHBONBMIDMA, int MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D935A0", Offset = "0x1D923A0", VA = "0x181D935A0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> ONBDBCDEPCD(this KHJFAGMNDBA CNFBJPGPBBJ, int EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D908B0", Offset = "0x1D8F6B0", VA = "0x181D908B0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DAEKDFIPEOE(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D90B30", Offset = "0x1D8F930", VA = "0x181D90B30")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DDICHDIBJBK(this KHJFAGMNDBA CNFBJPGPBBJ, float EHBONBMIDMA, float MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D909A0", Offset = "0x1D8F7A0", VA = "0x181D909A0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DBJNAOIMOBD(this KHJFAGMNDBA CNFBJPGPBBJ, float EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D91430", Offset = "0x1D90230", VA = "0x181D91430")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FDHDNAACLDH(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D92A80", Offset = "0x1D91880", VA = "0x181D92A80")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> KGJHDFKLIHE(this KHJFAGMNDBA CNFBJPGPBBJ, int EHBONBMIDMA, int MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D91CE0", Offset = "0x1D90AE0", VA = "0x181D91CE0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> GKOLFAOOBPA(this KHJFAGMNDBA CNFBJPGPBBJ, int EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1D93660", Offset = "0x1D92460", VA = "0x181D93660")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> OOECHJEKLIL(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D90200", Offset = "0x1D8F000", VA = "0x181D90200")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> ANDFJOFCOJE(this KHJFAGMNDBA CNFBJPGPBBJ, float EHBONBMIDMA, float MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D91610", Offset = "0x1D90410", VA = "0x181D91610")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FHBANGJLIPI(this KHJFAGMNDBA CNFBJPGPBBJ, float EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D925C0", Offset = "0x1D913C0", VA = "0x181D925C0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> IDOPOBEBPHA(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EHBONBMIDMA, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MKAKMHGMJJL)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D91D60", Offset = "0x1D90B60", VA = "0x181D91D60")]
	public static HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> GMOIBPEMIJA(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D91E30", Offset = "0x1D90C30", VA = "0x181D91E30")]
	public static HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> GNPBNOMNFJP(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D912D0", Offset = "0x1D900D0", VA = "0x181D912D0")]
	public static HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> EPNJJAHMFOM(this KHJFAGMNDBA CNFBJPGPBBJ, int NKKIECLCEML)
	{
		return default(HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1D93360", Offset = "0x1D92160", VA = "0x181D93360")]
	public static HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>> NFKEMCDOBOH(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> NKKIECLCEML)
	{
		return default(HIGDJMOGOKB<PHODGCNBLJG<PHODGCNBLJG<JOLDBKFKAKK>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1D93B50", Offset = "0x1D92950", VA = "0x181D93B50")]
	public static void PIJEEEHOHFC(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<CMMELENHHKO> DMOAAOBGDPJ, [In] ReadOnlySpan<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> JGFJPKHAJJF, [In] ReadOnlySpan<int> BILHHJAPKAE, [In] Span<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> LAJEILLPNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1D91F70", Offset = "0x1D90D70", VA = "0x181D91F70")]
	public static void HKIOMIDGGHJ(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<PIDNPLLKFEK> CFCINPOIFJL, [In] ReadOnlySpan<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> JGFJPKHAJJF, [In] ReadOnlySpan<int> BILHHJAPKAE, [In] Span<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> LAJEILLPNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1D92FC0", Offset = "0x1D91DC0", VA = "0x181D92FC0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> LPBIKNEGEMH(this KHJFAGMNDBA CNFBJPGPBBJ, DCOBHNIJDOJ EIFHACOADFO, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1D932D0", Offset = "0x1D920D0", VA = "0x181D932D0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MOODLEAFMPG(this KHJFAGMNDBA CNFBJPGPBBJ, int EIFHACOADFO, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1D90090", Offset = "0x1D8EE90", VA = "0x181D90090")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> AHDKGLCFMPC(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EIFHACOADFO, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1D91350", Offset = "0x1D90150", VA = "0x181D91350")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FBJPAJADJJE(this KHJFAGMNDBA CNFBJPGPBBJ, [In] ReadOnlySpan<byte> EIFHACOADFO, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FE00", Offset = "0x1D8EC00", VA = "0x181D8FE00")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> AFLHDHEIDDE(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EIFHACOADFO, int DDGPJFNNFJK, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D92640", Offset = "0x1D91440", VA = "0x181D92640")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> IJPBGDLFOAP(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, float EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D93110", Offset = "0x1D91F10", VA = "0x181D93110")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MHEPFIMABJC(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D92ED0", Offset = "0x1D91CD0", VA = "0x181D92ED0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> LMDEBMKBDAJ(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D90160", Offset = "0x1D8EF60", VA = "0x181D90160")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> AMMNKLNABPN(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, int EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D90A70", Offset = "0x1D8F870", VA = "0x181D90A70")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DBPIFDFDGLK(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1D92990", Offset = "0x1D91790", VA = "0x181D92990")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> KFMHOGFJOFN(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D90460", Offset = "0x1D8F260", VA = "0x181D90460")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BNBNGCAGABM(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, float EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1D92840", Offset = "0x1D91640", VA = "0x181D92840")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> JADCPICGNBB(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1D93F70", Offset = "0x1D92D70", VA = "0x181D93F70")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> PLEBLCKKNDP(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1D91C40", Offset = "0x1D90A40", VA = "0x181D91C40")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> GHHMLNDHGOC(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, int EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1D92BA0", Offset = "0x1D919A0", VA = "0x181D92BA0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> LDFBKPACIMJ(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1D91520", Offset = "0x1D90320", VA = "0x181D91520")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FEOLILLGGDN(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1D90E80", Offset = "0x1D8FC80", VA = "0x181D90E80")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EBCNGBKOLBB(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, float EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1D91210", Offset = "0x1D90010", VA = "0x181D91210")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EMIJOOHIIOK(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1D91910", Offset = "0x1D90710", VA = "0x181D91910")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FPBLHBDLMFL(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FF00", Offset = "0x1D8ED00", VA = "0x181D8FF00")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> AFPDJCCLNDO(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, int EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1D90500", Offset = "0x1D8F300", VA = "0x181D90500")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BNJLEPJADKE(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D90BD0", Offset = "0x1D8F9D0", VA = "0x181D90BD0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DEEBFJKALBJ(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D91F00", Offset = "0x1D90D00", VA = "0x181D91F00")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> HGKKDCJMCIK(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> NKKIECLCEML)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D926E0", Offset = "0x1D914E0", VA = "0x181D926E0")]
	public static void INHKOKMIFFO(this KHJFAGMNDBA CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1D93ED0", Offset = "0x1D92CD0", VA = "0x181D93ED0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> PKDKNDLLJPF(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, float EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1D937D0", Offset = "0x1D925D0", VA = "0x181D937D0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> PBOKOOLLHBK(this KHJFAGMNDBA CNFBJPGPBBJ, float BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1D91730", Offset = "0x1D90530", VA = "0x181D91730")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FNFJCCICOCO(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1D90810", Offset = "0x1D8F610", VA = "0x181D90810")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> CJGENELGNHO(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, int EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1D91150", Offset = "0x1D8FF50", VA = "0x181D91150")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EJFKJNHGAIL(this KHJFAGMNDBA CNFBJPGPBBJ, int BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1D936E0", Offset = "0x1D924E0", VA = "0x181D936E0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> PBEGLMCGPAP(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> BBHNHEAAOAJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> EDNBFKGKHNN)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D91A00", Offset = "0x1D90800", VA = "0x181D91A00")]
	public static void GDIPPAACBDO(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<CMMELENHHKO> DMOAAOBGDPJ, [In] ReadOnlySpan<(DCOBHNIJDOJ DataBack, int Size)> MOHDLAOCKML, [In] ReadOnlySpan<int> BILHHJAPKAE, [In] Span<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> LAJEILLPNMJ, [In] Span<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> AFEJNBJFJCK, [In] ReadOnlySpan<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>?> OPDHHIPFIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D92C60", Offset = "0x1D91A60", VA = "0x181D92C60")]
	public static void LFCINGBKJGN(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<PIDNPLLKFEK> ANOLKHFMNBM, [In] ReadOnlySpan<(DCOBHNIJDOJ DataBack, int Size)> MOHDLAOCKML, [In] ReadOnlySpan<int> BILHHJAPKAE, [In] Span<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> LAJEILLPNMJ, [In] Span<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>> AFEJNBJFJCK, [In] ReadOnlySpan<HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>?> OPDHHIPFIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D926F0", Offset = "0x1D914F0", VA = "0x181D926F0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> IPBGKEJIOBI(this KHJFAGMNDBA CNFBJPGPBBJ, [In] DCOBHNIJDOJ.BNMKPLGDBHI DNEOMBJDGDD, int DDGPJFNNFJK, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D93A30", Offset = "0x1D92830", VA = "0x181D93A30")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> PFEFBOKIIGL(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> JGBMOKAGIPB, int DDGPJFNNFJK, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D905C0", Offset = "0x1D8F3C0", VA = "0x181D905C0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> CDHNNHPPIPC(this KHJFAGMNDBA CNFBJPGPBBJ, [In] DCOBHNIJDOJ ADINJHHDHPM, int DDGPJFNNFJK, [Optional] HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? IDPPHHMPMLO)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x275FD70", Offset = "0x275EB70", VA = "0x18275FD70")]
	private static void OGHBHEGOMNM<TStateSys, TDeps>(this KHJFAGMNDBA CNFBJPGPBBJ, TStateSys JLJCCKNNIPG, TDeps DNHMNAAINOD) where TStateSys : notnull where TDeps : notnull, MGIBOMEJMIH<TStateSys>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x275F790", Offset = "0x275E590", VA = "0x18275F790")]
	public static DCOBHNIJDOJ AFGJKDMHGGI<TStateSys, TDeps>(this KHJFAGMNDBA CNFBJPGPBBJ, TStateSys JLJCCKNNIPG, TDeps DNHMNAAINOD) where TStateSys : notnull where TDeps : notnull, MGIBOMEJMIH<TStateSys>
	{
		return default(DCOBHNIJDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x275FAE0", Offset = "0x275E8E0", VA = "0x18275FAE0")]
	public static CJHGMOIFGDE GPMEALLKDEA<TStateSys, TDeps>(this KHJFAGMNDBA CNFBJPGPBBJ, TStateSys JLJCCKNNIPG, TDeps DNHMNAAINOD) where TStateSys : notnull where TDeps : notnull, MGIBOMEJMIH<TStateSys>
	{
		return default(CJHGMOIFGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D931D0", Offset = "0x1D91FD0", VA = "0x181D931D0")]
	private static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MJHLHDKCGDC(this KHJFAGMNDBA CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>? JGBMOKAGIPB, int DDGPJFNNFJK)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HGCPHFHLNGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> PCPFNHJJKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> OOJMIBGOBBB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA58C60", Offset = "0xA57A60", VA = "0x180A58C60")]
	public HGCPHFHLNGI(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> DNNFFLHIBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F540", Offset = "0x1D8E340", VA = "0x181D8F540")]
	public static HGCPHFHLNGI KJKFMOENPNA(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL)
	{
		return default(HGCPHFHLNGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OMGCGDLOJKF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class FNLGGLFGDIK : HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct FPDFDHDLDCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> BPAPAJMGFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int CCEAOHGDFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int EPHFPJNELPL;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x18D98D0", Offset = "0x18D86D0", VA = "0x1818D98D0")]
		public FPDFDHDLDCK(HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, int ENPOKNEMOMH, int HMCIMNDCLML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class HKAJANFAGEN : HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct IJIHCHBIIFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int CCEAOHGDFHD;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		public IJIHCHBIIFM(int ENPOKNEMOMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class MMMPBOGDGGO : HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct CEGNOBADAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> BPAPAJMGFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int CCEAOHGDFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int EPHFPJNELPL;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x18D98D0", Offset = "0x18D86D0", VA = "0x1818D98D0")]
		public CEGNOBADAPH(HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, int ENPOKNEMOMH, int HMCIMNDCLML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum APEGELIOPMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class MOMFOFLMPNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct MFCHIMGMFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public HGCPHFHLNGI PNDJPACCDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public APEGELIOPMD MABMHLENLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HIGDJMOGOKB<HDNNEINAAJN> IECNBABJKHP;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D94AA0", Offset = "0x1D938A0", VA = "0x181D94AA0")]
		private MFCHIMGMFLF([In] HGCPHFHLNGI HLPHHKINKEB, APEGELIOPMD EJKIJBMDFPJ, HIGDJMOGOKB<HDNNEINAAJN> IFHNDCFJHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D94A80", Offset = "0x1D93880", VA = "0x181D94A80")]
		public static MFCHIMGMFLF KJKFMOENPNA(HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL, APEGELIOPMD EJKIJBMDFPJ, HIGDJMOGOKB<HDNNEINAAJN> IFHNDCFJHDF)
		{
			return default(MFCHIMGMFLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class ODBPKDAIOMB : HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LHCAKBCEMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int EPHFPJNELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public bool JNOHHOPBAKI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xD7FE40", Offset = "0xD7EC40", VA = "0x180D7FE40")]
		public LHCAKBCEMNH(int HMCIMNDCLML, bool EMNADIMFLJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class JOPCPFHBLEL : HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct IPJMNPKOKIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int CCEAOHGDFHD;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		public IPJMNPKOKIM(int ENPOKNEMOMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class JDOOGPKBBNE : HDNNEINAAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct GONNCNGKHCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int EPHFPJNELPL;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x898350", Offset = "0x897150", VA = "0x180898350")]
		public GONNCNGKHCI(int HMCIMNDCLML)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal BOCFOHCFNAL<MOMFOFLMPNP, MFCHIMGMFLF> BGHGJOGHNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal BOCFOHCFNAL<JDOOGPKBBNE, GONNCNGKHCI> KEJHNFHCLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal BOCFOHCFNAL<ODBPKDAIOMB, LHCAKBCEMNH> OMBFDBIDFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal BOCFOHCFNAL<FNLGGLFGDIK, FPDFDHDLDCK> MJBEELFFIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal BOCFOHCFNAL<MMMPBOGDGGO, CEGNOBADAPH> PAKJPEMCBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal BOCFOHCFNAL<JOPCPFHBLEL, IPJMNPKOKIM> BFLALLMFLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal BOCFOHCFNAL<HKAJANFAGEN, IJIHCHBIIFM> FJEDDBMBGKO;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1D94E30", Offset = "0x1D93C30", VA = "0x181D94E30")]
	private OMGCGDLOJKF([In] BOCFOHCFNAL<MOMFOFLMPNP, MFCHIMGMFLF> BBGGHKHBHAE, [In] BOCFOHCFNAL<JDOOGPKBBNE, GONNCNGKHCI> FLACPEGKEPN, [In] BOCFOHCFNAL<ODBPKDAIOMB, LHCAKBCEMNH> LABJKPBBIDO, [In] BOCFOHCFNAL<FNLGGLFGDIK, FPDFDHDLDCK> DPDMPOMNPMH, [In] BOCFOHCFNAL<MMMPBOGDGGO, CEGNOBADAPH> FOAJBKAHEKK, [In] BOCFOHCFNAL<JOPCPFHBLEL, IPJMNPKOKIM> GEBLNLANNCM, [In] BOCFOHCFNAL<HKAJANFAGEN, IJIHCHBIIFM> NBICBJPPIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D94B80", Offset = "0x1D93980", VA = "0x181D94B80")]
	public static OMGCGDLOJKF KJKFMOENPNA()
	{
		return default(OMGCGDLOJKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FHALNNPKHJO
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static BOCFOHCFNAL<OMGCGDLOJKF.MOMFOFLMPNP, OMGCGDLOJKF.MFCHIMGMFLF> PNICHIBFMGL([In] this OMGCGDLOJKF CNFBJPGPBBJ)
	{
		return default(BOCFOHCFNAL<OMGCGDLOJKF.MOMFOFLMPNP, OMGCGDLOJKF.MFCHIMGMFLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1BCF260", Offset = "0x1BCE060", VA = "0x181BCF260")]
	public static BOCFOHCFNAL<OMGCGDLOJKF.ODBPKDAIOMB, OMGCGDLOJKF.LHCAKBCEMNH> BOBCBOFDMMM([In] this OMGCGDLOJKF CNFBJPGPBBJ)
	{
		return default(BOCFOHCFNAL<OMGCGDLOJKF.ODBPKDAIOMB, OMGCGDLOJKF.LHCAKBCEMNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DDF0", Offset = "0x1D8CBF0", VA = "0x181D8DDF0")]
	public static void ECEAPGIDAKG(this OMGCGDLOJKF CNFBJPGPBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E130", Offset = "0x1D8CF30", VA = "0x181D8E130")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> OEKJEGCJOCG(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL, int HMCIMNDCLML)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E040", Offset = "0x1D8CE40", VA = "0x181D8E040")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> NPCAABBEHDJ(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL, int HMCIMNDCLML, bool EMNADIMFLJJ)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E2C0", Offset = "0x1D8D0C0", VA = "0x181D8E2C0")]
	public static void PEHBCHAKEKP(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DEE0", Offset = "0x1D8CCE0", VA = "0x181D8DEE0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> FANABBNNMKM(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL, HIGDJMOGOKB<OMNMDCGADIH.CIKLDCJLMNP> MFAOHCFGLFJ, int ENPOKNEMOMH, int HMCIMNDCLML)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E1F0", Offset = "0x1D8CFF0", VA = "0x181D8E1F0")]
	public static HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> OMKNIBMKMEJ(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> MPIBCDHHKEL, int ENPOKNEMOMH)
	{
		return default(HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DCB0", Offset = "0x1D8CAB0", VA = "0x181D8DCB0")]
	public static void DGNDDPDDICO(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> MADAAOBJBLA, int ENPOKNEMOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DFD0", Offset = "0x1D8CDD0", VA = "0x181D8DFD0")]
	public static void MCIEBKILCLC(this OMGCGDLOJKF CNFBJPGPBBJ, HIGDJMOGOKB<OMGCGDLOJKF.MOMFOFLMPNP> DGIBOINMLED, HIGDJMOGOKB<PHODGCNBLJG<JOLDBKFKAKK>> CLCOJGBDGIH)
	{
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
