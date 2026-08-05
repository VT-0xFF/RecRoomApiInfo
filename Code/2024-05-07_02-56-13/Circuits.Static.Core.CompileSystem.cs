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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E58810", Offset = "0x1E57A10", VA = "0x181E58810")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct FJMFOBEAGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> KLAABHDFGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int OIGLMMJODMM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
	public FJMFOBEAGPO(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> JPLLMLDHNHB, int BJPGLMJPACN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BIAOCJCLOPL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EIBNJBCOBOF : JJIJCEDONIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct OPACOLCIGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly NNPMDHNJLOE<byte> MNKEOMKCPFL;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C420", Offset = "0x1E0B620", VA = "0x181E0C420")]
		public OPACOLCIGHP(NNPMDHNJLOE<byte> CGAHJPHALBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E58B80", Offset = "0x1E57D80", VA = "0x181E58B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class FAHKAIIDHCI : JJIJCEDONIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct HCEINPLKPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> IMAMFIJALCB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public HCEINPLKPJN(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> BEFJCGBGCEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LHJGIMBAAKD
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
	public sealed class EDLDMPEAOJK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class JJIJCEDONIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FNPHFBJABLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly LHJGIMBAAKD GBNIMFHPKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly EIPPGFCFCGI<JJIJCEDONIF> LBMHKGDJANP;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
		public FNPHFBJABLJ(LHJGIMBAAKD KMOFMIONHJP, EIPPGFCFCGI<JJIJCEDONIF> KKBFHIGBHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class GLNHDAEJPJH : JJIJCEDONIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct BGHHKNIAOOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GCIPEOIHBGL;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public BGHHKNIAOOD(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class IKOPFPCFEBD : JJIJCEDONIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct DNMPLBPACJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly JGPKAMILINE DECCPNNHLPI;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public DNMPLBPACJJ(JGPKAMILINE IOCEOAMEMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E54670", Offset = "0x1E53870", VA = "0x181E54670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal HKKIKIBKLHP<EDLDMPEAOJK, FNPHFBJABLJ> KJBLAFCFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal HKKIKIBKLHP<EIBNJBCOBOF, OPACOLCIGHP> FCCKLLIDKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal HKKIKIBKLHP<FAHKAIIDHCI, HCEINPLKPJN> LEMLIPFGMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HKKIKIBKLHP<GLNHDAEJPJH, BGHHKNIAOOD> NLIAGIJADEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal HKKIKIBKLHP<IKOPFPCFEBD, DNMPLBPACJJ> CDFHFEMEOKO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E600", Offset = "0x1E4D800", VA = "0x181E4E600")]
	private BIAOCJCLOPL([In] HKKIKIBKLHP<EDLDMPEAOJK, FNPHFBJABLJ> NJAJEKGJAFM, [In] HKKIKIBKLHP<EIBNJBCOBOF, OPACOLCIGHP> IPFPLIPEGGE, [In] HKKIKIBKLHP<FAHKAIIDHCI, HCEINPLKPJN> KLKMKLGNCNG, [In] HKKIKIBKLHP<GLNHDAEJPJH, BGHHKNIAOOD> IMJPMONMAAC, [In] HKKIKIBKLHP<IKOPFPCFEBD, DNMPLBPACJJ> DDDOFNMCKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E4C0", Offset = "0x1E4D6C0", VA = "0x181E4E4C0")]
	public static BIAOCJCLOPL MIJABIECKKD()
	{
		return default(BIAOCJCLOPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PEGKNICNBPG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E58DF0", Offset = "0x1E57FF0", VA = "0x181E58DF0")]
	public static void HDPILJBHDHI(this BIAOCJCLOPL KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum JLCAPFGBKIG
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
public struct HBEMBDIONIN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class MPMEHHPBIGK : JHGFJKNMJDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct AEOEEFDHJIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> EJPKDNHCNKF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public AEOEEFDHJIO(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> ADHLHICPMAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HJHPBBMFAAL
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
	public sealed class BNOPPKDOGLM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class JHGFJKNMJDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct FJJLPCBHKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HJHPBBMFAAL GBNIMFHPKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly EIPPGFCFCGI<JHGFJKNMJDC> LBMHKGDJANP;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
		public FJJLPCBHKOO(HJHPBBMFAAL KMOFMIONHJP, EIPPGFCFCGI<JHGFJKNMJDC> KKBFHIGBHLL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HKKIKIBKLHP<BNOPPKDOGLM, FJJLPCBHKOO> KJBLAFCFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HKKIKIBKLHP<MPMEHHPBIGK, AEOEEFDHJIO> JPPIBNKDFFC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E480", Offset = "0x1E4D680", VA = "0x181E4E480")]
	private HBEMBDIONIN([In] HKKIKIBKLHP<BNOPPKDOGLM, FJJLPCBHKOO> NJAJEKGJAFM, [In] HKKIKIBKLHP<MPMEHHPBIGK, AEOEEFDHJIO> MOOAIMAEGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E54D80", Offset = "0x1E53F80", VA = "0x181E54D80")]
	public static HBEMBDIONIN MIJABIECKKD()
	{
		return default(HBEMBDIONIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OILIPGBMGOK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E58890", Offset = "0x1E57A90", VA = "0x181E58890")]
	public static void HDPILJBHDHI(this HBEMBDIONIN KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KIAFALDBCPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public FNBPBCOGKJO<int> CAAEEEOCKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public FNBPBCOGKJO<int> CLFHNAKCBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NLLFBBKMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int NMAPPDEAGMI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E55670", Offset = "0x1E54870", VA = "0x181E55670")]
	private KIAFALDBCPC([In] FNBPBCOGKJO<int> LFAGKGNGKFN, [In] FNBPBCOGKJO<int> PBIPFDFDEGL, int HEACPMABKCF, int HNMOFNCMHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E555D0", Offset = "0x1E547D0", VA = "0x181E555D0")]
	public static KIAFALDBCPC MIJABIECKKD()
	{
		return default(KIAFALDBCPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AMDFPHKPHLL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E300", Offset = "0x1E4D500", VA = "0x181E4E300")]
	public static void HDPILJBHDHI(this KIAFALDBCPC KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JJIMANJGJFE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum HOAFPJNMIEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ALDEPNPMGOL : PKNNFCOMHBJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct OHAABAGHPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly EIPPGFCFCGI<PCBDNHOEENB> KHBEJJOENID;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public OHAABAGHPIC(EIPPGFCFCGI<PCBDNHOEENB> MLOECGMOBHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class DKBFPGJNCFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class PKNNFCOMHBJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct MGONEFFEMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly HOAFPJNMIEL GBNIMFHPKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly EIPPGFCFCGI<PKNNFCOMHBJ> LBMHKGDJANP;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
		private MGONEFFEMFB(HOAFPJNMIEL KMOFMIONHJP, EIPPGFCFCGI<PKNNFCOMHBJ> KKBFHIGBHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E556F0", Offset = "0x1E548F0", VA = "0x181E556F0")]
		public static MGONEFFEMFB MIJABIECKKD(HOAFPJNMIEL KMOFMIONHJP, EIPPGFCFCGI<PKNNFCOMHBJ> KKBFHIGBHLL)
		{
			return default(MGONEFFEMFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class MFFDHIJPOBG : PKNNFCOMHBJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct GALFJKJGHCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly EIPPGFCFCGI<PCBDNHOEENB> KHBEJJOENID;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public GALFJKJGHCB(EIPPGFCFCGI<PCBDNHOEENB> MLOECGMOBHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class PCBDNHOEENB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct BEJKGNPEKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FNBPBCOGKJO<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> IOEHEPNHDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FNBPBCOGKJO<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> JCPFMGHOCHJ;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E480", Offset = "0x1E4D680", VA = "0x181E4E480")]
		private BEJKGNPEKLF([In] FNBPBCOGKJO<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> NLKIGFDMHGH, [In] FNBPBCOGKJO<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> MEDAHOAMLCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E400", Offset = "0x1E4D600", VA = "0x181E4E400")]
		public static BEJKGNPEKLF MIJABIECKKD()
		{
			return default(BEJKGNPEKLF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal HKKIKIBKLHP<DKBFPGJNCFH, MGONEFFEMFB> KJBLAFCFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal HKKIKIBKLHP<MFFDHIJPOBG, GALFJKJGHCB> JGEGDEKANKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal HKKIKIBKLHP<ALDEPNPMGOL, OHAABAGHPIC> HIEMHLOACOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FNBPBCOGKJO<(EIPPGFCFCGI<DKBFPGJNCFH> CallId, EIPPGFCFCGI<PCBDNHOEENB> IOId)> ODDAHFCMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal HKKIKIBKLHP<PCBDNHOEENB, BEJKGNPEKLF> LMABPAOHMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal FMGHEKECDOM<PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> OHNCEJKODLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal FMGHEKECDOM<PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> PCDNNKOKJGL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E55290", Offset = "0x1E54490", VA = "0x181E55290")]
	private JJIMANJGJFE([In] HKKIKIBKLHP<DKBFPGJNCFH, MGONEFFEMFB> NJAJEKGJAFM, [In] HKKIKIBKLHP<MFFDHIJPOBG, GALFJKJGHCB> BCGHKAFGNPF, [In] HKKIKIBKLHP<ALDEPNPMGOL, OHAABAGHPIC> ENKNMGMMIEH, [In] FNBPBCOGKJO<(EIPPGFCFCGI<DKBFPGJNCFH> CallId, EIPPGFCFCGI<PCBDNHOEENB> IOId)> FMBGOHOMHGB, [In] HKKIKIBKLHP<PCBDNHOEENB, BEJKGNPEKLF> MIMNEANHDKL, [In] FMGHEKECDOM<PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> LCCODBCPMOL, [In] FMGHEKECDOM<PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> GMNOKANNCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E550F0", Offset = "0x1E542F0", VA = "0x181E550F0")]
	public static JJIMANJGJFE MIJABIECKKD()
	{
		return default(JJIMANJGJFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class COEEOJJOJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E54300", Offset = "0x1E53500", VA = "0x181E54300")]
	private static void HDPILJBHDHI(this JJIMANJGJFE.BEJKGNPEKLF KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E540F0", Offset = "0x1E532F0", VA = "0x181E540F0")]
	public static void HDPILJBHDHI(this JJIMANJGJFE KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NCGPOEIFEIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public FNBPBCOGKJO<byte> HJBPJKKEJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal JJIMANJGJFE GAOBEDBLAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CPHCHKEMDON MBBJJMKCLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> IBDMCCJOIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal BIAOCJCLOPL NDPMOLMEJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal HBEMBDIONIN OAMHNNKCFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal FMGHEKECDOM<PAOCCIMMJDB, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>?> PEDNDGNFPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal FNBPBCOGKJO<EIPPGFCFCGI<PAOCCIMMJDB>> PKCHIKMFMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> KOPLOGHCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> OEPOMEFFMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> DFCKKFFLKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal JLMJKPDCHCM HALEIFGGHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal EPEDPJMPDFP HCFIJLEKNPJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E561C0", Offset = "0x1E553C0", VA = "0x181E561C0")]
	private NCGPOEIFEIB([In] FNBPBCOGKJO<byte> EJCMFKOAOLD, [In] JJIMANJGJFE MECLAFIHOEE, [In] CPHCHKEMDON CAMOGOPDCBI, [In] BIAOCJCLOPL EANEGJLAMEO, [In] HBEMBDIONIN NKLCDMHGENK, [In] FMGHEKECDOM<PAOCCIMMJDB, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>?> MCOJNJBNIOP, [In] FNBPBCOGKJO<EIPPGFCFCGI<PAOCCIMMJDB>> KBNFEJHNNGO, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NPAECNHJFKL, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> KEKHGPLIHAP, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> ONGEEONHMNM, [In] JLMJKPDCHCM NFOAPIHPDNF, [In] EPEDPJMPDFP HOAAOMNNBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E55700", Offset = "0x1E54900", VA = "0x181E55700")]
	public static NCGPOEIFEIB MIJABIECKKD()
	{
		return default(NCGPOEIFEIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NMJOBFOFOOM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct IAAJMMAKIPF : LEHICCEODAC<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>, FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E54E90", Offset = "0x1E54090", VA = "0x181E54E90")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E54F10", Offset = "0x1E54110", VA = "0x181E54F10", Slot = "4")]
		public EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> GLDLMGNGLIC(int HMFNCGHECPG)
		{
			return default(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
		public bool MJFHMFOBFDH(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "5")]
		private bool GPFFCEEAGFM(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E54E90", Offset = "0x1E54090", VA = "0x181E54E90", Slot = "6")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> OGCOFPNBEKN(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct CMNEENCOFOE : DNEHMIKOPHE<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>, FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E54000", Offset = "0x1E53200", VA = "0x181E54000")]
		public FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>> AJOCPKMCLDI(int APFMAPIEBAI, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E54070", Offset = "0x1E53270", VA = "0x181E54070")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E53F70", Offset = "0x1E53170", VA = "0x181E53F70", Slot = "6")]
		public void AGHONIKLOEO(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E54000", Offset = "0x1E53200", VA = "0x181E54000", Slot = "4")]
		private FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>> KLMAPEFIONB(int APFMAPIEBAI, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E54070", Offset = "0x1E53270", VA = "0x181E54070", Slot = "5")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> FKBOLPALBDP(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct APBCAIAHFFD : LEHICCEODAC<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>, FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E350", Offset = "0x1E4D550", VA = "0x181E4E350")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E3D0", Offset = "0x1E4D5D0", VA = "0x181E4E3D0", Slot = "4")]
		public EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> GLDLMGNGLIC(int HMFNCGHECPG)
		{
			return default(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
		public bool MJFHMFOBFDH(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "5")]
		private bool CPOFNJGHCLH(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E350", Offset = "0x1E4D550", VA = "0x181E4E350", Slot = "6")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> DBJHEPMBGFI(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct CJCADAPKMGP : DNEHMIKOPHE<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>, FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4EA30", Offset = "0x1E4DC30", VA = "0x181E4EA30")]
		public FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>> AJOCPKMCLDI(int APFMAPIEBAI, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1E4EAA0", Offset = "0x1E4DCA0", VA = "0x181E4EAA0")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E9A0", Offset = "0x1E4DBA0", VA = "0x181E4E9A0", Slot = "6")]
		public void AGHONIKLOEO(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E4EA30", Offset = "0x1E4DC30", VA = "0x181E4EA30", Slot = "4")]
		private FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>> MHALJHKAIHB(int APFMAPIEBAI, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1E4EAA0", Offset = "0x1E4DCA0", VA = "0x181E4EAA0", Slot = "5")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> MJGCFMIMHBE(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> HMFNCGHECPG, [In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct CAOBBKFALHP : LEHICCEODAC<EIPPGFCFCGI<KJNHCLAFOIE>, FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E8C0", Offset = "0x1E4DAC0", VA = "0x181E4E8C0")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E960", Offset = "0x1E4DB60", VA = "0x181E4E960", Slot = "4")]
		public EIPPGFCFCGI<KJNHCLAFOIE> GLDLMGNGLIC(int HMFNCGHECPG)
		{
			return default(EIPPGFCFCGI<KJNHCLAFOIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E860", Offset = "0x1E4DA60", VA = "0x181E4E860")]
		public bool MJFHMFOBFDH(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E860", Offset = "0x1E4DA60", VA = "0x181E4E860", Slot = "5")]
		private bool GBLDEMCGPIB(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E990", Offset = "0x1E4DB90", VA = "0x181E4E990", Slot = "6")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> KLMLPBEEMED(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BJLBFDKDPNN : DNEHMIKOPHE<EIPPGFCFCGI<KJNHCLAFOIE>, FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E740", Offset = "0x1E4D940", VA = "0x181E4E740")]
		public FNBPBCOGKJO<EIPPGFCFCGI<KJNHCLAFOIE>> AJOCPKMCLDI(int APFMAPIEBAI, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<EIPPGFCFCGI<KJNHCLAFOIE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E7C0", Offset = "0x1E4D9C0", VA = "0x181E4E7C0")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E690", Offset = "0x1E4D890", VA = "0x181E4E690", Slot = "6")]
		public void AGHONIKLOEO(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E740", Offset = "0x1E4D940", VA = "0x181E4E740", Slot = "4")]
		private FNBPBCOGKJO<EIPPGFCFCGI<KJNHCLAFOIE>> BNCBDBFHNMH(int APFMAPIEBAI, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<EIPPGFCFCGI<KJNHCLAFOIE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E7B0", Offset = "0x1E4D9B0", VA = "0x181E4E7B0", Slot = "5")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> FKAGHFIMLGH(EIPPGFCFCGI<KJNHCLAFOIE> HMFNCGHECPG, [In] FMGHEKECDOM<KJNHCLAFOIE, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>?> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct EGPMMAINMEJ : LEHICCEODAC<int, FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E548B0", Offset = "0x1E53AB0", VA = "0x181E548B0")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x11FB280", Offset = "0x11FA480", VA = "0x1811FB280", Slot = "4")]
		public int GLDLMGNGLIC(int HMFNCGHECPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
		public bool MJFHMFOBFDH(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "5")]
		private bool BMKKNOEDHIO(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E548A0", Offset = "0x1E53AA0", VA = "0x181E548A0", Slot = "6")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> CILBLDMGKJA(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct FHGAJAHKEGO : DNEHMIKOPHE<int, FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1E54B60", Offset = "0x1E53D60", VA = "0x181E54B60")]
		public FNBPBCOGKJO<int> AJOCPKMCLDI(int APFMAPIEBAI, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E54BE0", Offset = "0x1E53DE0", VA = "0x181E54BE0")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1E54A70", Offset = "0x1E53C70", VA = "0x181E54A70", Slot = "6")]
		public void AGHONIKLOEO(int HMFNCGHECPG, FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E54B60", Offset = "0x1E53D60", VA = "0x181E54B60", Slot = "4")]
		private FNBPBCOGKJO<int> OKPBNJIEIAP(int APFMAPIEBAI, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E54BD0", Offset = "0x1E53DD0", VA = "0x181E54BD0", Slot = "5")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> CBMEBCKIPOJ(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> VariableId, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<LLKKIPNOJAP>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct HLMJFDJMOKO : LEHICCEODAC<int, FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E54E10", Offset = "0x1E54010", VA = "0x181E54E10")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11FB280", Offset = "0x11FA480", VA = "0x1811FB280", Slot = "4")]
		public int GLDLMGNGLIC(int HMFNCGHECPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
		public bool MJFHMFOBFDH(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "5")]
		private bool NNDIHJOJIOI(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1E54E10", Offset = "0x1E54010", VA = "0x181E54E10", Slot = "6")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> CBHONIPMPFJ(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct EAFLEDKNPJB : DNEHMIKOPHE<int, FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1E54770", Offset = "0x1E53970", VA = "0x181E54770")]
		public FNBPBCOGKJO<int> AJOCPKMCLDI(int APFMAPIEBAI, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1E547E0", Offset = "0x1E539E0", VA = "0x181E547E0")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E54690", Offset = "0x1E53890", VA = "0x181E54690", Slot = "6")]
		public void AGHONIKLOEO(int HMFNCGHECPG, FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1E54770", Offset = "0x1E53970", VA = "0x181E54770", Slot = "4")]
		private FNBPBCOGKJO<int> PBEOIKABDOD(int APFMAPIEBAI, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E547E0", Offset = "0x1E539E0", VA = "0x181E547E0", Slot = "5")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> OAOKHKEJKID(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct OLKPMDICLCM : LEHICCEODAC<int, FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E58A60", Offset = "0x1E57C60", VA = "0x181E58A60")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x11FB280", Offset = "0x11FA480", VA = "0x1811FB280", Slot = "4")]
		public int GLDLMGNGLIC(int HMFNCGHECPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
		public bool MJFHMFOBFDH(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "5")]
		private bool NNDIHJOJIOI(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E58A50", Offset = "0x1E57C50", VA = "0x181E58A50", Slot = "6")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> CBHONIPMPFJ(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct PEFMFBKMAPM : DNEHMIKOPHE<int, FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E58CF0", Offset = "0x1E57EF0", VA = "0x181E58CF0")]
		public FNBPBCOGKJO<int> AJOCPKMCLDI(int APFMAPIEBAI, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1E58D60", Offset = "0x1E57F60", VA = "0x181E58D60")]
		public EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E58C00", Offset = "0x1E57E00", VA = "0x181E58C00", Slot = "6")]
		public void AGHONIKLOEO(int HMFNCGHECPG, FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E58CF0", Offset = "0x1E57EF0", VA = "0x181E58CF0", Slot = "4")]
		private FNBPBCOGKJO<int> PBEOIKABDOD(int APFMAPIEBAI, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(FNBPBCOGKJO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E58DE0", Offset = "0x1E57FE0", VA = "0x181E58DE0", Slot = "5")]
		private EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> OAOKHKEJKID(int HMFNCGHECPG, [In] FNBPBCOGKJO<(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> Target, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> ByteCodeWriteLocation)> NGOGJHGFHFE)
		{
			return default(EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LIHMPGOBNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> MDAGALMFOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool AOLKBPPAHEF;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xED5850", Offset = "0xED4A50", VA = "0x180ED5850")]
		public LIHMPGOBNMD(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN, bool IOGIAOMBILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E556E0", Offset = "0x1E548E0", VA = "0x181E556E0")]
		public void NAEOOGIIDLH([Out] EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN, [Out] bool IOGIAOMBILE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct EEOCLBIKHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EIPPGFCFCGI<KJNHCLAFOIE> CFMCHPBPGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> MDAGALMFOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool AOLKBPPAHEF;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E54890", Offset = "0x1E53A90", VA = "0x181E54890")]
		public EEOCLBIKHBG(EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN, bool IOGIAOMBILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E54860", Offset = "0x1E53A60", VA = "0x181E54860")]
		public void NAEOOGIIDLH([Out] EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN, [Out] bool IOGIAOMBILE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E54870", Offset = "0x1E53A70", VA = "0x181E54870")]
		public void NAEOOGIIDLH([Out] EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN, [Out] EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH, [Out] bool IOGIAOMBILE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct KLDKNLDKOPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly EIPPGFCFCGI<KJNHCLAFOIE> CFMCHPBPGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> MDAGALMFOEF;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
		public KLDKNLDKOPO(EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E556D0", Offset = "0x1E548D0", VA = "0x181E556D0")]
		public void NAEOOGIIDLH([Out] EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN, [Out] EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E57300", Offset = "0x1E56500", VA = "0x181E57300")]
	public static void HDPILJBHDHI(this NCGPOEIFEIB KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E56A30", Offset = "0x1E55C30", VA = "0x181E56A30")]
	public static void EAGNKCBANHI(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> DKKGCALLPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E57670", Offset = "0x1E56870", VA = "0x181E57670")]
	public static void HMAEAPFLABB(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> DKKGCALLPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1E56E70", Offset = "0x1E56070", VA = "0x181E56E70")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>? EKJOGPHEMDE([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E575D0", Offset = "0x1E567D0", VA = "0x181E575D0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> HGKLLILDNGL([In] this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E56D10", Offset = "0x1E55F10", VA = "0x181E56D10")]
	private static void EHBNAHEPDJE(this NCGPOEIFEIB KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E56880", Offset = "0x1E55A80", VA = "0x181E56880")]
	private static EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>? DBFKEOBMHFK([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E57C20", Offset = "0x1E56E20", VA = "0x181E57C20")]
	public static void KBAFIAMPPCM(this NCGPOEIFEIB KNKOEEEKHDK, [In] FNBPBCOGKJO<FJMFOBEAGPO> FOGBLBIGAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E57120", Offset = "0x1E56320", VA = "0x181E57120")]
	public static BIAOCJCLOPL.LHJGIMBAAKD GELNFCINOAL([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
	{
		return default(BIAOCJCLOPL.LHJGIMBAAKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E58760", Offset = "0x1E57960", VA = "0x181E58760")]
	public static NNPMDHNJLOE<byte> PKFHBKDJNKJ([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
	{
		return default(NNPMDHNJLOE<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E56F00", Offset = "0x1E56100", VA = "0x181E56F00")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EPEOKBGBBCJ([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E58190", Offset = "0x1E57390", VA = "0x181E58190")]
	public static JGPKAMILINE LDNCFOPMDPJ([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A18040", Offset = "0x2A17240", VA = "0x182A18040")]
	private static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> MDLGIFDICCI<TMJoin>(this NCGPOEIFEIB KNKOEEEKHDK, BIAOCJCLOPL.LHJGIMBAAKD KMOFMIONHJP, EIPPGFCFCGI<TMJoin> KKBFHIGBHLL) where TMJoin : BIAOCJCLOPL.JJIJCEDONIF
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E58390", Offset = "0x1E57590", VA = "0x181E58390")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> NDMIHGIHDCG(this NCGPOEIFEIB KNKOEEEKHDK, bool OPKLDDNNKGH)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E57A40", Offset = "0x1E56C40", VA = "0x181E57A40")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> IMCEIFDPEJM(this NCGPOEIFEIB KNKOEEEKHDK, NNPMDHNJLOE<byte> CGAHJPHALBC)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E56AC0", Offset = "0x1E55CC0", VA = "0x181E56AC0")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> ECCNJFDOODC(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> BEFJCGBGCEB)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E584B0", Offset = "0x1E576B0", VA = "0x181E584B0")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> OLIMCJAPCCF(this NCGPOEIFEIB KNKOEEEKHDK, int ELDHCKMABGJ)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E57010", Offset = "0x1E56210", VA = "0x181E57010")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> FENFAJAMKJF(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A163F0", Offset = "0x2A155F0", VA = "0x182A163F0")]
	private static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> DEDBHFMPNNI<TMJoin>(this NCGPOEIFEIB KNKOEEEKHDK, HBEMBDIONIN.HJHPBBMFAAL KMOFMIONHJP, EIPPGFCFCGI<TMJoin> KKBFHIGBHLL) where TMJoin : HBEMBDIONIN.JHGFJKNMJDC
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1E57FF0", Offset = "0x1E571F0", VA = "0x181E57FF0")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> LAIIHFIPCNG(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E56580", Offset = "0x1E55780", VA = "0x181E56580")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> BDJALDPJBGL(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1E58310", Offset = "0x1E57510", VA = "0x181E58310")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> MAECLFAKEHO(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> ADHLHICPMAC)
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E57630", Offset = "0x1E56830", VA = "0x181E57630")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> HKHFCNDLFMK(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E58240", Offset = "0x1E57440", VA = "0x181E58240")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> LHGIPGCLIDK(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E56520", Offset = "0x1E55720", VA = "0x181E56520")]
	public static JJIMANJGJFE.HOAFPJNMIEL AIHLJNOCHAF([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> KBPAALNBGLJ)
	{
		return default(JJIMANJGJFE.HOAFPJNMIEL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E57740", Offset = "0x1E56940", VA = "0x181E57740")]
	public static KDEJKKKPGJL<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>, KNOBLHEFFHD<JJIMANJGJFE.PCBDNHOEENB>> HNDNBGEPJLF([In] this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(KDEJKKKPGJL<EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>, KNOBLHEFFHD<JJIMANJGJFE.PCBDNHOEENB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E585F0", Offset = "0x1E577F0", VA = "0x181E585F0")]
	public static EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> PGIHIHJMJBN([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> KBPAALNBGLJ)
	{
		return default(EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E569D0", Offset = "0x1E55BD0", VA = "0x181E569D0")]
	public static JJIMANJGJFE.BEJKGNPEKLF DHMNKNNGKJP([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> MLOECGMOBHH)
	{
		return default(JJIMANJGJFE.BEJKGNPEKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E56970", Offset = "0x1E55B70", VA = "0x181E56970")]
	public static JJIMANJGJFE.BEJKGNPEKLF DGJJIECOPDM(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> MLOECGMOBHH)
	{
		return default(JJIMANJGJFE.BEJKGNPEKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A16360", Offset = "0x2A15560", VA = "0x182A16360")]
	private static EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> BNIEPBDGMIM<TMJoin>(this NCGPOEIFEIB KNKOEEEKHDK, JJIMANJGJFE.HOAFPJNMIEL KMOFMIONHJP, EIPPGFCFCGI<TMJoin> KKBFHIGBHLL) where TMJoin : JJIMANJGJFE.PKNNFCOMHBJ
	{
		return default(EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E56B40", Offset = "0x1E55D40", VA = "0x181E56B40")]
	public static (EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>) EFKONHKJALE(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default((EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E565C0", Offset = "0x1E557C0", VA = "0x181E565C0")]
	public static (EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>) CEILCHCNCLC(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default((EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1E58150", Offset = "0x1E57350", VA = "0x181E58150")]
	public static EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> LDKPGHDKCPF(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E57090", Offset = "0x1E56290", VA = "0x181E57090")]
	public static void FKLACBAMDMH(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB> MLOECGMOBHH, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> KOKJHMBDNNM, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>> ICEPNNNBMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A16560", Offset = "0x2A15760", VA = "0x182A16560")]
	public static LIHMPGOBNMD FHIEIOOBCGK<TDeps, TStateSys>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH) where TDeps : IOMIBOIILDG<TStateSys>
	{
		return default(LIHMPGOBNMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A17760", Offset = "0x2A16960", VA = "0x182A17760")]
	public static EEOCLBIKHBG JCGPLCDBKBJ<TDeps, TStateSys>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<FKGCAMGPCBC> EPGOCEDJKAG, int NDBNGFNEMFE) where TDeps : IOMIBOIILDG<TStateSys>
	{
		return default(EEOCLBIKHBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A17340", Offset = "0x2A16540", VA = "0x182A17340")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>? GLGIFDDMLAG<TDeps, TStateSys>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<FKGCAMGPCBC> EPGOCEDJKAG, [In] ReadOnlySpan<int> IEJMMFPBPIA, [In] Span<KLDKNLDKOPO> NDEBCOJNAHB) where TDeps : IOMIBOIILDG<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A17AA0", Offset = "0x2A16CA0", VA = "0x182A17AA0")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> LJKLBIIGOAP<TDeps, TStateSys>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO) where TDeps : IOMIBOIILDG<TStateSys>
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E57D90", Offset = "0x1E56F90", VA = "0x181E57D90")]
	public static CPHCHKEMDON.LKDNOMNFDFP KINLMBINLIM([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNIKIHKLGAD)
	{
		return default(CPHCHKEMDON.LKDNOMNFDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1E57780", Offset = "0x1E56980", VA = "0x181E57780")]
	public static CPHCHKEMDON.MBDEPLDGHAJ HOBHMPOBMFL([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNIKIHKLGAD)
	{
		return default(CPHCHKEMDON.MBDEPLDGHAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E58410", Offset = "0x1E57610", VA = "0x181E58410")]
	public static CPHCHKEMDON.EIBMIHPDDKI ODGCEGKIICG([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNIKIHKLGAD)
	{
		return default(CPHCHKEMDON.EIBMIHPDDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E57E30", Offset = "0x1E57030", VA = "0x181E57E30")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KLCAFFIBIEL(this NCGPOEIFEIB KNKOEEEKHDK, int? ANGIKNKONLI, string IKEFBMMMAJB)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1E57B80", Offset = "0x1E56D80", VA = "0x181E57B80")]
	public static CPHCHKEMDON.JINKOBKGOGJ JNBOEPOEPKJ([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNIKIHKLGAD)
	{
		return default(CPHCHKEMDON.JINKOBKGOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E56FB0", Offset = "0x1E561B0", VA = "0x181E56FB0")]
	public static CPHCHKEMDON.BAIHFDFOLEG FCJOONNAGLP([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNIKIHKLGAD)
	{
		return default(CPHCHKEMDON.BAIHFDFOLEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E56910", Offset = "0x1E55B10", VA = "0x181E56910")]
	public static int? DCLDADEFCFH([In] this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNIKIHKLGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A16480", Offset = "0x2A15680", VA = "0x182A16480")]
	private static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DFBKEBLMCAE<TMJoin>(this NCGPOEIFEIB KNKOEEEKHDK, int? ANGIKNKONLI, CPHCHKEMDON.BAIHFDFOLEG KMOFMIONHJP, EIPPGFCFCGI<TMJoin> KKBFHIGBHLL) where TMJoin : CPHCHKEMDON.GIMDBNDEDBK
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E57AD0", Offset = "0x1E56CD0", VA = "0x181E57AD0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JFPNELEOEBK(this NCGPOEIFEIB KNKOEEEKHDK, int? ANGIKNKONLI, EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> KBPAALNBGLJ, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E57180", Offset = "0x1E56380", VA = "0x181E57180")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GGHPHEMDABL(this NCGPOEIFEIB KNKOEEEKHDK, int? ANGIKNKONLI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E57820", Offset = "0x1E56A20", VA = "0x181E57820")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HODIHACMLFL(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? JFDMCMACBIC, int? ANGIKNKONLI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E58280", Offset = "0x1E57480", VA = "0x181E58280")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LLELKGGFPMJ(this NCGPOEIFEIB KNKOEEEKHDK, int? ANGIKNKONLI, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E572A0", Offset = "0x1E564A0", VA = "0x181E572A0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAIFKEGAMBG(this NCGPOEIFEIB KNKOEEEKHDK, int? ANGIKNKONLI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E58030", Offset = "0x1E57230", VA = "0x181E58030")]
	public static void LAMKIDMAIDC(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO, EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> KBPAALNBGLJ, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E56780", Offset = "0x1E55980", VA = "0x181E56780")]
	public static void CNHDBOAGDFP(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E58530", Offset = "0x1E57730", VA = "0x181E58530")]
	public static void PBJLOGGOMDN(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E579B0", Offset = "0x1E56BB0", VA = "0x181E579B0")]
	public static void IIFLMAGNFKO(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> IOCBLPNBBJM, EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> JBHMEKLNJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E571E0", Offset = "0x1E563E0", VA = "0x181E571E0")]
	public static void GOEMFBAAKPI(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO, EIPPGFCFCGI<LPGDGOFEIPD<KCKOAFPCIJA>> PICGBDNGDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A179E0", Offset = "0x2A16BE0", VA = "0x182A179E0")]
	public static void LHHBGAHAADP<M>(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HKGICONLMLO, EIPPGFCFCGI<LPGDGOFEIPD<DGMFFODHHCI<M>>> PICGBDNGDEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IOMIBOIILDG<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIPPGFCFCGI<KHGPBHCJALI> FHMGJODDICH(TStateSys NINKHNMFJGB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EIPPGFCFCGI<KHGPBHCJALI> PNNOILOAFDF(TStateSys NINKHNMFJGB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EIPPGFCFCGI<KHGPBHCJALI> PKEGEDPBDDM(TStateSys NINKHNMFJGB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EIPPGFCFCGI<KHGPBHCJALI> EIGIADPLMIN(TStateSys NINKHNMFJGB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> MOKEKKABCAO(TStateSys NINKHNMFJGB, NCGPOEIFEIB KKAGEBCELIP, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> DDMGJNMANCN(TStateSys NINKHNMFJGB, NCGPOEIFEIB KKAGEBCELIP, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EHDKJEFBNFL(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EIPPGFCFCGI<PAOCCIMMJDB> PKOHIPEJMKE(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH, int CMJIKJFJHFK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JLCAPFGBKIG FDKMOEHKEPJ(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EONOOFFDPFM(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int NOCPPENBHCH(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NNPMDHNJLOE<byte> NOPEICOPNFL(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(NNPMDHNJLOE<byte>, EIPPGFCFCGI<KHGPBHCJALI>) FNPKHFFGPIN(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<KJNHCLAFOIE> LFBBIJDDIAH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int EKLNMFPGFED(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EIPPGFCFCGI<KJNHCLAFOIE> ENBDNLEICLC(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<PAOCCIMMJDB> JECBHFPMAIO, int NDBNGFNEMFE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EIPPGFCFCGI<KJNHCLAFOIE> KBGBBILBOLI(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<FKGCAMGPCBC> EPGOCEDJKAG, int NDBNGFNEMFE);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int NFBEDBGMMGE(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? BMNLMEJLKJA(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int NMLOAPECMMM(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? HMGDBJMNJGC(TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, int HMFNCGHECPG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CMEHNKKNMNF
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x271B4C0", Offset = "0x271A6C0", VA = "0x18271B4C0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP?> CNBCPMAOCKO<T, TOpInput, TOpOutput>(this NCGPOEIFEIB KNKOEEEKHDK, T EFLJLNCMHDD, T DJDKOLONKNI, int BCFNHIAKNLD, IntPtr PCECLFKEFEM)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x271BCE0", Offset = "0x271AEE0", VA = "0x18271BCE0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP?> HMFKBODBHAM<T, TOpInput, TOpOutput>(this NCGPOEIFEIB KNKOEEEKHDK, T EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI, int BCFNHIAKNLD, IntPtr PCECLFKEFEM)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x271BBC0", Offset = "0x271ADC0", VA = "0x18271BBC0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP?> HGAHDAJHAEB<TOpInput, TOpOutput>(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI, int BCFNHIAKNLD, IntPtr PCECLFKEFEM)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E52E30", Offset = "0x1E52030", VA = "0x181E52E30")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LIABAADOJEG(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E536B0", Offset = "0x1E528B0", VA = "0x181E536B0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> NNLFOGIGLJB(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E527B0", Offset = "0x1E519B0", VA = "0x181E527B0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KDEBJIOBLIO(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E537D0", Offset = "0x1E529D0", VA = "0x181E537D0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> NPFELHBOGPG(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E53D50", Offset = "0x1E52F50", VA = "0x181E53D50")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> PIKAGAMKMKE(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E51E20", Offset = "0x1E51020", VA = "0x181E51E20")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IJNGPKLPFEK(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E510D0", Offset = "0x1E502D0", VA = "0x181E510D0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GPLLINMGIKB(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F010", Offset = "0x1E4E210", VA = "0x181E4F010")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AFCOJMLOALA(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E51A20", Offset = "0x1E50C20", VA = "0x181E51A20")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IDBOOLEJCPF(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E500F0", Offset = "0x1E4F2F0", VA = "0x181E500F0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DICEIOOLMAG(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, int DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F130", Offset = "0x1E4E330", VA = "0x181E4F130")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AFKOILLCBHE(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E53B00", Offset = "0x1E52D00", VA = "0x181E53B00")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> PALJCONAKKK(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E51920", Offset = "0x1E50B20", VA = "0x181E51920")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IADKNLNCMHL(this NCGPOEIFEIB KNKOEEEKHDK, float EFLJLNCMHDD, float DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EBD0", Offset = "0x1E4DDD0", VA = "0x181E4EBD0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AAMCIBEKFOL(this NCGPOEIFEIB KNKOEEEKHDK, float EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E52670", Offset = "0x1E51870", VA = "0x181E52670")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KCLIBAGFIOH(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E51CE0", Offset = "0x1E50EE0", VA = "0x181E51CE0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IFJLFNLOCAO(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, int DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F250", Offset = "0x1E4E450", VA = "0x181E4F250")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AGCMKEAPNEP(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E52050", Offset = "0x1E51250", VA = "0x181E52050")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JFCBGNELCOP(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E51C60", Offset = "0x1E50E60", VA = "0x181E51C60")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IFAMFGDPFND(this NCGPOEIFEIB KNKOEEEKHDK, float EFLJLNCMHDD, float DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E52150", Offset = "0x1E51350", VA = "0x181E52150")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JHNGOGBPIJO(this NCGPOEIFEIB KNKOEEEKHDK, float EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E50BB0", Offset = "0x1E4FDB0", VA = "0x181E50BB0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GFHDANGAHIG(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E52570", Offset = "0x1E51770", VA = "0x181E52570")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JOLCHNBBEJB(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, int DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E520D0", Offset = "0x1E512D0", VA = "0x181E520D0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JFNOLHPJPAE(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E50990", Offset = "0x1E4FB90", VA = "0x181E50990")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GBNENLIOLIK(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F530", Offset = "0x1E4E730", VA = "0x181E4F530")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> APDBJOGCJDP(this NCGPOEIFEIB KNKOEEEKHDK, float EFLJLNCMHDD, float DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E51780", Offset = "0x1E50980", VA = "0x181E51780")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HINBKGILAJH(this NCGPOEIFEIB KNKOEEEKHDK, float EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E51050", Offset = "0x1E50250", VA = "0x181E51050")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GNAHNIPLPOE(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FCE0", Offset = "0x1E4EEE0", VA = "0x181E4FCE0")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> CDEPJJENLEH(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E53630", Offset = "0x1E52830", VA = "0x181E53630")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> NGLCJOGMFDE(this NCGPOEIFEIB KNKOEEEKHDK, int NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E50300", Offset = "0x1E4F500", VA = "0x181E50300")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> DONINFMDBON(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E50510", Offset = "0x1E4F710", VA = "0x181E50510")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> EOCMJFIGOKJ(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AGEDJJHBMHN)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FB70", Offset = "0x1E4ED70", VA = "0x181E4FB70")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> BJNJCENDHKO(this NCGPOEIFEIB KNKOEEEKHDK, int NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E50C30", Offset = "0x1E4FE30", VA = "0x181E50C30")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> GFJBACGGLGC(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E512F0", Offset = "0x1E504F0", VA = "0x181E512F0")]
	public static (EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>) HIDPOCCCNID(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<FAGPAEKFAEG> CBGFFEHOLGK, [In] ReadOnlySpan<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> NLKIGFDMHGH, [In] ReadOnlySpan<int?> PELKBDLPFGC, [In] Span<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> KOKGDNLOCKF)
	{
		return default((EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E53190", Offset = "0x1E52390", VA = "0x181E53190")]
	public static (EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>) MMFLHNJNIAL(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BGAMOELFEOB> LOJMMCNPJJL, [In] ReadOnlySpan<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> NLKIGFDMHGH, [In] ReadOnlySpan<int?> PELKBDLPFGC, [In] Span<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> KOKGDNLOCKF)
	{
		return default((EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x271B760", Offset = "0x271A960", VA = "0x18271B760")]
	public static (EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<KHGPBHCJALI>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<TMarker>>, EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>) EMMMBBEJBKG<TMarker>(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<KHGPBHCJALI> FBHBEGOMPGM, [In] ReadOnlySpan<byte> FODGEDCJIDC)
	{
		return default((EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<LPGDGOFEIPD<KHGPBHCJALI>>, EIPPGFCFCGI<LPGDGOFEIPD<FDNMKMOBOAM>>, EIPPGFCFCGI<LPGDGOFEIPD<TMarker>>, EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E51D60", Offset = "0x1E50F60", VA = "0x181E51D60")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IJKCJENIEKE(this NCGPOEIFEIB KNKOEEEKHDK, int AGNBNOOMFNG, [Optional] EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E52B00", Offset = "0x1E51D00", VA = "0x181E52B00")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KMIJCPMDINO(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AGNBNOOMFNG, [Optional] EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E528F0", Offset = "0x1E51AF0", VA = "0x181E528F0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KFLJIAIJOBP(this NCGPOEIFEIB KNKOEEEKHDK, [In] ReadOnlySpan<byte> AGNBNOOMFNG, [Optional] EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E50A90", Offset = "0x1E4FC90", VA = "0x181E50A90")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GCJNPMELDPG(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AGNBNOOMFNG, int MKJBDDDPMKM, [Optional] EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E53E70", Offset = "0x1E53070", VA = "0x181E53E70")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> PJMEGIJEAAP(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E501E0", Offset = "0x1E4F3E0", VA = "0x181E501E0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DKEKIAIJDHL(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E52F30", Offset = "0x1E52130", VA = "0x181E52F30")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LKPIJJBBMAK(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FEC0", Offset = "0x1E4F0C0", VA = "0x181E4FEC0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> CDKKJCJCLNA(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F2D0", Offset = "0x1E4E4D0", VA = "0x181E4F2D0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AHFKMBGGFCM(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E50F10", Offset = "0x1E50110", VA = "0x181E50F10")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GKIBJIKFIDA(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E525F0", Offset = "0x1E517F0", VA = "0x181E525F0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KBKNNKOFIPC(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, int DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E50490", Offset = "0x1E4F690", VA = "0x181E50490")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EMGLKCFEFJH(this NCGPOEIFEIB KNKOEEEKHDK, int EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E50A10", Offset = "0x1E4FC10", VA = "0x181E50A10")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GBNMKFJEGBE(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EFLJLNCMHDD, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DJDKOLONKNI)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F6A0", Offset = "0x1E4E8A0", VA = "0x181E4F6A0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> BDEJAJNODIL(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E511C0", Offset = "0x1E503C0", VA = "0x181E511C0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HFHPHKMFJHE(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F3F0", Offset = "0x1E4E5F0", VA = "0x181E4F3F0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AJJCMJIMONG(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F5B0", Offset = "0x1E4E7B0", VA = "0x181E4F5B0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> APFKNACIADH(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E52D10", Offset = "0x1E51F10", VA = "0x181E52D10")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KONKJPGHACB(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E50DD0", Offset = "0x1E4FFD0", VA = "0x181E50DD0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GJAIBBFODEI(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E50970", Offset = "0x1E4FB70", VA = "0x181E50970")]
	public static EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>> GBKLPJCEHAI(this NCGPOEIFEIB KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<LPGDGOFEIPD<LPGDGOFEIPD<KMIDLPHNLBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E50CD0", Offset = "0x1E4FED0", VA = "0x181E50CD0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> GIFJPBJFBLO(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E529E0", Offset = "0x1E51BE0", VA = "0x181E529E0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KGBCDLMAGBD(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E52430", Offset = "0x1E51630", VA = "0x181E52430")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JOIPABJACKM(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FBF0", Offset = "0x1E4EDF0", VA = "0x181E4FBF0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> BPEKGGFMMOA(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E521D0", Offset = "0x1E513D0", VA = "0x181E521D0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JHPFHEABCMG(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FFB0", Offset = "0x1E4F1B0", VA = "0x181E4FFB0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> DFNBMNFDLAC(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E53A00", Offset = "0x1E52C00", VA = "0x181E53A00")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> OKGMNDDCJGC(this NCGPOEIFEIB KNKOEEEKHDK, int NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E53C40", Offset = "0x1E52E40", VA = "0x181E53C40")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> PCAGHOMEFOJ(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> NICEPFIEJED)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E53620", Offset = "0x1E52820", VA = "0x181E53620")]
	public static void NAJLMEMAEBP(this NCGPOEIFEIB KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E51B60", Offset = "0x1E50D60", VA = "0x181E51B60")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IEGCNFCPOGJ(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, float LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E51800", Offset = "0x1E50A00", VA = "0x181E51800")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HNAKKBBMHJN(this NCGPOEIFEIB KNKOEEEKHDK, float HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E50830", Offset = "0x1E4FA30", VA = "0x181E50830")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> FLNCIDKNDMH(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E503A0", Offset = "0x1E4F5A0", VA = "0x181E503A0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> EHNEFALDABO(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E52BF0", Offset = "0x1E51DF0", VA = "0x181E52BF0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> KNCGOLGOOFA(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E522F0", Offset = "0x1E514F0", VA = "0x181E522F0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JNKFDPIMNJA(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F7A0", Offset = "0x1E4E9A0", VA = "0x181E4F7A0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> BGNEOJADEFH(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> BECHIIIDOMA, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> BEMJEANHAPD)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E51F60", Offset = "0x1E51160", VA = "0x181E51F60")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> IPGPHMLHIEE(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, int LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1E53070", Offset = "0x1E52270", VA = "0x181E53070")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LNICENKLMNF(this NCGPOEIFEIB KNKOEEEKHDK, int HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1E538C0", Offset = "0x1E52AC0", VA = "0x181E538C0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> OEOLJIEGELK(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> HAOMGFAPNPN, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> LBCEJKGAOCA)
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x271CDB0", Offset = "0x271BFB0", VA = "0x18271CDB0")]
	public static void KILPLEGOJOF<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<FAGPAEKFAEG> CBGFFEHOLGK, [In] ReadOnlySpan<EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>> LDKNBDBNMIK, [In] ReadOnlySpan<int?> PELKBDLPFGC, [In] Span<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> KOKGDNLOCKF, [In] Span<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> LGKMHBIIFCN, [In] ReadOnlySpan<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>?> NCPKPDDHLAG) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x271D680", Offset = "0x271C880", VA = "0x18271D680")]
	public static void LGFEOPGJCGJ<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<BGAMOELFEOB> MGNENKLDBLN, [In] ReadOnlySpan<EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>> FEPJPKGDLPC, [In] ReadOnlySpan<int?> PELKBDLPFGC, [In] Span<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> KOKGDNLOCKF, [In] Span<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>> LGKMHBIIFCN, [In] ReadOnlySpan<EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>?> NCPKPDDHLAG) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x271B300", Offset = "0x271A500", VA = "0x18271B300")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> BBBODGHIODH<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JFDMCMACBIC, [Optional] EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x271BFC0", Offset = "0x271B1C0", VA = "0x18271BFC0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> JFAIKPDGBJK<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> ADHLHICPMAC, [Optional] EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x271B850", Offset = "0x271AA50", VA = "0x18271B850")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> GNJONBBMDLC<TDeps, TStateSys>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB) where TDeps : notnull, IOMIBOIILDG<TStateSys> where TStateSys : notnull
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x271DB90", Offset = "0x271CD90", VA = "0x18271DB90")]
	public static EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM> OAJFFNCNOEK<TDeps, TStateSys>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB) where TDeps : notnull, IOMIBOIILDG<TStateSys> where TStateSys : notnull
	{
		return default(EIPPGFCFCGI<HBEMBDIONIN.BNOPPKDOGLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1E506F0", Offset = "0x1E4F8F0", VA = "0x181E506F0")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> FHOKPEDPFGF(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> EKMAKDCJMIB, IntPtr FKMICADBLKK, IntPtr CBIBBDJIGNB)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1E4ED00", Offset = "0x1E4DF00", VA = "0x181E4ED00")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> AEBBHMPKHDM(this NCGPOEIFEIB KNKOEEEKHDK, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> NDPCIBGELLP, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> KCPAHEDMNPP, IntPtr GOHMINNKOPM, IntPtr OPHDEKDBGLN, IntPtr HPMKECHMMCD, bool DGOKOJJJFKH)
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x271C3F0", Offset = "0x271B5F0", VA = "0x18271C3F0")]
	public static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> JOBIBEANGJP<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<FAGPAEKFAEG> BODKJBGEAKO, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> NDPCIBGELLP, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> KCPAHEDMNPP, int? MNGLGBKMPMM, [Optional] IntPtr HOGHBCMCBDL) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x271C5C0", Offset = "0x271B7C0", VA = "0x18271C5C0")]
	private static EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> JOBIBEANGJP<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<FAGPAEKFAEG> BODKJBGEAKO, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> NDPCIBGELLP, EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK> KCPAHEDMNPP, int? MNGLGBKMPMM) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
		return default(EIPPGFCFCGI<BIAOCJCLOPL.EDLDMPEAOJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x271DEE0", Offset = "0x271D0E0", VA = "0x18271DEE0")]
	public static EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> OBJLFELEPOI<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP> AGNBNOOMFNG, EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>? LKEJHNGNLDG) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
		return default(EIPPGFCFCGI<CPHCHKEMDON.CHLPJGKAJJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x271D2C0", Offset = "0x271C4C0", VA = "0x18271D2C0")]
	public static void LFKFHNCIONL<TDeps, TState>(this NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TState OAODOPKGJBP, int JECGEBJOIIL) where TDeps : notnull, IOMIBOIILDG<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PAKPGALBCHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> DHEOEABBDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> LIDJDNPKPNH;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
	public PAKPGALBCHF(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> BOJAKMEIICB, EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> ADJBMCOPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1E58BF0", Offset = "0x1E57DF0", VA = "0x181E58BF0")]
	public static PAKPGALBCHF MIJABIECKKD(EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>> BOJAKMEIICB)
	{
		return default(PAKPGALBCHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CPHCHKEMDON
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DLFHMANIKDH : GIMDBNDEDBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct LKDNOMNFDFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> OKPPGDCAKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JPDBMMOIFEO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
		public LKDNOMNFDFP(EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> KBPAALNBGLJ, int HMFNCGHECPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HLECODGHKMD : GIMDBNDEDBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct MBDEPLDGHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JPDBMMOIFEO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public MBDEPLDGHAJ(int HMFNCGHECPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class LKLNHMDDIDB : GIMDBNDEDBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct EIBMIHPDDKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> OKPPGDCAKHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int JPDBMMOIFEO;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
		public EIBMIHPDDKI(EIPPGFCFCGI<JJIMANJGJFE.DKBFPGJNCFH> KBPAALNBGLJ, int HMFNCGHECPG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum BAIHFDFOLEG
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
	public sealed class CHLPJGKAJJP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class GIMDBNDEDBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct AGGBJHBGAJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? KDNIMCKLNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PAKPGALBCHF MMBOOFDOAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BAIHFDFOLEG GBNIMFHPKLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EIPPGFCFCGI<GIMDBNDEDBK> LBMHKGDJANP;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1E4E2E0", Offset = "0x1E4D4E0", VA = "0x181E4E2E0")]
		public AGGBJHBGAJH(int? ANGIKNKONLI, [In] PAKPGALBCHF OHOGGELDIHP, BAIHFDFOLEG KMOFMIONHJP, EIPPGFCFCGI<GIMDBNDEDBK> KKBFHIGBHLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class AEBLOOJGEEA : GIMDBNDEDBK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JINKOBKGOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int JPDBMMOIFEO;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		public JINKOBKGOGJ(int HMFNCGHECPG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal NMDBIIGHHEP<CHLPJGKAJJP, AGGBJHBGAJH> KJBLAFCFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal NMDBIIGHHEP<DLFHMANIKDH, LKDNOMNFDFP> MGBLMNIAFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal NMDBIIGHHEP<LKLNHMDDIDB, EIBMIHPDDKI> BIJDOMBOAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal NMDBIIGHHEP<AEBLOOJGEEA, JINKOBKGOGJ> EJMLDEAFJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal NMDBIIGHHEP<HLECODGHKMD, MBDEPLDGHAJ> ILOGHGHGKBF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1E54540", Offset = "0x1E53740", VA = "0x181E54540")]
	private CPHCHKEMDON([In] NMDBIIGHHEP<CHLPJGKAJJP, AGGBJHBGAJH> NJAJEKGJAFM, [In] NMDBIIGHHEP<DLFHMANIKDH, LKDNOMNFDFP> OMOBDAGKNPE, [In] NMDBIIGHHEP<LKLNHMDDIDB, EIBMIHPDDKI> KHHILCHKKIJ, [In] NMDBIIGHHEP<AEBLOOJGEEA, JINKOBKGOGJ> CIACPOFIAKP, [In] NMDBIIGHHEP<HLECODGHKMD, MBDEPLDGHAJ> MKNMEOLKLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1E54350", Offset = "0x1E53550", VA = "0x181E54350")]
	public static CPHCHKEMDON MIJABIECKKD()
	{
		return default(CPHCHKEMDON);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CJHGANFFHIL
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EB20", Offset = "0x1E4DD20", VA = "0x181E4EB20")]
	public static void HDPILJBHDHI(this CPHCHKEMDON KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OJLIJLNPMGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E588F0", Offset = "0x1E57AF0", VA = "0x181E588F0")]
	public static void FPBPNKPIOLJ(NCGPOEIFEIB KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JLMJKPDCHCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, KIAFALDBCPC> PEJHGEIHOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int DCKLAKJMHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int CHNCAJDIMOH;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E55590", Offset = "0x1E54790", VA = "0x181E55590")]
	private JLMJKPDCHCM([In] FMGHEKECDOM<JJIMANJGJFE.PCBDNHOEENB, KIAFALDBCPC> MACMOCHHJEF, int DLJONCJLKAP, int MMBGDOIJECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1E55520", Offset = "0x1E54720", VA = "0x181E55520")]
	public static JLMJKPDCHCM MIJABIECKKD()
	{
		return default(JLMJKPDCHCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1E55350", Offset = "0x1E54550", VA = "0x181E55350")]
	public void HDPILJBHDHI([In] NCGPOEIFEIB EPAEKHCAPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2946B90", Offset = "0x2945D90", VA = "0x182946B90")]
	public static void FPBPNKPIOLJ<TDeps, TStateSys>(NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB, EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI) where TDeps : notnull, IOMIBOIILDG<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JFFJDIJDCFK
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1E54F40", Offset = "0x1E54140", VA = "0x181E54F40")]
	public static void FPBPNKPIOLJ(NCGPOEIFEIB KNKOEEEKHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EPEDPJMPDFP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface GEPBMFPDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AEDAJAPDLJO(FNBPBCOGKJO<byte> EJCMFKOAOLD, int HJKGKBENKKC);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PINCLHFPJEL : GEPBMFPDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E58EA0", Offset = "0x1E580A0", VA = "0x181E58EA0", Slot = "4")]
		public void AEDAJAPDLJO(FNBPBCOGKJO<byte> EJCMFKOAOLD, int HJKGKBENKKC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct OOKJAICBDLB : GEPBMFPDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1E58AE0", Offset = "0x1E57CE0", VA = "0x181E58AE0", Slot = "4")]
		public void AEDAJAPDLJO(FNBPBCOGKJO<byte> EJCMFKOAOLD, int HJKGKBENKKC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct HABHNHMJMOG : GEPBMFPDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1E54D00", Offset = "0x1E53F00", VA = "0x181E54D00", Slot = "4")]
		public void AEDAJAPDLJO(FNBPBCOGKJO<byte> EJCMFKOAOLD, int HJKGKBENKKC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct GBKMAKGACCA : GEPBMFPDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1E54C60", Offset = "0x1E53E60", VA = "0x181E54C60", Slot = "4")]
		public void AEDAJAPDLJO(FNBPBCOGKJO<byte> EJCMFKOAOLD, int HJKGKBENKKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class LKIFAANGEGE<TCallProcessorDeps> where TCallProcessorDeps : struct, GEPBMFPDHIG
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps KDDFIFIFPAP;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2580F10", Offset = "0x2580110", VA = "0x182580F10")]
		public static int FPBPNKPIOLJ<TDeps, TStateSys>(TDeps NMAKCOKENKA, TStateSys OAODOPKGJBP, NCGPOEIFEIB EPAEKHCAPHF, [In] FNBPBCOGKJO<byte> ENPNCKNJEKP, int ENAEIJLNKLP) where TDeps : IOMIBOIILDG<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private FNBPBCOGKJO<FJMFOBEAGPO> ALFLLHKPEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>> ABMDENGDPOE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1E54A30", Offset = "0x1E53C30", VA = "0x181E54A30")]
	private EPEDPJMPDFP([In] FNBPBCOGKJO<FJMFOBEAGPO> FOGBLBIGAGL, Dictionary<EIPPGFCFCGI<LPGDGOFEIPD<KMIDLPHNLBA>>, EIPPGFCFCGI<JJIMANJGJFE.PCBDNHOEENB>> FGGNACNLOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1E54970", Offset = "0x1E53B70", VA = "0x181E54970")]
	public static EPEDPJMPDFP MIJABIECKKD()
	{
		return default(EPEDPJMPDFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1E54930", Offset = "0x1E53B30", VA = "0x181E54930")]
	public void HDPILJBHDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x27802B0", Offset = "0x277F4B0", VA = "0x1827802B0")]
	public static void FPBPNKPIOLJ<TDeps, TStateSys>(NCGPOEIFEIB KNKOEEEKHDK, TDeps NMAKCOKENKA, TStateSys NINKHNMFJGB) where TDeps : IOMIBOIILDG<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LFDBLINMANH<TDeps, TIndex, TValues> where TDeps : struct, DNEHMIKOPHE<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3D2B150", Offset = "0x3D2A350", VA = "0x183D2B150")]
	public static void FPBPNKPIOLJ([In] FNBPBCOGKJO<FJMFOBEAGPO> FOGBLBIGAGL, int APFMAPIEBAI, TValues NGOGJHGFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface DNEHMIKOPHE<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FNBPBCOGKJO<TIndex> AJOCPKMCLDI(int APFMAPIEBAI, [In] TValues NGOGJHGFHFE);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(TIndex HMFNCGHECPG, [In] TValues NGOGJHGFHFE);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGHONIKLOEO(TIndex HMFNCGHECPG, TValues NGOGJHGFHFE, EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LEHICCEODAC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex GLDLMGNGLIC(int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MJFHMFOBFDH(TIndex HMFNCGHECPG, [In] TValues NGOGJHGFHFE);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EIPPGFCFCGI<LPGDGOFEIPD<LLKKIPNOJAP>> GCOBFIGPHJN(TIndex HMFNCGHECPG, [In] TValues NGOGJHGFHFE);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IBJEDPAKDOO<TDeps, TIndex, TValues> where TDeps : struct, LEHICCEODAC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3A34A50", Offset = "0x3A33C50", VA = "0x183A34A50")]
	public static FNBPBCOGKJO<TIndex> FPBPNKPIOLJ(int APFMAPIEBAI, [In] TValues NGOGJHGFHFE)
	{
		return default(FNBPBCOGKJO<TIndex>);
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
