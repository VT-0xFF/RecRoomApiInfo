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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FFFB00", Offset = "0x6FFEF00", VA = "0x186FFFB00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MBOHBBBANAN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NPBIALAKODJ<TPermission>(TPermission JJMFMMELMJH);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void GKGAAKLDJBJ(OOGKCGEGFAA MPPBKBAPBEE);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MKNNINKBKOG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HGGEJONNHHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMKMJMBIODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DCEDDIJAFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LFGKAPBAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HLKGGMDCADM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MMBGFCJPLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GGLNGOOCNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class ICAJKLCAHAL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum HDDGPHFEGEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid JLILAHEGIJN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid DEELPDMDBNI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid PDELECHABAI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid BOIKAGMPFBK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid CNAAOOEACEJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid LFJAMLPFNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly ELKKPICELGN<PPPMMMCJDKO, Guid> DGIJHOHIHIN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<PPPMMMCJDKO> JFCMJDOABEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8530", Offset = "0x6FF7930", VA = "0x186FF8530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FF84A0", Offset = "0x6FF78A0", VA = "0x186FF84A0")]
	public static PPPMMMCJDKO CEFCEAIFNAA(Guid HLKHAOEDAIN)
	{
		return default(PPPMMMCJDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8400", Offset = "0x6FF7800", VA = "0x186FF8400")]
	public static Guid BJCFJEKPNAK(PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8370", Offset = "0x6FF7770", VA = "0x186FF8370")]
	public static bool AOAPJGOCDDL(PPPMMMCJDKO NMOCKHJLFON, [Out] Guid HLKHAOEDAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FF86A0", Offset = "0x6FF7AA0", VA = "0x186FF86A0")]
	public static bool JKIGHNMBMGB(Guid HLKHAOEDAIN, [Out] PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FF85B0", Offset = "0x6FF79B0", VA = "0x186FF85B0")]
	public static PPPMMMCJDKO GBALJIBFLHD(PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(PPPMMMCJDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FF85F0", Offset = "0x6FF79F0", VA = "0x186FF85F0")]
	public static HDDGPHFEGEP HJEKCGAHANJ(PPPMMMCJDKO GPPBJBJBFJO)
	{
		return default(HDDGPHFEGEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8330", Offset = "0x6FF7730", VA = "0x186FF8330")]
	internal static PPPMMMCJDKO AGEADGNOMPG(HDDGPHFEGEP LDJECKGBNBJ)
	{
		return default(PPPMMMCJDKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BJOFIDCJGDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JKJBNNLINCG PDIPMPOJOME
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<HDIGNAAJFIB> JCNKJCECCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GKGAAKLDJBJ JEAHNHILMNG;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<HDIGNAAJFIB> HJNNKKDFONA(bool HNENLKGIEDA = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HDIGNAAJFIB IOOAMFELJKN(OOGKCGEGFAA MPPBKBAPBEE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BDMLKHMDCKH(OOGKCGEGFAA MPPBKBAPBEE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<HDIGNAAJFIB> ACKKCFGMIJO(OOGKCGEGFAA MPPBKBAPBEE, bool JHHGDFEAJEC = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EAHBNMGNFBD(OOGKCGEGFAA AJHAICGDLMI, PPPMMMCJDKO NMOCKHJLFON);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HDIGNAAJFIB GGLNDCAHCKJ(PPPMMMCJDKO NMOCKHJLFON);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DMHKEMIEMFC<T>(PPPMMMCJDKO NMOCKHJLFON, DNIMGCOBFIG JJMFMMELMJH, bool ELEDDNIPAHK, T PEGMNLKCILJ, [Optional] Action HMGMBCMKALL) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string LFJMKENPEKH(DNIMGCOBFIG JJMFMMELMJH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NCNDHOPEGHN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LMBPPMONEED(KKLGAOKAOFM AFNMBPMIHMN, CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKALKLONMME(KKLGAOKAOFM AFNMBPMIHMN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GACBNAOJNFK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OOGKCGEGFAA FBPGICPFENK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	POCEBCCPEBK EECFJHIFFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CKNBCJINDHA DIIAHFCPDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DKNDBBCGFDF> CNPPPEDFCCE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PCGCPNGCBDH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PPPMMMCJDKO FGKBLKJJOIE(OOGKCGEGFAA MPPBKBAPBEE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DKNDBBCGFDF> ILEMPJLJFKJ(CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PPCBFHEMMFN(long GICEIKJHPKB, IReadOnlyList<LEJACMAJCIG> DEEKLCECFCP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DOIJPOHKENL(long GICEIKJHPKB, long DLHGGKMFGDE, IReadOnlyList<LEJACMAJCIG> DEEKLCECFCP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<OOGKCGEGFAA> DNOPLIHCJDN();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ILCPDHNOLHG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8DA0", Offset = "0x6FF81A0", VA = "0x186FF8DA0")]
	public static PPPMMMCJDKO NEHCKIMNANH(this GACBNAOJNFK MOEBLOOGFEM)
	{
		return default(PPPMMMCJDKO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GLLPCPHOOMA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string GCIHIMEGDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NPBIALAKODJ<TPermission> NIJABGJHMIO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class PANJOHIHCEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? JGHBFIMCGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	protected PANJOHIHCEC(object? ENFEMJFNLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DLPBCJJPOIF(object? OBEEJPGJPFD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class DHKLHKOHEMO<T> : PANJOHIHCEC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T EFEADOMFEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> BDPKNEMBHED;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T KHLHBLNGCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x578E500", Offset = "0x578D900", VA = "0x18578E500", Slot = "4")]
	public override bool DLPBCJJPOIF(object? OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x578E920", Offset = "0x578DD20", VA = "0x18578E920")]
	public bool GANGODCOEFD(T MFLFOCPKACK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x578EEC0", Offset = "0x578E2C0", VA = "0x18578EEC0")]
	public DHKLHKOHEMO(T DFNADAHDJII, IEqualityComparer<T> BDPKNEMBHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ODGJAFHBIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<DNIMGCOBFIG, bool> HBDDCMFIBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<DNIMGCOBFIG, PANJOHIHCEC> NEMNIADCGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OCOJOBJMPEA BIJCMGGFFAG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70018E0", Offset = "0x7000CE0", VA = "0x1870018E0")]
	public ODGJAFHBIPM(OCOJOBJMPEA BIJCMGGFFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70015F0", Offset = "0x70009F0", VA = "0x1870015F0")]
	public bool GEFNKCGCMDJ(DNIMGCOBFIG JJMFMMELMJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C2C0", Offset = "0x2D0B6C0", VA = "0x182D0C2C0")]
	public bool NDHOAONAHFD<T>(DNIMGCOBFIG JJMFMMELMJH, bool ELEDDNIPAHK, T OBEEJPGJPFD) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BDC0", Offset = "0x2D0B1C0", VA = "0x182D0BDC0")]
	public (bool, T?) GGBCLAMFFNA<T>(DNIMGCOBFIG JJMFMMELMJH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7001800", Offset = "0x7000C00", VA = "0x187001800")]
	public bool NDHOAONAHFD(DNIMGCOBFIG JJMFMMELMJH, bool ELEDDNIPAHK, object OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7001660", Offset = "0x7000A60", VA = "0x187001660")]
	public (bool, object) GGBCLAMFFNA(DNIMGCOBFIG JJMFMMELMJH)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C260", Offset = "0x2D0B660", VA = "0x182D0C260")]
	private void MJCKFKDLGFL<T>(DNIMGCOBFIG JJMFMMELMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7001730", Offset = "0x7000B30", VA = "0x187001730")]
	private PANJOHIHCEC MJKAHOKLDGH(DNIMGCOBFIG JJMFMMELMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70013F0", Offset = "0x70007F0", VA = "0x1870013F0")]
	public void CMKIMMHCAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HKEJJOCNDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string JBICACFIAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type HKDCDEHCHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FOIEHAJAEME HPFOEKNMBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly DNIMGCOBFIG MDPHLJOCEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public IEEEMFPGFNN EIMLOFLKFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public IAKDOEGGNKP CEMNMMDCOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OAPCKBAMDJM IEFIJEKIHJD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8290", Offset = "0x6FF7690", VA = "0x186FF8290")]
	public HKEJJOCNDMG(Type MDFLEDLKGMM, string PCBJOJFBLLP, DNIMGCOBFIG JJMFMMELMJH, IEEEMFPGFNN OFFBODCBKMP, IAKDOEGGNKP GBEANMDMJFD, OAPCKBAMDJM EEKGOFHKLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8190", Offset = "0x6FF7590", VA = "0x186FF8190")]
	public object KBKAGKJOHHB(object? IEDCHGMDIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D9B0", Offset = "0x2B7CDB0", VA = "0x182B7D9B0")]
	public void MJCKFKDLGFL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF81E0", Offset = "0x6FF75E0", VA = "0x186FF81E0")]
	public void MJCKFKDLGFL(Type LNJHEPKIKLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DCNBOBOKIKJ<T> : HKEJJOCNDMG where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string FBMLNHBHAKH(T OBEEJPGJPFD);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T BKOCJBEHCGN(string? FJALCODCDPN, T DFNADAHDJII);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class EDFPPIADDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FBMLNHBHAKH serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public BKOCJBEHCGN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public EDFPPIADDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37EAB10", Offset = "0x37E9F10", VA = "0x1837EAB10")]
		internal string EDPCOFAEBIN(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37EABE0", Offset = "0x37E9FE0", VA = "0x1837EABE0")]
		internal object GLEPMFECKJH(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x577B5B0", Offset = "0x577A9B0", VA = "0x18577B5B0")]
	public DCNBOBOKIKJ(DNIMGCOBFIG JJMFMMELMJH, string PCBJOJFBLLP, [Optional] FBMLNHBHAKH? OFFBODCBKMP, [Optional] BKOCJBEHCGN? GBEANMDMJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x577A740", Offset = "0x5779B40", VA = "0x18577A740")]
	private static object? JLCLGLEKPEG(BKOCJBEHCGN? GBEANMDMJFD, string? FJALCODCDPN, object? DFNADAHDJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x577AA60", Offset = "0x5779E60", VA = "0x18577AA60")]
	private static string KPIBKDOHBCB(FBMLNHBHAKH? BMAHLIBDAIN, object? OBEEJPGJPFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string IEEEMFPGFNN(object? OBEEJPGJPFD);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object IAKDOEGGNKP(string? FJALCODCDPN, [Optional] object DFNADAHDJII);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate PANJOHIHCEC OAPCKBAMDJM();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OCOJOBJMPEA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class IGPJAKMMOBP : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static IGPJAKMMOBP CLHFPJDPLGI;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8A60", Offset = "0x6FF7E60", VA = "0x186FF8A60", Slot = "4")]
		public bool Equals(List<string> PCHHOKEGOFA, List<string> PDEIPLKJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8BB0", Offset = "0x6FF7FB0", VA = "0x186FF8BB0", Slot = "5")]
		public int GetHashCode(List<string> LALIGKIKEBM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public IGPJAKMMOBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class COHFACPBJIJ : HICHKOMIKFB<MBOHBBBANAN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7D10", Offset = "0x6FF7110", VA = "0x186FF7D10", Slot = "9")]
		public override string KPIBKDOHBCB(MBOHBBBANAN BCPLMINPIEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7B30", Offset = "0x6FF6F30", VA = "0x186FF7B30", Slot = "10")]
		protected override bool FDIFOOGBNPJ(string BCPLMINPIEH, [Out] MBOHBBBANAN OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7E00", Offset = "0x6FF7200", VA = "0x186FF7E00")]
		public COHFACPBJIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NCJCLMGOJNM HKDPFKDEFOF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly COHFACPBJIJ NIEIJHOJLJH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<HKEJJOCNDMG> EOJGDBNKAPC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<DNIMGCOBFIG> IJPJBGEGKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<DNIMGCOBFIG, HKEJJOCNDMG> PKHIPGDGGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70010A0", Offset = "0x70004A0", VA = "0x1870010A0")]
	public OCOJOBJMPEA([Optional] IList<HKEJJOCNDMG>? PNLDPOHBDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FFFB80", Offset = "0x6FFEF80", VA = "0x186FFFB80")]
	public HKEJJOCNDMG AKPOAFBNFGF(DNIMGCOBFIG JJMFMMELMJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JKJBNNLINCG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HDIGNAAJFIB FPEGJJCCCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class OLGHHMABPHM : JKJBNNLINCG
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static OLGHHMABPHM EGOFCOKFCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly ABDJKCNPANH MIIKCKJKNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<ABDJKCNPANH> LKANHGFPJKG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HDIGNAAJFIB FPEGJJCCCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70029E0", Offset = "0x7001DE0", VA = "0x1870029E0")]
	public OLGHHMABPHM(ABDJKCNPANH DAFBAABHBMM, IReadOnlyList<ABDJKCNPANH> GBEPPFAJLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7001B90", Offset = "0x7000F90", VA = "0x187001B90")]
	private static OLGHHMABPHM BPOOLBBBCCP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FPDBNLLLPOP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<PPPMMMCJDKO> ILFKAFBFGHD;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7EF0", Offset = "0x6FF72F0", VA = "0x186FF7EF0")]
	public static bool OBFNFPGINHA(this OOGKCGEGFAA BOLLDDOAFAE, PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7E70", Offset = "0x6FF7270", VA = "0x186FF7E70")]
	public static bool JNNCFIMICCD(this OOGKCGEGFAA BOLLDDOAFAE, PPPMMMCJDKO NMOCKHJLFON, CKNBCJINDHA MEFBIMIAFEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IAMPKJCEIAL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KMAKAOEIKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IDGPIKBBGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NPADMOPLPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NHCCBFKFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FECNCEFKMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HMILOIPEKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HAAJAJAPKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool KDDFBENFBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GHKAFMKGBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LLFECJLIFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CBIPIAHJCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FJFMICHMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GABEJEEAJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MBOHBBBANAN IKDLMOKDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HDIGNAAJFIB : IAMPKJCEIAL, HGGEJONNHHK, GLLPCPHOOMA<DNIMGCOBFIG>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string DFLIMNBIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	PPPMMMCJDKO OFENOFAONFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) DBDBELJOFBM<T>(DNIMGCOBFIG JJMFMMELMJH) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum DNIMGCOBFIG
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class ABDJKCNPANH : HDIGNAAJFIB, IAMPKJCEIAL, HGGEJONNHHK, GLLPCPHOOMA<DNIMGCOBFIG>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly OCOJOBJMPEA FBDKMFMBHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly ODGJAFHBIPM ADFMEGNFEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? HIBIPKKCJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? OIHDFFINDKL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool EPGMLCKJCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B20", Offset = "0x6FF4F20", VA = "0x186FF5B20", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool EJPLANIDADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6200", Offset = "0x6FF5600", VA = "0x186FF6200", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool GNBEDHNGKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5F60", Offset = "0x6FF5360", VA = "0x186FF5F60", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool CJLKIIFLPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6250", Offset = "0x6FF5650", VA = "0x186FF6250", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool GKAGBAOGMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5FB0", Offset = "0x6FF53B0", VA = "0x186FF5FB0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool MLBPAOELLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B70", Offset = "0x6FF4F70", VA = "0x186FF5B70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public PPPMMMCJDKO OFENOFAONFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PPPMMMCJDKO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x854F60", Offset = "0x854360", VA = "0x180854F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string GCIHIMEGDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6580", Offset = "0x6FF5980", VA = "0x186FF6580", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6870", Offset = "0x6FF5C70", VA = "0x186FF6870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string DFLIMNBIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6580", Offset = "0x6FF5980", VA = "0x186FF6580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KOAELKNBGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x95D4A0", Offset = "0x95C8A0", VA = "0x18095D4A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xACFFE0", Offset = "0xACF3E0", VA = "0x180ACFFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool KMAKAOEIKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF61B0", Offset = "0x6FF55B0", VA = "0x186FF61B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MBOHBBBANAN IKDLMOKDDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF77D0", Offset = "0x6FF6BD0", VA = "0x186FF77D0", Slot = "20")]
		get
		{
			return default(MBOHBBBANAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IDGPIKBBGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF65D0", Offset = "0x6FF59D0", VA = "0x186FF65D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool NPADMOPLPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6480", Offset = "0x6FF5880", VA = "0x186FF6480", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NHCCBFKFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF59A0", Offset = "0x6FF4DA0", VA = "0x186FF59A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool FECNCEFKMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF68C0", Offset = "0x6FF5CC0", VA = "0x186FF68C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HMILOIPEKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5A80", Offset = "0x6FF4E80", VA = "0x186FF5A80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HAAJAJAPKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5AD0", Offset = "0x6FF4ED0", VA = "0x186FF5AD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KDDFBENFBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6620", Offset = "0x6FF5A20", VA = "0x186FF6620", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GHKAFMKGBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7780", Offset = "0x6FF6B80", VA = "0x186FF7780", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GABEJEEAJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF64D0", Offset = "0x6FF58D0", VA = "0x186FF64D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MDLFFNNOJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B20", Offset = "0x6FF4F20", VA = "0x186FF5B20", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool MOOONCPIBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5FB0", Offset = "0x6FF53B0", VA = "0x186FF5FB0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IIAMHOJNJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6200", Offset = "0x6FF5600", VA = "0x186FF6200", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LLFECJLIFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7820", Offset = "0x6FF6C20", VA = "0x186FF7820", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CBIPIAHJCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5950", Offset = "0x6FF4D50", VA = "0x186FF5950", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OABMKBHKJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5F60", Offset = "0x6FF5360", VA = "0x186FF5F60", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FJFMICHMJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6430", Offset = "0x6FF5830", VA = "0x186FF6430", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OMHACGGINBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6250", Offset = "0x6FF5650", VA = "0x186FF6250", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CMNOFNDHKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF5B70", Offset = "0x6FF4F70", VA = "0x186FF5B70", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NPBIALAKODJ<DNIMGCOBFIG> NIJABGJHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6000", Offset = "0x6FF5400", VA = "0x186FF6000", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6380", Offset = "0x6FF5780", VA = "0x186FF6380", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3215280", Offset = "0x3214680", VA = "0x183215280", Slot = "6")]
	public (bool, T?) DBDBELJOFBM<T>(DNIMGCOBFIG JJMFMMELMJH) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3215470", Offset = "0x3214870", VA = "0x183215470")]
	public ABDJKCNPANH OBGENLFECMI<T>(DNIMGCOBFIG JJMFMMELMJH, bool ELEDDNIPAHK, T OBEEJPGJPFD) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7B10", Offset = "0x6FF6F10", VA = "0x186FF7B10")]
	public ABDJKCNPANH(PPPMMMCJDKO NMOCKHJLFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7900", Offset = "0x6FF6D00", VA = "0x186FF7900")]
	public ABDJKCNPANH(PPPMMMCJDKO NMOCKHJLFON, [Optional] string? HIBIPKKCJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7920", Offset = "0x6FF6D20", VA = "0x186FF7920")]
	public ABDJKCNPANH(ABDJKCNPANH FBLGNIJGFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF79B0", Offset = "0x6FF6DB0", VA = "0x186FF79B0")]
	internal ABDJKCNPANH(PPPMMMCJDKO PEKHBDOBNEC, [Optional] string? HIBIPKKCJDG, [Optional] ABDJKCNPANH? FBLGNIJGFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7700", Offset = "0x6FF6B00", VA = "0x186FF7700")]
	public static FOIEHAJAEME MPHOOMPBIBE(DNIMGCOBFIG JJMFMMELMJH)
	{
		return default(FOIEHAJAEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5BC0", Offset = "0x6FF4FC0", VA = "0x186FF5BC0")]
	public void CMKIMMHCAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF5BE0", Offset = "0x6FF4FE0", VA = "0x186FF5BE0")]
	internal ABDJKCNPANH DHOHFKNKDBC(ABDJKCNPANH CFDMPLIAPNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7290", Offset = "0x6FF6690", VA = "0x186FF7290")]
	internal IReadOnlyCollection<DNIMGCOBFIG> MFEBHLHMDPE(ABDJKCNPANH FBLGNIJGFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FF62A0", Offset = "0x6FF56A0", VA = "0x186FF62A0")]
	public bool HIPEAKGPCFC(DNIMGCOBFIG JJMFMMELMJH, bool ELEDDNIPAHK, string HMIBPENPMOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FF60B0", Offset = "0x6FF54B0", VA = "0x186FF60B0")]
	public (bool, string) FNDMKHFKPIP(DNIMGCOBFIG JJMFMMELMJH)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6530", Offset = "0x6FF5930", VA = "0x186FF6530")]
	internal void IGKKNGBFCMC(DNIMGCOBFIG JJMFMMELMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6670", Offset = "0x6FF5A70", VA = "0x186FF6670")]
	public MMNNOKIIBAL JJKAJKCNKEC(Func<PPPMMMCJDKO, Guid> EIFNFMNDIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6FF6910", Offset = "0x6FF5D10", VA = "0x186FF6910")]
	public void MDHGKGPABGE(MMNNOKIIBAL FKPFJHHKOAK, Func<Guid, PPPMMMCJDKO> LLCNKMKOCEB, [Optional] PPPMMMCJDKO? HEEMEKLOHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FF59F0", Offset = "0x6FF4DF0", VA = "0x186FF59F0")]
	[CompilerGenerated]
	private void AJHOGNJNLGH(DNIMGCOBFIG DNLCJDNKOOI, IFNBFOHHCOL HFGGMPJLFOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JHOOEOFCNIM : NCNDHOPEGHN, BJOFIDCJGDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DMGDLCCNNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ABDJKCNPANH newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DMGDLCCNNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7E40", Offset = "0x6FF7240", VA = "0x186FF7E40")]
		internal bool LIGJGCILDCP(ABDJKCNPANH rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HANBJFLNHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public PPPMMMCJDKO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public HANBJFLNHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8180", Offset = "0x6FF7580", VA = "0x186FF8180")]
		internal bool KIFPJPAGJON(PPPMMMCJDKO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct JOFAOOKAHMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public JHOOEOFCNIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KKLGAOKAOFM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<DKNDBBCGFDF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE940", Offset = "0x6FFDD40", VA = "0x186FFE940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6FFEFB0", Offset = "0x6FFE3B0", VA = "0x186FFEFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LDLHOELFLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public LDLHOELFLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF130", Offset = "0x6FFE530", VA = "0x186FFF130")]
		internal void KEIIBNEDIEH(MMNNOKIIBAL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF010", Offset = "0x6FFE410", VA = "0x186FFF010")]
		internal void HAOIANKGFIN(MMNNOKIIBAL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HHBIMFJOOHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KKLGAOKAOFM roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MDOBABCIHAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<MMNNOKIIBAL, IFNBFOHHCOL> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public MDOBABCIHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF240", Offset = "0x6FFE640", VA = "0x186FFF240")]
		internal void CPONABKIKLG(MMNNOKIIBAL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF210", Offset = "0x6FFE610", VA = "0x186FFF210")]
		internal void ACNOEMMLGNL(MMNNOKIIBAL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF270", Offset = "0x6FFE670", VA = "0x186FFF270")]
		internal void OLOIAOFENBI(MMNNOKIIBAL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PIMGPKILFIK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public PIMGPKILFIK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<DKNDBBCGFDF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x35A1100", Offset = "0x35A0500", VA = "0x1835A1100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DNIMGCOBFIG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PPPMMMCJDKO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FOIEHAJAEME recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JHOOEOFCNIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public PIMGPKILFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x47EC2E0", Offset = "0x47EB6E0", VA = "0x1847EC2E0")]
		[AsyncStateMachine(typeof(PIMGPKILFIK<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void LBBBMJKIFJO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GFAOKIOAGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<LEJACMAJCIG> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OMMCDCKMFCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GACBNAOJNFK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KKLGAOKAOFM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<PPPMMMCJDKO, ABDJKCNPANH> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JPOEPDBMJNF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7002AF0", Offset = "0x7001EF0", VA = "0x187002AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7003600", Offset = "0x7002A00", VA = "0x187003600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GACBNAOJNFK MOEBLOOGFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly OLGHHMABPHM GCDBHAADDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JPOEPDBMJNF GGBNKLGKHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, ABDJKCNPANH> PJDKMKEGDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<PPPMMMCJDKO, ABDJKCNPANH> NBPIKNMBOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<PPPMMMCJDKO, ABDJKCNPANH> FEIDACOLIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<ABDJKCNPANH> AGLOKHPBLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool MDBPBFFPCFO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly DNIMGCOBFIG[] LJIKHBBGENB;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public JKJBNNLINCG PDIPMPOJOME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<HDIGNAAJFIB> JCNKJCECCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA840", Offset = "0x6FF9C40", VA = "0x186FFA840", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GKGAAKLDJBJ JEAHNHILMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FFD110", Offset = "0x6FFC510", VA = "0x186FFD110", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FFE330", Offset = "0x6FFD730", VA = "0x186FFE330", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9210", Offset = "0x6FF8610", VA = "0x186FF9210")]
	[EAMANMFIEOM(LALOBMMKLJJ.Room, NBICBCAKHEI.None)]
	private static void CEJLFACGOBK(NFLAEHJHNPL KPKAOJGGAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE680", Offset = "0x6FFDA80", VA = "0x186FFE680")]
	[UnityEngine.Scripting.Preserve]
	internal JHOOEOFCNIM([NCPIDBJOPHL(null)] GACBNAOJNFK ICJLGAMHEKH, [NCPIDBJOPHL(null)] OLGHHMABPHM PBJDCPBFOJJ, [NCPIDBJOPHL(null)] JPOEPDBMJNF GGBNKLGKHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA250", Offset = "0x6FF9650", VA = "0x186FFA250", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC5F0", Offset = "0x6FFB9F0", VA = "0x186FFC5F0")]
	private void MJHBOLJKPHP(IEnumerable<ABDJKCNPANH> FMJHCPEMLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8E10", Offset = "0x6FF8210", VA = "0x186FF8E10", Slot = "12")]
	public bool BDMLKHMDCKH(OOGKCGEGFAA MPPBKBAPBEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE4A0", Offset = "0x6FFD8A0", VA = "0x186FFE4A0")]
	private void PCGCPNGCBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAB40", Offset = "0x6FF9F40", VA = "0x186FFAB40")]
	private void GNGHONCKFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAD30", Offset = "0x6FFA130", VA = "0x186FFAD30", Slot = "10")]
	public IReadOnlyList<HDIGNAAJFIB> HJNNKKDFONA(bool HNENLKGIEDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB4F0", Offset = "0x6FFA8F0", VA = "0x186FFB4F0", Slot = "11")]
	public HDIGNAAJFIB IOOAMFELJKN(OOGKCGEGFAA MPPBKBAPBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE3D0", Offset = "0x6FFD7D0", VA = "0x186FFE3D0")]
	private PPPMMMCJDKO OGNJHIIMDEP(OOGKCGEGFAA MPPBKBAPBEE)
	{
		return default(PPPMMMCJDKO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA360", Offset = "0x6FF9760", VA = "0x186FFA360", Slot = "14")]
	public bool EAHBNMGNFBD(OOGKCGEGFAA AJHAICGDLMI, PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFAAA0", Offset = "0x6FF9EA0", VA = "0x186FFAAA0", Slot = "15")]
	public HDIGNAAJFIB GGLNDCAHCKJ(PPPMMMCJDKO NMOCKHJLFON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8EE0", Offset = "0x6FF82E0", VA = "0x186FF8EE0")]
	private static bool CCDOFIGLGIG(IIKLMPBPMMB AICGAAIPPJD, PPPMMMCJDKO NMOCKHJLFON, [Out] MMNNOKIIBAL? NFBPGLEKKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB890", Offset = "0x6FFAC90", VA = "0x186FFB890")]
	private static void JBPBLGAPIML(IIKLMPBPMMB AICGAAIPPJD, Action<MMNNOKIIBAL> MMBLMPPIBMC, PPPMMMCJDKO DMJEMFFNLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB600", Offset = "0x6FFAA00", VA = "0x186FFB600")]
	private static void JBPBLGAPIML(IIKLMPBPMMB AICGAAIPPJD, Action<MMNNOKIIBAL> MMBLMPPIBMC, Predicate<PPPMMMCJDKO> BIHAJJPPFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF93D0", Offset = "0x6FF87D0", VA = "0x186FF93D0")]
	private void CKHOLFCFMKP(OOGKCGEGFAA MPPBKBAPBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBF40", Offset = "0x6FFB340", VA = "0x186FFBF40", Slot = "4")]
	[AsyncStateMachine(typeof(JOFAOOKAHMI))]
	public Task LMBPPMONEED([CanBeNull] KKLGAOKAOFM AFNMBPMIHMN, CancellationToken GNJJGEHBGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
	public void HKALKLONMME(KKLGAOKAOFM AFNMBPMIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC290", Offset = "0x6FFB690", VA = "0x186FFC290")]
	private void LOFJKENNDIB(IIKLMPBPMMB LKNKEJHPJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FF97B0", Offset = "0x6FF8BB0", VA = "0x186FF97B0")]
	internal static string DAGOOONAAGG(GACBNAOJNFK MOEBLOOGFEM, KKLGAOKAOFM AFNMBPMIHMN, IReadOnlyDictionary<PPPMMMCJDKO, ABDJKCNPANH> NBPIKNMBOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FFD1B0", Offset = "0x6FFC5B0", VA = "0x186FFD1B0")]
	private static void OAIPHMOIIDG(KKLGAOKAOFM AFNMBPMIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FFDFE0", Offset = "0x6FFD3E0", VA = "0x186FFDFE0")]
	private static void OCBPHPGECAO(IIKLMPBPMMB MFNEBGDIAGG, IReadOnlyDictionary<PPPMMMCJDKO, ABDJKCNPANH> NBPIKNMBOKK, StringBuilder PICEPKLJMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FFB980", Offset = "0x6FFAD80", VA = "0x186FFB980")]
	private static bool KDEOBKJPGBO(string DEAAIOECILC, [Out] Guid AMJHNFIAIFM, [Out] PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FFADB0", Offset = "0x6FFA1B0", VA = "0x186FFADB0")]
	private static void ICMPKBGBKJE(KKLGAOKAOFM AFNMBPMIHMN, StringBuilder PICEPKLJMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BD9A00", Offset = "0x2BD8E00", VA = "0x182BD9A00", Slot = "16")]
	public bool DMHKEMIEMFC<T>(PPPMMMCJDKO NMOCKHJLFON, DNIMGCOBFIG JJMFMMELMJH, bool ELEDDNIPAHK, T PEGMNLKCILJ, [Optional] Action HMGMBCMKALL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBEC0", Offset = "0x6FFB2C0", VA = "0x186FFBEC0", Slot = "17")]
	public string LFJMKENPEKH(DNIMGCOBFIG JJMFMMELMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA890", Offset = "0x6FF9C90", VA = "0x186FFA890")]
	private void FICJJBBPPGA(PPPMMMCJDKO NMOCKHJLFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC5D0", Offset = "0x6FFB9D0", VA = "0x186FFC5D0")]
	private bool LPNOPFLGLLP(OOGKCGEGFAA MPPBKBAPBEE, PPPMMMCJDKO NMOCKHJLFON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA4F0", Offset = "0x6FF98F0", VA = "0x186FFA4F0")]
	internal ABDJKCNPANH EMLGIDGLLAD(OOGKCGEGFAA MPPBKBAPBEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FF8E00", Offset = "0x6FF8200", VA = "0x186FF8E00", Slot = "13")]
	public IReadOnlyList<HDIGNAAJFIB> ACKKCFGMIJO(OOGKCGEGFAA MPPBKBAPBEE, bool JHHGDFEAJEC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FFC060", Offset = "0x6FFB460", VA = "0x186FFC060")]
	internal IReadOnlyList<ABDJKCNPANH> LNJJLKJKLCL(OOGKCGEGFAA MPPBKBAPBEE, bool JHHGDFEAJEC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9AC0", Offset = "0x6FF8EC0", VA = "0x186FF9AC0")]
	private void DEHIKFDLPKH(DKNDBBCGFDF OKKOAIFICPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBBD0", Offset = "0x6FFAFD0", VA = "0x186FFBBD0")]
	private static bool KPFAJDJLFID(ABDJKCNPANH IPCNIAMCNPC, IReadOnlyDictionary<PPPMMMCJDKO, ABDJKCNPANH> NBPIKNMBOKK, [Out] IReadOnlyList<DNIMGCOBFIG> MGPJANIHJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FFBA90", Offset = "0x6FFAE90", VA = "0x186FFBA90")]
	[AsyncStateMachine(typeof(OMMCDCKMFCE))]
	private static Task KDGEPJGNPBI(GACBNAOJNFK MOEBLOOGFEM, KKLGAOKAOFM AFNMBPMIHMN, IReadOnlyDictionary<PPPMMMCJDKO, ABDJKCNPANH> NBPIKNMBOKK, JPOEPDBMJNF GGBNKLGKHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FFCE70", Offset = "0x6FFC270", VA = "0x186FFCE70")]
	[CompilerGenerated]
	internal static void MJLAAGFNKCK(Func<MMNNOKIIBAL, IFNBFOHHCOL> KNBAHHOCGLF, HHBIMFJOOHF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9440", Offset = "0x6FF8840", VA = "0x186FF9440")]
	[CompilerGenerated]
	internal static bool CLHCPEHOBGE(PPPMMMCJDKO NMOCKHJLFON, DNIMGCOBFIG JJMFMMELMJH, [Out] LEJACMAJCIG CHIIGPFOCHI, GFAOKIOAGID P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IICLMDFNPJC
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool INFGLLDMJEA(OOGKCGEGFAA GKGPBGAHNBL, OOGKCGEGFAA PDGIMEDLBAJ, IEnumerable<OOGKCGEGFAA> NMGLIIKPNHO, [Out] MBOHBBBANAN LDFPPCOECPL, [Out] EOHEPLLADFG FPKHNAIBHKG);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FABLCHMIGHF(EOHEPLLADFG MKCKJMBGIIG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum EOHEPLLADFG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class NGNPKMICHBF : IICLMDFNPJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BJOFIDCJGDL MAGPNFGHAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly KOJKCJNAPHP GHJMFHOLEMG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x85AB00", Offset = "0x859F00", VA = "0x18085AB00")]
	[RecRoom.NoEngine.Common.Preserve]
	public NGNPKMICHBF([NCPIDBJOPHL(null)] BJOFIDCJGDL NKEOAJKNHOC, [NCPIDBJOPHL(null)] KOJKCJNAPHP FFBJDIOPDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF3A0", Offset = "0x6FFE7A0", VA = "0x186FFF3A0")]
	private static CKLJMLBJAHB? FMAPGHJKOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF3E0", Offset = "0x6FFE7E0", VA = "0x186FFF3E0", Slot = "4")]
	public bool INFGLLDMJEA(OOGKCGEGFAA GKGPBGAHNBL, OOGKCGEGFAA PDGIMEDLBAJ, IEnumerable<OOGKCGEGFAA> NMGLIIKPNHO, [Out] MBOHBBBANAN LDFPPCOECPL, [Out] EOHEPLLADFG FPKHNAIBHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF2A0", Offset = "0x6FFE6A0", VA = "0x186FFF2A0", Slot = "5")]
	public string FABLCHMIGHF(EOHEPLLADFG MKCKJMBGIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6FFF4E0", Offset = "0x6FFE8E0", VA = "0x186FFF4E0")]
	internal bool LNPIDAHPDGE(OOGKCGEGFAA GKGPBGAHNBL, OOGKCGEGFAA PDGIMEDLBAJ, IEnumerable<OOGKCGEGFAA> NMGLIIKPNHO, CKNBCJINDHA MEFBIMIAFEC, CKLJMLBJAHB? LHGAOMMIINA, [Out] MBOHBBBANAN LDFPPCOECPL, [Out] EOHEPLLADFG FPKHNAIBHKG)
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
