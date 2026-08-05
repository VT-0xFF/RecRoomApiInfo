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
using RecRoom.DataLayer.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x72C16E0", Offset = "0x72C00E0", VA = "0x1872C16E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PNABIHOFHPB
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
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72C1EC0", Offset = "0x72C08C0", VA = "0x1872C1EC0", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void ONKLNGAAGBI<TPermission>(TPermission CPIHEENNHEI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BBOBHEIKBJD(ICGGIJDMFMC DBKPGAEGHAD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CNBOEHKOKHG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BKHDPBECKON
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OJNBADCIHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FGDNCLCNOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ILGJPNNLKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LGKCEALNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NEPOLJEHLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ECJFDACLEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class ENBIOPKBIIJ
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum IPEGMFJAHIM
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
	public static readonly Guid KJFJEALLFOM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IJBODJGPHGO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid MCLOFPLMICG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid IGBKBGPDOEO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DBCEDJANEFH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid KJBCDGJIGEM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly GLNMNAKLAEF<LNBDJMHHJGO, Guid> AMFGONDJNHG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<LNBDJMHHJGO> FKBNCOOGLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x72B4190", Offset = "0x72B2B90", VA = "0x1872B4190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72B4030", Offset = "0x72B2A30", VA = "0x1872B4030")]
	public static LNBDJMHHJGO DOFIBFEMJBP(Guid OKMPNEEAGBI)
	{
		return default(LNBDJMHHJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72B4200", Offset = "0x72B2C00", VA = "0x1872B4200")]
	public static Guid MJKNKHMCPFF(LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72B4100", Offset = "0x72B2B00", VA = "0x1872B4100")]
	public static bool KNDBGECBCNN(LNBDJMHHJGO KHLJHJHCCGC, [Out] Guid OKMPNEEAGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72B3EE0", Offset = "0x72B28E0", VA = "0x1872B3EE0")]
	public static bool AMEHDKCDINN(Guid OKMPNEEAGBI, [Out] LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72B42A0", Offset = "0x72B2CA0", VA = "0x1872B42A0")]
	public static LNBDJMHHJGO PLNFFMNKHED(LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(LNBDJMHHJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72B3F80", Offset = "0x72B2980", VA = "0x1872B3F80")]
	public static IPEGMFJAHIM CLEAKLNFHFL(LNBDJMHHJGO MMKAADEEOKI)
	{
		return default(IPEGMFJAHIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72B40C0", Offset = "0x72B2AC0", VA = "0x1872B40C0")]
	internal static LNBDJMHHJGO HAKNOAFPJHL(IPEGMFJAHIM KBIAKPFBOCE)
	{
		return default(LNBDJMHHJGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HOJFGOFAEOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AFEGPFDBCKI HDCJONFMEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<KIPDPEFFADO> DFLHHCDAKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BBOBHEIKBJD DBHIMIMMIPO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<KIPDPEFFADO> OJHGOLEALKD(bool KGBPOIMKBGI = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KIPDPEFFADO HNJOJGOHBDH(ICGGIJDMFMC DBKPGAEGHAD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FGMCCOBOIDE(ICGGIJDMFMC DBKPGAEGHAD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<KIPDPEFFADO> EJIFLIPMGBH(ICGGIJDMFMC DBKPGAEGHAD, bool JGHAIGPMPMN = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PJHNNNNHNAF(ICGGIJDMFMC GDOIPGMMJEL, LNBDJMHHJGO KHLJHJHCCGC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KIPDPEFFADO FGAHKPLMIPC(LNBDJMHHJGO KHLJHJHCCGC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EKGCEHCHMPD<T>(LNBDJMHHJGO KHLJHJHCCGC, EFLDKEDAJFO CPIHEENNHEI, bool NADHNKNFKFF, T OKHFPGFAECB, [Optional] Action IKMNKNJKIOA) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string EKFEKLKIPND(EFLDKEDAJFO CPIHEENNHEI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OMEIMCMEFGE
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task INFEGEFGDDK(EGDKLHCLIKL HCKNFILJEND, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HHMCMCDFBKF(EGDKLHCLIKL HCKNFILJEND);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KEONHKCHPKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	ICGGIJDMFMC LJEDONCJDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FLFGKHCBJJD KBDFDJCLIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NBOIDPFPFBM DKOOFCLDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HNGOMGHAABH> KMMNMGGHJHL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HLCENPBALBA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LNBDJMHHJGO GNNBFPOPHJM(ICGGIJDMFMC DBKPGAEGHAD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HNGOMGHAABH> ONHOCGCNEHO(CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ENBPPFDPPHA(long MOEKPKHCJHD, IReadOnlyList<MPPEFPHOJAI> MPNIADOKHBJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task LMLBJIPFJEC(long MOEKPKHCJHD, long OAOCFKDGHFI, IReadOnlyList<MPPEFPHOJAI> MPNIADOKHBJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<ICGGIJDMFMC> LJIGDMKKLGC();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class NPDEEGNLNJG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72C1680", Offset = "0x72C0080", VA = "0x1872C1680")]
	public static LNBDJMHHJGO CKOILMLHKDD(this KEONHKCHPKM KILFGPOHMAC)
	{
		return default(LNBDJMHHJGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CGIAGCFDFAJ<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string POEEMHENHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ONKLNGAAGBI<TPermission> GKCGHGKFICK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class JEOGNDAFBDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? DPEAIKKHHGL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? PCIDGKMHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72B7930", Offset = "0x72B6330", VA = "0x1872B7930")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72B7A00", Offset = "0x72B6400", VA = "0x1872B7A00")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72B7B00", Offset = "0x72B6500", VA = "0x1872B7B00")]
	protected JEOGNDAFBDJ(object? FKKNFDGCPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool BANKOIMGLDC(object? IPHMAHBENGI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HGEEGIIKOLL<T> : JEOGNDAFBDJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> JJCIHJBGFLO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F5D290", Offset = "0x3F5BC90", VA = "0x183F5D290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3F5C8C0", Offset = "0x3F5B2C0", VA = "0x183F5C8C0", Slot = "4")]
	public override bool BANKOIMGLDC(object? IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3F5CCE0", Offset = "0x3F5B6E0", VA = "0x183F5CCE0")]
	public bool ELKGIKKIGNM(T FECLDLPFBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3F5D6F0", Offset = "0x3F5C0F0", VA = "0x183F5D6F0")]
	public HGEEGIIKOLL(T FABNMHPKJIP, IEqualityComparer<T> JJCIHJBGFLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ENGMGGKFLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<EFLDKEDAJFO, bool> BEJOGJAKODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<EFLDKEDAJFO, JEOGNDAFBDJ> LFCNBCPOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IHMKJKIDKCH KCLADCCOMBH;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72B4B70", Offset = "0x72B3570", VA = "0x1872B4B70")]
	public ENGMGGKFLEM(IHMKJKIDKCH KCLADCCOMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72B4950", Offset = "0x72B3350", VA = "0x1872B4950")]
	public bool HLJCEJPBMKH(EFLDKEDAJFO CPIHEENNHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1130", Offset = "0x2BCFB30", VA = "0x182BD1130")]
	public bool PLMKLEGAHPI<T>(EFLDKEDAJFO CPIHEENNHEI, bool NADHNKNFKFF, T IPHMAHBENGI) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0C90", Offset = "0x2BCF690", VA = "0x182BD0C90")]
	public (bool, T?) FINEKMNHEII<T>(EFLDKEDAJFO CPIHEENNHEI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72B4A90", Offset = "0x72B3490", VA = "0x1872B4A90")]
	public bool PLMKLEGAHPI(EFLDKEDAJFO CPIHEENNHEI, bool NADHNKNFKFF, object IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72B47C0", Offset = "0x72B31C0", VA = "0x1872B47C0")]
	public (bool, object) FINEKMNHEII(EFLDKEDAJFO CPIHEENNHEI)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0C30", Offset = "0x2BCF630", VA = "0x182BD0C30")]
	private void DLJDHNHDOLL<T>(EFLDKEDAJFO CPIHEENNHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72B49C0", Offset = "0x72B33C0", VA = "0x1872B49C0")]
	private JEOGNDAFBDJ KFNMGAEOBLG(EFLDKEDAJFO CPIHEENNHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72B45D0", Offset = "0x72B2FD0", VA = "0x1872B45D0")]
	public void ENJDIJGELFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LOHIBJOHCFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string MBOLGOCFBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type FAEBKDKFEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly FHJLMMDFOMF FNHKADKMFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EFLDKEDAJFO HIMIFCEJIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LGGPPLHCJHC EPMIGDOLNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PCCEFHAFJNJ PLGLKNHCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DPEEOPBABEE MLELNEIJMBP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72B8860", Offset = "0x72B7260", VA = "0x1872B8860")]
	public LOHIBJOHCFI(Type LGAAECIJHBO, string BLHNADIJFBC, EFLDKEDAJFO CPIHEENNHEI, LGGPPLHCJHC PBKLGKCCBAJ, PCCEFHAFJNJ ENICLGHACBF, DPEEOPBABEE NBIBMEAFCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72B8810", Offset = "0x72B7210", VA = "0x1872B8810")]
	public object OEIGONKAGLP(object? CGCLEIBHLHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2E59C40", Offset = "0x2E58640", VA = "0x182E59C40")]
	public void DLJDHNHDOLL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72B8760", Offset = "0x72B7160", VA = "0x1872B8760")]
	public void DLJDHNHDOLL(Type IGAOPCHCKIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HJNFOCDJDFN<T> : LOHIBJOHCFI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string LGKKAGNDMOM(T IPHMAHBENGI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T JNFBHEMEPNH(string? CHFICMBNKJJ, T FABNMHPKJIP);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MNBFEBBKMNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LGKKAGNDMOM serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JNFBHEMEPNH parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MNBFEBBKMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x473D840", Offset = "0x473C240", VA = "0x18473D840")]
		internal string HNJIKPCIEHG(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x473D6F0", Offset = "0x473C0F0", VA = "0x18473D6F0")]
		internal object BPPEMKOAMMP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3920", Offset = "0x3FC2320", VA = "0x183FC3920")]
	public HJNFOCDJDFN(EFLDKEDAJFO CPIHEENNHEI, string BLHNADIJFBC, [Optional] LGKKAGNDMOM? PBKLGKCCBAJ, [Optional] JNFBHEMEPNH? ENICLGHACBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2CD0", Offset = "0x3FC16D0", VA = "0x183FC2CD0")]
	private static object? MPIHBHFBPAP(JNFBHEMEPNH? ENICLGHACBF, string? CHFICMBNKJJ, object? FABNMHPKJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC21A0", Offset = "0x3FC0BA0", VA = "0x183FC21A0")]
	private static string BBLOJHGNHMB(LGKKAGNDMOM? AIHFMACBNBB, object? IPHMAHBENGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string LGGPPLHCJHC(object? IPHMAHBENGI);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object PCCEFHAFJNJ(string? CHFICMBNKJJ, [Optional] object FABNMHPKJIP);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate JEOGNDAFBDJ DPEEOPBABEE();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class IHMKJKIDKCH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class ELAMCFGPCII : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static ELAMCFGPCII GHBFIIGNNDE;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72B3BB0", Offset = "0x72B25B0", VA = "0x1872B3BB0", Slot = "4")]
		public bool Equals(List<string> OFCNMBDJPHM, List<string> CONCKFNNMJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72B3D00", Offset = "0x72B2700", VA = "0x1872B3D00", Slot = "5")]
		public int GetHashCode(List<string> FHFDEAHMMBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ELAMCFGPCII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class LAEPFLCEFIH : HELOAOEFPHK<PNABIHOFHPB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x72B8630", Offset = "0x72B7030", VA = "0x1872B8630", Slot = "9")]
		public override string BBLOJHGNHMB(PNABIHOFHPB AHBBCFFJCCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x72B8450", Offset = "0x72B6E50", VA = "0x1872B8450", Slot = "10")]
		protected override bool AEHNIJJPPAE(string AHBBCFFJCCJ, [Out] PNABIHOFHPB IPHMAHBENGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72B8720", Offset = "0x72B7120", VA = "0x1872B8720")]
		public LAEPFLCEFIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly ONFIHAPFOBL PNNMKIADFNO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LAEPFLCEFIH BBOIOHIFJFH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<LOHIBJOHCFI> OCOLKNCMFOC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<EFLDKEDAJFO> HAHHANNAPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<EFLDKEDAJFO, LOHIBJOHCFI> EIEHDAFNFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72B63C0", Offset = "0x72B4DC0", VA = "0x1872B63C0")]
	public IHMKJKIDKCH([Optional] IList<LOHIBJOHCFI>? HODLKJBECNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72B4EB0", Offset = "0x72B38B0", VA = "0x1872B4EB0")]
	public LOHIBJOHCFI CGJHGCIINFM(EFLDKEDAJFO CPIHEENNHEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AFEGPFDBCKI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KIPDPEFFADO BKLHBDLBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class NMILLFFBENJ : AFEGPFDBCKI
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static NMILLFFBENJ MOECOJKFGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly NCJIGBKPBOC LMMPBCMOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<NCJIGBKPBOC> NFNIPAEALBF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KIPDPEFFADO BKLHBDLBBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72C1270", Offset = "0x72BFC70", VA = "0x1872C1270")]
	public NMILLFFBENJ(NCJIGBKPBOC PMCHCOHPKDD, IReadOnlyList<NCJIGBKPBOC> KMFLAAMABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72C03E0", Offset = "0x72BEDE0", VA = "0x1872C03E0")]
	private static NMILLFFBENJ LGGGOCNKBPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NOCAKDLECEE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<LNBDJMHHJGO> BACOMFICMFJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72C1380", Offset = "0x72BFD80", VA = "0x1872C1380")]
	public static bool EFCPGDCCCEH(this ICGGIJDMFMC JDGFBJBABBK, LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72C1460", Offset = "0x72BFE60", VA = "0x1872C1460")]
	public static bool GJPHMCHOEOJ(this ICGGIJDMFMC JDGFBJBABBK, LNBDJMHHJGO KHLJHJHCCGC, NBOIDPFPFBM AHDMLEHPFLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JIMHGKAFJGP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LNDPEKDKNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BMEJJFPDMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool EBFNHDDIGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PADLEADMJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JNHCCGFMEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BCPGPBMIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool IKJDJAEFDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PCPOJHBAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FEFNINAMCAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OHBINCGBGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JNPHJIJECBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HEFCDNEKJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> PHFEJELKMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PNABIHOFHPB OPIEBGAEOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KIPDPEFFADO : JIMHGKAFJGP, BKHDPBECKON, CGIAGCFDFAJ<EFLDKEDAJFO>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string AFKLGDJODPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LNBDJMHHJGO MDCMEOJMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JFGCJAMIIJL<T>(EFLDKEDAJFO CPIHEENNHEI) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum EFLDKEDAJFO
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
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class NCJIGBKPBOC : KIPDPEFFADO, JIMHGKAFJGP, BKHDPBECKON, CGIAGCFDFAJ<EFLDKEDAJFO>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly IHMKJKIDKCH MOMOGKFFPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly ENGMGGKFLEM NOGGAIFDNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? KBAGCCEAHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? BOLFANJJIIM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool OKPHBGODDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x72BF660", Offset = "0x72BE060", VA = "0x1872BF660", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool ALMLIMMOLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72BF700", Offset = "0x72BE100", VA = "0x1872BF700", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HFEEOONLOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72BFF00", Offset = "0x72BE900", VA = "0x1872BFF00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool MJBBGLKGHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72BFFA0", Offset = "0x72BE9A0", VA = "0x1872BFFA0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FHDPKCIPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72BF380", Offset = "0x72BDD80", VA = "0x1872BF380", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool OLPIGAIMPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72BF610", Offset = "0x72BE010", VA = "0x1872BF610", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LNBDJMHHJGO MDCMEOJMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC0B0", Offset = "0xAAAAB0", VA = "0x180AAC0B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(LNBDJMHHJGO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88CDB0", Offset = "0x88B7B0", VA = "0x18088CDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string POEEMHENHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x72BE790", Offset = "0x72BD190", VA = "0x1872BE790", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72BF900", Offset = "0x72BE300", VA = "0x1872BF900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string AFKLGDJODPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72BE790", Offset = "0x72BD190", VA = "0x1872BE790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NMMLDNNBBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x92EC70", Offset = "0x92D670", VA = "0x18092EC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC24E20", Offset = "0xC23820", VA = "0x180C24E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool LNDPEKDKNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72BF520", Offset = "0x72BDF20", VA = "0x1872BF520", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PNABIHOFHPB OPIEBGAEOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72BFE60", Offset = "0x72BE860", VA = "0x1872BFE60", Slot = "20")]
		get
		{
			return default(PNABIHOFHPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BMEJJFPDMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72BF570", Offset = "0x72BDF70", VA = "0x1872BF570", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EBFNHDDIGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x72BF5C0", Offset = "0x72BDFC0", VA = "0x1872BF5C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PADLEADMJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72BF950", Offset = "0x72BE350", VA = "0x1872BF950", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JNHCCGFMEFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72C00B0", Offset = "0x72BEAB0", VA = "0x1872C00B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BCPGPBMIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72BF420", Offset = "0x72BDE20", VA = "0x1872BF420", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool IKJDJAEFDIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72BFEB0", Offset = "0x72BE8B0", VA = "0x1872BFEB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool PCPOJHBAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72BF6B0", Offset = "0x72BE0B0", VA = "0x1872BF6B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FEFNINAMCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72BFFF0", Offset = "0x72BE9F0", VA = "0x1872BFFF0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> PHFEJELKMJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72BE360", Offset = "0x72BCD60", VA = "0x1872BE360", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FPIKDIMHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72BF660", Offset = "0x72BE060", VA = "0x1872BF660", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FJLMKMJMOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72BF380", Offset = "0x72BDD80", VA = "0x1872BF380", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool JFDGNNGONBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72BF700", Offset = "0x72BE100", VA = "0x1872BF700", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OHBINCGBGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72BE740", Offset = "0x72BD140", VA = "0x1872BE740", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JNPHJIJECBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72BF3D0", Offset = "0x72BDDD0", VA = "0x1872BF3D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ILKLBBOJBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72BFF00", Offset = "0x72BE900", VA = "0x1872BFF00", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HEFCDNEKJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72C0100", Offset = "0x72BEB00", VA = "0x1872C0100", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CPJBCFEHKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72BFFA0", Offset = "0x72BE9A0", VA = "0x1872BFFA0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LKIOIPJDKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72BF610", Offset = "0x72BE010", VA = "0x1872BF610", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ONKLNGAAGBI<EFLDKEDAJFO> GKCGHGKFICK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x72BF470", Offset = "0x72BDE70", VA = "0x1872BF470", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x72BF850", Offset = "0x72BE250", VA = "0x1872BF850", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2ED5C00", Offset = "0x2ED4600", VA = "0x182ED5C00", Slot = "6")]
	public (bool, T?) JFGCJAMIIJL<T>(EFLDKEDAJFO CPIHEENNHEI) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED5BA0", Offset = "0x2ED45A0", VA = "0x182ED5BA0")]
	public NCJIGBKPBOC FGCMFKEOIEP<T>(EFLDKEDAJFO CPIHEENNHEI, bool NADHNKNFKFF, T IPHMAHBENGI) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72C01F0", Offset = "0x72BEBF0", VA = "0x1872C01F0")]
	public NCJIGBKPBOC(LNBDJMHHJGO KHLJHJHCCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72C01D0", Offset = "0x72BEBD0", VA = "0x1872C01D0")]
	public NCJIGBKPBOC(LNBDJMHHJGO KHLJHJHCCGC, [Optional] string? KBAGCCEAHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72C0360", Offset = "0x72BED60", VA = "0x1872C0360")]
	public NCJIGBKPBOC(NCJIGBKPBOC GACHEKCCOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x72C0210", Offset = "0x72BEC10", VA = "0x1872C0210")]
	internal NCJIGBKPBOC(LNBDJMHHJGO DMLIHHOJBJE, [Optional] string? KBAGCCEAHOK, [Optional] NCJIGBKPBOC? GACHEKCCOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72C0040", Offset = "0x72BEA40", VA = "0x1872C0040")]
	public static FHJLMMDFOMF PADEGJJGBOE(EFLDKEDAJFO CPIHEENNHEI)
	{
		return default(FHJLMMDFOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72BE7E0", Offset = "0x72BD1E0", VA = "0x1872BE7E0")]
	public void ENJDIJGELFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72BE3C0", Offset = "0x72BCDC0", VA = "0x1872BE3C0")]
	internal NCJIGBKPBOC CACBMCEAOCA(NCJIGBKPBOC HNACKPHHDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x72BFA80", Offset = "0x72BE480", VA = "0x1872BFA80")]
	internal IReadOnlyCollection<EFLDKEDAJFO> LGMKCBFJFDH(NCJIGBKPBOC GACHEKCCOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x72BF9A0", Offset = "0x72BE3A0", VA = "0x1872BF9A0")]
	public bool KPMHJCDADGD(EFLDKEDAJFO CPIHEENNHEI, bool NADHNKNFKFF, string PLJFFJLAEEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72BF750", Offset = "0x72BE150", VA = "0x1872BF750")]
	public (bool, string) IPGNOOIEJKG(EFLDKEDAJFO CPIHEENNHEI)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72BFF50", Offset = "0x72BE950", VA = "0x1872BFF50")]
	internal void NNMGMAJDFDD(EFLDKEDAJFO CPIHEENNHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x72BF180", Offset = "0x72BDB80", VA = "0x1872BF180")]
	public NHDCFLFNMCH FMLOCLDICKK(Func<LNBDJMHHJGO, Guid> HNCONIIIKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x72BE800", Offset = "0x72BD200", VA = "0x1872BE800")]
	public void FDDGMLOKDED(NHDCFLFNMCH AGIPCMLIJLE, Func<Guid, LNBDJMHHJGO> FFJNLJMOGOK, [Optional] LNBDJMHHJGO? ALEFDPGEJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x72BE6B0", Offset = "0x72BD0B0", VA = "0x1872BE6B0")]
	[CompilerGenerated]
	private void CIKKAHJPNEC(EFLDKEDAJFO JNHCGHFLEKI, OFMLHMOAGCF LMMEICDNOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MGNMDDIIOEO : OMEIMCMEFGE, HOJFGOFAEOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class MECJPMOLDDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NCJIGBKPBOC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MECJPMOLDDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72B8900", Offset = "0x72B7300", VA = "0x1872B8900")]
		internal bool BMGFNDAGIHL(NCJIGBKPBOC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class MMFFIFAFLBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LNBDJMHHJGO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public MMFFIFAFLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72BE350", Offset = "0x72BCD50", VA = "0x1872BE350")]
		internal bool NCBJOIBIAOI(LNBDJMHHJGO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct JEBKFCLBOAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public MGNMDDIIOEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EGDKLHCLIKL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<HNGOMGHAABH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x72B7260", Offset = "0x72B5C60", VA = "0x1872B7260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x72B78D0", Offset = "0x72B62D0", VA = "0x1872B78D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CFAFCONEHFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CFAFCONEHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x72B39B0", Offset = "0x72B23B0", VA = "0x1872B39B0")]
		internal void OODOBHDNDIA(NHDCFLFNMCH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72B3A90", Offset = "0x72B2490", VA = "0x1872B3A90")]
		internal void PKEPFCCBBNP(NHDCFLFNMCH r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct PMADHEJANGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public EGDKLHCLIKL roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GHMMGFOHJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<NHDCFLFNMCH, OFMLHMOAGCF> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public GHMMGFOHJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x72B4E50", Offset = "0x72B3850", VA = "0x1872B4E50")]
		internal void HPHLDFINDPA(NHDCFLFNMCH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72B4E20", Offset = "0x72B3820", VA = "0x1872B4E20")]
		internal void CBOMPACECLE(NHDCFLFNMCH r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x72B4E80", Offset = "0x72B3880", VA = "0x1872B4E80")]
		internal void IOJNCGKPEBO(NHDCFLFNMCH r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class BEHKAGKLCMM<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public BEHKAGKLCMM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<HNGOMGHAABH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x374DFE0", Offset = "0x374C9E0", VA = "0x18374DFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8D8CD0", Offset = "0x8D76D0", VA = "0x1808D8CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EFLDKEDAJFO rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public LNBDJMHHJGO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public FHJLMMDFOMF recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public MGNMDDIIOEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BEHKAGKLCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x50AB530", Offset = "0x50A9F30", VA = "0x1850AB530")]
		[AsyncStateMachine(typeof(BEHKAGKLCMM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GBNMELLEIBC()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BMGNJFJHKBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<MPPEFPHOJAI> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct INLLPGJFDBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public KEONHKCHPKM rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public EGDKLHCLIKL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<LNBDJMHHJGO, NCJIGBKPBOC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HIMJLHGHAJA debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x72B66E0", Offset = "0x72B50E0", VA = "0x1872B66E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x72B7200", Offset = "0x72B5C00", VA = "0x1872B7200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KEONHKCHPKM KILFGPOHMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NMILLFFBENJ BELGMAAPHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HIMJLHGHAJA DONCNEAGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, NCJIGBKPBOC> IOKJCNNKKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<LNBDJMHHJGO, NCJIGBKPBOC> GCIANOPBEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<LNBDJMHHJGO, NCJIGBKPBOC> BKOOKFHBFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<NCJIGBKPBOC> PPPOJOIOLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool EGALHPBOHIL;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly EFLDKEDAJFO[] MNHGKAGEIBH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public AFEGPFDBCKI HDCJONFMEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<KIPDPEFFADO> DFLHHCDAKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72BBBC0", Offset = "0x72BA5C0", VA = "0x1872BBBC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BBOBHEIKBJD DBHIMIMMIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x72BA540", Offset = "0x72B8F40", VA = "0x1872BA540", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x72BD330", Offset = "0x72BBD30", VA = "0x1872BD330", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x72BC530", Offset = "0x72BAF30", VA = "0x1872BC530")]
	[MDINNNLEANF.KOGFDGIBLGF]
	internal static void NBLEEGPPBCG(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x72BE090", Offset = "0x72BCA90", VA = "0x1872BE090")]
	[UnityEngine.Scripting.Preserve]
	internal MGNMDDIIOEO([LKKACOOMNBP(null)] KEONHKCHPKM PMLDGMKCDDG, [LKKACOOMNBP(null)] NMILLFFBENJ AHIBABJGJBH, [LKKACOOMNBP(null)] HIMJLHGHAJA DONCNEAGOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x72BA130", Offset = "0x72B8B30", VA = "0x1872BA130", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x72BD4C0", Offset = "0x72BBEC0", VA = "0x1872BD4C0")]
	private void OLMOIBCBCDF(IEnumerable<NCJIGBKPBOC> KLLONMGFNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72BA470", Offset = "0x72B8E70", VA = "0x1872BA470", Slot = "12")]
	public bool FGMCCOBOIDE(ICGGIJDMFMC DBKPGAEGHAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72BB340", Offset = "0x72B9D40", VA = "0x1872BB340")]
	private void HLCENPBALBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72B9990", Offset = "0x72B8390", VA = "0x1872B9990")]
	private void CFLHEAOHNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72BD440", Offset = "0x72BBE40", VA = "0x1872BD440", Slot = "10")]
	public IReadOnlyList<KIPDPEFFADO> OJHGOLEALKD(bool KGBPOIMKBGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72BB350", Offset = "0x72B9D50", VA = "0x1872BB350", Slot = "11")]
	public KIPDPEFFADO HNJOJGOHBDH(ICGGIJDMFMC DBKPGAEGHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72BB8E0", Offset = "0x72BA2E0", VA = "0x1872BB8E0")]
	private LNBDJMHHJGO JNIPBHJJKNG(ICGGIJDMFMC DBKPGAEGHAD)
	{
		return default(LNBDJMHHJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72BDD30", Offset = "0x72BC730", VA = "0x1872BDD30", Slot = "14")]
	public bool PJHNNNNHNAF(ICGGIJDMFMC GDOIPGMMJEL, LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72BA3D0", Offset = "0x72B8DD0", VA = "0x1872BA3D0", Slot = "15")]
	public KIPDPEFFADO FGAHKPLMIPC(LNBDJMHHJGO KHLJHJHCCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72BBC10", Offset = "0x72BA610", VA = "0x1872BBC10")]
	private static bool LIFMANGEEJP(KAPCNJDLFKE HPFKMEPJIBP, LNBDJMHHJGO KHLJHJHCCGC, [Out] NHDCFLFNMCH? GAIJEEGNKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72B9E10", Offset = "0x72B8810", VA = "0x1872B9E10")]
	private static void CPOMLNEHINK(KAPCNJDLFKE HPFKMEPJIBP, Action<NHDCFLFNMCH> BNJBLHAHCEI, LNBDJMHHJGO ILENMEDPBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72B9B80", Offset = "0x72B8580", VA = "0x1872B9B80")]
	private static void CPOMLNEHINK(KAPCNJDLFKE HPFKMEPJIBP, Action<NHDCFLFNMCH> BNJBLHAHCEI, Predicate<LNBDJMHHJGO> ANOGGJGNIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72BD3D0", Offset = "0x72BBDD0", VA = "0x1872BD3D0")]
	private void OBLDOIEHDDO(ICGGIJDMFMC DBKPGAEGHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72BB480", Offset = "0x72B9E80", VA = "0x1872BB480", Slot = "4")]
	[AsyncStateMachine(typeof(JEBKFCLBOAJ))]
	public Task INFEGEFGDDK([CanBeNull] EGDKLHCLIKL HCKNFILJEND, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
	public void HHMCMCDFBKF(EGDKLHCLIKL HCKNFILJEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72B8930", Offset = "0x72B7330", VA = "0x1872B8930")]
	private void AJAFPEKHDDJ(KAPCNJDLFKE LGEOPLANCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72BC220", Offset = "0x72BAC20", VA = "0x1872BC220")]
	internal static string MNKBDIFBBLI(KEONHKCHPKM KILFGPOHMAC, EGDKLHCLIKL HCKNFILJEND, IReadOnlyDictionary<LNBDJMHHJGO, NCJIGBKPBOC> GCIANOPBEEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72BA5E0", Offset = "0x72B8FE0", VA = "0x1872BA5E0")]
	private static void HKLEAAIGMLO(EGDKLHCLIKL HCKNFILJEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72B8F10", Offset = "0x72B7910", VA = "0x1872B8F10")]
	private static void AOAMENHOEPA(KAPCNJDLFKE PMADIMILKIO, IReadOnlyDictionary<LNBDJMHHJGO, NCJIGBKPBOC> GCIANOPBEEN, StringBuilder OHICALLNLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72BA240", Offset = "0x72B8C40", VA = "0x1872BA240")]
	private static bool EAHDNNNFDPD(string EEDJFCAONIB, [Out] Guid COLAFFLHJNO, [Out] LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72B9260", Offset = "0x72B7C60", VA = "0x1872B9260")]
	private static void BCOLBALCEND(EGDKLHCLIKL HCKNFILJEND, StringBuilder OHICALLNLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E72630", Offset = "0x2E71030", VA = "0x182E72630", Slot = "16")]
	public bool EKGCEHCHMPD<T>(LNBDJMHHJGO KHLJHJHCCGC, EFLDKEDAJFO CPIHEENNHEI, bool NADHNKNFKFF, T OKHFPGFAECB, [Optional] Action IKMNKNJKIOA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72BA360", Offset = "0x72B8D60", VA = "0x1872BA360", Slot = "17")]
	public string EKFEKLKIPND(EFLDKEDAJFO CPIHEENNHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72BB9B0", Offset = "0x72BA3B0", VA = "0x1872BB9B0")]
	private void LBNFFFNMDPC(LNBDJMHHJGO KHLJHJHCCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72BB460", Offset = "0x72B9E60", VA = "0x1872BB460")]
	private bool IABNCKEGIOE(ICGGIJDMFMC DBKPGAEGHAD, LNBDJMHHJGO KHLJHJHCCGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x72BB5A0", Offset = "0x72B9FA0", VA = "0x1872BB5A0")]
	internal NCJIGBKPBOC JFMFJOHNJCJ(ICGGIJDMFMC DBKPGAEGHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x72BA350", Offset = "0x72B8D50", VA = "0x1872BA350", Slot = "13")]
	public IReadOnlyList<KIPDPEFFADO> EJIFLIPMGBH(ICGGIJDMFMC DBKPGAEGHAD, bool JGHAIGPMPMN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x72B9F00", Offset = "0x72B8900", VA = "0x1872B9F00")]
	internal IReadOnlyList<NCJIGBKPBOC> DKLGBLOKPCA(ICGGIJDMFMC DBKPGAEGHAD, bool JGHAIGPMPMN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x72BCA60", Offset = "0x72BB460", VA = "0x1872BCA60")]
	private void NEBDIIDKLMB(HNGOMGHAABH BKMLNGBGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x72BBF40", Offset = "0x72BA940", VA = "0x1872BBF40")]
	private static bool LPKNPDPKDBB(NCJIGBKPBOC CFFCOAGKHDI, IReadOnlyDictionary<LNBDJMHHJGO, NCJIGBKPBOC> GCIANOPBEEN, [Out] IReadOnlyList<EFLDKEDAJFO> MPHHMECIMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x72BD1F0", Offset = "0x72BBBF0", VA = "0x1872BD1F0")]
	[AsyncStateMachine(typeof(INLLPGJFDBM))]
	private static Task NGPGMBHMGIN(KEONHKCHPKM KILFGPOHMAC, EGDKLHCLIKL HCKNFILJEND, IReadOnlyDictionary<LNBDJMHHJGO, NCJIGBKPBOC> GCIANOPBEEN, HIMJLHGHAJA DONCNEAGOEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x72B8C70", Offset = "0x72B7670", VA = "0x1872B8C70")]
	[CompilerGenerated]
	internal static void ALLOMLCCDAC(Func<NHDCFLFNMCH, OFMLHMOAGCF> IFOODIDBONK, PMADHEJANGC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x72BC6F0", Offset = "0x72BB0F0", VA = "0x1872BC6F0")]
	[CompilerGenerated]
	internal static bool NCGGLEGFIPL(LNBDJMHHJGO KHLJHJHCCGC, EFLDKEDAJFO CPIHEENNHEI, [Out] MPPEFPHOJAI DJIHJNHDIIK, BMGNJFJHKBC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DFLJANBOODH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIEBHHFLNCA(ICGGIJDMFMC BCLJGNBEHOA, ICGGIJDMFMC GIFMNHNPHCD, IEnumerable<ICGGIJDMFMC> KFHOMOIBNDK, [Out] PNABIHOFHPB HMBMPGMNDEG, [Out] MNAFFGEDBPE JAMELPMEFJF);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LJHHMPNLIAH(MNAFFGEDBPE ALIGAHCGAMP);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum MNAFFGEDBPE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class KOIIJAONBEM : DFLJANBOODH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly HOJFGOFAEOM NDOEDDCCINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IDCKMHHMMIA LBJFEGLEKEC;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x887590", Offset = "0x885F90", VA = "0x180887590")]
	[RecRoom.NoEngine.Common.Preserve]
	public KOIIJAONBEM([LKKACOOMNBP(null)] HOJFGOFAEOM NCGCGFBAOML, [LKKACOOMNBP(null)] IDCKMHHMMIA GBKBGNCMHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72B8210", Offset = "0x72B6C10", VA = "0x1872B8210")]
	private static LCGJOFALIMM? IMLIEHAFNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72B8350", Offset = "0x72B6D50", VA = "0x1872B8350", Slot = "4")]
	public bool OIEBHHFLNCA(ICGGIJDMFMC BCLJGNBEHOA, ICGGIJDMFMC GIFMNHNPHCD, IEnumerable<ICGGIJDMFMC> KFHOMOIBNDK, [Out] PNABIHOFHPB HMBMPGMNDEG, [Out] MNAFFGEDBPE JAMELPMEFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72B8250", Offset = "0x72B6C50", VA = "0x1872B8250", Slot = "5")]
	public string LJHHMPNLIAH(MNAFFGEDBPE ALIGAHCGAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72B7C00", Offset = "0x72B6600", VA = "0x1872B7C00")]
	internal bool EBKLCLABLFE(ICGGIJDMFMC BCLJGNBEHOA, ICGGIJDMFMC GIFMNHNPHCD, IEnumerable<ICGGIJDMFMC> KFHOMOIBNDK, NBOIDPFPFBM AHDMLEHPFLJ, LCGJOFALIMM? MNPJGCOMHEP, [Out] PNABIHOFHPB HMBMPGMNDEG, [Out] MNAFFGEDBPE JAMELPMEFJF)
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
