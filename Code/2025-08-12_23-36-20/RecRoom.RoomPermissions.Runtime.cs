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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C8E930", Offset = "0x8C8D730", VA = "0x188C8E930")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PJFDJNAMJHH
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
		[Cpp2IlInjected.Address(RVA = "0x8C8F740", Offset = "0x8C8E540", VA = "0x188C8F740", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IOEPOENFMED<TPermission>(TPermission NDCBECONEPG);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void GIEFAIONAAG(AFLCFHLHEHB GLMBLPAKFLM);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PJHIALFOBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GABFFCJKBMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OFIFBONIBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MKIMPLEHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EOEPNKKEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HINNENFGIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HCOIFLNEIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HGJPNBIEMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NNKJGIMEDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LBNLEOPFEJC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum KABCMAECBIM
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
	public static readonly Guid ANDNOFIMLCN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NJKOCIHEDKN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid DJNPFFDMJLG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PMPAFDKELPP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid DCDHEKKIDGO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid GNDCHCIEGMI;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly BEBAECJLFAM<DPLLHLFGGEJ, Guid> AGIPMHKJBME;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	internal static IEnumerable<DPLLHLFGGEJ> JJDONDKHOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B780", Offset = "0x8C8A580", VA = "0x188C8B780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B7F0", Offset = "0x8C8A5F0", VA = "0x188C8B7F0")]
	public static DPLLHLFGGEJ FPIGFPJIKDN(Guid NMEMPCKPCOG)
	{
		return default(DPLLHLFGGEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B6A0", Offset = "0x8C8A4A0", VA = "0x188C8B6A0")]
	public static Guid AOPPLILIALH(DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B880", Offset = "0x8C8A680", VA = "0x188C8B880")]
	public static bool GAOFJFKFFPC(DPLLHLFGGEJ KCABFJOLKBE, [Out] Guid NMEMPCKPCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B950", Offset = "0x8C8A750", VA = "0x188C8B950")]
	public static bool NHPNPBJAHID(Guid NMEMPCKPCOG, [Out] DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B910", Offset = "0x8C8A710", VA = "0x188C8B910")]
	public static DPLLHLFGGEJ NFMPLGCDICO(DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(DPLLHLFGGEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B9F0", Offset = "0x8C8A7F0", VA = "0x188C8B9F0")]
	public static KABCMAECBIM OADKEOEKFCE(DPLLHLFGGEJ FFOMIJNLMDN)
	{
		return default(KABCMAECBIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B740", Offset = "0x8C8A540", VA = "0x188C8B740")]
	internal static DPLLHLFGGEJ EJKPACIMCLL(KABCMAECBIM AEIJLIFBAFC)
	{
		return default(DPLLHLFGGEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJHGNOLDEDO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AFLCFHLHEHB LLFFNMNNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LLDPOPPOJLA PCPJAANLNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CPKIDEJABEO AGIBLJBFMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FMCOGKLCFCB> HHBDJHKJJKN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GONKAAPJMBO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPLLHLFGGEJ IKMNBOIAILO(AFLCFHLHEHB GLMBLPAKFLM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FMCOGKLCFCB> ADKFPPPDMNM(CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task LAEFFIOMAMG(long MDNJLMOPJKG, IReadOnlyList<HHBCBOIPNME> AKPBPEJMIGM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KGBAEJLMJHC(long MDNJLMOPJKG, long JDPEMOIFJMF, IReadOnlyList<HHBCBOIPNME> AKPBPEJMIGM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<AFLCFHLHEHB> IPCPGHLLHEP();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NFIIAMKBOAD
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8C8CC60", Offset = "0x8C8BA60", VA = "0x188C8CC60")]
	public static DPLLHLFGGEJ LCPKGFPHNDB(this EJHGNOLDEDO NJNKBALBKME)
	{
		return default(DPLLHLFGGEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface FPIAAFPIFBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FNPHKHKGLNO NABEJHNNEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GIEFAIONAAG GPFIGLMFAFH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<NEAGDMGPDEK> GKDAFHLFJLO(bool OJGHEPACFPP = false);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NEAGDMGPDEK PFOCELOFCEF(AFLCFHLHEHB GLMBLPAKFLM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMHKJKJPGAN(AFLCFHLHEHB GLMBLPAKFLM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<NEAGDMGPDEK> GHLCAJIBJJH(AFLCFHLHEHB GLMBLPAKFLM, bool JDLDNGBHACO = false);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KDEOJJNCNAB(AFLCFHLHEHB PBMDGOOPOHE, DPLLHLFGGEJ KCABFJOLKBE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NEAGDMGPDEK LLMILJCLMFC(DPLLHLFGGEJ KCABFJOLKBE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ENDDIHEEPCC<T>(DPLLHLFGGEJ KCABFJOLKBE, JAJFJFNCIMG NDCBECONEPG, bool BFCBJOCMNCE, T EIENELGOLAB, [Optional] Action PMGFNBMEFNF) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string JEHNGJNLHEH(JAJFJFNCIMG NDCBECONEPG);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GFHDENMCEAB(AFLCFHLHEHB GLMBLPAKFLM, JAJFJFNCIMG BMODAEEGEKI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OBLFICIKIOB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EKKCAHGKKJK(GJJFFFDCKLI OEACCCPPJMI, CancellationToken BKHGNHANFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LPNHJDPBIBH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string CAOPGJIDEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IOEPOENFMED<TPermission> KHJNCPNPNHG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class NDLGFDFAPEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? IJMLNHPOHON;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? LIINOIEODLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C780", Offset = "0x8C8B580", VA = "0x188C8C780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C680", Offset = "0x8C8B480", VA = "0x188C8C680")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8C8C850", Offset = "0x8C8B650", VA = "0x188C8C850")]
	protected NDLGFDFAPEK(object? AHBNBCIFNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DNEFPNGCBKL(object? HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EFGEMGIIFDC<T> : NDLGFDFAPEK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> IFGHMFNGBPM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A538B0", Offset = "0x4A526B0", VA = "0x184A538B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A530E0", Offset = "0x4A51EE0", VA = "0x184A530E0", Slot = "4")]
	public override bool DNEFPNGCBKL(object? HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A53540", Offset = "0x4A52340", VA = "0x184A53540")]
	public bool KHHDKJAAAKN(T OHODIKMPFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A53E40", Offset = "0x4A52C40", VA = "0x184A53E40")]
	public EFGEMGIIFDC(T PGFMONBPOJI, IEqualityComparer<T> IFGHMFNGBPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ECHIFLKICPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<JAJFJFNCIMG, bool> NPKEEKFCJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JAJFJFNCIMG, NDLGFDFAPEK> FBCLNPEFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JNNHBCEEBBA KLFDJCCOJNA;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8C82080", Offset = "0x8C80E80", VA = "0x188C82080")]
	public ECHIFLKICPF(JNNHBCEEBBA KLFDJCCOJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8C81DB0", Offset = "0x8C80BB0", VA = "0x188C81DB0")]
	public bool MPEPEPCHKEJ(JAJFJFNCIMG NDCBECONEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B76C40", Offset = "0x3B75A40", VA = "0x183B76C40")]
	public bool AFLOOLDADIF<T>(JAJFJFNCIMG NDCBECONEPG, bool BFCBJOCMNCE, T HGMAIPELJHM) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B77160", Offset = "0x3B75F60", VA = "0x183B77160")]
	public (bool, T?) NHCFEALLPOB<T>(JAJFJFNCIMG NDCBECONEPG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8C81AD0", Offset = "0x8C808D0", VA = "0x188C81AD0")]
	public bool AFLOOLDADIF(JAJFJFNCIMG NDCBECONEPG, bool BFCBJOCMNCE, object HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C81E20", Offset = "0x8C80C20", VA = "0x188C81E20")]
	public (bool, object) NHCFEALLPOB(JAJFJFNCIMG NDCBECONEPG)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B77120", Offset = "0x3B75F20", VA = "0x183B77120")]
	private void LHIBJPBHNGM<T>(JAJFJFNCIMG NDCBECONEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8C81FB0", Offset = "0x8C80DB0", VA = "0x188C81FB0")]
	private NDLGFDFAPEK OEADCADMHIM(JAJFJFNCIMG NDCBECONEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8C81BB0", Offset = "0x8C809B0", VA = "0x188C81BB0")]
	public void EMHBBLPONDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class ILDDGKGGADO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HFLFOHLMPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type JOLLPKCEOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly BFBINPPDHIH KGNAKBECDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly JAJFJFNCIMG GBDFBPDAJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ECGIOHFBEDM OCINDHHMDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public KGEDMFBIIDC MFLFCCGDAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public IHMMHMIPKEN CPJPDEGPLNH;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C89D70", Offset = "0x8C88B70", VA = "0x188C89D70")]
	public ILDDGKGGADO(Type KKIBEAGPCDL, string CGDIPBADIMH, JAJFJFNCIMG NDCBECONEPG, ECGIOHFBEDM PAHDLBMKANP, KGEDMFBIIDC OFDOLBHCEGB, IHMMHMIPKEN KLMGHCJDNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8C89C70", Offset = "0x8C88A70", VA = "0x188C89C70")]
	public object AEDCJDAOCKE(object? FGAEAFBDBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4DFE0", Offset = "0x3D4CDE0", VA = "0x183D4DFE0")]
	public void LHIBJPBHNGM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8C89CC0", Offset = "0x8C88AC0", VA = "0x188C89CC0")]
	public void LHIBJPBHNGM(Type BBPPEANNBLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class BKIIGPALGGI<T> : ILDDGKGGADO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string GMMFIACBKLB(T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T OOEFMKKCIDP(string? MOGKDIAAFBD, T PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DCNPKMLAHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GMMFIACBKLB serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OOEFMKKCIDP parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DCNPKMLAHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4531230", Offset = "0x4530030", VA = "0x184531230")]
		internal string LHBPIFBKPOF(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4531080", Offset = "0x452FE80", VA = "0x184531080")]
		internal object GOIEMHKCLNL(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x66FCF90", Offset = "0x66FBD90", VA = "0x1866FCF90")]
	public BKIIGPALGGI(JAJFJFNCIMG NDCBECONEPG, string CGDIPBADIMH, [Optional] GMMFIACBKLB? PAHDLBMKANP, [Optional] OOEFMKKCIDP? OFDOLBHCEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x66FC390", Offset = "0x66FB190", VA = "0x1866FC390")]
	private static object? PPEAGMPJINO(OOEFMKKCIDP? OFDOLBHCEGB, string? MOGKDIAAFBD, object? PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x66FC0D0", Offset = "0x66FAED0", VA = "0x1866FC0D0")]
	private static string OFACCHGGJAP(GMMFIACBKLB? HACKBFCEGJK, object? HGMAIPELJHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string ECGIOHFBEDM(object? HGMAIPELJHM);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object KGEDMFBIIDC(string? MOGKDIAAFBD, [Optional] object PGFMONBPOJI);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate NDLGFDFAPEK IHMMHMIPKEN();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class JNNHBCEEBBA
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class OJKDFHPLOCN : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static OJKDFHPLOCN MOIOIMEFPHA;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E9B0", Offset = "0x8C8D7B0", VA = "0x188C8E9B0", Slot = "4")]
		public bool Equals(List<string> DBBMOEGPNPP, List<string> COFKGIHGCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8C8EB00", Offset = "0x8C8D900", VA = "0x188C8EB00", Slot = "5")]
		public int GetHashCode(List<string> ALGAKMGCCLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public OJKDFHPLOCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class NDPNPFJFFJK : JFLEFCOBODM<PJFDJNAMJHH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8C8CB30", Offset = "0x8C8B930", VA = "0x188C8CB30", Slot = "9")]
		public override string OFACCHGGJAP(PJFDJNAMJHH DANFKLEPBNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C950", Offset = "0x8C8B750", VA = "0x188C8C950", Slot = "10")]
		protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] PJFDJNAMJHH HGMAIPELJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8CC20", Offset = "0x8C8BA20", VA = "0x188C8CC20")]
		public NDPNPFJFFJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly AJEEEKEHJGI ODMPBGBNBKA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NDPNPFJFFJK MBMGNINPMIJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<ILDDGKGGADO> IDNIGDMPFCG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JAJFJFNCIMG> INGEIKJHKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JAJFJFNCIMG, ILDDGKGGADO> NKLPJMHLEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B380", Offset = "0x8C8A180", VA = "0x188C8B380")]
	public JNNHBCEEBBA([Optional] IList<ILDDGKGGADO>? HPCANHCLJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8C89E10", Offset = "0x8C88C10", VA = "0x188C89E10")]
	public ILDDGKGGADO IOIHOAKHIPP(JAJFJFNCIMG NDCBECONEPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FNPHKHKGLNO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NEAGDMGPDEK LFGLAACGDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class FPIAKJFPOCM : FNPHKHKGLNO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static FPIAKJFPOCM DMOFLPDIAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly NLGKAKMLKHP OJGELDJNBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<NLGKAKMLKHP> MLHACCPMICA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NEAGDMGPDEK LFGLAACGDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8C83B40", Offset = "0x8C82940", VA = "0x188C83B40")]
	public FPIAKJFPOCM(NLGKAKMLKHP OIHONHMNDEG, IReadOnlyList<NLGKAKMLKHP> JKKPPKOPOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8C82C00", Offset = "0x8C81A00", VA = "0x188C82C00")]
	private static FPIAKJFPOCM KDODBECGMGB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PKHDNMPGICB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<DPLLHLFGGEJ> DDDEBGILOMH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8C8ED60", Offset = "0x8C8DB60", VA = "0x188C8ED60")]
	public static bool NHJKKNMPENB(this AFLCFHLHEHB EAJPHPMCNGA, DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8C8ECE0", Offset = "0x8C8DAE0", VA = "0x188C8ECE0")]
	public static bool CHFKPHNHDFF(this AFLCFHLHEHB EAJPHPMCNGA, DPLLHLFGGEJ KCABFJOLKBE, CPKIDEJABEO KOGDCKHOGED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LADBHBGHEBD
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IReadOnlyList<string> DNNGIIBCBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PJFDJNAMJHH NNBDLFILKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NEAGDMGPDEK : LADBHBGHEBD, GABFFCJKBMK, LPNHJDPBIBH<JAJFJFNCIMG>
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string HIJLOFHEPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DPLLHLFGGEJ IIBLAHEFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) HGFEKMMLKFJ<T>(JAJFJFNCIMG NDCBECONEPG) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class NLGKAKMLKHP : NEAGDMGPDEK, LADBHBGHEBD, GABFFCJKBMK, LPNHJDPBIBH<JAJFJFNCIMG>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly JNNHBCEEBBA JNCGJMHLGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly ECHIFLKICPF EGDCHGNKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? ECNKEACBBKA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool PNBNPCDEOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DD80", Offset = "0x8C8CB80", VA = "0x188C8DD80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool KPDLEHNNHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E070", Offset = "0x8C8CE70", VA = "0x188C8E070", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool AGMOMNCEAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DA90", Offset = "0x8C8C890", VA = "0x188C8DA90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool DNGIEEDPJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DAE0", Offset = "0x8C8C8E0", VA = "0x188C8DAE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool KIANJHJOHHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DE20", Offset = "0x8C8CC20", VA = "0x188C8DE20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PEGEJGJFDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DA40", Offset = "0x8C8C840", VA = "0x188C8DA40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool GIHIMJPIAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DDD0", Offset = "0x8C8CBD0", VA = "0x188C8DDD0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DPLLHLFGGEJ IIBLAHEFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DPLLHLFGGEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA93B80", Offset = "0xA92980", VA = "0x180A93B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public string CAOPGJIDEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D620", Offset = "0x8C8C420", VA = "0x188C8D620", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string HIJLOFHEPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D620", Offset = "0x8C8C420", VA = "0x188C8D620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HDBGMNBOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAC2300", Offset = "0xAC1100", VA = "0x180AC2300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PJFDJNAMJHH NNBDLFILKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E5C0", Offset = "0x8C8D3C0", VA = "0x188C8E5C0", Slot = "8")]
		get
		{
			return default(PJFDJNAMJHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyList<string> DNNGIIBCBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E3B0", Offset = "0x8C8D1B0", VA = "0x188C8E3B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool MJADOJOCFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DD80", Offset = "0x8C8CB80", VA = "0x188C8DD80", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool LHHDICLNGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DE20", Offset = "0x8C8CC20", VA = "0x188C8DE20", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OAFLHPBCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E070", Offset = "0x8C8CE70", VA = "0x188C8E070", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool MCDCLJHBJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DA90", Offset = "0x8C8C890", VA = "0x188C8DA90", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MJIOJNBNGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DAE0", Offset = "0x8C8C8E0", VA = "0x188C8DAE0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PHKLDBGNONE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DA40", Offset = "0x8C8C840", VA = "0x188C8DA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LGCJAFMABPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DDD0", Offset = "0x8C8CBD0", VA = "0x188C8DDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IOEPOENFMED<JAJFJFNCIMG> KHJNCPNPNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E410", Offset = "0x8C8D210", VA = "0x188C8E410", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E610", Offset = "0x8C8D410", VA = "0x188C8E610", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E778C0", Offset = "0x3E766C0", VA = "0x183E778C0", Slot = "6")]
	public (bool, T?) HGFEKMMLKFJ<T>(JAJFJFNCIMG NDCBECONEPG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3E77880", Offset = "0x3E76680", VA = "0x183E77880")]
	public NLGKAKMLKHP EKJDMBAPJAB<T>(JAJFJFNCIMG NDCBECONEPG, bool BFCBJOCMNCE, T HGMAIPELJHM) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E740", Offset = "0x8C8D540", VA = "0x188C8E740")]
	public NLGKAKMLKHP(DPLLHLFGGEJ KCABFJOLKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E760", Offset = "0x8C8D560", VA = "0x188C8E760")]
	public NLGKAKMLKHP(DPLLHLFGGEJ KCABFJOLKBE, [Optional] string? ECNKEACBBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E780", Offset = "0x8C8D580", VA = "0x188C8E780")]
	public NLGKAKMLKHP(NLGKAKMLKHP EKJADPHEPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E800", Offset = "0x8C8D600", VA = "0x188C8E800")]
	internal NLGKAKMLKHP(DPLLHLFGGEJ OLKFCFIJLPF, [Optional] string? ECNKEACBBKA, [Optional] NLGKAKMLKHP? EKJADPHEPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E4C0", Offset = "0x8C8D2C0", VA = "0x188C8E4C0")]
	public static BFBINPPDHIH MPICNKOBGHA(JAJFJFNCIMG NDCBECONEPG)
	{
		return default(BFBINPPDHIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DD60", Offset = "0x8C8CB60", VA = "0x188C8DD60")]
	public void EMHBBLPONDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E0C0", Offset = "0x8C8CEC0", VA = "0x188C8E0C0")]
	internal NLGKAKMLKHP IKINFIGLAPA(NLGKAKMLKHP DLPAJLCDLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D670", Offset = "0x8C8C470", VA = "0x188C8D670")]
	internal IReadOnlyCollection<JAJFJFNCIMG> BGGJAJMLDMH(NLGKAKMLKHP EKJADPHEPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DB80", Offset = "0x8C8C980", VA = "0x188C8DB80")]
	public bool DJECPHKBJAG(JAJFJFNCIMG NDCBECONEPG, bool BFCBJOCMNCE, string PMKMPCAEHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DC60", Offset = "0x8C8CA60", VA = "0x188C8DC60")]
	public (bool, string) DNDHCLDJEDD(JAJFJFNCIMG NDCBECONEPG)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DB30", Offset = "0x8C8C930", VA = "0x188C8DB30")]
	internal void CLONLOMHHDB(JAJFJFNCIMG NDCBECONEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DE70", Offset = "0x8C8CC70", VA = "0x188C8DE70")]
	public HOFPIPJBHIA HLHJEDJLBCD(Func<DPLLHLFGGEJ, Guid> FNNCGLJGGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8C8CCC0", Offset = "0x8C8BAC0", VA = "0x188C8CCC0")]
	public void AHFMGBALCGF(HOFPIPJBHIA GLPLGNLHJEG, Func<Guid, DPLLHLFGGEJ> PMAFNCLGOEH, [Optional] DPLLHLFGGEJ? EEBGIFKJEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E530", Offset = "0x8C8D330", VA = "0x188C8E530")]
	[CompilerGenerated]
	private void OGMEMMHFILH(JAJFJFNCIMG BMODAEEGEKI, LHMJJHDKFKA EECDMFODDHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HMPJFPLNGOG : OBLFICIKIOB, FPIAAFPIFBM, IDisposable, PKDFHNCAKBF
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GGNHPOJMDDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public NLGKAKMLKHP newRole;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GGNHPOJMDDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8C83C50", Offset = "0x8C82A50", VA = "0x188C83C50")]
		internal bool GJCMPBGKEML(NLGKAKMLKHP rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DNOACBEMPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public DPLLHLFGGEJ roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public DNOACBEMPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FF50", Offset = "0x1F1ED50", VA = "0x181F1FF50")]
		internal bool IGNEJFGMEDN(DPLLHLFGGEJ r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct EHFCJFMMHFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public HMPJFPLNGOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public GJJFFFDCKLI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<FMCOGKLCFCB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8C82330", Offset = "0x8C81130", VA = "0x188C82330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C829A0", Offset = "0x8C817A0", VA = "0x188C829A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FCKJJAKMINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FCKJJAKMINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C82B20", Offset = "0x8C81920", VA = "0x188C82B20")]
		internal void NGCBFCBDOFJ(HOFPIPJBHIA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C82A00", Offset = "0x8C81800", VA = "0x188C82A00")]
		internal void LJBPCBAELFF(HOFPIPJBHIA r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DOGCPEFAKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public GJJFFFDCKLI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MEBDOAJPJJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Func<HOFPIPJBHIA, LHMJJHDKFKA> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MEBDOAJPJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BDC0", Offset = "0x8C8ABC0", VA = "0x188C8BDC0")]
		internal void LLPCONPKMBP(HOFPIPJBHIA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BDF0", Offset = "0x8C8ABF0", VA = "0x188C8BDF0")]
		internal void OGGAJIHMIJG(HOFPIPJBHIA r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BD90", Offset = "0x8C8AB90", VA = "0x188C8BD90")]
		internal void DFEICDHILDJ(HOFPIPJBHIA r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EMNGEFBIPBE<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public EMNGEFBIPBE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<FMCOGKLCFCB> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x44F23B0", Offset = "0x44F11B0", VA = "0x1844F23B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public JAJFJFNCIMG rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public DPLLHLFGGEJ accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public BFBINPPDHIH recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HMPJFPLNGOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EMNGEFBIPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4A76090", Offset = "0x4A74E90", VA = "0x184A76090")]
		[AsyncStateMachine(typeof(EMNGEFBIPBE<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void MCGNFDKMNBF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct COGHDEBBJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IReadOnlyList<HHBCBOIPNME> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BLNGEKOOKBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public EJHGNOLDEDO rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public GJJFFFDCKLI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IReadOnlyDictionary<DPLLHLFGGEJ, NLGKAKMLKHP> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ODEBHGOALGK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8C80F50", Offset = "0x8C7FD50", VA = "0x188C80F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8C81A70", Offset = "0x8C80870", VA = "0x188C81A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[DependsOn]
	private readonly EJHGNOLDEDO NJNKBALBKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[DependsOn]
	private readonly FPIAKJFPOCM OPGHOAHEMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[DependsOn]
	private readonly ODEBHGOALGK NJIBFENKDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MHDHAKMDCEA? NPLLKDBLAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<int, DPLLHLFGGEJ> CKBDFODCMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<DPLLHLFGGEJ, NLGKAKMLKHP> FAHPDPKHBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly Dictionary<DPLLHLFGGEJ, NLGKAKMLKHP> FOIOENKAGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly Dictionary<DPLLHLFGGEJ, NLGKAKMLKHP> BEPBPFAJFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly List<NLGKAKMLKHP> PIBNIGFFAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool MPICEOHECOH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly JAJFJFNCIMG[] JKNLMDOFAPD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FNPHKHKGLNO NABEJHNNEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GIEFAIONAAG GPFIGLMFAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C857D0", Offset = "0x8C845D0", VA = "0x188C857D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C88C00", Offset = "0x8C87A00", VA = "0x188C88C00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8C847C0", Offset = "0x8C835C0", VA = "0x188C847C0")]
	[NKOKDPHOKEP.KIGECJIBHBL]
	internal static void DKLHNMBDELP(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x8C89980", Offset = "0x8C88780", VA = "0x188C89980")]
	[UnityEngine.Scripting.Preserve]
	internal HMPJFPLNGOG([POMNKOCGGBN(null)] EJHGNOLDEDO OKHMOCCCIOE, [POMNKOCGGBN(null)] FPIAKJFPOCM IBAKDGMAHBH, [POMNKOCGGBN(null)] ODEBHGOALGK NJIBFENKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8C85220", Offset = "0x8C84020", VA = "0x188C85220", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8C83C80", Offset = "0x8C82A80", VA = "0x188C83C80")]
	private void AGNAOPCKCOC(IEnumerable<NLGKAKMLKHP> NNAJMDIAKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8C84500", Offset = "0x8C83300", VA = "0x188C84500", Slot = "10")]
	public bool AMHKJKJPGAN(AFLCFHLHEHB GLMBLPAKFLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8C85E90", Offset = "0x8C84C90", VA = "0x188C85E90")]
	private void GONKAAPJMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8C88230", Offset = "0x8C87030", VA = "0x188C88230", Slot = "19")]
	public void LABDFKNPPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8C85E10", Offset = "0x8C84C10", VA = "0x188C85E10", Slot = "8")]
	public IReadOnlyList<NEAGDMGPDEK> GKDAFHLFJLO(bool OJGHEPACFPP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8C89330", Offset = "0x8C88130", VA = "0x188C89330", Slot = "9")]
	public NEAGDMGPDEK PFOCELOFCEF(AFLCFHLHEHB GLMBLPAKFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8C86490", Offset = "0x8C85290", VA = "0x188C86490")]
	private DPLLHLFGGEJ IPLLFFJIJLK(AFLCFHLHEHB GLMBLPAKFLM)
	{
		return default(DPLLHLFGGEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C86C60", Offset = "0x8C85A60", VA = "0x188C86C60", Slot = "12")]
	public bool KDEOJJNCNAB(AFLCFHLHEHB PBMDGOOPOHE, DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8C88420", Offset = "0x8C87220", VA = "0x188C88420", Slot = "13")]
	public NEAGDMGPDEK LLMILJCLMFC(DPLLHLFGGEJ KCABFJOLKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8C89000", Offset = "0x8C87E00", VA = "0x188C89000")]
	private static bool OOAJEGMNEPA(OAIJIPIKJFP BFKIGLCHDOB, DPLLHLFGGEJ KCABFJOLKBE, [Out] HOFPIPJBHIA? LKDIICKHPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8C87A90", Offset = "0x8C86890", VA = "0x188C87A90")]
	private static void KHBDDPDPAHK(OAIJIPIKJFP BFKIGLCHDOB, Action<HOFPIPJBHIA> HNDJEFPIDDE, DPLLHLFGGEJ CFONOOBPPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C87B80", Offset = "0x8C86980", VA = "0x188C87B80")]
	private static void KHBDDPDPAHK(OAIJIPIKJFP BFKIGLCHDOB, Action<HOFPIPJBHIA> HNDJEFPIDDE, Predicate<DPLLHLFGGEJ> DKOCKEPBPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8C85870", Offset = "0x8C84670", VA = "0x188C85870")]
	private void FECBGCMGACF(AFLCFHLHEHB GLMBLPAKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8C856B0", Offset = "0x8C844B0", VA = "0x188C856B0", Slot = "4")]
	[AsyncStateMachine(typeof(EHFCJFMMHFL))]
	public Task EKKCAHGKKJK([CanBeNull] GJJFFFDCKLI OEACCCPPJMI, CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C86920", Offset = "0x8C85720", VA = "0x188C86920")]
	private void JPCLGCLIMCF(OAIJIPIKJFP DLKNIJMIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8C894A0", Offset = "0x8C882A0", VA = "0x188C894A0")]
	internal static string PKOBABOFKDP(EJHGNOLDEDO NJNKBALBKME, GJJFFFDCKLI OEACCCPPJMI, IReadOnlyDictionary<DPLLHLFGGEJ, NLGKAKMLKHP> FOIOENKAGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8C86D30", Offset = "0x8C85B30", VA = "0x188C86D30")]
	private static void KEGFFCCCFPA(GJJFFFDCKLI OEACCCPPJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8C865D0", Offset = "0x8C853D0", VA = "0x188C865D0")]
	private static void JJJEPMNGFCA(OAIJIPIKJFP FCGJLFAPBAP, IReadOnlyDictionary<DPLLHLFGGEJ, NLGKAKMLKHP> FOIOENKAGGM, StringBuilder NOKLEKAIDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8C85110", Offset = "0x8C83F10", VA = "0x188C85110")]
	private static bool DPILBCMFMIA(string MEEEDHGMEIL, [Out] Guid AMAGFIHICNB, [Out] DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8C884C0", Offset = "0x8C872C0", VA = "0x188C884C0")]
	private static void MMPJJMAHJGN(GJJFFFDCKLI OEACCCPPJMI, StringBuilder NOKLEKAIDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D2CB80", Offset = "0x3D2B980", VA = "0x183D2CB80", Slot = "14")]
	public bool ENDDIHEEPCC<T>(DPLLHLFGGEJ KCABFJOLKBE, JAJFJFNCIMG NDCBECONEPG, bool BFCBJOCMNCE, T EIENELGOLAB, [Optional] Action PMGFNBMEFNF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C86560", Offset = "0x8C85360", VA = "0x188C86560", Slot = "15")]
	public string JEHNGJNLHEH(JAJFJFNCIMG NDCBECONEPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C85B60", Offset = "0x8C84960", VA = "0x188C85B60", Slot = "16")]
	public bool GFHDENMCEAB(AFLCFHLHEHB GLMBLPAKFLM, JAJFJFNCIMG BMODAEEGEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8C88F40", Offset = "0x8C87D40", VA = "0x188C88F40", Slot = "18")]
	public bool OAINNEMDMKD(OBKNICDPGNA KCABFJOLKBE, JAJFJFNCIMG BMODAEEGEKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8C86280", Offset = "0x8C85080", VA = "0x188C86280")]
	private void IDLOFEJLAHA(DPLLHLFGGEJ KCABFJOLKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C845D0", Offset = "0x8C833D0", VA = "0x188C845D0")]
	private bool AMLBEKCNECO(AFLCFHLHEHB GLMBLPAKFLM, DPLLHLFGGEJ KCABFJOLKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8C85FE0", Offset = "0x8C84DE0", VA = "0x188C85FE0")]
	private NLGKAKMLKHP HMOLOLHDLEG(DPLLHLFGGEJ KCABFJOLKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C858E0", Offset = "0x8C846E0", VA = "0x188C858E0")]
	internal DPLLHLFGGEJ FHCHELNNPGE(AFLCFHLHEHB GLMBLPAKFLM)
	{
		return default(DPLLHLFGGEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C85EA0", Offset = "0x8C84CA0", VA = "0x188C85EA0")]
	private void HMLBOCGODEF(int GLMBLPAKFLM, DPLLHLFGGEJ BEOJIIONDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8C85D90", Offset = "0x8C84B90", VA = "0x188C85D90", Slot = "11")]
	public IReadOnlyList<NEAGDMGPDEK> GHLCAJIBJJH(AFLCFHLHEHB GLMBLPAKFLM, bool JDLDNGBHACO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8C85D90", Offset = "0x8C84B90", VA = "0x188C85D90")]
	internal IReadOnlyList<NLGKAKMLKHP> GLMJEJNNLKJ(AFLCFHLHEHB GLMBLPAKFLM, bool JDLDNGBHACO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8C845F0", Offset = "0x8C833F0", VA = "0x188C845F0")]
	internal IReadOnlyList<NLGKAKMLKHP> BHPPCGACEJF(DPLLHLFGGEJ KCABFJOLKBE, bool JDLDNGBHACO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8C84980", Offset = "0x8C83780", VA = "0x188C84980")]
	private void DNEAOGOCAMI(FMCOGKLCFCB NGLNJKBEBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C87E10", Offset = "0x8C86C10", VA = "0x188C87E10")]
	private static bool KJAFGKDOOHK(NLGKAKMLKHP KBMGJBGCGME, IReadOnlyDictionary<DPLLHLFGGEJ, NLGKAKMLKHP> FOIOENKAGGM, [Out] IReadOnlyList<JAJFJFNCIMG> LCFAOCGIECL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8C880F0", Offset = "0x8C86EF0", VA = "0x188C880F0")]
	[AsyncStateMachine(typeof(BLNGEKOOKBE))]
	private static Task KMIKFCKDLNA(EJHGNOLDEDO NJNKBALBKME, GJJFFFDCKLI OEACCCPPJMI, IReadOnlyDictionary<DPLLHLFGGEJ, NLGKAKMLKHP> FOIOENKAGGM, ODEBHGOALGK NJIBFENKDOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8C88CA0", Offset = "0x8C87AA0", VA = "0x188C88CA0")]
	[CompilerGenerated]
	internal static void NODLOJCCADF(Func<HOFPIPJBHIA, LHMJJHDKFKA> DHBEPFKGEFH, DOGCPEFAKDC P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8C85330", Offset = "0x8C84130", VA = "0x188C85330")]
	[CompilerGenerated]
	internal static bool EGKKAFMEEHM(DPLLHLFGGEJ KCABFJOLKBE, JAJFJFNCIMG NDCBECONEPG, [Out] HHBCBOIPNME FOIOKLNIBMK, COGHDEBBJMC P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DCEFIILIAHC
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IANHIMACBIG(AFLCFHLHEHB CFABEFJNEIP, AFLCFHLHEHB IGPDFDGDEPN, IEnumerable<AFLCFHLHEHB> IEFANELKDAB, [Out] PJFDJNAMJHH PAOCIPGFFNE, [Out] GIGCIEGJMEJ HOEFEKGAPBM);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MOAKAILLFJK(GIGCIEGJMEJ BBCNOFCBDPN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum GIGCIEGJMEJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class NCNMDLJKBPK : DCEFIILIAHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly FPIAAFPIFBM EDDILENAKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EDIMOCGKPIJ AMOADPIBGPH;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NCNMDLJKBPK([POMNKOCGGBN(null)] FPIAAFPIFBM EDDILENAKBH, [POMNKOCGGBN(null)] EDIMOCGKPIJ ILPCFCDJEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8C8C640", Offset = "0x8C8B440", VA = "0x188C8C640")]
	private static OJEJMGKECPJ? PILDCMDOPCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C8C440", Offset = "0x8C8B240", VA = "0x188C8C440", Slot = "4")]
	public bool IANHIMACBIG(AFLCFHLHEHB CFABEFJNEIP, AFLCFHLHEHB IGPDFDGDEPN, IEnumerable<AFLCFHLHEHB> IEFANELKDAB, [Out] PJFDJNAMJHH PAOCIPGFFNE, [Out] GIGCIEGJMEJ HOEFEKGAPBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8C8C540", Offset = "0x8C8B340", VA = "0x188C8C540", Slot = "5")]
	public string MOAKAILLFJK(GIGCIEGJMEJ BBCNOFCBDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8C8BE20", Offset = "0x8C8AC20", VA = "0x188C8BE20")]
	internal bool DMKPDFDAJKJ(AFLCFHLHEHB CFABEFJNEIP, AFLCFHLHEHB IGPDFDGDEPN, IEnumerable<AFLCFHLHEHB> IEFANELKDAB, CPKIDEJABEO KOGDCKHOGED, OJEJMGKECPJ? NNIPPOGCGFP, [Out] PJFDJNAMJHH PAOCIPGFFNE, [Out] GIGCIEGJMEJ HOEFEKGAPBM)
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
