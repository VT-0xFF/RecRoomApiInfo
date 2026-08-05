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
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6034490", Offset = "0x6033890", VA = "0x186034490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x778380", Offset = "0x777780", VA = "0x180778380")]
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
		[Cpp2IlInjected.Address(RVA = "0xFCBE90", Offset = "0xFCB290", VA = "0x180FCBE90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KPLBLNJELCC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BJFGKLBBPJD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void CKAKJGAPDDM<TPermission>(TPermission PMDCHBBJDGN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void EKLACKDCCKB(JEHHKLECEGB AGDFLBCNCIL);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IIMNLAEEPGP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MGHELKKLOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LOPOFCIEMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AFONLMAJMDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JHPLDALDGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NJNELDMGKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BELEMAOIGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BODKGJPAAHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GAINPPPGFJC LOHHMDFHPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<GAAIADGFKCG> OAIOFGFEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EKLACKDCCKB OCIBCGGIFFH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<GAAIADGFKCG> OANDMGHLDCD(bool ILDHADFDMAK = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GAAIADGFKCG EEMGOCMJPLM(JEHHKLECEGB AGDFLBCNCIL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JKOPJMKOOCE(JEHHKLECEGB AGDFLBCNCIL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<GAAIADGFKCG> CHJPKBJKGPP(JEHHKLECEGB AGDFLBCNCIL, bool ODOLFOCOLKC = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CKAECDAJEML(JEHHKLECEGB IPKPDCFFBAG, OGBJCPACCPN CKDDMFPIAHD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GAAIADGFKCG GJDJLHAJLOG(OGBJCPACCPN CKDDMFPIAHD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JEPLHMIANFB<T>(OGBJCPACCPN CKDDMFPIAHD, MEEDCIKKNMD PMDCHBBJDGN, bool KCOFDHIDLIM, T DEMGJAEGHAE) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AJJAMMDAGFH
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ADHGAOIBAKG(LNPAGJDMHMD FOGLEECNIFC, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBHFFMLGJIG(ref LNPAGJDMHMD FOGLEECNIFC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LOOABMJFNHP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JEHHKLECEGB JLDBICMPKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OAILMIHJFAK GIOJNHONMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JIAGHJHJMHD LFIKIBAJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AGHDLKGKLGK> PDFJPCDKCFI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OHEHMHBMGCE;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OGBJCPACCPN DFCNCIFABMB(JEHHKLECEGB AGDFLBCNCIL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AGHDLKGKLGK> CCBLLFMNDMC(CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BCNHFIMDKAE(long COLNHBBPCAP, long JPKIIMPIPPD, IReadOnlyList<LHCPPIPINGM> AGGDNOBJGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<JEHHKLECEGB> KBNLMJAHDAJ();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NMOGIJCGMBE
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6034430", Offset = "0x6033830", VA = "0x186034430")]
	public static OGBJCPACCPN JHCFGFGNIHB(this LOOABMJFNHP DCDEMGODNCE)
	{
		return default(OGBJCPACCPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EONHONPKHBN<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string PODAOHGAMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::CKAKJGAPDDM<TPermission> FPLOIJKOMLI;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class IBOKOEJCHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum EEDOKFLPLDG
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
	public static readonly Guid DEMNAECGAAN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KMEPMBDNPAO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid JAFLOEFDJIO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid OLLFBBHBCFC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid MAIJILMHAOF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::ANJLMJKGMBM<OGBJCPACCPN, Guid> LMBLBDKCJMO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<OGBJCPACCPN> KODOGCCBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x602C110", Offset = "0x602B510", VA = "0x18602C110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x602C230", Offset = "0x602B630", VA = "0x18602C230")]
	public static OGBJCPACCPN JAMNOLJCKEE(Guid CFOLAEKFCNI)
	{
		return default(OGBJCPACCPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x602C3E0", Offset = "0x602B7E0", VA = "0x18602C3E0")]
	public static Guid MEOCJJDKIOF(OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x602C190", Offset = "0x602B590", VA = "0x18602C190")]
	public static bool HHCNNFLMEDM(OGBJCPACCPN CKDDMFPIAHD, out Guid CFOLAEKFCNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x602C490", Offset = "0x602B890", VA = "0x18602C490")]
	public static bool OFNCAGPCCEM(Guid CFOLAEKFCNI, out OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x602C2C0", Offset = "0x602B6C0", VA = "0x18602C2C0")]
	public static OGBJCPACCPN JMAPCMKEHCB(OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(OGBJCPACCPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x602C330", Offset = "0x602B730", VA = "0x18602C330")]
	public static EEDOKFLPLDG LJELJPJIEPE(OGBJCPACCPN APKFJJNHHNI)
	{
		return default(EEDOKFLPLDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x602C2F0", Offset = "0x602B6F0", VA = "0x18602C2F0")]
	internal static OGBJCPACCPN KBJOANILDBB(EEDOKFLPLDG NOGJGJMDIOM)
	{
		return default(OGBJCPACCPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class NFKLBOJBOAA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CMEGHCIJODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	protected NFKLBOJBOAA(object? BMNHPBLKEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JGDEPBFEPKN(object? FPLJCBGEJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KJLPHNJMNAI<T> : NFKLBOJBOAA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T EMCMCBNCOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> GEAAADGJPLD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x48963B0", Offset = "0x48957B0", VA = "0x1848963B0", Slot = "4")]
	public override bool JGDEPBFEPKN(object? FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4895FD0", Offset = "0x48953D0", VA = "0x184895FD0")]
	public bool GPPLLOENGMA(T PLOCOGNIKJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4896660", Offset = "0x4895A60", VA = "0x184896660")]
	public KJLPHNJMNAI(T IEMLIFLCGLH, IEqualityComparer<T> GEAAADGJPLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ICJOILIGJJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<MEEDCIKKNMD, bool> EICDJOLDILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<MEEDCIKKNMD, NFKLBOJBOAA> NEBDIPLFPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JAPGJMNHOMF PFKJFAINOEB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x602CC80", Offset = "0x602C080", VA = "0x18602CC80")]
	public ICJOILIGJJB(JAPGJMNHOMF PFKJFAINOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x602CC10", Offset = "0x602C010", VA = "0x18602CC10")]
	public bool OCEJGOPPOEN(MEEDCIKKNMD PMDCHBBJDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3425370", Offset = "0x3424770", VA = "0x183425370")]
	public bool JCAIENCKGOC<T>(MEEDCIKKNMD PMDCHBBJDGN, bool KCOFDHIDLIM, T FPLJCBGEJAP) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34256F0", Offset = "0x3424AF0", VA = "0x1834256F0")]
	public (bool, T?) MKKHAEJHAHK<T>(MEEDCIKKNMD PMDCHBBJDGN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x602C9A0", Offset = "0x602BDA0", VA = "0x18602C9A0")]
	public bool JCAIENCKGOC(MEEDCIKKNMD PMDCHBBJDGN, bool KCOFDHIDLIM, object FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x602CB40", Offset = "0x602BF40", VA = "0x18602CB40")]
	public (bool, object) MKKHAEJHAHK(MEEDCIKKNMD PMDCHBBJDGN)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3425030", Offset = "0x3424430", VA = "0x183425030")]
	private void HCNELBIMFOP<T>(MEEDCIKKNMD PMDCHBBJDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x602CA80", Offset = "0x602BE80", VA = "0x18602CA80")]
	private NFKLBOJBOAA MGMMAMLEEEC(MEEDCIKKNMD PMDCHBBJDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x602C800", Offset = "0x602BC00", VA = "0x18602C800")]
	public void IJIKLJAGFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OIFJKJKGDOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string BPMBBFLJLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type PNJMCGGJIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly GIGHGEMGOJA CJBIILEDEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly MEEDCIKKNMD JNJHCBCKKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GCHOPNMOKGO DDDELEEOGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EMADKIENJDM FKFFOODODMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JHHMFNGBLCG HCILHFBPFOH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6034610", Offset = "0x6033A10", VA = "0x186034610")]
	public OIFJKJKGDOO(Type AHGHBDDJJOH, string BAMLFEGHNBO, MEEDCIKKNMD PMDCHBBJDGN, GCHOPNMOKGO OIIMNNJCGAJ, EMADKIENJDM HEKCIBDHOBN, JHHMFNGBLCG FEONKHEGGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6034520", Offset = "0x6033920", VA = "0x186034520")]
	public object DOBLGFEOFAK(object? FJLHJLAMLMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x32176E0", Offset = "0x3216AE0", VA = "0x1832176E0")]
	public void HCNELBIMFOP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6034560", Offset = "0x6033960", VA = "0x186034560")]
	public void HCNELBIMFOP(Type EIHMJIHBPCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NNCHEAPCOBK<T> : OIFJKJKGDOO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string GPHKPJECMLP(T FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T KDCEHCDLBHN(string? COLCGHACINE, T IEMLIFLCGLH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class JHDKNIDOALI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GPHKPJECMLP serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KDCEHCDLBHN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public JHDKNIDOALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x328ACF0", Offset = "0x328A0F0", VA = "0x18328ACF0")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x328AD10", Offset = "0x328A110", VA = "0x18328AD10")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3354D80", Offset = "0x3354180", VA = "0x183354D80")]
	public NNCHEAPCOBK(MEEDCIKKNMD PMDCHBBJDGN, string BAMLFEGHNBO, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC40B0", Offset = "0xC34B0")] global::NNCHEAPCOBK<T>.GPHKPJECMLP OIIMNNJCGAJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC4110", Offset = "0xC3510")] global::NNCHEAPCOBK<T>.KDCEHCDLBHN HEKCIBDHOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3353DD0", Offset = "0x33531D0", VA = "0x183353DD0")]
	private static object? AHLFMBEKFNG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC4170", Offset = "0xC3570")] global::NNCHEAPCOBK<T?>.KDCEHCDLBHN? HEKCIBDHOBN, string? COLCGHACINE, object? IEMLIFLCGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3354420", Offset = "0x3353820", VA = "0x183354420")]
	private static string DGECGJPLFOM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC41D0", Offset = "0xC35D0")] global::NNCHEAPCOBK<T>.GPHKPJECMLP ADCOLHOIMEA, object? FPLJCBGEJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string GCHOPNMOKGO(object? FPLJCBGEJAP);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object EMADKIENJDM(string? COLCGHACINE, [Optional] object IEMLIFLCGLH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate NFKLBOJBOAA JHHMFNGBLCG();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JAPGJMNHOMF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class GCFEDMMDOCE : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static GCFEDMMDOCE KGGJIHLJBIH;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x602B4D0", Offset = "0x602A8D0", VA = "0x18602B4D0", Slot = "4")]
		public bool Equals(List<string> IMDGNLLHHDC, List<string> NJNDPGIDOBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x602B630", Offset = "0x602AA30", VA = "0x18602B630", Slot = "5")]
		public int GetHashCode(List<string> JGHFLANLLNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public GCFEDMMDOCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DFDODKNOGHL : global::EPGKLPEKMEK<KPLBLNJELCC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x602AB80", Offset = "0x6029F80", VA = "0x18602AB80", Slot = "9")]
		public override string DGECGJPLFOM(KPLBLNJELCC LEPPMEPJHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x602AC80", Offset = "0x602A080", VA = "0x18602AC80", Slot = "10")]
		protected override bool PODBLEABCEO(string LEPPMEPJHOI, out KPLBLNJELCC FPLJCBGEJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x602AE70", Offset = "0x602A270", VA = "0x18602AE70")]
		public DFDODKNOGHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly NOFFHCJBPJJ DHIOHGNBNON;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly DFDODKNOGHL EADEBCABOBC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<OIFJKJKGDOO> HMHAKDMKDKH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<MEEDCIKKNMD> MMFBILNMJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<MEEDCIKKNMD, OIFJKJKGDOO> OFIBKIIEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x602DB00", Offset = "0x602CF00", VA = "0x18602DB00")]
	public JAPGJMNHOMF([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC4230", Offset = "0xC3630")] IList<OIFJKJKGDOO> GJAAHLGGPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x602CF10", Offset = "0x602C310", VA = "0x18602CF10")]
	public OIFJKJKGDOO DEKMMBBJDEN(MEEDCIKKNMD PMDCHBBJDGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GAINPPPGFJC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GAAIADGFKCG JLNIAJHMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HHDGANLBHIO : GAINPPPGFJC
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static HHDGANLBHIO OPFKNAEKHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly CAOPGOIOKAA EANODGKNBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<CAOPGOIOKAA> EEEAGCPDOIA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GAAIADGFKCG JLNIAJHMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x602C010", Offset = "0x602B410", VA = "0x18602C010")]
	public HHDGANLBHIO(CAOPGOIOKAA BGFBPMOCFFC, IReadOnlyList<CAOPGOIOKAA> JOABDMOOIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x602B7D0", Offset = "0x602ABD0", VA = "0x18602B7D0")]
	private static HHDGANLBHIO MILFCACCKBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JELHGODLFGP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<OGBJCPACCPN> KGAJPOBHLBP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x602DE70", Offset = "0x602D270", VA = "0x18602DE70")]
	public static bool ENMKCGANBLN(this JEHHKLECEGB NKBGOBOMGOG, OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x602DF60", Offset = "0x602D360", VA = "0x18602DF60")]
	public static bool LKHPGFLDNKD(this JEHHKLECEGB NKBGOBOMGOG, OGBJCPACCPN CKDDMFPIAHD, JIAGHJHJMHD GNBAMMLEGON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IHFOBPFLOMI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LMIONPOHDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HEELDENPEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KGIAFBOGFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EPLPNOFOGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PFCOOFOFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JFEHDLILMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ALEKBLAGAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CIBDEMBHMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NPMAELHFJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IBENHLNINHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BPAGCJJDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OJBFHKKELOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> EKDGCLHDONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KPLBLNJELCC FKNMLJHJLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GAAIADGFKCG : IHFOBPFLOMI, IIMNLAEEPGP, global::EONHONPKHBN<MEEDCIKKNMD>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string ELALACACAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OGBJCPACCPN MMACCMOFLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) MLPMIAJPHKH<T>(MEEDCIKKNMD PMDCHBBJDGN) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum MEEDCIKKNMD
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
internal class CAOPGOIOKAA : GAAIADGFKCG, IHFOBPFLOMI, IIMNLAEEPGP, global::EONHONPKHBN<MEEDCIKKNMD>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly JAPGJMNHOMF FPJMGBCOHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly ICJOILIGJJB KAABDEOCCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? KHGHPJLNIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? HDMJCABJFKF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool LMIONPOHDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x602A6C0", Offset = "0x6029AC0", VA = "0x18602A6C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KPLBLNJELCC FKNMLJHJLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x602A8A0", Offset = "0x6029CA0", VA = "0x18602A8A0", Slot = "20")]
		get
		{
			return default(KPLBLNJELCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool HEELDENPEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6029BB0", Offset = "0x6028FB0", VA = "0x186029BB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KGIAFBOGFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6028CC0", Offset = "0x60280C0", VA = "0x186028CC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EPLPNOFOGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x602A850", Offset = "0x6029C50", VA = "0x18602A850", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PFCOOFOFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6029370", Offset = "0x6028770", VA = "0x186029370", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool JFEHDLILMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6028AE0", Offset = "0x6027EE0", VA = "0x186028AE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ALEKBLAGAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6028B30", Offset = "0x6027F30", VA = "0x186028B30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool CIBDEMBHMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6029B10", Offset = "0x6028F10", VA = "0x186029B10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NPMAELHFJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x602A760", Offset = "0x6029B60", VA = "0x18602A760", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> EKDGCLHDONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6028A80", Offset = "0x6027E80", VA = "0x186028A80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NKPAFEHPDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60295F0", Offset = "0x60289F0", VA = "0x1860295F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MLOGKEFFPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6028D10", Offset = "0x6028110", VA = "0x186028D10", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FECJAKMCNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60289E0", Offset = "0x6027DE0", VA = "0x1860289E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IBENHLNINHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6029B60", Offset = "0x6028F60", VA = "0x186029B60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BPAGCJJDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6029A70", Offset = "0x6028E70", VA = "0x186029A70", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool MIIOKHHGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6028E00", Offset = "0x6028200", VA = "0x186028E00", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OJBFHKKELOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6028D60", Offset = "0x6028160", VA = "0x186028D60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HPLMNCGOGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6028A30", Offset = "0x6027E30", VA = "0x186028A30", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LGGMANNNMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6029AC0", Offset = "0x6028EC0", VA = "0x186029AC0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool LCBCIOKNFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x60295F0", Offset = "0x60289F0", VA = "0x1860295F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool GLDCJLBCAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x60289E0", Offset = "0x6027DE0", VA = "0x1860289E0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool EMJKIEEOBOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6028E00", Offset = "0x6028200", VA = "0x186028E00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool CCBDGMFFBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6028A30", Offset = "0x6027E30", VA = "0x186028A30", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool DEJFMNHJMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6028D10", Offset = "0x6028110", VA = "0x186028D10", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool OBKKLDPDNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6029AC0", Offset = "0x6028EC0", VA = "0x186029AC0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OGBJCPACCPN MMACCMOFLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OGBJCPACCPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85F6C0", Offset = "0x85EAC0", VA = "0x18085F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string PODAOHGAMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6028DB0", Offset = "0x60281B0", VA = "0x186028DB0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x602A710", Offset = "0x6029B10", VA = "0x18602A710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string ELALACACAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6028DB0", Offset = "0x60281B0", VA = "0x186028DB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MELONCDNLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x782DE0", Offset = "0x7821E0", VA = "0x180782DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x782E60", Offset = "0x782260", VA = "0x180782E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::CKAKJGAPDDM<MEEDCIKKNMD> FPLOIJKOMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x602A7B0", Offset = "0x6029BB0", VA = "0x18602A7B0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6028B80", Offset = "0x6027F80", VA = "0x186028B80", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x60293E0", Offset = "0x60287E0", VA = "0x1860293E0")]
	public CNIJBMILBEL JFMHFLIDEMG(Func<OGBJCPACCPN, Guid> LFFOGGIOCJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6029D10", Offset = "0x6029110", VA = "0x186029D10")]
	public void NKJHBJOGJNL(CNIJBMILBEL NFBIGDALOIP, Func<Guid, OGBJCPACCPN> GADECABBDHB, [Optional] OGBJCPACCPN? LIHENAIOAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x32A27E0", Offset = "0x32A1BE0", VA = "0x1832A27E0", Slot = "6")]
	public (bool, T?) MLPMIAJPHKH<T>(MEEDCIKKNMD PMDCHBBJDGN) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x32A27A0", Offset = "0x32A1BA0", VA = "0x1832A27A0")]
	public CAOPGOIOKAA BALIDHBDPMA<T>(MEEDCIKKNMD PMDCHBBJDGN, bool KCOFDHIDLIM, T FPLJCBGEJAP) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x602A960", Offset = "0x6029D60", VA = "0x18602A960")]
	public CAOPGOIOKAA(OGBJCPACCPN CKDDMFPIAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x602A980", Offset = "0x6029D80", VA = "0x18602A980")]
	public CAOPGOIOKAA(OGBJCPACCPN CKDDMFPIAHD, [Optional] string? KHGHPJLNIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x602A9A0", Offset = "0x6029DA0", VA = "0x18602A9A0")]
	public CAOPGOIOKAA(CAOPGOIOKAA JMNLOMOBDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x602AA30", Offset = "0x6029E30", VA = "0x18602AA30")]
	internal CAOPGOIOKAA(OGBJCPACCPN BIKDFGMIIGE, [Optional] string? KHGHPJLNIEO, [Optional] CAOPGOIOKAA? JMNLOMOBDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6029C00", Offset = "0x6029000", VA = "0x186029C00")]
	public static GIGHGEMGOJA MLPPCJDCNKG(MEEDCIKKNMD PMDCHBBJDGN)
	{
		return default(GIGHGEMGOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x60293C0", Offset = "0x60287C0", VA = "0x1860293C0")]
	public void IJIKLJAGFLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6029030", Offset = "0x6028430", VA = "0x186029030")]
	internal CAOPGOIOKAA ICAGPGMILPE(CAOPGOIOKAA PONDGBHLKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6029640", Offset = "0x6028A40", VA = "0x186029640")]
	internal IReadOnlyCollection<MEEDCIKKNMD> JOLBHMNFBGF(CAOPGOIOKAA JMNLOMOBDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6028E50", Offset = "0x6028250", VA = "0x186028E50")]
	public bool HOKMCMNIFFL(MEEDCIKKNMD PMDCHBBJDGN, bool KCOFDHIDLIM, string OKGPBEABNFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6028F30", Offset = "0x6028330", VA = "0x186028F30")]
	public (bool, string) IBBNLPPGBOF(MEEDCIKKNMD PMDCHBBJDGN)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6028C20", Offset = "0x6028020", VA = "0x186028C20")]
	internal void EBBFJEDALBF(MEEDCIKKNMD PMDCHBBJDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6029C80", Offset = "0x6029080", VA = "0x186029C80")]
	[CompilerGenerated]
	private void NDDGMJDBKCA(MEEDCIKKNMD GELMBEPGDDK, MENPKLNCHDP MAAPEPKJKKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KBFCEKHPFLF : AJJAMMDAGFH, BODKGJPAAHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class IFMNJGLGLJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CAOPGOIOKAA newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public IFMNJGLGLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x602CEE0", Offset = "0x602C2E0", VA = "0x18602CEE0")]
		internal bool <InitializeRolesLists>b__0(CAOPGOIOKAA rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class LBPDJMMJALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OGBJCPACCPN roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public LBPDJMMJALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6034420", Offset = "0x6033820", VA = "0x186034420")]
		internal bool <UpdateRoleDatas>b__0(OGBJCPACCPN r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OOOIDCMADHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KBFCEKHPFLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LNPAGJDMHMD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC4880", Offset = "0xC3C80")]
		private TaskAwaiter<AGHDLKGKLGK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60346A0", Offset = "0x6033AA0", VA = "0x1860346A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FILLCJBJCMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public FILLCJBJCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x602B2D0", Offset = "0x602A6D0", VA = "0x18602B2D0")]
		internal void <RunBackwardsCompatibilityMigration>b__0(CNIJBMILBEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x602B3B0", Offset = "0x602A7B0", VA = "0x18602B3B0")]
		internal void <RunBackwardsCompatibilityMigration>b__1(CNIJBMILBEL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CNENLNDCACE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LNPAGJDMHMD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JMMCFOGIFPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC48E0", Offset = "0xC3CE0")]
		public Func<CNIJBMILBEL, MENPKLNCHDP> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public JMMCFOGIFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x602E1B0", Offset = "0x602D5B0", VA = "0x18602E1B0")]
		internal void <MigrateLegacyHostSettings>b__1(CNIJBMILBEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x602E210", Offset = "0x602D610", VA = "0x18602E210")]
		internal void <MigrateLegacyHostSettings>b__2(CNIJBMILBEL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x602E270", Offset = "0x602D670", VA = "0x18602E270")]
		internal void <MigrateLegacyHostSettings>b__3(CNIJBMILBEL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GAKIDMJNELP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KBFCEKHPFLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public MEEDCIKKNMD rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OGBJCPACCPN accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GIGHGEMGOJA recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public GAKIDMJNELP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ICAHCPGDBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<LHCPPIPINGM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KJJPAJMPBIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public LOOABMJFNHP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LNPAGJDMHMD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC49F0", Offset = "0xC3DF0")]
		public IReadOnlyDictionary<OGBJCPACCPN, CAOPGOIOKAA> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BKDBAAFNNFG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6033A10", Offset = "0x6032E10", VA = "0x186033A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly LOOABMJFNHP DCDEMGODNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HHDGANLBHIO HJKNKHPFBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BKDBAAFNNFG ONHMGPFCGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, CAOPGOIOKAA> ODEIIELLDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<OGBJCPACCPN, CAOPGOIOKAA> PFPOJKGNJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<OGBJCPACCPN, CAOPGOIOKAA> FBELBJFELPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<CAOPGOIOKAA> DPBODDHFPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool PFAJPMHCGBG;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly MEEDCIKKNMD[] BFBGALONFIC;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GAINPPPGFJC LOHHMDFHPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<GAAIADGFKCG> OAIOFGFEBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60314F0", Offset = "0x60308F0", VA = "0x1860314F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EKLACKDCCKB OCIBCGGIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x602FE90", Offset = "0x602F290", VA = "0x18602FE90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6031D80", Offset = "0x6031180", VA = "0x186031D80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6032A10", Offset = "0x6031E10", VA = "0x186032A10")]
	[KPHLIICFIPJ(JAIGHIDJKOL.Room, OEKFJILJDLM.None)]
	private static void NBKPOCLHNMG(BHKHBEKDAPI EDJAHGEIPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6033780", Offset = "0x6032B80", VA = "0x186033780")]
	[UnityEngine.Scripting.Preserve]
	internal KBFCEKHPFLF([ANGFGGDOPHE(null)] LOOABMJFNHP DIHBOFDOFHJ, [ANGFGGDOPHE(null)] HHDGANLBHIO AFEGNGLJPJB, [ANGFGGDOPHE(null)] BKDBAAFNNFG ONHMGPFCGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x602F530", Offset = "0x602E930", VA = "0x18602F530", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x602EAE0", Offset = "0x602DEE0", VA = "0x18602EAE0")]
	private void CFOMPEIFMLC(IEnumerable<CAOPGOIOKAA> GCGKJMCEIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6031E20", Offset = "0x6031220", VA = "0x186031E20", Slot = "12")]
	public bool JKOPJMKOOCE(JEHHKLECEGB AGDFLBCNCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6032E10", Offset = "0x6032210", VA = "0x186032E10")]
	private void OHEHMHBMGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6031BF0", Offset = "0x6030FF0", VA = "0x186031BF0")]
	private void ILLMIDHDFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6032D90", Offset = "0x6032190", VA = "0x186032D90", Slot = "10")]
	public IReadOnlyList<GAAIADGFKCG> OANDMGHLDCD(bool ILDHADFDMAK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x602F640", Offset = "0x602EA40", VA = "0x18602F640", Slot = "11")]
	public GAAIADGFKCG EEMGOCMJPLM(JEHHKLECEGB AGDFLBCNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x602F470", Offset = "0x602E870", VA = "0x18602F470")]
	private OGBJCPACCPN DHJIKADDFJF(JEHHKLECEGB AGDFLBCNCIL)
	{
		return default(OGBJCPACCPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x602F2E0", Offset = "0x602E6E0", VA = "0x18602F2E0", Slot = "14")]
	public bool CKAECDAJEML(JEHHKLECEGB IPKPDCFFBAG, OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6031540", Offset = "0x6030940", VA = "0x186031540", Slot = "15")]
	public GAAIADGFKCG GJDJLHAJLOG(OGBJCPACCPN CKDDMFPIAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x602E720", Offset = "0x602DB20", VA = "0x18602E720")]
	private static bool CBKGDANHPHN(NEHOONJGLNC HCAAMIEFLIK, OGBJCPACCPN CKDDMFPIAHD, out CNIJBMILBEL? KPJDIIAMDIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x60317F0", Offset = "0x6030BF0", VA = "0x1860317F0")]
	private static void HAJDDGPFNDI(NEHOONJGLNC HCAAMIEFLIK, Action<CNIJBMILBEL> FMCMCLJJLIP, OGBJCPACCPN KBAMECFDGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x60315F0", Offset = "0x60309F0", VA = "0x1860315F0")]
	private static void HAJDDGPFNDI(NEHOONJGLNC HCAAMIEFLIK, Action<CNIJBMILBEL> FMCMCLJJLIP, Predicate<OGBJCPACCPN> EMJFMHMPDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6032630", Offset = "0x6031A30", VA = "0x186032630")]
	private void LPLMPBBEOJH(JEHHKLECEGB AGDFLBCNCIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x602E2D0", Offset = "0x602D6D0", VA = "0x18602E2D0", Slot = "4")]
	[AsyncStateMachine(typeof(OOOIDCMADHE))]
	public Task ADHGAOIBAKG([CanBeNull] LNPAGJDMHMD FOGLEECNIFC, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
	public void JBHFFMLGJIG(ref LNPAGJDMHMD FOGLEECNIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6031280", Offset = "0x6030680", VA = "0x186031280")]
	private void GDFLMFAHCPM(NEHOONJGLNC PNMMMNELHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x60318F0", Offset = "0x6030CF0", VA = "0x1860318F0")]
	internal static string HBKDIILPKCK(LOOABMJFNHP DCDEMGODNCE, LNPAGJDMHMD FOGLEECNIFC, IReadOnlyDictionary<OGBJCPACCPN, CAOPGOIOKAA> PFPOJKGNJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x602FF30", Offset = "0x602F330", VA = "0x18602FF30")]
	private static void FNDHOGCDCAE(LNPAGJDMHMD FOGLEECNIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x602E410", Offset = "0x602D810", VA = "0x18602E410")]
	private static void AILIPBEEJNA(NEHOONJGLNC OAPJEHEFJMF, IReadOnlyDictionary<OGBJCPACCPN, CAOPGOIOKAA> PFPOJKGNJCE, StringBuilder HIILHIAAHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x602F750", Offset = "0x602EB50", VA = "0x18602F750")]
	private static bool FCMLIOJFCME(string GOHAEHDJHAP, out Guid NPEHMBMCHGM, out OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x602F8B0", Offset = "0x602ECB0", VA = "0x18602F8B0")]
	private static void FFHADGNPMKK(LNPAGJDMHMD FOGLEECNIFC, StringBuilder HIILHIAAHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29629D0", Offset = "0x2961DD0", VA = "0x1829629D0", Slot = "16")]
	public bool JEPLHMIANFB<T>(OGBJCPACCPN CKDDMFPIAHD, MEEDCIKKNMD PMDCHBBJDGN, bool KCOFDHIDLIM, T DEMGJAEGHAE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6032BD0", Offset = "0x6031FD0", VA = "0x186032BD0")]
	private void NCFGAIIAMGD(OGBJCPACCPN CKDDMFPIAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6032E20", Offset = "0x6032220", VA = "0x186032E20")]
	private bool PALLCNFJIDO(JEHHKLECEGB AGDFLBCNCIL, OGBJCPACCPN CKDDMFPIAHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6032FA0", Offset = "0x60323A0", VA = "0x186032FA0")]
	internal CAOPGOIOKAA PHMOKIKKNND(JEHHKLECEGB AGDFLBCNCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x602F2D0", Offset = "0x602E6D0", VA = "0x18602F2D0", Slot = "13")]
	public IReadOnlyList<GAAIADGFKCG> CHJPKBJKGPP(JEHHKLECEGB AGDFLBCNCIL, bool ODOLFOCOLKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6031060", Offset = "0x6030460", VA = "0x186031060")]
	internal IReadOnlyList<CAOPGOIOKAA> GCCDHHJGIBM(JEHHKLECEGB AGDFLBCNCIL, bool ODOLFOCOLKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6031EF0", Offset = "0x60312F0", VA = "0x186031EF0")]
	private void KDMMGMALFEE(AGHDLKGKLGK ICPOKAOEFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x60332C0", Offset = "0x60326C0", VA = "0x1860332C0")]
	private static bool PLGJAKIAHGI(CAOPGOIOKAA EJCJCFNFAHH, IReadOnlyDictionary<OGBJCPACCPN, CAOPGOIOKAA> PFPOJKGNJCE, out IReadOnlyList<MEEDCIKKNMD> JDABFPKCAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6032E40", Offset = "0x6032240", VA = "0x186032E40")]
	[AsyncStateMachine(typeof(KJJPAJMPBIA))]
	private static Task PCCMEDGIHEC(LOOABMJFNHP DCDEMGODNCE, LNPAGJDMHMD FOGLEECNIFC, IReadOnlyDictionary<OGBJCPACCPN, CAOPGOIOKAA> PFPOJKGNJCE, BKDBAAFNNFG ONHMGPFCGLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6030D90", Offset = "0x6030190", VA = "0x186030D90")]
	[CompilerGenerated]
	internal static void FONDLNIMLKJ(Func<CNIJBMILBEL, MENPKLNCHDP> HCGFLEFKGMK, ref CNENLNDCACE P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6032690", Offset = "0x6031A90", VA = "0x186032690")]
	[CompilerGenerated]
	internal static bool MDNOCBPKEIE(OGBJCPACCPN CKDDMFPIAHD, MEEDCIKKNMD PMDCHBBJDGN, out LHCPPIPINGM KGJBFPHIFKM, ref ICAHCPGDBDG P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CIHCNCFAHIL
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HFLPFPCMMFC(JEHHKLECEGB NKDJCDJIGJP, JEHHKLECEGB EGBOCHOOPOC, IEnumerable<JEHHKLECEGB> DHGKPJMOPAP, out KPLBLNJELCC FBGAINCKDAM, out KIHDFCPFCAC ONDOLBPDICP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum KIHDFCPFCAC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class BBADHCMADPN : CIHCNCFAHIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly BODKGJPAAHC NGALMKBBAJO;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	[RecRoom.NoEngine.Common.Preserve]
	public BBADHCMADPN([ANGFGGDOPHE(null)] BODKGJPAAHC ELOGABDGOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6028990", Offset = "0x6027D90", VA = "0x186028990")]
	private static GNHKMHKKAKO? MNKHFODPLCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6028880", Offset = "0x6027C80", VA = "0x186028880", Slot = "4")]
	public bool HFLPFPCMMFC(JEHHKLECEGB NKDJCDJIGJP, JEHHKLECEGB EGBOCHOOPOC, IEnumerable<JEHHKLECEGB> DHGKPJMOPAP, out KPLBLNJELCC FBGAINCKDAM, out KIHDFCPFCAC ONDOLBPDICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6028370", Offset = "0x6027770", VA = "0x186028370")]
	internal bool EHDJMAIOAFA(JEHHKLECEGB NKDJCDJIGJP, JEHHKLECEGB EGBOCHOOPOC, IEnumerable<JEHHKLECEGB> DHGKPJMOPAP, JIAGHJHJMHD GNBAMMLEGON, GNHKMHKKAKO? BEEKLIIINGD, out KPLBLNJELCC FBGAINCKDAM, out KIHDFCPFCAC ONDOLBPDICP)
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
