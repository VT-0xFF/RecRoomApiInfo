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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B71A80", Offset = "0x2B70480", VA = "0x182B71A80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JPLEIMJECLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> DEMNJDCDLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MMNMLIHNLBN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
	public JPLEIMJECLM(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> FKEHPJNDECK, int JBCPGNDLJHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BPPCBEDKILA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GPMBDAIJGDE : HAOHDNHBANL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BCGKHDIDNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly CEAGJEFPBKJ<byte> KCCMIEENPIG;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B08C60", Offset = "0x2B07660", VA = "0x182B08C60")]
		public BCGKHDIDNHB(CEAGJEFPBKJ<byte> BNICMFHPCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B67890", Offset = "0x2B66290", VA = "0x182B67890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ACCHPNLEJMK : HAOHDNHBANL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MJIOBBEJFHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> HIOMJNKNBJD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public MJIOBBEJFHJ(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> LNLBKGHMJJG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DOJBLHGPLDA
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
	public sealed class LJNPOCDPMML
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class HAOHDNHBANL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LFEHKKKMBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DOJBLHGPLDA JNCDMBCPJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly HOHDPLDONAJ<HAOHDNHBANL> LCALFMDBJCN;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		public LFEHKKKMBPL(DOJBLHGPLDA LALOCMCOIIC, HOHDPLDONAJ<HAOHDNHBANL> FJEIANNLOIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class LFFPDFGBAAN : HAOHDNHBANL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct BGLDDFNAMBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FJKMHJDDOOD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public BGLDDFNAMBK(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class NDMFGDHEOLD : HAOHDNHBANL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct BNNOPNFGOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly OMBMBLOABPD KAHICKHLHEA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public BNNOPNFGOEK(OMBMBLOABPD CBLLBCKKHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B67980", Offset = "0x2B66380", VA = "0x182B67980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal MIJPGGOFIBD<LJNPOCDPMML, LFEHKKKMBPL> GIBIMKGFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal MIJPGGOFIBD<GPMBDAIJGDE, BCGKHDIDNHB> PEFPOAHODGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal MIJPGGOFIBD<ACCHPNLEJMK, MJIOBBEJFHJ> KIHPAEFJMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MIJPGGOFIBD<LFFPDFGBAAN, BGLDDFNAMBK> IFLACFAMCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal MIJPGGOFIBD<NDMFGDHEOLD, BNNOPNFGOEK> ABLOCNAIILM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B67AE0", Offset = "0x2B664E0", VA = "0x182B67AE0")]
	private BPPCBEDKILA([In] MIJPGGOFIBD<LJNPOCDPMML, LFEHKKKMBPL> LHPBEKCGELI, [In] MIJPGGOFIBD<GPMBDAIJGDE, BCGKHDIDNHB> IOOBBNCBIIG, [In] MIJPGGOFIBD<ACCHPNLEJMK, MJIOBBEJFHJ> MFKKEHLPOEI, [In] MIJPGGOFIBD<LFFPDFGBAAN, BGLDDFNAMBK> KPLLDDLAKJO, [In] MIJPGGOFIBD<NDMFGDHEOLD, BNNOPNFGOEK> ENBLEHMHEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B679A0", Offset = "0x2B663A0", VA = "0x182B679A0")]
	public static BPPCBEDKILA KDBDJPAJKDJ()
	{
		return default(BPPCBEDKILA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ECAODLPKFJF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B68010", Offset = "0x2B66A10", VA = "0x182B68010")]
	public static void PIIFCIMJIKL(this BPPCBEDKILA DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EHBOJIHNIOD
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
public struct GBMELKDHDGE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class LMGPKGIJGNM : MNPBJAFBPEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct DBCENKGEBLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> EPNJDPABCCA;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public DBCENKGEBLO(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HOGNGAHMHLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum EJOOBJOABDA
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
	public sealed class EAGDLHLEGII
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class MNPBJAFBPEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct PKAFFIGIBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly EJOOBJOABDA JNCDMBCPJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly HOHDPLDONAJ<MNPBJAFBPEI> LCALFMDBJCN;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		public PKAFFIGIBNL(EJOOBJOABDA LALOCMCOIIC, HOHDPLDONAJ<MNPBJAFBPEI> FJEIANNLOIA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MIJPGGOFIBD<EAGDLHLEGII, PKAFFIGIBNL> GIBIMKGFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal MIJPGGOFIBD<LMGPKGIJGNM, DBCENKGEBLO> BFOJLJOONOM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A690", Offset = "0x2B69090", VA = "0x182B6A690")]
	private GBMELKDHDGE([In] MIJPGGOFIBD<EAGDLHLEGII, PKAFFIGIBNL> LHPBEKCGELI, [In] MIJPGGOFIBD<LMGPKGIJGNM, DBCENKGEBLO> GDAAIBFAHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A600", Offset = "0x2B69000", VA = "0x182B6A600")]
	public static GBMELKDHDGE KDBDJPAJKDJ()
	{
		return default(GBMELKDHDGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GOPHOEIOGLN
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A910", Offset = "0x2B69310", VA = "0x182B6A910")]
	public static void PIIFCIMJIKL(this GBMELKDHDGE DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HBPLCLOGJDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public DBIBICKBIIJ<int> FHJACIAOPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public DBIBICKBIIJ<int> OCKBKNGJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GOFJOLEMNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LJJLFCBGPIM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AA10", Offset = "0x2B69410", VA = "0x182B6AA10")]
	private HBPLCLOGJDP([In] DBIBICKBIIJ<int> JNCHEHLIHHP, [In] DBIBICKBIIJ<int> PJBGJMCOHIA, int FLKLLCILIJA, int DOFBCIEOKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A970", Offset = "0x2B69370", VA = "0x182B6A970")]
	public static HBPLCLOGJDP KDBDJPAJKDJ()
	{
		return default(HBPLCLOGJDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OMOJAFDJAOO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B71E70", Offset = "0x2B70870", VA = "0x182B71E70")]
	public static void PIIFCIMJIKL(this HBPLCLOGJDP DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PKKOLHIOKHB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum EGEFGNLKAOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class AFLHIENAAHM : EFGCFNAGCDM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct PDLMEEJNDAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly HOHDPLDONAJ<HFCMDNPMINN> OCGEEODAONH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public PDLMEEJNDAL(HOHDPLDONAJ<HFCMDNPMINN> GGPGNMHJADH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class IOFPJIONIJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class EFGCFNAGCDM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct GNFHLPGNJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly EGEFGNLKAOC JNCDMBCPJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly HOHDPLDONAJ<EFGCFNAGCDM> LCALFMDBJCN;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		private GNFHLPGNJOF(EGEFGNLKAOC LALOCMCOIIC, HOHDPLDONAJ<EFGCFNAGCDM> FJEIANNLOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A900", Offset = "0x2B69300", VA = "0x182B6A900")]
		public static GNFHLPGNJOF KDBDJPAJKDJ(EGEFGNLKAOC LALOCMCOIIC, HOHDPLDONAJ<EFGCFNAGCDM> FJEIANNLOIA)
		{
			return default(GNFHLPGNJOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class EMIDGGIDDFF : EFGCFNAGCDM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct FKBIMIACEGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly HOHDPLDONAJ<HFCMDNPMINN> OCGEEODAONH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public FKBIMIACEGB(HOHDPLDONAJ<HFCMDNPMINN> GGPGNMHJADH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class HFCMDNPMINN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct JLGINDMDGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DBIBICKBIIJ<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> EDPLDEHIPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DBIBICKBIIJ<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> NLGOLBKFKIJ;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A690", Offset = "0x2B69090", VA = "0x182B6A690")]
		private JLGINDMDGAL([In] DBIBICKBIIJ<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> DNEDADEPKEO, [In] DBIBICKBIIJ<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> CGBCEAGNJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AF50", Offset = "0x2B69950", VA = "0x182B6AF50")]
		public static JLGINDMDGAL KDBDJPAJKDJ()
		{
			return default(JLGINDMDGAL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal MIJPGGOFIBD<IOFPJIONIJB, GNFHLPGNJOF> GIBIMKGFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal MIJPGGOFIBD<EMIDGGIDDFF, FKBIMIACEGB> ALKEHIILHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal MIJPGGOFIBD<AFLHIENAAHM, PDLMEEJNDAL> ENCPDMCLFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal DBIBICKBIIJ<(HOHDPLDONAJ<IOFPJIONIJB> CallId, HOHDPLDONAJ<HFCMDNPMINN> IOId)> LPLHLEIDGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal MIJPGGOFIBD<HFCMDNPMINN, JLGINDMDGAL> CIFOEKCPLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal LGCELBLJKFI<HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FPKNFFMLLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal LGCELBLJKFI<HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> BBIEOGGKGHP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B722E0", Offset = "0x2B70CE0", VA = "0x182B722E0")]
	private PKKOLHIOKHB([In] MIJPGGOFIBD<IOFPJIONIJB, GNFHLPGNJOF> LHPBEKCGELI, [In] MIJPGGOFIBD<EMIDGGIDDFF, FKBIMIACEGB> PJABMDJLBEE, [In] MIJPGGOFIBD<AFLHIENAAHM, PDLMEEJNDAL> CDFACDBKBPE, [In] DBIBICKBIIJ<(HOHDPLDONAJ<IOFPJIONIJB> CallId, HOHDPLDONAJ<HFCMDNPMINN> IOId)> DFILMEPDPKK, [In] MIJPGGOFIBD<HFCMDNPMINN, JLGINDMDGAL> LNANPOANEKA, [In] LGCELBLJKFI<HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> BNMPHCHCMED, [In] LGCELBLJKFI<HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> KFONINGCPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B72140", Offset = "0x2B70B40", VA = "0x182B72140")]
	public static PKKOLHIOKHB KDBDJPAJKDJ()
	{
		return default(PKKOLHIOKHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HIJFDEFHMIM
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AD10", Offset = "0x2B69710", VA = "0x182B6AD10")]
	private static void PIIFCIMJIKL(this PKKOLHIOKHB.JLGINDMDGAL DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AB00", Offset = "0x2B69500", VA = "0x182B6AB00")]
	public static void PIIFCIMJIKL(this PKKOLHIOKHB DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KMCDDFKPJJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public DBIBICKBIIJ<byte> APKICLKJBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal PKKOLHIOKHB PELFMAFOCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal DCHEIPMCCIE CGIIEOGOCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> BBNDMNCAMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal BPPCBEDKILA INGOKGOLOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal GBMELKDHDGE JOKHMACHLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal LGCELBLJKFI<DIHEINFKHHL, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>?> HLCCFDMAPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal DBIBICKBIIJ<HOHDPLDONAJ<DIHEINFKHHL>> ECCDPEGCPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> MIGABHILKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> LKFAGJMCDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> EFHIJIEFDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal PCCPGCBMIIJ KEJEICBICGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal EAJNLEDDPMI CFCNIOLIEEH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B70F30", Offset = "0x2B6F930", VA = "0x182B70F30")]
	private KMCDDFKPJJK([In] DBIBICKBIIJ<byte> GAPEAGPINHO, [In] PKKOLHIOKHB PELLFIGOHJO, [In] DCHEIPMCCIE PNINDOBGDAJ, [In] BPPCBEDKILA EEALGCNKFAD, [In] GBMELKDHDGE GINIFDPDAPJ, [In] LGCELBLJKFI<DIHEINFKHHL, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>?> FKBKOJFCJCP, [In] DBIBICKBIIJ<HOHDPLDONAJ<DIHEINFKHHL>> LCEGJJBACFD, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> KBLFJHKFDOD, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> GCLJNAAEPDB, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> KLFMOCFCELK, [In] PCCPGCBMIIJ LAFCJHAGDNO, [In] EAJNLEDDPMI NKEPLDBFCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B70580", Offset = "0x2B6EF80", VA = "0x182B70580")]
	public static KMCDDFKPJJK KDBDJPAJKDJ()
	{
		return default(KMCDDFKPJJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FGLLHCKJLDA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct ILJBLCCHEDO : BJDOKBKBAFD<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>, LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AEA0", Offset = "0x2B698A0", VA = "0x182B6AEA0")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AF20", Offset = "0x2B69920", VA = "0x182B6AF20", Slot = "4")]
		public HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> OJNNLKCJPPH(int KABGMIEBEFC)
		{
			return default(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		public bool POCIKIMAIJL(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "5")]
		private bool DAFDKGFAIEC(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AEA0", Offset = "0x2B698A0", VA = "0x182B6AEA0", Slot = "6")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> FPNNLJJBCPF(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct MGOBGGDKFFK : MLICLJFBMMA<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>, LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B71470", Offset = "0x2B6FE70", VA = "0x182B71470")]
		public DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>> CGLHAEBMBDC(int DOLEDAOOKMC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B714E0", Offset = "0x2B6FEE0", VA = "0x182B714E0")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B713E0", Offset = "0x2B6FDE0", VA = "0x182B713E0", Slot = "6")]
		public void AABCPBKIMBA(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B71470", Offset = "0x2B6FE70", VA = "0x182B71470", Slot = "4")]
		private DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>> AGNLGGOOOGK(int DOLEDAOOKMC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B714E0", Offset = "0x2B6FEE0", VA = "0x182B714E0", Slot = "5")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JDONHINMGHC(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct EFFLAKNELOI : BJDOKBKBAFD<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>, LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B680C0", Offset = "0x2B66AC0", VA = "0x182B680C0")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B68140", Offset = "0x2B66B40", VA = "0x182B68140", Slot = "4")]
		public HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> OJNNLKCJPPH(int KABGMIEBEFC)
		{
			return default(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		public bool POCIKIMAIJL(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "5")]
		private bool DPHLBKBDCJE(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B680C0", Offset = "0x2B66AC0", VA = "0x182B680C0", Slot = "6")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> HMAPFHPBPLO(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OFFILGFCGCH : MLICLJFBMMA<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>, LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B71BA0", Offset = "0x2B705A0", VA = "0x182B71BA0")]
		public DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>> CGLHAEBMBDC(int DOLEDAOOKMC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C10", Offset = "0x2B70610", VA = "0x182B71C10")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B71B10", Offset = "0x2B70510", VA = "0x182B71B10", Slot = "6")]
		public void AABCPBKIMBA(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B71BA0", Offset = "0x2B705A0", VA = "0x182B71BA0", Slot = "4")]
		private DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>> BOAPEJFDHCH(int DOLEDAOOKMC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C10", Offset = "0x2B70610", VA = "0x182B71C10", Slot = "5")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> IANBLAMEPMN(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> KABGMIEBEFC, [In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct KNKPILJBBLD : BJDOKBKBAFD<HOHDPLDONAJ<MGHIDEJBICM>, LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B712F0", Offset = "0x2B6FCF0", VA = "0x182B712F0")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B713A0", Offset = "0x2B6FDA0", VA = "0x182B713A0", Slot = "4")]
		public HOHDPLDONAJ<MGHIDEJBICM> OJNNLKCJPPH(int KABGMIEBEFC)
		{
			return default(HOHDPLDONAJ<MGHIDEJBICM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B71290", Offset = "0x2B6FC90", VA = "0x182B71290")]
		public bool POCIKIMAIJL(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B71290", Offset = "0x2B6FC90", VA = "0x182B71290", Slot = "5")]
		private bool HIKLPKEEMKP(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B71390", Offset = "0x2B6FD90", VA = "0x182B71390", Slot = "6")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> LMOALNNGDEF(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct NDKPFKHCNNI : MLICLJFBMMA<HOHDPLDONAJ<MGHIDEJBICM>, LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B71620", Offset = "0x2B70020", VA = "0x182B71620")]
		public DBIBICKBIIJ<HOHDPLDONAJ<MGHIDEJBICM>> CGLHAEBMBDC(int DOLEDAOOKMC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<HOHDPLDONAJ<MGHIDEJBICM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B71690", Offset = "0x2B70090", VA = "0x182B71690")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B71560", Offset = "0x2B6FF60", VA = "0x182B71560", Slot = "6")]
		public void AABCPBKIMBA(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B71620", Offset = "0x2B70020", VA = "0x182B71620", Slot = "4")]
		private DBIBICKBIIJ<HOHDPLDONAJ<MGHIDEJBICM>> BDOGILNEGIC(int DOLEDAOOKMC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<HOHDPLDONAJ<MGHIDEJBICM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71610", Offset = "0x2B70010", VA = "0x182B71610", Slot = "5")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> BAEEGHEOPIN(HOHDPLDONAJ<MGHIDEJBICM> KABGMIEBEFC, [In] LGCELBLJKFI<MGHIDEJBICM, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>?> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct HFBNMCBJGHO : BJDOKBKBAFD<int, DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AA70", Offset = "0x2B69470", VA = "0x182B6AA70")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xBC2490", Offset = "0xBC0E90", VA = "0x180BC2490", Slot = "4")]
		public int OJNNLKCJPPH(int KABGMIEBEFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		public bool POCIKIMAIJL(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "5")]
		private bool HMMJPLEOCGE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AAF0", Offset = "0x2B694F0", VA = "0x182B6AAF0", Slot = "6")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> LMKKLOFLDLN(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct OJFNDGFJFGB : MLICLJFBMMA<int, DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D70", Offset = "0x2B70770", VA = "0x182B71D70")]
		public DBIBICKBIIJ<int> CGLHAEBMBDC(int DOLEDAOOKMC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B71DF0", Offset = "0x2B707F0", VA = "0x182B71DF0")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B71C90", Offset = "0x2B70690", VA = "0x182B71C90", Slot = "6")]
		public void AABCPBKIMBA(int KABGMIEBEFC, DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B71D70", Offset = "0x2B70770", VA = "0x182B71D70", Slot = "4")]
		private DBIBICKBIIJ<int> NLLMNGNGJLK(int DOLEDAOOKMC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B71DE0", Offset = "0x2B707E0", VA = "0x182B71DE0", Slot = "5")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> CNIMMKPLCHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> VariableId, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<EBPBDIDCDHC>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct BNFANBLACKL : BJDOKBKBAFD<int, DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B67900", Offset = "0x2B66300", VA = "0x182B67900")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xBC2490", Offset = "0xBC0E90", VA = "0x180BC2490", Slot = "4")]
		public int OJNNLKCJPPH(int KABGMIEBEFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		public bool POCIKIMAIJL(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "5")]
		private bool LIMKICIGBNK(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B67900", Offset = "0x2B66300", VA = "0x182B67900", Slot = "6")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> GOBGGIJLHLC(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct KEGKIPMABOC : MLICLJFBMMA<int, DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B70510", Offset = "0x2B6EF10", VA = "0x182B70510")]
		public DBIBICKBIIJ<int> CGLHAEBMBDC(int DOLEDAOOKMC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B70490", Offset = "0x2B6EE90", VA = "0x182B70490")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B703B0", Offset = "0x2B6EDB0", VA = "0x182B703B0", Slot = "6")]
		public void AABCPBKIMBA(int KABGMIEBEFC, DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B70510", Offset = "0x2B6EF10", VA = "0x182B70510", Slot = "4")]
		private DBIBICKBIIJ<int> HKDPHCGCBKM(int DOLEDAOOKMC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B70490", Offset = "0x2B6EE90", VA = "0x182B70490", Slot = "5")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> BAJHCONLBJE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct FKIJLOPEOFE : BJDOKBKBAFD<int, DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A580", Offset = "0x2B68F80", VA = "0x182B6A580")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBC2490", Offset = "0xBC0E90", VA = "0x180BC2490", Slot = "4")]
		public int OJNNLKCJPPH(int KABGMIEBEFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240")]
		public bool POCIKIMAIJL(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "5")]
		private bool LIMKICIGBNK(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A570", Offset = "0x2B68F70", VA = "0x182B6A570", Slot = "6")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> GOBGGIJLHLC(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct NHBNJGOLAKI : MLICLJFBMMA<int, DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B71830", Offset = "0x2B70230", VA = "0x182B71830")]
		public DBIBICKBIIJ<int> CGLHAEBMBDC(int DOLEDAOOKMC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B718A0", Offset = "0x2B702A0", VA = "0x182B718A0")]
		public HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B71740", Offset = "0x2B70140", VA = "0x182B71740", Slot = "6")]
		public void AABCPBKIMBA(int KABGMIEBEFC, DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B71830", Offset = "0x2B70230", VA = "0x182B71830", Slot = "4")]
		private DBIBICKBIIJ<int> HKDPHCGCBKM(int DOLEDAOOKMC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(DBIBICKBIIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B71820", Offset = "0x2B70220", VA = "0x182B71820", Slot = "5")]
		private HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> BAJHCONLBJE(int KABGMIEBEFC, [In] DBIBICKBIIJ<(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> Target, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> ByteCodeWriteLocation)> FDOLNIMJMJM)
		{
			return default(HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct OELCBGENFOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HHNCAIIHNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool NJJEBMKDILM;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x21DAD10", Offset = "0x21D9710", VA = "0x1821DAD10")]
		public OELCBGENFOH(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI, bool PAGOMDKFKIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2B71B00", Offset = "0x2B70500", VA = "0x182B71B00")]
		public void ODNAGOAKDMJ([Out] HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI, [Out] bool PAGOMDKFKIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct ECAJFHJBFIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly HOHDPLDONAJ<MGHIDEJBICM> HMJINFNEOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HHNCAIIHNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool NJJEBMKDILM;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2B68000", Offset = "0x2B66A00", VA = "0x182B68000")]
		public ECAJFHJBFIF(HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI, bool PAGOMDKFKIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2B67FF0", Offset = "0x2B669F0", VA = "0x182B67FF0")]
		public void ODNAGOAKDMJ([Out] HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI, [Out] bool PAGOMDKFKIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2B67FD0", Offset = "0x2B669D0", VA = "0x182B67FD0")]
		public void ODNAGOAKDMJ([Out] HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI, [Out] HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB, [Out] bool PAGOMDKFKIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NECKCNGEMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly HOHDPLDONAJ<MGHIDEJBICM> HMJINFNEOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HHNCAIIHNIC;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		public NECKCNGEMAJ(HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B71730", Offset = "0x2B70130", VA = "0x182B71730")]
		public void ODNAGOAKDMJ([Out] HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI, [Out] HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A170", Offset = "0x2B68B70", VA = "0x182B6A170")]
	public static void PIIFCIMJIKL(this KMCDDFKPJJK DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B69200", Offset = "0x2B67C00", VA = "0x182B69200")]
	public static void HOGELABLLBF(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> AKJEPJLKPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A060", Offset = "0x2B68A60", VA = "0x182B6A060")]
	public static void OFPJDABMFMM(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> AKJEPJLKPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B699B0", Offset = "0x2B683B0", VA = "0x182B699B0")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>? KKNKLDKIMBK([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B68260", Offset = "0x2B66C60", VA = "0x182B68260")]
	public static HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> AGEPDPMLIGD([In] this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B69040", Offset = "0x2B67A40", VA = "0x182B69040")]
	private static void HJONJHBPNAH(this KMCDDFKPJJK DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B69AF0", Offset = "0x2B684F0", VA = "0x182B69AF0")]
	private static HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>? MDDJDNCDHGC([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B68890", Offset = "0x2B67290", VA = "0x182B68890")]
	public static void DJLDDHIFHLI(this KMCDDFKPJJK DKGBCFDLMOI, [In] DBIBICKBIIJ<JPLEIMJECLM> KJPLFMNIFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B68170", Offset = "0x2B66B70", VA = "0x182B68170")]
	public static BPPCBEDKILA.DOJBLHGPLDA AFJMPCABIID([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
	{
		return default(BPPCBEDKILA.DOJBLHGPLDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B69F60", Offset = "0x2B68960", VA = "0x182B69F60")]
	public static CEAGJEFPBKJ<byte> NHIPIFJCDHK([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
	{
		return default(CEAGJEFPBKJ<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B69A40", Offset = "0x2B68440", VA = "0x182B69A40")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> MCNJHHKKKOP([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B69EB0", Offset = "0x2B688B0", VA = "0x182B69EB0")]
	public static OMBMBLOABPD MPHNHHGKAIC([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
	{
		return default(OMBMBLOABPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CA90", Offset = "0x3D6B490", VA = "0x183D6CA90")]
	private static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> KNACNMMBEGB<TMJoin>(this KMCDDFKPJJK DKGBCFDLMOI, BPPCBEDKILA.DOJBLHGPLDA LALOCMCOIIC, HOHDPLDONAJ<TMJoin> FJEIANNLOIA) where TMJoin : BPPCBEDKILA.HAOHDNHBANL
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B692F0", Offset = "0x2B67CF0", VA = "0x182B692F0")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> IOMHDIIGMPK(this KMCDDFKPJJK DKGBCFDLMOI, bool KGPKMEPIHNG)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B68800", Offset = "0x2B67200", VA = "0x182B68800")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> CLDMMANNINB(this KMCDDFKPJJK DKGBCFDLMOI, CEAGJEFPBKJ<byte> BNICMFHPCJC)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B695C0", Offset = "0x2B67FC0", VA = "0x182B695C0")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> JFNGNMMAAJC(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> LNLBKGHMJJG)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B68F70", Offset = "0x2B67970", VA = "0x182B68F70")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HHFJHIKJGLC(this KMCDDFKPJJK DKGBCFDLMOI, int KCGAKJDEOND)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B68780", Offset = "0x2B67180", VA = "0x182B68780")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> BPGKCLFHDAE(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AE50", Offset = "0x3D69850", VA = "0x183D6AE50")]
	private static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> AJGLCLMCBCK<TMJoin>(this KMCDDFKPJJK DKGBCFDLMOI, GBMELKDHDGE.EJOOBJOABDA LALOCMCOIIC, HOHDPLDONAJ<TMJoin> FJEIANNLOIA) where TMJoin : GBMELKDHDGE.MNPBJAFBPEI
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A130", Offset = "0x2B68B30", VA = "0x182B6A130")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> PFLAGGEADHP(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B68A40", Offset = "0x2B67440", VA = "0x182B68A40")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> ECNNACBDIHN(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B68AE0", Offset = "0x2B674E0", VA = "0x182B68AE0")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> GEBEGECPJBH(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HOGNGAHMHLM)
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A010", Offset = "0x2B68A10", VA = "0x182B6A010")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> NLHEPAMMNPJ(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B68A90", Offset = "0x2B67490", VA = "0x182B68A90")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> EDABOLIAJOB(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B69B80", Offset = "0x2B68580", VA = "0x182B69B80")]
	public static PKKOLHIOKHB.EGEFGNLKAOC MFOHBBAELJI([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> EEOGADADFMK)
	{
		return default(PKKOLHIOKHB.EGEFGNLKAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B68A00", Offset = "0x2B67400", VA = "0x182B68A00")]
	public static DPBDBKAMFJF<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>, CGCHJGLECAK<PKKOLHIOKHB.HFCMDNPMINN>> DPLAAPDNMFD([In] this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(DPBDBKAMFJF<HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>, CGCHJGLECAK<PKKOLHIOKHB.HFCMDNPMINN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B683F0", Offset = "0x2B66DF0", VA = "0x182B683F0")]
	public static HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> AJHMMCGAGNP([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> EEOGADADFMK)
	{
		return default(HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B68E60", Offset = "0x2B67860", VA = "0x182B68E60")]
	public static PKKOLHIOKHB.JLGINDMDGAL HEEMIMJFJBD([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> GGPGNMHJADH)
	{
		return default(PKKOLHIOKHB.JLGINDMDGAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B68BF0", Offset = "0x2B675F0", VA = "0x182B68BF0")]
	public static PKKOLHIOKHB.JLGINDMDGAL GLMPFLLLGIH(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> GGPGNMHJADH)
	{
		return default(PKKOLHIOKHB.JLGINDMDGAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CB20", Offset = "0x3D6B520", VA = "0x183D6CB20")]
	private static HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> OMCBNCLACAC<TMJoin>(this KMCDDFKPJJK DKGBCFDLMOI, PKKOLHIOKHB.EGEFGNLKAOC LALOCMCOIIC, HOHDPLDONAJ<TMJoin> FJEIANNLOIA) where TMJoin : PKKOLHIOKHB.EFGCFNAGCDM
	{
		return default(HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B68CB0", Offset = "0x2B676B0", VA = "0x182B68CB0")]
	public static (HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>) GPJHLGDDHHA(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default((HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B69D00", Offset = "0x2B68700", VA = "0x182B69D00")]
	public static (HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>) MJLDMBOLAFE(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default((HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B68FF0", Offset = "0x2B679F0", VA = "0x182B68FF0")]
	public static HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> HICFCICPIBP(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2B681D0", Offset = "0x2B66BD0", VA = "0x182B681D0")]
	public static void AFLOHEELNKF(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN> GGPGNMHJADH, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> PEMKFCCKODN, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>> DEKLCGCMGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B890", Offset = "0x3D6A290", VA = "0x183D6B890")]
	public static OELCBGENFOH EADHIKJEOPP<TDeps, TStateSys>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB) where TDeps : NGMGKEJIPAK<TStateSys>
	{
		return default(OELCBGENFOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C810", Offset = "0x3D6B210", VA = "0x183D6C810")]
	public static ECAJFHJBFIF KEOCMGAPEHO<TDeps, TStateSys>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<IOBEEHHAIPN> DKOKOBIEBLC, int IMODNBGHFFJ) where TDeps : NGMGKEJIPAK<TStateSys>
	{
		return default(ECAJFHJBFIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AEE0", Offset = "0x3D698E0", VA = "0x183D6AEE0")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>? CKOHEEPAFIC<TDeps, TStateSys>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<IOBEEHHAIPN> DKOKOBIEBLC, [In] ReadOnlySpan<int> ONOIGFNGJDI, [In] Span<NECKCNGEMAJ> ABADECNGAHA) where TDeps : NGMGKEJIPAK<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B300", Offset = "0x3D69D00", VA = "0x183D6B300")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> DLJLKCBLCJK<TDeps, TStateSys>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG) where TDeps : NGMGKEJIPAK<TStateSys>
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A440", Offset = "0x2B68E40", VA = "0x182B6A440")]
	public static DCHEIPMCCIE.CHKJLJJIHBK POJGIMMCFCK([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD)
	{
		return default(DCHEIPMCCIE.CHKJLJJIHBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B68570", Offset = "0x2B66F70", VA = "0x182B68570")]
	public static DCHEIPMCCIE.NPFDKNMJFLD AOCNEJGJGOF([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD)
	{
		return default(DCHEIPMCCIE.NPFDKNMJFLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B68EC0", Offset = "0x2B678C0", VA = "0x182B68EC0")]
	public static DCHEIPMCCIE.HOGCHAPHOKH HFFGIHPHMIL([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD)
	{
		return default(DCHEIPMCCIE.HOGCHAPHOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B69370", Offset = "0x2B67D70", VA = "0x182B69370")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> IPAHAAEGFLM(this KMCDDFKPJJK DKGBCFDLMOI, int? PKPGGGPMPCG, string IELIBBNCJAC)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B68620", Offset = "0x2B67020", VA = "0x182B68620")]
	public static DCHEIPMCCIE.JFEINCOKOAO APJMMCAHOPM([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD)
	{
		return default(DCHEIPMCCIE.JFEINCOKOAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B691A0", Offset = "0x2B67BA0", VA = "0x182B691A0")]
	public static DCHEIPMCCIE.DKECGCGABLM HNCKPPEJENL([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD)
	{
		return default(DCHEIPMCCIE.DKECGCGABLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B69290", Offset = "0x2B67C90", VA = "0x182B69290")]
	public static int? IDMNLAGPHNC([In] this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C730", Offset = "0x3D6B130", VA = "0x183D6C730")]
	private static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FIGGPNBOIHK<TMJoin>(this KMCDDFKPJJK DKGBCFDLMOI, int? PKPGGGPMPCG, DCHEIPMCCIE.DKECGCGABLM LALOCMCOIIC, HOHDPLDONAJ<TMJoin> FJEIANNLOIA) where TMJoin : DCHEIPMCCIE.PEGHNICHOAL
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B686D0", Offset = "0x2B670D0", VA = "0x182B686D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BJOAACDDEAE(this KMCDDFKPJJK DKGBCFDLMOI, int? PKPGGGPMPCG, HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> EEOGADADFMK, int KABGMIEBEFC)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B69890", Offset = "0x2B68290", VA = "0x182B69890")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KHLDOEFBBIL(this KMCDDFKPJJK DKGBCFDLMOI, int? PKPGGGPMPCG)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B69640", Offset = "0x2B68040", VA = "0x182B69640")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JHOJKPDAJOO(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? PJOKEHIDNNE, int? PKPGGGPMPCG)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B69530", Offset = "0x2B67F30", VA = "0x182B69530")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JCFIOBCEHGA(this KMCDDFKPJJK DKGBCFDLMOI, int? PKPGGGPMPCG, int KABGMIEBEFC)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B68C50", Offset = "0x2B67650", VA = "0x182B68C50")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GPEKPGDDKLF(this KMCDDFKPJJK DKGBCFDLMOI, int? PKPGGGPMPCG)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B682C0", Offset = "0x2B66CC0", VA = "0x182B682C0")]
	public static void AHBMFPBBDPE(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD, HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> EEOGADADFMK, int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B69BE0", Offset = "0x2B685E0", VA = "0x182B69BE0")]
	public static void MJGFEJKACGC(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD, int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B698F0", Offset = "0x2B682F0", VA = "0x182B698F0")]
	public static void KJDBHKHIBPN(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B68B60", Offset = "0x2B67560", VA = "0x182B68B60")]
	public static void GIDIEMDFKAO(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> JFBLIPHGGPK, HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> PIMLPMEACLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B697D0", Offset = "0x2B681D0", VA = "0x182B697D0")]
	public static void KEHDNFBFAGG(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD, HOHDPLDONAJ<OHDHECABCNC<LCKLKGGPNAN>> MLBNOHKDEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C670", Offset = "0x3D6B070", VA = "0x183D6C670")]
	public static void FHJMKLLGFHG<M>(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JKCGLDOGCKD, HOHDPLDONAJ<OHDHECABCNC<HINCLKNGOJL<M>>> MLBNOHKDEOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NGMGKEJIPAK<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOHDPLDONAJ<BKCLJJAMDCD> KEBOJIJENPL(TStateSys NHLBFHNJBHP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOHDPLDONAJ<BKCLJJAMDCD> PPMGPIOGDCG(TStateSys NHLBFHNJBHP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOHDPLDONAJ<BKCLJJAMDCD> JGMEHOLBEJN(TStateSys NHLBFHNJBHP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOHDPLDONAJ<BKCLJJAMDCD> PPEHNBBENJN(TStateSys NHLBFHNJBHP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> HNNEEFIPNGC(TStateSys NHLBFHNJBHP, KMCDDFKPJJK LDIENBHCMIP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> IBDOLEAGDOE(TStateSys NHLBFHNJBHP, KMCDDFKPJJK LDIENBHCMIP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HMBPHIENHBK(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HOHDPLDONAJ<DIHEINFKHHL> JIEIENBNJOC(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB, int MBJBICHOAFJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EHBOJIHNIOD LACCNIIDJPO(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DJPLDOMBBDM(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int DGEDHDEHLBN(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CEAGJEFPBKJ<byte> HIDOJIAPGAD(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(CEAGJEFPBKJ<byte>, HOHDPLDONAJ<BKCLJJAMDCD>) POANEBJOMKD(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<MGHIDEJBICM> GIAPOIJDOEB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int DMBKMMAICHE(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HOHDPLDONAJ<MGHIDEJBICM> MEEAKBNMOGE(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> PHKEKCBFAHG, int IMODNBGHFFJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HOHDPLDONAJ<MGHIDEJBICM> ADJJNFNIHAO(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<IOBEEHHAIPN> DKOKOBIEBLC, int IMODNBGHFFJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int KMNPNOADKBM(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? FNLDFAPJOMC(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int JOKLHNFLDCK(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? JNLKFNELKFD(TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, int KABGMIEBEFC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JLMMHFGDEHD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E29A90", Offset = "0x3E28490", VA = "0x183E29A90")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG?> PGCFLAOLGJO<T, TOpInput, TOpOutput>(this KMCDDFKPJJK DKGBCFDLMOI, T CFAKKPGMPGD, T KMGOFHJBCKL, int CLAECBEPGKJ, IntPtr EHMBLGMCOEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E283B0", Offset = "0x3E26DB0", VA = "0x183E283B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG?> IKECOIFMHOO<T, TOpInput, TOpOutput>(this KMCDDFKPJJK DKGBCFDLMOI, T CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL, int CLAECBEPGKJ, IntPtr EHMBLGMCOEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3E27A40", Offset = "0x3E26440", VA = "0x183E27A40")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG?> GGBMBLHCCFA<TOpInput, TOpOutput>(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL, int CLAECBEPGKJ, IntPtr EHMBLGMCOEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D4D0", Offset = "0x2B6BED0", VA = "0x182B6D4D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EPIPKBFFGKO(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B70270", Offset = "0x2B6EC70", VA = "0x182B70270")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> PHLFAECNOKL(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E4D0", Offset = "0x2B6CED0", VA = "0x182B6E4D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JBBAEJJBPDJ(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E2B0", Offset = "0x2B6CCB0", VA = "0x182B6E2B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> IPDMBOMHPLF(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F7B0", Offset = "0x2B6E1B0", VA = "0x182B6F7B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NLAPPEDBPKC(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BA80", Offset = "0x2B6A480", VA = "0x182B6BA80")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BOMOMAJNJNI(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DC00", Offset = "0x2B6C600", VA = "0x182B6DC00")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> HFPAAALEODF(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B330", Offset = "0x2B69D30", VA = "0x182B6B330")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BABJKKGDJIC(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CD70", Offset = "0x2B6B770", VA = "0x182B6CD70")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DJIPDFFJCAF(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C670", Offset = "0x2B6B070", VA = "0x182B6C670")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DCHEFMIHKDJ(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, int KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C150", Offset = "0x2B6AB50", VA = "0x182B6C150")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CGGDABKNCHD(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CEB0", Offset = "0x2B6B8B0", VA = "0x182B6CEB0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DNCMFNHGMEF(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D230", Offset = "0x2B6BC30", VA = "0x182B6D230")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EEAIACDODEM(this KMCDDFKPJJK DKGBCFDLMOI, float CFAKKPGMPGD, float KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EF80", Offset = "0x2B6D980", VA = "0x182B6EF80")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> LDCKGPMPCGP(this KMCDDFKPJJK DKGBCFDLMOI, float CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CC30", Offset = "0x2B6B630", VA = "0x182B6CC30")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DIIGNDDIKOG(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E8F0", Offset = "0x2B6D2F0", VA = "0x182B6E8F0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KHAFACCIGPP(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, int KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C930", Offset = "0x2B6B330", VA = "0x182B6C930")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DFDEMNLPIME(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B2B0", Offset = "0x2B69CB0", VA = "0x182B6B2B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> ANIELJECACD(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EA90", Offset = "0x2B6D490", VA = "0x182B6EA90")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KOHMOEMOMPB(this KMCDDFKPJJK DKGBCFDLMOI, float CFAKKPGMPGD, float KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B7D0", Offset = "0x2B6A1D0", VA = "0x182B6B7D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BJHDBODEJJG(this KMCDDFKPJJK DKGBCFDLMOI, float CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B750", Offset = "0x2B6A150", VA = "0x182B6B750")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BDFDGIDKKDD(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C570", Offset = "0x2B6AF70", VA = "0x182B6C570")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CPOMOAMHILB(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, int KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D430", Offset = "0x2B6BE30", VA = "0x182B6D430")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EICFLGBAEML(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B701F0", Offset = "0x2B6EBF0", VA = "0x182B701F0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> PDNBCEFGOBK(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C8B0", Offset = "0x2B6B2B0", VA = "0x182B6C8B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DELKIILHAPK(this KMCDDFKPJJK DKGBCFDLMOI, float CFAKKPGMPGD, float KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AFD0", Offset = "0x2B699D0", VA = "0x182B6AFD0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> AKGCFEHKJIN(this KMCDDFKPJJK DKGBCFDLMOI, float CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C330", Offset = "0x2B6AD30", VA = "0x182B6C330")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CLLEIIGBEIF(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E0D0", Offset = "0x2B6CAD0", VA = "0x182B6E0D0")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> IOOHBHEKPML(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DB80", Offset = "0x2B6C580", VA = "0x182B6DB80")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> GPEOKOKIPFL(this KMCDDFKPJJK DKGBCFDLMOI, int KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C4D0", Offset = "0x2B6AED0", VA = "0x182B6C4D0")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> CPFBPICKPFP(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E710", Offset = "0x2B6D110", VA = "0x182B6E710")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> JNJGBAPIKIA(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> FBNHLGLKAEI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C5F0", Offset = "0x2B6AFF0", VA = "0x182B6C5F0")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> DBFNLIKFGPN(this KMCDDFKPJJK DKGBCFDLMOI, int KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F4F0", Offset = "0x2B6DEF0", VA = "0x182B6F4F0")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> MPMLLPEOGBC(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EB10", Offset = "0x2B6D510", VA = "0x182B6EB10")]
	public static (HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>) LCPNBADLPNI(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<EIMNPDILGCO> HFHCPBJNAIM, [In] ReadOnlySpan<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> DNEDADEPKEO, [In] ReadOnlySpan<int?> CFKNKOEGFPG, [In] Span<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> AHONCEJHCGP)
	{
		return default((HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BCE0", Offset = "0x2B6A6E0", VA = "0x182B6BCE0")]
	public static (HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>) CFPLCHMAMHM(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<EAOCDNABPDC> FJDFEFDIJCO, [In] ReadOnlySpan<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> DNEDADEPKEO, [In] ReadOnlySpan<int?> CFKNKOEGFPG, [In] Span<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> AHONCEJHCGP)
	{
		return default((HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E29050", Offset = "0x3E27A50", VA = "0x183E29050")]
	public static (HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<BKCLJJAMDCD>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<TMarker>>, HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>) LHLKBPEPFBK<TMarker>(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BKCLJJAMDCD> CNCKDEOGGCB, [In] ReadOnlySpan<byte> BLPDDGCLNPE)
	{
		return default((HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<OHDHECABCNC<BKCLJJAMDCD>>, HOHDPLDONAJ<OHDHECABCNC<FKCNILDEBHK>>, HOHDPLDONAJ<OHDHECABCNC<TMarker>>, HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C270", Offset = "0x2B6AC70", VA = "0x182B6C270")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CLABIIPLEIA(this KMCDDFKPJJK DKGBCFDLMOI, int EILINOAEIMG, [Optional] HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B850", Offset = "0x2B6A250", VA = "0x182B6B850")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BMKDEMLKKAB(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EILINOAEIMG, [Optional] HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CB40", Offset = "0x2B6B540", VA = "0x182B6CB40")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DICKAIDCFLH(this KMCDDFKPJJK DKGBCFDLMOI, [In] ReadOnlySpan<byte> EILINOAEIMG, [Optional] HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DE80", Offset = "0x2B6C880", VA = "0x182B6DE80")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> HLNNAFOEIBK(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EILINOAEIMG, int BCAJFCGHDKI, [Optional] HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F8D0", Offset = "0x2B6E2D0", VA = "0x182B6F8D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NNIDMPKCHAI(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F9D0", Offset = "0x2B6E3D0", VA = "0x182B6F9D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> OACPGMBAPLI(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FAF0", Offset = "0x2B6E4F0", VA = "0x182B6FAF0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> OGNOFKMELJD(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FFF0", Offset = "0x2B6E9F0", VA = "0x182B6FFF0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> OJNOCNOPNJH(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C3B0", Offset = "0x2B6ADB0", VA = "0x182B6C3B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> COBNPBNKECC(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F270", Offset = "0x2B6DC70", VA = "0x182B6F270")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> MABPFBGNCDF(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DE00", Offset = "0x2B6C800", VA = "0x182B6DE00")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> HIDDDNOKPMF(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, int KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C9B0", Offset = "0x2B6B3B0", VA = "0x182B6C9B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DGMCNFAIFLK(this KMCDDFKPJJK DKGBCFDLMOI, int CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F0B0", Offset = "0x2B6DAB0", VA = "0x182B6F0B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> LFMJDNJJMAD(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CFAKKPGMPGD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMGOFHJBCKL)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D330", Offset = "0x2B6BD30", VA = "0x182B6D330")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EGLFANEHHFI(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DFA0", Offset = "0x2B6C9A0", VA = "0x182B6DFA0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> IOIDDADJBHG(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C770", Offset = "0x2B6B170", VA = "0x182B6C770")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DECBHJIGECE(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DD00", Offset = "0x2B6C700", VA = "0x182B6DD00")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> HGINLAMIIOI(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E3B0", Offset = "0x2B6CDB0", VA = "0x182B6E3B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> IPHMGENMMIC(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B940", Offset = "0x2B6A340", VA = "0x182B6B940")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> BNHPJDMADCO(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D4B0", Offset = "0x2B6BEB0", VA = "0x182B6D4B0")]
	public static HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>> EPHLHCHFHOF(this KMCDDFKPJJK DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<OHDHECABCNC<OHDHECABCNC<LLCGKPILIDN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D6D0", Offset = "0x2B6C0D0", VA = "0x182B6D6D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FNIMLNLMFNI(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E970", Offset = "0x2B6D370", VA = "0x182B6E970")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMPOALFHFFG(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B170", Offset = "0x2B69B70", VA = "0x182B6B170")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> AMMGNLMPIAA(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F6B0", Offset = "0x2B6E0B0", VA = "0x182B6F6B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NKKMCFMFKNJ(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F590", Offset = "0x2B6DF90", VA = "0x182B6F590")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NFEOKLCIBPD(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F130", Offset = "0x2B6DB30", VA = "0x182B6F130")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> LPLFMFAFOAO(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B700F0", Offset = "0x2B6EAF0", VA = "0x182B700F0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> PDADNFHMMEE(this KMCDDFKPJJK DKGBCFDLMOI, int KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CA30", Offset = "0x2B6B430", VA = "0x182B6CA30")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DHKFHKMPEEG(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> KMAFNKGMDCF)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D7D0", Offset = "0x2B6C1D0", VA = "0x182B6D7D0")]
	public static void GCHAIJFKDFK(this KMCDDFKPJJK DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E610", Offset = "0x2B6D010", VA = "0x182B6E610")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> JBMFEJJFBIN(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, float GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D920", Offset = "0x2B6C320", VA = "0x182B6D920")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GLMEPPCLBAB(this KMCDDFKPJJK DKGBCFDLMOI, float FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D7E0", Offset = "0x2B6C1E0", VA = "0x182B6D7E0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GEMGCLPBGCE(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D130", Offset = "0x2B6BB30", VA = "0x182B6D130")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> ECMPOJHJOJA(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B050", Offset = "0x2B69A50", VA = "0x182B6B050")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> AKNCHOFMMIL(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CFF0", Offset = "0x2B6B9F0", VA = "0x182B6CFF0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> DNKHPFCAIBK(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FC30", Offset = "0x2B6E630", VA = "0x182B6FC30")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> OIGPDKHNGKM(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> KIBMIACGBLJ, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> IEJJEDCHCPA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D5D0", Offset = "0x2B6BFD0", VA = "0x182B6D5D0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FABCCMKJCPD(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, int GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BBC0", Offset = "0x2B6A5C0", VA = "0x182B6BBC0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> CENACFBGLEI(this KMCDDFKPJJK DKGBCFDLMOI, int FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F3B0", Offset = "0x2B6DDB0", VA = "0x182B6F3B0")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> MCMIKAPMKHB(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FGHDIGDIKHD, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> GGJNNAMGOLA)
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3E26D10", Offset = "0x3E25710", VA = "0x183E26D10")]
	public static void AGDGINJOGED<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<EIMNPDILGCO> HFHCPBJNAIM, [In] ReadOnlySpan<HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>> GENGIKOEKDC, [In] ReadOnlySpan<int?> CFKNKOEGFPG, [In] Span<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> AHONCEJHCGP, [In] Span<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> EMCNCAJDFGO, [In] ReadOnlySpan<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>?> AHNNBCLMLGL) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3E27B60", Offset = "0x3E26560", VA = "0x183E27B60")]
	public static void HJJJCJIGKKP<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<EAOCDNABPDC> DHFPPCMKNFO, [In] ReadOnlySpan<HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>> GICOMMMCJIB, [In] ReadOnlySpan<int?> CFKNKOEGFPG, [In] Span<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> AHONCEJHCGP, [In] Span<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>> EMCNCAJDFGO, [In] ReadOnlySpan<HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>?> AHNNBCLMLGL) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3E29140", Offset = "0x3E27B40", VA = "0x183E29140")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> LPDAJGPAELO<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> PJOKEHIDNNE, [Optional] HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3E29670", Offset = "0x3E28070", VA = "0x183E29670")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> OLAAIKJENOK<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> HOGNGAHMHLM, [Optional] HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3E29300", Offset = "0x3E27D00", VA = "0x183E29300")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> MNOLFFJMOHC<TDeps, TStateSys>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP) where TDeps : notnull, NGMGKEJIPAK<TStateSys> where TStateSys : notnull
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3E28060", Offset = "0x3E26A60", VA = "0x183E28060")]
	public static HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII> IFAOJGJDNDM<TDeps, TStateSys>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP) where TDeps : notnull, NGMGKEJIPAK<TStateSys> where TStateSys : notnull
	{
		return default(HOHDPLDONAJ<GBMELKDHDGE.EAGDLHLEGII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DA40", Offset = "0x2B6C440", VA = "0x182B6DA40")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> GMLKNNDFNAB(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> GAFKPLDGKMI, IntPtr JMIDMDMOFII, IntPtr MDMNNKAINCF)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B450", Offset = "0x2B69E50", VA = "0x182B6B450")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> BBMBOJGMKFD(this KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> NGOGIFFPEAH, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> PLGKOPHCJPC, IntPtr HLMHAGFGDNO, IntPtr EPLJLKFFDGM, IntPtr LINHABAAKLM, bool MLIKFOOCBHB)
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3E28690", Offset = "0x3E27090", VA = "0x183E28690")]
	public static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> JLEFOHBPCDF<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<EIMNPDILGCO> GHDCFMBHDOM, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> NGOGIFFPEAH, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> PLGKOPHCJPC, int? NCKEFIOBBBF, [Optional] IntPtr JGAOOFCLHIP) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3E28860", Offset = "0x3E27260", VA = "0x183E28860")]
	private static HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> JLEFOHBPCDF<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<EIMNPDILGCO> GHDCFMBHDOM, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> NGOGIFFPEAH, HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML> PLGKOPHCJPC, int? NCKEFIOBBBF) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
		return default(HOHDPLDONAJ<BPPCBEDKILA.LJNPOCDPMML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3E27210", Offset = "0x3E25C10", VA = "0x183E27210")]
	public static HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FEHBHBAFLKA<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> EILINOAEIMG, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>? KAHHEMPAJEL) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
		return default(HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3E27690", Offset = "0x3E26090", VA = "0x183E27690")]
	public static void GADEMJOCGNJ<TDeps, TState>(this KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TState IMNBLKDCAKA, int DKEBFLPOHHB) where TDeps : notnull, NGMGKEJIPAK<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MFFKDDPPCHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> PDLFHBLHENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> KHMODEAFLEN;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
	public MFFKDDPPCHK(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> MBCOENCHCAJ, HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> AFNMOCAABIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B713D0", Offset = "0x2B6FDD0", VA = "0x182B713D0")]
	public static MFFKDDPPCHK KDBDJPAJKDJ(HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>> MBCOENCHCAJ)
	{
		return default(MFFKDDPPCHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DCHEIPMCCIE
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class FAHCPANDDLB : PEGHNICHOAL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CHKJLJJIHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> FLCOPOMNPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CIDCBGPMNFL;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		public CHKJLJJIHBK(HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> EEOGADADFMK, int KABGMIEBEFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HODCOOCFMPA : PEGHNICHOAL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct NPFDKNMJFLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int CIDCBGPMNFL;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public NPFDKNMJFLD(int KABGMIEBEFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CHBLPNMAAIN : PEGHNICHOAL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HOGCHAPHOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> FLCOPOMNPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int CIDCBGPMNFL;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xECA580", Offset = "0xEC8F80", VA = "0x180ECA580")]
		public HOGCHAPHOKH(HOHDPLDONAJ<PKKOLHIOKHB.IOFPJIONIJB> EEOGADADFMK, int KABGMIEBEFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum DKECGCGABLM
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
	public sealed class ABFKLLFKKBG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class PEGHNICHOAL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KEFHKDMNIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? HKNANIJJPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MFFKDDPPCHK IBDKIFBLAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public DKECGCGABLM JNCDMBCPJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HOHDPLDONAJ<PEGHNICHOAL> LCALFMDBJCN;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B70390", Offset = "0x2B6ED90", VA = "0x182B70390")]
		public KEFHKDMNIKL(int? PKPGGGPMPCG, [In] MFFKDDPPCHK GOHAEBNAKDA, DKECGCGABLM LALOCMCOIIC, HOHDPLDONAJ<PEGHNICHOAL> FJEIANNLOIA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LFGHACBHAJF : PEGHNICHOAL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JFEINCOKOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int CIDCBGPMNFL;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880")]
		public JFEINCOKOAO(int KABGMIEBEFC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal OELOAFJFOID<ABFKLLFKKBG, KEFHKDMNIKL> GIBIMKGFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal OELOAFJFOID<FAHCPANDDLB, CHKJLJJIHBK> DJPLFPFOCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal OELOAFJFOID<CHBLPNMAAIN, HOGCHAPHOKH> EMKBHFGGDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal OELOAFJFOID<LFGHACBHAJF, JFEINCOKOAO> DLGAHFLKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal OELOAFJFOID<HODCOOCFMPA, NPFDKNMJFLD> LCCJLMCOBDG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B67D60", Offset = "0x2B66760", VA = "0x182B67D60")]
	private DCHEIPMCCIE([In] OELOAFJFOID<ABFKLLFKKBG, KEFHKDMNIKL> LHPBEKCGELI, [In] OELOAFJFOID<FAHCPANDDLB, CHKJLJJIHBK> CLBCGDJBCGO, [In] OELOAFJFOID<CHBLPNMAAIN, HOGCHAPHOKH> BECPEABMHJL, [In] OELOAFJFOID<LFGHACBHAJF, JFEINCOKOAO> MAPKMFKINJO, [In] OELOAFJFOID<HODCOOCFMPA, NPFDKNMJFLD> IPBHOOJBBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B70", Offset = "0x2B66570", VA = "0x182B67B70")]
	public static DCHEIPMCCIE KDBDJPAJKDJ()
	{
		return default(DCHEIPMCCIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AGJLDOIKBBH
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B66D90", Offset = "0x2B65790", VA = "0x182B66D90")]
	public static void PIIFCIMJIKL(this DCHEIPMCCIE DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NLOLJNOIMID
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B71920", Offset = "0x2B70320", VA = "0x182B71920")]
	public static void AEOBHGFBIDI(KMCDDFKPJJK DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct PCCPGCBMIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HBPLCLOGJDP> MPNIKDGGEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int GHIBPKOLHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int AFHMFHEIFAE;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2B72100", Offset = "0x2B70B00", VA = "0x182B72100")]
	private PCCPGCBMIIJ([In] LGCELBLJKFI<PKKOLHIOKHB.HFCMDNPMINN, HBPLCLOGJDP> ECDKJJAHIDF, int LDDMIJBEDBN, int KDCLPPMDNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2B71EC0", Offset = "0x2B708C0", VA = "0x182B71EC0")]
	public static PCCPGCBMIIJ KDBDJPAJKDJ()
	{
		return default(PCCPGCBMIIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B71F30", Offset = "0x2B70930", VA = "0x182B71F30")]
	public void PIIFCIMJIKL([In] KMCDDFKPJJK GFENHEKLPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3F617D0", Offset = "0x3F601D0", VA = "0x183F617D0")]
	public static void AEOBHGFBIDI<TDeps, TStateSys>(KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP, HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO) where TDeps : notnull, NGMGKEJIPAK<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GHPGAJGCJKG
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A750", Offset = "0x2B69150", VA = "0x182B6A750")]
	public static void AEOBHGFBIDI(KMCDDFKPJJK DKGBCFDLMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EAJNLEDDPMI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface OBOELHADANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GGBIJFDDMJD(DBIBICKBIIJ<byte> GAPEAGPINHO, int PNAGKDODKAN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct GGEHLIHAHJO : OBOELHADANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A6D0", Offset = "0x2B690D0", VA = "0x182B6A6D0", Slot = "4")]
		public void GGBIJFDDMJD(DBIBICKBIIJ<byte> GAPEAGPINHO, int PNAGKDODKAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct IDBFGIJKDBL : OBOELHADANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AE00", Offset = "0x2B69800", VA = "0x182B6AE00", Slot = "4")]
		public void GGBIJFDDMJD(DBIBICKBIIJ<byte> GAPEAGPINHO, int PNAGKDODKAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct FHBBOGKKPPH : OBOELHADANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B6A4F0", Offset = "0x2B68EF0", VA = "0x182B6A4F0", Slot = "4")]
		public void GGBIJFDDMJD(DBIBICKBIIJ<byte> GAPEAGPINHO, int PNAGKDODKAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct HOFEIHBACOB : OBOELHADANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2B6AD60", Offset = "0x2B69760", VA = "0x182B6AD60", Slot = "4")]
		public void GGBIJFDDMJD(DBIBICKBIIJ<byte> GAPEAGPINHO, int PNAGKDODKAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class NJICNNNLHGG<TCallProcessorDeps> where TCallProcessorDeps : struct, OBOELHADANH
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps KLALHCJBOKG;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x453B470", Offset = "0x4539E70", VA = "0x18453B470")]
		public static int AEOBHGFBIDI<TDeps, TStateSys>(TDeps KPEJCAGFLDG, TStateSys IMNBLKDCAKA, KMCDDFKPJJK GFENHEKLPCC, [In] DBIBICKBIIJ<byte> ALKNPHLKEIJ, int KBIFHFKADKF) where TDeps : NGMGKEJIPAK<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private DBIBICKBIIJ<JPLEIMJECLM> PFOOOGIGPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>> FAIHAIMKADK;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2B67F90", Offset = "0x2B66990", VA = "0x182B67F90")]
	private EAJNLEDDPMI([In] DBIBICKBIIJ<JPLEIMJECLM> KJPLFMNIFKI, Dictionary<HOHDPLDONAJ<OHDHECABCNC<LLCGKPILIDN>>, HOHDPLDONAJ<PKKOLHIOKHB.HFCMDNPMINN>> FALILAICFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2B67E90", Offset = "0x2B66890", VA = "0x182B67E90")]
	public static EAJNLEDDPMI KDBDJPAJKDJ()
	{
		return default(EAJNLEDDPMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2B67F50", Offset = "0x2B66950", VA = "0x182B67F50")]
	public void PIIFCIMJIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BFB970", Offset = "0x3BFA370", VA = "0x183BFB970")]
	public static void AEOBHGFBIDI<TDeps, TStateSys>(KMCDDFKPJJK DKGBCFDLMOI, TDeps KPEJCAGFLDG, TStateSys NHLBFHNJBHP) where TDeps : NGMGKEJIPAK<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AKMLHICMBKN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct AFLEEDNEIGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> FBLJCBLPODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int CBAPPPOJHMC;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int MEFLDIGLPFE;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int EOIJKBJBCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2B66E40", Offset = "0x2B65840", VA = "0x182B66E40")]
	public static void AEOBHGFBIDI(KMCDDFKPJJK DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2B674E0", Offset = "0x2B65EE0", VA = "0x182B674E0")]
	private static void KDOLNDHMKAL([In] KMCDDFKPJJK DKGBCFDLMOI, HOHDPLDONAJ<DCHEIPMCCIE.ABFKLLFKKBG> NMAIBBDGPCD, DBIBICKBIIJ<byte> AHHKAIEKAJM, List<AFLEEDNEIGH> GBMFHENMIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2B67700", Offset = "0x2B66100", VA = "0x182B67700")]
	private static void KDOLNDHMKAL(DBIBICKBIIJ<byte> AHHKAIEKAJM, int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B673B0", Offset = "0x2B65DB0", VA = "0x182B673B0")]
	private static void AFCEDJCALFM(KMCDDFKPJJK DKGBCFDLMOI, List<AFLEEDNEIGH> GBMFHENMIPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CCOLKAKPGPF<TDeps, TIndex, TValues> where TDeps : struct, MLICLJFBMMA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps KLALHCJBOKG;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6C038C0", Offset = "0x6C022C0", VA = "0x186C038C0")]
	public static void AEOBHGFBIDI([In] DBIBICKBIIJ<JPLEIMJECLM> KJPLFMNIFKI, int DOLEDAOOKMC, TValues FDOLNIMJMJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MLICLJFBMMA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBIBICKBIIJ<TIndex> CGLHAEBMBDC(int DOLEDAOOKMC, [In] TValues FDOLNIMJMJM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(TIndex KABGMIEBEFC, [In] TValues FDOLNIMJMJM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AABCPBKIMBA(TIndex KABGMIEBEFC, TValues FDOLNIMJMJM, HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface BJDOKBKBAFD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex OJNNLKCJPPH(int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POCIKIMAIJL(TIndex KABGMIEBEFC, [In] TValues FDOLNIMJMJM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOHDPLDONAJ<OHDHECABCNC<EBPBDIDCDHC>> JOJBKEEGFHE(TIndex KABGMIEBEFC, [In] TValues FDOLNIMJMJM);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class APBLGILMIBA<TDeps, TIndex, TValues> where TDeps : struct, BJDOKBKBAFD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps KLALHCJBOKG;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x54E7DE0", Offset = "0x54E67E0", VA = "0x1854E7DE0")]
	public static DBIBICKBIIJ<TIndex> AEOBHGFBIDI(int DOLEDAOOKMC, [In] TValues FDOLNIMJMJM)
	{
		return default(DBIBICKBIIJ<TIndex>);
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
