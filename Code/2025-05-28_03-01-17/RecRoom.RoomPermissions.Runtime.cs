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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x864BED0", Offset = "0x864ACD0", VA = "0x18864BED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IHJNIOLJJPA
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
		[Cpp2IlInjected.Address(RVA = "0x864CE40", Offset = "0x864BC40", VA = "0x18864CE40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IBMILLGOCJI<TPermission>(TPermission KLAAIBKFNDA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CKFBNCMKCAH(AHNIMKBJLEJ ENPELEHFGFF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ENIGFNCGAHO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AFOIAKFCOLM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IMJEKADFAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OHCCGBHGBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KKCPOOFKDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FJKCPBHPAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KKHLCCPFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool POMJIKBKPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class KIAIDLPNFBI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum KEJMOAPCNIE
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
	public static readonly Guid KKBLKIPHAJH;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid IAILMNGKBBP;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid NIDHGJHCIAB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid GLOCIBCIGKI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NPMFABBLHNC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid DFIFHCPHFPB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HEJFBAJPMNN<OKJOLANABCP, Guid> HKKHFOAGAJD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<OKJOLANABCP> AKKDHLAEOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8645CF0", Offset = "0x8644AF0", VA = "0x188645CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8645B50", Offset = "0x8644950", VA = "0x188645B50")]
	public static OKJOLANABCP IPPACFFHONK(Guid PDFBNFKDLAH)
	{
		return default(OKJOLANABCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8645A10", Offset = "0x8644810", VA = "0x188645A10")]
	public static Guid DIICBFBNLDD(OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8645C60", Offset = "0x8644A60", VA = "0x188645C60")]
	public static bool MENCNHBIHLK(OKJOLANABCP ONFCPNPGLAJ, [Out] Guid PDFBNFKDLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8645AB0", Offset = "0x86448B0", VA = "0x188645AB0")]
	public static bool EEKPMBEFILM(Guid PDFBNFKDLAH, [Out] OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8645BE0", Offset = "0x86449E0", VA = "0x188645BE0")]
	public static OKJOLANABCP JEGOACPADFO(OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(OKJOLANABCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8645960", Offset = "0x8644760", VA = "0x188645960")]
	public static KEJMOAPCNIE BFIHOCPIBIB(OKJOLANABCP PMLNKOPDGNM)
	{
		return default(KEJMOAPCNIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8645C20", Offset = "0x8644A20", VA = "0x188645C20")]
	internal static OKJOLANABCP LBAHOHHENFJ(KEJMOAPCNIE MBJCKBHBNKG)
	{
		return default(OKJOLANABCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEJMHEFMPLB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AHNIMKBJLEJ GGGCAKCKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DAFHNINMJHP NFFBJEMLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IEHEOOILKKD DDJPPKMGDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IBAAIANPMNJ> PNKJGOOOLKO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IDBJBGBAHHJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKJOLANABCP KKHPFMHADKP(AHNIMKBJLEJ ENPELEHFGFF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IBAAIANPMNJ> COPENCMPPEB(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CBHFOGFMBBJ(long CEACGIDOODJ, IReadOnlyList<HKKBMLKADPE> FECOFHPMCBK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KOPIKEFHPAI(long CEACGIDOODJ, long AIBOEBCNHLB, IReadOnlyList<HKKBMLKADPE> FECOFHPMCBK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<AHNIMKBJLEJ> ENEEIFFFMMP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IACBEJONCKA
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86455C0", Offset = "0x86443C0", VA = "0x1886455C0")]
	public static OKJOLANABCP DHNBJLCPOOM(this LEJMHEFMPLB JLJLCFOLDMD)
	{
		return default(OKJOLANABCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface CBBBNKEEPHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EMJOKBMDCMM INKGHJNFANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CKFBNCMKCAH BJNIADKCJPE;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<BGIGCBHGGLI> BOAFNBGIGPJ(bool IBEFGPMMHFP = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BGIGCBHGGLI LCBJCPHGJCC(AHNIMKBJLEJ ENPELEHFGFF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BJFAKIDDKCN(AHNIMKBJLEJ ENPELEHFGFF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<BGIGCBHGGLI> PABEMKPBDJL(AHNIMKBJLEJ ENPELEHFGFF, bool KGCIBBLMIBP = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BDKPBILFMFD(AHNIMKBJLEJ FCFNMJLLEIJ, OKJOLANABCP ONFCPNPGLAJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BGIGCBHGGLI KILBMIJPCCL(OKJOLANABCP ONFCPNPGLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CHCKHGIDGKB<T>(OKJOLANABCP ONFCPNPGLAJ, LLPDOLMILHD KLAAIBKFNDA, bool JIGCGBIJDFF, T EMEICEFCBEP, [Optional] Action HKEBCCOLOFD) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string FMCIPCCGEGA(LLPDOLMILHD KLAAIBKFNDA);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool BNNKEGNCGDF(AHNIMKBJLEJ ENPELEHFGFF, LLPDOLMILHD HJKNJOPJHNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PBCPLAONOIN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MMPHACBFJNE(IEHAENGDKAI MLFFBNNKHKH, CancellationToken GHKBKDKNIOM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KJGDNMOBBLA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string LACIHCPOCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IBMILLGOCJI<TPermission> HKBNLGMKODJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class DKIGMAJFFOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? LOCGOPBFEMF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? DCMGICLPGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8641810", Offset = "0x8640610", VA = "0x188641810")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8641710", Offset = "0x8640510", VA = "0x188641710")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x86418E0", Offset = "0x86406E0", VA = "0x1886418E0")]
	protected DKIGMAJFFOA(object? EJGKKOCLMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KAGLLOHFOOC(object? OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class IEANKCLNDEH<T> : DKIGMAJFFOA where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> EDPFJJMAPIB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D30540", Offset = "0x4D2F340", VA = "0x184D30540")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D30A10", Offset = "0x4D2F810", VA = "0x184D30A10", Slot = "4")]
	public override bool KAGLLOHFOOC(object? OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D2FDB0", Offset = "0x4D2EBB0", VA = "0x184D2FDB0")]
	public bool EBHNJJNAKOP(T KHPEAOLANMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D30B80", Offset = "0x4D2F980", VA = "0x184D30B80")]
	public IEANKCLNDEH(T LDGCNLHOBMI, IEqualityComparer<T> EDPFJJMAPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FHJJMJNBCPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<LLPDOLMILHD, bool> ALPEDIHMIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<LLPDOLMILHD, DKIGMAJFFOA> IAJOHAFCLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly AMPDKDGHPJL KMDBGKNKGAL;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8641F90", Offset = "0x8640D90", VA = "0x188641F90")]
	public FHJJMJNBCPL(AMPDKDGHPJL KMDBGKNKGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8641E50", Offset = "0x8640C50", VA = "0x188641E50")]
	public bool KELGJLNFODF(LLPDOLMILHD KLAAIBKFNDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38E60C0", Offset = "0x38E4EC0", VA = "0x1838E60C0")]
	public bool GGOHJBDBNMD<T>(LLPDOLMILHD KLAAIBKFNDA, bool JIGCGBIJDFF, T OAIIHELJHLG) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x38E5C20", Offset = "0x38E4A20", VA = "0x1838E5C20")]
	public (bool, T?) CNLBGNDKDHA<T>(LLPDOLMILHD KLAAIBKFNDA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8641D70", Offset = "0x8640B70", VA = "0x188641D70")]
	public bool GGOHJBDBNMD(LLPDOLMILHD KLAAIBKFNDA, bool JIGCGBIJDFF, object OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86419E0", Offset = "0x86407E0", VA = "0x1886419E0")]
	public (bool, object) CNLBGNDKDHA(LLPDOLMILHD KLAAIBKFNDA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x38E6640", Offset = "0x38E5440", VA = "0x1838E6640")]
	private void OIOAGONGDFJ<T>(LLPDOLMILHD KLAAIBKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8641EC0", Offset = "0x8640CC0", VA = "0x188641EC0")]
	private DKIGMAJFFOA KGIKADFBJPE(LLPDOLMILHD KLAAIBKFNDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8641B70", Offset = "0x8640970", VA = "0x188641B70")]
	public void FDCJBJKLGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NEEFKOLGKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KPDIBFFPHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type CEAAFBBOBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PDHLIDCLFCJ EIOOOLLJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly LLPDOLMILHD LCANEJEOAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IDCFOKAIIGK EEDJJDFBIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OBBMJMBIGHM GAKGABKKMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public IKGBJPFBBKA MJCLHMJLKAK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x864BE30", Offset = "0x864AC30", VA = "0x18864BE30")]
	public NEEFKOLGKIP(Type CAPHDALFBKL, string DCBGPPPDNMF, LLPDOLMILHD KLAAIBKFNDA, IDCFOKAIIGK AJCEOPKCKCP, OBBMJMBIGHM IMHPOMAELPD, IKGBJPFBBKA IFPMMEFKCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x864BD30", Offset = "0x864AB30", VA = "0x18864BD30")]
	public object DFGAFOPBLPL(object? HBLONCAMFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E3A0", Offset = "0x3A9D1A0", VA = "0x183A9E3A0")]
	public void OIOAGONGDFJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x864BD80", Offset = "0x864AB80", VA = "0x18864BD80")]
	public void OIOAGONGDFJ(Type KMCCHFIHELL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class LJDBHMDFFMN<T> : NEEFKOLGKIP where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string LHPIEKEFFON(T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T HGNJKMALFJM(string? GOIIMABILCG, T LDGCNLHOBMI);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class IDMOGFEBKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LHPIEKEFFON serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HGNJKMALFJM parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IDMOGFEBKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D2E6C0", Offset = "0x4D2D4C0", VA = "0x184D2E6C0")]
		internal string IOAIKFNLDIN(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4D2E700", Offset = "0x4D2D500", VA = "0x184D2E700")]
		internal object POCFKLBDFBC(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5197E30", Offset = "0x5196C30", VA = "0x185197E30")]
	public LJDBHMDFFMN(LLPDOLMILHD KLAAIBKFNDA, string DCBGPPPDNMF, [Optional] LHPIEKEFFON? AJCEOPKCKCP, [Optional] HGNJKMALFJM? IMHPOMAELPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51977F0", Offset = "0x51965F0", VA = "0x1851977F0")]
	private static object? LGDBIGPAFJK(HGNJKMALFJM? IMHPOMAELPD, string? GOIIMABILCG, object? LDGCNLHOBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5196C80", Offset = "0x5195A80", VA = "0x185196C80")]
	private static string KIDMEGDOMCG(LHPIEKEFFON? AOLDIHCCNFH, object? OAIIHELJHLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string IDCFOKAIIGK(object? OAIIHELJHLG);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object OBBMJMBIGHM(string? GOIIMABILCG, [Optional] object LDGCNLHOBMI);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate DKIGMAJFFOA IKGBJPFBBKA();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class AMPDKDGHPJL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JFMKGNJOKEA : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static JFMKGNJOKEA ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8645620", Offset = "0x8644420", VA = "0x188645620", Slot = "4")]
		public bool Equals(List<string> AJEEBBBAOKG, List<string> GJPKMHAOJHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8645770", Offset = "0x8644570", VA = "0x188645770", Slot = "5")]
		public int GetHashCode(List<string> GLEBGNJJOHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JFMKGNJOKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class AANIAMNHCCG : HCLLCDKNBCK<IHJNIOLJJPA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x863FAF0", Offset = "0x863E8F0", VA = "0x18863FAF0", Slot = "9")]
		public override string KIDMEGDOMCG(IHJNIOLJJPA DGDLKJDMLAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x863F910", Offset = "0x863E710", VA = "0x18863F910", Slot = "10")]
		protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] IHJNIOLJJPA OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x863FBE0", Offset = "0x863E9E0", VA = "0x18863FBE0")]
		public AANIAMNHCCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly ELOOOGIEAKK EGFAJCFKKNN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly AANIAMNHCCG KCMOFPKDJNL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NEEFKOLGKIP> INJFJNKOKFJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<LLPDOLMILHD> BNGOKDGNOND
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<LLPDOLMILHD, NEEFKOLGKIP> EIKINFGIGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86411C0", Offset = "0x863FFC0", VA = "0x1886411C0")]
	public AMPDKDGHPJL([Optional] IList<NEEFKOLGKIP>? IIFLNHDKEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x863FC20", Offset = "0x863EA20", VA = "0x18863FC20")]
	public NEEFKOLGKIP LPJGDICPDCB(LLPDOLMILHD KLAAIBKFNDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EMJOKBMDCMM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BGIGCBHGGLI GAGPOOIBBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AAEDPCEKEPP : EMJOKBMDCMM
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static AAEDPCEKEPP EAOECOKPDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly FOMCNFKOJNN KNDMBFHOLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<FOMCNFKOJNN> EHGGMODLNDJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BGIGCBHGGLI GAGPOOIBBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x863F800", Offset = "0x863E600", VA = "0x18863F800")]
	public AAEDPCEKEPP(FOMCNFKOJNN IPBJELGOGCH, IReadOnlyList<FOMCNFKOJNN> OFGDLHICAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x863E8E0", Offset = "0x863D6E0", VA = "0x18863E8E0")]
	private static AAEDPCEKEPP NNINALEECGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FLIBMDHAPOL
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<OKJOLANABCP> EBBLKDFNGBI;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8642240", Offset = "0x8641040", VA = "0x188642240")]
	public static bool GFCBLIKBGJL(this AHNIMKBJLEJ ALDGPAKLOOK, OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8642320", Offset = "0x8641120", VA = "0x188642320")]
	public static bool MPFCCEDAFNN(this AHNIMKBJLEJ ALDGPAKLOOK, OKJOLANABCP ONFCPNPGLAJ, IEHEOOILKKD NMFHFJBGFII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HGODILAKPBM
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> MLJGMLDMBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IHJNIOLJJPA AENJANKGNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BGIGCBHGGLI : HGODILAKPBM, AFOIAKFCOLM, KJGDNMOBBLA<LLPDOLMILHD>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string FECFJIFFBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OKJOLANABCP NCEGNHPBIJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GOACBKGCFLO<T>(LLPDOLMILHD KLAAIBKFNDA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class FOMCNFKOJNN : BGIGCBHGGLI, HGODILAKPBM, AFOIAKFCOLM, KJGDNMOBBLA<LLPDOLMILHD>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly AMPDKDGHPJL OPAJHDIPLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly FHJJMJNBCPL LKMNFECJNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? OEJMIFJNKGA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool GOEMHGOOKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8642A00", Offset = "0x8641800", VA = "0x188642A00", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool IDIJDBHMONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86438D0", Offset = "0x86426D0", VA = "0x1886438D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool JBKMLBLGLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8642C30", Offset = "0x8641A30", VA = "0x188642C30", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool COHBGIJDPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8642A50", Offset = "0x8641850", VA = "0x188642A50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool KJDBHLIOCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8643BC0", Offset = "0x86429C0", VA = "0x188643BC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool NMFEDEGAJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8642BE0", Offset = "0x86419E0", VA = "0x188642BE0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public OKJOLANABCP NCEGNHPBIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OKJOLANABCP);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B690", Offset = "0xA0A490", VA = "0x180A0B690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string LACIHCPOCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8643AC0", Offset = "0x86428C0", VA = "0x188643AC0", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string FECFJIFFBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8643AC0", Offset = "0x86428C0", VA = "0x188643AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool IFKHOJMPFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IHJNIOLJJPA AENJANKGNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8642AA0", Offset = "0x86418A0", VA = "0x188642AA0", Slot = "8")]
		get
		{
			return default(IHJNIOLJJPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> MLJGMLDMBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8643920", Offset = "0x8642720", VA = "0x188643920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool JFIEPHGAOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8642A00", Offset = "0x8641800", VA = "0x188642A00", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool DOFDLALCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8643BC0", Offset = "0x86429C0", VA = "0x188643BC0", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool GIIPGOFOLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86438D0", Offset = "0x86426D0", VA = "0x1886438D0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool AAGNMKJNAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8642C30", Offset = "0x8641A30", VA = "0x188642C30", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PGCFEFGHLLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8642A50", Offset = "0x8641850", VA = "0x188642A50", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HFLLJPMAFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8642BE0", Offset = "0x86419E0", VA = "0x188642BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IBMILLGOCJI<LLPDOLMILHD> HKBNLGMKODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8643980", Offset = "0x8642780", VA = "0x188643980", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8643B10", Offset = "0x8642910", VA = "0x188643B10", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x38ECA10", Offset = "0x38EB810", VA = "0x1838ECA10", Slot = "6")]
	public (bool, T?) GOACBKGCFLO<T>(LLPDOLMILHD KLAAIBKFNDA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x38ECC00", Offset = "0x38EBA00", VA = "0x1838ECC00")]
	public FOMCNFKOJNN KMJPIDNLGBE<T>(LLPDOLMILHD KLAAIBKFNDA, bool JIGCGBIJDFF, T OAIIHELJHLG) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8644190", Offset = "0x8642F90", VA = "0x188644190")]
	public FOMCNFKOJNN(OKJOLANABCP ONFCPNPGLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8644170", Offset = "0x8642F70", VA = "0x188644170")]
	public FOMCNFKOJNN(OKJOLANABCP ONFCPNPGLAJ, [Optional] string? OEJMIFJNKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86440E0", Offset = "0x8642EE0", VA = "0x1886440E0")]
	public FOMCNFKOJNN(FOMCNFKOJNN ANJFHNJOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8643FA0", Offset = "0x8642DA0", VA = "0x188643FA0")]
	internal FOMCNFKOJNN(OKJOLANABCP IFFKPBALCBL, [Optional] string? OEJMIFJNKGA, [Optional] FOMCNFKOJNN? ANJFHNJOEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8642B40", Offset = "0x8641940", VA = "0x188642B40")]
	public static PDHLIDCLFCJ FBDJCGFGDGE(LLPDOLMILHD KLAAIBKFNDA)
	{
		return default(PDHLIDCLFCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8642BC0", Offset = "0x86419C0", VA = "0x188642BC0")]
	public void FDCJBJKLGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x86435E0", Offset = "0x86423E0", VA = "0x1886435E0")]
	internal FOMCNFKOJNN IHPCAMIHEEN(FOMCNFKOJNN EGNDJPMDLKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8642630", Offset = "0x8641430", VA = "0x188642630")]
	internal IReadOnlyCollection<LLPDOLMILHD> AHIDGMOAFFH(FOMCNFKOJNN ANJFHNJOEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8642550", Offset = "0x8641350", VA = "0x188642550")]
	public bool AFLHIOHHPBI(LLPDOLMILHD KLAAIBKFNDA, bool JIGCGBIJDFF, string LGPJCIFCAIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8643C10", Offset = "0x8642A10", VA = "0x188643C10")]
	public (bool, string) NIJNOALNKBF(LLPDOLMILHD KLAAIBKFNDA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8642AF0", Offset = "0x86418F0", VA = "0x188642AF0")]
	internal void DCGBFNGNIEP(LLPDOLMILHD KLAAIBKFNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8643D10", Offset = "0x8642B10", VA = "0x188643D10")]
	public BMFOANPBIEN OJOFGMKNEOD(Func<OKJOLANABCP, Guid> GMGPINFAFHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8642C80", Offset = "0x8641A80", VA = "0x188642C80")]
	public void HINDDFDDANH(BMFOANPBIEN DCBIDKMIGBP, Func<Guid, OKJOLANABCP> NKEPACCAMNB, [Optional] OKJOLANABCP? OLBFMNELOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8643A30", Offset = "0x8642830", VA = "0x188643A30")]
	[CompilerGenerated]
	private void LICJFKHFIPN(LLPDOLMILHD HJKNJOPJHNJ, BBNGIBNLDAD FAAEGGMKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KKPNFNOPDNH : PBCPLAONOIN, CBBBNKEEPHN, IDisposable, HFMJFJNBLHH
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GPFGHFDCCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FOMCNFKOJNN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public GPFGHFDCCHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86441B0", Offset = "0x8642FB0", VA = "0x1886441B0")]
		internal bool AGGKGLCAJDN(FOMCNFKOJNN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JOEPMCLGOOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public OKJOLANABCP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JOEPMCLGOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1C6FE40", Offset = "0x1C6EC40", VA = "0x181C6FE40")]
		internal bool NMHKGKIPLPA(OKJOLANABCP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct PEBELGPDDPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KKPNFNOPDNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IEHAENGDKAI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<IBAAIANPMNJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x864BF50", Offset = "0x864AD50", VA = "0x18864BF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x864C5C0", Offset = "0x864B3C0", VA = "0x18864C5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CJNLCENMCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CJNLCENMCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8641510", Offset = "0x8640310", VA = "0x188641510")]
		internal void CLMOFLIHKFG(BMFOANPBIEN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86415F0", Offset = "0x86403F0", VA = "0x1886415F0")]
		internal void NFINOGLADED(BMFOANPBIEN r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct IABDOAFBGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public IEHAENGDKAI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PHEHENFGCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<BMFOANPBIEN, BBNGIBNLDAD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PHEHENFGCPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x864C680", Offset = "0x864B480", VA = "0x18864C680")]
		internal void KBOMIHGOKBI(BMFOANPBIEN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x864C650", Offset = "0x864B450", VA = "0x18864C650")]
		internal void HNJADFCDAGK(BMFOANPBIEN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x864C620", Offset = "0x864B420", VA = "0x18864C620")]
		internal void EOFHEHLCIPG(BMFOANPBIEN r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CAJHGLCEIKG<T> where T : notnull
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
			public CAJHGLCEIKG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<IBAAIANPMNJ> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4196810", Offset = "0x4195610", VA = "0x184196810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public LLPDOLMILHD rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OKJOLANABCP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public PDHLIDCLFCJ recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public KKPNFNOPDNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CAJHGLCEIKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x65477C0", Offset = "0x65465C0", VA = "0x1865477C0")]
		[AsyncStateMachine(typeof(CAJHGLCEIKG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void OAEJGDHHOIO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EOMKGNMILAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<HKKBMLKADPE> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct HJIPBKEPLNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public LEJMHEFMPLB rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IEHAENGDKAI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<OKJOLANABCP, FOMCNFKOJNN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FOKFJHNOCCC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86441E0", Offset = "0x8642FE0", VA = "0x1886441E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8644D00", Offset = "0x8643B00", VA = "0x188644D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LEJMHEFMPLB JLJLCFOLDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AAEDPCEKEPP DHENJONIKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FOKFJHNOCCC IMOFFFALEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, FOMCNFKOJNN> JPAIHDEHCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<OKJOLANABCP, FOMCNFKOJNN> IINGGAFCCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<OKJOLANABCP, FOMCNFKOJNN> NEFFFIPJJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<FOMCNFKOJNN> DPLPJOLPGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool HMMFLKAFPOG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly LLPDOLMILHD[] PLOAJPLBIEH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EMJOKBMDCMM INKGHJNFANE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CKFBNCMKCAH BJNIADKCJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8648600", Offset = "0x8647400", VA = "0x188648600", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8647A80", Offset = "0x8646880", VA = "0x188647A80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8649B40", Offset = "0x8648940", VA = "0x188649B40")]
	[ENKLKENGHAE.NBNJEHHIPLL]
	internal static void JKEPFALEAEN(NAELDDAANND DICMPHOPMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x864BA70", Offset = "0x864A870", VA = "0x18864BA70")]
	[UnityEngine.Scripting.Preserve]
	internal KKPNFNOPDNH([LCNEJNNIOGA(null)] LEJMHEFMPLB APKPDEBAJEB, [LCNEJNNIOGA(null)] AAEDPCEKEPP HDFOEHGDLCO, [LCNEJNNIOGA(null)] FOKFJHNOCCC IMOFFFALEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8647E70", Offset = "0x8646C70", VA = "0x188647E70", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8649E10", Offset = "0x8648C10", VA = "0x188649E10")]
	private void JPFAIDEPNHF(IEnumerable<FOMCNFKOJNN> BKPKHLFJMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8646D20", Offset = "0x8645B20", VA = "0x188646D20", Slot = "10")]
	public bool BJFAKIDDKCN(AHNIMKBJLEJ ENPELEHFGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8649890", Offset = "0x8648690", VA = "0x188649890")]
	private void IDBJBGBAHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x864AD10", Offset = "0x8649B10", VA = "0x18864AD10")]
	private void LECGCMOJNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x86472C0", Offset = "0x86460C0", VA = "0x1886472C0", Slot = "8")]
	public IReadOnlyList<BGIGCBHGGLI> BOAFNBGIGPJ(bool IBEFGPMMHFP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x864AC00", Offset = "0x8649A00", VA = "0x18864AC00", Slot = "9")]
	public BGIGCBHGGLI LCBJCPHGJCC(AHNIMKBJLEJ ENPELEHFGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x864B570", Offset = "0x864A370", VA = "0x18864B570")]
	private OKJOLANABCP NOBGOOMDDLG(AHNIMKBJLEJ ENPELEHFGFF)
	{
		return default(OKJOLANABCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8646410", Offset = "0x8645210", VA = "0x188646410", Slot = "12")]
	public bool BDKPBILFMFD(AHNIMKBJLEJ FCFNMJLLEIJ, OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x864A6A0", Offset = "0x86494A0", VA = "0x18864A6A0", Slot = "13")]
	public BGIGCBHGGLI KILBMIJPCCL(OKJOLANABCP ONFCPNPGLAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8646DF0", Offset = "0x8645BF0", VA = "0x188646DF0")]
	private static bool BLEKLGOHJLD(KHLPGDDHALE GJHEIBLCFKN, OKJOLANABCP ONFCPNPGLAJ, [Out] BMFOANPBIEN? HDDCGMMBGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x864A740", Offset = "0x8649540", VA = "0x18864A740")]
	private static void KKCOOLPICAJ(KHLPGDDHALE GJHEIBLCFKN, Action<BMFOANPBIEN> GHCPJMFIPKA, OKJOLANABCP EDOCGGEKJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x864A830", Offset = "0x8649630", VA = "0x18864A830")]
	private static void KKCOOLPICAJ(KHLPGDDHALE GJHEIBLCFKN, Action<BMFOANPBIEN> GHCPJMFIPKA, Predicate<OKJOLANABCP> PDAGFBADHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8649820", Offset = "0x8648620", VA = "0x188649820")]
	private void HDPAOCDNAFN(AHNIMKBJLEJ ENPELEHFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x864B240", Offset = "0x864A040", VA = "0x18864B240", Slot = "4")]
	[AsyncStateMachine(typeof(PEBELGPDDPP))]
	public Task MMPHACBFJNE([CanBeNull] IEHAENGDKAI MLFFBNNKHKH, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x864AF00", Offset = "0x8649D00", VA = "0x18864AF00")]
	private void LLBBLIDNOGI(KHLPGDDHALE OLMIFBDNJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8647F80", Offset = "0x8646D80", VA = "0x188647F80")]
	internal static string EJKLDPDHFGD(LEJMHEFMPLB JLJLCFOLDMD, IEHAENGDKAI MLFFBNNKHKH, IReadOnlyDictionary<OKJOLANABCP, FOMCNFKOJNN> IINGGAFCCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x86486A0", Offset = "0x86474A0", VA = "0x1886486A0")]
	private static void GFDINDOJNGM(IEHAENGDKAI MLFFBNNKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8647B20", Offset = "0x8646920", VA = "0x188647B20")]
	private static void DFIHAPOBOIL(KHLPGDDHALE MPEMCPGKMCI, IReadOnlyDictionary<OKJOLANABCP, FOMCNFKOJNN> IINGGAFCCGM, StringBuilder KJBCANAKKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8649D00", Offset = "0x8648B00", VA = "0x188649D00")]
	private static bool JMJECBKPBED(string DBIENMPBHOF, [Out] Guid AAHBBPFFPLN, [Out] OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8647340", Offset = "0x8646140", VA = "0x188647340")]
	private static void CEKDDOGMBFI(IEHAENGDKAI MLFFBNNKHKH, StringBuilder KJBCANAKKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x39D82A0", Offset = "0x39D70A0", VA = "0x1839D82A0", Slot = "14")]
	public bool CHCKHGIDGKB<T>(OKJOLANABCP ONFCPNPGLAJ, LLPDOLMILHD KLAAIBKFNDA, bool JIGCGBIJDFF, T EMEICEFCBEP, [Optional] Action HKEBCCOLOFD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8648290", Offset = "0x8647090", VA = "0x188648290", Slot = "15")]
	public string FMCIPCCGEGA(LLPDOLMILHD KLAAIBKFNDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x86471D0", Offset = "0x8645FD0", VA = "0x1886471D0", Slot = "16")]
	public bool BNNKEGNCGDF(AHNIMKBJLEJ ENPELEHFGFF, LLPDOLMILHD HJKNJOPJHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8647120", Offset = "0x8645F20", VA = "0x188647120", Slot = "18")]
	public bool BNNKEGNCGDF(int FAPLIEIFOHC, LLPDOLMILHD HJKNJOPJHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x864B360", Offset = "0x864A160", VA = "0x18864B360")]
	private void NDLGKOPLNFJ(OKJOLANABCP ONFCPNPGLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x864B650", Offset = "0x864A450", VA = "0x18864B650")]
	private bool PADNIKGEHJB(AHNIMKBJLEJ ENPELEHFGFF, OKJOLANABCP ONFCPNPGLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x86494D0", Offset = "0x86482D0", VA = "0x1886494D0")]
	internal FOMCNFKOJNN HCBPKJEHJAP(AHNIMKBJLEJ ENPELEHFGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x864B640", Offset = "0x864A440", VA = "0x18864B640", Slot = "11")]
	public IReadOnlyList<BGIGCBHGGLI> PABEMKPBDJL(AHNIMKBJLEJ ENPELEHFGFF, bool KGCIBBLMIBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x864B670", Offset = "0x864A470", VA = "0x18864B670")]
	internal IReadOnlyList<FOMCNFKOJNN> PFOPIJPIGPG(AHNIMKBJLEJ ENPELEHFGFF, bool KGCIBBLMIBP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8646580", Offset = "0x8645380", VA = "0x188646580")]
	private void BGPAADAMLEO(IBAAIANPMNJ CAJICBLOGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8648310", Offset = "0x8647110", VA = "0x188648310")]
	private static bool GEJLPMBCNPO(FOMCNFKOJNN NAALAFPLBIJ, IReadOnlyDictionary<OKJOLANABCP, FOMCNFKOJNN> IINGGAFCCGM, [Out] IReadOnlyList<LLPDOLMILHD> MCPOLJEDODI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x864AAC0", Offset = "0x86498C0", VA = "0x18864AAC0")]
	[AsyncStateMachine(typeof(HJIPBKEPLNA))]
	private static Task KLJKABNELLN(LEJMHEFMPLB JLJLCFOLDMD, IEHAENGDKAI MLFFBNNKHKH, IReadOnlyDictionary<OKJOLANABCP, FOMCNFKOJNN> IINGGAFCCGM, FOKFJHNOCCC IMOFFFALEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x86498A0", Offset = "0x86486A0", VA = "0x1886498A0")]
	[CompilerGenerated]
	internal static void JBOMIHIGOEM(Func<BMFOANPBIEN, BBNGIBNLDAD> ICIJFEKNDIM, IABDOAFBGNJ P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8646090", Offset = "0x8644E90", VA = "0x188646090")]
	[CompilerGenerated]
	internal static bool ABJEBHFALEE(OKJOLANABCP ONFCPNPGLAJ, LLPDOLMILHD KLAAIBKFNDA, [Out] HKKBMLKADPE PKHHAKDFKBC, EOMKGNMILAO P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface PDCGKFILKFC
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DHEAGAFIJHL(AHNIMKBJLEJ OMNAMHGDFPL, AHNIMKBJLEJ PKILKNPCFJH, IEnumerable<AHNIMKBJLEJ> BKEBDKCLPKJ, [Out] IHJNIOLJJPA NBDPOHADJAL, [Out] CLKODNMEKAC KAFHCPPJEOK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ELOOMMBPCGO(CLKODNMEKAC HLMPCJGFMIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum CLKODNMEKAC : byte
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
internal class HMICMEGBJPB : PDCGKFILKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CBBBNKEEPHN LDLONODLCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BHGCDDHDGJI AMLGDHFCMIO;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	[RecRoom.NoEngine.Common.Preserve]
	public HMICMEGBJPB([LCNEJNNIOGA(null)] CBBBNKEEPHN LDLONODLCAG, [LCNEJNNIOGA(null)] BHGCDDHDGJI KKFKPLJJABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8645380", Offset = "0x8644180", VA = "0x188645380")]
	private static NBKPAFCODLJ? AMKNOBLHCMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x86453C0", Offset = "0x86441C0", VA = "0x1886453C0", Slot = "4")]
	public bool DHEAGAFIJHL(AHNIMKBJLEJ OMNAMHGDFPL, AHNIMKBJLEJ PKILKNPCFJH, IEnumerable<AHNIMKBJLEJ> BKEBDKCLPKJ, [Out] IHJNIOLJJPA NBDPOHADJAL, [Out] CLKODNMEKAC KAFHCPPJEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x86454C0", Offset = "0x86442C0", VA = "0x1886454C0", Slot = "5")]
	public string ELOOMMBPCGO(CLKODNMEKAC HLMPCJGFMIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8644D60", Offset = "0x8643B60", VA = "0x188644D60")]
	internal bool AAOCNGKIEDE(AHNIMKBJLEJ OMNAMHGDFPL, AHNIMKBJLEJ PKILKNPCFJH, IEnumerable<AHNIMKBJLEJ> BKEBDKCLPKJ, IEHEOOILKKD NMFHFJBGFII, NBKPAFCODLJ? LOGHAHIIBGD, [Out] IHJNIOLJJPA NBDPOHADJAL, [Out] CLKODNMEKAC KAFHCPPJEOK)
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
