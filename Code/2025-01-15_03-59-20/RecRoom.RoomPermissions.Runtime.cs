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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x777C0C0", Offset = "0x777B4C0", VA = "0x18777C0C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CIBOAGOHOPG
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
		[Cpp2IlInjected.Address(RVA = "0x7780FB0", Offset = "0x77803B0", VA = "0x187780FB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IJCFCADLFNB<TPermission>(TPermission OABKMCAOJLM);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IGLAOLGPNOI(GHBEGPNJJCK FFBDHANOEPC);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JPJBGAAGLMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KDBAFOPNAJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJAMFCPEIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LBPANEGBBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LLJHOMDPPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LJMPHHOBCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ELLJOGDKDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NDLOAMMJMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class JHKFLCBKBIE
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum EKDCPBBBDFI
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
	public static readonly Guid ECCBABJDOGN;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid JHPHBNJFBAF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid EOBHKDDOFLO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid DIBCOHGNLDB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid GLMDFIPDBOB;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid DNFLLJICPEF;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IKDIJMPJGNI<AECOPHFIFAP, Guid> MJKOAPDFHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<AECOPHFIFAP> JMCMPLFCJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x777A6B0", Offset = "0x7779AB0", VA = "0x18777A6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x777A720", Offset = "0x7779B20", VA = "0x18777A720")]
	public static AECOPHFIFAP FHGPNIOBIFB(Guid FNECNONNEND)
	{
		return default(AECOPHFIFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x777A5D0", Offset = "0x77799D0", VA = "0x18777A5D0")]
	public static Guid DKHCICOHLPM(AECOPHFIFAP OALGCELHDJB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x777A940", Offset = "0x7779D40", VA = "0x18777A940")]
	public static bool PFDDBFMHJJI(AECOPHFIFAP OALGCELHDJB, [Out] Guid FNECNONNEND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x777A8A0", Offset = "0x7779CA0", VA = "0x18777A8A0")]
	public static bool IMLOPILEBIF(Guid FNECNONNEND, [Out] AECOPHFIFAP OALGCELHDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x777A860", Offset = "0x7779C60", VA = "0x18777A860")]
	public static AECOPHFIFAP ILOCCFDIAMC(AECOPHFIFAP OALGCELHDJB)
	{
		return default(AECOPHFIFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x777A7B0", Offset = "0x7779BB0", VA = "0x18777A7B0")]
	public static EKDCPBBBDFI FNAEFNDLNGN(AECOPHFIFAP CLOENFHOPLI)
	{
		return default(EKDCPBBBDFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x777A670", Offset = "0x7779A70", VA = "0x18777A670")]
	internal static AECOPHFIFAP DMNJPALFKJD(EKDCPBBBDFI CCCOCLFAOIM)
	{
		return default(AECOPHFIFAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HHLLELBPECG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LGPNOHEDPPC NOGPNMALIME
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<HEIGKBBPBFF> CDLDNPNPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IGLAOLGPNOI PCDEOEFIIBI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<HEIGKBBPBFF> GHAHNDDEMCO(bool AFDDMKMLLAK = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HEIGKBBPBFF CBEJAMFKJPB(GHBEGPNJJCK FFBDHANOEPC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NAKJPCABENM(GHBEGPNJJCK FFBDHANOEPC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<HEIGKBBPBFF> DJIJHNOIEIL(GHBEGPNJJCK FFBDHANOEPC, bool FHOHBGBIEDC = false);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HOIMLAOGGHJ(GHBEGPNJJCK JNPCNAHKKNA, AECOPHFIFAP OALGCELHDJB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HEIGKBBPBFF PPBDNHJNMHJ(AECOPHFIFAP OALGCELHDJB);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool HGFKOABLDKL<T>(AECOPHFIFAP OALGCELHDJB, BOKPECKCALI OABKMCAOJLM, bool ONDCOCHIGLH, T FJIKACGIPBH, [Optional] Action HODGPNGLAJN) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string ACOOOFOEGFD(BOKPECKCALI OABKMCAOJLM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PFFPMNPGBLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ENFJMKLDJKL(HGOBDFLLNNB JOMOCOIMIGC, CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNDIFCKNOJA(HGOBDFLLNNB JOMOCOIMIGC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ALMKDAJBFMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GHBEGPNJJCK DMLKJKHJLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OPCCMKNHDBC DPEEOAIEBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NLMAEEICDJF LACKPHJPKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AJIPLJBGGDF> BNLHHHOPIFC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HAMDEMLGJJN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AECOPHFIFAP KKCODDDDGMI(GHBEGPNJJCK FFBDHANOEPC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AJIPLJBGGDF> IAHEPCIDJCJ(CancellationToken FHGIOBPPFHG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task FGAHNPHLIBL(long GGLEGKBAGLC, IReadOnlyList<FLPJOENPBLH> BCLCNAIJCDH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task IPEDKHDGGEN(long GGLEGKBAGLC, long LPKNEPKMMOO, IReadOnlyList<FLPJOENPBLH> BCLCNAIJCDH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GHBEGPNJJCK> HIOPBHMKCBK();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AFLJCELGCMO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7772E20", Offset = "0x7772220", VA = "0x187772E20")]
	public static AECOPHFIFAP MFBIJAEGKOP(this ALMKDAJBFMP GOBBJAKJBLM)
	{
		return default(AECOPHFIFAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KLEMNOIILDP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FOKMBIJHNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IJCFCADLFNB<TPermission> EHNKKOJDFBM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class PFADMHJMIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? IBDKMMNBMJJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? APADGGMHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7780580", Offset = "0x777F980", VA = "0x187780580")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7780650", Offset = "0x777FA50", VA = "0x187780650")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7780750", Offset = "0x777FB50", VA = "0x187780750")]
	protected PFADMHJMIBN(object? GJPGEGIKJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MDGOJDPAKGK(object? HCPAOILCJCB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class NPCIKHHCKOO<T> : PFADMHJMIBN where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> GNOIOLAMEKG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GFHLLJBPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A9DC70", Offset = "0x4A9D070", VA = "0x184A9DC70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E240", Offset = "0x4A9D640", VA = "0x184A9E240", Slot = "4")]
	public override bool MDGOJDPAKGK(object? HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A9DB00", Offset = "0x4A9CF00", VA = "0x184A9DB00")]
	public bool IPLJLLFOOCN(T ECJPOKJHMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A9E6A0", Offset = "0x4A9DAA0", VA = "0x184A9E6A0")]
	public NPCIKHHCKOO(T EKFBHIJFHMA, IEqualityComparer<T> GNOIOLAMEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KFBOOAKCGCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<BOKPECKCALI, bool> OKCJCGNLEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<BOKPECKCALI, PFADMHJMIBN> GOABKGMPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OADFKLPCCBL NNODGKGOCCM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x777B250", Offset = "0x777A650", VA = "0x18777B250")]
	public KFBOOAKCGCD(OADFKLPCCBL NNODGKGOCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x777AE50", Offset = "0x777A250", VA = "0x18777AE50")]
	public bool DBAKNJCEGOG(BOKPECKCALI OABKMCAOJLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x310FFB0", Offset = "0x310F3B0", VA = "0x18310FFB0")]
	public bool MLCOOGIEHGN<T>(BOKPECKCALI OABKMCAOJLM, bool ONDCOCHIGLH, T HCPAOILCJCB) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x310FAC0", Offset = "0x310EEC0", VA = "0x18310FAC0")]
	public (bool, T?) COPFAEHLMBE<T>(BOKPECKCALI OABKMCAOJLM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x777B170", Offset = "0x777A570", VA = "0x18777B170")]
	public bool MLCOOGIEHGN(BOKPECKCALI OABKMCAOJLM, bool ONDCOCHIGLH, object HCPAOILCJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x777ACC0", Offset = "0x777A0C0", VA = "0x18777ACC0")]
	public (bool, object) COPFAEHLMBE(BOKPECKCALI OABKMCAOJLM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x310FF50", Offset = "0x310F350", VA = "0x18310FF50")]
	private void JAMBAMPNGAH<T>(BOKPECKCALI OABKMCAOJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x777B0A0", Offset = "0x777A4A0", VA = "0x18777B0A0")]
	private PFADMHJMIBN FMLONCCFGAA(BOKPECKCALI OABKMCAOJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x777AEC0", Offset = "0x777A2C0", VA = "0x18777AEC0")]
	public void DEKMOFLBJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NGLHOHCCJPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ABEKIOKGBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type NICGGGBEMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly NKMHGMDIBKN DDCBMPPIBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly BOKPECKCALI DFHKGKDAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public KNDGHAFFFFK PFLGCABFAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HGFLOKPHFFA IFFACAOHOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NIEOCBGACDD LALNMLJOFBJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x777C020", Offset = "0x777B420", VA = "0x18777C020")]
	public NGLHOHCCJPN(Type MMBOOAILHNE, string MKKBKODCDFF, BOKPECKCALI OABKMCAOJLM, KNDGHAFFFFK JFOFCBMKBCN, HGFLOKPHFFA LGHKDMBIPPI, NIEOCBGACDD LOCMJINFHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x777BF20", Offset = "0x777B320", VA = "0x18777BF20")]
	public object GEENMHBCFGJ(object? BMKPAKCEMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31D9330", Offset = "0x31D8730", VA = "0x1831D9330")]
	public void JAMBAMPNGAH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x777BF70", Offset = "0x777B370", VA = "0x18777BF70")]
	public void JAMBAMPNGAH(Type DFOKJGLLMMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class CNKBKJBDOJG<T> : NGLHOHCCJPN where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string PCBAKHOJIAH(T HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T EFIECKJMFBF(string? LJCICHMOBHO, T EKFBHIJFHMA);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class CFJAONHLDAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public PCBAKHOJIAH serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EFIECKJMFBF parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CFJAONHLDAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5704C40", Offset = "0x5704040", VA = "0x185704C40")]
		internal string ILHGHBJFLPC(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5704D10", Offset = "0x5704110", VA = "0x185704D10")]
		internal object KGHKCIMPLKK(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5906350", Offset = "0x5905750", VA = "0x185906350")]
	public CNKBKJBDOJG(BOKPECKCALI OABKMCAOJLM, string MKKBKODCDFF, [Optional] PCBAKHOJIAH? JFOFCBMKBCN, [Optional] EFIECKJMFBF? LGHKDMBIPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x59059B0", Offset = "0x5904DB0", VA = "0x1859059B0")]
	private static object? KBLFJIABLOP(EFIECKJMFBF? LGHKDMBIPPI, string? LJCICHMOBHO, object? EKFBHIJFHMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x59056D0", Offset = "0x5904AD0", VA = "0x1859056D0")]
	private static string GKPJGNLGAKF(PCBAKHOJIAH? IKCIHOGCMJG, object? HCPAOILCJCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string KNDGHAFFFFK(object? HCPAOILCJCB);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object HGFLOKPHFFA(string? LJCICHMOBHO, [Optional] object EKFBHIJFHMA);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate PFADMHJMIBN NIEOCBGACDD();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class OADFKLPCCBL
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LCIPMFNAFFM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static LCIPMFNAFFM ELEBKANKHDF;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x777BBC0", Offset = "0x777AFC0", VA = "0x18777BBC0", Slot = "4")]
		public bool Equals(List<string> KENGFOGLPKI, List<string> IFGPABAHODO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x777BD10", Offset = "0x777B110", VA = "0x18777BD10", Slot = "5")]
		public int GetHashCode(List<string> NCHBKHMIMGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LCIPMFNAFFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class AELPMNHCKEI : DEELPEPLFAM<CIBOAGOHOPG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7772CF0", Offset = "0x77720F0", VA = "0x187772CF0", Slot = "9")]
		public override string GKPJGNLGAKF(CIBOAGOHOPG AOOGNGKJLKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7772B20", Offset = "0x7771F20", VA = "0x187772B20", Slot = "10")]
		protected override bool GGPJAKMCGOF(string AOOGNGKJLKL, [Out] CIBOAGOHOPG HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7772DE0", Offset = "0x77721E0", VA = "0x187772DE0")]
		public AELPMNHCKEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly DMLDIBPCIOL MDDMPBAGEIK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly AELPMNHCKEI ODOFENEAAKI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<NGLHOHCCJPN> FAEFEPEJLOK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<BOKPECKCALI> AIMOFBGFKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<BOKPECKCALI, NGLHOHCCJPN> PNNHMFCENOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x777D650", Offset = "0x777CA50", VA = "0x18777D650")]
	public OADFKLPCCBL([Optional] IList<NGLHOHCCJPN>? PAHNNLPKFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x777C140", Offset = "0x777B540", VA = "0x18777C140")]
	public NGLHOHCCJPN KFCGKKBPCEP(BOKPECKCALI OABKMCAOJLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LGPNOHEDPPC
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HEIGKBBPBFF AEDPLHFICKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class BCGNFCPJCBD : LGPNOHEDPPC
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static BCGNFCPJCBD KOOGIHDFGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly PEOGGGKCKEN FMIODFGPPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<PEOGGGKCKEN> DCELMFFABLC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public HEIGKBBPBFF AEDPLHFICKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7773D10", Offset = "0x7773110", VA = "0x187773D10")]
	public BCGNFCPJCBD(PEOGGGKCKEN NDIMPOKCGGL, IReadOnlyList<PEOGGGKCKEN> BBBKDJIAPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7772E80", Offset = "0x7772280", VA = "0x187772E80")]
	private static BCGNFCPJCBD AIBJGMBJIAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class IHOMCBKACGH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<AECOPHFIFAP> DGMOGFDHBOO;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7774980", Offset = "0x7773D80", VA = "0x187774980")]
	public static bool PAGMKJDFJPJ(this GHBEGPNJJCK JHJHBOANJNF, AECOPHFIFAP OALGCELHDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7774900", Offset = "0x7773D00", VA = "0x187774900")]
	public static bool JJALHEBDAAF(this GHBEGPNJJCK JHJHBOANJNF, AECOPHFIFAP OALGCELHDJB, NLMAEEICDJF MEMOPNKIGBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CMIHLCMNLDF
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool BLMCCPMILCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HIDIPLGLDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LGIIGFFNFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool BEJJEMIMCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PBHINKCHPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DCBMJNNOLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CLMMJODJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool OGMOKDKFCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CPLEPFNIHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EOALKHDFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NHILPANDLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FFNALPBNJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> BAICLGDNMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	CIBOAGOHOPG GMKDMLKJFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HEIGKBBPBFF : CMIHLCMNLDF, KDBAFOPNAJP, KLEMNOIILDP<BOKPECKCALI>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string GAPBKPHCKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AECOPHFIFAP PBCGOCOEGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AKKNMDPLMFO<T>(BOKPECKCALI OABKMCAOJLM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BOKPECKCALI
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
internal class PEOGGGKCKEN : HEIGKBBPBFF, CMIHLCMNLDF, KDBAFOPNAJP, KLEMNOIILDP<BOKPECKCALI>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly OADFKLPCCBL PLPHCOPAHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal readonly KFBOOAKCGCD DPJFBHDOLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private string? FLGNJFOIEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? GEHMBIOELPE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool CPLNFNDDFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x777F4F0", Offset = "0x777E8F0", VA = "0x18777F4F0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool EHNJAKDHHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x777E550", Offset = "0x777D950", VA = "0x18777E550", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool OKGBIMDNEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x777F400", Offset = "0x777E800", VA = "0x18777F400", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool PHJDLOPDEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7780120", Offset = "0x777F520", VA = "0x187780120", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool LKNKLCAELJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x777E6F0", Offset = "0x777DAF0", VA = "0x18777E6F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool FMBHIOALPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x777E810", Offset = "0x777DC10", VA = "0x18777E810", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AECOPHFIFAP PBCGOCOEGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AECOPHFIFAP);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE810", Offset = "0x8CDC10", VA = "0x1808CE810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string FOKMBIJHNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x777E500", Offset = "0x777D900", VA = "0x18777E500", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x777F310", Offset = "0x777E710", VA = "0x18777F310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string GAPBKPHCKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x777E500", Offset = "0x777D900", VA = "0x18777E500", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EPDHNBGBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9000", Offset = "0x9F8400", VA = "0x1809F9000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F8960", Offset = "0x9F7D60", VA = "0x1809F8960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool BLMCCPMILCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x777F360", Offset = "0x777E760", VA = "0x18777F360", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public CIBOAGOHOPG GMKDMLKJFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x777E7C0", Offset = "0x777DBC0", VA = "0x18777E7C0", Slot = "20")]
		get
		{
			return default(CIBOAGOHOPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HIDIPLGLDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x777F4A0", Offset = "0x777E8A0", VA = "0x18777F4A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LGIIGFFNFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x777E650", Offset = "0x777DA50", VA = "0x18777E650", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BEJJEMIMCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x777E6A0", Offset = "0x777DAA0", VA = "0x18777E6A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool PBHINKCHPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x777F3B0", Offset = "0x777E7B0", VA = "0x18777F3B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DCBMJNNOLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x777F9C0", Offset = "0x777EDC0", VA = "0x18777F9C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CLMMJODJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77802A0", Offset = "0x777F6A0", VA = "0x1877802A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OGMOKDKFCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x777F1E0", Offset = "0x777E5E0", VA = "0x18777F1E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CPLEPFNIHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x777F450", Offset = "0x777E850", VA = "0x18777F450", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> BAICLGDNMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x777E740", Offset = "0x777DB40", VA = "0x18777E740", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KGGACBJMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x777F4F0", Offset = "0x777E8F0", VA = "0x18777F4F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EKHDHKNEKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x777E6F0", Offset = "0x777DAF0", VA = "0x18777E6F0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NCDMCFKDKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x777E550", Offset = "0x777D950", VA = "0x18777E550", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EOALKHDFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x77801C0", Offset = "0x777F5C0", VA = "0x1877801C0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NHILPANDLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x777F540", Offset = "0x777E940", VA = "0x18777F540", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PMOONJKIGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x777F400", Offset = "0x777E800", VA = "0x18777F400", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FFNALPBNJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7780170", Offset = "0x777F570", VA = "0x187780170", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KOBBAIIJGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7780120", Offset = "0x777F520", VA = "0x187780120", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KKEAOGBCBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x777E810", Offset = "0x777DC10", VA = "0x18777E810", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event IJCFCADLFNB<BOKPECKCALI> EHNKKOJDFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x777E5A0", Offset = "0x777D9A0", VA = "0x18777E5A0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7780070", Offset = "0x777F470", VA = "0x187780070", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3221F60", Offset = "0x3221360", VA = "0x183221F60", Slot = "6")]
	public (bool, T?) AKKNMDPLMFO<T>(BOKPECKCALI OABKMCAOJLM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3222140", Offset = "0x3221540", VA = "0x183222140")]
	public PEOGGGKCKEN BAHAJKHFPKL<T>(BOKPECKCALI OABKMCAOJLM, bool ONDCOCHIGLH, T HCPAOILCJCB) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7780560", Offset = "0x777F960", VA = "0x187780560")]
	public PEOGGGKCKEN(AECOPHFIFAP OALGCELHDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7780540", Offset = "0x777F940", VA = "0x187780540")]
	public PEOGGGKCKEN(AECOPHFIFAP OALGCELHDJB, [Optional] string? FLGNJFOIEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7780370", Offset = "0x777F770", VA = "0x187780370")]
	public PEOGGGKCKEN(PEOGGGKCKEN PIPHFOONJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x77803F0", Offset = "0x777F7F0", VA = "0x1877803F0")]
	internal PEOGGGKCKEN(AECOPHFIFAP HMJLGEPHHKH, [Optional] string? FLGNJFOIEDA, [Optional] PEOGGGKCKEN? PIPHFOONJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x777FA10", Offset = "0x777EE10", VA = "0x18777FA10")]
	public static NKMHGMDIBKN LCDLHNCNHFB(BOKPECKCALI OABKMCAOJLM)
	{
		return default(NKMHGMDIBKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x777E7A0", Offset = "0x777DBA0", VA = "0x18777E7A0")]
	public void DEKMOFLBJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x777FD80", Offset = "0x777F180", VA = "0x18777FD80")]
	internal PEOGGGKCKEN MAALFPNBBNK(PEOGGGKCKEN AKONBDENHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x777F5E0", Offset = "0x777E9E0", VA = "0x18777F5E0")]
	internal IReadOnlyCollection<BOKPECKCALI> JFAPBEGNFEK(PEOGGGKCKEN PIPHFOONJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x777F230", Offset = "0x777E630", VA = "0x18777F230")]
	public bool EIDJDALOKNO(BOKPECKCALI OABKMCAOJLM, bool ONDCOCHIGLH, string GEJLKBBKLGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x777FA80", Offset = "0x777EE80", VA = "0x18777FA80")]
	public (bool, string) LIGCKOLNEEG(BOKPECKCALI OABKMCAOJLM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x777F590", Offset = "0x777E990", VA = "0x18777F590")]
	internal void JEELMHGCEMA(BOKPECKCALI OABKMCAOJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x777FB80", Offset = "0x777EF80", VA = "0x18777FB80")]
	public APMKIPJOENG LKKIIKAHOAH(Func<AECOPHFIFAP, Guid> ENCIPHJGPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x777E860", Offset = "0x777DC60", VA = "0x18777E860")]
	public void EDNPBBJLDEB(APMKIPJOENG NDFPMGLMHNP, Func<Guid, AECOPHFIFAP> LFPEGDMPPCI, [Optional] AECOPHFIFAP? HLIKAELNGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7780210", Offset = "0x777F610", VA = "0x187780210")]
	[CompilerGenerated]
	private void NBNNCIIEEOF(BOKPECKCALI GJNJAAODGFJ, EPFANPFMEPO EGJHONODBJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class IIBDMNHHHIE : PFFPMNPGBLJ, HHLLELBPECG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LNOIEBJNPNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public PEOGGGKCKEN newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LNOIEBJNPNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x777BEF0", Offset = "0x777B2F0", VA = "0x18777BEF0")]
		internal bool AMELHBEHLMF(PEOGGGKCKEN rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OGGEHHNLDPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AECOPHFIFAP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public OGGEHHNLDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x777D970", Offset = "0x777CD70", VA = "0x18777D970")]
		internal bool LGFOMDPIIKI(AECOPHFIFAP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KIBCLMKFLBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public IIBDMNHHHIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HGOBDFLLNNB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<AJIPLJBGGDF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x777B4F0", Offset = "0x777A8F0", VA = "0x18777B4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x777BB60", Offset = "0x777AF60", VA = "0x18777BB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HJNNDMLNJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public HJNNDMLNJMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7773EB0", Offset = "0x77732B0", VA = "0x187773EB0")]
		internal void AEKJBJPHNLL(APMKIPJOENG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7773F90", Offset = "0x7773390", VA = "0x187773F90")]
		internal void PIHLHLCCMCP(APMKIPJOENG r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct JBFNIIIHHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public HGOBDFLLNNB roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CMGNEBLAOGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Func<APMKIPJOENG, EPFANPFMEPO> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public CMGNEBLAOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7773E20", Offset = "0x7773220", VA = "0x187773E20")]
		internal void IFMOHMDIBGC(APMKIPJOENG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7773E80", Offset = "0x7773280", VA = "0x187773E80")]
		internal void MHDIAINDJDC(APMKIPJOENG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7773E50", Offset = "0x7773250", VA = "0x187773E50")]
		internal void JFIGIBJIBHL(APMKIPJOENG r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DNJKNHJBCNF<T> where T : notnull
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
			public DNJKNHJBCNF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<AJIPLJBGGDF> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x39AECF0", Offset = "0x39AE0F0", VA = "0x1839AECF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public BOKPECKCALI rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AECOPHFIFAP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public NKMHGMDIBKN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public IIBDMNHHHIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DNJKNHJBCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5E876E0", Offset = "0x5E86AE0", VA = "0x185E876E0")]
		[AsyncStateMachine(typeof(DNJKNHJBCNF<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void DDOPNEFMCEF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NAKBABGMPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public IReadOnlyList<FLPJOENPBLH> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct OHPMJDDDJAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public ALMKDAJBFMP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public HGOBDFLLNNB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IReadOnlyDictionary<AECOPHFIFAP, PEOGGGKCKEN> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CNEHIJMIJDK debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x777D980", Offset = "0x777CD80", VA = "0x18777D980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x777E4A0", Offset = "0x777D8A0", VA = "0x18777E4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly ALMKDAJBFMP GOBBJAKJBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly BCGNFCPJCBD BFCELJMONOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly CNEHIJMIJDK EDNCHDNMNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<int, PEOGGGKCKEN> IDMFGJEJILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	internal readonly Dictionary<AECOPHFIFAP, PEOGGGKCKEN> LIOCGJHEBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<AECOPHFIFAP, PEOGGGKCKEN> MIGACIGPDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly List<PEOGGGKCKEN> FAOMKMBCBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private bool BEIAJPIDBBO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly BOKPECKCALI[] KPNPIHIMILM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LGPNOHEDPPC NOGPNMALIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<HEIGKBBPBFF> CDLDNPNPCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7776550", Offset = "0x7775950", VA = "0x187776550", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IGLAOLGPNOI PCDEOEFIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x777A000", Offset = "0x7779400", VA = "0x18777A000", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x77753A0", Offset = "0x77747A0", VA = "0x1877753A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7779E50", Offset = "0x7779250", VA = "0x187779E50")]
	[AGCFNMIICNN.EOJADANDAPN]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC AEBJKCFPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x777A310", Offset = "0x7779710", VA = "0x18777A310")]
	[UnityEngine.Scripting.Preserve]
	internal IIBDMNHHHIE([CNGCCDLPGOD(null)] ALMKDAJBFMP LNPNCGBEFJL, [CNGCCDLPGOD(null)] BCGNFCPJCBD FJEEPKOOMBI, [CNGCCDLPGOD(null)] CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7776440", Offset = "0x7775840", VA = "0x187776440", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7775BE0", Offset = "0x7774FE0", VA = "0x187775BE0")]
	private void DCANBHCCFEN(IEnumerable<PEOGGGKCKEN> EMBEBGMPMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7779A70", Offset = "0x7778E70", VA = "0x187779A70", Slot = "12")]
	public bool NAKJPCABENM(GHBEGPNJJCK FFBDHANOEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7778430", Offset = "0x7777830", VA = "0x187778430")]
	private void HAMDEMLGJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7777AC0", Offset = "0x7776EC0", VA = "0x187777AC0")]
	private void GKOLOHLHFNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7777A40", Offset = "0x7776E40", VA = "0x187777A40", Slot = "10")]
	public IReadOnlyList<HEIGKBBPBFF> GHAHNDDEMCO(bool AFDDMKMLLAK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7775AD0", Offset = "0x7774ED0", VA = "0x187775AD0", Slot = "11")]
	public HEIGKBBPBFF CBEJAMFKJPB(GHBEGPNJJCK FFBDHANOEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7778DA0", Offset = "0x77781A0", VA = "0x187778DA0")]
	private AECOPHFIFAP KENCNONIFHJ(GHBEGPNJJCK FFBDHANOEPC)
	{
		return default(AECOPHFIFAP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7778550", Offset = "0x7777950", VA = "0x187778550", Slot = "14")]
	public bool HOIMLAOGGHJ(GHBEGPNJJCK JNPCNAHKKNA, AECOPHFIFAP OALGCELHDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x777A0A0", Offset = "0x77794A0", VA = "0x18777A0A0", Slot = "15")]
	public HEIGKBBPBFF PPBDNHJNMHJ(AECOPHFIFAP OALGCELHDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x77757A0", Offset = "0x7774BA0", VA = "0x1877757A0")]
	private static bool CAHGIHFPLKA(DNGFJCEPOEB EIEBPLKBLCK, AECOPHFIFAP OALGCELHDJB, [Out] APMKIPJOENG? LNEKLHMIFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7776830", Offset = "0x7775C30", VA = "0x187776830")]
	private static void EIHGPDLINDI(DNGFJCEPOEB EIEBPLKBLCK, Action<APMKIPJOENG> LLOOHNAIEJK, AECOPHFIFAP DNFKPAJKOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x77765A0", Offset = "0x77759A0", VA = "0x1877765A0")]
	private static void EIHGPDLINDI(DNGFJCEPOEB EIEBPLKBLCK, Action<APMKIPJOENG> LLOOHNAIEJK, Predicate<AECOPHFIFAP> GNAALNAHGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7778910", Offset = "0x7777D10", VA = "0x187778910")]
	private void JBOPEKPICHG(GHBEGPNJJCK FFBDHANOEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7776920", Offset = "0x7775D20", VA = "0x187776920", Slot = "4")]
	[AsyncStateMachine(typeof(KIBCLMKFLBD))]
	public Task ENFJMKLDJKL([CanBeNull] HGOBDFLLNNB JOMOCOIMIGC, CancellationToken FHGIOBPPFHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
	public void GNDIFCKNOJA(HGOBDFLLNNB JOMOCOIMIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7775460", Offset = "0x7774860", VA = "0x187775460")]
	private void BHICECDKOBP(DNGFJCEPOEB OJNJJABFGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7779B40", Offset = "0x7778F40", VA = "0x187779B40")]
	internal static string OAFJGJHKFMN(ALMKDAJBFMP GOBBJAKJBLM, HGOBDFLLNNB JOMOCOIMIGC, IReadOnlyDictionary<AECOPHFIFAP, PEOGGGKCKEN> LIOCGJHEBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7776CE0", Offset = "0x77760E0", VA = "0x187776CE0")]
	private static void FOPABJIAJLK(HGOBDFLLNNB JOMOCOIMIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7779720", Offset = "0x7778B20", VA = "0x187779720")]
	private static void MHMFBHPGLMM(DNGFJCEPOEB BJPDLCEJABB, IReadOnlyDictionary<AECOPHFIFAP, PEOGGGKCKEN> LIOCGJHEBEM, StringBuilder ICOGAHPLDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7778440", Offset = "0x7777840", VA = "0x187778440")]
	private static bool HMLGLGAEKAH(string NPANGJPBENC, [Out] Guid GOLCOLFJFHK, [Out] AECOPHFIFAP OALGCELHDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7774C70", Offset = "0x7774070", VA = "0x187774C70")]
	private static void AOAHLAHHLOA(HGOBDFLLNNB JOMOCOIMIGC, StringBuilder ICOGAHPLDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x30B2A90", Offset = "0x30B1E90", VA = "0x1830B2A90", Slot = "16")]
	public bool HGFKOABLDKL<T>(AECOPHFIFAP OALGCELHDJB, BOKPECKCALI OABKMCAOJLM, bool ONDCOCHIGLH, T FJIKACGIPBH, [Optional] Action HODGPNGLAJN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7774C00", Offset = "0x7774000", VA = "0x187774C00", Slot = "17")]
	public string ACOOOFOEGFD(BOKPECKCALI OABKMCAOJLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7778E70", Offset = "0x7778270", VA = "0x187778E70")]
	private void KHIHNLIBKAN(AECOPHFIFAP OALGCELHDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7775440", Offset = "0x7774840", VA = "0x187775440")]
	private bool BBDMOCIKEJM(GHBEGPNJJCK FFBDHANOEPC, AECOPHFIFAP OALGCELHDJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x77793F0", Offset = "0x77787F0", VA = "0x1877793F0")]
	internal PEOGGGKCKEN LHIPDFCBPGN(GHBEGPNJJCK FFBDHANOEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7776430", Offset = "0x7775830", VA = "0x187776430", Slot = "13")]
	public IReadOnlyList<HEIGKBBPBFF> DJIJHNOIEIL(GHBEGPNJJCK FFBDHANOEPC, bool FHOHBGBIEDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x77786E0", Offset = "0x7777AE0", VA = "0x1877786E0")]
	internal IReadOnlyList<PEOGGGKCKEN> HPMAKMIAHKJ(GHBEGPNJJCK FFBDHANOEPC, bool FHOHBGBIEDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7777CA0", Offset = "0x77770A0", VA = "0x187777CA0")]
	private void HAIANICNGJC(AJIPLJBGGDF GJAPIEHGLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7778980", Offset = "0x7777D80", VA = "0x187778980")]
	private static bool JENIKLDFJAP(PEOGGGKCKEN ILEICLONEHF, IReadOnlyDictionary<AECOPHFIFAP, PEOGGGKCKEN> LIOCGJHEBEM, [Out] IReadOnlyList<BOKPECKCALI> BEMIKFCJGKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7778C60", Offset = "0x7778060", VA = "0x187778C60")]
	[AsyncStateMachine(typeof(OHPMJDDDJAF))]
	private static Task JMBOKJDILHF(ALMKDAJBFMP GOBBJAKJBLM, HGOBDFLLNNB JOMOCOIMIGC, IReadOnlyDictionary<AECOPHFIFAP, PEOGGGKCKEN> LIOCGJHEBEM, CNEHIJMIJDK EDNCHDNMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7776A40", Offset = "0x7775E40", VA = "0x187776A40")]
	[CompilerGenerated]
	internal static void FAACFHBKMKE(Func<APMKIPJOENG, EPFANPFMEPO> EDDKDFHLPFC, JBFNIIIHHED P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7779070", Offset = "0x7778470", VA = "0x187779070")]
	[CompilerGenerated]
	internal static bool LHHEAONJIPG(AECOPHFIFAP OALGCELHDJB, BOKPECKCALI OABKMCAOJLM, [Out] FLPJOENPBLH NEKBGCJLEEH, NAKBABGMPEF P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface EJMALMOMBPM
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEFJEJFHKHE(GHBEGPNJJCK JNCDCKJJOCN, GHBEGPNJJCK PEDNAIPANEL, IEnumerable<GHBEGPNJJCK> KHJMOMJNEMH, [Out] CIBOAGOHOPG GOONNNOJGFK, [Out] LBHLAJBBLAI EKEEABKGNDH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KJHKKCEGIJJ(LBHLAJBBLAI NJHEBGJFJEI);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum LBHLAJBBLAI : byte
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
internal class IBONDGBCFDO : EJMALMOMBPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly HHLLELBPECG BCECLMMPDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BLGHCAHGEMO BIBFENGCPDK;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	[RecRoom.NoEngine.Common.Preserve]
	public IBONDGBCFDO([CNGCCDLPGOD(null)] HHLLELBPECG NPLHKHKDOIH, [CNGCCDLPGOD(null)] BLGHCAHGEMO ADGCJLIBCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x77742B0", Offset = "0x77736B0", VA = "0x1877742B0")]
	private static NNJKPPOBEOC? LDDHGCPLICE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x77740B0", Offset = "0x77734B0", VA = "0x1877740B0", Slot = "4")]
	public bool FEFJEJFHKHE(GHBEGPNJJCK JNCDCKJJOCN, GHBEGPNJJCK PEDNAIPANEL, IEnumerable<GHBEGPNJJCK> KHJMOMJNEMH, [Out] CIBOAGOHOPG GOONNNOJGFK, [Out] LBHLAJBBLAI EKEEABKGNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x77741B0", Offset = "0x77735B0", VA = "0x1877741B0", Slot = "5")]
	public string KJHKKCEGIJJ(LBHLAJBBLAI NJHEBGJFJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x77742F0", Offset = "0x77736F0", VA = "0x1877742F0")]
	internal bool LHBMAJPCMDO(GHBEGPNJJCK JNCDCKJJOCN, GHBEGPNJJCK PEDNAIPANEL, IEnumerable<GHBEGPNJJCK> KHJMOMJNEMH, NLMAEEICDJF MEMOPNKIGBD, NNJKPPOBEOC? HDKIMMGFJHD, [Out] CIBOAGOHOPG GOONNNOJGFK, [Out] LBHLAJBBLAI EKEEABKGNDH)
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
