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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x803AD10", Offset = "0x803A110", VA = "0x18803AD10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum NABIBCDMDDD
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
		[Cpp2IlInjected.Address(RVA = "0x803BEB0", Offset = "0x803B2B0", VA = "0x18803BEB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MMIFGDOAGIO<TPermission>(TPermission MNHDDCPOMKF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HPFIKKKFDIF(FEIKLGLBIHI CALAFNPECBD);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DFKFLJNFNNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HHNOKHDGFGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BKPDEGHDKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool INEACJJGPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IOPPGKOGPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IAIEMGICLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NPNLENJBNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BJLGFCOPIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class AABEIBNLMME
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum IKJKKPAABDE
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
	public static readonly Guid MKANPHKBHBP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid JHLHMOLJGMI;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid OAMOHMFAIHI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid JCHLPKCBHDA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid BELODBJLEAP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid MLOPAIGGLGD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PLPEPNLAPAF<HJMLLMJGAOM, Guid> MBIEAELNBEN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<HJMLLMJGAOM> IBKMAFLPPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x802DBC0", Offset = "0x802CFC0", VA = "0x18802DBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x802DA50", Offset = "0x802CE50", VA = "0x18802DA50")]
	public static HJMLLMJGAOM FBCBFJILIEG(Guid IIBHEJCKGGH)
	{
		return default(HJMLLMJGAOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x802DB20", Offset = "0x802CF20", VA = "0x18802DB20")]
	public static Guid MOHKCKKLHOM(HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x802D870", Offset = "0x802CC70", VA = "0x18802D870")]
	public static bool APAJEAKMDCM(HJMLLMJGAOM CPPAPHBMPAH, [Out] Guid IIBHEJCKGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x802D900", Offset = "0x802CD00", VA = "0x18802D900")]
	public static bool BDFLKCNDEFJ(Guid IIBHEJCKGGH, [Out] HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x802DAE0", Offset = "0x802CEE0", VA = "0x18802DAE0")]
	public static HJMLLMJGAOM FNFFDDAJEAJ(HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(HJMLLMJGAOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x802D9A0", Offset = "0x802CDA0", VA = "0x18802D9A0")]
	public static IKJKKPAABDE CLEGHMFMIOE(HJMLLMJGAOM FGMPPKALIJF)
	{
		return default(IKJKKPAABDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x802D830", Offset = "0x802CC30", VA = "0x18802D830")]
	internal static HJMLLMJGAOM ACGEALJCGJM(IKJKKPAABDE IHPDMKCLPFD)
	{
		return default(HJMLLMJGAOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OAGGGHJPEKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NIKGMMIMGFA OFPODBKFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<OEDMBEDKGCC> AINNDJONIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HPFIKKKFDIF HBIKDGCHHBH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<OEDMBEDKGCC> BCFGCNGOJOG(bool FGHGMAHNPHB = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OEDMBEDKGCC KAAAFDOPPNJ(FEIKLGLBIHI CALAFNPECBD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HEFOKIHAHIN(FEIKLGLBIHI CALAFNPECBD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<OEDMBEDKGCC> OHLJLEHMEPF(FEIKLGLBIHI CALAFNPECBD, bool MIINCKMJFNF = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KBLHKMJIDFB(FEIKLGLBIHI HACLDAGJIMM, HJMLLMJGAOM CPPAPHBMPAH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OEDMBEDKGCC NGLDHEIOMJH(HJMLLMJGAOM CPPAPHBMPAH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PMDIHJJIJHK<T>(HJMLLMJGAOM CPPAPHBMPAH, GHIPGOHOIDJ MNHDDCPOMKF, bool CEKNINAGLLA, T PKKPPHDAMAG, [Optional] Action JEDNPMPANDH) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string EPMGICIPMLO(GHIPGOHOIDJ MNHDDCPOMKF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IJPFKAJAJLA
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IHNPGNDAFFC(BPGLDJMOGPH BDAPIDPALOK, CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAKBNDDIIEN(BPGLDJMOGPH BDAPIDPALOK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MPAFPFABIAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FEIKLGLBIHI FHNCGKJHDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MEMBODLLNEP IFDIOLBKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KDNGIJKMAJN MAKCLLHGJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MACOMPOLJDK> ACPMHNLEKNB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ALLEHLIGCFA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HJMLLMJGAOM EPGDIIEFPGG(FEIKLGLBIHI CALAFNPECBD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MACOMPOLJDK> JFEFKLKFFHJ(CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task EMBIINOCLAK(long CCHPCHDJHAI, IReadOnlyList<AAFMDGKIHAA> IOBPOHEDEKP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FPFILHFNABG(long CCHPCHDJHAI, long CLKFEHDHMIF, IReadOnlyList<AAFMDGKIHAA> IOBPOHEDEKP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FEIKLGLBIHI> OELIMNPPDKD();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KMHNOLKFBKN
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8037D30", Offset = "0x8037130", VA = "0x188037D30")]
	public static HJMLLMJGAOM FGHAENAFMFA(this MPAFPFABIAC DDDAEFBIEFM)
	{
		return default(HJMLLMJGAOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KHPCELFDDKK<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string MKFLGFDPKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event MMIFGDOAGIO<TPermission> BKECCJNEHDM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class OIPPDDNFLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? APMFFJAELBA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? MCIKBFONPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x803AE90", Offset = "0x803A290", VA = "0x18803AE90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x803AD90", Offset = "0x803A190", VA = "0x18803AD90")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x803AF70", Offset = "0x803A370", VA = "0x18803AF70")]
	protected OIPPDDNFLDM(object? BOFIDJNAOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FFMDCEDPLLA(object? FIIKLGCIAGG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EFOHOEIBKAC<T> : OIPPDDNFLDM where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> JNJOJFOHKOO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4273BD0", Offset = "0x4272FD0", VA = "0x184273BD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x42739D0", Offset = "0x4272DD0", VA = "0x1842739D0", Slot = "4")]
	public override bool FFMDCEDPLLA(object? FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4274080", Offset = "0x4273480", VA = "0x184274080")]
	public bool MANCEKNBMDK(T BJJLIBFLLKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4274470", Offset = "0x4273870", VA = "0x184274470")]
	public EFOHOEIBKAC(T MBADHELIPJM, IEqualityComparer<T> JNJOJFOHKOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DKKBAIACIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<GHIPGOHOIDJ, bool> INKIIEGDEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<GHIPGOHOIDJ, OIPPDDNFLDM> NEIECFNGBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NHLCDHNABIE BJDJOCEFAMB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80340E0", Offset = "0x80334E0", VA = "0x1880340E0")]
	public DKKBAIACIBA(NHLCDHNABIE BJDJOCEFAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8033B20", Offset = "0x8032F20", VA = "0x188033B20")]
	public bool APADMOENLFC(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34184F0", Offset = "0x34178F0", VA = "0x1834184F0")]
	public bool APJNDPMPCHE<T>(GHIPGOHOIDJ MNHDDCPOMKF, bool CEKNINAGLLA, T FIIKLGCIAGG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3418AD0", Offset = "0x3417ED0", VA = "0x183418AD0")]
	public (bool, T?) LDBCPCOBMHJ<T>(GHIPGOHOIDJ MNHDDCPOMKF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8033B90", Offset = "0x8032F90", VA = "0x188033B90")]
	public bool APJNDPMPCHE(GHIPGOHOIDJ MNHDDCPOMKF, bool CEKNINAGLLA, object FIIKLGCIAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8033F40", Offset = "0x8033340", VA = "0x188033F40")]
	public (bool, object) LDBCPCOBMHJ(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3418A70", Offset = "0x3417E70", VA = "0x183418A70")]
	private void EGDKJFFMMBH<T>(GHIPGOHOIDJ MNHDDCPOMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8033E70", Offset = "0x8033270", VA = "0x188033E70")]
	private OIPPDDNFLDM ECCPEOBEAJP(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8033C70", Offset = "0x8033070", VA = "0x188033C70")]
	public void BDAAALFIGHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class BECBFJDAINO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ELJBCFEHELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type OHMKODLEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly ODJMGIAGKDJ PGEDMJBHGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly GHIPGOHOIDJ KBDHGGLOEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PDJGMDLDIKD CLABCDHGOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LJPHJNJEMFE OEDLAFAGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FCJLCAFMLOI EFBHGGCAAPE;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8033A80", Offset = "0x8032E80", VA = "0x188033A80")]
	public BECBFJDAINO(Type ACIAEMJGIOA, string NLAJKHJAKLM, GHIPGOHOIDJ MNHDDCPOMKF, PDJGMDLDIKD CFPMDEPOIJK, LJPHJNJEMFE IFGODMOAOLI, FCJLCAFMLOI NFAKHFDIMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8033A30", Offset = "0x8032E30", VA = "0x188033A30")]
	public object NFIPDIGEGDI(object? JAPIEEBOJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x335C140", Offset = "0x335B540", VA = "0x18335C140")]
	public void EGDKJFFMMBH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8033980", Offset = "0x8032D80", VA = "0x188033980")]
	public void EGDKJFFMMBH(Type OKOHJJHLFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HGPCCJJHPBH<T> : BECBFJDAINO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string GFCCJCFIMJN(T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T ANBAPLNDBJO(string? JCEFPKENDFK, T MBADHELIPJM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class FEMDJKHBEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GFCCJCFIMJN serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public ANBAPLNDBJO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FEMDJKHBEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x46C51F0", Offset = "0x46C45F0", VA = "0x1846C51F0")]
		internal string GLDKGICDEPL(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x46C52C0", Offset = "0x46C46C0", VA = "0x1846C52C0")]
		internal object KMPMPAEMPPM(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4886DE0", Offset = "0x48861E0", VA = "0x184886DE0")]
	public HGPCCJJHPBH(GHIPGOHOIDJ MNHDDCPOMKF, string NLAJKHJAKLM, [Optional] GFCCJCFIMJN? CFPMDEPOIJK, [Optional] ANBAPLNDBJO? IFGODMOAOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4886AC0", Offset = "0x4885EC0", VA = "0x184886AC0")]
	private static object? OJJOMCGFFJC(ANBAPLNDBJO? IFGODMOAOLI, string? JCEFPKENDFK, object? MBADHELIPJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x48861D0", Offset = "0x48855D0", VA = "0x1848861D0")]
	private static string LMGGAKIACNI(GFCCJCFIMJN? KNOFMFKDGNB, object? FIIKLGCIAGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string PDJGMDLDIKD(object? FIIKLGCIAGG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object LJPHJNJEMFE(string? JCEFPKENDFK, [Optional] object MBADHELIPJM);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate OIPPDDNFLDM FCJLCAFMLOI();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class NHLCDHNABIE
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DPJDGJPEIGI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static DPJDGJPEIGI DMADMDPHOOL;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8034390", Offset = "0x8033790", VA = "0x188034390", Slot = "4")]
		public bool Equals(List<string> JFJPEDLJOKC, List<string> MJINJIJLGDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x80344E0", Offset = "0x80338E0", VA = "0x1880344E0", Slot = "5")]
		public int GetHashCode(List<string> HAPOBHMBDHP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DPJDGJPEIGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class LFMDAAFLLPO : FLBIAAIFCHH<NABIBCDMDDD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8038AF0", Offset = "0x8037EF0", VA = "0x188038AF0", Slot = "9")]
		public override string LMGGAKIACNI(NABIBCDMDDD BEAPIEHNNIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8038910", Offset = "0x8037D10", VA = "0x188038910", Slot = "10")]
		protected override bool EFJBOHLINAN(string BEAPIEHNNIB, [Out] NABIBCDMDDD FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8038BE0", Offset = "0x8037FE0", VA = "0x188038BE0")]
		public LFMDAAFLLPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly MPMOIDJONII CDLMJEKEEOF;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly LFMDAAFLLPO PAKMOGJOBKJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<BECBFJDAINO> KHBMNIBKEBL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<GHIPGOHOIDJ> HAKJLEKHDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<GHIPGOHOIDJ, BECBFJDAINO> BPDCBCOCAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x803A190", Offset = "0x8039590", VA = "0x18803A190")]
	public NHLCDHNABIE([Optional] IList<BECBFJDAINO>? GGHPHHPGJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8038C20", Offset = "0x8038020", VA = "0x188038C20")]
	public BECBFJDAINO CKIJHHPIHMH(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NIKGMMIMGFA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	OEDMBEDKGCC IADIGIMLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class EGBMLKKIBLH : NIKGMMIMGFA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static EGBMLKKIBLH DGOFCMGLNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly EIOGJOIPKPC IJAFMPLKIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<EIOGJOIPKPC> LNKDFDEJCNE;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OEDMBEDKGCC IADIGIMLCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x80358D0", Offset = "0x8034CD0", VA = "0x1880358D0")]
	public EGBMLKKIBLH(EIOGJOIPKPC EAMKOFBGFLN, IReadOnlyList<EIOGJOIPKPC> FBICNNFLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x80349C0", Offset = "0x8033DC0", VA = "0x1880349C0")]
	private static EGBMLKKIBLH BEDBGLOAFCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class EBJLCLHDDBE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<HJMLLMJGAOM> CIPLDPDHMIF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x80346C0", Offset = "0x8033AC0", VA = "0x1880346C0")]
	public static bool HJDGJFAAKIA(this FEIKLGLBIHI HNCNLBLNACH, HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x80347A0", Offset = "0x8033BA0", VA = "0x1880347A0")]
	public static bool PIMOLLFHNIJ(this FEIKLGLBIHI HNCNLBLNACH, HJMLLMJGAOM CPPAPHBMPAH, KDNGIJKMAJN PIHDLOODHLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HCOOBGKLABN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MAHLDMACPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FPCLFPBMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JJBGOMGFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KHHPBOKDLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MLGDNPINHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NPGAIFOOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FPKKKKNHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IFDEIHJKAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool COBAPBKNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OMEBCBGOBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DCIGNAEEONL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool EKLKLAKEOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> DPDEIHOOJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NABIBCDMDDD MPGMCDNIAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OEDMBEDKGCC : HCOOBGKLABN, HHNOKHDGFGO, KHPCELFDDKK<GHIPGOHOIDJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string DKGNDPBLAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HJMLLMJGAOM EMGOPMKDEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) DKNKJLAFOCI<T>(GHIPGOHOIDJ MNHDDCPOMKF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum GHIPGOHOIDJ
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
internal class EIOGJOIPKPC : OEDMBEDKGCC, HCOOBGKLABN, HHNOKHDGFGO, KHPCELFDDKK<GHIPGOHOIDJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly NHLCDHNABIE GOGELEENOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly DKKBAIACIBA OCENCDBOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? LCEENGBFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? PCBIGKPMMFC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool GONDKGACMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8035C70", Offset = "0x8035070", VA = "0x188035C70", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool DHGHCJOBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x80359E0", Offset = "0x8034DE0", VA = "0x1880359E0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool ANKBIIIDCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8035E70", Offset = "0x8035270", VA = "0x188035E70", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool IICAKFIOLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8035EC0", Offset = "0x80352C0", VA = "0x188035EC0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool AJMAOPJAOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8036060", Offset = "0x8035460", VA = "0x188036060", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool CNDOGCJDKBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8035F10", Offset = "0x8035310", VA = "0x188035F10", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HJMLLMJGAOM EMGOPMKDEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA110A0", Offset = "0xA104A0", VA = "0x180A110A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HJMLLMJGAOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x996F20", Offset = "0x996320", VA = "0x180996F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string MKFLGFDPKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8037790", Offset = "0x8036B90", VA = "0x188037790", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8037440", Offset = "0x8036840", VA = "0x188037440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string DKGNDPBLAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8037790", Offset = "0x8036B90", VA = "0x188037790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ABNPECFPOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCD6B30", Offset = "0xCD5F30", VA = "0x180CD6B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCD6B50", Offset = "0xCD5F50", VA = "0x180CD6B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MAHLDMACPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8037350", Offset = "0x8036750", VA = "0x188037350", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NABIBCDMDDD MPGMCDNIAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80373A0", Offset = "0x80367A0", VA = "0x1880373A0", Slot = "20")]
		get
		{
			return default(NABIBCDMDDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FPCLFPBMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8036550", Offset = "0x8035950", VA = "0x188036550", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JJBGOMGFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80372B0", Offset = "0x80366B0", VA = "0x1880372B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool KHHPBOKDLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8035D80", Offset = "0x8035180", VA = "0x188035D80", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MLGDNPINHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8035DD0", Offset = "0x80351D0", VA = "0x188035DD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NPGAIFOOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8035AB0", Offset = "0x8034EB0", VA = "0x188035AB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FPKKKKNHDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x80365A0", Offset = "0x80359A0", VA = "0x1880365A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IFDEIHJKAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x80373F0", Offset = "0x80367F0", VA = "0x1880373F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool COBAPBKNIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8037260", Offset = "0x8036660", VA = "0x188037260", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> DPDEIHOOJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8035A50", Offset = "0x8034E50", VA = "0x188035A50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IBPEBPALIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8035C70", Offset = "0x8035070", VA = "0x188035C70", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KBFHOBNDIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8036060", Offset = "0x8035460", VA = "0x188036060", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool ODOMKOKCDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x80359E0", Offset = "0x8034DE0", VA = "0x1880359E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool OMEBCBGOBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8037300", Offset = "0x8036700", VA = "0x188037300", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool DCIGNAEEONL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8035D30", Offset = "0x8035130", VA = "0x188035D30", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MAEAGBDDCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8035E70", Offset = "0x8035270", VA = "0x188035E70", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool EKLKLAKEOPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8037490", Offset = "0x8036890", VA = "0x188037490", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FFMBANLFCLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8035EC0", Offset = "0x80352C0", VA = "0x188035EC0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NEMAIONKCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8035F10", Offset = "0x8035310", VA = "0x188035F10", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MMIFGDOAGIO<GHIPGOHOIDJ> BKECCJNEHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x80374E0", Offset = "0x80368E0", VA = "0x1880374E0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80364A0", Offset = "0x80358A0", VA = "0x1880364A0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3440B70", Offset = "0x343FF70", VA = "0x183440B70", Slot = "6")]
	public (bool, T?) DKNKJLAFOCI<T>(GHIPGOHOIDJ MNHDDCPOMKF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3440B10", Offset = "0x343FF10", VA = "0x183440B10")]
	public EIOGJOIPKPC ACCOOOPMMIO<T>(GHIPGOHOIDJ MNHDDCPOMKF, bool CEKNINAGLLA, T FIIKLGCIAGG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8037880", Offset = "0x8036C80", VA = "0x188037880")]
	public EIOGJOIPKPC(HJMLLMJGAOM CPPAPHBMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8037860", Offset = "0x8036C60", VA = "0x188037860")]
	public EIOGJOIPKPC(HJMLLMJGAOM CPPAPHBMPAH, [Optional] string? LCEENGBFHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x80378A0", Offset = "0x8036CA0", VA = "0x1880378A0")]
	public EIOGJOIPKPC(EIOGJOIPKPC DOFOFFLJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8037920", Offset = "0x8036D20", VA = "0x188037920")]
	internal EIOGJOIPKPC(HJMLLMJGAOM EOGEBKJFEDA, [Optional] string? LCEENGBFHOF, [Optional] EIOGJOIPKPC? DOFOFFLJABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8035CC0", Offset = "0x80350C0", VA = "0x188035CC0")]
	public static ODJMGIAGKDJ DGBDFFLBKIO(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return default(ODJMGIAGKDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8035A30", Offset = "0x8034E30", VA = "0x188035A30")]
	public void BDAAALFIGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x80365F0", Offset = "0x80359F0", VA = "0x1880365F0")]
	internal EIOGJOIPKPC IBNDPJGCLBG(EIOGJOIPKPC MNMPPDPIFDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x80360B0", Offset = "0x80354B0", VA = "0x1880360B0")]
	internal IReadOnlyCollection<GHIPGOHOIDJ> GHNGGIODPCD(EIOGJOIPKPC DOFOFFLJABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8035B00", Offset = "0x8034F00", VA = "0x188035B00")]
	public bool CEHPAJIFOJJ(GHIPGOHOIDJ MNHDDCPOMKF, bool CEKNINAGLLA, string MLHMFKMMBKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8035F60", Offset = "0x8035360", VA = "0x188035F60")]
	public (bool, string) FKCCCJCFJOJ(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8035E20", Offset = "0x8035220", VA = "0x188035E20")]
	internal void FBPHDJDGJIH(GHIPGOHOIDJ MNHDDCPOMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8037590", Offset = "0x8036990", VA = "0x188037590")]
	public AKAIMFIBNCN PAACKGIFGKO(Func<HJMLLMJGAOM, Guid> MGEMHGAEPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80368E0", Offset = "0x8035CE0", VA = "0x1880368E0")]
	public void IEJPPENANJL(AKAIMFIBNCN PIEKFFHDFLK, Func<Guid, HJMLLMJGAOM> EKLMBIPCICC, [Optional] HJMLLMJGAOM? OHFINACEPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8035BE0", Offset = "0x8034FE0", VA = "0x188035BE0")]
	[CompilerGenerated]
	private void CEMKBJKJFNL(GHIPGOHOIDJ ALHINPFPLNG, KFIPKGFLFDI OCNFELLANJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class AOFNOKHNCAC : IJPFKAJAJLA, OAGGGHJPEKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JKEKPJNDGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EIOGJOIPKPC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JKEKPJNDGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8037D00", Offset = "0x8037100", VA = "0x188037D00")]
		internal bool FBPKIMJPKPG(EIOGJOIPKPC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FPBJGLKMJIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public HJMLLMJGAOM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FPBJGLKMJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1AA7C20", Offset = "0x1AA7020", VA = "0x181AA7C20")]
		internal bool OEBKONKMPNF(HJMLLMJGAOM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct OJMLJPFIEPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AOFNOKHNCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BPGLDJMOGPH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<MACOMPOLJDK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x803B080", Offset = "0x803A480", VA = "0x18803B080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x803B6F0", Offset = "0x803AAF0", VA = "0x18803B6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GKFGFJJNOCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GKFGFJJNOCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8037A70", Offset = "0x8036E70", VA = "0x188037A70")]
		internal void JBFEJPKJLBB(AKAIMFIBNCN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8037B50", Offset = "0x8036F50", VA = "0x188037B50")]
		internal void JHDOCOBDBNB(AKAIMFIBNCN r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct JALCCCBILDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BPGLDJMOGPH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IIJBKNMOHGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<AKAIMFIBNCN, KFIPKGFLFDI> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IIJBKNMOHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8037CA0", Offset = "0x80370A0", VA = "0x188037CA0")]
		internal void LEANHACENDF(AKAIMFIBNCN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8037CD0", Offset = "0x80370D0", VA = "0x188037CD0")]
		internal void NMEMAJJCOIF(AKAIMFIBNCN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8037C70", Offset = "0x8037070", VA = "0x188037C70")]
		internal void CCPLIDHDANC(AKAIMFIBNCN r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EPHACOFLIKL<T> where T : notnull
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
			public EPHACOFLIKL<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<MACOMPOLJDK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x3E5BC70", Offset = "0x3E5B070", VA = "0x183E5BC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GHIPGOHOIDJ rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public HJMLLMJGAOM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ODJMGIAGKDJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AOFNOKHNCAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EPHACOFLIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x42BA6F0", Offset = "0x42B9AF0", VA = "0x1842BA6F0")]
		[AsyncStateMachine(typeof(EPHACOFLIKL<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void FEFGNPEKOGH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JGKKMAGNFNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<AAFMDGKIHAA> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct KNHLLOADNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public MPAFPFABIAC rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BPGLDJMOGPH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<HJMLLMJGAOM, EIOGJOIPKPC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FEHNCHIDFDG debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8037D90", Offset = "0x8037190", VA = "0x188037D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x80388B0", Offset = "0x8037CB0", VA = "0x1880388B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly MPAFPFABIAC DDDAEFBIEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EGBMLKKIBLH FENDKJLAABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly FEHNCHIDFDG EJEHNGBDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, EIOGJOIPKPC> FFECGIMLGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<HJMLLMJGAOM, EIOGJOIPKPC> LIMEMNBFDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<HJMLLMJGAOM, EIOGJOIPKPC> ACNFNMEGBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<EIOGJOIPKPC> FOHJKJGNHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool JEGHIEIKLIH;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly GHIPGOHOIDJ[] FGDBDHOBGLF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NIKGMMIMGFA OFPODBKFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<OEDMBEDKGCC> AINNDJONIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80302A0", Offset = "0x802F6A0", VA = "0x1880302A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HPFIKKKFDIF HBIKDGCHHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8032820", Offset = "0x8031C20", VA = "0x188032820", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8032080", Offset = "0x8031480", VA = "0x188032080", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80317F0", Offset = "0x8030BF0", VA = "0x1880317F0")]
	[BOBPNFIGGBE.IMBCNFJLKJE]
	internal static void KKOCPHMJODH(NPIEGGOELNH FLKEBBNIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80336C0", Offset = "0x8032AC0", VA = "0x1880336C0")]
	[UnityEngine.Scripting.Preserve]
	internal AOFNOKHNCAC([GKAMHFFOHNI(null)] MPAFPFABIAC IBIBINPPOJJ, [GKAMHFFOHNI(null)] EGBMLKKIBLH NPEGJEJEJEB, [GKAMHFFOHNI(null)] FEHNCHIDFDG EJEHNGBDFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8030190", Offset = "0x802F590", VA = "0x188030190", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x80328C0", Offset = "0x8031CC0", VA = "0x1880328C0")]
	private void OEMIEBDJCND(IEnumerable<EIOGJOIPKPC> PAABEFFALLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8030360", Offset = "0x802F760", VA = "0x188030360", Slot = "12")]
	public bool HEFOKIHAHIN(FEIKLGLBIHI CALAFNPECBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x802EFD0", Offset = "0x802E3D0", VA = "0x18802EFD0")]
	private void ALLEHLIGCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x802F060", Offset = "0x802E460", VA = "0x18802F060")]
	private void BIFMPNIIJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x802EFE0", Offset = "0x802E3E0", VA = "0x18802EFE0", Slot = "10")]
	public IReadOnlyList<OEDMBEDKGCC> BCFGCNGOJOG(bool FGHGMAHNPHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8030A90", Offset = "0x802FE90", VA = "0x188030A90", Slot = "11")]
	public OEDMBEDKGCC KAAAFDOPPNJ(FEIKLGLBIHI CALAFNPECBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x80326B0", Offset = "0x8031AB0", VA = "0x1880326B0")]
	private HJMLLMJGAOM MEDPEEJKNFC(FEIKLGLBIHI CALAFNPECBD)
	{
		return default(HJMLLMJGAOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8030BA0", Offset = "0x802FFA0", VA = "0x188030BA0", Slot = "14")]
	public bool KBLHKMJIDFB(FEIKLGLBIHI HACLDAGJIMM, HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8032780", Offset = "0x8031B80", VA = "0x188032780", Slot = "15")]
	public OEDMBEDKGCC NGLDHEIOMJH(HJMLLMJGAOM CPPAPHBMPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8030D30", Offset = "0x8030130", VA = "0x188030D30")]
	private static bool KCJAAIMPGPO(LENBOBOAKKK OHNPPPPKAPG, HJMLLMJGAOM CPPAPHBMPAH, [Out] AKAIMFIBNCN? GDMEOBGAFBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8031F90", Offset = "0x8031390", VA = "0x188031F90")]
	private static void KLJLDCDHPEP(LENBOBOAKKK OHNPPPPKAPG, Action<AKAIMFIBNCN> FJGGBDBGJAH, HJMLLMJGAOM JGCEDCGPLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8031D00", Offset = "0x8031100", VA = "0x188031D00")]
	private static void KLJLDCDHPEP(LENBOBOAKKK OHNPPPPKAPG, Action<AKAIMFIBNCN> FJGGBDBGJAH, Predicate<HJMLLMJGAOM> MEJLDKPGOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8030430", Offset = "0x802F830", VA = "0x188030430")]
	private void HNMPMCGLDCC(FEIKLGLBIHI CALAFNPECBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8030740", Offset = "0x802FB40", VA = "0x188030740", Slot = "4")]
	[AsyncStateMachine(typeof(OJMLJPFIEPH))]
	public Task IHNPGNDAFFC([CanBeNull] BPGLDJMOGPH BDAPIDPALOK, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
	public void BAKBNDDIIEN(BPGLDJMOGPH BDAPIDPALOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8032120", Offset = "0x8031520", VA = "0x188032120")]
	private void KPBPNJMHAJJ(LENBOBOAKKK BPFCNJAMJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x802FE80", Offset = "0x802F280", VA = "0x18802FE80")]
	internal static string CNBLPNLOGBA(MPAFPFABIAC DDDAEFBIEFM, BPGLDJMOGPH BDAPIDPALOK, IReadOnlyDictionary<HJMLLMJGAOM, EIOGJOIPKPC> LIMEMNBFDIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x802DF20", Offset = "0x802D320", VA = "0x18802DF20")]
	private static void ABFHJOLBJBL(BPGLDJMOGPH BDAPIDPALOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x80319B0", Offset = "0x8030DB0", VA = "0x1880319B0")]
	private static void KLAALKEAGEM(LENBOBOAKKK PGMBEJBALIK, IReadOnlyDictionary<HJMLLMJGAOM, EIOGJOIPKPC> LIMEMNBFDIM, StringBuilder COOFCJPGDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80325A0", Offset = "0x80319A0", VA = "0x1880325A0")]
	private static bool LHGGHFEPFOE(string ENDFCPNFAPI, [Out] Guid ACBACBHNLAM, [Out] HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x802F740", Offset = "0x802EB40", VA = "0x18802F740")]
	private static void CJEJLNLGNGH(BPGLDJMOGPH BDAPIDPALOK, StringBuilder COOFCJPGDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D66AD0", Offset = "0x3D65ED0", VA = "0x183D66AD0", Slot = "16")]
	public bool PMDIHJJIJHK<T>(HJMLLMJGAOM CPPAPHBMPAH, GHIPGOHOIDJ MNHDDCPOMKF, bool CEKNINAGLLA, T PKKPPHDAMAG, [Optional] Action JEDNPMPANDH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x80302F0", Offset = "0x802F6F0", VA = "0x1880302F0", Slot = "17")]
	public string EPMGICIPMLO(GHIPGOHOIDJ MNHDDCPOMKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x802F530", Offset = "0x802E930", VA = "0x18802F530")]
	private void CHBKLOGHLIF(HJMLLMJGAOM CPPAPHBMPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80334D0", Offset = "0x80328D0", VA = "0x1880334D0")]
	private bool PEDEEKAEDJD(FEIKLGLBIHI CALAFNPECBD, HJMLLMJGAOM CPPAPHBMPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x802EC80", Offset = "0x802E080", VA = "0x18802EC80")]
	internal EIOGJOIPKPC AKOBOJEOCFO(FEIKLGLBIHI CALAFNPECBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8033140", Offset = "0x8032540", VA = "0x188033140", Slot = "13")]
	public IReadOnlyList<OEDMBEDKGCC> OHLJLEHMEPF(FEIKLGLBIHI CALAFNPECBD, bool MIINCKMJFNF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8030860", Offset = "0x802FC60", VA = "0x188030860")]
	internal IReadOnlyList<EIOGJOIPKPC> JCNBKAJOKIN(FEIKLGLBIHI CALAFNPECBD, bool MIINCKMJFNF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8031060", Offset = "0x8030460", VA = "0x188031060")]
	private void KEMKMMNPIEK(MACOMPOLJDK IFFGIAKNKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x802F250", Offset = "0x802E650", VA = "0x18802F250")]
	private static bool CHAKODOPGOK(EIOGJOIPKPC PIDANEHANOE, IReadOnlyDictionary<HJMLLMJGAOM, EIOGJOIPKPC> LIMEMNBFDIM, [Out] IReadOnlyList<GHIPGOHOIDJ> CNEOEPEKNNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8032460", Offset = "0x8031860", VA = "0x188032460")]
	[AsyncStateMachine(typeof(KNHLLOADNFO))]
	private static Task LCENCJCCIOH(MPAFPFABIAC DDDAEFBIEFM, BPGLDJMOGPH BDAPIDPALOK, IReadOnlyDictionary<HJMLLMJGAOM, EIOGJOIPKPC> LIMEMNBFDIM, FEHNCHIDFDG EJEHNGBDFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80304A0", Offset = "0x802F8A0", VA = "0x1880304A0")]
	[CompilerGenerated]
	internal static void IABNLJKJFPN(Func<AKAIMFIBNCN, KFIPKGFLFDI> KAOJGMKKMCD, JALCCCBILDN P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x8033150", Offset = "0x8032550", VA = "0x188033150")]
	[CompilerGenerated]
	internal static bool ONBLNCHOPBL(HJMLLMJGAOM CPPAPHBMPAH, GHIPGOHOIDJ MNHDDCPOMKF, [Out] AAFMDGKIHAA EHFGBHHJOHM, JGKKMAGNFNJ P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AEJDJPJMBEN
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ALCENOGOAEK(FEIKLGLBIHI BPFBPIGIEBO, FEIKLGLBIHI AJFBKILMKNG, IEnumerable<FEIKLGLBIHI> GDAEDHKEELB, [Out] NABIBCDMDDD ENBCICDGNJE, [Out] DDKPDCIBEDL BBKOKGCPJMA);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DDBAFGPKMIA(DDKPDCIBEDL MANEEKAICOF);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum DDKPDCIBEDL : byte
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
internal class NJMKKOEOJBN : AEJDJPJMBEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly OAGGGHJPEKN CACHFAMNHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LBJGKDOMJDE LKIOGGPKELO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	[RecRoom.NoEngine.Common.Preserve]
	public NJMKKOEOJBN([GKAMHFFOHNI(null)] OAGGGHJPEKN KOHFHJCFDBA, [GKAMHFFOHNI(null)] LBJGKDOMJDE GJCPODPLCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x803ACD0", Offset = "0x803A0D0", VA = "0x18803ACD0")]
	private static CCAEPJFHACP? MMKDEJJLCOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x803A4B0", Offset = "0x80398B0", VA = "0x18803A4B0", Slot = "4")]
	public bool ALCENOGOAEK(FEIKLGLBIHI BPFBPIGIEBO, FEIKLGLBIHI AJFBKILMKNG, IEnumerable<FEIKLGLBIHI> GDAEDHKEELB, [Out] NABIBCDMDDD ENBCICDGNJE, [Out] DDKPDCIBEDL BBKOKGCPJMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x803A5B0", Offset = "0x80399B0", VA = "0x18803A5B0", Slot = "5")]
	public string DDBAFGPKMIA(DDKPDCIBEDL MANEEKAICOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x803A6B0", Offset = "0x8039AB0", VA = "0x18803A6B0")]
	internal bool HDBBHHJDNDD(FEIKLGLBIHI BPFBPIGIEBO, FEIKLGLBIHI AJFBKILMKNG, IEnumerable<FEIKLGLBIHI> GDAEDHKEELB, KDNGIJKMAJN PIHDLOODHLD, CCAEPJFHACP? MIMNMIBKIFL, [Out] NABIBCDMDDD ENBCICDGNJE, [Out] DDKPDCIBEDL BBKOKGCPJMA)
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
