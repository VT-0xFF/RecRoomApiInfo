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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF3D10", Offset = "0x1FF2310", VA = "0x181FF3D10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct KBANDOMCGKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> BIPKDOHEOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int AMCGEKKJOJG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
	public KBANDOMCGKC(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> GOMBEALOMON, int LHOLHMCKPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GJCGNJOFCOL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class COFHLDDFKNC : DIGCBCKOFBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct MOFPGOJDAGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly GNKFFOEHDOA<byte> BBMAJBGBBDL;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F93FC0", Offset = "0x1F925C0", VA = "0x181F93FC0")]
		public MOFPGOJDAGI(GNKFFOEHDOA<byte> CNNPIMPOGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3890", Offset = "0x1FF1E90", VA = "0x181FF3890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class CCPJCHPCHLG : DIGCBCKOFBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct IPJKMMBPENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> HIBMPHPFEFB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public IPJKMMBPENK(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> MPLAIKCCPPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DNNCKCLPCKC
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
	public sealed class KEPFFNDIKJD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class DIGCBCKOFBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct BINFAMECELA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DNNCKCLPCKC LPNFAOFKOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly EJDMOINMPCI<DIGCBCKOFBD> KKEHLKIBEIG;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		public BINFAMECELA(DNNCKCLPCKC KPKLBGOCIPG, EJDMOINMPCI<DIGCBCKOFBD> KENHJMBPDMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class DPGCGNIJHJD : DIGCBCKOFBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct GHOOEIPAKAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> DGDEJJOFHAK;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public GHOOEIPAKAN(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class ALDAHHBFDBE : DIGCBCKOFBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JODGMEAMKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly PEIEOFGIIME KJMHOJALBBE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public JODGMEAMKCI(PEIEOFGIIME MDMOFOJBJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FED890", Offset = "0x1FEBE90", VA = "0x181FED890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal PKNCMADMAHA<KEPFFNDIKJD, BINFAMECELA> PHIPEPEMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal PKNCMADMAHA<COFHLDDFKNC, MOFPGOJDAGI> JDJKMFFKBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal PKNCMADMAHA<CCPJCHPCHLG, IPJKMMBPENK> PBELPHILBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal PKNCMADMAHA<DPGCGNIJHJD, GHOOEIPAKAN> ADDIKMDOHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal PKNCMADMAHA<ALDAHHBFDBE, JODGMEAMKCI> LFADFKLFLNJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FED1A0", Offset = "0x1FEB7A0", VA = "0x181FED1A0")]
	private GJCGNJOFCOL([In] PKNCMADMAHA<KEPFFNDIKJD, BINFAMECELA> BBOMNGCDCAM, [In] PKNCMADMAHA<COFHLDDFKNC, MOFPGOJDAGI> ADJNKIOCKJC, [In] PKNCMADMAHA<CCPJCHPCHLG, IPJKMMBPENK> DFGAGELHCHC, [In] PKNCMADMAHA<DPGCGNIJHJD, GHOOEIPAKAN> JFANBEOJDMI, [In] PKNCMADMAHA<ALDAHHBFDBE, JODGMEAMKCI> BEIIKMNKEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FED060", Offset = "0x1FEB660", VA = "0x181FED060")]
	public static GJCGNJOFCOL NKOJKFHACJH()
	{
		return default(GJCGNJOFCOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OKLACNPODMH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4090", Offset = "0x1FF2690", VA = "0x181FF4090")]
	public static void AMMOOILDICF(this GJCGNJOFCOL ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CEPFALINOAO
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
public struct ODMDGLFBLMB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class EHHANHHOOEF : NJAACFJHCPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct CNJOEEBMCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> DMEONEIJOPK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public CNJOEEBMCMD(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> EAHGOCJPBJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum LEKOCOFILGM
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
	public sealed class IJAGEEAKECD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class NJAACFJHCPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct KPDHJPLEGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly LEKOCOFILGM LPNFAOFKOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly EJDMOINMPCI<NJAACFJHCPJ> KKEHLKIBEIG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		public KPDHJPLEGCF(LEKOCOFILGM KPKLBGOCIPG, EJDMOINMPCI<NJAACFJHCPJ> KENHJMBPDMM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal PKNCMADMAHA<IJAGEEAKECD, KPDHJPLEGCF> PHIPEPEMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal PKNCMADMAHA<EHHANHHOOEF, CNJOEEBMCMD> FJODNMFLDEL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3E20", Offset = "0x1FF2420", VA = "0x181FF3E20")]
	private ODMDGLFBLMB([In] PKNCMADMAHA<IJAGEEAKECD, KPDHJPLEGCF> BBOMNGCDCAM, [In] PKNCMADMAHA<EHHANHHOOEF, CNJOEEBMCMD> CPKLBNFFHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3D90", Offset = "0x1FF2390", VA = "0x181FF3D90")]
	public static ODMDGLFBLMB NKOJKFHACJH()
	{
		return default(ODMDGLFBLMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DILLJFOCOPD
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA2B0", Offset = "0x1FE88B0", VA = "0x181FEA2B0")]
	public static void AMMOOILDICF(this ODMDGLFBLMB ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IPJMFACOGEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public CDJBEBBGDPF<int> PBOHFPCFGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public CDJBEBBGDPF<int> DGICBJNEAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CGFPCOGGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int BPICLIJEJGL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FED440", Offset = "0x1FEBA40", VA = "0x181FED440")]
	private IPJMFACOGEI([In] CDJBEBBGDPF<int> MJDOELEGCFH, [In] CDJBEBBGDPF<int> KCBBNOBGMNE, int AKPNMLBMAMI, int CEHFMOCFHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FED3A0", Offset = "0x1FEB9A0", VA = "0x181FED3A0")]
	public static IPJMFACOGEI NKOJKFHACJH()
	{
		return default(IPJMFACOGEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LLAMOHFFCMP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDF30", Offset = "0x1FEC530", VA = "0x181FEDF30")]
	public static void AMMOOILDICF(this IPJMFACOGEI ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KMIJKCJOPKC
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum BGNIKJAMAPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class MBGFHHKHMAF : HAPLAMFNCIJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct HBIPMHFHLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly EJDMOINMPCI<NHIDKPKDFCM> IENNDDJLNCN;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public HBIPMHFHLKN(EJDMOINMPCI<NHIDKPKDFCM> EBBGDJNLABL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class AOAJBGPJFDJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HAPLAMFNCIJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct MMGCMJLHOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly BGNIKJAMAPG LPNFAOFKOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly EJDMOINMPCI<HAPLAMFNCIJ> KKEHLKIBEIG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		private MMGCMJLHOIF(BGNIKJAMAPG KPKLBGOCIPG, EJDMOINMPCI<HAPLAMFNCIJ> KENHJMBPDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3790", Offset = "0x1FF1D90", VA = "0x181FF3790")]
		public static MMGCMJLHOIF NKOJKFHACJH(BGNIKJAMAPG KPKLBGOCIPG, EJDMOINMPCI<HAPLAMFNCIJ> KENHJMBPDMM)
		{
			return default(MMGCMJLHOIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class NHEDJNFMBLJ : HAPLAMFNCIJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PEEOBPKCOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly EJDMOINMPCI<NHIDKPKDFCM> IENNDDJLNCN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public PEEOBPKCOMI(EJDMOINMPCI<NHIDKPKDFCM> EBBGDJNLABL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class NHIDKPKDFCM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PLIEDCMOAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public CDJBEBBGDPF<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> LKKPBMKJJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CDJBEBBGDPF<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> AHMBEAKBJNO;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3E20", Offset = "0x1FF2420", VA = "0x181FF3E20")]
		private PLIEDCMOAHD([In] CDJBEBBGDPF<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> PLJOOCONEHF, [In] CDJBEBBGDPF<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> GAHJNNCGKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5190", Offset = "0x1FF3790", VA = "0x181FF5190")]
		public static PLIEDCMOAHD NKOJKFHACJH()
		{
			return default(PLIEDCMOAHD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal PKNCMADMAHA<AOAJBGPJFDJ, MMGCMJLHOIF> PHIPEPEMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal PKNCMADMAHA<NHEDJNFMBLJ, PEEOBPKCOMI> BNEMOBHIPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal PKNCMADMAHA<MBGFHHKHMAF, HBIPMHFHLKN> HDDJKNJCDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal CDJBEBBGDPF<(EJDMOINMPCI<AOAJBGPJFDJ> CallId, EJDMOINMPCI<NHIDKPKDFCM> IOId)> FEJGNLNBKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal PKNCMADMAHA<NHIDKPKDFCM, PLIEDCMOAHD> IGHEGOJPGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal JMJAGLIJMHJ<NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> OHOMPDLOHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal JMJAGLIJMHJ<NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> NNCPMJNFOAP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDBB0", Offset = "0x1FEC1B0", VA = "0x181FEDBB0")]
	private KMIJKCJOPKC([In] PKNCMADMAHA<AOAJBGPJFDJ, MMGCMJLHOIF> BBOMNGCDCAM, [In] PKNCMADMAHA<NHEDJNFMBLJ, PEEOBPKCOMI> NHPNCPCBNIP, [In] PKNCMADMAHA<MBGFHHKHMAF, HBIPMHFHLKN> DDLENHELOHN, [In] CDJBEBBGDPF<(EJDMOINMPCI<AOAJBGPJFDJ> CallId, EJDMOINMPCI<NHIDKPKDFCM> IOId)> PMPEAGNDOHI, [In] PKNCMADMAHA<NHIDKPKDFCM, PLIEDCMOAHD> GDIFCHONHHC, [In] JMJAGLIJMHJ<NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> BKFBKKJBFIF, [In] JMJAGLIJMHJ<NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> DGEIHMEKFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDA10", Offset = "0x1FEC010", VA = "0x181FEDA10")]
	public static KMIJKCJOPKC NKOJKFHACJH()
	{
		return default(KMIJKCJOPKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MMDCJEEGCDE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3740", Offset = "0x1FF1D40", VA = "0x181FF3740")]
	private static void AMMOOILDICF(this KMIJKCJOPKC.PLIEDCMOAHD ELMHNMGFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3530", Offset = "0x1FF1B30", VA = "0x181FF3530")]
	public static void AMMOOILDICF(this KMIJKCJOPKC ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PGOBKAMEOBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public CDJBEBBGDPF<byte> PPHBIBECNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal KMIJKCJOPKC LIIGMJOCICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal MIGMEAFIBNC LGNIMOBJMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> FDOKBGBEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal GJCGNJOFCOL JFBDNCJJHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal ODMDGLFBLMB DNEHCJILEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal JMJAGLIJMHJ<FNFFOGDJCBH, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>?> IBDBONGCBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal CDJBEBBGDPF<EJDMOINMPCI<FNFFOGDJCBH>> LHGANGKCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> IKNILHKEIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> ENAFCFCHKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> NCNOMHPAPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal FMMELPFOFEM KBBMKHGFGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal OOAJHEAOBHN BPBIDPMJKAG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4E30", Offset = "0x1FF3430", VA = "0x181FF4E30")]
	private PGOBKAMEOBJ([In] CDJBEBBGDPF<byte> OJFJIONAKBB, [In] KMIJKCJOPKC JMDCNCKPGOF, [In] MIGMEAFIBNC FAAKKCFEHND, [In] GJCGNJOFCOL NHBHOFCFBHJ, [In] ODMDGLFBLMB PBJAJBBBCHM, [In] JMJAGLIJMHJ<FNFFOGDJCBH, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>?> HKEIIJJCMFP, [In] CDJBEBBGDPF<EJDMOINMPCI<FNFFOGDJCBH>> ABNDCEBBJHA, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> GFIBPJOKIKB, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> LFBJFFDGCID, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> MPPCAGGJBDO, [In] FMMELPFOFEM LPCDEMBMOHO, [In] OOAJHEAOBHN MFBIPFODFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4370", Offset = "0x1FF2970", VA = "0x181FF4370")]
	public static PGOBKAMEOBJ NKOJKFHACJH()
	{
		return default(PGOBKAMEOBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FLPJCHNFMJP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct PDGBMDCFNNG : LJEEJMENIBC<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>, JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF42C0", Offset = "0x1FF28C0", VA = "0x181FF42C0")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4290", Offset = "0x1FF2890", VA = "0x181FF4290", Slot = "4")]
		public EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> JIHEHBMNNIO(int EBDMAJMOJLN)
		{
			return default(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		public bool MDJLJNPLPIG(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "5")]
		private bool FHOFMKHOOIO(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4280", Offset = "0x1FF2880", VA = "0x181FF4280", Slot = "6")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> GAFPAJHMOIB(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct FHIIHHCKMKP : CPPMCFNGAPL<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>, JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA610", Offset = "0x1FE8C10", VA = "0x181FEA610")]
		public CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA690", Offset = "0x1FE8C90", VA = "0x181FEA690")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA550", Offset = "0x1FE8B50", VA = "0x181FEA550", Slot = "6")]
		public void BFBOGJHDHAA(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA610", Offset = "0x1FE8C10", VA = "0x181FEA610", Slot = "4")]
		private CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>> FPPMPLPCIJI(int NFIPMKOJLPK, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA680", Offset = "0x1FE8C80", VA = "0x181FEA680", Slot = "5")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> JGJHBJFPBMK(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct MNLMILJIJKH : LJEEJMENIBC<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>, JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FF37E0", Offset = "0x1FF1DE0", VA = "0x181FF37E0")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FF37B0", Offset = "0x1FF1DB0", VA = "0x181FF37B0", Slot = "4")]
		public EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> JIHEHBMNNIO(int EBDMAJMOJLN)
		{
			return default(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		public bool MDJLJNPLPIG(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "5")]
		private bool NDJNJFBLCAE(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FF37A0", Offset = "0x1FF1DA0", VA = "0x181FF37A0", Slot = "6")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> ACGMGIGAMAB(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct NJFPJMLKOHO : CPPMCFNGAPL<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>, JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3BD0", Offset = "0x1FF21D0", VA = "0x181FF3BD0")]
		public CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3C40", Offset = "0x1FF2240", VA = "0x181FF3C40")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3B10", Offset = "0x1FF2110", VA = "0x181FF3B10", Slot = "6")]
		public void BFBOGJHDHAA(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3BD0", Offset = "0x1FF21D0", VA = "0x181FF3BD0", Slot = "4")]
		private CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>> DNMLINGNNIP(int NFIPMKOJLPK, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3CF0", Offset = "0x1FF22F0", VA = "0x181FF3CF0", Slot = "5")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> NPMPPKDGMGN(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBDMAJMOJLN, [In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NDDFAMLBGLL : LJEEJMENIBC<EJDMOINMPCI<JFGPEANAFFG>, JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1FF39C0", Offset = "0x1FF1FC0", VA = "0x181FF39C0")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3990", Offset = "0x1FF1F90", VA = "0x181FF3990", Slot = "4")]
		public EJDMOINMPCI<JFGPEANAFFG> JIHEHBMNNIO(int EBDMAJMOJLN)
		{
			return default(EJDMOINMPCI<JFGPEANAFFG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3900", Offset = "0x1FF1F00", VA = "0x181FF3900")]
		public bool MDJLJNPLPIG(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3900", Offset = "0x1FF1F00", VA = "0x181FF3900", Slot = "5")]
		private bool BOLPLCJGFPG(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3980", Offset = "0x1FF1F80", VA = "0x181FF3980", Slot = "6")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> HPJONEJKGOI(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct OHOBKBACKPB : CPPMCFNGAPL<EJDMOINMPCI<JFGPEANAFFG>, JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3F40", Offset = "0x1FF2540", VA = "0x181FF3F40")]
		public CDJBEBBGDPF<EJDMOINMPCI<JFGPEANAFFG>> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<EJDMOINMPCI<JFGPEANAFFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3FB0", Offset = "0x1FF25B0", VA = "0x181FF3FB0")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3E60", Offset = "0x1FF2460", VA = "0x181FF3E60", Slot = "6")]
		public void BFBOGJHDHAA(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3F40", Offset = "0x1FF2540", VA = "0x181FF3F40", Slot = "4")]
		private CDJBEBBGDPF<EJDMOINMPCI<JFGPEANAFFG>> NEIMBGFDBID(int NFIPMKOJLPK, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<EJDMOINMPCI<JFGPEANAFFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FF4080", Offset = "0x1FF2680", VA = "0x181FF4080", Slot = "5")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> OGMJFLCOIHA(EJDMOINMPCI<JFGPEANAFFG> EBDMAJMOJLN, [In] JMJAGLIJMHJ<JFGPEANAFFG, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>?> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct IGDMCCIGINH : LJEEJMENIBC<int, CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FED2F0", Offset = "0x1FEB8F0", VA = "0x181FED2F0")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1474230", Offset = "0x1472830", VA = "0x181474230", Slot = "4")]
		public int JIHEHBMNNIO(int EBDMAJMOJLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		public bool MDJLJNPLPIG(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "5")]
		private bool BLGMAEJLAHH(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1FED390", Offset = "0x1FEB990", VA = "0x181FED390", Slot = "6")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> MKMLIALLIFM(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct JFHENBPDGPM : CPPMCFNGAPL<int, CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1FED670", Offset = "0x1FEBC70", VA = "0x181FED670")]
		public CDJBEBBGDPF<int> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1FED7E0", Offset = "0x1FEBDE0", VA = "0x181FED7E0")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FED6E0", Offset = "0x1FEBCE0", VA = "0x181FED6E0", Slot = "6")]
		public void BFBOGJHDHAA(int EBDMAJMOJLN, CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FED670", Offset = "0x1FEBC70", VA = "0x181FED670", Slot = "4")]
		private CDJBEBBGDPF<int> AJNFHFBPHHF(int NFIPMKOJLPK, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1FED880", Offset = "0x1FEBE80", VA = "0x181FED880", Slot = "5")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> NICBHFKCOBP(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> VariableId, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<LHPDJMBFANM>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct IEHFMBOJJOF : LJEEJMENIBC<int, CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FED240", Offset = "0x1FEB840", VA = "0x181FED240")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1474230", Offset = "0x1472830", VA = "0x181474230", Slot = "4")]
		public int JIHEHBMNNIO(int EBDMAJMOJLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		public bool MDJLJNPLPIG(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "5")]
		private bool PBCCGEOEOIP(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FED2E0", Offset = "0x1FEB8E0", VA = "0x181FED2E0", Slot = "6")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KKFFOJFGLHF(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct LIAKPEOLCAK : CPPMCFNGAPL<int, CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDD30", Offset = "0x1FEC330", VA = "0x181FEDD30")]
		public CDJBEBBGDPF<int> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDE90", Offset = "0x1FEC490", VA = "0x181FEDE90")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDDA0", Offset = "0x1FEC3A0", VA = "0x181FEDDA0", Slot = "6")]
		public void BFBOGJHDHAA(int EBDMAJMOJLN, CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDD30", Offset = "0x1FEC330", VA = "0x181FEDD30", Slot = "4")]
		private CDJBEBBGDPF<int> AFKDHMPGOBN(int NFIPMKOJLPK, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDD20", Offset = "0x1FEC320", VA = "0x181FEDD20", Slot = "5")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> AABNHNCCLBI(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct LFLHGLIALMO : LJEEJMENIBC<int, CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDC70", Offset = "0x1FEC270", VA = "0x181FEDC70")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1474230", Offset = "0x1472830", VA = "0x181474230", Slot = "4")]
		public int JIHEHBMNNIO(int EBDMAJMOJLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		public bool MDJLJNPLPIG(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "5")]
		private bool PBCCGEOEOIP(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDD10", Offset = "0x1FEC310", VA = "0x181FEDD10", Slot = "6")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KKFFOJFGLHF(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct DOGIOMAGJNC : CPPMCFNGAPL<int, CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA320", Offset = "0x1FE8920", VA = "0x181FEA320")]
		public CDJBEBBGDPF<int> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA490", Offset = "0x1FE8A90", VA = "0x181FEA490")]
		public EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA390", Offset = "0x1FE8990", VA = "0x181FEA390", Slot = "6")]
		public void BFBOGJHDHAA(int EBDMAJMOJLN, CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA320", Offset = "0x1FE8920", VA = "0x181FEA320", Slot = "4")]
		private CDJBEBBGDPF<int> AFKDHMPGOBN(int NFIPMKOJLPK, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(CDJBEBBGDPF<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA310", Offset = "0x1FE8910", VA = "0x181FEA310", Slot = "5")]
		private EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> AABNHNCCLBI(int EBDMAJMOJLN, [In] CDJBEBBGDPF<(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> Target, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> ByteCodeWriteLocation)> EGCOBBLGNBO)
		{
			return default(EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct GGMOMCMCNHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> JPLOGCCFOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool LNHMCDGPOAJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x128C750", Offset = "0x128AD50", VA = "0x18128C750")]
		public GGMOMCMCNHN(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL, bool PBCIKIGDBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1FED050", Offset = "0x1FEB650", VA = "0x181FED050")]
		public void NFDKAIMDEJH([Out] EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL, [Out] bool PBCIKIGDBLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct AOBBNDIIMDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EJDMOINMPCI<JFGPEANAFFG> AFBPNHCGBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> JPLOGCCFOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool LNHMCDGPOAJ;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA170", Offset = "0x1FE8770", VA = "0x181FEA170")]
		public AOBBNDIIMDP(EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL, bool PBCIKIGDBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA160", Offset = "0x1FE8760", VA = "0x181FEA160")]
		public void NFDKAIMDEJH([Out] EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL, [Out] bool PBCIKIGDBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA140", Offset = "0x1FE8740", VA = "0x181FEA140")]
		public void NFDKAIMDEJH([Out] EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL, [Out] EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE, [Out] bool PBCIKIGDBLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NKBKMBKBAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly EJDMOINMPCI<JFGPEANAFFG> AFBPNHCGBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> JPLOGCCFOEN;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		public NKBKMBKBAPO(EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3D00", Offset = "0x1FF2300", VA = "0x181FF3D00")]
		public void NFDKAIMDEJH([Out] EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL, [Out] EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA960", Offset = "0x1FE8F60", VA = "0x181FEA960")]
	public static void AMMOOILDICF(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC690", Offset = "0x1FEAC90", VA = "0x181FEC690")]
	public static void NGEDCAEDOPA(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> NGJDMIBKNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FEADC0", Offset = "0x1FE93C0", VA = "0x181FEADC0")]
	public static void BPFNEOEPOIF(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> NGJDMIBKNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAFC0", Offset = "0x1FE95C0", VA = "0x181FEAFC0")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>? DIDGMMJLDDK([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAD60", Offset = "0x1FE9360", VA = "0x181FEAD60")]
	public static EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> BKOEENHONKN([In] this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB930", Offset = "0x1FE9F30", VA = "0x181FEB930")]
	private static void HIKAJNCPFDP(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC3F0", Offset = "0x1FEA9F0", VA = "0x181FEC3F0")]
	private static EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>? NBPOKLHIIJD([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC7A0", Offset = "0x1FEADA0", VA = "0x181FEC7A0")]
	public static void OLBAPNDLNFE(this PGOBKAMEOBJ ELMHNMGFNPC, [In] CDJBEBBGDPF<KBANDOMCGKC> JMAKDAONPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC720", Offset = "0x1FEAD20", VA = "0x181FEC720")]
	public static GJCGNJOFCOL.DNNCKCLPCKC OGIFNHDJEJP([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
	{
		return default(GJCGNJOFCOL.DNNCKCLPCKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB7C0", Offset = "0x1FE9DC0", VA = "0x181FEB7C0")]
	public static GNKFFOEHDOA<byte> GPANAHBAEJM([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
	{
		return default(GNKFFOEHDOA<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAED0", Offset = "0x1FE94D0", VA = "0x181FEAED0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> DHECLDIHKGC([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB300", Offset = "0x1FE9900", VA = "0x181FEB300")]
	public static PEIEOFGIIME EHNBIMFEKLE([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
	{
		return default(PEIEOFGIIME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2B59630", Offset = "0x2B57C30", VA = "0x182B59630")]
	private static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> KHNFICPIOMA<TMJoin>(this PGOBKAMEOBJ ELMHNMGFNPC, GJCGNJOFCOL.DNNCKCLPCKC KPKLBGOCIPG, EJDMOINMPCI<TMJoin> KENHJMBPDMM) where TMJoin : GJCGNJOFCOL.DIGCBCKOFBD
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBF70", Offset = "0x1FEA570", VA = "0x181FEBF70")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> JBOBGOOLAJE(this PGOBKAMEOBJ ELMHNMGFNPC, bool HPMPNMCOJAI)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB180", Offset = "0x1FE9780", VA = "0x181FEB180")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> EDHKDHNJMAP(this PGOBKAMEOBJ ELMHNMGFNPC, GNKFFOEHDOA<byte> CNNPIMPOGKL)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC0E0", Offset = "0x1FEA6E0", VA = "0x181FEC0E0")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> JNDEGLGBJMM(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> MPLAIKCCPPO)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB430", Offset = "0x1FE9A30", VA = "0x181FEB430")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> FIOLFMDGMKH(this PGOBKAMEOBJ ELMHNMGFNPC, int IHBOJOAKJFB)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC370", Offset = "0x1FEA970", VA = "0x181FEC370")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> MNJEJMNAAAN(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B58EF0", Offset = "0x2B574F0", VA = "0x182B58EF0")]
	private static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> DMLBOBMJBGJ<TMJoin>(this PGOBKAMEOBJ ELMHNMGFNPC, ODMDGLFBLMB.LEKOCOFILGM KPKLBGOCIPG, EJDMOINMPCI<TMJoin> KENHJMBPDMM) where TMJoin : ODMDGLFBLMB.NJAACFJHCPJ
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FEACE0", Offset = "0x1FE92E0", VA = "0x181FEACE0")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> BIGELBKLLBO(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAE90", Offset = "0x1FE9490", VA = "0x181FEAE90")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> DEMFKBHNNML(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB080", Offset = "0x1FE9680", VA = "0x181FEB080")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> DNMDAGOPIFD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> EAHGOCJPBJM)
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAD20", Offset = "0x1FE9320", VA = "0x181FEAD20")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> BKGHBFNBFAC(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC510", Offset = "0x1FEAB10", VA = "0x181FEC510")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> NDMCCHAACEN(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB8B0", Offset = "0x1FE9EB0", VA = "0x181FEB8B0")]
	public static KMIJKCJOPKC.BGNIKJAMAPG HAODOELALKA([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> JGLOGFJNIBO)
	{
		return default(KMIJKCJOPKC.BGNIKJAMAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA920", Offset = "0x1FE8F20", VA = "0x181FEA920")]
	public static ICEDPHKEGDI<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>, OAGJMFPDMBA<KMIJKCJOPKC.NHIDKPKDFCM>> AJMHJNILLHF([In] this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(ICEDPHKEGDI<EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>, OAGJMFPDMBA<KMIJKCJOPKC.NHIDKPKDFCM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA740", Offset = "0x1FE8D40", VA = "0x181FEA740")]
	public static EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> ACEJNIKNFEJ([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> JGLOGFJNIBO)
	{
		return default(EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB100", Offset = "0x1FE9700", VA = "0x181FEB100")]
	public static KMIJKCJOPKC.PLIEDCMOAHD EDFFIJECIIJ([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBBGDJNLABL)
	{
		return default(KMIJKCJOPKC.PLIEDCMOAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC2F0", Offset = "0x1FEA8F0", VA = "0x181FEC2F0")]
	public static KMIJKCJOPKC.PLIEDCMOAHD MFMGHPAPAKE(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBBGDJNLABL)
	{
		return default(KMIJKCJOPKC.PLIEDCMOAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B59980", Offset = "0x2B57F80", VA = "0x182B59980")]
	private static EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> MNMCKCBLJBO<TMJoin>(this PGOBKAMEOBJ ELMHNMGFNPC, KMIJKCJOPKC.BGNIKJAMAPG KPKLBGOCIPG, EJDMOINMPCI<TMJoin> KENHJMBPDMM) where TMJoin : KMIJKCJOPKC.HAPLAMFNCIJ
	{
		return default(EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB4B0", Offset = "0x1FE9AB0", VA = "0x181FEB4B0")]
	public static (EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>) FLGNGHPPOMC(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default((EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FECB60", Offset = "0x1FEB160", VA = "0x181FECB60")]
	public static (EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>) PFHILLHKKNB(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default((EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB3F0", Offset = "0x1FE99F0", VA = "0x181FEB3F0")]
	public static EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> FCMEGBBIPED(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FECA60", Offset = "0x1FEB060", VA = "0x181FECA60")]
	public static void PAGPKLDGMAB(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM> EBBGDJNLABL, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> IKECBNKKNBH, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>> IGAPMFCNDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B580C0", Offset = "0x2B566C0", VA = "0x182B580C0")]
	public static GGMOMCMCNHN DKHGAFINHBF<TDeps, TStateSys>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE) where TDeps : HGDKEKDCOJC<TStateSys>
	{
		return default(GGMOMCMCNHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B596E0", Offset = "0x2B57CE0", VA = "0x182B596E0")]
	public static AOBBNDIIMDP LDMLMKLBBCN<TDeps, TStateSys>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int JCOCDKDILMK) where TDeps : HGDKEKDCOJC<TStateSys>
	{
		return default(AOBBNDIIMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B57C80", Offset = "0x2B56280", VA = "0x182B57C80")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>? BGHEEFGPIIB<TDeps, TStateSys>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, [In] ReadOnlySpan<int> NALLNOEOGDC, [In] Span<NKBKMBKBAPO> DKBPBONEMAM) where TDeps : HGDKEKDCOJC<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B59070", Offset = "0x2B57670", VA = "0x182B59070")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> HOLMDANINHF<TDeps, TStateSys>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC) where TDeps : HGDKEKDCOJC<TStateSys>
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBFF0", Offset = "0x1FEA5F0", VA = "0x181FEBFF0")]
	public static MIGMEAFIBNC.FEFCGFHKFGK JIDOGFNHEAJ([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAGKMEDPMHO)
	{
		return default(MIGMEAFIBNC.FEFCGFHKFGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBE80", Offset = "0x1FEA480", VA = "0x181FEBE80")]
	public static MIGMEAFIBNC.CECJIOACCAA INAHKLGJELD([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAGKMEDPMHO)
	{
		return default(MIGMEAFIBNC.CECJIOACCAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB210", Offset = "0x1FE9810", VA = "0x181FEB210")]
	public static MIGMEAFIBNC.LBAEBEFHNKH EGHIALMECKD([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAGKMEDPMHO)
	{
		return default(MIGMEAFIBNC.LBAEBEFHNKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC160", Offset = "0x1FEA760", VA = "0x181FEC160")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LINIBEDBBIE(this PGOBKAMEOBJ ELMHNMGFNPC, int? JPKPMFALPHA, string LGJDNDBECCI)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBD90", Offset = "0x1FEA390", VA = "0x181FEBD90")]
	public static MIGMEAFIBNC.HPHLCPNJIJF IMOIEPHAJHI([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAGKMEDPMHO)
	{
		return default(MIGMEAFIBNC.HPHLCPNJIJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB750", Offset = "0x1FE9D50", VA = "0x181FEB750")]
	public static MIGMEAFIBNC.LKCJOOGMFOL GOHIGJJIIJL([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAGKMEDPMHO)
	{
		return default(MIGMEAFIBNC.LKCJOOGMFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FECAF0", Offset = "0x1FEB0F0", VA = "0x181FECAF0")]
	public static int? PBCGIBAKGMN([In] this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAGKMEDPMHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B59A20", Offset = "0x2B58020", VA = "0x182B59A20")]
	private static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> PDPBPNMNNDE<TMJoin>(this PGOBKAMEOBJ ELMHNMGFNPC, int? JPKPMFALPHA, MIGMEAFIBNC.LKCJOOGMFOL KPKLBGOCIPG, EJDMOINMPCI<TMJoin> KENHJMBPDMM) where TMJoin : MIGMEAFIBNC.MBNEJJEHCNC
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FEAC30", Offset = "0x1FE9230", VA = "0x181FEAC30")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BCIBLDHEMGP(this PGOBKAMEOBJ ELMHNMGFNPC, int? JPKPMFALPHA, EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> JGLOGFJNIBO, int EBDMAJMOJLN)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBAA0", Offset = "0x1FEA0A0", VA = "0x181FEBAA0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> HKLNPLNPBLB(this PGOBKAMEOBJ ELMHNMGFNPC, int? JPKPMFALPHA)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC910", Offset = "0x1FEAF10", VA = "0x181FEC910")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OODEGFFALHH(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? IMNDIBKHHLA, int? JPKPMFALPHA)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FECD20", Offset = "0x1FEB320", VA = "0x181FECD20")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> PIFGFPMHBHF(this PGOBKAMEOBJ ELMHNMGFNPC, int? JPKPMFALPHA, int EBDMAJMOJLN)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC4B0", Offset = "0x1FEAAB0", VA = "0x181FEC4B0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NCMNMFFBPAO(this PGOBKAMEOBJ ELMHNMGFNPC, int? JPKPMFALPHA)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC550", Offset = "0x1FEAB50", VA = "0x181FEC550")]
	public static void NGAGAMDHBOD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI, EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> JGLOGFJNIBO, int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBB00", Offset = "0x1FEA100", VA = "0x181FEBB00")]
	public static void HOEKNJJFMGB(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI, int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBCC0", Offset = "0x1FEA2C0", VA = "0x181FEBCC0")]
	public static void IMHEAPAHMEA(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBC30", Offset = "0x1FEA230", VA = "0x181FEBC30")]
	public static void IKDOGNEOEGH(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> MNAGKONPJOO, EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> AHGMAMNAAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FEB680", Offset = "0x1FE9C80", VA = "0x181FEB680")]
	public static void FLHBMBAACNN(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI, EJDMOINMPCI<ECJCCLAGCON<EOLLBFFJMFO>> ANMJOFEAGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B58FA0", Offset = "0x2B575A0", VA = "0x182B58FA0")]
	public static void FCOGNGGBPCN<M>(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LPHJEJJLCEI, EJDMOINMPCI<ECJCCLAGCON<KHLBCHFOACL<M>>> ANMJOFEAGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HGDKEKDCOJC<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJDMOINMPCI<EJLGKGMKJHL> PGHHJNABFHJ(TStateSys PMCDBPBJKDB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJDMOINMPCI<EJLGKGMKJHL> OBFKIMOEHBM(TStateSys PMCDBPBJKDB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJDMOINMPCI<EJLGKGMKJHL> MPFNEHGGNEL(TStateSys PMCDBPBJKDB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJDMOINMPCI<EJLGKGMKJHL> JDJJCEPHPJH(TStateSys PMCDBPBJKDB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> IDBFKENHAOG(TStateSys PMCDBPBJKDB, PGOBKAMEOBJ LLCILPEHNOH, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> PLGKPPHKEBD(TStateSys PMCDBPBJKDB, PGOBKAMEOBJ LLCILPEHNOH, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PCJALLCOFNN(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EJDMOINMPCI<FNFFOGDJCBH> PCCNNFGIDMC(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE, int KBEACEHLJAH);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CEPFALINOAO OPILNJPECOE(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NALOHCNODFB(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CLILAAJLDKA(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GNKFFOEHDOA<byte> NCBLLAFJLAI(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(GNKFFOEHDOA<byte>, EJDMOINMPCI<EJLGKGMKJHL>) JFHDMIEKBMK(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JFCBAONMOOK(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EJDMOINMPCI<JFGPEANAFFG> MAIFMIMMCHH(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC, int JCOCDKDILMK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EJDMOINMPCI<JFGPEANAFFG> ADFJNBNOLCD(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int JCOCDKDILMK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int ABMOOPLLMIK(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? ILKHNCBAAFL(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, int EBDMAJMOJLN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int IKNNKIDHGGI(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? OGFCCKOMLJG(TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, int EBDMAJMOJLN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LMMNPMJHDMH
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A8C0", Offset = "0x2C18EC0", VA = "0x182C1A8C0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC?> JOLCHHILOGD<T, TOpInput, TOpOutput>(this PGOBKAMEOBJ ELMHNMGFNPC, T MIGBCLGIEPA, T MMACHIKDDMH, int HLIKPNJFDLA, IntPtr JNGNKNMOMFL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B840", Offset = "0x2C19E40", VA = "0x182C1B840")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC?> MKNMEDOPNEM<T, TOpInput, TOpOutput>(this PGOBKAMEOBJ ELMHNMGFNPC, T MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH, int HLIKPNJFDLA, IntPtr JNGNKNMOMFL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C195B0", Offset = "0x2C17BB0", VA = "0x182C195B0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC?> DAMHOPPBOMA<TOpInput, TOpOutput>(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH, int HLIKPNJFDLA, IntPtr JNGNKNMOMFL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2D90", Offset = "0x1FF1390", VA = "0x181FF2D90")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> PHIOOECKHKG(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2C70", Offset = "0x1FF1270", VA = "0x181FF2C70")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> PCIEMMBJAHP(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE0F0", Offset = "0x1FEC6F0", VA = "0x181FEE0F0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BODDFPJNLKP(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0C70", Offset = "0x1FEF270", VA = "0x181FF0C70")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KHPADEGPGGD(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2B50", Offset = "0x1FF1150", VA = "0x181FF2B50")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> PCFOLHOPPEL(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFD30", Offset = "0x1FEE330", VA = "0x181FEFD30")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> HNDEOAFMIFG(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1B30", Offset = "0x1FF0130", VA = "0x181FF1B30")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NEGNCNKBFPJ(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FF02E0", Offset = "0x1FEE8E0", VA = "0x181FF02E0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> INAEJHKDELE(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FF01A0", Offset = "0x1FEE7A0", VA = "0x181FF01A0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> IDOIDJFFDNN(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0830", Offset = "0x1FEEE30", VA = "0x181FF0830")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JLIGEOGBFII(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, int MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF5D0", Offset = "0x1FEDBD0", VA = "0x181FEF5D0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GIBBBBMBBOF(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FEECF0", Offset = "0x1FED2F0", VA = "0x181FEECF0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> EJOEDGHLDDE(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0D60", Offset = "0x1FEF360", VA = "0x181FF0D60")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KLJDEKBKPGG(this PGOBKAMEOBJ ELMHNMGFNPC, float MIGBCLGIEPA, float MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2830", Offset = "0x1FF0E30", VA = "0x181FF2830")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OJNKCNLFEHM(this PGOBKAMEOBJ ELMHNMGFNPC, float MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF1E0", Offset = "0x1FED7E0", VA = "0x181FEF1E0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FONBOGJACHN(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FF05C0", Offset = "0x1FEEBC0", VA = "0x181FF05C0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JGFMJDENPDC(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, int MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0640", Offset = "0x1FEEC40", VA = "0x181FF0640")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JJBKIFKMEOM(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FF10C0", Offset = "0x1FEF6C0", VA = "0x181FF10C0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LFLPONMIKBJ(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FF06C0", Offset = "0x1FEECC0", VA = "0x181FF06C0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JKHFBAPGMNJ(this PGOBKAMEOBJ ELMHNMGFNPC, float MIGBCLGIEPA, float MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3190", Offset = "0x1FF1790", VA = "0x181FF3190")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> PKDKOGHMOBK(this PGOBKAMEOBJ ELMHNMGFNPC, float MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF420", Offset = "0x1FEDA20", VA = "0x181FEF420")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GEOBPOLPJKA(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDF80", Offset = "0x1FEC580", VA = "0x181FEDF80")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BAOCBMPMPIA(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, int MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE710", Offset = "0x1FECD10", VA = "0x181FEE710")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> CCPKPENIOEB(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFF10", Offset = "0x1FEE510", VA = "0x181FEFF10")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> HPOEPMGICHB(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1AB0", Offset = "0x1FF00B0", VA = "0x181FF1AB0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NEGMLFMNBGF(this PGOBKAMEOBJ ELMHNMGFNPC, float MIGBCLGIEPA, float MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0B30", Offset = "0x1FEF130", VA = "0x181FF0B30")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KAEFCPEHCJL(this PGOBKAMEOBJ ELMHNMGFNPC, float MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE230", Offset = "0x1FEC830", VA = "0x181FEE230")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BODKPPCJNGD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FF17E0", Offset = "0x1FEFDE0", VA = "0x181FF17E0")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> NDENJEMBJED(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFE70", Offset = "0x1FEE470", VA = "0x181FEFE70")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> HNIOALLPIOC(this PGOBKAMEOBJ ELMHNMGFNPC, int FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2AA0", Offset = "0x1FF10A0", VA = "0x181FF2AA0")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> PAHKJAGJJMH(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFB80", Offset = "0x1FEE180", VA = "0x181FEFB80")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> HGBCJFAHNFM(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> AJPILFHKKGL)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE890", Offset = "0x1FECE90", VA = "0x181FEE890")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> DADLGHLIFBN(this PGOBKAMEOBJ ELMHNMGFNPC, int FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEC50", Offset = "0x1FED250", VA = "0x181FEEC50")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> EGBHALCPOFD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE2B0", Offset = "0x1FEC8B0", VA = "0x181FEE2B0")]
	public static (EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>) CAAAFBBGPMO(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<LDEGJPGOKID> KFCDLNPFEBI, [In] ReadOnlySpan<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> PLJOOCONEHF, [In] ReadOnlySpan<int?> MILEAHIGICE, [In] Span<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> DDPFAGCAEIF)
	{
		return default((EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1140", Offset = "0x1FEF740", VA = "0x181FF1140")]
	public static (EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>) LMMNCEBIOHG(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<OCJIFINKLKP> CJOAHGCKKDK, [In] ReadOnlySpan<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> PLJOOCONEHF, [In] ReadOnlySpan<int?> MILEAHIGICE, [In] Span<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> DDPFAGCAEIF)
	{
		return default((EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BBE0", Offset = "0x2C1A1E0", VA = "0x182C1BBE0")]
	public static (EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<EJLGKGMKJHL>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<TMarker>>, EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>) NGANCMNLMIJ<TMarker>(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<EJLGKGMKJHL> JIMEECOFIIH, [In] ReadOnlySpan<byte> JHLEMCFOEMF)
	{
		return default((EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<ECJCCLAGCON<EJLGKGMKJHL>>, EJDMOINMPCI<ECJCCLAGCON<IMGOAHLFMAJ>>, EJDMOINMPCI<ECJCCLAGCON<TMarker>>, EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0BB0", Offset = "0x1FEF1B0", VA = "0x181FF0BB0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KDNMBLGLAPC(this PGOBKAMEOBJ ELMHNMGFNPC, int ANJCAANKHOF, [Optional] EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEFF0", Offset = "0x1FED5F0", VA = "0x181FEEFF0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FIBNFLMLNFA(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> ANJCAANKHOF, [Optional] EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE000", Offset = "0x1FEC600", VA = "0x181FEE000")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BNAODIMLNEM(this PGOBKAMEOBJ ELMHNMGFNPC, [In] ReadOnlySpan<byte> ANJCAANKHOF, [Optional] EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEA30", Offset = "0x1FED030", VA = "0x181FEEA30")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> DIMPNHMIGEI(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> ANJCAANKHOF, int PPOFLGDKIBE, [Optional] EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE790", Offset = "0x1FECD90", VA = "0x181FEE790")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> CHCFJJGCNIG(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF830", Offset = "0x1FEDE30", VA = "0x181FEF830")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GLDGFOAGAKF(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0E60", Offset = "0x1FEF460", VA = "0x181FF0E60")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KOFMDLFCEJO(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FF15B0", Offset = "0x1FEFBB0", VA = "0x181FF15B0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MOAFFEAIEAM(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1990", Offset = "0x1FEFF90", VA = "0x181FF1990")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NDNIJNLNNDC(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEEB0", Offset = "0x1FED4B0", VA = "0x181FEEEB0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FEFBIIDKGHJ(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEE30", Offset = "0x1FED430", VA = "0x181FEEE30")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> EKJIAJGBMHM(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, int MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1D40", Offset = "0x1FF0340", VA = "0x181FF1D40")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NKAPAEIGKKH(this PGOBKAMEOBJ ELMHNMGFNPC, int MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0540", Offset = "0x1FEEB40", VA = "0x181FF0540")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JBMIPCKLNAN(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MIGBCLGIEPA, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MMACHIKDDMH)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF0E0", Offset = "0x1FED6E0", VA = "0x181FEF0E0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FLEICDIIBDL(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2040", Offset = "0x1FF0640", VA = "0x181FF2040")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OAFOJIADLII(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1F00", Offset = "0x1FF0500", VA = "0x181FF1F00")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NLMDPFHKIHA(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FF00B0", Offset = "0x1FEE6B0", VA = "0x181FF00B0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> IBJNIOFFHML(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE910", Offset = "0x1FECF10", VA = "0x181FEE910")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> DHFPILLHNGC(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2960", Offset = "0x1FF0F60", VA = "0x181FF2960")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OMJMHDKLGKD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFEF0", Offset = "0x1FEE4F0", VA = "0x181FEFEF0")]
	public static EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>> HOAOLFBPEEN(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
		return default(EJDMOINMPCI<ECJCCLAGCON<ECJCCLAGCON<CGILJFKPHAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2280", Offset = "0x1FF0880", VA = "0x181FF2280")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OCFJFOFBKPJ(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0FA0", Offset = "0x1FEF5A0", VA = "0x181FF0FA0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> LCGMIDBECDN(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1DC0", Offset = "0x1FF03C0", VA = "0x181FF1DC0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NKJDKJKJJJD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0920", Offset = "0x1FEEF20", VA = "0x181FF0920")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JLMGCNDEEKI(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FF1C20", Offset = "0x1FF0220", VA = "0x181FF1C20")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> NJJHFODHHAL(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF6F0", Offset = "0x1FEDCF0", VA = "0x181FEF6F0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GIOGPGHHPAD(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF320", Offset = "0x1FED920", VA = "0x181FEF320")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GEFFCKJHMBD(this PGOBKAMEOBJ ELMHNMGFNPC, int FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2170", Offset = "0x1FF0770", VA = "0x181FF2170")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OBOAIPNBFGC(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> FEBGGALLBNN)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2B40", Offset = "0x1FF1140", VA = "0x181FF2B40")]
	public static void PBGLMFHPOLP(this PGOBKAMEOBJ ELMHNMGFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEB50", Offset = "0x1FED150", VA = "0x181FEEB50")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> EEPEOLCHBDN(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, float GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0A10", Offset = "0x1FEF010", VA = "0x181FF0A10")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> KACBEAGPJMO(this PGOBKAMEOBJ ELMHNMGFNPC, float BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFA40", Offset = "0x1FEE040", VA = "0x181FEFA40")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GOIAFEPBFEJ(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF950", Offset = "0x1FEDF50", VA = "0x181FEF950")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GLICPNPIFBL(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2380", Offset = "0x1FF0980", VA = "0x181FF2380")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OGJKHHCBJKM(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0400", Offset = "0x1FEEA00", VA = "0x181FF0400")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JBIBKKKBKKN(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FF24A0", Offset = "0x1FF0AA0", VA = "0x181FF24A0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> OIFOFCIMIDG(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> LMNKALPMIGD, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> JGCEGDDGMGL)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0740", Offset = "0x1FEED40", VA = "0x181FF0740")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> JLIFPFDPEEC(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, int GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFF90", Offset = "0x1FEE590", VA = "0x181FEFF90")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> IBEMNHMENJE(this PGOBKAMEOBJ ELMHNMGFNPC, int BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1FF16A0", Offset = "0x1FEFCA0", VA = "0x181FF16A0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> MOALBLBOOMK(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> BHGMPFJEBGJ, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> GBHHIJKPLIB)
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2C18D80", Offset = "0x2C17380", VA = "0x182C18D80")]
	public static void BLACHLGGCCE<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<LDEGJPGOKID> KFCDLNPFEBI, [In] ReadOnlySpan<EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>> OJKBEDNNMOO, [In] ReadOnlySpan<int?> MILEAHIGICE, [In] Span<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> DDPFAGCAEIF, [In] Span<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> PAJIPKAOMII, [In] ReadOnlySpan<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>?> HANIJOLIKFK) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2C19F30", Offset = "0x2C18530", VA = "0x182C19F30")]
	public static void HLAMHBMCPCH<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<OCJIFINKLKP> MMBIFBKCHGP, [In] ReadOnlySpan<EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>> PDBDGEJCMOO, [In] ReadOnlySpan<int?> MILEAHIGICE, [In] Span<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> DDPFAGCAEIF, [In] Span<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>> PAJIPKAOMII, [In] ReadOnlySpan<EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>?> HANIJOLIKFK) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A4D0", Offset = "0x2C18AD0", VA = "0x182C1A4D0")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> ILIEPBLCPPP<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> IMNDIBKHHLA, [Optional] EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2C19720", Offset = "0x2C17D20", VA = "0x182C19720")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> DNOIKHLIGAK<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> EAHGOCJPBJM, [Optional] EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ABC0", Offset = "0x2C191C0", VA = "0x182C1ABC0")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> LIJFGDKCILK<TDeps, TStateSys>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB) where TDeps : notnull, HGDKEKDCOJC<TStateSys> where TStateSys : notnull
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A6B0", Offset = "0x2C18CB0", VA = "0x182C1A6B0")]
	public static EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD> JJOEEOCEEAL<TDeps, TStateSys>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB) where TDeps : notnull, HGDKEKDCOJC<TStateSys> where TStateSys : notnull
	{
		return default(EJDMOINMPCI<ODMDGLFBLMB.IJAGEEAKECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF4A0", Offset = "0x1FEDAA0", VA = "0x181FEF4A0")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> GHJKDJAIANG(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> DGHJLJHNHLK, IntPtr LEEOHGMBFMC, IntPtr LPFLMHPHIDL)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2E90", Offset = "0x1FF1490", VA = "0x181FF2E90")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> PJOJCBDMNIH(this PGOBKAMEOBJ ELMHNMGFNPC, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> KKHDLIFHPNB, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> FMEGNJNMPJK, IntPtr LBNJAGCFPPN, IntPtr CMCIFMDAHPK, IntPtr JLIONECDBAP, bool HKCIBBDGDHI)
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ADF0", Offset = "0x2C193F0", VA = "0x182C1ADF0")]
	public static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> MGNGAEAILMM<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<LDEGJPGOKID> IDNACCJDIGG, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> KKHDLIFHPNB, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> FMEGNJNMPJK, int? JDIJIPPHECF, [Optional] IntPtr HCCBKALEPCL) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B000", Offset = "0x2C19600", VA = "0x182C1B000")]
	private static EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> MGNGAEAILMM<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<LDEGJPGOKID> IDNACCJDIGG, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> KKHDLIFHPNB, EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD> FMEGNJNMPJK, int? JDIJIPPHECF) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
		return default(EJDMOINMPCI<GJCGNJOFCOL.KEPFFNDIKJD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2C19B80", Offset = "0x2C18180", VA = "0x182C19B80")]
	public static EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> EIEKOBABGFL<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC> ANJCAANKHOF, EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>? NLDMHMGCOCL) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
		return default(EJDMOINMPCI<MIGMEAFIBNC.MNPNFHJMBBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2C19320", Offset = "0x2C17920", VA = "0x182C19320")]
	public static void CHJFEEOLHKL<TDeps, TState>(this PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TState HJBEGIDNCHF, int FCKNNAMGDJH) where TDeps : notnull, HGDKEKDCOJC<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct HMJMCMPKELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> CGJBJBKGIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> LNHIHCENNEI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
	public HMJMCMPKELH(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> KJOCCFIODAH, EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> FEAEFCFLBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1FED230", Offset = "0x1FEB830", VA = "0x181FED230")]
	public static HMJMCMPKELH NKOJKFHACJH(EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>> KJOCCFIODAH)
	{
		return default(HMJMCMPKELH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct MIGMEAFIBNC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AMBAONGIDMC : MBNEJJEHCNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FEFCGFHKFGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> KKBIFEHGMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JPOHIBGABMB;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		public FEFCGFHKFGK(EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> JGLOGFJNIBO, int EBDMAJMOJLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class IIOACHOIOIK : MBNEJJEHCNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct CECJIOACCAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JPOHIBGABMB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public CECJIOACCAA(int EBDMAJMOJLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CHJBMKLMAEM : MBNEJJEHCNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct LBAEBEFHNKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> KKBIFEHGMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int JPOHIBGABMB;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
		public LBAEBEFHNKH(EJDMOINMPCI<KMIJKCJOPKC.AOAJBGPJFDJ> JGLOGFJNIBO, int EBDMAJMOJLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum LKCJOOGMFOL
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
	public sealed class MNPNFHJMBBC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class MBNEJJEHCNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct EIBFCEDGJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? PDCIFCDODDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HMJMCMPKELH MFICHIPIGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LKCJOOGMFOL LPNFAOFKOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EJDMOINMPCI<MBNEJJEHCNC> KKEHLKIBEIG;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA530", Offset = "0x1FE8B30", VA = "0x181FEA530")]
		public EIBFCEDGJLP(int? JPKPMFALPHA, [In] HMJMCMPKELH MAGFIHNLHFM, LKCJOOGMFOL KPKLBGOCIPG, EJDMOINMPCI<MBNEJJEHCNC> KENHJMBPDMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LCMODEKIINE : MBNEJJEHCNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HPHLCPNJIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int JPOHIBGABMB;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		public HPHLCPNJIJF(int EBDMAJMOJLN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal GBNNPJHJDEM<MNPNFHJMBBC, EIBFCEDGJLP> PHIPEPEMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal GBNNPJHJDEM<AMBAONGIDMC, FEFCGFHKFGK> JHEADLOEMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal GBNNPJHJDEM<CHJBMKLMAEM, LBAEBEFHNKH> KGNAGALPLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal GBNNPJHJDEM<LCMODEKIINE, HPHLCPNJIJF> ONEKOGLOENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal GBNNPJHJDEM<IIOACHOIOIK, CECJIOACCAA> IGKMICEKLNF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3400", Offset = "0x1FF1A00", VA = "0x181FF3400")]
	private MIGMEAFIBNC([In] GBNNPJHJDEM<MNPNFHJMBBC, EIBFCEDGJLP> BBOMNGCDCAM, [In] GBNNPJHJDEM<AMBAONGIDMC, FEFCGFHKFGK> JPFGMMIINGH, [In] GBNNPJHJDEM<CHJBMKLMAEM, LBAEBEFHNKH> LDJFGAMAHGA, [In] GBNNPJHJDEM<LCMODEKIINE, HPHLCPNJIJF> FBAKFKNCNIO, [In] GBNNPJHJDEM<IIOACHOIOIK, CECJIOACCAA> KLJHJLOKJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3210", Offset = "0x1FF1810", VA = "0x181FF3210")]
	public static MIGMEAFIBNC NKOJKFHACJH()
	{
		return default(MIGMEAFIBNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class KGHDECIHFIM
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FED960", Offset = "0x1FEBF60", VA = "0x181FED960")]
	public static void AMMOOILDICF(this MIGMEAFIBNC ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AHKNKAACHAH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9FE0", Offset = "0x1FE85E0", VA = "0x181FE9FE0")]
	public static void NGPKEBHLPHO(PGOBKAMEOBJ ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct FMMELPFOFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, IPJMFACOGEI> PNONNJMCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int OFPMJHDFGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int DAKPAPGGDCL;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1FED010", Offset = "0x1FEB610", VA = "0x181FED010")]
	private FMMELPFOFEM([In] JMJAGLIJMHJ<KMIJKCJOPKC.NHIDKPKDFCM, IPJMFACOGEI> JGOPHJJGNLF, int NLFMDLJBEPK, int JFJHAHEIMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1FECFA0", Offset = "0x1FEB5A0", VA = "0x181FECFA0")]
	public static FMMELPFOFEM NKOJKFHACJH()
	{
		return default(FMMELPFOFEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FECDB0", Offset = "0x1FEB3B0", VA = "0x181FECDB0")]
	public void AMMOOILDICF([In] PGOBKAMEOBJ AMHGNLFEGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2B59C70", Offset = "0x2B58270", VA = "0x182B59C70")]
	public static void NGPKEBHLPHO<TDeps, TStateSys>(PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA) where TDeps : notnull, HGDKEKDCOJC<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JEJEIMPBKKJ
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1FED4A0", Offset = "0x1FEBAA0", VA = "0x181FED4A0")]
	public static void NGPKEBHLPHO(PGOBKAMEOBJ ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct OOAJHEAOBHN
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface NAGBBBOEECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JAOEDFHKGOK(CDJBEBBGDPF<byte> OJFJIONAKBB, int JJDNFKEDHAJ);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct DADNBMEHFJE : NAGBBBOEECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA180", Offset = "0x1FE8780", VA = "0x181FEA180", Slot = "4")]
		public void JAOEDFHKGOK(CDJBEBBGDPF<byte> OJFJIONAKBB, int JJDNFKEDHAJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct KBGGOCLEPLJ : NAGBBBOEECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1FED8B0", Offset = "0x1FEBEB0", VA = "0x181FED8B0", Slot = "4")]
		public void JAOEDFHKGOK(CDJBEBBGDPF<byte> OJFJIONAKBB, int JJDNFKEDHAJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct NDKFFPPFKMG : NAGBBBOEECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3A90", Offset = "0x1FF2090", VA = "0x181FF3A90", Slot = "4")]
		public void JAOEDFHKGOK(CDJBEBBGDPF<byte> OJFJIONAKBB, int JJDNFKEDHAJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct DDMGPPNMLIP : NAGBBBOEECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA200", Offset = "0x1FE8800", VA = "0x181FEA200", Slot = "4")]
		public void JAOEDFHKGOK(CDJBEBBGDPF<byte> OJFJIONAKBB, int JJDNFKEDHAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class DFEDGEJNLDK<TCallProcessorDeps> where TCallProcessorDeps : struct, NAGBBBOEECB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps JLNBNFBMIEP;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x274CFD0", Offset = "0x274B5D0", VA = "0x18274CFD0")]
		public static int NGPKEBHLPHO<TDeps, TStateSys>(TDeps MEELJJGMLGH, TStateSys HJBEGIDNCHF, PGOBKAMEOBJ AMHGNLFEGOH, [In] CDJBEBBGDPF<byte> FIMMHAKFIPI, int DOLBEAPCCEC) where TDeps : HGDKEKDCOJC<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private CDJBEBBGDPF<KBANDOMCGKC> ICPDDCPPOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>> IMCANOEAMNI;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4240", Offset = "0x1FF2840", VA = "0x181FF4240")]
	private OOAJHEAOBHN([In] CDJBEBBGDPF<KBANDOMCGKC> JMAKDAONPHP, Dictionary<EJDMOINMPCI<ECJCCLAGCON<CGILJFKPHAP>>, EJDMOINMPCI<KMIJKCJOPKC.NHIDKPKDFCM>> NDJPPNMHJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4180", Offset = "0x1FF2780", VA = "0x181FF4180")]
	public static OOAJHEAOBHN NKOJKFHACJH()
	{
		return default(OOAJHEAOBHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1FF4140", Offset = "0x1FF2740", VA = "0x181FF4140")]
	public void AMMOOILDICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2CF12F0", Offset = "0x2CEF8F0", VA = "0x182CF12F0")]
	public static void NGPKEBHLPHO<TDeps, TStateSys>(PGOBKAMEOBJ ELMHNMGFNPC, TDeps MEELJJGMLGH, TStateSys PMCDBPBJKDB) where TDeps : HGDKEKDCOJC<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HKHGMCCMDOA<TDeps, TIndex, TValues> where TDeps : struct, CPPMCFNGAPL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps JLNBNFBMIEP;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3D4CE00", Offset = "0x3D4B400", VA = "0x183D4CE00")]
	public static void NGPKEBHLPHO([In] CDJBEBBGDPF<KBANDOMCGKC> JMAKDAONPHP, int NFIPMKOJLPK, TValues EGCOBBLGNBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CPPMCFNGAPL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDJBEBBGDPF<TIndex> ENDOGDMKOPJ(int NFIPMKOJLPK, [In] TValues EGCOBBLGNBO);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(TIndex EBDMAJMOJLN, [In] TValues EGCOBBLGNBO);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFBOGJHDHAA(TIndex EBDMAJMOJLN, TValues EGCOBBLGNBO, EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> FEBGGALLBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LJEEJMENIBC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex JIHEHBMNNIO(int EBDMAJMOJLN);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDJLJNPLPIG(TIndex EBDMAJMOJLN, [In] TValues EGCOBBLGNBO);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EJDMOINMPCI<ECJCCLAGCON<LHPDJMBFANM>> KGBDMKOENNC(TIndex EBDMAJMOJLN, [In] TValues EGCOBBLGNBO);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PKDDBCBJCOO<TDeps, TIndex, TValues> where TDeps : struct, LJEEJMENIBC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps JLNBNFBMIEP;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x481EA80", Offset = "0x481D080", VA = "0x18481EA80")]
	public static CDJBEBBGDPF<TIndex> NGPKEBHLPHO(int NFIPMKOJLPK, [In] TValues EGCOBBLGNBO)
	{
		return default(CDJBEBBGDPF<TIndex>);
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
