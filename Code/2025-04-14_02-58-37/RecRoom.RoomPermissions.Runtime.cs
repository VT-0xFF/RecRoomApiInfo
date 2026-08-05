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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x813D5C0", Offset = "0x813BFC0", VA = "0x18813D5C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AODMDNIIPGL
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
		[Cpp2IlInjected.Address(RVA = "0x813DE00", Offset = "0x813C800", VA = "0x18813DE00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EGGAHDHJKDH<TPermission>(TPermission MHMGJOPNDFD);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CPCCDJOLMNG(BKBJMNKBOED DHJCIPPGLOL);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LFHGIODHBDE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IPOEFIEOJAK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KAGBNIMBKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NDFDIGPIBJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool OLMAEMLPDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LMCMFGHDILH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FDHOCGBILCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JKBJECDNEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CNCFPHGJBHK
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum MIENIJAOFJH
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
	public static readonly Guid HMJPJNMDFGE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid LIKHMNDDOMJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid FHBPNMCGEOC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JEGNJIGGKNO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid ALJEFPILGMK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid GBOHFDPMFHL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly FECHJIEJFFC<OEADLBOEPJO, Guid> OGHHALMCIII;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<OEADLBOEPJO> HFIANIIGNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8131790", Offset = "0x8130190", VA = "0x188131790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8131700", Offset = "0x8130100", VA = "0x188131700")]
	public static OEADLBOEPJO LAEJMPAOFLM(Guid BIGAPECKJPI)
	{
		return default(OEADLBOEPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8131660", Offset = "0x8130060", VA = "0x188131660")]
	public static Guid KJBKEEMFIEL(OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81315D0", Offset = "0x812FFD0", VA = "0x1881315D0")]
	public static bool JOHIOLHIILD(OEADLBOEPJO ODHDBPIMBGI, [Out] Guid BIGAPECKJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8131440", Offset = "0x812FE40", VA = "0x188131440")]
	public static bool BPFAKPALBAM(Guid BIGAPECKJPI, [Out] OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8131590", Offset = "0x812FF90", VA = "0x188131590")]
	public static OEADLBOEPJO IFCCONHACOK(OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(OEADLBOEPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81314E0", Offset = "0x812FEE0", VA = "0x1881314E0")]
	public static MIENIJAOFJH EEPIEOFEPGA(OEADLBOEPJO OMKKAJKPMDH)
	{
		return default(MIENIJAOFJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8131800", Offset = "0x8130200", VA = "0x188131800")]
	internal static OEADLBOEPJO OHLLIFMAAIB(MIENIJAOFJH GCNLAMOAHCL)
	{
		return default(OEADLBOEPJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface INFIDBOMNED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NDJPJHIEMNB DFJBHFPLBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<JBFNLPJLCNP> IOIBIJPOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CPCCDJOLMNG ALJOLALKEKM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<JBFNLPJLCNP> NPGNFNBOANK(bool MEPIBDJFOPD = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBFNLPJLCNP EFNCJKONONP(BKBJMNKBOED DHJCIPPGLOL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ECMKNIJGCHJ(BKBJMNKBOED DHJCIPPGLOL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<JBFNLPJLCNP> JNAIAGICPGF(BKBJMNKBOED DHJCIPPGLOL, bool LAGPJALDCBP = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CAMJBMKJMED(BKBJMNKBOED AHKPNJDNAKG, OEADLBOEPJO ODHDBPIMBGI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JBFNLPJLCNP MFJPHHOMFIG(OEADLBOEPJO ODHDBPIMBGI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MAJDBPENMAL<T>(OEADLBOEPJO ODHDBPIMBGI, NGEAHKGPBPA MHMGJOPNDFD, bool IPHIFICKJHD, T JDKFBOCIIAB, [Optional] Action CKNPDPOANGJ) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string PPCJGHEBOPJ(NGEAHKGPBPA MHMGJOPNDFD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FOCDJJDPFDL
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HOBFPDCDPGO(ENCFJAGIPBN COLBDAEGKBA, CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEKCNHEHNKL(ENCFJAGIPBN COLBDAEGKBA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JEBCICNHBOM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BKBJMNKBOED EJGLDLJPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JIFMHENFAOG APAKLDLHHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AKGPNEALNMD CHGNCAALJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HJDGMGJGHBO> LCKPKBMMEIA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action DAMHDGCBIGE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OEADLBOEPJO HLHFCOCKCHE(BKBJMNKBOED DHJCIPPGLOL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HJDGMGJGHBO> HODPHLNANEL(CancellationToken BJEPDCCBCHJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ALGCLPABKBO(long ELGKGFHIPBE, IReadOnlyList<EKKPJLCDCJH> DMHJFAAFNID);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KELPBBCAJMD(long ELGKGFHIPBE, long CPBHLEIJEHC, IReadOnlyList<EKKPJLCDCJH> DMHJFAAFNID);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<BKBJMNKBOED> FDIODNNLJCM();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OMCBDEJMICF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x813D640", Offset = "0x813C040", VA = "0x18813D640")]
	public static OEADLBOEPJO FJJGBLCKFHL(this JEBCICNHBOM KFIBJOOODJF)
	{
		return default(OEADLBOEPJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PCDIBJBJIHJ<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FGCHEDKIPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EGGAHDHJKDH<TPermission> JNBKGEJMJEK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class JHJEGEMIPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? PFGAKPEEKBB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? CFONLIFLALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8134BE0", Offset = "0x81335E0", VA = "0x188134BE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8134AE0", Offset = "0x81334E0", VA = "0x188134AE0")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8134CB0", Offset = "0x81336B0", VA = "0x188134CB0")]
	protected JHJEGEMIPMB(object? BBAIADPIGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DMGHPFDEDAO(object? PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DCGGNAFDKKD<T> : JHJEGEMIPMB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> KADCJBCBGFI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4310", Offset = "0x3EE2D10", VA = "0x183EE4310")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3E30", Offset = "0x3EE2830", VA = "0x183EE3E30", Slot = "4")]
	public override bool DMGHPFDEDAO(object? PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4930", Offset = "0x3EE3330", VA = "0x183EE4930")]
	public bool KNPIICAJKGC(T MPABNOLHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4A90", Offset = "0x3EE3490", VA = "0x183EE4A90")]
	public DCGGNAFDKKD(T LPJIMLBFHAO, IEqualityComparer<T> KADCJBCBGFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KMKFHKPHBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<NGEAHKGPBPA, bool> IGNCEAJBAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<NGEAHKGPBPA, JHJEGEMIPMB> BFNKMIDFCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LEFICNOONPA MDEKCLCGHIG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8135680", Offset = "0x8134080", VA = "0x188135680")]
	public KMKFHKPHBPP(LEFICNOONPA MDEKCLCGHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8135610", Offset = "0x8134010", VA = "0x188135610")]
	public bool PJPMCMGLKCL(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x371C0C0", Offset = "0x371AAC0", VA = "0x18371C0C0")]
	public bool EFDPLIHBDLJ<T>(NGEAHKGPBPA MHMGJOPNDFD, bool IPHIFICKJHD, T PPJFMHBDGNA) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x371C6A0", Offset = "0x371B0A0", VA = "0x18371C6A0")]
	public (bool, T?) NDCAFJOBBEB<T>(NGEAHKGPBPA MHMGJOPNDFD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x81350E0", Offset = "0x8133AE0", VA = "0x1881350E0")]
	public bool EFDPLIHBDLJ(NGEAHKGPBPA MHMGJOPNDFD, bool IPHIFICKJHD, object PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8135480", Offset = "0x8133E80", VA = "0x188135480")]
	public (bool, object) NDCAFJOBBEB(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x371C640", Offset = "0x371B040", VA = "0x18371C640")]
	private void MIONEBLFKNE<T>(NGEAHKGPBPA MHMGJOPNDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x81351C0", Offset = "0x8133BC0", VA = "0x1881351C0")]
	private JHJEGEMIPMB EGMKPJANFIP(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8135290", Offset = "0x8133C90", VA = "0x188135290")]
	public void KEJJLIADCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JHEOBNEMPPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string EOBMKMINNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type DFJAKAOOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly MKKKJLDJJHL PJKGNPFAMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly NGEAHKGPBPA IPGKFHFCPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NONNDCNEOFC FJDACJJKOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OKNHEKFOFEM KDLDHPDNHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HFMGIPOGOLH EECGDKMGKFG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8134A40", Offset = "0x8133440", VA = "0x188134A40")]
	public JHEOBNEMPPI(Type JDPKIEBKOOB, string HNBKFLJPFAC, NGEAHKGPBPA MHMGJOPNDFD, NONNDCNEOFC IALPMMHDCCC, OKNHEKFOFEM JFEHKKBNOFK, HFMGIPOGOLH ELHOELODFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x81349F0", Offset = "0x81333F0", VA = "0x1881349F0")]
	public object NGNBGNAOECF(object? OLKLGHOAKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36E1E20", Offset = "0x36E0820", VA = "0x1836E1E20")]
	public void MIONEBLFKNE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8134940", Offset = "0x8133340", VA = "0x188134940")]
	public void MIONEBLFKNE(Type JMIIINDPING)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class DFDDKJNFNEC<T> : JHEOBNEMPPI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string FEPPHEHLLDH(T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T KCDPLNJDOEC(string? KFJFMDMAEJP, T LPJIMLBFHAO);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EBKOPJPICLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FEPPHEHLLDH serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KCDPLNJDOEC parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EBKOPJPICLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4352560", Offset = "0x4350F60", VA = "0x184352560")]
		internal string JAOIKODCLIP(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4352350", Offset = "0x4350D50", VA = "0x184352350")]
		internal object GONOFCIBJEG(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1520", Offset = "0x3EEFF20", VA = "0x183EF1520")]
	public DFDDKJNFNEC(NGEAHKGPBPA MHMGJOPNDFD, string HNBKFLJPFAC, [Optional] FEPPHEHLLDH? IALPMMHDCCC, [Optional] KCDPLNJDOEC? JFEHKKBNOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0F00", Offset = "0x3EEF900", VA = "0x183EF0F00")]
	private static object? DHOLDBOACBA(KCDPLNJDOEC? JFEHKKBNOFK, string? KFJFMDMAEJP, object? LPJIMLBFHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF00C0", Offset = "0x3EEEAC0", VA = "0x183EF00C0")]
	private static string CFLEALCFLNK(FEPPHEHLLDH? DPICAOGHDAA, object? PPJFMHBDGNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string NONNDCNEOFC(object? PPJFMHBDGNA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object OKNHEKFOFEM(string? KFJFMDMAEJP, [Optional] object LPJIMLBFHAO);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate JHJEGEMIPMB HFMGIPOGOLH();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class LEFICNOONPA
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class KKOGEOFLDLF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static KKOGEOFLDLF LALLOKGAEJH;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8134DB0", Offset = "0x81337B0", VA = "0x188134DB0", Slot = "4")]
		public bool Equals(List<string> CJBFFOKBLHB, List<string> CNBLFOFLDDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8134F00", Offset = "0x8133900", VA = "0x188134F00", Slot = "5")]
		public int GetHashCode(List<string> OIIGDBLKEDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KKOGEOFLDLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class KOLMBPADENA : NFMMBNJABEI<AODMDNIIPGL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8135930", Offset = "0x8134330", VA = "0x188135930", Slot = "9")]
		public override string CFLEALCFLNK(AODMDNIIPGL OBMEHBOBMDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8135A20", Offset = "0x8134420", VA = "0x188135A20", Slot = "10")]
		protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] AODMDNIIPGL PPJFMHBDGNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8135BF0", Offset = "0x81345F0", VA = "0x188135BF0")]
		public KOLMBPADENA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly PKFGFLNANED DHFJBGOCEJE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KOLMBPADENA FDPEOPEGOOJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<JHEOBNEMPPI> LPPEHDHAKAK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<NGEAHKGPBPA> OMAKMBPIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<NGEAHKGPBPA, JHEOBNEMPPI> KDEIBLODPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81371A0", Offset = "0x8135BA0", VA = "0x1881371A0")]
	public LEFICNOONPA([Optional] IList<JHEOBNEMPPI>? NGBPEDAIIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8135C30", Offset = "0x8134630", VA = "0x188135C30")]
	public JHEOBNEMPPI FFCCBENKEND(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NDJPJHIEMNB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JBFNLPJLCNP IGKCIHDIDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class BHAJHAEKDEO : NDJPJHIEMNB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static BHAJHAEKDEO KMCLKHHAONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly HINPFNPKPJP MECIMCBBGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<HINPFNPKPJP> BDAJKFBEPPD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JBFNLPJLCNP IGKCIHDIDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8131330", Offset = "0x812FD30", VA = "0x188131330")]
	public BHAJHAEKDEO(HINPFNPKPJP LALNDJGLKMH, IReadOnlyList<HINPFNPKPJP> MFLNNFAHFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8130420", Offset = "0x812EE20", VA = "0x188130420")]
	private static BHAJHAEKDEO GBGIPDLNANK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ACMKJBHNCJL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<OEADLBOEPJO> FNGHFFIENLM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x812F830", Offset = "0x812E230", VA = "0x18812F830")]
	public static bool BKHMMHKCPEP(this BKBJMNKBOED DOBJHMJOLKM, OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x812F910", Offset = "0x812E310", VA = "0x18812F910")]
	public static bool JIJJCKOJFLF(this BKBJMNKBOED DOBJHMJOLKM, OEADLBOEPJO ODHDBPIMBGI, AKGPNEALNMD ABDKGJKIOJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GPDABHGHKJM
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MILCHBFHPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BEHEAKFBIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ENBAAOLDGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BNPLGPIJJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IBKHHMODINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CIJNCLMEALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NMHJNAIGJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EKMGJHIKOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool FGNINENDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FPCFFFNLEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool GIDOPFJHPBK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool POJDFHHOKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> AENGOBHPBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	AODMDNIIPGL JNPDNIADKIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JBFNLPJLCNP : GPDABHGHKJM, IPOEFIEOJAK, PCDIBJBJIHJ<NGEAHKGPBPA>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string HNFLPIBHKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OEADLBOEPJO HOCEBHAEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) CDAGGIDIEOE<T>(NGEAHKGPBPA MHMGJOPNDFD) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NGEAHKGPBPA
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
internal class HINPFNPKPJP : JBFNLPJLCNP, GPDABHGHKJM, IPOEFIEOJAK, PCDIBJBJIHJ<NGEAHKGPBPA>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly LEFICNOONPA OBGJNJDLAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly KMKFHKPHBPP APCPAHALBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? INLKCKMBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? FFGPFBDBLAP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool MJDILANLOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8132E80", Offset = "0x8131880", VA = "0x188132E80", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FDLGPNDEKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8132F20", Offset = "0x8131920", VA = "0x188132F20", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool FIJAPBNJBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8134370", Offset = "0x8132D70", VA = "0x188134370", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool FCPKEHMNGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8133D80", Offset = "0x8132780", VA = "0x188133D80", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool IMOKNFGAFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8133D30", Offset = "0x8132730", VA = "0x188133D30", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CKIDKKODELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8134550", Offset = "0x8132F50", VA = "0x188134550", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public OEADLBOEPJO HOCEBHAEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA45A60", Offset = "0xA44460", VA = "0x180A45A60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OEADLBOEPJO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9BABA0", Offset = "0x9B95A0", VA = "0x1809BABA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string FGCHEDKIPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8132E30", Offset = "0x8131830", VA = "0x188132E30", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8133E70", Offset = "0x8132870", VA = "0x188133E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string HNFLPIBHKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8132E30", Offset = "0x8131830", VA = "0x188132E30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EOBIMEFKCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xD09970", Offset = "0xD08370", VA = "0x180D09970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xD09990", Offset = "0xD08390", VA = "0x180D09990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MILCHBFHPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8132DE0", Offset = "0x81317E0", VA = "0x188132DE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public AODMDNIIPGL JNPDNIADKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8133C90", Offset = "0x8132690", VA = "0x188133C90", Slot = "20")]
		get
		{
			return default(AODMDNIIPGL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool BEHEAKFBIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8132940", Offset = "0x8131340", VA = "0x188132940", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ENBAAOLDGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8133CE0", Offset = "0x81326E0", VA = "0x188133CE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BNPLGPIJJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8132ED0", Offset = "0x81318D0", VA = "0x188132ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IBKHHMODINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8133E20", Offset = "0x8132820", VA = "0x188133E20", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CIJNCLMEALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8133C40", Offset = "0x8132640", VA = "0x188133C40", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NMHJNAIGJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8134660", Offset = "0x8133060", VA = "0x188134660", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool EKMGJHIKOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x81345A0", Offset = "0x8132FA0", VA = "0x1881345A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FGNINENDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x81331C0", Offset = "0x8131BC0", VA = "0x1881331C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> AENGOBHPBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8132990", Offset = "0x8131390", VA = "0x188132990", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BOKBLMKILFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8132E80", Offset = "0x8131880", VA = "0x188132E80", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool NGPODLIDNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8133D30", Offset = "0x8132730", VA = "0x188133D30", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GNNJGCPBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8132F20", Offset = "0x8131920", VA = "0x188132F20", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FPCFFFNLEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8133DD0", Offset = "0x81327D0", VA = "0x188133DD0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GIDOPFJHPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8133170", Offset = "0x8131B70", VA = "0x188133170", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EDALNKJOKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8134370", Offset = "0x8132D70", VA = "0x188134370", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool POJDFHHOKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8133F30", Offset = "0x8132930", VA = "0x188133F30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool LHGKOHFEBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8133D80", Offset = "0x8132780", VA = "0x188133D80", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HPMPOPPKOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8134550", Offset = "0x8132F50", VA = "0x188134550", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event EGGAHDHJKDH<NGEAHKGPBPA> JNBKGEJMJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x81343C0", Offset = "0x8132DC0", VA = "0x1881343C0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8133B90", Offset = "0x8132590", VA = "0x188133B90", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x369AB30", Offset = "0x3699530", VA = "0x18369AB30", Slot = "6")]
	public (bool, T?) CDAGGIDIEOE<T>(NGEAHKGPBPA MHMGJOPNDFD) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x369AD20", Offset = "0x3699720", VA = "0x18369AD20")]
	public HINPFNPKPJP JCKAHEDPGHE<T>(NGEAHKGPBPA MHMGJOPNDFD, bool IPHIFICKJHD, T PPJFMHBDGNA) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x81347D0", Offset = "0x81331D0", VA = "0x1881347D0")]
	public HINPFNPKPJP(OEADLBOEPJO ODHDBPIMBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8134730", Offset = "0x8133130", VA = "0x188134730")]
	public HINPFNPKPJP(OEADLBOEPJO ODHDBPIMBGI, [Optional] string? INLKCKMBOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8134750", Offset = "0x8133150", VA = "0x188134750")]
	public HINPFNPKPJP(HINPFNPKPJP DEMPADMPLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x81347F0", Offset = "0x81331F0", VA = "0x1881347F0")]
	internal HINPFNPKPJP(OEADLBOEPJO FHLHNEKDPCP, [Optional] string? INLKCKMBOOJ, [Optional] HINPFNPKPJP? DEMPADMPLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x81345F0", Offset = "0x8132FF0", VA = "0x1881345F0")]
	public static MKKKJLDJJHL OGIHMJKNMOJ(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return default(MKKKJLDJJHL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8133EC0", Offset = "0x81328C0", VA = "0x188133EC0")]
	public void KEJJLIADCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8134080", Offset = "0x8132A80", VA = "0x188134080")]
	internal HINPFNPKPJP MGLGJDFFIIP(HINPFNPKPJP MAJPMGPMNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81329F0", Offset = "0x81313F0", VA = "0x1881329F0")]
	internal IReadOnlyCollection<NGEAHKGPBPA> BHGIPDHFJMP(HINPFNPKPJP DEMPADMPLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8134470", Offset = "0x8132E70", VA = "0x188134470")]
	public bool NHDAAPBNPPA(NGEAHKGPBPA MHMGJOPNDFD, bool IPHIFICKJHD, string LDNJLKCCPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8133F80", Offset = "0x8132980", VA = "0x188133F80")]
	public (bool, string) MFGCBOGLAOO(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8133EE0", Offset = "0x81328E0", VA = "0x188133EE0")]
	internal void KNCCIKBGAGF(NGEAHKGPBPA MHMGJOPNDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8132F70", Offset = "0x8131970", VA = "0x188132F70")]
	public EKMNOMDELAN EDPCJDELACB(Func<OEADLBOEPJO, Guid> GOHJPEOOLDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8133210", Offset = "0x8131C10", VA = "0x188133210")]
	public void FMJHHIMIJDD(EKMNOMDELAN DGHLEOKOFAG, Func<Guid, OEADLBOEPJO> PEEOFHMHLEN, [Optional] OEADLBOEPJO? PGBOFLDGGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x81328B0", Offset = "0x81312B0", VA = "0x1881328B0")]
	[CompilerGenerated]
	private void AGPINHBFLOB(NGEAHKGPBPA DCDNJOCDHLF, AOPCPAMFOHH OLLKAEIHDFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MAPPELNLLFK : FOCDJJDPFDL, INFIDBOMNED, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class MIMDLGJNFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HINPFNPKPJP newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public MIMDLGJNFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x813D590", Offset = "0x813BF90", VA = "0x18813D590")]
		internal bool KKFOFBLKPKD(HINPFNPKPJP rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OMJDGDMKCCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public OEADLBOEPJO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public OMJDGDMKCCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1B061D0", Offset = "0x1B04BD0", VA = "0x181B061D0")]
		internal bool LHNADEDIDMG(OEADLBOEPJO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MGEHIMONGLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MAPPELNLLFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public ENCFJAGIPBN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<HJDGMGJGHBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x813CEC0", Offset = "0x813B8C0", VA = "0x18813CEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x813D530", Offset = "0x813BF30", VA = "0x18813D530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EKJBDNKJBOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public EKJBDNKJBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8131C50", Offset = "0x8130650", VA = "0x188131C50")]
		internal void OCKGPLPFFOO(EKMNOMDELAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8131B30", Offset = "0x8130530", VA = "0x188131B30")]
		internal void MPHNBDEFFAH(EKMNOMDELAN r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GLFEAFPACEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public ENCFJAGIPBN roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BCEPAMFPHBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<EKMNOMDELAN, AOPCPAMFOHH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public BCEPAMFPHBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8130390", Offset = "0x812ED90", VA = "0x188130390")]
		internal void EJJMAMHCOGO(EKMNOMDELAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81303C0", Offset = "0x812EDC0", VA = "0x1881303C0")]
		internal void IJMHMGDBLBK(EKMNOMDELAN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x81303F0", Offset = "0x812EDF0", VA = "0x1881303F0")]
		internal void LMBDPMKOALE(EKMNOMDELAN r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class KKDAMHJOLFM<T> where T : notnull
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
			public KKDAMHJOLFM<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<HJDGMGJGHBO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3EAEE10", Offset = "0x3EAD810", VA = "0x183EAEE10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A10", Offset = "0x9F8410", VA = "0x1809F9A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public NGEAHKGPBPA rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OEADLBOEPJO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MKKKJLDJJHL recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MAPPELNLLFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KKDAMHJOLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E04AC0", Offset = "0x4E034C0", VA = "0x184E04AC0")]
		[AsyncStateMachine(typeof(KKDAMHJOLFM<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void BKLIDPAOOHO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ANKGJFMIHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<EKKPJLCDCJH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct EOHKHNFKDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JEBCICNHBOM rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ENCFJAGIPBN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<OEADLBOEPJO, HINPFNPKPJP> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CDENNGLKHCJ debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8131D30", Offset = "0x8130730", VA = "0x188131D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8132850", Offset = "0x8131250", VA = "0x188132850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly JEBCICNHBOM KFIBJOOODJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly BHAJHAEKDEO JBJBKKNIDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CDENNGLKHCJ DCGDAHBNIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, HINPFNPKPJP> DNAOIGDEGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<OEADLBOEPJO, HINPFNPKPJP> HLFBKLFLBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<OEADLBOEPJO, HINPFNPKPJP> OOOLNJCAKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<HINPFNPKPJP> DEGLFKNGLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool FINBDDKFGLC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly NGEAHKGPBPA[] MACMDOPEKGO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NDJPJHIEMNB DFJBHFPLBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<JBFNLPJLCNP> IOIBIJPOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8139940", Offset = "0x8138340", VA = "0x188139940", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CPCCDJOLMNG ALJOLALKEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x813BD30", Offset = "0x813A730", VA = "0x18813BD30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8138220", Offset = "0x8136C20", VA = "0x188138220", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x813BB80", Offset = "0x813A580", VA = "0x18813BB80")]
	[EFEOGKEOEKD.CFCDPMMHJPB]
	internal static void LMIBOGDHNKD(LKOLOODKMPF JACGBGKJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x813CC00", Offset = "0x813B600", VA = "0x18813CC00")]
	[UnityEngine.Scripting.Preserve]
	internal MAPPELNLLFK([GJJKIKPKKBJ(null)] JEBCICNHBOM MCNOJBKAMDC, [GJJKIKPKKBJ(null)] BHAJHAEKDEO JGBCJKNGFKM, [GJJKIKPKKBJ(null)] CDENNGLKHCJ DCGDAHBNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8138CE0", Offset = "0x81376E0", VA = "0x188138CE0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x813ABD0", Offset = "0x81395D0", VA = "0x18813ABD0")]
	private void KGEGAAHNPBD(IEnumerable<HINPFNPKPJP> BBLIAIDBHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8138DF0", Offset = "0x81377F0", VA = "0x188138DF0", Slot = "12")]
	public bool ECMKNIJGCHJ(BKBJMNKBOED DHJCIPPGLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8138CD0", Offset = "0x81376D0", VA = "0x188138CD0")]
	private void DAMHDGCBIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x813A5D0", Offset = "0x8138FD0", VA = "0x18813A5D0")]
	private void IKLFKJGFNJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x813BE70", Offset = "0x813A870", VA = "0x18813BE70", Slot = "10")]
	public IReadOnlyList<JBFNLPJLCNP> NPGNFNBOANK(bool MEPIBDJFOPD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8138EC0", Offset = "0x81378C0", VA = "0x188138EC0", Slot = "11")]
	public JBFNLPJLCNP EFNCJKONONP(BKBJMNKBOED DHJCIPPGLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x813A7B0", Offset = "0x81391B0", VA = "0x18813A7B0")]
	private OEADLBOEPJO IKOOGEHHNIK(BKBJMNKBOED DHJCIPPGLOL)
	{
		return default(OEADLBOEPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8138B40", Offset = "0x8137540", VA = "0x188138B40", Slot = "14")]
	public bool CAMJBMKJMED(BKBJMNKBOED AHKPNJDNAKG, OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x813BDD0", Offset = "0x813A7D0", VA = "0x18813BDD0", Slot = "15")]
	public JBFNLPJLCNP MFJPHHOMFIG(OEADLBOEPJO ODHDBPIMBGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8139C70", Offset = "0x8138670", VA = "0x188139C70")]
	private static bool HNCPDAHMNDC(OMKDGAGOKJN MGHLAKMIFJD, OEADLBOEPJO ODHDBPIMBGI, [Out] EKMNOMDELAN? JDMDBCOBMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x813B430", Offset = "0x8139E30", VA = "0x18813B430")]
	private static void KKGABMDDEHA(OMKDGAGOKJN MGHLAKMIFJD, Action<EKMNOMDELAN> IGKJKICILNF, OEADLBOEPJO INCLMGDFJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x813B520", Offset = "0x8139F20", VA = "0x18813B520")]
	private static void KKGABMDDEHA(OMKDGAGOKJN MGHLAKMIFJD, Action<EKMNOMDELAN> IGKJKICILNF, Predicate<OEADLBOEPJO> NGPDDAMOOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x813B7B0", Offset = "0x813A1B0", VA = "0x18813B7B0")]
	private void LCGNOPGFLED(BKBJMNKBOED DHJCIPPGLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8139FA0", Offset = "0x81389A0", VA = "0x188139FA0", Slot = "4")]
	[AsyncStateMachine(typeof(MGEHIMONGLA))]
	public Task HOBFPDCDPGO([CanBeNull] ENCFJAGIPBN COLBDAEGKBA, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
	public void EEKCNHEHNKL(ENCFJAGIPBN COLBDAEGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x813BEF0", Offset = "0x813A8F0", VA = "0x18813BEF0")]
	private void OGEOHGFOPAC(OMKDGAGOKJN PCOBOEIILKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x813A0C0", Offset = "0x8138AC0", VA = "0x18813A0C0")]
	internal static string HOMONFCMHMM(JEBCICNHBOM KFIBJOOODJF, ENCFJAGIPBN COLBDAEGKBA, IReadOnlyDictionary<OEADLBOEPJO, HINPFNPKPJP> HLFBKLFLBDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x81374C0", Offset = "0x8135EC0", VA = "0x1881374C0")]
	private static void APIDIFJALOC(ENCFJAGIPBN COLBDAEGKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8138FD0", Offset = "0x81379D0", VA = "0x188138FD0")]
	private static void EGBGNNPMFLD(OMKDGAGOKJN CCIAELHEFBP, IReadOnlyDictionary<OEADLBOEPJO, HINPFNPKPJP> HLFBKLFLBDE, StringBuilder KLEHAHBLOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x813BA70", Offset = "0x813A470", VA = "0x18813BA70")]
	private static bool LJJEBNIMNEB(string GELIBLKBEHH, [Out] Guid DEFFKKEPCCN, [Out] OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x81382C0", Offset = "0x8136CC0", VA = "0x1881382C0")]
	private static void BODNHEFLKBC(ENCFJAGIPBN COLBDAEGKBA, StringBuilder KLEHAHBLOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x37449F0", Offset = "0x37433F0", VA = "0x1837449F0", Slot = "16")]
	public bool MAJDBPENMAL<T>(OEADLBOEPJO ODHDBPIMBGI, NGEAHKGPBPA MHMGJOPNDFD, bool IPHIFICKJHD, T JDKFBOCIIAB, [Optional] Action CKNPDPOANGJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x813C9C0", Offset = "0x813B3C0", VA = "0x18813C9C0", Slot = "17")]
	public string PPCJGHEBOPJ(NGEAHKGPBPA MHMGJOPNDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x813A3D0", Offset = "0x8138DD0", VA = "0x18813A3D0")]
	private void IFBOKNPEHHK(OEADLBOEPJO ODHDBPIMBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x813BA50", Offset = "0x813A450", VA = "0x18813BA50")]
	private bool LJENBPPFBJO(BKBJMNKBOED DHJCIPPGLOL, OEADLBOEPJO ODHDBPIMBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x813A880", Offset = "0x8139280", VA = "0x18813A880")]
	internal HINPFNPKPJP IPMIOBBIPPN(BKBJMNKBOED DHJCIPPGLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x813ABC0", Offset = "0x81395C0", VA = "0x18813ABC0", Slot = "13")]
	public IReadOnlyList<JBFNLPJLCNP> JNAIAGICPGF(BKBJMNKBOED DHJCIPPGLOL, bool LAGPJALDCBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x813B820", Offset = "0x813A220", VA = "0x18813B820")]
	internal IReadOnlyList<HINPFNPKPJP> LGAGOPNGEKC(BKBJMNKBOED DHJCIPPGLOL, bool LAGPJALDCBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x813C230", Offset = "0x813AC30", VA = "0x18813C230")]
	private void PKABGFCJJPC(HJDGMGJGHBO LABGLFOBGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8139990", Offset = "0x8138390", VA = "0x188139990")]
	private static bool HKPKILMIOPK(HINPFNPKPJP FLKFADICGGD, IReadOnlyDictionary<OEADLBOEPJO, HINPFNPKPJP> HLFBKLFLBDE, [Out] IReadOnlyList<NGEAHKGPBPA> HNIEOILIMIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8138A00", Offset = "0x8137400", VA = "0x188138A00")]
	[AsyncStateMachine(typeof(EOHKHNFKDFJ))]
	private static Task BPEOJMIAHME(JEBCICNHBOM KFIBJOOODJF, ENCFJAGIPBN COLBDAEGKBA, IReadOnlyDictionary<OEADLBOEPJO, HINPFNPKPJP> HLFBKLFLBDE, CDENNGLKHCJ DCGDAHBNIII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x81396A0", Offset = "0x81380A0", VA = "0x1881396A0")]
	[CompilerGenerated]
	internal static void HFDDKABFABI(Func<EKMNOMDELAN, AOPCPAMFOHH> IGKKKBIJONJ, GLFEAFPACEF P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8139320", Offset = "0x8137D20", VA = "0x188139320")]
	[CompilerGenerated]
	internal static bool GDBIBGDHPCO(OEADLBOEPJO ODHDBPIMBGI, NGEAHKGPBPA MHMGJOPNDFD, [Out] EKKPJLCDCJH IEIPFDBECBE, ANKGJFMIHOP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface CDCODPKJFJN
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJAMFLOIHGN(BKBJMNKBOED DHCGLPCOFLF, BKBJMNKBOED CEIGONBNEJP, IEnumerable<BKBJMNKBOED> GBGAOKCKELD, [Out] AODMDNIIPGL AMJMFHNPKEE, [Out] ENFGAELCLHG IINONFJAPGM);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JAALJEKOGGA(ENFGAELCLHG BFIGDKICPFK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum ENFGAELCLHG : byte
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
internal class AIJBGMBFBIL : CDCODPKJFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly INFIDBOMNED HHHIEGGNCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly PAKOBINAFGI AGFFDAILCKG;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	[RecRoom.NoEngine.Common.Preserve]
	public AIJBGMBFBIL([GJJKIKPKKBJ(null)] INFIDBOMNED HNMIOGFPLFD, [GJJKIKPKKBJ(null)] PAKOBINAFGI COGBCMIKGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8130350", Offset = "0x812ED50", VA = "0x188130350")]
	private static COIBAOOKNFN? KPCILIJKGLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x812FB30", Offset = "0x812E530", VA = "0x18812FB30", Slot = "4")]
	public bool HJAMFLOIHGN(BKBJMNKBOED DHCGLPCOFLF, BKBJMNKBOED CEIGONBNEJP, IEnumerable<BKBJMNKBOED> GBGAOKCKELD, [Out] AODMDNIIPGL AMJMFHNPKEE, [Out] ENFGAELCLHG IINONFJAPGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x812FC30", Offset = "0x812E630", VA = "0x18812FC30", Slot = "5")]
	public string JAALJEKOGGA(ENFGAELCLHG BFIGDKICPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x812FD30", Offset = "0x812E730", VA = "0x18812FD30")]
	internal bool JNMFEKFDHML(BKBJMNKBOED DHCGLPCOFLF, BKBJMNKBOED CEIGONBNEJP, IEnumerable<BKBJMNKBOED> GBGAOKCKELD, AKGPNEALNMD ABDKGJKIOJH, COIBAOOKNFN? FAFKFGACHOB, [Out] AODMDNIIPGL AMJMFHNPKEE, [Out] ENFGAELCLHG IINONFJAPGM)
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
