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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A01310", Offset = "0x89FFF10", VA = "0x188A01310")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CIPNCGLAONO
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
		[Cpp2IlInjected.Address(RVA = "0x8A07B10", Offset = "0x8A06710", VA = "0x188A07B10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NCFDOCCOLNN<TPermission>(TPermission KIJEMPCDPPF);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void JHEIOBFADIH(PLCCGHEKGIM FANAFCDPEEP);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JPKECBLIIPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HNHLIEDLBOB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MGDLJFEAPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BBKBIKBBBON
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EENBCFJMOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JDBHNHOLHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MDONDJNKKCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool ONEIDGGENJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CPECJDFACGN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum EOKPLKMLFPF
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
	public static readonly Guid JAHDKIGOPLL;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid CLGHOKDALBL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid CLIONLPPEAD;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid ICKKOHJIMNL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid COHNMMHODBP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid EFNNNMAKGJB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly EEHMPKPIKGH<NAEHKMDNNHC, Guid> JNNMBPLHINH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<NAEHKMDNNHC> CHADBMDMAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89F8E60", Offset = "0x89F7A60", VA = "0x1889F8E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B70", Offset = "0x89F7770", VA = "0x1889F8B70")]
	public static NAEHKMDNNHC BCKDHDCDAOE(Guid FHNOHJCOOKK)
	{
		return default(NAEHKMDNNHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x89F8D80", Offset = "0x89F7980", VA = "0x1889F8D80")]
	public static Guid JEPHKDDHMNG(NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x89F8C40", Offset = "0x89F7840", VA = "0x1889F8C40")]
	public static bool DDNIHCKECPH(NAEHKMDNNHC OMOPAJCGHAC, [Out] Guid FHNOHJCOOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x89F8AD0", Offset = "0x89F76D0", VA = "0x1889F8AD0")]
	public static bool ADGBFDOLCML(Guid FHNOHJCOOKK, [Out] NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x89F8C00", Offset = "0x89F7800", VA = "0x1889F8C00")]
	public static NAEHKMDNNHC DBAKEFCGLBI(NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(NAEHKMDNNHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x89F8CD0", Offset = "0x89F78D0", VA = "0x1889F8CD0")]
	public static EOKPLKMLFPF JEAFMBAMIGH(NAEHKMDNNHC LAKOMPNHCHA)
	{
		return default(EOKPLKMLFPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89F8E20", Offset = "0x89F7A20", VA = "0x1889F8E20")]
	internal static NAEHKMDNNHC JIGMGKHKDEC(EOKPLKMLFPF CBGGHOHFBDD)
	{
		return default(NAEHKMDNNHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AFGDENHPLOA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PLCCGHEKGIM ICOENGNGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FFENMNGBBAG FGHLCPGCJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	ENCNDLOJDIG CEKLICPOOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MEMHHBHBDOM> GFJEHFILLLK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LNLMJFKDLAP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NAEHKMDNNHC HJBPJKIEDFB(PLCCGHEKGIM FANAFCDPEEP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MEMHHBHBDOM> FLCIPHBHFJB(CancellationToken JHCOCAANJDL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task KLJNEDJGIIC(long MJILNJAJHOI, IReadOnlyList<JNMEBFOCNAP> GJNIDBJBCEO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task PEBOBIMIHDN(long MJILNJAJHOI, long PCJGLPAGJMA, IReadOnlyList<JNMEBFOCNAP> GJNIDBJBCEO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PLCCGHEKGIM> LAKFMJAIJKE();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FAFJGNJLDIG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89FB3A0", Offset = "0x89F9FA0", VA = "0x1889FB3A0")]
	public static NAEHKMDNNHC GPOHNNNAOKN(this AFGDENHPLOA JBKDKDGALHL)
	{
		return default(NAEHKMDNNHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface AGKDNFMJFKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ILGEOHNLEDD GDPMACNAPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JHEIOBFADIH PMMEFLFFKIN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<MMIIFBCPEBG> LAOIHONOFMK(bool ENNDIKKBAIE = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MMIIFBCPEBG NBAAHIKIKGN(PLCCGHEKGIM FANAFCDPEEP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HKPBIPMHEKM(PLCCGHEKGIM FANAFCDPEEP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<MMIIFBCPEBG> IMNAFNBELKK(PLCCGHEKGIM FANAFCDPEEP, bool JGDHEMBPLII = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AGCHJHNICIP(PLCCGHEKGIM NCFEIHDLOCI, NAEHKMDNNHC OMOPAJCGHAC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MMIIFBCPEBG OLCGKHDCMII(NAEHKMDNNHC OMOPAJCGHAC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ECHHOBICIPG<T>(NAEHKMDNNHC OMOPAJCGHAC, LGMDOCAFNFL KIJEMPCDPPF, bool BHAAPEJHLBM, T AHGPJFFLNPG, [Optional] Action KDPMHGKCPML) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string CMGKHNEANBB(LGMDOCAFNFL KIJEMPCDPPF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KIIKDGPJAKO(PLCCGHEKGIM FANAFCDPEEP, LGMDOCAFNFL AHOPMNICLDC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DAPPJFLMMMF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LCABKLPPFAP(HEBHGEKOEHP NBKNOAMHHFE, CancellationToken JHCOCAANJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ACNMLLDLJDO<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string FGAIBGMIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NCFDOCCOLNN<TPermission> MPJNCDICEBG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class PEAIDGFHBDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? CNOPEFAHIPM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? HLLAJONJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A07190", Offset = "0x8A05D90", VA = "0x188A07190")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A07090", Offset = "0x8A05C90", VA = "0x188A07090")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8A07270", Offset = "0x8A05E70", VA = "0x188A07270")]
	protected PEAIDGFHBDE(object? OOHDHJFLLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MJLOGPHGKHJ(object? BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class NFPMHDDKPFI<T> : PEAIDGFHBDE where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> FLFBEHPGIBM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T AHLMJDKCEID
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x570A7F0", Offset = "0x57093F0", VA = "0x18570A7F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5709ED0", Offset = "0x5708AD0", VA = "0x185709ED0", Slot = "4")]
	public override bool MJLOGPHGKHJ(object? BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x570A160", Offset = "0x5708D60", VA = "0x18570A160")]
	public bool NAFLFGOMNNC(T PMAOAIPCOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x570A9D0", Offset = "0x57095D0", VA = "0x18570A9D0")]
	public NFPMHDDKPFI(T PLEDLJICBFM, IEqualityComparer<T> FLFBEHPGIBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GCIENNCGKBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<LGMDOCAFNFL, bool> IAIGNIBLFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<LGMDOCAFNFL, PEAIDGFHBDE> JJJBFINEGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DOFGILLOJKB EKIDHKLAGPG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x89FC740", Offset = "0x89FB340", VA = "0x1889FC740")]
	public GCIENNCGKBJ(DOFGILLOJKB EKIDHKLAGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89FC460", Offset = "0x89FB060", VA = "0x1889FC460")]
	public bool JGCHGKOCGOB(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C425C0", Offset = "0x3C411C0", VA = "0x183C425C0")]
	public bool JEKHAMMBLFK<T>(LGMDOCAFNFL KIJEMPCDPPF, bool BHAAPEJHLBM, T BKMPCFIAHIG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C42AA0", Offset = "0x3C416A0", VA = "0x183C42AA0")]
	public (bool, T?) JHLBKJANHGM<T>(LGMDOCAFNFL KIJEMPCDPPF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x89FC380", Offset = "0x89FAF80", VA = "0x1889FC380")]
	public bool JEKHAMMBLFK(LGMDOCAFNFL KIJEMPCDPPF, bool BHAAPEJHLBM, object BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x89FC4D0", Offset = "0x89FB0D0", VA = "0x1889FC4D0")]
	public (bool, object) JHLBKJANHGM(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C42580", Offset = "0x3C41180", VA = "0x183C42580")]
	private void DBKCILJMMME<T>(LGMDOCAFNFL KIJEMPCDPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89FC670", Offset = "0x89FB270", VA = "0x1889FC670")]
	private PEAIDGFHBDE PBCFFBIIFJM(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89FC190", Offset = "0x89FAD90", VA = "0x1889FC190")]
	public void CIFOPCFLBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LHFPLFBANLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string BMCPEJAJHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type LNLJPOIFACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly HFOEPPGMCKB NHLAFHJLPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly LGMDOCAFNFL OIODPHJOKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public MCICLGHCAFB LANADCFGEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OKMEGKPBFFN CPJDIMEJOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JJEIGGDJCBJ ABHOJKKNMGH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8A00070", Offset = "0x89FEC70", VA = "0x188A00070")]
	public LHFPLFBANLK(Type HEFLMBGNOFN, string HIJPOAFCJLO, LGMDOCAFNFL KIJEMPCDPPF, MCICLGHCAFB GHOJLDDFLKG, OKMEGKPBFFN CLJCMFLPGAG, JJEIGGDJCBJ MGKKFFBDFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8A00020", Offset = "0x89FEC20", VA = "0x188A00020")]
	public object NENMAFMIMPC(object? IIOGPDPGOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D25D90", Offset = "0x3D24990", VA = "0x183D25D90")]
	public void DBKCILJMMME<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89FFF70", Offset = "0x89FEB70", VA = "0x1889FFF70")]
	public void DBKCILJMMME(Type HLNNCMEACIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class ILNHEEBCKPN<T> : LHFPLFBANLK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string FBIBOHLLLKJ(T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T HINFICNICLO(string? PPDACMEFBFE, T PLEDLJICBFM);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EODBGPDIOHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FBIBOHLLLKJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HINFICNICLO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EODBGPDIOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x48F4800", Offset = "0x48F3400", VA = "0x1848F4800")]
		internal string GEHOIAPHLML(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x48F4680", Offset = "0x48F3280", VA = "0x1848F4680")]
		internal object EAALGDEJIFP(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x50AD0A0", Offset = "0x50ABCA0", VA = "0x1850AD0A0")]
	public ILNHEEBCKPN(LGMDOCAFNFL KIJEMPCDPPF, string HIJPOAFCJLO, [Optional] FBIBOHLLLKJ? GHOJLDDFLKG, [Optional] HINFICNICLO? CLJCMFLPGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50AC340", Offset = "0x50AAF40", VA = "0x1850AC340")]
	private static object? GLDNKJDIMCO(HINFICNICLO? CLJCMFLPGAG, string? PPDACMEFBFE, object? PLEDLJICBFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x50AC900", Offset = "0x50AB500", VA = "0x1850AC900")]
	private static string PBHGMJKEMBG(FBIBOHLLLKJ? JJEGPINGPLH, object? BKMPCFIAHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string MCICLGHCAFB(object? BKMPCFIAHIG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object OKMEGKPBFFN(string? PPDACMEFBFE, [Optional] object PLEDLJICBFM);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate PEAIDGFHBDE JJEIGGDJCBJ();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class DOFGILLOJKB
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class GCHMNBLLOHI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static GCHMNBLLOHI MFAGMJBMEEP;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89FBE50", Offset = "0x89FAA50", VA = "0x1889FBE50", Slot = "4")]
		public bool Equals(List<string> LGCEHLADNJC, List<string> LFHMHCKODDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89FBFA0", Offset = "0x89FABA0", VA = "0x1889FBFA0", Slot = "5")]
		public int GetHashCode(List<string> KOJLNGLNBMH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GCHMNBLLOHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class GLOAAFNEKJB : JAFMKCHMNCM<CIPNCGLAONO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x89FCBD0", Offset = "0x89FB7D0", VA = "0x1889FCBD0", Slot = "9")]
		public override string PBHGMJKEMBG(CIPNCGLAONO HOKNBAKODNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x89FC9F0", Offset = "0x89FB5F0", VA = "0x1889FC9F0", Slot = "10")]
		protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] CIPNCGLAONO BKMPCFIAHIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x89FCCC0", Offset = "0x89FB8C0", VA = "0x1889FCCC0")]
		public GLOAAFNEKJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly FABDDKGFACO BEKANOJIHBB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GLOAAFNEKJB OEPPIKGAHML;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<LHFPLFBANLK> KIDBJJCCFAM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<LGMDOCAFNFL> JADNNLCNJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<LGMDOCAFNFL, LHFPLFBANLK> CDNLPPDEHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x89FB050", Offset = "0x89F9C50", VA = "0x1889FB050")]
	public DOFGILLOJKB([Optional] IList<LHFPLFBANLK>? KNNGJLLJLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89F9200", Offset = "0x89F7E00", VA = "0x1889F9200")]
	public LHFPLFBANLK AHOADBOJGCO(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface ILGEOHNLEDD
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	MMIIFBCPEBG MIJEPBJBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class NALLOCINDEK : ILGEOHNLEDD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static NALLOCINDEK GLLJKHPACOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly KKFNFIDCMCA HPMGMDMKOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<KKFNFIDCMCA> JAMMCMOCMHK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MMIIFBCPEBG MIJEPBJBMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8A01200", Offset = "0x89FFE00", VA = "0x188A01200")]
	public NALLOCINDEK(KKFNFIDCMCA LKEMPJICBIP, IReadOnlyList<KKFNFIDCMCA> KAFEHLNGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A00110", Offset = "0x89FED10", VA = "0x188A00110")]
	private static NALLOCINDEK DMKPLEKFCFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JMPGGAIBMMM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<NAEHKMDNNHC> KAKEOOPAGOB;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x89FD460", Offset = "0x89FC060", VA = "0x1889FD460")]
	public static bool CHDJAKPOGBG(this PLCCGHEKGIM HLIHHEBAMJP, NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x89FD540", Offset = "0x89FC140", VA = "0x1889FD540")]
	public static bool KPDDMGDHKKF(this PLCCGHEKGIM HLIHHEBAMJP, NAEHKMDNNHC OMOPAJCGHAC, ENCNDLOJDIG FHEILPMIKEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CPGNGPANBEG
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> AOGKPOIHPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CIPNCGLAONO AMGMAAKGJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MMIIFBCPEBG : CPGNGPANBEG, HNHLIEDLBOB, ACNMLLDLJDO<LGMDOCAFNFL>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string DHKHOOAFLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NAEHKMDNNHC HPHOIJJHOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) BGDEJJHMOHI<T>(LGMDOCAFNFL KIJEMPCDPPF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class KKFNFIDCMCA : MMIIFBCPEBG, CPGNGPANBEG, HNHLIEDLBOB, ACNMLLDLJDO<LGMDOCAFNFL>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly DOFGILLOJKB KBIIMDDANGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly GCIENNCGKBJ FIJHNFPKPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? AJOPFIPGPCE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool PFBIHGEICPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89FE370", Offset = "0x89FCF70", VA = "0x1889FE370", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool NDLFCOMIFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89FF630", Offset = "0x89FE230", VA = "0x1889FF630", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool NENGADJADEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89FEC30", Offset = "0x89FD830", VA = "0x1889FEC30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool IBKPGMGPFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89FE410", Offset = "0x89FD010", VA = "0x1889FE410", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool EFKNGAHBCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89FE3C0", Offset = "0x89FCFC0", VA = "0x1889FE3C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool ADIAJGIJBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89FF7B0", Offset = "0x89FE3B0", VA = "0x1889FF7B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NAEHKMDNNHC HPHOIJJHOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NAEHKMDNNHC);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA61310", Offset = "0xA5FF10", VA = "0x180A61310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string FGAIBGMIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89FF680", Offset = "0x89FE280", VA = "0x1889FF680", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string DHKHOOAFLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89FF680", Offset = "0x89FE280", VA = "0x1889FF680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AFDGLOIOPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CIPNCGLAONO AMGMAAKGJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x89FE5C0", Offset = "0x89FD1C0", VA = "0x1889FE5C0", Slot = "8")]
		get
		{
			return default(CIPNCGLAONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> AOGKPOIHPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x89FE9D0", Offset = "0x89FD5D0", VA = "0x1889FE9D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool KIAJKJJPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89FE370", Offset = "0x89FCF70", VA = "0x1889FE370", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool BJIFDAFEGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89FE3C0", Offset = "0x89FCFC0", VA = "0x1889FE3C0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool KAIFIMKKADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x89FF630", Offset = "0x89FE230", VA = "0x1889FF630", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool AKBLFHBGBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89FEC30", Offset = "0x89FD830", VA = "0x1889FEC30", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BOILMDPMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89FE410", Offset = "0x89FD010", VA = "0x1889FE410", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ENOOLJBOODL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89FF7B0", Offset = "0x89FE3B0", VA = "0x1889FF7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NCFDOCCOLNN<LGMDOCAFNFL> MPJNCDICEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89FE510", Offset = "0x89FD110", VA = "0x1889FE510", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89FFAF0", Offset = "0x89FE6F0", VA = "0x1889FFAF0", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D05090", Offset = "0x3D03C90", VA = "0x183D05090", Slot = "6")]
	public (bool, T?) BGDEJJHMOHI<T>(LGMDOCAFNFL KIJEMPCDPPF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3D05220", Offset = "0x3D03E20", VA = "0x183D05220")]
	public KKFNFIDCMCA JEEKDKJIIMC<T>(LGMDOCAFNFL KIJEMPCDPPF, bool BHAAPEJHLBM, T BKMPCFIAHIG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x89FFF20", Offset = "0x89FEB20", VA = "0x1889FFF20")]
	public KKFNFIDCMCA(NAEHKMDNNHC OMOPAJCGHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x89FFDC0", Offset = "0x89FE9C0", VA = "0x1889FFDC0")]
	public KKFNFIDCMCA(NAEHKMDNNHC OMOPAJCGHAC, [Optional] string? AJOPFIPGPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x89FFD30", Offset = "0x89FE930", VA = "0x1889FFD30")]
	public KKFNFIDCMCA(KKFNFIDCMCA OCJOECEGEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x89FFDE0", Offset = "0x89FE9E0", VA = "0x1889FFDE0")]
	internal KKFNFIDCMCA(NAEHKMDNNHC CFLEJDPGBCP, [Optional] string? AJOPFIPGPCE, [Optional] KKFNFIDCMCA? OCJOECEGEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x89FE2F0", Offset = "0x89FCEF0", VA = "0x1889FE2F0")]
	public static HFOEPPGMCKB AEFEGKPKFAG(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return default(HFOEPPGMCKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x89FE4F0", Offset = "0x89FD0F0", VA = "0x1889FE4F0")]
	public void CIFOPCFLBJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x89FF800", Offset = "0x89FE400", VA = "0x1889FF800")]
	internal KKFNFIDCMCA LJALPCCMFOG(KKFNFIDCMCA EAIIDDGHIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x89FE610", Offset = "0x89FD210", VA = "0x1889FE610")]
	internal IReadOnlyCollection<LGMDOCAFNFL> EAKGOBIEKMJ(KKFNFIDCMCA OCJOECEGEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x89FF6D0", Offset = "0x89FE2D0", VA = "0x1889FF6D0")]
	public bool IEEIPPOAKKC(LGMDOCAFNFL KIJEMPCDPPF, bool BHAAPEJHLBM, string PHFEBFHJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x89FFBA0", Offset = "0x89FE7A0", VA = "0x1889FFBA0")]
	public (bool, string) PNHCPGBDLFD(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x89FEC80", Offset = "0x89FD880", VA = "0x1889FEC80")]
	internal void GFFBPEIPLEF(LGMDOCAFNFL KIJEMPCDPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x89FEA30", Offset = "0x89FD630", VA = "0x1889FEA30")]
	public ODKNAMLFNLC FBBABCILOOF(Func<NAEHKMDNNHC, Guid> MDOJLOEMOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x89FECD0", Offset = "0x89FD8D0", VA = "0x1889FECD0")]
	public void HGFFDCGPHBJ(ODKNAMLFNLC KHLFHEBHLMO, Func<Guid, NAEHKMDNNHC> PEBCLMHIGIE, [Optional] NAEHKMDNNHC? PIMIMGAKHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x89FE460", Offset = "0x89FD060", VA = "0x1889FE460")]
	[CompilerGenerated]
	private void BJKJKECLPPJ(LGMDOCAFNFL AHOPMNICLDC, IECGKOHFJAM KMDEPBPHJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OFEDKDJKCHB : DAPPJFLMMMF, AGKDNFMJFKK, IDisposable, IFHAPBABDCM
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LHDCKOJFJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public KKFNFIDCMCA newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LHDCKOJFJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x89FFF40", Offset = "0x89FEB40", VA = "0x1889FFF40")]
		internal bool EJDNKDIDDCA(KKFNFIDCMCA rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HCFOCBMPGCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NAEHKMDNNHC roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HCFOCBMPGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E7E4A0", Offset = "0x1E7D0A0", VA = "0x181E7E4A0")]
		internal bool AKNCALGEKMJ(NAEHKMDNNHC r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct JEEPLMNLEFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OFEDKDJKCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public HEBHGEKOEHP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<MEMHHBHBDOM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x89FCD90", Offset = "0x89FB990", VA = "0x1889FCD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x89FD400", Offset = "0x89FC000", VA = "0x1889FD400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FNABFMCIJLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FNABFMCIJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x89FBC50", Offset = "0x89FA850", VA = "0x1889FBC50")]
		internal void BJCNNGBAAHG(ODKNAMLFNLC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x89FBD30", Offset = "0x89FA930", VA = "0x1889FBD30")]
		internal void BKHCAAHGMPN(ODKNAMLFNLC r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IEFBFCMCKKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HEBHGEKOEHP roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HKOIKNFEFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<ODKNAMLFNLC, IECGKOHFJAM> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public HKOIKNFEFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x89FCD00", Offset = "0x89FB900", VA = "0x1889FCD00")]
		internal void ICPECNKCPMI(ODKNAMLFNLC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x89FCD60", Offset = "0x89FB960", VA = "0x1889FCD60")]
		internal void LNJLBAKLLBA(ODKNAMLFNLC r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x89FCD30", Offset = "0x89FB930", VA = "0x1889FCD30")]
		internal void IJJDHCBGKJP(ODKNAMLFNLC r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JDBEGKEHJLJ<T> where T : notnull
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
			public JDBEGKEHJLJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<MEMHHBHBDOM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x441A600", Offset = "0x4419200", VA = "0x18441A600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public LGMDOCAFNFL rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NAEHKMDNNHC accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public HFOEPPGMCKB recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public OFEDKDJKCHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JDBEGKEHJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x52AA530", Offset = "0x52A9130", VA = "0x1852AA530")]
		[AsyncStateMachine(typeof(JDBEGKEHJLJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HAAKJNKFLLD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DBGMKAJIJFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<JNMEBFOCNAP> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KKEJLLCDJDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AFGDENHPLOA rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HEBHGEKOEHP roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<NAEHKMDNNHC, KKFNFIDCMCA> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MBDBKJKILHH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x89FD770", Offset = "0x89FC370", VA = "0x1889FD770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x89FE290", Offset = "0x89FCE90", VA = "0x1889FE290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly AFGDENHPLOA JBKDKDGALHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly NALLOCINDEK NMPGPMOLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MBDBKJKILHH LOAKGGDNOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, KKFNFIDCMCA> LCBMGOPLMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<NAEHKMDNNHC, KKFNFIDCMCA> BPMBHOHELBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<NAEHKMDNNHC, KKFNFIDCMCA> KAHLBLPIPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<KKFNFIDCMCA> HGIPBJHACOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool OIHOIKIFNML;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly LGMDOCAFNFL[] NKBCECEIBHP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ILGEOHNLEDD GDPMACNAPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JHEIOBFADIH PMMEFLFFKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A03090", Offset = "0x8A01C90", VA = "0x188A03090", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8A02F20", Offset = "0x8A01B20", VA = "0x188A02F20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8A01500", Offset = "0x8A00100", VA = "0x188A01500")]
	[HHMPGEJNNFC.FBIGHDDEPNK]
	internal static void AMOEJCEGAKO(LGPCNHIHIDJ FDOOPNLIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8A06DD0", Offset = "0x8A059D0", VA = "0x188A06DD0")]
	[UnityEngine.Scripting.Preserve]
	internal OFEDKDJKCHB([HAKCNCGPHPD(null)] AFGDENHPLOA DLOPCJGDJDF, [HAKCNCGPHPD(null)] NALLOCINDEK DIABONIHNCJ, [HAKCNCGPHPD(null)] MBDBKJKILHH LOAKGGDNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8A01A80", Offset = "0x8A00680", VA = "0x188A01A80", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8A039B0", Offset = "0x8A025B0", VA = "0x188A039B0")]
	private void IOHCAJKLJDO(IEnumerable<KKFNFIDCMCA> CICEJMGOEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8A02FC0", Offset = "0x8A01BC0", VA = "0x188A02FC0", Slot = "10")]
	public bool HKPBIPMHEKM(PLCCGHEKGIM FANAFCDPEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8A04A40", Offset = "0x8A03640", VA = "0x188A04A40")]
	private void LNLMJFKDLAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8A03130", Offset = "0x8A01D30", VA = "0x188A03130")]
	private void HOBLLGADCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8A04830", Offset = "0x8A03430", VA = "0x188A04830", Slot = "8")]
	public IReadOnlyList<MMIIFBCPEBG> LAOIHONOFMK(bool ENNDIKKBAIE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8A06510", Offset = "0x8A05110", VA = "0x188A06510", Slot = "9")]
	public MMIIFBCPEBG NBAAHIKIKGN(PLCCGHEKGIM FANAFCDPEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8A045C0", Offset = "0x8A031C0", VA = "0x188A045C0")]
	private NAEHKMDNNHC KEJCOHHFHIC(PLCCGHEKGIM FANAFCDPEEP)
	{
		return default(NAEHKMDNNHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8A01390", Offset = "0x89FFF90", VA = "0x188A01390", Slot = "12")]
	public bool AGCHJHNICIP(PLCCGHEKGIM NCFEIHDLOCI, NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8A06640", Offset = "0x8A05240", VA = "0x188A06640", Slot = "13")]
	public MMIIFBCPEBG OLCGKHDCMII(NAEHKMDNNHC OMOPAJCGHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8A03670", Offset = "0x8A02270", VA = "0x188A03670")]
	private static bool IJGKLAMLPGP(PGOPOKPBHGL BHCBLCKBCGC, NAEHKMDNNHC OMOPAJCGHAC, [Out] ODKNAMLFNLC? HPHFENAAMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8A06190", Offset = "0x8A04D90", VA = "0x188A06190")]
	private static void MPMFLCMEDAP(PGOPOKPBHGL BHCBLCKBCGC, Action<ODKNAMLFNLC> FANEAIBLLJF, NAEHKMDNNHC IPFAOEEBIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8A06280", Offset = "0x8A04E80", VA = "0x188A06280")]
	private static void MPMFLCMEDAP(PGOPOKPBHGL BHCBLCKBCGC, Action<ODKNAMLFNLC> FANEAIBLLJF, Predicate<NAEHKMDNNHC> MJKCLEMANPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8A049D0", Offset = "0x8A035D0", VA = "0x188A049D0")]
	private void LHJJMADGOHC(PLCCGHEKGIM FANAFCDPEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8A048B0", Offset = "0x8A034B0", VA = "0x188A048B0", Slot = "4")]
	[AsyncStateMachine(typeof(JEEPLMNLEFB))]
	public Task LCABKLPPFAP([CanBeNull] HEBHGEKOEHP NBKNOAMHHFE, CancellationToken JHCOCAANJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8A05D10", Offset = "0x8A04910", VA = "0x188A05D10")]
	private void MGINAGODMED(PGOPOKPBHGL MBMELGKCMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8A042B0", Offset = "0x8A02EB0", VA = "0x188A042B0")]
	internal static string JOILDGEEPEL(AFGDENHPLOA JBKDKDGALHL, HEBHGEKOEHP NBKNOAMHHFE, IReadOnlyDictionary<NAEHKMDNNHC, KKFNFIDCMCA> BPMBHOHELBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8A04EE0", Offset = "0x8A03AE0", VA = "0x188A04EE0")]
	private static void MCKCKKJBGJN(HEBHGEKOEHP NBKNOAMHHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8A03320", Offset = "0x8A01F20", VA = "0x188A03320")]
	private static void IENFNCHOELE(PGOPOKPBHGL FPAKLHIGEDH, IReadOnlyDictionary<NAEHKMDNNHC, KKFNFIDCMCA> BPMBHOHELBA, StringBuilder HGMGGCGGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8A04A50", Offset = "0x8A03650", VA = "0x188A04A50")]
	private static bool LOGBIMCJPNL(string ADEAIIDIIFM, [Out] Guid JNHBNMKEOFH, [Out] NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8A01B90", Offset = "0x8A00790", VA = "0x188A01B90")]
	private static void ECMLEHFMKOH(HEBHGEKOEHP NBKNOAMHHFE, StringBuilder HGMGGCGGBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7990", Offset = "0x3DF6590", VA = "0x183DF7990", Slot = "14")]
	public bool ECHHOBICIPG<T>(NAEHKMDNNHC OMOPAJCGHAC, LGMDOCAFNFL KIJEMPCDPPF, bool BHAAPEJHLBM, T AHGPJFFLNPG, [Optional] Action KDPMHGKCPML) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8A016C0", Offset = "0x8A002C0", VA = "0x188A016C0", Slot = "15")]
	public string CMGKHNEANBB(LGMDOCAFNFL KIJEMPCDPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8A04690", Offset = "0x8A03290", VA = "0x188A04690", Slot = "16")]
	public bool KIIKDGPJAKO(PLCCGHEKGIM FANAFCDPEEP, LGMDOCAFNFL AHOPMNICLDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8A04780", Offset = "0x8A03380", VA = "0x188A04780", Slot = "18")]
	public bool KIIKDGPJAKO(int JGGIBDMAPLG, LGMDOCAFNFL AHOPMNICLDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8A02D10", Offset = "0x8A01910", VA = "0x188A02D10")]
	private void FBDNMFEOCOA(NAEHKMDNNHC OMOPAJCGHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8A06620", Offset = "0x8A05220", VA = "0x188A06620")]
	private bool OILDLMDKPKB(PLCCGHEKGIM FANAFCDPEEP, NAEHKMDNNHC OMOPAJCGHAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8A01740", Offset = "0x8A00340", VA = "0x188A01740")]
	internal KKFNFIDCMCA DBEAPPEEPPE(PLCCGHEKGIM FANAFCDPEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A039A0", Offset = "0x8A025A0", VA = "0x188A039A0", Slot = "11")]
	public IReadOnlyList<MMIIFBCPEBG> IMNAFNBELKK(PLCCGHEKGIM FANAFCDPEEP, bool JGDHEMBPLII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8A069D0", Offset = "0x8A055D0", VA = "0x188A069D0")]
	internal IReadOnlyList<KKFNFIDCMCA> PJCHOPLPKLF(PLCCGHEKGIM FANAFCDPEEP, bool JGDHEMBPLII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8A022D0", Offset = "0x8A00ED0", VA = "0x188A022D0")]
	private void EEPKPILPHIL(MEMHHBHBDOM HMLAGLNDAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8A066E0", Offset = "0x8A052E0", VA = "0x188A066E0")]
	private static bool PDACMGODCDP(KKFNFIDCMCA MPBAEJPDNFO, IReadOnlyDictionary<NAEHKMDNNHC, KKFNFIDCMCA> BPMBHOHELBA, [Out] IReadOnlyList<LGMDOCAFNFL> PPCENHOODOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8A06050", Offset = "0x8A04C50", VA = "0x188A06050")]
	[AsyncStateMachine(typeof(KKEJLLCDJDB))]
	private static Task MKANJEHKIGA(AFGDENHPLOA JBKDKDGALHL, HEBHGEKOEHP NBKNOAMHHFE, IReadOnlyDictionary<NAEHKMDNNHC, KKFNFIDCMCA> BPMBHOHELBA, MBDBKJKILHH LOAKGGDNOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8A02A70", Offset = "0x8A01670", VA = "0x188A02A70")]
	[CompilerGenerated]
	internal static void ENGMKOCMLLL(Func<ODKNAMLFNLC, IECGKOHFJAM> MMDOGIPDPPM, IEFBFCMCKKM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8A04B60", Offset = "0x8A03760", VA = "0x188A04B60")]
	[CompilerGenerated]
	internal static bool MACCGFOFDIK(NAEHKMDNNHC OMOPAJCGHAC, LGMDOCAFNFL KIJEMPCDPPF, [Out] JNMEBFOCNAP FKPNDFHGOJE, DBGMKAJIJFE P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HIGOAGEOEFP
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKDNLKDEIDF(PLCCGHEKGIM PKEDKLLNBEH, PLCCGHEKGIM PDMLBJDLMHJ, IEnumerable<PLCCGHEKGIM> BDEILKIKNPD, [Out] CIPNCGLAONO KLAAOLFKNBG, [Out] FOBAOOCHOJP GDPKDEDBGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AJCOHCGBPAD(FOBAOOCHOJP CAKAADKCLFE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum FOBAOOCHOJP : byte
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
internal class FAMNEPOJGAP : HIGOAGEOEFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly AGKDNFMJFKK MNJLNBDEJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CJIMPEOGELP BFNCJNBDIJH;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FAMNEPOJGAP([HAKCNCGPHPD(null)] AGKDNFMJFKK MNJLNBDEJCC, [HAKCNCGPHPD(null)] CJIMPEOGELP MCJFIABFEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x89FB500", Offset = "0x89FA100", VA = "0x1889FB500")]
	private static KMKOHDDPKAO? CAIEGJKJEOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x89FB540", Offset = "0x89FA140", VA = "0x1889FB540", Slot = "4")]
	public bool JKDNLKDEIDF(PLCCGHEKGIM PKEDKLLNBEH, PLCCGHEKGIM PDMLBJDLMHJ, IEnumerable<PLCCGHEKGIM> BDEILKIKNPD, [Out] CIPNCGLAONO KLAAOLFKNBG, [Out] FOBAOOCHOJP GDPKDEDBGBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x89FB400", Offset = "0x89FA000", VA = "0x1889FB400", Slot = "5")]
	public string AJCOHCGBPAD(FOBAOOCHOJP CAKAADKCLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x89FB640", Offset = "0x89FA240", VA = "0x1889FB640")]
	internal bool JNMGMEJNKLH(PLCCGHEKGIM PKEDKLLNBEH, PLCCGHEKGIM PDMLBJDLMHJ, IEnumerable<PLCCGHEKGIM> BDEILKIKNPD, ENCNDLOJDIG FHEILPMIKEF, KMKOHDDPKAO? PJGEOCANCKO, [Out] CIPNCGLAONO KLAAOLFKNBG, [Out] FOBAOOCHOJP GDPKDEDBGBJ)
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
