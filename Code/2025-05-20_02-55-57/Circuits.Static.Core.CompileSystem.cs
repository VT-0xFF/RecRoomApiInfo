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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D9CB0", Offset = "0x27D8EB0", VA = "0x1827D9CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct LOJBPOLIFFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> ELBGKFCJMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int EKHHHLINNHK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
	public LOJBPOLIFFF(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> OLCINMKNKOH, int OEBFFKLMAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ADFBFFJOPCH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GFGABBNGDFF : OAMBPGJBKFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HHMDODGIBPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly CAAPNMCCHDL<byte> OILJIPOEBDI;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2781BC0", Offset = "0x2780DC0", VA = "0x182781BC0")]
		public HHMDODGIBPL(CAAPNMCCHDL<byte> FONJAIMABAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27D3130", Offset = "0x27D2330", VA = "0x1827D3130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GFCPCOINICD : OAMBPGJBKFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct MEEHHCNKKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> EPMGNBHHFJF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public MEEHHCNKKCC(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> FDKGHHJILLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LDEIOKJBFMF
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
	public sealed class OLLJCPKAPBP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class OAMBPGJBKFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct EOLANHKCNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly LDEIOKJBFMF GFBJKHNMBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly JFIBBLJIDCN<OAMBPGJBKFG> OIFCPPOCINF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		public EOLANHKCNHN(LDEIOKJBFMF HEGJGCGMEML, JFIBBLJIDCN<OAMBPGJBKFG> JEIFGIOCPEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class KEKLGOEDLDH : OAMBPGJBKFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct BMDNELKJEFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> PKNKKHKNEJD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public BMDNELKJEFC(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class DLDDONHGJGI : OAMBPGJBKFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JEHBGJHGBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HOMKGHPABMN EDHNDKAEOKB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public JEHBGJHGBHG(HOMKGHPABMN AFACPAFBCCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x27D8630", Offset = "0x27D7830", VA = "0x1827D8630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal ADGECIKNHNH<OLLJCPKAPBP, EOLANHKCNHN> JFOAFMNFIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal ADGECIKNHNH<GFGABBNGDFF, HHMDODGIBPL> KOEEGBOIHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ADGECIKNHNH<GFCPCOINICD, MEEHHCNKKCC> MKJDIPGILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal ADGECIKNHNH<KEKLGOEDLDH, BMDNELKJEFC> JIMDGPOEPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ADGECIKNHNH<DLDDONHGJGI, JEHBGJHGBHG> NEICDGNNNLJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27CF350", Offset = "0x27CE550", VA = "0x1827CF350")]
	private ADFBFFJOPCH([In] ADGECIKNHNH<OLLJCPKAPBP, EOLANHKCNHN> PMKGOMFOLBD, [In] ADGECIKNHNH<GFGABBNGDFF, HHMDODGIBPL> PAHLHDJKFFM, [In] ADGECIKNHNH<GFCPCOINICD, MEEHHCNKKCC> FLDMOPKEMLF, [In] ADGECIKNHNH<KEKLGOEDLDH, BMDNELKJEFC> JGPAFDLJKEB, [In] ADGECIKNHNH<DLDDONHGJGI, JEHBGJHGBHG> FLNBKJKPEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27CF210", Offset = "0x27CE410", VA = "0x1827CF210")]
	public static ADFBFFJOPCH OIKMHICCLEP()
	{
		return default(ADFBFFJOPCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MJEENNBCNIC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27D8D90", Offset = "0x27D7F90", VA = "0x1827D8D90")]
	public static void NHLEMPKJEGJ(this ADFBFFJOPCH CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum LCHEGNGAEJF
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
public struct EMCDHGIHDNB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class OHLPOPIFNHD : HBDFICMIJDF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct LHAOFHJDLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> JMJDIPHOJFP;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public LHAOFHJDLDK(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GNLLAMANIAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum MFOGCHIMIAK
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
	public sealed class AACAOPCODIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class HBDFICMIJDF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct DKHCAELPLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly MFOGCHIMIAK GFBJKHNMBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly JFIBBLJIDCN<HBDFICMIJDF> OIFCPPOCINF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		public DKHCAELPLNC(MFOGCHIMIAK HEGJGCGMEML, JFIBBLJIDCN<HBDFICMIJDF> JEIFGIOCPEB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ADGECIKNHNH<AACAOPCODIF, DKHCAELPLNC> JFOAFMNFIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ADGECIKNHNH<OHLPOPIFNHD, LHAOFHJDLDK> DKPBGJPEECE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27CF460", Offset = "0x27CE660", VA = "0x1827CF460")]
	private EMCDHGIHDNB([In] ADGECIKNHNH<AACAOPCODIF, DKHCAELPLNC> PMKGOMFOLBD, [In] ADGECIKNHNH<OHLPOPIFNHD, LHAOFHJDLDK> MIEHPILMODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27D2C50", Offset = "0x27D1E50", VA = "0x1827D2C50")]
	public static EMCDHGIHDNB OIKMHICCLEP()
	{
		return default(EMCDHGIHDNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JHCDEHFONLC
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27D8650", Offset = "0x27D7850", VA = "0x1827D8650")]
	public static void NHLEMPKJEGJ(this EMCDHGIHDNB CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BOJKCCNAKDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public PAKIJLEMGBA<int> DPGADAJOPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public PAKIJLEMGBA<int> CFFPDNDBALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int KKADHIHFLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int EJADCHONCLD;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27CF7A0", Offset = "0x27CE9A0", VA = "0x1827CF7A0")]
	private BOJKCCNAKDK([In] PAKIJLEMGBA<int> ELGHHHHIENJ, [In] PAKIJLEMGBA<int> CFHMKEPJDMP, int CJGGHNFBEMI, int GLKFHADLOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27CF700", Offset = "0x27CE900", VA = "0x1827CF700")]
	public static BOJKCCNAKDK OIKMHICCLEP()
	{
		return default(BOJKCCNAKDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MEFHLFAIHNM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27D8C50", Offset = "0x27D7E50", VA = "0x1827D8C50")]
	public static void NHLEMPKJEGJ(this BOJKCCNAKDK CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CKFEEKILNBN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum KNJLDFCFMKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class MBLFDDEFCLP : DGKEJENLNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct BGCPFHOBCGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly JFIBBLJIDCN<ICHOPGFGFBG> HCJKBGOHGOD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public BGCPFHOBCGH(JFIBBLJIDCN<ICHOPGFGFBG> JKOIKPOPKEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class LCNJBKDILPN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class DGKEJENLNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct PLECODHNMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly KNJLDFCFMKB GFBJKHNMBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly JFIBBLJIDCN<DGKEJENLNMN> OIFCPPOCINF;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		private PLECODHNMNB(KNJLDFCFMKB HEGJGCGMEML, JFIBBLJIDCN<DGKEJENLNMN> JEIFGIOCPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27DAE60", Offset = "0x27DA060", VA = "0x1827DAE60")]
		public static PLECODHNMNB OIKMHICCLEP(KNJLDFCFMKB HEGJGCGMEML, JFIBBLJIDCN<DGKEJENLNMN> JEIFGIOCPEB)
		{
			return default(PLECODHNMNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class MCNDOGMMOLL : DGKEJENLNMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct DDPMHPDBMCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly JFIBBLJIDCN<ICHOPGFGFBG> HCJKBGOHGOD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public DDPMHPDBMCI(JFIBBLJIDCN<ICHOPGFGFBG> JKOIKPOPKEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class ICHOPGFGFBG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct AIKLMKOBCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PAKIJLEMGBA<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> KCAGHKKEJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PAKIJLEMGBA<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> PLECHGOABIG;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27CF460", Offset = "0x27CE660", VA = "0x1827CF460")]
		private AIKLMKOBCIB([In] PAKIJLEMGBA<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> OLHPCEIIIOL, [In] PAKIJLEMGBA<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> FMKBABKFMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27CF3E0", Offset = "0x27CE5E0", VA = "0x1827CF3E0")]
		public static AIKLMKOBCIB OIKMHICCLEP()
		{
			return default(AIKLMKOBCIB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal ADGECIKNHNH<LCNJBKDILPN, PLECODHNMNB> JFOAFMNFIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal ADGECIKNHNH<MCNDOGMMOLL, DDPMHPDBMCI> EKPCGCFCDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ADGECIKNHNH<MBLFDDEFCLP, BGCPFHOBCGH> COFGIIHNLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal PAKIJLEMGBA<(JFIBBLJIDCN<LCNJBKDILPN> CallId, JFIBBLJIDCN<ICHOPGFGFBG> IOId)> OFBOMLDABCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal ADGECIKNHNH<ICHOPGFGFBG, AIKLMKOBCIB> EIKDLNPHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal KGAPBMDBEOB<ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> JIFNLHKJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal KGAPBMDBEOB<ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> PFJBFPLKAPN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27CFCF0", Offset = "0x27CEEF0", VA = "0x1827CFCF0")]
	private CKFEEKILNBN([In] ADGECIKNHNH<LCNJBKDILPN, PLECODHNMNB> PMKGOMFOLBD, [In] ADGECIKNHNH<MCNDOGMMOLL, DDPMHPDBMCI> PFJLIHMFEFH, [In] ADGECIKNHNH<MBLFDDEFCLP, BGCPFHOBCGH> MOGEFBGMDNK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<LCNJBKDILPN> CallId, JFIBBLJIDCN<ICHOPGFGFBG> IOId)> JCJJLBBDIKO, [In] ADGECIKNHNH<ICHOPGFGFBG, AIKLMKOBCIB> HCMPPNBNDCB, [In] KGAPBMDBEOB<ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> BAJAFLDDKJD, [In] KGAPBMDBEOB<ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> IHKOGEHHLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27CFB50", Offset = "0x27CED50", VA = "0x1827CFB50")]
	public static CKFEEKILNBN OIKMHICCLEP()
	{
		return default(CKFEEKILNBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BEAGEFEBOGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x27CF6B0", Offset = "0x27CE8B0", VA = "0x1827CF6B0")]
	private static void NHLEMPKJEGJ(this CKFEEKILNBN.AIKLMKOBCIB CEENCLMGJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27CF4A0", Offset = "0x27CE6A0", VA = "0x1827CF4A0")]
	public static void NHLEMPKJEGJ(this CKFEEKILNBN CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NMDEMDJAPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public PAKIJLEMGBA<byte> AGEKEDFPDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CKFEEKILNBN HGONNNIOHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal OKJHNFLHPLN IOBNJPPPEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> CDNDDLDHIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal ADFBFFJOPCH BIEJAABPBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal EMCDHGIHDNB BDFIHKCHJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal KGAPBMDBEOB<KLMHALNMEAA, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>?> PIDFOGLOPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> CDGDMPNEOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> HEPMJEHCKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> LPLNPKIKKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> ENONMFDFHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal CBJNJNNMGBC MAGEPHONFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal CLNAGLMHKHI KIFLOBFBOEB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27D9950", Offset = "0x27D8B50", VA = "0x1827D9950")]
	private NMDEMDJAPPL([In] PAKIJLEMGBA<byte> NEMFMDMIFHB, [In] CKFEEKILNBN GEFBLLDMAIG, [In] OKJHNFLHPLN PFNFGJEOLNM, [In] ADFBFFJOPCH DMNDDICOKHN, [In] EMCDHGIHDNB EFCNIHCEILI, [In] KGAPBMDBEOB<KLMHALNMEAA, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>?> AFOAJMKDGLD, [In] PAKIJLEMGBA<JFIBBLJIDCN<KLMHALNMEAA>> JOFEIEBAFHP, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> MMEILGJLHLP, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> OHNGNJOEMNJ, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> MCGBADKJPGE, [In] CBJNJNNMGBC OOBDLADLCAM, [In] CLNAGLMHKHI OLEADPEEDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27D8FA0", Offset = "0x27D81A0", VA = "0x1827D8FA0")]
	public static NMDEMDJAPPL OIKMHICCLEP()
	{
		return default(NMDEMDJAPPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DKFALAEBCCE
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct GBILJDNIECB : PBGHICIMCNK<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>, KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x27D2EB0", Offset = "0x27D20B0", VA = "0x1827D2EB0")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x27D2F60", Offset = "0x27D2160", VA = "0x1827D2F60", Slot = "4")]
		public JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> AGCAMPINGFP(int NIBICIJAIGM)
		{
			return default(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		public bool JGMKNHFGIMA(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "5")]
		private bool PBLKLDLGGPA(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27D2F90", Offset = "0x27D2190", VA = "0x1827D2F90", Slot = "6")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> JPFEDCILGNF(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct DNBIKDBFJJE : BBINEAECOIN<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>, KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27D2850", Offset = "0x27D1A50", VA = "0x1827D2850")]
		public PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>> OANHDKLDGLN(int FMFDOGBLNBK, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27D2790", Offset = "0x27D1990", VA = "0x1827D2790")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x27D28C0", Offset = "0x27D1AC0", VA = "0x1827D28C0", Slot = "6")]
		public void MFDCOKMLAKL(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x27D2850", Offset = "0x27D1A50", VA = "0x1827D2850", Slot = "4")]
		private PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>> BFBDEMNIGJB(int FMFDOGBLNBK, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x27D2840", Offset = "0x27D1A40", VA = "0x1827D2840", Slot = "5")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AKFDOEKKHHK(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct MFBBPMOAKHF : PBGHICIMCNK<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>, KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27D8CA0", Offset = "0x27D7EA0", VA = "0x1827D8CA0")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27D8D50", Offset = "0x27D7F50", VA = "0x1827D8D50", Slot = "4")]
		public JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> AGCAMPINGFP(int NIBICIJAIGM)
		{
			return default(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		public bool JGMKNHFGIMA(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "5")]
		private bool BKADDENFBMF(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x27D8D80", Offset = "0x27D7F80", VA = "0x1827D8D80", Slot = "6")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> KINODFDFKHH(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct ODMGEIHLDEB : BBINEAECOIN<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>, KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x27D9DF0", Offset = "0x27D8FF0", VA = "0x1827D9DF0")]
		public PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>> OANHDKLDGLN(int FMFDOGBLNBK, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x27D9D40", Offset = "0x27D8F40", VA = "0x1827D9D40")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27D9E60", Offset = "0x27D9060", VA = "0x1827D9E60", Slot = "6")]
		public void MFDCOKMLAKL(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27D9DF0", Offset = "0x27D8FF0", VA = "0x1827D9DF0", Slot = "4")]
		private PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>> EFMPKPHPJEK(int FMFDOGBLNBK, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x27D9D30", Offset = "0x27D8F30", VA = "0x1827D9D30", Slot = "5")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AEBALAKOHLG(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> NIBICIJAIGM, [In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GKKCJLMAAOG : PBGHICIMCNK<JFIBBLJIDCN<PFJDLPPNNBM>, KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x27D2FA0", Offset = "0x27D21A0", VA = "0x1827D2FA0")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x27D3070", Offset = "0x27D2270", VA = "0x1827D3070", Slot = "4")]
		public JFIBBLJIDCN<PFJDLPPNNBM> AGCAMPINGFP(int NIBICIJAIGM)
		{
			return default(JFIBBLJIDCN<PFJDLPPNNBM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x27D30A0", Offset = "0x27D22A0", VA = "0x1827D30A0")]
		public bool JGMKNHFGIMA(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x27D30A0", Offset = "0x27D22A0", VA = "0x1827D30A0", Slot = "5")]
		private bool GGPINPENCBJ(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x27D3120", Offset = "0x27D2320", VA = "0x1827D3120", Slot = "6")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> KABHHHDHKOP(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct KNGPHDEGPFL : BBINEAECOIN<JFIBBLJIDCN<PFJDLPPNNBM>, KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x27D8A50", Offset = "0x27D7C50", VA = "0x1827D8A50")]
		public PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> OANHDKLDGLN(int FMFDOGBLNBK, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x27D8980", Offset = "0x27D7B80", VA = "0x1827D8980")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x27D8AC0", Offset = "0x27D7CC0", VA = "0x1827D8AC0", Slot = "6")]
		public void MFDCOKMLAKL(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x27D8A50", Offset = "0x27D7C50", VA = "0x1827D8A50", Slot = "4")]
		private PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>> MECIDLHJOFB(int FMFDOGBLNBK, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<JFIBBLJIDCN<PFJDLPPNNBM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x27D8BA0", Offset = "0x27D7DA0", VA = "0x1827D8BA0", Slot = "5")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> PBIBJGPLIBJ(JFIBBLJIDCN<PFJDLPPNNBM> NIBICIJAIGM, [In] KGAPBMDBEOB<PFJDLPPNNBM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>?> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct KDDCOLEEIMM : PBGHICIMCNK<int, PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x27D88D0", Offset = "0x27D7AD0", VA = "0x1827D88D0")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA70030", Offset = "0xA6F230", VA = "0x180A70030", Slot = "4")]
		public int AGCAMPINGFP(int NIBICIJAIGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		public bool JGMKNHFGIMA(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "5")]
		private bool JDJHIIIIOJB(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x27D8970", Offset = "0x27D7B70", VA = "0x1827D8970", Slot = "6")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> NALEHCLPIAN(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct JMIPJALIADF : BBINEAECOIN<int, PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x27D8760", Offset = "0x27D7960", VA = "0x1827D8760")]
		public PAKIJLEMGBA<int> OANHDKLDGLN(int FMFDOGBLNBK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x27D86C0", Offset = "0x27D78C0", VA = "0x1827D86C0")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x27D87D0", Offset = "0x27D79D0", VA = "0x1827D87D0", Slot = "6")]
		public void MFDCOKMLAKL(int NIBICIJAIGM, PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x27D8760", Offset = "0x27D7960", VA = "0x1827D8760", Slot = "4")]
		private PAKIJLEMGBA<int> JINFAJJGMLM(int FMFDOGBLNBK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x27D86B0", Offset = "0x27D78B0", VA = "0x1827D86B0", Slot = "5")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> ABMKGBFMKJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> VariableId, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<KMIODFPCFME>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct IHEEAEHBBHI : PBGHICIMCNK<int, PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x27D8580", Offset = "0x27D7780", VA = "0x1827D8580")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA70030", Offset = "0xA6F230", VA = "0x180A70030", Slot = "4")]
		public int AGCAMPINGFP(int NIBICIJAIGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		public bool JGMKNHFGIMA(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "5")]
		private bool EFJCCKNFPHM(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x27D8620", Offset = "0x27D7820", VA = "0x1827D8620", Slot = "6")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> GMDKMNMCJGI(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct DHMHNNFJEFF : BBINEAECOIN<int, PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27CFFA0", Offset = "0x27CF1A0", VA = "0x1827CFFA0")]
		public PAKIJLEMGBA<int> OANHDKLDGLN(int FMFDOGBLNBK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x27CFF00", Offset = "0x27CF100", VA = "0x1827CFF00")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x27D0020", Offset = "0x27CF220", VA = "0x1827D0020", Slot = "6")]
		public void MFDCOKMLAKL(int NIBICIJAIGM, PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x27CFFA0", Offset = "0x27CF1A0", VA = "0x1827CFFA0", Slot = "4")]
		private PAKIJLEMGBA<int> GLPFOEOKBDC(int FMFDOGBLNBK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x27D0010", Offset = "0x27CF210", VA = "0x1827D0010", Slot = "5")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> LOLDKALOHNJ(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct OJGJEKIKMFM : PBGHICIMCNK<int, PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x27DAA30", Offset = "0x27D9C30", VA = "0x1827DAA30")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA70030", Offset = "0xA6F230", VA = "0x180A70030", Slot = "4")]
		public int AGCAMPINGFP(int NIBICIJAIGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0")]
		public bool JGMKNHFGIMA(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5F0", Offset = "0xA0A7F0", VA = "0x180A0B5F0", Slot = "5")]
		private bool EFJCCKNFPHM(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x27DAAD0", Offset = "0x27D9CD0", VA = "0x1827DAAD0", Slot = "6")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> GMDKMNMCJGI(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct EBEPEFEOCDK : BBINEAECOIN<int, PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x27D2A20", Offset = "0x27D1C20", VA = "0x1827D2A20")]
		public PAKIJLEMGBA<int> OANHDKLDGLN(int FMFDOGBLNBK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x27D2980", Offset = "0x27D1B80", VA = "0x1827D2980")]
		public JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x27D2AA0", Offset = "0x27D1CA0", VA = "0x1827D2AA0", Slot = "6")]
		public void MFDCOKMLAKL(int NIBICIJAIGM, PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x27D2A20", Offset = "0x27D1C20", VA = "0x1827D2A20", Slot = "4")]
		private PAKIJLEMGBA<int> GLPFOEOKBDC(int FMFDOGBLNBK, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(PAKIJLEMGBA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27D2A90", Offset = "0x27D1C90", VA = "0x1827D2A90", Slot = "5")]
		private JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> LOLDKALOHNJ(int NIBICIJAIGM, [In] PAKIJLEMGBA<(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> Target, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ByteCodeWriteLocation)> CPMBLPBIGIH)
		{
			return default(JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct DFDOFKBNHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> CMDPFMINKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool HGAALGEDACI;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1E7B550", Offset = "0x1E7A750", VA = "0x181E7B550")]
		public DFDOFKBNHBC(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN, bool IBKOGPOMOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x27CFEF0", Offset = "0x27CF0F0", VA = "0x1827CFEF0")]
		public void EFFIMEDBJAK([Out] JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN, [Out] bool IBKOGPOMOIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct PKKCMEELPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly JFIBBLJIDCN<PFJDLPPNNBM> EEFBKCNKEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> CMDPFMINKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool HGAALGEDACI;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x27DAE50", Offset = "0x27DA050", VA = "0x1827DAE50")]
		public PKKCMEELPMG(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN, bool IBKOGPOMOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x27DAE40", Offset = "0x27DA040", VA = "0x1827DAE40")]
		public void EFFIMEDBJAK([Out] JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN, [Out] bool IBKOGPOMOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x27DAE20", Offset = "0x27DA020", VA = "0x1827DAE20")]
		public void EFFIMEDBJAK([Out] JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN, [Out] JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD, [Out] bool IBKOGPOMOIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LJKFJECHPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly JFIBBLJIDCN<PFJDLPPNNBM> EEFBKCNKEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> CMDPFMINKDM;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		public LJKFJECHPOB(JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x27D8BB0", Offset = "0x27D7DB0", VA = "0x1827D8BB0")]
		public void EFFIMEDBJAK([Out] JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN, [Out] JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x27D1FB0", Offset = "0x27D11B0", VA = "0x1827D1FB0")]
	public static void NHLEMPKJEGJ(this NMDEMDJAPPL CEENCLMGJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27D2280", Offset = "0x27D1480", VA = "0x1827D2280")]
	public static void NOLEJGFKBFP(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> MKJJHFHGEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27D04D0", Offset = "0x27CF6D0", VA = "0x1827D04D0")]
	public static void BENEDLDAEIM(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> MKJJHFHGEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27D1E40", Offset = "0x27D1040", VA = "0x1827D1E40")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>? MBPBHDPODDK([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x27D2420", Offset = "0x27D1620", VA = "0x1827D2420")]
	public static JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> ODCFKPCNKPE([In] this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27D1940", Offset = "0x27D0B40", VA = "0x1827D1940")]
	private static void LJNMAIHHPIB(this NMDEMDJAPPL CEENCLMGJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x27D0800", Offset = "0x27CFA00", VA = "0x1827D0800")]
	private static JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>? DBKCPLJDMGP([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27D1390", Offset = "0x27D0590", VA = "0x1827D1390")]
	public static void JBPPBEBNGLP(this NMDEMDJAPPL CEENCLMGJAM, [In] PAKIJLEMGBA<LOJBPOLIFFF> GAAGDJICFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27D25A0", Offset = "0x27D17A0", VA = "0x1827D25A0")]
	public static ADFBFFJOPCH.LDEIOKJBFMF PDDNGGOELCB([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
	{
		return default(ADFBFFJOPCH.LDEIOKJBFMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x27D1AB0", Offset = "0x27D0CB0", VA = "0x1827D1AB0")]
	public static CAAPNMCCHDL<byte> LOEBODOEDHP([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
	{
		return default(CAAPNMCCHDL<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x27D1810", Offset = "0x27D0A10", VA = "0x1827D1810")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LACOJFGPEBM([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27D0A10", Offset = "0x27CFC10", VA = "0x1827D0A10")]
	public static HOMKGHPABMN DKGLPJJBJNM([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
	{
		return default(HOMKGHPABMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x366CC40", Offset = "0x366BE40", VA = "0x18366CC40")]
	private static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> OMNNJMMOEED<TMJoin>(this NMDEMDJAPPL CEENCLMGJAM, ADFBFFJOPCH.LDEIOKJBFMF HEGJGCGMEML, JFIBBLJIDCN<TMJoin> JEIFGIOCPEB) where TMJoin : ADFBFFJOPCH.OAMBPGJBKFG
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x27D0C70", Offset = "0x27CFE70", VA = "0x1827D0C70")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> FJMKIEAAOGF(this NMDEMDJAPPL CEENCLMGJAM, bool OLNDNEIBJOI)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x27D2620", Offset = "0x27D1820", VA = "0x1827D2620")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> PNOKNAJABBC(this NMDEMDJAPPL CEENCLMGJAM, CAAPNMCCHDL<byte> FONJAIMABAP)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27D2710", Offset = "0x27D1910", VA = "0x1827D2710")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> PPLGHNKNDCE(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> FDKGHHJILLD)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x27D1200", Offset = "0x27D0400", VA = "0x1827D1200")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> HIHDELEENHH(this NMDEMDJAPPL CEENCLMGJAM, int OHFNCGNAANO)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x27D0160", Offset = "0x27CF360", VA = "0x1827D0160")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> AGMEFILFAIC(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x366C4F0", Offset = "0x366B6F0", VA = "0x18366C4F0")]
	private static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> JNGLPAOPHEF<TMJoin>(this NMDEMDJAPPL CEENCLMGJAM, EMCDHGIHDNB.MFOGCHIMIAK HEGJGCGMEML, JFIBBLJIDCN<TMJoin> JEIFGIOCPEB) where TMJoin : EMCDHGIHDNB.HBDFICMIJDF
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x27D1900", Offset = "0x27D0B00", VA = "0x1827D1900")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> LCKFBPIKJPF(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x27D0CF0", Offset = "0x27CFEF0", VA = "0x1827D0CF0")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> FPIHEFFNHIL(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x27D23A0", Offset = "0x27D15A0", VA = "0x1827D23A0")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> OCDCEMAJPDF(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GNLLAMANIAA)
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x27D0110", Offset = "0x27CF310", VA = "0x1827D0110")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> ACIMLJPGJLC(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27D15B0", Offset = "0x27D07B0", VA = "0x1827D15B0")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> JMNIPBLJCIH(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27D0BF0", Offset = "0x27CFDF0", VA = "0x1827D0BF0")]
	public static CKFEEKILNBN.KNJLDFCFMKB FBDAPHMJOAA([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ODJJBLPFEED)
	{
		return default(CKFEEKILNBN.KNJLDFCFMKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27D1570", Offset = "0x27D0770", VA = "0x1827D1570")]
	public static MAIDBPOBJJB<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>, DIEDADNLJBK<CKFEEKILNBN.ICHOPGFGFBG>> JIPBAMHFPEP([In] this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>, DIEDADNLJBK<CKFEEKILNBN.ICHOPGFGFBG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x27D0EF0", Offset = "0x27D00F0", VA = "0x1827D0EF0")]
	public static JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> GGMBAECPOLF([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ODJJBLPFEED)
	{
		return default(JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x27D0690", Offset = "0x27CF890", VA = "0x1827D0690")]
	public static CKFEEKILNBN.AIKLMKOBCIB CJADPIOLJMA([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> JKOIKPOPKEP)
	{
		return default(CKFEEKILNBN.AIKLMKOBCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27D1280", Offset = "0x27D0480", VA = "0x1827D1280")]
	public static CKFEEKILNBN.AIKLMKOBCIB HJFFOOMJLIA(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> JKOIKPOPKEP)
	{
		return default(CKFEEKILNBN.AIKLMKOBCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x366B1F0", Offset = "0x366A3F0", VA = "0x18366B1F0")]
	private static JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> DHKMJNKPHMC<TMJoin>(this NMDEMDJAPPL CEENCLMGJAM, CKFEEKILNBN.KNJLDFCFMKB HEGJGCGMEML, JFIBBLJIDCN<TMJoin> JEIFGIOCPEB) where TMJoin : CKFEEKILNBN.DGKEJENLNMN
	{
		return default(JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x27D0D40", Offset = "0x27CFF40", VA = "0x1827D0D40")]
	public static (JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>) GDPAPJCJDDC(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default((JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27D1660", Offset = "0x27D0860", VA = "0x1827D1660")]
	public static (JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>) KIGEKIKPFFI(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default((JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27D2550", Offset = "0x27D1750", VA = "0x1827D2550")]
	public static JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ONAPFIJIBND(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27D2310", Offset = "0x27D1510", VA = "0x1827D2310")]
	public static void NPMDNGGHBDA(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG> JKOIKPOPKEP, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> HLDFLKFAKIN, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>> FNJGLBHDFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x366B6D0", Offset = "0x366A8D0", VA = "0x18366B6D0")]
	public static DFDOFKBNHBC EAKMALNHJGL<TDeps, TStateSys>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD) where TDeps : LICGCBGGHOC<TStateSys>
	{
		return default(DFDOFKBNHBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x366AE50", Offset = "0x366A050", VA = "0x18366AE50")]
	public static PKKCMEELPMG APAENIJHOEI<TDeps, TStateSys>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, int HIILHOHJDGC) where TDeps : LICGCBGGHOC<TStateSys>
	{
		return default(PKKCMEELPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x366B290", Offset = "0x366A490", VA = "0x18366B290")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>? DPMNEHNHHPM<TDeps, TStateSys>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, [In] ReadOnlySpan<int> PPHMIGFGCNE, [In] Span<LJKFJECHPOB> ABMOPENBJGE) where TDeps : LICGCBGGHOC<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x366C670", Offset = "0x366B870", VA = "0x18366C670")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> LKEFAMGOKIM<TDeps, TStateSys>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED) where TDeps : LICGCBGGHOC<TStateSys>
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x27D0B00", Offset = "0x27CFD00", VA = "0x1827D0B00")]
	public static OKJHNFLHPLN.DJHKPDBGHDK DPBOPMMPIMJ([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN)
	{
		return default(OKJHNFLHPLN.DJHKPDBGHDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x27D0710", Offset = "0x27CF910", VA = "0x1827D0710")]
	public static OKJHNFLHPLN.FOHJBIBMIDF CNNKKALPOGG([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN)
	{
		return default(OKJHNFLHPLN.FOHJBIBMIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x27D05A0", Offset = "0x27CF7A0", VA = "0x1827D05A0")]
	public static OKJHNFLHPLN.HGNFIMHIHOM BHEJOEPMPKA([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN)
	{
		return default(OKJHNFLHPLN.HGNFIMHIHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x27D0250", Offset = "0x27CF450", VA = "0x1827D0250")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> BCONNJBDODO(this NMDEMDJAPPL CEENCLMGJAM, int? KEJPCHFKIMO, string DGIAFBEDPNJ)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x27D03E0", Offset = "0x27CF5E0", VA = "0x1827D03E0")]
	public static OKJHNFLHPLN.GFMCMPDJACK BEFGBICAJPH([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN)
	{
		return default(OKJHNFLHPLN.GFMCMPDJACK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27D01E0", Offset = "0x27CF3E0", VA = "0x1827D01E0")]
	public static OKJHNFLHPLN.OBMAKHDCMAH AMPFEJBCNKP([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN)
	{
		return default(OKJHNFLHPLN.OBMAKHDCMAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x27D1500", Offset = "0x27D0700", VA = "0x1827D1500")]
	public static int? JFEIMNBAOIM([In] this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x366B0F0", Offset = "0x366A2F0", VA = "0x18366B0F0")]
	private static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> CPDBFGMGDGJ<TMJoin>(this NMDEMDJAPPL CEENCLMGJAM, int? KEJPCHFKIMO, OKJHNFLHPLN.OBMAKHDCMAH HEGJGCGMEML, JFIBBLJIDCN<TMJoin> JEIFGIOCPEB) where TMJoin : OKJHNFLHPLN.MJBNMDJLCEK
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27D1F00", Offset = "0x27D1100", VA = "0x1827D1F00")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKODPCMGFLB(this NMDEMDJAPPL CEENCLMGJAM, int? KEJPCHFKIMO, JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ODJJBLPFEED, int NIBICIJAIGM)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27D26B0", Offset = "0x27D18B0", VA = "0x1827D26B0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> POFDKDPJDEO(this NMDEMDJAPPL CEENCLMGJAM, int? KEJPCHFKIMO)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x27D08C0", Offset = "0x27CFAC0", VA = "0x1827D08C0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DFFABGCJGKC(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? JOCGBJKPMGE, int? KEJPCHFKIMO)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27D1300", Offset = "0x27D0500", VA = "0x1827D1300")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> IKPFFENCHDK(this NMDEMDJAPPL CEENCLMGJAM, int? KEJPCHFKIMO, int NIBICIJAIGM)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27D1600", Offset = "0x27D0800", VA = "0x1827D1600")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KDCGCMIJEEF(this NMDEMDJAPPL CEENCLMGJAM, int? KEJPCHFKIMO)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27D1BA0", Offset = "0x27D0DA0", VA = "0x1827D1BA0")]
	public static void LPNAFLAGCGE(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC, JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ODJJBLPFEED, int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27D10D0", Offset = "0x27D02D0", VA = "0x1827D10D0")]
	public static void GLJKIANBDOK(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC, int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x27D1D70", Offset = "0x27D0F70", VA = "0x1827D1D70")]
	public static void MAKGAKLMCFG(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27D1CE0", Offset = "0x27D0EE0", VA = "0x1827D1CE0")]
	public static void MABFKIKEEFH(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> PJNHLGGHCLG, JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> GGDFGOBGGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27D2480", Offset = "0x27D1680", VA = "0x1827D2480")]
	public static void ODPNKEPMMLF(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC, JFIBBLJIDCN<HAAFGKINDME<AACIIJFJGBP>> KCEDIMIOGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x366C5A0", Offset = "0x366B7A0", VA = "0x18366C5A0")]
	public static void JNIJJMJJKKN<M>(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AGIMOMIDNCC, JFIBBLJIDCN<HAAFGKINDME<KFJDANDCLAB<M>>> KCEDIMIOGEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LICGCBGGHOC<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFIBBLJIDCN<HGLMKHOJKPL> LLMIDMGLGFJ(TStateSys MMHHKGPDNAE);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFIBBLJIDCN<HGLMKHOJKPL> HALAEOBCALD(TStateSys MMHHKGPDNAE);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFIBBLJIDCN<HGLMKHOJKPL> KPKBPKFEFAD(TStateSys MMHHKGPDNAE);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JFIBBLJIDCN<HGLMKHOJKPL> ENGNIIMMFJJ(TStateSys MMHHKGPDNAE);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> FBDPLPCHMBO(TStateSys MMHHKGPDNAE, NMDEMDJAPPL BEIACMCLENJ, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> EGLEHAFLDIN(TStateSys MMHHKGPDNAE, NMDEMDJAPPL BEIACMCLENJ, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KOFNMMJIBIK(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JFIBBLJIDCN<KLMHALNMEAA> FLLAOOFHGNI(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD, int ACPHKIIOJAK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LCHEGNGAEJF KIHFIAEFLAI(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GOEHFDKBCGH(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CLOMOFGPLDG(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CAAPNMCCHDL<byte> PIHCEGDHCMO(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(CAAPNMCCHDL<byte>, JFIBBLJIDCN<HGLMKHOJKPL>) NPDBIBHJJPG(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PFJDLPPNNBM> HAPCGDBBODD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int OBBKGMOEAIN(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JFIBBLJIDCN<PFJDLPPNNBM> NNMFCHBIOPL(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<KLMHALNMEAA> DAPOJGPODED, int HIILHOHJDGC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JFIBBLJIDCN<PFJDLPPNNBM> PLPCOPHGDKH(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, JFIBBLJIDCN<PKEJDDGKOJK> CANDMCKMDKL, int HIILHOHJDGC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int NCDIEKDJEHK(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? ALJAEPDPHPJ(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int FMHOJBEAAAO(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? PMJGBCMOBLK(TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM, int NIBICIJAIGM);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IGOMHFHBING
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3846D90", Offset = "0x3845F90", VA = "0x183846D90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD?> BMFIBMHPIIF<T, TOpInput, TOpOutput>(this NMDEMDJAPPL CEENCLMGJAM, T OGNDHFPFEOJ, T ABBPAGLDFGP, int FJMGCENFNIP, IntPtr KGAIOPMOPGF)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x38494A0", Offset = "0x38486A0", VA = "0x1838494A0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD?> PMLMAAJBKGC<T, TOpInput, TOpOutput>(this NMDEMDJAPPL CEENCLMGJAM, T OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP, int FJMGCENFNIP, IntPtr KGAIOPMOPGF)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x38472A0", Offset = "0x38464A0", VA = "0x1838472A0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD?> EOOJABIIEOG<TOpInput, TOpOutput>(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP, int FJMGCENFNIP, IntPtr KGAIOPMOPGF)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x27D7770", Offset = "0x27D6970", VA = "0x1827D7770")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MNNCECBAFGC(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x27D7DD0", Offset = "0x27D6FD0", VA = "0x1827D7DD0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NMFAINEOGMM(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x27D45E0", Offset = "0x27D37E0", VA = "0x1827D45E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> EHAABIBCMHJ(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27D5B90", Offset = "0x27D4D90", VA = "0x1827D5B90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> IGKPEJMCCKE(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27D42C0", Offset = "0x27D34C0", VA = "0x1827D42C0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DJBKGHPFDCG(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27D63D0", Offset = "0x27D55D0", VA = "0x1827D63D0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JPBLNKABHEI(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x27D6C90", Offset = "0x27D5E90", VA = "0x1827D6C90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LBKFOFJIDEB(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27D4820", Offset = "0x27D3A20", VA = "0x1827D4820")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> FAOFJNJNFFG(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x27D7EF0", Offset = "0x27D70F0", VA = "0x1827D7EF0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NNKJBKBIKLL(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x27D7450", Offset = "0x27D6650", VA = "0x1827D7450")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LOLGNLAIOIO(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, int ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27D4060", Offset = "0x27D3260", VA = "0x1827D4060")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DHBIBKBEOBE(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27D39D0", Offset = "0x27D2BD0", VA = "0x1827D39D0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> CALABFPOGOC(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x27D6510", Offset = "0x27D5710", VA = "0x1827D6510")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KBPPEMPBKND(this NMDEMDJAPPL CEENCLMGJAM, float OGNDHFPFEOJ, float ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27D7300", Offset = "0x27D6500", VA = "0x1827D7300")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LJPEMCMBFIA(this NMDEMDJAPPL CEENCLMGJAM, float OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x27D32D0", Offset = "0x27D24D0", VA = "0x1827D32D0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AEGFFIPNILA(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27D7870", Offset = "0x27D6A70", VA = "0x1827D7870")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MOABBMCECFA(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, int ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27D6760", Offset = "0x27D5960", VA = "0x1827D6760")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KHIPDOJCJME(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27D4F80", Offset = "0x27D4180", VA = "0x1827D4F80")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GIHPGMOOLOJ(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27D5120", Offset = "0x27D4320", VA = "0x1827D5120")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GLGPAGINABN(this NMDEMDJAPPL CEENCLMGJAM, float OGNDHFPFEOJ, float ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27D7670", Offset = "0x27D6870", VA = "0x1827D7670")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKDJMFPHDOL(this NMDEMDJAPPL CEENCLMGJAM, float OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x27D43E0", Offset = "0x27D35E0", VA = "0x1827D43E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DJCPFLBAMIA(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27D3B90", Offset = "0x27D2D90", VA = "0x1827D3B90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> CGBAAPHFGBA(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, int ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27D6250", Offset = "0x27D5450", VA = "0x1827D6250")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JMEPOIDIFLD(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x27D8210", Offset = "0x27D7410", VA = "0x1827D8210")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OLCBCIPNCNN(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x27D5B10", Offset = "0x27D4D10", VA = "0x1827D5B10")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> IBMCEPBBJPF(this NMDEMDJAPPL CEENCLMGJAM, float OGNDHFPFEOJ, float ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27D3B10", Offset = "0x27D2D10", VA = "0x1827D3B10")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> CAMOEHGBCAJ(this NMDEMDJAPPL CEENCLMGJAM, float OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27D3510", Offset = "0x27D2710", VA = "0x1827D3510")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ANFEPDGELFP(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27D3CB0", Offset = "0x27D2EB0", VA = "0x1827D3CB0")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> DAFCFBCKMLD(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27D76F0", Offset = "0x27D68F0", VA = "0x1827D76F0")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> MMHBFCAMOEO(this NMDEMDJAPPL CEENCLMGJAM, int MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x27D8030", Offset = "0x27D7230", VA = "0x1827D8030")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> NOIIANBAEGM(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27D8290", Offset = "0x27D7490", VA = "0x1827D8290")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> ONKPCBEGBKM(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IHEHFFEJKMN)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x27D4460", Offset = "0x27D3660", VA = "0x1827D4460")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> EENLDNHIJCN(this NMDEMDJAPPL CEENCLMGJAM, int MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x27D3C10", Offset = "0x27D2E10", VA = "0x1827D3C10")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> CHCIOAFPELF(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27D3590", Offset = "0x27D2790", VA = "0x1827D3590")]
	public static (JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>) BBMOCMLCINP(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<DJKJBIDFBJO> DKLGHGOJGML, [In] ReadOnlySpan<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> OLHPCEIIIOL, [In] ReadOnlySpan<int?> FJFIDOHBNPO, [In] Span<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> BJHEFNCIFMC)
	{
		return default((JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27D6EC0", Offset = "0x27D60C0", VA = "0x1827D6EC0")]
	public static (JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>) LIAGPJCCDEO(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<LDMFJMAMADM> EEHLCJKAHMI, [In] ReadOnlySpan<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> OLHPCEIIIOL, [In] ReadOnlySpan<int?> FJFIDOHBNPO, [In] Span<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> BJHEFNCIFMC)
	{
		return default((JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x38468E0", Offset = "0x3845AE0", VA = "0x1838468E0")]
	public static (JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HGLMKHOJKPL>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<TMarker>>, JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>) BKFLOHLFEAK<TMarker>(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<HGLMKHOJKPL> DKDLLLEHNFP, [In] ReadOnlySpan<byte> DHAOEHNLNON)
	{
		return default((JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<HAAFGKINDME<HGLMKHOJKPL>>, JFIBBLJIDCN<HAAFGKINDME<GIGAPMKOANA>>, JFIBBLJIDCN<HAAFGKINDME<TMarker>>, JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27D6190", Offset = "0x27D5390", VA = "0x1827D6190")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JLEGFJJHMJC(this NMDEMDJAPPL CEENCLMGJAM, int NNAIPNIHBIM, [Optional] JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x27D5900", Offset = "0x27D4B00", VA = "0x1827D5900")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> HNILHMGIOMP(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NNAIPNIHBIM, [Optional] JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27D6BA0", Offset = "0x27D5DA0", VA = "0x1827D6BA0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LBEMMIMHKBK(this NMDEMDJAPPL CEENCLMGJAM, [In] ReadOnlySpan<byte> NNAIPNIHBIM, [Optional] JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27D59F0", Offset = "0x27D4BF0", VA = "0x1827D59F0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> IANIGCJIBCM(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NNAIPNIHBIM, int JAFKPMJIGFL, [Optional] JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27D44E0", Offset = "0x27D36E0", VA = "0x1827D44E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> EFPNIOBPHNM(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x27D5000", Offset = "0x27D4200", VA = "0x1827D5000")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GJHFLIMJANO(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27D6610", Offset = "0x27D5810", VA = "0x1827D6610")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KGAIKKBMPCF(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x27D5DB0", Offset = "0x27D4FB0", VA = "0x1827D5DB0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ILOPHNBLCBL(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x27D5C90", Offset = "0x27D4E90", VA = "0x1827D5C90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> IIPINPDKHLJ(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x27D6050", Offset = "0x27D5250", VA = "0x1827D6050")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JHKEJDBHGOJ(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x27D6B20", Offset = "0x27D5D20", VA = "0x1827D6B20")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KPJBBJCEDFI(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, int ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27D5760", Offset = "0x27D4960", VA = "0x1827D5760")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> HDAJGKAAAKO(this NMDEMDJAPPL CEENCLMGJAM, int OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x27D5EB0", Offset = "0x27D50B0", VA = "0x1827D5EB0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> IPAHNDMCOBO(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OGNDHFPFEOJ, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> ABBPAGLDFGP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27D3F60", Offset = "0x27D3160", VA = "0x1827D3F60")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DFLOOACFBEH(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27D6D90", Offset = "0x27D5F90", VA = "0x1827D6D90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LFFFNIPNFAD(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x27D7B50", Offset = "0x27D6D50", VA = "0x1827D7B50")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NDNGMGGGNMN(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27D4C40", Offset = "0x27D3E40", VA = "0x1827D4C40")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> FHOFFHBFJHO(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27D5F30", Offset = "0x27D5130", VA = "0x1827D5F30")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JCMOKHJEIEM(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27D8440", Offset = "0x27D7640", VA = "0x1827D8440")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> PEIHJGHOMJF(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27D7430", Offset = "0x27D6630", VA = "0x1827D7430")]
	public static JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>> LLCGFNDDEBF(this NMDEMDJAPPL CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<HAAFGKINDME<HAAFGKINDME<JANJHCEFKOJ>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27D4720", Offset = "0x27D3920", VA = "0x1827D4720")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> EJHNOKKDHKH(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27D57E0", Offset = "0x27D49E0", VA = "0x1827D57E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> HNCGPLEPDDN(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27D78F0", Offset = "0x27D6AF0", VA = "0x1827D78F0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MOEAFKCJJCO(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x27D51A0", Offset = "0x27D43A0", VA = "0x1827D51A0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GNPCIPMPMDK(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27D68E0", Offset = "0x27D5AE0", VA = "0x1827D68E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KMLJBINCKEH(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x27D52A0", Offset = "0x27D44A0", VA = "0x1827D52A0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GPLPEGPPHHM(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27D3E60", Offset = "0x27D3060", VA = "0x1827D3E60")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DFBBLCHLOAG(this NMDEMDJAPPL CEENCLMGJAM, int MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x27D4D40", Offset = "0x27D3F40", VA = "0x1827D4D40")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> FMMIMNLGAPL(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MLCDCHNOCFI)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x27D6750", Offset = "0x27D5950", VA = "0x1827D6750")]
	public static void KGHOGIDDOBC(this NMDEMDJAPPL CEENCLMGJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27D67E0", Offset = "0x27D59E0", VA = "0x1827D67E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KIEFNJIJAIH(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, float KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27D6A00", Offset = "0x27D5C00", VA = "0x1827D6A00")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KNKGDOFIPCP(this NMDEMDJAPPL CEENCLMGJAM, float GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x27D80D0", Offset = "0x27D72D0", VA = "0x1827D80D0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OBFKNFIBAKP(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x27D62D0", Offset = "0x27D54D0", VA = "0x1827D62D0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JMNDJOKCFBG(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x27D7550", Offset = "0x27D6750", VA = "0x1827D7550")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MELGKFIABPC(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x27D7C90", Offset = "0x27D6E90", VA = "0x1827D7C90")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NJBJFMMLEAD(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x27D53E0", Offset = "0x27D45E0", VA = "0x1827D53E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> HBNFPACNMNC(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> JIDGKOGFDJM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IBMHLNGEJPP)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x27D3410", Offset = "0x27D2610", VA = "0x1827D3410")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> AHPGCGAILPA(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, int KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x27D7A30", Offset = "0x27D6C30", VA = "0x1827D7A30")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NALINPDCIGC(this NMDEMDJAPPL CEENCLMGJAM, int GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x27D4180", Offset = "0x27D3380", VA = "0x1827D4180")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> DHDPJGHMHJP(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> GENFKMCJKPD, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> KAAAPNGENND)
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3847E60", Offset = "0x3847060", VA = "0x183847E60")]
	public static void IIJJAOEHDCN<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<DJKJBIDFBJO> DKLGHGOJGML, [In] ReadOnlySpan<JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>> DFCJLLNMBLH, [In] ReadOnlySpan<int?> FJFIDOHBNPO, [In] Span<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> BJHEFNCIFMC, [In] Span<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> FJBCHDIDGLL, [In] ReadOnlySpan<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>?> MCAPONONNNF) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3848400", Offset = "0x3847600", VA = "0x183848400")]
	public static void KJCMFNDGOOA<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<LDMFJMAMADM> OOKJGLKPPPN, [In] ReadOnlySpan<JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>> FNDILJFLNEF, [In] ReadOnlySpan<int?> FJFIDOHBNPO, [In] Span<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> BJHEFNCIFMC, [In] Span<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>> FJBCHDIDGLL, [In] ReadOnlySpan<JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>?> MCAPONONNNF) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3848C30", Offset = "0x3847E30", VA = "0x183848C30")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> LENKKOGPJAO<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> JOCGBJKPMGE, [Optional] JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3848E10", Offset = "0x3848010", VA = "0x183848E10")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> OBBJLJFMDGH<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GNLLAMANIAA, [Optional] JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3849270", Offset = "0x3848470", VA = "0x183849270")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> OELFKDAGDLD<TDeps, TStateSys>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE) where TDeps : notnull, LICGCBGGHOC<TStateSys> where TStateSys : notnull
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3847090", Offset = "0x3846290", VA = "0x183847090")]
	public static JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF> CPEICHAPBOC<TDeps, TStateSys>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE) where TDeps : notnull, LICGCBGGHOC<TStateSys> where TStateSys : notnull
	{
		return default(JFIBBLJIDCN<EMCDHGIHDNB.AACAOPCODIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27D4E50", Offset = "0x27D4050", VA = "0x1827D4E50")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GGJOIKHGMGJ(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> JHLBKDKEDKC, IntPtr INOLJPCLPOF, IntPtr DFKLENHAIAK)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27D4940", Offset = "0x27D3B40", VA = "0x1827D4940")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> FFFMBIKMLOD(this NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GMNLAHKOPGE, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> FLCMFILELBC, IntPtr DAJNIFAJAMC, IntPtr HOBPBCODHEM, IntPtr IKCNHLKCFLE, bool BAIBNKMGGDA)
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3847730", Offset = "0x3846930", VA = "0x183847730")]
	public static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IFEPFLIGKDM<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<DJKJBIDFBJO> FCLEJDFADBP, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GMNLAHKOPGE, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> FLCMFILELBC, int? MGNBLGJEMPH, [Optional] IntPtr LPDMAHCCFLD) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3847410", Offset = "0x3846610", VA = "0x183847410")]
	private static JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> IFEPFLIGKDM<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<DJKJBIDFBJO> FCLEJDFADBP, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> GMNLAHKOPGE, JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP> FLCMFILELBC, int? MGNBLGJEMPH) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
		return default(JFIBBLJIDCN<ADFBFFJOPCH.OLLJCPKAPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x38469E0", Offset = "0x3845BE0", VA = "0x1838469E0")]
	public static JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> BLHPPBMFKLK<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NNAIPNIHBIM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>? HLCHGMIKLCE) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
		return default(JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38489A0", Offset = "0x3847BA0", VA = "0x1838489A0")]
	public static void LCBADHEPILC<TDeps, TState>(this NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TState HPAPEOOKLIH, int EOIPPNNCFNL) where TDeps : notnull, LICGCBGGHOC<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MCPLJCFDMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> CNKGGMOIBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> APNNNLEOLHB;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
	public MCPLJCFDMKN(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> CJDPLPANJGC, JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> HMADKOKMPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x27D8C40", Offset = "0x27D7E40", VA = "0x1827D8C40")]
	public static MCPLJCFDMKN OIKMHICCLEP(JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>> CJDPLPANJGC)
	{
		return default(MCPLJCFDMKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OKJHNFLHPLN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class KKIJAOOANPI : MJBNMDJLCEK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct DJHKPDBGHDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> DCIAGHCHHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int PMLOAHGMFBB;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		public DJHKPDBGHDK(JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ODJJBLPFEED, int NIBICIJAIGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class CNFPAAHJFJM : MJBNMDJLCEK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct FOHJBIBMIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int PMLOAHGMFBB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public FOHJBIBMIDF(int NIBICIJAIGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CENKFEHNLJJ : MJBNMDJLCEK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HGNFIMHIHOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> DCIAGHCHHIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int PMLOAHGMFBB;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
		public HGNFIMHIHOM(JFIBBLJIDCN<CKFEEKILNBN.LCNJBKDILPN> ODJJBLPFEED, int NIBICIJAIGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum OBMAKHDCMAH
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
	public sealed class KBMNMLLCKKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class MJBNMDJLCEK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PKEMADDBECD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? EGIADCOAHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MCPLJCFDMKN MFLIEMAAGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OBMAKHDCMAH GFBJKHNMBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JFIBBLJIDCN<MJBNMDJLCEK> OIFCPPOCINF;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27DAE00", Offset = "0x27DA000", VA = "0x1827DAE00")]
		public PKEMADDBECD(int? KEJPCHFKIMO, [In] MCPLJCFDMKN LLIFHLHIACF, OBMAKHDCMAH HEGJGCGMEML, JFIBBLJIDCN<MJBNMDJLCEK> JEIFGIOCPEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LNILOBOBPHP : MJBNMDJLCEK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct GFMCMPDJACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int PMLOAHGMFBB;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		public GFMCMPDJACK(int NIBICIJAIGM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal GMPPBJCHAEP<KBMNMLLCKKD, PKEMADDBECD> JFOAFMNFIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal GMPPBJCHAEP<KKIJAOOANPI, DJHKPDBGHDK> FDNECLMGNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal GMPPBJCHAEP<CENKFEHNLJJ, HGNFIMHIHOM> MFBABDGMENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal GMPPBJCHAEP<LNILOBOBPHP, GFMCMPDJACK> BNLDJLAGEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal GMPPBJCHAEP<CNFPAAHJFJM, FOHJBIBMIDF> PMCGBFJBHIP;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x27DACD0", Offset = "0x27D9ED0", VA = "0x1827DACD0")]
	private OKJHNFLHPLN([In] GMPPBJCHAEP<KBMNMLLCKKD, PKEMADDBECD> PMKGOMFOLBD, [In] GMPPBJCHAEP<KKIJAOOANPI, DJHKPDBGHDK> IMGOCOKOAED, [In] GMPPBJCHAEP<CENKFEHNLJJ, HGNFIMHIHOM> AJGOKNPOFDI, [In] GMPPBJCHAEP<LNILOBOBPHP, GFMCMPDJACK> BMDPIHLAFLJ, [In] GMPPBJCHAEP<CNFPAAHJFJM, FOHJBIBMIDF> ENGMEDFINLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x27DAAE0", Offset = "0x27D9CE0", VA = "0x1827DAAE0")]
	public static OKJHNFLHPLN OIKMHICCLEP()
	{
		return default(OKJHNFLHPLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ICJNOEOBIEN
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x27D3220", Offset = "0x27D2420", VA = "0x1827D3220")]
	public static void NHLEMPKJEGJ(this OKJHNFLHPLN CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NAENOBJNOGE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x27D8E40", Offset = "0x27D8040", VA = "0x1827D8E40")]
	public static void MENHHIHEOIL(NMDEMDJAPPL CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CBJNJNNMGBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, BOJKCCNAKDK> KAJNANOKMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int FAHGDAOMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int ABMLLGHPLHB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x27CFA60", Offset = "0x27CEC60", VA = "0x1827CFA60")]
	private CBJNJNNMGBC([In] KGAPBMDBEOB<CKFEEKILNBN.ICHOPGFGFBG, BOJKCCNAKDK> GJFEOAIGBBJ, int CMKEBDPLNEO, int PIOHFEPDMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x27CF9F0", Offset = "0x27CEBF0", VA = "0x1827CF9F0")]
	public static CBJNJNNMGBC OIKMHICCLEP()
	{
		return default(CBJNJNNMGBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27CF800", Offset = "0x27CEA00", VA = "0x1827CF800")]
	public void NHLEMPKJEGJ([In] NMDEMDJAPPL LEPDDHJAJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3616D70", Offset = "0x3615F70", VA = "0x183616D70")]
	public static void MENHHIHEOIL<TDeps, TStateSys>(NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE, JFIBBLJIDCN<JJGKIIIBOJJ> EEKBMGEEJKM) where TDeps : notnull, LICGCBGGHOC<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EOOAHAGHACK
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x27D2CE0", Offset = "0x27D1EE0", VA = "0x1827D2CE0")]
	public static void MENHHIHEOIL(NMDEMDJAPPL CEENCLMGJAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct CLNAGLMHKHI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface KPBFFKPJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HGOBAIJDBKF(PAKIJLEMGBA<byte> NEMFMDMIFHB, int KPAPEOAFPPG);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct IBPEJODALAL : KPBFFKPJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x27D31A0", Offset = "0x27D23A0", VA = "0x1827D31A0", Slot = "4")]
		public void HGOBAIJDBKF(PAKIJLEMGBA<byte> NEMFMDMIFHB, int KPAPEOAFPPG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct CIGNGMLBKFO : KPBFFKPJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x27CFAA0", Offset = "0x27CECA0", VA = "0x1827CFAA0", Slot = "4")]
		public void HGOBAIJDBKF(PAKIJLEMGBA<byte> NEMFMDMIFHB, int KPAPEOAFPPG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct LLBDGFGLNLI : KPBFFKPJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x27D8BC0", Offset = "0x27D7DC0", VA = "0x1827D8BC0", Slot = "4")]
		public void HGOBAIJDBKF(PAKIJLEMGBA<byte> NEMFMDMIFHB, int KPAPEOAFPPG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct EJMDIMBOHJL : KPBFFKPJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x27D2BA0", Offset = "0x27D1DA0", VA = "0x1827D2BA0", Slot = "4")]
		public void HGOBAIJDBKF(PAKIJLEMGBA<byte> NEMFMDMIFHB, int KPAPEOAFPPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class DBICNPNDANH<TCallProcessorDeps> where TCallProcessorDeps : struct, KPBFFKPJGLB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps MPDDJFAHINH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x39A9860", Offset = "0x39A8A60", VA = "0x1839A9860")]
		public static int MENHHIHEOIL<TDeps, TStateSys>(TDeps POLANHDJCNH, TStateSys HPAPEOOKLIH, NMDEMDJAPPL LEPDDHJAJAH, [In] PAKIJLEMGBA<byte> LDHHLCKKFBF, int GHGKDFELHCK) where TDeps : LICGCBGGHOC<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private PAKIJLEMGBA<LOJBPOLIFFF> GDFJPEBDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>> CNKNLJBDDDB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x27CFEB0", Offset = "0x27CF0B0", VA = "0x1827CFEB0")]
	private CLNAGLMHKHI([In] PAKIJLEMGBA<LOJBPOLIFFF> GAAGDJICFKI, Dictionary<JFIBBLJIDCN<HAAFGKINDME<JANJHCEFKOJ>>, JFIBBLJIDCN<CKFEEKILNBN.ICHOPGFGFBG>> PLLBKGFJANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x27CFDF0", Offset = "0x27CEFF0", VA = "0x1827CFDF0")]
	public static CLNAGLMHKHI OIKMHICCLEP()
	{
		return default(CLNAGLMHKHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x27CFDB0", Offset = "0x27CEFB0", VA = "0x1827CFDB0")]
	public void NHLEMPKJEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3625430", Offset = "0x3624630", VA = "0x183625430")]
	public static void MENHHIHEOIL<TDeps, TStateSys>(NMDEMDJAPPL CEENCLMGJAM, TDeps POLANHDJCNH, TStateSys MMHHKGPDNAE) where TDeps : LICGCBGGHOC<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class OHLFABKLGPF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct CJBMPMJJHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> NBNIDPNCGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int PBHODNAENLH;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int JPKLDGFAFFG;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int AECMKGAHBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x27DA320", Offset = "0x27D9520", VA = "0x1827DA320")]
	public static void MENHHIHEOIL(NMDEMDJAPPL CEENCLMGJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x27D9F20", Offset = "0x27D9120", VA = "0x1827D9F20")]
	private static void FLBAADJJHOO([In] NMDEMDJAPPL CEENCLMGJAM, JFIBBLJIDCN<OKJHNFLHPLN.KBMNMLLCKKD> MKHHKDJKLDN, PAKIJLEMGBA<byte> PGMOOMFFECN, List<CJBMPMJJHID> FJOFCNEJFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x27DA0B0", Offset = "0x27D92B0", VA = "0x1827DA0B0")]
	private static void FLBAADJJHOO(PAKIJLEMGBA<byte> PGMOOMFFECN, int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x27DA1F0", Offset = "0x27D93F0", VA = "0x1827DA1F0")]
	private static void KNKPEAEANGL(NMDEMDJAPPL CEENCLMGJAM, List<CJBMPMJJHID> FJOFCNEJFLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LLPILHBLKBJ<TDeps, TIndex, TValues> where TDeps : struct, BBINEAECOIN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps MPDDJFAHINH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x50E2DF0", Offset = "0x50E1FF0", VA = "0x1850E2DF0")]
	public static void MENHHIHEOIL([In] PAKIJLEMGBA<LOJBPOLIFFF> GAAGDJICFKI, int FMFDOGBLNBK, TValues CPMBLPBIGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface BBINEAECOIN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAKIJLEMGBA<TIndex> OANHDKLDGLN(int FMFDOGBLNBK, [In] TValues CPMBLPBIGIH);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(TIndex NIBICIJAIGM, [In] TValues CPMBLPBIGIH);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFDCOKMLAKL(TIndex NIBICIJAIGM, TValues CPMBLPBIGIH, JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface PBGHICIMCNK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex AGCAMPINGFP(int NIBICIJAIGM);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JGMKNHFGIMA(TIndex NIBICIJAIGM, [In] TValues CPMBLPBIGIH);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFIBBLJIDCN<HAAFGKINDME<KMIODFPCFME>> AFKJLAIIOJD(TIndex NIBICIJAIGM, [In] TValues CPMBLPBIGIH);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class AFCBAFEDKBG<TDeps, TIndex, TValues> where TDeps : struct, PBGHICIMCNK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps MPDDJFAHINH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4A810C0", Offset = "0x4A802C0", VA = "0x184A810C0")]
	public static PAKIJLEMGBA<TIndex> MENHHIHEOIL(int FMFDOGBLNBK, [In] TValues CPMBLPBIGIH)
	{
		return default(PAKIJLEMGBA<TIndex>);
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
