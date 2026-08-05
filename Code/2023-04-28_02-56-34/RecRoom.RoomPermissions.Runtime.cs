using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6321050", Offset = "0x631FA50", VA = "0x186321050")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72C090", Offset = "0x72AA90", VA = "0x18072C090")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA36880", Offset = "0xA35280", VA = "0x180A36880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BODHECLGFJO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JEIFJPNNAJP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void OMDCOMGDIIP<TPermission>(TPermission HHCGHKIPMPP);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void DABIGGHPMBC(IEIHKFAAJEG DDCEIPJJNAJ);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NMGIJPPCNMI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KHHCCBLFOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FOOECGFANOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PCFCOMDLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HIEFFNCONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BNFFCFFGLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BEIOMKHLBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DPNKEONOFML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FMGLIICIMIB JOOINHENJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<FKDDPLLEJML> FPOOLECBIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DABIGGHPMBC EJKGEDHBJNB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<FKDDPLLEJML> PHDEKAJHNPL(bool OHGKLADJCHB = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FKDDPLLEJML OMFNNABKHHO(IEIHKFAAJEG DDCEIPJJNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool INGIEPHMCKP(IEIHKFAAJEG DDCEIPJJNAJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<FKDDPLLEJML> HIIENHBCNOC(IEIHKFAAJEG DDCEIPJJNAJ, bool FJHHPGCJJCL = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EPFBJBPADAG(IEIHKFAAJEG CHNAEOCOLJM, AALDFAGJKHE ENHDGCJILNE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FKDDPLLEJML CNGMMOKAKOL(AALDFAGJKHE ENHDGCJILNE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OGAIIAPIKDL<T>(AALDFAGJKHE ENHDGCJILNE, HJCEOIBEONB HHCGHKIPMPP, bool NCKOBMCKFDE, T HACNEHKIBDN) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LMHGEGAHELF
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BANGACJHCAD(ALDNBFOLDOE GOKPFGBACOI, CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAOPDAEGNAL(ref ALDNBFOLDOE GOKPFGBACOI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CBGBEJPCLKD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEIHKFAAJEG CLMJPHEMKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OFCNMCIOFIM OHKGAEPFPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LLBNMMPGAFE LJLLOPOPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HPFGCBBAIID> GKLABCBGCEH;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MCGFIBHDPGH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AALDFAGJKHE IPJLPMDIICE(IEIHKFAAJEG DDCEIPJJNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HPFGCBBAIID> CKJMCKHPBCN(CancellationToken OIMNLGJCBEC);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task EANCNFJNJFE(long LCIEPBGBKGO, long HJCAHMBDEEM, IReadOnlyList<COMGONFGDDI> BBAOAKHHEHP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IEIHKFAAJEG> BILHCAFIHEH();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OCAAOKNKGDE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63210E0", Offset = "0x631FAE0", VA = "0x1863210E0")]
	public static AALDFAGJKHE MIBPBFGIPCJ(this CBGBEJPCLKD CLINNHAKMAF)
	{
		return default(AALDFAGJKHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GFAKMMLJBLM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NHNILFGOJNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::OMDCOMGDIIP<TPermission> KMDHKBMKCCO;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class LAADOHHDNJF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum KPHMJANEOAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid ILCPEFHNPFH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid OFDCPLFMEPH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ONPFFLIFPLO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid FKCLCLGPFFE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NDEIPHHOEBM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::GNFFLKLNNJJ<AALDFAGJKHE, Guid> AHHFBIHJEPO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<AALDFAGJKHE> MMHPEHLOCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x631E670", Offset = "0x631D070", VA = "0x18631E670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x631E920", Offset = "0x631D320", VA = "0x18631E920")]
	public static AALDFAGJKHE KIAFEPNEHNJ(Guid NPIFLODGAHD)
	{
		return default(AALDFAGJKHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x631E9E0", Offset = "0x631D3E0", VA = "0x18631E9E0")]
	public static Guid ONDKIDCHLIC(AALDFAGJKHE ENHDGCJILNE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x631E880", Offset = "0x631D280", VA = "0x18631E880")]
	public static bool JMNAIPAPJPN(AALDFAGJKHE ENHDGCJILNE, out Guid NPIFLODGAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x631E7A0", Offset = "0x631D1A0", VA = "0x18631E7A0")]
	public static bool IMAMCGIGDHK(Guid NPIFLODGAHD, out AALDFAGJKHE ENHDGCJILNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x631E9B0", Offset = "0x631D3B0", VA = "0x18631E9B0")]
	public static AALDFAGJKHE MGBMNDNDLHC(AALDFAGJKHE ENHDGCJILNE)
	{
		return default(AALDFAGJKHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x631E6F0", Offset = "0x631D0F0", VA = "0x18631E6F0")]
	public static KPHMJANEOAD EMBLEIMLCBN(AALDFAGJKHE JHOPMNPMDON)
	{
		return default(KPHMJANEOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x631E840", Offset = "0x631D240", VA = "0x18631E840")]
	internal static AALDFAGJKHE IPMAEILEICL(KPHMJANEOAD ABLAGFBCNLN)
	{
		return default(AALDFAGJKHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class LOCPLCNPNPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CFJKADLIFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	protected LOCPLCNPNPL(object? LGKGGGICOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BLINKILGJLB(object? LPJDDLMPNCG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KIJNGBAFDFE<T> : LOCPLCNPNPL where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T MAMKFFPECLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> GIMMCBBNPCI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T NDNOLKCBONM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x38ED2A0", Offset = "0x38EBCA0", VA = "0x1838ED2A0", Slot = "4")]
	public override bool BLINKILGJLB(object? LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x38ED470", Offset = "0x38EBE70", VA = "0x1838ED470")]
	public bool CCDCILNKHFA(T GJLEENLCHAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x38ED940", Offset = "0x38EC340", VA = "0x1838ED940")]
	public KIJNGBAFDFE(T LGCPJJBBDLH, IEqualityComparer<T> GIMMCBBNPCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HJKENPPMAON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<HJCEOIBEONB, bool> HJMEKPGKOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<HJCEOIBEONB, LOCPLCNPNPL> BMKHKMLLCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FNFHOAIOJOA CIEINDIJGEH;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x63181C0", Offset = "0x6316BC0", VA = "0x1863181C0")]
	public HJKENPPMAON(FNFHOAIOJOA CIEINDIJGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6317D40", Offset = "0x6316740", VA = "0x186317D40")]
	public bool AFNFEBHHMDB(HJCEOIBEONB HHCGHKIPMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x252D5B0", Offset = "0x252BFB0", VA = "0x18252D5B0")]
	public bool FGGOEBJIEPC<T>(HJCEOIBEONB HHCGHKIPMPP, bool NCKOBMCKFDE, T LPJDDLMPNCG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x252D0A0", Offset = "0x252BAA0", VA = "0x18252D0A0")]
	public (bool, T?) EPHJGDCLHPD<T>(HJCEOIBEONB HHCGHKIPMPP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6317E80", Offset = "0x6316880", VA = "0x186317E80")]
	public bool FGGOEBJIEPC(HJCEOIBEONB HHCGHKIPMPP, bool NCKOBMCKFDE, object LPJDDLMPNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6317DB0", Offset = "0x63167B0", VA = "0x186317DB0")]
	public (bool, object) EPHJGDCLHPD(HJCEOIBEONB HHCGHKIPMPP)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x252CE60", Offset = "0x252B860", VA = "0x18252CE60")]
	private void DGEIFAGEONE<T>(HJCEOIBEONB HHCGHKIPMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6318100", Offset = "0x6316B00", VA = "0x186318100")]
	private LOCPLCNPNPL JANFLDBABMD(HJCEOIBEONB HHCGHKIPMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6317F60", Offset = "0x6316960", VA = "0x186317F60")]
	public void HCCEMOPBHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HNIHEGHKNFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string EFBIABFPECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type COFCGFAOHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly MKKNALIFFIH CBGAFDLOABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly HJCEOIBEONB JDMENDDHOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GPMCEBJNLLI LBFFCDGOJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OIEAHPBANAA BHBJKIGDOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public IPGBAFAEGCE PGCMHFJKKEP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x631DC60", Offset = "0x631C660", VA = "0x18631DC60")]
	public HNIHEGHKNFD(Type CHLLFCBIGHM, string CIJOBEFNJEC, HJCEOIBEONB HHCGHKIPMPP, GPMCEBJNLLI HDAHMDAECGA, OIEAHPBANAA IKEPKBPOFKP, IPGBAFAEGCE JFLLHLKFCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x631DC20", Offset = "0x631C620", VA = "0x18631DC20")]
	public object PIEIDHNBFAM(object? MPHACEGLFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x253DD40", Offset = "0x253C740", VA = "0x18253DD40")]
	public void DGEIFAGEONE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x631DB70", Offset = "0x631C570", VA = "0x18631DB70")]
	public void DGEIFAGEONE(Type NPIMIOCMLCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class HNOCCOCEKBC<T> : HNIHEGHKNFD where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string NLMMLPKBIDB(T LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T HCLBADKJFKJ(string? MBEGBJFAHOD, T LGCPJJBBDLH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EKAGOJEJHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public NLMMLPKBIDB serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HCLBADKJFKJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public EKAGOJEJHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4064170", Offset = "0x4062B70", VA = "0x184064170")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4064210", Offset = "0x4062C10", VA = "0x184064210")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2FDB3F0", Offset = "0x2FD9DF0", VA = "0x182FDB3F0")]
	public HNOCCOCEKBC(HJCEOIBEONB HHCGHKIPMPP, string CIJOBEFNJEC, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6740", Offset = "0x6D5B40")] global::HNOCCOCEKBC<T>.NLMMLPKBIDB HDAHMDAECGA, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D67A0", Offset = "0x6D5BA0")] global::HNOCCOCEKBC<T>.HCLBADKJFKJ IKEPKBPOFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2FDB070", Offset = "0x2FD9A70", VA = "0x182FDB070")]
	private static object? JDGCKOHAIDJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6800", Offset = "0x6D5C00")] global::HNOCCOCEKBC<T?>.HCLBADKJFKJ? IKEPKBPOFKP, string? MBEGBJFAHOD, object? LGCPJJBBDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2FDA3B0", Offset = "0x2FD8DB0", VA = "0x182FDA3B0")]
	private static string HLHCEBOKDMG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6860", Offset = "0x6D5C60")] global::HNOCCOCEKBC<T>.NLMMLPKBIDB DBCCFBJMCNF, object? LPJDDLMPNCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string GPMCEBJNLLI(object? LPJDDLMPNCG);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object OIEAHPBANAA(string? MBEGBJFAHOD, [Optional] object LGCPJJBBDLH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate LOCPLCNPNPL IPGBAFAEGCE();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FNFHOAIOJOA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KCHJCBNPPIF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static KCHJCBNPPIF AGBLMGNNIDO;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x631E370", Offset = "0x631CD70", VA = "0x18631E370", Slot = "4")]
		public bool Equals(List<string> GKBCEINHOJB, List<string> LAMHEDHCIJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x631E4D0", Offset = "0x631CED0", VA = "0x18631E4D0", Slot = "5")]
		public int GetHashCode(List<string> NBNOMDAKOCG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public KCHJCBNPPIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class BPPHLNJJAGH : global::GMANKPLLNJI<BODHECLGFJO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6315730", Offset = "0x6314130", VA = "0x186315730", Slot = "9")]
		public override string HLHCEBOKDMG(BODHECLGFJO JMFFKIOGAJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6315540", Offset = "0x6313F40", VA = "0x186315540", Slot = "10")]
		protected override bool GNLLBJFIDDL(string JMFFKIOGAJJ, out BODHECLGFJO LPJDDLMPNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6315830", Offset = "0x6314230", VA = "0x186315830")]
		public BPPHLNJJAGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly KAKDNNFBJPN CBNHJJJAJPF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly BPPHLNJJAGH KKDOEDJDAGM;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<HNIHEGHKNFD> CEABECCMJGH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<HJCEOIBEONB> NFPHFLICPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<HJCEOIBEONB, HNIHEGHKNFD> ONGCBAIMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x63171B0", Offset = "0x6315BB0", VA = "0x1863171B0")]
	public FNFHOAIOJOA([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D68C0", Offset = "0x6D5CC0")] IList<HNIHEGHKNFD> CPJCPOBHAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x63165C0", Offset = "0x6314FC0", VA = "0x1863165C0")]
	public HNIHEGHKNFD BKIKMEPJOMF(HJCEOIBEONB HHCGHKIPMPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FMGLIICIMIB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FKDDPLLEJML OMBFGMFOEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class OPDNCJDHBDD : FMGLIICIMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static OPDNCJDHBDD NKBGECDCGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly MKEOHMJJHMD OJACFELAKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<MKEOHMJJHMD> HLAMFOMGMEE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FKDDPLLEJML OMBFGMFOEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6321DA0", Offset = "0x63207A0", VA = "0x186321DA0")]
	public OPDNCJDHBDD(MKEOHMJJHMD JPFIECIKBBN, IReadOnlyList<MKEOHMJJHMD> JDIDEPLIICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6321560", Offset = "0x631FF60", VA = "0x186321560")]
	private static OPDNCJDHBDD DBAOOCCOMKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EGAAMJECCFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<AALDFAGJKHE> OJCPAKFFBMN;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6316280", Offset = "0x6314C80", VA = "0x186316280")]
	public static bool DFCAFLGKJGA(this IEIHKFAAJEG DCELPOHIPLK, AALDFAGJKHE ENHDGCJILNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6316370", Offset = "0x6314D70", VA = "0x186316370")]
	public static bool OJFEIJPHFKE(this IEIHKFAAJEG DCELPOHIPLK, AALDFAGJKHE ENHDGCJILNE, LLBNMMPGAFE DDACBKFDEHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EKAALBBDHGF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HMHEGKPCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MBNMMBMIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BKPLPFCMHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GMDGKLIBJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NJCKNGDJGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KFDLDEGLLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JGEMHBPOMIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool KMGMMPEABHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EAKHEHPFICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GAPDHPCDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MDODAJGJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FBOMAJEHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> CELHBEFDEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BODHECLGFJO CBNMFGLONME
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FKDDPLLEJML : EKAALBBDHGF, NMGIJPPCNMI, global::GFAKMMLJBLM<HJCEOIBEONB>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FHBPKIIFJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AALDFAGJKHE MPBDLHODKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) KIMLNPOCKPD<T>(HJCEOIBEONB HHCGHKIPMPP) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum HJCEOIBEONB
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class MKEOHMJJHMD : FKDDPLLEJML, EKAALBBDHGF, NMGIJPPCNMI, global::GFAKMMLJBLM<HJCEOIBEONB>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly FNFHOAIOJOA AOHMIMGLNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly HJKENPPMAON LFFJMJCCMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? PGBMIHHHOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? JMHLEHIGAMD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool HMHEGKPCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6320300", Offset = "0x631ED00", VA = "0x186320300", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public BODHECLGFJO CBNMFGLONME
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6320D20", Offset = "0x631F720", VA = "0x186320D20", Slot = "20")]
		get
		{
			return default(BODHECLGFJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool MBNMMBMIKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x631F2E0", Offset = "0x631DCE0", VA = "0x18631F2E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BKPLPFCMHKI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x631F3D0", Offset = "0x631DDD0", VA = "0x18631F3D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GMDGKLIBJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x631F5C0", Offset = "0x631DFC0", VA = "0x18631F5C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NJCKNGDJGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6320350", Offset = "0x631ED50", VA = "0x186320350", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KFDLDEGLLGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6320D70", Offset = "0x631F770", VA = "0x186320D70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JGEMHBPOMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x63203A0", Offset = "0x631EDA0", VA = "0x1863203A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool KMGMMPEABHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6320120", Offset = "0x631EB20", VA = "0x186320120", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EAKHEHPFICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6320B60", Offset = "0x631F560", VA = "0x186320B60", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> CELHBEFDEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x631EEB0", Offset = "0x631D8B0", VA = "0x18631EEB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OMPDFPGLEML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x631F330", Offset = "0x631DD30", VA = "0x18631F330", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OLHKJEGLJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x63201C0", Offset = "0x631EBC0", VA = "0x1863201C0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool INDOCAAFEML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x631F1A0", Offset = "0x631DBA0", VA = "0x18631F1A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GAPDHPCDLEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x63200D0", Offset = "0x631EAD0", VA = "0x1863200D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MDODAJGJBJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x631F420", Offset = "0x631DE20", VA = "0x18631F420", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FDCKENNEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x63202B0", Offset = "0x631ECB0", VA = "0x1863202B0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FBOMAJEHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6320170", Offset = "0x631EB70", VA = "0x186320170", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DFCFEDAIDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x631F610", Offset = "0x631E010", VA = "0x18631F610", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ACKCPICBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x631F470", Offset = "0x631DE70", VA = "0x18631F470", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool NBFLNFFOOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x631F330", Offset = "0x631DD30", VA = "0x18631F330", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool PDFOKFNLHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x631F1A0", Offset = "0x631DBA0", VA = "0x18631F1A0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool LCNOAIGHKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x63202B0", Offset = "0x631ECB0", VA = "0x1863202B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool AAPNNMIAPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x631F610", Offset = "0x631E010", VA = "0x18631F610", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool CKDMLKGPAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x63201C0", Offset = "0x631EBC0", VA = "0x1863201C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool POOIFPFDBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x631F470", Offset = "0x631DE70", VA = "0x18631F470", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AALDFAGJKHE MPBDLHODKNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AALDFAGJKHE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x74CAD0", Offset = "0x74B4D0", VA = "0x18074CAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string NHNILFGOJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x631F380", Offset = "0x631DD80", VA = "0x18631F380", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x631F1F0", Offset = "0x631DBF0", VA = "0x18631F1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string FHBPKIIFJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x631F380", Offset = "0x631DD80", VA = "0x18631F380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HLIOMPIJAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC220", Offset = "0x7DAC20", VA = "0x1807DC220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9427A0", Offset = "0x9411A0", VA = "0x1809427A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::OMDCOMGDIIP<HJCEOIBEONB> KMDHKBMKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6320030", Offset = "0x631EA30", VA = "0x186320030", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x631F240", Offset = "0x631DC40", VA = "0x18631F240", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x631EF10", Offset = "0x631D910", VA = "0x18631EF10")]
	public DCJLBCEKAAB AHMGOBHNBEG(Func<AALDFAGJKHE, Guid> MEPFDKKOJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x631F680", Offset = "0x631E080", VA = "0x18631F680")]
	public void HDJINHCLHDD(DCJLBCEKAAB OFHAKFGPMHG, Func<Guid, AALDFAGJKHE> OICDJOFECNH, [Optional] AALDFAGJKHE? DJBLPGBGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x28DE290", Offset = "0x28DCC90", VA = "0x1828DE290", Slot = "6")]
	public (bool, T?) KIMLNPOCKPD<T>(HJCEOIBEONB HHCGHKIPMPP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x28DE250", Offset = "0x28DCC50", VA = "0x1828DE250")]
	public MKEOHMJJHMD GEBNHFPEOOA<T>(HJCEOIBEONB HHCGHKIPMPP, bool NCKOBMCKFDE, T LPJDDLMPNCG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6320F80", Offset = "0x631F980", VA = "0x186320F80")]
	public MKEOHMJJHMD(AALDFAGJKHE ENHDGCJILNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6321030", Offset = "0x631FA30", VA = "0x186321030")]
	public MKEOHMJJHMD(AALDFAGJKHE ENHDGCJILNE, [Optional] string? PGBMIHHHOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6320FA0", Offset = "0x631F9A0", VA = "0x186320FA0")]
	public MKEOHMJJHMD(MKEOHMJJHMD IGPCPAMLEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6320E30", Offset = "0x631F830", VA = "0x186320E30")]
	internal MKEOHMJJHMD(AALDFAGJKHE JPCKEJJPCLI, [Optional] string? PGBMIHHHOIM, [Optional] MKEOHMJJHMD? IGPCPAMLEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x631F120", Offset = "0x631DB20", VA = "0x18631F120")]
	public static MKKNALIFFIH BBBDMIKOBEN(HJCEOIBEONB HHCGHKIPMPP)
	{
		return default(MKKNALIFFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x631F660", Offset = "0x631E060", VA = "0x18631F660")]
	public void HCCEMOPBHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6320820", Offset = "0x631F220", VA = "0x186320820")]
	internal MKEOHMJJHMD MNLIHOGNBPH(MKEOHMJJHMD BDFHMIEIGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x63203F0", Offset = "0x631EDF0", VA = "0x1863203F0")]
	internal IReadOnlyCollection<HJCEOIBEONB> MLOEOOCDIIH(MKEOHMJJHMD IGPCPAMLEOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6320BB0", Offset = "0x631F5B0", VA = "0x186320BB0")]
	public bool OHMHOGOCJAE(HJCEOIBEONB HHCGHKIPMPP, bool NCKOBMCKFDE, string JOAJNFNPBLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x631F4C0", Offset = "0x631DEC0", VA = "0x18631F4C0")]
	public (bool, string) FJJEIMFEFJM(HJCEOIBEONB HHCGHKIPMPP)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6320210", Offset = "0x631EC10", VA = "0x186320210")]
	internal void KMGLCDFCEFK(HJCEOIBEONB HHCGHKIPMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6320C90", Offset = "0x631F690", VA = "0x186320C90")]
	[CompilerGenerated]
	private void OIENFHGKCPP(HJCEOIBEONB NEHPENPDOEK, HDOKKMJKLLA GNLIFJLGKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HMALNAEIDIE : LMHGEGAHELF, DPNKEONOFML, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MBCOGEIHPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MKEOHMJJHMD newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MBCOGEIHPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x631ED60", Offset = "0x631D760", VA = "0x18631ED60")]
		internal bool <InitializeRolesLists>b__0(MKEOHMJJHMD rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JJPDPENEDBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AALDFAGJKHE roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public JJPDPENEDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x631E360", Offset = "0x631CD60", VA = "0x18631E360")]
		internal bool <UpdateRoleDatas>b__0(AALDFAGJKHE r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct GAMLMHCGEOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public HMALNAEIDIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public ALDNBFOLDOE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6E70", Offset = "0x6D6270")]
		private TaskAwaiter<HPFGCBBAIID> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6317520", Offset = "0x6315F20", VA = "0x186317520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HJJLHHCNDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public HJJLHHCNDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6317B40", Offset = "0x6316540", VA = "0x186317B40")]
		internal void <RunBackwardsCompatibilityMigration>b__0(DCJLBCEKAAB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6317C20", Offset = "0x6316620", VA = "0x186317C20")]
		internal void <RunBackwardsCompatibilityMigration>b__1(DCJLBCEKAAB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HJFJCFMKMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public ALDNBFOLDOE roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MHLPEFPOJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6ED0", Offset = "0x6D62D0")]
		public Func<DCJLBCEKAAB, HDOKKMJKLLA> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public MHLPEFPOJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x631ED90", Offset = "0x631D790", VA = "0x18631ED90")]
		internal void <MigrateLegacyHostSettings>b__1(DCJLBCEKAAB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x631EDF0", Offset = "0x631D7F0", VA = "0x18631EDF0")]
		internal void <MigrateLegacyHostSettings>b__2(DCJLBCEKAAB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x631EE50", Offset = "0x631D850", VA = "0x18631EE50")]
		internal void <MigrateLegacyHostSettings>b__3(DCJLBCEKAAB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OPFONNONCOA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HMALNAEIDIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public HJCEOIBEONB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AALDFAGJKHE accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MKKNALIFFIH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public OPFONNONCOA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct CIOEKGJBPFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<COMGONFGDDI> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CAAEHOGHOLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CBGBEJPCLKD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public ALDNBFOLDOE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6D6FE0", Offset = "0x6D63E0")]
		public IReadOnlyDictionary<AALDFAGJKHE, MKEOHMJJHMD> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NHOBFCMCDOK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6315870", Offset = "0x6314270", VA = "0x186315870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly CBGBEJPCLKD CLINNHAKMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly OPDNCJDHBDD NAOAALBKHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly NHOBFCMCDOK HNGDIECMCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, MKEOHMJJHMD> DAIGMIIMACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<AALDFAGJKHE, MKEOHMJJHMD> JLLBCHDEGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<AALDFAGJKHE, MKEOHMJJHMD> HKLCMPPFDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<MKEOHMJJHMD> BFEGFMIPPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool NOFHJBEAMOA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly HJCEOIBEONB[] NGCLJCMPKEL;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FMGLIICIMIB JOOINHENJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<FKDDPLLEJML> FPOOLECBIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6319E30", Offset = "0x6318830", VA = "0x186319E30", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DABIGGHPMBC EJKGEDHBJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6319000", Offset = "0x6317A00", VA = "0x186319000", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x631A910", Offset = "0x6319310", VA = "0x18631A910", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6319E80", Offset = "0x6318880", VA = "0x186319E80")]
	[JDDIJBKLPJE(JMBPMAGFLED.Room, GHILFLKBMBN.None)]
	private static void GBFPCIFAHPO(AOONKACGDKK HBEJHFKCBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x631D8E0", Offset = "0x631C2E0", VA = "0x18631D8E0")]
	[UnityEngine.Scripting.Preserve]
	internal HMALNAEIDIE([LIKONNNLKGK(null)] CBGBEJPCLKD FNKHCNDOIOB, [LIKONNNLKGK(null)] OPDNCJDHBDD FLDMNDOHBON, [LIKONNNLKGK(null)] NHOBFCMCDOK HNGDIECMCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6318EF0", Offset = "0x63178F0", VA = "0x186318EF0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x631A040", Offset = "0x6318A40", VA = "0x18631A040")]
	private void GPADHIMABFF(IEnumerable<MKEOHMJJHMD> BBOIAKOINCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x631A840", Offset = "0x6319240", VA = "0x18631A840", Slot = "12")]
	public bool INGIEPHMCKP(IEIHKFAAJEG DDCEIPJJNAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x631C780", Offset = "0x631B180", VA = "0x18631C780")]
	private void MCGFIBHDPGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x631B3C0", Offset = "0x6319DC0", VA = "0x18631B3C0")]
	private void LDKOKDLHLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x631CB90", Offset = "0x631B590", VA = "0x18631CB90", Slot = "10")]
	public IReadOnlyList<FKDDPLLEJML> PHDEKAJHNPL(bool OHGKLADJCHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x631C7B0", Offset = "0x631B1B0", VA = "0x18631C7B0", Slot = "11")]
	public FKDDPLLEJML OMFNNABKHHO(IEIHKFAAJEG DDCEIPJJNAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6318E30", Offset = "0x6317830", VA = "0x186318E30")]
	private AALDFAGJKHE DKPMJEPHHHA(IEIHKFAAJEG DDCEIPJJNAJ)
	{
		return default(AALDFAGJKHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x63193C0", Offset = "0x6317DC0", VA = "0x1863193C0", Slot = "14")]
	public bool EPFBJBPADAG(IEIHKFAAJEG CHNAEOCOLJM, AALDFAGJKHE ENHDGCJILNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6318D80", Offset = "0x6317780", VA = "0x186318D80", Slot = "15")]
	public FKDDPLLEJML CNGMMOKAKOL(AALDFAGJKHE ENHDGCJILNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x631D350", Offset = "0x631BD50", VA = "0x18631D350")]
	private static bool PLEHMBALJIN(KGJPIKINCGG KCFFMBPICCO, AALDFAGJKHE ENHDGCJILNE, out DCJLBCEKAAB? INAGAGHLKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6319D30", Offset = "0x6318730", VA = "0x186319D30")]
	private static void FNCNBBEDAJF(KGJPIKINCGG KCFFMBPICCO, Action<DCJLBCEKAAB> GFHOKPOKFLF, AALDFAGJKHE NPNIAHPGOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6319B30", Offset = "0x6318530", VA = "0x186319B30")]
	private static void FNCNBBEDAJF(KGJPIKINCGG KCFFMBPICCO, Action<DCJLBCEKAAB> GFHOKPOKFLF, Predicate<AALDFAGJKHE> JGPCECOPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6318420", Offset = "0x6316E20", VA = "0x186318420")]
	private void ACJPOFHKBKE(IEIHKFAAJEG DDCEIPJJNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6318930", Offset = "0x6317330", VA = "0x186318930", Slot = "4")]
	[AsyncStateMachine(typeof(GAMLMHCGEOC))]
	public Task BANGACJHCAD([CanBeNull] ALDNBFOLDOE GOKPFGBACOI, CancellationToken OIMNLGJCBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
	public void JAOPDAEGNAL(ref ALDNBFOLDOE GOKPFGBACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x631C510", Offset = "0x631AF10", VA = "0x18631C510")]
	private void LOCNEKOENOC(KGJPIKINCGG NODLKNIHIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x631AF60", Offset = "0x6319960", VA = "0x18631AF60")]
	internal static string LCLPIDADFNO(CBGBEJPCLKD CLINNHAKMAF, ALDNBFOLDOE GOKPFGBACOI, IReadOnlyDictionary<AALDFAGJKHE, MKEOHMJJHMD> JLLBCHDEGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x631B550", Offset = "0x6319F50", VA = "0x18631B550")]
	private static void LHHOIDBHFGF(ALDNBFOLDOE GOKPFGBACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6318A70", Offset = "0x6317470", VA = "0x186318A70")]
	private static void BDFHNBAHFHF(KGJPIKINCGG LODPKHBHAKD, IReadOnlyDictionary<AALDFAGJKHE, MKEOHMJJHMD> JLLBCHDEGDH, StringBuilder LCOMEGBHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x631B260", Offset = "0x6319C60", VA = "0x18631B260")]
	private static bool LDJBKDKEBPK(string NOFPIKJHOEC, out Guid KFDONJOOODP, out AALDFAGJKHE ENHDGCJILNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6319550", Offset = "0x6317F50", VA = "0x186319550")]
	private static void FLIIMGABHAK(ALDNBFOLDOE GOKPFGBACOI, StringBuilder LCOMEGBHDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x253D190", Offset = "0x253BB90", VA = "0x18253D190", Slot = "16")]
	public bool OGAIIAPIKDL<T>(AALDFAGJKHE ENHDGCJILNE, HJCEOIBEONB HHCGHKIPMPP, bool NCKOBMCKFDE, T HACNEHKIBDN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6318480", Offset = "0x6316E80", VA = "0x186318480")]
	private void AGJPCDJBBNJ(AALDFAGJKHE ENHDGCJILNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x631C790", Offset = "0x631B190", VA = "0x18631C790")]
	private bool ODEOPALONCG(IEIHKFAAJEG DDCEIPJJNAJ, AALDFAGJKHE ENHDGCJILNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x63190A0", Offset = "0x6317AA0", VA = "0x1863190A0")]
	internal MKEOHMJJHMD ECCLAHNPCHA(IEIHKFAAJEG DDCEIPJJNAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x631A830", Offset = "0x6319230", VA = "0x18631A830", Slot = "13")]
	public IReadOnlyList<FKDDPLLEJML> HIIENHBCNOC(IEIHKFAAJEG DDCEIPJJNAJ, bool FJHHPGCJJCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x631A9B0", Offset = "0x63193B0", VA = "0x18631A9B0")]
	internal IReadOnlyList<MKEOHMJJHMD> KGCFAHFNMED(IEIHKFAAJEG DDCEIPJJNAJ, bool FJHHPGCJJCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x631CC10", Offset = "0x631B610", VA = "0x18631CC10")]
	private void PIHMNACFKPC(HPFGCBBAIID KCEHFOIJDJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6318640", Offset = "0x6317040", VA = "0x186318640")]
	private static bool AGMHPHKLBLI(MKEOHMJJHMD DLKMOHNJOLD, IReadOnlyDictionary<AALDFAGJKHE, MKEOHMJJHMD> JLLBCHDEGDH, out IReadOnlyList<HJCEOIBEONB> HHFILNMHGIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x631C3B0", Offset = "0x631ADB0", VA = "0x18631C3B0")]
	[AsyncStateMachine(typeof(CAAEHOGHOLH))]
	private static Task LNEOJJDNGIE(CBGBEJPCLKD CLINNHAKMAF, ALDNBFOLDOE GOKPFGBACOI, IReadOnlyDictionary<AALDFAGJKHE, MKEOHMJJHMD> JLLBCHDEGDH, NHOBFCMCDOK HNGDIECMCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x631C8C0", Offset = "0x631B2C0", VA = "0x18631C8C0")]
	[CompilerGenerated]
	internal static void PBNCIGDPHEI(Func<DCJLBCEKAAB, HDOKKMJKLLA> GMABEGJACLE, ref HJFJCFMKMHF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x631ABD0", Offset = "0x63195D0", VA = "0x18631ABD0")]
	[CompilerGenerated]
	internal static bool KKFPEIHNMDC(AALDFAGJKHE ENHDGCJILNE, HJCEOIBEONB HHCGHKIPMPP, out COMGONFGDDI MKBFKIDDDOD, ref CIOEKGJBPFN P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HLNPKJCKJGB
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOPKKNIGJPJ(IEIHKFAAJEG GAMLPGLFCCE, IEIHKFAAJEG FKNNHHKJCKD, IEnumerable<IEIHKFAAJEG> MNGKNBJMAAP, out BODHECLGFJO GILKCIEHCLO, out JLFGLCJIJPO ECOPCJALBJG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum JLFGLCJIJPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class JIDFAGDIIKJ : HLNPKJCKJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly DPNKEONOFML KBLFINPNNFA;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x74A940", Offset = "0x749340", VA = "0x18074A940")]
	[RecRoom.NoEngine.Common.Preserve]
	public JIDFAGDIIKJ([LIKONNNLKGK(null)] DPNKEONOFML LJPKDCIFDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x631DE00", Offset = "0x631C800", VA = "0x18631DE00")]
	private static BFKOGJLBEFA? MBPLLJMNCJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x631DCF0", Offset = "0x631C6F0", VA = "0x18631DCF0", Slot = "4")]
	public bool KOPKKNIGJPJ(IEIHKFAAJEG GAMLPGLFCCE, IEIHKFAAJEG FKNNHHKJCKD, IEnumerable<IEIHKFAAJEG> MNGKNBJMAAP, out BODHECLGFJO GILKCIEHCLO, out JLFGLCJIJPO ECOPCJALBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x631DE50", Offset = "0x631C850", VA = "0x18631DE50")]
	internal bool MMLFAEAIGMM(IEIHKFAAJEG GAMLPGLFCCE, IEIHKFAAJEG FKNNHHKJCKD, IEnumerable<IEIHKFAAJEG> MNGKNBJMAAP, LLBNMMPGAFE DDACBKFDEHC, BFKOGJLBEFA? DAKDHNGOEOB, out BODHECLGFJO GILKCIEHCLO, out JLFGLCJIJPO ECOPCJALBJG)
	{
		return default(bool);
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
