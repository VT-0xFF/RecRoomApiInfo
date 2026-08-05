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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x836A6D0", Offset = "0x8368ED0", VA = "0x18836A6D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EKEAAGAGCOJ
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
		[Cpp2IlInjected.Address(RVA = "0x836B5A0", Offset = "0x8369DA0", VA = "0x18836B5A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EFGIKCGKODL<TPermission>(TPermission GCCJHANBJGG);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void BLEEKIBPHID(GFEBJDBBDID PPBALHIMPIH);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LNPGPIPPLKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ODPDKDNBLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LAPLOLDGNEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BGBBODLLKJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KBBEJBDBAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OMHHNGCENPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CDGAGNEOJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KKLMJIDNDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class ONKLELAOHEF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum ONNLGNAOBBB
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
	public static readonly Guid CMACIFDLNEF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PLEKBJIEFJM;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid BADKLBOLPCI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PFEJEFNMJOA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EDNJBCNHPBN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid AOFGKMDIHEA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PDKOGHFNHHG<COICKFBCMHF, Guid> HIAJHCMCNML;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<COICKFBCMHF> BJDHAIAILMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x836A8C0", Offset = "0x83690C0", VA = "0x18836A8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x836A830", Offset = "0x8369030", VA = "0x18836A830")]
	public static COICKFBCMHF EKHNOKBOPFH(Guid BGPPHEMBCAA)
	{
		return default(COICKFBCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x836A750", Offset = "0x8368F50", VA = "0x18836A750")]
	public static Guid AGCINALGJBH(COICKFBCMHF COFMNIJMBEA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x836A9E0", Offset = "0x83691E0", VA = "0x18836A9E0")]
	public static bool KBCMMCIHCGI(COICKFBCMHF COFMNIJMBEA, [Out] Guid BGPPHEMBCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x836AAB0", Offset = "0x83692B0", VA = "0x18836AAB0")]
	public static bool LPKCNOJEEBL(Guid BGPPHEMBCAA, [Out] COICKFBCMHF COFMNIJMBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x836A7F0", Offset = "0x8368FF0", VA = "0x18836A7F0")]
	public static COICKFBCMHF DMMBMKBEEIO(COICKFBCMHF COFMNIJMBEA)
	{
		return default(COICKFBCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x836A930", Offset = "0x8369130", VA = "0x18836A930")]
	public static ONNLGNAOBBB IKCEOKLEOCC(COICKFBCMHF KPNBDHMGLIB)
	{
		return default(ONNLGNAOBBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x836AA70", Offset = "0x8369270", VA = "0x18836AA70")]
	internal static COICKFBCMHF LJCPKLGONLI(ONNLGNAOBBB NKOBHNOGMOH)
	{
		return default(COICKFBCMHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JGMIOBDOCME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FCOKINMMMJE LFDMKHAOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<MIJNILDCMJJ> FEPCBHCPJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BLEEKIBPHID IBMMKJMCIDF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<MIJNILDCMJJ> MPNABEKFNDO(bool LGCPFOFDDLJ = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MIJNILDCMJJ HPGDAGNKHIG(GFEBJDBBDID PPBALHIMPIH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CKGJPOLMDCG(GFEBJDBBDID PPBALHIMPIH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<MIJNILDCMJJ> ALKIDLKDGIA(GFEBJDBBDID PPBALHIMPIH, bool FLOBKJICMPI = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GGOOFFKCMBM(GFEBJDBBDID ALGIOKNEGPA, COICKFBCMHF COFMNIJMBEA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MIJNILDCMJJ GLACIOPGNBF(COICKFBCMHF COFMNIJMBEA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KCAOPKGHNGI<T>(COICKFBCMHF COFMNIJMBEA, EJJAGMFINLH GCCJHANBJGG, bool DANNHOKBAIC, T MJAILKMLAHP, [Optional] Action JLONHGHAIIH) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string JOCEIFGBDAH(EJJAGMFINLH GCCJHANBJGG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MPGHNPHBFKO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CNILIHPFDJM(IOKANKGCBIH PDNEBCPKAAP, CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLPLNDBNBNC(IOKANKGCBIH PDNEBCPKAAP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KLKLBPFLJGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GFEBJDBBDID MIFHJIFKLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ADDOLAOCDBG KEIDDJKOCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HCHPFAEFOMI EGFOEMKEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FNCGLCELCEN> AEKPEMHFMOB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OLIBOLCBOEI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COICKFBCMHF PCLKKGMBOFF(GFEBJDBBDID PPBALHIMPIH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FNCGLCELCEN> FDPCKHGNPDG(CancellationToken DNHBNMHIDAC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MGCHFCAFDMF(long MDLDCACFGIB, IReadOnlyList<HDCIIHAMABI> ACOIPGKOKFL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task IKIPENALOAE(long MDLDCACFGIB, long DBEJCKJKFPB, IReadOnlyList<HDCIIHAMABI> ACOIPGKOKFL);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GFEBJDBBDID> FHOFJKDFAAB();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JKPGGFFKJOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8369FA0", Offset = "0x83687A0", VA = "0x188369FA0")]
	public static COICKFBCMHF BLEFDIEKOID(this KLKLBPFLJGM OGMBAGIIACI)
	{
		return default(COICKFBCMHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DDCLDAONCAM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string DKOGHJDPLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EFGIKCGKODL<TPermission> DDABKOBFEBM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class HGBDMKJOJNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? OPBDGGHOPKK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? PKGDDCJPBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83616B0", Offset = "0x835FEB0", VA = "0x1883616B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8361780", Offset = "0x835FF80", VA = "0x188361780")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8361880", Offset = "0x8360080", VA = "0x188361880")]
	protected HGBDMKJOJNG(object? NEFPHCDMFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CDJBNKOKNEH(object? OPMIAMEJKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KPNGDGOPNFF<T> : HGBDMKJOJNG where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> OHBECKLCOCD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F50BA0", Offset = "0x4F4F3A0", VA = "0x184F50BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F50E80", Offset = "0x4F4F680", VA = "0x184F50E80", Slot = "4")]
	public override bool CDJBNKOKNEH(object? OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F511C0", Offset = "0x4F4F9C0", VA = "0x184F511C0")]
	public bool NCLCHAFLNGC(T CFNDDHMCOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F51630", Offset = "0x4F4FE30", VA = "0x184F51630")]
	public KPNGDGOPNFF(T LHCNPHOLELG, IEqualityComparer<T> OHBECKLCOCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class CIMNDBMCAFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<EJJAGMFINLH, bool> IHIFAHKFPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<EJJAGMFINLH, HGBDMKJOJNG> BIFCPDALGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JHKHGOINEGI MOPOEFAIMME;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x835E900", Offset = "0x835D100", VA = "0x18835E900")]
	public CIMNDBMCAFH(JHKHGOINEGI MOPOEFAIMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x835E4F0", Offset = "0x835CCF0", VA = "0x18835E4F0")]
	public bool JNJGEBCEHKF(EJJAGMFINLH GCCJHANBJGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3590550", Offset = "0x358ED50", VA = "0x183590550")]
	public bool PMNEEKEKLDH<T>(EJJAGMFINLH GCCJHANBJGG, bool DANNHOKBAIC, T OPMIAMEJKDH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35900B0", Offset = "0x358E8B0", VA = "0x1835900B0")]
	public (bool, T?) GFPBGEMLPEA<T>(EJJAGMFINLH GCCJHANBJGG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x835E820", Offset = "0x835D020", VA = "0x18835E820")]
	public bool PMNEEKEKLDH(EJJAGMFINLH GCCJHANBJGG, bool DANNHOKBAIC, object OPMIAMEJKDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x835E360", Offset = "0x835CB60", VA = "0x18835E360")]
	public (bool, object) GFPBGEMLPEA(EJJAGMFINLH GCCJHANBJGG)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3590050", Offset = "0x358E850", VA = "0x183590050")]
	private void GDAJGOPKLMO<T>(EJJAGMFINLH GCCJHANBJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x835E560", Offset = "0x835CD60", VA = "0x18835E560")]
	private HGBDMKJOJNG KBOMJONJJHF(EJJAGMFINLH GCCJHANBJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x835E630", Offset = "0x835CE30", VA = "0x18835E630")]
	public void PBLACGACONH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class FLLCILEAJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string DGFFOJPABFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type HHOEPADHAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly HIJJGLPOKJF DOFCMFGINDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EJJAGMFINLH BPFLIAOHPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OAAFIDANEEF KINBEPLHIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LEPFOOMDLFD LMOPJADDMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CPCKCNACCHF HDLKOMNMCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8360D30", Offset = "0x835F530", VA = "0x188360D30")]
	public FLLCILEAJOI(Type AGIOGNJIKGH, string PANEKIAKHIH, EJJAGMFINLH GCCJHANBJGG, OAAFIDANEEF AFNOEFFDGFE, LEPFOOMDLFD OLAAIALNNPI, CPCKCNACCHF LDBECHOIPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8360C30", Offset = "0x835F430", VA = "0x188360C30")]
	public object EPINMJIIPCI(object? PGPJMFPAKOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3784610", Offset = "0x3782E10", VA = "0x183784610")]
	public void GDAJGOPKLMO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8360C80", Offset = "0x835F480", VA = "0x188360C80")]
	public void GDAJGOPKLMO(Type AACNDNCHFFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FMDFBMAJPBM<T> : FLLCILEAJOI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string PCDFHKJFNHJ(T OPMIAMEJKDH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T KBEJEDAEKNL(string? CMCMHADACKB, T LHCNPHOLELG);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KDFNEAPELEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public PCDFHKJFNHJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KBEJEDAEKNL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KDFNEAPELEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBE60", Offset = "0x4EEA660", VA = "0x184EEBE60")]
		internal string GJLCNIACNFJ(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4EEBCE0", Offset = "0x4EEA4E0", VA = "0x184EEBCE0")]
		internal object BEKBLGGLCKL(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x48D63A0", Offset = "0x48D4BA0", VA = "0x1848D63A0")]
	public FMDFBMAJPBM(EJJAGMFINLH GCCJHANBJGG, string PANEKIAKHIH, [Optional] PCDFHKJFNHJ? AFNOEFFDGFE, [Optional] KBEJEDAEKNL? OLAAIALNNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x48D5750", Offset = "0x48D3F50", VA = "0x1848D5750")]
	private static object? MPBEICGIKAG(KBEJEDAEKNL? OLAAIALNNPI, string? CMCMHADACKB, object? LHCNPHOLELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x48D5180", Offset = "0x48D3980", VA = "0x1848D5180")]
	private static string LIJGMGKAKKG(PCDFHKJFNHJ? FDOGMBABEDE, object? OPMIAMEJKDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string OAAFIDANEEF(object? OPMIAMEJKDH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object LEPFOOMDLFD(string? CMCMHADACKB, [Optional] object LHCNPHOLELG);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate HGBDMKJOJNG CPCKCNACCHF();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class JHKHGOINEGI
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class APAGMOLAINB : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static APAGMOLAINB DJLOIKDDKCN;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x835DB30", Offset = "0x835C330", VA = "0x18835DB30", Slot = "4")]
		public bool Equals(List<string> LEFBJAGNHCD, List<string> LLGPJHIECFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x835DC80", Offset = "0x835C480", VA = "0x18835DC80", Slot = "5")]
		public int GetHashCode(List<string> PNHCNFOFAFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public APAGMOLAINB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class HNHADOMCMKN : FECLMDBGLMA<EKEAAGAGCOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8367590", Offset = "0x8365D90", VA = "0x188367590", Slot = "9")]
		public override string LIJGMGKAKKG(EKEAAGAGCOJ JEOEDPICHHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83673B0", Offset = "0x8365BB0", VA = "0x1883673B0", Slot = "10")]
		protected override bool BLBICEGAHDG(string JEOEDPICHHI, [Out] EKEAAGAGCOJ OPMIAMEJKDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8367680", Offset = "0x8365E80", VA = "0x188367680")]
		public HNHADOMCMKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly IOAFEBNHBFG FJGMEMCGKCH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly HNHADOMCMKN NNNLAALFNGE;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<FLLCILEAJOI> HMGFPIINIMM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<EJJAGMFINLH> PNCECGDDNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<EJJAGMFINLH, FLLCILEAJOI> HPFHGIGJCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8369C80", Offset = "0x8368480", VA = "0x188369C80")]
	public JHKHGOINEGI([Optional] IList<FLLCILEAJOI>? DGJPEGFPPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8368710", Offset = "0x8366F10", VA = "0x188368710")]
	public FLLCILEAJOI ILDDJOPCKDJ(EJJAGMFINLH GCCJHANBJGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FCOKINMMMJE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MIJNILDCMJJ JJNFFDHPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IGLLLGIJCPO : FCOKINMMMJE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static IGLLLGIJCPO FIEDFNCLGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly ENBAMNLHEAO LGLPBPFJGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<ENBAMNLHEAO> DDDOGMJBANK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MIJNILDCMJJ JJNFFDHPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x83685D0", Offset = "0x8366DD0", VA = "0x1883685D0")]
	public IGLLLGIJCPO(ENBAMNLHEAO DPHCLPLKIIG, IReadOnlyList<ENBAMNLHEAO> HDOBMEDOECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x83676C0", Offset = "0x8365EC0", VA = "0x1883676C0")]
	private static IGLLLGIJCPO EGDNNKFCAHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BIPDLAMALMA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<COICKFBCMHF> GFMIOCGLJLJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x835DEE0", Offset = "0x835C6E0", VA = "0x18835DEE0")]
	public static bool HIMNONEBCMA(this GFEBJDBBDID JFDOFPAEGJJ, COICKFBCMHF COFMNIJMBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x835DE60", Offset = "0x835C660", VA = "0x18835DE60")]
	public static bool ABHHGGNILAI(this GFEBJDBBDID JFDOFPAEGJJ, COICKFBCMHF COFMNIJMBEA, HCHPFAEFOMI DDNKGBJDCEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JGKIDCJJDPN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EMENICBDNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FHKBBKKKGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CCPKIDPDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PBGADKNHAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JEEOGEEEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GOMEJBGFEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KHJEDEELDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BHDAMKFGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DDPOEBIOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LPOJAINDEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BJJBEOPLLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LJMCCKAMAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MEHDICLCEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	EKEAAGAGCOJ APMEEEFMAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MIJNILDCMJJ : JGKIDCJJDPN, ODPDKDNBLDO, DDCLDAONCAM<EJJAGMFINLH>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string INAPEHBAGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	COICKFBCMHF CFFBDHBHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FKNJDDFHGLN<T>(EJJAGMFINLH GCCJHANBJGG) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum EJJAGMFINLH
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
internal class ENBAMNLHEAO : MIJNILDCMJJ, JGKIDCJJDPN, ODPDKDNBLDO, DDCLDAONCAM<EJJAGMFINLH>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly JHKHGOINEGI OMILFLLCMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly CIMNDBMCAFH NLBCADKGDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? JCPHPOEJCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? AJBNDCMEFBG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LDOAKDMIOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x835ED50", Offset = "0x835D550", VA = "0x18835ED50", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool ENEFHPDKPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x835EC10", Offset = "0x835D410", VA = "0x18835EC10", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool LKHILCHNBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x835F160", Offset = "0x835D960", VA = "0x18835F160", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool EDOHMJBLMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x835FE10", Offset = "0x835E610", VA = "0x18835FE10", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool DOJNFEMJDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x835EFC0", Offset = "0x835D7C0", VA = "0x18835EFC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool KOCOMMMADPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x835F010", Offset = "0x835D810", VA = "0x18835F010", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public COICKFBCMHF CFFBDHBHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(COICKFBCMHF);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9E1B40", Offset = "0x9E0340", VA = "0x1809E1B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string DKOGHJDPLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x835F6A0", Offset = "0x835DEA0", VA = "0x18835F6A0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x835FAD0", Offset = "0x835E2D0", VA = "0x18835FAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string INAPEHBAGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x835F6A0", Offset = "0x835DEA0", VA = "0x18835F6A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BJKFMMMGKNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD58CC0", Offset = "0xD574C0", VA = "0x180D58CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD58CE0", Offset = "0xD574E0", VA = "0x180D58CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool EMENICBDNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x835F570", Offset = "0x835DD70", VA = "0x18835F570", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EKEAAGAGCOJ APMEEEFMAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x835EF20", Offset = "0x835D720", VA = "0x18835EF20", Slot = "20")]
		get
		{
			return default(EKEAAGAGCOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FHKBBKKKGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x835EED0", Offset = "0x835D6D0", VA = "0x18835EED0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CCPKIDPDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x835EDA0", Offset = "0x835D5A0", VA = "0x18835EDA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PBGADKNHAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x835FFD0", Offset = "0x835E7D0", VA = "0x18835FFD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JEEOGEEEFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x835F5C0", Offset = "0x835DDC0", VA = "0x18835F5C0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool GOMEJBGFEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x835FE60", Offset = "0x835E660", VA = "0x18835FE60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KHJEDEELDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x835F400", Offset = "0x835DC00", VA = "0x18835F400", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BHDAMKFGOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x835F1B0", Offset = "0x835D9B0", VA = "0x18835F1B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DDPOEBIOKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x835ECB0", Offset = "0x835D4B0", VA = "0x18835ECB0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MEHDICLCEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x835EBB0", Offset = "0x835D3B0", VA = "0x18835EBB0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CCFFDJFNFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x835ED50", Offset = "0x835D550", VA = "0x18835ED50", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OKOHGDMBHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x835EFC0", Offset = "0x835D7C0", VA = "0x18835EFC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool COKOLFGAMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x835EC10", Offset = "0x835D410", VA = "0x18835EC10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LPOJAINDEEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x835FF60", Offset = "0x835E760", VA = "0x18835FF60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BJJBEOPLLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x835ED00", Offset = "0x835D500", VA = "0x18835ED00", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MJOPEGKPEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x835F160", Offset = "0x835D960", VA = "0x18835F160", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool LJMCCKAMAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x835EF70", Offset = "0x835D770", VA = "0x18835EF70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CAMOAHDMFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x835FE10", Offset = "0x835E610", VA = "0x18835FE10", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ABHGAFOPICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x835F010", Offset = "0x835D810", VA = "0x18835F010", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EFGIKCGKODL<EJJAGMFINLH> DDABKOBFEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x835F4C0", Offset = "0x835DCC0", VA = "0x18835F4C0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x835FEB0", Offset = "0x835E6B0", VA = "0x18835FEB0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x360C640", Offset = "0x360AE40", VA = "0x18360C640", Slot = "6")]
	public (bool, T?) FKNJDDFHGLN<T>(EJJAGMFINLH GCCJHANBJGG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x360C5E0", Offset = "0x360ADE0", VA = "0x18360C5E0")]
	public ENBAMNLHEAO BDHHNGLEECI<T>(EJJAGMFINLH GCCJHANBJGG, bool DANNHOKBAIC, T OPMIAMEJKDH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8360B70", Offset = "0x835F370", VA = "0x188360B70")]
	public ENBAMNLHEAO(COICKFBCMHF COFMNIJMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8360B90", Offset = "0x835F390", VA = "0x188360B90")]
	public ENBAMNLHEAO(COICKFBCMHF COFMNIJMBEA, [Optional] string? JCPHPOEJCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8360BB0", Offset = "0x835F3B0", VA = "0x188360BB0")]
	public ENBAMNLHEAO(ENBAMNLHEAO IHHLNGNBFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8360A20", Offset = "0x835F220", VA = "0x188360A20")]
	internal ENBAMNLHEAO(COICKFBCMHF IPLENNNENDP, [Optional] string? JCPHPOEJCNK, [Optional] ENBAMNLHEAO? IHHLNGNBFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x835F450", Offset = "0x835DC50", VA = "0x18835F450")]
	public static HIJJGLPOKJF GJHBKODNDHI(EJJAGMFINLH GCCJHANBJGG)
	{
		return default(HIJJGLPOKJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x835FFB0", Offset = "0x835E7B0", VA = "0x18835FFB0")]
	public void PBLACGACONH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x835FB20", Offset = "0x835E320", VA = "0x18835FB20")]
	internal ENBAMNLHEAO NGMIFHNBJDA(ENBAMNLHEAO KKLEDIBEANP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x835F6F0", Offset = "0x835DEF0", VA = "0x18835F6F0")]
	internal IReadOnlyCollection<EJJAGMFINLH> MCKFNIJNPJM(ENBAMNLHEAO IHHLNGNBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x835EDF0", Offset = "0x835D5F0", VA = "0x18835EDF0")]
	public bool BFMGPEDPLKJ(EJJAGMFINLH GCCJHANBJGG, bool DANNHOKBAIC, string PNEHFDDDAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x835F060", Offset = "0x835D860", VA = "0x18835F060")]
	public (bool, string) DHLOGMJIFCJ(EJJAGMFINLH GCCJHANBJGG)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x835EC60", Offset = "0x835D460", VA = "0x18835EC60")]
	internal void ADFBBNPLPFM(EJJAGMFINLH GCCJHANBJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x835F200", Offset = "0x835DA00", VA = "0x18835F200")]
	public BIFBJGIDKAM FBPKLAMOAFK(Func<COICKFBCMHF, Guid> MHGAGFJMPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8360020", Offset = "0x835E820", VA = "0x188360020")]
	public void PINAIBOKAIC(BIFBJGIDKAM BNFHAGNKELG, Func<Guid, COICKFBCMHF> DIJNFPHBIPI, [Optional] COICKFBCMHF? AMACPIAAHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x835F610", Offset = "0x835DE10", VA = "0x18835F610")]
	[CompilerGenerated]
	private void KFFNBHDLGKM(EJJAGMFINLH MMBOJIKNFMF, CLBMOKDPBPF AGHHOPCKDIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HKGAJDKBINF : MPGHNPHBFKO, JGMIOBDOCME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IJIIEMIHJEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ENBAMNLHEAO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IJIIEMIHJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83686E0", Offset = "0x8366EE0", VA = "0x1883686E0")]
		internal bool JJJBHCKIGGO(ENBAMNLHEAO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OKNMOGPOAHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public COICKFBCMHF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OKNMOGPOAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1BB10F0", Offset = "0x1BAF8F0", VA = "0x181BB10F0")]
		internal bool BKJOHOHBENC(COICKFBCMHF r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MEMGFALIEFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public HKGAJDKBINF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IOKANKGCBIH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<FNCGLCELCEN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x836A000", Offset = "0x8368800", VA = "0x18836A000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x836A670", Offset = "0x8368E70", VA = "0x18836A670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BPHNANKMOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BPHNANKMOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x835E160", Offset = "0x835C960", VA = "0x18835E160")]
		internal void MDJCEIDJHNF(BIFBJGIDKAM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x835E240", Offset = "0x835CA40", VA = "0x18835E240")]
		internal void PBCHIKGMFEN(BIFBJGIDKAM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GCAAIEIPJFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IOKANKGCBIH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HBFAMCNOPFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<BIFBJGIDKAM, CLBMOKDPBPF> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HBFAMCNOPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8360E30", Offset = "0x835F630", VA = "0x188360E30")]
		internal void IMANNEEFFBN(BIFBJGIDKAM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8360E00", Offset = "0x835F600", VA = "0x188360E00")]
		internal void DKNAOGBGEHK(BIFBJGIDKAM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8360DD0", Offset = "0x835F5D0", VA = "0x188360DD0")]
		internal void CPKJBMEKEOM(BIFBJGIDKAM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DELDPKMINBP<T> where T : notnull
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
			public DELDPKMINBP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<FNCGLCELCEN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3FD3700", Offset = "0x3FD1F00", VA = "0x183FD3700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EJJAGMFINLH rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public COICKFBCMHF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HIJJGLPOKJF recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HKGAJDKBINF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DELDPKMINBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68CBD20", Offset = "0x68CA520", VA = "0x1868CBD20")]
		[AsyncStateMachine(typeof(DELDPKMINBP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void EJEMNPCAKCE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KEMJGOJBDNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<HDCIIHAMABI> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct ANHECBANNKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public KLKLBPFLJGM rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IOKANKGCBIH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<COICKFBCMHF, ENBAMNLHEAO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public MKCGLADJFFJ debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x835CFB0", Offset = "0x835B7B0", VA = "0x18835CFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x835DAD0", Offset = "0x835C2D0", VA = "0x18835DAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KLKLBPFLJGM OGMBAGIIACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IGLLLGIJCPO MFCNONNNKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly MKCGLADJFFJ MLNADBAMFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, ENBAMNLHEAO> HOOBHHEFLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<COICKFBCMHF, ENBAMNLHEAO> LHFNHABANHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<COICKFBCMHF, ENBAMNLHEAO> CPKGOONBPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<ENBAMNLHEAO> CJEMJKPLMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool AHBKJAAMNEM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly EJJAGMFINLH[] DLEJPPNBKEP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FCOKINMMMJE LFDMKHAOMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<MIJNILDCMJJ> FEPCBHCPJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8365080", Offset = "0x8363880", VA = "0x188365080", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BLEEKIBPHID IBMMKJMCIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8363F90", Offset = "0x8362790", VA = "0x188363F90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8364870", Offset = "0x8363070", VA = "0x188364870", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8364030", Offset = "0x8362830", VA = "0x188364030")]
	[PJMOOJOMMCC.JJBJMJNFHOJ]
	internal static void FGFPGKKONLH(HHDGAAFLDEF LFLOONKADLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x83670F0", Offset = "0x83658F0", VA = "0x1883670F0")]
	[UnityEngine.Scripting.Preserve]
	internal HKGAJDKBINF([LDAFGEHKDJK(null)] KLKLBPFLJGM BCAHAKOHDBE, [LDAFGEHKDJK(null)] IGLLLGIJCPO MEDLGJOBBMK, [LDAFGEHKDJK(null)] MKCGLADJFFJ MLNADBAMFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8363950", Offset = "0x8362150", VA = "0x188363950", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8365730", Offset = "0x8363F30", VA = "0x188365730")]
	private void MNBILKOLAGH(IEnumerable<ENBAMNLHEAO> HHMMGGLDAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8363690", Offset = "0x8361E90", VA = "0x188363690", Slot = "12")]
	public bool CKGJPOLMDCG(GFEBJDBBDID PPBALHIMPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8366DD0", Offset = "0x83655D0", VA = "0x188366DD0")]
	private void OLIBOLCBOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8363DA0", Offset = "0x83625A0", VA = "0x188363DA0")]
	private void FDCDKPDEACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8365FA0", Offset = "0x83647A0", VA = "0x188365FA0", Slot = "10")]
	public IReadOnlyList<MIJNILDCMJJ> MPNABEKFNDO(bool LGCPFOFDDLJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8364910", Offset = "0x8363110", VA = "0x188364910", Slot = "11")]
	public MIJNILDCMJJ HPGDAGNKHIG(GFEBJDBBDID PPBALHIMPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8363760", Offset = "0x8361F60", VA = "0x188363760")]
	private COICKFBCMHF CKPGDMOKGPL(GFEBJDBBDID PPBALHIMPIH)
	{
		return default(COICKFBCMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8364530", Offset = "0x8362D30", VA = "0x188364530", Slot = "14")]
	public bool GGOOFFKCMBM(GFEBJDBBDID ALGIOKNEGPA, COICKFBCMHF COFMNIJMBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x83646C0", Offset = "0x8362EC0", VA = "0x1883646C0", Slot = "15")]
	public MIJNILDCMJJ GLACIOPGNBF(COICKFBCMHF COFMNIJMBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83626F0", Offset = "0x8360EF0", VA = "0x1883626F0")]
	private static bool ANBIDHKMIPE(JHBPJJFMNMD MBPBCPBMGGM, COICKFBCMHF COFMNIJMBEA, [Out] BIFBJGIDKAM? EKNNGNFAEIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x83662C0", Offset = "0x8364AC0", VA = "0x1883662C0")]
	private static void NLALMKKKFAF(JHBPJJFMNMD MBPBCPBMGGM, Action<BIFBJGIDKAM> PPFPLOIGIPG, COICKFBCMHF LAHNDECHIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x83663B0", Offset = "0x8364BB0", VA = "0x1883663B0")]
	private static void NLALMKKKFAF(JHBPJJFMNMD MBPBCPBMGGM, Action<BIFBJGIDKAM> PPFPLOIGIPG, Predicate<COICKFBCMHF> KIMCNPNAPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8366020", Offset = "0x8364820", VA = "0x188366020")]
	private void NDIGCCKNLAJ(GFEBJDBBDID PPBALHIMPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8363830", Offset = "0x8362030", VA = "0x188363830", Slot = "4")]
	[AsyncStateMachine(typeof(MEMGFALIEFO))]
	public Task CNILIHPFDJM([CanBeNull] IOKANKGCBIH PDNEBCPKAAP, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
	public void HLPLNDBNBNC(IOKANKGCBIH PDNEBCPKAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x83641F0", Offset = "0x83629F0", VA = "0x1883641F0")]
	private void GFGNBPACIJA(JHBPJJFMNMD CEPALEKHDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8363380", Offset = "0x8361B80", VA = "0x188363380")]
	internal static string CIPAFJJIOIK(KLKLBPFLJGM OGMBAGIIACI, IOKANKGCBIH PDNEBCPKAAP, IReadOnlyDictionary<COICKFBCMHF, ENBAMNLHEAO> LHFNHABANHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8361980", Offset = "0x8360180", VA = "0x188361980")]
	private static void AAACMJDAOCA(IOKANKGCBIH PDNEBCPKAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8364D30", Offset = "0x8363530", VA = "0x188364D30")]
	private static void KIFAELOKLBN(JHBPJJFMNMD JNOHGJOHGHM, IReadOnlyDictionary<COICKFBCMHF, ENBAMNLHEAO> LHFNHABANHB, StringBuilder DIBOIHCJJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8364760", Offset = "0x8362F60", VA = "0x188364760")]
	private static bool HDHNHJIDHPA(string LDFOIEGMNHD, [Out] Guid DCNMJOOAOGJ, [Out] COICKFBCMHF COFMNIJMBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8362A40", Offset = "0x8361240", VA = "0x188362A40")]
	private static void CADIPGMOJAG(IOKANKGCBIH PDNEBCPKAAP, StringBuilder DIBOIHCJJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x37BD6D0", Offset = "0x37BBED0", VA = "0x1837BD6D0", Slot = "16")]
	public bool KCAOPKGHNGI<T>(COICKFBCMHF COFMNIJMBEA, EJJAGMFINLH GCCJHANBJGG, bool DANNHOKBAIC, T MJAILKMLAHP, [Optional] Action JLONHGHAIIH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8364CC0", Offset = "0x83634C0", VA = "0x188364CC0", Slot = "17")]
	public string JOCEIFGBDAH(EJJAGMFINLH GCCJHANBJGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8363170", Offset = "0x8361970", VA = "0x188363170")]
	private void CEGOKKMNCKL(COICKFBCMHF COFMNIJMBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8362A20", Offset = "0x8361220", VA = "0x188362A20")]
	private bool APODDBDMDAC(GFEBJDBBDID PPBALHIMPIH, COICKFBCMHF COFMNIJMBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8363A60", Offset = "0x8362260", VA = "0x188363A60")]
	internal ENBAMNLHEAO EGHAIHHEPDE(GFEBJDBBDID PPBALHIMPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x83626E0", Offset = "0x8360EE0", VA = "0x1883626E0", Slot = "13")]
	public IReadOnlyList<MIJNILDCMJJ> ALKIDLKDGIA(GFEBJDBBDID PPBALHIMPIH, bool FLOBKJICMPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8366090", Offset = "0x8364890", VA = "0x188366090")]
	internal IReadOnlyList<ENBAMNLHEAO> NFLLIMPENOA(GFEBJDBBDID PPBALHIMPIH, bool FLOBKJICMPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8366640", Offset = "0x8364E40", VA = "0x188366640")]
	private void OJAMMIKOCOD(FNCGLCELCEN FMEHKCBPJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8365450", Offset = "0x8363C50", VA = "0x188365450")]
	private static bool MBKGFPEMMBP(ENBAMNLHEAO BFCPPOIJEKF, IReadOnlyDictionary<COICKFBCMHF, ENBAMNLHEAO> LHFNHABANHB, [Out] IReadOnlyList<EJJAGMFINLH> CIOOEHDGLJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8366DE0", Offset = "0x83655E0", VA = "0x188366DE0")]
	[AsyncStateMachine(typeof(ANHECBANNKH))]
	private static Task ONKBMEMCJOK(KLKLBPFLJGM OGMBAGIIACI, IOKANKGCBIH PDNEBCPKAAP, IReadOnlyDictionary<COICKFBCMHF, ENBAMNLHEAO> LHFNHABANHB, MKCGLADJFFJ MLNADBAMFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8364A20", Offset = "0x8363220", VA = "0x188364A20")]
	[CompilerGenerated]
	internal static void IKMCOIGPECM(Func<BIFBJGIDKAM, CLBMOKDPBPF> JGCJLAHBLOM, GCAAIEIPJFF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x83650D0", Offset = "0x83638D0", VA = "0x1883650D0")]
	[CompilerGenerated]
	internal static bool LGPKAOHAFLN(COICKFBCMHF COFMNIJMBEA, EJJAGMFINLH GCCJHANBJGG, [Out] HDCIIHAMABI MAPNOLICNNK, KEMJGOJBDNK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ADBHCLPDPIM
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPPNLADNJMN(GFEBJDBBDID MCKBHGKIINC, GFEBJDBBDID JBFFAMABDBK, IEnumerable<GFEBJDBBDID> AKINBMOJAGM, [Out] EKEAAGAGCOJ BKGJOFFNEIL, [Out] IKODHPMEOAA ABKJHLLBBNB);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OIOBEADMBCI(IKODHPMEOAA OJKAGGGAGIF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum IKODHPMEOAA : byte
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
internal class HDCFHAFMKAG : ADBHCLPDPIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JGMIOBDOCME HOPKKPJHPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly INHDBINHEGG OIDNBDHPCFL;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HDCFHAFMKAG([LDAFGEHKDJK(null)] JGMIOBDOCME JJGLPEEAEHL, [LDAFGEHKDJK(null)] INHDBINHEGG BGCDNOLKNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8361570", Offset = "0x835FD70", VA = "0x188361570")]
	private static NDPKNMECKKD? LAAHAAOBPEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8360E60", Offset = "0x835F660", VA = "0x188360E60", Slot = "4")]
	public bool IPPNLADNJMN(GFEBJDBBDID MCKBHGKIINC, GFEBJDBBDID JBFFAMABDBK, IEnumerable<GFEBJDBBDID> AKINBMOJAGM, [Out] EKEAAGAGCOJ BKGJOFFNEIL, [Out] IKODHPMEOAA ABKJHLLBBNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x83615B0", Offset = "0x835FDB0", VA = "0x1883615B0", Slot = "5")]
	public string OIOBEADMBCI(IKODHPMEOAA OJKAGGGAGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x8360F60", Offset = "0x835F760", VA = "0x188360F60")]
	internal bool JBCEBHGJNGC(GFEBJDBBDID MCKBHGKIINC, GFEBJDBBDID JBFFAMABDBK, IEnumerable<GFEBJDBBDID> AKINBMOJAGM, HCHPFAEFOMI DDNKGBJDCEA, NDPKNMECKKD? IBJLPMMFNHO, [Out] EKEAAGAGCOJ BKGJOFFNEIL, [Out] IKODHPMEOAA ABKJHLLBBNB)
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
