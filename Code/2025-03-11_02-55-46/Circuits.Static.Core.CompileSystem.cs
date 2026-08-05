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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x25D43E0", Offset = "0x25D37E0", VA = "0x1825D43E0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
public readonly struct PFMKFLDPKCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PHOJMGBGCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int CDNMPCJCEBO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
	public PFMKFLDPKCP(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> DNLMCMLJLID, int FGCNBOMLCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JDNPKKPOCNB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class NOJHDCIHHLK : CNBKKPKEENB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct ABHGBJOPLLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly FFAILDLPKDE<byte> INEBAFPBBGB;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2573520", Offset = "0x2572920", VA = "0x182573520")]
		public ABHGBJOPLLJ(FFAILDLPKDE<byte> KPLABGDDBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x25C8B00", Offset = "0x25C7F00", VA = "0x1825C8B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class KODCDKJNFFB : CNBKKPKEENB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct EMJMKBHEDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> GPFMEACPBAK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public EMJMKBHEDKB(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> HKAPMMKADDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DBJALNHADMF
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
	public sealed class EANLEKIPACB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class CNBKKPKEENB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct NPIHFGHFIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DBJALNHADMF BLLEJPAJECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly DDIPAIMAGGM<CNBKKPKEENB> FBOENDJJEKJ;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
		public NPIHFGHFIMH(DBJALNHADMF HJOIFMIMAPJ, DDIPAIMAGGM<CNBKKPKEENB> NMHGMCOFDIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class GDMDAGDFHGB : CNBKKPKEENB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct EECIMLNECCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> INEHFNGEOBG;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public EECIMLNECCB(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class GMJMGBFBEED : CNBKKPKEENB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct ELEGOIOIDAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly LMMLKBHKBDN HPGDIAMNALD;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public ELEGOIOIDAD(LMMLKBHKBDN OIEGMCCPKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x25CC750", Offset = "0x25CBB50", VA = "0x1825CC750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal GEFNJIOOCNN<EANLEKIPACB, NPIHFGHFIMH> DCDANBJLAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal GEFNJIOOCNN<NOJHDCIHHLK, ABHGBJOPLLJ> FKCNGBLPBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal GEFNJIOOCNN<KODCDKJNFFB, EMJMKBHEDKB> ADEDHLHJABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal GEFNJIOOCNN<GDMDAGDFHGB, EECIMLNECCB> LAIBFJFGLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal GEFNJIOOCNN<GMJMGBFBEED, ELEGOIOIDAD> FMNMHAKJCPC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25D3450", Offset = "0x25D2850", VA = "0x1825D3450")]
	private JDNPKKPOCNB([In] GEFNJIOOCNN<EANLEKIPACB, NPIHFGHFIMH> LDBKEKHLIEE, [In] GEFNJIOOCNN<NOJHDCIHHLK, ABHGBJOPLLJ> MNECLJFBLBA, [In] GEFNJIOOCNN<KODCDKJNFFB, EMJMKBHEDKB> AGJDCPEKMPF, [In] GEFNJIOOCNN<GDMDAGDFHGB, EECIMLNECCB> MJBLMKNAFBM, [In] GEFNJIOOCNN<GMJMGBFBEED, ELEGOIOIDAD> NPBPMKDHMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25D3310", Offset = "0x25D2710", VA = "0x1825D3310")]
	public static JDNPKKPOCNB KMDIICJFNJF()
	{
		return default(JDNPKKPOCNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FPOKLGLNDMO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x25CCAA0", Offset = "0x25CBEA0", VA = "0x1825CCAA0")]
	public static void FKLDNICNGJG(this JDNPKKPOCNB IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum MHLAFIIDCMJ
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
public struct PCLIBJIEHIB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class KFGNGMGLNJB : NLGKKEEIGMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct FNLKHCIFLNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> LELDFEHBDLI;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public FNLKHCIFLNB(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> HFNMOOKGHOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum CCCLBJGCAGC
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
	public sealed class CGIJBLKMJOF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class NLGKKEEIGMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct MCHKLEJDKCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CCCLBJGCAGC BLLEJPAJECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly DDIPAIMAGGM<NLGKKEEIGMN> FBOENDJJEKJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
		public MCHKLEJDKCE(CCCLBJGCAGC HJOIFMIMAPJ, DDIPAIMAGGM<NLGKKEEIGMN> NMHGMCOFDIG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal GEFNJIOOCNN<CGIJBLKMJOF, MCHKLEJDKCE> DCDANBJLAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GEFNJIOOCNN<KFGNGMGLNJB, FNLKHCIFLNB> PHKGHGOKJEE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x25C8BF0", Offset = "0x25C7FF0", VA = "0x1825C8BF0")]
	private PCLIBJIEHIB([In] GEFNJIOOCNN<CGIJBLKMJOF, MCHKLEJDKCE> LDBKEKHLIEE, [In] GEFNJIOOCNN<KFGNGMGLNJB, FNLKHCIFLNB> BGJPGPDOOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x25D44E0", Offset = "0x25D38E0", VA = "0x1825D44E0")]
	public static PCLIBJIEHIB KMDIICJFNJF()
	{
		return default(PCLIBJIEHIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BOGKKHLNLNA
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x25CB860", Offset = "0x25CAC60", VA = "0x1825CB860")]
	public static void FKLDNICNGJG(this PCLIBJIEHIB IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GKGKFPDGLPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public FPKFBGDMAGD<int> LMCMJALMCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public FPKFBGDMAGD<int> IECALOIKNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MEPBDOEBFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int IBCEMKMPPGK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25CCBF0", Offset = "0x25CBFF0", VA = "0x1825CCBF0")]
	private GKGKFPDGLPA([In] FPKFBGDMAGD<int> PFCDMKBBMMN, [In] FPKFBGDMAGD<int> POJIMKHFAGH, int JOPGDEDJEJL, int EPODFGNBCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x25CCB50", Offset = "0x25CBF50", VA = "0x1825CCB50")]
	public static GKGKFPDGLPA KMDIICJFNJF()
	{
		return default(GKGKFPDGLPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AAHHHPNPPLG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x25C8AB0", Offset = "0x25C7EB0", VA = "0x1825C8AB0")]
	public static void FKLDNICNGJG(this GKGKFPDGLPA IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EIBNJLDMIAM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum JNMIFBHKKNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ECDDLDCEHPM : JONBKGONACO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct EHDPCFEEFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly DDIPAIMAGGM<FJFDKMJGMFH> ACFDGNIEFIL;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public EHDPCFEEFAG(DDIPAIMAGGM<FJFDKMJGMFH> EPKLDPNABNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class EGKEGAECMAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class JONBKGONACO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct HNDEPKPKBBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly JNMIFBHKKNC BLLEJPAJECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly DDIPAIMAGGM<JONBKGONACO> FBOENDJJEKJ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
		private HNDEPKPKBBH(JNMIFBHKKNC HJOIFMIMAPJ, DDIPAIMAGGM<JONBKGONACO> NMHGMCOFDIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x25D2C10", Offset = "0x25D2010", VA = "0x1825D2C10")]
		public static HNDEPKPKBBH KMDIICJFNJF(JNMIFBHKKNC HJOIFMIMAPJ, DDIPAIMAGGM<JONBKGONACO> NMHGMCOFDIG)
		{
			return default(HNDEPKPKBBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class AJJEACMDJAJ : JONBKGONACO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PKNIAGGJEAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly DDIPAIMAGGM<FJFDKMJGMFH> ACFDGNIEFIL;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public PKNIAGGJEAC(DDIPAIMAGGM<FJFDKMJGMFH> EPKLDPNABNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class FJFDKMJGMFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct AMFLBHNENNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FPKFBGDMAGD<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> ECJFNDGKBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FPKFBGDMAGD<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> BAKPLOLMBHM;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25C8BF0", Offset = "0x25C7FF0", VA = "0x1825C8BF0")]
		private AMFLBHNENNP([In] FPKFBGDMAGD<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> BMMAKKAHGMI, [In] FPKFBGDMAGD<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> AHMJKKLGCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x25C8B70", Offset = "0x25C7F70", VA = "0x1825C8B70")]
		public static AMFLBHNENNP KMDIICJFNJF()
		{
			return default(AMFLBHNENNP);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal GEFNJIOOCNN<EGKEGAECMAD, HNDEPKPKBBH> DCDANBJLAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal GEFNJIOOCNN<AJJEACMDJAJ, PKNIAGGJEAC> BPDACAKHNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal GEFNJIOOCNN<ECDDLDCEHPM, EHDPCFEEFAG> GLFDGINCHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FPKFBGDMAGD<(DDIPAIMAGGM<EGKEGAECMAD> CallId, DDIPAIMAGGM<FJFDKMJGMFH> IOId)> MOIDLLEGADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal GEFNJIOOCNN<FJFDKMJGMFH, AMFLBHNENNP> CLOPOOHBCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal NFPEEHNJFJP<FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> EAEJMOHONBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal NFPEEHNJFJP<FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> NMCLECPDOHB;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x25CC690", Offset = "0x25CBA90", VA = "0x1825CC690")]
	private EIBNJLDMIAM([In] GEFNJIOOCNN<EGKEGAECMAD, HNDEPKPKBBH> LDBKEKHLIEE, [In] GEFNJIOOCNN<AJJEACMDJAJ, PKNIAGGJEAC> CPIOMIAJPPE, [In] GEFNJIOOCNN<ECDDLDCEHPM, EHDPCFEEFAG> MKMEDFFPFFN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<EGKEGAECMAD> CallId, DDIPAIMAGGM<FJFDKMJGMFH> IOId)> OAPIHMFFFFK, [In] GEFNJIOOCNN<FJFDKMJGMFH, AMFLBHNENNP> LIKHJEHOMMG, [In] NFPEEHNJFJP<FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> FKJADELBNKJ, [In] NFPEEHNJFJP<FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> HKFEOMFGAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x25CC4F0", Offset = "0x25CB8F0", VA = "0x1825CC4F0")]
	public static EIBNJLDMIAM KMDIICJFNJF()
	{
		return default(EIBNJLDMIAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class IKDEPEELMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x25D30B0", Offset = "0x25D24B0", VA = "0x1825D30B0")]
	private static void FKLDNICNGJG(this EIBNJLDMIAM.AMFLBHNENNP IIICNLIAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25D3100", Offset = "0x25D2500", VA = "0x1825D3100")]
	public static void FKLDNICNGJG(this EIBNJLDMIAM IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HDOMMPOBHDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public FPKFBGDMAGD<byte> OPIPHPCOCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EIBNJLDMIAM PCEBNMJMNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NNPKNLLMHIB HIMOCHIJIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> JKNOIKAHPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JDNPKKPOCNB HDKFPIALPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal PCLIBJIEHIB NIBBIKFNOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal NFPEEHNJFJP<BIIAPNECPOC, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>?> JGCHEOLMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FPKFBGDMAGD<DDIPAIMAGGM<BIIAPNECPOC>> LDLMOMFNFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> NEEPPKOCEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> HHMAGOGEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JDKGLLHFKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal IINNCFHJAMH FINCIAGCINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal IJHDAPBNDGA MDBHNIMEBPL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25CD600", Offset = "0x25CCA00", VA = "0x1825CD600")]
	private HDOMMPOBHDE([In] FPKFBGDMAGD<byte> PCJJNAMDCMK, [In] EIBNJLDMIAM LAEINJPKNNH, [In] NNPKNLLMHIB JNCONCDOHAO, [In] JDNPKKPOCNB OFAIGCKPBCP, [In] PCLIBJIEHIB GFJCHMKHCIK, [In] NFPEEHNJFJP<BIIAPNECPOC, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>?> HMJEHIKNOMM, [In] FPKFBGDMAGD<DDIPAIMAGGM<BIIAPNECPOC>> GJNDMPJOHFH, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> PEKOGGPGCMP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JLBHFOHMNCP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> OIMHOGCECOP, [In] IINNCFHJAMH NCHADIJKFFH, [In] IJHDAPBNDGA OIOKOPCJLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25CCC50", Offset = "0x25CC050", VA = "0x1825CCC50")]
	public static HDOMMPOBHDE KMDIICJFNJF()
	{
		return default(HDOMMPOBHDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BDJDMACHFIG
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct PDMEBDOJDFI : DIDHMMCOFLK<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>, NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x25D45B0", Offset = "0x25D39B0", VA = "0x1825D45B0")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x25D4580", Offset = "0x25D3980", VA = "0x1825D4580", Slot = "4")]
		public DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> EMONJGDKOMD(int FFCBHHABFJN)
		{
			return default(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		public bool KPJIJHBBHLM(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "5")]
		private bool AJKMDPHPCNN(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x25D4570", Offset = "0x25D3970", VA = "0x1825D4570", Slot = "6")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> CFMAOHNNANI(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct DOKJMPBAKIH : KPNLMMMHOJN<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>, NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x25CC040", Offset = "0x25CB440", VA = "0x1825CC040")]
		public FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>> DIJFOFNNPGM(int OFPOPHJFIBP, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x25CC0C0", Offset = "0x25CB4C0", VA = "0x1825CC0C0")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x25CBF80", Offset = "0x25CB380", VA = "0x1825CBF80", Slot = "6")]
		public void AMLDJGJFIHB(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x25CC040", Offset = "0x25CB440", VA = "0x1825CC040", Slot = "4")]
		private FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>> GKHABFBBFIG(int OFPOPHJFIBP, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x25CC0B0", Offset = "0x25CB4B0", VA = "0x1825CC0B0", Slot = "5")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> JMBKPHNAFLK(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct FAMBBKCLGIG : DIDHMMCOFLK<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>, NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x25CC7B0", Offset = "0x25CBBB0", VA = "0x1825CC7B0")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x25CC770", Offset = "0x25CBB70", VA = "0x1825CC770", Slot = "4")]
		public DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> EMONJGDKOMD(int FFCBHHABFJN)
		{
			return default(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		public bool KPJIJHBBHLM(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "5")]
		private bool GCIFHFMDOLC(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25CC7A0", Offset = "0x25CBBA0", VA = "0x1825CC7A0", Slot = "6")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> HPPOLPNMJME(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct EDAACMLDOFC : KPNLMMMHOJN<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>, NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x25CC3C0", Offset = "0x25CB7C0", VA = "0x1825CC3C0")]
		public FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>> DIJFOFNNPGM(int OFPOPHJFIBP, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x25CC440", Offset = "0x25CB840", VA = "0x1825CC440")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25CC300", Offset = "0x25CB700", VA = "0x1825CC300", Slot = "6")]
		public void AMLDJGJFIHB(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x25CC3C0", Offset = "0x25CB7C0", VA = "0x1825CC3C0", Slot = "4")]
		private FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>> NEAJIHAPKIH(int OFPOPHJFIBP, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x25CC430", Offset = "0x25CB830", VA = "0x1825CC430", Slot = "5")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> HOPLBOPKFMD(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> FFCBHHABFJN, [In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct DPCIOMCKPKB : DIDHMMCOFLK<DDIPAIMAGGM<HAEPGAFINPD>, NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x25CC230", Offset = "0x25CB630", VA = "0x1825CC230")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x25CC170", Offset = "0x25CB570", VA = "0x1825CC170", Slot = "4")]
		public DDIPAIMAGGM<HAEPGAFINPD> EMONJGDKOMD(int FFCBHHABFJN)
		{
			return default(DDIPAIMAGGM<HAEPGAFINPD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x25CC1A0", Offset = "0x25CB5A0", VA = "0x1825CC1A0")]
		public bool KPJIJHBBHLM(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x25CC1A0", Offset = "0x25CB5A0", VA = "0x1825CC1A0", Slot = "5")]
		private bool HMKIEOPCFFI(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x25CC220", Offset = "0x25CB620", VA = "0x1825CC220", Slot = "6")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> LBPHJEFIEEI(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct APODIANCIBO : KPNLMMMHOJN<DDIPAIMAGGM<HAEPGAFINPD>, NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x25C8D10", Offset = "0x25C8110", VA = "0x1825C8D10")]
		public FPKFBGDMAGD<DDIPAIMAGGM<HAEPGAFINPD>> DIJFOFNNPGM(int OFPOPHJFIBP, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<DDIPAIMAGGM<HAEPGAFINPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x25C8D90", Offset = "0x25C8190", VA = "0x1825C8D90")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x25C8C30", Offset = "0x25C8030", VA = "0x1825C8C30", Slot = "6")]
		public void AMLDJGJFIHB(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25C8D10", Offset = "0x25C8110", VA = "0x1825C8D10", Slot = "4")]
		private FPKFBGDMAGD<DDIPAIMAGGM<HAEPGAFINPD>> JHJHKCLIAFM(int OFPOPHJFIBP, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<DDIPAIMAGGM<HAEPGAFINPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x25C8D80", Offset = "0x25C8180", VA = "0x1825C8D80", Slot = "5")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> HNJNIAAOLPG(DDIPAIMAGGM<HAEPGAFINPD> FFCBHHABFJN, [In] NFPEEHNJFJP<HAEPGAFINPD, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>?> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct PIHFHBCJILJ : DIDHMMCOFLK<int, FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x25D4670", Offset = "0x25D3A70", VA = "0x1825D4670")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCAA690", Offset = "0xCA9A90", VA = "0x180CAA690", Slot = "4")]
		public int EMONJGDKOMD(int FFCBHHABFJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		public bool KPJIJHBBHLM(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "5")]
		private bool BBGIOBMNNDE(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x25D4660", Offset = "0x25D3A60", VA = "0x1825D4660", Slot = "6")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> GALMKKAFKCO(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct CEMCLMNIHPH : KPNLMMMHOJN<int, FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x25CB9C0", Offset = "0x25CADC0", VA = "0x1825CB9C0")]
		public FPKFBGDMAGD<int> DIJFOFNNPGM(int OFPOPHJFIBP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x25CBA40", Offset = "0x25CAE40", VA = "0x1825CBA40")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x25CB8C0", Offset = "0x25CACC0", VA = "0x1825CB8C0", Slot = "6")]
		public void AMLDJGJFIHB(int FFCBHHABFJN, FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x25CB9C0", Offset = "0x25CADC0", VA = "0x1825CB9C0", Slot = "4")]
		private FPKFBGDMAGD<int> KCLKPONDJOL(int OFPOPHJFIBP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x25CBA30", Offset = "0x25CAE30", VA = "0x1825CBA30", Slot = "5")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> DLNMNEEOPIF(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> VariableId, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<IAEDDOGNOPD>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct MDEIJFLODLK : DIDHMMCOFLK<int, FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x25D4020", Offset = "0x25D3420", VA = "0x1825D4020")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCAA690", Offset = "0xCA9A90", VA = "0x180CAA690", Slot = "4")]
		public int EMONJGDKOMD(int FFCBHHABFJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		public bool KPJIJHBBHLM(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "5")]
		private bool HINNCJDDOJG(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x25D4010", Offset = "0x25D3410", VA = "0x1825D4010", Slot = "6")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> CEEFHJMPPBB(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct FBKHIJLEOOL : KPNLMMMHOJN<int, FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x25CC950", Offset = "0x25CBD50", VA = "0x1825CC950")]
		public FPKFBGDMAGD<int> DIJFOFNNPGM(int OFPOPHJFIBP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x25CC9D0", Offset = "0x25CBDD0", VA = "0x1825CC9D0")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x25CC860", Offset = "0x25CBC60", VA = "0x1825CC860", Slot = "6")]
		public void AMLDJGJFIHB(int FFCBHHABFJN, FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x25CC950", Offset = "0x25CBD50", VA = "0x1825CC950", Slot = "4")]
		private FPKFBGDMAGD<int> EKCAMNJDBMI(int OFPOPHJFIBP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x25CC9C0", Offset = "0x25CBDC0", VA = "0x1825CC9C0", Slot = "5")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> LFFAKABKGIH(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct DGOBJIDLCBL : DIDHMMCOFLK<int, FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x25CBCD0", Offset = "0x25CB0D0", VA = "0x1825CBCD0")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xCAA690", Offset = "0xCA9A90", VA = "0x180CAA690", Slot = "4")]
		public int EMONJGDKOMD(int FFCBHHABFJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
		public bool KPJIJHBBHLM(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "5")]
		private bool HINNCJDDOJG(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x25CBCC0", Offset = "0x25CB0C0", VA = "0x1825CBCC0", Slot = "6")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> CEEFHJMPPBB(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct BHPPLMMFCMJ : KPNLMMMHOJN<int, FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x25CB5E0", Offset = "0x25CA9E0", VA = "0x1825CB5E0")]
		public FPKFBGDMAGD<int> DIJFOFNNPGM(int OFPOPHJFIBP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x25CB660", Offset = "0x25CAA60", VA = "0x1825CB660")]
		public DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x25CB4E0", Offset = "0x25CA8E0", VA = "0x1825CB4E0", Slot = "6")]
		public void AMLDJGJFIHB(int FFCBHHABFJN, FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x25CB5E0", Offset = "0x25CA9E0", VA = "0x1825CB5E0", Slot = "4")]
		private FPKFBGDMAGD<int> EKCAMNJDBMI(int OFPOPHJFIBP, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(FPKFBGDMAGD<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x25CB650", Offset = "0x25CAA50", VA = "0x1825CB650", Slot = "5")]
		private DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> LFFAKABKGIH(int FFCBHHABFJN, [In] FPKFBGDMAGD<(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> Target, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> ByteCodeWriteLocation)> JPGIMCGBJEJ)
		{
			return default(DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct KOMGKBBGHPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> EGMLMIJMNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool BGOKIBPJMPO;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1C8CE10", Offset = "0x1C8C210", VA = "0x181C8CE10")]
		public KOMGKBBGHPC(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG, bool NLHJABCFAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x25D3FF0", Offset = "0x25D33F0", VA = "0x1825D3FF0")]
		public void COICBMCKFLC([Out] DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG, [Out] bool NLHJABCFAFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct DLJJCPHHMHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DDIPAIMAGGM<HAEPGAFINPD> CCAKIHAEIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> EGMLMIJMNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool BGOKIBPJMPO;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x25CBDA0", Offset = "0x25CB1A0", VA = "0x1825CBDA0")]
		public DLJJCPHHMHJ(DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG, bool NLHJABCFAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x25CBD70", Offset = "0x25CB170", VA = "0x1825CBD70")]
		public void COICBMCKFLC([Out] DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG, [Out] bool NLHJABCFAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x25CBD80", Offset = "0x25CB180", VA = "0x1825CBD80")]
		public void COICBMCKFLC([Out] DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG, [Out] DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL, [Out] bool NLHJABCFAFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LHPINHFJJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly DDIPAIMAGGM<HAEPGAFINPD> CCAKIHAEIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> EGMLMIJMNFM;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
		public LHPINHFJJAD(DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x25D4000", Offset = "0x25D3400", VA = "0x1825D4000")]
		public void COICBMCKFLC([Out] DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG, [Out] DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25CA2F0", Offset = "0x25C96F0", VA = "0x1825CA2F0")]
	public static void FKLDNICNGJG(this HDOMMPOBHDE IIICNLIAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25C97C0", Offset = "0x25C8BC0", VA = "0x1825C97C0")]
	public static void COBHDFEBBNF(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> ABBOKFIGLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25CA1D0", Offset = "0x25C95D0", VA = "0x1825CA1D0")]
	public static void FDOHNHNKCOA(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> ABBOKFIGLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25C9400", Offset = "0x25C8800", VA = "0x1825C9400")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>? CBAICILCNBG([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x25CABB0", Offset = "0x25C9FB0", VA = "0x1825CABB0")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> KKJIFJONPGH([In] this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25C98E0", Offset = "0x25C8CE0", VA = "0x1825C98E0")]
	private static void DGPJEMEPOBG(this HDOMMPOBHDE IIICNLIAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25C9530", Offset = "0x25C8930", VA = "0x1825C9530")]
	private static DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>? CDCPPFCDHLI([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x25C8F50", Offset = "0x25C8350", VA = "0x1825C8F50")]
	public static void ADLADMILGFE(this HDOMMPOBHDE IIICNLIAPBJ, [In] FPKFBGDMAGD<PFMKFLDPKCP> IOCACOMBHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x25CAFB0", Offset = "0x25CA3B0", VA = "0x1825CAFB0")]
	public static JDNPKKPOCNB.DBJALNHADMF NKGEJOKBOLL([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
	{
		return default(JDNPKKPOCNB.DBJALNHADMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x25C9650", Offset = "0x25C8A50", VA = "0x1825C9650")]
	public static FFAILDLPKDE<byte> CGCJLFGJEJN([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
	{
		return default(FFAILDLPKDE<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x25C9C30", Offset = "0x25C9030", VA = "0x1825C9C30")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLLHPIAEEJA([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25CB230", Offset = "0x25CA630", VA = "0x1825CB230")]
	public static LMMLKBHKBDN OOGMELIIGNE([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31FCC60", Offset = "0x31FC060", VA = "0x1831FCC60")]
	private static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> JEJHBOAIEPI<TMJoin>(this HDOMMPOBHDE IIICNLIAPBJ, JDNPKKPOCNB.DBJALNHADMF HJOIFMIMAPJ, DDIPAIMAGGM<TMJoin> NMHGMCOFDIG) where TMJoin : JDNPKKPOCNB.CNBKKPKEENB
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x25CA820", Offset = "0x25C9C20", VA = "0x1825CA820")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> IMMILHEHKBA(this HDOMMPOBHDE IIICNLIAPBJ, bool HFNHBPGHMBN)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25CAF20", Offset = "0x25CA320", VA = "0x1825CAF20")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> NHHACIKLBFN(this HDOMMPOBHDE IIICNLIAPBJ, FFAILDLPKDE<byte> KPLABGDDBEL)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x25C9740", Offset = "0x25C8B40", VA = "0x1825C9740")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> CIEDFDLMJDI(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> HKAPMMKADDG)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x25CAEA0", Offset = "0x25CA2A0", VA = "0x1825CAEA0")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> NCBFDKKHAPA(this HDOMMPOBHDE IIICNLIAPBJ, int IJNAPLMKODI)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x25C9230", Offset = "0x25C8630", VA = "0x1825C9230")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> BMKDMFMACNC(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31FCDB0", Offset = "0x31FC1B0", VA = "0x1831FCDB0")]
	private static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> MLOKNFMFIPK<TMJoin>(this HDOMMPOBHDE IIICNLIAPBJ, PCLIBJIEHIB.CCCLBJGCAGC HJOIFMIMAPJ, DDIPAIMAGGM<TMJoin> NMHGMCOFDIG) where TMJoin : PCLIBJIEHIB.NLGKKEEIGMN
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x25CA6F0", Offset = "0x25C9AF0", VA = "0x1825CA6F0")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> IAMBBBKKGJF(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25CB030", Offset = "0x25CA430", VA = "0x1825CB030")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> NLEIEKDHBNM(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x25CA670", Offset = "0x25C9A70", VA = "0x1825CA670")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> HPIPJGECDOB(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> HFNMOOKGHOG)
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25CA9D0", Offset = "0x25C9DD0", VA = "0x1825CA9D0")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> KAJBIJONKIB(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x25CB080", Offset = "0x25CA480", VA = "0x1825CB080")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> NONAKKLJDCK(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25CADC0", Offset = "0x25CA1C0", VA = "0x1825CADC0")]
	public static EIBNJLDMIAM.JNMIFBHKKNC MLGHFONGHNG([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> CGBBIIEKMKJ)
	{
		return default(EIBNJLDMIAM.JNMIFBHKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25CA8A0", Offset = "0x25C9CA0", VA = "0x1825CA8A0")]
	public static LLLPAHMDLKB<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>, INBCIIAFGCB<EIBNJLDMIAM.FJFDKMJGMFH>> IPEILNMIPJE([In] this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(LLLPAHMDLKB<DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>, INBCIIAFGCB<EIBNJLDMIAM.FJFDKMJGMFH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25C9A50", Offset = "0x25C8E50", VA = "0x1825C9A50")]
	public static DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> DHOBNNPPKDG([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> CGBBIIEKMKJ)
	{
		return default(DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25C92B0", Offset = "0x25C86B0", VA = "0x1825C92B0")]
	public static EIBNJLDMIAM.AMFLBHNENNP BPDBAKGDNAF([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> EPKLDPNABNI)
	{
		return default(EIBNJLDMIAM.AMFLBHNENNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25C91B0", Offset = "0x25C85B0", VA = "0x1825C91B0")]
	public static EIBNJLDMIAM.AMFLBHNENNP BEKLIPFGNLG(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> EPKLDPNABNI)
	{
		return default(EIBNJLDMIAM.AMFLBHNENNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31FCD10", Offset = "0x31FC110", VA = "0x1831FCD10")]
	private static DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> LFPDIFCONEL<TMJoin>(this HDOMMPOBHDE IIICNLIAPBJ, EIBNJLDMIAM.JNMIFBHKKNC HJOIFMIMAPJ, DDIPAIMAGGM<TMJoin> NMHGMCOFDIG) where TMJoin : EIBNJLDMIAM.JONBKGONACO
	{
		return default(DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25CA020", Offset = "0x25C9420", VA = "0x1825CA020")]
	public static (DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>) FCMIOOBFBEN(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default((DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25CAC10", Offset = "0x25CA010", VA = "0x1825CAC10")]
	public static (DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>) KNOJGALMPBA(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default((DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25CA2A0", Offset = "0x25C96A0", VA = "0x1825CA2A0")]
	public static DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> FGCJMEDOEEE(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25C9E60", Offset = "0x25C9260", VA = "0x1825C9E60")]
	public static void DPALMDDBLFH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH> EPKLDPNABNI, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> MKCOMLCDDAM, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>> NPLMCEEJPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31FB920", Offset = "0x31FAD20", VA = "0x1831FB920")]
	public static KOMGKBBGHPC DFGNNJNDCPJ<TDeps, TStateSys>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL) where TDeps : HIGMIGFBJIO<TStateSys>
	{
		return default(KOMGKBBGHPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31FCE60", Offset = "0x31FC260", VA = "0x1831FCE60")]
	public static DLJJCPHHMHJ PGLPPAIPJNJ<TDeps, TStateSys>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, int DEHGFPGBPMM) where TDeps : HIGMIGFBJIO<TStateSys>
	{
		return default(DLJJCPHHMHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x31FC750", Offset = "0x31FBB50", VA = "0x1831FC750")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>? HHNCIBCEEIE<TDeps, TStateSys>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, [In] ReadOnlySpan<int> LHIAFAACCHB, [In] Span<LHPINHFJJAD> PIJOAHPMNAB) where TDeps : HIGMIGFBJIO<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31FB260", Offset = "0x31FA660", VA = "0x1831FB260")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> BMNIMJKCFON<TDeps, TStateSys>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ) where TDeps : HIGMIGFBJIO<TStateSys>
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x25C8E60", Offset = "0x25C8260", VA = "0x1825C8E60")]
	public static NNPKNLLMHIB.MLBBGLAHPPK ACFBAMNMDGG([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC)
	{
		return default(NNPKNLLMHIB.MLBBGLAHPPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x25CA8E0", Offset = "0x25C9CE0", VA = "0x1825CA8E0")]
	public static NNPKNLLMHIB.BEGOLGONIMC JBAONEAFGMH([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC)
	{
		return default(NNPKNLLMHIB.BEGOLGONIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x25C90C0", Offset = "0x25C84C0", VA = "0x1825C90C0")]
	public static NNPKNLLMHIB.EMEGCDELBBO BACEBFIKIPH([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC)
	{
		return default(NNPKNLLMHIB.EMEGCDELBBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x25CAA20", Offset = "0x25C9E20", VA = "0x1825CAA20")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KAMFEIHNAPI(this HDOMMPOBHDE IIICNLIAPBJ, int? ACELBMOCJGD, string OGOCCCFKJPG)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x25CA730", Offset = "0x25C9B30", VA = "0x1825CA730")]
	public static NNPKNLLMHIB.LCIDMAJBBCI IJPPGLFBMDD([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC)
	{
		return default(NNPKNLLMHIB.LCIDMAJBBCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25CB470", Offset = "0x25CA870", VA = "0x1825CB470")]
	public static NNPKNLLMHIB.KDBNOFKOIHL PIBPIJFACEM([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC)
	{
		return default(NNPKNLLMHIB.KDBNOFKOIHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x25C94C0", Offset = "0x25C88C0", VA = "0x1825C94C0")]
	public static int? CCKLCJKDKMF([In] this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31FB820", Offset = "0x31FAC20", VA = "0x1831FB820")]
	private static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CBBPPPJDMJF<TMJoin>(this HDOMMPOBHDE IIICNLIAPBJ, int? ACELBMOCJGD, NNPKNLLMHIB.KDBNOFKOIHL HJOIFMIMAPJ, DDIPAIMAGGM<TMJoin> NMHGMCOFDIG) where TMJoin : NNPKNLLMHIB.JNBPAONIOKF
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x25CA5C0", Offset = "0x25C99C0", VA = "0x1825CA5C0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> GOOAEFJBCCC(this HDOMMPOBHDE IIICNLIAPBJ, int? ACELBMOCJGD, DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> CGBBIIEKMKJ, int FFCBHHABFJN)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25CAE40", Offset = "0x25CA240", VA = "0x1825CAE40")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> MMEPFMAKIDD(this HDOMMPOBHDE IIICNLIAPBJ, int? ACELBMOCJGD)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25CB320", Offset = "0x25CA720", VA = "0x1825CB320")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PGBCBGKGIFN(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? BBFADJDKAAF, int? ACELBMOCJGD)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25CB1A0", Offset = "0x25CA5A0", VA = "0x1825CB1A0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OIELGDOFOOD(this HDOMMPOBHDE IIICNLIAPBJ, int? ACELBMOCJGD, int FFCBHHABFJN)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25C95F0", Offset = "0x25C89F0", VA = "0x1825C95F0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CFGPKECHIID(this HDOMMPOBHDE IIICNLIAPBJ, int? ACELBMOCJGD)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25C9D20", Offset = "0x25C9120", VA = "0x1825C9D20")]
	public static void DMBBEKJMCFB(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK, DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> CGBBIIEKMKJ, int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25C9EF0", Offset = "0x25C92F0", VA = "0x1825C9EF0")]
	public static void EDCJDLBNBAG(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK, int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25CB0D0", Offset = "0x25CA4D0", VA = "0x1825CB0D0")]
	public static void OEFNFPPKCKH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25C9850", Offset = "0x25C8C50", VA = "0x1825C9850")]
	public static void DFKMCGNCEIJ(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> GACPILKGIFM, DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> FJACBNHCAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25C9330", Offset = "0x25C8730", VA = "0x1825C9330")]
	public static void BPDJKHFIKCN(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK, DDIPAIMAGGM<JGEBJEKIHIN<IHJPEIAEEFI>> KJDLAOKDIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x31FCB90", Offset = "0x31FBF90", VA = "0x1831FCB90")]
	public static void INDLCOBKLFE<M>(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBLLNADJFAK, DDIPAIMAGGM<JGEBJEKIHIN<BLMNBLBFGJK<M>>> KJDLAOKDIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HIGMIGFBJIO<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DDIPAIMAGGM<ELHHKLOAKFK> FOMPJJNGLCE(TStateSys KLICHOJOEBG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DDIPAIMAGGM<ELHHKLOAKFK> CLFEAMGLCEB(TStateSys KLICHOJOEBG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDIPAIMAGGM<ELHHKLOAKFK> ENBABDAIJAF(TStateSys KLICHOJOEBG);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DDIPAIMAGGM<ELHHKLOAKFK> OEENNPHFOGD(TStateSys KLICHOJOEBG);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> IJHFNKLMFGC(TStateSys KLICHOJOEBG, HDOMMPOBHDE FKFCNOEOCKJ, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> JAAPOFHAIGO(TStateSys KLICHOJOEBG, HDOMMPOBHDE FKFCNOEOCKJ, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GCLPHMCBPOP(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DDIPAIMAGGM<BIIAPNECPOC> HCNAKBOILIB(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL, int EDIOMDNEKAO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MHLAFIIDCMJ KIGAPJFIJOE(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MFDELBCLHPF(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int BLOPMDKFDDC(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FFAILDLPKDE<byte> PNHDBBGMKNF(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(FFAILDLPKDE<byte>, DDIPAIMAGGM<ELHHKLOAKFK>) JHOLHBAPAJB(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<HAEPGAFINPD> KPKAGMFKFEL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int PLJIGHGADIA(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DDIPAIMAGGM<HAEPGAFINPD> DLEIDAFJEBH(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<BIIAPNECPOC> BFKOLDCFMBJ, int DEHGFPGBPMM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DDIPAIMAGGM<HAEPGAFINPD> AJLCOGNJGLE(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, DDIPAIMAGGM<MJBBEHHNFNA> JFBLNBCAHJM, int DEHGFPGBPMM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int JBEGIKBGCEN(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? PBGNOIFPLOP(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, int FFCBHHABFJN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int MELBEKCIJMN(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? POLIHCNEMKA(TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ, int FFCBHHABFJN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class HGGCBFOBHKG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34DE250", Offset = "0x34DD650", VA = "0x1834DE250")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK?> NFHNKGAGJAP<T, TOpInput, TOpOutput>(this HDOMMPOBHDE IIICNLIAPBJ, T HGHHJPDLMPJ, T OLNKLOFDFBI, int DMCFCKIGIOE, IntPtr KEOONJFHAPA)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34DC9C0", Offset = "0x34DBDC0", VA = "0x1834DC9C0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK?> CKNBOCOHFFD<T, TOpInput, TOpOutput>(this HDOMMPOBHDE IIICNLIAPBJ, T HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI, int DMCFCKIGIOE, IntPtr KEOONJFHAPA)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x34DF7B0", Offset = "0x34DEBB0", VA = "0x1834DF7B0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK?> PHEAOHKECKC<TOpInput, TOpOutput>(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI, int DMCFCKIGIOE, IntPtr KEOONJFHAPA)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25CE4F0", Offset = "0x25CD8F0", VA = "0x1825CE4F0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CAIIJMBIOBH(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25CDD40", Offset = "0x25CD140", VA = "0x1825CDD40")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> AHFMKMAMLCO(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x25CF7D0", Offset = "0x25CEBD0", VA = "0x1825CF7D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> FEILLOEKLDM(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x25D0FE0", Offset = "0x25D03E0", VA = "0x1825D0FE0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KBELGLNIIBA(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x25D2140", Offset = "0x25D1540", VA = "0x1825D2140")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OHEHGIDOEEP(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x25D1A90", Offset = "0x25D0E90", VA = "0x1825D1A90")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> MMHOJDEGMNA(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x25D1910", Offset = "0x25D0D10", VA = "0x1825D1910")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> MIPGBCMJEPL(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x25D0030", Offset = "0x25CF430", VA = "0x1825D0030")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IEBCCEOHEMA(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x25CEF30", Offset = "0x25CE330", VA = "0x1825CEF30")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> EJPELDBMFNC(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x25CDAA0", Offset = "0x25CCEA0", VA = "0x1825CDAA0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> AEMFBKEJDBD(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, int OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x25D2420", Offset = "0x25D1820", VA = "0x1825D2420")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> ONHGLEDBMIO(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x25CDE60", Offset = "0x25CD260", VA = "0x1825CDE60")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> BGLAIKLDHDK(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x25D1CF0", Offset = "0x25D10F0", VA = "0x1825D1CF0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NBAOHNCNKJF(this HDOMMPOBHDE IIICNLIAPBJ, float HGHHJPDLMPJ, float OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x25CDFA0", Offset = "0x25CD3A0", VA = "0x1825CDFA0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> BHBGINKKJHC(this HDOMMPOBHDE IIICNLIAPBJ, float HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x25D15A0", Offset = "0x25D09A0", VA = "0x1825D15A0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> LFJLOJCFDAD(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x25D1A10", Offset = "0x25D0E10", VA = "0x1825D1A10")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> MJHEFAOHLOD(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, int OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x25CED10", Offset = "0x25CE110", VA = "0x1825CED10")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DJCPOHNHGLI(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x25CEEB0", Offset = "0x25CE2B0", VA = "0x1825CEEB0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> ECLIOPIKNPE(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x25D25C0", Offset = "0x25D19C0", VA = "0x1825D25C0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OPCKAIDEOMI(this HDOMMPOBHDE IIICNLIAPBJ, float HGHHJPDLMPJ, float OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x25D2260", Offset = "0x25D1660", VA = "0x1825D2260")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OIDKOCGOOFN(this HDOMMPOBHDE IIICNLIAPBJ, float HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x25D2640", Offset = "0x25D1A40", VA = "0x1825D2640")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PDBMPJAEBDH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x25D1890", Offset = "0x25D0C90", VA = "0x1825D1890")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> MEFNNFINHOP(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, int OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x25D2950", Offset = "0x25D1D50", VA = "0x1825D2950")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PMKHJOHNNJK(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x25D1BD0", Offset = "0x25D0FD0", VA = "0x1825D1BD0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> MMONCDADIDA(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x25D0150", Offset = "0x25CF550", VA = "0x1825D0150")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IHKKPHJONOG(this HDOMMPOBHDE IIICNLIAPBJ, float HGHHJPDLMPJ, float OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x25D2760", Offset = "0x25D1B60", VA = "0x1825D2760")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PJKKBMCFBMA(this HDOMMPOBHDE IIICNLIAPBJ, float HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x25CFE70", Offset = "0x25CF270", VA = "0x1825CFE70")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IAEADLKDHMC(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x25D0A30", Offset = "0x25CFE30", VA = "0x1825D0A30")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> JKHOGLOMODJ(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x25CEB50", Offset = "0x25CDF50", VA = "0x1825CEB50")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> DDAIIDGDLIK(this HDOMMPOBHDE IIICNLIAPBJ, int PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x25D26C0", Offset = "0x25D1AC0", VA = "0x1825D26C0")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> PGDFHJJPKBI(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x25D16E0", Offset = "0x25D0AE0", VA = "0x1825D16E0")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> MAJKPJGGOFJ(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FHBAIEEHGNG)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x25D2540", Offset = "0x25D1940", VA = "0x1825D2540")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> OOEBNKPEKFI(this HDOMMPOBHDE IIICNLIAPBJ, int PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x25D1C50", Offset = "0x25D1050", VA = "0x1825D1C50")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> MPCPPHGENGH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x25D03D0", Offset = "0x25CF7D0", VA = "0x1825D03D0")]
	public static (DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>) JFAAONDEKJH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<OCOFJJGLOAJ> ELCFLEOHIJE, [In] ReadOnlySpan<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> BMMAKKAHGMI, [In] ReadOnlySpan<int?> NEDNHCIPCKO, [In] Span<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> ENHJPBHLOKH)
	{
		return default((DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x25CF390", Offset = "0x25CE790", VA = "0x1825CF390")]
	public static (DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>) FDINFLLDCKN(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JIDAEHPGGPO> HEIAIGNEKDF, [In] ReadOnlySpan<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> BMMAKKAHGMI, [In] ReadOnlySpan<int?> NEDNHCIPCKO, [In] Span<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> ENHJPBHLOKH)
	{
		return default((DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x34DE150", Offset = "0x34DD550", VA = "0x1834DE150")]
	public static (DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<ELHHKLOAKFK>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<TMarker>>, DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>) MOEFCGELAEP<TMarker>(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<ELHHKLOAKFK> CBFFBBKECOB, [In] ReadOnlySpan<byte> MJFOKKFMONL)
	{
		return default((DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<JGEBJEKIHIN<ELHHKLOAKFK>>, DDIPAIMAGGM<JGEBJEKIHIN<PPJMDEDELHN>>, DDIPAIMAGGM<JGEBJEKIHIN<TMarker>>, DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x25CF2D0", Offset = "0x25CE6D0", VA = "0x1825CF2D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> ENNONOEDDFE(this HDOMMPOBHDE IIICNLIAPBJ, int HHINCEGHBKK, [Optional] DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x25D27E0", Offset = "0x25D1BE0", VA = "0x1825D27E0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PLDMEMKOHJN(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HHINCEGHBKK, [Optional] DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x25CFB70", Offset = "0x25CEF70", VA = "0x1825CFB70")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HCODPCAEGAJ(this HDOMMPOBHDE IIICNLIAPBJ, [In] ReadOnlySpan<byte> HHINCEGHBKK, [Optional] DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x25CE5F0", Offset = "0x25CD9F0", VA = "0x1825CE5F0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CAMGPNLEHGD(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HHINCEGHBKK, int NBPEDBIONNC, [Optional] DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x25D01D0", Offset = "0x25CF5D0", VA = "0x1825D01D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IIADAOENIKM(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x25CF1B0", Offset = "0x25CE5B0", VA = "0x1825CF1B0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> EMNFJIALPLP(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x25CD960", Offset = "0x25CCD60", VA = "0x1825CD960")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> AAKJFJMKNKG(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x25D2B10", Offset = "0x25D1F10", VA = "0x1825D2B10")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PPAALAOOEJA(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x25CE0D0", Offset = "0x25CD4D0", VA = "0x1825CE0D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> BHNCJMAGAFL(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x25D10E0", Offset = "0x25D04E0", VA = "0x1825D10E0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KGMICFAPDKM(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25D28D0", Offset = "0x25D1CD0", VA = "0x1825D28D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PLKGGANOBIO(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, int OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x25D0F60", Offset = "0x25D0360", VA = "0x1825D0F60")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> KAIPHPGHECK(this HDOMMPOBHDE IIICNLIAPBJ, int HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x25CDCC0", Offset = "0x25CD0C0", VA = "0x1825CDCC0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> AHANJGADAMH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HGHHJPDLMPJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OLNKLOFDFBI)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x25D0930", Offset = "0x25CFD30", VA = "0x1825D0930")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> JJHAPEMJACI(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x25D2010", Offset = "0x25D1410", VA = "0x1825D2010")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NOHEIBMACCF(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x25CFA10", Offset = "0x25CEE10", VA = "0x1825CFA10")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> FOFNIOGNMAJ(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x25CE710", Offset = "0x25CDB10", VA = "0x1825CE710")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CFLDNLJNOGP(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x25D0BE0", Offset = "0x25CFFE0", VA = "0x1825D0BE0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> JKJHODFNDIA(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x25CFEF0", Offset = "0x25CF2F0", VA = "0x1825CFEF0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IAIKKFEEIEP(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x25CFB50", Offset = "0x25CEF50", VA = "0x1825CFB50")]
	public static DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>> GPDPCAINLHM(this HDOMMPOBHDE IIICNLIAPBJ)
	{
		return default(DDIPAIMAGGM<JGEBJEKIHIN<JGEBJEKIHIN<KHCMNODBABG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x25CFC60", Offset = "0x25CF060", VA = "0x1825CFC60")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HHJCIEAJNIL(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x25CDBA0", Offset = "0x25CCFA0", VA = "0x1825CDBA0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> AFEDIBDAFOJ(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x25CF070", Offset = "0x25CE470", VA = "0x1825CF070")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> ELOKJOFLJNA(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x25D1DF0", Offset = "0x25D11F0", VA = "0x1825D1DF0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NFPBKFGAOOG(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x25CED90", Offset = "0x25CE190", VA = "0x1825CED90")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> ECGJNHGGCCC(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x25CEBD0", Offset = "0x25CDFD0", VA = "0x1825CEBD0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DFPFCLFFJGL(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x25CE910", Offset = "0x25CDD10", VA = "0x1825CE910")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CLOAAELIMMJ(this HDOMMPOBHDE IIICNLIAPBJ, int PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x25CFD60", Offset = "0x25CF160", VA = "0x1825CFD60")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HKAPNLFGIIJ(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> PEBNJNGMMHE)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x25D0E20", Offset = "0x25D0220", VA = "0x1825D0E20")]
	public static void JNCGAAKJODO(this HDOMMPOBHDE IIICNLIAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x25CE810", Offset = "0x25CDC10", VA = "0x1825CE810")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CHJNNMIMDGJ(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, float IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x25D0D00", Offset = "0x25D0100", VA = "0x1825D0D00")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> JMJGIDPLBJC(this HDOMMPOBHDE IIICNLIAPBJ, float DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x25CEA10", Offset = "0x25CDE10", VA = "0x1825CEA10")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DCAMFDHKGDH(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x25D02D0", Offset = "0x25CF6D0", VA = "0x1825D02D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> JAOFAAKNLNK(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x25D0810", Offset = "0x25CFC10", VA = "0x1825D0810")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> JGLFPPFKEJH(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x25D22E0", Offset = "0x25D16E0", VA = "0x1825D22E0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> OKGGGBHHOFN(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x25D1220", Offset = "0x25D0620", VA = "0x1825D1220")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> LAOGACHFEAC(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> NJMEIGBHGAE, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> KNOCFOMGDBB)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x25CF910", Offset = "0x25CED10", VA = "0x1825CF910")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> FMNBPDCEKAI(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, int IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x25D1EF0", Offset = "0x25D12F0", VA = "0x1825D1EF0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NMHNMNLPBFM(this HDOMMPOBHDE IIICNLIAPBJ, int DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x25D29D0", Offset = "0x25D1DD0", VA = "0x1825D29D0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> POOEECIHCPM(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> DLGPHICDAGP, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> IMFBFGLLCGO)
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x34DD380", Offset = "0x34DC780", VA = "0x1834DD380")]
	public static void EILAOFAPHHE<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<OCOFJJGLOAJ> ELCFLEOHIJE, [In] ReadOnlySpan<DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>> CBBEHDBLKDL, [In] ReadOnlySpan<int?> NEDNHCIPCKO, [In] Span<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> ENHJPBHLOKH, [In] Span<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> PICKMEOAEOL, [In] ReadOnlySpan<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>?> NHFJMAMCKCH) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x34DDBB0", Offset = "0x34DCFB0", VA = "0x1834DDBB0")]
	public static void MIFDOCJPOMF<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<JIDAEHPGGPO> JPHIIBFAEAA, [In] ReadOnlySpan<DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>> DMAOLFBHCMA, [In] ReadOnlySpan<int?> NEDNHCIPCKO, [In] Span<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> ENHJPBHLOKH, [In] Span<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>> PICKMEOAEOL, [In] ReadOnlySpan<DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>?> NHFJMAMCKCH) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x34DCD60", Offset = "0x34DC160", VA = "0x1834DCD60")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> CLOPOGJELAH<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> BBFADJDKAAF, [Optional] DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x34DE550", Offset = "0x34DD950", VA = "0x1834DE550")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NHPONCOFFIN<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> HFNMOOKGHOG, [Optional] DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x34DCF40", Offset = "0x34DC340", VA = "0x1834DCF40")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> DJHDEPBHNAJ<TDeps, TStateSys>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG) where TDeps : notnull, HIGMIGFBJIO<TStateSys> where TStateSys : notnull
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x34DD170", Offset = "0x34DC570", VA = "0x1834DD170")]
	public static DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF> EEKEOFLGHDA<TDeps, TStateSys>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG) where TDeps : notnull, HIGMIGFBJIO<TStateSys> where TStateSys : notnull
	{
		return default(DDIPAIMAGGM<PCLIBJIEHIB.CGIJBLKMJOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x25D0E30", Offset = "0x25D0230", VA = "0x1825D0E30")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> KAHNOACFFFM(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> DPHNBCDMBFB, IntPtr EIDDFFKKHAA, IntPtr EICJNKBBKJN)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x25CE1F0", Offset = "0x25CD5F0", VA = "0x1825CE1F0")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> BJJABMPOOHL(this HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> MDJDECACGFM, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FGOKCKMCKLE, IntPtr ILIOGDOCAFL, IntPtr FHKGOGEHHJO, IntPtr KNBKKIGDFGF, bool DBFJNDNLNMD)
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x34DED60", Offset = "0x34DE160", VA = "0x1834DED60")]
	public static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> OENPPJNKIKC<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<OCOFJJGLOAJ> HACOPPAOMJB, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> MDJDECACGFM, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FGOKCKMCKLE, int? EDAFBNIKGBP, [Optional] IntPtr PGHHBAGIDFE) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x34DEF70", Offset = "0x34DE370", VA = "0x1834DEF70")]
	private static DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> OENPPJNKIKC<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<OCOFJJGLOAJ> HACOPPAOMJB, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> MDJDECACGFM, DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB> FGOKCKMCKLE, int? EDAFBNIKGBP) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
		return default(DDIPAIMAGGM<JDNPKKPOCNB.EANLEKIPACB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x34DE9B0", Offset = "0x34DDDB0", VA = "0x1834DE9B0")]
	public static DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNFOENMINLM<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> HHINCEGHBKK, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>? LKAFJIABCIL) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
		return default(DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34DD920", Offset = "0x34DCD20", VA = "0x1834DD920")]
	public static void JDANIPCAOEG<TDeps, TState>(this HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TState MLIDEILJAJE, int FDIAJAAABDF) where TDeps : notnull, HIGMIGFBJIO<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct FKAGJBMFKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> HFNFMJCNIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> MKFLMOMEBLM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
	public FKAGJBMFKEE(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> IDOBMIDOJDF, DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> PLFAHGHBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x25CCA90", Offset = "0x25CBE90", VA = "0x1825CCA90")]
	public static FKAGJBMFKEE KMDIICJFNJF(DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>> IDOBMIDOJDF)
	{
		return default(FKAGJBMFKEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NNPKNLLMHIB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class HMHCOMKKEPK : JNBPAONIOKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct MLBBGLAHPPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> EHJODMIAAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int NGGCGOFGPAK;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
		public MLBBGLAHPPK(DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> CGBBIIEKMKJ, int FFCBHHABFJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NFCIIBGLDDC : JNBPAONIOKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BEGOLGONIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int NGGCGOFGPAK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public BEGOLGONIMC(int FFCBHHABFJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CCEHDOOECHI : JNBPAONIOKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct EMEGCDELBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> EHJODMIAAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int NGGCGOFGPAK;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
		public EMEGCDELBBO(DDIPAIMAGGM<EIBNJLDMIAM.EGKEGAECMAD> CGBBIIEKMKJ, int FFCBHHABFJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum KDBNOFKOIHL
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
	public sealed class BKBKLILFFDK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class JNBPAONIOKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FDCDGPHCPAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? MBGEGHENELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FKAGJBMFKEE BCMOBLHHAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KDBNOFKOIHL BLLEJPAJECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DDIPAIMAGGM<JNBPAONIOKF> FBOENDJJEKJ;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x25CCA70", Offset = "0x25CBE70", VA = "0x1825CCA70")]
		public FDCDGPHCPAD(int? ACELBMOCJGD, [In] FKAGJBMFKEE MNKOMAFEGLJ, KDBNOFKOIHL HJOIFMIMAPJ, DDIPAIMAGGM<JNBPAONIOKF> NMHGMCOFDIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class ICIPKABNMCO : JNBPAONIOKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct LCIDMAJBBCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int NGGCGOFGPAK;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		public LCIDMAJBBCI(int FFCBHHABFJN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal NFPDFMAELEC<BKBKLILFFDK, FDCDGPHCPAD> DCDANBJLAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal NFPDFMAELEC<HMHCOMKKEPK, MLBBGLAHPPK> OOOCCDOCGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal NFPDFMAELEC<CCEHDOOECHI, EMEGCDELBBO> CGGODLBLFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal NFPDFMAELEC<ICIPKABNMCO, LCIDMAJBBCI> MPFFIOECJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal NFPDFMAELEC<NFCIIBGLDDC, BEGOLGONIMC> LHMDDHPOKCN;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x25D42B0", Offset = "0x25D36B0", VA = "0x1825D42B0")]
	private NNPKNLLMHIB([In] NFPDFMAELEC<BKBKLILFFDK, FDCDGPHCPAD> LDBKEKHLIEE, [In] NFPDFMAELEC<HMHCOMKKEPK, MLBBGLAHPPK> OPLENCMLCCF, [In] NFPDFMAELEC<CCEHDOOECHI, EMEGCDELBBO> JOIKMPNFILM, [In] NFPDFMAELEC<ICIPKABNMCO, LCIDMAJBBCI> IHOPFDHLJMM, [In] NFPDFMAELEC<NFCIIBGLDDC, BEGOLGONIMC> PKFFIEKDBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x25D40C0", Offset = "0x25D34C0", VA = "0x1825D40C0")]
	public static NNPKNLLMHIB KMDIICJFNJF()
	{
		return default(NNPKNLLMHIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class DGGNCGJAPOL
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x25CBC10", Offset = "0x25CB010", VA = "0x1825CBC10")]
	public static void FKLDNICNGJG(this NNPKNLLMHIB IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BINHFMHMFNC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x25CB700", Offset = "0x25CAB00", VA = "0x1825CB700")]
	public static void GNAFMGAEBCA(HDOMMPOBHDE IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct IINNCFHJAMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, GKGKFPDGLPA> PMGPIOKIIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int BIJPNFLFKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int IHMDGGIBCOP;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x25D2F30", Offset = "0x25D2330", VA = "0x1825D2F30")]
	private IINNCFHJAMH([In] NFPEEHNJFJP<EIBNJLDMIAM.FJFDKMJGMFH, GKGKFPDGLPA> IJKNDFOGMAP, int PPBHOGINAOH, int PLOJEACDKKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x25D2EC0", Offset = "0x25D22C0", VA = "0x1825D2EC0")]
	public static IINNCFHJAMH KMDIICJFNJF()
	{
		return default(IINNCFHJAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25D2CD0", Offset = "0x25D20D0", VA = "0x1825D2CD0")]
	public void FKLDNICNGJG([In] HDOMMPOBHDE GAGLNNPOAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3500950", Offset = "0x34FFD50", VA = "0x183500950")]
	public static void GNAFMGAEBCA<TDeps, TStateSys>(HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG, DDIPAIMAGGM<HFJKEPEKFIF> BPHNGBDIGAJ) where TDeps : notnull, HIGMIGFBJIO<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DOKCINMOBMH
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x25CBDB0", Offset = "0x25CB1B0", VA = "0x1825CBDB0")]
	public static void GNAFMGAEBCA(HDOMMPOBHDE IIICNLIAPBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IJHDAPBNDGA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface IKMFJECGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CPELHBMDFFD(FPKFBGDMAGD<byte> PCJJNAMDCMK, int MPOHMNEOCNH);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct OPIMPJDAMAG : IKMFJECGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x25D4460", Offset = "0x25D3860", VA = "0x1825D4460", Slot = "4")]
		public void CPELHBMDFFD(FPKFBGDMAGD<byte> PCJJNAMDCMK, int MPOHMNEOCNH)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct CGGPBHPNAGH : IKMFJECGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x25CBAE0", Offset = "0x25CAEE0", VA = "0x1825CBAE0", Slot = "4")]
		public void CPELHBMDFFD(FPKFBGDMAGD<byte> PCJJNAMDCMK, int MPOHMNEOCNH)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct CLAIJOEKBOK : IKMFJECGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x25CBB90", Offset = "0x25CAF90", VA = "0x1825CBB90", Slot = "4")]
		public void CPELHBMDFFD(FPKFBGDMAGD<byte> PCJJNAMDCMK, int MPOHMNEOCNH)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct HPBAGJNNDNB : IKMFJECGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x25D2C20", Offset = "0x25D2020", VA = "0x1825D2C20", Slot = "4")]
		public void CPELHBMDFFD(FPKFBGDMAGD<byte> PCJJNAMDCMK, int MPOHMNEOCNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class PIIHPCGJHBK<TCallProcessorDeps> where TCallProcessorDeps : struct, IKMFJECGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps JPIGDBMGNPA;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9CF0", Offset = "0x3AE90F0", VA = "0x183AE9CF0")]
		public static int GNAFMGAEBCA<TDeps, TStateSys>(TDeps BDKFMFBFJII, TStateSys MLIDEILJAJE, HDOMMPOBHDE GAGLNNPOAHI, [In] FPKFBGDMAGD<byte> ELDECOCPLHM, int LDBPBJLJEDK) where TDeps : HIGMIGFBJIO<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private FPKFBGDMAGD<PFMKFLDPKCP> FLEDILFNMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>> DJHFFOELOPP;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x25D3070", Offset = "0x25D2470", VA = "0x1825D3070")]
	private IJHDAPBNDGA([In] FPKFBGDMAGD<PFMKFLDPKCP> IOCACOMBHCN, Dictionary<DDIPAIMAGGM<JGEBJEKIHIN<KHCMNODBABG>>, DDIPAIMAGGM<EIBNJLDMIAM.FJFDKMJGMFH>> OGNHNDAGAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x25D2FB0", Offset = "0x25D23B0", VA = "0x1825D2FB0")]
	public static IJHDAPBNDGA KMDIICJFNJF()
	{
		return default(IJHDAPBNDGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x25D2F70", Offset = "0x25D2370", VA = "0x1825D2F70")]
	public void FKLDNICNGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3503190", Offset = "0x3502590", VA = "0x183503190")]
	public static void GNAFMGAEBCA<TDeps, TStateSys>(HDOMMPOBHDE IIICNLIAPBJ, TDeps BDKFMFBFJII, TStateSys KLICHOJOEBG) where TDeps : HIGMIGFBJIO<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class KJBNIJLHPBK
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct FFFCEJDNAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> JPLIJLPGLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int HPNLOIPLECN;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int MGIEMIIKDOJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int AEBDNOHJEKB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x25D38E0", Offset = "0x25D2CE0", VA = "0x1825D38E0")]
	public static void GNAFMGAEBCA(HDOMMPOBHDE IIICNLIAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x25D3750", Offset = "0x25D2B50", VA = "0x1825D3750")]
	private static void BCDGLHHDOGD([In] HDOMMPOBHDE IIICNLIAPBJ, DDIPAIMAGGM<NNPKNLLMHIB.BKBKLILFFDK> NNKBGKICBEC, FPKFBGDMAGD<byte> IJMBFMMGIJD, List<FFFCEJDNAJG> PPFKJGHKMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x25D3610", Offset = "0x25D2A10", VA = "0x1825D3610")]
	private static void BCDGLHHDOGD(FPKFBGDMAGD<byte> IJMBFMMGIJD, int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x25D34E0", Offset = "0x25D28E0", VA = "0x1825D34E0")]
	private static void ALJLKDDPJMH(HDOMMPOBHDE IIICNLIAPBJ, List<FFFCEJDNAJG> PPFKJGHKMPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class AFDOAHHIDCG<TDeps, TIndex, TValues> where TDeps : struct, KPNLMMMHOJN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x462DAA0", Offset = "0x462CEA0", VA = "0x18462DAA0")]
	public static void GNAFMGAEBCA([In] FPKFBGDMAGD<PFMKFLDPKCP> IOCACOMBHCN, int OFPOPHJFIBP, TValues JPGIMCGBJEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface KPNLMMMHOJN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FPKFBGDMAGD<TIndex> DIJFOFNNPGM(int OFPOPHJFIBP, [In] TValues JPGIMCGBJEJ);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(TIndex FFCBHHABFJN, [In] TValues JPGIMCGBJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMLDJGJFIHB(TIndex FFCBHHABFJN, TValues JPGIMCGBJEJ, DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> PEBNJNGMMHE);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface DIDHMMCOFLK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex EMONJGDKOMD(int FFCBHHABFJN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPJIJHBBHLM(TIndex FFCBHHABFJN, [In] TValues JPGIMCGBJEJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDIPAIMAGGM<JGEBJEKIHIN<IAEDDOGNOPD>> MOHFIKDEHII(TIndex FFCBHHABFJN, [In] TValues JPGIMCGBJEJ);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class NLOPGIPFHML<TDeps, TIndex, TValues> where TDeps : struct, DIDHMMCOFLK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4E916A0", Offset = "0x4E90AA0", VA = "0x184E916A0")]
	public static FPKFBGDMAGD<TIndex> GNAFMGAEBCA(int OFPOPHJFIBP, [In] TValues JPGIMCGBJEJ)
	{
		return default(FPKFBGDMAGD<TIndex>);
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
