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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x689B390", Offset = "0x689A190", VA = "0x18689B390")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DLNJFDAECKM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CHFHKPOOCIJ<TPermission>(TPermission PLDLNJLCELO);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JBEDPJFIFJH(CMFDBPHCNJN HKNKALEJLDA);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IDKPIHHMAKO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IDAGKNFBKLO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJOOKICJEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LCIAHBDLCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CKEBKBEDJED
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool INGHOEIFMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FHPANEBCIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NOKMOMPNDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class DBPHIJFKANI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum JKALAJHPHHO
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
	public static readonly Guid INDPIODLMNF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid EAPAPPCKGFD;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid AABOLDFAIAA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid ICGLAACJPBK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid GELECJGHPHP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid AALPDLFEDOD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly CLDJADLMKCG<JNIALDEPLOP, Guid> IIJFOPABAMK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<JNIALDEPLOP> CCKCNNMPPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6891FD0", Offset = "0x6890DD0", VA = "0x186891FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68920E0", Offset = "0x6890EE0", VA = "0x1868920E0")]
	public static JNIALDEPLOP PNLCIOKGKAI(Guid IIGMMHCLOGB)
	{
		return default(JNIALDEPLOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6892040", Offset = "0x6890E40", VA = "0x186892040")]
	public static Guid MGAOKLIOEII(JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6891E60", Offset = "0x6890C60", VA = "0x186891E60")]
	public static bool DGIOOMBECIL(JNIALDEPLOP EAPBKMFPOHN, [Out] Guid IIGMMHCLOGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6891F30", Offset = "0x6890D30", VA = "0x186891F30")]
	public static bool KAIMNIOAJPM(Guid IIGMMHCLOGB, [Out] JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6891EF0", Offset = "0x6890CF0", VA = "0x186891EF0")]
	public static JNIALDEPLOP DNNAIJDLJNJ(JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(JNIALDEPLOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6892170", Offset = "0x6890F70", VA = "0x186892170")]
	public static JKALAJHPHHO PNOIDCNEDPN(JNIALDEPLOP KLBIECNHDIA)
	{
		return default(JKALAJHPHHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6891E20", Offset = "0x6890C20", VA = "0x186891E20")]
	internal static JNIALDEPLOP CMMNDGDAPLO(JKALAJHPHHO HBCFEHFMDMG)
	{
		return default(JNIALDEPLOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PHJJBDKBNMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	AIANNOIBJFL LELPGMAEDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<KKCMOGJOINJ> ELPOAFBAOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JBEDPJFIFJH INGCMAKJDNM;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<KKCMOGJOINJ> DHHLBAFLDNI(bool BMFCLOKNJJP = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KKCMOGJOINJ KIILFBEOHOK(CMFDBPHCNJN HKNKALEJLDA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ANGJEODEIJM(CMFDBPHCNJN HKNKALEJLDA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<KKCMOGJOINJ> DIOEODPJCCO(CMFDBPHCNJN HKNKALEJLDA, bool GCEAPBGGPKK = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BIIMCEJJPFH(CMFDBPHCNJN OANMCPCENEN, JNIALDEPLOP EAPBKMFPOHN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KKCMOGJOINJ FIEJIJLDJIC(JNIALDEPLOP EAPBKMFPOHN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool POBDEFHOJPG<T>(JNIALDEPLOP EAPBKMFPOHN, JBAFJGCMPCH PLDLNJLCELO, bool EDKMMCGHLDI, T PNJHNPALLNI, [Optional] Action MDALMMMIFOG) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GBHCCEFGMOF
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JNNFFKODOHJ(CCLFGPLFGKK EEKNEAJDFKG, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHKDKGFFFHL(CCLFGPLFGKK EEKNEAJDFKG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GIMLENIPDCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CMFDBPHCNJN KMOGGEGKNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OCJDEGLDIGA EGMJBHCANAD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GGLDCNABNOB NDGMDEFAAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IHOFHALNEGK> HJNGGGPCCGP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OCJFFHBEHDA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JNIALDEPLOP HMMKIBJMNBJ(CMFDBPHCNJN HKNKALEJLDA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<IHOFHALNEGK> IAANIDEINPK(CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task BFPLPCFHHFH(long EKMDOMOGGBC, long LCDEHGNNMHO, IReadOnlyList<HPMBEKGEKIF> CEGHDJOMBBM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CMFDBPHCNJN> KPJGPFOCBIF();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GCELDFIFNLN
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6893FA0", Offset = "0x6892DA0", VA = "0x186893FA0")]
	public static JNIALDEPLOP BMIHMNEHMBI(this GIMLENIPDCG JABGEFAOCKA)
	{
		return default(JNIALDEPLOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FPILNPKMKJF<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NADFEEILFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CHFHKPOOCIJ<TPermission> BGEJAIPBJGE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class CCDOMGNPNEL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? POFJFCHCIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	protected CCDOMGNPNEL(object? IFJMIGHBBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool AFKLOOAJFMI(object? DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class LNKIPEACMMN<T> : CCDOMGNPNEL where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T ILDFLPKKNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> PDBOAJNGLNM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA660", Offset = "0x3DC9460", VA = "0x183DCA660", Slot = "4")]
	public override bool AFKLOOAJFMI(object? DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3DCA840", Offset = "0x3DC9640", VA = "0x183DCA840")]
	public bool PJDLKFOEJLB(T AKJBLGHMBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCADC0", Offset = "0x3DC9BC0", VA = "0x183DCADC0")]
	public LNKIPEACMMN(T OPPINNBBHIO, IEqualityComparer<T> PDBOAJNGLNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BHNDCJBDKJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JBAFJGCMPCH, bool> HCMLFEBHFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<JBAFJGCMPCH, CCDOMGNPNEL> HEBJOGCHELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NJOOOHEGHJF AGGCMALLEPI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6890920", Offset = "0x688F720", VA = "0x186890920")]
	public BHNDCJBDKJG(NJOOOHEGHJF AGGCMALLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6890530", Offset = "0x688F330", VA = "0x186890530")]
	public bool FKLBGCGIICP(JBAFJGCMPCH PLDLNJLCELO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26A8B60", Offset = "0x26A7960", VA = "0x1826A8B60")]
	public bool COEPKOCJLLL<T>(JBAFJGCMPCH PLDLNJLCELO, bool EDKMMCGHLDI, T DIBNBLEEFNN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26A90B0", Offset = "0x26A7EB0", VA = "0x1826A90B0")]
	public (bool, T?) HCNOAJKDAMK<T>(JBAFJGCMPCH PLDLNJLCELO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6890450", Offset = "0x688F250", VA = "0x186890450")]
	public bool COEPKOCJLLL(JBAFJGCMPCH PLDLNJLCELO, bool EDKMMCGHLDI, object DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6890670", Offset = "0x688F470", VA = "0x186890670")]
	public (bool, object) HCNOAJKDAMK(JBAFJGCMPCH PLDLNJLCELO)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x26A9070", Offset = "0x26A7E70", VA = "0x1826A9070")]
	private void DKHPLMEGMGM<T>(JBAFJGCMPCH PLDLNJLCELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x68905A0", Offset = "0x688F3A0", VA = "0x1868905A0")]
	private CCDOMGNPNEL GDOGOHGIFNF(JBAFJGCMPCH PLDLNJLCELO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6890740", Offset = "0x688F540", VA = "0x186890740")]
	public void JJNOIHKEELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class CHCKOOPHMNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string EMIKMDCGJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type LELBNKEGCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly LGELKFHPCPN HAOLOHDLGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JBAFJGCMPCH PKDIFNIIKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BCFBJMMKIIH JNGBJALKNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MBKHPJACOBH ADABGAMKLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public LOGJJJGAHHM GBGBCNHGPHP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6891CF0", Offset = "0x6890AF0", VA = "0x186891CF0")]
	public CHCKOOPHMNO(Type BFMBFKHPDHL, string JNOKBJHHDMH, JBAFJGCMPCH PLDLNJLCELO, BCFBJMMKIIH EFLIFIBABHN, MBKHPJACOBH EBEMMPMIBLP, LOGJJJGAHHM EMDJOENLEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6891BF0", Offset = "0x68909F0", VA = "0x186891BF0")]
	public object DKHDOLOAAEL(object? GGINNHLAMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2716950", Offset = "0x2715750", VA = "0x182716950")]
	public void DKHPLMEGMGM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6891C40", Offset = "0x6890A40", VA = "0x186891C40")]
	public void DKHPLMEGMGM(Type NJKODHHLAMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DHFEKIOGKNL<T> : CHCKOOPHMNO where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string CCCMKJOKHIJ(T DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T NMGDOIFGIML(string? AAFKMCEAKAA, T OPPINNBBHIO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CDBEGAKKMEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CCCMKJOKHIJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NMGDOIFGIML parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CDBEGAKKMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4C47110", Offset = "0x4C45F10", VA = "0x184C47110")]
		internal string BINFDPDIDCH(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4C47140", Offset = "0x4C45F40", VA = "0x184C47140")]
		internal object ICFKMGMFGAD(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x514ADE0", Offset = "0x5149BE0", VA = "0x18514ADE0")]
	public DHFEKIOGKNL(JBAFJGCMPCH PLDLNJLCELO, string JNOKBJHHDMH, [Optional] CCCMKJOKHIJ? EFLIFIBABHN, [Optional] NMGDOIFGIML? EBEMMPMIBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x514A070", Offset = "0x5148E70", VA = "0x18514A070")]
	private static object? FPNHMAJLCHC(NMGDOIFGIML? EBEMMPMIBLP, string? AAFKMCEAKAA, object? OPPINNBBHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x514A840", Offset = "0x5149640", VA = "0x18514A840")]
	private static string JPFDICAGNEF(CCCMKJOKHIJ? JBNJGCLOHIC, object? DIBNBLEEFNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string BCFBJMMKIIH(object? DIBNBLEEFNN);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object MBKHPJACOBH(string? AAFKMCEAKAA, [Optional] object OPPINNBBHIO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate CCDOMGNPNEL LOGJJJGAHHM();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class NJOOOHEGHJF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class ANDHPGOOKIF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static ANDHPGOOKIF LLCJIHIKEMG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6890120", Offset = "0x688EF20", VA = "0x186890120", Slot = "4")]
		public bool Equals(List<string> FCLAAGLFIOD, List<string> OJPNBFDBAHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6890270", Offset = "0x688F070", VA = "0x186890270", Slot = "5")]
		public int GetHashCode(List<string> EIFMADKIHON)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ANDHPGOOKIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class BOGGIAMGMCC : NFKFOAOEFMO<DLNJFDAECKM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6890DC0", Offset = "0x688FBC0", VA = "0x186890DC0", Slot = "9")]
		public override string JPFDICAGNEF(DLNJFDAECKM PGOKJJEIBMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6890BF0", Offset = "0x688F9F0", VA = "0x186890BF0", Slot = "10")]
		protected override bool CHLEDGCEDFG(string PGOKJJEIBMC, [Out] DLNJFDAECKM DIBNBLEEFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6890EB0", Offset = "0x688FCB0", VA = "0x186890EB0")]
		public BOGGIAMGMCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FKADHCICMMN OKBPPIBKHMG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly BOGGIAMGMCC EFJFHEFPBGB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<CHCKOOPHMNO> FFBJKIBNCPK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JBAFJGCMPCH> LPALNKBBFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JBAFJGCMPCH, CHCKOOPHMNO> BHLOFNHNDAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x689B070", Offset = "0x6899E70", VA = "0x18689B070")]
	public NJOOOHEGHJF([Optional] IList<CHCKOOPHMNO>? ECLCLFAIGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6899BD0", Offset = "0x68989D0", VA = "0x186899BD0")]
	public CHCKOOPHMNO HPCIGCGKGJL(JBAFJGCMPCH PLDLNJLCELO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AIANNOIBJFL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KKCMOGJOINJ OBJMKGJNEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class CAODMKJEBOL : AIANNOIBJFL
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static CAODMKJEBOL GCHEPPEPLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly PLKNKEKCLNK GAJGLLFKDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<PLKNKEKCLNK> AMBJKHKCEHL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public KKCMOGJOINJ OBJMKGJNEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6891AE0", Offset = "0x68908E0", VA = "0x186891AE0")]
	public CAODMKJEBOL(PLKNKEKCLNK MHBEKBOCIOA, IReadOnlyList<PLKNKEKCLNK> ALEODHOBOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6890EF0", Offset = "0x688FCF0", VA = "0x186890EF0")]
	private static CAODMKJEBOL MFEEGFAPBED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PBECLCLPNBG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<JNIALDEPLOP> AIIOFEGEDFI;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x689B410", Offset = "0x689A210", VA = "0x18689B410")]
	public static bool LIBGMGFPGJJ(this CMFDBPHCNJN CIJPLICOMPO, JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x689B4F0", Offset = "0x689A2F0", VA = "0x18689B4F0")]
	public static bool PNMAIDKIAGB(this CMFDBPHCNJN CIJPLICOMPO, JNIALDEPLOP EAPBKMFPOHN, GGLDCNABNOB JFFMGNMCEKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BGKBBMMEMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OPPKHLEOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OOGNGKDLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool AILHMPJKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GENFFFBIKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GPDCLHILNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool KOMPFBNEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PIBHLAIONEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CMBNNCNGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MPIKMALDFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MFOLPJJAMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CCGDMDNIDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ONMCAMJKDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> CHOFLMCMGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DLNJFDAECKM LPJBEJJIKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KKCMOGJOINJ : BGKBBMMEMHG, IDAGKNFBKLO, FPILNPKMKJF<JBAFJGCMPCH>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string ALBNFMDDIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JNIALDEPLOP LBGIFCMKHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) FGJOOLOEOIE<T>(JBAFJGCMPCH PLDLNJLCELO) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JBAFJGCMPCH
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
internal class PLKNKEKCLNK : KKCMOGJOINJ, BGKBBMMEMHG, IDAGKNFBKLO, FPILNPKMKJF<JBAFJGCMPCH>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly NJOOOHEGHJF DPNHPJILFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly BHNDCJBDKJG AILBDGHABNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? GPOBBMLABNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? KLDCMDIEHOK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool FGCABFKLAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x689B850", Offset = "0x689A650", VA = "0x18689B850", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CGMFIFBOMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x689CB00", Offset = "0x689B900", VA = "0x18689CB00", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool FDFGIJIFNEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x689B8A0", Offset = "0x689A6A0", VA = "0x18689B8A0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool AJKMBIOPOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x689BD00", Offset = "0x689AB00", VA = "0x18689BD00", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FPECLAJICGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x689C400", Offset = "0x689B200", VA = "0x18689C400", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool JKMFJMNOGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x689C4A0", Offset = "0x689B2A0", VA = "0x18689C4A0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JNIALDEPLOP LBGIFCMKHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JNIALDEPLOP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D50", Offset = "0x7B6B50", VA = "0x1807B7D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NADFEEILFIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x689B710", Offset = "0x689A510", VA = "0x18689B710", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x689C5F0", Offset = "0x689B3F0", VA = "0x18689C5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string ALBNFMDDIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x689B710", Offset = "0x689A510", VA = "0x18689B710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AKDOAAAGKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86DBD0", Offset = "0x86C9D0", VA = "0x18086DBD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86D4A0", Offset = "0x86C2A0", VA = "0x18086D4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OPPKHLEOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x689B990", Offset = "0x689A790", VA = "0x18689B990", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public DLNJFDAECKM LPJBEJJIKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x689CAB0", Offset = "0x689B8B0", VA = "0x18689CAB0", Slot = "20")]
		get
		{
			return default(DLNJFDAECKM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OOGNGKDLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x689BDA0", Offset = "0x689ABA0", VA = "0x18689BDA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AILHMPJKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x689BD50", Offset = "0x689AB50", VA = "0x18689BD50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GENFFFBIKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x689C4F0", Offset = "0x689B2F0", VA = "0x18689C4F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool GPDCLHILNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x689B8F0", Offset = "0x689A6F0", VA = "0x18689B8F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool KOMPFBNEIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x689CB50", Offset = "0x689B950", VA = "0x18689CB50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PIBHLAIONEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x689B760", Offset = "0x689A560", VA = "0x18689B760", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CMBNNCNGNIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x689B7B0", Offset = "0x689A5B0", VA = "0x18689B7B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool MPIKMALDFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x689C450", Offset = "0x689B250", VA = "0x18689C450", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> CHOFLMCMGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x689D520", Offset = "0x689C320", VA = "0x18689D520", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool JEJCKBMCBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x689B850", Offset = "0x689A650", VA = "0x18689B850", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EKJHFEKEIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x689C400", Offset = "0x689B200", VA = "0x18689C400", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MHJFCOACKJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x689CB00", Offset = "0x689B900", VA = "0x18689CB00", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool MFOLPJJAMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x689B800", Offset = "0x689A600", VA = "0x18689B800", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool CCGDMDNIDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x689D580", Offset = "0x689C380", VA = "0x18689D580", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IKDOIDCEFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x689B8A0", Offset = "0x689A6A0", VA = "0x18689B8A0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ONMCAMJKDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x689B940", Offset = "0x689A740", VA = "0x18689B940", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool INAHMOBCINN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x689BD00", Offset = "0x689AB00", VA = "0x18689BD00", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GFKGCKJEAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x689C4A0", Offset = "0x689B2A0", VA = "0x18689C4A0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CHFHKPOOCIJ<JBAFJGCMPCH> BGEJAIPBJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x689BC50", Offset = "0x689AA50", VA = "0x18689BC50", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x689C350", Offset = "0x689B150", VA = "0x18689C350", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2A57600", Offset = "0x2A56400", VA = "0x182A57600", Slot = "6")]
	public (bool, T?) FGJOOLOEOIE<T>(JBAFJGCMPCH PLDLNJLCELO) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2A57790", Offset = "0x2A56590", VA = "0x182A57790")]
	public PLKNKEKCLNK IMKMFNGBPIA<T>(JBAFJGCMPCH PLDLNJLCELO, bool EDKMMCGHLDI, T DIBNBLEEFNN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x689D810", Offset = "0x689C610", VA = "0x18689D810")]
	public PLKNKEKCLNK(JNIALDEPLOP EAPBKMFPOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x689D6A0", Offset = "0x689C4A0", VA = "0x18689D6A0")]
	public PLKNKEKCLNK(JNIALDEPLOP EAPBKMFPOHN, [Optional] string? GPOBBMLABNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x689D830", Offset = "0x689C630", VA = "0x18689D830")]
	public PLKNKEKCLNK(PLKNKEKCLNK MDECIOHHMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x689D6C0", Offset = "0x689C4C0", VA = "0x18689D6C0")]
	internal PLKNKEKCLNK(JNIALDEPLOP GKCFNFNHLAO, [Optional] string? GPOBBMLABNP, [Optional] PLKNKEKCLNK? MDECIOHHMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x689BBE0", Offset = "0x689A9E0", VA = "0x18689BBE0")]
	public static LGELKFHPCPN EHKJKIFLJOG(JBAFJGCMPCH PLDLNJLCELO)
	{
		return default(LGELKFHPCPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x689C5D0", Offset = "0x689B3D0", VA = "0x18689C5D0")]
	public void JJNOIHKEELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x689BFD0", Offset = "0x689ADD0", VA = "0x18689BFD0")]
	internal PLKNKEKCLNK GAOMJGIPJLJ(PLKNKEKCLNK DBDLCOKGGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x689C640", Offset = "0x689B440", VA = "0x18689C640")]
	internal IReadOnlyCollection<JBAFJGCMPCH> KKGLAFBLIAH(PLKNKEKCLNK MDECIOHHMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x689BDF0", Offset = "0x689ABF0", VA = "0x18689BDF0")]
	public bool FJMBJNAMNEN(JBAFJGCMPCH PLDLNJLCELO, bool EDKMMCGHLDI, string FFBPNJPFIAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x689BED0", Offset = "0x689ACD0", VA = "0x18689BED0")]
	public (bool, string) GAIICOOKJKK(JBAFJGCMPCH PLDLNJLCELO)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x689D5D0", Offset = "0x689C3D0", VA = "0x18689D5D0")]
	internal void PHDFMFEBMJG(JBAFJGCMPCH PLDLNJLCELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x689B9E0", Offset = "0x689A7E0", VA = "0x18689B9E0")]
	public AMPGGKFCMBE ECICKGINKII(Func<JNIALDEPLOP, Guid> ODIEHHIEKPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x689CBA0", Offset = "0x689B9A0", VA = "0x18689CBA0")]
	public void NGFHNAGDPFL(AMPGGKFCMBE FNKJJIFOHFH, Func<Guid, JNIALDEPLOP> CNBGGDABMGF, [Optional] JNIALDEPLOP? LLFDCKBFHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x689C540", Offset = "0x689B340", VA = "0x18689C540")]
	[CompilerGenerated]
	private void JFLFIBBOHAF(JBAFJGCMPCH IIMDBPMLIHA, FMNDHGJHAOP KEPDDOGGLHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JDPLPFCNNIK : GBHCCEFGMOF, PHJJBDKBNMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BNKKGGNBGDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public PLKNKEKCLNK newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BNKKGGNBGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6890BC0", Offset = "0x688F9C0", VA = "0x186890BC0")]
		internal bool IKNNFBICCBK(PLKNKEKCLNK rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class POJKJMLGDPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public JNIALDEPLOP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public POJKJMLGDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x689D8B0", Offset = "0x689C6B0", VA = "0x18689D8B0")]
		internal bool JHGBFEDDNJC(JNIALDEPLOP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct DMHFAKJOKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public JDPLPFCNNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CCLFGPLFGKK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<IHOFHALNEGK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68938D0", Offset = "0x68926D0", VA = "0x1868938D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6893F40", Offset = "0x6892D40", VA = "0x186893F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HMJJMLEABLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HMJJMLEABLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6894120", Offset = "0x6892F20", VA = "0x186894120")]
		internal void HODEJCBBJPN(AMPGGKFCMBE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6894000", Offset = "0x6892E00", VA = "0x186894000")]
		internal void FEPEIPEEFDE(AMPGGKFCMBE r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FEOHHFMMFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CCLFGPLFGKK roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CLLIEEADEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<AMPGGKFCMBE, FMNDHGJHAOP> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CLLIEEADEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6891DC0", Offset = "0x6890BC0", VA = "0x186891DC0")]
		internal void HMKMGJNIBFF(AMPGGKFCMBE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6891DF0", Offset = "0x6890BF0", VA = "0x186891DF0")]
		internal void KMGDAEHIGCG(AMPGGKFCMBE r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6891D90", Offset = "0x6890B90", VA = "0x186891D90")]
		internal void CLFBFMONNOP(AMPGGKFCMBE r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EANPIFODIMO<T> where T : notnull
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
			public EANPIFODIMO<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<IHOFHALNEGK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3273060", Offset = "0x3271E60", VA = "0x183273060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x898D70", Offset = "0x897B70", VA = "0x180898D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JDPLPFCNNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JBAFJGCMPCH rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JNIALDEPLOP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LGELKFHPCPN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public EANPIFODIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3470FA0", Offset = "0x346FDA0", VA = "0x183470FA0")]
		[AsyncStateMachine(typeof(EANPIFODIMO<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void EOPEAGNIEMD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EKLMBIDAKJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<HPMBEKGEKIF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DIACPAHMLHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public GIMLENIPDCG rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CCLFGPLFGKK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<JNIALDEPLOP, PLKNKEKCLNK> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FOHHKPJKGLI debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6892D60", Offset = "0x6891B60", VA = "0x186892D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6893870", Offset = "0x6892670", VA = "0x186893870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly GIMLENIPDCG JABGEFAOCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly CAODMKJEBOL HBCIIHIOINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly FOHHKPJKGLI MOPKNGLJGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, PLKNKEKCLNK> NCKGIJNGBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<JNIALDEPLOP, PLKNKEKCLNK> AAGKFPFAMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<JNIALDEPLOP, PLKNKEKCLNK> BJPJJLJFLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<PLKNKEKCLNK> GICPOJIKCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool MDDIAPBFNJM;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JBAFJGCMPCH[] APMLCLGJDDO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public AIANNOIBJFL LELPGMAEDAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<KKCMOGJOINJ> ELPOAFBAOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6894200", Offset = "0x6893000", VA = "0x186894200", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JBEDPJFIFJH INGCMAKJDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68984B0", Offset = "0x68972B0", VA = "0x1868984B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6897600", Offset = "0x6896400", VA = "0x186897600", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6899580", Offset = "0x6898380", VA = "0x186899580")]
	[DPHBJKOLDBD(FMOBJKPMAGC.Room, OHNOEEJKPCM.None)]
	private static void NHIOCKBFPIL(NAINNGGFMLM LMEEFHNMKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6899910", Offset = "0x6898710", VA = "0x186899910")]
	[UnityEngine.Scripting.Preserve]
	internal JDPLPFCNNIK([PENMPEOFMMN(null)] GIMLENIPDCG FFKDFABBCFO, [PENMPEOFMMN(null)] CAODMKJEBOL CKGENAAENMN, [PENMPEOFMMN(null)] FOHHKPJKGLI MOPKNGLJGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6895780", Offset = "0x6894580", VA = "0x186895780", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68963C0", Offset = "0x68951C0", VA = "0x1868963C0")]
	private void GJFMOHMBCBG(IEnumerable<PLKNKEKCLNK> ALDMBHJHGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6894250", Offset = "0x6893050", VA = "0x186894250", Slot = "12")]
	public bool ANGJEODEIJM(CMFDBPHCNJN HKNKALEJLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6899730", Offset = "0x6898530", VA = "0x186899730")]
	private void OCJFFHBEHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68980B0", Offset = "0x6896EB0", VA = "0x1868980B0")]
	private void KEDCECFANBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68950E0", Offset = "0x6893EE0", VA = "0x1868950E0", Slot = "10")]
	public IReadOnlyList<KKCMOGJOINJ> DHHLBAFLDNI(bool BMFCLOKNJJP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68983A0", Offset = "0x68971A0", VA = "0x1868983A0", Slot = "11")]
	public KKCMOGJOINJ KIILFBEOHOK(CMFDBPHCNJN HKNKALEJLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68994B0", Offset = "0x68982B0", VA = "0x1868994B0")]
	private JNIALDEPLOP NBKPLMLJDIF(CMFDBPHCNJN HKNKALEJLDA)
	{
		return default(JNIALDEPLOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6894BE0", Offset = "0x68939E0", VA = "0x186894BE0", Slot = "14")]
	public bool BIIMCEJJPFH(CMFDBPHCNJN OANMCPCENEN, JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6895F80", Offset = "0x6894D80", VA = "0x186895F80", Slot = "15")]
	public KKCMOGJOINJ FIEJIJLDJIC(JNIALDEPLOP EAPBKMFPOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6895440", Offset = "0x6894240", VA = "0x186895440")]
	private static bool DIJCHNHPIOP(GHMIFKPJPNK IGKGHJNGPMB, JNIALDEPLOP EAPBKMFPOHN, [Out] AMPGGKFCMBE? JHJGAEFHNNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6895890", Offset = "0x6894690", VA = "0x186895890")]
	private static void EJIFLCNFADD(GHMIFKPJPNK IGKGHJNGPMB, Action<AMPGGKFCMBE> MIDCCBOFAGF, JNIALDEPLOP HHKLEDBBIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6895980", Offset = "0x6894780", VA = "0x186895980")]
	private static void EJIFLCNFADD(GHMIFKPJPNK IGKGHJNGPMB, Action<AMPGGKFCMBE> MIDCCBOFAGF, Predicate<JNIALDEPLOP> JEKHLCDJCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6896020", Offset = "0x6894E20", VA = "0x186896020")]
	private void GCKCMFDNKNA(CMFDBPHCNJN HKNKALEJLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6897C50", Offset = "0x6896A50", VA = "0x186897C50", Slot = "4")]
	[AsyncStateMachine(typeof(DMHFAKJOKGA))]
	public Task JNNFFKODOHJ([CanBeNull] CCLFGPLFGKK EEKNEAJDFKG, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
	public void JHKDKGFFFHL(CCLFGPLFGKK EEKNEAJDFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6897D70", Offset = "0x6896B70", VA = "0x186897D70")]
	private void KAMPDMJLPHE(GHMIFKPJPNK EKLILMGBMFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68976A0", Offset = "0x68964A0", VA = "0x1868976A0")]
	internal static string INKBOLOMFHE(GIMLENIPDCG JABGEFAOCKA, CCLFGPLFGKK EEKNEAJDFKG, IReadOnlyDictionary<JNIALDEPLOP, PLKNKEKCLNK> AAGKFPFAMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6898750", Offset = "0x6897550", VA = "0x186898750")]
	private static void MGKMKMEKKPM(CCLFGPLFGKK EEKNEAJDFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6894D70", Offset = "0x6893B70", VA = "0x186894D70")]
	private static void CGBHAMAMHMA(GHMIFKPJPNK FAJKIHHMJOM, IReadOnlyDictionary<JNIALDEPLOP, PLKNKEKCLNK> AAGKFPFAMKI, StringBuilder EHNOONFPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6898290", Offset = "0x6897090", VA = "0x186898290")]
	private static bool KIGBJPBFBJJ(string JGJKOPCDJLI, [Out] Guid EODOLLKNCBJ, [Out] JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6896C90", Offset = "0x6895A90", VA = "0x186896C90")]
	private static void HJPOFGLCNIA(CCLFGPLFGKK EEKNEAJDFKG, StringBuilder EHNOONFPKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2928970", Offset = "0x2927770", VA = "0x182928970", Slot = "16")]
	public bool POBDEFHOJPG<T>(JNIALDEPLOP EAPBKMFPOHN, JBAFJGCMPCH PLDLNJLCELO, bool EDKMMCGHLDI, T PNJHNPALLNI, [Optional] Action MDALMMMIFOG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6898550", Offset = "0x6897350", VA = "0x186898550")]
	private void MDGDPDKOCME(JNIALDEPLOP EAPBKMFPOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x68950C0", Offset = "0x6893EC0", VA = "0x1868950C0")]
	private bool CHMHPCGODCI(CMFDBPHCNJN HKNKALEJLDA, JNIALDEPLOP EAPBKMFPOHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6896090", Offset = "0x6894E90", VA = "0x186896090")]
	internal PLKNKEKCLNK GDPKMJHPJCH(CMFDBPHCNJN HKNKALEJLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6895770", Offset = "0x6894570", VA = "0x186895770", Slot = "13")]
	public IReadOnlyList<KKCMOGJOINJ> DIOEODPJCCO(CMFDBPHCNJN HKNKALEJLDA, bool GCEAPBGGPKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x68973D0", Offset = "0x68961D0", VA = "0x1868973D0")]
	internal IReadOnlyList<PLKNKEKCLNK> IJENFKLEJMJ(CMFDBPHCNJN HKNKALEJLDA, bool GCEAPBGGPKK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6894320", Offset = "0x6893120", VA = "0x186894320")]
	private void AOFKNNKAHFK(IHOFHALNEGK HOENNABGLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6895160", Offset = "0x6893F60", VA = "0x186895160")]
	private static bool DIHOLOBFGJM(PLKNKEKCLNK BFJJCANOFMB, IReadOnlyDictionary<JNIALDEPLOP, PLKNKEKCLNK> AAGKFPFAMKI, [Out] IReadOnlyList<JBAFJGCMPCH> PFOBKELJCBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6894AA0", Offset = "0x68938A0", VA = "0x186894AA0")]
	[AsyncStateMachine(typeof(DIACPAHMLHK))]
	private static Task BCJPMPCOIDJ(GIMLENIPDCG JABGEFAOCKA, CCLFGPLFGKK EEKNEAJDFKG, IReadOnlyDictionary<JNIALDEPLOP, PLKNKEKCLNK> AAGKFPFAMKI, FOHHKPJKGLI MOPKNGLJGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x68979B0", Offset = "0x68967B0", VA = "0x1868979B0")]
	[CompilerGenerated]
	internal static void JLEAPHOLOBP(Func<AMPGGKFCMBE, FMNDHGJHAOP> OFFBHMAOFNM, FEOHHFMMFHD P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6895C10", Offset = "0x6894A10", VA = "0x186895C10")]
	[CompilerGenerated]
	internal static bool EOOMDHLHNOF(JNIALDEPLOP EAPBKMFPOHN, JBAFJGCMPCH PLDLNJLCELO, [Out] HPMBEKGEKIF PODCBJOCPKB, EKLMBIDAKJB P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EKNNENBLDDN
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCEEEOCOKAK(CMFDBPHCNJN GNKKGDFJDGC, CMFDBPHCNJN BFMLJPLOFFP, IEnumerable<CMFDBPHCNJN> GNNDFGDOPEH, [Out] DLNJFDAECKM OJHEJLKBADO, [Out] ACMHPNKIPMP KDIHMBDMMJA);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LKAFFHKCIEH(ACMHPNKIPMP FDILDGAMIKN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum ACMHPNKIPMP : byte
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
internal class DCIDDFCPDBO : EKNNENBLDDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PHJJBDKBNMK MDFHDEMLKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LOJFIAHKPMA LDLOIBNPLEL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
	[RecRoom.NoEngine.Common.Preserve]
	public DCIDDFCPDBO([PENMPEOFMMN(null)] PHJJBDKBNMK ALGMNEGLIAB, [PENMPEOFMMN(null)] LOJFIAHKPMA KAKONBOMNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6892710", Offset = "0x6891510", VA = "0x186892710")]
	private static GABOCKHHBHE? MGOKLKOHHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6892610", Offset = "0x6891410", VA = "0x186892610", Slot = "4")]
	public bool MCEEEOCOKAK(CMFDBPHCNJN GNKKGDFJDGC, CMFDBPHCNJN BFMLJPLOFFP, IEnumerable<CMFDBPHCNJN> GNNDFGDOPEH, [Out] DLNJFDAECKM OJHEJLKBADO, [Out] ACMHPNKIPMP KDIHMBDMMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6892510", Offset = "0x6891310", VA = "0x186892510", Slot = "5")]
	public string LKAFFHKCIEH(ACMHPNKIPMP FDILDGAMIKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6892750", Offset = "0x6891550", VA = "0x186892750")]
	internal bool OMGCKDIJMMK(CMFDBPHCNJN GNKKGDFJDGC, CMFDBPHCNJN BFMLJPLOFFP, IEnumerable<CMFDBPHCNJN> GNNDFGDOPEH, GGLDCNABNOB JFFMGNMCEKP, GABOCKHHBHE? OGOCJNIIJPO, [Out] DLNJFDAECKM OJHEJLKBADO, [Out] ACMHPNKIPMP KDIHMBDMMJA)
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
