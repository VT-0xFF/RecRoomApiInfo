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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x20BF710", Offset = "0x20BE110", VA = "0x1820BF710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct OLMIGEAENHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> AFOIONJHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int JGJBOLABHCM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
	public OLMIGEAENHI(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> LCPNEJHOLNH, int ELDAPMPELBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DEKKFMGMFJG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class DDJOEHBNPKI : JLFKLMDLHAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct MDBPNOAFNEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly CGDDIIDHBMN<byte> DGBCKGKIAFP;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2062DC0", Offset = "0x20617C0", VA = "0x182062DC0")]
		public MDBPNOAFNEJ(CGDDIIDHBMN<byte> OPJILLDCBJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20BF2A0", Offset = "0x20BDCA0", VA = "0x1820BF2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LEPOFFMGMIG : JLFKLMDLHAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MBFIAEFLCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> JDMKOPEOJPH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public MBFIAEFLCOO(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> BCCLCJHBJCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum HBMDCJGCMEH
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
	public sealed class OGOCGBNGHBP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class JLFKLMDLHAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LPGOIMCCBIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly HBMDCJGCMEH KICIBBOIGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MLGFJIHMDCD<JLFKLMDLHAD> NKDHAOPNKKC;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		public LPGOIMCCBIN(HBMDCJGCMEH DMOKMPNIHEM, MLGFJIHMDCD<JLFKLMDLHAD> OIJIDHLBHEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class HBGDLIFMDGG : JLFKLMDLHAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct GHBBOKFPJND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNAAHNNCFOP;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public GHBBOKFPJND(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FHNALJNGDFL : JLFKLMDLHAD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct ENGDFEHIIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GFDAFGLFBDL GABMPNHDOIK;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public ENGDFEHIIFE(GFDAFGLFBDL KGNJAPCILGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x20BC250", Offset = "0x20BAC50", VA = "0x1820BC250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DHOGMNOIJFD<OGOCGBNGHBP, LPGOIMCCBIN> FMCGBCEAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal DHOGMNOIJFD<DDJOEHBNPKI, MDBPNOAFNEJ> OOFPFIFHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal DHOGMNOIJFD<LEPOFFMGMIG, MBFIAEFLCOO> NNDJNNOMKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DHOGMNOIJFD<HBGDLIFMDGG, GHBBOKFPJND> AHGOFCHBIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal DHOGMNOIJFD<FHNALJNGDFL, ENGDFEHIIFE> CDKODICGNAP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20BBB80", Offset = "0x20BA580", VA = "0x1820BBB80")]
	private DEKKFMGMFJG([In] DHOGMNOIJFD<OGOCGBNGHBP, LPGOIMCCBIN> DCFGOJMPGGH, [In] DHOGMNOIJFD<DDJOEHBNPKI, MDBPNOAFNEJ> ABEEOPENCKK, [In] DHOGMNOIJFD<LEPOFFMGMIG, MBFIAEFLCOO> MGMCFGHEBNA, [In] DHOGMNOIJFD<HBGDLIFMDGG, GHBBOKFPJND> GIICNLFLHNC, [In] DHOGMNOIJFD<FHNALJNGDFL, ENGDFEHIIFE> HAEKFGDOHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x20BBA40", Offset = "0x20BA440", VA = "0x1820BBA40")]
	public static DEKKFMGMFJG MMKGNMBHOIH()
	{
		return default(DEKKFMGMFJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DKEIMHOBMEH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20BBD80", Offset = "0x20BA780", VA = "0x1820BBD80")]
	public static void EPGEGEJNIJO(this DEKKFMGMFJG PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EDOGKIFJHGI
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
public struct OCEJPHJMNGN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class AJECKBKIGAC : ADFOBMDJAFE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct MKNOCINECNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> NAHGBBPCFDM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public MKNOCINECNH(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> HIGFNBDNOKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HOMIMLGKAJH
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
	public sealed class DAELAILAPNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ADFOBMDJAFE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct IDBHNENAMJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HOMIMLGKAJH KICIBBOIGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly MLGFJIHMDCD<ADFOBMDJAFE> NKDHAOPNKKC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		public IDBHNENAMJJ(HOMIMLGKAJH DMOKMPNIHEM, MLGFJIHMDCD<ADFOBMDJAFE> OIJIDHLBHEH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal DHOGMNOIJFD<DAELAILAPNC, IDBHNENAMJJ> FMCGBCEAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DHOGMNOIJFD<AJECKBKIGAC, MKNOCINECNH> CKOPNLDMEPG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x20BBC90", Offset = "0x20BA690", VA = "0x1820BBC90")]
	private OCEJPHJMNGN([In] DHOGMNOIJFD<DAELAILAPNC, IDBHNENAMJJ> DCFGOJMPGGH, [In] DHOGMNOIJFD<AJECKBKIGAC, MKNOCINECNH> APKGIANJLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20BF790", Offset = "0x20BE190", VA = "0x1820BF790")]
	public static OCEJPHJMNGN MMKGNMBHOIH()
	{
		return default(OCEJPHJMNGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EICFCMKIDIH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20BC1F0", Offset = "0x20BABF0", VA = "0x1820BC1F0")]
	public static void EPGEGEJNIJO(this OCEJPHJMNGN PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ALPMBOACDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public CBGFCAOFHCN<int> AKHJNLJICPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public CBGFCAOFHCN<int> HKDDLLEFCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int ONIBMGILCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KGOODDGIABN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20BA1A0", Offset = "0x20B8BA0", VA = "0x1820BA1A0")]
	private ALPMBOACDMF([In] CBGFCAOFHCN<int> PNMNBADKCDI, [In] CBGFCAOFHCN<int> IJMAPABGINN, int ALGFKMJNPAA, int JGJFFBCPJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20BA100", Offset = "0x20B8B00", VA = "0x1820BA100")]
	public static ALPMBOACDMF MMKGNMBHOIH()
	{
		return default(ALPMBOACDMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JAACABALDNA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20BCAE0", Offset = "0x20BB4E0", VA = "0x1820BCAE0")]
	public static void EPGEGEJNIJO(this ALPMBOACDMF PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HJPKANLABBD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum OHJJANKKGBA
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class JHGNJJLPPFN : HHEOHGGDIJJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct EFCBBFOPMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly MLGFJIHMDCD<BFHCGGFBNCB> KCBAJFKMKFG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public EFCBBFOPMMD(MLGFJIHMDCD<BFHCGGFBNCB> JOIIPABDJDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class GOBEGAFNAEP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HHEOHGGDIJJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct MGPPABIODKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly OHJJANKKGBA KICIBBOIGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MLGFJIHMDCD<HHEOHGGDIJJ> NKDHAOPNKKC;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		private MGPPABIODKI(OHJJANKKGBA DMOKMPNIHEM, MLGFJIHMDCD<HHEOHGGDIJJ> OIJIDHLBHEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x20BF570", Offset = "0x20BDF70", VA = "0x1820BF570")]
		public static MGPPABIODKI MMKGNMBHOIH(OHJJANKKGBA DMOKMPNIHEM, MLGFJIHMDCD<HHEOHGGDIJJ> OIJIDHLBHEH)
		{
			return default(MGPPABIODKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class OKDCJEPEIEF : HHEOHGGDIJJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct DFBBMIPJHNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly MLGFJIHMDCD<BFHCGGFBNCB> KCBAJFKMKFG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public DFBBMIPJHNJ(MLGFJIHMDCD<BFHCGGFBNCB> JOIIPABDJDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BFHCGGFBNCB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct DFIKMDIFGII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CBGFCAOFHCN<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> KAPICABJJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CBGFCAOFHCN<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> MPPBEJLKKAB;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x20BBC90", Offset = "0x20BA690", VA = "0x1820BBC90")]
		private DFIKMDIFGII([In] CBGFCAOFHCN<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> NOCLMLOBJPM, [In] CBGFCAOFHCN<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> PAODDFFIPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x20BBC10", Offset = "0x20BA610", VA = "0x1820BBC10")]
		public static DFIKMDIFGII MMKGNMBHOIH()
		{
			return default(DFIKMDIFGII);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal DHOGMNOIJFD<GOBEGAFNAEP, MGPPABIODKI> FMCGBCEAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal DHOGMNOIJFD<OKDCJEPEIEF, DFBBMIPJHNJ> DDCCOPFJJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DHOGMNOIJFD<JHGNJJLPPFN, EFCBBFOPMMD> AMBBFEOONDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal CBGFCAOFHCN<(MLGFJIHMDCD<GOBEGAFNAEP> CallId, MLGFJIHMDCD<BFHCGGFBNCB> IOId)> CKAGNLENPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DHOGMNOIJFD<BFHCGGFBNCB, DFIKMDIFGII> GIBFMGLDGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal IJMILKHKGPD<BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> FBFCAPEFOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal IJMILKHKGPD<BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> CCMJPIAFNDD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20BCA20", Offset = "0x20BB420", VA = "0x1820BCA20")]
	private HJPKANLABBD([In] DHOGMNOIJFD<GOBEGAFNAEP, MGPPABIODKI> DCFGOJMPGGH, [In] DHOGMNOIJFD<OKDCJEPEIEF, DFBBMIPJHNJ> KFFGJHFKJOH, [In] DHOGMNOIJFD<JHGNJJLPPFN, EFCBBFOPMMD> CADKPACAMOF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<GOBEGAFNAEP> CallId, MLGFJIHMDCD<BFHCGGFBNCB> IOId)> BBODMOBLGNE, [In] DHOGMNOIJFD<BFHCGGFBNCB, DFIKMDIFGII> GPOGOODBJLN, [In] IJMILKHKGPD<BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> FFEKMPNPLAI, [In] IJMILKHKGPD<BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> MFJDKJJALOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20BC880", Offset = "0x20BB280", VA = "0x1820BC880")]
	public static HJPKANLABBD MMKGNMBHOIH()
	{
		return default(HJPKANLABBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MEMIHCALKND
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x20BF520", Offset = "0x20BDF20", VA = "0x1820BF520")]
	private static void EPGEGEJNIJO(this HJPKANLABBD.DFIKMDIFGII PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x20BF310", Offset = "0x20BDD10", VA = "0x1820BF310")]
	public static void EPGEGEJNIJO(this HJPKANLABBD PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct AMGPEKAANLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public CBGFCAOFHCN<byte> IPDGBBBGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal HJPKANLABBD LDKOEKLJOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal AMKJJAEMFJA OBDGLKDGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> HJCACIALINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal DEKKFMGMFJG JIHAODKLAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal OCEJPHJMNGN DNMGCJAKENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal IJMILKHKGPD<EGLCODOFCAG, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>?> BKEAFHGIEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal CBGFCAOFHCN<MLGFJIHMDCD<EGLCODOFCAG>> LJLAOLNMJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> LFBEOAIGJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> PHIHOILGBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> KHHHPKCFJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal DMHIKALDJFB BDBGDEHAIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal AFEOIEMKLHB ICAALCABBII;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x20BACC0", Offset = "0x20B96C0", VA = "0x1820BACC0")]
	private AMGPEKAANLN([In] CBGFCAOFHCN<byte> MPCPEPNKNJO, [In] HJPKANLABBD JEPJPCAMFAH, [In] AMKJJAEMFJA NILJGGPJFHI, [In] DEKKFMGMFJG MBMGAPBHCCE, [In] OCEJPHJMNGN LBHMAIHPKOD, [In] IJMILKHKGPD<EGLCODOFCAG, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>?> OPOEBBFPBGL, [In] CBGFCAOFHCN<MLGFJIHMDCD<EGLCODOFCAG>> PCPMOBDBJIO, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> COJGENDMOOF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> JACJEPHDHGH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> MPDIEPCFMPN, [In] DMHIKALDJFB IDGMBBIBCLH, [In] AFEOIEMKLHB BIDJANAJOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x20BA200", Offset = "0x20B8C00", VA = "0x1820BA200")]
	public static AMGPEKAANLN MMKGNMBHOIH()
	{
		return default(AMGPEKAANLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LKGDKGLMPEH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct DOEBCJEBGGG : CFAKADPGIPM<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>, IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x20BC110", Offset = "0x20BAB10", VA = "0x1820BC110")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x20BC0D0", Offset = "0x20BAAD0", VA = "0x1820BC0D0", Slot = "4")]
		public MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> IKPNKIJLCMD(int EBDDHAPIAHH)
		{
			return default(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		public bool LAFAIBEIFLG(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "5")]
		private bool HPELGEKBNKP(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x20BC100", Offset = "0x20BAB00", VA = "0x1820BC100", Slot = "6")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> NBHHHBEEAGE(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct BEDOMAOCGCM : PKKMKLFEGEC<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>, IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x20BB410", Offset = "0x20B9E10", VA = "0x1820BB410")]
		public CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>> GOIGOKENPDD(int PMOJILAOLPF, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20BB480", Offset = "0x20B9E80", VA = "0x1820BB480")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x20BB350", Offset = "0x20B9D50", VA = "0x1820BB350", Slot = "6")]
		public void FDBDLAODONO(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x20BB410", Offset = "0x20B9E10", VA = "0x1820BB410", Slot = "4")]
		private CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>> NHGJNDPOHAB(int PMOJILAOLPF, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x20BB340", Offset = "0x20B9D40", VA = "0x1820BB340", Slot = "5")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> DMGKEFBINMD(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct LBONAEHANGL : CFAKADPGIPM<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>, IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x20BCB70", Offset = "0x20BB570", VA = "0x1820BCB70")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x20BCB40", Offset = "0x20BB540", VA = "0x1820BCB40", Slot = "4")]
		public MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> IKPNKIJLCMD(int EBDDHAPIAHH)
		{
			return default(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		public bool LAFAIBEIFLG(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "5")]
		private bool OLIHKFFJPPL(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x20BCC20", Offset = "0x20BB620", VA = "0x1820BCC20", Slot = "6")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> PKBOHADPEMP(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OIHGPHJFMAP : PKKMKLFEGEC<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>, IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x20BF820", Offset = "0x20BE220", VA = "0x1820BF820")]
		public CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>> GOIGOKENPDD(int PMOJILAOLPF, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x20BF960", Offset = "0x20BE360", VA = "0x1820BF960")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x20BF890", Offset = "0x20BE290", VA = "0x1820BF890", Slot = "6")]
		public void FDBDLAODONO(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x20BF820", Offset = "0x20BE220", VA = "0x1820BF820", Slot = "4")]
		private CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>> DLJEBJNOCPC(int PMOJILAOLPF, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x20BF950", Offset = "0x20BE350", VA = "0x1820BF950", Slot = "5")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> JMBGJNOKKJP(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> EBDDHAPIAHH, [In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NDOCHMOJHHB : CFAKADPGIPM<MLGFJIHMDCD<EEPPPKFALIN>, IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x20BF630", Offset = "0x20BE030", VA = "0x1820BF630")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x20BF580", Offset = "0x20BDF80", VA = "0x1820BF580", Slot = "4")]
		public MLGFJIHMDCD<EEPPPKFALIN> IKPNKIJLCMD(int EBDDHAPIAHH)
		{
			return default(MLGFJIHMDCD<EEPPPKFALIN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20BF5B0", Offset = "0x20BDFB0", VA = "0x1820BF5B0")]
		public bool LAFAIBEIFLG(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x20BF5B0", Offset = "0x20BDFB0", VA = "0x1820BF5B0", Slot = "5")]
		private bool NAJNGKNMLLF(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x20BF700", Offset = "0x20BE100", VA = "0x1820BF700", Slot = "6")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> PEPEKHCMKNC(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct COEPJMGGCNH : PKKMKLFEGEC<MLGFJIHMDCD<EEPPPKFALIN>, IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x20BB580", Offset = "0x20B9F80", VA = "0x1820BB580")]
		public CBGFCAOFHCN<MLGFJIHMDCD<EEPPPKFALIN>> GOIGOKENPDD(int PMOJILAOLPF, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<MLGFJIHMDCD<EEPPPKFALIN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20BB6E0", Offset = "0x20BA0E0", VA = "0x1820BB6E0")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x20BB5F0", Offset = "0x20B9FF0", VA = "0x1820BB5F0", Slot = "6")]
		public void FDBDLAODONO(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x20BB580", Offset = "0x20B9F80", VA = "0x1820BB580", Slot = "4")]
		private CBGFCAOFHCN<MLGFJIHMDCD<EEPPPKFALIN>> AELDJKLJIFM(int PMOJILAOLPF, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<MLGFJIHMDCD<EEPPPKFALIN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x20BB6D0", Offset = "0x20BA0D0", VA = "0x1820BB6D0", Slot = "5")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> IHCKJAMLKHL(MLGFJIHMDCD<EEPPPKFALIN> EBDDHAPIAHH, [In] IJMILKHKGPD<EEPPPKFALIN, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>?> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct HAOPMFELPDP : CFAKADPGIPM<int, CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x20BC5D0", Offset = "0x20BAFD0", VA = "0x1820BC5D0")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x912E80", Offset = "0x911880", VA = "0x180912E80", Slot = "4")]
		public int IKPNKIJLCMD(int EBDDHAPIAHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		public bool LAFAIBEIFLG(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "5")]
		private bool IDCMHJACHEN(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x20BC5C0", Offset = "0x20BAFC0", VA = "0x1820BC5C0", Slot = "6")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> IHJIJNGFKOH(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct EPPGKHDCDHO : PKKMKLFEGEC<int, CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x20BC380", Offset = "0x20BAD80", VA = "0x1820BC380")]
		public CBGFCAOFHCN<int> GOIGOKENPDD(int PMOJILAOLPF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x20BC3F0", Offset = "0x20BADF0", VA = "0x1820BC3F0")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x20BC280", Offset = "0x20BAC80", VA = "0x1820BC280", Slot = "6")]
		public void FDBDLAODONO(int EBDDHAPIAHH, CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20BC380", Offset = "0x20BAD80", VA = "0x1820BC380", Slot = "4")]
		private CBGFCAOFHCN<int> IADDHHGLCLO(int PMOJILAOLPF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20BC270", Offset = "0x20BAC70", VA = "0x1820BC270", Slot = "5")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> ELPMHNGOFAG(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> VariableId, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<JCILPIOHADJ>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct GPJNCGLAPOD : CFAKADPGIPM<int, CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x20BC520", Offset = "0x20BAF20", VA = "0x1820BC520")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x912E80", Offset = "0x911880", VA = "0x180912E80", Slot = "4")]
		public int IKPNKIJLCMD(int EBDDHAPIAHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		public bool LAFAIBEIFLG(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "5")]
		private bool HLMIKJKFJHK(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x20BC510", Offset = "0x20BAF10", VA = "0x1820BC510", Slot = "6")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> LBNCFKHDCCL(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct HHKCLNNOLKJ : PKKMKLFEGEC<int, CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x20BC670", Offset = "0x20BB070", VA = "0x1820BC670")]
		public CBGFCAOFHCN<int> GOIGOKENPDD(int PMOJILAOLPF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x20BC7E0", Offset = "0x20BB1E0", VA = "0x1820BC7E0")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x20BC6E0", Offset = "0x20BB0E0", VA = "0x1820BC6E0", Slot = "6")]
		public void FDBDLAODONO(int EBDDHAPIAHH, CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x20BC670", Offset = "0x20BB070", VA = "0x1820BC670", Slot = "4")]
		private CBGFCAOFHCN<int> CHDOCGNGLFA(int PMOJILAOLPF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x20BC7D0", Offset = "0x20BB1D0", VA = "0x1820BC7D0", Slot = "5")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> NGKNECOFFKO(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct CPGNIKJGKJC : CFAKADPGIPM<int, CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x20BB7C0", Offset = "0x20BA1C0", VA = "0x1820BB7C0")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x912E80", Offset = "0x911880", VA = "0x180912E80", Slot = "4")]
		public int IKPNKIJLCMD(int EBDDHAPIAHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		public bool LAFAIBEIFLG(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "5")]
		private bool HLMIKJKFJHK(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x20BB7B0", Offset = "0x20BA1B0", VA = "0x1820BB7B0", Slot = "6")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> LBNCFKHDCCL(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct POPEMCCIBCJ : PKKMKLFEGEC<int, CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x20C4E00", Offset = "0x20C3800", VA = "0x1820C4E00")]
		public CBGFCAOFHCN<int> GOIGOKENPDD(int PMOJILAOLPF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x20C4F80", Offset = "0x20C3980", VA = "0x1820C4F80")]
		public MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x20C4E70", Offset = "0x20C3870", VA = "0x1820C4E70", Slot = "6")]
		public void FDBDLAODONO(int EBDDHAPIAHH, CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x20C4E00", Offset = "0x20C3800", VA = "0x1820C4E00", Slot = "4")]
		private CBGFCAOFHCN<int> CHDOCGNGLFA(int PMOJILAOLPF, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(CBGFCAOFHCN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x20C4F70", Offset = "0x20C3970", VA = "0x1820C4F70", Slot = "5")]
		private MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> NGKNECOFFKO(int EBDDHAPIAHH, [In] CBGFCAOFHCN<(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> Target, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ByteCodeWriteLocation)> ACOKCANBLGD)
		{
			return default(MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct KBAKLGAJIBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> FNDLBOGKPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool LLPOOPBJJKH;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x151E9D0", Offset = "0x151D3D0", VA = "0x18151E9D0")]
		public KBAKLGAJIBB(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ, bool MKLIIOCCMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x20BCB30", Offset = "0x20BB530", VA = "0x1820BCB30")]
		public void LPCIDOHDNGA([Out] MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ, [Out] bool MKLIIOCCMCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct BPMGCEAFEBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly MLGFJIHMDCD<EEPPPKFALIN> OKJFMONDMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> FNDLBOGKPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool LLPOOPBJJKH;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x20BB570", Offset = "0x20B9F70", VA = "0x1820BB570")]
		public BPMGCEAFEBN(MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ, bool MKLIIOCCMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x20BB560", Offset = "0x20B9F60", VA = "0x1820BB560")]
		public void LPCIDOHDNGA([Out] MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ, [Out] bool MKLIIOCCMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x20BB540", Offset = "0x20B9F40", VA = "0x1820BB540")]
		public void LPCIDOHDNGA([Out] MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ, [Out] MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK, [Out] bool MKLIIOCCMCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct BHKFMFKONNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly MLGFJIHMDCD<EEPPPKFALIN> OKJFMONDMNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> FNDLBOGKPEP;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		public BHKFMFKONNJ(MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x20BB530", Offset = "0x20B9F30", VA = "0x1820BB530")]
		public void LPCIDOHDNGA([Out] MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ, [Out] MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x20BD9B0", Offset = "0x20BC3B0", VA = "0x1820BD9B0")]
	public static void EPGEGEJNIJO(this AMGPEKAANLN PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x20BE240", Offset = "0x20BCC40", VA = "0x1820BE240")]
	public static void IDIIENHECAN(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> AJKPPCOOMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x20BE7F0", Offset = "0x20BD1F0", VA = "0x1820BE7F0")]
	public static void LILIIHOMHPN(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> AJKPPCOOMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x20BD7B0", Offset = "0x20BC1B0", VA = "0x1820BD7B0")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>? DNJIPNEPMKI([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20BF030", Offset = "0x20BDA30", VA = "0x1820BF030")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> OEAKEJEICNM([In] this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20BE9D0", Offset = "0x20BD3D0", VA = "0x1820BE9D0")]
	private static void MGABEKAGNJE(this AMGPEKAANLN PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x20BE180", Offset = "0x20BCB80", VA = "0x1820BE180")]
	private static MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>? HNFBKILMHDO([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x20BD130", Offset = "0x20BBB30", VA = "0x1820BD130")]
	public static void CHMHONGOPCL(this AMGPEKAANLN PECHDAFMNOO, [In] CBGFCAOFHCN<OLMIGEAENHI> IIFPNHMGOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x20BCED0", Offset = "0x20BB8D0", VA = "0x1820BCED0")]
	public static DEKKFMGMFJG.HBMDCJGCMEH BNPEAPOLCJA([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
	{
		return default(DEKKFMGMFJG.HBMDCJGCMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20BE2D0", Offset = "0x20BCCD0", VA = "0x1820BE2D0")]
	public static CGDDIIDHBMN<byte> INOMBDIKMNB([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
	{
		return default(CGDDIIDHBMN<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x20BD6C0", Offset = "0x20BC0C0", VA = "0x1820BD6C0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DMGLGJPFKFN([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20BD040", Offset = "0x20BBA40", VA = "0x1820BD040")]
	public static GFDAFGLFBDL CFEAKDHGJCG([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
	{
		return default(GFDAFGLFBDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2D411E0", Offset = "0x2D3FBE0", VA = "0x182D411E0")]
	private static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> DOOGOICGGGL<TMJoin>(this AMGPEKAANLN PECHDAFMNOO, DEKKFMGMFJG.HBMDCJGCMEH DMOKMPNIHEM, MLGFJIHMDCD<TMJoin> OIJIDHLBHEH) where TMJoin : DEKKFMGMFJG.JLFKLMDLHAD
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20BF220", Offset = "0x20BDC20", VA = "0x1820BF220")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> PIJDOAKOGCO(this AMGPEKAANLN PECHDAFMNOO, bool GEACCNIJNLF)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20BDE50", Offset = "0x20BC850", VA = "0x1820BDE50")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> GDNFFILOKKA(this AMGPEKAANLN PECHDAFMNOO, CGDDIIDHBMN<byte> OPJILLDCBJI)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x20BE3C0", Offset = "0x20BCDC0", VA = "0x1820BE3C0")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> IOPMBNJPHHO(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> BCCLCJHBJCL)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x20BE030", Offset = "0x20BCA30", VA = "0x1820BE030")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> GOACEONPCNA(this AMGPEKAANLN PECHDAFMNOO, int EPNBMFOFBHE)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x20BE600", Offset = "0x20BD000", VA = "0x1820BE600")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> KBLGJIIEOFA(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D421B0", Offset = "0x2D40BB0", VA = "0x182D421B0")]
	private static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> PDPAADKHHKM<TMJoin>(this AMGPEKAANLN PECHDAFMNOO, OCEJPHJMNGN.HOMIMLGKAJH DMOKMPNIHEM, MLGFJIHMDCD<TMJoin> OIJIDHLBHEH) where TMJoin : OCEJPHJMNGN.ADFOBMDJAFE
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x20BF0F0", Offset = "0x20BDAF0", VA = "0x1820BF0F0")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> OPHIGLAHDPC(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20BEBF0", Offset = "0x20BD5F0", VA = "0x1820BEBF0")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> NADNOECHHKO(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x20BE8C0", Offset = "0x20BD2C0", VA = "0x1820BE8C0")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> LLLAFIAMAGJ(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> HIGFNBDNOKA)
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x20BE5C0", Offset = "0x20BCFC0", VA = "0x1820BE5C0")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> JLNCIBCFBLL(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20BDEE0", Offset = "0x20BC8E0", VA = "0x1820BDEE0")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> GHBIFGMFOAJ(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20BDDD0", Offset = "0x20BC7D0", VA = "0x1820BDDD0")]
	public static HJPKANLABBD.OHJJANKKGBA FMOLAEJBEEC([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> HOCIOAMJPOO)
	{
		return default(HJPKANLABBD.OHJJANKKGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20BE7B0", Offset = "0x20BD1B0", VA = "0x1820BE7B0")]
	public static CDOCMFNFDNB<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>, GBIJLBGHMJG<HJPKANLABBD.BFHCGGFBNCB>> LDJBCFLLIEO([In] this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(CDOCMFNFDNB<MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>, GBIJLBGHMJG<HJPKANLABBD.BFHCGGFBNCB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20BD390", Offset = "0x20BBD90", VA = "0x1820BD390")]
	public static MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> CNDOOJBLDKI([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> HOCIOAMJPOO)
	{
		return default(MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x20BDFB0", Offset = "0x20BC9B0", VA = "0x1820BDFB0")]
	public static HJPKANLABBD.DFIKMDIFGII GMCMDEJDJPC([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> JOIIPABDJDD)
	{
		return default(HJPKANLABBD.DFIKMDIFGII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20BD570", Offset = "0x20BBF70", VA = "0x1820BD570")]
	public static HJPKANLABBD.DFIKMDIFGII DKPJKBEOJMN(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> JOIIPABDJDD)
	{
		return default(HJPKANLABBD.DFIKMDIFGII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D41BD0", Offset = "0x2D405D0", VA = "0x182D41BD0")]
	private static MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> KALNGEDGIBA<TMJoin>(this AMGPEKAANLN PECHDAFMNOO, HJPKANLABBD.OHJJANKKGBA DMOKMPNIHEM, MLGFJIHMDCD<TMJoin> OIJIDHLBHEH) where TMJoin : HJPKANLABBD.HHEOHGGDIJJ
	{
		return default(MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x20BEDF0", Offset = "0x20BD7F0", VA = "0x1820BEDF0")]
	public static (MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>) NDLEJNPIMLI(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default((MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x20BEC30", Offset = "0x20BD630", VA = "0x1820BEC30")]
	public static (MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>) NBAKLNJOEEI(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default((MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x20BCCA0", Offset = "0x20BB6A0", VA = "0x1820BCCA0")]
	public static MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> AHCGOOAAKJP(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x20BDF20", Offset = "0x20BC920", VA = "0x1820BDF20")]
	public static void GHLNJDPGNLF(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB> JOIIPABDJDD, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> GOIEBBAOOHA, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>> OCMJCKEMKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D403C0", Offset = "0x2D3EDC0", VA = "0x182D403C0")]
	public static KBAKLGAJIBB AIFOLFNIFKJ<TDeps, TStateSys>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK) where TDeps : NNHKMOPDPHA<TStateSys>
	{
		return default(KBAKLGAJIBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D41290", Offset = "0x2D3FC90", VA = "0x182D41290")]
	public static BPMGCEAFEBN EOLGOEGFLIG<TDeps, TStateSys>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<COGPDFLIJHB> ODLOJKBAHLA, int IGFHNMEDLLI) where TDeps : NNHKMOPDPHA<TStateSys>
	{
		return default(BPMGCEAFEBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2D41C70", Offset = "0x2D40670", VA = "0x182D41C70")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>? LEOCJPOAAFF<TDeps, TStateSys>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<COGPDFLIJHB> ODLOJKBAHLA, [In] ReadOnlySpan<int> KAFPEDBOFBA, [In] Span<BHKFMFKONNJ> NFBNEPOFEDM) where TDeps : NNHKMOPDPHA<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D41530", Offset = "0x2D3FF30", VA = "0x182D41530")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> FPFLNBGGAIB<TDeps, TStateSys>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ) where TDeps : NNHKMOPDPHA<TStateSys>
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x20BCF50", Offset = "0x20BB950", VA = "0x1820BCF50")]
	public static AMKJJAEMFJA.OOEMAEKGBPB CDJDCNEAFMB([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KFBALBFDDFF)
	{
		return default(AMKJJAEMFJA.OOEMAEKGBPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x20BD2A0", Offset = "0x20BBCA0", VA = "0x1820BD2A0")]
	public static AMKJJAEMFJA.PGDOHJNEAMD CJKGNEKDBJG([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KFBALBFDDFF)
	{
		return default(AMKJJAEMFJA.PGDOHJNEAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x20BF130", Offset = "0x20BDB30", VA = "0x1820BF130")]
	public static AMKJJAEMFJA.EMJMDDPNCDN PEOHOEANLCA([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KFBALBFDDFF)
	{
		return default(AMKJJAEMFJA.EMJMDDPNCDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x20BCD40", Offset = "0x20BB740", VA = "0x1820BCD40")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> BDNFHEAAKIF(this AMGPEKAANLN PECHDAFMNOO, int? BALEBIMMAIK, string HBOONHFLONJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x20BE440", Offset = "0x20BCE40", VA = "0x1820BE440")]
	public static AMKJJAEMFJA.HNMPFIMFPAO JJHAHHFNDMG([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KFBALBFDDFF)
	{
		return default(AMKJJAEMFJA.HNMPFIMFPAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x20BCC30", Offset = "0x20BB630", VA = "0x1820BCC30")]
	public static AMKJJAEMFJA.OGFGPLICGBI AEIIIHGKIMP([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KFBALBFDDFF)
	{
		return default(AMKJJAEMFJA.OGFGPLICGBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20BEFC0", Offset = "0x20BD9C0", VA = "0x1820BEFC0")]
	public static int? NODFGFPDPMB([In] this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KFBALBFDDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D420B0", Offset = "0x2D40AB0", VA = "0x182D420B0")]
	private static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> LPDOCEMHCOB<TMJoin>(this AMGPEKAANLN PECHDAFMNOO, int? BALEBIMMAIK, AMKJJAEMFJA.OGFGPLICGBI DMOKMPNIHEM, MLGFJIHMDCD<TMJoin> OIJIDHLBHEH) where TMJoin : AMKJJAEMFJA.LELOKBKNGKF
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20BEB40", Offset = "0x20BD540", VA = "0x1820BEB40")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> MPGIPEMBDDG(this AMGPEKAANLN PECHDAFMNOO, int? BALEBIMMAIK, MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> HOCIOAMJPOO, int EBDDHAPIAHH)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20BF090", Offset = "0x20BDA90", VA = "0x1820BF090")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> OMCNGGJKJNA(this AMGPEKAANLN PECHDAFMNOO, int? BALEBIMMAIK)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20BDC80", Offset = "0x20BC680", VA = "0x1820BDC80")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FAAABOGJLKB(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? NNPGCOAKKJO, int? BALEBIMMAIK)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20BE940", Offset = "0x20BD340", VA = "0x1820BE940")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> MABFBHOIFGI(this AMGPEKAANLN PECHDAFMNOO, int? BALEBIMMAIK, int EBDDHAPIAHH)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20BCCE0", Offset = "0x20BB6E0", VA = "0x1820BCCE0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> BCCBJFDBHHK(this AMGPEKAANLN PECHDAFMNOO, int? BALEBIMMAIK)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20BD870", Offset = "0x20BC270", VA = "0x1820BD870")]
	public static void EACKGMPEJON(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG, MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> HOCIOAMJPOO, int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20BE680", Offset = "0x20BD080", VA = "0x1820BE680")]
	public static void KHJCIEGNJJI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG, int EBDDHAPIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x20BE0B0", Offset = "0x20BCAB0", VA = "0x1820BE0B0")]
	public static void HDKAJMCKEIC(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20BE530", Offset = "0x20BCF30", VA = "0x1820BE530")]
	public static void JJJAGPPFKFP(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> IPOCAIFIKHJ, MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> HGIBDBMNPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x20BD5F0", Offset = "0x20BBFF0", VA = "0x1820BD5F0")]
	public static void DLDIBDEGFBP(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG, MLGFJIHMDCD<IEEJBCOLPEF<HNCBHEFCMGO>> JNJCKCOIGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D41B00", Offset = "0x2D40500", VA = "0x182D41B00")]
	public static void HBFCMPMODKD<M>(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FNKKFCGCENG, MLGFJIHMDCD<IEEJBCOLPEF<FIAEKMGGFMC<M>>> JNJCKCOIGKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NNHKMOPDPHA<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLGFJIHMDCD<KBPLJEDPMGK> HKLMNICDDLO(TStateSys MGPPMKLIDEK);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLGFJIHMDCD<KBPLJEDPMGK> NKPIBAKMKHO(TStateSys MGPPMKLIDEK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLGFJIHMDCD<KBPLJEDPMGK> CBJNDKINHGK(TStateSys MGPPMKLIDEK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLGFJIHMDCD<KBPLJEDPMGK> GKHGAEJEBPM(TStateSys MGPPMKLIDEK);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> ECPLPCEPNJA(TStateSys MGPPMKLIDEK, AMGPEKAANLN PAAJAFMIFAA, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> GCLFCMKPCEN(TStateSys MGPPMKLIDEK, AMGPEKAANLN PAAJAFMIFAA, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OOKEDPPKPPJ(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MLGFJIHMDCD<EGLCODOFCAG> DLAECDJHIOH(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK, int EINNMBDFPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EDOGKIFJHGI MKJJOMIAHJN(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LHHOLFJLAMH(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int KIJPKIJNDBH(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CGDDIIDHBMN<byte> OBBECBLMFDN(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(CGDDIIDHBMN<byte>, MLGFJIHMDCD<KBPLJEDPMGK>) GJJKEOIBBHH(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EEPPPKFALIN> KKKBAAHOPHK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int DJDBHJNEPMB(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MLGFJIHMDCD<EEPPPKFALIN> MOBHAHEMONJ(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<EGLCODOFCAG> NCKPDHPKIAJ, int IGFHNMEDLLI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MLGFJIHMDCD<EEPPPKFALIN> NLHHPEEIFFE(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, MLGFJIHMDCD<COGPDFLIJHB> ODLOJKBAHLA, int IGFHNMEDLLI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int DFLFLHDMAOE(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? OAPHFFNIKIN(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, int EBDDHAPIAHH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int AHNIIGPMCEI(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? NNPFOGKLAIN(TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI, int EBDDHAPIAHH);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PNHMGPJPKJB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F190", Offset = "0x2E4DB90", VA = "0x182E4F190")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC?> LIMCPHNGPOP<T, TOpInput, TOpOutput>(this AMGPEKAANLN PECHDAFMNOO, T CGCFANNHAMA, T GEGAHIEHOAB, int IJKMAJLGKNE, IntPtr LFEKCPAMHKM)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2E50F00", Offset = "0x2E4F900", VA = "0x182E50F00")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC?> PMFJHKLDGPC<T, TOpInput, TOpOutput>(this AMGPEKAANLN PECHDAFMNOO, T CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB, int IJKMAJLGKNE, IntPtr LFEKCPAMHKM)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E340", Offset = "0x2E4CD40", VA = "0x182E4E340")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC?> AGMDPECKJLF<TOpInput, TOpOutput>(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB, int IJKMAJLGKNE, IntPtr LFEKCPAMHKM)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x20BFC90", Offset = "0x20BE690", VA = "0x1820BFC90")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ABKHAMDKMBG(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x20C40D0", Offset = "0x20C2AD0", VA = "0x1820C40D0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> NFGCHCJDAJK(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x20BFF20", Offset = "0x20BE920", VA = "0x1820BFF20")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> AGHKJNOGOLF(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x20C2F40", Offset = "0x20C1940", VA = "0x1820C2F40")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> LDODEIKDEEM(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x20C08A0", Offset = "0x20BF2A0", VA = "0x1820C08A0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DHAOPFJFCFI(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x20C23A0", Offset = "0x20C0DA0", VA = "0x1820C23A0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ICNMJGHNGMK(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x20C2BF0", Offset = "0x20C15F0", VA = "0x1820C2BF0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KNPNEPHFLEP(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x20C2E20", Offset = "0x20C1820", VA = "0x1820C2E20")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KPAJDIFGDHA(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x20C3E50", Offset = "0x20C2850", VA = "0x1820C3E50")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> NDCGAPAFLCI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x20C3800", Offset = "0x20C2200", VA = "0x1820C3800")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> LNNJCMAPKJK(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, int GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x20C2200", Offset = "0x20C0C00", VA = "0x1820C2200")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> HLJIDLOBHAG(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x20C4CC0", Offset = "0x20C36C0", VA = "0x1820C4CC0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> PMLIFPBBAKK(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20C4780", Offset = "0x20C3180", VA = "0x1820C4780")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> OIIOHPCGDFH(this AMGPEKAANLN PECHDAFMNOO, float CGCFANNHAMA, float GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20C19D0", Offset = "0x20C03D0", VA = "0x1820C19D0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GDKKGMJDPIA(this AMGPEKAANLN PECHDAFMNOO, float CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x20C09C0", Offset = "0x20BF3C0", VA = "0x1820C09C0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DIHGEFHOJNI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x20C0820", Offset = "0x20BF220", VA = "0x1820C0820")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CLJABDGGOME(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, int GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x20C0B00", Offset = "0x20BF500", VA = "0x1820C0B00")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DLHKJDNCPJO(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x20C1D60", Offset = "0x20C0760", VA = "0x1820C1D60")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GPCCJHLBAGP(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x20C1460", Offset = "0x20BFE60", VA = "0x1820C1460")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> EOANHCLIFFF(this AMGPEKAANLN PECHDAFMNOO, float CGCFANNHAMA, float GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x20C2320", Offset = "0x20C0D20", VA = "0x1820C2320")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> IBALOJLMGHI(this AMGPEKAANLN PECHDAFMNOO, float CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x20C2180", Offset = "0x20C0B80", VA = "0x1820C2180")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> HJCMKNOLDJK(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x20C18D0", Offset = "0x20C02D0", VA = "0x1820C18D0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GBCCDFLMDFN(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, int GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x20C3640", Offset = "0x20C2040", VA = "0x1820C3640")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> LICCOGMBKIH(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x20C4900", Offset = "0x20C3300", VA = "0x1820C4900")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> OLMFFEKLDGO(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x20C0E60", Offset = "0x20BF860", VA = "0x1820C0E60")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> EBIGDDLNBBK(this AMGPEKAANLN PECHDAFMNOO, float CGCFANNHAMA, float GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x20C4880", Offset = "0x20C3280", VA = "0x1820C4880")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> OKCHAOBJEDL(this AMGPEKAANLN PECHDAFMNOO, float CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x20C24E0", Offset = "0x20C0EE0", VA = "0x1820C24E0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> JPEFFPFGOGF(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x20C3490", Offset = "0x20C1E90", VA = "0x1820C3490")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> LHEFPBCIMHD(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x20C41F0", Offset = "0x20C2BF0", VA = "0x1820C41F0")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> NHIIAELOGAH(this AMGPEKAANLN PECHDAFMNOO, int CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20C1340", Offset = "0x20BFD40", VA = "0x1820C1340")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> ELNFOMGEPEP(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20C44D0", Offset = "0x20C2ED0", VA = "0x1820C44D0")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> OCONJCHAANN(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OICCMEGKJMJ)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20C1950", Offset = "0x20C0350", VA = "0x1820C1950")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> GDDOCNKNLGC(this AMGPEKAANLN PECHDAFMNOO, int CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x20C14E0", Offset = "0x20BFEE0", VA = "0x1820C14E0")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> EPEFKIBEGNA(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20C3030", Offset = "0x20C1A30", VA = "0x1820C3030")]
	public static (MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>) LGOIAGKLNDO(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<GJEGPHJEIMP> PGLIMJEPEPF, [In] ReadOnlySpan<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> NOCLMLOBJPM, [In] ReadOnlySpan<int?> HFKBMHHIFAD, [In] Span<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> MGKKOJPEPPK)
	{
		return default((MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20C39E0", Offset = "0x20C23E0", VA = "0x1820C39E0")]
	public static (MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>) MKJPONIOLNA(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<MDEOHEADBEE> JABGPPGPNMM, [In] ReadOnlySpan<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> NOCLMLOBJPM, [In] ReadOnlySpan<int?> HFKBMHHIFAD, [In] Span<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> MGKKOJPEPPK)
	{
		return default((MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EA50", Offset = "0x2E4D450", VA = "0x182E4EA50")]
	public static (MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<KBPLJEDPMGK>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<TMarker>>, MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>) BHHLIJAKDFP<TMarker>(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<KBPLJEDPMGK> PGLGHGDBEBP, [In] ReadOnlySpan<byte> OIGMDCDEKEG)
	{
		return default((MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<IEEJBCOLPEF<KBPLJEDPMGK>>, MLGFJIHMDCD<IEEJBCOLPEF<GPLOIDPOBED>>, MLGFJIHMDCD<IEEJBCOLPEF<TMarker>>, MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20C0DA0", Offset = "0x20BF7A0", VA = "0x1820C0DA0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> EALHEEOPNGI(this AMGPEKAANLN PECHDAFMNOO, int ACEPIENHFHI, [Optional] MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20C2B00", Offset = "0x20C1500", VA = "0x1820C2B00")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KLGIAAEMFDK(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ACEPIENHFHI, [Optional] MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20C0730", Offset = "0x20BF130", VA = "0x1820C0730")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CKIFAEDDABI(this AMGPEKAANLN PECHDAFMNOO, [In] ReadOnlySpan<byte> ACEPIENHFHI, [Optional] MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x20BFB70", Offset = "0x20BE570", VA = "0x1820BFB70")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> AAMCEJCDGNA(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ACEPIENHFHI, int MPLHLKNKHIM, [Optional] MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x20C4AA0", Offset = "0x20C34A0", VA = "0x1820C4AA0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> OOLNHMGIKKK(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20C4BA0", Offset = "0x20C35A0", VA = "0x1820C4BA0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> PLLLDEECKCN(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x20C1790", Offset = "0x20C0190", VA = "0x1820C1790")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FJOGPJLLEEI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x20C2680", Offset = "0x20C1080", VA = "0x1820C2680")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KHKIGPCNECC(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x20C0C80", Offset = "0x20BF680", VA = "0x1820C0C80")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> EAEGDEDFLDK(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x20C1B00", Offset = "0x20C0500", VA = "0x1820C1B00")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GFCKCOPECFD(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x20C13E0", Offset = "0x20BFDE0", VA = "0x1820C13E0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ENBLCLGBIFE(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, int GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x20BFD90", Offset = "0x20BE790", VA = "0x1820BFD90")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> AFCJDCEHMDO(this AMGPEKAANLN PECHDAFMNOO, int CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x20C0390", Offset = "0x20BED90", VA = "0x1820C0390")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> BNCNFBIBBBI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CGCFANNHAMA, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GEGAHIEHOAB)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x20C0B80", Offset = "0x20BF580", VA = "0x1820C0B80")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DMIEMBDGAPA(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x20C1DE0", Offset = "0x20C07E0", VA = "0x1820C1DE0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> HBMFGKJJMFP(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x20C0060", Offset = "0x20BEA60", VA = "0x1820C0060")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> AGPELDCBNLP(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x20C1580", Offset = "0x20BFF80", VA = "0x1820C1580")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FEFFMIIBEAH(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x20C2050", Offset = "0x20C0A50", VA = "0x1820C2050")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> HFHFJEBJGLE(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x20C4390", Offset = "0x20C2D90", VA = "0x1820C4390")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> NJHCNIJJAEO(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x20C1020", Offset = "0x20BFA20", VA = "0x1820C1020")]
	public static MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>> EGAKHEIHMCF(this AMGPEKAANLN PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<IEEJBCOLPEF<IEEJBCOLPEF<JPOKFMIFKLO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x20C4680", Offset = "0x20C3080", VA = "0x1820C4680")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> OFGMKBCOIFA(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x20C4270", Offset = "0x20C2C70", VA = "0x1820C4270")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> NHNJHBLKMNK(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x20C1F10", Offset = "0x20C0910", VA = "0x1820C1F10")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> HDJEAIPAJMK(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x20C02A0", Offset = "0x20BECA0", VA = "0x1820C02A0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> BENJJBDGPPI(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x20C2560", Offset = "0x20C0F60", VA = "0x1820C2560")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KGNCCCACCFF(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x20C3F90", Offset = "0x20C2990", VA = "0x1820C3F90")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> NEFFMIDKCAA(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x20C01A0", Offset = "0x20BEBA0", VA = "0x1820C01A0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> BEGPOMOBNCI(this AMGPEKAANLN PECHDAFMNOO, int CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x20BFE10", Offset = "0x20BE810", VA = "0x1820BFE10")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> AFHJLIFNMAP(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CLMKDBDPNNH)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x20C2170", Offset = "0x20C0B70", VA = "0x1820C2170")]
	public static void HGALAIMMAMM(this AMGPEKAANLN PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x20C0500", Offset = "0x20BEF00", VA = "0x1820C0500")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CHKLEONJBIK(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, float DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x20C1670", Offset = "0x20C0070", VA = "0x1820C1670")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> FJCLOHDONJN(this AMGPEKAANLN PECHDAFMNOO, float ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x20C0EE0", Offset = "0x20BF8E0", VA = "0x1820C0EE0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> EFJLCOHANFG(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x20C0410", Offset = "0x20BEE10", VA = "0x1820C0410")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> CDBAEMIOHMA(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x20C1C40", Offset = "0x20C0640", VA = "0x1820C1C40")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> GOCJOJIPLII(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x20C2CE0", Offset = "0x20C16E0", VA = "0x1820C2CE0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KOAEIMCFHKH(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x20C2770", Offset = "0x20C1170", VA = "0x1820C2770")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> KJEIDCHNCAJ(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> AOOFEHJLLGO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> KGEEHFJNDMH)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x20C38F0", Offset = "0x20C22F0", VA = "0x1820C38F0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> MDPPCJDCEDN(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, int DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x20C4980", Offset = "0x20C3380", VA = "0x1820C4980")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONFKAIAALIB(this AMGPEKAANLN PECHDAFMNOO, int ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x20C36C0", Offset = "0x20C20C0", VA = "0x1820C36C0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> LMEKJJMHNHI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ONHAKDJFOLN, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DKEADGGNEJJ)
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E4B0", Offset = "0x2E4CEB0", VA = "0x182E4E4B0")]
	public static void AMAOLAGJHJG<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<GJEGPHJEIMP> PGLIMJEPEPF, [In] ReadOnlySpan<MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>> MCLCHMJGBGM, [In] ReadOnlySpan<int?> HFKBMHHIFAD, [In] Span<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> MGKKOJPEPPK, [In] Span<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> HEPOKOEPHOK, [In] ReadOnlySpan<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>?> PHKDJPEAFDO) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E4FB00", Offset = "0x2E4E500", VA = "0x182E4FB00")]
	public static void OJJBOIFIDBI<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<MDEOHEADBEE> MIDOKEPAEFF, [In] ReadOnlySpan<MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>> JHGJGIAJGJF, [In] ReadOnlySpan<int?> HFKBMHHIFAD, [In] Span<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> MGKKOJPEPPK, [In] Span<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>> HEPOKOEPHOK, [In] ReadOnlySpan<MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>?> PHKDJPEAFDO) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E50AF0", Offset = "0x2E4F4F0", VA = "0x182E50AF0")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> PCDEOJDBKLP<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> NNPGCOAKKJO, [Optional] MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F490", Offset = "0x2E4DE90", VA = "0x182E4F490")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> LJINPOHHMGD<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> HIGFNBDNOKA, [Optional] MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E50CD0", Offset = "0x2E4F6D0", VA = "0x182E50CD0")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> PGMEFHOHCEG<TDeps, TStateSys>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK) where TDeps : notnull, NNHKMOPDPHA<TStateSys> where TStateSys : notnull
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F8F0", Offset = "0x2E4E2F0", VA = "0x182E4F8F0")]
	public static MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC> LJNFGAFMKNF<TDeps, TStateSys>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK) where TDeps : notnull, NNHKMOPDPHA<TStateSys> where TStateSys : notnull
	{
		return default(MLGFJIHMDCD<OCEJPHJMNGN.DAELAILAPNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x20C0600", Offset = "0x20BF000", VA = "0x1820C0600")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> CIIKBDOKKKK(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> IKNJDPKHBEM, IntPtr EKBCGEEANGJ, IntPtr MJHPLGDAEEI)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x20C1040", Offset = "0x20BFA40", VA = "0x1820C1040")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> EIBBANMNGCI(this AMGPEKAANLN PECHDAFMNOO, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> KJBHAHLMEED, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OFMIEDAOKDO, IntPtr JGLJPFMPPKL, IntPtr IILBEGGDMEP, IntPtr HKGLAFPCMKL, bool JOODBIDMEHB)
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2E500A0", Offset = "0x2E4EAA0", VA = "0x182E500A0")]
	public static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OJKNFOPCOPL<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<GJEGPHJEIMP> KOEFJPNEKGM, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> KJBHAHLMEED, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OFMIEDAOKDO, int? CENMADPNBIC, [Optional] IntPtr JBIDBIHHGHA) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E502B0", Offset = "0x2E4ECB0", VA = "0x182E502B0")]
	private static MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OJKNFOPCOPL<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<GJEGPHJEIMP> KOEFJPNEKGM, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> KJBHAHLMEED, MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP> OFMIEDAOKDO, int? CENMADPNBIC) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
		return default(MLGFJIHMDCD<DEKKFMGMFJG.OGOCGBNGHBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EB50", Offset = "0x2E4D550", VA = "0x182E4EB50")]
	public static MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> DMDAKGOAFIA<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC> ACEPIENHFHI, MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>? GPOGEIBDPAB) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
		return default(MLGFJIHMDCD<AMKJJAEMFJA.ICFGJCAEHEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4EF00", Offset = "0x2E4D900", VA = "0x182E4EF00")]
	public static void HKHIOEINFIB<TDeps, TState>(this AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TState ACEEMNFHFMB, int BDDHIHKLGDA) where TDeps : notnull, NNHKMOPDPHA<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct DPODLGBADEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> HBAKBOOMDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> NHBEMBAKPMM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
	public DPODLGBADEH(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> NJKKNCALJOP, MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> HHLPPHCPHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x20BC1C0", Offset = "0x20BABC0", VA = "0x1820BC1C0")]
	public static DPODLGBADEH MMKGNMBHOIH(MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>> NJKKNCALJOP)
	{
		return default(DPODLGBADEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct AMKJJAEMFJA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class FDNFMNHFIEH : LELOKBKNGKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct OOEMAEKGBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> LMCDCNEFFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int MOMFAOPBBMD;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		public OOEMAEKGBPB(MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> HOCIOAMJPOO, int EBDDHAPIAHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class APODPNPPNJK : LELOKBKNGKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct PGDOHJNEAMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int MOMFAOPBBMD;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public PGDOHJNEAMD(int EBDDHAPIAHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class KHBBOGLMHFK : LELOKBKNGKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct EMJMDDPNCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> LMCDCNEFFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int MOMFAOPBBMD;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
		public EMJMDDPNCDN(MLGFJIHMDCD<HJPKANLABBD.GOBEGAFNAEP> HOCIOAMJPOO, int EBDDHAPIAHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum OGFGPLICGBI
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
	public sealed class ICFGJCAEHEC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class LELOKBKNGKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct EDPBJGPAKJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? DEMIBAPEMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public DPODLGBADEH GPGDCLJMHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OGFGPLICGBI KICIBBOIGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MLGFJIHMDCD<LELOKBKNGKF> NKDHAOPNKKC;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x20BC1D0", Offset = "0x20BABD0", VA = "0x1820BC1D0")]
		public EDPBJGPAKJF(int? BALEBIMMAIK, [In] DPODLGBADEH HLHGGHFEKBI, OGFGPLICGBI DMOKMPNIHEM, MLGFJIHMDCD<LELOKBKNGKF> OIJIDHLBHEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class IPCKDACCKPO : LELOKBKNGKF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HNMPFIMFPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int MOMFAOPBBMD;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60")]
		public HNMPFIMFPAO(int EBDDHAPIAHH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal LMODCKDKOOP<ICFGJCAEHEC, EDPBJGPAKJF> FMCGBCEAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal LMODCKDKOOP<FDNFMNHFIEH, OOEMAEKGBPB> BBOFMPABCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal LMODCKDKOOP<KHBBOGLMHFK, EMJMDDPNCDN> AKOAGELKMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal LMODCKDKOOP<IPCKDACCKPO, HNMPFIMFPAO> KLDHOLACJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal LMODCKDKOOP<APODPNPPNJK, PGDOHJNEAMD> EPFMKONNBAJ;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x20BB210", Offset = "0x20B9C10", VA = "0x1820BB210")]
	private AMKJJAEMFJA([In] LMODCKDKOOP<ICFGJCAEHEC, EDPBJGPAKJF> DCFGOJMPGGH, [In] LMODCKDKOOP<FDNFMNHFIEH, OOEMAEKGBPB> EGAOHMBMDBJ, [In] LMODCKDKOOP<KHBBOGLMHFK, EMJMDDPNCDN> EBJBHNOFKHK, [In] LMODCKDKOOP<IPCKDACCKPO, HNMPFIMFPAO> MEHOLMCLJMO, [In] LMODCKDKOOP<APODPNPPNJK, PGDOHJNEAMD> BMIEMBJFBBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x20BB020", Offset = "0x20B9A20", VA = "0x1820BB020")]
	public static AMKJJAEMFJA MMKGNMBHOIH()
	{
		return default(AMKJJAEMFJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PBEHCLAHNAA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x20BFAC0", Offset = "0x20BE4C0", VA = "0x1820BFAC0")]
	public static void EPGEGEJNIJO(this AMKJJAEMFJA PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DCKMJDMPAFL
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x20BB8E0", Offset = "0x20BA2E0", VA = "0x1820BB8E0")]
	public static void IIGKFMPFNHH(AMGPEKAANLN PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DMHIKALDJFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, ALPMBOACDMF> NDHDLIODEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int JJMHFBLEJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int PCICNHDDADB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x20BC090", Offset = "0x20BAA90", VA = "0x1820BC090")]
	private DMHIKALDJFB([In] IJMILKHKGPD<HJPKANLABBD.BFHCGGFBNCB, ALPMBOACDMF> CHOFBDADDLB, int AGFCBELKMBK, int IPAHOAMAHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x20BC020", Offset = "0x20BAA20", VA = "0x1820BC020")]
	public static DMHIKALDJFB MMKGNMBHOIH()
	{
		return default(DMHIKALDJFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x20BBE30", Offset = "0x20BA830", VA = "0x1820BBE30")]
	public void EPGEGEJNIJO([In] AMGPEKAANLN GDMNEIEFKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2B04040", Offset = "0x2B02A40", VA = "0x182B04040")]
	public static void IIGKFMPFNHH<TDeps, TStateSys>(AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK, MLGFJIHMDCD<BLDJADOAIME> OJMCAIBKDOI) where TDeps : notnull, NNHKMOPDPHA<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PPIPIMAGBMP
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x20C5020", Offset = "0x20C3A20", VA = "0x1820C5020")]
	public static void IIGKFMPFNHH(AMGPEKAANLN PECHDAFMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct AFEOIEMKLHB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface MCMIKPOBCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JJAHJBACPKJ(CBGFCAOFHCN<byte> MPCPEPNKNJO, int HFHNMDHKOLF);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct DAHEDGPNEDA : MCMIKPOBCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x20BB860", Offset = "0x20BA260", VA = "0x1820BB860", Slot = "4")]
		public void JJAHJBACPKJ(CBGFCAOFHCN<byte> MPCPEPNKNJO, int HFHNMDHKOLF)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct OIHNIHFMNME : MCMIKPOBCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x20BFA10", Offset = "0x20BE410", VA = "0x1820BFA10", Slot = "4")]
		public void JJAHJBACPKJ(CBGFCAOFHCN<byte> MPCPEPNKNJO, int HFHNMDHKOLF)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct FKGEDEEPPLB : MCMIKPOBCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x20BC490", Offset = "0x20BAE90", VA = "0x1820BC490", Slot = "4")]
		public void JJAHJBACPKJ(CBGFCAOFHCN<byte> MPCPEPNKNJO, int HFHNMDHKOLF)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct DJHBGKGFCAD : MCMIKPOBCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x20BBCD0", Offset = "0x20BA6D0", VA = "0x1820BBCD0", Slot = "4")]
		public void JJAHJBACPKJ(CBGFCAOFHCN<byte> MPCPEPNKNJO, int HFHNMDHKOLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class OPBJJPJPFCL<TCallProcessorDeps> where TCallProcessorDeps : struct, MCMIKPOBCDE
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps OIIMCPAPNGD;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2DDE3C0", Offset = "0x2DDCDC0", VA = "0x182DDE3C0")]
		public static int IIGKFMPFNHH<TDeps, TStateSys>(TDeps JPDKLLDNBGD, TStateSys ACEEMNFHFMB, AMGPEKAANLN GDMNEIEFKPA, [In] CBGFCAOFHCN<byte> CCHEJOKNLMP, int GFAGIEEMGHL) where TDeps : NNHKMOPDPHA<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private CBGFCAOFHCN<OLMIGEAENHI> PBHJOLHAFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>> NDKIADNNCHM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x20BA0C0", Offset = "0x20B8AC0", VA = "0x1820BA0C0")]
	private AFEOIEMKLHB([In] CBGFCAOFHCN<OLMIGEAENHI> IIFPNHMGOJG, Dictionary<MLGFJIHMDCD<IEEJBCOLPEF<JPOKFMIFKLO>>, MLGFJIHMDCD<HJPKANLABBD.BFHCGGFBNCB>> KKKLLHOFEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x20BA000", Offset = "0x20B8A00", VA = "0x1820BA000")]
	public static AFEOIEMKLHB MMKGNMBHOIH()
	{
		return default(AFEOIEMKLHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x20B9FC0", Offset = "0x20B89C0", VA = "0x1820B9FC0")]
	public void EPGEGEJNIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3361060", Offset = "0x335FA60", VA = "0x183361060")]
	public static void IIGKFMPFNHH<TDeps, TStateSys>(AMGPEKAANLN PECHDAFMNOO, TDeps JPDKLLDNBGD, TStateSys MGPPMKLIDEK) where TDeps : NNHKMOPDPHA<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HIICMKDAFAI<TDeps, TIndex, TValues> where TDeps : struct, PKKMKLFEGEC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5980", Offset = "0x3EE4380", VA = "0x183EE5980")]
	public static void IIGKFMPFNHH([In] CBGFCAOFHCN<OLMIGEAENHI> IIFPNHMGOJG, int PMOJILAOLPF, TValues ACOKCANBLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface PKKMKLFEGEC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBGFCAOFHCN<TIndex> GOIGOKENPDD(int PMOJILAOLPF, [In] TValues ACOKCANBLGD);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(TIndex EBDDHAPIAHH, [In] TValues ACOKCANBLGD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDBDLAODONO(TIndex EBDDHAPIAHH, TValues ACOKCANBLGD, MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface CFAKADPGIPM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex IKPNKIJLCMD(int EBDDHAPIAHH);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LAFAIBEIFLG(TIndex EBDDHAPIAHH, [In] TValues ACOKCANBLGD);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLGFJIHMDCD<IEEJBCOLPEF<JCILPIOHADJ>> OLOLJHIKKKM(TIndex EBDDHAPIAHH, [In] TValues ACOKCANBLGD);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FPLLKCDPNHG<TDeps, TIndex, TValues> where TDeps : struct, CFAKADPGIPM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3D74DA0", Offset = "0x3D737A0", VA = "0x183D74DA0")]
	public static CBGFCAOFHCN<TIndex> IIGKFMPFNHH(int PMOJILAOLPF, [In] TValues ACOKCANBLGD)
	{
		return default(CBGFCAOFHCN<TIndex>);
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
