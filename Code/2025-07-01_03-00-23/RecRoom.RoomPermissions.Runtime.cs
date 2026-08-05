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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x888C720", Offset = "0x888AD20", VA = "0x18888C720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FFHMDKOCHGM
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
		[Cpp2IlInjected.Address(RVA = "0x8893700", Offset = "0x8891D00", VA = "0x188893700", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KDJCOGCAJNO<TPermission>(TPermission LJAPEEGHDDO);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CFIEBKAELLO(KNOJHPOMDED OPOGJMFOAFI);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum AAPAKOLPHFA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IOOPBEGFLBN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PAIMKMCAKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MFHGCCKPDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BDEHHBGOOON
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EEHJPDJCMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HGEGEFGJLII
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MAHMDLHOFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GOEOGDCKJEF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum CEILJCNEHFN
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
	public static readonly Guid JPFDINLPOIG;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid EOHJFBKHHOG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid MPJLOBHABEP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid OLAEBNHGCIO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid HPFDJOLBGGM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid BINHOBHGPNH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly OBGOAGIJEMO<MJGCNECCLCM, Guid> CABAKOAONNG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MJGCNECCLCM> IBLGHGAHEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8889A10", Offset = "0x8888010", VA = "0x188889A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8889840", Offset = "0x8887E40", VA = "0x188889840")]
	public static MJGCNECCLCM DAHEKGHFKBJ(Guid PPIICOOCLEP)
	{
		return default(MJGCNECCLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8889A90", Offset = "0x8888090", VA = "0x188889A90")]
	public static Guid IDJPMIALFOI(MJGCNECCLCM NNNCKHEINOB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88898D0", Offset = "0x8887ED0", VA = "0x1888898D0")]
	public static bool DDPDGAJECDE(MJGCNECCLCM NNNCKHEINOB, [Out] Guid PPIICOOCLEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8889B70", Offset = "0x8888170", VA = "0x188889B70")]
	public static bool PMEKDGDBPGJ(Guid PPIICOOCLEP, [Out] MJGCNECCLCM NNNCKHEINOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8889B30", Offset = "0x8888130", VA = "0x188889B30")]
	public static MJGCNECCLCM JHDLOAGCDHJ(MJGCNECCLCM NNNCKHEINOB)
	{
		return default(MJGCNECCLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8889960", Offset = "0x8887F60", VA = "0x188889960")]
	public static CEILJCNEHFN HEPLOLIAJLI(MJGCNECCLCM JGNFLNKPIGD)
	{
		return default(CEILJCNEHFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8889800", Offset = "0x8887E00", VA = "0x188889800")]
	internal static MJGCNECCLCM CFGCCNDINNE(CEILJCNEHFN HMFBDBEJLPC)
	{
		return default(MJGCNECCLCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MHCCJBIDCFD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KNOJHPOMDED BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MPGMBCPBAJA BMFHEBNGMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AHDDLFMPJGL IKLKANMLENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LCKNHJHOJIL> GLOLJANIELP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MHPMBOBMKIC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJGCNECCLCM FPADODOBAPA(KNOJHPOMDED OPOGJMFOAFI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LCKNHJHOJIL> GCEALELEMFJ(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task AMCBCDGKGDG(long CDFGHIILPDC, IReadOnlyList<ECDEFAMMPGE> DODHPHBAKOO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task IANFFJKIEGK(long CDFGHIILPDC, long EIMKPFCNHML, IReadOnlyList<ECDEFAMMPGE> DODHPHBAKOO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KNOJHPOMDED> ODCJKJMJJED();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LELMMBGJJNF
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x888C3F0", Offset = "0x888A9F0", VA = "0x18888C3F0")]
	public static MJGCNECCLCM IMHMFGNCFIL(this MHCCJBIDCFD FEPGHPEMBNI)
	{
		return default(MJGCNECCLCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface HANMFEHKMAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EENEKFBOFEO CNGBNGEHPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CFIEBKAELLO KKILDGBKNEB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<GNAADADHDFD> LBDEOIGFJKK(bool AMCNGHDNJPC = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GNAADADHDFD FMCEFCCOLMD(KNOJHPOMDED OPOGJMFOAFI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MFHLLGBJHJK(KNOJHPOMDED OPOGJMFOAFI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<GNAADADHDFD> OOIJHJJFFOF(KNOJHPOMDED OPOGJMFOAFI, bool MANBAFCAHFL = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HKNJCAAIHMP(KNOJHPOMDED AMPLEIOJLLC, MJGCNECCLCM NNNCKHEINOB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GNAADADHDFD BLDMLJCBAEP(MJGCNECCLCM NNNCKHEINOB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AFDJJOEFDPI<T>(MJGCNECCLCM NNNCKHEINOB, HLMDEMNIOLE LJAPEEGHDDO, bool JLEPNHHGBMJ, T DFPJDDAMCPC, [Optional] Action CEACCFOPNED) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string JCMNDDBEJKI(HLMDEMNIOLE LJAPEEGHDDO);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DKNGDKAGHPL(KNOJHPOMDED OPOGJMFOAFI, HLMDEMNIOLE MDKMHFPNICI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IOCBJOEFOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task APPBANMIEFF(AJMAHGBGLEH MODBIBDJKOA, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MFFHKMIDOFA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string LPNNIKMKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event KDJCOGCAJNO<TPermission> FGDMCBEEACJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class MBGIAJIEFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? MNALIIKKONG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? MNEOHBLPOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x888C550", Offset = "0x888AB50", VA = "0x18888C550")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x888C450", Offset = "0x888AA50", VA = "0x18888C450")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x888C620", Offset = "0x888AC20", VA = "0x18888C620")]
	protected MBGIAJIEFIA(object? JHAIJMNNDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool ALDAFJKHCIJ(object? KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GGFGAFFCMIK<T> : MBGIAJIEFIA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> NJKFJEICBEB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D548E0", Offset = "0x4D52EE0", VA = "0x184D548E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D54510", Offset = "0x4D52B10", VA = "0x184D54510", Slot = "4")]
	public override bool ALDAFJKHCIJ(object? KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D54AC0", Offset = "0x4D530C0", VA = "0x184D54AC0")]
	public bool OJAKKMACJFH(T CHGHGMOGECA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D55180", Offset = "0x4D53780", VA = "0x184D55180")]
	public GGFGAFFCMIK(T COMAGLLDBOM, IEqualityComparer<T> NJKFJEICBEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GEKKCBOIJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<HLMDEMNIOLE, bool> GPONFMPHLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<HLMDEMNIOLE, MBGIAJIEFIA> DPBOFAGBIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BMMDHHCPMJO AOCBANOBCME;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x88892C0", Offset = "0x88878C0", VA = "0x1888892C0")]
	public GEKKCBOIJJJ(BMMDHHCPMJO AOCBANOBCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8889250", Offset = "0x8887850", VA = "0x188889250")]
	public bool NPFPOHAFEOC(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B48F10", Offset = "0x3B47510", VA = "0x183B48F10")]
	public bool GJCAKDONNFL<T>(HLMDEMNIOLE LJAPEEGHDDO, bool JLEPNHHGBMJ, T KKGBKLFKCPO) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B48B40", Offset = "0x3B47140", VA = "0x183B48B40")]
	public (bool, T?) DIFMEMAAFHL<T>(HLMDEMNIOLE LJAPEEGHDDO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8888F80", Offset = "0x8887580", VA = "0x188888F80")]
	public bool GJCAKDONNFL(HLMDEMNIOLE LJAPEEGHDDO, bool JLEPNHHGBMJ, object KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8888DF0", Offset = "0x88873F0", VA = "0x188888DF0")]
	public (bool, object) DIFMEMAAFHL(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B49420", Offset = "0x3B47A20", VA = "0x183B49420")]
	private void JALGOFIAIKP<T>(HLMDEMNIOLE LJAPEEGHDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8888D20", Offset = "0x8887320", VA = "0x188888D20")]
	private MBGIAJIEFIA ABJEOMIDAIC(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8889060", Offset = "0x8887660", VA = "0x188889060")]
	public void GLMEKKNHFPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CFCNOOHCALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KNEGKBBPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type LCBKGIJCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly NMBJKPPKMBJ JPCDLBJLELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly HLMDEMNIOLE DJNDALIPGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ENJGKGECMGL AEEGOJLIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LCHKFJEKJOC ALMHLAFEFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PDBDBJFHEMN BKDIMFLBJGM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8888300", Offset = "0x8886900", VA = "0x188888300")]
	public CFCNOOHCALM(Type CAENDMPPDKF, string OLAMKOHKMJF, HLMDEMNIOLE LJAPEEGHDDO, ENJGKGECMGL KABCHKIIGBK, LCHKFJEKJOC JCIENMFAPFD, PDBDBJFHEMN HLLPBIGMKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88882B0", Offset = "0x88868B0", VA = "0x1888882B0")]
	public object PPKCAPEDFPB(object? HOPHFOOKMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x392CC10", Offset = "0x392B210", VA = "0x18392CC10")]
	public void JALGOFIAIKP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8888200", Offset = "0x8886800", VA = "0x188888200")]
	public void JALGOFIAIKP(Type DEGJKLFNAHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class GHPIBKMACIN<T> : CFCNOOHCALM where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string LGFCIOPCPNC(T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T AHDFNJNFOHJ(string? GEOHHFFLBNK, T COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FJGLIDGJKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LGFCIOPCPNC serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AHDFNJNFOHJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FJGLIDGJKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FEB0", Offset = "0x4C4E4B0", VA = "0x184C4FEB0")]
		internal string NFGNFMIJEJA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FD00", Offset = "0x4C4E300", VA = "0x184C4FD00")]
		internal object FFKCNBPCPMP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4D60840", Offset = "0x4D5EE40", VA = "0x184D60840")]
	public GHPIBKMACIN(HLMDEMNIOLE LJAPEEGHDDO, string OLAMKOHKMJF, [Optional] LGFCIOPCPNC? KABCHKIIGBK, [Optional] AHDFNJNFOHJ? JCIENMFAPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5F700", Offset = "0x4D5DD00", VA = "0x184D5F700")]
	private static object? FJJOMODMCLM(AHDFNJNFOHJ? JCIENMFAPFD, string? GEOHHFFLBNK, object? COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D5FA00", Offset = "0x4D5E000", VA = "0x184D5FA00")]
	private static string LGGJGPOGIBH(LGFCIOPCPNC? OCGNFMIAENJ, object? KKGBKLFKCPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string ENJGKGECMGL(object? KKGBKLFKCPO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object LCHKFJEKJOC(string? GEOHHFFLBNK, [Optional] object COMAGLLDBOM);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate MBGIAJIEFIA PDBDBJFHEMN();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class BMMDHHCPMJO
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class EIMJBMAEEPC : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static EIMJBMAEEPC FNIBPMLJKFE;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88886E0", Offset = "0x8886CE0", VA = "0x1888886E0", Slot = "4")]
		public bool Equals(List<string> POMHCCBBBGD, List<string> JKKMGDMGNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8888830", Offset = "0x8886E30", VA = "0x188888830", Slot = "5")]
		public int GetHashCode(List<string> ODCICEDDLMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EIMJBMAEEPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class FAIAFHNDMCJ : ODILPPNGKKC<FFHMDKOCHGM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8888BF0", Offset = "0x88871F0", VA = "0x188888BF0", Slot = "9")]
		public override string LGGJGPOGIBH(FFHMDKOCHGM FCHACHIDAGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8888A20", Offset = "0x8887020", VA = "0x188888A20", Slot = "10")]
		protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] FFHMDKOCHGM KKGBKLFKCPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8888CE0", Offset = "0x88872E0", VA = "0x188888CE0")]
		public FAIAFHNDMCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly HJNPCHBCNNH BCNFOCGOMHI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FAIAFHNDMCJ JIAFPELKKGL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CFCNOOHCALM> OCPMLOEPNNE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<HLMDEMNIOLE> PMEBJIPAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<HLMDEMNIOLE, CFCNOOHCALM> EOGFFPLBFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8887EB0", Offset = "0x88864B0", VA = "0x188887EB0")]
	public BMMDHHCPMJO([Optional] IList<CFCNOOHCALM>? PLDNKONBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8886910", Offset = "0x8884F10", VA = "0x188886910")]
	public CFCNOOHCALM IHPHMDHACHP(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EENEKFBOFEO
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	GNAADADHDFD PGPJBECCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class BJADCNAEBNH : EENEKFBOFEO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static BJADCNAEBNH ANBAAGLNNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly KPGGJCLHCLI JANBPIPENKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<KPGGJCLHCLI> EENGNFBNACN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GNAADADHDFD PGPJBECCOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8886800", Offset = "0x8884E00", VA = "0x188886800")]
	public BJADCNAEBNH(KPGGJCLHCLI AHHCLAHCLBJ, IReadOnlyList<KPGGJCLHCLI> JHANDDKCDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88858E0", Offset = "0x8883EE0", VA = "0x1888858E0")]
	private static BJADCNAEBNH GBODNKBHABD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DPCHDHNAAML
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<MJGCNECCLCM> GIFCBLBGDBA;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x88883D0", Offset = "0x88869D0", VA = "0x1888883D0")]
	public static bool AEKCDFMAEBJ(this KNOJHPOMDED GEHCGKCBEID, MJGCNECCLCM NNNCKHEINOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x88884B0", Offset = "0x8886AB0", VA = "0x1888884B0")]
	public static bool CDDGEFNMEBK(this KNOJHPOMDED GEHCGKCBEID, MJGCNECCLCM NNNCKHEINOB, AHDDLFMPJGL NHAFNMPNAOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IIFIBDPBLJK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> OFGFFLBAACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FFHMDKOCHGM HFNBDKIJOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GNAADADHDFD : IIFIBDPBLJK, IOOPBEGFLBN, MFFHKMIDOFA<HLMDEMNIOLE>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string APHDOJBIDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	MJGCNECCLCM NLNEKGBLGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ABBHDPCMNKM<T>(HLMDEMNIOLE LJAPEEGHDDO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class KPGGJCLHCLI : GNAADADHDFD, IIFIBDPBLJK, IOOPBEGFLBN, MFFHKMIDOFA<HLMDEMNIOLE>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly BMMDHHCPMJO CMBFEABEBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly GEKKCBOIJJJ JLGBKLKNKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? KJOFNPECEGH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool HLIHAAHNJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x888A890", Offset = "0x8888E90", VA = "0x18888A890", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool DDPFDHAIHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x888A930", Offset = "0x8888F30", VA = "0x18888A930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool NCEFPPEDEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x888A9D0", Offset = "0x8888FD0", VA = "0x18888A9D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool KEANKGHOEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x888C080", Offset = "0x888A680", VA = "0x18888C080", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool ENNFINDJIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x888A980", Offset = "0x8888F80", VA = "0x18888A980", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MHFPJCLFLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x888BD30", Offset = "0x888A330", VA = "0x18888BD30", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MJGCNECCLCM NLNEKGBLGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MJGCNECCLCM);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string LPNNIKMKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x888A840", Offset = "0x8888E40", VA = "0x18888A840", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string APHDOJBIDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x888A840", Offset = "0x8888E40", VA = "0x18888A840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MPMOEIHGJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FFHMDKOCHGM HFNBDKIJOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x888AA40", Offset = "0x8889040", VA = "0x18888AA40", Slot = "8")]
		get
		{
			return default(FFHMDKOCHGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> OFGFFLBAACD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x888B770", Offset = "0x8889D70", VA = "0x18888B770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool HOEHBFKCDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x888A890", Offset = "0x8888E90", VA = "0x18888A890", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool EGNGJECBKII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x888A980", Offset = "0x8888F80", VA = "0x18888A980", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool LPIBNLNAMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x888A930", Offset = "0x8888F30", VA = "0x18888A930", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool BPBBJMMFANM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x888A9D0", Offset = "0x8888FD0", VA = "0x18888A9D0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JEANAKPGKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x888C080", Offset = "0x888A680", VA = "0x18888C080", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IIKLNNDDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x888BD30", Offset = "0x888A330", VA = "0x18888BD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KDJCOGCAJNO<HLMDEMNIOLE> FGDMCBEEACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x888A790", Offset = "0x8888D90", VA = "0x18888A790", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x888BC80", Offset = "0x888A280", VA = "0x18888BC80", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE3FD0", Offset = "0x3BE25D0", VA = "0x183BE3FD0", Slot = "6")]
	public (bool, T?) ABBHDPCMNKM<T>(HLMDEMNIOLE LJAPEEGHDDO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3BE4160", Offset = "0x3BE2760", VA = "0x183BE4160")]
	public KPGGJCLHCLI EBGIAKOEAGO<T>(HLMDEMNIOLE LJAPEEGHDDO, bool JLEPNHHGBMJ, T KKGBKLFKCPO) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x888C270", Offset = "0x888A870", VA = "0x18888C270")]
	public KPGGJCLHCLI(MJGCNECCLCM NNNCKHEINOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x888C290", Offset = "0x888A890", VA = "0x18888C290")]
	public KPGGJCLHCLI(MJGCNECCLCM NNNCKHEINOB, [Optional] string? KJOFNPECEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x888C1E0", Offset = "0x888A7E0", VA = "0x18888C1E0")]
	public KPGGJCLHCLI(KPGGJCLHCLI HIPKNMGBALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x888C2B0", Offset = "0x888A8B0", VA = "0x18888C2B0")]
	internal KPGGJCLHCLI(MJGCNECCLCM HAJPIJOFJEL, [Optional] string? KJOFNPECEGH, [Optional] KPGGJCLHCLI? HIPKNMGBALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x888C0D0", Offset = "0x888A6D0", VA = "0x18888C0D0")]
	public static NMBJKPPKMBJ NMDCLAOCAAJ(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return default(NMBJKPPKMBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x888AA20", Offset = "0x8889020", VA = "0x18888AA20")]
	public void GLMEKKNHFPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x888AB20", Offset = "0x8889120", VA = "0x18888AB20")]
	internal KPGGJCLHCLI IMDCLABPHGF(KPGGJCLHCLI JHKKIPJEMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x888B8B0", Offset = "0x8889EB0", VA = "0x18888B8B0")]
	internal IReadOnlyCollection<HLMDEMNIOLE> KOBGMGDADOJ(KPGGJCLHCLI HIPKNMGBALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x888B7D0", Offset = "0x8889DD0", VA = "0x18888B7D0")]
	public bool KENIDJHHJID(HLMDEMNIOLE LJAPEEGHDDO, bool JLEPNHHGBMJ, string OJPJLOBCLKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x888BD80", Offset = "0x888A380", VA = "0x18888BD80")]
	public (bool, string) LDLFKNNLIGF(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x888A8E0", Offset = "0x8888EE0", VA = "0x18888A8E0")]
	internal void DKGPIFGDLHL(HLMDEMNIOLE LJAPEEGHDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x888BE80", Offset = "0x888A480", VA = "0x18888BE80")]
	public GAEOJDDANNC LEPIFMPJKPP(Func<MJGCNECCLCM, Guid> NHEEIHIIKON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x888AE10", Offset = "0x8889410", VA = "0x18888AE10")]
	public void JFAOGDAGDIJ(GAEOJDDANNC EJNNGEKLKPO, Func<Guid, MJGCNECCLCM> IJJFKDLIKDM, [Optional] MJGCNECCLCM? HOHFMGGBMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x888AA90", Offset = "0x8889090", VA = "0x18888AA90")]
	[CompilerGenerated]
	private void HPHKFLBCKHO(HLMDEMNIOLE MDKMHFPNICI, EOIPLNKEKPI BNJKAALLNKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ONNPNELNAKG : IOCBJOEFOOO, HANMFEHKMAM, IDisposable, GEKAHGJJFJJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DDMOBCPFMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public KPGGJCLHCLI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DDMOBCPFMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x88883A0", Offset = "0x88869A0", VA = "0x1888883A0")]
		internal bool HMDLHJLIGPI(KPGGJCLHCLI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JJDOEJOFEEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public MJGCNECCLCM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public JJDOEJOFEEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA600", Offset = "0x1DC8C00", VA = "0x181DCA600")]
		internal bool BIIEJPFOAEN(MJGCNECCLCM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AFAHOEPJGPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ONNPNELNAKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AJMAHGBGLEH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<LCKNHJHOJIL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8885210", Offset = "0x8883810", VA = "0x188885210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8885880", Offset = "0x8883E80", VA = "0x188885880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GGJHBDCDAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GGJHBDCDAML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8889570", Offset = "0x8887B70", VA = "0x188889570")]
		internal void ACBGHICEECN(GAEOJDDANNC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8889650", Offset = "0x8887C50", VA = "0x188889650")]
		internal void BEFINEOGHPD(GAEOJDDANNC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CHKJBDCMCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AJMAHGBGLEH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GJANBBJDMIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<GAEOJDDANNC, EOIPLNKEKPI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GJANBBJDMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x88897D0", Offset = "0x8887DD0", VA = "0x1888897D0")]
		internal void IIMMEOBJHKG(GAEOJDDANNC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8889770", Offset = "0x8887D70", VA = "0x188889770")]
		internal void ENKNELDAAPJ(GAEOJDDANNC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x88897A0", Offset = "0x8887DA0", VA = "0x1888897A0")]
		internal void GNKHFIBKFJN(GAEOJDDANNC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NLPIIFJJFNJ<T> where T : notnull
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
			public NLPIIFJJFNJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<LCKNHJHOJIL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4303940", Offset = "0x4301F40", VA = "0x184303940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public HLMDEMNIOLE rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MJGCNECCLCM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NMBJKPPKMBJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ONNPNELNAKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public NLPIIFJJFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x569EAC0", Offset = "0x569D0C0", VA = "0x18569EAC0")]
		[AsyncStateMachine(typeof(NLPIIFJJFNJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void ABLJMHPGCBN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KDJEKJPBCMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<ECDEFAMMPGE> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PEKLBFECBDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public MHCCJBIDCFD rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AJMAHGBGLEH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<MJGCNECCLCM, KPGGJCLHCLI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HJILBECDIFL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x88923F0", Offset = "0x88909F0", VA = "0x1888923F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8892F10", Offset = "0x8891510", VA = "0x188892F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MHCCJBIDCFD FEPGHPEMBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BJADCNAEBNH AMMHMLNFEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HJILBECDIFL KOFKJMOGEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, KPGGJCLHCLI> IDLPHBPGLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<MJGCNECCLCM, KPGGJCLHCLI> ELBEGCABHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<MJGCNECCLCM, KPGGJCLHCLI> MBLCFILJDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<KPGGJCLHCLI> JOEPMKOFMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool KCIMCDFFOEN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly HLMDEMNIOLE[] HGIOBDJKNIE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EENEKFBOFEO CNGBNGEHPOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CFIEBKAELLO KKILDGBKNEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x888EEB0", Offset = "0x888D4B0", VA = "0x18888EEB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x888EC10", Offset = "0x888D210", VA = "0x18888EC10", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x888EF50", Offset = "0x888D550", VA = "0x18888EF50")]
	[BNHIEDNKDNA.CCDABDMPDDG]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK PPICPBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8892130", Offset = "0x8890730", VA = "0x188892130")]
	[UnityEngine.Scripting.Preserve]
	internal ONNPNELNAKG([GGNLMCAPMLP(null)] MHCCJBIDCFD GFHPIJMNEIB, [GGNLMCAPMLP(null)] BJADCNAEBNH JHMOHHHFONK, [GGNLMCAPMLP(null)] HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x888D540", Offset = "0x888BB40", VA = "0x18888D540", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x888D650", Offset = "0x888BC50", VA = "0x18888D650")]
	private void EIDELODFIKJ(IEnumerable<KPGGJCLHCLI> HAHKLBGANBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8891440", Offset = "0x888FA40", VA = "0x188891440", Slot = "10")]
	public bool MFHLLGBJHJK(KNOJHPOMDED OPOGJMFOAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8891510", Offset = "0x888FB10", VA = "0x188891510")]
	private void MHPMBOBMKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8891B00", Offset = "0x8890100", VA = "0x188891B00")]
	private void OGAGHDIFEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8891080", Offset = "0x888F680", VA = "0x188891080", Slot = "8")]
	public IReadOnlyList<GNAADADHDFD> LBDEOIGFJKK(bool AMCNGHDNJPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x888ECB0", Offset = "0x888D2B0", VA = "0x18888ECB0", Slot = "9")]
	public GNAADADHDFD FMCEFCCOLMD(KNOJHPOMDED OPOGJMFOAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x888EDC0", Offset = "0x888D3C0", VA = "0x18888EDC0")]
	private MJGCNECCLCM FPLBLBFBCGP(KNOJHPOMDED OPOGJMFOAFI)
	{
		return default(MJGCNECCLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x888F110", Offset = "0x888D710", VA = "0x18888F110", Slot = "12")]
	public bool HKNJCAAIHMP(KNOJHPOMDED AMPLEIOJLLC, MJGCNECCLCM NNNCKHEINOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x888CD00", Offset = "0x888B300", VA = "0x18888CD00", Slot = "13")]
	public GNAADADHDFD BLDMLJCBAEP(MJGCNECCLCM NNNCKHEINOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x888C7A0", Offset = "0x888ADA0", VA = "0x18888C7A0")]
	private static bool APACAKEIFHG(FGKJCAEEOCF JLOMENCIIGI, MJGCNECCLCM NNNCKHEINOB, [Out] GAEOJDDANNC? JDOLNCPEHIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x888E8F0", Offset = "0x888CEF0", VA = "0x18888E8F0")]
	private static void FAKJBMCKPGJ(FGKJCAEEOCF JLOMENCIIGI, Action<GAEOJDDANNC> MMFDFGDFOFC, MJGCNECCLCM NLGJLCOOODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x888E660", Offset = "0x888CC60", VA = "0x18888E660")]
	private static void FAKJBMCKPGJ(FGKJCAEEOCF JLOMENCIIGI, Action<GAEOJDDANNC> MMFDFGDFOFC, Predicate<MJGCNECCLCM> LFMAOLBKFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8891CE0", Offset = "0x88902E0", VA = "0x188891CE0")]
	private void OGNJPLAEPJI(KNOJHPOMDED OPOGJMFOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x888CAD0", Offset = "0x888B0D0", VA = "0x18888CAD0", Slot = "4")]
	[AsyncStateMachine(typeof(AFAHOEPJGPA))]
	public Task APPBANMIEFF([CanBeNull] AJMAHGBGLEH MODBIBDJKOA, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8891100", Offset = "0x888F700", VA = "0x188891100")]
	private void LKNDPPJCOPD(FGKJCAEEOCF JGDDAOKFPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x888D090", Offset = "0x888B690", VA = "0x18888D090")]
	internal static string COMKKNHEAJJ(MHCCJBIDCFD FEPGHPEMBNI, AJMAHGBGLEH MODBIBDJKOA, IReadOnlyDictionary<MJGCNECCLCM, KPGGJCLHCLI> ELBEGCABHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8890110", Offset = "0x888E710", VA = "0x188890110")]
	private static void JPECDEEMEOJ(AJMAHGBGLEH MODBIBDJKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x888F280", Offset = "0x888D880", VA = "0x18888F280")]
	private static void INEMEMCEHEN(FGKJCAEEOCF JLNIBABFDCP, IReadOnlyDictionary<MJGCNECCLCM, KPGGJCLHCLI> ELBEGCABHDJ, StringBuilder JAMMOELFGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x888CBF0", Offset = "0x888B1F0", VA = "0x18888CBF0")]
	private static bool BCGPHNGBGNH(string HBAGFEIEHDF, [Out] Guid OJFPCGOHIML, [Out] MJGCNECCLCM NNNCKHEINOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x888F9D0", Offset = "0x888DFD0", VA = "0x18888F9D0")]
	private static void JFLNCKEGELG(AJMAHGBGLEH MODBIBDJKOA, StringBuilder JAMMOELFGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0920", Offset = "0x3CEEF20", VA = "0x183CF0920", Slot = "14")]
	public bool AFDJJOEFDPI<T>(MJGCNECCLCM NNNCKHEINOB, HLMDEMNIOLE LJAPEEGHDDO, bool JLEPNHHGBMJ, T DFPJDDAMCPC, [Optional] Action CEACCFOPNED) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x888F5D0", Offset = "0x888DBD0", VA = "0x18888F5D0", Slot = "15")]
	public string JCMNDDBEJKI(HLMDEMNIOLE LJAPEEGHDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x888D450", Offset = "0x888BA50", VA = "0x18888D450", Slot = "16")]
	public bool DKNGDKAGHPL(KNOJHPOMDED OPOGJMFOAFI, HLMDEMNIOLE MDKMHFPNICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x888D3A0", Offset = "0x888B9A0", VA = "0x18888D3A0", Slot = "18")]
	public bool DKNGDKAGHPL(int HFCJPLHKMHP, HLMDEMNIOLE MDKMHFPNICI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8891D50", Offset = "0x8890350", VA = "0x188891D50")]
	private void OOHOBOJMAAO(MJGCNECCLCM NNNCKHEINOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x888EE90", Offset = "0x888D490", VA = "0x18888EE90")]
	private bool GBMFNGFEFGE(KNOJHPOMDED OPOGJMFOAFI, MJGCNECCLCM NNNCKHEINOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x88917C0", Offset = "0x888FDC0", VA = "0x1888917C0")]
	internal KPGGJCLHCLI NLEKJEBCGGB(KNOJHPOMDED OPOGJMFOAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8891F50", Offset = "0x8890550", VA = "0x188891F50", Slot = "11")]
	public IReadOnlyList<GNAADADHDFD> OOIJHJJFFOF(KNOJHPOMDED OPOGJMFOAFI, bool MANBAFCAHFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x888E9E0", Offset = "0x888CFE0", VA = "0x18888E9E0")]
	internal IReadOnlyList<KPGGJCLHCLI> FDKCHIEBAAH(KNOJHPOMDED OPOGJMFOAFI, bool MANBAFCAHFL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x888DEC0", Offset = "0x888C4C0", VA = "0x18888DEC0")]
	private void EPOKGPBBDGF(LCKNHJHOJIL MJHAFKHIAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x888CDA0", Offset = "0x888B3A0", VA = "0x18888CDA0")]
	private static bool BMLHNEJKIMP(KPGGJCLHCLI FMNKGFAIOIG, IReadOnlyDictionary<MJGCNECCLCM, KPGGJCLHCLI> ELBEGCABHDJ, [Out] IReadOnlyList<HLMDEMNIOLE> KFMMFBIGPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8890F40", Offset = "0x888F540", VA = "0x188890F40")]
	[AsyncStateMachine(typeof(PEKLBFECBDI))]
	private static Task KOLMMFKCEHK(MHCCJBIDCFD FEPGHPEMBNI, AJMAHGBGLEH MODBIBDJKOA, IReadOnlyDictionary<MJGCNECCLCM, KPGGJCLHCLI> ELBEGCABHDJ, HJILBECDIFL KOFKJMOGEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8891520", Offset = "0x888FB20", VA = "0x188891520")]
	[CompilerGenerated]
	internal static void MLEBINKFHBP(Func<GAEOJDDANNC, EOIPLNKEKPI> LFEMKDGKAON, CHKJBDCMCDN P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x888F650", Offset = "0x888DC50", VA = "0x18888F650")]
	[CompilerGenerated]
	internal static bool JDBNHBBHMBM(MJGCNECCLCM NNNCKHEINOB, HLMDEMNIOLE LJAPEEGHDDO, [Out] ECDEFAMMPGE DFHMEBHJJPP, KDJEKJPBCMP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CEAPOIHGGLO
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMDJBKBAADB(KNOJHPOMDED DJHLJDBNJPP, KNOJHPOMDED MBPLDMKEELO, IEnumerable<KNOJHPOMDED> JACOAPMDDJG, [Out] FFHMDKOCHGM FHPGGBILBOK, [Out] BFCCBECCGHF GCGLGMJHFFA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BCLKMAFDOMK(BFCCBECCGHF BDDGNBGKGJH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum BFCCBECCGHF : byte
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
internal class JFMFENLDAKP : CEAPOIHGGLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly HANMFEHKMAM COKFJGLOKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CHOHCOOIGDI EEDOMDKMPJJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JFMFENLDAKP([GGNLMCAPMLP(null)] HANMFEHKMAM COKFJGLOKLJ, [GGNLMCAPMLP(null)] CHOHCOOIGDI DFHNHLJPHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x888A750", Offset = "0x8888D50", VA = "0x18888A750")]
	private static PABPINJHJCA? KNPMCECDGEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x888A030", Offset = "0x8888630", VA = "0x18888A030", Slot = "4")]
	public bool DMDJBKBAADB(KNOJHPOMDED DJHLJDBNJPP, KNOJHPOMDED MBPLDMKEELO, IEnumerable<KNOJHPOMDED> JACOAPMDDJG, [Out] FFHMDKOCHGM FHPGGBILBOK, [Out] BFCCBECCGHF GCGLGMJHFFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8889F30", Offset = "0x8888530", VA = "0x188889F30", Slot = "5")]
	public string BCLKMAFDOMK(BFCCBECCGHF BDDGNBGKGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x888A130", Offset = "0x8888730", VA = "0x18888A130")]
	internal bool FJBLDKNMLKK(KNOJHPOMDED DJHLJDBNJPP, KNOJHPOMDED MBPLDMKEELO, IEnumerable<KNOJHPOMDED> JACOAPMDDJG, AHDDLFMPJGL NHAFNMPNAOF, PABPINJHJCA? OEBMJPADELB, [Out] FFHMDKOCHGM FHPGGBILBOK, [Out] BFCCBECCGHF GCGLGMJHFFA)
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
