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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x752AAC0", Offset = "0x7529EC0", VA = "0x18752AAC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GCBEKIKNGOF
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x752C570", Offset = "0x752B970", VA = "0x18752C570", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void AFJGBPIEPIC<TPermission>(TPermission IOOMFDFNPLK);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void PMKNLPFPGGG(NGDBFKPHNOF PBJBOGHPHPG);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DDBFEBCALJN
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MFONBOCBPAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DGGBNEGCGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PGIPDLBAMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AGGKAENKADI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KJCFBLJGLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EBGBPMHIENM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NIOOLOMAIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class DOHCHFLLIAB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum FIEGOAPMOIH
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
	public static readonly Guid PKAJGDGJPAN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid JIOOGHGPKHN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid ANMNKNCBCMD;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid CFEHJNLNOAL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid IEJNJDDJDGA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid EMKOICCIKHK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly ELEMDMKBHMI<MJIHINAKBBL, Guid> AONBGIOODED;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MJIHINAKBBL> BKKOJCHONAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7526730", Offset = "0x7525B30", VA = "0x187526730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75265B0", Offset = "0x75259B0", VA = "0x1875265B0")]
	public static MJIHINAKBBL CCIENLNEMCN(Guid FDANKBMKMCE)
	{
		return default(MJIHINAKBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7526510", Offset = "0x7525910", VA = "0x187526510")]
	public static Guid BHBKMEEHKNM(MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7526840", Offset = "0x7525C40", VA = "0x187526840")]
	public static bool NNEHKCKLABB(MJIHINAKBBL ONMGJDKAOFK, [Out] Guid FDANKBMKMCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75267A0", Offset = "0x7525BA0", VA = "0x1875267A0")]
	public static bool MKFIDGNEHEF(Guid FDANKBMKMCE, [Out] MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75266F0", Offset = "0x7525AF0", VA = "0x1875266F0")]
	public static MJIHINAKBBL KEGKPIDNGDG(MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(MJIHINAKBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7526640", Offset = "0x7525A40", VA = "0x187526640")]
	public static FIEGOAPMOIH HODOOGDPEGB(MJIHINAKBBL KPDFEIOKNFD)
	{
		return default(FIEGOAPMOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75264D0", Offset = "0x75258D0", VA = "0x1875264D0")]
	internal static MJIHINAKBBL BBNACEAOFCD(FIEGOAPMOIH JNEFGAILJIE)
	{
		return default(MJIHINAKBBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLMOIKADBMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PNHKMPHKCAI GOLKPHNOIOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NHKDALKDMHO> BLDHGNOKBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PMKNLPFPGGG LGKOMIBKOGC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NHKDALKDMHO> AMMDGCIBCGA(bool BJDMGOOLBHH = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NHKDALKDMHO FEIBGDKNLIA(NGDBFKPHNOF PBJBOGHPHPG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BCNHJBGMDDM(NGDBFKPHNOF PBJBOGHPHPG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NHKDALKDMHO> DCCPJLHOCLI(NGDBFKPHNOF PBJBOGHPHPG, bool LCALOKLCAEE = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CJOFODOBMBH(NGDBFKPHNOF IHKEPHGDAIG, MJIHINAKBBL ONMGJDKAOFK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NHKDALKDMHO JLIGFLLFBDP(MJIHINAKBBL ONMGJDKAOFK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PLBANJOLAIO<T>(MJIHINAKBBL ONMGJDKAOFK, NIGJOKJKKNK IOOMFDFNPLK, bool GKABPJFHGEF, T MGBFBAKCCAP, [Optional] Action GJFOBIJDKDC) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string CJNPBOHLIDN(NIGJOKJKKNK IOOMFDFNPLK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MCMEFHPKNHM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ALNBCIDHCGN(GBHFJBFIHDK CAAMOPOAIJO, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJGKGPFHEFO(GBHFJBFIHDK CAAMOPOAIJO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface POFHJJPNHJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NGDBFKPHNOF GIAIOBCAMHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GAGHJCEIHCL CIGGHNLIEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JKIABJFEAHD BGOEEACBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JJHEHAGBFBH> NHHJDEECAJA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OANHIHCAAIJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJIHINAKBBL PHCHNCDEIDN(NGDBFKPHNOF PBJBOGHPHPG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<JJHEHAGBFBH> KEGJPLNABFA(CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task EHJGDDAJMKH(long HLGODMOGCOI, IReadOnlyList<HPDBMLGDMJL> OMDHGHGAPDJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DOBAKKLIEDP(long HLGODMOGCOI, long LBMLFGGHFGP, IReadOnlyList<HPDBMLGDMJL> OMDHGHGAPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NGDBFKPHNOF> MFLECKIAIFL();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KDFNBHHLKPN
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7528E80", Offset = "0x7528280", VA = "0x187528E80")]
	public static MJIHINAKBBL GJECPHGMFFA(this POFHJJPNHJI HNAKHJLCJGC)
	{
		return default(MJIHINAKBBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DFDPNGPJELI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string BEIMFCCHPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AFJGBPIEPIC<TPermission> ILBPCKFCAPA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class INNPEBHOHNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? GLLHEEPEFBK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? IFKBOLFDFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7528990", Offset = "0x7527D90", VA = "0x187528990")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7528890", Offset = "0x7527C90", VA = "0x187528890")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7528A70", Offset = "0x7527E70", VA = "0x187528A70")]
	protected INNPEBHOHNH(object? IFEEEEHNNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MICHIDJGAIF(object? LIHHDPOHLDK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BFKKMMHOAEE<T> : INNPEBHOHNH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> BEBALKAAJIF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x526E1C0", Offset = "0x526D5C0", VA = "0x18526E1C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x526EB70", Offset = "0x526DF70", VA = "0x18526EB70", Slot = "4")]
	public override bool MICHIDJGAIF(object? LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x526E770", Offset = "0x526DB70", VA = "0x18526E770")]
	public bool LOABDKJIJON(T AOGLHFPBEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x526EFE0", Offset = "0x526E3E0", VA = "0x18526EFE0")]
	public BFKKMMHOAEE(T JGBDACMOCCC, IEqualityComparer<T> BEBALKAAJIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DEBODDPNLEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<NIGJOKJKKNK, bool> PGFDCLPFLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<NIGJOKJKKNK, INNPEBHOHNH> CODINKJBDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MCMJKLOKGJK IMEDDFFHHKB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7526220", Offset = "0x7525620", VA = "0x187526220")]
	public DEBODDPNLEJ(MCMJKLOKGJK IMEDDFFHHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7526000", Offset = "0x7525400", VA = "0x187526000")]
	public bool FJEPEGMNGML(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C817E0", Offset = "0x2C80BE0", VA = "0x182C817E0")]
	public bool ONFBCHJMNAC<T>(NIGJOKJKKNK IOOMFDFNPLK, bool GKABPJFHGEF, T LIHHDPOHLDK) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C812E0", Offset = "0x2C806E0", VA = "0x182C812E0")]
	public (bool, T?) AMMMDCBLJKN<T>(NIGJOKJKKNK IOOMFDFNPLK) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7526140", Offset = "0x7525540", VA = "0x187526140")]
	public bool ONFBCHJMNAC(NIGJOKJKKNK IOOMFDFNPLK, bool GKABPJFHGEF, object LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7525C70", Offset = "0x7525070", VA = "0x187525C70")]
	public (bool, object) AMMMDCBLJKN(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2C81780", Offset = "0x2C80B80", VA = "0x182C81780")]
	private void NDNEOKCIICF<T>(NIGJOKJKKNK IOOMFDFNPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7526070", Offset = "0x7525470", VA = "0x187526070")]
	private INNPEBHOHNH HOIPAKLIHOO(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7525E10", Offset = "0x7525210", VA = "0x187525E10")]
	public void BAAHHGOAOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CADCAMODBKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string IEGAFNEHLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type FGBJKFPCBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly GELLMGHAHAM MKHFIFLILFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NIGJOKJKKNK AABCBFLANNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public MEEOJEMOJGN EKAJOHFBHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EECHCFFAFAI NEOGLKJLAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FGOGJJKCHHC LKOBBIFNEEE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7525BD0", Offset = "0x7524FD0", VA = "0x187525BD0")]
	public CADCAMODBKL(Type AFHIFEGMKHI, string FHFNMMNBNEA, NIGJOKJKKNK IOOMFDFNPLK, MEEOJEMOJGN DFIOIEALBOM, EECHCFFAFAI BPOBGOCCHKJ, FGOGJJKCHHC IPFDDAIGHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7525AD0", Offset = "0x7524ED0", VA = "0x187525AD0")]
	public object BICCFHBJDOL(object? OCKBFCIKBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2C49110", Offset = "0x2C48510", VA = "0x182C49110")]
	public void NDNEOKCIICF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7525B20", Offset = "0x7524F20", VA = "0x187525B20")]
	public void NDNEOKCIICF(Type FEPHIAAAEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class MGAKPNCLEDI<T> : CADCAMODBKL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string HPNEJDKJMII(T LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T GPPEHLFCDCN(string? JIJKEHKAJNC, T JGBDACMOCCC);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PFAFNJFMPBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HPNEJDKJMII serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public GPPEHLFCDCN parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PFAFNJFMPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C540", Offset = "0x4B5B940", VA = "0x184B5C540")]
		internal string LCKJGALHHIK(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C640", Offset = "0x4B5BA40", VA = "0x184B5C640")]
		internal object PKGHMIPOOON(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x481AAE0", Offset = "0x4819EE0", VA = "0x18481AAE0")]
	public MGAKPNCLEDI(NIGJOKJKKNK IOOMFDFNPLK, string FHFNMMNBNEA, [Optional] HPNEJDKJMII? DFIOIEALBOM, [Optional] GPPEHLFCDCN? BPOBGOCCHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x48198B0", Offset = "0x4818CB0", VA = "0x1848198B0")]
	private static object? GEBAPMNFHGF(GPPEHLFCDCN? BPOBGOCCHKJ, string? JIJKEHKAJNC, object? JGBDACMOCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x481A250", Offset = "0x4819650", VA = "0x18481A250")]
	private static string KEEAKGCJIOB(HPNEJDKJMII? KIDHOOGFBCL, object? LIHHDPOHLDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string MEEOJEMOJGN(object? LIHHDPOHLDK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object EECHCFFAFAI(string? JIJKEHKAJNC, [Optional] object JGBDACMOCCC);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate INNPEBHOHNH FGOGJJKCHHC();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class MCMJKLOKGJK
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class PADLADHCMBA : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static PADLADHCMBA FKMJLLKHOAH;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x752BAE0", Offset = "0x752AEE0", VA = "0x18752BAE0", Slot = "4")]
		public bool Equals(List<string> CFANGCOBGCF, List<string> HHLCHNICLGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x752BC30", Offset = "0x752B030", VA = "0x18752BC30", Slot = "5")]
		public int GetHashCode(List<string> PBAACPJGKNP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PADLADHCMBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class KKKMMBPNCLD : EEFAJCIFCHO<GCBEKIKNGOF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x75290C0", Offset = "0x75284C0", VA = "0x1875290C0", Slot = "9")]
		public override string KEEAKGCJIOB(GCBEKIKNGOF GJMNBMBONPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7528EE0", Offset = "0x75282E0", VA = "0x187528EE0", Slot = "10")]
		protected override bool JOJFNENGGGI(string GJMNBMBONPJ, [Out] GCBEKIKNGOF LIHHDPOHLDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75291B0", Offset = "0x75285B0", VA = "0x1875291B0")]
		public KKKMMBPNCLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly GPBCAGFJKHP PFJHGCENMGA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KKKMMBPNCLD GKJHAGDBGKK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CADCAMODBKL> FKMIDONCPFF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<NIGJOKJKKNK> FPGKOMDBJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<NIGJOKJKKNK, CADCAMODBKL> FAFMAJDJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x752A7A0", Offset = "0x7529BA0", VA = "0x18752A7A0")]
	public MCMJKLOKGJK([Optional] IList<CADCAMODBKL>? JGIIKLEHHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7529290", Offset = "0x7528690", VA = "0x187529290")]
	public CADCAMODBKL PJJBDOFJAEJ(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PNHKMPHKCAI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NHKDALKDMHO BNPLODEPNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OMIMBIAHCBC : PNHKMPHKCAI
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static OMIMBIAHCBC PAAMGKPPNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly AJIGHCAAJGE JIBLICKACDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<AJIGHCAAJGE> IPJJCKABJEA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NHKDALKDMHO BNPLODEPNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x752B9D0", Offset = "0x752ADD0", VA = "0x18752B9D0")]
	public OMIMBIAHCBC(AJIGHCAAJGE LHCOIPINCKH, IReadOnlyList<AJIGHCAAJGE> EJNDPFJFJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x752AB40", Offset = "0x7529F40", VA = "0x18752AB40")]
	private static OMIMBIAHCBC DCEGAMINBDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JFIGBFFFNAK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<MJIHINAKBBL> NGKILHLLBGB;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7528C00", Offset = "0x7528000", VA = "0x187528C00")]
	public static bool HMJDAMCMCIE(this NGDBFKPHNOF NMLJOPBBABK, MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7528B80", Offset = "0x7527F80", VA = "0x187528B80")]
	public static bool FAFHPGDCKJC(this NGDBFKPHNOF NMLJOPBBABK, MJIHINAKBBL ONMGJDKAOFK, JKIABJFEAHD KKKJMHEOKEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HGNNLOFPLDP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PDAKLIPEENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OMMHAOJKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CPIAHFCGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FFHFBNIKAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MBIGKIIGFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CJIAOHLIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OENIENNNHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GGOLIMBBKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KANMPHIFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EIIIMHKIBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AIOBCJFOKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DOBAKPAGCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> NFCKGOLPLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GCBEKIKNGOF GDDNCACOILN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NHKDALKDMHO : HGNNLOFPLDP, MFONBOCBPAM, DFDPNGPJELI<NIGJOKJKKNK>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string IAFCIMPFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MJIHINAKBBL CDONFPOBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AABHEIALILD<T>(NIGJOKJKKNK IOOMFDFNPLK) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NIGJOKJKKNK
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
internal class AJIGHCAAJGE : NHKDALKDMHO, HGNNLOFPLDP, MFONBOCBPAM, DFDPNGPJELI<NIGJOKJKKNK>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly MCMJKLOKGJK IOLEPNFAOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly DEBODDPNLEJ EOBKFOCEKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? OMGBICDKOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? EFKAPBAOANG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PBINDPIHBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x751EBC0", Offset = "0x751DFC0", VA = "0x18751EBC0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DKINDDGJLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x751E9A0", Offset = "0x751DDA0", VA = "0x18751E9A0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NMCMABNBAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x751F020", Offset = "0x751E420", VA = "0x18751F020", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool GFJLDHGOKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x751E020", Offset = "0x751D420", VA = "0x18751E020", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JEMNKMCLENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x751E8B0", Offset = "0x751DCB0", VA = "0x18751E8B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool KLMDGLEDIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x751E430", Offset = "0x751D830", VA = "0x18751E430", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MJIHINAKBBL CDONFPOBLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MJIHINAKBBL);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B60D0", Offset = "0x8B54D0", VA = "0x1808B60D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string BEIMFCCHPAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x751FDC0", Offset = "0x751F1C0", VA = "0x18751FDC0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x751ECD0", Offset = "0x751E0D0", VA = "0x18751ECD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string IAFCIMPFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x751FDC0", Offset = "0x751F1C0", VA = "0x18751FDC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NIHGGIKJBPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x96BBB0", Offset = "0x96AFB0", VA = "0x18096BBB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x96B7F0", Offset = "0x96ABF0", VA = "0x18096B7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool PDAKLIPEENI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x751F200", Offset = "0x751E600", VA = "0x18751F200", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public GCBEKIKNGOF GDDNCACOILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x751E860", Offset = "0x751DC60", VA = "0x18751E860", Slot = "20")]
		get
		{
			return default(GCBEKIKNGOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OMMHAOJKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x751E9F0", Offset = "0x751DDF0", VA = "0x18751E9F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CPIAHFCGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x751FC20", Offset = "0x751F020", VA = "0x18751FC20", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FFHFBNIKAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x751EA40", Offset = "0x751DE40", VA = "0x18751EA40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MBIGKIIGFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x751F070", Offset = "0x751E470", VA = "0x18751F070", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CJIAOHLIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x751E900", Offset = "0x751DD00", VA = "0x18751E900", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OENIENNNHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x751EC10", Offset = "0x751E010", VA = "0x18751EC10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GGOLIMBBKAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x751FC70", Offset = "0x751F070", VA = "0x18751FC70", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KANMPHIFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x751E950", Offset = "0x751DD50", VA = "0x18751E950", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> NFCKGOLPLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x751F0C0", Offset = "0x751E4C0", VA = "0x18751F0C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NKBKAOGDOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x751EBC0", Offset = "0x751DFC0", VA = "0x18751EBC0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HHEMMECGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x751E8B0", Offset = "0x751DCB0", VA = "0x18751E8B0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PBPDDCIFHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x751E9A0", Offset = "0x751DDA0", VA = "0x18751E9A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EIIIMHKIBIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x751F120", Offset = "0x751E520", VA = "0x18751F120", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AIOBCJFOKAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x751FBD0", Offset = "0x751EFD0", VA = "0x18751FBD0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CJLEJMIMIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x751F020", Offset = "0x751E420", VA = "0x18751F020", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DOBAKPAGCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x751EA90", Offset = "0x751DE90", VA = "0x18751EA90", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KDFKLOKHDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x751E020", Offset = "0x751D420", VA = "0x18751E020", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FBHHHABKBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x751E430", Offset = "0x751D830", VA = "0x18751E430", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AFJGBPIEPIC<NIGJOKJKKNK> ILBPCKFCAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x751E090", Offset = "0x751D490", VA = "0x18751E090", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x751FCC0", Offset = "0x751F0C0", VA = "0x18751FCC0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3571300", Offset = "0x3570700", VA = "0x183571300", Slot = "6")]
	public (bool, T?) AABHEIALILD<T>(NIGJOKJKKNK IOOMFDFNPLK) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35714F0", Offset = "0x35708F0", VA = "0x1835714F0")]
	public AJIGHCAAJGE DCLBGMBGBMO<T>(NIGJOKJKKNK IOOMFDFNPLK, bool GKABPJFHGEF, T LIHHDPOHLDK) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x751FE90", Offset = "0x751F290", VA = "0x18751FE90")]
	public AJIGHCAAJGE(MJIHINAKBBL ONMGJDKAOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x751FF30", Offset = "0x751F330", VA = "0x18751FF30")]
	public AJIGHCAAJGE(MJIHINAKBBL ONMGJDKAOFK, [Optional] string? OMGBICDKOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x751FEB0", Offset = "0x751F2B0", VA = "0x18751FEB0")]
	public AJIGHCAAJGE(AJIGHCAAJGE OABHKNIMGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x751FF50", Offset = "0x751F350", VA = "0x18751FF50")]
	internal AJIGHCAAJGE(MJIHINAKBBL HIHPEFDFBBM, [Optional] string? OMGBICDKOIP, [Optional] AJIGHCAAJGE? OABHKNIMGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x751EC60", Offset = "0x751E060", VA = "0x18751EC60")]
	public static GELLMGHAHAM GLPOIBEKGKG(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return default(GELLMGHAHAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x751E070", Offset = "0x751D470", VA = "0x18751E070")]
	public void BAAHHGOAOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x751E140", Offset = "0x751D540", VA = "0x18751E140")]
	internal AJIGHCAAJGE BENLJKOHJBD(AJIGHCAAJGE BBLMHMLLBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x751E480", Offset = "0x751D880", VA = "0x18751E480")]
	internal IReadOnlyCollection<NIGJOKJKKNK> CAOLCICLPPL(AJIGHCAAJGE OABHKNIMGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x751EAE0", Offset = "0x751DEE0", VA = "0x18751EAE0")]
	public bool FBKKDALAPCH(NIGJOKJKKNK IOOMFDFNPLK, bool GKABPJFHGEF, string LBKLFIGFBDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x751ED20", Offset = "0x751E120", VA = "0x18751ED20")]
	public (bool, string) HGDCNHMPPEC(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x751FD70", Offset = "0x751F170", VA = "0x18751FD70")]
	internal void OFPMANJBICE(NIGJOKJKKNK IOOMFDFNPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x751EE20", Offset = "0x751E220", VA = "0x18751EE20")]
	public PKKDLOJGGHP HPHLAINDAMP(Func<MJIHINAKBBL, Guid> AIPPDBNAEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x751F250", Offset = "0x751E650", VA = "0x18751F250")]
	public void LIOKJGEJPGK(PKKDLOJGGHP KMFJCBFAIBI, Func<Guid, MJIHINAKBBL> NOJLLLKIALC, [Optional] MJIHINAKBBL? BMJNKGHCAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x751F170", Offset = "0x751E570", VA = "0x18751F170")]
	[CompilerGenerated]
	private void KPMDFIMNCHL(NIGJOKJKKNK BJABLPOOBFM, KGANHNJEHBN KKKJMBFFILJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ANDLIFBLIKB : MCMEFHPKNHM, PLMOIKADBMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EELIBMBFEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AJIGHCAAJGE newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EELIBMBFEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7527740", Offset = "0x7526B40", VA = "0x187527740")]
		internal bool LKNELPGIFMC(AJIGHCAAJGE rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LPEGDBEBGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MJIHINAKBBL roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LPEGDBEBGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7529280", Offset = "0x7528680", VA = "0x187529280")]
		internal bool HLHNIHCDDNH(MJIHINAKBBL r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FGIEHHDPEFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public ANDLIFBLIKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public GBHFJBFIHDK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<JJHEHAGBFBH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7527770", Offset = "0x7526B70", VA = "0x187527770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7527DE0", Offset = "0x75271E0", VA = "0x187527DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FLDCGHKILLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FLDCGHKILLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7527E40", Offset = "0x7527240", VA = "0x187527E40")]
		internal void DJHBOPEOCGI(PKKDLOJGGHP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7527F20", Offset = "0x7527320", VA = "0x187527F20")]
		internal void KFOPIAHCDJO(PKKDLOJGGHP r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct NMKPLDGBODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GBHFJBFIHDK roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KMGIGOFOANE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<PKKDLOJGGHP, KGANHNJEHBN> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KMGIGOFOANE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75291F0", Offset = "0x75285F0", VA = "0x1875291F0")]
		internal void CBFPNHJGOJN(PKKDLOJGGHP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7529250", Offset = "0x7528650", VA = "0x187529250")]
		internal void LAFOBBOOCPL(PKKDLOJGGHP r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7529220", Offset = "0x7528620", VA = "0x187529220")]
		internal void JEFEBAAJANH(PKKDLOJGGHP r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DHFDJOGNJDL<T> where T : notnull
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
			public DHFDJOGNJDL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<JJHEHAGBFBH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3882550", Offset = "0x3881950", VA = "0x183882550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x954FC0", Offset = "0x9543C0", VA = "0x180954FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public NIGJOKJKKNK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MJIHINAKBBL accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public GELLMGHAHAM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public ANDLIFBLIKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DHFDJOGNJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5C2C790", Offset = "0x5C2BB90", VA = "0x185C2C790")]
		[AsyncStateMachine(typeof(DHFDJOGNJDL<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void JFAGNPHNOOF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NJJAEIPKILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<HPDBMLGDMJL> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EEBLOLOLCMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public POFHJJPNHJI rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GBHFJBFIHDK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<MJIHINAKBBL, AJIGHCAAJGE> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public GOLAIFJFJFA debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7526BC0", Offset = "0x7525FC0", VA = "0x187526BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x75276E0", Offset = "0x7526AE0", VA = "0x1875276E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly POFHJJPNHJI HNAKHJLCJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly OMIMBIAHCBC NNLEOCCAOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly GOLAIFJFJFA DPKKJKPNDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, AJIGHCAAJGE> DNMNADMFBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<MJIHINAKBBL, AJIGHCAAJGE> OGEHFKBEJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<MJIHINAKBBL, AJIGHCAAJGE> FHADFFKIJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<AJIGHCAAJGE> GGDKCDKKIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool OJIGNKJKGFE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly NIGJOKJKKNK[] PLHOFFMFOPH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PNHKMPHKCAI GOLKPHNOIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NHKDALKDMHO> BLDHGNOKBCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7525250", Offset = "0x7524650", VA = "0x187525250", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PMKNLPFPGGG LGKOMIBKOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7520240", Offset = "0x751F640", VA = "0x187520240", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7523470", Offset = "0x7522870", VA = "0x187523470", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7524920", Offset = "0x7523D20", VA = "0x187524920")]
	[FHFMOACGLML.FCMFIOLNDJB]
	internal static void MBGCLLCDEMF(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7525810", Offset = "0x7524C10", VA = "0x187525810")]
	[UnityEngine.Scripting.Preserve]
	internal ANDLIFBLIKB([ACGOIOBGIEE(null)] POFHJJPNHJI CAOOHMJECBO, [ACGOIOBGIEE(null)] OMIMBIAHCBC CGDPHLCKHDD, [ACGOIOBGIEE(null)] GOLAIFJFJFA DPKKJKPNDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7522360", Offset = "0x7521760", VA = "0x187522360", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7523510", Offset = "0x7522910", VA = "0x187523510")]
	private void HPMPEHFKHKD(IEnumerable<AJIGHCAAJGE> DDLPCBDCNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75202E0", Offset = "0x751F6E0", VA = "0x1875202E0", Slot = "12")]
	public bool BCNHJBGMDDM(NGDBFKPHNOF PBJBOGHPHPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7524BB0", Offset = "0x7523FB0", VA = "0x187524BB0")]
	private void OANHIHCAAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75225B0", Offset = "0x75219B0", VA = "0x1875225B0")]
	private void EHABIAANPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x75201C0", Offset = "0x751F5C0", VA = "0x1875201C0", Slot = "10")]
	public IReadOnlyList<NHKDALKDMHO> AMMDGCIBCGA(bool BJDMGOOLBHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7522B10", Offset = "0x7521F10", VA = "0x187522B10", Slot = "11")]
	public NHKDALKDMHO FEIBGDKNLIA(NGDBFKPHNOF PBJBOGHPHPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7524AE0", Offset = "0x7523EE0", VA = "0x187524AE0")]
	private MJIHINAKBBL NLPPBPBFEOG(NGDBFKPHNOF PBJBOGHPHPG)
	{
		return default(MJIHINAKBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x75221A0", Offset = "0x75215A0", VA = "0x1875221A0", Slot = "14")]
	public bool CJOFODOBMBH(NGDBFKPHNOF IHKEPHGDAIG, MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x75240C0", Offset = "0x75234C0", VA = "0x1875240C0", Slot = "15")]
	public NHKDALKDMHO JLIGFLLFBDP(MJIHINAKBBL ONMGJDKAOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7525310", Offset = "0x7524710", VA = "0x187525310")]
	private static bool PFHGFGJAMEL(BJBCOHBBPEK NHLOEDEIPDC, MJIHINAKBBL ONMGJDKAOFK, [Out] PKKDLOJGGHP? FFKGGEHNKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7524600", Offset = "0x7523A00", VA = "0x187524600")]
	private static void KLLFNGEJLBM(BJBCOHBBPEK NHLOEDEIPDC, Action<PKKDLOJGGHP> MEMEGGILGPC, MJIHINAKBBL KEANPELHLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7524370", Offset = "0x7523770", VA = "0x187524370")]
	private static void KLLFNGEJLBM(BJBCOHBBPEK NHLOEDEIPDC, Action<PKKDLOJGGHP> MEMEGGILGPC, Predicate<MJIHINAKBBL> BGPHGHKODAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x75252A0", Offset = "0x75246A0", VA = "0x1875252A0")]
	private void PECFGFHEHDL(NGDBFKPHNOF PBJBOGHPHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75200A0", Offset = "0x751F4A0", VA = "0x1875200A0", Slot = "4")]
	[AsyncStateMachine(typeof(FGIEHHDPEFI))]
	public Task ALNBCIDHCGN([CanBeNull] GBHFJBFIHDK CAAMOPOAIJO, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
	public void AJGKGPFHEFO(GBHFJBFIHDK CAAMOPOAIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7524F10", Offset = "0x7524310", VA = "0x187524F10")]
	private void OLIGILCOLLF(BJBCOHBBPEK GHKLBAGKPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75203B0", Offset = "0x751F7B0", VA = "0x1875203B0")]
	internal static string BGJHHBMGKCI(POFHJJPNHJI HNAKHJLCJGC, GBHFJBFIHDK CAAMOPOAIJO, IReadOnlyDictionary<MJIHINAKBBL, AJIGHCAAJGE> OGEHFKBEJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x75206C0", Offset = "0x751FAC0", VA = "0x1875206C0")]
	private static void BMNNNMAGLEH(GBHFJBFIHDK CAAMOPOAIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7524BC0", Offset = "0x7523FC0", VA = "0x187524BC0")]
	private static void OEAPNFJHAPL(BJBCOHBBPEK DKIGEOKCFEO, IReadOnlyDictionary<MJIHINAKBBL, AJIGHCAAJGE> OGEHFKBEJPM, StringBuilder LDJKDFIEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7522C20", Offset = "0x7522020", VA = "0x187522C20")]
	private static bool FGCOEEIMFAG(string BKDOPDJFLIO, [Out] Guid BPKKHEBMBLB, [Out] MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7522D30", Offset = "0x7522130", VA = "0x187522D30")]
	private static void GDNCCGLFNCH(GBHFJBFIHDK CAAMOPOAIJO, StringBuilder LDJKDFIEADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x35764F0", Offset = "0x35758F0", VA = "0x1835764F0", Slot = "16")]
	public bool PLBANJOLAIO<T>(MJIHINAKBBL ONMGJDKAOFK, NIGJOKJKKNK IOOMFDFNPLK, bool GKABPJFHGEF, T MGBFBAKCCAP, [Optional] Action GJFOBIJDKDC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x75219A0", Offset = "0x7520DA0", VA = "0x1875219A0", Slot = "17")]
	public string CJNPBOHLIDN(NIGJOKJKKNK IOOMFDFNPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7524160", Offset = "0x7523560", VA = "0x187524160")]
	private void KIICDEECOKN(MJIHINAKBBL ONMGJDKAOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7522340", Offset = "0x7521740", VA = "0x187522340")]
	private bool DCLDGJBKIAH(NGDBFKPHNOF PBJBOGHPHPG, MJIHINAKBBL ONMGJDKAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7523D80", Offset = "0x7523180", VA = "0x187523D80")]
	internal AJIGHCAAJGE IJHBCCLNBDL(NGDBFKPHNOF PBJBOGHPHPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7522330", Offset = "0x7521730", VA = "0x187522330", Slot = "13")]
	public IReadOnlyList<NHKDALKDMHO> DCCPJLHOCLI(NGDBFKPHNOF PBJBOGHPHPG, bool LCALOKLCAEE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x75246F0", Offset = "0x7523AF0", VA = "0x1875246F0")]
	internal IReadOnlyList<AJIGHCAAJGE> LPJEAEMGAPO(NGDBFKPHNOF PBJBOGHPHPG, bool LCALOKLCAEE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7521A10", Offset = "0x7520E10", VA = "0x187521A10")]
	private void CJOCDJJIEAJ(JJHEHAGBFBH BIDDCACPDPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x75216C0", Offset = "0x7520AC0", VA = "0x1875216C0")]
	private static bool CCEPEBBLLCG(AJIGHCAAJGE BKBADJAEDJF, IReadOnlyDictionary<MJIHINAKBBL, AJIGHCAAJGE> OGEHFKBEJPM, [Out] IReadOnlyList<NIGJOKJKKNK> GKAOAKCOLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7522470", Offset = "0x7521870", VA = "0x187522470")]
	[AsyncStateMachine(typeof(EEBLOLOLCMI))]
	private static Task EFILGKGACEA(POFHJJPNHJI HNAKHJLCJGC, GBHFJBFIHDK CAAMOPOAIJO, IReadOnlyDictionary<MJIHINAKBBL, AJIGHCAAJGE> OGEHFKBEJPM, GOLAIFJFJFA DPKKJKPNDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7521420", Offset = "0x7520820", VA = "0x187521420")]
	[CompilerGenerated]
	internal static void BNGJFKEGNIP(Func<PKKDLOJGGHP, KGANHNJEHBN> MLMPGOMEBIJ, NMKPLDGBODB P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x75227A0", Offset = "0x7521BA0", VA = "0x1875227A0")]
	[CompilerGenerated]
	internal static bool EICFFOIMJJO(MJIHINAKBBL ONMGJDKAOFK, NIGJOKJKKNK IOOMFDFNPLK, [Out] HPDBMLGDMJL MPPIJOEMELH, NJJAEIPKILJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ANLLIFFHPDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIPJLHFFIDF(NGDBFKPHNOF GKOPMCJAOAB, NGDBFKPHNOF FOALLOGOBNK, IEnumerable<NGDBFKPHNOF> DAGCPDEGHEL, [Out] GCBEKIKNGOF JKFBOAELJAP, [Out] CCMCDPBAMLJ JLGNFJOBPNO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KCDPNFFLMHL(CCMCDPBAMLJ DGDDHKBAEJA);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum CCMCDPBAMLJ : byte
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
internal class ICELNGJBIFK : ANLLIFFHPDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly PLMOIKADBMB KJJGGKCLJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly NHPOGHDLMME ELAHECOKGCJ;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ICELNGJBIFK([ACGOIOBGIEE(null)] PLMOIKADBMB JHIAIPDKBHH, [ACGOIOBGIEE(null)] NHPOGHDLMME EAECLBPMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7528040", Offset = "0x7527440", VA = "0x187528040")]
	private static AIKNJHKCMJP? AFDBMIELOGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7528080", Offset = "0x7527480", VA = "0x187528080", Slot = "4")]
	public bool CIPJLHFFIDF(NGDBFKPHNOF GKOPMCJAOAB, NGDBFKPHNOF FOALLOGOBNK, IEnumerable<NGDBFKPHNOF> DAGCPDEGHEL, [Out] GCBEKIKNGOF JKFBOAELJAP, [Out] CCMCDPBAMLJ JLGNFJOBPNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7528790", Offset = "0x7527B90", VA = "0x187528790", Slot = "5")]
	public string KCDPNFFLMHL(CCMCDPBAMLJ DGDDHKBAEJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7528180", Offset = "0x7527580", VA = "0x187528180")]
	internal bool COJIEAKFHNH(NGDBFKPHNOF GKOPMCJAOAB, NGDBFKPHNOF FOALLOGOBNK, IEnumerable<NGDBFKPHNOF> DAGCPDEGHEL, JKIABJFEAHD KKKJMHEOKEA, AIKNJHKCMJP? EBGGALHFONB, [Out] GCBEKIKNGOF JKFBOAELJAP, [Out] CCMCDPBAMLJ JLGNFJOBPNO)
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
