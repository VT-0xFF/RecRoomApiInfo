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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x627ADF0", Offset = "0x6279BF0", VA = "0x18627ADF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IBHMCOMKEDP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void BPNKFKNGNIM<TPermission>(TPermission LAIFILEDJBA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FIMEHMEOOJH(OOAELAJMHEN IJEPINGDCGI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CBMNJOHIKLB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IMHBKCMFLHF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NFAFIKCODHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KLDPFHOCAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AHAIKPFGJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DEGHPDEDJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LMHAIAOJJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FJFBDMLGKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DNJPNMOGNFM
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum PKIGFANFADH
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
	public static readonly Guid AHGJEGCKDBC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IIHGKKMADHO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid JKIBKHLHECK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid OAOHIIEKODN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid GMHCCDNDFFJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid BACCFELKEBF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HJCMHKCOKPC<KIPPJHCADAO, Guid> PFFODKMKECH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<KIPPJHCADAO> BOGGPJGJFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62764A0", Offset = "0x62752A0", VA = "0x1862764A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62766F0", Offset = "0x62754F0", VA = "0x1862766F0")]
	public static KIPPJHCADAO PJONPGHIHKO(Guid EIODILKIKCN)
	{
		return default(KIPPJHCADAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6276560", Offset = "0x6275360", VA = "0x186276560")]
	public static Guid LFNDKCKOBDG(KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6276410", Offset = "0x6275210", VA = "0x186276410")]
	public static bool GCAINKNICEB(KIPPJHCADAO HKAFPHFMNKJ, [Out] Guid EIODILKIKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6276370", Offset = "0x6275170", VA = "0x186276370")]
	public static bool FPNGGKONFNL(Guid EIODILKIKCN, [Out] KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6276600", Offset = "0x6275400", VA = "0x186276600")]
	public static KIPPJHCADAO LLCBBFILIEI(KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(KIPPJHCADAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6276640", Offset = "0x6275440", VA = "0x186276640")]
	public static PKIGFANFADH NNJEJCBECOE(KIPPJHCADAO KIIEMHOKOPD)
	{
		return default(PKIGFANFADH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6276520", Offset = "0x6275320", VA = "0x186276520")]
	internal static KIPPJHCADAO LEJAGPMFKOP(PKIGFANFADH GMEHACPNEDD)
	{
		return default(KIPPJHCADAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GKFLDDFDJDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HKBGLIMODOD HHFAJDKDLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<DNOHJNCHJOG> CEPEKGELEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FIMEHMEOOJH NBNOJNAMPFI;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<DNOHJNCHJOG> GDGANDHMGDE(bool HGHEPHPHGMP = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DNOHJNCHJOG MFDCEGKCDNP(OOAELAJMHEN IJEPINGDCGI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PALNNBOIJFB(OOAELAJMHEN IJEPINGDCGI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<DNOHJNCHJOG> HIIPELBGIKF(OOAELAJMHEN IJEPINGDCGI, bool KFJCMPJKBCI = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NNNEBPEAANK(OOAELAJMHEN ENOOMKCEHOA, KIPPJHCADAO HKAFPHFMNKJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DNOHJNCHJOG GOEBENDGFHN(KIPPJHCADAO HKAFPHFMNKJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LOHIJLAKCDB<T>(KIPPJHCADAO HKAFPHFMNKJ, FKNMKBGNIGA LAIFILEDJBA, bool GPAEHODFNPN, T GIMGFOJNMGL) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LBMFJHANOOH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CBFGHEGPBHH(ELNFILGNBCL EDDLBMGEMFE, CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNDMEHEGJEG(ELNFILGNBCL EDDLBMGEMFE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KMBCNEIIPKO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OOAELAJMHEN LLMPEMBMOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KGDNOOKHPHA NBHNAJLLMCD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HEKEHEGBBLG FFIDNHJHEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<FKALNKMPHHK> HNAEKKAOPIB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GCNOHNHHLHB;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KIPPJHCADAO MMAGELIOECJ(OOAELAJMHEN IJEPINGDCGI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FKALNKMPHHK> COKCEOOFAAC(CancellationToken BCCDJHNACKO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task FKGHMHOBKEC(long ODPLBFKINCE, long CNKFDDFGKPE, IReadOnlyList<DBIHMHBPKNC> BDKABJGEGJK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<OOAELAJMHEN> BJMELIAPLCC();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OPPBNANEEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x627CE90", Offset = "0x627BC90", VA = "0x18627CE90")]
	public static KIPPJHCADAO HNGOMBNGODK(this KMBCNEIIPKO IMADGLMGHHF)
	{
		return default(KIPPJHCADAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BGJBBCEKIGI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NKMCADOEFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event BPNKFKNGNIM<TPermission> GBACDIICNLB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class KLGFDPCNGIP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ICHOPAGLLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	protected KLGFDPCNGIP(object? JCKNHIFLPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MIJIMIONLJI(object? POACLGOFKAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class INAGEPGBFGJ<T> : KLGFDPCNGIP where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T JICAFAADPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> GKEGMLFBEMI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36A6E60", Offset = "0x36A5C60", VA = "0x1836A6E60", Slot = "4")]
	public override bool MIJIMIONLJI(object? POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36A7230", Offset = "0x36A6030", VA = "0x1836A7230")]
	public bool MMBJMIMFNMJ(T MDADPMIMGNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36A74B0", Offset = "0x36A62B0", VA = "0x1836A74B0")]
	public INAGEPGBFGJ(T PPFOBEPKLDB, IEqualityComparer<T> GKEGMLFBEMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OBGKNEELFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<FKNMKBGNIGA, bool> MNOKPOHGJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<FKNMKBGNIGA, KLGFDPCNGIP> FLFNBDBHFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly ONJKFIGAEJE LFHKIOEBOGB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x627B360", Offset = "0x627A160", VA = "0x18627B360")]
	public OBGKNEELFHA(ONJKFIGAEJE LFHKIOEBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x627B2F0", Offset = "0x627A0F0", VA = "0x18627B2F0")]
	public bool PMCLELKLKBN(FKNMKBGNIGA LAIFILEDJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24FDDC0", Offset = "0x24FCBC0", VA = "0x1824FDDC0")]
	public bool JBCFOGNOKLB<T>(FKNMKBGNIGA LAIFILEDJBA, bool GPAEHODFNPN, T POACLGOFKAJ) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24FE2D0", Offset = "0x24FD0D0", VA = "0x1824FE2D0")]
	public (bool, T?) MMFOJJECJLG<T>(FKNMKBGNIGA LAIFILEDJBA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x627B140", Offset = "0x6279F40", VA = "0x18627B140")]
	public bool JBCFOGNOKLB(FKNMKBGNIGA LAIFILEDJBA, bool GPAEHODFNPN, object POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x627B220", Offset = "0x627A020", VA = "0x18627B220")]
	public (bool, object) MMFOJJECJLG(FKNMKBGNIGA LAIFILEDJBA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24FDD80", Offset = "0x24FCB80", VA = "0x1824FDD80")]
	private void FCLIDLEHMGA<T>(FKNMKBGNIGA LAIFILEDJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x627B070", Offset = "0x6279E70", VA = "0x18627B070")]
	private KLGFDPCNGIP JADBACKEKIM(FKNMKBGNIGA LAIFILEDJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x627AE70", Offset = "0x6279C70", VA = "0x18627AE70")]
	public void GEDBIMOBPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FDFJJGLPCIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string PHABGLMBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type PNDNHBAHIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly INOKEIJFAPE KAMCHMJJPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly FKNMKBGNIGA MJFOAHHEKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NGGJFAACNMA ELHJICODEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public AEKDFFONGIP IAOJLNHIDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public IBPJMHGAALI JNPJJILLMHA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6276BA0", Offset = "0x62759A0", VA = "0x186276BA0")]
	public FDFJJGLPCIP(Type EPGJCLHCDKG, string NPMILPHBDEH, FKNMKBGNIGA LAIFILEDJBA, NGGJFAACNMA EMCDCGCNHOA, AEKDFFONGIP DEHNPLBMBFJ, IBPJMHGAALI HOAMPCIDNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6276B50", Offset = "0x6275950", VA = "0x186276B50")]
	public object JEBKHCCDPLI(object? LKMMHIOOCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2372220", Offset = "0x2371020", VA = "0x182372220")]
	public void FCLIDLEHMGA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6276AA0", Offset = "0x62758A0", VA = "0x186276AA0")]
	public void FCLIDLEHMGA(Type DIODDAGGCIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class FDGDLDONCPH<T> : FDFJJGLPCIP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string FJANFOGNNCM(T POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T KFOKDCELKKB(string? PPACAGJDPOA, T PPFOBEPKLDB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IEANKBLOMKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FJANFOGNNCM serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KFOKDCELKKB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IEANKBLOMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36760B0", Offset = "0x3674EB0", VA = "0x1836760B0")]
		internal string JFNJDBFGGNA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3676010", Offset = "0x3674E10", VA = "0x183676010")]
		internal object CGPEBOJMCJK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3396DB0", Offset = "0x3395BB0", VA = "0x183396DB0")]
	public FDGDLDONCPH(FKNMKBGNIGA LAIFILEDJBA, string NPMILPHBDEH, [Optional] FJANFOGNNCM? EMCDCGCNHOA, [Optional] KFOKDCELKKB? DEHNPLBMBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3396150", Offset = "0x3394F50", VA = "0x183396150")]
	private static object? NLOFGFEMKNI(KFOKDCELKKB? DEHNPLBMBFJ, string? PPACAGJDPOA, object? PPFOBEPKLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3395BB0", Offset = "0x33949B0", VA = "0x183395BB0")]
	private static string LJOKGFFEJKK(FJANFOGNNCM? MBKFAALDIHA, object? POACLGOFKAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string NGGJFAACNMA(object? POACLGOFKAJ);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object AEKDFFONGIP(string? PPACAGJDPOA, [Optional] object PPFOBEPKLDB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate KLGFDPCNGIP IBPJMHGAALI();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class ONJKFIGAEJE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class FPHIDPLCGAH : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static FPHIDPLCGAH IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6276C40", Offset = "0x6275A40", VA = "0x186276C40", Slot = "4")]
		public bool Equals(List<string> NPDPLEIHBMM, List<string> CINKHPOEGPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6276D90", Offset = "0x6275B90", VA = "0x186276D90", Slot = "5")]
		public int GetHashCode(List<string> DGPHOMINFCK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FPHIDPLCGAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class NBJBAHOCCFB : NIJDIKIGJCP<IBHMCOMKEDP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x627ACC0", Offset = "0x6279AC0", VA = "0x18627ACC0", Slot = "9")]
		public override string LJOKGFFEJKK(IBHMCOMKEDP KHNEEJJPNNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x627AAE0", Offset = "0x62798E0", VA = "0x18627AAE0", Slot = "10")]
		protected override bool IGFKLLGCMKG(string KHNEEJJPNNH, [Out] IBHMCOMKEDP POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x627ADB0", Offset = "0x6279BB0", VA = "0x18627ADB0")]
		public NBJBAHOCCFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly IBLMCNLAFKH GCNADAEDJJH;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly NBJBAHOCCFB EKGJENGOEJO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<FDFJJGLPCIP> JDKAJFDDOHG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<FKNMKBGNIGA> DKGJKDIODLF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<FKNMKBGNIGA, FDFJJGLPCIP> PIPEKBPFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x627CB40", Offset = "0x627B940", VA = "0x18627CB40")]
	public ONJKFIGAEJE([Optional] IList<FDFJJGLPCIP>? PGPMFLMINNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x627BCD0", Offset = "0x627AAD0", VA = "0x18627BCD0")]
	public FDFJJGLPCIP GJHHLOHLHKE(FKNMKBGNIGA LAIFILEDJBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HKBGLIMODOD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DNOHJNCHJOG ILMLPLPCOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class LFMIBLJHEEE : HKBGLIMODOD
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static LFMIBLJHEEE OKFCJHCHCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IGFCODNHODE MLKDFDKIJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<IGFCODNHODE> ELMKEEKNMOP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DNOHJNCHJOG ILMLPLPCOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x627A740", Offset = "0x6279540", VA = "0x18627A740")]
	public LFMIBLJHEEE(IGFCODNHODE DALAALFNJCG, IReadOnlyList<IGFCODNHODE> EBGOLDBFIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6279D10", Offset = "0x6278B10", VA = "0x186279D10")]
	private static LFMIBLJHEEE ANGCCLJAKNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LACNEOOGAAP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<KIPPJHCADAO> NIKOMEKBCEJ;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6279A80", Offset = "0x6278880", VA = "0x186279A80")]
	public static bool HJGJCKAAEKN(this OOAELAJMHEN DPOAKIJENBG, KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6279A00", Offset = "0x6278800", VA = "0x186279A00")]
	public static bool CHBNHGDLMFH(this OOAELAJMHEN DPOAKIJENBG, KIPPJHCADAO HKAFPHFMNKJ, HEKEHEGBBLG BNHJGEKGFBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DNKHIPPHLDB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PBCNNANDNCE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GLCMEDFJMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GAOHOGFAKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DIOOIHGCEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CDONBMALAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HGAHPFBAAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FCBCFKNODNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PAJBAMFBOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ODLBGPEPBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ENHIMHKJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DMINJGNLNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool APLMIJIAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> LBDMLLNDIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IBHMCOMKEDP PIJBLGCMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DNOHJNCHJOG : DNKHIPPHLDB, IMHBKCMFLHF, BGJBBCEKIGI<FKNMKBGNIGA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string OHKLCIBPCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KIPPJHCADAO PICCGIFGNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) KPCBNAIDKKG<T>(FKNMKBGNIGA LAIFILEDJBA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum FKNMKBGNIGA
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
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class IGFCODNHODE : DNOHJNCHJOG, DNKHIPPHLDB, IMHBKCMFLHF, BGJBBCEKIGI<FKNMKBGNIGA>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly ONJKFIGAEJE NNDODKFFBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly OBGKNEELFHA GKFJMMOCBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? BKLCBKOHBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? JFHCPHBJOHM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool AIDGGPCOFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6278880", Offset = "0x6277680", VA = "0x186278880", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool HLGAOALLDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6277810", Offset = "0x6276610", VA = "0x186277810", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool HFCLHAPMHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6277E10", Offset = "0x6276C10", VA = "0x186277E10", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool EALCJLCCPMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62794B0", Offset = "0x62782B0", VA = "0x1862794B0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LHGOINNBGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6278830", Offset = "0x6277630", VA = "0x186278830", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool MJIGADALEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6277860", Offset = "0x6276660", VA = "0x186277860", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KIPPJHCADAO PICCGIFGNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KIPPJHCADAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x763AB0", VA = "0x180764CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NKMCADOEFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6278A40", Offset = "0x6277840", VA = "0x186278A40", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6279500", Offset = "0x6278300", VA = "0x186279500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string OHKLCIBPCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6278A40", Offset = "0x6277840", VA = "0x186278A40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FDHJJKOECID
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D1380", Offset = "0x7D0180", VA = "0x1807D1380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7D1030", Offset = "0x7CFE30", VA = "0x1807D1030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PBCNNANDNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6278D80", Offset = "0x6277B80", VA = "0x186278D80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IBHMCOMKEDP PIJBLGCMGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6278F30", Offset = "0x6277D30", VA = "0x186278F30", Slot = "20")]
		get
		{
			return default(IBHMCOMKEDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GLCMEDFJMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62787E0", Offset = "0x62775E0", VA = "0x1862787E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GAOHOGFAKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62778B0", Offset = "0x62766B0", VA = "0x1862778B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DIOOIHGCEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6277900", Offset = "0x6276700", VA = "0x186277900", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CDONBMALAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6278C90", Offset = "0x6277A90", VA = "0x186278C90", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HGAHPFBAAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6278F80", Offset = "0x6277D80", VA = "0x186278F80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FCBCFKNODNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6278CE0", Offset = "0x6277AE0", VA = "0x186278CE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool PAJBAMFBOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6277DC0", Offset = "0x6276BC0", VA = "0x186277DC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ODLBGPEPBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6279550", Offset = "0x6278350", VA = "0x186279550", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> LBDMLLNDIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6278ED0", Offset = "0x6277CD0", VA = "0x186278ED0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NIJFOOALICA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6278880", Offset = "0x6277680", VA = "0x186278880", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LEOPMDGDFDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6278830", Offset = "0x6277630", VA = "0x186278830", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FADFBMNMJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6277810", Offset = "0x6276610", VA = "0x186277810", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ENHIMHKJHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6278E80", Offset = "0x6277C80", VA = "0x186278E80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DMINJGNLNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62788D0", Offset = "0x62776D0", VA = "0x1862788D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PEIFACGBMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6277E10", Offset = "0x6276C10", VA = "0x186277E10", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool APLMIJIAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6278FD0", Offset = "0x6277DD0", VA = "0x186278FD0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LKMLOFFHOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62794B0", Offset = "0x62782B0", VA = "0x1862794B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LJOEHNOFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6277860", Offset = "0x6276660", VA = "0x186277860", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event BPNKFKNGNIM<FKNMKBGNIGA> GBACDIICNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6279680", Offset = "0x6278480", VA = "0x186279680", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6278DD0", Offset = "0x6277BD0", VA = "0x186278DD0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x23E0EF0", Offset = "0x23DFCF0", VA = "0x1823E0EF0", Slot = "6")]
	public (bool, T?) KPCBNAIDKKG<T>(FKNMKBGNIGA LAIFILEDJBA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23E1080", Offset = "0x23DFE80", VA = "0x1823E1080")]
	public IGFCODNHODE OPJNDLCNEGI<T>(FKNMKBGNIGA LAIFILEDJBA, bool GPAEHODFNPN, T POACLGOFKAJ) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6279920", Offset = "0x6278720", VA = "0x186279920")]
	public IGFCODNHODE(KIPPJHCADAO HKAFPHFMNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x62799D0", Offset = "0x62787D0", VA = "0x1862799D0")]
	public IGFCODNHODE(KIPPJHCADAO HKAFPHFMNKJ, [Optional] string? BKLCBKOHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6279940", Offset = "0x6278740", VA = "0x186279940")]
	public IGFCODNHODE(IGFCODNHODE JDPOABCNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62797C0", Offset = "0x62785C0", VA = "0x1862797C0")]
	internal IGFCODNHODE(KIPPJHCADAO HCGMBOPMHLE, [Optional] string? BKLCBKOHBOM, [Optional] IGFCODNHODE? JDPOABCNDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6279020", Offset = "0x6277E20", VA = "0x186279020")]
	public static INOKEIJFAPE MPPLPBKGGDA(FKNMKBGNIGA LAIFILEDJBA)
	{
		return default(INOKEIJFAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6278A20", Offset = "0x6277820", VA = "0x186278A20")]
	public void GEDBIMOBPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62790A0", Offset = "0x6277EA0", VA = "0x1862790A0")]
	internal IGFCODNHODE NBDBODBIDLI(IGFCODNHODE HIGKHLCCJJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6277950", Offset = "0x6276750", VA = "0x186277950")]
	internal IReadOnlyCollection<FKNMKBGNIGA> DPPGELLEEGP(IGFCODNHODE JDPOABCNDFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62795A0", Offset = "0x62783A0", VA = "0x1862795A0")]
	public bool OLCNFHGJBKL(FKNMKBGNIGA LAIFILEDJBA, bool GPAEHODFNPN, string MIDHMEHADPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6278920", Offset = "0x6277720", VA = "0x186278920")]
	public (bool, string) GBKCFNNKNAC(FKNMKBGNIGA LAIFILEDJBA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6278D30", Offset = "0x6277B30", VA = "0x186278D30")]
	internal void JPGCEJNOKBP(FKNMKBGNIGA LAIFILEDJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6278A90", Offset = "0x6277890", VA = "0x186278A90")]
	public PAFLCDNDIBI HKFKGMFEFNK(Func<KIPPJHCADAO, Guid> GBLCGOPFIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6277E60", Offset = "0x6276C60", VA = "0x186277E60")]
	public void EMDMJEPGONF(PAFLCDNDIBI JOOIKHNBIID, Func<Guid, KIPPJHCADAO> JJJHGGODLNA, [Optional] KIPPJHCADAO? DEJIPMPIBBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6279420", Offset = "0x6278220", VA = "0x186279420")]
	[CompilerGenerated]
	private void NDJAMDOLMGO(FKNMKBGNIGA GELECBIAFCD, NGHCFMAOKHD KANCLOPIBBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AEEJPCCGFMN : LBMFJHANOOH, GKFLDDFDJDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HOHFDILPIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IGFCODNHODE newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HOHFDILPIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6276F80", Offset = "0x6275D80", VA = "0x186276F80")]
		internal bool DFIMGEGMNJC(IGFCODNHODE rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JBHJPGNDHDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KIPPJHCADAO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JBHJPGNDHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62799F0", Offset = "0x62787F0", VA = "0x1862799F0")]
		internal bool HHFALECMGKP(KIPPJHCADAO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OEIHJHDOOLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AEEJPCCGFMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public ELNFILGNBCL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<FKALNKMPHHK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x627B610", Offset = "0x627A410", VA = "0x18627B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x627BC70", Offset = "0x627AA70", VA = "0x18627BC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MBPFKCJBAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MBPFKCJBAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x627A850", Offset = "0x6279650", VA = "0x18627A850")]
		internal void BNKANOGNOPK(PAFLCDNDIBI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x627A930", Offset = "0x6279730", VA = "0x18627A930")]
		internal void MCFABLDNNJH(PAFLCDNDIBI r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct CFLHDENHLKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public ELNFILGNBCL roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MOMLBHACBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<PAFLCDNDIBI, NGHCFMAOKHD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MOMLBHACBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x627AA80", Offset = "0x6279880", VA = "0x18627AA80")]
		internal void FCFEBKIOGNI(PAFLCDNDIBI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x627AA50", Offset = "0x6279850", VA = "0x18627AA50")]
		internal void AFMHOLFMDKA(PAFLCDNDIBI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x627AAB0", Offset = "0x62798B0", VA = "0x18627AAB0")]
		internal void NFJKADAMKGE(PAFLCDNDIBI r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MCPFOEBPDBH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public MCPFOEBPDBH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<FKALNKMPHHK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2EB5480", Offset = "0x2EB4280", VA = "0x182EB5480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AEEJPCCGFMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public FKNMKBGNIGA rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KIPPJHCADAO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public INOKEIJFAPE recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MCPFOEBPDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B6B0", Offset = "0x3B5A4B0", VA = "0x183B5B6B0")]
		[AsyncStateMachine(typeof(MCPFOEBPDBH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OPOIIKFMFLG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NKCIFJBCMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<DBIHMHBPKNC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CEBHNIOBFOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KMBCNEIIPKO rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public ELNFILGNBCL roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<KIPPJHCADAO, IGFCODNHODE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KNIGOHBLMAO debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6275800", Offset = "0x6274600", VA = "0x186275800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6276310", Offset = "0x6275110", VA = "0x186276310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KMBCNEIIPKO IMADGLMGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly LFMIBLJHEEE EAOLOFFPFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KNIGOHBLMAO LJGOGIGCNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, IGFCODNHODE> MBHEBPIPPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<KIPPJHCADAO, IGFCODNHODE> PCNCEBHKLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<KIPPJHCADAO, IGFCODNHODE> LBBMFLNFOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<IGFCODNHODE> DBNEJNDLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool AGGADHMMFFO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FKNMKBGNIGA[] APHDEAJEMIP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HKBGLIMODOD HHFAJDKDLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<DNOHJNCHJOG> CEPEKGELEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6273A80", Offset = "0x6272880", VA = "0x186273A80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event FIMEHMEOOJH NBNOJNAMPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6274170", Offset = "0x6272F70", VA = "0x186274170", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6273BA0", Offset = "0x62729A0", VA = "0x186273BA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6273FB0", Offset = "0x6272DB0", VA = "0x186273FB0")]
	[DJDJPHIPNFL(KHJICKDGEOE.Room, IEJLPKKICHC.None)]
	private static void LKBEDIJGOEL(NNIGDKDCOBN AMGLAFJJOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6275540", Offset = "0x6274340", VA = "0x186275540")]
	[UnityEngine.Scripting.Preserve]
	internal AEEJPCCGFMN([FGPOJKOJBFM(null)] KMBCNEIIPKO BMCDJBGLGBP, [FGPOJKOJBFM(null)] LFMIBLJHEEE CBJOCAOBKCN, [FGPOJKOJBFM(null)] KNIGOHBLMAO LJGOGIGCNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6271AB0", Offset = "0x62708B0", VA = "0x186271AB0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6273200", Offset = "0x6272000", VA = "0x186273200")]
	private void IMOEOAJPIBF(IEnumerable<IGFCODNHODE> FCMNJAJOPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x62752A0", Offset = "0x62740A0", VA = "0x1862752A0", Slot = "12")]
	public bool PALNNBOIJFB(OOAELAJMHEN IJEPINGDCGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x62724B0", Offset = "0x62712B0", VA = "0x1862724B0")]
	private void GCNOHNHHLHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x62722C0", Offset = "0x62710C0", VA = "0x1862722C0")]
	private void FIOCKDLLIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x62724C0", Offset = "0x62712C0", VA = "0x1862724C0", Slot = "10")]
	public IReadOnlyList<DNOHJNCHJOG> GDGANDHMGDE(bool HGHEPHPHGMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6274210", Offset = "0x6273010", VA = "0x186274210", Slot = "11")]
	public DNOHJNCHJOG MFDCEGKCDNP(OOAELAJMHEN IJEPINGDCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6273AD0", Offset = "0x62728D0", VA = "0x186273AD0")]
	private KIPPJHCADAO JPPCNKHDNLH(OOAELAJMHEN IJEPINGDCGI)
	{
		return default(KIPPJHCADAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6275110", Offset = "0x6273F10", VA = "0x186275110", Slot = "14")]
	public bool NNNEBPEAANK(OOAELAJMHEN ENOOMKCEHOA, KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6272540", Offset = "0x6271340", VA = "0x186272540", Slot = "15")]
	public DNOHJNCHJOG GOEBENDGFHN(KIPPJHCADAO HKAFPHFMNKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x62725F0", Offset = "0x62713F0", VA = "0x1862725F0")]
	private static bool HPKFAHHJFLB(BFIAPBDDKKJ JENFKPIBGLN, KIPPJHCADAO HKAFPHFMNKJ, [Out] PAFLCDNDIBI? EKPHPHPLAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x626FD70", Offset = "0x626EB70", VA = "0x18626FD70")]
	private static void BDFCFAMAEIG(BFIAPBDDKKJ JENFKPIBGLN, Action<PAFLCDNDIBI> FLKGFPGNOHA, KIPPJHCADAO KCBAHIEDDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x626FE60", Offset = "0x626EC60", VA = "0x18626FE60")]
	private static void BDFCFAMAEIG(BFIAPBDDKKJ JENFKPIBGLN, Action<PAFLCDNDIBI> FLKGFPGNOHA, Predicate<KIPPJHCADAO> NNNPMMBMECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6271DF0", Offset = "0x6270BF0", VA = "0x186271DF0")]
	private void FCFPOHLAPCJ(OOAELAJMHEN IJEPINGDCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6270830", Offset = "0x626F630", VA = "0x186270830", Slot = "4")]
	[AsyncStateMachine(typeof(OEIHJHDOOLH))]
	public Task CBFGHEGPBHH([CanBeNull] ELNFILGNBCL EDDLBMGEMFE, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
	public void LNDMEHEGJEG(ELNFILGNBCL EDDLBMGEMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6272C20", Offset = "0x6271A20", VA = "0x186272C20")]
	private void ILNCLONKOGJ(BFIAPBDDKKJ LKGELHEOCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6272920", Offset = "0x6271720", VA = "0x186272920")]
	internal static string IBMMFHOCJDN(KMBCNEIIPKO IMADGLMGHHF, ELNFILGNBCL EDDLBMGEMFE, IReadOnlyDictionary<KIPPJHCADAO, IGFCODNHODE> PCNCEBHKLOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6270950", Offset = "0x626F750", VA = "0x186270950")]
	private static void CINGDLOFLHE(ELNFILGNBCL EDDLBMGEMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6271760", Offset = "0x6270560", VA = "0x186271760")]
	private static void DOKALMGBPPC(BFIAPBDDKKJ IGJOLIBBBOM, IReadOnlyDictionary<KIPPJHCADAO, IGFCODNHODE> PCNCEBHKLOC, StringBuilder FNBHGHDAFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6271E60", Offset = "0x6270C60", VA = "0x186271E60")]
	private static bool FCGFFGDFMDD(string NFNBKFAAEKE, [Out] Guid HMFHACILCJN, [Out] KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x62700F0", Offset = "0x626EEF0", VA = "0x1862700F0")]
	private static void BKJJMMIIFHK(ELNFILGNBCL EDDLBMGEMFE, StringBuilder FNBHGHDAFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29BC2D0", Offset = "0x29BB0D0", VA = "0x1829BC2D0", Slot = "16")]
	public bool LOHIJLAKCDB<T>(KIPPJHCADAO HKAFPHFMNKJ, FKNMKBGNIGA LAIFILEDJBA, bool GPAEHODFNPN, T GIMGFOJNMGL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6271BE0", Offset = "0x62709E0", VA = "0x186271BE0")]
	private void FAFNKEKIIIC(KIPPJHCADAO HKAFPHFMNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6271BC0", Offset = "0x62709C0", VA = "0x186271BC0")]
	private bool EIDGPKIFCMG(OOAELAJMHEN IJEPINGDCGI, KIPPJHCADAO HKAFPHFMNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6271F70", Offset = "0x6270D70", VA = "0x186271F70")]
	internal IGFCODNHODE FFDECGICOBN(OOAELAJMHEN IJEPINGDCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x62725E0", Offset = "0x62713E0", VA = "0x1862725E0", Slot = "13")]
	public IReadOnlyList<DNOHJNCHJOG> HIIPELBGIKF(OOAELAJMHEN IJEPINGDCGI, bool KFJCMPJKBCI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6274610", Offset = "0x6273410", VA = "0x186274610")]
	internal IReadOnlyList<IGFCODNHODE> MLAPHENCIPK(OOAELAJMHEN IJEPINGDCGI, bool KFJCMPJKBCI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6274980", Offset = "0x6273780", VA = "0x186274980")]
	private void NDCKMOBBGFK(FKALNKMPHHK NENPBOECLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6274320", Offset = "0x6273120", VA = "0x186274320")]
	private static bool MIOFNECDIBH(IGFCODNHODE LCCOMMFEHHD, IReadOnlyDictionary<KIPPJHCADAO, IGFCODNHODE> PCNCEBHKLOC, [Out] IReadOnlyList<FKNMKBGNIGA> MKIPJIEKEDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6274840", Offset = "0x6273640", VA = "0x186274840")]
	[AsyncStateMachine(typeof(CEBHNIOBFOG))]
	private static Task MPMHPAGFCCF(KMBCNEIIPKO IMADGLMGHHF, ELNFILGNBCL EDDLBMGEMFE, IReadOnlyDictionary<KIPPJHCADAO, IGFCODNHODE> PCNCEBHKLOC, KNIGOHBLMAO LJGOGIGCNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6272F60", Offset = "0x6271D60", VA = "0x186272F60")]
	[CompilerGenerated]
	internal static void IMJHEICHDPF(Func<PAFLCDNDIBI, NGHCFMAOKHD> PHLHINOIAOJ, CFLHDENHLKM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6273C40", Offset = "0x6272A40", VA = "0x186273C40")]
	[CompilerGenerated]
	internal static bool KHMPDOCPDNA(KIPPJHCADAO HKAFPHFMNKJ, FKNMKBGNIGA LAIFILEDJBA, [Out] DBIHMHBPKNC PPJNJMBJMGJ, NKCIFJBCMJE P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EACBMJHMHGE
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBCONOMNCGP(OOAELAJMHEN OPIAPALKAOD, OOAELAJMHEN NLAPPABBNJB, IEnumerable<OOAELAJMHEN> ADCNCOIHHLG, [Out] IBHMCOMKEDP LPENNMGHPFK, [Out] COFDBNBCFOC DFNMOAHIFFN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JODNDLMGKMI(COFDBNBCFOC LNOJLBJCIHI);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum COFDBNBCFOC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class IGCPLODNBJE : EACBMJHMHGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly GKFLDDFDJDI IFNOHBKGDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OHHLDDDLFIG ACPBLKHOJOF;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IGCPLODNBJE([FGPOJKOJBFM(null)] GKFLDDFDJDI MBEFHFCFIIK, [FGPOJKOJBFM(null)] OHHLDDDLFIG NKPDKNHCCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6276FB0", Offset = "0x6275DB0", VA = "0x186276FB0")]
	private static LNOLIFDBGLJ? CHMKICDENPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6277710", Offset = "0x6276510", VA = "0x186277710", Slot = "4")]
	public bool KBCONOMNCGP(OOAELAJMHEN OPIAPALKAOD, OOAELAJMHEN NLAPPABBNJB, IEnumerable<OOAELAJMHEN> ADCNCOIHHLG, [Out] IBHMCOMKEDP LPENNMGHPFK, [Out] COFDBNBCFOC DFNMOAHIFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6277610", Offset = "0x6276410", VA = "0x186277610", Slot = "5")]
	public string JODNDLMGKMI(COFDBNBCFOC LNOJLBJCIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6276FF0", Offset = "0x6275DF0", VA = "0x186276FF0")]
	internal bool JEKDIDCAJON(OOAELAJMHEN OPIAPALKAOD, OOAELAJMHEN NLAPPABBNJB, IEnumerable<OOAELAJMHEN> ADCNCOIHHLG, HEKEHEGBBLG BNHJGEKGFBE, LNOLIFDBGLJ? GJDMPMBCGFM, [Out] IBHMCOMKEDP LPENNMGHPFK, [Out] COFDBNBCFOC DFNMOAHIFFN)
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
