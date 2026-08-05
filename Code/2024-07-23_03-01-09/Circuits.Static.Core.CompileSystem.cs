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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA620", Offset = "0x1FD9820", VA = "0x181FDA620")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JAGGKPOBNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> BMEOCDAJLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int FGGMJJKKBCO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
	public JAGGKPOBNJB(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> OODHBEDJENO, int PENDBLHFGOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JKNFFJDDHLF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EKEGIGGPDKM : INHKIAEHDOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NDLPIAPDFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly LHCIICLJEAC<byte> FFDJEBPLBGD;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F829D0", Offset = "0x1F81BD0", VA = "0x181F829D0")]
		public NDLPIAPDFKL(LHCIICLJEAC<byte> DDNKCFIIBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FD96E0", Offset = "0x1FD88E0", VA = "0x181FD96E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class CIAEOFEBFPB : INHKIAEHDOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MHAFMGADGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> FMNNAFLEBKM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public MHAFMGADGHI(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> FPCDKEGNGEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum NDLGEKBMCGK
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
	public sealed class DKONFINEJAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class INHKIAEHDOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct JLNNBGDFALK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly NDLGEKBMCGK INCGKENDBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly OMNCLBBEMMM<INHKIAEHDOO> MHDAKKGFBEH;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
		public JLNNBGDFALK(NDLGEKBMCGK OMHMMFFCKOG, OMNCLBBEMMM<INHKIAEHDOO> NOFDJJFHNGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IGOINHNEJHB : INHKIAEHDOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct IICEAIDBKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> NCKMCOPJALF;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public IICEAIDBKAN(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class CFLMNNHELEM : INHKIAEHDOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct OOOJAOAIEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly NKFCAEJKJCA OAPHBBJFBFH;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public OOOJAOAIEMK(NKFCAEJKJCA HKHIANAINEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA800", Offset = "0x1FD9A00", VA = "0x181FDA800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal IIMPOGHAHMM<DKONFINEJAP, JLNNBGDFALK> APHGBNPKNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal IIMPOGHAHMM<EKEGIGGPDKM, NDLPIAPDFKL> MLIBNNBLKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal IIMPOGHAHMM<CIAEOFEBFPB, MHAFMGADGHI> ILNKNGFHDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal IIMPOGHAHMM<IGOINHNEJHB, IICEAIDBKAN> KAALMKPCGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal IIMPOGHAHMM<CFLMNNHELEM, OOOJAOAIEMK> FPLODLPDMNE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9120", Offset = "0x1FD8320", VA = "0x181FD9120")]
	private JKNFFJDDHLF([In] IIMPOGHAHMM<DKONFINEJAP, JLNNBGDFALK> NNPIJKHHMEE, [In] IIMPOGHAHMM<EKEGIGGPDKM, NDLPIAPDFKL> OMNBNNOFEJE, [In] IIMPOGHAHMM<CIAEOFEBFPB, MHAFMGADGHI> HNOODKMJFAP, [In] IIMPOGHAHMM<IGOINHNEJHB, IICEAIDBKAN> HHDDDJKHGDJ, [In] IIMPOGHAHMM<CFLMNNHELEM, OOOJAOAIEMK> NGGDHOMIOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8FE0", Offset = "0x1FD81E0", VA = "0x181FD8FE0")]
	public static JKNFFJDDHLF FJAAFKPDAIA()
	{
		return default(JKNFFJDDHLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OCBFEOJFEAP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA6A0", Offset = "0x1FD98A0", VA = "0x181FDA6A0")]
	public static void CKOHIKCJKJA(this JKNFFJDDHLF HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum LMACHENEFKE
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
public struct BJNHOMGEGMG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class GGEOKCGFMME : NMENLCCBAKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct KECNFFCBBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GEMIKJLJDJJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public KECNFFCBBDF(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> JNPOCCFBJPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum KNJHGLJJIBN
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
	public sealed class JOKEIDIIHCA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class NMENLCCBAKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct NNIIOGLENEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly KNJHGLJJIBN INCGKENDBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly OMNCLBBEMMM<NMENLCCBAKO> MHDAKKGFBEH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
		public NNIIOGLENEL(KNJHGLJJIBN OMHMMFFCKOG, OMNCLBBEMMM<NMENLCCBAKO> NOFDJJFHNGO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal IIMPOGHAHMM<JOKEIDIIHCA, NNIIOGLENEL> APHGBNPKNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal IIMPOGHAHMM<GGEOKCGFMME, KECNFFCBBDF> HDFCBDDILPG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4EB0", Offset = "0x1FD40B0", VA = "0x181FD4EB0")]
	private BJNHOMGEGMG([In] IIMPOGHAHMM<JOKEIDIIHCA, NNIIOGLENEL> NNPIJKHHMEE, [In] IIMPOGHAHMM<GGEOKCGFMME, KECNFFCBBDF> BAPLPGFILDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4E20", Offset = "0x1FD4020", VA = "0x181FD4E20")]
	public static BJNHOMGEGMG FJAAFKPDAIA()
	{
		return default(BJNHOMGEGMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JPGPCNKHNCH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FD91B0", Offset = "0x1FD83B0", VA = "0x181FD91B0")]
	public static void CKOHIKCJKJA(this BJNHOMGEGMG HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DBNGFIBEHEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public MAHDLFLAHIJ<int> MJNEJGLDNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public MAHDLFLAHIJ<int> BAOLKHGNFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JDJNOFAINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int ICMEMFDHMEN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FD52A0", Offset = "0x1FD44A0", VA = "0x181FD52A0")]
	private DBNGFIBEHEK([In] MAHDLFLAHIJ<int> BGONPBEGFBJ, [In] MAHDLFLAHIJ<int> MAJHJKJBFGD, int PLDCCJLOGOI, int EECKACJLLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5200", Offset = "0x1FD4400", VA = "0x181FD5200")]
	public static DBNGFIBEHEK FJAAFKPDAIA()
	{
		return default(DBNGFIBEHEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FINACAFCJAK
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5B40", Offset = "0x1FD4D40", VA = "0x181FD5B40")]
	public static void CKOHIKCJKJA(this DBNGFIBEHEK HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CHLNNCNOLPG
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum LKOONHPBMBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class HJIAADDOLKD : DDDBHABKGBH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct HCMCHEMMCAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly OMNCLBBEMMM<MLKINMPODCP> ACGLKJGEJDN;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public HCMCHEMMCAL(OMNCLBBEMMM<MLKINMPODCP> FHJEMFKIFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class NEGLCKNFHHF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class DDDBHABKGBH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct EGFMEDOENMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly LKOONHPBMBC INCGKENDBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly OMNCLBBEMMM<DDDBHABKGBH> MHDAKKGFBEH;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
		private EGFMEDOENMI(LKOONHPBMBC OMHMMFFCKOG, OMNCLBBEMMM<DDDBHABKGBH> NOFDJJFHNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5430", Offset = "0x1FD4630", VA = "0x181FD5430")]
		public static EGFMEDOENMI FJAAFKPDAIA(LKOONHPBMBC OMHMMFFCKOG, OMNCLBBEMMM<DDDBHABKGBH> NOFDJJFHNGO)
		{
			return default(EGFMEDOENMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class NDKAKALPMJB : DDDBHABKGBH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct DNAPAFFGGMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly OMNCLBBEMMM<MLKINMPODCP> ACGLKJGEJDN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public DNAPAFFGGMI(OMNCLBBEMMM<MLKINMPODCP> FHJEMFKIFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class MLKINMPODCP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct KAJKIGJDNOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MAHDLFLAHIJ<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> IHCCOEFDOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MAHDLFLAHIJ<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> PGHDIANCANK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4EB0", Offset = "0x1FD40B0", VA = "0x181FD4EB0")]
		private KAJKIGJDNOL([In] MAHDLFLAHIJ<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> AHNMHBFDPAL, [In] MAHDLFLAHIJ<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> HGMJDJJKDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9210", Offset = "0x1FD8410", VA = "0x181FD9210")]
		public static KAJKIGJDNOL FJAAFKPDAIA()
		{
			return default(KAJKIGJDNOL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal IIMPOGHAHMM<NEGLCKNFHHF, EGFMEDOENMI> APHGBNPKNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal IIMPOGHAHMM<NDKAKALPMJB, DNAPAFFGGMI> BIFMBIHAAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal IIMPOGHAHMM<HJIAADDOLKD, HCMCHEMMCAL> GOBCOCADPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal MAHDLFLAHIJ<(OMNCLBBEMMM<NEGLCKNFHHF> CallId, OMNCLBBEMMM<MLKINMPODCP> IOId)> NHNNAHKJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IIMPOGHAHMM<MLKINMPODCP, KAJKIGJDNOL> NGMKNEHNCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal PCDHHAOMILC<MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> EAJNNOPFFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal PCDHHAOMILC<MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> OCIBMMLNKNH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5140", Offset = "0x1FD4340", VA = "0x181FD5140")]
	private CHLNNCNOLPG([In] IIMPOGHAHMM<NEGLCKNFHHF, EGFMEDOENMI> NNPIJKHHMEE, [In] IIMPOGHAHMM<NDKAKALPMJB, DNAPAFFGGMI> LPGJAOFJOAD, [In] IIMPOGHAHMM<HJIAADDOLKD, HCMCHEMMCAL> OJLMBCGDLAB, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<NEGLCKNFHHF> CallId, OMNCLBBEMMM<MLKINMPODCP> IOId)> MPDMCDHCMDB, [In] IIMPOGHAHMM<MLKINMPODCP, KAJKIGJDNOL> OLFIEKOGBIA, [In] PCDHHAOMILC<MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> IDKPLNLIIBF, [In] PCDHHAOMILC<MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> EBPBBAGJEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4FA0", Offset = "0x1FD41A0", VA = "0x181FD4FA0")]
	public static CHLNNCNOLPG FJAAFKPDAIA()
	{
		return default(CHLNNCNOLPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HGPIAHLHOJB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FD88B0", Offset = "0x1FD7AB0", VA = "0x181FD88B0")]
	private static void CKOHIKCJKJA(this CHLNNCNOLPG.KAJKIGJDNOL HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8900", Offset = "0x1FD7B00", VA = "0x181FD8900")]
	public static void CKOHIKCJKJA(this CHLNNCNOLPG HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NONHMEFJOIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public MAHDLFLAHIJ<byte> BLGLFPINEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CHLNNCNOLPG GBOIFHCHGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal PICJDPBAIJH CFLPFDEOFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> KLMCAANMHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JKNFFJDDHLF FCDMNDHAHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal BJNHOMGEGMG PJACFMHEHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal PCDHHAOMILC<OKPLNKOBIDG, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>?> IOKFAKMDNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal MAHDLFLAHIJ<OMNCLBBEMMM<OKPLNKOBIDG>> GPKFKFMPAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> CNNGIKLCOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> GHOPIDDIKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> BJOAPAOJKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal FEBJFOOPNHB OODIHBNPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal IGLBFDLJGIL ACPHIKEAKBO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA2C0", Offset = "0x1FD94C0", VA = "0x181FDA2C0")]
	private NONHMEFJOIK([In] MAHDLFLAHIJ<byte> IPNOEBHFNMF, [In] CHLNNCNOLPG AHHFKMHMCJC, [In] PICJDPBAIJH LIENPAIFMIH, [In] JKNFFJDDHLF CPFHENDKPPG, [In] BJNHOMGEGMG MIBJDOBOMAJ, [In] PCDHHAOMILC<OKPLNKOBIDG, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>?> IGPBIJJPKLH, [In] MAHDLFLAHIJ<OMNCLBBEMMM<OKPLNKOBIDG>> APFGPFIAMDI, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MDONHMDBBBD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> PKEBOBDEGBD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MCOOKFHDLLE, [In] FEBJFOOPNHB MEBFDMNPGMI, [In] IGLBFDLJGIL MHBDGMLONNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FD9800", Offset = "0x1FD8A00", VA = "0x181FD9800")]
	public static NONHMEFJOIK FJAAFKPDAIA()
	{
		return default(NONHMEFJOIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GJDGMMJAILC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct APGFGBALHPL : FKMOBJHPBIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>, PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4C90", Offset = "0x1FD3E90", VA = "0x181FD4C90")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4C60", Offset = "0x1FD3E60", VA = "0x181FD4C60", Slot = "4")]
		public OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> IOBLLDBMLEL(int DHNLEFJCEAH)
		{
			return default(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520")]
		public bool DFGMCAJIFLJ(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "5")]
		private bool JEKEDDMONJF(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4D40", Offset = "0x1FD3F40", VA = "0x181FD4D40", Slot = "6")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> MELIHBJHBHG(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct EGGGFJIMJDL : KGMGKFEGOAF<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>, PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5440", Offset = "0x1FD4640", VA = "0x181FD5440")]
		public MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>> NKEPIPKONHE(int BFPHHJPAKDD, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5570", Offset = "0x1FD4770", VA = "0x181FD5570")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FD54B0", Offset = "0x1FD46B0", VA = "0x181FD54B0", Slot = "6")]
		public void KHLAFJJMIHD(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5440", Offset = "0x1FD4640", VA = "0x181FD5440", Slot = "4")]
		private MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>> DHNADAJBMIP(int BFPHHJPAKDD, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5620", Offset = "0x1FD4820", VA = "0x181FD5620", Slot = "5")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> PFNHFAOLJFC(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct HCFGMPHBIEM : FKMOBJHPBIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>, PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8610", Offset = "0x1FD7810", VA = "0x181FD8610")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FD85E0", Offset = "0x1FD77E0", VA = "0x181FD85E0", Slot = "4")]
		public OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> IOBLLDBMLEL(int DHNLEFJCEAH)
		{
			return default(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520")]
		public bool DFGMCAJIFLJ(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "5")]
		private bool CABHNNOELNG(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD85D0", Offset = "0x1FD77D0", VA = "0x181FD85D0", Slot = "6")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> DIIBLEFMMFI(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct HFMDIBGKFNO : KGMGKFEGOAF<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>, PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD86D0", Offset = "0x1FD78D0", VA = "0x181FD86D0")]
		public MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>> NKEPIPKONHE(int BFPHHJPAKDD, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8800", Offset = "0x1FD7A00", VA = "0x181FD8800")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8740", Offset = "0x1FD7940", VA = "0x181FD8740", Slot = "6")]
		public void KHLAFJJMIHD(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD86D0", Offset = "0x1FD78D0", VA = "0x181FD86D0", Slot = "4")]
		private MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>> HJFIKDPIDLN(int BFPHHJPAKDD, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FD86C0", Offset = "0x1FD78C0", VA = "0x181FD86C0", Slot = "5")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> GFAJKAAPCIB(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> DHNLEFJCEAH, [In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NCJJFGKGOOD : FKMOBJHPBIJ<OMNCLBBEMMM<DHDGOLLCFBA>, PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9610", Offset = "0x1FD8810", VA = "0x181FD9610")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1FD95E0", Offset = "0x1FD87E0", VA = "0x181FD95E0", Slot = "4")]
		public OMNCLBBEMMM<DHDGOLLCFBA> IOBLLDBMLEL(int DHNLEFJCEAH)
		{
			return default(OMNCLBBEMMM<DHDGOLLCFBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9560", Offset = "0x1FD8760", VA = "0x181FD9560")]
		public bool DFGMCAJIFLJ(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9560", Offset = "0x1FD8760", VA = "0x181FD9560", Slot = "5")]
		private bool JCENKHADHGH(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1FD95D0", Offset = "0x1FD87D0", VA = "0x181FD95D0", Slot = "6")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> FHLMODABMGA(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct IIOANFMFCOH : KGMGKFEGOAF<OMNCLBBEMMM<DHDGOLLCFBA>, PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8E10", Offset = "0x1FD8010", VA = "0x181FD8E10")]
		public MAHDLFLAHIJ<OMNCLBBEMMM<DHDGOLLCFBA>> NKEPIPKONHE(int BFPHHJPAKDD, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<OMNCLBBEMMM<DHDGOLLCFBA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8D40", Offset = "0x1FD7F40", VA = "0x181FD8D40")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8C60", Offset = "0x1FD7E60", VA = "0x181FD8C60", Slot = "6")]
		public void KHLAFJJMIHD(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8E10", Offset = "0x1FD8010", VA = "0x181FD8E10", Slot = "4")]
		private MAHDLFLAHIJ<OMNCLBBEMMM<DHDGOLLCFBA>> LPNFCNPHNGN(int BFPHHJPAKDD, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<OMNCLBBEMMM<DHDGOLLCFBA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD8C50", Offset = "0x1FD7E50", VA = "0x181FD8C50", Slot = "5")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> AFILEINOMHJ(OMNCLBBEMMM<DHDGOLLCFBA> DHNLEFJCEAH, [In] PCDHHAOMILC<DHDGOLLCFBA, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>?> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct CBGPAFKPGIM : FKMOBJHPBIJ<int, MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4EF0", Offset = "0x1FD40F0", VA = "0x181FD4EF0")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1391D40", Offset = "0x1390F40", VA = "0x181391D40", Slot = "4")]
		public int IOBLLDBMLEL(int DHNLEFJCEAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520")]
		public bool DFGMCAJIFLJ(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "5")]
		private bool KKFMDMEEJFJ(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4F90", Offset = "0x1FD4190", VA = "0x181FD4F90", Slot = "6")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> OAHEPPGGGMJ(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct FIANOLLJPNE : KGMGKFEGOAF<int, MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5AC0", Offset = "0x1FD4CC0", VA = "0x181FD5AC0")]
		public MAHDLFLAHIJ<int> NKEPIPKONHE(int BFPHHJPAKDD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5A20", Offset = "0x1FD4C20", VA = "0x181FD5A20")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5920", Offset = "0x1FD4B20", VA = "0x181FD5920", Slot = "6")]
		public void KHLAFJJMIHD(int DHNLEFJCEAH, MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5AC0", Offset = "0x1FD4CC0", VA = "0x181FD5AC0", Slot = "4")]
		private MAHDLFLAHIJ<int> PBOHGMAOGIG(int BFPHHJPAKDD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5B30", Offset = "0x1FD4D30", VA = "0x181FD5B30", Slot = "5")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> OEJIBFEEBLD(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> VariableId, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<JHGAOCPFCLJ>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct NJJJFKBDKFO : FKMOBJHPBIJ<int, MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9760", Offset = "0x1FD8960", VA = "0x181FD9760")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1391D40", Offset = "0x1390F40", VA = "0x181391D40", Slot = "4")]
		public int IOBLLDBMLEL(int DHNLEFJCEAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520")]
		public bool DFGMCAJIFLJ(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "5")]
		private bool KEINOIKEEOM(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9750", Offset = "0x1FD8950", VA = "0x181FD9750", Slot = "6")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> GIFGOOJAHHM(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct FKKEPOLMJNF : KGMGKFEGOAF<int, MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5B90", Offset = "0x1FD4D90", VA = "0x181FD5B90")]
		public MAHDLFLAHIJ<int> NKEPIPKONHE(int BFPHHJPAKDD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5CF0", Offset = "0x1FD4EF0", VA = "0x181FD5CF0")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5C00", Offset = "0x1FD4E00", VA = "0x181FD5C00", Slot = "6")]
		public void KHLAFJJMIHD(int DHNLEFJCEAH, MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5B90", Offset = "0x1FD4D90", VA = "0x181FD5B90", Slot = "4")]
		private MAHDLFLAHIJ<int> FBCBLHIDHDG(int BFPHHJPAKDD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5D90", Offset = "0x1FD4F90", VA = "0x181FD5D90", Slot = "5")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> MOAIEOKFBCL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct DPOKFKGJDMF : FKMOBJHPBIJ<int, MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5390", Offset = "0x1FD4590", VA = "0x181FD5390")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1391D40", Offset = "0x1390F40", VA = "0x181391D40", Slot = "4")]
		public int IOBLLDBMLEL(int DHNLEFJCEAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520")]
		public bool DFGMCAJIFLJ(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "5")]
		private bool KEINOIKEEOM(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5380", Offset = "0x1FD4580", VA = "0x181FD5380", Slot = "6")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> GIFGOOJAHHM(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct MELFAFHIECL : KGMGKFEGOAF<int, MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9290", Offset = "0x1FD8490", VA = "0x181FD9290")]
		public MAHDLFLAHIJ<int> NKEPIPKONHE(int BFPHHJPAKDD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9400", Offset = "0x1FD8600", VA = "0x181FD9400")]
		public OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9300", Offset = "0x1FD8500", VA = "0x181FD9300", Slot = "6")]
		public void KHLAFJJMIHD(int DHNLEFJCEAH, MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FD9290", Offset = "0x1FD8490", VA = "0x181FD9290", Slot = "4")]
		private MAHDLFLAHIJ<int> FBCBLHIDHDG(int BFPHHJPAKDD, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(MAHDLFLAHIJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FD94A0", Offset = "0x1FD86A0", VA = "0x181FD94A0", Slot = "5")]
		private OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> MOAIEOKFBCL(int DHNLEFJCEAH, [In] MAHDLFLAHIJ<(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> Target, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> ByteCodeWriteLocation)> MNHECFLLMJH)
		{
			return default(OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct HALGHHPIKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> FKMBCBEJEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool NEFHMPCIBIL;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10DDDF0", Offset = "0x10DCFF0", VA = "0x1810DDDF0")]
		public HALGHHPIKAM(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI, bool AGPCEGGPLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1FD85C0", Offset = "0x1FD77C0", VA = "0x181FD85C0")]
		public void ACGMCNJANLE([Out] OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI, [Out] bool AGPCEGGPLLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FEKBCKGNODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly OMNCLBBEMMM<DHDGOLLCFBA> BADOLIAEIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> FKMBCBEJEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool NEFHMPCIBIL;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5900", Offset = "0x1FD4B00", VA = "0x181FD5900")]
		public FEKBCKGNODN(OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI, bool AGPCEGGPLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FD58D0", Offset = "0x1FD4AD0", VA = "0x181FD58D0")]
		public void ACGMCNJANLE([Out] OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI, [Out] bool AGPCEGGPLLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FD58E0", Offset = "0x1FD4AE0", VA = "0x181FD58E0")]
		public void ACGMCNJANLE([Out] OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI, [Out] OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA, [Out] bool AGPCEGGPLLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct FGPIFLBFHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly OMNCLBBEMMM<DHDGOLLCFBA> BADOLIAEIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> FKMBCBEJEFC;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
		public FGPIFLBFHLK(OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5910", Offset = "0x1FD4B10", VA = "0x181FD5910")]
		public void ACGMCNJANLE([Out] OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI, [Out] OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FD64B0", Offset = "0x1FD56B0", VA = "0x181FD64B0")]
	public static void CKOHIKCJKJA(this NONHMEFJOIK HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FD60A0", Offset = "0x1FD52A0", VA = "0x181FD60A0")]
	public static void BIAHDCLFHBF(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> NBGNJJACJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6BB0", Offset = "0x1FD5DB0", VA = "0x181FD6BB0")]
	public static void FGLHJELNCMI(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> NBGNJJACJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FD72B0", Offset = "0x1FD64B0", VA = "0x181FD72B0")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>? JFIFGIKHHIO([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6780", Offset = "0x1FD5980", VA = "0x181FD6780")]
	public static OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> DDCNAFJNKMH([In] this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8380", Offset = "0x1FD7580", VA = "0x181FD8380")]
	private static void PFIGOHKNFFL(this NONHMEFJOIK HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7FB0", Offset = "0x1FD71B0", VA = "0x181FD7FB0")]
	private static OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>? NHIPHBHFLGL([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7D70", Offset = "0x1FD6F70", VA = "0x181FD7D70")]
	public static void NGIDJJOHBLF(this NONHMEFJOIK HIKEOGPAJAF, [In] MAHDLFLAHIJ<JAGGKPOBNJB> EFKHLOMFLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7230", Offset = "0x1FD6430", VA = "0x181FD7230")]
	public static JKNFFJDDHLF.NDLGEKBMCGK INMJPKLJHDE([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
	{
		return default(JKNFFJDDHLF.NDLGEKBMCGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7570", Offset = "0x1FD6770", VA = "0x181FD7570")]
	public static LHCIICLJEAC<byte> KCJFBDFDPPP([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
	{
		return default(LHCIICLJEAC<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6310", Offset = "0x1FD5510", VA = "0x181FD6310")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CECJIPNFOJO([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7750", Offset = "0x1FD6950", VA = "0x181FD7750")]
	public static NKFCAEJKJCA KIMFFGKCKDF([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
	{
		return default(NKFCAEJKJCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2B37EB0", Offset = "0x2B370B0", VA = "0x182B37EB0")]
	private static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> ADLMEOFEOOG<TMJoin>(this NONHMEFJOIK HIKEOGPAJAF, JKNFFJDDHLF.NDLGEKBMCGK OMHMMFFCKOG, OMNCLBBEMMM<TMJoin> NOFDJJFHNGO) where TMJoin : JKNFFJDDHLF.INHKIAEHDOO
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FD82A0", Offset = "0x1FD74A0", VA = "0x181FD82A0")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> PAAPEHIIFAK(this NONHMEFJOIK HIKEOGPAJAF, bool AKBADEMAGHC)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8530", Offset = "0x1FD7730", VA = "0x181FD8530")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> PMGEOHCPCPA(this NONHMEFJOIK HIKEOGPAJAF, LHCIICLJEAC<byte> DDNKCFIIBGP)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8060", Offset = "0x1FD7260", VA = "0x181FD8060")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> NKANGHLEGHO(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> FPCDKEGNGEP)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8120", Offset = "0x1FD7320", VA = "0x181FD8120")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> OHLBFANNBLE(this NONHMEFJOIK HIKEOGPAJAF, int JKCDGJHMGDA)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6C80", Offset = "0x1FD5E80", VA = "0x181FD6C80")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GAINICOFOPA(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B387C0", Offset = "0x2B379C0", VA = "0x182B387C0")]
	private static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> DCNHPCLDCMG<TMJoin>(this NONHMEFJOIK HIKEOGPAJAF, BJNHOMGEGMG.KNJHGLJJIBN OMHMMFFCKOG, OMNCLBBEMMM<TMJoin> NOFDJJFHNGO) where TMJoin : BJNHOMGEGMG.NMENLCCBAKO
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7C60", Offset = "0x1FD6E60", VA = "0x181FD7C60")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> LPLGFFMNDHG(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7360", Offset = "0x1FD6560", VA = "0x181FD7360")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> JMONBEKPMCF(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6020", Offset = "0x1FD5220", VA = "0x181FD6020")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> APNKKEJDOJG(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> JNPOCCFBJPO)
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7CA0", Offset = "0x1FD6EA0", VA = "0x181FD7CA0")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> MIBJAFLMFEK(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD84F0", Offset = "0x1FD76F0", VA = "0x181FD84F0")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> PFMJOAEEOIG(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD67E0", Offset = "0x1FD59E0", VA = "0x181FD67E0")]
	public static CHLNNCNOLPG.LKOONHPBMBC DDFLOLJLDMF([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> AJPLBPLLHJL)
	{
		return default(CHLNNCNOLPG.LKOONHPBMBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6470", Offset = "0x1FD5670", VA = "0x181FD6470")]
	public static CJFNOILOBFK<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>, NFLCMDINLKA<CHLNNCNOLPG.MLKINMPODCP>> CKDGGKLALIK([In] this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(CJFNOILOBFK<OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>, NFLCMDINLKA<CHLNNCNOLPG.MLKINMPODCP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6130", Offset = "0x1FD5330", VA = "0x181FD6130")]
	public static OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> BIKFHOMKOOA([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> AJPLBPLLHJL)
	{
		return default(OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6860", Offset = "0x1FD5A60", VA = "0x181FD6860")]
	public static CHLNNCNOLPG.KAJKIGJDNOL DPKGGNBHAFB([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> FHJEMFKIFGC)
	{
		return default(CHLNNCNOLPG.KAJKIGJDNOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6D00", Offset = "0x1FD5F00", VA = "0x181FD6D00")]
	public static CHLNNCNOLPG.KAJKIGJDNOL GHBKFCHLNLG(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> FHJEMFKIFGC)
	{
		return default(CHLNNCNOLPG.KAJKIGJDNOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B38870", Offset = "0x2B37A70", VA = "0x182B38870")]
	private static OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> EIKMMNHKGCB<TMJoin>(this NONHMEFJOIK HIKEOGPAJAF, CHLNNCNOLPG.LKOONHPBMBC OMHMMFFCKOG, OMNCLBBEMMM<TMJoin> NOFDJJFHNGO) where TMJoin : CHLNNCNOLPG.DDDBHABKGBH
	{
		return default(OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FD73A0", Offset = "0x1FD65A0", VA = "0x181FD73A0")]
	public static (OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>) KAKDPGGHMBN(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default((OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7840", Offset = "0x1FD6A40", VA = "0x181FD7840")]
	public static (OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>) KOPGKOHHDAH(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default((OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FD80E0", Offset = "0x1FD72E0", VA = "0x181FD80E0")]
	public static OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> OGMKNEJLLMC(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6B20", Offset = "0x1FD5D20", VA = "0x181FD6B20")]
	public static void EPFCJEIFMHG(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP> FHJEMFKIFGC, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> EEIJDCOFBLO, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>> IFODLPPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B38E50", Offset = "0x2B38050", VA = "0x182B38E50")]
	public static HALGHHPIKAM LIFDEICKHGO<TDeps, TStateSys>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA) where TDeps : BILICGJHGFC<TStateSys>
	{
		return default(HALGHHPIKAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B37F60", Offset = "0x2B37160", VA = "0x182B37F60")]
	public static FEKBCKGNODN BDKBNPKILCN<TDeps, TStateSys>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<CBPAPLPKJIA> DJMPLCHOJFC, int MBCEOBLJCKP) where TDeps : BILICGJHGFC<TStateSys>
	{
		return default(FEKBCKGNODN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B38910", Offset = "0x2B37B10", VA = "0x182B38910")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>? FFKBOKIJKFO<TDeps, TStateSys>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<CBPAPLPKJIA> DJMPLCHOJFC, [In] ReadOnlySpan<int> LBLEKMKNAFH, [In] Span<FGPIFLBFHLK> LOOPFCFHACJ) where TDeps : BILICGJHGFC<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B38200", Offset = "0x2B37400", VA = "0x182B38200")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> CFDGIAJECNO<TDeps, TStateSys>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC) where TDeps : BILICGJHGFC<TStateSys>
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7660", Offset = "0x1FD6860", VA = "0x181FD7660")]
	public static PICJDPBAIJH.NCHAIAHEMJC KIJEMNLIFJF([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DKFNFHGODON)
	{
		return default(PICJDPBAIJH.NCHAIAHEMJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD68E0", Offset = "0x1FD5AE0", VA = "0x181FD68E0")]
	public static PICJDPBAIJH.JJNJADGCLGK EJBKGEAADGO([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DKFNFHGODON)
	{
		return default(PICJDPBAIJH.JJNJADGCLGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6A30", Offset = "0x1FD5C30", VA = "0x181FD6A30")]
	public static PICJDPBAIJH.DJOECJGHIHJ EMFNCIDPCBO([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DKFNFHGODON)
	{
		return default(PICJDPBAIJH.DJOECJGHIHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7AD0", Offset = "0x1FD6CD0", VA = "0x181FD7AD0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LOJGKJKLBHO(this NONHMEFJOIK HIKEOGPAJAF, int? OOJKMNACDLA, string BHFPKCCDEEC)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7140", Offset = "0x1FD6340", VA = "0x181FD7140")]
	public static PICJDPBAIJH.HBJJJIBNIFE IMPADIFAJLO([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DKFNFHGODON)
	{
		return default(PICJDPBAIJH.HBJJJIBNIFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6400", Offset = "0x1FD5600", VA = "0x181FD6400")]
	public static PICJDPBAIJH.IKAJCGCPOOL CIDFPDHDLJK([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DKFNFHGODON)
	{
		return default(PICJDPBAIJH.IKAJCGCPOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FD81A0", Offset = "0x1FD73A0", VA = "0x181FD81A0")]
	public static int? OMEFIMGDFKK([In] this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DKFNFHGODON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B38D50", Offset = "0x2B37F50", VA = "0x182B38D50")]
	private static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FLPELNPAFDN<TMJoin>(this NONHMEFJOIK HIKEOGPAJAF, int? OOJKMNACDLA, PICJDPBAIJH.IKAJCGCPOOL OMHMMFFCKOG, OMNCLBBEMMM<TMJoin> NOFDJJFHNGO) where TMJoin : PICJDPBAIJH.MFOBPPOHKMP
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5F70", Offset = "0x1FD5170", VA = "0x181FD5F70")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> AOGHPHBODHI(this NONHMEFJOIK HIKEOGPAJAF, int? OOJKMNACDLA, OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> AJPLBPLLHJL, int DHNLEFJCEAH)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8320", Offset = "0x1FD7520", VA = "0x181FD8320")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> PDMCNLGBECI(this NONHMEFJOIK HIKEOGPAJAF, int? OOJKMNACDLA)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6FF0", Offset = "0x1FD61F0", VA = "0x181FD6FF0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> ICGBHGOHAEE(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? OCANHOHNLDB, int? OOJKMNACDLA)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7CE0", Offset = "0x1FD6EE0", VA = "0x181FD7CE0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> MIJKJBONJID(this NONHMEFJOIK HIKEOGPAJAF, int? OOJKMNACDLA, int DHNLEFJCEAH)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FD69D0", Offset = "0x1FD5BD0", VA = "0x181FD69D0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> EKPCMBLMKHF(this NONHMEFJOIK HIKEOGPAJAF, int? OOJKMNACDLA)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6EB0", Offset = "0x1FD60B0", VA = "0x181FD6EB0")]
	public static void HDIDBIHKEOD(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL, OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> AJPLBPLLHJL, int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FD6D80", Offset = "0x1FD5F80", VA = "0x181FD6D80")]
	public static void GMGAANNHMDD(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL, int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7A00", Offset = "0x1FD6C00", VA = "0x181FD7A00")]
	public static void LFKFGPIOBJP(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8210", Offset = "0x1FD7410", VA = "0x181FD8210")]
	public static void OODPLJLGLMB(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> CGKANMHMCOJ, OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> CDEDEECGKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD7EE0", Offset = "0x1FD70E0", VA = "0x181FD7EE0")]
	public static void NGLCGLLLAEE(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL, OMNCLBBEMMM<EEHEIECAIMH<DJCHFFPCLAB>> AJLAPDABKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B39C70", Offset = "0x2B38E70", VA = "0x182B39C70")]
	public static void PPMDCDFAHBH<M>(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLGOPBLKAKL, OMNCLBBEMMM<EEHEIECAIMH<PLNLGICOJDD<M>>> AJLAPDABKGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface BILICGJHGFC<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMNCLBBEMMM<GDGJOIIKKHE> CNKFJFCMJFO(TStateSys FGFGKADDOOO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMNCLBBEMMM<GDGJOIIKKHE> OOLJHAKCNKC(TStateSys FGFGKADDOOO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OMNCLBBEMMM<GDGJOIIKKHE> EFKIFFADCFF(TStateSys FGFGKADDOOO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OMNCLBBEMMM<GDGJOIIKKHE> ADCMJCCOEKB(TStateSys FGFGKADDOOO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> OFEBOFKIDBM(TStateSys FGFGKADDOOO, NONHMEFJOIK CMLBKFIDFAP, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> FMONGGPJHMM(TStateSys FGFGKADDOOO, NONHMEFJOIK CMLBKFIDFAP, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MDBHBCEGMBP(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OMNCLBBEMMM<OKPLNKOBIDG> OCNJGDPIGML(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA, int GHAFKPOCIGP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LMACHENEFKE BLJCJDLBABM(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FJJMONNNJNO(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int KCEFKNNEFAG(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LHCIICLJEAC<byte> LHPBIELDBMG(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(LHCIICLJEAC<byte>, OMNCLBBEMMM<GDGJOIIKKHE>) MKIPGJGIJNN(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<DHDGOLLCFBA> AFCOHGCGHPA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int OCBFPDECMMA(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OMNCLBBEMMM<DHDGOLLCFBA> BAFCNJGFODN(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<OKPLNKOBIDG> BPLLNJLCLAC, int MBCEOBLJCKP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OMNCLBBEMMM<DHDGOLLCFBA> AKHCNCLBLEM(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, OMNCLBBEMMM<CBPAPLPKJIA> DJMPLCHOJFC, int MBCEOBLJCKP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int GIDNAIBLFKN(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? DJBKKMNJLNO(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, int DHNLEFJCEAH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int EDGDKPPNPLE(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? HODIOEGGJPC(TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG, int DHNLEFJCEAH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PBJPKHFANJH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2CD09F0", Offset = "0x2CCFBF0", VA = "0x182CD09F0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE?> EGMKKELEBOB<T, TOpInput, TOpOutput>(this NONHMEFJOIK HIKEOGPAJAF, T DIAAOCPNHKC, T LLLBDLGIMPP, int ACOOGPKGDMM, IntPtr MFIDPDMAIND)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CD14B0", Offset = "0x2CD06B0", VA = "0x182CD14B0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE?> KHAAOHNMAFJ<T, TOpInput, TOpOutput>(this NONHMEFJOIK HIKEOGPAJAF, T DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP, int ACOOGPKGDMM, IntPtr MFIDPDMAIND)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2A10", Offset = "0x2CD1C10", VA = "0x182CD2A10")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE?> LFAIEKPKCPH<TOpInput, TOpOutput>(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP, int ACOOGPKGDMM, IntPtr MFIDPDMAIND)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDC60", Offset = "0x1FDCE60", VA = "0x181FDDC60")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> IPIPKIEKNHK(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB8F0", Offset = "0x1FDAAF0", VA = "0x181FDB8F0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CNGANHIJJID(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDADD0", Offset = "0x1FD9FD0", VA = "0x181FDADD0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> BGPJHIKELJC(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCE50", Offset = "0x1FDC050", VA = "0x181FDCE50")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FMEIHHKIBOA(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE370", Offset = "0x1FDD570", VA = "0x181FDE370")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> KJFJAALAAFH(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC690", Offset = "0x1FDB890", VA = "0x181FDC690")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> EHGEFOKKNHD(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD150", Offset = "0x1FDC350", VA = "0x181FDD150")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GHGHAIFCDEN(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF850", Offset = "0x1FDEA50", VA = "0x181FDF850")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> PFEFGFDMINJ(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE490", Offset = "0x1FDD690", VA = "0x181FDE490")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> KLJHJGJHNOJ(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEA10", Offset = "0x1FDDC10", VA = "0x181FDEA10")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> MCKDFCKFFPP(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, int LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD950", Offset = "0x1FDCB50", VA = "0x181FDD950")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> HEKBJOIGJGG(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF3F0", Offset = "0x1FDE5F0", VA = "0x181FDF3F0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> NDEECNOPFKD(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC0E0", Offset = "0x1FDB2E0", VA = "0x181FDC0E0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DNIOLMJKFKL(this NONHMEFJOIK HIKEOGPAJAF, float DIAAOCPNHKC, float LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB520", Offset = "0x1FDA720", VA = "0x181FDB520")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CALMLILNMHI(this NONHMEFJOIK HIKEOGPAJAF, float DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA960", Offset = "0x1FD9B60", VA = "0x181FDA960")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> ALIDOAHBKMA(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEC20", Offset = "0x1FDDE20", VA = "0x181FDEC20")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> MJBEGNDKBBG(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, int LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA820", Offset = "0x1FD9A20", VA = "0x181FDA820")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> AHMNHCGJJIL(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE990", Offset = "0x1FDDB90", VA = "0x181FDE990")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LDIGAAGDCPF(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDDA90", VA = "0x181FDE890")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LBPPOODJNNN(this NONHMEFJOIK HIKEOGPAJAF, float DIAAOCPNHKC, float LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FDECA0", Offset = "0x1FDDEA0", VA = "0x181FDECA0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> MLEFEGGEEKG(this NONHMEFJOIK HIKEOGPAJAF, float DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE910", Offset = "0x1FDDB10", VA = "0x181FDE910")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LCFHOLIBJLH(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD440", Offset = "0x1FDC640", VA = "0x181FDD440")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GOGPCGNGCFG(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, int LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE810", Offset = "0x1FDDA10", VA = "0x181FDE810")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LBJEHGMNDBK(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB770", Offset = "0x1FDA970", VA = "0x181FDB770")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CHOIFCGHIIN(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCBB0", Offset = "0x1FDBDB0", VA = "0x181FDCBB0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FIFJDIBBDHD(this NONHMEFJOIK HIKEOGPAJAF, float DIAAOCPNHKC, float LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDAF0", Offset = "0x1FDCCF0", VA = "0x181FDDAF0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> HMGJAIPAKEP(this NONHMEFJOIK HIKEOGPAJAF, float DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAF10", Offset = "0x1FDA110", VA = "0x181FDAF10")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> BMGEABFEBHE(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE090", Offset = "0x1FDD290", VA = "0x181FDE090")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> JILOMHJLCOH(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDA70", Offset = "0x1FDCC70", VA = "0x181FDDA70")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> HIJOEIHBKDF(this NONHMEFJOIK HIKEOGPAJAF, int JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD7C0", Offset = "0x1FDC9C0", VA = "0x181FDD7C0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> HBHPHEHMBDM(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBF30", Offset = "0x1FDB130", VA = "0x181FDBF30")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> DMHPBBECLMI(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GHNEAALAJAI)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBB50", Offset = "0x1FDAD50", VA = "0x181FDBB50")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> DGJOFDEKCHF(this NONHMEFJOIK HIKEOGPAJAF, int JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF7B0", Offset = "0x1FDE9B0", VA = "0x181FDF7B0")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> OHDBJDMHMDB(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEE50", Offset = "0x1FDE050", VA = "0x181FDEE50")]
	public static (OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>) NCHMCDDNMMB(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<FLHNECBBMMA> BDENMAEBFCA, [In] ReadOnlySpan<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> AHNMHBFDPAL, [In] ReadOnlySpan<int?> KAGCJHKFEEE, [In] Span<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> HBCBEDDEGKA)
	{
		return default((OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB0B0", Offset = "0x1FDA2B0", VA = "0x181FDB0B0")]
	public static (OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>) BMODOOFLIAH(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<DPDKCKKCEBB> IIGKAGHCCOD, [In] ReadOnlySpan<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> AHNMHBFDPAL, [In] ReadOnlySpan<int?> KAGCJHKFEEE, [In] Span<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> HBCBEDDEGKA)
	{
		return default((OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2B80", Offset = "0x2CD1D80", VA = "0x182CD2B80")]
	public static (OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>, OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>) OIHKEBDPBJJ<TMarker>(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<GDGJOIIKKHE> KACPLHADPFC, [In] ReadOnlySpan<byte> LINJEFIAFHO)
	{
		return default((OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<EEHEIECAIMH<GDGJOIIKKHE>>, OMNCLBBEMMM<EEHEIECAIMH<BALKHKDPIOA>>, OMNCLBBEMMM<EEHEIECAIMH<TMarker>>, OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA8A0", Offset = "0x1FD9AA0", VA = "0x181FDA8A0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> AIJILIOOBOK(this NONHMEFJOIK HIKEOGPAJAF, int GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FDABA0", Offset = "0x1FD9DA0", VA = "0x181FDABA0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> BFECMBCNCMK(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDE80", Offset = "0x1FDD080", VA = "0x181FDDE80")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> JDLODOOPKLG(this NONHMEFJOIK HIKEOGPAJAF, [In] ReadOnlySpan<byte> GHPNOJNBADJ, [Optional] OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB650", Offset = "0x1FDA850", VA = "0x181FDB650")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CGGPOLKFJGO(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GHPNOJNBADJ, int ECGAAJFODGN, [Optional] OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAAA0", Offset = "0x1FD9CA0", VA = "0x181FDAAA0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> BDIEGPNBFEP(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FDEB00", Offset = "0x1FDDD00", VA = "0x181FDEB00")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> MDLIDKMMDBH(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBA10", Offset = "0x1FDAC10", VA = "0x181FDBA10")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCOBEMPGGK(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE710", Offset = "0x1FDD910", VA = "0x181FDE710")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> KNNBPCNLFMB(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCF40", Offset = "0x1FDC140", VA = "0x181FDCF40")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FOKFOLEIKKO(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF530", Offset = "0x1FDE730", VA = "0x181FDF530")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> ODPLLELJBON(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC8F0", Offset = "0x1FDBAF0", VA = "0x181FDC8F0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> ELOKPOGCNAD(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, int LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB870", Offset = "0x1FDAA70", VA = "0x181FDB870")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CLPGHBBGBCH(this NONHMEFJOIK HIKEOGPAJAF, int DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB7F0", Offset = "0x1FDA9F0", VA = "0x181FDB7F0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CKMKDOOBBJH(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIAAOCPNHKC, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> LLLBDLGIMPP)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC570", Offset = "0x1FDB770", VA = "0x181FDC570")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> ECMDCNFGENB(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDED20", Offset = "0x1FDDF20", VA = "0x181FDED20")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> MPLMADFCKIB(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAC90", Offset = "0x1FD9E90", VA = "0x181FDAC90")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> BFNDHFGFHCE(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD860", Offset = "0x1FDCA60", VA = "0x181FDD860")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> HDKBJHABFBF(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAF90", Offset = "0x1FDA190", VA = "0x181FDAF90")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> BMJHPHCLFIE(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCA70", Offset = "0x1FDBC70", VA = "0x181FDCA70")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FHIEOKLKJNE(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC670", Offset = "0x1FDB870", VA = "0x181FDC670")]
	public static OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>> EGGOJINGKEC(this NONHMEFJOIK HIKEOGPAJAF)
	{
		return default(OMNCLBBEMMM<EEHEIECAIMH<EEHEIECAIMH<KOHBJJHPJHN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCD50", Offset = "0x1FDBF50", VA = "0x181FDCD50")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FLFFHKPFHJH(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDD60", Offset = "0x1FDCF60", VA = "0x181FDDD60")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> JDCIJLGPDLH(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF970", Offset = "0x1FDEB70", VA = "0x181FDF970")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> PPKLGFIFNNA(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDB70", Offset = "0x1FDCD70", VA = "0x181FDDB70")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> ILIJGAHMPDC(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FDDF70", Offset = "0x1FDD170", VA = "0x181FDDF70")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> JFPALJEOBIB(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBBD0", Offset = "0x1FDADD0", VA = "0x181FDBBD0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DIPANNNNKCF(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBE30", Offset = "0x1FDB030", VA = "0x181FDBE30")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DJPHAPEOIKA(this NONHMEFJOIK HIKEOGPAJAF, int JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD330", Offset = "0x1FDC530", VA = "0x181FDD330")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GODIAHPLEHF(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> JMDCGOKJIDA)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE800", Offset = "0x1FDDA00", VA = "0x181FDE800")]
	public static void KPANLHLFIGJ(this NONHMEFJOIK HIKEOGPAJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC970", Offset = "0x1FDBB70", VA = "0x181FDC970")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FFHAPONKGHG(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, float DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1FDBD10", Offset = "0x1FDAF10", VA = "0x181FDBD10")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DJDHFODCECG(this NONHMEFJOIK HIKEOGPAJAF, float DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF2B0", Offset = "0x1FDE4B0", VA = "0x181FDF2B0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> NCLNKDOIMDP(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD240", Offset = "0x1FDC440", VA = "0x181FDD240")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GNGAPADJJNF(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FDCC30", Offset = "0x1FDBE30", VA = "0x181FDCC30")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> FJMHANCPLML(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF670", Offset = "0x1FDE870", VA = "0x181FDF670")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> OGDJHFPOAOL(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC1E0", Offset = "0x1FDB3E0", VA = "0x181FDC1E0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> EAGAJAPDNIA(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KGOMDPLIGPG, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> EKHJPFAFPLH)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD060", Offset = "0x1FDC260", VA = "0x181FDD060")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GCMPFHGEDJF(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, int DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1FDC7D0", Offset = "0x1FDB9D0", VA = "0x181FDC7D0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> EHPEJFAEOAB(this NONHMEFJOIK HIKEOGPAJAF, int DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE5D0", Offset = "0x1FDD7D0", VA = "0x181FDE5D0")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> KMNOPCAKFBL(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DCFFNODJOBH, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> DGCFGPHGFGD)
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0460", Offset = "0x2CCF660", VA = "0x182CD0460")]
	public static void CMECBPEHNFN<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<FLHNECBBMMA> BDENMAEBFCA, [In] ReadOnlySpan<OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>> FJAFNMBIMPC, [In] ReadOnlySpan<int?> KAGCJHKFEEE, [In] Span<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> HBCBEDDEGKA, [In] Span<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> CIIDJBOCOJF, [In] ReadOnlySpan<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>?> FKFHELCLCGA) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0CF0", Offset = "0x2CCFEF0", VA = "0x182CD0CF0")]
	public static void EHMEIIBOFOP<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<DPDKCKKCEBB> GPJOKKOGGOF, [In] ReadOnlySpan<OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>> PCJFIIJPOGK, [In] ReadOnlySpan<int?> KAGCJHKFEEE, [In] Span<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> HBCBEDDEGKA, [In] Span<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>> CIIDJBOCOJF, [In] ReadOnlySpan<OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>?> FKFHELCLCGA) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0280", Offset = "0x2CCF480", VA = "0x182CD0280")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CGKJDAMNIEL<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> OCANHOHNLDB, [Optional] OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFE20", Offset = "0x2CCF020", VA = "0x182CCFE20")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> CANCNHIMBBI<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> JNPOCCFBJPO, [Optional] OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1280", Offset = "0x2CD0480", VA = "0x182CD1280")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> HALKFCENLKE<TDeps, TStateSys>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO) where TDeps : notnull, BILICGJHGFC<TStateSys> where TStateSys : notnull
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2CCFC10", Offset = "0x2CCEE10", VA = "0x182CCFC10")]
	public static OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA> BCIGBDCKMKF<TDeps, TStateSys>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO) where TDeps : notnull, BILICGJHGFC<TStateSys> where TStateSys : notnull
	{
		return default(OMNCLBBEMMM<BJNHOMGEGMG.JOKEIDIIHCA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE240", Offset = "0x1FDD440", VA = "0x181FDE240")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KEGGMINABKB(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> LLGFAKPOKMG, IntPtr FOCHFFAHLDA, IntPtr APDPIPABHIA)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD4C0", Offset = "0x1FDC6C0", VA = "0x181FDD4C0")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> GOIMEBOHJFP(this NONHMEFJOIK HIKEOGPAJAF, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KCDIHOEKHIO, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> OKBHOGCIIOP, IntPtr GDJKMDPCGJG, IntPtr EGJEEAHNDEJ, IntPtr LEKEGCLNADO, bool NLJJLHPABPB)
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1B60", Offset = "0x2CD0D60", VA = "0x182CD1B60")]
	public static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KOMBPBCDKMK<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<FLHNECBBMMA> CMEGJEJJADG, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KCDIHOEKHIO, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> OKBHOGCIIOP, int? KNLPKNIGBBA, [Optional] IntPtr CEMBCCEIPKP) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD1840", Offset = "0x2CD0A40", VA = "0x182CD1840")]
	private static OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KOMBPBCDKMK<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<FLHNECBBMMA> CMEGJEJJADG, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> KCDIHOEKHIO, OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP> OKBHOGCIIOP, int? KNLPKNIGBBA) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
		return default(OMNCLBBEMMM<JKNFFJDDHLF.DKONFINEJAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2F10", Offset = "0x2CD2110", VA = "0x182CD2F10")]
	public static OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> PPGJDMENMKM<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE> GHPNOJNBADJ, OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>? GIEIMDLAKLP) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
		return default(OMNCLBBEMMM<PICJDPBAIJH.EBMGKPHAAHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2C80", Offset = "0x2CD1E80", VA = "0x182CD2C80")]
	public static void OMKEGILJINN<TDeps, TState>(this NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TState DMDDBNBIFMI, int MELPLHDFCKC) where TDeps : notnull, BILICGJHGFC<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct ALPKKDMJFEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> KBABDCPOHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> FKDMKKFLOPL;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
	public ALPKKDMJFEA(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> DOGKJALEOML, OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> KIIADKFENKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4C50", Offset = "0x1FD3E50", VA = "0x181FD4C50")]
	public static ALPKKDMJFEA FJAAFKPDAIA(OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>> DOGKJALEOML)
	{
		return default(ALPKKDMJFEA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PICJDPBAIJH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class NLFBLIIGEGP : MFOBPPOHKMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct NCHAIAHEMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> MOGEEPCAIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LINJEMEJAMF;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
		public NCHAIAHEMJC(OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> AJPLBPLLHJL, int DHNLEFJCEAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class GCDJDHEKIID : MFOBPPOHKMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct JJNJADGCLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int LINJEMEJAMF;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public JJNJADGCLGK(int DHNLEFJCEAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class KHABFAOINJJ : MFOBPPOHKMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct DJOECJGHIHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> MOGEEPCAIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int LINJEMEJAMF;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC40320", Offset = "0xC3F520", VA = "0x180C40320")]
		public DJOECJGHIHJ(OMNCLBBEMMM<CHLNNCNOLPG.NEGLCKNFHHF> AJPLBPLLHJL, int DHNLEFJCEAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum IKAJCGCPOOL
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
	public sealed class EBMGKPHAAHE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class MFOBPPOHKMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct BHGOPEJAFPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? PKKJCKJFCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ALPKKDMJFEA OPGMOFEJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IKAJCGCPOOL INCGKENDBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OMNCLBBEMMM<MFOBPPOHKMP> MHDAKKGFBEH;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FD4E00", Offset = "0x1FD4000", VA = "0x181FD4E00")]
		public BHGOPEJAFPI(int? OOJKMNACDLA, [In] ALPKKDMJFEA ILEHANLNOPM, IKAJCGCPOOL OMHMMFFCKOG, OMNCLBBEMMM<MFOBPPOHKMP> NOFDJJFHNGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class JNBIJBEEEPD : MFOBPPOHKMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HBJJJIBNIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int LINJEMEJAMF;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0")]
		public HBJJJIBNIFE(int DHNLEFJCEAH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal EAPHEIGHFPH<EBMGKPHAAHE, BHGOPEJAFPI> APHGBNPKNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal EAPHEIGHFPH<NLFBLIIGEGP, NCHAIAHEMJC> OKOKGDGEJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal EAPHEIGHFPH<KHABFAOINJJ, DJOECJGHIHJ> PIAHGBANGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal EAPHEIGHFPH<JNBIJBEEEPD, HBJJJIBNIFE> NLBIIMPKFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal EAPHEIGHFPH<GCDJDHEKIID, JJNJADGCLGK> LPEMPELLIDG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFD20", Offset = "0x1FDEF20", VA = "0x181FDFD20")]
	private PICJDPBAIJH([In] EAPHEIGHFPH<EBMGKPHAAHE, BHGOPEJAFPI> NNPIJKHHMEE, [In] EAPHEIGHFPH<NLFBLIIGEGP, NCHAIAHEMJC> BBGDFOJOBIJ, [In] EAPHEIGHFPH<KHABFAOINJJ, DJOECJGHIHJ> JBNJEEPCCNO, [In] EAPHEIGHFPH<JNBIJBEEEPD, HBJJJIBNIFE> BFCCGEMCPEM, [In] EAPHEIGHFPH<GCDJDHEKIID, JJNJADGCLGK> GMJGBFELOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1FDFB30", Offset = "0x1FDED30", VA = "0x181FDFB30")]
	public static PICJDPBAIJH FJAAFKPDAIA()
	{
		return default(PICJDPBAIJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BGPHEJJCNMO
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FD4D50", Offset = "0x1FD3F50", VA = "0x181FD4D50")]
	public static void CKOHIKCJKJA(this PICJDPBAIJH HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JAIKGOMGANG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8E80", Offset = "0x1FD8080", VA = "0x181FD8E80")]
	public static void AGALHLJOLPH(NONHMEFJOIK HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct FEBJFOOPNHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, DBNGFIBEHEK> GGOIPJGAIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int EDJEHNCEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int BMFFOBNECKB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5890", Offset = "0x1FD4A90", VA = "0x181FD5890")]
	private FEBJFOOPNHB([In] PCDHHAOMILC<CHLNNCNOLPG.MLKINMPODCP, DBNGFIBEHEK> LELPOKHBKDA, int OJJLPONKIGD, int JIFONIEALII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5820", Offset = "0x1FD4A20", VA = "0x181FD5820")]
	public static FEBJFOOPNHB FJAAFKPDAIA()
	{
		return default(FEBJFOOPNHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5630", Offset = "0x1FD4830", VA = "0x181FD5630")]
	public void CKOHIKCJKJA([In] NONHMEFJOIK MOPANCMKHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2B1C170", Offset = "0x2B1B370", VA = "0x182B1C170")]
	public static void AGALHLJOLPH<TDeps, TStateSys>(NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO, OMNCLBBEMMM<MBFOKBNJOGA> KDKOCALOMKG) where TDeps : notnull, BILICGJHGFC<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GEKEMGKKCIL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD5DA0", Offset = "0x1FD4FA0", VA = "0x181FD5DA0")]
	public static void AGALHLJOLPH(NONHMEFJOIK HIKEOGPAJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IGLBFDLJGIL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface MLOAACJACLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CHJAJHJPHJF(MAHDLFLAHIJ<byte> IPNOEBHFNMF, int ENEDCKANOFI);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PHMFJCMFCEE : MLOAACJACLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FDFAB0", Offset = "0x1FDECB0", VA = "0x181FDFAB0", Slot = "4")]
		public void CHJAJHJPHJF(MAHDLFLAHIJ<byte> IPNOEBHFNMF, int ENEDCKANOFI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct OOHJFNJNGKO : MLOAACJACLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1FDA750", Offset = "0x1FD9950", VA = "0x181FDA750", Slot = "4")]
		public void CHJAJHJPHJF(MAHDLFLAHIJ<byte> IPNOEBHFNMF, int ENEDCKANOFI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct DMJKAOJOGLG : MLOAACJACLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FD5300", Offset = "0x1FD4500", VA = "0x181FD5300", Slot = "4")]
		public void CHJAJHJPHJF(MAHDLFLAHIJ<byte> IPNOEBHFNMF, int ENEDCKANOFI)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct MGNKBJMNDCE : MLOAACJACLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1FD94B0", Offset = "0x1FD86B0", VA = "0x181FD94B0", Slot = "4")]
		public void CHJAJHJPHJF(MAHDLFLAHIJ<byte> IPNOEBHFNMF, int ENEDCKANOFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class CMFENEBPOBC<TCallProcessorDeps> where TCallProcessorDeps : struct, MLOAACJACLI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps NMBACBFNMGF;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27549B0", Offset = "0x2753BB0", VA = "0x1827549B0")]
		public static int AGALHLJOLPH<TDeps, TStateSys>(TDeps HDLOJHGAFKF, TStateSys DMDDBNBIFMI, NONHMEFJOIK MOPANCMKHLH, [In] MAHDLFLAHIJ<byte> HNBDOKAPHPI, int KJJBKOMLKJA) where TDeps : BILICGJHGFC<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private MAHDLFLAHIJ<JAGGKPOBNJB> MNNBHGJMHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>> BNGCJLKHMCJ;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8C10", Offset = "0x1FD7E10", VA = "0x181FD8C10")]
	private IGLBFDLJGIL([In] MAHDLFLAHIJ<JAGGKPOBNJB> EFKHLOMFLAE, Dictionary<OMNCLBBEMMM<EEHEIECAIMH<KOHBJJHPJHN>>, OMNCLBBEMMM<CHLNNCNOLPG.MLKINMPODCP>> OGFEPBHLALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8B50", Offset = "0x1FD7D50", VA = "0x181FD8B50")]
	public static IGLBFDLJGIL FJAAFKPDAIA()
	{
		return default(IGLBFDLJGIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8B10", Offset = "0x1FD7D10", VA = "0x181FD8B10")]
	public void CKOHIKCJKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2B8FE80", Offset = "0x2B8F080", VA = "0x182B8FE80")]
	public static void AGALHLJOLPH<TDeps, TStateSys>(NONHMEFJOIK HIKEOGPAJAF, TDeps HDLOJHGAFKF, TStateSys FGFGKADDOOO) where TDeps : BILICGJHGFC<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BMMJFGFKJME<TDeps, TIndex, TValues> where TDeps : struct, KGMGKFEGOAF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4E84F50", Offset = "0x4E84150", VA = "0x184E84F50")]
	public static void AGALHLJOLPH([In] MAHDLFLAHIJ<JAGGKPOBNJB> EFKHLOMFLAE, int BFPHHJPAKDD, TValues MNHECFLLMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface KGMGKFEGOAF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MAHDLFLAHIJ<TIndex> NKEPIPKONHE(int BFPHHJPAKDD, [In] TValues MNHECFLLMJH);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(TIndex DHNLEFJCEAH, [In] TValues MNHECFLLMJH);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHLAFJJMIHD(TIndex DHNLEFJCEAH, TValues MNHECFLLMJH, OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface FKMOBJHPBIJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex IOBLLDBMLEL(int DHNLEFJCEAH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFGMCAJIFLJ(TIndex DHNLEFJCEAH, [In] TValues MNHECFLLMJH);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OMNCLBBEMMM<EEHEIECAIMH<JHGAOCPFCLJ>> LEMJDHOPEOL(TIndex DHNLEFJCEAH, [In] TValues MNHECFLLMJH);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class GAJHBBDMJJK<TDeps, TIndex, TValues> where TDeps : struct, FKMOBJHPBIJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3CAAF60", Offset = "0x3CAA160", VA = "0x183CAAF60")]
	public static MAHDLFLAHIJ<TIndex> AGALHLJOLPH(int BFPHHJPAKDD, [In] TValues MNHECFLLMJH)
	{
		return default(MAHDLFLAHIJ<TIndex>);
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
