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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E1ACE0", Offset = "0x7E19EE0", VA = "0x187E1ACE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DIKLJODDHIL
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B4C0", Offset = "0x7E1A6C0", VA = "0x187E1B4C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void AJMLMLOIJLO<TPermission>(TPermission NCDCGGJIOLL);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void OFBMMIIAMFI(GJGNFGDHFCI NCAFEKBCKBL);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ADNNPBHEOKO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OLNPEKMDBPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BPEKCJLGKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ODMJANDJHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FEINIEJIIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LPCEPIJPFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BOIEFFOAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LKOLLDEJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HBAPIEELFMP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum JIEDIMKHMCA
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
	public static readonly Guid FIPMIKDJNCL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NGOJBBNNKJG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid IHINNODAKEA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid GDAIHMNKLGN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid CNKFPLAHNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid EMDPAABKEGL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BBIILLILECM<MMOLBELIPAC, Guid> KGKFIOMNFCL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MMOLBELIPAC> BFLHPPHLLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E14A50", Offset = "0x7E13C50", VA = "0x187E14A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E14830", Offset = "0x7E13A30", VA = "0x187E14830")]
	public static MMOLBELIPAC HEHPMKGIDEE(Guid FGPNICIMMFP)
	{
		return default(MMOLBELIPAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E146C0", Offset = "0x7E138C0", VA = "0x187E146C0")]
	public static Guid BNOBIBKBMAH(MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E147A0", Offset = "0x7E139A0", VA = "0x187E147A0")]
	public static bool GJNICMDLAJA(MMOLBELIPAC LNFIMHGHDGN, [Out] Guid FGPNICIMMFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E149B0", Offset = "0x7E13BB0", VA = "0x187E149B0")]
	public static bool JNNJLLCAKGN(Guid FGPNICIMMFP, [Out] MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E14760", Offset = "0x7E13960", VA = "0x187E14760")]
	public static MMOLBELIPAC FDBJINIJKHG(MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(MMOLBELIPAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E148C0", Offset = "0x7E13AC0", VA = "0x187E148C0")]
	public static JIEDIMKHMCA IMHOLJOMIEH(MMOLBELIPAC LOOPIABCGPE)
	{
		return default(JIEDIMKHMCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E14970", Offset = "0x7E13B70", VA = "0x187E14970")]
	internal static MMOLBELIPAC JCBIGKCGPGK(JIEDIMKHMCA CJECNBMANOJ)
	{
		return default(MMOLBELIPAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KAJLCNPGDDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GKCHIHEIFOA ANJDPFAPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<JJANENCKJMM> MOJGMNPMIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OFBMMIIAMFI DNIPOCDPJOO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<JJANENCKJMM> HJAFILGEINK(bool IKOPONEJMMA = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJANENCKJMM IMAFKHMPJPG(GJGNFGDHFCI NCAFEKBCKBL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EIFPBBLNEAJ(GJGNFGDHFCI NCAFEKBCKBL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<JJANENCKJMM> PPCBKEDMFIN(GJGNFGDHFCI NCAFEKBCKBL, bool HOBMDGDCEFP = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CPOFLBHLOJB(GJGNFGDHFCI FFHFGGBFNHM, MMOLBELIPAC LNFIMHGHDGN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JJANENCKJMM GPHBBIKIANA(MMOLBELIPAC LNFIMHGHDGN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EJLBBBEILBP<T>(MMOLBELIPAC LNFIMHGHDGN, GKEDFAIHPDG NCDCGGJIOLL, bool IPFHLECCEII, T DLGGINKGFFM, [Optional] Action HIDOPKFLLBG) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string HJHMNBPKIGE(GKEDFAIHPDG NCDCGGJIOLL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NMGOPMJDOLO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LLNBLIEOPGJ(HKFACLJBOKN JEICPGHJIDH, CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFIMJIAJPIG(HKFACLJBOKN JEICPGHJIDH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IONGMJGDDPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GJGNFGDHFCI HGFGBJPFNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DCEEACKECED OAFPDKKGMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AELLMCLLHFN NMEBGLMKIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BCJEFLAOEBL> GFIEPAKEBAJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ALLENHMIAAJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMOLBELIPAC FCOFBPLDLOB(GJGNFGDHFCI NCAFEKBCKBL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BCJEFLAOEBL> FFNIBEGILON(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CIMBPMMAFOC(long KCAAOMDKNIH, IReadOnlyList<OBCJCPKHCCK> FCDNIJLBCCH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task EBGCAOHIKPP(long KCAAOMDKNIH, long NFFPLNPCCNI, IReadOnlyList<OBCJCPKHCCK> FCDNIJLBCCH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GJGNFGDHFCI> GBAEFAKJIPN();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AEPEOCHPKGG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E0CE90", Offset = "0x7E0C090", VA = "0x187E0CE90")]
	public static MMOLBELIPAC JIMNFCLDHGJ(this IONGMJGDDPL HEOAEEEHBIN)
	{
		return default(MMOLBELIPAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FOIAKBBJMBP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string PGBEAAIPPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AJMLMLOIJLO<TPermission> CJNOICGGEBF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class HDNMFIBKHAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? ONDNDBOOAGE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? KFAHHFHCLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E15480", Offset = "0x7E14680", VA = "0x187E15480")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E15560", Offset = "0x7E14760", VA = "0x187E15560")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E15660", Offset = "0x7E14860", VA = "0x187E15660")]
	protected HDNMFIBKHAN(object? HKHEABBLLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KOOFDNPAJKG(object? OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LALCKKJMNCK<T> : HDNMFIBKHAN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> DIHIGKEAOAK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4B256F0", Offset = "0x4B248F0", VA = "0x184B256F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4B25BE0", Offset = "0x4B24DE0", VA = "0x184B25BE0", Slot = "4")]
	public override bool KOOFDNPAJKG(object? OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4B25F40", Offset = "0x4B25140", VA = "0x184B25F40")]
	public bool MCFLNKFLAGL(T IAJGACLPFPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4B262A0", Offset = "0x4B254A0", VA = "0x184B262A0")]
	public LALCKKJMNCK(T OGPHJJMKHNA, IEqualityComparer<T> DIHIGKEAOAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class EIDJBOHIGKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<GKEDFAIHPDG, bool> CANIHOLIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<GKEDFAIHPDG, HDNMFIBKHAN> DJNAPPPAICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IJLAFNEMMAH DHAECKOEMGO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E13BC0", Offset = "0x7E12DC0", VA = "0x187E13BC0")]
	public EIDJBOHIGKP(IJLAFNEMMAH DHAECKOEMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E139A0", Offset = "0x7E12BA0", VA = "0x187E139A0")]
	public bool IGPIPFGMOCN(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x32EC550", Offset = "0x32EB750", VA = "0x1832EC550")]
	public bool PPKAFAFFABD<T>(GKEDFAIHPDG NCDCGGJIOLL, bool IPFHLECCEII, T OMFJNFBDJCA) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x32EC050", Offset = "0x32EB250", VA = "0x1832EC050")]
	public (bool, T?) HDDHNBFEDLA<T>(GKEDFAIHPDG NCDCGGJIOLL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E13AE0", Offset = "0x7E12CE0", VA = "0x187E13AE0")]
	public bool PPKAFAFFABD(GKEDFAIHPDG NCDCGGJIOLL, bool IPFHLECCEII, object OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E13800", Offset = "0x7E12A00", VA = "0x187E13800")]
	public (bool, object) HDDHNBFEDLA(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32EC4F0", Offset = "0x32EB6F0", VA = "0x1832EC4F0")]
	private void OPJOCMAOBPC<T>(GKEDFAIHPDG NCDCGGJIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E13A10", Offset = "0x7E12C10", VA = "0x187E13A10")]
	private HDNMFIBKHAN OFCHKBLEBCM(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E13610", Offset = "0x7E12810", VA = "0x187E13610")]
	public void DEJFOJIKGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CIFNPBPNMHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HEIDAHJIDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type DMGHIAMFDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly APNDJDAFHIC FOMNJKOKIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GKEDFAIHPDG APCJCCDPFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LNCJJACEOJM HFDPGODJEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BOOKLLJOCNF CEMFFBDJGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FBLCDBFHCGA ELEDPPLNHEE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E12F40", Offset = "0x7E12140", VA = "0x187E12F40")]
	public CIFNPBPNMHE(Type JDPMMEKAGIK, string CAOLAKPGBJI, GKEDFAIHPDG NCDCGGJIOLL, LNCJJACEOJM GMIMILIBNJL, BOOKLLJOCNF FFKHNHLPNFB, FBLCDBFHCGA PBDELIANOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E12E40", Offset = "0x7E12040", VA = "0x187E12E40")]
	public object FPJKICHDMKI(object? LDKNLBHIGFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3287620", Offset = "0x3286820", VA = "0x183287620")]
	public void OPJOCMAOBPC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E12E90", Offset = "0x7E12090", VA = "0x187E12E90")]
	public void OPJOCMAOBPC(Type IKKKLDGOOIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class EEOAOELAGAN<T> : CIFNPBPNMHE where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string AMMLCEDCIMD(T OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T BOPEJOHBHFM(string? EEMOPODOCFO, T OGPHJJMKHNA);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LCKDDCFNKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AMMLCEDCIMD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BOPEJOHBHFM parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LCKDDCFNKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4B2FD10", Offset = "0x4B2EF10", VA = "0x184B2FD10")]
		internal string GGGHCEFPACF(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4B2FB10", Offset = "0x4B2ED10", VA = "0x184B2FB10")]
		internal object APDJFGMMCML(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x40E1AD0", Offset = "0x40E0CD0", VA = "0x1840E1AD0")]
	public EEOAOELAGAN(GKEDFAIHPDG NCDCGGJIOLL, string CAOLAKPGBJI, [Optional] AMMLCEDCIMD? GMIMILIBNJL, [Optional] BOPEJOHBHFM? FFKHNHLPNFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x40E09A0", Offset = "0x40DFBA0", VA = "0x1840E09A0")]
	private static object? ANADGBKPLNB(BOPEJOHBHFM? FFKHNHLPNFB, string? EEMOPODOCFO, object? OGPHJJMKHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x40E1810", Offset = "0x40E0A10", VA = "0x1840E1810")]
	private static string JEAAONFOJJH(AMMLCEDCIMD? ALDOACNEBLD, object? OMFJNFBDJCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string LNCJJACEOJM(object? OMFJNFBDJCA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object BOOKLLJOCNF(string? EEMOPODOCFO, [Optional] object OGPHJJMKHNA);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate HDNMFIBKHAN FBLCDBFHCGA();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class IJLAFNEMMAH
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DGLFGBGFDDM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static DGLFGBGFDDM JLGHKLNHGNO;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7E12FE0", Offset = "0x7E121E0", VA = "0x187E12FE0", Slot = "4")]
		public bool Equals(List<string> NNDJDIFFAID, List<string> AMFIBFNKFFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7E13130", Offset = "0x7E12330", VA = "0x187E13130", Slot = "5")]
		public int GetHashCode(List<string> ONELFPFEALD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DGLFGBGFDDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class AKEDMBCEHAH : CBPOMKGGABL<DIKLJODDHIL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CEF0", Offset = "0x7E0C0F0", VA = "0x187E0CEF0", Slot = "9")]
		public override string JEAAONFOJJH(DIKLJODDHIL GEDAGNGPIPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CFE0", Offset = "0x7E0C1E0", VA = "0x187E0CFE0", Slot = "10")]
		protected override bool OANCGIEAPIM(string GEDAGNGPIPL, [Out] DIKLJODDHIL OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E0D1C0", Offset = "0x7E0C3C0", VA = "0x187E0D1C0")]
		public AKEDMBCEHAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly FAEABLFNIHA FNBFKDAECIB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly AKEDMBCEHAH LLJKGEEIEJL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CIFNPBPNMHE> CLLJJHKHPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<GKEDFAIHPDG> AENKCMPPALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<GKEDFAIHPDG, CIFNPBPNMHE> CKIGNAMLBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E16D70", Offset = "0x7E15F70", VA = "0x187E16D70")]
	public IJLAFNEMMAH([Optional] IList<CIFNPBPNMHE>? HJLKGOOLCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E15800", Offset = "0x7E14A00", VA = "0x187E15800")]
	public CIFNPBPNMHE CANAJPDFDJB(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GKCHIHEIFOA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JJANENCKJMM BINLHLDHCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MKCEFFFFGDK : GKCHIHEIFOA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static MKCEFFFFGDK BOPJCPALIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly IMGHPIHJECN KBFCBKJIGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<IMGHPIHJECN> AMMOPBMBMNP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JJANENCKJMM BINLHLDHCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E1ABD0", Offset = "0x7E19DD0", VA = "0x187E1ABD0")]
	public MKCEFFFFGDK(IMGHPIHJECN KBKGALGMMCF, IReadOnlyList<IMGHPIHJECN> PGNODIKIPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E19CC0", Offset = "0x7E18EC0", VA = "0x187E19CC0")]
	private static MKCEFFFFGDK HAGIEJHMJHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DIELIMLECFI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<MMOLBELIPAC> GGCONAFOFFA;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E13310", Offset = "0x7E12510", VA = "0x187E13310")]
	public static bool KIPEJNMKGDL(this GJGNFGDHFCI CIGHHJOJKIO, MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E133F0", Offset = "0x7E125F0", VA = "0x187E133F0")]
	public static bool PEGJLLLKNCD(this GJGNFGDHFCI CIGHHJOJKIO, MMOLBELIPAC LNFIMHGHDGN, AELLMCLLHFN OIGFHLOIIFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LLAKOHBPMGC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PEHNIDKLHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LCLGMPEHBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LHOGANEJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DEEIOKCLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LCECHJDAACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HGACHAIPPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JGFEAHBPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LLGHOHHKFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool AAGEIGGBMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool AJPECHDJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NMEILOJEIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CMHPEHOPFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> PAMKONEPNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DIKLJODDHIL IMMFEIGEMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JJANENCKJMM : LLAKOHBPMGC, OLNPEKMDBPK, FOIAKBBJMBP<GKEDFAIHPDG>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string JJDDHLFMNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MMOLBELIPAC BAGKFBJNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HDDBCNEGNBB<T>(GKEDFAIHPDG NCDCGGJIOLL) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum GKEDFAIHPDG
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
	CAN_ADD_ROOM_BANS = 1018,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class IMGHPIHJECN : JJANENCKJMM, LLAKOHBPMGC, OLNPEKMDBPK, FOIAKBBJMBP<GKEDFAIHPDG>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly IJLAFNEMMAH AIAFLCNNEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly EIDJBOHIGKP JFNEBLIIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? NNNMICIHNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? OENDFGNNANO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool JFGAOOHPHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E175D0", Offset = "0x7E167D0", VA = "0x187E175D0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool NGKGHOBMACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E17710", Offset = "0x7E16910", VA = "0x187E17710", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NMBHFCGOJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7E17C80", Offset = "0x7E16E80", VA = "0x187E17C80", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool CACIJOPLCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7E17240", Offset = "0x7E16440", VA = "0x187E17240", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FFMGKDNEBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7E17D20", Offset = "0x7E16F20", VA = "0x187E17D20", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool PJFGENABPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7E177B0", Offset = "0x7E169B0", VA = "0x187E177B0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MMOLBELIPAC BAGKFBJNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC04650", Offset = "0xC03850", VA = "0x180C04650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MMOLBELIPAC);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x964790", Offset = "0x963990", VA = "0x180964790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string PGBEAAIPPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E18110", Offset = "0x7E17310", VA = "0x187E18110", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E17670", Offset = "0x7E16870", VA = "0x187E17670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string JJDDHLFMNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E18110", Offset = "0x7E17310", VA = "0x187E18110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CCAOMIIEKCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC6B200", Offset = "0xC6A400", VA = "0x180C6B200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xC6B220", Offset = "0xC6A420", VA = "0x180C6B220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PEHNIDKLHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E180C0", Offset = "0x7E172C0", VA = "0x187E180C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DIKLJODDHIL IMMFEIGEMLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E17DC0", Offset = "0x7E16FC0", VA = "0x187E17DC0", Slot = "20")]
		get
		{
			return default(DIKLJODDHIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LCLGMPEHBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E17CD0", Offset = "0x7E16ED0", VA = "0x187E17CD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LHOGANEJOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E17800", Offset = "0x7E16A00", VA = "0x187E17800", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DEEIOKCLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E17850", Offset = "0x7E16A50", VA = "0x187E17850", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LCECHJDAACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E17D70", Offset = "0x7E16F70", VA = "0x187E17D70", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HGACHAIPPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E18210", Offset = "0x7E17410", VA = "0x187E18210", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JGFEAHBPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E17E10", Offset = "0x7E17010", VA = "0x187E17E10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LLGHOHHKFJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E17760", Offset = "0x7E16960", VA = "0x187E17760", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AAGEIGGBMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E17620", Offset = "0x7E16820", VA = "0x187E17620", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> PAMKONEPNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E17E60", Offset = "0x7E17060", VA = "0x187E17E60", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DNKMMILNFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E175D0", Offset = "0x7E167D0", VA = "0x187E175D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OGKJIFEHMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E17D20", Offset = "0x7E16F20", VA = "0x187E17D20", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GFJHGMHAEML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E17710", Offset = "0x7E16910", VA = "0x187E17710", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AJPECHDJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E171D0", Offset = "0x7E163D0", VA = "0x187E171D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NMEILOJEIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E18DC0", Offset = "0x7E17FC0", VA = "0x187E18DC0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool HBBBBFJKNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E17C80", Offset = "0x7E16E80", VA = "0x187E17C80", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool CMHPEHOPFIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E176C0", Offset = "0x7E168C0", VA = "0x187E176C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JOJBGCAGFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E17240", Offset = "0x7E16440", VA = "0x187E17240", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PDOKHNOGENK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E177B0", Offset = "0x7E169B0", VA = "0x187E177B0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AJMLMLOIJLO<GKEDFAIHPDG> CJNOICGGEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7E17120", Offset = "0x7E16320", VA = "0x187E17120", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7E18160", Offset = "0x7E17360", VA = "0x187E18160", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x34DB2E0", Offset = "0x34DA4E0", VA = "0x1834DB2E0", Slot = "6")]
	public (bool, T?) HDDBCNEGNBB<T>(GKEDFAIHPDG NCDCGGJIOLL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34DB280", Offset = "0x34DA480", VA = "0x1834DB280")]
	public IMGHPIHJECN FLMGCFHGBGM<T>(GKEDFAIHPDG NCDCGGJIOLL, bool IPFHLECCEII, T OMFJNFBDJCA) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E18FA0", Offset = "0x7E181A0", VA = "0x187E18FA0")]
	public IMGHPIHJECN(MMOLBELIPAC LNFIMHGHDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E18F80", Offset = "0x7E18180", VA = "0x187E18F80")]
	public IMGHPIHJECN(MMOLBELIPAC LNFIMHGHDGN, [Optional] string? NNNMICIHNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E18F00", Offset = "0x7E18100", VA = "0x187E18F00")]
	public IMGHPIHJECN(IMGHPIHJECN MNKFDJHHFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E18FC0", Offset = "0x7E181C0", VA = "0x187E18FC0")]
	internal IMGHPIHJECN(MMOLBELIPAC FIDPMJPLGJI, [Optional] string? NNNMICIHNCD, [Optional] IMGHPIHJECN? MNKFDJHHFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E18E10", Offset = "0x7E18010", VA = "0x187E18E10")]
	public static APNDJDAFHIC PKFFPBEILOD(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return default(APNDJDAFHIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E17220", Offset = "0x7E16420", VA = "0x187E17220")]
	public void DEJFOJIKGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E172E0", Offset = "0x7E164E0", VA = "0x187E172E0")]
	internal IMGHPIHJECN DLLFODJBFPA(IMGHPIHJECN NKNJNGIILMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E178A0", Offset = "0x7E16AA0", VA = "0x187E178A0")]
	internal IReadOnlyCollection<GKEDFAIHPDG> ILGAGJANMHO(IMGHPIHJECN MNKFDJHHFHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7E18BE0", Offset = "0x7E17DE0", VA = "0x187E18BE0")]
	public bool NMHLHCBIHPE(GKEDFAIHPDG NCDCGGJIOLL, bool IPFHLECCEII, string LAIHFMNHAAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E18CC0", Offset = "0x7E17EC0", VA = "0x187E18CC0")]
	public (bool, string) OLFCMLNHGEE(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E17290", Offset = "0x7E16490", VA = "0x187E17290")]
	internal void DJANFEGIGEG(GKEDFAIHPDG NCDCGGJIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E17EC0", Offset = "0x7E170C0", VA = "0x187E17EC0")]
	public CNBFEOFDELO LMIOJEAELCO(Func<MMOLBELIPAC, Guid> IGCOHFGPEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E18260", Offset = "0x7E17460", VA = "0x187E18260")]
	public void MOPKHPIOPNF(CNBFEOFDELO ADJCNLJAMDN, Func<Guid, MMOLBELIPAC> MAHCKCJPJJO, [Optional] MMOLBELIPAC? FOFBJNPNHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E17090", Offset = "0x7E16290", VA = "0x187E17090")]
	[CompilerGenerated]
	private void ANMKEHDAFLA(GKEDFAIHPDG FFPMCBLOOLB, PIAHCMKMHFK GNNKLPPCJNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BIGFFFNLJLE : NMGOPMJDOLO, KAJLCNPGDDA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LNMEFDGCCOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IMGHPIHJECN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LNMEFDGCCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E19C90", Offset = "0x7E18E90", VA = "0x187E19C90")]
		internal bool GHBPNCPDAAP(IMGHPIHJECN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class IGDNGNKABBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public MMOLBELIPAC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IGDNGNKABBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1A061F0", Offset = "0x1A053F0", VA = "0x181A061F0")]
		internal bool DFGKHIGABNC(MMOLBELIPAC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct HDAEDOAKFLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public BIGFFFNLJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HKFACLJBOKN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<BCJEFLAOEBL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7E14DB0", Offset = "0x7E13FB0", VA = "0x187E14DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7E15420", Offset = "0x7E14620", VA = "0x187E15420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BJGCBDJIDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BJGCBDJIDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E12D60", Offset = "0x7E11F60", VA = "0x187E12D60")]
		internal void EPOBJBAMOJG(CNBFEOFDELO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7E12C40", Offset = "0x7E11E40", VA = "0x187E12C40")]
		internal void BCNIMECFEKD(CNBFEOFDELO r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CBLMEGMEPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public HKFACLJBOKN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HHKJFKKOBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<CNBFEOFDELO, PIAHCMKMHFK> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HHKJFKKOBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E15770", Offset = "0x7E14970", VA = "0x187E15770")]
		internal void JLHAMJMBPLJ(CNBFEOFDELO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7E157D0", Offset = "0x7E149D0", VA = "0x187E157D0")]
		internal void OFAKENHCMLE(CNBFEOFDELO r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7E157A0", Offset = "0x7E149A0", VA = "0x187E157A0")]
		internal void KNEALLMNPAI(CNBFEOFDELO r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FCCJBIPJDCD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
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
			public FCCJBIPJDCD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<BCJEFLAOEBL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3D6DD00", Offset = "0x3D6CF00", VA = "0x183D6DD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GKEDFAIHPDG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MMOLBELIPAC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public APNDJDAFHIC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public BIGFFFNLJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FCCJBIPJDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x44B0CF0", Offset = "0x44AFEF0", VA = "0x1844B0CF0")]
		[AsyncStateMachine(typeof(FCCJBIPJDCD<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void LJKNEIKKBDE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JBNHJMIAHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<OBCJCPKHCCK> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct JKHJNEPIKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public IONGMJGDDPL rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HKFACLJBOKN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<MMOLBELIPAC, IMGHPIHJECN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public IDECIICAEAC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7E19110", Offset = "0x7E18310", VA = "0x187E19110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E19C30", Offset = "0x7E18E30", VA = "0x187E19C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly IONGMJGDDPL HEOAEEEHBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly MKCEFFFFGDK MMIKOHJKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IDECIICAEAC GMEPCNOKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, IMGHPIHJECN> ADELECJKKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<MMOLBELIPAC, IMGHPIHJECN> JCBPKFMBEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<MMOLBELIPAC, IMGHPIHJECN> HPKPHOLABPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<IMGHPIHJECN> NODHJIAMMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool POLJCBKNKON;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly GKEDFAIHPDG[] JJGABMMDEDN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GKCHIHEIFOA ANJDPFAPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<JJANENCKJMM> MOJGMNPMIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E10F90", Offset = "0x7E10190", VA = "0x187E10F90", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event OFBMMIIAMFI DNIPOCDPJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7E0F5E0", Offset = "0x7E0E7E0", VA = "0x187E0F5E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E0DB40", Offset = "0x7E0CD40", VA = "0x187E0DB40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F420", Offset = "0x7E0E620", VA = "0x187E0F420")]
	[LDKBBAENJDF.LNCMKHHEGFN]
	internal static void JHIKJAALCJE(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E12980", Offset = "0x7E11B80", VA = "0x187E12980")]
	[UnityEngine.Scripting.Preserve]
	internal BIGFFFNLJLE([KMMHIEIDBEA(null)] IONGMJGDDPL NHBOGNMNFGO, [KMMHIEIDBEA(null)] MKCEFFFFGDK LIAEDMMHEHE, [KMMHIEIDBEA(null)] IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E520", Offset = "0x7E0D720", VA = "0x187E0E520", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E11A10", Offset = "0x7E10C10", VA = "0x187E11A10")]
	private void OCFCONKLIMK(IEnumerable<IMGHPIHJECN> AHFNPLKPAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E630", Offset = "0x7E0D830", VA = "0x187E0E630", Slot = "12")]
	public bool EIFPBBLNEAJ(GJGNFGDHFCI NCAFEKBCKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D7E0", Offset = "0x7E0C9E0", VA = "0x187E0D7E0")]
	private void ALLENHMIAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E12280", Offset = "0x7E11480", VA = "0x187E12280")]
	private void OHFEIAFLFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EF40", Offset = "0x7E0E140", VA = "0x187E0EF40", Slot = "10")]
	public IReadOnlyList<JJANENCKJMM> HJAFILGEINK(bool IKOPONEJMMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F310", Offset = "0x7E0E510", VA = "0x187E0F310", Slot = "11")]
	public JJANENCKJMM IMAFKHMPJPG(GJGNFGDHFCI NCAFEKBCKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E450", Offset = "0x7E0D650", VA = "0x187E0E450")]
	private MMOLBELIPAC DJLPAEJFEPB(GJGNFGDHFCI NCAFEKBCKBL)
	{
		return default(MMOLBELIPAC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E2C0", Offset = "0x7E0D4C0", VA = "0x187E0E2C0", Slot = "14")]
	public bool CPOFLBHLOJB(GJGNFGDHFCI FFHFGGBFNHM, MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EEA0", Offset = "0x7E0E0A0", VA = "0x187E0EEA0", Slot = "15")]
	public JJANENCKJMM GPHBBIKIANA(MMOLBELIPAC LNFIMHGHDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E12470", Offset = "0x7E11670", VA = "0x187E12470")]
	private static bool PAHNJMGGKMM(ADHHCGCJLNE OHBJIOEHIDJ, MMOLBELIPAC LNFIMHGHDGN, [Out] CNBFEOFDELO? BFEDHAIFLDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E810", Offset = "0x7E0DA10", VA = "0x187E0E810")]
	private static void GIBAOFGFBJL(ADHHCGCJLNE OHBJIOEHIDJ, Action<CNBFEOFDELO> GBCPPKIKGDL, MMOLBELIPAC IDCGCBPKJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E900", Offset = "0x7E0DB00", VA = "0x187E0E900")]
	private static void GIBAOFGFBJL(ADHHCGCJLNE OHBJIOEHIDJ, Action<CNBFEOFDELO> GBCPPKIKGDL, Predicate<MMOLBELIPAC> MEFPPPJDCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7E11210", Offset = "0x7E10410", VA = "0x187E11210")]
	private void NAHNPPICMPM(GJGNFGDHFCI NCAFEKBCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E105F0", Offset = "0x7E0F7F0", VA = "0x187E105F0", Slot = "4")]
	[AsyncStateMachine(typeof(HDAEDOAKFLJ))]
	public Task LLNBLIEOPGJ([CanBeNull] HKFACLJBOKN JEICPGHJIDH, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
	public void GFIMJIAJPIG(HKFACLJBOKN JEICPGHJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D200", Offset = "0x7E0C400", VA = "0x187E0D200")]
	private void ACBMJOGFKKC(ADHHCGCJLNE LDAIMOJDEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EB90", Offset = "0x7E0DD90", VA = "0x187E0EB90")]
	internal static string GKOCDKEEBAE(IONGMJGDDPL HEOAEEEHBIN, HKFACLJBOKN JEICPGHJIDH, IReadOnlyDictionary<MMOLBELIPAC, IMGHPIHJECN> JCBPKFMBEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F680", Offset = "0x7E0E880", VA = "0x187E0F680")]
	private static void KKLFCICHBLP(HKFACLJBOKN JEICPGHJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D7F0", Offset = "0x7E0C9F0", VA = "0x187E0D7F0")]
	private static void BCONCLDJFBG(ADHHCGCJLNE LPOIDBOGIFI, IReadOnlyDictionary<MMOLBELIPAC, IMGHPIHJECN> JCBPKFMBEIL, StringBuilder EPGMLHAELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E700", Offset = "0x7E0D900", VA = "0x187E0E700")]
	private static bool FNNMPJLNAIP(string IPNKHFNHGJG, [Out] Guid PKONGBONELE, [Out] MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7E10710", Offset = "0x7E0F910", VA = "0x187E10710")]
	private static void LMFINDLILIO(HKFACLJBOKN JEICPGHJIDH, StringBuilder EPGMLHAELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x31FC620", Offset = "0x31FB820", VA = "0x1831FC620", Slot = "16")]
	public bool EJLBBBEILBP<T>(MMOLBELIPAC LNFIMHGHDGN, GKEDFAIHPDG NCDCGGJIOLL, bool IPFHLECCEII, T DLGGINKGFFM, [Optional] Action HIDOPKFLLBG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EFC0", Offset = "0x7E0E1C0", VA = "0x187E0EFC0", Slot = "17")]
	public string HJHMNBPKIGE(GKEDFAIHPDG NCDCGGJIOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7E103E0", Offset = "0x7E0F5E0", VA = "0x187E103E0")]
	private void LLLAEKCBICN(MMOLBELIPAC LNFIMHGHDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DBE0", Offset = "0x7E0CDE0", VA = "0x187E0DBE0")]
	private bool CHJGKAINDBM(GJGNFGDHFCI NCAFEKBCKBL, MMOLBELIPAC LNFIMHGHDGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DF80", Offset = "0x7E0D180", VA = "0x187E0DF80")]
	internal IMGHPIHJECN CLOLPEIIDHL(GJGNFGDHFCI NCAFEKBCKBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7E127A0", Offset = "0x7E119A0", VA = "0x187E127A0", Slot = "13")]
	public IReadOnlyList<JJANENCKJMM> PPCBKEDMFIN(GJGNFGDHFCI NCAFEKBCKBL, bool HOBMDGDCEFP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7E10FE0", Offset = "0x7E101E0", VA = "0x187E10FE0")]
	internal IReadOnlyList<IMGHPIHJECN> MHPHKAMKIEG(GJGNFGDHFCI NCAFEKBCKBL, bool HOBMDGDCEFP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7E11280", Offset = "0x7E10480", VA = "0x187E11280")]
	private void OBAPKNKEHEG(BCJEFLAOEBL BMHPLIJEIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F030", Offset = "0x7E0E230", VA = "0x187E0F030")]
	private static bool ICGEEIGGGMH(IMGHPIHJECN NCIEIDHOEIO, IReadOnlyDictionary<MMOLBELIPAC, IMGHPIHJECN> JCBPKFMBEIL, [Out] IReadOnlyList<GKEDFAIHPDG> CIOIPMPPLOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7E10E50", Offset = "0x7E10050", VA = "0x187E10E50")]
	[AsyncStateMachine(typeof(JKHJNEPIKHB))]
	private static Task MAGPDOGFAMN(IONGMJGDDPL HEOAEEEHBIN, HKFACLJBOKN JEICPGHJIDH, IReadOnlyDictionary<MMOLBELIPAC, IMGHPIHJECN> JCBPKFMBEIL, IDECIICAEAC GMEPCNOKEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D540", Offset = "0x7E0C740", VA = "0x187E0D540")]
	[CompilerGenerated]
	internal static void AIPAFDFCBIM(Func<CNBFEOFDELO, PIAHCMKMHFK> PPLGIIPLNFE, CBLMEGMEPDC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DC00", Offset = "0x7E0CE00", VA = "0x187E0DC00")]
	[CompilerGenerated]
	internal static bool CLNBOIALJPB(MMOLBELIPAC LNFIMHGHDGN, GKEDFAIHPDG NCDCGGJIOLL, [Out] OBCJCPKHCCK GCCGEFGMKCN, JBNHJMIAHHA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface FOMGHPEFJJP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJOHNGLLLLD(GJGNFGDHFCI CBCLAKFBKNG, GJGNFGDHFCI POBBJNOCHEO, IEnumerable<GJGNFGDHFCI> FKMDGJJAHEG, [Out] DIKLJODDHIL AKDMAFJHNEA, [Out] NAHAOMLCLJM DIFELJOPPFG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CNGIIGCPDEM(NAHAOMLCLJM LPDIBKJHHKE);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum NAHAOMLCLJM : byte
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
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal class GMFLIOPFFCG : FOMGHPEFJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly KAJLCNPGDDA IKGHAFCAHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly MMBBOODMKAL HKLDMNPGJEE;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	[RecRoom.NoEngine.Common.Preserve]
	public GMFLIOPFFCG([KMMHIEIDBEA(null)] KAJLCNPGDDA NHLHFFADBAE, [KMMHIEIDBEA(null)] MMBBOODMKAL GMECGJFGMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7E14580", Offset = "0x7E13780", VA = "0x187E14580")]
	private static GDDCHMNKMCA? KPKIJOHMEGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7E145C0", Offset = "0x7E137C0", VA = "0x187E145C0", Slot = "4")]
	public bool LJOHNGLLLLD(GJGNFGDHFCI CBCLAKFBKNG, GJGNFGDHFCI POBBJNOCHEO, IEnumerable<GJGNFGDHFCI> FKMDGJJAHEG, [Out] DIKLJODDHIL AKDMAFJHNEA, [Out] NAHAOMLCLJM DIFELJOPPFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7E14480", Offset = "0x7E13680", VA = "0x187E14480", Slot = "5")]
	public string CNGIIGCPDEM(NAHAOMLCLJM LPDIBKJHHKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7E13E70", Offset = "0x7E13070", VA = "0x187E13E70")]
	internal bool ABFNOEJKDLJ(GJGNFGDHFCI CBCLAKFBKNG, GJGNFGDHFCI POBBJNOCHEO, IEnumerable<GJGNFGDHFCI> FKMDGJJAHEG, AELLMCLLHFN OIGFHLOIIFP, GDDCHMNKMCA? KMHDIPHFDND, [Out] DIKLJODDHIL AKDMAFJHNEA, [Out] NAHAOMLCLJM DIFELJOPPFG)
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
