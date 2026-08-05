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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6872D90", Offset = "0x6871F90", VA = "0x186872D90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DLHMBJNHGIB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GPMJDPJONKP<TPermission>(TPermission CMFLEFGKNDP);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NMBPPJGFFAL(EOBANJCDGLI DBPHBPCOBKD);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KIOBIMKPFJB
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DBPOAJICNFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCNGIAEHNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LOEIFEJPCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KKJPAECIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MBHLKNBIFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HCJFAJEAOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool AKCKKCCPLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class IJJKNOKDBDG
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum AKBJPBFNKHH
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
	public static readonly Guid EBEABMPGCJE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid FJJCODPBLHK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid EAAEPKGJEEJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PLPEAAKCMAK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid FAKFCBAGOPF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid EBKFLJFFEFP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FDIAKNNBCDL<MCHADAHGOKF, Guid> OCABAJGDNAM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MCHADAHGOKF> MPMKDJJGCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6870770", Offset = "0x686F970", VA = "0x186870770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68707E0", Offset = "0x686F9E0", VA = "0x1868707E0")]
	public static MCHADAHGOKF GOJMPPHBNDK(Guid IKOKEKHMFKH)
	{
		return default(MCHADAHGOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68706D0", Offset = "0x686F8D0", VA = "0x1868706D0")]
	public static Guid FGANKFAMOJA(MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68705C0", Offset = "0x686F7C0", VA = "0x1868705C0")]
	public static bool BALOHJJOENF(MCHADAHGOKF PDNPNGCMBEJ, [Out] Guid IKOKEKHMFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6870870", Offset = "0x686FA70", VA = "0x186870870")]
	public static bool LBMEONAKMKO(Guid IKOKEKHMFKH, [Out] MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6870650", Offset = "0x686F850", VA = "0x186870650")]
	public static MCHADAHGOKF DCLEOMPEEEB(MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(MCHADAHGOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6870910", Offset = "0x686FB10", VA = "0x186870910")]
	public static AKBJPBFNKHH MHEPIOLAHIF(MCHADAHGOKF HDDOFFFMAOB)
	{
		return default(AKBJPBFNKHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6870690", Offset = "0x686F890", VA = "0x186870690")]
	internal static MCHADAHGOKF EMILCOKAMKA(AKBJPBFNKHH NJOJCJDHHME)
	{
		return default(MCHADAHGOKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CMHMJICFAKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LJDEIPAAFLH DINPPIGPIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<FEIGNJPIBKG> AOMGLBIHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NMBPPJGFFAL ENAGICBPDBO;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<FEIGNJPIBKG> DCLOAAPBHCF(bool PJLLEIBFOJE = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FEIGNJPIBKG CKLOIOAMHEC(EOBANJCDGLI DBPHBPCOBKD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LLCHMBEGPEB(EOBANJCDGLI DBPHBPCOBKD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<FEIGNJPIBKG> CEBJLLLAFPK(EOBANJCDGLI DBPHBPCOBKD, bool MPPHILIIELM = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OHELMDKCDPM(EOBANJCDGLI NNGFHFKAABJ, MCHADAHGOKF PDNPNGCMBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FEIGNJPIBKG CPNLFCIEHKF(MCHADAHGOKF PDNPNGCMBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MGMNFHDPLGD<T>(MCHADAHGOKF PDNPNGCMBEJ, ICGMIOACDKP CMFLEFGKNDP, bool AKMGCAHOMOI, T GFMMLICJDDH, [Optional] Action LBLLPMAFCIO) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BHOHLNPJOOI
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NBCLMAGEFJF(LJKOKHIIAPB JENPAMGBIKD, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMHAEBIJJAL(LJKOKHIIAPB JENPAMGBIKD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MOFKOOLFKMF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EOBANJCDGLI ABNGLKMDABA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NKKGGOEDKKI LKBHGNMJKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NHHLGHBJLHK IFJDLBIOCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EPNDOPLNHEA> CCIGDFABADP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EOOPFBFICBC;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCHADAHGOKF KNFFNKIBKKM(EOBANJCDGLI DBPHBPCOBKD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<EPNDOPLNHEA> NJCBAMFNNIP(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JEPIBADKAIN(long NCFOOPOBBIJ, long DIKKNIGACBL, IReadOnlyList<KHCEJFBJJLH> LGIPFGNDDLJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EOBANJCDGLI> NMBGJHKGDAD();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ODKPDOCKGBH
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6872E10", Offset = "0x6872010", VA = "0x186872E10")]
	public static MCHADAHGOKF HKFGJMOPIEB(this MOFKOOLFKMF PFBMEDGPEJJ)
	{
		return default(MCHADAHGOKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IJDKEDPBHAA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string HDBEAOBGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event GPMJDPJONKP<TPermission> PNGKDEKHGLI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class AJGOJBFECKB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? OHJIFAEPOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	protected AJGOJBFECKB(object? JCOLDDANIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JBIBBIAKINL(object? NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class APNHONAHAIM<T> : AJGOJBFECKB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T KFEHFKCJFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> FDCJDIIBDAL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85F3E0", Offset = "0x85E5E0", VA = "0x18085F3E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B07F60", Offset = "0x3B07160", VA = "0x183B07F60", Slot = "4")]
	public override bool JBIBBIAKINL(object? NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B08120", Offset = "0x3B07320", VA = "0x183B08120")]
	public bool LDJFAOACBCD(T GLPAIDCJKGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B085A0", Offset = "0x3B077A0", VA = "0x183B085A0")]
	public APNHONAHAIM(T FJPKGOAOIBJ, IEqualityComparer<T> FDCJDIIBDAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CLCGJMFGILE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<ICGMIOACDKP, bool> NEHDJAFAFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<ICGMIOACDKP, AJGOJBFECKB> PPDONLAGCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HEGBGEJCJMP NCOPCMAAEIN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6867ED0", Offset = "0x68670D0", VA = "0x186867ED0")]
	public CLCGJMFGILE(HEGBGEJCJMP NCOPCMAAEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6867D90", Offset = "0x6866F90", VA = "0x186867D90")]
	public bool IOMLHDNKPDD(ICGMIOACDKP CMFLEFGKNDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x271A640", Offset = "0x2719840", VA = "0x18271A640")]
	public bool GMFKCEAJLKH<T>(ICGMIOACDKP CMFLEFGKNDP, bool AKMGCAHOMOI, T NICEPFIEJED) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x271AB50", Offset = "0x2719D50", VA = "0x18271AB50")]
	public (bool, T?) MKHJPDALGCI<T>(ICGMIOACDKP CMFLEFGKNDP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6867AB0", Offset = "0x6866CB0", VA = "0x186867AB0")]
	public bool GMFKCEAJLKH(ICGMIOACDKP CMFLEFGKNDP, bool AKMGCAHOMOI, object NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6867E00", Offset = "0x6867000", VA = "0x186867E00")]
	public (bool, object) MKHJPDALGCI(ICGMIOACDKP CMFLEFGKNDP)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x271A600", Offset = "0x2719800", VA = "0x18271A600")]
	private void DGJPOOPBKEF<T>(ICGMIOACDKP CMFLEFGKNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68679E0", Offset = "0x6866BE0", VA = "0x1868679E0")]
	private AJGOJBFECKB FKDIMMIAAFF(ICGMIOACDKP CMFLEFGKNDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6867B90", Offset = "0x6866D90", VA = "0x186867B90")]
	public void IMIEJNNJKLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LJAFECKBFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string IOJNOHEFDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type FMPOALLCLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EIBJEJIGGME KHBGGHOHPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly ICGMIOACDKP BBENILPFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JJABMPNGCJH MIKKJLCEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public GDIBHIIIJEO MONKGCOBKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public AOEKPBHBOPL HALPDHJFODC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6872320", Offset = "0x6871520", VA = "0x186872320")]
	public LJAFECKBFHA(Type ENCGOKLBPGJ, string CADINNPBOOI, ICGMIOACDKP CMFLEFGKNDP, JJABMPNGCJH HBGJOIBPLCH, GDIBHIIIJEO MLHNEKDPNGK, AOEKPBHBOPL IGELHEEBMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6872220", Offset = "0x6871420", VA = "0x186872220")]
	public object DEAJMMCEAED(object? NOBJAPGNDAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x298A330", Offset = "0x2989530", VA = "0x18298A330")]
	public void DGJPOOPBKEF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6872270", Offset = "0x6871470", VA = "0x186872270")]
	public void DGJPOOPBKEF(Type DAPJJIECCMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CMIHGPAOHDB<T> : LJAFECKBFHA where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string PAFEOHACMAK(T NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T IBACCDOGNDB(string? OCJNFBNKPPF, T FJPKGOAOIBJ);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PCAMOLONFHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PAFEOHACMAK serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IBACCDOGNDB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public PCAMOLONFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4257F80", Offset = "0x4257180", VA = "0x184257F80")]
		internal string FNOIMPLHEIM(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4257E60", Offset = "0x4257060", VA = "0x184257E60")]
		internal object AGKNEAELMCN(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C3C760", Offset = "0x4C3B960", VA = "0x184C3C760")]
	public CMIHGPAOHDB(ICGMIOACDKP CMFLEFGKNDP, string CADINNPBOOI, [Optional] PAFEOHACMAK? HBGJOIBPLCH, [Optional] IBACCDOGNDB? MLHNEKDPNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C3BA90", Offset = "0x4C3AC90", VA = "0x184C3BA90")]
	private static object? LKMADFBDLGL(IBACCDOGNDB? MLHNEKDPNGK, string? OCJNFBNKPPF, object? FJPKGOAOIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C3C280", Offset = "0x4C3B480", VA = "0x184C3C280")]
	private static string OHDBDPJBHPM(PAFEOHACMAK? DHEMCNBLAOJ, object? NICEPFIEJED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string JJABMPNGCJH(object? NICEPFIEJED);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object GDIBHIIIJEO(string? OCJNFBNKPPF, [Optional] object FJPKGOAOIBJ);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate AJGOJBFECKB AOEKPBHBOPL();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class HEGBGEJCJMP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class IJGJFCNJDKN : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static IJGJFCNJDKN KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6870290", Offset = "0x686F490", VA = "0x186870290", Slot = "4")]
		public bool Equals(List<string> KPEEHKEJDAP, List<string> OEKGMAOIIKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68703E0", Offset = "0x686F5E0", VA = "0x1868703E0", Slot = "5")]
		public int GetHashCode(List<string> JFJMICPDNDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IJGJFCNJDKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class GFCOAODOILO : BGIKFEBOMKA<DLHMBJNHGIB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x686DDA0", Offset = "0x686CFA0", VA = "0x18686DDA0", Slot = "9")]
		public override string OHDBDPJBHPM(DLHMBJNHGIB CCAOJBHBKKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x686DBC0", Offset = "0x686CDC0", VA = "0x18686DBC0", Slot = "10")]
		protected override bool KHACDHDJOCM(string CCAOJBHBKKC, [Out] DLHMBJNHGIB NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x686DE90", Offset = "0x686D090", VA = "0x18686DE90")]
		public GFCOAODOILO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly CGJDGMEHPDA DPLLLJHEFDO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly GFCOAODOILO BIPAKGHPFOI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<LJAFECKBFHA> PMMLPLOBMPD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<ICGMIOACDKP> NKMBJMFCOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<ICGMIOACDKP, LJAFECKBFHA> HFJOAENJLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x686FEE0", Offset = "0x686F0E0", VA = "0x18686FEE0")]
	public HEGBGEJCJMP([Optional] IList<LJAFECKBFHA>? GOBCGFDHKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x686EA40", Offset = "0x686DC40", VA = "0x18686EA40")]
	public LJAFECKBFHA CMMAEOJCMJF(ICGMIOACDKP CMFLEFGKNDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LJDEIPAAFLH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FEIGNJPIBKG GLHNFENFPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KEEEHOPNMDD : LJDEIPAAFLH
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KEEEHOPNMDD MLIHGDLGNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly BIGKJKDJJOK KEMKICDDBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<BIGKJKDJJOK> MJCBILJLIGK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FEIGNJPIBKG GLHNFENFPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6872110", Offset = "0x6871310", VA = "0x186872110")]
	public KEEEHOPNMDD(BIGKJKDJJOK EMDKCKFCNEL, IReadOnlyList<BIGKJKDJJOK> NMKPJIPKIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6871520", Offset = "0x6870720", VA = "0x186871520")]
	private static KEEEHOPNMDD IGHBJFENIKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NMDDFGFNJFE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<MCHADAHGOKF> DJCLCPNLPAB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6872B10", Offset = "0x6871D10", VA = "0x186872B10")]
	public static bool PFDOJFOAOLB(this EOBANJCDGLI NEJMNOMAPNA, MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6872A90", Offset = "0x6871C90", VA = "0x186872A90")]
	public static bool BNHCDFCIEOB(this EOBANJCDGLI NEJMNOMAPNA, MCHADAHGOKF PDNPNGCMBEJ, NHHLGHBJLHK BOJALOCECAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface JNPFEBDHODK
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DNMIELJHEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MIHBFHMFDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool APOCCLMIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KKIAAIAJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KEJOLKDEJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CNKLDKAJGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KOIAKLODEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ADGBNHMHBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FAJHDOLLGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PAMIMKECBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LGGMOBLBIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OHIAKKFKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> ACHOOHIAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DLHMBJNHGIB FFPNKLOEDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FEIGNJPIBKG : JNPFEBDHODK, DBPOAJICNFB, IJDKEDPBHAA<ICGMIOACDKP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string JODLACKHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MCHADAHGOKF BIMOLEIJHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FCNFIAOBKDF<T>(ICGMIOACDKP CMFLEFGKNDP) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum ICGMIOACDKP
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
internal class BIGKJKDJJOK : FEIGNJPIBKG, JNPFEBDHODK, DBPOAJICNFB, IJDKEDPBHAA<ICGMIOACDKP>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly HEGBGEJCJMP FOKPNLALFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly CLCGJMFGILE ANFBFJMIJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? LKOCBPIFPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? NCDIMNKBKLK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool DKECMKJGJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68670D0", Offset = "0x68662D0", VA = "0x1868670D0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BEJCPBLOINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6866A10", Offset = "0x6865C10", VA = "0x186866A10", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool PGHCILHLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6867370", Offset = "0x6866570", VA = "0x186867370", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool CNKMJELGFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6865EA0", Offset = "0x68650A0", VA = "0x186865EA0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool KJEBKCKHMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6865EF0", Offset = "0x68650F0", VA = "0x186865EF0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool IPHGHJOAFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6866A60", Offset = "0x6865C60", VA = "0x186866A60", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MCHADAHGOKF BIMOLEIJHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85F3E0", Offset = "0x85E5E0", VA = "0x18085F3E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MCHADAHGOKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BA960", Offset = "0x7B9B60", VA = "0x1807BA960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string HDBEAOBGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x68676D0", Offset = "0x68668D0", VA = "0x1868676D0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6867080", Offset = "0x6866280", VA = "0x186867080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string JODLACKHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x68676D0", Offset = "0x68668D0", VA = "0x1868676D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OIFKGMLAKHM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x899660", Offset = "0x898860", VA = "0x180899660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x898AD0", Offset = "0x897CD0", VA = "0x180898AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DNMIELJHEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68674A0", Offset = "0x68666A0", VA = "0x1868674A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DLHMBJNHGIB FFPNKLOEDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68675D0", Offset = "0x68667D0", VA = "0x1868675D0", Slot = "20")]
		get
		{
			return default(DLHMBJNHGIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MIHBFHMFDNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6865910", Offset = "0x6864B10", VA = "0x186865910", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool APOCCLMIMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6866F70", Offset = "0x6866170", VA = "0x186866F70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KKIAAIAJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6867030", Offset = "0x6866230", VA = "0x186867030", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KEJOLKDEJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6866FC0", Offset = "0x68661C0", VA = "0x186866FC0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CNKLDKAJGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6865DE0", Offset = "0x6864FE0", VA = "0x186865DE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KOIAKLODEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6865F90", Offset = "0x6865190", VA = "0x186865F90", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool ADGBNHMHBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6865D40", Offset = "0x6864F40", VA = "0x186865D40", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FAJHDOLLGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6865D90", Offset = "0x6864F90", VA = "0x186865D90", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> ACHOOHIAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6865CE0", Offset = "0x6864EE0", VA = "0x186865CE0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool LAJPLADCGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68670D0", Offset = "0x68662D0", VA = "0x1868670D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool NMEBNHEHAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6865EF0", Offset = "0x68650F0", VA = "0x186865EF0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LFCPMDHHGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6866A10", Offset = "0x6865C10", VA = "0x186866A10", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PAMIMKECBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6866F20", Offset = "0x6866120", VA = "0x186866F20", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LGGMOBLBIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68673C0", Offset = "0x68665C0", VA = "0x1868673C0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GILMLJHDILL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6867370", Offset = "0x6866570", VA = "0x186867370", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OHIAKKFKNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6865F40", Offset = "0x6865140", VA = "0x186865F40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DEMNONBFBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6865EA0", Offset = "0x68650A0", VA = "0x186865EA0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LBFCGEOBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6866A60", Offset = "0x6865C60", VA = "0x186866A60", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GPMJDPJONKP<ICGMIOACDKP> PNGKDEKHGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6867620", Offset = "0x6866820", VA = "0x186867620", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6865FE0", Offset = "0x68651E0", VA = "0x186865FE0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x26BA780", Offset = "0x26B9980", VA = "0x1826BA780", Slot = "6")]
	public (bool, T?) FCNFIAOBKDF<T>(ICGMIOACDKP CMFLEFGKNDP) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26BA910", Offset = "0x26B9B10", VA = "0x1826BA910")]
	public BIGKJKDJJOK GLLADPOBLDN<T>(ICGMIOACDKP CMFLEFGKNDP, bool AKMGCAHOMOI, T NICEPFIEJED) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6867990", Offset = "0x6866B90", VA = "0x186867990")]
	public BIGKJKDJJOK(MCHADAHGOKF PDNPNGCMBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6867820", Offset = "0x6866A20", VA = "0x186867820")]
	public BIGKJKDJJOK(MCHADAHGOKF PDNPNGCMBEJ, [Optional] string? LKOCBPIFPED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68677A0", Offset = "0x68669A0", VA = "0x1868677A0")]
	public BIGKJKDJJOK(BIGKJKDJJOK BKGODGFONAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6867840", Offset = "0x6866A40", VA = "0x186867840")]
	internal BIGKJKDJJOK(MCHADAHGOKF NENGFIOLMJE, [Optional] string? LKOCBPIFPED, [Optional] BIGKJKDJJOK? BKGODGFONAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6865E30", Offset = "0x6865030", VA = "0x186865E30")]
	public static EIBJEJIGGME DEKGDIOKHBN(ICGMIOACDKP CMFLEFGKNDP)
	{
		return default(EIBJEJIGGME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6867010", Offset = "0x6866210", VA = "0x186867010")]
	public void IMIEJNNJKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6865960", Offset = "0x6864B60", VA = "0x186865960")]
	internal BIGKJKDJJOK AEHNPEACLCA(BIGKJKDJJOK LFLCKBDMMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6866AB0", Offset = "0x6865CB0", VA = "0x186866AB0")]
	internal IReadOnlyCollection<ICGMIOACDKP> GMJOKEELPME(BIGKJKDJJOK BKGODGFONAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x68674F0", Offset = "0x68666F0", VA = "0x1868674F0")]
	public bool MABHGNFKILN(ICGMIOACDKP CMFLEFGKNDP, bool AKMGCAHOMOI, string GGPHMDNHMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6865810", Offset = "0x6864A10", VA = "0x186865810")]
	public (bool, string) ABOINEFFHJF(ICGMIOACDKP CMFLEFGKNDP)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6867320", Offset = "0x6866520", VA = "0x186867320")]
	internal void KGBLDLLMHAP(ICGMIOACDKP CMFLEFGKNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6867120", Offset = "0x6866320", VA = "0x186867120")]
	public BBIMANBOOCB JLINLAAMHMN(Func<MCHADAHGOKF, Guid> BACGCDABILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6866090", Offset = "0x6865290", VA = "0x186866090")]
	public void GFGDGDHDAKG(BBIMANBOOCB LMIJFMGNJMK, Func<Guid, MCHADAHGOKF> HIDEKKINABB, [Optional] MCHADAHGOKF? KGHNCHKPCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6867410", Offset = "0x6866610", VA = "0x186867410")]
	[CompilerGenerated]
	private void LLFKNDCFOAI(ICGMIOACDKP KAPCBPHOCPI, LJBHELOJOLO MMNKLMBEHLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ECMHGHGDBIE : BHOHLNPJOOI, CMHMJICFAKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CIOOGGFMPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public BIGKJKDJJOK newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CIOOGGFMPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68679B0", Offset = "0x6866BB0", VA = "0x1868679B0")]
		internal bool IFLFOOOCMFN(BIGKJKDJJOK rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class KAGIMOHFFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public MCHADAHGOKF roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public KAGIMOHFFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6871510", Offset = "0x6870710", VA = "0x186871510")]
		internal bool PEHMCMBIHHC(MCHADAHGOKF r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct MHBJAEAOJGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public ECMHGHGDBIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LJKOKHIIAPB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<EPNDOPLNHEA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68723C0", Offset = "0x68715C0", VA = "0x1868723C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6872A30", Offset = "0x6871C30", VA = "0x186872A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BEHAGFJNNHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BEHAGFJNNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6865730", Offset = "0x6864930", VA = "0x186865730")]
		internal void NMMEEOEGLEI(BBIMANBOOCB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6865610", Offset = "0x6864810", VA = "0x186865610")]
		internal void EDKAGMOHOPB(BBIMANBOOCB r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BNKNAKDAOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LJKOKHIIAPB roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HMBHKBOFECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<BBIMANBOOCB, LJBHELOJOLO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HMBHKBOFECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6870230", Offset = "0x686F430", VA = "0x186870230")]
		internal void OIDBIEDJGNH(BBIMANBOOCB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6870260", Offset = "0x686F460", VA = "0x186870260")]
		internal void OJMHJDFJLDF(BBIMANBOOCB r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6870200", Offset = "0x686F400", VA = "0x186870200")]
		internal void LPEFEONFDLF(BBIMANBOOCB r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IHLMOLHFOAP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public IHLMOLHFOAP<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<EPNDOPLNHEA> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3275AB0", Offset = "0x3274CB0", VA = "0x183275AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public ECMHGHGDBIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ICGMIOACDKP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MCHADAHGOKF accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EIBJEJIGGME recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IHLMOLHFOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3A40000", Offset = "0x3A3F200", VA = "0x183A40000")]
		[AsyncStateMachine(typeof(IHLMOLHFOAP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void EPCJOAHHMEK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KBKJPBPNMDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<KHCEJFBJJLH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HECMMKIBKLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MOFKOOLFKMF rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public LJKOKHIIAPB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<MCHADAHGOKF, BIGKJKDJJOK> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IAFPOFNODCF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x686DED0", Offset = "0x686D0D0", VA = "0x18686DED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x686E9E0", Offset = "0x686DBE0", VA = "0x18686E9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly MOFKOOLFKMF PFBMEDGPEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly KEEEHOPNMDD DNNNNHKMCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly IAFPOFNODCF POMHMEMGNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, BIGKJKDJJOK> KPNCGGCAMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<MCHADAHGOKF, BIGKJKDJJOK> MPBGLBCDHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<MCHADAHGOKF, BIGKJKDJJOK> CBACHPOJBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<BIGKJKDJJOK> LGKFAKLAPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool ELCNNECKOPH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ICGMIOACDKP[] MFDGLMHEPBG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LJDEIPAAFLH DINPPIGPIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<FEIGNJPIBKG> AOMGLBIHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x686AE70", Offset = "0x686A070", VA = "0x18686AE70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NMBPPJGFFAL ENAGICBPDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6868290", Offset = "0x6867490", VA = "0x186868290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6868B80", Offset = "0x6867D80", VA = "0x186868B80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x686B660", Offset = "0x686A860", VA = "0x18686B660")]
	[KEFCCLBEAOJ(BDECECCJEGA.Room, CMEECPGEPNF.None)]
	private static void MOJFLBKELFO(LEHDPNIFNIH AJCCGGFMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x686D900", Offset = "0x686CB00", VA = "0x18686D900")]
	[UnityEngine.Scripting.Preserve]
	internal ECMHGHGDBIE([GAGPBLHNPNO(null)] MOFKOOLFKMF PHPJNKKACMA, [GAGPBLHNPNO(null)] KEEEHOPNMDD PDHPGMKJABF, [GAGPBLHNPNO(null)] IAFPOFNODCF POMHMEMGNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6868C20", Offset = "0x6867E20", VA = "0x186868C20", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x686C400", Offset = "0x686B600", VA = "0x18686C400")]
	private void OEHMFCPINGA(IEnumerable<BIGKJKDJJOK> LEMFFEFFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x686B240", Offset = "0x686A440", VA = "0x18686B240", Slot = "12")]
	public bool LLCHMBEGPEB(EOBANJCDGLI DBPHBPCOBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6868F40", Offset = "0x6868140", VA = "0x186868F40")]
	private void EOOPFBFICBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6868680", Offset = "0x6867880", VA = "0x186868680")]
	private void BKAMLDNNEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6868B00", Offset = "0x6867D00", VA = "0x186868B00", Slot = "10")]
	public IReadOnlyList<FEIGNJPIBKG> DCLOAAPBHCF(bool PJLLEIBFOJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6868880", Offset = "0x6867A80", VA = "0x186868880", Slot = "11")]
	public FEIGNJPIBKG CKLOIOAMHEC(EOBANJCDGLI DBPHBPCOBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6868A30", Offset = "0x6867C30", VA = "0x186868A30")]
	private MCHADAHGOKF DCFNPGEPODE(EOBANJCDGLI DBPHBPCOBKD)
	{
		return default(MCHADAHGOKF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x686CF20", Offset = "0x686C120", VA = "0x18686CF20", Slot = "14")]
	public bool OHELMDKCDPM(EOBANJCDGLI NNGFHFKAABJ, MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6868990", Offset = "0x6867B90", VA = "0x186868990", Slot = "15")]
	public FEIGNJPIBKG CPNLFCIEHKF(MCHADAHGOKF PDNPNGCMBEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x686A740", Offset = "0x6869940", VA = "0x18686A740")]
	private static bool IDFNFPFPHPE(GPMFCLKPPND NFEHCGEMLMP, MCHADAHGOKF PDNPNGCMBEJ, [Out] BBIMANBOOCB? JDNIADALFJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x686AEC0", Offset = "0x686A0C0", VA = "0x18686AEC0")]
	private static void LBKNCHNDELG(GPMFCLKPPND NFEHCGEMLMP, Action<BBIMANBOOCB> DHIOOHIMCNF, MCHADAHGOKF MGAMNFDLELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x686AFB0", Offset = "0x686A1B0", VA = "0x18686AFB0")]
	private static void LBKNCHNDELG(GPMFCLKPPND NFEHCGEMLMP, Action<BBIMANBOOCB> DHIOOHIMCNF, Predicate<MCHADAHGOKF> BAILKFFGGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6868F50", Offset = "0x6868150", VA = "0x186868F50")]
	private void GCNPEPHOOIM(EOBANJCDGLI DBPHBPCOBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x686B820", Offset = "0x686AA20", VA = "0x18686B820", Slot = "4")]
	[AsyncStateMachine(typeof(MHBJAEAOJGH))]
	public Task NBCLMAGEFJF([CanBeNull] LJKOKHIIAPB JENPAMGBIKD, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
	public void HMHAEBIJJAL(LJKOKHIIAPB JENPAMGBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x686B940", Offset = "0x686AB40", VA = "0x18686B940")]
	private void NECNAOGBCME(GPMFCLKPPND OBNMOOGDIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x686D0B0", Offset = "0x686C2B0", VA = "0x18686D0B0")]
	internal static string OLOOABAJHIG(MOFKOOLFKMF PFBMEDGPEJJ, LJKOKHIIAPB JENPAMGBIKD, IReadOnlyDictionary<MCHADAHGOKF, BIGKJKDJJOK> MPBGLBCDHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68699E0", Offset = "0x6868BE0", VA = "0x1868699E0")]
	private static void HKIOOIGIPIO(LJKOKHIIAPB JENPAMGBIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x686B310", Offset = "0x686A510", VA = "0x18686B310")]
	private static void MBLPNGDCHJB(GPMFCLKPPND CNDCGFEGMPD, IReadOnlyDictionary<MCHADAHGOKF, BIGKJKDJJOK> MPBGLBCDHJI, StringBuilder CCBGPPEGFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6868180", Offset = "0x6867380", VA = "0x186868180")]
	private static bool ANPCFELHGLI(string CANBPONGMJA, [Out] Guid LNHOCDOCCLD, [Out] MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6868FC0", Offset = "0x68681C0", VA = "0x186868FC0")]
	private static void GDJBGBAOGPM(LJKOKHIIAPB JENPAMGBIKD, StringBuilder CCBGPPEGFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27793D0", Offset = "0x27785D0", VA = "0x1827793D0", Slot = "16")]
	public bool MGMNFHDPLGD<T>(MCHADAHGOKF PDNPNGCMBEJ, ICGMIOACDKP CMFLEFGKNDP, bool AKMGCAHOMOI, T GFMMLICJDDH, [Optional] Action LBLLPMAFCIO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6868D30", Offset = "0x6867F30", VA = "0x186868D30")]
	private void EDBKCILELMP(MCHADAHGOKF PDNPNGCMBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x686AD10", Offset = "0x6869F10", VA = "0x18686AD10")]
	private bool INLDCPCEPJC(EOBANJCDGLI DBPHBPCOBKD, MCHADAHGOKF PDNPNGCMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6868330", Offset = "0x6867530", VA = "0x186868330")]
	internal BIGKJKDJJOK BFCJGHMHLJH(EOBANJCDGLI DBPHBPCOBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6868870", Offset = "0x6867A70", VA = "0x186868870", Slot = "13")]
	public IReadOnlyList<FEIGNJPIBKG> CEBJLLLAFPK(EOBANJCDGLI DBPHBPCOBKD, bool MPPHILIIELM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x686CCF0", Offset = "0x686BEF0", VA = "0x18686CCF0")]
	internal IReadOnlyList<BIGKJKDJJOK> OFCAFNMHDBN(EOBANJCDGLI DBPHBPCOBKD, bool MPPHILIIELM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x686BC80", Offset = "0x686AE80", VA = "0x18686BC80")]
	private void NPNLEBDOPOA(EPNDOPLNHEA NEIMLAIFAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6869700", Offset = "0x6868900", VA = "0x186869700")]
	private static bool HAFBINPEPPL(BIGKJKDJJOK JFCIIKIHHHJ, IReadOnlyDictionary<MCHADAHGOKF, BIGKJKDJJOK> MPBGLBCDHJI, [Out] IReadOnlyList<ICGMIOACDKP> NPHKCLJFLNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x686AD30", Offset = "0x6869F30", VA = "0x18686AD30")]
	[AsyncStateMachine(typeof(HECMMKIBKLE))]
	private static Task JFODKCNAMJB(MOFKOOLFKMF PFBMEDGPEJJ, LJKOKHIIAPB JENPAMGBIKD, IReadOnlyDictionary<MCHADAHGOKF, BIGKJKDJJOK> MPBGLBCDHJI, IAFPOFNODCF POMHMEMGNEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x686AA70", Offset = "0x6869C70", VA = "0x18686AA70")]
	[CompilerGenerated]
	internal static void IKJIDFGFJLK(Func<BBIMANBOOCB, LJBHELOJOLO> CDPCNKFJOCC, BNKNAKDAOOB P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x686D3C0", Offset = "0x686C5C0", VA = "0x18686D3C0")]
	[CompilerGenerated]
	internal static bool PJCFCDIIHCA(MCHADAHGOKF PDNPNGCMBEJ, ICGMIOACDKP CMFLEFGKNDP, [Out] KHCEJFBJJLH PEGEMMJPDDM, KBKJPBPNMDB P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AHJCDPGJCIG
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NHODGBLGDOI(EOBANJCDGLI OGNLHHDIDEF, EOBANJCDGLI KFPJOICMDIJ, IEnumerable<EOBANJCDGLI> IIOPOAJKJGO, [Out] DLHMBJNHGIB GNDFEJFILKN, [Out] KJAGPEJDFJH KAODGAFLAFI);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BLKGAKDENIJ(KJAGPEJDFJH FLHBGCAGACO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum KJAGPEJDFJH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class INNNHBGLINF : AHJCDPGJCIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CMHMJICFAKO BHCDFHEDKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly NLFHOJCOKFC EJHDEENBOHB;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public INNNHBGLINF([GAGPBLHNPNO(null)] CMHMJICFAKO EPCLENMHKBH, [GAGPBLHNPNO(null)] NLFHOJCOKFC PNJONHBFMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6870CB0", Offset = "0x686FEB0", VA = "0x186870CB0")]
	private static CHDFKNLCCAD? AKGIILHDCCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6871410", Offset = "0x6870610", VA = "0x186871410", Slot = "4")]
	public bool NHODGBLGDOI(EOBANJCDGLI OGNLHHDIDEF, EOBANJCDGLI KFPJOICMDIJ, IEnumerable<EOBANJCDGLI> IIOPOAJKJGO, [Out] DLHMBJNHGIB GNDFEJFILKN, [Out] KJAGPEJDFJH KAODGAFLAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6870CF0", Offset = "0x686FEF0", VA = "0x186870CF0", Slot = "5")]
	public string BLKGAKDENIJ(KJAGPEJDFJH FLHBGCAGACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6870DF0", Offset = "0x686FFF0", VA = "0x186870DF0")]
	internal bool JCLGPIOPDPF(EOBANJCDGLI OGNLHHDIDEF, EOBANJCDGLI KFPJOICMDIJ, IEnumerable<EOBANJCDGLI> IIOPOAJKJGO, NHHLGHBJLHK BOJALOCECAH, CHDFKNLCCAD? BEBHKELGBFH, [Out] DLHMBJNHGIB GNDFEJFILKN, [Out] KJAGPEJDFJH KAODGAFLAFI)
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
