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
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A7F5C0", Offset = "0x8A7E5C0", VA = "0x188A7F5C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DKDKMOACCJF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A806A0", Offset = "0x8A7F6A0", VA = "0x188A806A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LAJEJCGCFLM<TPermission>(TPermission HGKEEFLEOJB);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void EMICEKNEKHD(IALDHONKEJC MFOAOKBDIIM);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum MGOBNPDKPGD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NOCKIKAADKF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DAJMGNEJFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BKAJKEKFBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PNBNHBGDDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HHPFMEFHIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ECIGFEJDJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HOHNOKILNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class DFKNIPGGOGP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum OHMDGBOHFNB
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
	public static readonly Guid FCHHNPNFFOH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid ONAEIKOMGBD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid BGHINKLLHKG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid DIKJELDCJPM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid HLFAFHOLAMH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KNIIDDLFEKI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MBMCNGKDFPF<PHBPGMMKBJJ, Guid> IMOPFIPHGGO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<PHBPGMMKBJJ> GKLKEGHGKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A78590", Offset = "0x8A77590", VA = "0x188A78590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8A78430", Offset = "0x8A77430", VA = "0x188A78430")]
	public static PHBPGMMKBJJ DEKIIOEJIHL(Guid JFLBGDIIGHK)
	{
		return default(PHBPGMMKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8A786C0", Offset = "0x8A776C0", VA = "0x188A786C0")]
	public static Guid NMJMFJOPIGH(PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8A784C0", Offset = "0x8A774C0", VA = "0x188A784C0")]
	public static bool EIHOMIGNDCA(PHBPGMMKBJJ GKNAOACDPDG, [Out] Guid JFLBGDIIGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8A78350", Offset = "0x8A77350", VA = "0x188A78350")]
	public static bool DCFAGBIPNAL(Guid JFLBGDIIGHK, [Out] PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8A783F0", Offset = "0x8A773F0", VA = "0x188A783F0")]
	public static PHBPGMMKBJJ DEICOKPLOBM(PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(PHBPGMMKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8A78610", Offset = "0x8A77610", VA = "0x188A78610")]
	public static OHMDGBOHFNB NCMAHBFLACN(PHBPGMMKBJJ GFMAKNAEFLD)
	{
		return default(OHMDGBOHFNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8A78550", Offset = "0x8A77550", VA = "0x188A78550")]
	internal static PHBPGMMKBJJ JIPGONEMMNA(OHMDGBOHFNB HPOLGNLIBPG)
	{
		return default(PHBPGMMKBJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BOIBFMBGBGB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IALDHONKEJC JLABICKAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GGCLDGNBNLI BIIPCOCNDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HGMJJMJDHLJ PKEBJCDACNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FEJPDKONECB> FNGHMOPLHPC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AAMAEKPECFL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PHBPGMMKBJJ GBKGGEDPCDE(IALDHONKEJC MFOAOKBDIIM);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FEJPDKONECB> NPPNKOILMFK(CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BAKBFPICHDM(long DJJNJEHBMJK, IReadOnlyList<OAANAMJCIDA> OJBFMMAOGPP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FOHKKKNNPAA(long DJJNJEHBMJK, long MNMAOOEOJPN, IReadOnlyList<OAANAMJCIDA> OJBFMMAOGPP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<IALDHONKEJC> BIAHJKEOEOO();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class HCLCAPOIGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8A79FC0", Offset = "0x8A78FC0", VA = "0x188A79FC0")]
	public static PHBPGMMKBJJ CDBIHNFIEKE(this BOIBFMBGBGB ACFNLAEJBDC)
	{
		return default(PHBPGMMKBJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface AMPDNNNHIBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FGLEMHIJHNG GAIFBLLPCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EMICEKNEKHD GFIAPFCDBPO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<HLIPNNDGLNC> JNBMMPMNBCO(bool OLDGEICEJLA = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HLIPNNDGLNC CCKKICCANGK(IALDHONKEJC MFOAOKBDIIM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CECELNNNHJA(IALDHONKEJC MFOAOKBDIIM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<HLIPNNDGLNC> MKJAHIEGKFE(IALDHONKEJC MFOAOKBDIIM, bool FEPPLOAHJLC = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FKDNPJKCMEA(IALDHONKEJC OOKKMGPCHEK, PHBPGMMKBJJ GKNAOACDPDG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HLIPNNDGLNC PGKPGIGLCEG(PHBPGMMKBJJ GKNAOACDPDG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PPOEDHEGNGM<T>(PHBPGMMKBJJ GKNAOACDPDG, OGKGADHHDKM HGKEEFLEOJB, bool PJGAJPGOEEA, T AJDOBKLONKL, [Optional] Action BLLJDPEIIGO) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string CKKNJLKNDIL(OGKGADHHDKM HGKEEFLEOJB);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CNLKIHKBDNB(IALDHONKEJC MFOAOKBDIIM, OGKGADHHDKM EGLMDHKAILI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FLFKPLLAOJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DIPOLJKADLI(KDGPCLGNAFG IANLOKBOBGO, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NJEGOMFFNJL<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HNCOEOLGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event LAJEJCGCFLM<TPermission> DCFNKHICFMC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class BPDEPMBIJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? MJILOFPIDHM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? DKNJDIFOJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A72360", Offset = "0x8A71360", VA = "0x188A72360")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A72440", Offset = "0x8A71440", VA = "0x188A72440")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8A72540", Offset = "0x8A71540", VA = "0x188A72540")]
	protected BPDEPMBIJBK(object? HOHGHHFBMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool EOIEFHJOFII(object? IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OGNHJGHAGEO<T> : BPDEPMBIJBK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> FFIFKGOLOOF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x58B2530", Offset = "0x58B1530", VA = "0x1858B2530")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x58B1D00", Offset = "0x58B0D00", VA = "0x1858B1D00", Slot = "4")]
	public override bool EOIEFHJOFII(object? IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x58B2200", Offset = "0x58B1200", VA = "0x1858B2200")]
	public bool FNLBOCELMHP(T FPACKLIGFHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x58B28C0", Offset = "0x58B18C0", VA = "0x1858B28C0")]
	public OGNHJGHAGEO(T CAILINJCNIJ, IEqualityComparer<T> FFIFKGOLOOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class JNPJHKGBCGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<OGKGADHHDKM, bool> JKCPMDIGOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OGKGADHHDKM, BPDEPMBIJBK> KMCOCMGMGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IDPJFDIJMJJ OPKPDHFGBEA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8A7F280", Offset = "0x8A7E280", VA = "0x188A7F280")]
	public JNPJHKGBCGD(IDPJFDIJMJJ OPKPDHFGBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8A7F210", Offset = "0x8A7E210", VA = "0x188A7F210")]
	public bool POHEAGKBMNF(OGKGADHHDKM HGKEEFLEOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CF25A0", Offset = "0x3CF15A0", VA = "0x183CF25A0")]
	public bool EBDFNKJKPHH<T>(OGKGADHHDKM HGKEEFLEOJB, bool PJGAJPGOEEA, T IOALKPFEKEK) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2A80", Offset = "0x3CF1A80", VA = "0x183CF2A80")]
	public (bool, T?) FBPKGFDBGEC<T>(OGKGADHHDKM HGKEEFLEOJB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8A7ECD0", Offset = "0x8A7DCD0", VA = "0x188A7ECD0")]
	public bool EBDFNKJKPHH(OGKGADHHDKM HGKEEFLEOJB, bool PJGAJPGOEEA, object IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8A7EDB0", Offset = "0x8A7DDB0", VA = "0x188A7EDB0")]
	public (bool, object) FBPKGFDBGEC(OGKGADHHDKM HGKEEFLEOJB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2560", Offset = "0x3CF1560", VA = "0x183CF2560")]
	private void DIHOLJOIHHF<T>(OGKGADHHDKM HGKEEFLEOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A7F140", Offset = "0x8A7E140", VA = "0x188A7F140")]
	private BPDEPMBIJBK OINHJBFFFBI(OGKGADHHDKM HGKEEFLEOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8A7EF50", Offset = "0x8A7DF50", VA = "0x188A7EF50")]
	public void GGEDEEEMEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BAGKCBCKGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string MDMHNCCIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type ACCHINJBCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly IGAEHBCMEEN NNGENICIKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OGKGADHHDKM DCHPGCAHBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IEPGMICEJMH MEGADIMCFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GGBHDPIBNAP PHLGPKAIJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MBKDGALNJHF PBINABENGLA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8A71760", Offset = "0x8A70760", VA = "0x188A71760")]
	public BAGKCBCKGHE(Type IFFGJNNPNLD, string MHAJOEPCBAD, OGKGADHHDKM HGKEEFLEOJB, IEPGMICEJMH MDJBAFFLECK, GGBHDPIBNAP DBDENCCJNGK, MBKDGALNJHF CHFBOEOGOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8A71710", Offset = "0x8A70710", VA = "0x188A71710")]
	public object MLFHNJMGDBF(object? EDJHHGMLKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39D04E0", Offset = "0x39CF4E0", VA = "0x1839D04E0")]
	public void DIHOLJOIHHF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8A71660", Offset = "0x8A70660", VA = "0x188A71660")]
	public void DIHOLJOIHHF(Type KDFPGCKKNGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class GIJOAPPIDCE<T> : BAGKCBCKGHE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string HLAHFPAKBND(T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T HPANACLAJOA(string? GFOKKCNMFNE, T CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LFFOLMPPAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HLAHFPAKBND serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HPANACLAJOA parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public LFFOLMPPAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5470CD0", Offset = "0x546FCD0", VA = "0x185470CD0")]
		internal string IPHOKKAPDOM(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5470BB0", Offset = "0x546FBB0", VA = "0x185470BB0")]
		internal object CIKAONDHCLP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4EBCBD0", Offset = "0x4EBBBD0", VA = "0x184EBCBD0")]
	public GIJOAPPIDCE(OGKGADHHDKM HGKEEFLEOJB, string MHAJOEPCBAD, [Optional] HLAHFPAKBND? MDJBAFFLECK, [Optional] HPANACLAJOA? DBDENCCJNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC050", Offset = "0x4EBB050", VA = "0x184EBC050")]
	private static object? LABNBGADOBH(HPANACLAJOA? DBDENCCJNGK, string? GFOKKCNMFNE, object? CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBB10", Offset = "0x4EBAB10", VA = "0x184EBBB10")]
	private static string FBGBLPHHDGN(HLAHFPAKBND? DHEKKMJMCKO, object? IOALKPFEKEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string IEPGMICEJMH(object? IOALKPFEKEK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object GGBHDPIBNAP(string? GFOKKCNMFNE, [Optional] object CAILINJCNIJ);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate BPDEPMBIJBK MBKDGALNJHF();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class IDPJFDIJMJJ
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HMCBOIAEJJE : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static HMCBOIAEJJE KONBGMLOLPI;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8A7A020", Offset = "0x8A79020", VA = "0x188A7A020", Slot = "4")]
		public bool Equals(List<string> OEFDFBLCHHF, List<string> GDBEEAKMPMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8A7A170", Offset = "0x8A79170", VA = "0x188A7A170", Slot = "5")]
		public int GetHashCode(List<string> PGIOEBKALDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HMCBOIAEJJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class BFLIDEADNMK : LHFIDOIGCLG<DKDKMOACCJF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8A71800", Offset = "0x8A70800", VA = "0x188A71800", Slot = "9")]
		public override string FBGBLPHHDGN(DKDKMOACCJF JMJJABEKOFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8A718F0", Offset = "0x8A708F0", VA = "0x188A718F0", Slot = "10")]
		protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] DKDKMOACCJF IOALKPFEKEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8A71AD0", Offset = "0x8A70AD0", VA = "0x188A71AD0")]
		public BFLIDEADNMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly OFDBFCAKGIH EFOOCJCGOKG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly BFLIDEADNMK GGDKAKBCMKE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<BAGKCBCKGHE> FJDLPDKMACC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<OGKGADHHDKM> MOLHBFPNNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<OGKGADHHDKM, BAGKCBCKGHE> BLDHPNMMDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8A7CD30", Offset = "0x8A7BD30", VA = "0x188A7CD30")]
	public IDPJFDIJMJJ([Optional] IList<BAGKCBCKGHE>? OKJCFLOOJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8A7AEE0", Offset = "0x8A79EE0", VA = "0x188A7AEE0")]
	public BAGKCBCKGHE OOPCNIHCMFN(OGKGADHHDKM HGKEEFLEOJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FGLEMHIJHNG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HLIPNNDGLNC BIHIDGIPPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GFAHLHNHIJH : FGLEMHIJHNG
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static GFAHLHNHIJH PPLMLIGBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly JNGHOMKNFPP DBFBNDFLMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<JNGHOMKNFPP> NHCDLKNIDAA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public HLIPNNDGLNC BIHIDGIPPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8A79EB0", Offset = "0x8A78EB0", VA = "0x188A79EB0")]
	public GFAHLHNHIJH(JNGHOMKNFPP LBPDPIGAELC, IReadOnlyList<JNGHOMKNFPP> CKMEBIMBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A78DC0", Offset = "0x8A77DC0", VA = "0x188A78DC0")]
	private static GFAHLHNHIJH IANKJHIPNCC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DODFHPANBGC
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<PHBPGMMKBJJ> DMOMBNBPHKI;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8A78B00", Offset = "0x8A77B00", VA = "0x188A78B00")]
	public static bool COILPMFJFEL(this IALDHONKEJC DEJHNGPBFGP, PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A78A80", Offset = "0x8A77A80", VA = "0x188A78A80")]
	public static bool AHELGODPECC(this IALDHONKEJC DEJHNGPBFGP, PHBPGMMKBJJ GKNAOACDPDG, HGMJJMJDHLJ DPCFNINBHHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OIBHLLBLLFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> LEJNIPGGLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DKDKMOACCJF NGMKGBEHNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HLIPNNDGLNC : OIBHLLBLLFJ, NOCKIKAADKF, NJEGOMFFNJL<OGKGADHHDKM>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string PLLFFAHOIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PHBPGMMKBJJ PADGOJNELHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IOEFHPHDIIK<T>(OGKGADHHDKM HGKEEFLEOJB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class JNGHOMKNFPP : HLIPNNDGLNC, OIBHLLBLLFJ, NOCKIKAADKF, NJEGOMFFNJL<OGKGADHHDKM>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly IDPJFDIJMJJ DGNHMOHKBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly JNPJHKGBCGD FCMMNPELMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? PJFFNNLBKHD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool FKMAGEMFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DE80", Offset = "0x8A7CE80", VA = "0x188A7DE80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool PKHCLIAHDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A7D9E0", Offset = "0x8A7C9E0", VA = "0x188A7D9E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool DHGADKNGPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DCB0", Offset = "0x8A7CCB0", VA = "0x188A7DCB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KHNLCELOGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A7E5C0", Offset = "0x8A7D5C0", VA = "0x188A7E5C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool LINLOCFEAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DB10", Offset = "0x8A7CB10", VA = "0x188A7DB10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool KFCPOFDKOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DAC0", Offset = "0x8A7CAC0", VA = "0x188A7DAC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public PHBPGMMKBJJ PADGOJNELHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(PHBPGMMKBJJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string HNCOEOLGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DDB0", Offset = "0x8A7CDB0", VA = "0x188A7DDB0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string PLLFFAHOIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DDB0", Offset = "0x8A7CDB0", VA = "0x188A7DDB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AFEHIEKOLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DKDKMOACCJF NGMKGBEHNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A7E1E0", Offset = "0x8A7D1E0", VA = "0x188A7E1E0", Slot = "8")]
		get
		{
			return default(DKDKMOACCJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> LEJNIPGGLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A7E610", Offset = "0x8A7D610", VA = "0x188A7E610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OADCFHMCDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DE80", Offset = "0x8A7CE80", VA = "0x188A7DE80", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool CJHKDAFJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DB10", Offset = "0x8A7CB10", VA = "0x188A7DB10", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool IMDPLFMKOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A7D9E0", Offset = "0x8A7C9E0", VA = "0x188A7D9E0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FJEBEAKDDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DCB0", Offset = "0x8A7CCB0", VA = "0x188A7DCB0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KMMKBLFFOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A7E5C0", Offset = "0x8A7D5C0", VA = "0x188A7E5C0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EBGBFJIDKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DAC0", Offset = "0x8A7CAC0", VA = "0x188A7DAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LAJEJCGCFLM<OGKGADHHDKM> DCFNKHICFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A7E430", Offset = "0x8A7D430", VA = "0x188A7E430", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD00", Offset = "0x8A7CD00", VA = "0x188A7DD00", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF11D0", Offset = "0x3CF01D0", VA = "0x183CF11D0", Slot = "6")]
	public (bool, T?) IOEFHPHDIIK<T>(OGKGADHHDKM HGKEEFLEOJB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1360", Offset = "0x3CF0360", VA = "0x183CF1360")]
	public JNGHOMKNFPP PBCFKDDAHOL<T>(OGKGADHHDKM HGKEEFLEOJB, bool PJGAJPGOEEA, T IOALKPFEKEK) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8A7EAE0", Offset = "0x8A7DAE0", VA = "0x188A7EAE0")]
	public JNGHOMKNFPP(PHBPGMMKBJJ GKNAOACDPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8A7EAC0", Offset = "0x8A7DAC0", VA = "0x188A7EAC0")]
	public JNGHOMKNFPP(PHBPGMMKBJJ GKNAOACDPDG, [Optional] string? PJFFNNLBKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8A7EC40", Offset = "0x8A7DC40", VA = "0x188A7EC40")]
	public JNGHOMKNFPP(JNGHOMKNFPP ACELJMKGKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8A7EB00", Offset = "0x8A7DB00", VA = "0x188A7EB00")]
	internal JNGHOMKNFPP(PHBPGMMKBJJ LPCBDHDNPKD, [Optional] string? PJFFNNLBKHD, [Optional] JNGHOMKNFPP? ACELJMKGKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8A7DE00", Offset = "0x8A7CE00", VA = "0x188A7DE00")]
	public static IGAEHBCMEEN EGDIJIMPBHE(OGKGADHHDKM HGKEEFLEOJB)
	{
		return default(IGAEHBCMEEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8A7E1C0", Offset = "0x8A7D1C0", VA = "0x188A7E1C0")]
	public void GGEDEEEMEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8A7DED0", Offset = "0x8A7CED0", VA = "0x188A7DED0")]
	internal JNGHOMKNFPP ENDBGLJBNLE(JNGHOMKNFPP GDLBDIMODLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8A7E670", Offset = "0x8A7D670", VA = "0x188A7E670")]
	internal IReadOnlyCollection<OGKGADHHDKM> PBLMCCENHMO(JNGHOMKNFPP ACELJMKGKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8A7E4E0", Offset = "0x8A7D4E0", VA = "0x188A7E4E0")]
	public bool INMHHJFAOGL(OGKGADHHDKM HGKEEFLEOJB, bool PJGAJPGOEEA, string COCKDBBHDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8A7DB60", Offset = "0x8A7CB60", VA = "0x188A7DB60")]
	public (bool, string) CCBFGOEEDCA(OGKGADHHDKM HGKEEFLEOJB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8A7DC60", Offset = "0x8A7CC60", VA = "0x188A7DC60")]
	internal void CCGEICLFBON(OGKGADHHDKM HGKEEFLEOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8A7E230", Offset = "0x8A7D230", VA = "0x188A7E230")]
	public PNNGOCDOMKC HBJEJKFAJPC(Func<PHBPGMMKBJJ, Guid> KCBJNEPGAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8A7D080", Offset = "0x8A7C080", VA = "0x188A7D080")]
	public void AFCMIEOALGM(PNNGOCDOMKC GNOPMLAFEIH, Func<Guid, PHBPGMMKBJJ> KLHKEMAHENH, [Optional] PHBPGMMKBJJ? KEBOMBDLJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8A7DA30", Offset = "0x8A7CA30", VA = "0x188A7DA30")]
	[CompilerGenerated]
	private void APBHALPLIEB(OGKGADHHDKM EGLMDHKAILI, LHGGKFMPAAO NHOHHAJMNNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DFBNLBFNPDP : FLFKPLLAOJJ, AMPDNNNHIBA, IDisposable, DFCBBOEONAP
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EJCCDELEKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JNGHOMKNFPP newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EJCCDELEKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A78D90", Offset = "0x8A77D90", VA = "0x188A78D90")]
		internal bool AGHOFIFNKCD(JNGHOMKNFPP rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HEJPJMGBFEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PHBPGMMKBJJ roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HEJPJMGBFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E95250", Offset = "0x1E94250", VA = "0x181E95250")]
		internal bool KDFAMMMAFJF(PHBPGMMKBJJ r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OAFGCOENHOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DFBNLBFNPDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KDGPCLGNAFG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<FEJPDKONECB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F640", Offset = "0x8A7E640", VA = "0x188A7F640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FCB0", Offset = "0x8A7ECB0", VA = "0x188A7FCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PDKEOLEJKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PDKEOLEJKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FE30", Offset = "0x8A7EE30", VA = "0x188A7FE30")]
		internal void KJNIIMKOLAA(PNNGOCDOMKC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FD10", Offset = "0x8A7ED10", VA = "0x188A7FD10")]
		internal void EHNPNABLHII(PNNGOCDOMKC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FLDJILDHCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KDGPCLGNAFG roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class KJPAGGBLBIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<PNNGOCDOMKC, LHGGKFMPAAO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KJPAGGBLBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F590", Offset = "0x8A7E590", VA = "0x188A7F590")]
		internal void LMOLGNMDKLA(PNNGOCDOMKC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F560", Offset = "0x8A7E560", VA = "0x188A7F560")]
		internal void LEBOFOKMHGF(PNNGOCDOMKC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A7F530", Offset = "0x8A7E530", VA = "0x188A7F530")]
		internal void IMCOAFHANPD(PNNGOCDOMKC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OGGDFKDFINO<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public OGGDFKDFINO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<FEJPDKONECB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4453740", Offset = "0x4452740", VA = "0x184453740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public OGKGADHHDKM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public PHBPGMMKBJJ accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public IGAEHBCMEEN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public DFBNLBFNPDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OGGDFKDFINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x58AD240", Offset = "0x58AC240", VA = "0x1858AD240")]
		[AsyncStateMachine(typeof(OGGDFKDFINO<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void ADMAAPIOJFL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct ACIOJEPKBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<OAANAMJCIDA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HPBPODPNPPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public BOIBFMBGBGB rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KDGPCLGNAFG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<PHBPGMMKBJJ, JNGHOMKNFPP> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PFDLEOBDONH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A7A360", Offset = "0x8A79360", VA = "0x188A7A360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A7AE80", Offset = "0x8A79E80", VA = "0x188A7AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly BOIBFMBGBGB ACFNLAEJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly GFAHLHNHIJH PEEFNDKHAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PFDLEOBDONH CHJCOCHCMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, JNGHOMKNFPP> NKCDBLDMHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<PHBPGMMKBJJ, JNGHOMKNFPP> GAFLFAMCCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<PHBPGMMKBJJ, JNGHOMKNFPP> CJGOPMELPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<JNGHOMKNFPP> ENEMIKHNPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool BHDJLMEJLJF;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly OGKGADHHDKM[] AKKJAMPFFIP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public FGLEMHIJHNG GAIFBLLPCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EMICEKNEKHD GFIAPFCDBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A76BB0", Offset = "0x8A75BB0", VA = "0x188A76BB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A72B50", Offset = "0x8A71B50", VA = "0x188A72B50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8A77920", Offset = "0x8A76920", VA = "0x188A77920")]
	[GOMLKAICHII.BCJFEFEABPB]
	internal static void PHNOHKBOJEP(CBHAAKGBAOP NACGIDKDDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8A78090", Offset = "0x8A77090", VA = "0x188A78090")]
	[UnityEngine.Scripting.Preserve]
	internal DFBNLBFNPDP([KELEGLJPNHI(null)] BOIBFMBGBGB BLMOPOMHMBI, [KELEGLJPNHI(null)] GFAHLHNHIJH LMNCCMOMHAJ, [KELEGLJPNHI(null)] PFDLEOBDONH CHJCOCHCMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8A74300", Offset = "0x8A73300", VA = "0x188A74300", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8A76F80", Offset = "0x8A75F80", VA = "0x188A76F80")]
	private void OLKFACAGHNO(IEnumerable<JNGHOMKNFPP> HGAOEBKKOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8A730C0", Offset = "0x8A720C0", VA = "0x188A730C0", Slot = "10")]
	public bool CECELNNNHJA(IALDHONKEJC MFOAOKBDIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8A72650", Offset = "0x8A71650", VA = "0x188A72650")]
	private void AAMAEKPECFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8A74580", Offset = "0x8A73580", VA = "0x188A74580")]
	private void HFECDFGNMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8A75AF0", Offset = "0x8A74AF0", VA = "0x188A75AF0", Slot = "8")]
	public IReadOnlyList<HLIPNNDGLNC> JNBMMPMNBCO(bool OLDGEICEJLA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8A72FB0", Offset = "0x8A71FB0", VA = "0x188A72FB0", Slot = "9")]
	public HLIPNNDGLNC CCKKICCANGK(IALDHONKEJC MFOAOKBDIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8A72770", Offset = "0x8A71770", VA = "0x188A72770")]
	private PHBPGMMKBJJ AFNHLFMOGJH(IALDHONKEJC MFOAOKBDIIM)
	{
		return default(PHBPGMMKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8A74410", Offset = "0x8A73410", VA = "0x188A74410", Slot = "12")]
	public bool FKDNPJKCMEA(IALDHONKEJC OOKKMGPCHEK, PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8A77880", Offset = "0x8A76880", VA = "0x188A77880", Slot = "13")]
	public HLIPNNDGLNC PGKPGIGLCEG(PHBPGMMKBJJ GKNAOACDPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8A76C50", Offset = "0x8A75C50", VA = "0x188A76C50")]
	private static bool OCHBPNHBEBB(NLJMFLAFPJL DDMKJJCEKLF, PHBPGMMKBJJ GKNAOACDPDG, [Out] PNNGOCDOMKC? MOGNONBEEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8A75260", Offset = "0x8A74260", VA = "0x188A75260")]
	private static void JBLEDJKBFEM(NLJMFLAFPJL DDMKJJCEKLF, Action<PNNGOCDOMKC> KIPGIABNFHJ, PHBPGMMKBJJ DJEGLAKPFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8A74FD0", Offset = "0x8A73FD0", VA = "0x188A74FD0")]
	private static void JBLEDJKBFEM(NLJMFLAFPJL DDMKJJCEKLF, Action<PNNGOCDOMKC> KIPGIABNFHJ, Predicate<PHBPGMMKBJJ> AFGCMELKDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8A72BF0", Offset = "0x8A71BF0", VA = "0x188A72BF0")]
	private void BEKIBGLOCJO(IALDHONKEJC MFOAOKBDIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8A741E0", Offset = "0x8A731E0", VA = "0x188A741E0", Slot = "4")]
	[AsyncStateMachine(typeof(OAFGCOENHOD))]
	public Task DIPOLJKADLI([CanBeNull] KDGPCLGNAFG IANLOKBOBGO, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8A75B70", Offset = "0x8A74B70", VA = "0x188A75B70")]
	private void KCIFGHDEMFC(NLJMFLAFPJL AHMMHKNHLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8A72840", Offset = "0x8A71840", VA = "0x188A72840")]
	internal static string AGCJPGPMIDD(BOIBFMBGBGB ACFNLAEJBDC, KDGPCLGNAFG IANLOKBOBGO, IReadOnlyDictionary<PHBPGMMKBJJ, JNGHOMKNFPP> GAFLFAMCCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8A73210", Offset = "0x8A72210", VA = "0x188A73210")]
	private static void CMDICKDPBLL(KDGPCLGNAFG IANLOKBOBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8A72C60", Offset = "0x8A71C60", VA = "0x188A72C60")]
	private static void BONEKFBKFGM(NLJMFLAFPJL KPOLHKIKLJF, IReadOnlyDictionary<PHBPGMMKBJJ, JNGHOMKNFPP> GAFLFAMCCHK, StringBuilder MBAACJBNIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8A72660", Offset = "0x8A71660", VA = "0x188A72660")]
	private static bool AEBJPAOHGLL(string OEDOIPEIFFM, [Out] Guid KHCHFCNNIOK, [Out] PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8A76470", Offset = "0x8A75470", VA = "0x188A76470")]
	private static void MPFLLFOGEIE(KDGPCLGNAFG IANLOKBOBGO, StringBuilder MBAACJBNIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A936A0", Offset = "0x3A926A0", VA = "0x183A936A0", Slot = "14")]
	public bool PPOEDHEGNGM<T>(PHBPGMMKBJJ GKNAOACDPDG, OGKGADHHDKM HGKEEFLEOJB, bool PJGAJPGOEEA, T AJDOBKLONKL, [Optional] Action BLLJDPEIIGO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8A73190", Offset = "0x8A72190", VA = "0x188A73190", Slot = "15")]
	public string CKKNJLKNDIL(OGKGADHHDKM HGKEEFLEOJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8A740F0", Offset = "0x8A730F0", VA = "0x188A740F0", Slot = "16")]
	public bool CNLKIHKBDNB(IALDHONKEJC MFOAOKBDIIM, OGKGADHHDKM EGLMDHKAILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8A74040", Offset = "0x8A73040", VA = "0x188A74040", Slot = "18")]
	public bool CNLKIHKBDNB(int NFDMOMMJDAE, OGKGADHHDKM EGLMDHKAILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8A76250", Offset = "0x8A75250", VA = "0x188A76250")]
	private void LBCGNFJJACC(PHBPGMMKBJJ GKNAOACDPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8A75EB0", Offset = "0x8A74EB0", VA = "0x188A75EB0")]
	private bool KDECBODLFHJ(IALDHONKEJC MFOAOKBDIIM, PHBPGMMKBJJ GKNAOACDPDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8A749A0", Offset = "0x8A739A0", VA = "0x188A749A0")]
	internal JNGHOMKNFPP ICGOLNCAEBA(IALDHONKEJC MFOAOKBDIIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A76460", Offset = "0x8A75460", VA = "0x188A76460", Slot = "11")]
	public IReadOnlyList<HLIPNNDGLNC> MKJAHIEGKFE(IALDHONKEJC MFOAOKBDIIM, bool FEPPLOAHJLC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8A74770", Offset = "0x8A73770", VA = "0x188A74770")]
	internal IReadOnlyList<JNGHOMKNFPP> HNEJFBCGGOA(IALDHONKEJC MFOAOKBDIIM, bool FEPPLOAHJLC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8A75350", Offset = "0x8A74350", VA = "0x188A75350")]
	private void JHMINFODHFF(FEJPDKONECB LFGAMIKBHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8A74CE0", Offset = "0x8A73CE0", VA = "0x188A74CE0")]
	private static bool IGHIIMHHGJD(JNGHOMKNFPP LBPPLIEFGHN, IReadOnlyDictionary<PHBPGMMKBJJ, JNGHOMKNFPP> GAFLFAMCCHK, [Out] IReadOnlyList<OGKGADHHDKM> FCLIFOLNAOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8A77AE0", Offset = "0x8A76AE0", VA = "0x188A77AE0")]
	[AsyncStateMachine(typeof(HPBPODPNPPO))]
	private static Task PJBDBONGOIE(BOIBFMBGBGB ACFNLAEJBDC, KDGPCLGNAFG IANLOKBOBGO, IReadOnlyDictionary<PHBPGMMKBJJ, JNGHOMKNFPP> GAFLFAMCCHK, PFDLEOBDONH CHJCOCHCMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8A77C20", Offset = "0x8A76C20", VA = "0x188A77C20")]
	[CompilerGenerated]
	internal static void POLBNIKFFCM(Func<PNNGOCDOMKC, LHGGKFMPAAO> NMIEHDCILIL, FLDJILDHCEC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8A75ED0", Offset = "0x8A74ED0", VA = "0x188A75ED0")]
	[CompilerGenerated]
	internal static bool LADMPAMHNKG(PHBPGMMKBJJ GKNAOACDPDG, OGKGADHHDKM HGKEEFLEOJB, [Out] OAANAMJCIDA DGBFBOJCACN, ACIOJEPKBOA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NDOJEHBPBMO
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HLOFEMMEOIN(IALDHONKEJC HALHOKOMEFL, IALDHONKEJC ANCDHOGGFFA, IEnumerable<IALDHONKEJC> BAMPECEGPPK, [Out] DKDKMOACCJF OHPFHPCCKDJ, [Out] HCDAGJHICKF BFCNCFCJIPH);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GAFHJJBKECH(HCDAGJHICKF KKJHKJALCMN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum HCDAGJHICKF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class BOLLECKELEN : NDOJEHBPBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly AMPDNNNHIBA HPLMNPPEMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MLEHPOEFLAG HJIOLBEHJLP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BOLLECKELEN([KELEGLJPNHI(null)] AMPDNNNHIBA HPLMNPPEMKC, [KELEGLJPNHI(null)] MLEHPOEFLAG FNMGDANLIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8A72120", Offset = "0x8A71120", VA = "0x188A72120")]
	private static NEMBNIGCMFK? BFLKBAPDLCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8A72260", Offset = "0x8A71260", VA = "0x188A72260", Slot = "4")]
	public bool HLOFEMMEOIN(IALDHONKEJC HALHOKOMEFL, IALDHONKEJC ANCDHOGGFFA, IEnumerable<IALDHONKEJC> BAMPECEGPPK, [Out] DKDKMOACCJF OHPFHPCCKDJ, [Out] HCDAGJHICKF BFCNCFCJIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8A72160", Offset = "0x8A71160", VA = "0x188A72160", Slot = "5")]
	public string GAFHJJBKECH(HCDAGJHICKF KKJHKJALCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8A71B10", Offset = "0x8A70B10", VA = "0x188A71B10")]
	internal bool AAHNCGJNCKL(IALDHONKEJC HALHOKOMEFL, IALDHONKEJC ANCDHOGGFFA, IEnumerable<IALDHONKEJC> BAMPECEGPPK, HGMJJMJDHLJ DPCFNINBHHF, NEMBNIGCMFK? CJOEGPGHFJH, [Out] DKDKMOACCJF OHPFHPCCKDJ, [Out] HCDAGJHICKF BFCNCFCJIPH)
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
