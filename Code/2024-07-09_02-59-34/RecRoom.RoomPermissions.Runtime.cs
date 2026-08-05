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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x70DC1E0", Offset = "0x70DADE0", VA = "0x1870DC1E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OGLHNCJDFCG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void AFIGKDJBIFN<TPermission>(TPermission HOPFMLFBEOD);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void DLIHFOJLABF(MLFBKPIOFCD OCPDBKCKFCD);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BJPJLBPMHKA
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LHIJFFJEFAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GPNIKJHFFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PIDGBCKDNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BCCICJKKKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JCEHPFLDMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EAFOKPLMGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NMHODHJCGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class HOGAHEEEIKE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum BLDNKCLAAPO
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
	public static readonly Guid FBINCAGPLIH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NHAMFEMNMKN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid BCLLLPCAPNH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid LGGDPNMDICL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid EKDCBKFAMFN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid CLFFGNIKLFH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FMJOKBECEHL<CDDOIGKGONH, Guid> JNIJDNCDCID;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<CDDOIGKGONH> BAGJDDHNFPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70D0440", Offset = "0x70CF040", VA = "0x1870D0440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70D0190", Offset = "0x70CED90", VA = "0x1870D0190")]
	public static CDDOIGKGONH ECOBFDPFLEJ(Guid GBCIBJHFOHP)
	{
		return default(CDDOIGKGONH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70D02B0", Offset = "0x70CEEB0", VA = "0x1870D02B0")]
	public static Guid FDMDNMKFJKM(CDDOIGKGONH MEBAECNIKKO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70D0220", Offset = "0x70CEE20", VA = "0x1870D0220")]
	public static bool EEHJMDNBHGE(CDDOIGKGONH MEBAECNIKKO, [Out] Guid GBCIBJHFOHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70D04C0", Offset = "0x70CF0C0", VA = "0x1870D04C0")]
	public static bool PPPPICAALNE(Guid GBCIBJHFOHP, [Out] CDDOIGKGONH MEBAECNIKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70D0350", Offset = "0x70CEF50", VA = "0x1870D0350")]
	public static CDDOIGKGONH GKHNKDDJFEA(CDDOIGKGONH MEBAECNIKKO)
	{
		return default(CDDOIGKGONH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70D0390", Offset = "0x70CEF90", VA = "0x1870D0390")]
	public static BLDNKCLAAPO MOLBEFGNDNJ(CDDOIGKGONH EDHFIJLJKOH)
	{
		return default(BLDNKCLAAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70D0150", Offset = "0x70CED50", VA = "0x1870D0150")]
	internal static CDDOIGKGONH DAKHDHJEJNJ(BLDNKCLAAPO IKPJCFNGGHM)
	{
		return default(CDDOIGKGONH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CLMKIBMGPFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PHOMJDPLOAI OMHGKIHNMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<PDHMJHHKDDF> KELMGBJIHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DLIHFOJLABF LNLCOIJKJKN;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<PDHMJHHKDDF> ONKHKLCMAOG(bool PLDENPDAEBM = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PDHMJHHKDDF PNDOPDBLCAB(MLFBKPIOFCD OCPDBKCKFCD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HOLIPDLDAKD(MLFBKPIOFCD OCPDBKCKFCD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<PDHMJHHKDDF> MEKPBAADOEL(MLFBKPIOFCD OCPDBKCKFCD, bool EHHJEAJAEDH = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NFIPIMJBECA(MLFBKPIOFCD PIEDLOCPLIN, CDDOIGKGONH MEBAECNIKKO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PDHMJHHKDDF OLNENHMDCLG(CDDOIGKGONH MEBAECNIKKO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IJCJOGIAKAL<T>(CDDOIGKGONH MEBAECNIKKO, OBLPLKJADCP HOPFMLFBEOD, bool GELMLLCMOPL, T OKLJLMJMKDA, [Optional] Action LHGEGKFLMIA) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NNCCKAGFGPE(OBLPLKJADCP HOPFMLFBEOD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HKEKKJDOCBL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LIGGJHIINEI(KDDAPCIFEMM ABJNEIDNHBL, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EENBNMFFNOG(KDDAPCIFEMM ABJNEIDNHBL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GNPBGAGJEEK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	MLFBKPIOFCD CJDPMHBENLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MEEJEPKLPKH PDMBNHKFHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PFJIJEDBGEL LBHKNFDHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BDBMCBNBJHH> LOGNMLEALOE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action IDNGDBMJHMJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CDDOIGKGONH OGMIJDDKCOI(MLFBKPIOFCD OCPDBKCKFCD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BDBMCBNBJHH> AGKIPDKLCMB(CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task FPLCCADCJNP(long ACIHEOIHPAO, IReadOnlyList<MAHLDODDCIC> JFCLBFKPECE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FCHGOMKHJOL(long ACIHEOIHPAO, long GPDLAAEANOD, IReadOnlyList<MAHLDODDCIC> JFCLBFKPECE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<MLFBKPIOFCD> JGCKACFCPOI();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NMMCJLHEPCM
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70DC180", Offset = "0x70DAD80", VA = "0x1870DC180")]
	public static CDDOIGKGONH KLFMCGBAEDN(this GNPBGAGJEEK AGPGMOOLCKG)
	{
		return default(CDDOIGKGONH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PKMAOIPHONH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string GHIMENNMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event AFIGKDJBIFN<TPermission> BAIDHOMLPEC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class LFFIPJGMNIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? OBICJPCLHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	protected LFFIPJGMNIN(object? JMIEICIBCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FIINAHLFLGM(object? IIPLJLPCLBC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class NLIJPHOKAEH<T> : LFFIPJGMNIN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T EAIDGOEODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> DMKIEMJDBGM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x933850", Offset = "0x932450", VA = "0x180933850")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x452BFA0", Offset = "0x452ABA0", VA = "0x18452BFA0", Slot = "4")]
	public override bool FIINAHLFLGM(object? IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x452BB20", Offset = "0x452A720", VA = "0x18452BB20")]
	public bool ACFNLKLHMPF(T JLODNLENGMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x452C110", Offset = "0x452AD10", VA = "0x18452C110")]
	public NLIJPHOKAEH(T APDNGABBFBA, IEqualityComparer<T> DMKIEMJDBGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class IPCDCIJAFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OBLPLKJADCP, bool> EECBCIHNMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<OBLPLKJADCP, LFFIPJGMNIN> ILEAIMIMFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly MPPGCPGBCGD KDPIDMFJEOA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70D3FB0", Offset = "0x70D2BB0", VA = "0x1870D3FB0")]
	public IPCDCIJAFLC(MPPGCPGBCGD KDPIDMFJEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70D3BB0", Offset = "0x70D27B0", VA = "0x1870D3BB0")]
	public bool DFPOGMHJAMG(OBLPLKJADCP HOPFMLFBEOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B87C10", Offset = "0x2B86810", VA = "0x182B87C10")]
	public bool PNDLOOBHPLC<T>(OBLPLKJADCP HOPFMLFBEOD, bool GELMLLCMOPL, T IIPLJLPCLBC) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2B87780", Offset = "0x2B86380", VA = "0x182B87780")]
	public (bool, T?) MJAINAMPFEJ<T>(OBLPLKJADCP HOPFMLFBEOD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70D3ED0", Offset = "0x70D2AD0", VA = "0x1870D3ED0")]
	public bool PNDLOOBHPLC(OBLPLKJADCP HOPFMLFBEOD, bool GELMLLCMOPL, object IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70D3C20", Offset = "0x70D2820", VA = "0x1870D3C20")]
	public (bool, object) MJAINAMPFEJ(OBLPLKJADCP HOPFMLFBEOD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B87720", Offset = "0x2B86320", VA = "0x182B87720")]
	private void DELIFMHGLHB<T>(OBLPLKJADCP HOPFMLFBEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70D3AE0", Offset = "0x70D26E0", VA = "0x1870D3AE0")]
	private LFFIPJGMNIN CGEDINHNDOK(OBLPLKJADCP HOPFMLFBEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70D3CF0", Offset = "0x70D28F0", VA = "0x1870D3CF0")]
	public void NHKNIIOFPBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class PMGHHCIBCKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string NGJMKJKOLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type IOINPCMAPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ILHFOLMAOOC DMAOAJGNGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly OBLPLKJADCP OIMKIKHKPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JOABCICHMOL AIMNLLOFIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PBFDKAFEMBF IAALCPFHPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public LGAHLGMMOIO CCMNGEKOEPO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x70DC6A0", Offset = "0x70DB2A0", VA = "0x1870DC6A0")]
	public PMGHHCIBCKL(Type BEDMDOPMGEA, string CPEMDJPLCHA, OBLPLKJADCP HOPFMLFBEOD, JOABCICHMOL NGFOHGOMBHB, PBFDKAFEMBF FIDJMMLFLED, LGAHLGMMOIO LNLJALLFCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70DC650", Offset = "0x70DB250", VA = "0x1870DC650")]
	public object IALBBOMAODD(object? HEIGABGMPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2CE90D0", Offset = "0x2CE7CD0", VA = "0x182CE90D0")]
	public void DELIFMHGLHB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70DC5A0", Offset = "0x70DB1A0", VA = "0x1870DC5A0")]
	public void DELIFMHGLHB(Type PLJEGEIHGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KOIHMFBMBJJ<T> : PMGHHCIBCKL where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string DGDANOFGLEN(T IIPLJLPCLBC);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T HAKMKGKFBEM(string? GCIJDIGEKLB, T APDNGABBFBA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CEOIEMMHEGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DGDANOFGLEN serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public HAKMKGKFBEM parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CEOIEMMHEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5575E80", Offset = "0x5574A80", VA = "0x185575E80")]
		internal string DOBNEHIALON(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5576010", Offset = "0x5574C10", VA = "0x185576010")]
		internal object JFEJINMILAB(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41D1CB0", Offset = "0x41D08B0", VA = "0x1841D1CB0")]
	public KOIHMFBMBJJ(OBLPLKJADCP HOPFMLFBEOD, string CPEMDJPLCHA, [Optional] DGDANOFGLEN? NGFOHGOMBHB, [Optional] HAKMKGKFBEM? FIDJMMLFLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41D0FD0", Offset = "0x41CFBD0", VA = "0x1841D0FD0")]
	private static object? GCPIDJEBGBI(HAKMKGKFBEM? FIDJMMLFLED, string? GCIJDIGEKLB, object? APDNGABBFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41D0A30", Offset = "0x41CF630", VA = "0x1841D0A30")]
	private static string CJJBNJOFCID(DGDANOFGLEN? GONLOJMKMLP, object? IIPLJLPCLBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string JOABCICHMOL(object? IIPLJLPCLBC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object PBFDKAFEMBF(string? GCIJDIGEKLB, [Optional] object APDNGABBFBA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate LFFIPJGMNIN LGAHLGMMOIO();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MPPGCPGBCGD
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OBLIJKAEKLG : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static OBLIJKAEKLG NKKNEDDGFMP;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70DC260", Offset = "0x70DAE60", VA = "0x1870DC260", Slot = "4")]
		public bool Equals(List<string> KIGIELEFAKI, List<string> DKINGMIONNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x70DC3B0", Offset = "0x70DAFB0", VA = "0x1870DC3B0", Slot = "5")]
		public int GetHashCode(List<string> APKAFMDACKK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public OBLIJKAEKLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LAIBAKOIMHJ : LKMLJNKEHFB<OGLHNCJDFCG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x70D4430", Offset = "0x70D3030", VA = "0x1870D4430", Slot = "9")]
		public override string CJJBNJOFCID(OGLHNCJDFCG NGMMAKENIFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70D4260", Offset = "0x70D2E60", VA = "0x1870D4260", Slot = "10")]
		protected override bool BGAJMHDMGHD(string NGMMAKENIFG, [Out] OGLHNCJDFCG IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70D4520", Offset = "0x70D3120", VA = "0x1870D4520")]
		public LAIBAKOIMHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly OIJLIMOFNED LPJNHLMNEJF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly LAIBAKOIMHJ LMDMKDJPJJA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<PMGHHCIBCKL> BIFIMPLGLPP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OBLPLKJADCP> IKLAHNACLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OBLPLKJADCP, PMGHHCIBCKL> GMIEDACAMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70D6360", Offset = "0x70D4F60", VA = "0x1870D6360")]
	public MPPGCPGBCGD([Optional] IList<PMGHHCIBCKL>? NCAFNACDLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70D4E40", Offset = "0x70D3A40", VA = "0x1870D4E40")]
	public PMGHHCIBCKL JKLBPIHLEEI(OBLPLKJADCP HOPFMLFBEOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PHOMJDPLOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PDHMJHHKDDF JIDFFPAPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HMLGHKDOIDE : PHOMJDPLOAI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static HMLGHKDOIDE GAKLFCEAIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IKAIADPOOCL NAGPDALOLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<IKAIADPOOCL> MLIKBMAAKJO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PDHMJHHKDDF JIDFFPAPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70D0040", Offset = "0x70CEC40", VA = "0x1870D0040")]
	public HMLGHKDOIDE(IKAIADPOOCL GIAAEGMGMBE, IReadOnlyList<IKAIADPOOCL> APDNDDLKCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70CF1F0", Offset = "0x70CDDF0", VA = "0x1870CF1F0")]
	private static HMLGHKDOIDE GPBOKGDEPDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HOJJLAANMIE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<CDDOIGKGONH> DMEPDFPHPBL;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70D0880", Offset = "0x70CF480", VA = "0x1870D0880")]
	public static bool JCGBICNGCND(this MLFBKPIOFCD FNNNADILIEG, CDDOIGKGONH MEBAECNIKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70D0960", Offset = "0x70CF560", VA = "0x1870D0960")]
	public static bool JHNDCFCHJBA(this MLFBKPIOFCD FNNNADILIEG, CDDOIGKGONH MEBAECNIKKO, PFJIJEDBGEL DBGEDMHOIDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MAFBHAODEGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JFGGILMFIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool ADAMNABGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DBAMHHIDELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EHONLADPBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LJPFMBAKGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BPDDAIENNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PGAAAAAHAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CNJDKBHOIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NCIIKGOGHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ENABHMCHFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LADAONPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JDEALAHMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GFJMOLCKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OGLHNCJDFCG MAHLGIBGBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PDHMJHHKDDF : MAFBHAODEGJ, LHIJFFJEFAB, PKMAOIPHONH<OBLPLKJADCP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KFGCELBOKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CDDOIGKGONH POHFBPGCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JIBOCOMLAAO<T>(OBLPLKJADCP HOPFMLFBEOD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OBLPLKJADCP
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
internal class IKAIADPOOCL : PDHMJHHKDDF, MAFBHAODEGJ, LHIJFFJEFAB, PKMAOIPHONH<OBLPLKJADCP>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly MPPGCPGBCGD CCFBAOIDJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly IPCDCIJAFLC GAJGIBCGENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? NKJDPEDBEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? MEIBKPGALNH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool KIKDDOGEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70D0E40", Offset = "0x70CFA40", VA = "0x1870D0E40", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool AMHMHBNJIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x70D29B0", Offset = "0x70D15B0", VA = "0x1870D29B0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool CJNNOMENINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x70D1020", Offset = "0x70CFC20", VA = "0x1870D1020", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool MEHHAOGCLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70D1750", Offset = "0x70D0350", VA = "0x1870D1750", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool HNAFDLIHFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x70D23A0", Offset = "0x70D0FA0", VA = "0x1870D23A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool PBBFEEEIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x70D0FD0", Offset = "0x70CFBD0", VA = "0x1870D0FD0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public CDDOIGKGONH POHFBPGCDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x933850", Offset = "0x932450", VA = "0x180933850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(CDDOIGKGONH);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x873D60", Offset = "0x872960", VA = "0x180873D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string GHIMENNMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x70D11B0", Offset = "0x70CFDB0", VA = "0x1870D11B0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x70D17A0", Offset = "0x70D03A0", VA = "0x1870D17A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string KFGCELBOKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x70D11B0", Offset = "0x70CFDB0", VA = "0x1870D11B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool BDCAMGAAHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F38E0", Offset = "0x9F24E0", VA = "0x1809F38E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FC0", Offset = "0x9F1BC0", VA = "0x1809F2FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JFGGILMFIJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x70D1070", Offset = "0x70CFC70", VA = "0x1870D1070", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OGLHNCJDFCG MAHLGIBGBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x70D1200", Offset = "0x70CFE00", VA = "0x1870D1200", Slot = "20")]
		get
		{
			return default(OGLHNCJDFCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ADAMNABGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x70D23F0", Offset = "0x70D0FF0", VA = "0x1870D23F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DBAMHHIDELI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x70D1160", Offset = "0x70CFD60", VA = "0x1870D1160", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EHONLADPBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x70D2350", Offset = "0x70D0F50", VA = "0x1870D2350", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LJPFMBAKGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x70D0F30", Offset = "0x70CFB30", VA = "0x1870D0F30", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BPDDAIENNNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x70D2440", Offset = "0x70D1040", VA = "0x1870D2440", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PGAAAAAHAAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70D10C0", Offset = "0x70CFCC0", VA = "0x1870D10C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CNJDKBHOIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70D2A00", Offset = "0x70D1600", VA = "0x1870D2A00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool NCIIKGOGHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x70D0E90", Offset = "0x70CFA90", VA = "0x1870D0E90", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GFJMOLCKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70D2C50", Offset = "0x70D1850", VA = "0x1870D2C50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CGIDBNIHMPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70D0E40", Offset = "0x70CFA40", VA = "0x1870D0E40", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool NBPLILOGMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70D23A0", Offset = "0x70D0FA0", VA = "0x1870D23A0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BHLCJOFBMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70D29B0", Offset = "0x70D15B0", VA = "0x1870D29B0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ENABHMCHFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70D1110", Offset = "0x70CFD10", VA = "0x1870D1110", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LADAONPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70D2960", Offset = "0x70D1560", VA = "0x1870D2960", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OFKCOHNCHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x70D1020", Offset = "0x70CFC20", VA = "0x1870D1020", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JDEALAHMIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x70D0F80", Offset = "0x70CFB80", VA = "0x1870D0F80", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CNCFBJJJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70D1750", Offset = "0x70D0350", VA = "0x1870D1750", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NHIGEBOKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70D0FD0", Offset = "0x70CFBD0", VA = "0x1870D0FD0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AFIGKDJBIFN<OBLPLKJADCP> BAIDHOMLPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x70D0D90", Offset = "0x70CF990", VA = "0x1870D0D90", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x70D2490", Offset = "0x70D1090", VA = "0x1870D2490", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D8F0", Offset = "0x2B7C4F0", VA = "0x182B7D8F0", Slot = "6")]
	public (bool, T?) JIBOCOMLAAO<T>(OBLPLKJADCP HOPFMLFBEOD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D890", Offset = "0x2B7C490", VA = "0x182B7D890")]
	public IKAIADPOOCL EBIGKNJFCEB<T>(OBLPLKJADCP HOPFMLFBEOD, bool GELMLLCMOPL, T IIPLJLPCLBC) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70D2F50", Offset = "0x70D1B50", VA = "0x1870D2F50")]
	public IKAIADPOOCL(CDDOIGKGONH MEBAECNIKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70D2D40", Offset = "0x70D1940", VA = "0x1870D2D40")]
	public IKAIADPOOCL(CDDOIGKGONH MEBAECNIKKO, [Optional] string? NKJDPEDBEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70D2D60", Offset = "0x70D1960", VA = "0x1870D2D60")]
	public IKAIADPOOCL(IKAIADPOOCL OPCKCJKMFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x70D2DF0", Offset = "0x70D19F0", VA = "0x1870D2DF0")]
	internal IKAIADPOOCL(CDDOIGKGONH BMEKOIALGBO, [Optional] string? NKJDPEDBEBM, [Optional] IKAIADPOOCL? OPCKCJKMFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x70D28C0", Offset = "0x70D14C0", VA = "0x1870D28C0")]
	public static ILHFOLMAOOC LDKMJIMDFPF(OBLPLKJADCP HOPFMLFBEOD)
	{
		return default(ILHFOLMAOOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x70D2940", Offset = "0x70D1540", VA = "0x1870D2940")]
	public void NHKNIIOFPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70D2540", Offset = "0x70D1140", VA = "0x1870D2540")]
	internal IKAIADPOOCL KPHHNBJAFMF(IKAIADPOOCL DOEHEOPLEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70D1250", Offset = "0x70CFE50", VA = "0x1870D1250")]
	internal IReadOnlyCollection<OBLPLKJADCP> FEPLHPFJIDG(IKAIADPOOCL OPCKCJKMFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x70D17F0", Offset = "0x70D03F0", VA = "0x1870D17F0")]
	public bool HCGHMPKGIEN(OBLPLKJADCP HOPFMLFBEOD, bool GELMLLCMOPL, string EMBLHFMACLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70D18D0", Offset = "0x70D04D0", VA = "0x1870D18D0")]
	public (bool, string) HPFMBBOAMOH(OBLPLKJADCP HOPFMLFBEOD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x70D0EE0", Offset = "0x70CFAE0", VA = "0x1870D0EE0")]
	internal void AMLNIPMGMGJ(OBLPLKJADCP HOPFMLFBEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x70D2A50", Offset = "0x70D1650", VA = "0x1870D2A50")]
	public LGNPGLINBKL ONIHHFFAONC(Func<CDDOIGKGONH, Guid> LBOPHFFCCDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x70D19D0", Offset = "0x70D05D0", VA = "0x1870D19D0")]
	public void JBOFLEHCNOE(LGNPGLINBKL EMAKGAJGIHA, Func<Guid, CDDOIGKGONH> CILHCBOKOPC, [Optional] CDDOIGKGONH? MGCLMLFNAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x70D16C0", Offset = "0x70D02C0", VA = "0x1870D16C0")]
	[CompilerGenerated]
	private void FIFEFCPDPKO(OBLPLKJADCP JOCIMGNNEGI, AGIMKMJNGFG POKMFMEMNBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NFKNNDEDGPL : HKEKKJDOCBL, CLMKIBMGPFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class EDONNNPFPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IKAIADPOOCL newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public EDONNNPFPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x70CF1C0", Offset = "0x70CDDC0", VA = "0x1870CF1C0")]
		internal bool FCCLCLGOMJB(IKAIADPOOCL rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JNEPICPFBDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public CDDOIGKGONH roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public JNEPICPFBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x70D4250", Offset = "0x70D2E50", VA = "0x1870D4250")]
		internal bool CFILPODIDNI(CDDOIGKGONH r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PPEAHFLCIEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NFKNNDEDGPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public KDDAPCIFEMM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<BDBMCBNBJHH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70DC740", Offset = "0x70DB340", VA = "0x1870DC740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70DCDB0", Offset = "0x70DB9B0", VA = "0x1870DCDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IGIHGBBGHFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public IGIHGBBGHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x70D0CB0", Offset = "0x70CF8B0", VA = "0x1870D0CB0")]
		internal void FFJDLIBEEND(LGNPGLINBKL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x70D0B90", Offset = "0x70CF790", VA = "0x1870D0B90")]
		internal void DGCHOHJAKNP(LGNPGLINBKL r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EGLAJMKEOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KDDAPCIFEMM roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LHOOIDOPJON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<LGNPGLINBKL, AGIMKMJNGFG> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public LHOOIDOPJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x70D4560", Offset = "0x70D3160", VA = "0x1870D4560")]
		internal void DJGJPKJDMLA(LGNPGLINBKL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x70D45C0", Offset = "0x70D31C0", VA = "0x1870D45C0")]
		internal void IGAOOGABKPP(LGNPGLINBKL r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x70D4590", Offset = "0x70D3190", VA = "0x1870D4590")]
		internal void FNELKJAJKNA(LGNPGLINBKL r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GOLGGFENFCB<T> where T : notnull
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
			public GOLGGFENFCB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<BDBMCBNBJHH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3574FC0", Offset = "0x3573BC0", VA = "0x183574FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA03250", Offset = "0xA01E50", VA = "0x180A03250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public OBLPLKJADCP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public CDDOIGKGONH accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ILHFOLMAOOC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public NFKNNDEDGPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public GOLGGFENFCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3D7FEE0", Offset = "0x3D7EAE0", VA = "0x183D7FEE0")]
		[AsyncStateMachine(typeof(GOLGGFENFCB<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HAAKHDGMEIE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DCOAADBBOEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<MAHLDODDCIC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct INCIEIDIPPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public GNPBGAGJEEK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public KDDAPCIFEMM roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<CDDOIGKGONH, IKAIADPOOCL> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public HLJCFCHLOHC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x70D2F70", Offset = "0x70D1B70", VA = "0x1870D2F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x70D3A80", Offset = "0x70D2680", VA = "0x1870D3A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GNPBGAGJEEK AGPGMOOLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly HMLGHKDOIDE MDGELFCAGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly HLJCFCHLOHC IEHMKNPHDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, IKAIADPOOCL> IODPALGGGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<CDDOIGKGONH, IKAIADPOOCL> PHANJCBPLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<CDDOIGKGONH, IKAIADPOOCL> IHBCFFLPAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<IKAIADPOOCL> DKHGKHLPEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool FMFFEDDKHOO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly OBLPLKJADCP[] LNNODOCAENB;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PHOMJDPLOAI OMHGKIHNMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<PDHMJHHKDDF> KELMGBJIHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x70DA120", Offset = "0x70D8D20", VA = "0x1870DA120", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DLIHFOJLABF LNLCOIJKJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x70D80F0", Offset = "0x70D6CF0", VA = "0x1870D80F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x70D73E0", Offset = "0x70D5FE0", VA = "0x1870D73E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x70DB5D0", Offset = "0x70DA1D0", VA = "0x1870DB5D0")]
	[DHOHFCLMOGD(OBGPNJNCONH.Room, IDHBAGABJJA.None)]
	private static void NOFLNPHPAAG(IMEOEBHKJNP DAOJEFNFNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x70DBEC0", Offset = "0x70DAAC0", VA = "0x1870DBEC0")]
	[UnityEngine.Scripting.Preserve]
	internal NFKNNDEDGPL([POJODGKFIMO(null)] GNPBGAGJEEK ENBCCBKINJD, [POJODGKFIMO(null)] HMLGHKDOIDE CEONADGLPMA, [POJODGKFIMO(null)] HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x70D7F10", Offset = "0x70D6B10", VA = "0x1870D7F10", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x70DACF0", Offset = "0x70D98F0", VA = "0x1870DACF0")]
	private void NKOPDPPMOIO(IEnumerable<IKAIADPOOCL> OBCPAEJGODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x70DA050", Offset = "0x70D8C50", VA = "0x1870DA050", Slot = "12")]
	public bool HOLIPDLDAKD(MLFBKPIOFCD OCPDBKCKFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x70DA170", Offset = "0x70D8D70", VA = "0x1870DA170")]
	private void IDNGDBMJHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x70DA180", Offset = "0x70D8D80", VA = "0x1870DA180")]
	private void IOENLKEBGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x70DB830", Offset = "0x70DA430", VA = "0x1870DB830", Slot = "10")]
	public IReadOnlyList<PDHMJHHKDDF> ONKHKLCMAOG(bool PLDENPDAEBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x70DBBE0", Offset = "0x70DA7E0", VA = "0x1870DBBE0", Slot = "11")]
	public PDHMJHHKDDF PNDOPDBLCAB(MLFBKPIOFCD OCPDBKCKFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x70D8020", Offset = "0x70D6C20", VA = "0x1870D8020")]
	private CDDOIGKGONH EPAMDFCAEML(MLFBKPIOFCD OCPDBKCKFCD)
	{
		return default(CDDOIGKGONH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x70DAB60", Offset = "0x70D9760", VA = "0x1870DAB60", Slot = "14")]
	public bool NFIPIMJBECA(MLFBKPIOFCD PIEDLOCPLIN, CDDOIGKGONH MEBAECNIKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x70DB790", Offset = "0x70DA390", VA = "0x1870DB790", Slot = "15")]
	public PDHMJHHKDDF OLNENHMDCLG(CDDOIGKGONH MEBAECNIKKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x70DB8B0", Offset = "0x70DA4B0", VA = "0x1870DB8B0")]
	private static bool PIHJNLDMJMP(FJEEENLMEPH OEJALJMPCIO, CDDOIGKGONH MEBAECNIKKO, [Out] LGNPGLINBKL? PEIBLAHJHNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x70DAA70", Offset = "0x70D9670", VA = "0x1870DAA70")]
	private static void MMJMDIBPDDC(FJEEENLMEPH OEJALJMPCIO, Action<LGNPGLINBKL> GLMCLLCJGOL, CDDOIGKGONH GBEJNMEGHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x70DA7E0", Offset = "0x70D93E0", VA = "0x1870DA7E0")]
	private static void MMJMDIBPDDC(FJEEENLMEPH OEJALJMPCIO, Action<LGNPGLINBKL> GLMCLLCJGOL, Predicate<CDDOIGKGONH> AHNAMEDMHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x70D6DF0", Offset = "0x70D59F0", VA = "0x1870D6DF0")]
	private void AGKMEBNLFEJ(MLFBKPIOFCD OCPDBKCKFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x70DA6B0", Offset = "0x70D92B0", VA = "0x1870DA6B0", Slot = "4")]
	[AsyncStateMachine(typeof(PPEAHFLCIEL))]
	public Task LIGGJHIINEI([CanBeNull] KDDAPCIFEMM ABJNEIDNHBL, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
	public void EENBNMFFNOG(KDDAPCIFEMM ABJNEIDNHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x70D7BD0", Offset = "0x70D67D0", VA = "0x1870D7BD0")]
	private void DHIDDHDPPIH(FJEEENLMEPH OODDAOLKOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x70D9D40", Offset = "0x70D8940", VA = "0x1870D9D40")]
	internal static string HBNIGCBBLIA(GNPBGAGJEEK AGPGMOOLCKG, KDDAPCIFEMM ABJNEIDNHBL, IReadOnlyDictionary<CDDOIGKGONH, IKAIADPOOCL> PHANJCBPLNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x70D8A30", Offset = "0x70D7630", VA = "0x1870D8A30")]
	private static void GDNOLDCICNI(KDDAPCIFEMM ABJNEIDNHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x70DA360", Offset = "0x70D8F60", VA = "0x1870DA360")]
	private static void JMELMJPAPCO(FJEEENLMEPH GLGICDDFPOG, IReadOnlyDictionary<CDDOIGKGONH, IKAIADPOOCL> PHANJCBPLNK, StringBuilder DMFPBDJPKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x70D8190", Offset = "0x70D6D90", VA = "0x1870D8190")]
	private static bool GACDIJFCIAG(string PDGFKAMPKHO, [Out] Guid JDBNENCAOKH, [Out] CDDOIGKGONH MEBAECNIKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x70D66B0", Offset = "0x70D52B0", VA = "0x1870D66B0")]
	private static void AFKNDECBNJB(KDDAPCIFEMM ABJNEIDNHBL, StringBuilder DMFPBDJPKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2CA6630", Offset = "0x2CA5230", VA = "0x182CA6630", Slot = "16")]
	public bool IJCJOGIAKAL<T>(CDDOIGKGONH MEBAECNIKKO, OBLPLKJADCP HOPFMLFBEOD, bool GELMLLCMOPL, T OKLJLMJMKDA, [Optional] Action LHGEGKFLMIA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x70DB550", Offset = "0x70DA150", VA = "0x1870DB550", Slot = "17")]
	public string NNCCKAGFGPE(OBLPLKJADCP HOPFMLFBEOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x70D9860", Offset = "0x70D8460", VA = "0x1870D9860")]
	private void GIJKGJNIBDH(CDDOIGKGONH MEBAECNIKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x70D6E60", Offset = "0x70D5A60", VA = "0x1870D6E60")]
	private bool ALKJPNPBBAG(MLFBKPIOFCD OCPDBKCKFCD, CDDOIGKGONH MEBAECNIKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x70D70B0", Offset = "0x70D5CB0", VA = "0x1870D70B0")]
	internal IKAIADPOOCL BOAGPKFJHOE(MLFBKPIOFCD OCPDBKCKFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x70DA7D0", Offset = "0x70D93D0", VA = "0x1870DA7D0", Slot = "13")]
	public IReadOnlyList<PDHMJHHKDDF> MEKPBAADOEL(MLFBKPIOFCD OCPDBKCKFCD, bool EHHJEAJAEDH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x70D6E80", Offset = "0x70D5A80", VA = "0x1870D6E80")]
	internal IReadOnlyList<IKAIADPOOCL> BEMMKHKPACE(MLFBKPIOFCD OCPDBKCKFCD, bool EHHJEAJAEDH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x70D82A0", Offset = "0x70D6EA0", VA = "0x1870D82A0")]
	private void GCMHBHABJNN(BDBMCBNBJHH EDGIFGJGCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x70D9A60", Offset = "0x70D8660", VA = "0x1870D9A60")]
	private static bool GIJMIHHCMGD(IKAIADPOOCL HLGPOEGFHBL, IReadOnlyDictionary<CDDOIGKGONH, IKAIADPOOCL> PHANJCBPLNK, [Out] IReadOnlyList<OBLPLKJADCP> EEKKAKAOIMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x70D7480", Offset = "0x70D6080", VA = "0x1870D7480")]
	[AsyncStateMachine(typeof(INCIEIDIPPD))]
	private static Task CLLFIFIIFEC(GNPBGAGJEEK AGPGMOOLCKG, KDDAPCIFEMM ABJNEIDNHBL, IReadOnlyDictionary<CDDOIGKGONH, IKAIADPOOCL> PHANJCBPLNK, HLJCFCHLOHC IEHMKNPHDEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x70D7930", Offset = "0x70D6530", VA = "0x1870D7930")]
	[CompilerGenerated]
	internal static void DDLEDEIANCL(Func<LGNPGLINBKL, AGIMKMJNGFG> PPDBFNGFGFN, EGLAJMKEOMH P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x70D75C0", Offset = "0x70D61C0", VA = "0x1870D75C0")]
	[CompilerGenerated]
	internal static bool DCGOILDJHBH(CDDOIGKGONH MEBAECNIKKO, OBLPLKJADCP HOPFMLFBEOD, [Out] MAHLDODDCIC DDOEFJACJFO, DCOAADBBOEC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface COKGHAELKCB
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLMFCKNHJPN(MLFBKPIOFCD OKGJPCOMMKB, MLFBKPIOFCD LELPGNGGCBJ, IEnumerable<MLFBKPIOFCD> CBKKCNDONEA, [Out] OGLHNCJDFCG MCPMGOMECHD, [Out] KMHJBGFOGMJ CEDJPAPLGEL);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CFDDDBNPCOD(KMHJBGFOGMJ CKHGGPPOLHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum KMHJBGFOGMJ : byte
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
internal class MLBNHEPILKL : COKGHAELKCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CLMKIBMGPFP BBIPPGAPOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly FJJOFJGDEEG ANHLEELFNIL;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x872290", Offset = "0x870E90", VA = "0x180872290")]
	[RecRoom.NoEngine.Common.Preserve]
	public MLBNHEPILKL([POJODGKFIMO(null)] CLMKIBMGPFP MCNOOKMPMGG, [POJODGKFIMO(null)] FJJOFJGDEEG EAOEHKACBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x70D46F0", Offset = "0x70D32F0", VA = "0x1870D46F0")]
	private static NHFEFLJCGCO? NIOINLNNLML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x70D4D40", Offset = "0x70D3940", VA = "0x1870D4D40", Slot = "4")]
	public bool OLMFCKNHJPN(MLFBKPIOFCD OKGJPCOMMKB, MLFBKPIOFCD LELPGNGGCBJ, IEnumerable<MLFBKPIOFCD> CBKKCNDONEA, [Out] OGLHNCJDFCG MCPMGOMECHD, [Out] KMHJBGFOGMJ CEDJPAPLGEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70D45F0", Offset = "0x70D31F0", VA = "0x1870D45F0", Slot = "5")]
	public string CFDDDBNPCOD(KMHJBGFOGMJ CKHGGPPOLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70D4730", Offset = "0x70D3330", VA = "0x1870D4730")]
	internal bool OBEMBBIDPFC(MLFBKPIOFCD OKGJPCOMMKB, MLFBKPIOFCD LELPGNGGCBJ, IEnumerable<MLFBKPIOFCD> CBKKCNDONEA, PFJIJEDBGEL DBGEDMHOIDK, NHFEFLJCGCO? EJLPEKELJAJ, [Out] OGLHNCJDFCG MCPMGOMECHD, [Out] KMHJBGFOGMJ CEDJPAPLGEL)
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
